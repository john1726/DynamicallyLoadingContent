using DynamicallyLoadingContent.Models.Common;

namespace DynamicallyLoadingContent.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeInfo")]
    public partial class EmployeeInfo : Entity<int>
    {
        [Key]
        public override int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string EmployeeName { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        public int Experience { get; set; }
    }
}
