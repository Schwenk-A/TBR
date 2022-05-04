using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Andrea.TBR.Core.Entities;

namespace Andrea.TBR.Core.Interfaces;
public interface IUserRepo
{
  public User AddUser { get; set; }
  public User UpdateUser { get; set; }

  public int DeleteUser { get; set; }

}
