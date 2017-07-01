using System;
using System.Text;
using System.Collections.Generic;


namespace COM.DTO {
    
    public class BookDTO {
        public BookDTO() { }
        public virtual System.Guid Id { get; set; }
        public virtual AuthorDTO Author { get; set; }
        public virtual CategoryDTO Category { get; set; }
        public virtual string Title { get; set; }
        public virtual string Cover { get; set; }
        public virtual string Pictures { get; set; }
        public virtual string ShortDescription { get; set; }
        public virtual string LongDescription { get; set; }
        public virtual string ISBN { get; set; }
        public virtual DateTime? PublishDate { get; set; }
        public virtual byte? Rating { get; set; }
        public virtual float? Price { get; set; }
        public virtual float? HirePrice { get; set; }
        public virtual int? BookCount { get; set; }
        public virtual int? HiringCount { get; set; }
    }
}
