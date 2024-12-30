using Incidencias.Models;
using Incidencias.PDF;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Incidencias.Forms
{
    public partial class Incidencias : Form
    {
        private List<Incidencia> listaIncidencias = new List<Incidencia>();

        public Incidencias()
        {
            InitializeComponent();
        }

        #region ======= Metodos privados =======
        private void Changed_Format_DateTimePicker(DateTimePicker dtp)
        {
            // Set the Format type and the CustomFormat string.
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd/MMMM/yyyy";
        }

        private void Clear_Incidencia()
        {
            Load_CB_Observations();
            dtp_fecha.Value = DateTime.Now;
            nup_HorasPermiso.Value = 0;
            txtB_Entrada.Text = string.Empty;
            nup_Inicio.Value = 6;
            nup_Fin.Value = 6;
            txtB_HorasTotales.Text = 0.ToString();
        }

        private void Get_CurrentPosition_TxtBox(TextBox currentContainer)
        {
            int caretPosition = currentContainer.SelectionStart;
            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        private void Load_CB_Observations()
        {
            //cb_Observaciones.Items.Clear();
            List<Observacion> listaObservaciones = new List<Observacion>();
            listaObservaciones.Add(new Observacion() { Id = 0, Descripcion = "- SELECCIONE -" });
            listaObservaciones.Add(new Observacion() { Id = 1, Descripcion = "Descanso" });
            listaObservaciones.Add(new Observacion() { Id = 2, Descripcion = "No cabina" });
            listaObservaciones.Add(new Observacion() { Id = 3, Descripcion = "No por contingencia COVID-19" });
            listaObservaciones.Add(new Observacion() { Id = 4, Descripcion = "Permiso SIN goce de sueldo" });
            listaObservaciones.Add(new Observacion() { Id = 5, Descripcion = "Trabajó" });
            listaObservaciones.Add(new Observacion() { Id = 6, Descripcion = "Día festivo, no trabajó" });
            listaObservaciones.Add(new Observacion() { Id = 7, Descripcion = "Permiso CON goce de sueldo" });
            listaObservaciones.Add(new Observacion() { Id = 8, Descripcion = "Permiso a cuenta de Vacaciones" });
            listaObservaciones = listaObservaciones.OrderBy(o => o.Descripcion).ToList();
            cb_Observaciones.ValueMember = "Id";
            cb_Observaciones.DisplayMember = "Descripcion";
            cb_Observaciones.DataSource = listaObservaciones;
        }

        private void Load_DGV_Incidencias(List<Incidencia> listaIncidencias)
        {
            dgv_Incidencias.DataSource = null;
            dgv_Incidencias.DataSource = listaIncidencias;
            //dgv_Incidencias.DataSource = listaIncidencias.Select(o => new Incidencia()
            //{
            //    ObservacionDescrip = o.Observacion.Descripcion,
            //}).ToList();
        }

        private void Show_MessageBox(string titleMessage, string errorMessage, MessageBoxIcon mbi)
        {
            MessageBox.Show(errorMessage, titleMessage, MessageBoxButtons.OK, mbi);
        }

        private bool Valid_Form_Incidencia()
        {
            if (dtp_fecha.Text == "")
            {
                Show_MessageBox("Fecha", "Fecha no puede ir vacío.", MessageBoxIcon.Warning);
                return false;
            }
            switch (((Observacion)cb_Observaciones.SelectedItem).Id)
            {
                case 0:
                    Show_MessageBox("Marieli", "Debe seleccionar criterio de Marieli.", MessageBoxIcon.Warning);
                    return false;
                case 4:
                    if (nup_HorasPermiso.Value <= 0)
                    {
                        Show_MessageBox("Horas permiso", "Las horas de permiso deben ser mayor a 0.", MessageBoxIcon.Warning);
                        return false;
                    }
                    break;
                case 7:
                    if (nup_HorasPermiso.Value <= 0)
                    {
                        Show_MessageBox("Horas permiso", "Las horas de permiso deben ser mayor a 0.", MessageBoxIcon.Warning);
                        return false;
                    }
                    break;
                default:
                    break;
            }
            if (((Observacion)cb_Observaciones.SelectedItem).Id > 0 && ((Observacion)cb_Observaciones.SelectedItem).Id != 8)
            {
                if (string.IsNullOrEmpty(txtB_Entrada.Text))
                {
                    Show_MessageBox("Entrada", "Debe indicar la hora de entrada.", MessageBoxIcon.Warning);
                    return false;
                }
                if (nup_Inicio.Value <= 0)
                {
                    Show_MessageBox("Inicio", "Debe indicar la hora de inicio.", MessageBoxIcon.Warning);
                    return false;
                }
                if (nup_Fin.Value <= 0)
                {
                    Show_MessageBox("Fin", "Debe indicar la hora de fin.", MessageBoxIcon.Warning);
                    return false;
                }
                if (nup_Fin.Value <= nup_Inicio.Value)
                {
                    Show_MessageBox("Advertencia hora fin", string.Format("La hora fin debe ser mayor a la hora de inicio ({0})", nup_Inicio.Value), MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    int horasDiferencia = (int)(nup_Inicio.Value - nup_Fin.Value);
                    txtB_HorasTotales.Text = horasDiferencia >= 0 ? 0.ToString() : Math.Abs(horasDiferencia).ToString();
                }
            }
            return true;
        }

        private bool Valid_Form_Guardar()
        {
            //if (string.IsNullOrEmpty(txtB_UsuarioCreador.Text))
            //{
            //    Show_MessageBox("Nombre", "El campo del 'Creado por' no puede estar vacío.", MessageBoxIcon.Error);
            //    return false;
            //}
            if (string.IsNullOrEmpty(txtB_Nombre.Text))
            {
                Show_MessageBox("Nombre", "El campo del 'Nombre' no puede estar vacío.", MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtB_ApePat.Text))
            {
                Show_MessageBox("Nombre", "El campo del 'Apellido paterno' no puede estar vacío.", MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtB_ApeMat.Text))
            {
                Show_MessageBox("Nombre", "El campo del 'Apellido materno' no puede estar vacío.", MessageBoxIcon.Error);
                return false;
            }
            if (listaIncidencias.Count <= 0)
            {
                Show_MessageBox("Incidencias", "Debe existir al menos una incidencia para poder 'Guardar'.", MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion

        private void txtB_Nombre_TextChanged(object sender, EventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            Get_CurrentPosition_TxtBox(currentContainer);
        }
        private void txtB_ApePat_TextChanged(object sender, EventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            Get_CurrentPosition_TxtBox(currentContainer);
        }
        private void txtB_ApeMat_TextChanged(object sender, EventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            Get_CurrentPosition_TxtBox(currentContainer);
        }
        private void txtB_UsuarioCreador_TextChanged(object sender, EventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            Get_CurrentPosition_TxtBox(currentContainer);
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Valid_Form_Incidencia())
                    return;
                Incidencia incidencia = new Incidencia();
                incidencia.Fecha = dtp_fecha.Value;
                incidencia.Observacion = (Observacion)cb_Observaciones.SelectedItem;
                incidencia.HorasPermiso = (int)nup_HorasPermiso.Value;
                incidencia.HoraEntrada = txtB_Entrada.Text;
                incidencia.HoraInicio = (int)nup_Inicio.Value;
                incidencia.HoraFin = (int)nup_Fin.Value;
                incidencia.HorasTotales = string.IsNullOrEmpty(txtB_HorasTotales.Text) ? 0 : int.Parse(txtB_HorasTotales.Text);
                //incidencia.HorasTotales += incidencia.HorasPermiso;
                listaIncidencias.Add(incidencia);
                Load_DGV_Incidencias(listaIncidencias);
                Clear_Incidencia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            Changed_Format_DateTimePicker(dtp_fecha);
        }

        private void cb_Observaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Observacion)cb_Observaciones.SelectedItem).Id == 8 || ((Observacion)cb_Observaciones.SelectedItem).Id == 0)
            {
                nup_HorasPermiso.Enabled = false;
                nup_HorasPermiso.Value = 0;
                txtB_Entrada.Enabled = false;
                nup_Inicio.Enabled = false;
                nup_Fin.Enabled = false;
                txtB_HorasTotales.Enabled = false;
            }
            else
            {
                if (((Observacion)cb_Observaciones.SelectedItem).Id == 4 || ((Observacion)cb_Observaciones.SelectedItem).Id == 7)
                    nup_HorasPermiso.Enabled = true;
                else
                {
                    nup_HorasPermiso.Enabled = false;
                    nup_HorasPermiso.Value = 0;
                }
                txtB_Entrada.Enabled = true;
                nup_Inicio.Enabled = true;
                nup_Fin.Enabled = true;
                txtB_HorasTotales.Enabled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtB_UsuarioCreador.Focus();
            dtp_fecha.Value = DateTime.Now;
            Load_DGV_Incidencias(listaIncidencias);
            Changed_Format_DateTimePicker(dtp_fecha);
            Load_CB_Observations();
        }

        private void nup_Fin_ValueChanged(object sender, EventArgs e)
        {
            if (nup_Fin.Value > nup_Inicio.Value)
            {
                int horasDiferencia = (int)(nup_Inicio.Value - nup_Fin.Value);
                txtB_HorasTotales.Text = horasDiferencia >= 0 ? 0.ToString() : Math.Abs(horasDiferencia).ToString();
            }
            else
                txtB_HorasTotales.Text = 0.ToString();
        }

        private void nup_Inicio_ValueChanged(object sender, EventArgs e)
        {
            if (nup_Fin.Value > nup_Inicio.Value)
            {
                int horasDiferencia = (int)(nup_Inicio.Value - nup_Fin.Value);
                txtB_HorasTotales.Text = horasDiferencia >= 0 ? 0.ToString() : Math.Abs(horasDiferencia).ToString();
            }
            else
                txtB_HorasTotales.Text = 0.ToString();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Valid_Form_Guardar())
                    return;
                Reporte reporte = new Reporte();
                reporte.UsuarioCreador = "TERESITA MELCHOR";
                reporte.UsuarioIncidencia = $"{txtB_Nombre.Text} {txtB_ApePat.Text} {txtB_ApeMat.Text}";
                reporte.ListaIncidencias = listaIncidencias;
                PDFIncidencia.CreatePDF_Incidencia(reporte);
                Show_MessageBox("Ok", $"Listo", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
