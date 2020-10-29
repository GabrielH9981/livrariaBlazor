using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace crudBlazor.Shared
{
    public class Category
    {
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Nome { get; set; }
        public ICollection<Book> Books{ get; set; }
    }
}