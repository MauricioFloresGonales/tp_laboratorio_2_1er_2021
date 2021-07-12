﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class DBConexion
    {
        static private SqlConnection miConexion;
        static private SqlCommand consulta;

        static DBConexion()
        {
            DBConexion.miConexion = new SqlConnection();
            DBConexion.consulta = new SqlCommand();
            miConexion.ConnectionString = "Data Source = NOTEBOOKPIPOCA\\SQLEXPRESS; Database = TP4_Fabrica; Trusted_Connection=true;";
            DBConexion.consulta.CommandType = System.Data.CommandType.Text;
            DBConexion.consulta.Connection = DBConexion.miConexion;
        }
        public static int TraerAutos(List<Auto> listaDeAutos)
        {
            try
            {
                DBConexion.consulta.CommandText = "SELECT * FROM Autos";

                if (miConexion.State != System.Data.ConnectionState.Open)
                {
                    miConexion.Open();
                }

                SqlDataReader datos = DBConexion.consulta.ExecuteReader();

                int cargados = 0;
                while (datos.Read())
                {
                    Auto dato = new Auto(
                        int.Parse(datos["id"].ToString()),
                        datos["creado_por"].ToString().Trim(),
                        datos["nombre"].ToString().Trim(),
                        datos["carroceria_estilo"].ToString(),
                        datos["carroceria_cant_puertas"].ToString(),
                        datos["motor_tipo"].ToString(),
                        datos["rueda_tipo"].ToString(),
                        datos["rueda_tamanio"].ToString()
                        );
                    
                    if(!dato.AutoExiste(Taller.listaDeAutos))
                    {
                        Taller.AgregarUnVehiculo(dato);
                        cargados++;
                    }
                    
                }
                return cargados;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrio un error al cargar los Autos\n{ex.Message}"); ;
            }
            finally
            {
                if (miConexion.State != System.Data.ConnectionState.Closed)
                {
                    miConexion.Close();
                }
            }
        }
        public static int InsertarAuto(Auto aux)
        {
            try
            {
                DBConexion.consulta.CommandText = "INSERT INTO AUTOS values (@creado_por,@nombre,@carroceria_estilo,@carroceria_cant_puertas,@motor_tipo,@rueda_tipo,@rueda_tamanio)";

                DBConexion.consulta.Parameters.Clear();
                DBConexion.consulta.Parameters.Add(new SqlParameter("@creado_por", aux.CreadoPor));
                DBConexion.consulta.Parameters.Add(new SqlParameter("@nombre", aux.Nombre));
                DBConexion.consulta.Parameters.Add(new SqlParameter("@carroceria_estilo", aux.Carroceria.Estilo.ToString()));
                DBConexion.consulta.Parameters.Add(new SqlParameter("@carroceria_cant_puertas", aux.Carroceria.CantPuertas));
                DBConexion.consulta.Parameters.Add(new SqlParameter("@motor_tipo", aux.Motor.MotorTipo.ToString()));
                DBConexion.consulta.Parameters.Add(new SqlParameter("@rueda_tipo", aux.Ruedas.Tipo.ToString()));
                DBConexion.consulta.Parameters.Add(new SqlParameter("@rueda_tamanio", aux.Ruedas.Tamanio.ToString()));

                if (miConexion.State != System.Data.ConnectionState.Open)
                {
                    miConexion.Open();
                }

                return DBConexion.consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (miConexion.State != System.Data.ConnectionState.Closed)
                {
                    miConexion.Close();
                }
            }
        }
        public static int InsertarAutos(List<Auto> listaDeAutos)
        {
            try
            {
                int insertados = 0;
                foreach (Auto item in listaDeAutos)
                {
                    insertados += DBConexion.InsertarAuto(item);
                }
                return insertados;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
