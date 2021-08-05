using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using LUCKY.Models;
using System.Threading.Tasks;

namespace LUCKY.Data
{
   public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper (string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath); // conexion con la base de datos
            db.CreateTableAsync<Users>().Wait(); //Creacion de la tabla, tomando como referencia nuestro modelo

        }
        //Guardad Usuarios
        public Task<int> SaveUsuariosAsync(Users usua)
        {
            if (usua.IDUser == 0) // si no existe, procede a insertar
            {
                return db.InsertAsync(usua); 
            }
            else
            {
                return null;
            
        }
      

    }
        public Task<Users> GetUsuarios(string email, string pwd)
        {

            return db.Table<Users>().Where(x => x.Email == email && x.password == pwd).FirstOrDefaultAsync();
        }
    }
}
