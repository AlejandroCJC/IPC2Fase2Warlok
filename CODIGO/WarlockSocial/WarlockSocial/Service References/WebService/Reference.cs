﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarlockSocial.WebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebServicefase/", ConfigurationName="WebService.WebServiceFase2")]
    public interface WebServiceFase2 {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nickName del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebServicefase/WebServiceFase2/RegistrarUsuarioRequest", ReplyAction="http://WebServicefase/WebServiceFase2/RegistrarUsuarioResponse")]
        WarlockSocial.WebService.RegistrarUsuarioResponse RegistrarUsuario(WarlockSocial.WebService.RegistrarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebServicefase/WebServiceFase2/RegistrarUsuarioRequest", ReplyAction="http://WebServicefase/WebServiceFase2/RegistrarUsuarioResponse")]
        System.Threading.Tasks.Task<WarlockSocial.WebService.RegistrarUsuarioResponse> RegistrarUsuarioAsync(WarlockSocial.WebService.RegistrarUsuarioRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento name del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebServicefase/WebServiceFase2/helloRequest", ReplyAction="http://WebServicefase/WebServiceFase2/helloResponse")]
        WarlockSocial.WebService.helloResponse hello(WarlockSocial.WebService.helloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebServicefase/WebServiceFase2/helloRequest", ReplyAction="http://WebServicefase/WebServiceFase2/helloResponse")]
        System.Threading.Tasks.Task<WarlockSocial.WebService.helloResponse> helloAsync(WarlockSocial.WebService.helloRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistrarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistrarUsuario", Namespace="http://WebServicefase/", Order=0)]
        public WarlockSocial.WebService.RegistrarUsuarioRequestBody Body;
        
        public RegistrarUsuarioRequest() {
        }
        
        public RegistrarUsuarioRequest(WarlockSocial.WebService.RegistrarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class RegistrarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nickName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string contrasena;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string correo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string fecha_nac;
        
        public RegistrarUsuarioRequestBody() {
        }
        
        public RegistrarUsuarioRequestBody(string nickName, string contrasena, string correo, string fecha_nac) {
            this.nickName = nickName;
            this.contrasena = contrasena;
            this.correo = correo;
            this.fecha_nac = fecha_nac;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistrarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistrarUsuarioResponse", Namespace="http://WebServicefase/", Order=0)]
        public WarlockSocial.WebService.RegistrarUsuarioResponseBody Body;
        
        public RegistrarUsuarioResponse() {
        }
        
        public RegistrarUsuarioResponse(WarlockSocial.WebService.RegistrarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class RegistrarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public RegistrarUsuarioResponseBody() {
        }
        
        public RegistrarUsuarioResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="hello", Namespace="http://WebServicefase/", Order=0)]
        public WarlockSocial.WebService.helloRequestBody Body;
        
        public helloRequest() {
        }
        
        public helloRequest(WarlockSocial.WebService.helloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public helloRequestBody() {
        }
        
        public helloRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="helloResponse", Namespace="http://WebServicefase/", Order=0)]
        public WarlockSocial.WebService.helloResponseBody Body;
        
        public helloResponse() {
        }
        
        public helloResponse(WarlockSocial.WebService.helloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public helloResponseBody() {
        }
        
        public helloResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceFase2Channel : WarlockSocial.WebService.WebServiceFase2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceFase2Client : System.ServiceModel.ClientBase<WarlockSocial.WebService.WebServiceFase2>, WarlockSocial.WebService.WebServiceFase2 {
        
        public WebServiceFase2Client() {
        }
        
        public WebServiceFase2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceFase2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceFase2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceFase2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WarlockSocial.WebService.RegistrarUsuarioResponse WarlockSocial.WebService.WebServiceFase2.RegistrarUsuario(WarlockSocial.WebService.RegistrarUsuarioRequest request) {
            return base.Channel.RegistrarUsuario(request);
        }
        
        public string RegistrarUsuario(string nickName, string contrasena, string correo, string fecha_nac) {
            WarlockSocial.WebService.RegistrarUsuarioRequest inValue = new WarlockSocial.WebService.RegistrarUsuarioRequest();
            inValue.Body = new WarlockSocial.WebService.RegistrarUsuarioRequestBody();
            inValue.Body.nickName = nickName;
            inValue.Body.contrasena = contrasena;
            inValue.Body.correo = correo;
            inValue.Body.fecha_nac = fecha_nac;
            WarlockSocial.WebService.RegistrarUsuarioResponse retVal = ((WarlockSocial.WebService.WebServiceFase2)(this)).RegistrarUsuario(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WarlockSocial.WebService.RegistrarUsuarioResponse> WarlockSocial.WebService.WebServiceFase2.RegistrarUsuarioAsync(WarlockSocial.WebService.RegistrarUsuarioRequest request) {
            return base.Channel.RegistrarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<WarlockSocial.WebService.RegistrarUsuarioResponse> RegistrarUsuarioAsync(string nickName, string contrasena, string correo, string fecha_nac) {
            WarlockSocial.WebService.RegistrarUsuarioRequest inValue = new WarlockSocial.WebService.RegistrarUsuarioRequest();
            inValue.Body = new WarlockSocial.WebService.RegistrarUsuarioRequestBody();
            inValue.Body.nickName = nickName;
            inValue.Body.contrasena = contrasena;
            inValue.Body.correo = correo;
            inValue.Body.fecha_nac = fecha_nac;
            return ((WarlockSocial.WebService.WebServiceFase2)(this)).RegistrarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WarlockSocial.WebService.helloResponse WarlockSocial.WebService.WebServiceFase2.hello(WarlockSocial.WebService.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello(string name) {
            WarlockSocial.WebService.helloRequest inValue = new WarlockSocial.WebService.helloRequest();
            inValue.Body = new WarlockSocial.WebService.helloRequestBody();
            inValue.Body.name = name;
            WarlockSocial.WebService.helloResponse retVal = ((WarlockSocial.WebService.WebServiceFase2)(this)).hello(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WarlockSocial.WebService.helloResponse> WarlockSocial.WebService.WebServiceFase2.helloAsync(WarlockSocial.WebService.helloRequest request) {
            return base.Channel.helloAsync(request);
        }
        
        public System.Threading.Tasks.Task<WarlockSocial.WebService.helloResponse> helloAsync(string name) {
            WarlockSocial.WebService.helloRequest inValue = new WarlockSocial.WebService.helloRequest();
            inValue.Body = new WarlockSocial.WebService.helloRequestBody();
            inValue.Body.name = name;
            return ((WarlockSocial.WebService.WebServiceFase2)(this)).helloAsync(inValue);
        }
    }
}
