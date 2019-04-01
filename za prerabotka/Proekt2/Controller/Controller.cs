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
        private proektContext db;
        private Users test;
        private UserUi inter;
        public Controller()
        {   
            db = new proektContext();
            test = new Users();
            inter = new UserUi();
        }
        public void register(string username,string password,string first,string last,string email)
        {
            Users potrebitel = new Users();
            potrebitel.Username = username;
            potrebitel.Password = password;
            potrebitel.First = first;
            potrebitel.Last = last;
            potrebitel.Email = email;
            db.Users.Add(potrebitel);
            db.SaveChanges();


        }
        public string login(string username,string password)
        {
            
            foreach (var user in db.Users)
            {
                if (user.Username == username && user.Password == password)
                {
                    test.Id = user.Id;
                    test.Username = user.Username;
                    test.Password = user.Password;
                    test.First = user.First;
                    test.Last = user.Last;
                    test.Email = user.Email;
                    inter.IdUser = user.Id;
                    return "Login uspeshen";


                }
                else
                {

                    return "Login neuspeshen";

                }
                
            }
            return "";

        }
        
        public void ChangePass(string old,string nova)
        {
            if (test.Password == old)
            {
                test.Password = nova;
                db.Users.Update(test);
            }
        }
        public void ChangeMail(string password,string novemail)
        {
            if (test.Password == password)
            {
                test.Email = novemail;
                db.Users.Update(test);
            }
        }
        public  void u1(int chislo)
        {
            
            
            switch (chislo)
            {
                case 0:
                    Console.Clear();
                   
                    break;
                case 1:
                    inter.Ui1 = "black";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 2:
                    inter.Ui1 = "blue";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    inter.Ui1 = "cyan";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                case 4:
                    inter.Ui1 = "darkblue";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case 5:
                    inter.Ui1 = "darkgreen";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case 6:
                    inter.Ui1 = "darkmagenta";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 7:
                    inter.Ui1 = "darkred";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    break;
                case 8:
                    inter.Ui1 = "darkyellow";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case 9:
                    inter.Ui1 = "gray";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 10:
                    inter.Ui1 = "green";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 11:
                    inter.Ui1 = "magenta";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case 12:
                    inter.Ui1 = "red";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 13:
                    inter.Ui1 = "white";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case 14:
                    inter.Ui1 = "yellow";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case 15:
                    inter.Ui1 = "darkgray";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
            }   
        }
        public  void u2(int chislo)
        {
            
            
            switch (chislo)
            {
                case 0:
                    Console.Clear();
                   
                    break;
                case 1:
                    inter.Ui2= "black";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 2:
                    inter.Ui2 = "blue";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    inter.Ui2 = "cyan";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                case 4:
                    inter.Ui2 = "darkblue";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case 5:
                    inter.Ui2 = "darkgreen";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case 6:
                    inter.Ui2 = "darkmagenta";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 7:
                    inter.Ui2 = "darkred";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    break;
                case 8:
                    inter.Ui2 = "darkyellow";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case 9:
                    inter.Ui2 = "gray";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 10:
                    inter.Ui2 = "green";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 11:
                    inter.Ui2 = "magenta";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case 12:
                    inter.Ui2 = "red";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 13:
                    inter.Ui2 = "white";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case 14:
                    inter.Ui2 = "yellow";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case 15:
                    inter.Ui2 = "darkgray";
                    db.UserUi.Update(inter);
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
            }   
        }
        public string check_u1()
        {
            return inter.Ui1; 
        }
        public string check_u2()
        {
            return inter.Ui2; 
        }
        public void uploader(string path)
        {
            Files fail = new Files();
            var ime = Path.GetFileName(path);
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
            List<Files> spisuk = new List<Files>();
            foreach (var fail in db.Files)
            {
                if (fail.IdUser == test.Id) { spisuk.Add(fail); }
            }
            return spisuk;


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
