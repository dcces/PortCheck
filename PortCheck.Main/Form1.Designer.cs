namespace PortCheck.Main
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_address = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_ports = new System.Windows.Forms.TextBox();
            this.lb_ports = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.lb_result = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Location = new System.Drawing.Point(36, 29);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(53, 15);
            this.lb_address.TabIndex = 0;
            this.lb_address.Text = "Ip地址";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(112, 26);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(172, 25);
            this.tb_address.TabIndex = 1;
            this.tb_address.Text = "127.0.0.1";
            // 
            // tb_ports
            // 
            this.tb_ports.Location = new System.Drawing.Point(112, 80);
            this.tb_ports.Multiline = true;
            this.tb_ports.Name = "tb_ports";
            this.tb_ports.Size = new System.Drawing.Size(172, 81);
            this.tb_ports.TabIndex = 3;
            this.tb_ports.Text = "80,21,22,23,25,53,110,443,1433,1863,2289,3306,5631,5632,5000,8080,9090";
            // 
            // lb_ports
            // 
            this.lb_ports.AutoSize = true;
            this.lb_ports.Location = new System.Drawing.Point(36, 83);
            this.lb_ports.Name = "lb_ports";
            this.lb_ports.Size = new System.Drawing.Size(37, 15);
            this.lb_ports.TabIndex = 2;
            this.lb_ports.Text = "端口";
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(112, 208);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_result.Size = new System.Drawing.Size(375, 346);
            this.tb_result.TabIndex = 4;
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Location = new System.Drawing.Point(39, 208);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(37, 15);
            this.lb_result.TabIndex = 5;
            this.lb_result.Text = "结果";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(347, 29);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(140, 132);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "测试";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 582);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.tb_ports);
            this.Controls.Add(this.lb_ports);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.lb_address);
            this.Name = "Form1";
            this.Text = "端口检测";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_ports;
        private System.Windows.Forms.Label lb_ports;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.Button btn_start;
    }
}

