using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace crudBlazor.Shared
{
    public class Autor
    {
        public int AutorId { get; set; }
        [Required]
        public string Nome { get; set; }
        public bool Checked { get; set; }
        public List<BookAutor> BookAutors { get; set; }
    }
}