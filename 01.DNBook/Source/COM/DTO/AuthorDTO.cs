using System;
using System.Text;
using System.Collections.Generic;


namespace COM.DTO {
    
    public class AuthorDTO {
        public AuthorDTO() { }
        public virtual System.Guid Id { get; set; }
        public virtual string Fullname { get; set; }
        public virtual string Description { get; set; }
        public virtual string Avatar { get; set; }
        public virtual string Url { get; set; }
    }
}
