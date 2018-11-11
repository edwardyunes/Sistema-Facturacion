﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SisVenttas.Datos;
using System.Configuration;
using Sistema_de_Venta.Entidades;

namespace Sistema_de_Venta.Datos
{
    public class FClientes
    {
       public static DataSet GetAll()
        {
           SqlParameter[] dbParams = new SqlParameter[]
                {
                    
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FClientes_GetAll", dbParams);

        }

       public static int Insertar(Cliente cliente)
       {
           SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, cliente.Nombre),
                     FDBHelper.MakeParam("@Apellido", SqlDbType.VarChar, 0, cliente.Apellido),
                      FDBHelper.MakeParam("@Dni", SqlDbType.VarChar, 0, cliente.Dni),
                       FDBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0, cliente.Domicilio),
                       FDBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, cliente.Telefono)

                };
           return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FClientes_Insertar", dbParams));

       }

       public static int Actualizar(Cliente cliente)
       {
           SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id", SqlDbType.Int, 0, cliente.Id),
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, cliente.Nombre),
                     FDBHelper.MakeParam("@Apellido", SqlDbType.VarChar, 0, cliente.Apellido),
                      FDBHelper.MakeParam("@Dni", SqlDbType.VarChar, 0, cliente.Dni),
                       FDBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0, cliente.Domicilio),
                       FDBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, cliente.Telefono)

                };
           return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FClientes_Actualizar", dbParams));

       }

       public static int Eliminar(Cliente cliente)
       {
           SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id", SqlDbType.Int, 0, cliente.Id),

                };
           return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FClientes_Eliminar", dbParams));

       } 
    }
}