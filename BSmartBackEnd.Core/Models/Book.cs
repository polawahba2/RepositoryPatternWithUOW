using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSmartBackEnd.Core.Models
{
  using System;

public class Book
{
    public int BookID { get; set; }
    public string Title { get; set; } =null!;
    public int AuthorID { get; set; }
    public string Genre { get; set; }= null!;
    public decimal Price { get; set; }
    public DateTime PublishedDate { get; set; }
}

}