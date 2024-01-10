namespace rlegardaDeber2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage=new NavigationPage(new vistas.Loguin());
           // MainPage = new vistas.Loguin();
        }
    }
}
