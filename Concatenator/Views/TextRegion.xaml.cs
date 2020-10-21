using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Concatenator.ViewModels;

namespace Concatenator.Views
{
    /// <summary>
    /// TextRegion.xaml 的交互逻辑
    /// </summary>
    public partial class TextRegion : Window
    {
        public TextRegion()
        {
            InitializeComponent();
            DataContext = new TextRegionViewModel();
        }
    }
}
