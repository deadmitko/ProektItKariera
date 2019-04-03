
using ConsoleApp28.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp28.Display
{
    public class View
    {
        private Controller control;
        public View()
        {
            control = new Controller();
        }
        public void register()
        {

            Console.WriteLine("Register");
            Console.Write("Username:");
            var username = Console.ReadLine();
            Console.Write("Password:");
            var password = Console.ReadLine();
           
            control.register(username, password);
        }
        public void login()
        {
            Console.WriteLine("Login");
            Console.Write("Username:");
            var username = Console.ReadLine();
            Console.Write("Password:");
            var password = Console.ReadLine();
            control.login(username, password);
        }
        public void accountmenu()
        {
            Console.Clear();
            Console.WriteLine("1.Change Password");
            
            Console.WriteLine("2.Change UI");
            Console.WriteLine("3.Back");
            switch (int.Parse(Console.ReadLine()))
            {
               
                case 1:
                    Console.Write("Enter your new password");
                    var newpass = Console.ReadLine();
                    Console.Write("Enter your old password");
                    var password2 = Console.ReadLine();
                    control.ChangePass(password2, newpass);
                    break;
                case 3:
                    Console.Clear();
                    Menu();
                    break;
                case 2:
                    Console.Clear();
                    changeui();
                    break;
            }

        }
        public void enforce_u2()
        {
            switch (control.check_u2())
            {
                case "black":

                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "blue":

                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "cyan":

                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "darkblue":

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "darkgreen":

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "darkmagenta":

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "darkred":

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "darkyellow":

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "gray":

                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "green":

                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "magenta":

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "red":

                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "white":

                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "yellow":

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "darkgray":

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }




        }
        public void enforce_u1()
        {
            switch (control.check_u1())
            {
                case "black":

                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "blue":

                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case "cyan":

                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case "darkblue":

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case "darkgreen":

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case "darkmagenta":

                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "darkred":

                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    break;
                case "darkyellow":

                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case "gray":

                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case "green":

                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case "magenta":

                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case "red":

                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "white":

                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case "yellow":

                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case "darkgray":

                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
            }
        }
        public void changeui()
        {

            Console.WriteLine("Current background: " + control.check_u1());
            Console.WriteLine("Current foreground: " + control.check_u2());
            Console.WriteLine("1.Background");
            Console.WriteLine("2.Foreground");
            Console.WriteLine("3.Back");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.Clear();
                    u1();

                    break;
                case 2:
                    Console.Clear();
                    u2();

                    break;
                case 3:
                    Console.Clear();
                    accountmenu();
                    break;




            }



        }
        public void u1()
        {
            Console.WriteLine("0.Back");
            Console.WriteLine("1.Black");
            Console.WriteLine("2.Blue");
            Console.WriteLine("3.Cyan");
            Console.WriteLine("4.Dark Blue");
            Console.WriteLine("5.Dark green");
            Console.WriteLine("6.Dark magenta");
            Console.WriteLine("7.Dark red");
            Console.WriteLine("8.Dark yellow");
            Console.WriteLine("9.gray");
            Console.WriteLine("10.green");
            Console.WriteLine("11.magenta");
            Console.WriteLine("12.red");
            Console.WriteLine("13.white");
            Console.WriteLine("14.yellow");
            Console.WriteLine("15.Dark gray");

            switch (int.Parse(Console.ReadLine()))
            {
                case 0:
                    Console.Clear();
                    changeui();
                    break;
                case 1:
                    control.u1(1);
                    enforce_u1();
                    break;
                case 2:
                    control.u1(2);
                    enforce_u1();
                    break;
                case 3:
                    control.u1(3);
                    enforce_u1();
                    break;
                case 4:
                    control.u1(4);
                    enforce_u1();
                    break;
                case 5:
                    control.u1(5);
                    enforce_u1();
                    break;
                case 6:
                    control.u1(6);
                    enforce_u1();
                    break;
                case 7:
                    control.u1(7);
                    enforce_u1();
                    break;
                case 8:
                    control.u1(8);
                    enforce_u1();
                    break;
                case 9:
                    control.u1(9);
                    enforce_u1();
                    break;
                case 10:
                    control.u1(10);
                    enforce_u1();
                    break;
                case 11:
                    control.u1(11);
                    enforce_u1();
                    break;
                case 12:
                    control.u1(12);
                    enforce_u1();
                    break;
                case 13:
                    control.u1(2);
                    enforce_u1();
                    break;
                case 14:
                    control.u1(14);
                    enforce_u1();
                    break;
                case 15:
                    control.u1(15);
                    enforce_u1();
                    break;
            }
            Console.Clear();
            changeui();
        }
        public void u2()
        {
            Console.WriteLine("0.Back");
            Console.WriteLine("1.Black");
            Console.WriteLine("2.Blue");
            Console.WriteLine("3.Cyan");
            Console.WriteLine("4.Dark Blue");
            Console.WriteLine("5.Dark green");
            Console.WriteLine("6.Dark magenta");
            Console.WriteLine("7.Dark red");
            Console.WriteLine("8.Dark yellow");
            Console.WriteLine("9.gray");
            Console.WriteLine("10.green");
            Console.WriteLine("11.magenta");
            Console.WriteLine("12.red");
            Console.WriteLine("13.white");
            Console.WriteLine("14.yellow");
            Console.WriteLine("15.Dark gray");

            switch (int.Parse(Console.ReadLine()))
            {
                case 0:
                    Console.Clear();
                    changeui();
                    break;
                case 1:
                    control.u2(1);
                    enforce_u2();
                    break;
                case 2:
                    control.u2(2);
                    enforce_u2();
                    break;
                case 3:
                    control.u2(3);
                    enforce_u2();
                    break;
                case 4:
                    control.u2(4);
                    enforce_u2();
                    break;
                case 5:
                    control.u2(5);
                    enforce_u2();
                    break;
                case 6:
                    control.u2(6);
                    enforce_u2();
                    break;
                case 7:
                    control.u2(7);
                    enforce_u2();
                    break;
                case 8:
                    control.u2(8);
                    enforce_u2();
                    break;
                case 9:
                    control.u2(9);
                    enforce_u2();
                    break;
                case 10:
                    control.u2(10);
                    enforce_u2();
                    break;
                case 11:
                    control.u2(11);
                    enforce_u2();
                    break;
                case 12:
                    control.u2(12);
                    enforce_u2();
                    break;
                case 13:
                    control.u2(13);
                    enforce_u2();
                    break;
                case 14:
                    control.u2(14);
                    enforce_u2();
                    break;
                case 15:
                    control.u2(15);
                    enforce_u2();
                    break;
            }
            Console.Clear();
            changeui();
        }
        public void Menu()
        {
            Console.Title = "ReceptaBook";
            if (control.user.Id == 0)
            {
                Console.WriteLine("1.Register");
                Console.WriteLine("2.Login");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 2:
                        while (control.user.Id == 0)
                        {
                            Console.Clear();
                            login();
                            
                        }
                        break;
                    case 1:
                        while (control.user.Id == 0)
                        {
                            register();
                            Console.Clear();
                        }
                        break;
                }
            }
            else
            {
                Console.Clear();
                if (control.user.Id != 0)
                {
                    enforce_u1();
                    enforce_u2();
                    Console.WriteLine("Welcome!!!");
                    Console.WriteLine("1.Account settings");
                    Console.WriteLine("2.Receipts");
                    Console.WriteLine("3.Exit");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Console.Clear();
                            accountmenu();
                            break;
                        case 2:
                            Console.Clear();
                            ReceiptsMenu();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                    }
                }
                else
                {
                    while (control.user.Id == 0)
                    {
                        login();
                    }
                }
            }
            



        }
        public void ReceiptsMenu()
        {
            Console.WriteLine("1.Public");
            Console.WriteLine("2.My Favourite");
            Console.WriteLine("3.My Personal");
            Console.WriteLine("4.Back");
            
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.Clear();
                    publicrecepts();
                    break;
                case 2:
                    Console.Clear();
                    myfavourite();
                    break;
                case 3:
                    mypersonal();
                    break;
                case 4:
                   Console.Clear();
                    Menu();
                    break;
            }









        }

        private void mypersonal()
        {

            personalmenu();
        }

        private void myfavourite()
        {
            favmenu();
        }
        private static string ReadLine()
        {
            Stream inputStream = Console.OpenStandardInput(500);
            byte[] bytes = new byte[500];
            int outputLength = inputStream.Read(bytes, 0, 500);
            //Console.WriteLine(outputLength);
            char[] chars = Encoding.UTF7.GetChars(bytes, 0, outputLength);
            return new string(chars);
        }
        private void publicrecepts()
        {
            Console.Clear();
            Console.WriteLine("0.Back");
            Console.WriteLine("-1.Add");
           
            foreach (var item in control.Getall())
            {
                Console.WriteLine(item.Id+". Name:"+item.Name+"  Category:"+item.Category);
            }
            var selected = int.Parse(Console.ReadLine());
            switch (selected)
            {
                case 0:
                    Console.Clear();
                    ReceiptsMenu();
                    break;
                case -1:
                    string name;
                    string description;
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Description: ");
                    description = ReadLine();
                    Console.WriteLine("Category:");
                    Console.WriteLine( "1.Desert");
                    Console.WriteLine("2.Salata");
                    Console.WriteLine("3.Supa");
                    Console.WriteLine("4.Studena supa");
                    Console.WriteLine("5.Osnovno qstie");
                    Console.WriteLine("6.Morski darove");
                    Console.WriteLine("7.Drugo");
                    control.AddPublic(name,description,int.Parse(Console.ReadLine()));
                    Console.Clear();
                    ReceiptsMenu();
                    break;
                default:
                    Console.WriteLine("Name: "+ control.Get(selected).Name);
                    Console.WriteLine("Description: "+ control.Get(selected).Description);
                    Console.WriteLine("Category: "+ control.Get(selected).Category);
                    ShowCommets(selected);
                    Console.WriteLine("0.Back");
                    Console.WriteLine("1.Add Comments");
                    Console.WriteLine("2.Add to favourite");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine(selected);
                            AddComments(selected);
                            Console.Clear();
                            publicrecepts();
                            break;
                        case 2:
                            control.AddToFavourite(selected);
                            Console.Clear();
                            publicrecepts();
                            break;
                        case 0:
                            Console.Clear();
                            publicrecepts();
                            break;


                    }                  
                    break;

            }

        }
        private void favmenu()
        {
            Console.Clear();
            Console.WriteLine("0.Back");
            
           
            foreach (var item in control.GetFavourites())
            {
                Console.WriteLine(item.Id+". Name:"+item.Name);
            }
            
            var selected = int.Parse(Console.ReadLine());
            switch (selected)
            {
                case 0:
                    Console.Clear();
                    ReceiptsMenu();
                    break;          
                default:
                    Console.Clear();
                    Console.WriteLine("Name: "+ control.GetOnlyOneFav(selected).Name);
                    Console.WriteLine("Description: "+ control.GetOnlyOneFav(selected).Description);
                     Console.WriteLine("0.Back");
                    Console.WriteLine("1.Remove from favourites");
                    
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            control.RemoveFav(selected);
                            Console.Clear();
                            favmenu();
                            break;    
                        case 0:
                            Console.Clear();
                            favmenu();
                            break;
                    }                  
                    break;

            }

        }
        private void personalmenu()
        {
            Console.Clear();
            Console.WriteLine("0.Back");
            Console.WriteLine("-1.Add");
           
            foreach (var item in control.GetPersonals())
            {
                Console.WriteLine(item.Id+". Name:"+item.Name);
            }
            
            var selected = int.Parse(Console.ReadLine());
            switch (selected)
            {
                case 0:
                    Console.Clear();
                    ReceiptsMenu();
                    break;
                case -1:
                    string name;
                    string description;
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    
                    Console.Write("Description: ");
                    description = ReadLine();
                    control.AddPersonal(name, description);
                    Console.Clear();
                    personalmenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Name: "+ control.GetOnlyOnePer(selected).Name);
                    Console.WriteLine("Description: "+ control.GetOnlyOnePer(selected).Description);   
                    Console.WriteLine("0.Back");
                    Console.WriteLine("1.Remove from personals");
                    
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            control.RemovePer(selected);
                            Console.Clear();
                            personalmenu();
                            break;    
                        case 0:
                            Console.Clear();
                            personalmenu();
                            break;
                    }                  
                    break;

            }

        }
        public void AddComments(int id)
        {

            string text = ReadLine();
            control.AddComments(id, text);



        }
        public void ShowCommets(int id)
        {
            int length=0;
            foreach (var item in control.GetComments(id))
            {
                
                Console.WriteLine(new string('*',item.Text.Length));
                length = item.Text.Length;
                Console.WriteLine("Comment written by " + control.GetAuthor(item.AuthorId.Value).Username);
                Console.WriteLine(item.Text);
               
            }
            Console.WriteLine(new string('*',length));
        }

    }
}
