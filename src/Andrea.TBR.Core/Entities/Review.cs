using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrea.TBR.Core.Entities;
public class Review
{
  public int UserId { get; set; } 
  
  public int ISBN { get; set; }

  public int StarRating { get; set; }

  public string UserReview { get; set; }

  
}
