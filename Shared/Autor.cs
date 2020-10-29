using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace crudBlazor.Shared
{
    public class Autor
    {
        public int Id { get; set; }
        public int IdAutor { get; set; }
        [Required]
        public string Nome { get; set; }
        public List<Book> Books { get; set; }
    }
}