using System;
using System.Collections.Generic;

namespace FSParts.API.Models
{
    public partial class FsUser
    {
        public FsUser()
        {
            FsSurveys = new HashSet<FsSurvey>();
        }

        public long UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Company { get; set; }
        public string? Title { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PasswordHint { get; set; }
        public string? RepCode { get; set; }

        public virtual ICollection<FsSurvey> FsSurveys { get; set; }
    }
}
