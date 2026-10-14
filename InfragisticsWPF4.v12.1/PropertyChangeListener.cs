using System;

namespace Infragistics
{
	// Token: 0x02000058 RID: 88
	internal class PropertyChangeListener<TOwner> : global::Infragistics.IPropertyChangeListener, global::Infragistics.ITypedPropertyChangeListener<object, string> where TOwner : class
	{
		// Token: 0x06000375 RID: 885 RVA: 0x0000F904 File Offset: 0x0000DB04
		public PropertyChangeListener(TOwner owner, global::System.Action<TOwner, object, string, object> action, bool useWeakReference = true)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(owner);
			this._wwOwner = (useWeakReference ? new global::System.WeakReference(owner) : owner);
			this._action = action;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0000F93A File Offset: 0x0000DB3A
		public TOwner Owner
		{
			get
			{
				return (TOwner)((object)global::Infragistics.ListenerList.GetItemHelper(this._wwOwner));
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000F94C File Offset: 0x0000DB4C
		public virtual void OnPropertyValueChanged(object dataItem, string property, object extraInfo)
		{
			TOwner owner = this.Owner;
			if (owner != null && this._action != null)
			{
				this._action(owner, dataItem, property, extraInfo);
			}
		}

		// Token: 0x0400011F RID: 287
		private object _wwOwner;

		// Token: 0x04000120 RID: 288
		private global::System.Action<TOwner, object, string, object> _action;
	}
}
