using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Worker.Entities.Enums;

namespace Worker.Entities
{
    class Worker
    {
        public string Name { get; private set; }
        public WorkerLevel Level { get; private set; }
        public double  BaseSalary { get; private set; }
    
        private List<HourContract> contracts = new List<HourContract>();
        private Department Department;


        public void AddContracts(HourContract contract)
        {
            contracts.Add(contract);
        }

        public void RemoveContracts(HourContract contract)
        {
            contracts.Remove(contract);
        }

        public double Income(int month, int year)
        {
            return 0;
        }

    }
}
