using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incidencias.Models
{
    public class Observacion
    {
        #region PRIVADAS
        private int _id = 0;
        private string _descripcion = string.Empty;
        #endregion

        #region PUBLICAS
        public int Id { get { return _id; } set { _id = value; } }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        #endregion
    }
}
