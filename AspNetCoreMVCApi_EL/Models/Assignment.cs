using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreMVCApi_EL.Models
{
    [Table("Assignments")]
    public class Assignment
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Column(Order = 2)]
        public DateTime CreatedDate { get; set; }
        [Column(Order = 3)]
        [Required]
        [StringLength(500, MinimumLength = 2, ErrorMessage = "Görev tavını en az 2 en çok 500 karakter olmalıdır")]
        public string Description { get; set; }
        [Column(Order = 4)]
        public bool IsCompleted { get; set; } //Görev tamamlandıMı ?


    }
}
