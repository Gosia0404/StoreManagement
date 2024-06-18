using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StoreManagement.DAL.Entities
{
    public class Order
    {
        #region Properties
        public int? Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int IdClient { get; set; }
        public int Thing1 { get; set; }
        public int? Thing2 { get; set; }
        public int? Thing3 { get; set; }
        public int? Thing4 { get; set; }
        public int? Thing5 { get; set; }

        // Możemy także zdefiniować właściwości nawigacyjne, jeśli chcemy
        /*public User Client { get; set; }
        public Clothes Item1 { get; set; }
        public Clothes Item2 { get; set; }
        public Clothes Item3 { get; set; }
        public Clothes Item4 { get; set; }
        public Clothes Item5 { get; set; }*/
        #endregion

        #region Constructors
        public Order() { }
        public Order(MySqlDataReader reader)
        {
            Id = int.Parse(reader["Id"].ToString());
            OrderDate = DateTime.Parse(reader["OrderDate"].ToString());
            IdClient = int.Parse(reader["IdClient"].ToString());
            Thing1 = int.Parse(reader["Thing1"].ToString());
            Thing2 = reader["Thing2"] == DBNull.Value ? (int?)null : int.Parse(reader["Thing2"].ToString());
            Thing3 = reader["Thing3"] == DBNull.Value ? (int?)null : int.Parse(reader["Thing3"].ToString());
            Thing4 = reader["Thing4"] == DBNull.Value ? (int?)null : int.Parse(reader["Thing4"].ToString());
            Thing5 = reader["Thing5"] == DBNull.Value ? (int?)null : int.Parse(reader["Thing5"].ToString());
        }

        /*public Order(DateTime orderDate, int idClient, int thing1, int? thing2 = null, int? thing3 = null, int? thing4 = null, int? thing5 = null)
        {
            Id = null;
            OrderDate = orderDate;
            IdClient = idClient;
            Thing1 = thing1;
            Thing2 = thing2;
            Thing3 = thing3;
            Thing4 = thing4;
            Thing5 = thing5;
        }

        // Konstruktor kopiujący
        public Order(Order order)
        {
            Id = order.Id;
            OrderDate = order.OrderDate;
            IdClient = order.IdClient;
            Thing1 = order.Thing1;
            Thing2 = order.Thing2;
            Thing3 = order.Thing3;
            Thing4 = order.Thing4;
            Thing5 = order.Thing5;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Order ID: {Id}, Date: {OrderDate}, Client ID: {IdClient}, Things: [{Thing1}, {Thing2}, {Thing3}, {Thing4}, {Thing5}]";
        }*/

        public string ToInsert()
        {
            return $"('{OrderDate:yyyy-MM-dd HH:mm:ss}', {IdClient}, {Thing1}, {Thing2}, {Thing3}, {Thing4}, {Thing5})";
        }

        /*public override bool Equals(object obj)
        {
            var order = obj as Order;
            if (order is null) return false;
            if (OrderDate != order.OrderDate) return false;
            if (IdClient != order.IdClient) return false;
            if (Thing1 != order.Thing1) return false;
            if (Thing2 != order.Thing2) return false;
            if (Thing3 != order.Thing3) return false;
            if (Thing4 != order.Thing4) return false;
            if (Thing5 != order.Thing5) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }*/
        #endregion
    }
}
