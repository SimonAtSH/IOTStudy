using System;
using System.IO.Ports;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using log4net;

namespace PMS5003TReader
{
    public partial class MainForm : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public MainForm()
        {
            InitializeComponent();
            serialPort1.DataReceived += Port_DataReceived;          //串口数据接收事件
            serialPort1.Encoding = Encoding.GetEncoding("UTF-8");  //串口接收编码
            CheckForIllegalCrossThreadCalls = false;               //
        }

        private string[] GetAllSeralPorts()
        {
            string[] sAllPort = null;
            try
            {
                sAllPort = SerialPort.GetPortNames();
            }
            catch (Exception ex)
            {
                throw new Exception("获取计算机COM口列表失败!\r\n错误信息:" + ex.Message);
            }
            return sAllPort;
        }
        private void OpenBbutton_Click(object sender, EventArgs e)                                      //打开串口
        {
            try
            {
                serialPort1.PortName = PortComboBox.Text;                                              //端口号
                serialPort1.BaudRate = Convert.ToInt32(BaundRateComboBox.Text);                             //波特率
                serialPort1.Open();                                                                 //打开串口
                OpenButton.Enabled = false;
                CloseButton.Enabled = true;
            }
            catch
            {
                MessageBox.Show("端口错误", "错误");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            log4net.Config.XmlConfigurator.Configure();
            Log.Info("Init");
            PortComboBox.Items.Clear();
            string[] sPorts = GetAllSeralPorts();
            PortComboBox.Items.AddRange(sPorts);
            BaundRateComboBox.Text = "9600";
        }

        bool CheckoutOneSequence(byte[] buffer)
        {
            return (buffer.Length > 0) &&
                (buffer[0] == 0x42) &&
                (buffer[1] == 0x4D) &&
                (buffer[2] == 0x00) &&
                (buffer[3] == 0x1C);
        }


        //传感器是根据两个位显示pm2.5或者pm10的值的
        private int GetIntValByTwoBytes(byte high, byte low)
        {
            int retVal = low;
            retVal += (int)(high) * 256;
            return retVal;
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buffer = new byte[serialPort1.BytesToRead]; //定义缓冲区，因为串口事件触发时有可能收到不止一个字节
            int readBytes = serialPort1.Read(buffer, 0, buffer.Length);
            //string str = Convert.ToString(buffer, 16).ToUpper();
            //textBox1.Text = DateTime.Now.ToString("YYYY/MM/DD HH:mm:ss") + @": 0x" + (str.Length == 1 ? "0" + str : str);
            if (readBytes > 0 && CheckoutOneSequence(buffer))
            {
                cfpm01Label.Text = "PM1.0: " + GetIntValByTwoBytes(buffer[4], buffer[5]) + " ug/m3";
                cfpm25Label.Text = "PM2.5: " + GetIntValByTwoBytes(buffer[6], buffer[7]) + " ug/m3";
                cfpm10Label.Text = "PM 10: " + GetIntValByTwoBytes(buffer[8], buffer[9]) + " ug/m3";

                PM01Label.Text = "PM1.0: " + GetIntValByTwoBytes(buffer[10], buffer[11]) + " ug/m3";
                PM25Label.Text = "PM2.5: " + GetIntValByTwoBytes(buffer[12], buffer[13]) + " ug/m3";
                PM10Label.Text = "PM 10: " + GetIntValByTwoBytes(buffer[14], buffer[15]) + " ug/m3";

                Count03umLabel.Text = "0.3um计数: " + GetIntValByTwoBytes(buffer[16], buffer[17]);
                Count05umLabel.Text = "0.5um计数: " + GetIntValByTwoBytes(buffer[18], buffer[19]);
                Count10umLabel.Text = "1.0um计数: " + GetIntValByTwoBytes(buffer[20], buffer[21]);
                Count25umLabel.Text = "2.5um计数: " + GetIntValByTwoBytes(buffer[22], buffer[23]);

                TempLabel.Text = "温 度: " + ((float)GetIntValByTwoBytes(buffer[24], buffer[25])) / 10 + "C";
                HumLabel.Text =  "湿 度: " + ((float)GetIntValByTwoBytes(buffer[26], buffer[27])) / 10 + "%";
                string strLog = SerilizeData(buffer);
                LogTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss,fff") + "\t" + strLog + "\r\n");
                Log.Info(strLog);
            }
        }

        private string SerilizeData(byte[] buffer)
        {
            string str = string.Format(
                "PM1.0: {0} ug/m3, PM2.5: {1} ug/m3, PM10: {2} ug/m3, PMC 0.3: {3}, PMC 0.5: {4}, PMC 1.0: {5}, PMC 2.5: {6}, Temp: {7}, Hum: {8}%",
                GetIntValByTwoBytes(buffer[10], buffer[11]),
                GetIntValByTwoBytes(buffer[12], buffer[13]),
                GetIntValByTwoBytes(buffer[14], buffer[15]),
                GetIntValByTwoBytes(buffer[16], buffer[17]),
                GetIntValByTwoBytes(buffer[18], buffer[19]),
                GetIntValByTwoBytes(buffer[20], buffer[21]),
                GetIntValByTwoBytes(buffer[22], buffer[23]),
                ((float) GetIntValByTwoBytes(buffer[24], buffer[25])) / 10,
                ((float) GetIntValByTwoBytes(buffer[26], buffer[27])) / 10);
            return str;
        }

        private void ClosePortButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();        //关闭串口        
                OpenButton.Enabled = true;
                CloseButton.Enabled = false;
            }
            catch { }
        }


    }
}
