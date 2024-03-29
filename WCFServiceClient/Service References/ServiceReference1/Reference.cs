﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFServiceClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IData")]
    public interface IData {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IData/Add", ReplyAction="http://tempuri.org/IData/AddResponse")]
        double Add(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IData/Add", ReplyAction="http://tempuri.org/IData/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IData/Subtract", ReplyAction="http://tempuri.org/IData/SubtractResponse")]
        double Subtract(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IData/Subtract", ReplyAction="http://tempuri.org/IData/SubtractResponse")]
        System.Threading.Tasks.Task<double> SubtractAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IData/Multiply", ReplyAction="http://tempuri.org/IData/MultiplyResponse")]
        double Multiply(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IData/Multiply", ReplyAction="http://tempuri.org/IData/MultiplyResponse")]
        System.Threading.Tasks.Task<double> MultiplyAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IData/Divide", ReplyAction="http://tempuri.org/IData/DivideResponse")]
        double Divide(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IData/Divide", ReplyAction="http://tempuri.org/IData/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IData/Concat", ReplyAction="http://tempuri.org/IData/ConcatResponse")]
        string Concat(string a, string b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IData/Concat", ReplyAction="http://tempuri.org/IData/ConcatResponse")]
        System.Threading.Tasks.Task<string> ConcatAsync(string a, string b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IData/Shuffle", ReplyAction="http://tempuri.org/IData/ShuffleResponse")]
        string Shuffle(string a, string b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IData/Shuffle", ReplyAction="http://tempuri.org/IData/ShuffleResponse")]
        System.Threading.Tasks.Task<string> ShuffleAsync(string a, string b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataChannel : WCFServiceClient.ServiceReference1.IData, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataClient : System.ServiceModel.ClientBase<WCFServiceClient.ServiceReference1.IData>, WCFServiceClient.ServiceReference1.IData {
        
        public DataClient() {
        }
        
        public DataClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double n1, double n2) {
            return base.Channel.Add(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double n1, double n2) {
            return base.Channel.AddAsync(n1, n2);
        }
        
        public double Subtract(double n1, double n2) {
            return base.Channel.Subtract(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> SubtractAsync(double n1, double n2) {
            return base.Channel.SubtractAsync(n1, n2);
        }
        
        public double Multiply(double n1, double n2) {
            return base.Channel.Multiply(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyAsync(double n1, double n2) {
            return base.Channel.MultiplyAsync(n1, n2);
        }
        
        public double Divide(double n1, double n2) {
            return base.Channel.Divide(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double n1, double n2) {
            return base.Channel.DivideAsync(n1, n2);
        }
        
        public string Concat(string a, string b) {
            return base.Channel.Concat(a, b);
        }
        
        public System.Threading.Tasks.Task<string> ConcatAsync(string a, string b) {
            return base.Channel.ConcatAsync(a, b);
        }
        
        public string Shuffle(string a, string b) {
            return base.Channel.Shuffle(a, b);
        }
        
        public System.Threading.Tasks.Task<string> ShuffleAsync(string a, string b) {
            return base.Channel.ShuffleAsync(a, b);
        }
    }
}
