using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace DataParalelism
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }
        private void btnProcessImages_Click(object sender,EventArgs e)
        {
            ProcessFiles();
        }
        private void ProcessFiles()
        {
            string[] files = Directory.GetFiles(@"C:\Users\Public\Pictures\Sample Pictures", "*.jpg", SearchOption.AllDirectories);
            string newDir = @"C:\ModifiedPictures";
            Directory.CreateDirectory(newDir);
            Parallel.ForEach(files, currentFile =>
             {
                 string filename = Path.GetFileName(currentFile);
                 using (Bitmap bitmap = new Bitmap(currentFile))
                 {
                     bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                     bitmap.Save(Path.Combine(newDir, filename));
                     // this.Text = string.Format("Processing {0} on thread {1}",filename,Thread.CurrentThread.ManagedThreadId);
                     this.Invoke((Action)delegate
                     {
                         this.Text = string.Format("Processing {0} on thread {1}", filename, Thread.CurrentThread.ManagedThreadId);
                     });
                 }
             });
        }
    }
}
