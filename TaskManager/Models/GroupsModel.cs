using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    [Table("Groups")]
    public class GroupsModel
    {
        [Key]
        public int GroupID { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane!")]
        [MaxLength(50)]
        [Display(Name = "Nazwa grupy")]
        public string NameOfGroup { get; set; }
        public bool GroupVisible { get; set; }
    }
}
