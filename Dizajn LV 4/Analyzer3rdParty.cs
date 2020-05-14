using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Dizajn_LV_4
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            //1. zadatak
            int ColumnCount = data[1].Length;
            double[] results = new double[ColumnCount];
            for (int i = 0; i < ColumnCount; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    results[i] += data[i][j];
                }
                results[i] /= 3;
            }
            return results;
        }
    }
}
