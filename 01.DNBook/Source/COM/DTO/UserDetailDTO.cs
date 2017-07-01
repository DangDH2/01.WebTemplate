using System;
using System.Text;
using System.Collections.Generic;


namespace COM.DTO {
    
    public class UserDetailDTO {
        public UserDetailDTO() { }
        public virtual System.Guid Id { get; set; }
        public virtual string SecondEmail { get; set; }
        public virtual string SecondPhone { get; set; }
        public virtual string Bio { get; set; }
        public virtual string Facebook { get; set; }
        public virtual string Twitter { get; set; }
        public virtual decimal? LocationX { get; set; }
        public virtual decimal? LocationY { get; set; }
    }
}
