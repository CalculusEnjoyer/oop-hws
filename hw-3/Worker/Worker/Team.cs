using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    internal class Team
    {
        private List<Worker> _workers = new List<Worker>();
        private string _teamName;

        public Team(string teamName)
        {
            _teamName = teamName;
        }

        public void AddWorker(Worker worker)
        {
            _workers.Add(worker);
        }

        public void ShowWorkersNames()
        {
            System.Console.WriteLine("Team name: " + this._teamName);
            foreach (Worker worker in _workers)
            {
                System.Console.WriteLine(worker.GetName());
            }
        }

        public void ShowWorkersFull()
        {
            System.Console.WriteLine("Team name: " + this._teamName);
            foreach (Worker worker in _workers)
            {
                System.Console.Write(worker.GetName() + "-");
                System.Console.Write(worker.GetPosition() + "-");
                System.Console.WriteLine(worker.GetWorkDay());
            }
        }
    }
}
