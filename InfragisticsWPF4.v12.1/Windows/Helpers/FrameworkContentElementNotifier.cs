using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x020000F8 RID: 248
	public abstract class FrameworkContentElementNotifier : global::System.Windows.FrameworkContentElement, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x0600088C RID: 2188 RVA: 0x0001CB65 File Offset: 0x0001AD65
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			this.RaisePropertyChangedEvent(e.Property.Name);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0001CB80 File Offset: 0x0001AD80
		protected void RaisePropertyChangedEvent(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0001CB9C File Offset: 0x0001AD9C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public virtual void Reset()
		{
			global::System.Collections.Generic.List<global::System.Windows.DependencyProperty> list = new global::System.Collections.Generic.List<global::System.Windows.DependencyProperty>();
			global::System.Windows.LocalValueEnumerator localValueEnumerator = base.GetLocalValueEnumerator();
			while (localValueEnumerator.MoveNext())
			{
				global::System.Windows.LocalValueEntry localValueEntry = localValueEnumerator.Current;
				global::System.Windows.DependencyProperty property = localValueEntry.Property;
				if (!property.ReadOnly)
				{
					list.Add(property);
				}
			}
			foreach (global::System.Windows.DependencyProperty dp in list)
			{
				base.ClearValue(dp);
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0001CC24 File Offset: 0x0001AE24
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public virtual bool ShouldSerialize()
		{
			global::System.Windows.LocalValueEnumerator localValueEnumerator = base.GetLocalValueEnumerator();
			while (localValueEnumerator.MoveNext())
			{
				global::System.Windows.LocalValueEntry localValueEntry = localValueEnumerator.Current;
				if (!object.Equals(localValueEntry.Property.DefaultMetadata.DefaultValue, localValueEntry.Value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000890 RID: 2192 RVA: 0x0001CC70 File Offset: 0x0001AE70
		// (remove) Token: 0x06000891 RID: 2193 RVA: 0x0001CCA8 File Offset: 0x0001AEA8
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	}
}
