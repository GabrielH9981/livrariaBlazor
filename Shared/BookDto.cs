using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace crudBlazor.Shared
{
    public class BookDto
    {
        public int BookId { get; set; }
        [Required]
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public List<BookAutor> BookAutors { get; set; }
    }
}