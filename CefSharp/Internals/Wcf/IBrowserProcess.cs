using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CefSharp.Internals.Wcf
{
	// Token: 0x020000F9 RID: 249
	[global::System.ServiceModel.ServiceContract(SessionMode = global::System.ServiceModel.SessionMode.Required)]
	[global::System.ServiceModel.ServiceKnownType(typeof(object[]))]
	[global::System.ServiceModel.ServiceKnownType(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
	[global::System.ServiceModel.ServiceKnownType(typeof(global::CefSharp.Internals.JavascriptObject))]
	[global::System.ServiceModel.ServiceKnownType(typeof(global::CefSharp.Internals.JavascriptMethod))]
	[global::System.ServiceModel.ServiceKnownType(typeof(global::CefSharp.Internals.JavascriptProperty))]
	[global::System.ServiceModel.ServiceKnownType(typeof(global::CefSharp.Internals.JavascriptCallback))]
	public interface IBrowserProcess
	{
		// Token: 0x06000759 RID: 1881
		[global::System.ServiceModel.OperationContract]
		global::CefSharp.Internals.Wcf.BrowserProcessResponse CallMethod(long objectId, string name, object[] parameters);

		// Token: 0x0600075A RID: 1882
		[global::System.ServiceModel.OperationContract]
		global::CefSharp.Internals.Wcf.BrowserProcessResponse GetProperty(long objectId, string name);

		// Token: 0x0600075B RID: 1883
		[global::System.ServiceModel.OperationContract]
		global::CefSharp.Internals.Wcf.BrowserProcessResponse SetProperty(long objectId, string name, object value);
	}
}
