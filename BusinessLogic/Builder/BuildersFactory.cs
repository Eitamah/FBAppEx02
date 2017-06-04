using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp.BusinessLogic.Builder
{
    public static class BuildersFactory
    {
        public static IChartBuilder CreateChartBuilder(eChartType i_Type)
        {
            IChartBuilder builder = null;

            switch (i_Type)
            {
                case eChartType.Gender:
                {
                    builder = new GenderChartBuilder();
                    break;
                }
                case eChartType.City:
                {
                    builder = new CityChartBuilder();
                    break;
                }
                case eChartType.RelationshipStatus:
                {
                    builder = new RelationshipStatusChartBuilder();
                    break;
                }
                default:
                {
                    break;
                }
            }

            return builder;
        }
    }
}
