using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Iteedee.ApkReader;
using System.IO;

namespace AdbApkInstaller
{
    public partial class Form1 : Form
    {
        String NomeAPK;
        public string packName;
        byte[] manifestData = null;
        byte[] resourcesData = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void SelectAPK(object sender, EventArgs e)
        {            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            packageNameLBL.Text = "Package Name: LENDO ARQUIVO";
            openFileDialog1.Filter = "APK Files|*.APK";
            openFileDialog1.Title = "Selecione um arquivo .APK";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                NomeAPK = openFileDialog1.FileName;
                using (ICSharpCode.SharpZipLib.Zip.ZipInputStream zip = new ICSharpCode.SharpZipLib.Zip.ZipInputStream(File.OpenRead(openFileDialog1.FileName)))
                {

                    using (var filestream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                    {
                        ICSharpCode.SharpZipLib.Zip.ZipFile zipfile = new ICSharpCode.SharpZipLib.Zip.ZipFile(filestream);
                        ICSharpCode.SharpZipLib.Zip.ZipEntry item;
                        try
                        {
                            while ((item = zip.GetNextEntry()) != null)
                            {
                                if (item.Name.ToLower() == "androidmanifest.xml")
                                {
                                    manifestData = new byte[50 * 1024];
                                    using (Stream strm = zipfile.GetInputStream(item))
                                    {
                                        strm.Read(manifestData, 0, manifestData.Length);
                                    }

                                }
                                if (item.Name.ToLower() == "resources.arsc")
                                {
                                    using (Stream strm = zipfile.GetInputStream(item))
                                    {
                                        using (BinaryReader s = new BinaryReader(strm))
                                        {
                                            resourcesData = s.ReadBytes((int)s.BaseStream.Length);

                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
                ApkReader apkReader = new ApkReader();
                ApkInfo info = apkReader.extractInfo(manifestData, resourcesData);
                packageNameLBL.Text = "Package Name: " + info.packageName;
                versionLBL.Text = "Version: " + info.versionName;
                installAPKBTN.Enabled = true;
            }
        }
        private void installAPKBTN_Click(object sender, EventArgs e)
        {
            installAPK();
        }
        public void installAPK()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "\\adb\\adb.exe";
            //startInfo.Arguments = " uninstall " + packName;
            startInfo.Arguments = @"install -r " + string.Format("\"{0}\"", NomeAPK);
            process.StartInfo = startInfo;
            process.Start();
            string output1 = process.StandardOutput.ReadToEnd();
            iconLBL.Text = output1;
            Console.WriteLine(output1);
            MessageBox.Show(output1, output1, MessageBoxButtons.OK, MessageBoxIcon.Information);
            process.WaitForExit();
        }
    }
}
