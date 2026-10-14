using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace Infragistics.Controls
{
	// Token: 0x020000DB RID: 219
	[global::System.Windows.Markup.ContentProperty("Template")]
	public class HierarchicalDataTemplate : global::System.Windows.Freezable
	{
		// Token: 0x06000802 RID: 2050 RVA: 0x0001C625 File Offset: 0x0001A825
		protected override void CloneCore(global::System.Windows.Freezable sourceFreezable)
		{
			base.CloneCore(sourceFreezable);
			this.CopyCommon((global::Infragistics.Controls.HierarchicalDataTemplate)sourceFreezable);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0001C63A File Offset: 0x0001A83A
		protected override void CloneCurrentValueCore(global::System.Windows.Freezable sourceFreezable)
		{
			base.CloneCurrentValueCore(sourceFreezable);
			this.CopyCommon((global::Infragistics.Controls.HierarchicalDataTemplate)sourceFreezable);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0001C64F File Offset: 0x0001A84F
		protected override global::System.Windows.Freezable CreateInstanceCore()
		{
			return new global::Infragistics.Controls.HierarchicalDataTemplate();
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0001C656 File Offset: 0x0001A856
		protected override void GetAsFrozenCore(global::System.Windows.Freezable sourceFreezable)
		{
			base.GetAsFrozenCore(sourceFreezable);
			this.CopyCommon((global::Infragistics.Controls.HierarchicalDataTemplate)sourceFreezable);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0001C66B File Offset: 0x0001A86B
		protected override void GetCurrentValueAsFrozenCore(global::System.Windows.Freezable sourceFreezable)
		{
			base.GetCurrentValueAsFrozenCore(sourceFreezable);
			this.CopyCommon((global::Infragistics.Controls.HierarchicalDataTemplate)sourceFreezable);
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x0001C680 File Offset: 0x0001A880
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x0001C692 File Offset: 0x0001A892
		public global::Infragistics.Controls.HierarchicalDataTemplate HierarchicalItemTemplate
		{
			get
			{
				return (global::Infragistics.Controls.HierarchicalDataTemplate)base.GetValue(global::Infragistics.Controls.HierarchicalDataTemplate.HierarchicalItemTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.HierarchicalDataTemplate.HierarchicalItemTemplateProperty, value);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x0001C6A0 File Offset: 0x0001A8A0
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x0001C6B2 File Offset: 0x0001A8B2
		public global::System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.HierarchicalDataTemplate.ItemTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.HierarchicalDataTemplate.ItemTemplateProperty, value);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x0001C6C0 File Offset: 0x0001A8C0
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x0001C6D2 File Offset: 0x0001A8D2
		public global::System.Windows.DataTemplate Template
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.HierarchicalDataTemplate.TemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.HierarchicalDataTemplate.TemplateProperty, value);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x0001C6E0 File Offset: 0x0001A8E0
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x0001C6EE File Offset: 0x0001A8EE
		public global::System.Windows.Data.Binding ItemsSource
		{
			get
			{
				base.ReadPreamble();
				return this._itemsSource;
			}
			set
			{
				base.WritePreamble();
				this._itemsSource = value;
				base.WritePostscript();
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x0001C703 File Offset: 0x0001A903
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x0001C715 File Offset: 0x0001A915
		public global::System.Windows.Style ItemContainerStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.HierarchicalDataTemplate.ItemContainerStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.HierarchicalDataTemplate.ItemContainerStyleProperty, value);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x0001C723 File Offset: 0x0001A923
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x0001C735 File Offset: 0x0001A935
		public global::System.Windows.DataTemplate DefaultItemsContainer
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.HierarchicalDataTemplate.DefaultItemsContainerProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.HierarchicalDataTemplate.DefaultItemsContainerProperty, value);
			}
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0001C743 File Offset: 0x0001A943
		private void CopyCommon(global::Infragistics.Controls.HierarchicalDataTemplate source)
		{
			this._itemsSource = source._itemsSource;
		}

		// Token: 0x040003E6 RID: 998
		public static readonly global::System.Windows.DependencyProperty HierarchicalItemTemplateProperty = global::System.Windows.DependencyProperty.Register("HierarchicalItemTemplate", typeof(global::Infragistics.Controls.HierarchicalDataTemplate), typeof(global::Infragistics.Controls.HierarchicalDataTemplate), null);

		// Token: 0x040003E7 RID: 999
		public static readonly global::System.Windows.DependencyProperty ItemTemplateProperty = global::System.Windows.DependencyProperty.Register("ItemTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.HierarchicalDataTemplate), null);

		// Token: 0x040003E8 RID: 1000
		public static readonly global::System.Windows.DependencyProperty TemplateProperty = global::System.Windows.DependencyProperty.Register("Template", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.HierarchicalDataTemplate), null);

		// Token: 0x040003E9 RID: 1001
		private global::System.Windows.Data.Binding _itemsSource;

		// Token: 0x040003EA RID: 1002
		public static readonly global::System.Windows.DependencyProperty ItemContainerStyleProperty = global::System.Windows.DependencyProperty.Register("ItemContainerStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.HierarchicalDataTemplate), null);

		// Token: 0x040003EB RID: 1003
		public static readonly global::System.Windows.DependencyProperty DefaultItemsContainerProperty = global::System.Windows.DependencyProperty.Register("DefaultItemsContainer", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.HierarchicalDataTemplate), null);
	}
}
