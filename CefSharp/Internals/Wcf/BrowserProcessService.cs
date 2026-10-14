using System;
using System.ServiceModel;

namespace CefSharp.Internals.Wcf
{
	// Token: 0x020000F7 RID: 247
	[global::System.ServiceModel.ServiceBehavior(InstanceContextMode = global::System.ServiceModel.InstanceContextMode.PerSession, ConcurrencyMode = global::System.ServiceModel.ConcurrencyMode.Multiple)]
	internal class BrowserProcessService : global::CefSharp.Internals.Wcf.IBrowserProcess
	{
		// Token: 0x06000750 RID: 1872 RVA: 0x0000BED8 File Offset: 0x0000A0D8
		public BrowserProcessService()
		{
			global::System.ServiceModel.OperationContext operationContext = global::System.ServiceModel.OperationContext.Current;
			this.host = (global::CefSharp.Internals.Wcf.BrowserProcessServiceHost)operationContext.Host;
			this.javascriptObjectRepository = this.host.JavascriptObjectRepository;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0000BF14 File Offset: 0x0000A114
		public global::CefSharp.Internals.Wcf.BrowserProcessResponse CallMethod(long objectId, string name, object[] parameters)
		{
			global::CefSharp.Internals.TryCallMethodResult tryCallMethodResult = this.javascriptObjectRepository.TryCallMethod(objectId, name, parameters);
			return new global::CefSharp.Internals.Wcf.BrowserProcessResponse
			{
				Success = tryCallMethodResult.Success,
				Result = tryCallMethodResult.ReturnValue,
				Message = tryCallMethodResult.Exception
			};
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0000BF5C File Offset: 0x0000A15C
		public global::CefSharp.Internals.Wcf.BrowserProcessResponse GetProperty(long objectId, string name)
		{
			object result;
			string message;
			bool success = this.javascriptObjectRepository.TryGetProperty(objectId, name, out result, out message);
			return new global::CefSharp.Internals.Wcf.BrowserProcessResponse
			{
				Success = success,
				Result = result,
				Message = message
			};
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0000BF98 File Offset: 0x0000A198
		public global::CefSharp.Internals.Wcf.BrowserProcessResponse SetProperty(long objectId, string name, object value)
		{
			string message;
			bool success = this.javascriptObjectRepository.TrySetProperty(objectId, name, value, out message);
			return new global::CefSharp.Internals.Wcf.BrowserProcessResponse
			{
				Success = success,
				Result = null,
				Message = message
			};
		}

		// Token: 0x040003CF RID: 975
		private readonly global::CefSharp.Internals.IJavascriptObjectRepositoryInternal javascriptObjectRepository;

		// Token: 0x040003D0 RID: 976
		private readonly global::CefSharp.Internals.Wcf.BrowserProcessServiceHost host;
	}
}
