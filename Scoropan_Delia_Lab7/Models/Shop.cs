using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoropan_Delia_Lab7.Models
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
    public string ShopName { get; set; }
    public string Adress { get; set; }
    public string ShopDetails
    {
        get
        {
            return ShopName + ""+Adress;} }
      [OneToMany]
 public List<ShopList> ShopLists { get; set; }

}

