using System;
using System.Text;
using System.Collections.Generic;


namespace COM.DTO {
    
    public class BookTagDTO {
        public virtual System.Guid Id { get; set; }
        public virtual BookDTO DNB_BOOKS { get; set; }
        public virtual TagDTO DNB_TAGS { get; set; }
    }
}
