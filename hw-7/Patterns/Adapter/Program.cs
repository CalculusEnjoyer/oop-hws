using System;
namespace AdapterExample
{
    class USB
    {
        public string Connect()
        {
            return "Connected through USB";
        }
    }

    interface MobileStandartConnection
    {
        string Connect();
    }


    class MicroUsb : MobileStandartConnection
    {
        public string Connect()
        {
            return "Connected through Micro USB";
        }
    }

    class Adapter : MobileStandartConnection
    {
        private readonly USB _computerUSB;
        public Adapter(USB computerUSB)
        {
            _computerUSB = computerUSB;
        }

        public string Connect()
        {
            return _computerUSB.Connect() + " and adapted to Micro USB";
        }
    }

     class  Mobilephone
    {
        public static void PlugInCable(MobileStandartConnection cable)
        {
            Console.WriteLine(cable.Connect());
        }
    }

    public class AdapterDemo
    {
        static void Main()
        {
            var connectionThroughMicro = new MicroUsb();
            Mobilephone.PlugInCable(connectionThroughMicro);

            var computerUsbConnection = new USB();
            var adapter = new Adapter(computerUsbConnection);
            Mobilephone.PlugInCable(adapter);            
            Console.ReadKey();
        }
    }
}
