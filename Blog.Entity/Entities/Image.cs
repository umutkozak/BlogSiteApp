using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    public class Image:BaseEntity
    {
        public Image()
        {
                
        }
        public Image(string fileName,string fileType)
        {
            FileName = fileName;
            FileType = fileType;
        }
        public string FileName { get; set; }
        public string FileType { get; set; }
        ICollection<Article> Articles { get; set;}
        ICollection<AppUser> AppUsers { get; set;}
    }
}
