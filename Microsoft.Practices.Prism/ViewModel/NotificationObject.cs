using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Microsoft.Practices.Prism.ViewModel
{
	// Token: 0x0200008E RID: 142
	[global::System.Serializable]
	public abstract class NotificationObject : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060003CA RID: 970 RVA: 0x0000A998 File Offset: 0x00008B98
		// (remove) Token: 0x060003CB RID: 971 RVA: 0x0000A9D0 File Offset: 0x00008BD0
		[global::System.NonSerialized]
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060003CC RID: 972 RVA: 0x0000AA08 File Offset: 0x00008C08
		protected virtual void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000AA2C File Offset: 0x00008C2C
		protected void RaisePropertyChanged(params string[] propertyNames)
		{
			if (propertyNames == null)
			{
				throw new global::System.ArgumentNullException("propertyNames");
			}
			foreach (string propertyName in propertyNames)
			{
				this.RaisePropertyChanged(propertyName);
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000AA64 File Offset: 0x00008C64
		protected void RaisePropertyChanged<T>(global::System.Linq.Expressions.Expression<global::System.Func<T>> propertyExpression)
		{
			string propertyName = global::Microsoft.Practices.Prism.ViewModel.PropertySupport.ExtractPropertyName<T>(propertyExpression);
			this.RaisePropertyChanged(propertyName);
		}
	}
}
