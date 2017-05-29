using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC5_ATM.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Display(Name ="Account #")]
        [Required]
        [StringLength(10)]
        [Column(TypeName ="varchar")]
        [RegularExpression(@"\d{6,10}" ,ErrorMessage ="Account Number must be a number with (min length = 6 and max length= 10)")]
        public string AccountNumber { get; set; }

        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return $"{FirstName +" " + LastName }"; }
        }

        
        public virtual ApplicationUser User { get; set; }  //the virtual keyword here used for lazy loading

        [Required]
        public string ApplicationUserId { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}