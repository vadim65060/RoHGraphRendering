using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RoHGraphRendering.ViewModels;

namespace RoHGraphRendering.UserControls
{
    /// <summary>
    /// Логика взаимодействия для GraphRenderingUserControl.xaml
    /// </summary>
    public partial class GraphRenderingUserControl : UserControl
    {
        private readonly GraphRenderingViewModel _viewModel;

        public GraphRenderingUserControl()
        {
            InitializeComponent();
            _viewModel = new GraphRenderingViewModel();
            DataContext = _viewModel;
            _viewModel.Init();
        }

        public void SetConstants(double brightness, double range, double attenuation0, double attenuation1,
            double attenuation2)
        {
            _viewModel.SetConstants(brightness, range, attenuation0, attenuation1, attenuation2);
        }
    }
}
