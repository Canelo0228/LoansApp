using PrestamosApp.Models;
using System.Data;
using System.Data.SQLite;

namespace PrestamosApp.BD
{
    public class Datos
    {
        public static string BasedeDatos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Prestamos.bd");
        public static string connectionString = $"Data Source={BasedeDatos}";

        public static void InicializarBD()
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();

                    string crearTablaPrestamos = @"
                CREATE TABLE IF NOT EXISTS Prestamos (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    NOMBRE TEXT,
                    ""#"" TEXT,
                    ""DIA DE PAGO"" TEXT,
                    ""COBRO TOTAL"" TEXT,
                    INTERES TEXT,
                    CAPITAL TEXT,
                    ""VALOR DE PRESTAMO"" TEXT,
                    ""NUEVO BALANCE"" TEXT,
                    CUOTAS INTEGER
                );
            ";

                    string crearTablaHistorial = @"
                CREATE TABLE IF NOT EXISTS Historial (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    NOMBRE TEXT,
                    ""#"" TEXT,
                    ""FECHA FINALIZACION"" TEXT,
                    ""COBRO MENSUAL"" TEXT,
                    ""INTERES MENSUAL"" TEXT,
                    ""CAPITAL MENSUAL"" TEXT,
                    ""VALOR PRESTAMO"" TEXT,
                    ""INTERES GANADOS"" TEXT
                );
            ";

                    string crearTablaPagos = @"
                CREATE TABLE IF NOT EXISTS Pagos (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ID_Prestamo INTEGER,
                    Year TEXT,
                    Enero9 TEXT, Enero24 TEXT, Febrero9 TEXT, Febrero24 TEXT,
                    Marzo9 TEXT, Marzo24 TEXT, Abril9 TEXT, Abril24 TEXT,
                    Mayo9 TEXT, Mayo24 TEXT, Junio9 TEXT, Junio24 TEXT,
                    Julio9 TEXT, Julio24 TEXT, Agosto9 TEXT, Agosto24 TEXT,
                    Septiembre9 TEXT, Septiembre24 TEXT, Octubre9 TEXT, Octubre24 TEXT,
                    Noviembre9 TEXT, Noviembre24 TEXT, Diciembre9 TEXT, Diciembre24 TEXT
                );
            ";

