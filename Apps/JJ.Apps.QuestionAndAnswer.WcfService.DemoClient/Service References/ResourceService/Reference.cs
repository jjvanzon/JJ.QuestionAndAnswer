﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Messages", Namespace="http://schemas.datacontract.org/2004/07/JJ.Apps.QuestionAndAnswer.WcfService")]
    [System.SerializableAttribute()]
    public partial class Messages : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuestionNotFoundField;
        
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
        public string QuestionNotFound {
            get {
                return this.QuestionNotFoundField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionNotFoundField, value) != true)) {
                    this.QuestionNotFoundField = value;
                    this.RaisePropertyChanged("QuestionNotFound");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Labels", Namespace="http://schemas.datacontract.org/2004/07/JJ.Apps.QuestionAndAnswer.WcfService")]
    [System.SerializableAttribute()]
    public partial class Labels : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AnswerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TheCorrectAnswerField;
        
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
        public string Answer {
            get {
                return this.AnswerField;
            }
            set {
                if ((object.ReferenceEquals(this.AnswerField, value) != true)) {
                    this.AnswerField = value;
                    this.RaisePropertyChanged("Answer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TheCorrectAnswer {
            get {
                return this.TheCorrectAnswerField;
            }
            set {
                if ((object.ReferenceEquals(this.TheCorrectAnswerField, value) != true)) {
                    this.TheCorrectAnswerField = value;
                    this.RaisePropertyChanged("TheCorrectAnswer");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Titles", Namespace="http://schemas.datacontract.org/2004/07/JJ.Apps.QuestionAndAnswer.WcfService")]
    [System.SerializableAttribute()]
    public partial class Titles : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HideAnswerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NextQuestionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuestionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuestionNotFoundField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShowAnswerField;
        
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
        public string HideAnswer {
            get {
                return this.HideAnswerField;
            }
            set {
                if ((object.ReferenceEquals(this.HideAnswerField, value) != true)) {
                    this.HideAnswerField = value;
                    this.RaisePropertyChanged("HideAnswer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NextQuestion {
            get {
                return this.NextQuestionField;
            }
            set {
                if ((object.ReferenceEquals(this.NextQuestionField, value) != true)) {
                    this.NextQuestionField = value;
                    this.RaisePropertyChanged("NextQuestion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Question {
            get {
                return this.QuestionField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionField, value) != true)) {
                    this.QuestionField = value;
                    this.RaisePropertyChanged("Question");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string QuestionNotFound {
            get {
                return this.QuestionNotFoundField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionNotFoundField, value) != true)) {
                    this.QuestionNotFoundField = value;
                    this.RaisePropertyChanged("QuestionNotFound");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShowAnswer {
            get {
                return this.ShowAnswerField;
            }
            set {
                if ((object.ReferenceEquals(this.ShowAnswerField, value) != true)) {
                    this.ShowAnswerField = value;
                    this.RaisePropertyChanged("ShowAnswer");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ResourceService.IResourceService")]
    public interface IResourceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResourceService/GetMessages", ReplyAction="http://tempuri.org/IResourceService/GetMessagesResponse")]
        JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService.Messages GetMessages(string cultureName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResourceService/GetMessages", ReplyAction="http://tempuri.org/IResourceService/GetMessagesResponse")]
        System.Threading.Tasks.Task<JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService.Messages> GetMessagesAsync(string cultureName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResourceService/GetLabels", ReplyAction="http://tempuri.org/IResourceService/GetLabelsResponse")]
        JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService.Labels GetLabels(string cultureName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResourceService/GetLabels", ReplyAction="http://tempuri.org/IResourceService/GetLabelsResponse")]
        System.Threading.Tasks.Task<JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService.Labels> GetLabelsAsync(string cultureName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResourceService/GetTitles", ReplyAction="http://tempuri.org/IResourceService/GetTitlesResponse")]
        JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService.Titles GetTitles(string cultureName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResourceService/GetTitles", ReplyAction="http://tempuri.org/IResourceService/GetTitlesResponse")]
        System.Threading.Tasks.Task<JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService.Titles> GetTitlesAsync(string cultureName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IResourceServiceChannel : JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService.IResourceService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ResourceServiceClient : System.ServiceModel.ClientBase<JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService.IResourceService>, JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService.IResourceService {
        
        public ResourceServiceClient() {
        }
        
        public ResourceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ResourceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ResourceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ResourceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService.Messages GetMessages(string cultureName) {
            return base.Channel.GetMessages(cultureName);
        }
        
        public System.Threading.Tasks.Task<JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService.Messages> GetMessagesAsync(string cultureName) {
            return base.Channel.GetMessagesAsync(cultureName);
        }
        
        public JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService.Labels GetLabels(string cultureName) {
            return base.Channel.GetLabels(cultureName);
        }
        
        public System.Threading.Tasks.Task<JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService.Labels> GetLabelsAsync(string cultureName) {
            return base.Channel.GetLabelsAsync(cultureName);
        }
        
        public JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService.Titles GetTitles(string cultureName) {
            return base.Channel.GetTitles(cultureName);
        }
        
        public System.Threading.Tasks.Task<JJ.Apps.QuestionAndAnswer.WcfService.DemoClient.ResourceService.Titles> GetTitlesAsync(string cultureName) {
            return base.Channel.GetTitlesAsync(cultureName);
        }
    }
}
