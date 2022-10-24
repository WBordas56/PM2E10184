using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PM2Examen.Models
{
    public class sitios
    {
        [PrimaryKey, AutoIncrement]
        public int  id { get; set; }    
        public string longitud { get; set; }  
        public string latitud { get; set; }
        public string descripcion { get; set; }
        public byte[] imagen { get; set; }    
    }
}
