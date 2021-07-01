using dev.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dev.Business.Interfaces
{
    interface IProdutoRepository: IRepository<Produto>
    {
        Task<Fornecedor> ObterProdutosPorFornecedor(Guid fornecedorId);
        Task<Fornecedor> ObterProdutosFornecedores();
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}
