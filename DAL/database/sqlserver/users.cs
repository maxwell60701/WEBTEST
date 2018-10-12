namespace DAL.database.sqlserver
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(36)]
        public string UserCode { get; set; }

        [Required]
        [StringLength(36)]
        public string UserName { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime UpdatedDate { get; set; }

        [StringLength(36)]
        public string Extend1 { get; set; }

        [StringLength(36)]
        public string Extend2 { get; set; }

        [StringLength(36)]
        public string Extend3 { get; set; }

        [Required]
        [StringLength(36)]
        public string Password { get; set; }
    }
}
