using SfiziTest.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziTest.EntityLayer.Model
{
    [Table("Menu", Schema = "dbo")]
    public class Menu : BasicEntity, IEntity
    {
        public Menu()
        {
            CategoryMenus = new HashSet<CategoryMenu>();
        }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public string ImageUrl4 { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountPrice { get; set; }

        public virtual ICollection<CategoryMenu> CategoryMenus { get; set; }
    }
}
