﻿using System.ComponentModel.DataAnnotations;

namespace APIalmoxarifado.Models
{
    public class Categoria
    {
        [Key] 
        public int id { get; set; }
        public string descricao { get; set; }
    }
}
