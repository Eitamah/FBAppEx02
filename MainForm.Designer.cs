namespace FacebookApp
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelCommonPages = new System.Windows.Forms.Label();
            this.labelCommonFriends = new System.Windows.Forms.Label();
            this.labelFriendsInCommon = new System.Windows.Forms.Label();
            this.pictureBoxCommonLikedPages = new System.Windows.Forms.PictureBox();
            this.pictureBoxCommonFriends = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonChartButton = new System.Windows.Forms.Button();
            this.comboChartType = new System.Windows.Forms.ComboBox();
            this.friendsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureProfilePic = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureCoverPhoto = new System.Windows.Forms.PictureBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageSelectedPage = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonLikedPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonFriends)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSelectedPage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(93, 12);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelGreeting
            // 
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.Font = new System.Drawing.Font("Lucida Console", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreeting.Location = new System.Drawing.Point(183, 9);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(162, 33);
            this.labelGreeting.TabIndex = 7;
            this.labelGreeting.Text = "Welcome";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 366);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 488);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.labelCommonPages);
            this.tabPage1.Controls.Add(this.labelCommonFriends);
            this.tabPage1.Controls.Add(this.labelFriendsInCommon);
            this.tabPage1.Controls.Add(this.pictureBoxCommonLikedPages);
            this.tabPage1.Controls.Add(this.pictureBoxCommonFriends);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(832, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Common";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelCommonPages
            // 
            this.labelCommonPages.AutoSize = true;
            this.labelCommonPages.Location = new System.Drawing.Point(229, 69);
            this.labelCommonPages.Name = "labelCommonPages";
            this.labelCommonPages.Size = new System.Drawing.Size(145, 17);
            this.labelCommonPages.TabIndex = 18;
            this.labelCommonPages.Text = "Most Common Pages:";
            // 
            // labelCommonFriends
            // 
            this.labelCommonFriends.AutoSize = true;
            this.labelCommonFriends.Location = new System.Drawing.Point(6, 69);
            this.labelCommonFriends.Name = "labelCommonFriends";
            this.labelCommonFriends.Size = new System.Drawing.Size(152, 17);
            this.labelCommonFriends.TabIndex = 17;
            this.labelCommonFriends.Text = "Most Common Friends:";
            // 
            // labelFriendsInCommon
            // 
            this.labelFriendsInCommon.AutoSize = true;
            this.labelFriendsInCommon.Location = new System.Drawing.Point(-2, 61);
            this.labelFriendsInCommon.Name = "labelFriendsInCommon";
            this.labelFriendsInCommon.Size = new System.Drawing.Size(0, 17);
            this.labelFriendsInCommon.TabIndex = 16;
            // 
            // pictureBoxCommonLikedPages
            // 
            this.pictureBoxCommonLikedPages.Location = new System.Drawing.Point(232, 106);
            this.pictureBoxCommonLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCommonLikedPages.Name = "pictureBoxCommonLikedPages";
            this.pictureBoxCommonLikedPages.Size = new System.Drawing.Size(215, 180);
            this.pictureBoxCommonLikedPages.TabIndex = 15;
            this.pictureBoxCommonLikedPages.TabStop = false;
            // 
            // pictureBoxCommonFriends
            // 
            this.pictureBoxCommonFriends.Location = new System.Drawing.Point(2, 105);
            this.pictureBoxCommonFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCommonFriends.Name = "pictureBoxCommonFriends";
            this.pictureBoxCommonFriends.Size = new System.Drawing.Size(207, 181);
            this.pictureBoxCommonFriends.TabIndex = 14;
            this.pictureBoxCommonFriends.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.imageSelectedPage);
            this.tabPage2.Controls.Add(this.listBoxPages);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(832, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxPages
            // 
            this.listBoxPages.DataSource = this.pageBindingSource;
            this.listBoxPages.DisplayMember = "Name";
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 16;
            this.listBoxPages.Location = new System.Drawing.Point(25, 53);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(279, 324);
            this.listBoxPages.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonChartButton);
            this.tabPage3.Controls.Add(this.comboChartType);
            this.tabPage3.Controls.Add(this.friendsChart);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(832, 459);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Graph";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonChartButton
            // 
            this.buttonChartButton.Location = new System.Drawing.Point(268, 20);
            this.buttonChartButton.Name = "buttonChartButton";
            this.buttonChartButton.Size = new System.Drawing.Size(119, 24);
            this.buttonChartButton.TabIndex = 2;
            this.buttonChartButton.Text = "Build Chart";
            this.buttonChartButton.UseVisualStyleBackColor = true;
            this.buttonChartButton.Click += new System.EventHandler(this.buttonChartButton_Click);
            // 
            // comboChartType
            // 
            this.comboChartType.FormattingEnabled = true;
            this.comboChartType.Location = new System.Drawing.Point(98, 20);
            this.comboChartType.Name = "comboChartType";
            this.comboChartType.Size = new System.Drawing.Size(121, 24);
            this.comboChartType.TabIndex = 1;
            this.comboChartType.Text = "Choose type";
            // 
            // friendsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.friendsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.friendsChart.Legends.Add(legend1);
            this.friendsChart.Location = new System.Drawing.Point(19, 64);
            this.friendsChart.Name = "friendsChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.friendsChart.Series.Add(series1);
            this.friendsChart.Size = new System.Drawing.Size(771, 392);
            this.friendsChart.TabIndex = 0;
            this.friendsChart.Text = "chartFriendsChart";
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(FacebookApp.MainForm);
            // 
            // mainFormBindingSource1
            // 
            this.mainFormBindingSource1.DataSource = typeof(FacebookApp.MainForm);
            // 
            // nameLabel1
            // 
            this.nameLabel1.Font = new System.Drawing.Font("Lucida Console", 19.8F, System.Drawing.FontStyle.Bold);
            this.nameLabel1.Location = new System.Drawing.Point(351, 9);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(178, 30);
            this.nameLabel1.TabIndex = 20;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookApp.BusinessLogic.FacebookLogic);
            // 
            // pictureProfilePic
            // 
            this.pictureProfilePic.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "LoggedInUser.ImageLarge", true));
            this.pictureProfilePic.Location = new System.Drawing.Point(12, 181);
            this.pictureProfilePic.Name = "pictureProfilePic";
            this.pictureProfilePic.Size = new System.Drawing.Size(280, 179);
            this.pictureProfilePic.TabIndex = 18;
            this.pictureProfilePic.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LoggedInUser.Name", true));
            this.labelName.Font = new System.Drawing.Font("Lucida Console", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(350, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(389, 33);
            this.labelName.TabIndex = 20;
            // 
            // pictureCoverPhoto
            // 
            this.pictureCoverPhoto.Location = new System.Drawing.Point(12, 40);
            this.pictureCoverPhoto.Name = "pictureCoverPhoto";
            this.pictureCoverPhoto.Size = new System.Drawing.Size(836, 320);
            this.pictureCoverPhoto.TabIndex = 21;
            this.pictureCoverPhoto.TabStop = false;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // imageSelectedPage
            // 
            this.imageSelectedPage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageLarge", true));
            this.imageSelectedPage.Location = new System.Drawing.Point(341, 53);
            this.imageSelectedPage.Name = "imageSelectedPage";
            this.imageSelectedPage.Size = new System.Drawing.Size(424, 324);
            this.imageSelectedPage.TabIndex = 9;
            this.imageSelectedPage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(872, 874);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureProfilePic);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelGreeting);
            this.Controls.Add(this.pictureCoverPhoto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Facebook App";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonLikedPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonFriends)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.friendsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSelectedPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelGreeting;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelFriendsInCommon;
        private System.Windows.Forms.PictureBox pictureBoxCommonLikedPages;
        private System.Windows.Forms.PictureBox pictureBoxCommonFriends;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonChartButton;
        private System.Windows.Forms.ComboBox comboChartType;
        private System.Windows.Forms.DataVisualization.Charting.Chart friendsChart;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private System.Windows.Forms.BindingSource mainFormBindingSource1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.PictureBox pictureProfilePic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureCoverPhoto;
        private System.Windows.Forms.Label labelCommonPages;
        private System.Windows.Forms.Label labelCommonFriends;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.PictureBox imageSelectedPage;
        private System.Windows.Forms.BindingSource pageBindingSource;
    }
}
