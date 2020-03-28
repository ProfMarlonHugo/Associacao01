using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associacao
{
    class Departamento : AcaoEmpresa
    {
        /*Atributos*/
        private string nome;
        private string sigla;
        private List<Funcionario> funcionario = new List<Funcionario>(); //array

        /*GET SET*/
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        private void addFunc(Funcionario F)
        {
            F.setDepartamento(this);
            this.funcionario.Add(F);
        }
        private bool removeFunc(Funcionario F)
        {
            int buscarFunc = this.funcionario.IndexOf(F); //[0]Marlon [1]Luís
            if(buscarFunc != -1)
            {
                this.funcionario.RemoveAt(buscarFunc);
                return true;
            }
            return false;
        }


        /*Interface*/
        public void contratarFunc(Funcionario F)
        {
            this.addFunc(F);
        }

        public void demitirFunc(Funcionario F)
        {
            if( ! this.removeFunc(F))
            {
                //se false
                Console.WriteLine("Não foi possível demitir funcionário " +
                    F.Nome);
            }else
            {
                Console.WriteLine("Funcionário " + F.Nome + " Demitido.");
            }
        }

        public int totalfuncionarios()
        {
            return funcionario.Count();
        }
    }
}
