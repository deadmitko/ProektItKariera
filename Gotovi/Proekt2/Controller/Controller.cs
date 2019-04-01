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
        private ProjectContext DataBase;
        private Users test;
        private UserInterface Interface;
        public Controller()
        {   
            DataBase = new ProjectContext();
            test = new Users();
            Interface = new UserInterface();
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
        public void ChangeMail(string password,string novemail)
        {
            if (test.Password == password)
            {
                test.Email = newEmail;
                DataBase.Users.Update(test);
            }
        }
        public  void UserInterfaceBackgroundColor(int number)
        {
            
            
            switch (number)
            {
                case 0:
                    Console.Clear();
                   
                    break;
                case 1:
                    Interface.UserInterfaceBackgroundColor = "black";
                    DataBase.UserInterface.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 2:
                    Interface.UserInterfaceBackgroundColor = "blue";
                    DataBase.UserInterface.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Interface.UserInterfaceBackgroundColor = "cyan";
                    DataBase.UserInterface.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                case 4:
                    Interface.UserInterfaceBackgroundColor = "darkblue";
                    DataBase.UserInterface.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case 5:
                    Interface.UserInterfaceBackgroundColor = "darkgreen";
                    DataBase.UserInterface.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case 6:
                    Interface.UserInterfaceBackgroundColor = "darkmagenta";
                    DataBase.UserInterface.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 7:
                    Interface.UserInterface = "darkred";
                    DataBase.UserInterface.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    break;
                case 8:
                    Interface.UserInterfaceBackgroundColor = "darkyellow";
                    DataBase.UserInterface.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case 9:
                    Interface.UserInterfaceBackgroundColor = "gray";
                    DataBase.UserInterface.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 10:
                    Interface.UserInterfaceBackgroundColor = "green";
                    DataBase.UserInterface.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 11:
                    Interface.UserInterfaceBackgroundColor = "magenta";
                    DataBase.UserInterface.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case 12:
                    Interface.UserInterfaceBackgroundColor = "red";
                    DataBase.UserInterface.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 13:
                    Interface.UserInterfaceBackgroundColor = "white";
                    DataBase.UserInterface.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case 14:
                    Interface.UserInterfaceBackgroundColor = "yellow";
                    DataBase.UserInterface.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case 15:
                    Interface.UserInterfaceBackgroundColor = "darkgray";
                    DataBase.UserInterface.Update(Interface);
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
            }   
        }
        public  void UserInterfaceForegroundColor(int number)
        {
            
            
            switch (number)
            {
                case 0:
                    Console.Clear();
                   
                    break;
                case 1:
                    Interface.UserInterfaceForegroundColor = "black";
                    DataBase.UserInterface.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 2:
                    inter.UserInterfaceForegroundColor = "blue";
                    DataBase.UserInterface.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    inter.UserInterfaceForegroundColor = "cyan";
                    DataBase.UserInterface.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 4:
                    inter.UserInterfaceForegroundColor = "darkblue";
                    DataBase.UserInterface.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 5:
                    inter.UserInterfaceForegroundColor = "darkgreen";
                    DataBase.UserInterface.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 6:
                    inter.UserInterfaceForegroundColor = "darkmagenta";
                    DataBase.UserInterface.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 7:
                    inter.UserInterfaceForegroundColor = "darkred";
                    DataBase.UserInterface.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 8:
                    inter.UserInterfaceForegroundColor = "darkyellow";
                    DataBase.UserInterface.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 9:
                    inter.UserInterfaceForegroundColor = "gray";
                    DataBase.UserInterface.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 10:
                    inter.UserInterfaceForegroundColor = "green";
                    DataBase.UserInterface.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 11:
                    inter.UserInterfaceForegroundColor = "magenta";
                    db.UserInterface.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 12:
                    inter.UserInterfaceForegroundColor = "red";
                    DataBase.UserInterface.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 13:
                    inter.UserInterfaceForegroundColor = "white";
                    DataBase.UserUi.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 14:
                    inter.UserInterfaceForegroundColor = "yellow";
                    db.UserInterface.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 15:
                    inter.UserInterfaceForegroundColor = "darkgray";
                    DataBase.UserInterface.Update(Interface);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }   
        }
        public string check_userInterfaceBackgroundColor()
        {
            return Interface.UserInterfaceBackgroundColor; 
        }
        public string check_userInterfaceForegroundColor()
        {
            return Interface.UserInterfaceForegroundColor; 
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
