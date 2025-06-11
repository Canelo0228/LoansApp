using System.Data.SQLite;

namespace PrestamosApp.BD
{
    public class ConexionBD
    {
        private string BasedeDatos;
        private static ConexionBD Con = null;

        public ConexionBD()
        {
            this.BasedeDatos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Prestamos.bd");
            string connectionString = $"Data Source={BasedeDatos}";
        }

        public SQLiteConnection CrearConexion()
        {
            SQLiteConnection Cadena = new SQLiteConnection();
            try
            {
                Cadena.ConnectionString = $"Data Source={BasedeDatos}";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw new Exception("Error al crear la conexión: " + ex.Message);
            }
            return Cadena;
        }

        public static ConexionBD getInstancia()
        {
            if (Con == null)
            {
                Con = new ConexionBD();
            }
            return Con;
        }
    }
}
