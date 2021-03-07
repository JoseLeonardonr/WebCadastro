using CadastroEstabelecimento.Data;
using System;
using System.Collections.Generic;
using CadastroEstabelecimento.Models.Status;
using System.Linq;
using System.Threading.Tasks;
using CadastroEstabelecimento.Models;

namespace CadastroEstabelecimento.Services
{
    public class StatusServices
    {
        private readonly CadastroEstabelecimentoContext _context;

        public StatusServices(CadastroEstabelecimentoContext context)
        {
            _context = context;
        }

        public List<Categorias> FindAll()
        {
            return _context.Categorias.OrderBy(x => x.CategoriaDescricao).ToList();
        }

    }
}
