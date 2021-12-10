using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using RoHGraphRendering.Сlasses;

namespace RoHGraphRendering.ViewModels
{
    class GraphRenderingViewModel : INotifyPropertyChanged
    {
        public PlotModel Model { get; } = new PlotModel();
        private Graph graph = new();
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Init()
        {
            ModelUpdate();
        }

        private void ModelUpdate()
        {
            Model.Series.Clear();
            Model.Series.Add(graph.PointsCalculate());
            Model.InvalidatePlot(true);
        }

        public void SetConstants(double brightness, double range, double attenuation0, double attenuation1,
            double attenuation2)
        {
            graph.Brightness = brightness;
            graph.Range = range;
            graph.Attenuation0 = attenuation0;
            graph.Attenuation1 = attenuation1;
            graph.Attenuation2 = attenuation2;
            ModelUpdate();
        }

        public double Brightness
        {
            get => graph.Brightness;
            set
            {
                graph.Brightness = value;
                ModelUpdate();
            }
        }

        public double Range
        {
            get => graph.Range;
            set
            {
                graph.Range = value;
                ModelUpdate();
            }
        }

        public double Attenuation0
        {
            get => graph.Attenuation0;
            set
            {
                graph.Attenuation0 = value;
                ModelUpdate();
            }
        }

        public double Attenuation1
        {
            get => graph.Attenuation1;
            set
            {
                graph.Attenuation1 = value;
                ModelUpdate();
            }
        }

        public double Attenuation2
        {
            get => graph.Attenuation2;
            set
            {
                graph.Attenuation2 = value;
                ModelUpdate();
            }
        }
    }
}
