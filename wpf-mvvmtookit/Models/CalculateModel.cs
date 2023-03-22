using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_mvvmtookit.Models
{
    public class CalculateModel: ObservableObject
    {
        private int _a;
        private int _b;
        private int _c;
        public int a
        {
            get
            {
                return _a;
            }
            set
            {
                SetProperty(ref _a, value);
            }
        }
        public int b {
            get {
                return _b;
            }
            set {
                SetProperty(ref _b, value);
            }
           }
        public int c { 
            get
            {
                return _c;
            }
            set
            {
                SetProperty(ref _c, value);
            }
        }
    }
}
