﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Test : Entity
    {
        public virtual string Name { get; set; }


        public virtual string Code { set; get; }
    }

}
