using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoCrafts.WebSite.Models
{
    [Table("People")]
    public class People
    {
        public int PeopleID { get; set; }

        [Column("name")]
        public string Nome { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return Nome + ", Aqui";
            }
        }
    }
}
