using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace persona_ciudad.Data
{
    public class Ubicacion
    {
        [Key]
        public string Codigo {get; set;}
        public string Nombre {get; set;}

    }
}