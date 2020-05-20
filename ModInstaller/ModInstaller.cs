using SharpCompress.Archives;
using SharpCompress.Archives.Rar;
using SharpCompress.Archives.Zip;
using SharpCompress.Common;
using SharpCompress.Crypto;
using SharpCompress.IO;
using SharpCompress.Readers;
using SharpCompress.Writers;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ModInstaller
{
    public partial class ModInstaller : Form
    {
        private PrivateFontCollection pft = new PrivateFontCollection();
        private OpenFileDialog filechoose = new OpenFileDialog();
        private string version = null;
        private string wusername = WindowsIdentity.GetCurrent().Name.Substring(WindowsIdentity.GetCurrent().Name.LastIndexOf("\\"));
        private string appdata = null;


        public ModInstaller()
        {
            InitializeComponent();
            setupform1();
            setupFonts();
            configWindow();
            pft.AddFontFile("C:/Users/jesus/Desktop/C#/ModInstaller/ModInstaller/Resources/Montserrat-Light.ttf");
            progressBar.Visible = false;
        }

        public void setupform1()
        {
            if (cboxVersions.SelectedItem == null )
            {
                btnInstalar.Enabled = false;
            }
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = Color.FromArgb(48,48,48);
            pft.AddFontFile("C:/Users/jesus/Desktop/C#/ModInstaller/ModInstaller/Resources/Montserrat-Light.ttf");
        }

        public void configWindow()
        {
            
            appdata = $"C:\\Users\\{wusername}\\AppData\\Roaming";
            LabelBackUP.Text = "Mod Installer";
            LabelBackUP.BackColor = LabelBackUP.ForeColor = Color.FromArgb(159, 33, 33);
            LabelBackUP.ForeColor = Color.White;

            LabelModPath.ForeColor = Color.White;
            LabelModPath.Text = "Mods Path:";
            
            LabelUpload.ForeColor = Color.White;
            
            LabelVersion.Text = "Select Mod Pack Version:";
            LabelVersion.ForeColor = Color.White;

            btnInstalar.Text = "Select Version";
            btnInstalar.ForeColor = Color.FromArgb(28,28,28);

            cboxVersions.DropDownStyle = ComboBoxStyle.DropDownList;
            String[] versionsmc = {"1.7.10","1.8","1.8.8","1.8.9","add+"};
            foreach (string v in versionsmc)
            {
                cboxVersions.Items.Add(v);
            }

        }

        public void setupFonts()
        {
            LabelBackUP.Font = new Font(pft.Families[0],15);
            LabelModPath.Font = new Font(pft.Families[0],10);
            txtPath.Font = new Font(pft.Families[0],10);
            LabelUpload.Font = new Font(pft.Families[0], 10);
            LabelVersion.Font = new Font(pft.Families[0], 10);
            btnInstalar.Font = new Font(pft.Families[0], 15);
        }

        private void cbEditPath_Click(object sender, EventArgs e)
        {
            if (txtPath.Enabled is true)
            {
                txtPath.Enabled = false;
            }
            else
            {
                txtPath.Enabled = true;
            }
        }

        private void LabelUpload_MouseMove(object sender, MouseEventArgs e)
        {
            LabelUpload.ForeColor = Color.FromArgb(255, 84, 84);
        }

        private void LabelUpload_MouseLeave(object sender, EventArgs e)
        {
            LabelUpload.ForeColor = Color.FromArgb(255,255,255);
        }

        private void LabelUpload_Click(object sender, EventArgs e)
        {
            //Variables
            string getname = WindowsIdentity.GetCurrent().Name;
            string puser = getname.Substring(getname.LastIndexOf("\\") + 1);
            string initdir = $"C:/Users/{puser}/Desktop";
            
            //cuadro para buscar archivo:v
            filechoose.Title = "Select Your Mod Pack:";
            filechoose.InitialDirectory = initdir;
            filechoose.Filter = "Zip Files (*.zip)|*.zip|Rar Files (*.rar)|*.rar";

            //Colocar directorio al txt v
            if (filechoose.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = filechoose.FileName;
                txtPath.Enabled = false;
            }
            else
            {
                MessageBox.Show("No ah seleccionado el archivo!");
            }
        }

        private void cboxVersions_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnInstalar.Text = $"Instalar en Version: {cboxVersions.SelectedItem}";
            btnInstalar.Enabled = true;
        }
        
        private void btnInstalar_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;

            version = $"{cboxVersions.SelectedItem}";
            InstallFiles();
        }

        public void InstallFiles()
        {
           
            //Verificando si el archivo es rar o zip
            if (txtPath.Text != "")
            {
                btnInstalar.Text = "Creating Directory...";
                //Verificando esta creada la carpeta de los mods
                if (Directory.Exists($"{appdata}/.minecraft/mods/{version}")) { }
                else
                {
                    Directory.CreateDirectory($"{appdata}/.minecraft/mods/{version}");
                }
                //Verificando si es .rar o .zip el archivo y extrayendolo
                try
                {
                    if (RarArchive.IsRarFile(txtPath.Text))
                    {

                        var archive = RarArchive.Open(txtPath.Text);
                        btnInstalar.Text = "Installing Mods...";
                        foreach (var rentry in archive.Entries.Where(rentry => !rentry.IsDirectory))
                        {
                            rentry.WriteToDirectory($"{appdata}/.minecraft/mods/{version}/", new ExtractionOptions() { Overwrite = true });
                        }
                    }

                    else if (ZipArchive.IsZipFile(txtPath.Text))
                    {
                        var ziparchive = ZipArchive.Open(txtPath.Text);
                        btnInstalar.Text = "Installing Mods...";
                        foreach (var zentry in ziparchive.Entries.Where(zentry => !zentry.IsDirectory))
                        {
                            zentry.WriteToDirectory($"{appdata}/.minecraft/mods/{version}/", new ExtractionOptions() { Overwrite = true });
                        }
                    }
                    btnInstalar.Text = "Installed";
                    MessageBox.Show("Mods Installed Sucessfull");
                }
                catch(Exception e)
                {
                    MessageBox.Show($"Error Ocurred: {e}");
                }
            }
            else
            {
                MessageBox.Show("Error, Reasons: " +
                                "\n- The file is not rar or zip." +
                                "\n- No file has been selected.");
            }

            btnInstalar.Enabled = true;
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.Value = 0;
            Thread.Sleep(1000);
            btnInstalar.Text = "Instalar en Version";
            
        }
    }
}
