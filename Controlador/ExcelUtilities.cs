using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using System.IO;
using OfficeOpenXml;

namespace Controlador
{
    public class ExcelUtilities
    {
        // Método para exportar datos de un DataGridView a un archivo Excel
        private SLStyle CreateHeaderStyle()
        {
            SLStyle estiloEncabezado = new SLStyle();
            // Definir estilo para encabezados
            estiloEncabezado.Font.Bold = true;
            estiloEncabezado.Font.FontSize = 12;
            estiloEncabezado.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.LightGray, System.Drawing.Color.LightGray);
            estiloEncabezado.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
            estiloEncabezado.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            estiloEncabezado.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
            estiloEncabezado.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
            return estiloEncabezado;
        }

        private SLStyle CreateCellStyle()
        {
            SLStyle estiloCeldas = new SLStyle();
            // Definir estilo para las celdas de datos
            estiloCeldas.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
            estiloCeldas.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            estiloCeldas.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
            estiloCeldas.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
            return estiloCeldas;
        }

        public string ExportDataGridViewToExcel(DataGridView gridView, string nombreExcel, out string message)
        {
            SLDocument sl = new SLDocument();

            // Crear estilos
            SLStyle estiloEncabezado = CreateHeaderStyle();
            SLStyle estiloCeldas = CreateCellStyle();

            // Aplicar encabezados con estilo
            int iR = 1; // Fila 1 en Excel para el encabezado
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                sl.SetCellValue(iR, i + 1, gridView.Columns[i].HeaderText); // Colocar el nombre de la columna como encabezado
                sl.SetCellStyle(iR, i + 1, estiloEncabezado); // Aplicar el estilo a los encabezados
            }

            // Recorrer DataGridView y rellenar las filas con datos
            iR = 2; // Comenzar en la fila 2 para los datos
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        sl.SetCellValue(iR, i + 1, row.Cells[i].Value?.ToString());
                        sl.SetCellStyle(iR, i + 1, estiloCeldas); // Aplicar estilo a las celdas
                    }
                    iR++;
                }
            }

            // Ajustar el ancho de las columnas automáticamente
            for (int i = 1; i <= gridView.Columns.Count; i++)
            {
                sl.AutoFitColumn(i);
            }

            try
            {
                // Guardar el archivo Excel
                string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                string folderPath = Path.Combine(projectRoot, "Documentos");

                // Crear la carpeta si no existe
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string filePath = Path.Combine(folderPath, nombreExcel + ".xlsx");
                sl.SaveAs(filePath);
                message = "Datos exportados correctamente a Excel con estilo.";
                return message;
            }
            catch (Exception ex)
            {
                // Manejar cualquier error durante la exportación
                message = "Error al exportar a Excel: " + ex.Message;
                return message;
            }
        }

        public void CreateExcelChart(DataGridView gridView, string columnaValorY, string columnaEjeX, string nombreArchivo, out string mess)
        {
            try
            {
                // Establecer el contexto de licencia
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Datos");

                    // Pasar los datos del DataGridView a Excel
                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = gridView.Columns[i].HeaderText;
                    }

                    for (int i = 0; i < gridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < gridView.Columns.Count; j++)
                        {
                            var cellValue = gridView.Rows[i].Cells[j].Value;

                            // Comprobar si la columna es la de "Cantidad de Votos"
                            if (gridView.Columns[j].Name == columnaValorY)
                            {
                                // Convertir a número si es posible
                                if (cellValue != null && double.TryParse(cellValue.ToString(), out double numericValue))
                                {
                                    worksheet.Cells[i + 2, j + 1].Value = numericValue; // Guardar como número
                                    worksheet.Cells[i + 2, j + 1].Style.Numberformat.Format = "0"; // Formato de número
                                }
                                else
                                {
                                    worksheet.Cells[i + 2, j + 1].Value = 0; // Asignar 0 si no se puede convertir
                                }
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1].Value = cellValue?.ToString();
                            }
                        }
                    }


                    // Obtener índices de columnas
                    int indexX = gridView.Columns[columnaEjeX].Index + 1;
                    int indexY = gridView.Columns[columnaValorY].Index + 1;

                    // Crear un gráfico
                    var chart = worksheet.Drawings.AddChart(nombreArchivo, eChartType.ColumnClustered);
                    chart.Title.Text = nombreArchivo;
                    chart.SetPosition(10, 0, 2, 0);
                    chart.SetSize(400, 300);

                    // Obtener las columnas para la serie
                    var yValues = worksheet.Cells[2, indexY, gridView.Rows.Count + 1, indexY];
                    var xValues = worksheet.Cells[2, indexX, gridView.Rows.Count + 1, indexX];

                    var series = chart.Series.Add(yValues, xValues);
                    series.Header = "Cantidad de Votos";

                    // Guardar el archivo Excel
                    string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                    string folderPath = Path.Combine(projectRoot, "Documentos");

                    // Crear la carpeta si no existe
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    string filePath = Path.Combine(folderPath, nombreArchivo + ".xlsx");
                    package.SaveAs(new FileInfo(filePath));

                    mess = "Gráfica creada exitosamente y datos exportados correctamente a Excel.";
                }
            }
            catch (Exception ex)
            {
                mess = $"Ocurrió un error: {ex.Message}";
            }
        }

    }
}
