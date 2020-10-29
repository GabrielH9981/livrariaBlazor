using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace crudBlazor.Shared
{
    public class RentDto
    {
        [Required]
        public int RentId { get; set; }
        public string nomeBiblioteca { get; set; }
        public string BookId { get; set; }
        public Book Book { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}