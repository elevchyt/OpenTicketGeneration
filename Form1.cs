using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPrinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void ExportBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ticket has been created inside C:", "Open Ticket Generation");

            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFSharp.";
            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            // TICKET CONTENTS

            // Title
            XFont fontTitle = new XFont("Verdana", 16, XFontStyle.Bold);
            gfx.DrawString("TICKET GENERATED", fontTitle, XBrushes.Black, new XRect(0, 4, page.Width, page.Height), XStringFormats.TopCenter);

            // Ticket Details
            XFont fontDetails = new XFont("Verdana", 12, XFontStyle.Regular);
            gfx.DrawString("Name: " + nameTb.Text, fontDetails, XBrushes.Black, new XRect(42, 28, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString("Date: " + dateBox.Text, fontDetails, XBrushes.Black, new XRect(42, 52, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString("Location: " + locationTb.Text, fontDetails, XBrushes.Black, new XRect(42, 76, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString("Code: " + nameTb.Text, fontDetails, XBrushes.Black, new XRect(42, 100, page.Width, page.Height), XStringFormats.TopLeft);

            // Add Logo Image
            //DrawImage(gfx, fileSpec, 0, 0, (int)page.Width, (int)page.Height);

            // Extras
            gfx.DrawString("---------------------------------------------------------------------------------------------------------------", fontDetails, XBrushes.Black, new XRect(0, 128, page.Width, page.Height), XStringFormats.TopLeft);



            // Final PDF File Save
            const string filename = "c:\\TicketExport.pdf";
            document.Save(filename);
        }

        void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
        {
            XImage image = XImage.FromFile(jpegSamplePath);
            gfx.DrawImage(image, x, y, width, height);
        }
    }
}
