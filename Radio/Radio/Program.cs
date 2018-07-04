using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Radio
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new Unity.UnityContainer();
            UnityContainer.RegisterElements(container);

            IBattery battery = container.Resolve<IBattery>();
            Console.WriteLine(battery.SerialNumber());

            ITuner tuner = container.Resolve<ITuner>();
            Console.WriteLine(tuner.SerialNumber());

            ICasing casing = container.Resolve<ICasing>();
            Console.WriteLine(casing.TypeOfMaterial());

            Console.ReadLine();
        }
    }
}
