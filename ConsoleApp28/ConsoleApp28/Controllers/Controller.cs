using ConsoleApp28.Data;
using ConsoleApp28.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Favourites = ConsoleApp28.Data.Models.Favourites;
using Receipts = ConsoleApp28.Data.Models.Receipts;
using Users = ConsoleApp28.Data.Models.Users;

namespace ConsoleApp28.Controllers
{

    public class Controller
    {
        private proektContext db;
        public Users user;
        public Controller()
        {
            db = new proektContext();
            user = new Users();
        }
        public void register(string username, string password)
        {
            if (db.Users.Where(x => x.Username == username).SingleOrDefault() == null)
            {
                user.Username = username;
                user.Password = password;

                Console.WriteLine(user.Id);
                db.Users.Add(user);
                Console.WriteLine(user.Id);
                db.SaveChanges();
                Console.WriteLine(user.Id);
                UserUi test = new UserUi();
                test.IdUser = user.Id;
                db.UserUi.Add(test);
                db.SaveChanges();
            }
            
            


        }
        public string login(string username, string password)
        {
            var user = db.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            if (user != null)
            {
                this.user.Id = user.Id;
                user.Username = user.Username;
                user.Password = user.Password;
                return "Login uspeshen";
            }
            else
            {
                return "Login neuspeshen";
            }
        }
    
        public void ChangePass(string old, string nova)
        {
            var user = db.Users.SingleOrDefault(x => x.Id == this.user.Id);
            if (user.Password == old)
            {
                user.Password = nova;
                
                db.SaveChanges();
            }
        }
        public List<Receipts> Getall()
        {
            List<Receipts> test = new List<Receipts>();
           
            
                foreach (var item in db.Receipts)
                {
                    test.Add(item);
                }                        
            return test;
        }
        public Receipts Get(int id)
        {
            Receipts test = db.Receipts.Where(x=>x.Id==id).Single();
            
           
            
                                     
            return test;
        }


