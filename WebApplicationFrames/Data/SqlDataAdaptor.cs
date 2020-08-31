using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace WebApplicationFrames.Data
{
    public class SqlDataAdaptor
    {
        Model1 db;
        public SqlDataAdaptor()
        {
            db = new Model1();
            


        }

        public List<Modal> GetAll()
        {
            return db.Modals.ToList();
        }
      
    }
}