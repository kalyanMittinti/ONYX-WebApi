using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onxy.models;
using Onyx.Common.Helpers;

namespace Onxy.DataAccess

{
    public class ProductRepo : IProductRepo
    {

        public void Create(Product item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(int id)
        {
            var outParam = new SqlParameter("@ReturnCode", SqlDbType.NVarChar, 20)
            {
                Direction = ParameterDirection.Output
            };
            SqlParameter[] param = {
                new SqlParameter("@Id",id),
                //new SqlParameter("@Name",model.Name),
                //new SqlParameter("@EmailId",model.EmailId),
                //new SqlParameter("@Mobile",model.Mobile),
                //new SqlParameter("@Address",model.Address),
                outParam
            };

            DataTable dt = SQLHelper.SQLHelper_ExecuteReader("", param);
            List<Product> lst = new List<Product>();
            foreach (DataRow row in dt.Rows)
            {
                lst.Add(new Product
                {
                    //ProductID = Convert.ToInt32(row["RecordId"]),
                    Productname = row["Productname"].ToString()
                });
            }


            return lst;



        }

        public Product GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, Product item)
        {
            throw new NotImplementedException();
        }



    }
    // Interface Creation
    public interface IProductRepo
    {

        void Create(Product item);
        Product GetById(int Id);
        List<Product> GetAll(int id);
        void Update(int Id, Product item);
        void Delete(int Id);
    }
}
