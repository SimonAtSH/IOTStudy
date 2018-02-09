using System;
using System.IO.Ports;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using log4net;

namespace DartWZSReader
{
    public partial class MainForm : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public MainForm()
        {
            InitializeComponent();
            serialPort1.DataReceived += Port_DataReceived;          //串口数据接收事件
            serialPort1.Encoding = Encoding.GetEncoding("UTF-8");   //串口接收编码
            CheckForIllegalCrossThreadCalls = false;                //
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
                serialPort1.PortName = PortComboBox.Text;            //端口号
                serialPort1.BaudRate = Convert.ToInt32(BaundRateComboBox.Text);     //波特率
                serialPort1.Open();                                                 //打开串口
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
                (buffer[0] == 0xFF) &&
                (buffer[1] == 0x17);
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
            //string str = Convert.ToString(buffer, ).ToUpper();
            //textBox1.Text = DateTime.Now.ToString("YYYY/MM/DD HH:mm:ss") + @": 0x" + (str.Length == 1 ? "0" + str : str);
            if (readBytes > 0 && CheckoutOneSequence(buffer))
            {
                int ppb = GetIntValByTwoBytes(buffer[4], buffer[5]);
                double value = (float) GetIntValByTwoBytes(buffer[4], buffer[5]) * 0.0012;
                CH2OLabel.Text = string.Format("甲醛浓度：{0} PPB, {1:#,###0.0000} mg/m3", ppb, value);

                int scopePpb = GetIntValByTwoBytes(buffer[6], buffer[7]);
                double scope = (float)scopePpb  * 0.0012;
                ScopeLabel.Text = string.Format("测量范围：{0} PPB, {1:#,###0.0000} mg/m3", scopePpb, value); 

                string strLog = SerilizeData(buffer);
                LogTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss,fff") + "\t" + strLog + "\r\n");
                Log.Info(strLog);
            }
        }

        private string SerilizeData(byte[] buffer)
        {
            string str = string.Format(
                "CH2O: {0} ppb, Scope: {1} ppb",
                GetIntValByTwoBytes(buffer[4], buffer[5]),
                GetIntValByTwoBytes(buffer[6], buffer[7]));
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
