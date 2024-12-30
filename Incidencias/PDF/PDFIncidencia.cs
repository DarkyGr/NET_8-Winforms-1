using Incidencias.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Previewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incidencias.PDF
{
    public class PDFIncidencia
    {
        public static void CreatePDF_Incidencia(Reporte reporte)
        {
            try
            {
                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                // Create new Document
                Document.Create(document =>
                {
                    document.Page(page =>
                    {
                        // page.Header().Height(100).Background(Colors.Blue.Medium);
                        // page.Content().Background(Colors.Yellow.Medium);
                        // page.Footer().Height(50).Background(Colors.Red.Medium);
                        page.Margin(30);
                        // Header
                        page.Header().ShowOnce().Row(row =>
                        {
                            string startupPath = System.IO.Directory.GetCurrentDirectory();
                            startupPath = startupPath.Split("bin")[0];
                            var Fecha = DateTime.Now;
                            // Path Logo
                            var FileName = startupPath + "Resources\\incidencia.png";
                            // Convert Logo
                            byte[] logoData = System.IO.File.ReadAllBytes(FileName);
                            // Set Logo
                            row.ConstantItem(60).Image(logoData).FitWidth();
                            // Information Business
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().AlignCenter().Text("").FontSize(9);
                                col.Item().AlignCenter().Text("Incidencias").Bold().FontSize(14);
                                col.Item().AlignCenter().Text("TPrende").FontSize(9);
                            });
                            // Information Report
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().AlignCenter().Text("").FontSize(9);
                                col.Item().Border(1).BorderColor("#257272").AlignCenter().Text($"Reporte por: {reporte.UsuarioCreador.ToString()}");
                                col.Item().Border(1).Background("#ED8842").AlignCenter().Text($"Fecha: {Fecha.ToString("dd/MM/yyyy")}").FontColor("#fff");
                            });
                        });
                        // Content
                        page.Content().PaddingVertical(10).Column(col1 =>
                        {
                            var TipoNomina = "Asalariado";
                            // Info Empleado Incidencia
                            col1.Item().Column(col2 =>
                            {
                                col2.Item().Text("Información del empleado - Incidencia").Underline().Bold();
                                // Name
                                col2.Item().Text(txt =>
                                {
                                    txt.Span("Name: ").SemiBold().FontSize(10);
                                    txt.Span($"{reporte.UsuarioIncidencia}").FontSize(10);
                                });
                                // Tipo de nomina
                                col2.Item().Text(txt =>
                                {
                                    txt.Span("Tipo de nómina: ").SemiBold().FontSize(10);
                                    txt.Span($"{TipoNomina}").FontSize(10);
                                });
                            });
                            // Line
                            col1.Item().LineHorizontal(0.5f);
                            // Table
                            col1.Item().PaddingVertical(10).Table(table =>
                            {
                                // Table Columns
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                });
                                // Table headers
                                table.Header(header =>
                                {
                                    header.Cell().Background("#ED8842").Padding(10).Text("Fecha").FontColor("#fff").AlignCenter();
                                    header.Cell().Background("#ED8842").Padding(10).Text("Dia Semana").FontColor("#fff").AlignCenter();
                                    header.Cell().Background("#ED8842").Padding(10).Text("Observación").FontColor("#fff").AlignCenter();
                                    header.Cell().Background("#ED8842").Padding(10).Text("Horas Permiso").FontColor("#fff").AlignCenter();
                                    header.Cell().Background("#ED8842").Padding(10).Text("Hora Entrada").FontColor("#fff").AlignCenter();
                                    header.Cell().Background("#ED8842").Padding(10).Text("Hora Inicio").FontColor("#fff").AlignCenter();
                                    header.Cell().Background("#ED8842").Padding(10).Text("Hora Fin").FontColor("#fff").AlignCenter();
                                    header.Cell().Background("#ED8842").Padding(10).Text("Horas Totales").FontColor("#fff").AlignCenter();
                                });
                                // List
                                foreach (var item in reporte.ListaIncidencias)
                                {
                                    table.Cell().BorderBottom(0.5f).BorderColor("#d9d9d9").Padding(2).Text($"{item.FechaS.ToString()}").FontSize(10);
                                    table.Cell().BorderBottom(0.5f).BorderColor("#d9d9d9").Padding(2).Text($"{item.DiaSemana.ToString()}").FontSize(10);
                                    table.Cell().BorderBottom(0.5f).BorderColor("#d9d9d9").Padding(2).Text($"{item.ObservacionDescrip.ToString()}").FontSize(10);
                                    table.Cell().BorderBottom(0.5f).BorderColor("#d9d9d9").Padding(2).Text($"{item.HorasPermisoS.ToString()}").FontSize(10);
                                    table.Cell().BorderBottom(0.5f).BorderColor("#d9d9d9").Padding(2).Text($"{item.HoraEntradaS.ToString()}").FontSize(10);
                                    table.Cell().BorderBottom(0.5f).BorderColor("#d9d9d9").Padding(2).Text($"{item.HoraInicioS.ToString()}").FontSize(10);
                                    table.Cell().BorderBottom(0.5f).BorderColor("#d9d9d9").Padding(2).Text($"{item.HoraFinS.ToString()}").FontSize(10);
                                    table.Cell().BorderBottom(0.5f).BorderColor("#d9d9d9").Padding(2).Text($"{item.HorasTotalesS.ToString()}").FontSize(10);
                                }
                            });
                        });
                        // Footer
                        page.Footer().Height(50).AlignCenter().Text(txt =>
                        {
                            txt.Span("DarkyGr. © All rights reserved 2024").FontSize(10);
                        });
                    });
                }).GeneratePdfAndShow();
                //{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}
            }
            catch (Exception ex)
            {
                throw new WarningException(ex.Message);
            }
        }
    }
}