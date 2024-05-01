using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtsProject.Resources
{
    public class BD
    {
        private readonly SQLiteConnection conn;
        public BD(string path)
        {
            conn = new SQLiteConnection(path);
            conn.CreateTable<Bron>();
        }
        public List<Bron> GetBrons()
        {
            return conn.Table<Bron>().ToList();
        }
        public int SaveItem(Bron item)
        {
            return conn.Insert(item);
        }
    }
}
