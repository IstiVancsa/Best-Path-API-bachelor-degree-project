﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class BaseEntity
    {
        [Key]//nu e obligatoriu daca prop se numeste Id sau entityname+Id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        //public virtual List<BaseEntity> CreateSeeds(int numberOfSeeds)
        //{
        //    return null;
        //}
    }
}
