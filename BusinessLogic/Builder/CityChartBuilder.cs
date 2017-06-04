using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.BusinessLogic.Builder
{
    internal class CityChartBuilder : IChartBuilder
    {
        private Dictionary<String, int> ChartValues { get; set; }
        private Chart CityChart { get; set; }

        public void BuildChart()
        {
            ChartValues = new Dictionary<String, int>();
            CityChart = new Chart();
        }

        public Chart GetChart()
        {
            return CityChart;
        }

        public void PopulateChart()
        {
            foreach (KeyValuePair<string, int> item in ChartValues)
            {
                Series seriesCity = CityChart.Series.Add(item.Key.ToString());
                seriesCity.Points.Add(item.Value);
            }
        }

        public void PopulateKeys(User i_User)
        {
            // Add all cities
            foreach (User friend in i_User.Friends)
            {
                try
                {
                    ChartValues.Add(friend.Location.Name, 0);
                }
                catch (Exception)
                {
                    // IF failed for a friend, just ignore and continue to the next friend
                }
            }
        }

        public void PopulateValues(User i_User)
        {
            // Count friends location
            foreach (User friend in i_User.Friends)
            {
                try
                {
                    ChartValues[friend.Location.Name]++;
                }
                catch (Exception)
                {
                    // IF failed for a friend, just ignore and continue to the next friend
                }
            }
        }
    }
}
