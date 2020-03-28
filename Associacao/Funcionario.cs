using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associacao
{
    class Funcionario
    {
        /*Atributos*/
        private string nome;
        private string rg;
        private Departamento departamento;

        /*get set*/
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string RG
        {
            get { return rg; }
            set { rg = value;  }
        }

        public void setDepartamento(Departamento D)
        {
            this.departamento = D;
        }

        public Departamento getDepartamento()
        {
            return this.departamento;
        }

    }
}
