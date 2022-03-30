﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalManagementClient.InventoryServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Inventory", Namespace="http://schemas.datacontract.org/2004/07/HospitalManagementSystem")]
    [System.SerializableAttribute()]
    public partial class Inventory : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Inventory_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
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
        public string Inventory_Name {
            get {
                return this.Inventory_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Inventory_NameField, value) != true)) {
                    this.Inventory_NameField = value;
                    this.RaisePropertyChanged("Inventory_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InventoryServiceReference.IInventoryService")]
    public interface IInventoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetInventories", ReplyAction="http://tempuri.org/IInventoryService/GetInventoriesResponse")]
        System.Data.DataSet GetInventories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetInventories", ReplyAction="http://tempuri.org/IInventoryService/GetInventoriesResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetInventoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetInventory", ReplyAction="http://tempuri.org/IInventoryService/GetInventoryResponse")]
        HospitalManagementClient.InventoryServiceReference.Inventory GetInventory(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetInventory", ReplyAction="http://tempuri.org/IInventoryService/GetInventoryResponse")]
        System.Threading.Tasks.Task<HospitalManagementClient.InventoryServiceReference.Inventory> GetInventoryAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/AddInventory", ReplyAction="http://tempuri.org/IInventoryService/AddInventoryResponse")]
        string AddInventory(HospitalManagementClient.InventoryServiceReference.Inventory inventory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/AddInventory", ReplyAction="http://tempuri.org/IInventoryService/AddInventoryResponse")]
        System.Threading.Tasks.Task<string> AddInventoryAsync(HospitalManagementClient.InventoryServiceReference.Inventory inventory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/UpdateInventory", ReplyAction="http://tempuri.org/IInventoryService/UpdateInventoryResponse")]
        string UpdateInventory(HospitalManagementClient.InventoryServiceReference.Inventory inventory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/UpdateInventory", ReplyAction="http://tempuri.org/IInventoryService/UpdateInventoryResponse")]
        System.Threading.Tasks.Task<string> UpdateInventoryAsync(HospitalManagementClient.InventoryServiceReference.Inventory inventory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/DeleteInventory", ReplyAction="http://tempuri.org/IInventoryService/DeleteInventoryResponse")]
        string DeleteInventory(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/DeleteInventory", ReplyAction="http://tempuri.org/IInventoryService/DeleteInventoryResponse")]
        System.Threading.Tasks.Task<string> DeleteInventoryAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInventoryServiceChannel : HospitalManagementClient.InventoryServiceReference.IInventoryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InventoryServiceClient : System.ServiceModel.ClientBase<HospitalManagementClient.InventoryServiceReference.IInventoryService>, HospitalManagementClient.InventoryServiceReference.IInventoryService {
        
        public InventoryServiceClient() {
        }
        
        public InventoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InventoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetInventories() {
            return base.Channel.GetInventories();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetInventoriesAsync() {
            return base.Channel.GetInventoriesAsync();
        }
        
        public HospitalManagementClient.InventoryServiceReference.Inventory GetInventory(int id) {
            return base.Channel.GetInventory(id);
        }
        
        public System.Threading.Tasks.Task<HospitalManagementClient.InventoryServiceReference.Inventory> GetInventoryAsync(int id) {
            return base.Channel.GetInventoryAsync(id);
        }
        
        public string AddInventory(HospitalManagementClient.InventoryServiceReference.Inventory inventory) {
            return base.Channel.AddInventory(inventory);
        }
        
        public System.Threading.Tasks.Task<string> AddInventoryAsync(HospitalManagementClient.InventoryServiceReference.Inventory inventory) {
            return base.Channel.AddInventoryAsync(inventory);
        }
        
        public string UpdateInventory(HospitalManagementClient.InventoryServiceReference.Inventory inventory) {
            return base.Channel.UpdateInventory(inventory);
        }
        
        public System.Threading.Tasks.Task<string> UpdateInventoryAsync(HospitalManagementClient.InventoryServiceReference.Inventory inventory) {
            return base.Channel.UpdateInventoryAsync(inventory);
        }
        
        public string DeleteInventory(int id) {
            return base.Channel.DeleteInventory(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteInventoryAsync(int id) {
            return base.Channel.DeleteInventoryAsync(id);
        }
    }
}