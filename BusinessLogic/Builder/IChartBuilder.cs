using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace FacebookApp.BusinessLogic.Builder
{
    public interface IChartBuilder
    {
        void BuildChart();
        void PopulateKeys(User user);
        void PopulateValues(User user);
        void PopulateChart();
        Chart GetChart();
    }
}
