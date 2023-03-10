using SfiziTest.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfiziTest.EntityLayer.Model
{
    [Table("MenuSeo", Schema = "dbo")]
    public class MenuSeo : SeoEntity, IEntity
    {
        public string PageName { get; set; }
    }
}
