using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Entities
{
    public abstract class BaseEntity:IBaseEntity
        
    {
        
        public BaseEntity()//Default değerleri ctor da tanımladık.
        {
            Id=new Guid();
            CreatedDate = DateTime.Now;
            IsDeleted = false;
        }
        public virtual Guid Id { get; set ; }

        public virtual string? CreatedBy { get; set; }
        public virtual string? ModifiedBy { get; set; }
        public virtual string? DeletedBy { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool? IsDeleted { get; set; }
    }
}
