using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp.BusinessLogic.Builder
{
    public class BuildersFactory
    {
        public static IChartBuilder CreateChartBuilder(eChartType i_Type)
        {
            IChartBuilder ret = null;

            switch (i_Type)
            {
                case eChartType.Gender:
                {
                    ret = new GenderChartBuilder();
                    break;
                }
                case eChartType.City:
                {
                    ret = new CityChartBuilder();
                    break;
                }
                case eChartType.RelationshipStatus:
                {
                    ret = new RelationshipStatusChartBuilder();
                    break;
                }
                default:
                {
                    break;
                }
            }

            return ret;
        }
    }
}
