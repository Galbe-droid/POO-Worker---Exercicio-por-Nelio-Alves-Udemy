using System;
using WorkerInfo.Entites;
using WorkerInfo.Entites.Enum;

namespace WorkerInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Departament departamento;
            int levelInt;
            int escolha;
            double baseSalary;
            WorkLevel level = new WorkLevel();
            bool on = true;

            Console.WriteLine("Insira as informações do trabalhador.");
            Console.Write("Departamento: ");
            departamento = new Departament(Console.ReadLine());
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Nivel (Junior = 1/Pleno = 2/Senior = 3): ");
            levelInt = int.Parse(Console.ReadLine());
            Console.Write("Salario: ");
            baseSalary = double.Parse(Console.ReadLine());

            if (levelInt == 1) { level = WorkLevel.JUNIOR; }
            if (levelInt == 2) { level = WorkLevel.MID_LEVEL; }
            if (levelInt == 3) { level = WorkLevel.SENIOR; }


            Worker worker = new Worker(name, level, baseSalary, departamento);

            while(on)
            {
                Console.WriteLine(worker);

                Console.WriteLine("Você deseja.");
                Console.WriteLine("1 - Novo Contrato \n2 - Apagar Contrato\n3 - Saber Ganho\n4 - Sair");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 4) { on = false; } 

                Escolhas(escolha, worker);
            }
        }

        static void Escolhas(int escolha, Worker worker)
        {
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Quantos contratos esse trabalhador tem ?");
                    Console.WriteLine("Contratos: ");
                    int contratos = int.Parse(Console.ReadLine());
                    for (int i = 0; i < contratos; i++)
                    {
                        Console.WriteLine($"Contrato #{i}");
                        worker.AddContract();
                        Console.Clear();
                    }
                    break;

                case 2:
                    worker.RemoveContract();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 3:
                    worker.Income();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Invalido");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
}
