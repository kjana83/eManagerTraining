using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Web.Helper;

namespace eManager.Web.Models
{
    public class CreateEmployeeViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int DepartmentId { get; set; }

        [Required]
        [ExcludeChar(",/")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Joining Date")]
        public DateTime? JoiningDate { get; set; }

    }
}