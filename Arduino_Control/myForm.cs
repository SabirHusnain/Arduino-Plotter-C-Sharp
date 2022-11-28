using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace Arduino_Control
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        public string yComb, y1, y2;
        public DateTime sTime, cTime;
        public TimeSpan xValue;
        public long xAxisMin = 0, xAxisMax = 15000;
        public SerialPort myPort = new SerialPort();
        Thread dataThread;
        public static string filePath = "Arduino_Plotter_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + ".csv";
        StreamWriter file;

        public void myForm_Load(object sender, EventArgs e)
        {
            config();
            pnl_Start.Show();
            pnl_Code.Hide();
            pnl_Values.Enabled = false;
            Console.WriteLine(filePath);
        }

        public void btn_Start_Click(object sender, EventArgs e)
        {
            file = new StreamWriter(@filePath, true);

            myCon();

            myPort.PortName = cmb_COM.Text;
            myPort.BaudRate = Convert.ToInt32(cmb_BR.Text);
            if (!myPort.IsOpen)
                myPort.Open();

            dataThread = new Thread(myRead);

            pnl_Start.Hide();
            pnl_Code.Hide();

            sTime = DateTime.Now;
            file.WriteLine("Time" + "," + "Analog Data" + "," + "Digital Data");
            dataThread.Start();
        }

        public void lnklbl_ArduinoCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnl_Code.Show();
            pnl_Start.Show();
        }

        public void btn_Back_Click(object sender, EventArgs e)
        {
            pnl_Code.Hide();
            pnl_Start.Show();
        }

        public void btn_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl_Code.Text);
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pnl_Values.Enabled)
            {
                Point mousePoint = new Point(e.X, e.Y);
                chart1.ChartAreas[0].CursorX.SetCursorPixelPosition(mousePoint, true);
                chart1.ChartAreas[0].CursorY.SetCursorPixelPosition(mousePoint, true);

                chart1.ChartAreas[0].CursorX.LineDashStyle = ChartDashStyle.Dash;
                chart1.ChartAreas[0].CursorY.LineDashStyle = ChartDashStyle.Dash;

                chart1.ChartAreas[0].CursorX.LineColor = Color.HotPink;
                chart1.ChartAreas[0].CursorY.LineColor = Color.HotPink;

                lblR_X_Value.Text = Convert.ToString(chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.X));
                lblR_Y_Value.Text = Convert.ToString(chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Y));
            }
            else
            {
                chart1.ChartAreas[0].CursorX.LineDashStyle = ChartDashStyle.NotSet;
                chart1.ChartAreas[0].CursorY.LineDashStyle = ChartDashStyle.NotSet;
            }
        }

        private void btn_Cursor_Click(object sender, EventArgs e)
        {
            if (!pnl_Values.Enabled)
                pnl_Values.Enabled = true;
            else
                pnl_Values.Enabled = false;
        }

        private void bnt_Pause_Click(object sender, EventArgs e)
        {

        }

        public void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void config()
        {
            string[] availablePort = SerialPort.GetPortNames();
            foreach (string myPort in availablePort)
                cmb_COM.Items.Add(myPort);
        }

        public void myCon()
        {
            btn_Start.Enabled = false;
            pnl_Config.Enabled = false;
            btn_Cursor.Enabled = true;
            btn_Pause.Enabled = true;

            Series Series1 = new Series();
            chart1.Series.Add(Series1);
            Series1.ChartType = SeriesChartType.Line;

            Series Series2 = new Series();
            chart1.Series.Add(Series2);
            Series2.ChartType = SeriesChartType.Line;

            chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;

            Series1.Name = "Analog Data";
            Series2.Name = "Digital Data";

            Series1.Color = Color.Red;
            Series2.Color = Color.Green;

            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = true;

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 1200;

            chart1.ChartAreas[0].AxisX.Minimum = xAxisMin;
            chart1.ChartAreas[0].AxisX.Maximum = xAxisMax;

            chart1.ChartAreas[0].AxisX.Interval = 2500;
            chart1.ChartAreas[0].AxisY.Interval = 200;

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.MinorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.LightGray;

            chart1.ChartAreas[0].AxisX.Title = "Time (us)";
            chart1.ChartAreas[0].AxisY.Title = "Arduino Data";
        }

        public void myRead()
        {
            while (true)
            {
                try
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        chart1.ChartAreas[0].AxisX.Minimum = xAxisMin;
                        chart1.ChartAreas[0].AxisX.Maximum = xAxisMax;
                    });

                    cTime = DateTime.Now;
                    xValue = cTime.Subtract(sTime);
                    yComb = myPort.ReadLine();
                    y1 = yComb.Substring(0, yComb.IndexOf(' '));
                    y2 = yComb.Substring(yComb.IndexOf(' ') + 1);
                    chart1.Invoke((MethodInvoker)(() => chart1.Series["Analog Data"].Points.AddXY(xValue.TotalMilliseconds, Convert.ToInt64(y1.Trim()))));
                    chart1.Invoke((MethodInvoker)(() => chart1.Series["Digital Data"].Points.AddXY(xValue.TotalMilliseconds, (Convert.ToInt64(y2.Trim())))));
                    file.WriteLine(xValue.TotalMilliseconds + "," + y1.Trim() + "," + y2.Trim());
                    yComb = y1 = y2 = null;
                    if (xValue.TotalMilliseconds > xAxisMax - 7500)
                    {
                        xAxisMin += 50;
                        xAxisMax += 50;
                    }
                }

                catch (Exception ex)
                {
                    if (myPort.IsOpen)
                        myPort.Close();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                finally
                {
                    myRead();
                }
            }
        }
    }
}