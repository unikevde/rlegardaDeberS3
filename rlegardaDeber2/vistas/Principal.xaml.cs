using Microsoft.Maui.Animations;

namespace rlegardaDeber2.vistas;

public partial class Principal : ContentPage
{
	public Principal(string usuario)
	{
		InitializeComponent();
        lblUsaurio.Text = "Usuario:" + usuario;
        //DisplayAlert("alerta", "los datos son:" + usuario, "cerrar");
    }

    private void btncalcular_Clicked(object sender, EventArgs e)
    {
        string estado="";
        int n1 = Convert.ToInt32(txtn1.Text);
        int n2 = Convert.ToInt32(txtn2.Text);
        int p1 = Convert.ToInt32(txtp1.Text);
        int p2 = Convert.ToInt32(txtp2.Text);
        double np1, np2,final;

        np1 = (n1 * 0.30) + (p1 * 0.20);
        np2 = (n2 * 0.30) + (p2 * 0.20);
        final= np1+np2;

        if (final >= 7.00) { estado = "APROBADO"; }
        if (final >=5.00 &&  final <= 6.99) { estado = "COMPLEMENTARIO"; }
        else { estado = "REPROBADO"; }

        DisplayAlert("NOMBRE:"+pknombres.SelectedItem.ToString(),"NOTA PARCIAL 1:"+np1+"\n"+ "NOTA PARCIAL 2:"+np2+"\n"+"NOTA FINAL:"+final+"\n"+"ESTADO:"+estado,"ACPTAR");



    }
}