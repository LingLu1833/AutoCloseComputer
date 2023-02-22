using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCloseComputer
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 启动定时关机程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_StartOrEnd_Click(object sender, EventArgs e)
        {
            if (button_StartOrEnd.Text.Equals("定时关机"))
            {
                DateTime dateTime = dateTimePicker_Time.Value;
                DateTime closeDateTime = DateTime.Now;
                string str;
                // 时间小于当前当前时间则认为是第二天的时间
                if (dateTime.Hour < closeDateTime.Hour)
                {
                    str = closeDateTime.AddDays(1D).ToString("yyyy-MM-dd") + " " + dateTime.Hour.ToString().PadLeft(2, '0') + ":" + dateTime.Minute.ToString().PadLeft(2, '0');
                    closeDateTime = Convert.ToDateTime(str);
                }
                else
                {
                    str = DateTime.Now.ToString("yyyy-MM-dd") + " " + dateTime.Hour.ToString().PadLeft(2, '0') + ":" + dateTime.Minute.ToString().PadLeft(2, '0');
                    closeDateTime = Convert.ToDateTime(str);
                }
                // 计算出时间差
                int seconds = Convert.ToInt32((closeDateTime - DateTime.Now).TotalSeconds);
                OperateComputer("shutdown -s -t " + seconds);
                button_StartOrEnd.Text = "取消定时";
            }
            else
            {
                OperateComputer("shutdown -a");
                button_StartOrEnd.Text = "定时关机";
            }
        }

        /// <summary>
        /// 执行cmd命令
        /// </summary>
        /// <param name="command"></param>
        private void OperateComputer(string command)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe");
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            var myProcess = new System.Diagnostics.Process();
            myProcess.StartInfo = startInfo;
            myProcess.Start();
            myProcess.StandardInput.WriteLine(command);
        }
    }
}
