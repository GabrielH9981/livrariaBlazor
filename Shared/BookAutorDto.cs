using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace crudBlazor.Shared
{
    public class BookAutorDto
    {
        public string BookId { get; set; }
        public Book Book { get; set; }
        public string AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}