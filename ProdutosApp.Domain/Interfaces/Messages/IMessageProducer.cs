using ProdutosApp.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Domain.Interfaces.Messages
{
    /// <summary>
    /// Interface para gravação dos dados do produto
    /// em um serviço de fila de mensageria
    /// </summary>
    public interface IMessageProducer
    {
        void CreateLog(ProdutosLogDto produtosLogDto);
    }
}



