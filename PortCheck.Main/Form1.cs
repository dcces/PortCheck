using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortCheck.Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Btn_start_Click(object sender, EventArgs e)
        {
            Check();
        }

        public void Check()
        {
            var points = new string[0];
            points = tb_ports.Text.Split(',');
            int index = 0;
            foreach (var point in points)
            {
                Task.Run(() =>
                {
                    var result = CheckPortIsOpen(tb_address.Text, int.Parse(point));
                    Call(() =>
                   {//
                       index++;
                       tb_result.AppendText($"{tb_address.Text}:{point}：端口{(result ? "打开" : "关闭")}{Environment.NewLine}" +
                           $"{(index == points.Length ? $"扫描完毕{Environment.NewLine}" : "")}");
                   });
                });
            }
        }
        public void AppendValue(string strValue)
        {
            // 无返回值无参数用MethodInvoker委托，无返回值可有参数用Action委托，有返回值可有参数用Func委托
            tb_result.BeginInvoke(new Action<string>(msg => tb_result.Text += msg),
                new object[] { strValue });
        }
        public void Call(Action action, params object[] args)

        //public void Call<T>(T t, Action action, params object[] args) where T : Control
        {
            this.BeginInvoke(action, args);
            //t.BeginInvoke(action, args);
        }

        public static bool CheckPortIsOpen(string address, int port)
        {
            var isO = false;
            try
            {
                TcpClient client = new TcpClient(address, port);
                isO = true;
                return isO;

            }
            catch (Exception e)
            {
                isO = false;
                return isO;
                throw;
            }
            finally
            {
                Console.WriteLine($"{address}:{port} {isO}");
            }
        }
    }
}
