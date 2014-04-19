
using DataModel;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {

        RestClient m_client;

        string baseURL = "http://localhost:9132/";
        
        public Form1()
        {
            InitializeComponent();
            m_client = new RestClient(baseURL);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var dm = TestDataGenerator.GetOneData();


            RestRequest req = new RestRequest("api/transfer");
            req.Method = Method.POST;
            req.RequestFormat = DataFormat.Json;
            req.AddHeader("content-type", "application/json");
            req.AddHeader("accept", "application/json");
            req.AddBody(dm);

            IRestResponse<DataTransfer> resp = m_client.Execute<DataTransfer>(req);

            if (resp.StatusCode == System.Net.HttpStatusCode.OK
                || resp.StatusCode == System.Net.HttpStatusCode.Created)
            {
                listBox1.Items.Add(dm.ToString());
            }

        }
    }
}
