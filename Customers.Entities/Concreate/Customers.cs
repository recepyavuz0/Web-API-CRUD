using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concreate
{
    public class Customers : IEntity
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
