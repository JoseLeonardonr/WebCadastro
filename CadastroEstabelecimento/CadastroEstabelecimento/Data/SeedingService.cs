﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroEstabelecimento.Models;

namespace CadastroEstabelecimento.Data
{
    public class SeedingService
    {
        private CadastroEstabelecimentoContext _context;

        public SeedingService(CadastroEstabelecimentoContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Categorias.Any() || _context.Estabelecimentos.Any())
            {
                return; //banco populado
            }

            Categorias C1 = new Categorias(1, "Supermercado");
            Categorias C2 = new Categorias(2, "Restaurante");
            Categorias C3 = new Categorias(3, "Borracharia");
            Categorias C4 = new Categorias(4, "Posto");
            Categorias C5 = new Categorias(5, "Oficina");

            Estabelecimentos E1 = new Estabelecimentos(1, "Restaurante Ana", "Restaurante Ana - LTDA", "20320255566", "teste", "rua teste", "Nova Resende", "MG", "359856352", new DateTime(2021, 02, 28), "2353", "131687", Models.Status.EstabelecimentosStatus.Ativo, C1);

            _context.Categorias.AddRange(C1, C2, C3, C4, C5);
            _context.Estabelecimentos.AddRange(E1);

            _context.SaveChanges();

        }
    }
}
