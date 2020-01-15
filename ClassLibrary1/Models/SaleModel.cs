using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI.Library.Models
{
    public class SaleModel
    {
        //this one is used to just send what we need to send to the API
        public List<SaleDetailModel> SaleDetails { get; set; } = new List<SaleDetailModel>();
    }
}
