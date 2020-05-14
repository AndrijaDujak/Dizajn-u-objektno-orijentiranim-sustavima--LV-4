using System;

namespace Dizajn_LV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Zadatak
            Dataset dataset = new Dataset("Documents/primjer.cvs");
            Analyzer3rdParty analyzer = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer);
            double[] averagecol = adapter.CalculateAveragePerColumn(dataset);
            double[] averagerow = adapter.CalculateAveragePerRow(dataset);
        }
    }
}
