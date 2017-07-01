using System;
using System.Text;
using System.Collections.Generic;


namespace COM.DTO {
    
    public class HiringDTO {
        public virtual System.Guid Id { get; set; }
        public virtual UserBookDTO DNB_UsersBooks { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual string Status { get; set; }
    }
}
