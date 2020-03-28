using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeFunc = "";
            string rgFunc = "";

            Console.WriteLine("Entre com o nome de um funcionário");
            nomeFunc = Console.ReadLine();
            Console.WriteLine("Entre com o RG do funcionário");
            rgFunc = Console.ReadLine();

            Funcionario func1 = new Funcionario();
            func1.Nome = nomeFunc;
            func1.RG = rgFunc;

            Funcionario func2 = new Funcionario();
            func2.Nome = "Olgmar";
            func2.RG = "MG-15.333.211";

            Funcionario func3 = new Funcionario();
            func3.Nome = "Hebert";
            func3.RG = "MG-10.123.234";

            Departamento dep1 = new Departamento();
            dep1.Nome = "Contabilidade";  //set
            dep1.Sigla = "CONTABIL";
            dep1.contratarFunc(func1);
            dep1.contratarFunc(func2);

            Departamento dep2 = new Departamento();
            dep2.Nome = "Financeiro";  //set
            dep2.Sigla = "FIN";
            dep2.contratarFunc(func3);

            Console.WriteLine("Total de funcionários do departamento " + dep1.Nome +
                  " é " + dep1.totalfuncionarios());
            Console.WriteLine("Total de funcionários do departamento " + dep2.Nome +
                  " é " + dep2.totalfuncionarios());

            Console.WriteLine("O funcionário " + func1.Nome +
                  " está no departamento " + func1.getDepartamento().Nome);
            Console.WriteLine("O funcionário " + func2.Nome +
                  " está no departamento " + func2.getDepartamento().Nome);
            Console.WriteLine("O funcionário " + func3.Nome +
                  " está no departamento " + func3.getDepartamento().Nome);

            Console.WriteLine("Demitindo funcionário " + func2.Nome +
                  " do departamento " + func2.getDepartamento().Nome);

            dep1.demitirFunc(func2);
            Console.WriteLine("Total de funcionários do departamento " + dep1.Nome +
                 " é " + dep1.totalfuncionarios());



            Console.ReadKey();
        }
    }
}
