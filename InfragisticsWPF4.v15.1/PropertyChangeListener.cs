using System;

namespace Infragistics
{
	// Token: 0x0200006C RID: 108
	internal class PropertyChangeListener<TOwner> : global::Infragistics.IPropertyChangeListener, global::Infragistics.ITypedPropertyChangeListener<object, string> where TOwner : class
	{
		// Token: 0x0600040A RID: 1034 RVA: 0x0001156B File Offset: 0x0000F76B
		public PropertyChangeListener(TOwner owner, global::System.Action<TOwner, object, string, object> action, bool useWeakReference = true)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(owner);
			this._wwOwner = (useWeakReference ? new global::System.WeakReference(owner) : owner);
			this._action = action;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x000115A1 File Offset: 0x0000F7A1
		public TOwner Owner
		{
			get
			{
				return (TOwner)((object)global::Infragistics.ListenerList.GetItemHelper(this._wwOwner));
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000115B4 File Offset: 0x0000F7B4
		public virtual void OnPropertyValueChanged(object dataItem, string property, object extraInfo)
		{
			TOwner owner = this.Owner;
			if (owner != null && this._action != null)
			{
				this._action(owner, dataItem, property, extraInfo);
			}
		}

		// Token: 0x0400017A RID: 378
		private object _wwOwner;

		// Token: 0x0400017B RID: 379
		private global::System.Action<TOwner, object, string, object> _action;
	}
}
