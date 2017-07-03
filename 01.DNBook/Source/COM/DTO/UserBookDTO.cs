using System;
using System.Text;
using System.Collections.Generic;


namespace COM.DTO {
    
    public class UserBookDTO {
        public UserBookDTO() { }
        public virtual System.Guid Id { get; set; }
        public virtual BookDTO BookDTO { get; set; }
        public virtual UserDTO UserDTO { get; set; }
        public virtual byte? BookNo { get; set; }
    }
}
