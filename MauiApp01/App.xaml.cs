
namespace MauiApp01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var button = new Button();
            button.Text = "Generar un nueva ventana";
            button.Clicked += (s, a) =>
            {
                var ventana2 = new Window(new ContentPage());
                ventana2.Created += (s, a) => System.Diagnostics.Debug.WriteLine(nameof(ventana2.Created));
                ventana2.Activated += (s, a) => System.Diagnostics.Debug.WriteLine(nameof(ventana2.Activated));
                ventana2.Deactivated += (s, a) => System.Diagnostics.Debug.WriteLine(nameof(ventana2.Deactivated));
                
                OpenWindow(ventana2);
            };

            MainPage = new ContentPage() { 
                Content = button
            };
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var ventana = base.CreateWindow(activationState);
            ventana.Created += Ventana_Created;
            ventana.Deactivated += Ventana_Deactivated;
            ventana.Activated += Ventana_Activated;
            return ventana;
        }

        private void Ventana_Activated(object? sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(nameof(Ventana_Activated));
        }

        private void Ventana_Deactivated(object? sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(nameof(Ventana_Deactivated));
        }

        private void Ventana_Created(object? sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(nameof(Ventana_Created));
        }
    }
}
