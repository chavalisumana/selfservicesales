﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace websitefinal.getservice {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Class2", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Class2 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Service_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Service_nameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Service_id {
            get {
                return this.Service_idField;
            }
            set {
                if ((object.ReferenceEquals(this.Service_idField, value) != true)) {
                    this.Service_idField = value;
                    this.RaisePropertyChanged("Service_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Service_name {
            get {
                return this.Service_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Service_nameField, value) != true)) {
                    this.Service_nameField = value;
                    this.RaisePropertyChanged("Service_name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="getservice.Service1Soap")]
    public interface Service1Soap {
        
        // CODEGEN: Generating message contract since element name getserviceResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getservice", ReplyAction="*")]
        websitefinal.getservice.getserviceResponse getservice(websitefinal.getservice.getserviceRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getserviceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getservice", Namespace="http://tempuri.org/", Order=0)]
        public websitefinal.getservice.getserviceRequestBody Body;
        
        public getserviceRequest() {
        }
        
        public getserviceRequest(websitefinal.getservice.getserviceRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getserviceRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int cid;
        
        public getserviceRequestBody() {
        }
        
        public getserviceRequestBody(int cid) {
            this.cid = cid;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getserviceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getserviceResponse", Namespace="http://tempuri.org/", Order=0)]
        public websitefinal.getservice.getserviceResponseBody Body;
        
        public getserviceResponse() {
        }
        
        public getserviceResponse(websitefinal.getservice.getserviceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getserviceResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public websitefinal.getservice.Class2[] getserviceResult;
        
        public getserviceResponseBody() {
        }
        
        public getserviceResponseBody(websitefinal.getservice.Class2[] getserviceResult) {
            this.getserviceResult = getserviceResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : websitefinal.getservice.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<websitefinal.getservice.Service1Soap>, websitefinal.getservice.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        websitefinal.getservice.getserviceResponse websitefinal.getservice.Service1Soap.getservice(websitefinal.getservice.getserviceRequest request) {
            return base.Channel.getservice(request);
        }
        
        public websitefinal.getservice.Class2[] getservice(int cid) {
            websitefinal.getservice.getserviceRequest inValue = new websitefinal.getservice.getserviceRequest();
            inValue.Body = new websitefinal.getservice.getserviceRequestBody();
            inValue.Body.cid = cid;
            websitefinal.getservice.getserviceResponse retVal = ((websitefinal.getservice.Service1Soap)(this)).getservice(inValue);
            return retVal.Body.getserviceResult;
        }
    }
}
