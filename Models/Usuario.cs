using System;
public class Usuario
{
    public string UserName{get;set;}
    public string Contraseña{get;set;}
    public int Telefono{set;get;}
    public string Gmail{set;get;}
    public int Edad{set;get;}

    public Usuario()
    {

    }

    public Usuario(string username, string contraseña, int telefono, string gmail, int edad)
    {
        UserName = username;
        Contraseña = contraseña;
        Telefono = telefono;
        Gmail = gmail;
        Edad = edad;
    }
}