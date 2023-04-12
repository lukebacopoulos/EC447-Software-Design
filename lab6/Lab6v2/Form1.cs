using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Lab6v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Browse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               string filePath = openFileDialog.FileName;
                Filename_box.Text = filePath;
            }
        }

        private void Enc_button_Click(object sender, EventArgs e)
        {
            // Get the input file path and key from the input boxes
            string inputFilePath = Filename_box.Text;
            string key = Key_box.Text;

            // Validate the input
           
            if (File.Exists(inputFilePath) == false)
            {
                MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter a key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Use the provided algorithm to encrypt the file
            try
            {
                if (File.Exists(inputFilePath + ".enc"))
                {
                    string message = "Output file exists. Overwrite?";
                    string title = "File Exists";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                // Open the input and output files
                using (var fin = new FileStream(inputFilePath, FileMode.Open))
                using (var fout = new FileStream(inputFilePath + ".enc", FileMode.Create))
                {
                    int rbyte;
                    int pos = 0;    //position in key string
                    int length = key.Length; //length of key
                    byte kbyte, ebyte; //encrypted byte

                    while ((rbyte = fin.ReadByte()) != -1)
                    {
                        kbyte = (byte)key[pos];
                        ebyte = (byte)(rbyte ^ kbyte);
                        fout.WriteByte(ebyte);
                        ++pos;
                        if (pos == length)
                            pos = 0;
                    }
                }
                MessageBox.Show("Operation Completed Successfully.");
            }
            catch
            {
                MessageBox.Show("Error Encrypting File.");
            }
        }
        private void Dec_button_Click(object sender, EventArgs e)
        {
            // Get the input file path and key from the input boxes
            string inputFilePath = Filename_box.Text;
            string key = Key_box.Text;

            // Validate the input
           

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter a key.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (inputFilePath.EndsWith(".enc") == false)
            {
                MessageBox.Show("Not a .enc file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Use the provided algorithm to decrypt the file
            try
            {
                inputFilePath = inputFilePath.Replace(".enc", "");
                if (File.Exists(inputFilePath))
                {
                    string message = "Output file exists. Overwrite?";
                    string title = "File Exists";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                // Open the input and output files
                using (var fin = new FileStream(inputFilePath + ".enc", FileMode.Open))
                using (var fout = new FileStream(inputFilePath, FileMode.Create))
                {
                    int rbyte;
                    int pos = 0;    //position in key string
                    int length = key.Length; //length of key
                    byte kbyte, dbyte; //decrypted byte

                    while ((rbyte = fin.ReadByte()) != -1)
                    {
                        kbyte = (byte)key[pos];
                        dbyte = (byte)(rbyte ^ kbyte);
                        fout.WriteByte(dbyte);
                        ++pos;
                        if (pos == length)
                            pos = 0;
                    }
               
                }
                MessageBox.Show("Operation Completed Successfully.");
            }
            catch
            {
                MessageBox.Show("Error Decrypting File.");
            }
        }
    }
}