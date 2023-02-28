using System;
using System.Collections.Generic;

#nullable disable

namespace coursework
{
    public partial class User
    {
        public User()
        {
            Authorizations = new HashSet<Authorization>();
            Orders = new HashSet<Order>();
        }

        public long IdUser { get; set; }
        public string SurnameUser { get; set; }
        public string NameUser { get; set; }
        public string PatronymicUser { get; set; }
        public string MobileNumberUser { get; set; }
        public string AddressUser { get; set; }

        public virtual ICollection<Authorization> Authorizations { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
