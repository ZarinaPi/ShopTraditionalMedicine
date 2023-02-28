using System;
using System.Collections.Generic;

#nullable disable

namespace coursework
{
    public partial class Authorization
    {
        public long IdAuthorization { get; set; }
        public long? IdUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public virtual User IdUserNavigation { get; set; }
    }
}
