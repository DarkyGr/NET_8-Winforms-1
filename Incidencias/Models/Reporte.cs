using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incidencias.Models
{
    public class Reporte
    {
        #region PRIVADAS
        private string _usuarioCreador = string.Empty;
        private string _usuarioIncidencia = string.Empty;
        private string _tipoNomina = string.Empty;
        private List<Incidencia> _listaIncidencias = new List<Incidencia>();
        #endregion

        #region PUBLICAS
        public string UsuarioCreador { get { return _usuarioCreador; } set { _usuarioCreador = value; } }
        public string UsuarioIncidencia { get { return _usuarioIncidencia; } set { _usuarioIncidencia = value; } }
        public string TipoNomina { get { return _tipoNomina; } set { _tipoNomina = value; } }
        public List<Incidencia> ListaIncidencias { get { return _listaIncidencias; } set { _listaIncidencias = value; } }

        #endregion
    }
}