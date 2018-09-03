using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }

        //SEO
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        //Switch
        bool Status { set; get; }
    }
}
