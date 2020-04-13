using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MqttLib;


namespace MQTTTEST
{
    public partial class Form_MQTTTEST : Form
    {
        public Form_MQTTTEST()
        {
            InitializeComponent();
        }
        IMqtt _client;
        private void Form_MQTTTEST_Load(object sender, EventArgs e)
        {
            button_Send.Enabled = false;
            MQTT_TEST("tcp://tailor.cloudmqtt.com:15720", Guid.NewGuid().ToString(), "emkxuvxa", "iODE5Mwtuevh");
            label1.Text = Application.ExecutablePath;
        }

        private void button_Press_Click(object sender, EventArgs e)
        {           
            Start();
            button_Press.Enabled = false;
            button_Send.Enabled = true;
            
        }
        private void MQTT_TEST(string connectionString, string clientId, string username, string password)
        {
            _client = MqttClientFactory.CreateClient(connectionString, clientId, username, password);
            _client.Connected += new ConnectionDelegate(client_Connected);
            _client.ConnectionLost += new ConnectionDelegate(client_ConnectionLost);
            _client.PublishArrived += new PublishArrivedDelegate(client_PublishArrived);
            _client.PublishArrived += _client_PublishArrived;
        }

        private bool _client_PublishArrived(object sender, PublishArrivedArgs e)
        {
            throw new NotImplementedException();
        }

        private bool client_PublishArrived(object sender, PublishArrivedArgs e)
        {
            label1.Text = e.Payload;
            return true;
        }

        private void client_ConnectionLost(object sender, EventArgs e)
        {
            MessageBox.Show("Connection Lost");
        }

        private void client_Connected(object sender, EventArgs e)
        {
            RegisterOurSubscriptions();
            PublishSomething();
        }
        void Start()
        {
            _client.Connect(true);
        }

        void Stop()
        {
            if (_client.IsConnected)
            {
                _client.Disconnect();
                MessageBox.Show("Stopped!!");
            }
        }

        void RegisterOurSubscriptions()
        {
            _client.Subscribe("/Testing/topic/#", QoS.BestEfforts);
        }
        void PublishSomething()
        {
            _client.Publish("/Testing/topic/", "Hello MQTT World", QoS.BestEfforts, false);
        }
      
        private void button_Stop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            _client.Publish("/Testing/topic/", textBox_Message.Text, QoS.BestEfforts, false);
        }

        private void button_Listen_Click(object sender, EventArgs e)
        {
            
        }
    }
}
