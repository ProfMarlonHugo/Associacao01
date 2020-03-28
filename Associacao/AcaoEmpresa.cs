using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associacao
{
    interface AcaoEmpresa
    {
        void contratarFunc(Funcionario F);
        void demitirFunc(Funcionario F);
    }
}
