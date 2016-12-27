using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
namespace ExcelPDFExporter.GlobalClass
{
    public class EXCELPDFExporter : DataTable
    {
        public string FileName { get; set; } //pdf oluşturacağımız dosya adı
        public string Text { get; set; } //dosyanın içinde oluşturacağımız pdf adı
        public int PdfRowIndex { get; set; } //pdfrowindex
        public string Path { get; set; } //settings içinden global olarak tanımlanan pathi almak için(dosya yolu global olarak projede settings içinde tutuluyor.Bu şekilde yolu değiştirmek isterseniz tüm projede kolaylıkla değiştirmiş olacaksınız.)

        /// <summary>
        /// Data table oluşturarak kolonların adlarını ekler,sonra kolonlara ait satırları doldurur
        /// </summary>
        public DataTable CreateTable(DataGridView dataGridview1)
        {
            DataTable tbl = new DataTable();
            DataRow row;
            for (int i = 0; i < dataGridview1.Columns.Count; i++)
            {
                tbl.Columns.Add(dataGridview1.Columns[i].HeaderText, typeof(string));
            }

            for (int i = 0; i < dataGridview1.Rows.Count; i++)
            {
                row = tbl.NewRow();
                for (int j = 0; j < dataGridview1.Columns.Count; j++)
                {
                    row[dataGridview1.Columns[j].HeaderText] = dataGridview1.Rows[i].Cells[j].Value;
                }
                tbl.Rows.Add(row);
            }

            return tbl;

        }

        /// <summary>
        /// verileri PDFe aktarabilmek için itextsharp kütüphanesi tanımlandı
        /// Metot yardımı ile (create table) bağlanarak data table oluşturur,data table'ı oluşturulan pdftable'a atanır.Belge oluşturulur.
        /// Oluşan pdf belgesinin dosya adı ve belge adı eklenir.Belge açılır.itextsharp kütüphanesi kullanılarak font ayarlaması yapılır.
        /// </summary>

        public void ToPdf(DataGridView dataGridView1)
        {
            DataTable dtPDF = CreateTable(dataGridView1);
            Document document = new Document();
            //string Path = set.PdfExporterPath; //dosya yolu alındı
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(Path + Text, FileMode.Create));
            document.Open();
            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 5);
            PdfPTable table = null;
            table = new PdfPTable(dataGridView1.Columns.Count);
            table.WidthPercentage = 100;
            string str = string.Empty;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                str += dataGridView1.Columns[i].HeaderText;
                if (dataGridView1.Columns.Count > i)
                    str += "+";
            }

            string str2 = str.TrimEnd('+').ToString();

            ///<summary>
            /// DataGridView kolonlarının sayısı kadar belgenin başlıkları doldurulur.
            /// Pdf hücreleri oluşturulur.Dökumandaki başlık kısmı için ilk satır oluşturulur ve colspan yapılır.
            ///</summary>

            PdfPCell cell = new PdfPCell(new Phrase(FileName));
            cell.Colspan = dataGridView1.Columns.Count;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            table.AddCell(cell);

            ///<summary>
            ///pdf tablosu hücreleri doldurulur
            ///</summary>

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                table.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText, font5));
            }


            for (int i = 0; i < dtPDF.Rows.Count; i++)
            {
                for (int j = 0; j < dtPDF.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(dtPDF.Rows[i][j].ToString(), font5));

                    PdfRowIndex++;
                }
            }
            document.Add(table);

            MessageBox.Show("Kaydınız Başarıyla Tamamlanmıştır!" + "\n" + "Kayıt Yeri" + " " + Path + Text, "Aktarım Sonucu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            document.Close();
        }

        /// <summary>
        /// Gridview_Right içindeki veriler excele kaydedilir,Microsoft.Office.Interop.Excel dll referans olarak eklendi.
        /// Excel hücreleri dolduruldu
        /// </summary>

       
    }
}


