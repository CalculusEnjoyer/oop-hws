using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    interface IGeoObject
    {
        public String GetInfo();
    }

    internal class MountainFromI : IGeoObject
    {
        private string name;
        private int height;

        public string Name { get => name; set => name = value; }
        public int Height { get => height; set => height = value; }

        internal MountainFromI(string name, int height)
        {
            Name = name;
            Height = height;
        }

        string IGeoObject.GetInfo()
        {
            return "Height of mountain" + name + " is: " + height.ToString();
        }
    }

    internal class RiverFromI : IGeoObject
    {
        private string name;
        private int length;

        public string Name { get => name; set => name = value; }
        public int Height { get => length; set => length = value; }

        internal RiverFromI(string name, int height)
        {
            Name = name;
            Height = height;
        }

        string IGeoObject.GetInfo()
        {
            return "Length of river" + name + " is: " + length.ToString();
        }
    }
}
