using dev.Business.Interfaces;
using dev.Business.Models;
using dev.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dev.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(ProjDbContext context) : base(context) { }
        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores
                        .AsNoTracking()
                        .Include(e => e.Endereco)
                        .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores
                .AsNoTracking()
                .Include(e => e.Endereco)
                .Include(p => p.Produtos)
                .FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
