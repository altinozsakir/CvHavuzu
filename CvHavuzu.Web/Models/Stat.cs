﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CvHavuzu.Web.Models
{
    public class Stat
    {
        public int Id { get; set; }
        public int ResumeId { get; set; }
       
        [StringLength(200)]
        public string ResumeFullName { get; set; }


        [Required]
        [StringLength(200)]
        public string Ip { get; set; }
        [Required]
        public DateTime DownloadDate { get; set; }
        [Display(Name = "İsim Soyisim")]
        [StringLength(200)]
        public string Fullname { get; set; }
        [Display(Name = "E-mail")]
        [StringLength(200)]
        public string Email { get; set; }
        [Display(Name = "Şirket İsmi")]
        [StringLength(200)]
        public string CompanyName { get; set; }
        [Display(Name = "Telefon Numarası")]
        [StringLength(200)]
        public string Phone { get; set; }
        [StringLength(200)]
        public string UserName { get; set; }
        
    }
}
