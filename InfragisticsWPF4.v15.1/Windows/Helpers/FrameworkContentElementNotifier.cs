using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000116 RID: 278
	public abstract class FrameworkContentElementNotifier : global::System.Windows.FrameworkContentElement, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x0600098B RID: 2443 RVA: 0x0002072D File Offset: 0x0001E92D
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			this.RaisePropertyChangedEvent(e.Property.Name);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00020748 File Offset: 0x0001E948
		protected void RaisePropertyChangedEvent(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00020764 File Offset: 0x0001E964
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

		// Token: 0x0600098E RID: 2446 RVA: 0x000207EC File Offset: 0x0001E9EC
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

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x0600098F RID: 2447 RVA: 0x00020838 File Offset: 0x0001EA38
		// (remove) Token: 0x06000990 RID: 2448 RVA: 0x00020870 File Offset: 0x0001EA70
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	}
}