                    using (SQLiteCommand cmd = new SQLiteCommand(crearTablaPrestamos, conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    using (SQLiteCommand cmd = new SQLiteCommand(crearTablaHistorial, conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    using (SQLiteCommand cmd = new SQLiteCommand(crearTablaPagos, conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar la base de datos: " + ex.Message);
            }
        }
        public static DataTable ObtenerDatos()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {

                    string query = "SELECT ID, NOMBRE,\"#\",\"DIA DE PAGO\",\"COBRO TOTAL\",INTERES,CAPITAL,\"VALOR DE PRESTAMO\" AS \"VALOR PRESTAMO\",\"NUEVO BALANCE\" AS \"BALANCE PENDIENTE\",CUOTAS FROM Prestamos;";

                    using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                    {
                        using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }

            return tabla;
        }
        public static DataTable ObtenerHistorial()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {

                    string query = "SELECT NOMBRE,\"#\",\"FECHA FINALIZACION\",\"COBRO MENSUAL\",\"INTERES MENSUAL\",\"CAPITAL MENSUAL\",\"VALOR PRESTAMO\", \"INTERES GANADOS\" AS \"INTERESES GANADOS\" FROM Historial ORDER BY \"FECHA FINALIZACION\" DESC, \"INTERES GANADOS\" DESC;";

                    using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                    {
                        using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }

            return tabla;
        }
        public static DataTable buscarPrestamo(string parametro, string valorParametro)
        {
            string _parametro = "";
            if (parametro == "#")
            {
                _parametro = "\"#\"";
            }
            else if (parametro == "COBRO TOTAL")
            {
                _parametro = "\"COBRO TOTAL\"";
            }
            else if (parametro == "VALOR")
            {
                _parametro = "\"VALOR DE PRESTAMO\"";
            }
            else
            {
                _parametro = parametro;
            }
            DataTable tabla = new DataTable();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {

                    string query = "SELECT ID, " +
                        "NOMBRE,\"#\",\"DIA DE PAGO\",\"COBRO TOTAL\",INTERES,CAPITAL,\"VALOR DE PRESTAMO\" AS \"VALOR PRESTAMO\",\"NUEVO BALANCE\" AS \"BALANCE PENDIENTE\",CUOTAS FROM Prestamos WHERE " + _parametro + " LIKE '%" + valorParametro + "%' COLLATE NOCASE;";

                    using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                    {
                        using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }

            return tabla;
        }
        public string guardarEnHistorial(GuardarHistorial data)
        {
            string res = "";
            string query = "";
            SQLiteConnection conexion = new SQLiteConnection();

            try
            {
                conexion = ConexionBD.getInstancia().CrearConexion();

                query = "INSERT INTO Historial(NOMBRE,\"#\",\"FECHA FINALIZACION\",\"COBRO MENSUAL\",\"INTERES MENSUAL\",\"CAPITAL MENSUAL\",\"VALOR PRESTAMO\", \"INTERES GANADOS\") " +
                        "VALUES(@name, @number, @fecha, @cobroTotal, @interes, @capital, @valor, @interesGanados)";

                SQLiteCommand comando = new SQLiteCommand(query, conexion);
                comando.Parameters.AddWithValue("@name", data.name);
                comando.Parameters.AddWithValue("@number", data.number);
                comando.Parameters.AddWithValue("@fecha", data.fecha);
                comando.Parameters.AddWithValue("@cobroTotal", data.cobroTotal);
                comando.Parameters.AddWithValue("@interes", data.interes);
                comando.Parameters.AddWithValue("@capital", data.capital);
                comando.Parameters.AddWithValue("@valor", data.valor);
                comando.Parameters.AddWithValue("@interesGanados", data.interesesGanados);

                conexion.Open();
                res = comando.ExecuteNonQuery() >= 1 ? "OK" : "Error al registrar el préstamo";

            }
            catch (Exception ex)
            {
                res = "Error: " + ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return res;
        }
        public string guardarRegistro(int codigo, Guardar data)
        {
            string res = "";
            string query = "";
            SQLiteConnection conexion = new SQLiteConnection();

            try
            {
                conexion = ConexionBD.getInstancia().CrearConexion();

                if (codigo == 1)
                {
                    query = "INSERT INTO Prestamos(NOMBRE, \"#\", \"DIA DE PAGO\", \"COBRO TOTAL\", INTERES, CAPITAL, \"VALOR DE PRESTAMO\", \"NUEVO BALANCE\", CUOTAS) " +
                            "VALUES(@name, @number, @payDay, @cobroTotal, @interes, @capital, @valor, @nuevoBalance, @cuotas)";

                    SQLiteCommand comando = new SQLiteCommand(query, conexion);
                    comando.Parameters.AddWithValue("@name", data.name);
                    comando.Parameters.AddWithValue("@number", data.number);
                    comando.Parameters.AddWithValue("@payDay", data.payDay);
                    comando.Parameters.AddWithValue("@cobroTotal", data.cobroTotal);
                    comando.Parameters.AddWithValue("@interes", data.interes);
                    comando.Parameters.AddWithValue("@capital", data.capital);
                    comando.Parameters.AddWithValue("@valor", data.valor);
                    comando.Parameters.AddWithValue("@nuevoBalance", data.valor); // El balance inicial es igual al valor
                    comando.Parameters.AddWithValue("@cuotas", data.cuotas);

                    conexion.Open();
                    res = comando.ExecuteNonQuery() >= 1 ? "OK" : "Error al registrar el préstamo";
                }
                else
                {
                    conexion.Open();

                    // Buscar valor anterior y balance anterior
                    string selectQuery = "SELECT \"VALOR DE PRESTAMO\", \"NUEVO BALANCE\" FROM Prestamos WHERE ID = @id";
                    SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, conexion);
                    selectCommand.Parameters.AddWithValue("@id", data.Id);

                    SQLiteDataReader reader = selectCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        string valorAnteriorStr = reader["VALOR DE PRESTAMO"].ToString().Trim();
                        string balanceAnteriorStr = reader["NUEVO BALANCE"].ToString().Trim();
                        string nuevoValorStr = data.valor.Trim();

                        int valorAnterior = (int)float.Parse(valorAnteriorStr);
                        int balanceAnterior = (int)float.Parse(balanceAnteriorStr);
                        int nuevoValor = (int)float.Parse(nuevoValorStr);

                        int diferencia = nuevoValor - valorAnterior;
                        int nuevoBalance = balanceAnterior + diferencia;

                        reader.Close();

                        // Ahora actualizamos
                        string updateQuery = "UPDATE Prestamos SET " +
                            "NOMBRE = @name, " +
                            "\"#\" = @number, " +
                            "\"DIA DE PAGO\" = @payDay, " +
                            "\"COBRO TOTAL\" = @cobroTotal, " +
                            "INTERES = @interes, " +
                            "CAPITAL = @capital, " +
                            "\"VALOR DE PRESTAMO\" = @valor, " +
                            "\"NUEVO BALANCE\" = @nuevoBalance, " +
                            "CUOTAS = @cuotas " +
                            "WHERE ID = @id";

                        SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, conexion);
                        updateCommand.Parameters.AddWithValue("@name", data.name);
                        updateCommand.Parameters.AddWithValue("@number", data.number);
                        updateCommand.Parameters.AddWithValue("@payDay", data.payDay);
                        updateCommand.Parameters.AddWithValue("@cobroTotal", data.cobroTotal);
                        updateCommand.Parameters.AddWithValue("@interes", data.interes);
                        updateCommand.Parameters.AddWithValue("@capital", data.capital);
                        updateCommand.Parameters.AddWithValue("@valor", data.valor);
                        updateCommand.Parameters.AddWithValue("@nuevoBalance", nuevoBalance);
                        updateCommand.Parameters.AddWithValue("@cuotas", data.cuotas);
                        updateCommand.Parameters.AddWithValue("@id", data.Id);

                        res = updateCommand.ExecuteNonQuery() >= 1 ? "OK" : "Error al actualizar el préstamo";
                    }
                    else
                    {
                        res = "Error: Préstamo no encontrado";
                    }
                }
            }
            catch (Exception ex)
            {
                res = "Error: " + ex.Message;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return res;
        }
        public string eliminarRegistro(int id)
        {
            string res = "";
            string query;
            SQLiteConnection conexion = new SQLiteConnection();
            try
            {
                conexion = ConexionBD.getInstancia().CrearConexion();

                query = "DELETE FROM Prestamos WHERE ID = " + id;

                SQLiteCommand comando = new SQLiteCommand(query, conexion);
                conexion.Open();
                res = comando.ExecuteNonQuery() >= 1 ? "OK" : "Error al registrar el prestamo";
                return res;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
                throw;
            }

        }
        public static DataTable obtenerPagos(int id, int rango, string year)
        {
            DataTable tabla = new DataTable();
            string query = "";
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {
                    if (rango == 1)
                    {
                        query = "SELECT Enero9 AS \"Enero 9\", Enero24 AS \"Enero 24\", Febrero9 AS \"Febrero 9\", Febrero24 AS \"Febrero 24\", " +
                            "Marzo9 AS \"Marzo 9\", Marzo24 AS \"Marzo 24\", Abril9 AS \"Abril 9\", Abril24 AS \"Abril 24\", Mayo9 AS \"Mayo 9\", Mayo24 AS \"Mayo 24\"," +
                            " Junio9 AS \"Junio 9\", Junio24 AS \"Junio 24\" FROM Pagos WHERE id_Prestamo='" + id + "' AND Year='" + year + "'";
                    }
                    else
                    {
                        query = "SELECT Julio9 AS \"Julio 9\", Julio24 AS \"Julio 24\", Agosto9 AS \"Agosto 9\", Agosto24 AS \"Agosto 24\", Septiembre9 AS \"Septiembre 9\", " +
                            "Septiembre24 AS \"Septiembre 24\", Octubre9 AS \"Octubre 9\", Octubre24 AS \"Octubre 24\", Noviembre9 AS \"Noviembre 9\", " +
                            "Noviembre24 AS \"Noviembre 24\", Diciembre9 AS \"Diciembre 9\", Diciembre24 AS \"Diciembre 24\" FROM Pagos WHERE id_Prestamo='" + id + "' AND Year='" + year + "'";
                    }


                    using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                    {
                        using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los pagos: " + ex.Message);
            }

            return tabla;
        }
        public string guardarPago(Pagos data)
        {
            string res = "";
            string query = "";

            using (SQLiteConnection conexion = ConexionBD.getInstancia().CrearConexion())
            {
                try
                {
                    conexion.Open();

                    string countPayments = "SELECT COUNT(*) FROM Pagos WHERE ID_Prestamo = @ID_Prestamo AND Year = @Year";

                    using (SQLiteCommand comando1 = new SQLiteCommand(countPayments, conexion))
                    {
                        comando1.Parameters.AddWithValue("@ID_Prestamo", data.ID);
                        comando1.Parameters.AddWithValue("@Year", data.Year);

                        int conteo = Convert.ToInt32(comando1.ExecuteScalar());

                        string getPrestamo = "SELECT \"NUEVO BALANCE\", INTERES, CAPITAL, CUOTAS FROM Prestamos WHERE ID = @ID_Prestamo";

                        decimal saldoPendiente = 0;
                        decimal interesFijo = 0;
                        decimal capitalFijo = 0;
                        int cuotas = 0;

                        using (SQLiteCommand comandoPrestamo = new SQLiteCommand(getPrestamo, conexion))
                        {
                            comandoPrestamo.Parameters.AddWithValue("@ID_Prestamo", data.ID);

                            using (SQLiteDataReader reader = comandoPrestamo.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    decimal.TryParse(reader["NUEVO BALANCE"].ToString(), out saldoPendiente);
                                    decimal.TryParse(reader["INTERES"].ToString(), out interesFijo);
                                    decimal.TryParse(reader["CAPITAL"].ToString(), out capitalFijo);
                                    int.TryParse(reader["CUOTAS"].ToString(), out cuotas);
                                }
                            }
                        }

                        if (conteo > 0)
                        {
                            query = "UPDATE Pagos SET " + data.MesDia + " = @Cantidad WHERE ID_Prestamo = @ID_Prestamo AND Year = @Year AND " + data.MesDia + " IS NULL";

                            using (SQLiteCommand updateCommand = new SQLiteCommand(query, conexion))
                            {
                                updateCommand.Parameters.AddWithValue("@Cantidad", data.Cantidad);
                                updateCommand.Parameters.AddWithValue("@ID_Prestamo", data.ID);
                                updateCommand.Parameters.AddWithValue("@Year", data.Year);

                                int rowsAffected = updateCommand.ExecuteNonQuery();
                                if (rowsAffected >= 1)
                                {
                                    res = "OK";
                                }
                                else
                                {
                                    res = "Ya existe un pago para esa fecha";
                                }
                            }
                        }
                        else
                        {
                            query = "INSERT INTO Pagos (" + data.MesDia + ", ID_Prestamo, Year) VALUES (@Cantidad, @ID_Prestamo, @Year)";

                            using (SQLiteCommand insertCommand = new SQLiteCommand(query, conexion))
                            {
                                insertCommand.Parameters.AddWithValue("@Cantidad", data.Cantidad);
                                insertCommand.Parameters.AddWithValue("@ID_Prestamo", data.ID);
                                insertCommand.Parameters.AddWithValue("@Year", data.Year);

                                int rowsAffected = insertCommand.ExecuteNonQuery();
                                if (rowsAffected >= 1)
                                {
                                    res = "OK";
                                }
                                else
                                {
                                    res = "Error al registrar el pago";
                                }
                            }
                        }

                        if (res == "OK")
                        {
                            decimal nuevoSaldo = saldoPendiente - capitalFijo;
                            int nuevasCuotas = cuotas - 1;

                            string updatePrestamo = "UPDATE Prestamos SET \"NUEVO BALANCE\" = @NuevoSaldo, CUOTAS = @NuevasCuotas WHERE ID = @ID_Prestamo";

                            using (SQLiteCommand updatePrestamoCommand = new SQLiteCommand(updatePrestamo, conexion))
                            {
                                updatePrestamoCommand.Parameters.AddWithValue("@NuevoSaldo", nuevoSaldo.ToString("0.00"));
                                updatePrestamoCommand.Parameters.AddWithValue("@NuevasCuotas", nuevasCuotas);
                                updatePrestamoCommand.Parameters.AddWithValue("@ID_Prestamo", data.ID);
                                updatePrestamoCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    res = "Error: " + ex.Message;
                }
            }

            return res;
        }
    }
}
