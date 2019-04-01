using Proekt2.Data.Models;
using Proekt2.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Proekt2.Models;
using System.IO;

namespace Proekt2.Controller
{
    public class Controller
    {
        private proektContext DataBase;
        private Users test;
        private UserUi Interface;
        public Controller()
        {   
            DataBase = new proektContext();
            test = new Users();
            Interface = new UserUi();
        }
        public void register(string username,string password,string FirstNameOfUser,string LastNameOfUser, string Email)
        {
            Users user = new Users();
            user.Username = username;
            user.Password = password;
            user.FirstNameOfUser = firstNameOfUser;
            user.LastNameOfUser = lastNameOfUser;
            user.Email = email;
            DataBase.Users.Add(user);
            DataBase.SaveChanges();


        }
        public string login(string username,string password)
        {
            
            foreach (var account in DataBase.Users)
            {
                if (account.Username == username && account.Password == password)
                {
                    test.Id = account.Id;
                    test.Username = account.Username;
                    test.Password = account.Password;
                    test.First = account.FirstNameOfUser;
                    test.Last = account.LastNameOfUser;
                    test.Email = account.Email;
                    Interface.IdUser = account.Id;
                    return "You have logged in succesfuly";


                }
                else
                {

                    return "Invalid Login";

                }
                
            }
            return "";

        }
        
        public void ChangePass(string oldPassword,string newPassword)
        {
            if (test.Password == oldPassword)
            {
                test.Password = newPassword;
                DataBase.Users.Update(test);
            }
        }
        public void ChangeMail(string password,string newEmail)
        {
            if (test.Password == password)
            {
                test.Email = newEmail;
                DataBase.Users.Update(test);
            }
        }
        public  void UserUiBackgroundColor(int number)
        {
            
            
            switch (number)
            {
                case 0:
                    Console.Clear();
                   
                    break;
                case 1:
                    Interface.UserUiBackgroundColor = "black";
                    DataBase.UserUi.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 2:
                    Interface.UserUiBackgroundColor = "blue";
                    DataBase.UserUi.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Interface.UserUiBackgroundColor = "cyan";
                    DataBase.UserUi.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                case 4:
                    Interface.UserUiBackgroundColor = "darkblue";
                    DataBase.UserUi.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case 5:
                    Interface.UserUiBackgroundColor = "darkgreen";
                    DataBase.UserUi.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case 6:
                    Interface.UserUiBackgroundColor = "darkmagenta";
                    DataBase.UserUi.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 7:
                    Interface.UserUi = "darkred";
                    DataBase.UserUi.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    break;
                case 8:
                    Interface.UserUiBackgroundColor = "darkyellow";
                    DataBase.UserUi.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case 9:
                    Interface.UserUiBackgroundColor = "gray";
                    DataBase.UserUi.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 10:
                    Interface.UserUiBackgroundColor = "green";
                    DataBase.UserUi.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 11:
                    Interface.UserUiBackgroundColor = "magenta";
                    DataBase.UserUi.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case 12:
                    Interface.UserUiBackgroundColor = "red";
                    DataBase.UserUi.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 13:
                    Interface.UserUiBackgroundColor = "white";
                    DataBase.UserUi.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case 14:
                    Interface.UserUiBackgroundColor = "yellow";
                    DataBase.UserUi.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case 15:
                    Interface.UserUiBackgroundColor = "darkgray";
                    DataBase.UserUi.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
            }   
        }
        public  void UserUiForegroundColor(int number)
        {
            
            
            switch (number)
            {
                case 0:
                    Console.Clear();
                   
                    break;
                case 1:
                    Interface.UserUiForegroundColor = "black";
                    DataBase.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 2:
                    inter.UserUiForegroundColor = "blue";
                    DataBase.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    inter.UserUiForegroundColor = "cyan";
                    DataBase.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 4:
                    inter.UserUiForegroundColor = "darkblue";
                    DataBase.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 5:
                    inter.UserUiForegroundColor = "darkgreen";
                    DataBase.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 6:
                    inter.UserUiForegroundColor = "darkmagenta";
                    DataBase.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 7:
                    inter.UserUiForegroundColor = "darkred";
                    DataBase.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 8:
                    inter.UserUiForegroundColor = "darkyellow";
                    DataBase.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 9:
                    inter.UserUiForegroundColor = "gray";
                    DataBase.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 10:
                    inter.UserUiForegroundColor = "green";
                    DataBase.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 11:
                    inter.UserUiForegroundColor = "magenta";
                    db.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 12:
                    inter.UserUiForegroundColor = "red";
                    DataBase.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 13:
                    inter.UserUiForegroundColor = "white";
                    DataBase.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 14:
                    inter.UserUiForegroundColor = "yellow";
                    db.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 15:
                    inter.UserUiForegroundColor = "darkgray";
                    DataBase.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }   
        }
        public string check_UserUiBackgroundColor()
        {
            return Interface.UserUiBackgroundColor; 
        }
        public string check_UserUiForegroundColor()
        {
            return Interface.UserUiForegroundColor; 
        }
        public void uploader(string path)
        {
            Files fail = new Files();
            var Name = Path.GetFileName(path);
            var put = Path.GetFullPath(path);
            var extension = Path.GetExtension(path);
           var size = new FileInfo(path).Length;
            try
            {
                fail.Ext = extension;
                fail.File = put;
                fail.Size = size.ToString();
                fail.IdUser = test.Id;
                fail.Name = ime;
                db.Files.Add(fail);
                

               
            }
            catch (Exception e) { }
        }
        public List<Files>  showallfiles()
        {
            List<Files> ListOfUsers = new List<Files>();
            foreach (var fail in db.Files)
            {
                if (fail.IdUser == test.Id) { ListOfUsers.Add(fail); }
            }
            return ListOfUsers;


        }
        public Files info(int id)
        {
            Files failat = new Files();
            foreach (var fail in db.Files)
            {
                if(fail.Id == id && fail.IdUser == test.Id) { failat = fail; }
            }
            return failat;
        }
        public Files downloader(int id)
        {
            Files failat = new Files();
            foreach (var fail in db.Files)
            {
                if(fail.Id == id && fail.IdUser == test.Id) { failat = fail; }
            }
            return failat;
        }


    }
}
