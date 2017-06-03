using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace FacebookApp.BusinessLogic.Builder
{
    public class ChartBuilderDirector
    {
        static public Chart BuildChartData(eChartType type, User user, Chart chart)
        {
            IChartBuilder builder = BuildersFactory.CreateChartBuilder(type);
            builder.BuildChart();
            builder.PopulateKeys(user);
            builder.PopulateValues(user);
            builder.PopulateChart();

            return builder.GetChart();
        }
    }
}
