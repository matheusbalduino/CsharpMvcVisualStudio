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
    public class EnderecoRepository: Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ProjDbContext context) : base(context) { }
        
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos
                           .AsNoTracking()
                           .Include(f => f.Fornecedor)
                           .FirstOrDefaultAsync(e => e.FornecedorId == fornecedorId);
        }
    }
}
