using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Practices.Prism.Events
{
	// Token: 0x0200001C RID: 28
	internal class WeakDelegatesManager
	{
		// Token: 0x0600008A RID: 138 RVA: 0x0000366C File Offset: 0x0000186C
		public void AddListener(global::System.Delegate listener)
		{
			this.listeners.Add(new global::Microsoft.Practices.Prism.Events.DelegateReference(listener, false));
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000036B0 File Offset: 0x000018B0
		public void RemoveListener(global::System.Delegate listener)
		{
			this.listeners.RemoveAll(delegate(global::Microsoft.Practices.Prism.Events.DelegateReference reference)
			{
				global::System.Delegate target = reference.Target;
				return listener.Equals(target) || target == null;
			});
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003700 File Offset: 0x00001900
		public void Raise(params object[] args)
		{
			this.listeners.RemoveAll((global::Microsoft.Practices.Prism.Events.DelegateReference listener) => listener.Target == null);
			foreach (global::System.Delegate @delegate in from listener in this.listeners.ToList<global::Microsoft.Practices.Prism.Events.DelegateReference>()
			select listener.Target into listener
			where listener != null
			select listener)
			{
				@delegate.DynamicInvoke(args);
			}
		}

		// Token: 0x0400002A RID: 42
		private readonly global::System.Collections.Generic.List<global::Microsoft.Practices.Prism.Events.DelegateReference> listeners = new global::System.Collections.Generic.List<global::Microsoft.Practices.Prism.Events.DelegateReference>();
	}
}
