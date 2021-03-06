﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta.Entidades
{
    public class Cliente
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        private string _domicilio;

        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }
        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private string _ncf;

        public string Ncf
        {
            get { return _ncf; }
            set { _ncf = value; }
        }

        private string _tipoCliente;

        public string TipoCliente
        {
            get { return _tipoCliente; }
            set { _tipoCliente = value; }
        }

        private int _totalArtComprados;

        public int TotalArtComprados
        {
            get { return _totalArtComprados; }
            set { _totalArtComprados = value; }
        }

        private DateTime _vencimientoSecuencia;

        public DateTime VencimientoSecuencia
        {
            get { return _vencimientoSecuencia; }
            set { _vencimientoSecuencia = value; }
        }
        

        //Crédito Fiscal
        private int _rnc;

        public int Rnc
        {
            get { return _rnc; }
            set { _rnc = value; }
        }

        private string _noRSocial;

        public string NoRSocial
        {
            get { return _noRSocial; }
            set { _noRSocial = value; }
        }







        public Cliente()
        {

        }
        public Cliente (int id, string nombre, string apellido, string domicilio, string telefono, string ncf, string vencimientoSecuencia)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._domicilio = domicilio;
            this._telefono = telefono;
            this._ncf = ncf;
            this._vencimientoSecuencia = VencimientoSecuencia;
        }

    }
}
