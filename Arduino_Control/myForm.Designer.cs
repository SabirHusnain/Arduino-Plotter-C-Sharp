
namespace Arduino_Control
{
    partial class myForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myForm));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pnl_Config = new System.Windows.Forms.Panel();
            this.lbl_COM = new System.Windows.Forms.Label();
            this.cmb_COM = new System.Windows.Forms.ComboBox();
            this.lbl_BaudRate = new System.Windows.Forms.Label();
            this.cmb_BR = new System.Windows.Forms.ComboBox();
            this.pnl_Start = new System.Windows.Forms.Panel();
            this.lnklbl_ArduinoCode = new System.Windows.Forms.LinkLabel();
            this.lbl_Use_Marker = new System.Windows.Forms.Label();
            this.lbl_Use = new System.Windows.Forms.Label();
            this.lbl_Des_Marker = new System.Windows.Forms.Label();
            this.lbl_Des = new System.Windows.Forms.Label();
            this.lbl_Marker = new System.Windows.Forms.Label();
            this.pnl_Code = new System.Windows.Forms.Panel();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.btn_Cursor = new System.Windows.Forms.Button();
            this.pnl_Values = new System.Windows.Forms.Panel();
            this.lbl_Y_Value = new System.Windows.Forms.Label();
            this.lbl_X_Value = new System.Windows.Forms.Label();
            this.lblR_X_Value = new System.Windows.Forms.Label();
            this.lblR_Y_Value = new System.Windows.Forms.Label();
            this.btn_Pause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnl_Config.SuspendLayout();
            this.pnl_Start.SuspendLayout();
            this.pnl_Code.SuspendLayout();
            this.pnl_Values.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1023, 480);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(883, 201);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(144, 23);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(883, 423);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(144, 23);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Close";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pnl_Config
            // 
            this.pnl_Config.BackColor = System.Drawing.Color.White;
            this.pnl_Config.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Config.Controls.Add(this.lbl_COM);
            this.pnl_Config.Controls.Add(this.cmb_COM);
            this.pnl_Config.Controls.Add(this.lbl_BaudRate);
            this.pnl_Config.Controls.Add(this.cmb_BR);
            this.pnl_Config.Location = new System.Drawing.Point(883, 89);
            this.pnl_Config.Name = "pnl_Config";
            this.pnl_Config.Size = new System.Drawing.Size(144, 106);
            this.pnl_Config.TabIndex = 5;
            // 
            // lbl_COM
            // 
            this.lbl_COM.AutoSize = true;
            this.lbl_COM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_COM.Location = new System.Drawing.Point(3, 55);
            this.lbl_COM.Name = "lbl_COM";
            this.lbl_COM.Size = new System.Drawing.Size(39, 17);
            this.lbl_COM.TabIndex = 3;
            this.lbl_COM.Text = "COM";
            // 
            // cmb_COM
            // 
            this.cmb_COM.FormattingEnabled = true;
            this.cmb_COM.Location = new System.Drawing.Point(3, 75);
            this.cmb_COM.Name = "cmb_COM";
            this.cmb_COM.Size = new System.Drawing.Size(136, 21);
            this.cmb_COM.TabIndex = 2;
            // 
            // lbl_BaudRate
            // 
            this.lbl_BaudRate.AutoSize = true;
            this.lbl_BaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BaudRate.Location = new System.Drawing.Point(3, 4);
            this.lbl_BaudRate.Name = "lbl_BaudRate";
            this.lbl_BaudRate.Size = new System.Drawing.Size(75, 17);
            this.lbl_BaudRate.TabIndex = 1;
            this.lbl_BaudRate.Text = "Baud Rate";
            // 
            // cmb_BR
            // 
            this.cmb_BR.FormattingEnabled = true;
            this.cmb_BR.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.cmb_BR.Location = new System.Drawing.Point(3, 24);
            this.cmb_BR.Name = "cmb_BR";
            this.cmb_BR.Size = new System.Drawing.Size(136, 21);
            this.cmb_BR.TabIndex = 0;
            // 
            // pnl_Start
            // 
            this.pnl_Start.BackColor = System.Drawing.Color.White;
            this.pnl_Start.Controls.Add(this.lnklbl_ArduinoCode);
            this.pnl_Start.Controls.Add(this.lbl_Use_Marker);
            this.pnl_Start.Controls.Add(this.lbl_Use);
            this.pnl_Start.Controls.Add(this.lbl_Des_Marker);
            this.pnl_Start.Controls.Add(this.lbl_Des);
            this.pnl_Start.Controls.Add(this.lbl_Marker);
            this.pnl_Start.Location = new System.Drawing.Point(21, 22);
            this.pnl_Start.Name = "pnl_Start";
            this.pnl_Start.Size = new System.Drawing.Size(772, 460);
            this.pnl_Start.TabIndex = 6;
            // 
            // lnklbl_ArduinoCode
            // 
            this.lnklbl_ArduinoCode.AutoSize = true;
            this.lnklbl_ArduinoCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklbl_ArduinoCode.Location = new System.Drawing.Point(470, 336);
            this.lnklbl_ArduinoCode.Name = "lnklbl_ArduinoCode";
            this.lnklbl_ArduinoCode.Size = new System.Drawing.Size(106, 20);
            this.lnklbl_ArduinoCode.TabIndex = 5;
            this.lnklbl_ArduinoCode.TabStop = true;
            this.lnklbl_ArduinoCode.Text = "Arduino Code";
            this.lnklbl_ArduinoCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_ArduinoCode_LinkClicked);
            // 
            // lbl_Use_Marker
            // 
            this.lbl_Use_Marker.AutoSize = true;
            this.lbl_Use_Marker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Use_Marker.Location = new System.Drawing.Point(3, 165);
            this.lbl_Use_Marker.Name = "lbl_Use_Marker";
            this.lbl_Use_Marker.Size = new System.Drawing.Size(123, 24);
            this.lbl_Use_Marker.TabIndex = 4;
            this.lbl_Use_Marker.Text = "How to Use: -";
            this.lbl_Use_Marker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Use
            // 
            this.lbl_Use.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Use.Location = new System.Drawing.Point(3, 189);
            this.lbl_Use.Name = "lbl_Use";
            this.lbl_Use.Size = new System.Drawing.Size(765, 92);
            this.lbl_Use.TabIndex = 3;
            this.lbl_Use.Text = resources.GetString("lbl_Use.Text");
            // 
            // lbl_Des_Marker
            // 
            this.lbl_Des_Marker.AutoSize = true;
            this.lbl_Des_Marker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Des_Marker.Location = new System.Drawing.Point(3, 59);
            this.lbl_Des_Marker.Name = "lbl_Des_Marker";
            this.lbl_Des_Marker.Size = new System.Drawing.Size(120, 24);
            this.lbl_Des_Marker.TabIndex = 2;
            this.lbl_Des_Marker.Text = "Description: -";
            this.lbl_Des_Marker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Des
            // 
            this.lbl_Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Des.Location = new System.Drawing.Point(3, 83);
            this.lbl_Des.Name = "lbl_Des";
            this.lbl_Des.Size = new System.Drawing.Size(765, 72);
            this.lbl_Des.TabIndex = 1;
            this.lbl_Des.Text = resources.GetString("lbl_Des.Text");
            // 
            // lbl_Marker
            // 
            this.lbl_Marker.AutoSize = true;
            this.lbl_Marker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marker.Location = new System.Drawing.Point(437, 13);
            this.lbl_Marker.Name = "lbl_Marker";
            this.lbl_Marker.Size = new System.Drawing.Size(172, 29);
            this.lbl_Marker.TabIndex = 0;
            this.lbl_Marker.Text = "Arduino Plotter";
            this.lbl_Marker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Code
            // 
            this.pnl_Code.BackColor = System.Drawing.Color.White;
            this.pnl_Code.Controls.Add(this.btn_Copy);
            this.pnl_Code.Controls.Add(this.btn_Back);
            this.pnl_Code.Controls.Add(this.lbl_Code);
            this.pnl_Code.Location = new System.Drawing.Point(837, 22);
            this.pnl_Code.Name = "pnl_Code";
            this.pnl_Code.Size = new System.Drawing.Size(190, 460);
            this.pnl_Code.TabIndex = 6;
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(6, 419);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(75, 23);
            this.btn_Copy.TabIndex = 2;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(109, 419);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Code
            // 
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.Location = new System.Drawing.Point(3, 10);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(184, 377);
            this.lbl_Code.TabIndex = 0;
            this.lbl_Code.Text = resources.GetString("lbl_Code.Text");
            // 
            // btn_Cursor
            // 
            this.btn_Cursor.Enabled = false;
            this.btn_Cursor.Location = new System.Drawing.Point(883, 383);
            this.btn_Cursor.Name = "btn_Cursor";
            this.btn_Cursor.Size = new System.Drawing.Size(144, 23);
            this.btn_Cursor.TabIndex = 8;
            this.btn_Cursor.Text = "Cursor ON/OFF";
            this.btn_Cursor.UseVisualStyleBackColor = true;
            this.btn_Cursor.Click += new System.EventHandler(this.btn_Cursor_Click);
            // 
            // pnl_Values
            // 
            this.pnl_Values.BackColor = System.Drawing.Color.White;
            this.pnl_Values.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Values.Controls.Add(this.lbl_Y_Value);
            this.pnl_Values.Controls.Add(this.lbl_X_Value);
            this.pnl_Values.Controls.Add(this.lblR_X_Value);
            this.pnl_Values.Controls.Add(this.lblR_Y_Value);
            this.pnl_Values.Location = new System.Drawing.Point(883, 271);
            this.pnl_Values.Name = "pnl_Values";
            this.pnl_Values.Size = new System.Drawing.Size(144, 106);
            this.pnl_Values.TabIndex = 6;
            // 
            // lbl_Y_Value
            // 
            this.lbl_Y_Value.AutoSize = true;
            this.lbl_Y_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Y_Value.Location = new System.Drawing.Point(3, 55);
            this.lbl_Y_Value.Name = "lbl_Y_Value";
            this.lbl_Y_Value.Size = new System.Drawing.Size(47, 17);
            this.lbl_Y_Value.TabIndex = 3;
            this.lbl_Y_Value.Text = "Y-Axis";
            // 
            // lbl_X_Value
            // 
            this.lbl_X_Value.AutoSize = true;
            this.lbl_X_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_X_Value.Location = new System.Drawing.Point(3, 4);
            this.lbl_X_Value.Name = "lbl_X_Value";
            this.lbl_X_Value.Size = new System.Drawing.Size(47, 17);
            this.lbl_X_Value.TabIndex = 1;
            this.lbl_X_Value.Text = "X-Axis";
            // 
            // lblR_X_Value
            // 
            this.lblR_X_Value.BackColor = System.Drawing.Color.White;
            this.lblR_X_Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblR_X_Value.Location = new System.Drawing.Point(3, 24);
            this.lblR_X_Value.Name = "lblR_X_Value";
            this.lblR_X_Value.Size = new System.Drawing.Size(136, 21);
            this.lblR_X_Value.TabIndex = 11;
            this.lblR_X_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblR_Y_Value
            // 
            this.lblR_Y_Value.BackColor = System.Drawing.Color.White;
            this.lblR_Y_Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblR_Y_Value.Location = new System.Drawing.Point(3, 75);
            this.lblR_Y_Value.Name = "lblR_Y_Value";
            this.lblR_Y_Value.Size = new System.Drawing.Size(136, 21);
            this.lblR_Y_Value.TabIndex = 14;
            this.lblR_Y_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Pause
            // 
            this.btn_Pause.Enabled = false;
            this.btn_Pause.Location = new System.Drawing.Point(883, 230);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(144, 23);
            this.btn_Pause.TabIndex = 9;
            this.btn_Pause.Text = "Pause/Resume";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.bnt_Pause_Click);
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1047, 504);
            this.Controls.Add(this.pnl_Code);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.pnl_Values);
            this.Controls.Add(this.btn_Cursor);
            this.Controls.Add(this.pnl_Start);
            this.Controls.Add(this.pnl_Config);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "myForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myForm";
            this.Load += new System.EventHandler(this.myForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnl_Config.ResumeLayout(false);
            this.pnl_Config.PerformLayout();
            this.pnl_Start.ResumeLayout(false);
            this.pnl_Start.PerformLayout();
            this.pnl_Code.ResumeLayout(false);
            this.pnl_Code.PerformLayout();
            this.pnl_Values.ResumeLayout(false);
            this.pnl_Values.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel pnl_Config;
        private System.Windows.Forms.Label lbl_COM;
        private System.Windows.Forms.ComboBox cmb_COM;
        private System.Windows.Forms.Label lbl_BaudRate;
        private System.Windows.Forms.ComboBox cmb_BR;
        private System.Windows.Forms.Panel pnl_Start;
        private System.Windows.Forms.Label lbl_Des;
        private System.Windows.Forms.Label lbl_Marker;
        private System.Windows.Forms.Label lbl_Use_Marker;
        private System.Windows.Forms.Label lbl_Use;
        private System.Windows.Forms.Label lbl_Des_Marker;
        private System.Windows.Forms.Panel pnl_Code;
        private System.Windows.Forms.Label lbl_Code;
        private System.Windows.Forms.LinkLabel lnklbl_ArduinoCode;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Cursor;
        private System.Windows.Forms.Panel pnl_Values;
        private System.Windows.Forms.Label lblR_X_Value;
        private System.Windows.Forms.Label lbl_X_Value;
        private System.Windows.Forms.Label lbl_Y_Value;
        private System.Windows.Forms.Label lblR_Y_Value;
        private System.Windows.Forms.Button btn_Pause;
    }
}