using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zhaoxi.Configuration.Models;

namespace Zhaoxi.Configuration.ViewModels
{
    public class MainViewModel
    {
        public List<DeviceModel> DeviceList { get; set; } =
            new List<DeviceModel>();

        public List<DeviceStateModel> StateList { get; set; } =
            new List<DeviceStateModel>();

        public ObservableCollection<MessageModel> MessageList { get; set; } =
            new ObservableCollection<MessageModel>();

        public MainViewModel()
        {
            // 模拟数据   为了UI的显示处理
            for (int i = 0; i < 5; i++)
            {
                DeviceList.Add(new DeviceModel()
                {
                    DeviceNum = "AB123123",
                    StartTime = "10/11",
                    Power = "500KWH",
                    WorkTime = "1000min"
                });



            }

            StateList.Add(new DeviceStateModel
            {
                Icon = "/Assets/Images/a1.png",
                Header = "保养中",
                Value = 12.3
            });
            StateList.Add(new DeviceStateModel
            {
                Icon = "/Assets/Images/a2.png",
                Header = "待检验",
                Value = 43.6
            });
            StateList.Add(new DeviceStateModel
            {
                Icon = "/Assets/Images/a3.png",
                Header = "已停用",
                Value = 10.5
            });
            StateList.Add(new DeviceStateModel
            {
                Icon = "/Assets/Images/a1.png",
                Header = "保养中",
                Value = 12.3
            });


            for (int i = 0; i < 15; i++)
            {
                MessageList.Add(new MessageModel()
                {
                    Message = "报警消息，报警消息，报警消息",
                    Date="07/01"
                });
            }
        }
    }
}
