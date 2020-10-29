using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace crudBlazor.Shared
{
    public class BookAutor
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}