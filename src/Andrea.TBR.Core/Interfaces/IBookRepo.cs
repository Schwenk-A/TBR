using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Andrea.TBR.Core.Entities;

namespace Andrea.TBR.Core.Interfaces;
public interface IBookRepo
{
  /// <summary>
  /// returning how many rows were changed in the data base.
  /// </summary>
  /// <param name="bookToInsert"></param>
  /// <returns></returns>
  public int InsertBook(Book bookToInsert); 

  public Book GetByISBN(int isbn);

}
