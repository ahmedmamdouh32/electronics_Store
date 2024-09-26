using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Product
    {
        /*
         * 
         * 	[Name] [nchar](30) NOT NULL,
	[SerialNumber] [nchar](10) NULL,
	[Price] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Profit] [float] NOT NULL,
	[InStock] [bit] NULL
        */

        public string Name {  get; set; }
        public string SerialNumber { get; set; }
        public decimal Price { set; get; }
        public int Quantity { set; get; }
        public decimal Profit { set; get; }
        public Nullable<bool> InStock {  set; get; }

    }
}
