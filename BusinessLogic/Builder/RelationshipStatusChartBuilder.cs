using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.BusinessLogic.Builder
{
    class RelationshipStatusChartBuilder : IChartBuilder
    {
        private Chart RelationshipStatusChart { get; set; }
        private Dictionary<User.eRelationshipStatus, int> ChartValues { get; set; }

        public void BuildChart()
        {
            ChartValues = new Dictionary<User.eRelationshipStatus, int>();
            RelationshipStatusChart = new Chart();
        }

        public Chart GetChart()
        {
            return RelationshipStatusChart;
        }

        public void PopulateChart()
        {
            foreach (KeyValuePair<User.eRelationshipStatus, int> item in ChartValues)
            {
                Series seriesStatus = RelationshipStatusChart.Series.Add(item.Key.ToString());
                seriesStatus.Points.Add(item.Value);
            }
        }

        public void PopulateKeys(User i_User)
        {
            foreach (User.eRelationshipStatus item in Enum.GetValues(typeof(User.eRelationshipStatus)))
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
                    ChartValues[friend.RelationshipStatus.Value]++;
                }
                catch (Exception)
                {
                    // IF failed for a friend, just ignore and continue to the next friend
                }
            }
        }
    }
}
