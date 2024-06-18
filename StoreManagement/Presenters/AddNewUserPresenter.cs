using MySql.Data.MySqlClient;
using StoreManagement.Views.StartViews;
using StoreManagement.DAL;
using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManagement.DAL.Entities;

namespace StoreManagement.Presenters
{
    public class AddNewUserPresenter
    {
        private IAddNewUserView _addNewUserView;
        private Model _model;
        public AddNewUserPresenter(IAddNewUserView view, Model model)
        {
            _addNewUserView = view;
            _model = model;
            _addNewUserView.AddUser += Create;

        }
        public void Create(object sender, EventArgs e)
        {
            string name = _addNewUserView.UserName;
            string surname = _addNewUserView.Surname;
            string address = _addNewUserView.Address;
            string phone = _addNewUserView.Phone;
            string username = _addNewUserView.Username;
            string password = _addNewUserView.Password;
            string type = "client";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                _addNewUserView.ShowMessage("All fields must be completed.");
                return;
            }
            if (_model.IsUsernameTaken(username))
            {
                _addNewUserView.ShowMessage("Username is already taken.");
                return;
            }

            User user = new User
            {
                Name = name,
                Surname = surname,
                Address = address,
                Phone = phone,
                Username = username,
                Password = password,
                Type = type
            };

            if (_model.AddUserToDB(user))
            {
                _addNewUserView.ShowMessage("A new user has been added.");
            }
            else
            {
                _addNewUserView.ShowMessage("Error adding.");
            }
        }
    }
}
