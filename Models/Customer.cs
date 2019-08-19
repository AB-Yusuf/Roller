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

        
        public string Name { get; set; }

        public bool SubscribeToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }


        public  byte MembershipTypeId { get; set; }

        public MembershipType MembershipName { get; set; }
    }
}