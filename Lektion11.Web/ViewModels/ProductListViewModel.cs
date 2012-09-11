using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion11.Data.Entities;
using Lektion11.Web.ViewModels;

namespace Lektion11.Web.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}