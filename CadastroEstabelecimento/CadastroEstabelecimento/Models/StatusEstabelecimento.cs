using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroEstabelecimento.Models
{
    public class StatusEstabelecimento
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public ICollection<Estabelecimentos> Estabelecimentos { get; set; } = new List<Estabelecimentos>();

        public StatusEstabelecimento()
        {

        }

        public StatusEstabelecimento(int id, string categoriaDescricao)
        {
            Id = id;
            Status = Status;
        }
    }
}
