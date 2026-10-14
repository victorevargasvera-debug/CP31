using System;

namespace Microsoft.Practices.Prism.Events
{
	// Token: 0x0200001A RID: 26
	public class SubscriptionToken : global::System.IEquatable<global::Microsoft.Practices.Prism.Events.SubscriptionToken>, global::System.IDisposable
	{
		// Token: 0x06000085 RID: 133 RVA: 0x000035D0 File Offset: 0x000017D0
		public SubscriptionToken(global::System.Action<global::Microsoft.Practices.Prism.Events.SubscriptionToken> unsubscribeAction)
		{
			this._unsubscribeAction = unsubscribeAction;
			this._token = global::System.Guid.NewGuid();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000035EA File Offset: 0x000017EA
		public bool Equals(global::Microsoft.Practices.Prism.Events.SubscriptionToken other)
		{
			return other != null && object.Equals(this._token, other._token);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000360C File Offset: 0x0000180C
		public override bool Equals(object obj)
		{
			return object.ReferenceEquals(this, obj) || this.Equals(obj as global::Microsoft.Practices.Prism.Events.SubscriptionToken);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003628 File Offset: 0x00001828
		public override int GetHashCode()
		{
			return this._token.GetHashCode();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003649 File Offset: 0x00001849
		public virtual void Dispose()
		{
			if (this._unsubscribeAction != null)
			{
				this._unsubscribeAction(this);
				this._unsubscribeAction = null;
			}
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000024 RID: 36
		private readonly global::System.Guid _token;

		// Token: 0x04000025 RID: 37
		private global::System.Action<global::Microsoft.Practices.Prism.Events.SubscriptionToken> _unsubscribeAction;
	}
}
