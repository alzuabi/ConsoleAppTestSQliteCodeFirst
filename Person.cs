﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [Table("Person")]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
