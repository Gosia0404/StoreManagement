using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace StoreManagement.DAL.Entities
{
    public class User
    {
        #region Properties
        public int? Id { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        #endregion

        #region Constructors
        public User() { }
        public User(MySqlDataReader reader)
        {
            Id = int.Parse(reader["Id"].ToString());
            Name = reader["Name"].ToString();
            Surname = reader["Surname"].ToString();
            Address = reader["Address"].ToString();
            Phone = reader["Phone"].ToString();
            Username = reader["Username"].ToString();
            Password = reader["Password"].ToString();
            Type = reader["Type"].ToString();
        }
        /*public User(string name, string surname, string address, string phone, string username, string password, string type)
        {
            Id = null;
            Name = name.Trim();
            Surname = surname.Trim();
            Address = address?.Trim(); // Address może być null
            Phone = phone.Trim();
            Username = username.Trim();
            Password = password.Trim();
            Type = type?.Trim(); // Type może być null
        }
        // Konstruktor kopiujący
        public User(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Surname = user.Surname;
            Address = user.Address;
            Phone = user.Phone;
            Username = user.Username;
            Password = user.Password;
            Type = user.Type;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Name} {Surname}, Address: {Address}, Phone: {Phone}, Username: {Username}, Type: {Type}";
        }*/
        public string ToInsert()
        {
            return $"('{Name}', '{Surname}', '{Address}', '{Phone}', '{Username}', '{Password}', '{Type}')";
        }
        /*public override bool Equals(object obj)
        {
            var user = obj as User;
            if (user is null) return false;
            if (Name.ToLower() != user.Name.ToLower()) return false;
            if (Surname.ToLower() != user.Surname.ToLower()) return false;
            if (Address?.ToLower() != user.Address?.ToLower()) return false;
            if (Phone != user.Phone) return false;
            if (Username.ToLower() != user.Username.ToLower()) return false;
            if (Password != user.Password) return false;
            if (Type?.ToLower() != user.Type?.ToLower()) return false;
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }*/
        #endregion
    }
}
