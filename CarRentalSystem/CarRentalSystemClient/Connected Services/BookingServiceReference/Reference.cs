﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalSystemClient.BookingServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Booking", Namespace="http://schemas.datacontract.org/2004/07/CarRentalSystem")]
    [System.SerializableAttribute()]
    public partial class Booking : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BookingIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CarIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DriverRequiredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
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
        public int BookingId {
            get {
                return this.BookingIdField;
            }
            set {
                if ((this.BookingIdField.Equals(value) != true)) {
                    this.BookingIdField = value;
                    this.RaisePropertyChanged("BookingId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CarId {
            get {
                return this.CarIdField;
            }
            set {
                if ((this.CarIdField.Equals(value) != true)) {
                    this.CarIdField = value;
                    this.RaisePropertyChanged("CarId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool DriverRequired {
            get {
                return this.DriverRequiredField;
            }
            set {
                if ((this.DriverRequiredField.Equals(value) != true)) {
                    this.DriverRequiredField = value;
                    this.RaisePropertyChanged("DriverRequired");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndDate {
            get {
                return this.EndDateField;
            }
            set {
                if ((this.EndDateField.Equals(value) != true)) {
                    this.EndDateField = value;
                    this.RaisePropertyChanged("EndDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookingServiceReference.IBookingService")]
    public interface IBookingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/GetAllBooking", ReplyAction="http://tempuri.org/IBookingService/GetAllBookingResponse")]
        System.Data.DataSet GetAllBooking();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/GetAllBooking", ReplyAction="http://tempuri.org/IBookingService/GetAllBookingResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllBookingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/AddBooking", ReplyAction="http://tempuri.org/IBookingService/AddBookingResponse")]
        bool AddBooking(CarRentalSystemClient.BookingServiceReference.Booking booking);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/AddBooking", ReplyAction="http://tempuri.org/IBookingService/AddBookingResponse")]
        System.Threading.Tasks.Task<bool> AddBookingAsync(CarRentalSystemClient.BookingServiceReference.Booking booking);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/RemoveBooking", ReplyAction="http://tempuri.org/IBookingService/RemoveBookingResponse")]
        bool RemoveBooking(int bookingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/RemoveBooking", ReplyAction="http://tempuri.org/IBookingService/RemoveBookingResponse")]
        System.Threading.Tasks.Task<bool> RemoveBookingAsync(int bookingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/GetBookingByUserId", ReplyAction="http://tempuri.org/IBookingService/GetBookingByUserIdResponse")]
        CarRentalSystemClient.BookingServiceReference.Booking[] GetBookingByUserId(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/GetBookingByUserId", ReplyAction="http://tempuri.org/IBookingService/GetBookingByUserIdResponse")]
        System.Threading.Tasks.Task<CarRentalSystemClient.BookingServiceReference.Booking[]> GetBookingByUserIdAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/GetBookingByCarId", ReplyAction="http://tempuri.org/IBookingService/GetBookingByCarIdResponse")]
        CarRentalSystemClient.BookingServiceReference.Booking[] GetBookingByCarId(int carId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/GetBookingByCarId", ReplyAction="http://tempuri.org/IBookingService/GetBookingByCarIdResponse")]
        System.Threading.Tasks.Task<CarRentalSystemClient.BookingServiceReference.Booking[]> GetBookingByCarIdAsync(int carId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookingServiceChannel : CarRentalSystemClient.BookingServiceReference.IBookingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookingServiceClient : System.ServiceModel.ClientBase<CarRentalSystemClient.BookingServiceReference.IBookingService>, CarRentalSystemClient.BookingServiceReference.IBookingService {
        
        public BookingServiceClient() {
        }
        
        public BookingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetAllBooking() {
            return base.Channel.GetAllBooking();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllBookingAsync() {
            return base.Channel.GetAllBookingAsync();
        }
        
        public bool AddBooking(CarRentalSystemClient.BookingServiceReference.Booking booking) {
            return base.Channel.AddBooking(booking);
        }
        
        public System.Threading.Tasks.Task<bool> AddBookingAsync(CarRentalSystemClient.BookingServiceReference.Booking booking) {
            return base.Channel.AddBookingAsync(booking);
        }
        
        public bool RemoveBooking(int bookingId) {
            return base.Channel.RemoveBooking(bookingId);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveBookingAsync(int bookingId) {
            return base.Channel.RemoveBookingAsync(bookingId);
        }
        
        public CarRentalSystemClient.BookingServiceReference.Booking[] GetBookingByUserId(int userId) {
            return base.Channel.GetBookingByUserId(userId);
        }
        
        public System.Threading.Tasks.Task<CarRentalSystemClient.BookingServiceReference.Booking[]> GetBookingByUserIdAsync(int userId) {
            return base.Channel.GetBookingByUserIdAsync(userId);
        }
        
        public CarRentalSystemClient.BookingServiceReference.Booking[] GetBookingByCarId(int carId) {
            return base.Channel.GetBookingByCarId(carId);
        }
        
        public System.Threading.Tasks.Task<CarRentalSystemClient.BookingServiceReference.Booking[]> GetBookingByCarIdAsync(int carId) {
            return base.Channel.GetBookingByCarIdAsync(carId);
        }
    }
}
