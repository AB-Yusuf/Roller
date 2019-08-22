using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roller.Models
{
    public class Customer
    {

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool SubscribeToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        //public string TypeOfMembership { get; set; }


        public  int MembershipTypeId { get; set; }

        //public MembershipType MembershipName { get; set; }
    }
}