using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Class1
    {
    }

    public class clsUser
    {

        public string Username { get; set; }

        public string Password { get; set; }

    }

    [DataContract]
    public class MessageClass
    {
        [DataMember]
        public string message { get; set; }

        [DataMember]
        public string status { get; set; }
        [DataMember]
        public int Active { get; set; }

        public enum statusmsg
        {
            error, success

        }
    }

    [DataContract]
    public class clsCustomer
    {
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public string CardNo { get; set; }
        [DataMember]
        public string RegDate { get; set; }
        [DataMember]
        public string CustomerName { get; set; }
        [DataMember]
        public string ScreenName { get; set; }
        [DataMember]
        public string AddressI { get; set; }
        [DataMember]
        public string AddressII { get; set; }
        [DataMember]
        public string TelNo { get; set; }
        [DataMember]
        public string MobileNo { get; set; }
        [DataMember]
        public string NICType { get; set; }
        [DataMember]
        public string NICNo { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public Int16 LocationID { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string Remark { get; set; }
        [DataMember]
        public string BLockYN { get; set; }
    }

    [DataContract]
    [KnownType(typeof(clsPayment))]
    public class clsPayment
    {
        [DataMember]
        public int PaymentID { get; set; }
        [DataMember]
        public string PaymentDate { get; set; }

        [DataMember]
        public int CustomerID { get; set; }
        [DataMember]
        public int LoanNo { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public double Pay_Amount { get; set; }
        [DataMember]
        public int AgentID { get; set; }
        [DataMember]
        public string CardNo { get; set; }
    }


}
