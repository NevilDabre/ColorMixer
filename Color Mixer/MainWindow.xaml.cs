/*Assignment#3 Group#6
 * Aicun Lu
 * Neville Francis Dabre
 * Abhimanyu Vats
 * Angileena Jacob 
 */
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

namespace Color_Mixer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MixVM mvm;

        public MainWindow()
        {
            InitializeComponent();
            mvm = new MixVM();
            DataContext = mvm;
        }
    }
}
