using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class BooksDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string publishDay { get; set; }
        public int? rating { get; set; }
        public int GenreID { get; set; }
    }
}
