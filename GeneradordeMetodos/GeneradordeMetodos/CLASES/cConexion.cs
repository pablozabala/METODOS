﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradordeMetodos.CLASES
{
    public static class cConexion
    {
        public static string GetConexion()
        {
            string cadena = "Data Source=SECRETARIA-2\\SQLEXPRESS;Initial Catalog=DGA;Integrated Security=True";
            return cadena;
        }
    }
}
