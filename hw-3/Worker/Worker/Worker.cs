using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    internal abstract class Worker
    {
        protected string _name;
        protected string _position;
        protected string _workDay;

        protected Worker(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetPosition()
        {
            return _position;
        }

        public void SetPosition(string position)
        {
            _position = position;
        }
        public string GetWorkDay()
        {
            return _workDay;
        }

        public void SetWorkDay(string workDay)
        {
            _workDay = workDay;
        }

        public void Call()
        {
            System.Console.WriteLine(_name + " is being called...");
        }

        public void WriteCode()
        {
            System.Console.WriteLine(_name + " is writing code");
        }

        public void Relax()
        {
            System.Console.WriteLine(_name + " is relaxing");
        }

        public abstract void FillWorkDay();
    }

    internal class Developer : Worker
    {
        public Developer(string name) : base(name)
        {
            this._position = "Developer";
        }

        public override void FillWorkDay()
        {
            this.WriteCode();
            this.Call();
            this.Relax();
            this.WriteCode();
        }
    }

    internal class Manager : Worker
    {
        private Random _randomizer;
        public Manager(string name) : base(name)
        {
            _position = "Manager";
            _randomizer = new Random();
        }

        public override void FillWorkDay()
        {
            for(int i = 0; i< _randomizer.Next(1,10); i++)
            {
                this.Call();
            }

            this.Relax();

            for(int i = 0; i < _randomizer.Next(1, 5); i++)
            {
                this.Call();
            }
        }
    }
}
