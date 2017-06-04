using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookApp.BusinessLogic.Builder;
using FacebookApp.BusinessLogic;
using System.Threading;

namespace FacebookApp
{
    public partial class MainForm : Form
    {
        private const int k_CollectionLimit = 200;
        private const float k_FbApiVersion = 2.8f;

        public MainForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = k_CollectionLimit;
            FacebookWrapper.FacebookService.s_FbApiVersion = k_FbApiVersion;
            disableButtons();
            FacebookLogic.Instance.LoginFinished += OnLoginFinishedHandler;
            FacebookLogic.Instance.LogoutFinished += OnLogoutFinishedHandler;
            AddChartTypes();
        }

        private void AddChartTypes()
        {
            foreach (eChartType item in Enum.GetValues(typeof(eChartType)))
            {
                comboChartType.Items.Add(item);
            }
        }

        private void OnLoginFinishedHandler()
        {
            this.Invoke(new Action(loginFinished));
        }

        private void loginFinished()
        {
            enableButtons();
            pageBindingSource.DataSource = FacebookLogic.Instance.LoggedInUser.LikedPages;
            listBoxPages.DataSource = pageBindingSource;
            listBoxPages.DisplayMember = "Name";

            // Load images
            pictureBoxCommonFriends.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCommonLikedPages.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureCoverPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureCoverPhoto.LoadAsync(FacebookLogic.Instance.LoggedInUser.Cover.SourceURL);
            pictureProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            userBindingSource.DataSource = FacebookLogic.Instance.LoggedInUser;
            pictureBoxCommonFriends.LoadAsync(FacebookLogic.Instance.CommonFriendsFriend.PictureLargeURL);
            pictureBoxCommonLikedPages.LoadAsync(FacebookLogic.Instance.CommonLikesFriend.PictureLargeURL);
            friendsChart.Series.Clear();
        }

        private void enableButtons()
        {
            buttonChartButton.Enabled = true;
            buttonLogout.Enabled = true;
            buttonLogin.Enabled = true;
        }
        private void disableButtons()
        {
            buttonChartButton.Enabled = false;
            buttonLogout.Enabled = false;
            buttonLogin.Enabled = true;
        }

        private void loginAndInit()
        {
            Thread t = new Thread(FacebookLogic.Instance.Login);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookLogic.Instance.Logout();
        }

        private void OnLogoutFinishedHandler()
        {
            this.Invoke(new Action(LogoutFinished));
        }

        private void LogoutFinished()
        {
            friendsChart.Series.Clear();

            // Clear all pictures of user
            foreach (PictureBox pic in this.Controls.OfType<PictureBox>())
            {
                pic.Image = null;
            }

            pictureBoxCommonFriends.Image = null;
            pictureBoxCommonLikedPages.Image = null;
            labelName.Text = string.Empty;
            disableButtons();
            imageSelectedPage.Image = null;
            listBoxPages.DataSource = null;
            listBoxPages.Items.Clear();
        }

        private void buttonChartButton_Click(object sender, EventArgs e)
        {
            friendsChart.Series.Clear();

            if (comboChartType.SelectedItem != null)
            {
                Chart c = FacebookLogic.Instance.GetChart((eChartType)comboChartType.SelectedItem);
                copyChart(c);
            }
            else
            {
                MessageBox.Show("Please choose chart type");
            }
        }

        private void copyChart(Chart i_Chart)
        {
            foreach (Series series in i_Chart.Series)
            {
                Series seriesChart = friendsChart.Series.Add(series.Name);

                foreach (DataPoint point in series.Points)
                {
                    seriesChart.Points.Add(point);
                }
            }
        }
    }
}
