using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using ClassLibrary;
using System.Runtime.InteropServices;

namespace WindowsFormsAppCrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            listBox.SelectionMode = SelectionMode.MultiExtended;
        }
        DESCryptoServiceProvider sSecretKey;
        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Error");
            }
            string filename = openFileDialog.FileName;
            string file_specname = System.IO.Path.GetFileName(filename);
            //listBox.Items.Add("Путь: " + filename);
            listBox.Items.Add( file_specname);
        }
        private void шифруватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sSecretKey = EncryptDecrypt.GenerateKey();

            GCHandle gch = GCHandle.Alloc(sSecretKey.Key, GCHandleType.Pinned);

            EncryptDecrypt.EncryptFile(openFileDialog.FileName, (Path.GetDirectoryName(openFileDialog.FileName) + $@"\{System.IO.Path.GetFileName(openFileDialog.FileName)}.crypt"), sSecretKey);
            
            gch.Free();
        }

        private void розшифруватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncryptDecrypt.DecryptFile((Path.GetDirectoryName(openFileDialog.FileName) + $@"\{System.IO.Path.GetFileName(openFileDialog.FileName)}.crypt"), (Path.GetDirectoryName(openFileDialog.FileName) + $@"\{System.IO.Path.GetFileName(openFileDialog.FileName)}"), sSecretKey);
        }
        private void архівуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream sourceStream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
            { 
                using (FileStream targetStream = File.Create(Path.GetDirectoryName(openFileDialog.FileName) + $@"\{System.IO.Path.GetFileName(openFileDialog.FileName)}.gzar"))
                {
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        private void розархівуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream sourceStream = new FileStream(openFileDialog.FileName+ @".gzar", FileMode.OpenOrCreate))
            {
                using (FileStream targetStream = File.Create(Path.GetDirectoryName(openFileDialog.FileName) + $@"\reac{System.IO.Path.GetFileName(openFileDialog.FileName)}"))
                {
                    using (GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(targetStream);
                    }
                }
            }
        }

        private void listBox_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            for (int i = 0; i < files.Length; i++)
                listBox.Items.Add(System.IO.Path.GetFileName(files[i]));
        }
    }
}
