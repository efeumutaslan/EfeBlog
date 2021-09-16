﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfeBlog.Entities.Concrete;
using EfeBlog.Shared.Entities.Abstract;
using EfeBlog.Shared.Utilities.Results.ComplexTypes;

namespace EfeBlog.Entities.Dtos
{
    public class ArticleDto:DtoGetBase
    {
        public Article Article { get; set; }
        }
}
