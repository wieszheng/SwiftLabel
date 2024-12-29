﻿using System;
using Seagull.BarTender.Print;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SwiftLabel
{
    public partial class PrintForm : Form
    {
        private Engine engine = null; // The BarTender Print Engine
        private LabelFormatDocument format = null; // The currently open Format
        private List<string> listCodes;
        private string previewPath = ""; // The path to the folder where the previews will be exported.
        private string _btw_path = "";
        private string _configPath;  // 移除初始值
        private IniFile _iniFile;
   
        private Messages messages;
        
        public PrintForm()  
        {
            InitializeComponent();
            // 在构造函数中设置配置文件路径
            _configPath = Path.Combine(Application.StartupPath, "config.ini");
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            try
            {
                engine = new Engine(true);
            }
            catch (PrintEngineException exception)
            {
                // If the engine is unable to start, a PrintEngineException will be thrown.
                MessageBox.Show(this, exception.Message, Application.ProductName);
                //this.Close(); // Close this app. We cannot run without connection to an engine.
                return;
            }

            _iniFile = new IniFile(_configPath);  // 使用完整路径
            LoadConfig();

            listCodes = new List<string>();
            
            _btw_path = Application.StartupPath + "\\" + "test.btw";
            if (File.Exists(_btw_path))
            {
                fileNametBox.Text = "test.btw";
                format = engine.Documents.Open(_btw_path);

            }
            //创建临时文件夹
            // Create a temporary folder to hold the images.
            string tempPath = Path.GetTempPath(); // Something like "C:\Documents and Settings\<username>\Local Settings\Temp\"
            string newFolder;

            // It's not likely we'll have a path that already exists, but we'll check for it anyway.
            do
            {
                newFolder = Path.GetRandomFileName();
                previewPath = tempPath + newFolder; // newFolder is something crazy like "gulvwdmt.3r4"
            } while (Directory.Exists(previewPath));
            Directory.CreateDirectory(previewPath);
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;//多个文件
                dialog.Title = "请选择要打印的文件";
                dialog.Filter = "bwt文件(*.btw)|*.btw";
                dialog.InitialDirectory = Application.StartupPath;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _btw_path = dialog.FileName;
                    fileNametBox.Text = dialog.SafeFileName;
                    fileNametBox.BackColor = Color.LightGreen;

                    if (OpenBtw())
                    {
                        fileNametBox.Enabled = false;
                    }
                    else
                    {
                        fileNametBox.Enabled = true;
                    }
                }
            }
        }

        private bool OpenBtw()
        {
            string errorMessage = "";

            try
            {
                if (format != null)
                    format.Close(SaveOptions.DoNotSaveChanges);
                format = engine.Documents.Open(_btw_path);
                pictureBox.Image = null;
                if (format != null)
                {
                    format.ExportImageToFile(previewPath + @"\exp.bmp", ImageType.BMP, Seagull.BarTender.Print.ColorDepth.ColorDepth256, new Resolution(300, 300
                        ), OverwriteOptions.Overwrite);

                    Image image = Image.FromFile(previewPath + @"\exp.bmp");
                    Bitmap NmpImage = new Bitmap(image);
                    pictureBox.Image = NmpImage;
                    image.Dispose();
                }

                return true;
            }
            catch (System.Runtime.InteropServices.COMException comException)
            {
                errorMessage = String.Format("无法打开格式: {0}\nReason: {1}", _btw_path, comException.Message);
                format = null;
                MessageBox.Show(this, errorMessage, "出现错误");

                return false;
            }
        }

        private void PrintForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            engine?.Stop(SaveOptions.DoNotSaveChanges);

            // Remove the temporary path and all the images.
            if (previewPath.Length != 0)
                Directory.Delete(previewPath, true);
        }

        private void saveConfig_Click(object sender, EventArgs e)
        {
            if (passWrod.Text != "2024")
            {
                MessageBox.Show(this, "密码错误，请确认", Application.ProductName);
                return;
            }

            try
            {
                _iniFile.WriteValue("Settings", "Hint", hint.Text);
                _iniFile.WriteValue("Settings", "DataName", dataName.Text);
                _iniFile.WriteValue("Settings", "StartIndex", inputStart.Text);
                _iniFile.WriteValue("Settings", "ContinuousLength", inputContinuous.Text);
                _iniFile.WriteValue("Settings", "TotalLength", inputNum.Text);
                _iniFile.WriteValue("Settings", "VerifyText", inputText.Text);
                _iniFile.WriteValue("Settings", "VerifyEnabled", checkVerify.Checked.ToString());

                MessageBox.Show(this, "配置保存成功", Application.ProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存配置文件失败：" + ex.Message, "错误");
            }
        }


        void PrintBar(bool isPreView = false)
        {
            try
            {
                format.SubStrings.SetSubString(dataName.Text, pringData.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show("修改内容出错 " + ex.Message, "操作提示");
            }
            if (format != null)
            {
                format.ExportImageToFile(previewPath + @"\exp.bmp", ImageType.BMP, Seagull.BarTender.Print.ColorDepth.ColorDepth256, new Resolution(350, 165
                    ), OverwriteOptions.Overwrite);

                Image image = Image.FromFile(previewPath + @"\exp.bmp");
                Bitmap NmpImage = new Bitmap(image);
                pictureBox.Image = NmpImage;
                image.Dispose();
            }
            else
            {
                MessageBox.Show(this, "生成图片错误", Application.ProductName);
            }
            frontData.Text = pringData.Text;
            if (isPreView) return;

            //if (printer_comboBox.SelectedItem != null)
            //    format.PrintSetup.PrinterName = printer_comboBox.SelectedItem.ToString();
            format.Print("BarPrint" + DateTime.Now, 1);
        }


        private void pringData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && checkAutoPrint.Checked) {

                if (checkVerify.Checked)
                {
                    string substring = pringData.Text.Substring(Convert.ToInt32(inputStart.Text) -1, Convert.ToInt32(inputContinuous.Text));

                    if (pringData.Text.Length <= Convert.ToInt32(inputContinuous.Text) + Convert.ToInt32(inputStart.Text))
                    {
                        MessageBox.Show(this, "数据设置长度错误，请确认\n" + pringData.Text.Length, Application.ProductName);
                        return;
                    }
                    if (substring != inputText.Text)
                    {
                        MessageBox.Show(this, "数据取值内容错误，请确认\n" + substring, Application.ProductName);
                        return;
                    }
                    if (pringData.Text.Length != Convert.ToInt32(inputNum.Text))
                    {
                        MessageBox.Show(this, "数据取值长度错误，请确认\n" + pringData.Text.Length, Application.ProductName);
                        return;
                    }

                    PrintBar();
                }
                else
                {
                    PrintBar();
                }
                
            }
            
        }

        // 添加读取配置方法
        private void LoadConfig()
        {
            try
            {
                hintShow.Text = _iniFile.ReadValue("Settings", "Hint", "");
                hint.Text = _iniFile.ReadValue("Settings", "Hint", "");
                dataName.Text = _iniFile.ReadValue("Settings", "DataName", "");
                inputStart.Text = _iniFile.ReadValue("Settings", "StartIndex", "0");
                inputContinuous.Text = _iniFile.ReadValue("Settings", "ContinuousLength", "0");
                inputNum.Text = _iniFile.ReadValue("Settings", "TotalLength", "0");
                inputText.Text = _iniFile.ReadValue("Settings", "VerifyText", "");
                string verifyEnabled = _iniFile.ReadValue("Settings", "VerifyEnabled", "False");
                checkVerify.Checked = bool.Parse(verifyEnabled);
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取配置文件失败：" + ex.Message, "错误");
            }
        }
    }
}