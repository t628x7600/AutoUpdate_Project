﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DownLoadForm
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DownLoadForm(args));
        }
    }
}
