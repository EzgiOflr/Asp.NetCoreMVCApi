using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreMVCApi_EL.ViewModels
{
    public class AssignmentVM
    {
        public int Id { get; set; }
       
        public DateTime CreatedDate { get; set; }
      
        [Required]
        [StringLength(500, MinimumLength = 2, ErrorMessage = "Görev tanımı  en az 2 en çok 500 karakter olmalıdır")]
        public string Description { get; set; }
      
        public bool IsCompleted { get; set; } //Görev tamamlandıMı ?


    }
}
