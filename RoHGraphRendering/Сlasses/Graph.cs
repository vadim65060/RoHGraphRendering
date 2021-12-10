using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

namespace RoHGraphRendering.Сlasses
{
    class Graph
    {
        public double Brightness, Range, Attenuation0, Attenuation1, Attenuation2;
        private double wieth = 100;

        public Graph(double brightness, double range, double attenuation0, double attenuation1,
            double attenuation2)
        {
            Brightness = brightness;
            Range = range;
            Attenuation0 = attenuation0;
            Attenuation1 = attenuation1;
            Attenuation2 = attenuation2;
        }
        public Graph()
        {
            Brightness = 1;
            Range = 1;
            Attenuation0 = 1;
            Attenuation1 = 1;
            Attenuation2 = 1;
        }

        public FunctionSeries PointsCalculate()
        {
            var pointSeries = new FunctionSeries();
            double d_cost = Range / wieth;
            for (int d = 1; d < wieth + 1; d++)
            {
                double R = d * d_cost;
                double b = Brightness / (Attenuation0 + Attenuation1 * R + Attenuation2 * R * R);
                b -= Brightness * R / (Range * (Attenuation0 + Attenuation1 * Range + Attenuation2 * Range * Range));
                pointSeries.Points.Add(new DataPoint(d, b));
            }

            return pointSeries;
        }
    }
}
