using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnSocketSIC
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        Socket client;
        private void btnAccess_Click(object sender, EventArgs e)
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("192.168.1.46"), 6789);
            client.Connect(IP);

            Thread receiveThread = new Thread(() =>
            {
                while (true)
                {
                    byte[] receiveData = new byte[1024];
                    client.Receive(receiveData);
                    MessageContent message = (MessageContent)Deserialize(receiveData);

                    lsvChat.Invoke(new Action(() =>
                    {
                        lsvChat.Items.Add(message.name + " : " + message.content);
                    }));
                }
            });
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MessageContent message = new MessageContent();
            message.name = txbName.Text;
            message.content = txbContent.Text;
            client.Send(Serialize(message));
            txbContent.Text = "";
        }

        byte[] Serialize(Object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, obj);
            return stream.ToArray();
        }

        Object Deserialize(byte[] byteArray)
        {
            MemoryStream stream = new MemoryStream(byteArray);
            BinaryFormatter bf = new BinaryFormatter();
            return bf.Deserialize(stream);
        }
    }
}
