﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bullshit.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Bullshit.Db")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Bullshit.ServiceReference1.Project CurrentProjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool RightField;
        
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
        public Bullshit.ServiceReference1.Project CurrentProject {
            get {
                return this.CurrentProjectField;
            }
            set {
                if ((object.ReferenceEquals(this.CurrentProjectField, value) != true)) {
                    this.CurrentProjectField = value;
                    this.RaisePropertyChanged("CurrentProject");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gmail {
            get {
                return this.GmailField;
            }
            set {
                if ((object.ReferenceEquals(this.GmailField, value) != true)) {
                    this.GmailField = value;
                    this.RaisePropertyChanged("Gmail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
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
        public bool Right {
            get {
                return this.RightField;
            }
            set {
                if ((this.RightField.Equals(value) != true)) {
                    this.RightField = value;
                    this.RaisePropertyChanged("Right");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Project", Namespace="http://schemas.datacontract.org/2004/07/Server_WCF_.Db")]
    [System.SerializableAttribute()]
    public partial class Project : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProjectNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Bullshit.ServiceReference1.User[] UsersInProjectField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProjectName {
            get {
                return this.ProjectNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProjectNameField, value) != true)) {
                    this.ProjectNameField = value;
                    this.RaisePropertyChanged("ProjectName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Bullshit.ServiceReference1.User[] UsersInProject {
            get {
                return this.UsersInProjectField;
            }
            set {
                if ((object.ReferenceEquals(this.UsersInProjectField, value) != true)) {
                    this.UsersInProjectField = value;
                    this.RaisePropertyChanged("UsersInProject");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserViewClass", Namespace="http://schemas.datacontract.org/2004/07/Server_WCF_.MyClasses")]
    [System.SerializableAttribute()]
    public partial class UserViewClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserField;
        
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
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IWcfInterface")]
    public interface IWcfInterface {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/WriteToDbOneUser", ReplyAction="http://tempuri.org/IWcfInterface/WriteToDbOneUserResponse")]
        bool WriteToDbOneUser(Bullshit.ServiceReference1.User User);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/WriteToDbOneUser", ReplyAction="http://tempuri.org/IWcfInterface/WriteToDbOneUserResponse")]
        System.Threading.Tasks.Task<bool> WriteToDbOneUserAsync(Bullshit.ServiceReference1.User User);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/ReadFromDbOneUser", ReplyAction="http://tempuri.org/IWcfInterface/ReadFromDbOneUserResponse")]
        Bullshit.ServiceReference1.User ReadFromDbOneUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/ReadFromDbOneUser", ReplyAction="http://tempuri.org/IWcfInterface/ReadFromDbOneUserResponse")]
        System.Threading.Tasks.Task<Bullshit.ServiceReference1.User> ReadFromDbOneUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/RetrunCurentStateOfProject", ReplyAction="http://tempuri.org/IWcfInterface/RetrunCurentStateOfProjectResponse")]
        Bullshit.ServiceReference1.User RetrunCurentStateOfProject(int ProjectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/RetrunCurentStateOfProject", ReplyAction="http://tempuri.org/IWcfInterface/RetrunCurentStateOfProjectResponse")]
        System.Threading.Tasks.Task<Bullshit.ServiceReference1.User> RetrunCurentStateOfProjectAsync(int ProjectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/IsLogined", ReplyAction="http://tempuri.org/IWcfInterface/IsLoginedResponse")]
        bool IsLogined(Bullshit.ServiceReference1.User user, Bullshit.ServiceReference1.Project project);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/IsLogined", ReplyAction="http://tempuri.org/IWcfInterface/IsLoginedResponse")]
        System.Threading.Tasks.Task<bool> IsLoginedAsync(Bullshit.ServiceReference1.User user, Bullshit.ServiceReference1.Project project);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/ReturnAllUsersForChat", ReplyAction="http://tempuri.org/IWcfInterface/ReturnAllUsersForChatResponse")]
        Bullshit.ServiceReference1.UserViewClass[] ReturnAllUsersForChat(int IdOfProject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/ReturnAllUsersForChat", ReplyAction="http://tempuri.org/IWcfInterface/ReturnAllUsersForChatResponse")]
        System.Threading.Tasks.Task<Bullshit.ServiceReference1.UserViewClass[]> ReturnAllUsersForChatAsync(int IdOfProject);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfInterfaceChannel : Bullshit.ServiceReference1.IWcfInterface, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfInterfaceClient : System.ServiceModel.ClientBase<Bullshit.ServiceReference1.IWcfInterface>, Bullshit.ServiceReference1.IWcfInterface {
        
        public WcfInterfaceClient() {
        }
        
        public WcfInterfaceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfInterfaceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfInterfaceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfInterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool WriteToDbOneUser(Bullshit.ServiceReference1.User User) {
            return base.Channel.WriteToDbOneUser(User);
        }
        
        public System.Threading.Tasks.Task<bool> WriteToDbOneUserAsync(Bullshit.ServiceReference1.User User) {
            return base.Channel.WriteToDbOneUserAsync(User);
        }
        
        public Bullshit.ServiceReference1.User ReadFromDbOneUser() {
            return base.Channel.ReadFromDbOneUser();
        }
        
        public System.Threading.Tasks.Task<Bullshit.ServiceReference1.User> ReadFromDbOneUserAsync() {
            return base.Channel.ReadFromDbOneUserAsync();
        }
        
        public Bullshit.ServiceReference1.User RetrunCurentStateOfProject(int ProjectId) {
            return base.Channel.RetrunCurentStateOfProject(ProjectId);
        }
        
        public System.Threading.Tasks.Task<Bullshit.ServiceReference1.User> RetrunCurentStateOfProjectAsync(int ProjectId) {
            return base.Channel.RetrunCurentStateOfProjectAsync(ProjectId);
        }
        
        public bool IsLogined(Bullshit.ServiceReference1.User user, Bullshit.ServiceReference1.Project project) {
            return base.Channel.IsLogined(user, project);
        }
        
        public System.Threading.Tasks.Task<bool> IsLoginedAsync(Bullshit.ServiceReference1.User user, Bullshit.ServiceReference1.Project project) {
            return base.Channel.IsLoginedAsync(user, project);
        }
        
        public Bullshit.ServiceReference1.UserViewClass[] ReturnAllUsersForChat(int IdOfProject) {
            return base.Channel.ReturnAllUsersForChat(IdOfProject);
        }
        
        public System.Threading.Tasks.Task<Bullshit.ServiceReference1.UserViewClass[]> ReturnAllUsersForChatAsync(int IdOfProject) {
            return base.Channel.ReturnAllUsersForChatAsync(IdOfProject);
        }
    }
}
