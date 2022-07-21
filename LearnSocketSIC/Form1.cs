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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Socket> listClient = new List<Socket>();
        private void btnStart_Click(object sender, EventArgs e)
        {
            //Alt + Enter
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            IPEndPoint IP = new IPEndPoint(IPAddress.Any, 6789);
            server.Bind(IP);

            Thread listenThread = new Thread(() =>
            {
                while (true)
                {
                    server.Listen(100);
                    Socket client = server.Accept();
                    listClient.Add(client);

                    Thread receiveThread = new Thread(ReceiveMethod);
                    receiveThread.IsBackground = true;
                    receiveThread.Start(client);
                }
            })
            {
                IsBackground = true
            };
            listenThread.Start();

        }

        private void ReceiveMethod(Object objSocket)
        {
            while (true)
            {
                Socket client = (Socket)objSocket;
                byte[] receiveData = new byte[1024];
                client.Receive(receiveData);

                MessageContent message = (MessageContent)Deserialize(receiveData);

                lsvChat.Invoke(new Action(() =>
                {
                    lsvChat.Items.Add(message.name + " : " + message.content);
                }));
                SendToAllClient(receiveData);
            }
        }

        private void SendToAllClient(byte[] receiveData)
        {
            foreach(Socket client in listClient)
            {
                client.Send(receiveData);
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Client clientForm = new Client();
            clientForm.Show();
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
