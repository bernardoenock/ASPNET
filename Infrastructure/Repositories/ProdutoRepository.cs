using System.Collections.Generic;
using System.Linq;
using TesteASPNET.Domain.Entities;
using TesteASPNET.Infrastructure.Context;

namespace TesteASPNET.Infrastructure.Repositories
{
    public class ProdutoRepository 
    {
        private readonly DataContext _context;

        public ProdutoRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Update(Produto produto)
        {
            _context.Entry(produto).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var prod = GetById(id);
            if (prod != null)
            {
                _context.Produtos.Remove(prod);
                _context.SaveChanges();
            }
        }

        public Produto GetById(int id) => _context.Produtos.Find(id);

        public IEnumerable<Produto> GetAll() => _context.Produtos.ToList();
    }
}