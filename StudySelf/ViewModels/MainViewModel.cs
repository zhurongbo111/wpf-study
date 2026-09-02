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
        public ObservableCollection<DeviceStateModel> DeviceStates { get; set; }

        public ObservableCollection<DeviceModel> Devices { get; set; }

        public ObservableCollection<MessageModel> MessageList { get; set; } = new ObservableCollection<MessageModel>();

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
            this.DeviceStates = new ObservableCollection<DeviceStateModel>
            {
                new DeviceStateModel{ Icon = "/Assets/Images/a1.png", Header = "保养中", Value = 12.3 },
                new DeviceStateModel{ Icon = "/Assets/Images/a2.png", Header = "待机", Value = 58.7 },
                new DeviceStateModel{ Icon = "/Assets/Images/a3.png", Header = "故障", Value = 35.2 },
                new DeviceStateModel{ Icon = "/Assets/Images/a4.png", Header = "运行中", Value = 75.2 }
            };

            for (int i = 0; i < 15; i++)
            {
                MessageList.Add(new MessageModel()
                {
                    Message = "报警消息，报警消息，报警消息",
                    Date = DateTime.Now.AddDays(-i).ToString("MM/dd"),
                });
            }
        }
    }
}
