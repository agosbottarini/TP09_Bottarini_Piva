using System.Data.SqlClient;
using Dapper;
public static class BD
{
    public static string _connectionString = @"Server=localhost;
    DataBase=TP9_Bottarini_Piva;Trusted_Connection=True";

    public static Usuario ObtenerUsuario(string username, string contraseña)
    {
       Usuario UsuarioEncontrado = null;
       using(SqlConnection db = new SqlConnection(_connectionString))
       {
            string sql = "SELECT * FROM Usuario WHERE username = @pUsername OR contraseña = @pContraseña";
            UsuarioEncontrado = db.QueryFirstOrDefault<Usuario>(sql, new {pUsername = username, PContraseña = contraseña});
       }
       return UsuarioEncontrado;
    }

    public static void AgregarUsuario(string UserName, string Contraseña, int Telefono, string Gmail, DateTime Edad)
    {
        string SQL = "INSERT INTO Usuario(UserName, Contraseña, Telefono, Gmail, Edad) VALUES (@PUserName, @pContraseña, @pTelefono, @pGmail, @pEdad)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(SQL, new {pUsername = UserName, pContraseña = Contraseña, pTelefono = Telefono, pGmail = Gmail, pEdad = Edad});
        }
    }

    public static string ObtenerContraseña(int telefono)
    {
        string ContraseñaEncontrado = null;
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT Contraseña FROM Usuario WHERE telefono = @pTelefono";
            ContraseñaEncontrado = db.QueryFirstOrDefault<string>(sql, new {pTelefono = telefono});
        }
        return ContraseñaEncontrado;
    }


    /*
    public static void CambiarContraseña(string Contraseña, string UserName)
    {
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string SQL = "UPDATE Usuario SET Contraseña = pcontraseña WHERE UserName = @pUserName";
            db.Execute(SQL, new {pUserName = UserName, pcontraseña = Contraseña});
        }
    }
    */




}
