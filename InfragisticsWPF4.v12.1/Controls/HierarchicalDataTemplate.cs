using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace Infragistics.Controls
{
	// Token: 0x020000BE RID: 190
	[global::System.Windows.Markup.ContentProperty("Template")]
	public class HierarchicalDataTemplate : global::System.Windows.DependencyObject
	{
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x00018E49 File Offset: 0x00017049
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x00018E5B File Offset: 0x0001705B
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

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00018E69 File Offset: 0x00017069
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x00018E7B File Offset: 0x0001707B
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

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00018E89 File Offset: 0x00017089
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x00018E9B File Offset: 0x0001709B
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

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00018EA9 File Offset: 0x000170A9
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x00018EB1 File Offset: 0x000170B1
		public global::System.Windows.Data.Binding ItemsSource { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00018EBA File Offset: 0x000170BA
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x00018ECC File Offset: 0x000170CC
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

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00018EDA File Offset: 0x000170DA
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x00018EEC File Offset: 0x000170EC
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

		// Token: 0x04000338 RID: 824
		public static readonly global::System.Windows.DependencyProperty HierarchicalItemTemplateProperty = global::System.Windows.DependencyProperty.Register("HierarchicalItemTemplate", typeof(global::Infragistics.Controls.HierarchicalDataTemplate), typeof(global::Infragistics.Controls.HierarchicalDataTemplate), null);

		// Token: 0x04000339 RID: 825
		public static readonly global::System.Windows.DependencyProperty ItemTemplateProperty = global::System.Windows.DependencyProperty.Register("ItemTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.HierarchicalDataTemplate), null);

		// Token: 0x0400033A RID: 826
		public static readonly global::System.Windows.DependencyProperty TemplateProperty = global::System.Windows.DependencyProperty.Register("Template", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.HierarchicalDataTemplate), null);

		// Token: 0x0400033B RID: 827
		public static readonly global::System.Windows.DependencyProperty ItemContainerStyleProperty = global::System.Windows.DependencyProperty.Register("ItemContainerStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.HierarchicalDataTemplate), null);

		// Token: 0x0400033C RID: 828
		public static readonly global::System.Windows.DependencyProperty DefaultItemsContainerProperty = global::System.Windows.DependencyProperty.Register("DefaultItemsContainer", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.HierarchicalDataTemplate), null);
	}
}
