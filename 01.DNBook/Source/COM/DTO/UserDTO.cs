using System;
using System.Text;
using System.Collections.Generic;


namespace COM.DTO {
    
    public class UserDTO {
        public UserDTO() { }
        public virtual System.Guid Id { get; set; }
        public virtual UserDetailDTO UserDetailDTO { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual byte? Gender { get; set; }
        public virtual DateTime? Birthday { get; set; }
        public virtual string Avatar { get; set; }
        public virtual string CMND { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        public virtual byte? Country { get; set; }
        public virtual byte? City { get; set; }
        public virtual byte? District { get; set; }
        public virtual string Ward { get; set; }
        public virtual string Street { get; set; }
        public virtual byte? Rating { get; set; }
        public virtual string Status { get; set; }
        public virtual DateTime? LastLoginDate { get; set; }
        public virtual byte? Role { get; set; }
    }
}
