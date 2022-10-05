using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal abstract class GeologicalObject
    {
        protected String _name;
        protected double _longitudeX;
        protected double _longitudeY;
        protected String _describtion;

        protected GeologicalObject() { }

        protected GeologicalObject(String name, double longitudeX, double longitudeY, string describtion)
        {
            this._name = name;
            this._longitudeX = longitudeX;
            this._longitudeY = longitudeY;
            this._describtion = describtion;
        }

        public virtual String GetInfo()
        {
            return _describtion;
        }

    }

    class River : GeologicalObject
    {
        private double _riverSpeed;
        private double _length;

        public River(double riverSpeed, double length)
        {
            _riverSpeed = riverSpeed;
            _length = length;
        }

        public River(String name, double longitudeX, double longitudeY, string describtion, double riverSpeed, double length)
            : base(name, longitudeX, longitudeY, describtion)
        {
            _riverSpeed = riverSpeed;
            _length = length;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " River length: " + _length + " River speed: " + _riverSpeed;
        }
    }

    class Mountain : GeologicalObject
    {
        private String _highestMountain;

        public Mountain(string highestMountain)
        {
            _highestMountain = highestMountain;
        }

        public Mountain(String name, double longitudeX, double longitudeY, string describtion, String highestMountain) :
            base(name, longitudeX, longitudeY, describtion)
        {
            _highestMountain = highestMountain;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " Highest mountain: " + _highestMountain;
        }
    }
}
