﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace SilverlightApplication1.BlogService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Post", Namespace="http://tempuri.org/")]
    public partial class Post : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int IdField;
        
        private string TitleField;
        
        private string AuthorField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BlogService.BlogServiceSoap")]
    public interface BlogServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.IAsyncResult BeginHelloWorld(SilverlightApplication1.BlogService.HelloWorldRequest request, System.AsyncCallback callback, object asyncState);
        
        SilverlightApplication1.BlogService.HelloWorldResponse EndHelloWorld(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/GetPosts", ReplyAction="*")]
        System.IAsyncResult BeginGetPosts(SilverlightApplication1.BlogService.GetPostsRequest request, System.AsyncCallback callback, object asyncState);
        
        SilverlightApplication1.BlogService.GetPostsResponse EndGetPosts(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public SilverlightApplication1.BlogService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(SilverlightApplication1.BlogService.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public SilverlightApplication1.BlogService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(SilverlightApplication1.BlogService.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPostsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPosts", Namespace="http://tempuri.org/", Order=0)]
        public SilverlightApplication1.BlogService.GetPostsRequestBody Body;
        
        public GetPostsRequest() {
        }
        
        public GetPostsRequest(SilverlightApplication1.BlogService.GetPostsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetPostsRequestBody {
        
        public GetPostsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPostsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPostsResponse", Namespace="http://tempuri.org/", Order=0)]
        public SilverlightApplication1.BlogService.GetPostsResponseBody Body;
        
        public GetPostsResponse() {
        }
        
        public GetPostsResponse(SilverlightApplication1.BlogService.GetPostsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPostsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Collections.ObjectModel.ObservableCollection<SilverlightApplication1.BlogService.Post> GetPostsResult;
        
        public GetPostsResponseBody() {
        }
        
        public GetPostsResponseBody(System.Collections.ObjectModel.ObservableCollection<SilverlightApplication1.BlogService.Post> GetPostsResult) {
            this.GetPostsResult = GetPostsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BlogServiceSoapChannel : SilverlightApplication1.BlogService.BlogServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetPostsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetPostsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<SilverlightApplication1.BlogService.Post> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<SilverlightApplication1.BlogService.Post>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BlogServiceSoapClient : System.ServiceModel.ClientBase<SilverlightApplication1.BlogService.BlogServiceSoap>, SilverlightApplication1.BlogService.BlogServiceSoap {
        
        private BeginOperationDelegate onBeginHelloWorldDelegate;
        
        private EndOperationDelegate onEndHelloWorldDelegate;
        
        private System.Threading.SendOrPostCallback onHelloWorldCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetPostsDelegate;
        
        private EndOperationDelegate onEndGetPostsDelegate;
        
        private System.Threading.SendOrPostCallback onGetPostsCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public BlogServiceSoapClient() {
        }
        
        public BlogServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BlogServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BlogServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BlogServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("无法设置 CookieContainer。请确保绑定包含 HttpCookieContainerBindingElement。");
                }
            }
        }
        
        public event System.EventHandler<HelloWorldCompletedEventArgs> HelloWorldCompleted;
        
        public event System.EventHandler<GetPostsCompletedEventArgs> GetPostsCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightApplication1.BlogService.BlogServiceSoap.BeginHelloWorld(SilverlightApplication1.BlogService.HelloWorldRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginHelloWorld(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginHelloWorld(System.AsyncCallback callback, object asyncState) {
            SilverlightApplication1.BlogService.HelloWorldRequest inValue = new SilverlightApplication1.BlogService.HelloWorldRequest();
            inValue.Body = new SilverlightApplication1.BlogService.HelloWorldRequestBody();
            return ((SilverlightApplication1.BlogService.BlogServiceSoap)(this)).BeginHelloWorld(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SilverlightApplication1.BlogService.HelloWorldResponse SilverlightApplication1.BlogService.BlogServiceSoap.EndHelloWorld(System.IAsyncResult result) {
            return base.Channel.EndHelloWorld(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private string EndHelloWorld(System.IAsyncResult result) {
            SilverlightApplication1.BlogService.HelloWorldResponse retVal = ((SilverlightApplication1.BlogService.BlogServiceSoap)(this)).EndHelloWorld(result);
            return retVal.Body.HelloWorldResult;
        }
        
        private System.IAsyncResult OnBeginHelloWorld(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginHelloWorld(callback, asyncState);
        }
        
        private object[] OnEndHelloWorld(System.IAsyncResult result) {
            string retVal = this.EndHelloWorld(result);
            return new object[] {
                    retVal};
        }
        
        private void OnHelloWorldCompleted(object state) {
            if ((this.HelloWorldCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        public void HelloWorldAsync(object userState) {
            if ((this.onBeginHelloWorldDelegate == null)) {
                this.onBeginHelloWorldDelegate = new BeginOperationDelegate(this.OnBeginHelloWorld);
            }
            if ((this.onEndHelloWorldDelegate == null)) {
                this.onEndHelloWorldDelegate = new EndOperationDelegate(this.OnEndHelloWorld);
            }
            if ((this.onHelloWorldCompletedDelegate == null)) {
                this.onHelloWorldCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnHelloWorldCompleted);
            }
            base.InvokeAsync(this.onBeginHelloWorldDelegate, null, this.onEndHelloWorldDelegate, this.onHelloWorldCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightApplication1.BlogService.BlogServiceSoap.BeginGetPosts(SilverlightApplication1.BlogService.GetPostsRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetPosts(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginGetPosts(System.AsyncCallback callback, object asyncState) {
            SilverlightApplication1.BlogService.GetPostsRequest inValue = new SilverlightApplication1.BlogService.GetPostsRequest();
            inValue.Body = new SilverlightApplication1.BlogService.GetPostsRequestBody();
            return ((SilverlightApplication1.BlogService.BlogServiceSoap)(this)).BeginGetPosts(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SilverlightApplication1.BlogService.GetPostsResponse SilverlightApplication1.BlogService.BlogServiceSoap.EndGetPosts(System.IAsyncResult result) {
            return base.Channel.EndGetPosts(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.Collections.ObjectModel.ObservableCollection<SilverlightApplication1.BlogService.Post> EndGetPosts(System.IAsyncResult result) {
            SilverlightApplication1.BlogService.GetPostsResponse retVal = ((SilverlightApplication1.BlogService.BlogServiceSoap)(this)).EndGetPosts(result);
            return retVal.Body.GetPostsResult;
        }
        
        private System.IAsyncResult OnBeginGetPosts(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetPosts(callback, asyncState);
        }
        
        private object[] OnEndGetPosts(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<SilverlightApplication1.BlogService.Post> retVal = this.EndGetPosts(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetPostsCompleted(object state) {
            if ((this.GetPostsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetPostsCompleted(this, new GetPostsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetPostsAsync() {
            this.GetPostsAsync(null);
        }
        
        public void GetPostsAsync(object userState) {
            if ((this.onBeginGetPostsDelegate == null)) {
                this.onBeginGetPostsDelegate = new BeginOperationDelegate(this.OnBeginGetPosts);
            }
            if ((this.onEndGetPostsDelegate == null)) {
                this.onEndGetPostsDelegate = new EndOperationDelegate(this.OnEndGetPosts);
            }
            if ((this.onGetPostsCompletedDelegate == null)) {
                this.onGetPostsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetPostsCompleted);
            }
            base.InvokeAsync(this.onBeginGetPostsDelegate, null, this.onEndGetPostsDelegate, this.onGetPostsCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override SilverlightApplication1.BlogService.BlogServiceSoap CreateChannel() {
            return new BlogServiceSoapClientChannel(this);
        }
        
        private class BlogServiceSoapClientChannel : ChannelBase<SilverlightApplication1.BlogService.BlogServiceSoap>, SilverlightApplication1.BlogService.BlogServiceSoap {
            
            public BlogServiceSoapClientChannel(System.ServiceModel.ClientBase<SilverlightApplication1.BlogService.BlogServiceSoap> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginHelloWorld(SilverlightApplication1.BlogService.HelloWorldRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("HelloWorld", _args, callback, asyncState);
                return _result;
            }
            
            public SilverlightApplication1.BlogService.HelloWorldResponse EndHelloWorld(System.IAsyncResult result) {
                object[] _args = new object[0];
                SilverlightApplication1.BlogService.HelloWorldResponse _result = ((SilverlightApplication1.BlogService.HelloWorldResponse)(base.EndInvoke("HelloWorld", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetPosts(SilverlightApplication1.BlogService.GetPostsRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("GetPosts", _args, callback, asyncState);
                return _result;
            }
            
            public SilverlightApplication1.BlogService.GetPostsResponse EndGetPosts(System.IAsyncResult result) {
                object[] _args = new object[0];
                SilverlightApplication1.BlogService.GetPostsResponse _result = ((SilverlightApplication1.BlogService.GetPostsResponse)(base.EndInvoke("GetPosts", _args, result)));
                return _result;
            }
        }
    }
}