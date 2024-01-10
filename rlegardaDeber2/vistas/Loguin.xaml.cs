using System.Security.Principal;

namespace rlegardaDeber2.vistas;

public partial class Loguin : ContentPage
{
    string[] users = { "Carlos", "Ana", "Jose" };
    string[] passwords = { "carlos123", "ana123", "jose123" };
    public Loguin()
	{
		InitializeComponent();
	}

    private void btnloguin_Clicked(object sender, EventArgs e)
    {
        string usuario = txtusuario.Text;
        string password = txtpassword.Text;
        int index = Array.IndexOf(users, usuario);
        if (index != -1 && passwords[index] == password)
        {
            string nombreUsuario = users[index];
            DisplayAlert("Bienvenido", $"¡Hola {nombreUsuario}!", "Aceptar");
            Navigation.PushAsync(new vistas.Principal(nombreUsuario));
        }
        else
        {

            DisplayAlert("ALERTA", "Usuario/Contraseña incorrectos", "Cancelar");
        }
    }
}

        
