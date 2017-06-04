using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.BusinessLogic.Builder
{
    internal class GenderChartBuilder : IChartBuilder
    {
        private Chart GenderChart { get; set; }
        private Dictionary<User.eGender, int> ChartValues { get; set; }

        public void BuildChart()
        {
            ChartValues = new Dictionary<User.eGender, int>();
            GenderChart = new Chart();
        }

        public Chart GetChart()
        {
            return GenderChart;
        }

        public void PopulateChart()
        {
            foreach (KeyValuePair<User.eGender, int> item in ChartValues)
            {
                Series seriesGender = GenderChart.Series.Add(item.Key.ToString());
                seriesGender.Points.Add(item.Value);
            }
        }

        public void PopulateKeys(User i_User)
        {
            foreach (User.eGender item in Enum.GetValues(typeof(User.eGender)))
            {
                ChartValues.Add(item, 0);
            }
        }

        public void PopulateValues(User i_User)
        {
            foreach (User friend in i_User.Friends)
            {
                try
                {
                    ChartValues[friend.Gender.Value]++;
                }
                catch (Exception)
                {
                    // IF failed for a friend, just ignore and continue to the next friend
                }
            }
        }
    }
}
