using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incidencias.Models
{
    public class Incidencia
    {
        private CultureInfo mx = new CultureInfo("es-MX");

        #region PRIVADAS
        private DateTime _fecha = DateTime.MinValue;
        private Observacion _observacion = new Observacion();
        private int _horasPermiso = 0;
        private string _horaEntrada = string.Empty;
        private int _horaInicio = 0;
        private int _horaFin = 0;
        private int _horasTotales = 0;

        private string _diaSemana = string.Empty;
        private string _observacionDescrip = string.Empty;
        #endregion

        #region PUBLICAS
        [DisplayName("Fecha")][Editable(false)] public virtual string FechaS { get { return Fecha.ToString("dd/MM/yyyy"); } }
        [DisplayName("Día de la semana")][Editable(false)] public virtual string DiaSemana { get { return mx.DateTimeFormat.DayNames[(int)Fecha.DayOfWeek].ToUpper(); } }
        [DisplayName("Observación descripción")][Editable(false)] public virtual string ObservacionDescrip { get { return Observacion.Descripcion; } }
        [DisplayName("Horas permiso")][Editable(false)] public virtual string HorasPermisoS { get { return HorasPermiso.ToString(); } }
        [DisplayName("Hora de entrada")][Editable(false)] public virtual string HoraEntradaS { get { return HoraEntrada; } }
        [DisplayName("Hora inicio")][Editable(false)] public virtual string HoraInicioS { get { return HoraInicio.ToString(); } }
        [DisplayName("Hora fin")][Editable(false)] public virtual string HoraFinS { get { return HoraFin.ToString(); } }
        [DisplayName("Horas totales")][Editable(false)] public virtual string HorasTotalesS { get { return HorasTotales.ToString(); } }


        [Browsable(false)]
        public DateTime Fecha { get { return _fecha; } set { _fecha = value; } }
        [Browsable(false)]
        public Observacion Observacion { get { return _observacion; } set { _observacion = value; } }
        [Browsable(false)]
        public int HorasPermiso { get { return _horasPermiso; } set { _horasPermiso = value; } }
        [Browsable(false)]
        public string HoraEntrada { get { return _horaEntrada; } set { _horaEntrada = value; } }
        [Browsable(false)]
        public int HoraInicio { get { return _horaInicio; } set { _horaInicio = value; } }
        [Browsable(false)]
        public int HoraFin { get { return _horaFin; } set { _horaFin = value; } }
        [Browsable(false)]
        public int HorasTotales { get { return _horasTotales; } set { _horasTotales = value; } }


        #endregion
    }
}