using CommunityToolkit.Mvvm.ComponentModel;
using StudySelf.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySelf.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _name;

        //public ObservableCollection<DeviceStateModel> DeviceStates { get; set; }

        public ObservableCollection<DeviceModel> Devices { get; set; }

        public MainViewModel()
        {
            this.Devices = new ObservableCollection<DeviceModel>
            {
                new DeviceModel{ DeviceNum = "ABC001", StartTime = DateTime.Now.ToString("HH:mm"), Power = "80%", WorkTime = "2h 30m" },
                new DeviceModel{ DeviceNum = "ABC002", StartTime = DateTime.Now.ToString("HH:mm"), Power = "70%", WorkTime = "1h 20m" },
                new DeviceModel{ DeviceNum = "ABC003", StartTime = DateTime.Now.ToString("HH:mm"), Power = "60%", WorkTime = "3h 10m" },
                new DeviceModel{ DeviceNum = "ABC004", StartTime = DateTime.Now.ToString("HH:mm"), Power = "50%", WorkTime = "2h 00m" },
                new DeviceModel{ DeviceNum = "ABC005", StartTime = DateTime.Now.ToString("HH:mm"), Power = "30%", WorkTime = "3h 50m" }
            };
        }
    }
}
