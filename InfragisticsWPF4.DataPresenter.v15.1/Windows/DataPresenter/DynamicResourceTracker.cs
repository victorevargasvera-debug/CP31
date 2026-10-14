using System;
using System.ComponentModel;
using Infragistics.Shared;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001FE RID: 510
	internal class DynamicResourceTracker
	{
		// Token: 0x06001F63 RID: 8035 RVA: 0x00088E20 File Offset: 0x00087020
		internal DynamicResourceTracker(global::Infragistics.Shared.DynamicResourceString dr, global::Infragistics.Windows.DataPresenter.DynamicResourceTracker.RaisePropertyValueChanged propChangeCallback, string callbackPropName)
		{
			this._dr = dr;
			this._callback = propChangeCallback;
			this._callbackPropName = callbackPropName;
			dr.PropertyChanged += this.Resource_PropertyChanged;
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00088E4F File Offset: 0x0008704F
		private void Resource_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if ("Value" == e.PropertyName)
			{
				this._callback(this._callbackPropName);
			}
		}

		// Token: 0x04000D32 RID: 3378
		private global::Infragistics.Shared.DynamicResourceString _dr;

		// Token: 0x04000D33 RID: 3379
		private global::Infragistics.Windows.DataPresenter.DynamicResourceTracker.RaisePropertyValueChanged _callback;

		// Token: 0x04000D34 RID: 3380
		private string _callbackPropName;

		// Token: 0x020001FF RID: 511
		// (Invoke) Token: 0x06001F66 RID: 8038
		public delegate void RaisePropertyValueChanged(string propName);
	}
}
