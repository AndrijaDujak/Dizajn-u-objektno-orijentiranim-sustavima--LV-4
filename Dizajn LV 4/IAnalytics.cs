using System;
using System.Collections.Generic;
using System.Text;

namespace Dizajn_LV_4
{
    interface IAnalytics
    {
        double[] CalculateAveragePerColumn(Dataset dataset);
        double[] CalculateAveragePerRow(Dataset dataset);

    }
}
