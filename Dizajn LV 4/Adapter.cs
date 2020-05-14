using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dizajn_LV_4
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            IList<List<double>> matrix = dataset.GetData();
            double[][] rijesenje = new double[matrix.Count()][];
            int i = 0, j = 0;
            foreach (List<double> Element in matrix)
            {
                foreach (double n in Element)
                {
                    rijesenje[i][j] = n;
                    j++;
                }
                i++;
            }
            return rijesenje;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }

    }
}
