﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.WcfService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/ServerApp")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Logowanie", Namespace="http://schemas.datacontract.org/2004/07/ServerApp.DTO")]
    [System.SerializableAttribute()]
    public partial class Logowanie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CzyZalogowanyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HasloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
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
        public bool CzyZalogowany {
            get {
                return this.CzyZalogowanyField;
            }
            set {
                if ((this.CzyZalogowanyField.Equals(value) != true)) {
                    this.CzyZalogowanyField = value;
                    this.RaisePropertyChanged("CzyZalogowany");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Haslo {
            get {
                return this.HasloField;
            }
            set {
                if ((object.ReferenceEquals(this.HasloField, value) != true)) {
                    this.HasloField = value;
                    this.RaisePropertyChanged("Haslo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Uwierzytelnianie", Namespace="http://schemas.datacontract.org/2004/07/ServerApp.DTO")]
    [System.SerializableAttribute()]
    public partial class Uwierzytelnianie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Imie {
            get {
                return this.ImieField;
            }
            set {
                if ((object.ReferenceEquals(this.ImieField, value) != true)) {
                    this.ImieField = value;
                    this.RaisePropertyChanged("Imie");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FormyNauki", Namespace="http://schemas.datacontract.org/2004/07/ServerApp.DTO")]
    [System.SerializableAttribute()]
    public partial class FormyNauki : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FormaNaukiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PoziomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WybranyJezykField;
        
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
        public string FormaNauki {
            get {
                return this.FormaNaukiField;
            }
            set {
                if ((object.ReferenceEquals(this.FormaNaukiField, value) != true)) {
                    this.FormaNaukiField = value;
                    this.RaisePropertyChanged("FormaNauki");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Poziom {
            get {
                return this.PoziomField;
            }
            set {
                if ((object.ReferenceEquals(this.PoziomField, value) != true)) {
                    this.PoziomField = value;
                    this.RaisePropertyChanged("Poziom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WybranyJezyk {
            get {
                return this.WybranyJezykField;
            }
            set {
                if ((object.ReferenceEquals(this.WybranyJezykField, value) != true)) {
                    this.WybranyJezykField = value;
                    this.RaisePropertyChanged("WybranyJezyk");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Slowka", Namespace="http://schemas.datacontract.org/2004/07/ServerApp.DTO")]
    [System.SerializableAttribute()]
    public partial class Slowka : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TlumaczenieSlowkaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WprowadzoneSlowoField;
        
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
        public string TlumaczenieSlowka {
            get {
                return this.TlumaczenieSlowkaField;
            }
            set {
                if ((object.ReferenceEquals(this.TlumaczenieSlowkaField, value) != true)) {
                    this.TlumaczenieSlowkaField = value;
                    this.RaisePropertyChanged("TlumaczenieSlowka");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WprowadzoneSlowo {
            get {
                return this.WprowadzoneSlowoField;
            }
            set {
                if ((object.ReferenceEquals(this.WprowadzoneSlowoField, value) != true)) {
                    this.WprowadzoneSlowoField = value;
                    this.RaisePropertyChanged("WprowadzoneSlowo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Sesja", Namespace="http://schemas.datacontract.org/2004/07/ServerApp.DTO")]
    [System.SerializableAttribute()]
    public partial class Sesja : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CzasOstatniejAkcjiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CzasZalogowaniaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdUzytkownikaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<string> ListaTokenowField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TokenField;
        
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
        public System.DateTime CzasOstatniejAkcji {
            get {
                return this.CzasOstatniejAkcjiField;
            }
            set {
                if ((this.CzasOstatniejAkcjiField.Equals(value) != true)) {
                    this.CzasOstatniejAkcjiField = value;
                    this.RaisePropertyChanged("CzasOstatniejAkcji");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CzasZalogowania {
            get {
                return this.CzasZalogowaniaField;
            }
            set {
                if ((this.CzasZalogowaniaField.Equals(value) != true)) {
                    this.CzasZalogowaniaField = value;
                    this.RaisePropertyChanged("CzasZalogowania");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdUzytkownika {
            get {
                return this.IdUzytkownikaField;
            }
            set {
                if ((this.IdUzytkownikaField.Equals(value) != true)) {
                    this.IdUzytkownikaField = value;
                    this.RaisePropertyChanged("IdUzytkownika");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<string> ListaTokenow {
            get {
                return this.ListaTokenowField;
            }
            set {
                if ((object.ReferenceEquals(this.ListaTokenowField, value) != true)) {
                    this.ListaTokenowField = value;
                    this.RaisePropertyChanged("ListaTokenow");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Token {
            get {
                return this.TokenField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenField, value) != true)) {
                    this.TokenField = value;
                    this.RaisePropertyChanged("Token");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        ClientApp.WcfService.CompositeType GetDataUsingDataContract(ClientApp.WcfService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ClientApp.WcfService.CompositeType> GetDataUsingDataContractAsync(ClientApp.WcfService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SprawdzDaneLogowania", ReplyAction="http://tempuri.org/IService1/SprawdzDaneLogowaniaResponse")]
        bool SprawdzDaneLogowania(string login, string haslo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SprawdzDaneLogowania", ReplyAction="http://tempuri.org/IService1/SprawdzDaneLogowaniaResponse")]
        System.Threading.Tasks.Task<bool> SprawdzDaneLogowaniaAsync(string login, string haslo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrzekazDaneDoZalogowania", ReplyAction="http://tempuri.org/IService1/PrzekazDaneDoZalogowaniaResponse")]
        ClientApp.WcfService.Logowanie PrzekazDaneDoZalogowania(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PrzekazDaneDoZalogowania", ReplyAction="http://tempuri.org/IService1/PrzekazDaneDoZalogowaniaResponse")]
        System.Threading.Tasks.Task<ClientApp.WcfService.Logowanie> PrzekazDaneDoZalogowaniaAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajUzytkownika", ReplyAction="http://tempuri.org/IService1/DodajUzytkownikaResponse")]
        void DodajUzytkownika(string login, string haslo, string email, string imie, string nazwisko);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajUzytkownika", ReplyAction="http://tempuri.org/IService1/DodajUzytkownikaResponse")]
        System.Threading.Tasks.Task DodajUzytkownikaAsync(string login, string haslo, string email, string imie, string nazwisko);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PobierzLoginyMaileImiona", ReplyAction="http://tempuri.org/IService1/PobierzLoginyMaileImionaResponse")]
        System.Collections.Generic.List<ClientApp.WcfService.Uwierzytelnianie> PobierzLoginyMaileImiona();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PobierzLoginyMaileImiona", ReplyAction="http://tempuri.org/IService1/PobierzLoginyMaileImionaResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ClientApp.WcfService.Uwierzytelnianie>> PobierzLoginyMaileImionaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WyslijMailaRejestracja", ReplyAction="http://tempuri.org/IService1/WyslijMailaRejestracjaResponse")]
        void WyslijMailaRejestracja(string login, string haslo, string email, string imie, string nazwisko);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WyslijMailaRejestracja", ReplyAction="http://tempuri.org/IService1/WyslijMailaRejestracjaResponse")]
        System.Threading.Tasks.Task WyslijMailaRejestracjaAsync(string login, string haslo, string email, string imie, string nazwisko);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RozpocznijNauke", ReplyAction="http://tempuri.org/IService1/RozpocznijNaukeResponse")]
        ClientApp.WcfService.FormyNauki RozpocznijNauke(string formaNauki, string jezyk, string poziom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RozpocznijNauke", ReplyAction="http://tempuri.org/IService1/RozpocznijNaukeResponse")]
        System.Threading.Tasks.Task<ClientApp.WcfService.FormyNauki> RozpocznijNaukeAsync(string formaNauki, string jezyk, string poziom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ZwrocTlumaczenieSlowka", ReplyAction="http://tempuri.org/IService1/ZwrocTlumaczenieSlowkaResponse")]
        ClientApp.WcfService.Slowka ZwrocTlumaczenieSlowka(string slowo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ZwrocTlumaczenieSlowka", ReplyAction="http://tempuri.org/IService1/ZwrocTlumaczenieSlowkaResponse")]
        System.Threading.Tasks.Task<ClientApp.WcfService.Slowka> ZwrocTlumaczenieSlowkaAsync(string slowo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerujToken", ReplyAction="http://tempuri.org/IService1/GenerujTokenResponse")]
        ClientApp.WcfService.Sesja GenerujToken(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerujToken", ReplyAction="http://tempuri.org/IService1/GenerujTokenResponse")]
        System.Threading.Tasks.Task<ClientApp.WcfService.Sesja> GenerujTokenAsync(string login);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientApp.WcfService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientApp.WcfService.IService1>, ClientApp.WcfService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public ClientApp.WcfService.CompositeType GetDataUsingDataContract(ClientApp.WcfService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ClientApp.WcfService.CompositeType> GetDataUsingDataContractAsync(ClientApp.WcfService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public bool SprawdzDaneLogowania(string login, string haslo) {
            return base.Channel.SprawdzDaneLogowania(login, haslo);
        }
        
        public System.Threading.Tasks.Task<bool> SprawdzDaneLogowaniaAsync(string login, string haslo) {
            return base.Channel.SprawdzDaneLogowaniaAsync(login, haslo);
        }
        
        public ClientApp.WcfService.Logowanie PrzekazDaneDoZalogowania(string login) {
            return base.Channel.PrzekazDaneDoZalogowania(login);
        }
        
        public System.Threading.Tasks.Task<ClientApp.WcfService.Logowanie> PrzekazDaneDoZalogowaniaAsync(string login) {
            return base.Channel.PrzekazDaneDoZalogowaniaAsync(login);
        }
        
        public void DodajUzytkownika(string login, string haslo, string email, string imie, string nazwisko) {
            base.Channel.DodajUzytkownika(login, haslo, email, imie, nazwisko);
        }
        
        public System.Threading.Tasks.Task DodajUzytkownikaAsync(string login, string haslo, string email, string imie, string nazwisko) {
            return base.Channel.DodajUzytkownikaAsync(login, haslo, email, imie, nazwisko);
        }
        
        public System.Collections.Generic.List<ClientApp.WcfService.Uwierzytelnianie> PobierzLoginyMaileImiona() {
            return base.Channel.PobierzLoginyMaileImiona();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ClientApp.WcfService.Uwierzytelnianie>> PobierzLoginyMaileImionaAsync() {
            return base.Channel.PobierzLoginyMaileImionaAsync();
        }
        
        public void WyslijMailaRejestracja(string login, string haslo, string email, string imie, string nazwisko) {
            base.Channel.WyslijMailaRejestracja(login, haslo, email, imie, nazwisko);
        }
        
        public System.Threading.Tasks.Task WyslijMailaRejestracjaAsync(string login, string haslo, string email, string imie, string nazwisko) {
            return base.Channel.WyslijMailaRejestracjaAsync(login, haslo, email, imie, nazwisko);
        }
        
        public ClientApp.WcfService.FormyNauki RozpocznijNauke(string formaNauki, string jezyk, string poziom) {
            return base.Channel.RozpocznijNauke(formaNauki, jezyk, poziom);
        }
        
        public System.Threading.Tasks.Task<ClientApp.WcfService.FormyNauki> RozpocznijNaukeAsync(string formaNauki, string jezyk, string poziom) {
            return base.Channel.RozpocznijNaukeAsync(formaNauki, jezyk, poziom);
        }
        
        public ClientApp.WcfService.Slowka ZwrocTlumaczenieSlowka(string slowo) {
            return base.Channel.ZwrocTlumaczenieSlowka(slowo);
        }
        
        public System.Threading.Tasks.Task<ClientApp.WcfService.Slowka> ZwrocTlumaczenieSlowkaAsync(string slowo) {
            return base.Channel.ZwrocTlumaczenieSlowkaAsync(slowo);
        }
        
        public ClientApp.WcfService.Sesja GenerujToken(string login) {
            return base.Channel.GenerujToken(login);
        }
        
        public System.Threading.Tasks.Task<ClientApp.WcfService.Sesja> GenerujTokenAsync(string login) {
            return base.Channel.GenerujTokenAsync(login);
        }
    }
}
