using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;

namespace System.Data.Entity.Infrastructure.Design
{
	// Token: 0x0200029D RID: 669
	internal class ForwardingProxy<T> : global::System.Runtime.Remoting.Proxies.RealProxy
	{
		// Token: 0x06002167 RID: 8551 RVA: 0x0005CD3C File Offset: 0x0005AF3C
		public ForwardingProxy(object target) : base(typeof(T))
		{
			this._target = (global::System.MarshalByRefObject)target;
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x0005CD5A File Offset: 0x0005AF5A
		public override global::System.Runtime.Remoting.Messaging.IMessage Invoke(global::System.Runtime.Remoting.Messaging.IMessage msg)
		{
			new global::System.Runtime.Remoting.Messaging.MethodCallMessageWrapper((global::System.Runtime.Remoting.Messaging.IMethodCallMessage)msg).Uri = global::System.Runtime.Remoting.RemotingServices.GetObjectUri(this._target);
			return global::System.Runtime.Remoting.RemotingServices.GetEnvoyChainForProxy(this._target).SyncProcessMessage(msg);
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x0005CD88 File Offset: 0x0005AF88
		public new T GetTransparentProxy()
		{
			return (T)((object)base.GetTransparentProxy());
		}

		// Token: 0x04000B9E RID: 2974
		private readonly global::System.MarshalByRefObject _target;
	}
}
