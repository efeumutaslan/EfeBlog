﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfeBlog.Entities.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        [MaxLength(70,ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(3,ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]
        public string Description { get; set; }
        [DisplayName("Kategori Özel Not Alanı")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")] 
        public string Note { get; set; }
        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        public bool IsActive { get; set; }
    }
}
