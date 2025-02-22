using Bookstore.Application.Interfaces;
using Bookstore.Domain.Entities;
using Bookstore.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;
        public BookRepository(AppDbContext context) => _context = context;

        public async Task<IEnumerable<Book>> GetAllAsync() => await _context.Books.ToListAsync();
        public async Task<Book> GetByIdAsync(int id) => await _context.Books.FindAsync(id);
        public async Task AddAsync(Book book) { _context.Books.Add(book); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Book book) { _context.Books.Update(book); await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var book = await _context.Books.FindAsync(id); if (book != null) { _context.Books.Remove(book); await _context.SaveChangesAsync(); } }
    }
}
