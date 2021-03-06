﻿using System;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using AutoUpdate;
namespace TestApp
{
    public partial class TestForm : Form
    {
        /// <summary>
        /// Download information Server address
        /// </summary>
        private const string Server = @"https://raw.githubusercontent.com/t628x7600/AutoUpdate_Project/master/updateInfo.xml";
        
        /// <summary>
        /// Previous update information address
        /// </summary>
        private readonly Version local = Assembly.GetEntryAssembly().GetName().Version; 
        

        /// <summary>
        /// Download application address
        /// </summary>
        private const string DownLoadFormName = "DownLoadForm.exe";

        private string DownLoadFormFullPath = Path.Combine(Environment.CurrentDirectory,
                                                           DownLoadFormName);
        
        private Update UpdateInterface;
        
        public TestForm()
        {
            InitializeComponent();
            Uri uri = new Uri(Server);
            UpdateInterface = new AutoUpdate.Update(uri, local);
            UpdateInterface.UpdateComplete += new EventHandler(UpdateComplete);
            UpdateInterface.DoUpdate();
        }
        
        private  void UpdateComplete(object sneder,EventArgs args)
        {
            //download application path
            UpdateInterface.StartDownLoad(DownLoadFormFullPath);  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "當前版本號碼" + "\n     " + ProductVersion; 
        }

        private void btn_check_Click(object sender, EventArgs e)
        {

        }
    }
}
