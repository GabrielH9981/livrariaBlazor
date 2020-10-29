using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace crudBlazor.Shared
{
    public class Book
    {
        [Required]
        public int BookId { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Sinopse { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}