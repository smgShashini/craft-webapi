/*
 * Date   : 14/07/2021
 * Author : Shashini Maheshika Gunawardhana
 * Description : Product model with all properties 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftWebApi.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int Rate { get; set; }
        public string  MainImage { get; set; }
        public double Price  { get; set; }
        public int AvailableItems { get; set; }
    }
}
