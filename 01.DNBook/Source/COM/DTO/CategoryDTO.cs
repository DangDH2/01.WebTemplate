using System;
using System.Text;
using System.Collections.Generic;


namespace COM.DTO {
    
    public class CategoryDTO {
        public CategoryDTO() { }
        public virtual System.Guid Id { get; set; }
        public virtual CategoryDTO ParentDTO { get; set; }
        public virtual string Name { get; set; }
    }
}
