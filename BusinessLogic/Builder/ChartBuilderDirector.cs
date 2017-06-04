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
        static public Chart BuildChart(IChartBuilder i_Builder, User i_User)
        {
            i_Builder.BuildChart();
            i_Builder.PopulateKeys(i_User);
            i_Builder.PopulateValues(i_User);
            i_Builder.PopulateChart();

            return i_Builder.GetChart();
        }
    }
}
