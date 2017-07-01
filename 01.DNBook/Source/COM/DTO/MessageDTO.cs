using System;
using System.Text;
using System.Collections.Generic;


namespace COM.DTO {
    
    public class MessageDTO {
        public virtual System.Guid Id { get; set; }
        public virtual UserDTO DNB_Users { get; set; }
        public virtual string Title { get; set; }
        public virtual string Contents { get; set; }
        public virtual byte? ImportantLevel { get; set; }
        public virtual string Status { get; set; }
    }
}
