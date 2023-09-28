using System.Data.SqlClient;
using Dapper;
public static class BD
{
    public static string _connectionString = @"localost";

    //public static Usuario ObtenerUsuario(string Username, string Contraseña)
    {
       //Usuario UsuarioEncontrado = null;
       //using(SqlConnection db = new SqlConnection(_connectionString))
       {
          //  string sql = "SELECT * FROM Usuario WHERE username = @pUsername AND contraseña = @pContraseña";
           // UsuarioEncontrado = db.QueryFirstOrDefault<Usuario>(sql, new {pUsername = username, PContraseña = contraseña});
       }
      // return UsuarioEncontrado;
    }

    //public static void AgregarUsuario(string Username, string Contraseña, int Telefono, string Gmail, int Edad)
    {
        //string SQL = "INSERT INTO Jugadores(UserName, Contraseña, Telefono, Gmail, Edad) VALUES (@PUserName, @pContraseña, @pTelefono, @pGmail, @pEdad)";
        //using(SqlConnection db = new SqlConnection(_connectionString))
        {
           // db.Execute(SQL, new {pUsername = Usua.UserName, pContraseña = Usua.Contraseña, pTelefono = Usua.Telefono, pGmail = Usua.Gmail, pEdad = Usua.Edad});
        }
    }

    //public static void CambiarContraseña(string Contraseña, string UserName)
    {
        //using(SqlConnection db = new SqlConnection(_connectionString))
        {
            //string SQL = "UPDATE Usuario SET Contraseña = pcontraseña WHERE UserName = @pUserName";
            //db.Execute(sql, new {pUserName = UserName, pcontraseña = Contraseña});
        }
    }


}
