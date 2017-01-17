using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WebClient client = new WebClient();
            //client.Headers["Content-type"] = "application/json";
            //clsUser oUser = new clsUser() { Username = "namal", Password = "123" };
            //MemoryStream stream = new MemoryStream();
            //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(clsUser));
            //serializer.WriteObject(stream, oUser);

            //byte[] data = client.UploadData("http://124.43.22.231:8080/AthugalaService.svc/Login", "POST", stream.ToArray());

            //stream = new MemoryStream(data);
            //serializer = new DataContractJsonSerializer(typeof(MessageClass));
            //MessageClass result = (MessageClass)serializer.ReadObject(stream);


            //string xx = result.message.ToString();
            //MessageBox.Show(xx);
            Pyamrnt();
        }


        void Pyamrnt()
        {
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            clsPayment oPayment = new clsPayment() { CardNo = "000001", CustomerID = 1, LoanNo =3, PaymentDate = "07-31-2016", Pay_Amount = 200, UserID = 1, AgentID = 1 };
            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(clsPayment));
            serializer.WriteObject(stream, oPayment);

           // byte[] data = client.UploadData("http://124.43.22.231:8080/AthugalaService.svc/PaymentRecevied", "POST", stream.ToArray());
            byte[] data = client.UploadData("http://localhost:45197/AthugalaService.svc/PaymentRecevied", "POST", stream.ToArray());
        
            stream = new MemoryStream(data);
            serializer = new DataContractJsonSerializer(typeof(MessageClass));
            MessageClass result = (MessageClass)serializer.ReadObject(stream);


            string xx = result.message.ToString();
            MessageBox.Show(xx);
        }
    }
}
