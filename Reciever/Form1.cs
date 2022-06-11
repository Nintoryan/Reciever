using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Reciever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string _hiddenMessage;
        private void Form1_Load(object sender, EventArgs e)
        {
            new Thread(StartListening).Start();
        }
        private void StartListening()
        {
            try
            {
                IPAddress localAddr = IPAddress.Parse(GetLocalIPAddress());
                int port = 8888;
                TcpListener server = new TcpListener(localAddr, port);
                server.Start();
                Invoke(() =>
                {
                    serverSoket.Text = $"{GetLocalIPAddress()}:{port}";
                });

                while (true)
                {
                    Invoke(() =>
                    {
                        serverStatus.Text = "Статус:Ожидание подключений... ";
                    });

                    TcpClient client = server.AcceptTcpClient();

                    Invoke(() =>
                    {
                        serverStatus.Text = "Статус:Отправитель подключён.";

                    });
                    byte[] data = new byte[1024];
                    StringBuilder response = new StringBuilder();
                    Stopwatch watch = new Stopwatch();

                    NetworkStream stream = client.GetStream();
                    data[0] = (byte)stream.ReadByte();
                    switch (data[0])
                    {
                        case 0:
                            Invoke(() => { messageType.Text = "HTTP/2"; });
                            break;
                        case 1:
                            Invoke(() => { messageType.Text = "IPv4 Header"; });
                            break;
                        default:
                            Invoke(() => { messageType.Text = "Неизвестный тип пакета"; });
                            break;
                    }
                    watch.Start();
                    var byteAmount = stream.Read(data, 1, data.Length - 1);

                    watch.Stop();
                    double timeElapsed = watch.Elapsed.TotalSeconds;
                    watch.Reset();

                    Invoke(() =>
                    {
                        time.Text = $"Время передачи: {timeElapsed} с";
                        size.Text = $"Передано: {byteAmount} байт";
                        speed.Text = $"{byteAmount / timeElapsed / 1000000d} МБайт/c";
                        byteShow.Text = "";
                        var stringMessage = Encoding.UTF8.GetString(data);
                        switch (data[0])
                        {
                            case 0:
                                var httpResponse = new HTTP2Response(stringMessage);
                                bitShow.Text = httpResponse.ToString(false);
                                recievedMessage.Text = httpResponse.ToString(true);
                                hiddenMessageData.Text = httpResponse.GetHiddenBinary();
                                _hiddenMessage += httpResponse.GetHiddenBinary();
                                hiddenMessageWhole.Text += httpResponse.GetHiddenBinary();
                                hiddenText.Text = BinaryStringToUTF8(_hiddenMessage);
                                break;
                            case 1:
                                var ipv4 = new IPv4Response(stringMessage);
                                bitShow.Text = ipv4.ToString(false);
                                recievedMessage.Text = ipv4.ToString(true);
                                hiddenMessageData.Text = ipv4.GetHiddenBinary();
                                _hiddenMessage += ipv4.GetHiddenBinary();
                                hiddenMessageWhole.Text += ipv4.GetHiddenBinary();
                                hiddenText.Text = BinaryStringToUTF8(_hiddenMessage);
                                break;
                            default:
                                Invoke(() => { MessageBox.Show($"Неизвестный тип пакета",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); });
                                break;
                        }

                    });
                }
            }
            catch(Exception e)
            {
                MessageBox.Show($"{e}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void recievedMessage_TextChanged(object sender, EventArgs e)
        {
        }

        private void byteShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void serverSoket_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void messageType_TextChanged(object sender, EventArgs e)
        {

        }

        private void hiddenMessageWhole_TextChanged(object sender, EventArgs e)
        {

        }

        private string BinaryStringToUTF8(string a)
        {
            var mes = Encoding.UTF8.GetString(Regex.Split(a, "(.{8})")
                .Where(binary => !String.IsNullOrEmpty(binary))
                .Select(binary => Convert.ToByte(binary, 2))
                .ToArray());
            return mes;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}