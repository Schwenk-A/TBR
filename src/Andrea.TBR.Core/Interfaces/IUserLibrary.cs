using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Andrea.TBR.Core.Entities;

namespace Andrea.TBR.Core.Interfaces;
public interface IUserLibrary
{
  public IEnumerable<Book> GetByAuthor(string author, int userId);
  public IEnumerable<Book> GetByTitle(string title, int userId);
  public IEnumerable<Book> GetBySubject(string subject, int userId);
  public IEnumerable<Book> GetByStarRating(int starRating, int userId);
  public int DeleteBook(Book book, int userId);
  public Book GetByRating(int rating, int userId);

}
