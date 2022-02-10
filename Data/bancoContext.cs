using ControleDeCadastros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeCadastros.Data
{
    public class bancoContext : DBcontext
    {
        public bancoContext(DbContextOptions<bancoContext>options) : base(options)
        {
        }
        public DbSet<CadastrosModel> Cadastros { get; set; }
    }
}
