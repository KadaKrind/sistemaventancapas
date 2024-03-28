using Microsoft.VisualBasic;

namespace SistemaVentas.VISTA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new PersonaVistas.PersonaListarVista ());
            //Application.Run(new PersonaVistas.PersonaInsertarVista());
            //Application.Run(new UsuarioVistar.UsuarioInsertarVista());
            //Application.Run(new PersonaVistas.PersonaListarVista());
            //Application.Run(new GerenteVistas.GerenteAgregarVista());
            //Application.Run(new GerenteVistas.GerenteUsuarioSeleccionarVista()); *Quitar las slash para ver la tabla
            Application.Run(new GerenteVistas.UsuarioSeleccionarIdVista());
        }
    }
}