using System;
using System.Linq;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace MattDoc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            filePickerDialog.ShowDialog();
            if(filePickerDialog.FileNames != null && filePickerDialog.FileNames.Any())
                filePickerDialog.FileNames.ToList().ForEach(f => fileList.Items.Add(f));
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (fileList.Items.Count <= 0)
                return;

            var doc = new PdfDocument();
            doc.Info.Title = "Matt Doc 0.1";

            foreach (var item in fileList.Items)
            {
                var filename = (string) item;
                if(filename.EndsWith(".pdf"))
                    AddPdf(filename, doc);
                else
                    AddImage(filename, doc);
            }

            var saveFile = PromptForFilenameSave();

            doc.Save(saveFile);
        }

        private string PromptForFilenameSave()
        {
            filePickerDialog.CheckFileExists = false;
            filePickerDialog.Multiselect = false;
            filePickerDialog.ShowDialog();
            filePickerDialog.CheckFileExists = true;
            filePickerDialog.Multiselect = true;
            return filePickerDialog.FileName;
        }

        private void AddImage(string filename, PdfDocument doc)
        {
            var page = doc.AddPage();

            var gfx = XGraphics.FromPdfPage(page);

            var img = XImage.FromFile(filename);

            gfx.DrawImage(img, 0, 0);
        }

        private void AddPdf(string filename, PdfDocument doc)
        {
            using (var inputDoc = PdfReader.Open(filename, PdfDocumentOpenMode.Import))
                for (int i = 0; i < inputDoc.PageCount; i++)
                    doc.AddPage(inputDoc.Pages[i]);
        }
    }
}
