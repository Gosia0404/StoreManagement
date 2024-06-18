using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StoreManagement.DAL.Entities
{
    public class Clothes
    {
        #region Properties
        public int? Id { get; set; } 
        public string Name { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }
        public string Colour { get; set; }
        public uint Price { get; set; }
        public uint Amount { get; set; }
        /* 
         * uint: 
         * Typ całkowitoliczbowy bez znaku, który przechowuje tylko liczby dodatnie. 
         * Używany, gdy jesteś pewny, że liczby nie będą ujemne, 
         
         * int?:  
         * Typ Nullable, który może przechowywać wartości całkowitoliczbowe lub null. 
         * Używany, gdy istnieje możliwość, że wartość może być nieznana lub niezdefiniowana, 
         * np. Id (identyfikator), który może być null przed zapisaniem rekordu w bazie danych.
         */
        #endregion

        #region Constructors
        public Clothes() { }
        public Clothes(MySqlDataReader reader)
        {
            Id = int.Parse(reader["Id"].ToString());
            Name = reader["Name"].ToString();
            Category = reader["Category"].ToString();
            Size = reader["Size"].ToString();
            Colour = reader["Colour"].ToString();
            Price = uint.Parse(reader["Price"].ToString());
            Amount = uint.Parse(reader["Amount"].ToString());
        }
        /*//konstruktor tworzacy obiekt nie dodany jeszcze do bazy z id pustym
        public Clothes(string name, string category, string size, string colour, uint price, uint amount)
        {
            Id = null;
            Name = name.Trim();
            Category = category.Trim();
            Size = size.Trim();
            Colour = colour.Trim();
            Price = price;
            Amount = amount;
        }

        // Konstruktor kopiujący
        public Clothes(Clothes clothes)
        {
            Id = clothes.Id;
            Name = clothes.Name;
            Category = clothes.Category;
            Size = clothes.Size;
            Colour = clothes.Colour;
            Price = clothes.Price;
            Amount = clothes.Amount;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Name} ({Category}) - Size: {Size}, Colour: {Colour}, Price: ${Price}, Amount: {Amount}";
        }*/
        //metoda generuje string dla INSERT INTO (Name, Category, Size, Colour, Price, Amount)
        public string ToInsert()
        {
            return $"('{Name}', '{Category}', '{Size}', '{Colour}', {Price}, {Amount})";
        }
        //dzięki przeciążeniu tej metody Contains w liście sprawdzi czy dany obiekt do niej należy
        /*public override bool Equals(object obj)
        {
            var clothes = obj as Clothes;
            if (clothes is null) return false;
            if (Name.ToLower() != clothes.Name.ToLower()) return false;
            if (Category.ToLower() != clothes.Category.ToLower()) return false;
            if (Size.ToLower() != clothes.Size.ToLower()) return false;
            if (Colour.ToLower() != clothes.Colour.ToLower()) return false;
            if (Price != clothes.Price) return false;
            if (Amount != clothes.Amount) return false;
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }*/
        #endregion
    }
}
