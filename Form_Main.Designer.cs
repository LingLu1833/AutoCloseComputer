
namespace AutoCloseComputer
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.label_Time = new System.Windows.Forms.Label();
            this.dateTimePicker_Time = new System.Windows.Forms.DateTimePicker();
            this.button_StartOrEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Time.Location = new System.Drawing.Point(18, 52);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(48, 20);
            this.label_Time.TabIndex = 0;
            this.label_Time.Text = "时间 : ";
            // 
            // dateTimePicker_Time
            // 
            this.dateTimePicker_Time.CustomFormat = "";
            this.dateTimePicker_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_Time.Location = new System.Drawing.Point(72, 50);
            this.dateTimePicker_Time.Name = "dateTimePicker_Time";
            this.dateTimePicker_Time.ShowUpDown = true;
            this.dateTimePicker_Time.Size = new System.Drawing.Size(72, 23);
            this.dateTimePicker_Time.TabIndex = 1;
            // 
            // button_StartOrEnd
            // 
            this.button_StartOrEnd.Location = new System.Drawing.Point(160, 48);
            this.button_StartOrEnd.Name = "button_StartOrEnd";
            this.button_StartOrEnd.Size = new System.Drawing.Size(75, 25);
            this.button_StartOrEnd.TabIndex = 2;
            this.button_StartOrEnd.Text = "定时关机";
            this.button_StartOrEnd.UseVisualStyleBackColor = true;
            this.button_StartOrEnd.Click += new System.EventHandler(this.button_StartOrEnd_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 122);
            this.Controls.Add(this.button_StartOrEnd);
            this.Controls.Add(this.dateTimePicker_Time);
            this.Controls.Add(this.label_Time);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电脑控制程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Time;
        private System.Windows.Forms.Button button_StartOrEnd;
    }
}

