using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServicoEstoque
{
    [ServiceContract]
    public interface IEstoque
    {
        [OperationContract]
        bool TemLivroEmEstoque(string nomeLivro);
    }
}
