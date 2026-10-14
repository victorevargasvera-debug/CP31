using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace CefSharp.Internals.Wcf
{
	// Token: 0x020000FA RID: 250
	internal sealed class JavascriptCallbackEndpointBehavior : global::System.ServiceModel.Description.IEndpointBehavior
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x0000C173 File Offset: 0x0000A373
		public JavascriptCallbackEndpointBehavior(global::CefSharp.Internals.IJavascriptCallbackFactory callbackFactory)
		{
			this.callbackFactory = callbackFactory;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0000C182 File Offset: 0x0000A382
		public void Validate(global::System.ServiceModel.Description.ServiceEndpoint endpoint)
		{
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0000C184 File Offset: 0x0000A384
		public void AddBindingParameters(global::System.ServiceModel.Description.ServiceEndpoint endpoint, global::System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
		{
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0000C188 File Offset: 0x0000A388
		public void ApplyDispatchBehavior(global::System.ServiceModel.Description.ServiceEndpoint endpoint, global::System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher)
		{
			foreach (global::System.ServiceModel.Description.OperationDescription operationDescription in from o in endpoint.Contract.Operations
			where global::CefSharp.Internals.Wcf.JavascriptCallbackEndpointBehavior.Methods.Contains(o.Name)
			select o)
			{
				operationDescription.Behaviors.Find<global::System.ServiceModel.Description.DataContractSerializerOperationBehavior>().DataContractSurrogate = new global::CefSharp.Internals.Wcf.JavascriptCallbackSurrogate(this.callbackFactory);
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0000C214 File Offset: 0x0000A414
		public void ApplyClientBehavior(global::System.ServiceModel.Description.ServiceEndpoint endpoint, global::System.ServiceModel.Dispatcher.ClientRuntime clientRuntime)
		{
		}

		// Token: 0x040003D3 RID: 979
		private static readonly global::System.Collections.Generic.List<string> Methods = new global::System.Collections.Generic.List<string>
		{
			global::CefSharp.Internals.ReflectionUtils.GetMethodName<global::CefSharp.Internals.Wcf.IBrowserProcess>((global::CefSharp.Internals.Wcf.IBrowserProcess p) => p.CallMethod(0L, null, null))
		};

		// Token: 0x040003D4 RID: 980
		private readonly global::CefSharp.Internals.IJavascriptCallbackFactory callbackFactory;
	}
}
