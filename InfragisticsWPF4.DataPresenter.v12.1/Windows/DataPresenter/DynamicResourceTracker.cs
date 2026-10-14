using System;
using System.ComponentModel;
using Infragistics.Shared;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001D7 RID: 471
	internal class DynamicResourceTracker
	{
		// Token: 0x06001B5B RID: 7003 RVA: 0x000751B4 File Offset: 0x000733B4
		internal DynamicResourceTracker(global::Infragistics.Shared.DynamicResourceString dr, global::Infragistics.Windows.DataPresenter.DynamicResourceTracker.RaisePropertyValueChanged propChangeCallback, string callbackPropName)
		{
			this._dr = dr;
			this._callback = propChangeCallback;
			this._callbackPropName = callbackPropName;
			dr.PropertyChanged += this.Resource_PropertyChanged;
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x000751E3 File Offset: 0x000733E3
		private void Resource_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if ("Value" == e.PropertyName)
			{
				this._callback(this._callbackPropName);
			}
		}

		// Token: 0x04000B4C RID: 2892
		private global::Infragistics.Shared.DynamicResourceString _dr;

		// Token: 0x04000B4D RID: 2893
		private global::Infragistics.Windows.DataPresenter.DynamicResourceTracker.RaisePropertyValueChanged _callback;

		// Token: 0x04000B4E RID: 2894
		private string _callbackPropName;

		// Token: 0x020001D8 RID: 472
		// (Invoke) Token: 0x06001B5E RID: 7006
		public delegate void RaisePropertyValueChanged(string propName);
	}
}
