﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class commentsDTO
    {
        public int id { get; set; }
        public string message { get; set; }

        public int bookID { get; set; }

        public int UserID { get; set; }
    }
}
