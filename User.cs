using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WindowsFormsApp1._0
{
    public class User
    {
        //int num;
        public string login;
        public string password;
        public User(string log, string pass)
        {
            login = log;
            password = pass;
        }
        //public void save_user()
        //{

        //    string way = @"db.txt";
        //    StreamWriter file = new StreamWriter(way, false);

        //    //file.WriteLine(num);
        //    file.WriteLine(login);
        //    file.WriteLine(password);
        //}
        public void save(StreamWriter file)
        {
            file.WriteLine(login.ToString());
            file.WriteLine(password.ToString());
        }
    }
    public class User_st
    {
        private int n = 1;
        public int k = 0;
        public User[] st = new User[1];

        public void add(User new_user)
        {
            if (k < n)
            {
                st[k] = new_user;
                k = k + 1;
            }
            else
            {
                n = n * 2;
                User[] st_ = new User[n];
                for (int i = 0; i < k; ++i)
                    st_[i] = st[i];
                st_[k] = new_user;
                k = k + 1;
                for (int i = k; i < n; ++i)
                    st_[i] = null;
                st = st_;
            }
        }
        public User_st(string way)
        {
            StreamReader file = new StreamReader(way);
            // считываем кол-во эл-в в хран.
            int count = Int32.Parse(file.ReadLine());
            for (int i = 0; i < count; ++i)
            {
                string log = file.ReadLine();
                string pass = file.ReadLine();

                add(new User(log,pass));

            }
            file.Close();
        }
        public void save(string way)
        {
            //string way = @"db.txt";
            //StreamWriter file = new StreamWriter(way, false);

            ////file.WriteLine(num);
            //file.WriteLine(login);
            //file.WriteLine(password);

            StreamWriter file = new StreamWriter(way, false);
            // сохраняем инф. о кол-ве эл-в
            file.WriteLine(k);
            // сохраняем инф. обо всех объектах, находящихся в хранилище
            for (int i = 0; i < k; ++i)
            {
                st[i].save(file);
            }
            file.Close();
        }
    }
}
