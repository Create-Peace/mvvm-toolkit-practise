using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_mvvmtookit.Models;

namespace wpf_mvvmtookit.ViewModels
{
    public class MainViewModel
    {
        //在MianViewModel中写处理逻辑，这个类 类似于在不分mvvm模式下的后台的代码
        public CalculateModel? calculateModel { get; set; }
        public MainViewModel()
        {
            calculateModel = new CalculateModel();
            calculateModel.a = 1;
            calculateModel.b = 1;
            calculateModel.c = calculateModel.a + calculateModel.b;
        }
    }
}
