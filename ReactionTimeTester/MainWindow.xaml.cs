using ReactionTimeTester.lib;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ReactionTimeTester
{
    public partial class MainWindow : Window
    {

        Helper _helper = new Helper();
        public MainWindow()
        {
            InitializeComponent();

            //HideWithStartup();
            FillComboBoxWithIps();
        }

        private void HideWithStartup()
        {
            throw new NotImplementedException();
        }

        private void FillComboBoxWithIps()
        {
            var ipList = _helper.GetActiveIP4s();

            foreach(var ip in ipList)
            {
                cmbIpAdresses.Items.Add(ip);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