        public void u1(int chislo)
        {

            var interfa = db.UserUi.SingleOrDefault(x => x.IdUser == user.Id);
            switch (chislo)
            {
                case 0:
                    Console.Clear();

                    break;
                case 1:
                    interfa.Ui1 = "black";

                    Console.BackgroundColor = ConsoleColor.Black;

                    break;
                case 2:
                    interfa.Ui1 = "blue";

                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    interfa.Ui1 = "cyan";

                    Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                case 4:
                    interfa.Ui1 = "darkblue";

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case 5:
                    interfa.Ui1 = "darkgreen";

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case 6:
                    interfa.Ui1 = "darkmagenta";

                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 7:
                    interfa.Ui1 = "darkred";

                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    break;
                case 8:
                    interfa.Ui1 = "darkyellow";

                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case 9:
                    interfa.Ui1 = "gray";

                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 10:
                    interfa.Ui1 = "green";

                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 11:
                    interfa.Ui1 = "magenta";

                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case 12:
                    interfa.Ui1 = "red";

                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 13:
                    interfa.Ui1 = "white";

                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case 14:
                    interfa.Ui1 = "yellow";

                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case 15:
                    interfa.Ui1 = "darkgray";

                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
            }
            db.SaveChanges();
        }
        public void u2(int chislo)
        {

            var interfa = db.UserUi.SingleOrDefault(x => x.IdUser == user.Id);
            switch (chislo)
            {
                case 0:
                    Console.Clear();

                    break;
                case 1:
                    interfa.Ui2 = "black";

                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 2:
                    interfa.Ui2 = "blue";

                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    interfa.Ui2 = "cyan";

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 4:
                    interfa.Ui2 = "darkblue";

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 5:
                    interfa.Ui2 = "darkgreen";

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 6:
                    interfa.Ui2 = "darkmagenta";

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 7:
                    interfa.Ui2 = "darkred";

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 8:
                    interfa.Ui2 = "darkyellow";

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 9:
                    interfa.Ui2 = "gray";

                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 10:
                    interfa.Ui2 = "green";

                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 11:
                    interfa.Ui2 = "magenta";

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 12:
                    interfa.Ui2 = "red";

                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 13:
                    interfa.Ui2 = "white";

                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 14:
                    interfa.Ui2 = "yellow";

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 15:
                    interfa.Ui2 = "darkgray";

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }
            db.SaveChanges();
        }
        public string check_u1()
        {
            var interfa = db.UserUi.SingleOrDefault(x => x.IdUser == user.Id);
            return interfa.Ui1;
        }
        public string check_u2()
        {
            var interfa = db.UserUi.SingleOrDefault(x => x.IdUser == user.Id);
            return interfa.Ui2;
        }
        public List<Comments> GetComments(int id)
        {
            List<Comments> GetComments = db.Comments.Where(x=>x.ReceiptId ==id).ToList();
            return GetComments;
        }
        public void AddPublic(string name,string discription,int Category)
        {
            Receipts recepta = new Receipts();
            recepta.Name = name;
            recepta.Description = discription;
            switch (Category)
            {


                case 1:
                    recepta.Category = "Desert";
                    break;
                case 2:
                    recepta.Category = "Salata";
                    break;
                case 3:
                    recepta.Category = "Supa";
                    break;
                case 4:
                    recepta.Category = "Studena supa";
                    break;
                case 5:
                    recepta.Category = "Osnovno qstie";
                    break;
                case 6:
                    recepta.Category = "Morski darove";
                    break;
                default:
                    recepta.Category = "Drugo";
                    break;
            }
            recepta.AuthorId = user.Id;
            db.Receipts.Add(recepta);
            db.SaveChanges();
        }
        public void AddPersonal(string name,string discription)
        {
            Personals recepta = new Personals();
            recepta.Name = name;
            recepta.Description = discription;
            recepta.IdUser = user.Id;
            db.Personals.Add(recepta);
            db.SaveChanges();
        }
        public void AddComments(int id,string text)
        {
            Comments komentar = new Comments();
            Console.WriteLine(komentar.Id);
            
            db.Comments.Add(komentar);
            db.SaveChanges();
            Console.WriteLine(komentar.Id);
            komentar.Text = text;
            komentar.ReceiptId = id;
            komentar.AuthorId = user.Id;
            db.SaveChanges();
        }
        public void AddToFavourite(int id)
        {
            var recepta = db.Receipts.Where(x => x.Id == id).Single();
            Favourites lubim = new Favourites();
            lubim.Description = recepta.Description;
            lubim.Name = recepta.Name;
            lubim.IdUser = user.Id;
            db.Favourites.Add(lubim);
            db.SaveChanges();
        }
        public List<Favourites> GetFavourites()
        {
            List<Favourites> fav = db.Favourites.Where(x => x.IdUser == user.Id).ToList();
            return fav;
        }
        public List<Personals> GetPersonals()
        {
            List<Personals> fav = db.Personals.Where(x => x.IdUser == user.Id).ToList();
            return fav;
        }
        public Favourites GetOnlyOneFav(int id)
        {
            var fav =db.Favourites.Where(x => x.Id == id && x.IdUser == user.Id).Single();
            return fav;


        }
        public Personals GetOnlyOnePer(int id)
        {
            var fav =db.Personals.Where(x => x.Id == id && x.IdUser == user.Id).Single();
            return fav;
        }
        public void RemoveFav(int id)
        {
            var fav =db.Favourites.Where(x => x.Id == id && x.IdUser == user.Id).Single();

            db.Favourites.Remove(fav);
            db.SaveChanges();

        }
        public void RemovePer(int id)
        {
            var fav =db.Personals.Where(x => x.Id == id && x.IdUser == user.Id).Single();

            db.Personals.Remove(fav);
            db.SaveChanges();

        }
        public Users GetAuthor(int id)
        {
           return db.Users.Where(x => x.Id == id).Single();



        }

        
    }
}
