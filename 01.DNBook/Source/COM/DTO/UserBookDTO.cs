using System;
using System.Text;
using System.Collections.Generic;


namespace COM.DTO {
    
    public class UserBookDTO {
        public UserBookDTO() { }
        public virtual System.Guid Id { get; set; }
        public virtual BookDTO DNB_BOOKS { get; set; }
        public virtual UserDTO DNB_Users { get; set; }
        public virtual byte? BookNo { get; set; }
    }
}
