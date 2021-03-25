using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace persona_ciudad.Data
{
    public class Categoria
    {
        [Key]
        public int Id {get; set;}
        public string Nombre {get; set;}

    }
}