﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clsUser", Namespace="http://schemas.datacontract.org/2004/07/LoanSystemApp")]
    [System.SerializableAttribute()]
    public partial class clsUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MessageClass", Namespace="http://schemas.datacontract.org/2004/07/LoanSystemApp")]
    [System.SerializableAttribute()]
    public partial class MessageClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string messageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string statusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Active {
            get {
                return this.ActiveField;
            }
            set {
                if ((this.ActiveField.Equals(value) != true)) {
                    this.ActiveField = value;
                    this.RaisePropertyChanged("Active");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string message {
            get {
                return this.messageField;
            }
            set {
                if ((object.ReferenceEquals(this.messageField, value) != true)) {
                    this.messageField = value;
                    this.RaisePropertyChanged("message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string status {
            get {
                return this.statusField;
            }
            set {
                if ((object.ReferenceEquals(this.statusField, value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clsAgent", Namespace="http://schemas.datacontract.org/2004/07/LoanSystemApp")]
    [System.SerializableAttribute()]
    public partial class clsAgent : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AgentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AgentUsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AgentID {
            get {
                return this.AgentIDField;
            }
            set {
                if ((this.AgentIDField.Equals(value) != true)) {
                    this.AgentIDField = value;
                    this.RaisePropertyChanged("AgentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AgentName {
            get {
                return this.AgentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.AgentNameField, value) != true)) {
                    this.AgentNameField = value;
                    this.RaisePropertyChanged("AgentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AgentUsername {
            get {
                return this.AgentUsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.AgentUsernameField, value) != true)) {
                    this.AgentUsernameField = value;
                    this.RaisePropertyChanged("AgentUsername");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clsLoan", Namespace="http://schemas.datacontract.org/2004/07/LoanSystemApp.Class")]
    [System.SerializableAttribute()]
    public partial class clsLoan : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CardNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DurationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DurationTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double GrandLoanAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float InterestField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LoanAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoanCompleteYNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoanDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LoanIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LoanNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NoOfDaysField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CardNo {
            get {
                return this.CardNoField;
            }
            set {
                if ((object.ReferenceEquals(this.CardNoField, value) != true)) {
                    this.CardNoField = value;
                    this.RaisePropertyChanged("CardNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((this.CustomerIDField.Equals(value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerName {
            get {
                return this.CustomerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerNameField, value) != true)) {
                    this.CustomerNameField = value;
                    this.RaisePropertyChanged("CustomerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Duration {
            get {
                return this.DurationField;
            }
            set {
                if ((this.DurationField.Equals(value) != true)) {
                    this.DurationField = value;
                    this.RaisePropertyChanged("Duration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DurationType {
            get {
                return this.DurationTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.DurationTypeField, value) != true)) {
                    this.DurationTypeField = value;
                    this.RaisePropertyChanged("DurationType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double GrandLoanAmount {
            get {
                return this.GrandLoanAmountField;
            }
            set {
                if ((this.GrandLoanAmountField.Equals(value) != true)) {
                    this.GrandLoanAmountField = value;
                    this.RaisePropertyChanged("GrandLoanAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Interest {
            get {
                return this.InterestField;
            }
            set {
                if ((this.InterestField.Equals(value) != true)) {
                    this.InterestField = value;
                    this.RaisePropertyChanged("Interest");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double LoanAmount {
            get {
                return this.LoanAmountField;
            }
            set {
                if ((this.LoanAmountField.Equals(value) != true)) {
                    this.LoanAmountField = value;
                    this.RaisePropertyChanged("LoanAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LoanCompleteYN {
            get {
                return this.LoanCompleteYNField;
            }
            set {
                if ((object.ReferenceEquals(this.LoanCompleteYNField, value) != true)) {
                    this.LoanCompleteYNField = value;
                    this.RaisePropertyChanged("LoanCompleteYN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LoanDate {
            get {
                return this.LoanDateField;
            }
            set {
                if ((object.ReferenceEquals(this.LoanDateField, value) != true)) {
                    this.LoanDateField = value;
                    this.RaisePropertyChanged("LoanDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LoanID {
            get {
                return this.LoanIDField;
            }
            set {
                if ((this.LoanIDField.Equals(value) != true)) {
                    this.LoanIDField = value;
                    this.RaisePropertyChanged("LoanID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LoanNo {
            get {
                return this.LoanNoField;
            }
            set {
                if ((this.LoanNoField.Equals(value) != true)) {
                    this.LoanNoField = value;
                    this.RaisePropertyChanged("LoanNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NoOfDays {
            get {
                return this.NoOfDaysField;
            }
            set {
                if ((this.NoOfDaysField.Equals(value) != true)) {
                    this.NoOfDaysField = value;
                    this.RaisePropertyChanged("NoOfDays");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((this.UserIDField.Equals(value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAthugalaService")]
    public interface IAthugalaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAthugalaService/Login", ReplyAction="http://tempuri.org/IAthugalaService/LoginResponse")]
        WindowsFormsApplication1.ServiceReference1.MessageClass Login(WindowsFormsApplication1.ServiceReference1.clsUser User);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAthugalaService/Login", ReplyAction="http://tempuri.org/IAthugalaService/LoginResponse")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.MessageClass> LoginAsync(WindowsFormsApplication1.ServiceReference1.clsUser User);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAthugalaService/GetUser", ReplyAction="http://tempuri.org/IAthugalaService/GetUserResponse")]
        WindowsFormsApplication1.ServiceReference1.clsAgent GetUser(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAthugalaService/GetUser", ReplyAction="http://tempuri.org/IAthugalaService/GetUserResponse")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.clsAgent> GetUserAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAthugalaService/GetLoanDetails", ReplyAction="http://tempuri.org/IAthugalaService/GetLoanDetailsResponse")]
        WindowsFormsApplication1.ServiceReference1.clsLoan GetLoanDetails(string CardNo, string LoanNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAthugalaService/GetLoanDetails", ReplyAction="http://tempuri.org/IAthugalaService/GetLoanDetailsResponse")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.clsLoan> GetLoanDetailsAsync(string CardNo, string LoanNo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAthugalaServiceChannel : WindowsFormsApplication1.ServiceReference1.IAthugalaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AthugalaServiceClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference1.IAthugalaService>, WindowsFormsApplication1.ServiceReference1.IAthugalaService {
        
        public AthugalaServiceClient() {
        }
        
        public AthugalaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AthugalaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AthugalaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AthugalaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsApplication1.ServiceReference1.MessageClass Login(WindowsFormsApplication1.ServiceReference1.clsUser User) {
            return base.Channel.Login(User);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.MessageClass> LoginAsync(WindowsFormsApplication1.ServiceReference1.clsUser User) {
            return base.Channel.LoginAsync(User);
        }
        
        public WindowsFormsApplication1.ServiceReference1.clsAgent GetUser(string userName) {
            return base.Channel.GetUser(userName);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.clsAgent> GetUserAsync(string userName) {
            return base.Channel.GetUserAsync(userName);
        }
        
        public WindowsFormsApplication1.ServiceReference1.clsLoan GetLoanDetails(string CardNo, string LoanNo) {
            return base.Channel.GetLoanDetails(CardNo, LoanNo);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.clsLoan> GetLoanDetailsAsync(string CardNo, string LoanNo) {
            return base.Channel.GetLoanDetailsAsync(CardNo, LoanNo);
        }
    }
}
