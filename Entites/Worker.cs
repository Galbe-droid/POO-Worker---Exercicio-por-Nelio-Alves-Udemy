using System;
using System.Collections.Generic;
using System.Text;
using WorkerInfo.Entites.Enum;

namespace WorkerInfo.Entites
{
    class Worker
    {
        public string Nome { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; private set; }
        public Departament Departament { get; set; }

        List<HourContract> WorkContractList = new List<HourContract>();

        public Worker(string name, WorkLevel level, double salary, Departament departamento)
        {
            Nome = name;
            Level = level;
            BaseSalary = salary;
            Departament = departamento;
        }

        public void AddContract()
        {
            int id;
            double preco;
            int hora;
            DateTime date;

            HourContract contract;

            id = WorkContractList.Count + 1;

            Console.WriteLine("Data de inicio.");
            Console.Write("DD/MM/AAAA: ");
            date = DateTime.Parse(Console.ReadLine());


            Console.WriteLine("Quanto o Trabalhadore recebe por hora.");
            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Por quanto tempo.");
            Console.Write("Tempo: ");
            hora = int.Parse(Console.ReadLine());

            contract = new HourContract(id, preco, hora, date);

            WorkContractList.Add(contract);
        }

        public void RemoveContract()
        {
            int id;

            for (int i = 0; i < WorkContractList.Count; i++)
            {
                Console.WriteLine(WorkContractList[i]);
            }

            Console.WriteLine("Remover qual contrato por ID.");
            Console.Write("ID: ");
            id = int.Parse(Console.ReadLine());

            for (int x = 0; x < WorkContractList.Count; x++)
            {
                if (WorkContractList[x].Id == id)
                {
                    WorkContractList.RemoveAt(x);
                }
            }
        }

        public double Income()
        {
            int id;

            for (int i = 0; i < WorkContractList.Count; i++)
            {
                Console.WriteLine(WorkContractList[i]);
            }

            Console.WriteLine("Saber o total ganho por ID.");
            Console.Write("ID: ");
            id = int.Parse(Console.ReadLine());

            for (int x = 0; x < WorkContractList.Count; x++)
            {
                if (WorkContractList[x].Id == id)
                {
                    return WorkContractList[x].TotalValue() + BaseSalary;
                }
            }

            return BaseSalary;
        }
    }
}
