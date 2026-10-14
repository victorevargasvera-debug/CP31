using System;
using System.Reflection;

namespace Microsoft.Practices.Prism.Events
{
	// Token: 0x02000016 RID: 22
	public class DelegateReference : global::Microsoft.Practices.Prism.Events.IDelegateReference
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00003488 File Offset: 0x00001688
		public DelegateReference(global::System.Delegate @delegate, bool keepReferenceAlive)
		{
			if (@delegate == null)
			{
				throw new global::System.ArgumentNullException("delegate");
			}
			if (keepReferenceAlive)
			{
				this._delegate = @delegate;
				return;
			}
			this._weakReference = new global::System.WeakReference(@delegate.Target);
			this._method = @delegate.Method;
			this._delegateType = @delegate.GetType();
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000034DD File Offset: 0x000016DD
		public global::System.Delegate Target
		{
			get
			{
				if (this._delegate != null)
				{
					return this._delegate;
				}
				return this.TryGetDelegate();
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000034F4 File Offset: 0x000016F4
		private global::System.Delegate TryGetDelegate()
		{
			if (this._method.IsStatic)
			{
				return global::System.Delegate.CreateDelegate(this._delegateType, null, this._method);
			}
			object target = this._weakReference.Target;
			if (target != null)
			{
				return global::System.Delegate.CreateDelegate(this._delegateType, target, this._method);
			}
			return null;
		}

		// Token: 0x0400001E RID: 30
		private readonly global::System.Delegate _delegate;

		// Token: 0x0400001F RID: 31
		private readonly global::System.WeakReference _weakReference;

		// Token: 0x04000020 RID: 32
		private readonly global::System.Reflection.MethodInfo _method;

		// Token: 0x04000021 RID: 33
		private readonly global::System.Type _delegateType;
	}
}
