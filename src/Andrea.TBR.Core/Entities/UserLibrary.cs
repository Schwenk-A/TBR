using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrea.TBR.Core.Entities;
public class UserLibrary
{
  public IEnumerable<Book> Library { get; set; }
  public string UserId { get; set; }

}
