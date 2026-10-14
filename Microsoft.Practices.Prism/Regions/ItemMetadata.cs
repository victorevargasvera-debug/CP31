using System;
using System.Windows;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000067 RID: 103
	public class ItemMetadata : global::System.Windows.DependencyObject
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x000088AC File Offset: 0x00006AAC
		public ItemMetadata(object item)
		{
			this.Item = item;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002EA RID: 746 RVA: 0x000088BB File Offset: 0x00006ABB
		// (set) Token: 0x060002EB RID: 747 RVA: 0x000088C3 File Offset: 0x00006AC3
		public object Item { get; private set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002EC RID: 748 RVA: 0x000088CC File Offset: 0x00006ACC
		// (set) Token: 0x060002ED RID: 749 RVA: 0x000088DE File Offset: 0x00006ADE
		public string Name
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Practices.Prism.Regions.ItemMetadata.NameProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Practices.Prism.Regions.ItemMetadata.NameProperty, value);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002EE RID: 750 RVA: 0x000088EC File Offset: 0x00006AEC
		// (set) Token: 0x060002EF RID: 751 RVA: 0x000088FE File Offset: 0x00006AFE
		public bool IsActive
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Practices.Prism.Regions.ItemMetadata.IsActiveProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Practices.Prism.Regions.ItemMetadata.IsActiveProperty, value);
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060002F0 RID: 752 RVA: 0x00008914 File Offset: 0x00006B14
		// (remove) Token: 0x060002F1 RID: 753 RVA: 0x0000894C File Offset: 0x00006B4C
		public event global::System.EventHandler MetadataChanged;

		// Token: 0x060002F2 RID: 754 RVA: 0x00008984 File Offset: 0x00006B84
		public void InvokeMetadataChanged()
		{
			global::System.EventHandler metadataChanged = this.MetadataChanged;
			if (metadataChanged != null)
			{
				metadataChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000089A8 File Offset: 0x00006BA8
		private static void DependencyPropertyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Microsoft.Practices.Prism.Regions.ItemMetadata itemMetadata = dependencyObject as global::Microsoft.Practices.Prism.Regions.ItemMetadata;
			if (itemMetadata != null)
			{
				itemMetadata.InvokeMetadataChanged();
			}
		}

		// Token: 0x040000A3 RID: 163
		public static readonly global::System.Windows.DependencyProperty NameProperty = global::System.Windows.DependencyProperty.Register("Name", typeof(string), typeof(global::Microsoft.Practices.Prism.Regions.ItemMetadata), null);

		// Token: 0x040000A4 RID: 164
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty = global::System.Windows.DependencyProperty.Register("IsActive", typeof(bool), typeof(global::Microsoft.Practices.Prism.Regions.ItemMetadata), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Practices.Prism.Regions.ItemMetadata.DependencyPropertyChanged)));
	}
}
