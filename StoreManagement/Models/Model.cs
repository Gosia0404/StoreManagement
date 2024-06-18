using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManagement.DAL.Entities;
using StoreManagement.DAL.Repositories;
using System.Collections.ObjectModel;
using MySql.Data.MySqlClient;
namespace StoreManagement.Models
{
    public class Model
    {
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
        public ObservableCollection<Clothes> Clothes { get; set; } = new ObservableCollection<Clothes>();
        public ObservableCollection<Order> Orders { get; set; } = new ObservableCollection<Order>();
        private List<Clothes> _cartItems = new List<Clothes>();

        public Model()
        {
            LoadAllData();
        }
        private void LoadAllData()
        {
            var users = UsersRepository.LoadAllUsers();
            foreach (var user in users)
                Users.Add(user);

            var clothes = ClothesRepository.LoadAllClothes();
            foreach (var cloth in clothes)
                Clothes.Add(cloth);

            var orders = OrdersRepository.LoadAllOrders();
            foreach (var order in orders)
                Orders.Add(order);
        }

        public bool AddUserToDB(User user)
        {
            if (!Users.Contains(user) && UsersRepository.AddNewUserToDB(user))
            {
                Users.Add(user);
                return true;
            }
            return false;
        }

        public bool AddClothesToDB(Clothes clothes)
        {
            if (!Clothes.Contains(clothes) && ClothesRepository.AddNewClothesToDB(clothes))
            {
                Clothes.Add(clothes);
                return true;
            }
            return false;
        }
        public bool DeleteClothesFromDB(Clothes clothes)
        {
            if (Clothes.Contains(clothes) && ClothesRepository.DeleteClothesFromDB(clothes))
            {
                Clothes.Remove(clothes);
                return true;
            }
            return false;
        }

        public bool AddOrderToDB(Order order)
        {
            if (!Orders.Contains(order) && OrdersRepository.AddNewOrderToDB(order))
            {
                Orders.Add(order);
                return true;
            }
            return false;
        }

        public List<Clothes> LoadAvailableClothes()
        {
            return ClothesRepository.LoadAvailableClothes();
        }

        public void UpdateClothes(Clothes clothes)
        {
            ClothesRepository.UpdateClothes(clothes);
        }

        public void AddToCart(Clothes clothes)
        {
            _cartItems.Add(clothes);
        }

        public List<Clothes> GetCartItems()
        {
            return _cartItems;
        }

        public void RemoveFromCart(Clothes clothes)
        {
            _cartItems.Remove(clothes);
        }
        public void ClearCart()
        {
            _cartItems.Clear();
        }
        public bool IsUsernameTaken(string username)
        {
            return UsersRepository.IsUsernameInDB(username);
        }
        public bool AddProductToDB(Clothes clothes)
        {
            try
            {
                return ClothesRepository.AddNewClothesToDB(clothes); // Przykładowe wywołanie repozytorium
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding product to database.", ex);
            }
        }

        
        /*private User FindUserById(int id)
        {
            foreach (var u in Users)
            {
                if (u.Id == id) 
                    return u;
            }
            return null;
        }

        private Clothes FindClothesById(int id)
        {
            foreach (var c in Clothes)
            {
                if (c.Id == id) 
                    return c;
            }
            return null;
        }


        public ObservableCollection<Order> GetOrdersByUser(User user)
        {
            var orders = new ObservableCollection<Order>();
            foreach (var o in Orders)
            {
                if (o.IdClient == user.Id)
                    orders.Add(o);
            }
            return orders;
        }

        public bool IsUserInRepo(User user) => Users.Contains(user);

        public bool IsClothesInRepo(Clothes clothes) => Clothes.Contains(clothes);
        public bool IsOrderInRepo(Order order) => Orders.Contains(order);

        public bool AddUserToDB(User user)
        {
            if (!IsUserInRepo(user))
            {
                if (UsersRepository.AddNewUserToDB(user))
                {
                    Users.Add(user);
                    return true;
                }
            }
            return false;
        }

        // mozna dodac do edytowania osoby
        public bool AddClothesToDB(Clothes clothes)
        {
            if (!IsClothesInRepo(clothes))
            {
                if (ClothesRepository.AddNewClothesToDB(clothes))
                {
                    Clothes.Add(clothes);
                    return true;
                }
            }
            return false;
        }

        public bool EditClothesInDB(Clothes clothes, int idClothes)
        {
            if (ClothesRepository.EditClothesInDB(clothes, idClothes))
            {
                for (int i = 0; i < Clothes.Count; i++)
                {
                    if (Clothes[i].Id == idClothes)
                    {
                        clothes.Id = idClothes;
                        Clothes[i] = new Clothes(clothes);
                    }
                }
                return true;
            }
            return false;
        }

        public bool AddOrderToDB(Order order)
        {
            if (!IsOrderInRepo(order))
            {
                if (OrdersRepository.AddNewOrderToDB(order))
                {
                    Orders.Add(order);
                    return true;
                }
            }
            return false;
        }

        //można dodać do edytowania zamówienia*/
    }
}
