using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;

namespace Inventory_management_System

{
     
    public class Connection
    {

        public OleDbConnection conn = new OleDbConnection();

              
        
        //ConfigurationManager.ConnectionStrings["conn"].ToString()
        
    }
}
