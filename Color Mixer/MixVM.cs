using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Color_Mixer
{
    class MixVM : INotifyPropertyChanged
    {
        private double redColor;
        private double greenColor;
        private double blueColor;
        private string backgroundColor;
    
        public double RedColor {
            get { return redColor; }
            set {
                redColor = value;
                changeBackground();
                OnPropertyChanged();
            }
        }

        public double GreenColor
        {
            get { return greenColor; }
            set {
                greenColor = value;
                changeBackground();
                OnPropertyChanged();
            }
        }

        public double BlueColor {
            get { return blueColor; }
            set {
                blueColor = value;
                changeBackground();
                OnPropertyChanged();
            }
        }

        public string BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                OnPropertyChanged();
            }
        }

        private void changeBackground() {
            string color = Color.FromRgb(Convert.ToByte(redColor), Convert.ToByte(greenColor), Convert.ToByte(blueColor)).ToString();
            BackgroundColor = color;
        } 

        #region Propertychanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string caller = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(caller));
        }
        #endregion
    }
}
