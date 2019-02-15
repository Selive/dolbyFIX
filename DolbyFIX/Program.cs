using Dolby.Interop;
using Dolby.Pcee.Common;
using Dolby.Pcee.Selector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DolbyFIX
{
    class Program
    {
        public static MainViewModel Model;
        private static DolbyGateway gateway;

        static void Main(string[] args)
        {
            gateway = new DolbyGateway();
            gateway.Initialize();
            Model = new MainViewModel(gateway);
            while (true)
            {
                Model.IsDolbyEnabled = true;
                Thread.Sleep(10);
            }
        }
    }
}
