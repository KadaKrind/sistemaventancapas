﻿using SistemaVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.MODELOS;

namespace SistemaVentas.BSS
{
    public class PersonaBss
    {
        PersonaDal dal=new PersonaDal();
        public DataTable ListarPersonaBss()
        {
            return dal.ListarPersonaDal();
        }
        public void InsertarPersonaBss(persona persona)
        {
            dal.InsertarPersonaDal(persona);
        }
        public persona ObtenerId(int id) 
        {
            return dal.ObtenerPersonaId(id);
        }
    }
}
