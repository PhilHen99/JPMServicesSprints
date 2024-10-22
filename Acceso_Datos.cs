using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace Formularios_H3
{
    internal class Acceso_Datos
    {
        private MySqlConnection connection;


        public Acceso_Datos()
        {
            string connectionString = "server=asidi.xyz;user=DBFACTURAS;database=dbfacturas;port=3306;password=facturas2024;";
            connection = new MySqlConnection(connectionString);
        }

        public string AbrirBd()
        {
            string mensaje = "Conexion abierta con exito.";
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                mensaje = "Error al abrir la base de datos";
            }
            return mensaje;
        }

        public string CerrarBd()
        {
            string mensaje = "Conexion cerrada con exito.";
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                mensaje = $"Error al cerrar la conexion: {ex.Message}";
            }
            return mensaje;
        }

        

        public DataTable Leertabla(string tabla, string strCondicion)
        {
            string query = $"SELECT * FROM {tabla}";
            if (!string.IsNullOrEmpty(strCondicion))
            {
                query += $" WHERE {strCondicion}";
            }


            
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();

            try
            {
                AbrirBd();
                adapter.Fill(dt);
                int numRegistros = dt.Rows.Count;
                MessageBox.Show($"Número de registros leídos: {numRegistros}");  // Muestra cuántos registros fueron leídos
                Console.WriteLine($"Número de registros leídos: {numRegistros}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"error al leer la tabla: {ex.Message}");
            }
            finally
            {
                CerrarBd();
            }
            
            return dt;
        }



        public string EjecutarComando(string comandoSQL)
        {
            string resultado = "Comando ejecutado con éxito.";
            try
            {
                AbrirBd();
                MySqlCommand command = new MySqlCommand(comandoSQL, connection);
                int rowsAffected = command.ExecuteNonQuery();
                resultado = $"{rowsAffected} filas afectadas.";
            }
            catch (Exception ex)
            {
                resultado = $"Error al ejecutar el comando: {ex.Message}";
            }
            finally
            {
                CerrarBd();
            }
            MessageBox.Show(resultado); // Esto debería mostrar cuántas filas fueron afectadas

            return resultado;
        }


        public DataTable EjecutarComandoTabla(string columnas, string tabla, string strCondicion)
        {
            string query = $"SELECT {columnas} FROM {tabla}";
            if (!string.IsNullOrEmpty(strCondicion))
            {
                query += $" WHERE {strCondicion}";
            }



            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();

            try
            {
                AbrirBd();
                adapter.Fill(dt);
                int numRegistros = dt.Rows.Count;
                MessageBox.Show($"Número de registros leídos: {numRegistros}");  // Muestra cuántos registros fueron leídos
                Console.WriteLine($"Número de registros leídos: {numRegistros}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"error al leer la tabla: {ex.Message}");
            }
            finally
            {
                CerrarBd();
            }

            return dt;
        }



    }
}
