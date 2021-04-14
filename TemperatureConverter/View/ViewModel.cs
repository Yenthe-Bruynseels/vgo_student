﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class ConverterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double temperatureInKelvin;

        public double TemperatureInKelvin
        {
            get
            {
                return temperatureInKelvin;
            }
            set
            {
                temperatureInKelvin = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TemperatureInKelvin)));
            }
        }
    }
}
