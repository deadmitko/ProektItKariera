using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    class Program
    {

        public static User potrebitel;
        [STAThread]
        static void Main(string[] args)
        {
            potrebitel = new User();
            while (true)
            {
                Menu();
            }
           
           


        }
        public static MySqlDataReader Connect(int i,string kommanda)
        {
            MySqlConnectionStringBuilder test = new MySqlConnectionStringBuilder();
            test.UserID = "root";
            test.Password = "root";
            test.Server = "127.0.0.1";
            test.Database = "proekt";

            MySqlConnection test2 = new MySqlConnection(test.ToString());

            var komanda = kommanda;
            MySqlCommand komand = new MySqlCommand(kommanda, test2);
            MySqlDataReader chetec;
            test2.Open();
            if (i == 1)
            {
                chetec = komand.ExecuteReader();

               
                return chetec;
            }
            else {
                komand.ExecuteNonQuery();
                test2.Close();
                chetec = null;
                return chetec;


            }
            

           
            

        }






        public static void register()
        {
            Console.WriteLine("Register");
            Console.Write("Username:");
            var username = Console.ReadLine();
            Console.Write("Password:");
            var password = Console.ReadLine();
            Console.Write("First:");
            var first = Console.ReadLine();
            Console.Write("Last:");
            var last = Console.ReadLine();
            Console.Write("Email:");
            var email = Console.ReadLine();
            var test = Connect(1, "SELECT * FROM users");
            bool flag=true;
            while (test.Read())
            {

                if (username == (string)test[1] || email == (string)test[5]) { flag = false; }




            }
            if (flag)
            {
                Connect(0, $"INSERT INTO users (username, password,first,last,email)VALUES('{username}','{password}','{first}','{last}','{email}')");
                potrebitel.Password = password;
                potrebitel.Email = email;
                MySqlConnectionStringBuilder test2 = new MySqlConnectionStringBuilder();
                test2.UserID = "root";
                test2.Password = "root";
                test2.Server = "127.0.0.1";
                test2.Database = "proekt";
                MySqlConnection connection2 = new MySqlConnection(test2.ToString());
                connection2.Open();
                MySqlCommand command2 = new MySqlCommand($"Select id from users where username='{username}'", connection2);
                var id = (int)command2.ExecuteScalar();
                potrebitel.Id = id;
            }
            else { Console.WriteLine("greshka usernama ili email se izpolvzva"); }



        }
        public static void login()
        {
            Console.WriteLine("Login");
            Console.Write("Username:");
            var username = Console.ReadLine();
            Console.Write("Password:");
            var password = Console.ReadLine();
            var test = Connect(1, $"SELECT id,username,PASSWORD,FIRST,LAST,email FROM users WHERE username='{username}' AND PASSWORD='{password}'");
            while (test.Read())
            {
                if ((int)test[0] == 0)
                {
                    Console.WriteLine("Greshna parola ili ime");


                }
                else {
                    potrebitel.Id = (int)test[0];
                    potrebitel.Password = password;

                    Console.WriteLine("chestito lognah te se ");
                    Console.Clear();

                }
            }


        }
        public static void Menu()
        {
            Console.Title = "AtaDim";
            if (potrebitel.Id == 0)
            {

                Console.WriteLine("1.Register");
                Console.WriteLine("2.Login");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 2:

                       
                            while (potrebitel.Id == 0)
                            {
                                Console.Clear();
                                login();
                            }
                        
                        break;

                    case 1:
                        while (potrebitel.Id==0)
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
                if (potrebitel.Id != 0)
                {
                    check_u1();
                    check_u2();
                    Console.WriteLine("Welcome!!!");
                    Console.WriteLine("1.Account settings");
                    Console.WriteLine("2.Files menu");
                    Console.WriteLine("3.Exit");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            accountmenu();
                            break;
                        case 2:
                            filemenu();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;

                    }
                }
                else
                {
                    while (potrebitel.Id == 0)
                    {

                        login();
                    }
                }





            }
            
        }
        public void menu2()
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    var test = Console.ReadLine();
                    var test2 = Connect(1, "SELECT * FROM users");

                    break;
                default:
                    break;
            }




        }
        public static void accountmenu()
        {
            Console.Clear();
            Console.WriteLine("1.Change Password");
            Console.WriteLine("2.Change email");
            Console.WriteLine("3.Change UI");
            Console.WriteLine("4.Back");
            switch (int.Parse(Console.ReadLine()))
            {
                case 2:
                    Console.Write("Enter your new email");
                    var newemail = Console.ReadLine();
                    Console.Write("Enter your  password");
                    var password = Console.ReadLine();
                    if (password == potrebitel.Password)
                    {
                        Connect(0,$"UPDATE users "+
$"SET email = '{newemail}' "+
$"WHERE id = {potrebitel.Id}");
                        

                        Console.Clear();
                        accountmenu();



                    }
                    
                    break;
                case 1:
                    Console.Write("Enter your new password");
                    var newpass = Console.ReadLine();
                    Console.Write("Enter your old password");
                    var password2 = Console.ReadLine();
                    if (password2 == potrebitel.Password)
                    {
                        Connect(0, $"UPDATE users " +
$"SET password = '{newpass}' " +
$"WHERE id = {potrebitel.Id}");
                        potrebitel.Password = newpass;
                        Console.Clear();
                        accountmenu();



                    }
                    break;
                case 4:
                    Console.Clear();
                    Menu();
                    break;
                case 3:
                    Console.Clear();
                    changeui();
                    break;
            }
            
        }
        public static void changeui()
        {
            MySqlConnectionStringBuilder test = new MySqlConnectionStringBuilder();
            test.UserID = "root";
            test.Password = "root";
            test.Server = "127.0.0.1";
            test.Database = "proekt";
            MySqlConnection connection = new MySqlConnection(test.ToString());
            connection.Open();
            MySqlCommand command = new MySqlCommand($"Select ui1 from users where id={potrebitel.Id}", connection);
            var u01 = (string)command.ExecuteScalar();
            command = new MySqlCommand($"Select ui2 from users where id={potrebitel.Id}", connection);
            var u02 = (string)command.ExecuteScalar();
            Console.WriteLine("Current background: "+u01);
            Console.WriteLine("Current foreground: "+u02);
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
        public static void u1()
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

            switch (int.Parse(Console.ReadLine())) {
                case 0:
                    Console.Clear();
                    changeui();
                    break;
                case 1:
                    Connect(0, $"UPDATE users " + $"SET ui1 = 'black' " + $"WHERE id = {potrebitel.Id}");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 2:
                    Connect(0, $"UPDATE users " + $"SET ui1 = 'blue' " + $"WHERE id = {potrebitel.Id}");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Connect(0, $"UPDATE users " + $"SET ui1 = 'cyan' " + $"WHERE id = {potrebitel.Id}");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    Connect(0, $"UPDATE users " + $"SET ui1 = 'darkblue' " + $"WHERE id = {potrebitel.Id}");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case 5:
                    Connect(0, $"UPDATE users " + $"SET ui1 = 'darkgreen' " + $"WHERE id = {potrebitel.Id}");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case 6:
                    Connect(0, $"UPDATE users " + $"SET ui1 = 'darkmagenta' " + $"WHERE id = {potrebitel.Id}");
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 7:
                    Connect(0, $"UPDATE users " + $"SET ui1 = 'darkred' " + $"WHERE id = {potrebitel.Id}");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    break;
                case 8:
                    Connect(0, $"UPDATE users " + $"SET ui1 = 'darkyellow' " + $"WHERE id = {potrebitel.Id}");
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case 9:
                    Connect(0, $"UPDATE users " + $"SET ui1 = 'gray' " + $"WHERE id = {potrebitel.Id}");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 10:
                    Connect(0, $"UPDATE users " + $"SET ui1 = 'green' " + $"WHERE id = {potrebitel.Id}");
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 11:
                    Connect(0, $"UPDATE users " + $"SET ui1 = 'magenta' " + $"WHERE id = {potrebitel.Id}");
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case 12:
                    Connect(0, $"UPDATE users " + $"SET ui1 = 'red' " + $"WHERE id = {potrebitel.Id}");
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 13:
                    Connect(0, $"UPDATE users " + $"SET ui1 = 'white' " + $"WHERE id = {potrebitel.Id}");
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case 14:
                    Connect(0, $"UPDATE users " + $"SET ui1 = 'yellow' " + $"WHERE id = {potrebitel.Id}");
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case 15:
                    Connect(0, $"UPDATE users " + $"SET ui1 = 'darkgray' " + $"WHERE id = {potrebitel.Id}");
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
            }
            Console.Clear();
            changeui();
        }
        public static void check_u1()
        {

            MySqlConnectionStringBuilder test = new MySqlConnectionStringBuilder();
            test.UserID = "root";
            test.Password = "root";
            test.Server = "127.0.0.1";
            test.Database = "proekt";
            MySqlConnection connection = new MySqlConnection(test.ToString());
            connection.Open();
            MySqlCommand command = new MySqlCommand($"Select ui1 from users where id={potrebitel.Id}", connection);
            var u01 = (string)command.ExecuteScalar();

            switch (u01)
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
        public static void check_u2()
        {

            MySqlConnectionStringBuilder test = new MySqlConnectionStringBuilder();
            test.UserID = "root";
            test.Password = "root";
            test.Server = "127.0.0.1";
            test.Database = "proekt";
            MySqlConnection connection = new MySqlConnection(test.ToString());
            connection.Open();
            MySqlCommand command = new MySqlCommand($"Select ui2 from users where id={potrebitel.Id}", connection);
            var u01 = (string)command.ExecuteScalar();

            switch (u01)
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
        public static void u2()
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
                    Connect(0, $"UPDATE users " + $"SET ui2 = 'black' " + $"WHERE id = {potrebitel.Id}");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 2:
                    Connect(0, $"UPDATE users " + $"SET ui2 = 'blue' " + $"WHERE id = {potrebitel.Id}");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Connect(0, $"UPDATE users " + $"SET ui2 = 'cyan' " + $"WHERE id = {potrebitel.Id}");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    Connect(0, $"UPDATE users " + $"SET ui2 = 'darkblue' " + $"WHERE id = {potrebitel.Id}");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 5:
                    Connect(0, $"UPDATE users " + $"SET ui2 = 'darkgreen' " + $"WHERE id = {potrebitel.Id}");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 6:
                    Connect(0, $"UPDATE users " + $"SET ui2 = 'darkmagenta' " + $"WHERE id = {potrebitel.Id}");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 7:
                    Connect(0, $"UPDATE users " + $"SET ui2 = 'darkred' " + $"WHERE id = {potrebitel.Id}");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 8:
                    Connect(0, $"UPDATE users " + $"SET ui2 = 'darkyellow' " + $"WHERE id = {potrebitel.Id}");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 9:
                    Connect(0, $"UPDATE users " + $"SET ui2 = 'gray' " + $"WHERE id = {potrebitel.Id}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 10:
                    Connect(0, $"UPDATE users " + $"SET ui2 = 'green' " + $"WHERE id = {potrebitel.Id}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 11:
                    Connect(0, $"UPDATE users " + $"SET ui2 = 'magenta' " + $"WHERE id = {potrebitel.Id}");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 12:
                    Connect(0, $"UPDATE users " + $"SET ui2 = 'red' " + $"WHERE id = {potrebitel.Id}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 13:
                    Connect(0, $"UPDATE users " + $"SET ui2 = 'white' " + $"WHERE id = {potrebitel.Id}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 14:
                    Connect(0, $"UPDATE users " + $"SET ui2 = 'yellow' " + $"WHERE id = {potrebitel.Id}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 15:
                    Connect(0, $"UPDATE users " + $"SET ui2 = 'darkgray' " + $"WHERE id = {potrebitel.Id}");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }
            Console.Clear();
            changeui();

        }
        public static void filemenu()
        {
            Console.Clear();
            Console.WriteLine("1.Upload file");
            Console.WriteLine("2.Show all");
            Console.WriteLine("3.Back");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.Clear();
                    uploader();
                     
                    break;
                case 2:
                    Console.Clear();
                    manage();
                    
                   
                    break;
                case 3:
                    Console.Clear();
                    Menu();
                    break;




            }
            




        }
        public static void manage()
        {
            Console.Clear();
            
            showallfiles();
            Console.WriteLine("0.Back");
           
            var tekst = Console.ReadLine();
            object test4 = null;
            if (tekst == "0") { Console.Clear(); filemenu(); }
            while (true)
            {
                if (tekst == "0") { Console.Clear(); filemenu(); }
                var tekst2= int.Parse(tekst);
                MySqlConnectionStringBuilder test = new MySqlConnectionStringBuilder();
                test.UserID = "root";
                test.Password = "root";
                test.Server = "127.0.0.1";
                test.Database = "proekt";
                MySqlConnection connection = new MySqlConnection(test.ToString());
                connection.Open();
                MySqlCommand command = new MySqlCommand($"Select id from files where id={tekst2} and id_user={potrebitel.Id}", connection);
                test4 = command.ExecuteScalar();
                
                if (test4 == null)
                { Console.Clear();showallfiles(); tekst = Console.ReadLine(); }
                else
                { break; }
                
            }
            var selected = int.Parse(tekst);
            Console.Clear();
            info(selected);
            Console.WriteLine("1.Download");
            Console.WriteLine("2.Rename");
            Console.WriteLine("3.Delete");
            Console.WriteLine("4.Back");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    downloader(selected);
                    
                    
                    break;
                case 2:
                    Console.Write("Novo ime: ");
                    var newname = Console.ReadLine();
                    Connect(0, $"UPDATE files " +
                $"SET name = '{newname}' " +
                 $"WHERE id = {selected}");
                    Console.Clear();
                    manage();
                    break;
                case 3:
                    Connect(0, $"DELETE from files " +

                         $"WHERE id = {selected}");
                    Console.Clear();
                    manage();
                    break;
                case 4:
                    Console.Clear();
                    manage();
                    break;
                    
            }

        }
        public static void uploader()
        {
            try
            {
                Console.Clear();
                OpenFileDialog fdlg = new OpenFileDialog();
                fdlg.Title = "Izberi file za ka4vane";
                fdlg.InitialDirectory = @"c:\Desktop";
                fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";

                fdlg.FilterIndex = 2;
                fdlg.RestoreDirectory = true;
                fdlg.ShowDialog();

                byte[] images = null;
                FileStream stream = new FileStream(fdlg.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                brs.Close();
                stream.Close();
                MySqlConnectionStringBuilder test = new MySqlConnectionStringBuilder();
                test.UserID = "root";
                test.Password = "root";
                test.Server = "127.0.0.1";
                test.Database = "proekt";

                MySqlConnection test2 = new MySqlConnection(test.ToString());
                var kommanda = $"INSERT INTO files (id_user,name,file,ext) VALUES(@id_user,@name,@image,@ext)";
                MySqlCommand komand = new MySqlCommand(kommanda, test2);
                komand.Parameters.AddWithValue("@image", images);
                komand.Parameters.AddWithValue("@id_user", potrebitel.Id);
                komand.Parameters.AddWithValue("@name", fdlg.SafeFileName);
                komand.Parameters.AddWithValue("@ext", Path.GetExtension(fdlg.FileName));
                test2.Open();
                komand.ExecuteNonQuery();
                Console.WriteLine("failat e ka4en uspeshno");
                test2.Close();
                Console.Clear();
                filemenu();
            }
            catch (Exception e) { Console.Clear();filemenu(); }
        }
        public static void showallfiles()
        {
           
            MySqlConnectionStringBuilder test = new MySqlConnectionStringBuilder();
            test.UserID = "root";
            test.Password = "root";
            test.Server = "127.0.0.1";
            test.Database = "proekt";
            MySqlConnection connection = new MySqlConnection(test.ToString());
            connection.Open();
            MySqlCommand command = new MySqlCommand($"Select id,name from files where id_user={potrebitel.Id}", connection);
           var test2 = command.ExecuteReader();
            while (test2.Read())
            {

                Console.WriteLine((int)test2[0] +" " + (string)test2[1]);





            }
        }
        public static void info(int id)
        {

            MySqlConnectionStringBuilder test = new MySqlConnectionStringBuilder();
            test.UserID = "root";
            test.Password = "root";
            test.Server = "127.0.0.1";
            test.Database = "proekt";
            MySqlConnection connection = new MySqlConnection(test.ToString());
            connection.Open();
            MySqlCommand command = new MySqlCommand($"Select id,name from files where id={id}", connection);
            var test2 = command.ExecuteReader();
            while (test2.Read())
            {

                Console.WriteLine("Vie izbrahte: "+(int)test2[0] + " " + (string)test2[1]);





            }


        }
        public static void downloader(int id)
        {
            try
            {
                MySqlConnectionStringBuilder test = new MySqlConnectionStringBuilder();
                test.UserID = "root";
                test.Password = "root";
                test.Server = "127.0.0.1";
                test.Database = "proekt";
                MySqlConnection connection = new MySqlConnection(test.ToString());
                connection.Open();
                MySqlCommand command = new MySqlCommand($"Select file from files where id={id}", connection);
                MySqlCommand command2 = new MySqlCommand($"Select ext from files where id={id}", connection);
                var ext = (string)command2.ExecuteScalar();
                byte[] buffer = (byte[])command.ExecuteScalar();
                connection.Close();
                SaveFileDialog sdlg = new SaveFileDialog();
                sdlg.Title = "Zapazi kato";
                sdlg.InitialDirectory = @"c:\";
                sdlg.Filter = "*" + ext + "|*" + ext;
                sdlg.DefaultExt = ext;
                sdlg.AddExtension = true;
                sdlg.ShowDialog();
                Stream stream2 = new FileStream(sdlg.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                BinaryWriter bw = new BinaryWriter(stream2);

                foreach (var b in buffer)
                {
                    bw.Write(b);
                }

                bw.Flush();
                bw.Close();

                Console.Clear();
                manage();

            }
            catch (Exception e) { Console.Clear(); manage(); }

        }
        public static StringBuilder hash(string password)
        {
            StringBuilder stringa = new StringBuilder();
            for (int i = 0; i < password.Length; i++)
            {
                switch (password[i])
                {
                    case 'a':
                        stringa = stringa.Append("gf");
                        break;
                    case 'b':
                        stringa = stringa.Append("uy");
                        break;
                    case 'c':
                        stringa = stringa.Append("qw");
                        break;
                    case 'd':
                        stringa = stringa.Append("hj");
                        break;
                    case 'e':
                        stringa = stringa.Append("bg");
                        break;
                    case 'f':
                        stringa = stringa.Append("nm");
                        break;
                    case 'g':
                        stringa = stringa.Append("0h");
                        break;
                    case 'h':
                        stringa = stringa.Append("3b");
                        break;
                    case 'i':
                        stringa = stringa.Append("1y");
                        break;
                    case 'j':
                        stringa = stringa.Append("jo");
                        break;
                    case 'k':
                        stringa = stringa.Append("pi");
                        break;
                    case 'l':
                        stringa = stringa.Append("2f");
                        break;
                    case 'm':
                        stringa = stringa.Append("u8");
                        break;
                    case 'n':
                        stringa = stringa.Append("q1");
                        break;
                    case 'o':
                        stringa = stringa.Append("qr");
                        break;
                    case 'p':
                        stringa = stringa.Append("6j");
                        break;
                    case 'q':
                        stringa = stringa.Append("yt");
                        break;
                    case 'r':
                        stringa = stringa.Append("re");
                        break;
                    case 's':
                        stringa = stringa.Append("qs");
                        break;
                    case 't':
                        stringa = stringa.Append("xx");
                        break;
                    case 'u':
                        stringa = stringa.Append("vf");
                        break;
                    case 'v':
                        stringa = stringa.Append("op");
                        break;
                    case 'w':
                        stringa = stringa.Append("rd");
                        break;
                    case 'x':
                        stringa = stringa.Append("rs");
                        break;
                    case 'y':
                        stringa = stringa.Append("ss");
                        break;
                    case 'z':
                        stringa = stringa.Append("mj");
                        break;




                }
            }

            return stringa;
        }







    }
}
