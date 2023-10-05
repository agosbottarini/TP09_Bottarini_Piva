function ConfirmarRegistro()
{
    const contraseña = document.getElementById("Contraseña").value;
    const caracteres = '!"#$%&/()=,.-{}´+;:_[]*'
    caracterencontrado == false;
    caractermayus == false;

    while(contraseña.length < 8 || caracterencontrado == false || caractermayus == false)
    {
        if(contraseña[a] === contraseña[a].ToLowerCase())
            {
                 caractermayus == true;   
            }
        for(i = 0; i<contraseña.length; i++)
        {
            for(a = 0; a<caracteres.length; a++)
            {
                if(contraseña[i] == caracteres[a])
                {
                    caracterencontrado == true;
                }
            }
            
                   
        }
    }

    
}