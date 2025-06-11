using System;
using System.Windows.Forms;
using PrestamosApp.BD;
using SQLitePCL; // Necesario para Batteries.Init()

namespace PrestamosApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            try
            {
                using (var conexion = ConexionBD.getInstancia().CrearConexion())
                {
                    conexion.Open();
                }
                Datos.InicializarBD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }


            Application.Run(new Prestamos());
        }
    }
}
