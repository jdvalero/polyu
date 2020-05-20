using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace DiseñoTres
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
      
        

        public Conexion()
        {
            try
            {
                cn = new SqlConnection(@"Data Source=DESKTOP-NI7MF7I\SQLEXPRESS01;Initial catalog=polyuprotec;Integrated Security=true");
                cn.Open();
                MessageBox.Show("Bienvenido ");

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }

        public string insertar(int id_Carpetas, string Nombre, string Estado)
        {
            string salida = "se inserto";
            try
            {
                cmd = new SqlCommand("Insert into Carpeta(id_Carpetas,Nombre,Estado) values("+id_Carpetas+",'"+Nombre+"','"+Estado+"')",cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public int personaRegistrada( int id_Carpetas)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Carpeta where id_Carpetas="+id_Carpetas+"", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        
       
        
    }
}
