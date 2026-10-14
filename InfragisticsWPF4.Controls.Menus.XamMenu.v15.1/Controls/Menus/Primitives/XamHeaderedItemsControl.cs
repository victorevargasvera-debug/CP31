using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Menus.Primitives
{
	// Token: 0x02000019 RID: 25
	[global::System.Windows.StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	public class XamHeaderedItemsControl : global::System.Windows.Controls.ItemsControl, global::Infragistics.IProvidePropertyPersistenceSettings
	{
		// Token: 0x06000089 RID: 137 RVA: 0x000039DB File Offset: 0x00001BDB
		public XamHeaderedItemsControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl);
			this.HeaderedItemContainerGenerator = new global::Infragistics.HeaderedItemContainerGenerator(this);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000039FF File Offset: 0x00001BFF
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00003A11 File Offset: 0x00001C11
		public global::Infragistics.Controls.HierarchicalDataTemplate HierarchicalItemTemplate
		{
			get
			{
				return (global::Infragistics.Controls.HierarchicalDataTemplate)base.GetValue(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.HierarchicalItemTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.HierarchicalItemTemplateProperty, value);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003A20 File Offset: 0x00001C20
		private static void OnHierarchicalItemTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl xamHeaderedItemsControl = obj as global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl;
			global::Infragistics.Controls.HierarchicalDataTemplate hierarchicalDataTemplate = e.NewValue as global::Infragistics.Controls.HierarchicalDataTemplate;
			if (hierarchicalDataTemplate != null && hierarchicalDataTemplate.Template != null)
			{
				xamHeaderedItemsControl.SetValue(global::System.Windows.Controls.ItemsControl.ItemTemplateProperty, hierarchicalDataTemplate.Template);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00003A5D File Offset: 0x00001C5D
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00003A6F File Offset: 0x00001C6F
		public global::System.Windows.DataTemplate DefaultItemsContainer
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.DefaultItemsContainerProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.DefaultItemsContainerProperty, value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00003A7D File Offset: 0x00001C7D
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00003A8A File Offset: 0x00001C8A
		public object Header
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.HeaderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.HeaderProperty, value);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003A98 File Offset: 0x00001C98
		private static void OnHeaderPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl xamHeaderedItemsControl = d as global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl;
			xamHeaderedItemsControl.OnHeaderChanged(e.OldValue, e.NewValue);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00003AC0 File Offset: 0x00001CC0
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00003AD2 File Offset: 0x00001CD2
		public global::System.Windows.DataTemplate HeaderTemplate
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.HeaderTemplateProperty) as global::System.Windows.DataTemplate;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.HeaderTemplateProperty, value);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003AE0 File Offset: 0x00001CE0
		private static void OnHeaderTemplatePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl xamHeaderedItemsControl = d as global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl;
			global::System.Windows.DataTemplate oldHeaderTemplate = e.OldValue as global::System.Windows.DataTemplate;
			global::System.Windows.DataTemplate newHeaderTemplate = e.NewValue as global::System.Windows.DataTemplate;
			xamHeaderedItemsControl.OnHeaderTemplateChanged(oldHeaderTemplate, newHeaderTemplate);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00003B16 File Offset: 0x00001D16
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00003B1E File Offset: 0x00001D1E
		internal bool HeaderIsItem { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00003B27 File Offset: 0x00001D27
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00003B2F File Offset: 0x00001D2F
		internal global::Infragistics.IHeaderedItemContainerGenerator HeaderedItemContainerGenerator { get; private set; }

		// Token: 0x06000099 RID: 153 RVA: 0x00003B38 File Offset: 0x00001D38
		public override void OnApplyTemplate()
		{
			this.HeaderedItemContainerGenerator.OnApplyTemplate();
			base.OnApplyTemplate();
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003B4B File Offset: 0x00001D4B
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			base.PrepareContainerForItemOverride(element, item);
			this.HeaderedItemContainerGenerator.PrepareContainerForItemOverride(element, item, base.ItemContainerStyle);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003B68 File Offset: 0x00001D68
		protected override void ClearContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			this.HeaderedItemContainerGenerator.ClearContainerForItemOverride(element, item);
			base.ClearContainerForItemOverride(element, item);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003B7F File Offset: 0x00001D7F
		protected override void OnItemContainerStyleChanged(global::System.Windows.Style oldItemContainerStyle, global::System.Windows.Style newItemContainerStyle)
		{
			this.HeaderedItemContainerGenerator.UpdateItemContainerStyle(newItemContainerStyle);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00003B8D File Offset: 0x00001D8D
		protected virtual void OnHeaderChanged(object oldHeader, object newHeader)
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003B8F File Offset: 0x00001D8F
		protected virtual void OnHeaderTemplateChanged(global::System.Windows.DataTemplate oldHeaderTemplate, global::System.Windows.DataTemplate newHeaderTemplate)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00003B94 File Offset: 0x00001D94
		protected virtual global::System.Collections.Generic.List<string> PropertiesToIgnore
		{
			get
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				if (base.ItemsSource != null)
				{
					list.AddRange(new string[]
					{
						"ItemsSource",
						"Items"
					});
				}
				return list;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00003BCE File Offset: 0x00001DCE
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PropertiesToIgnore
		{
			get
			{
				return this.PropertiesToIgnore;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00003BD6 File Offset: 0x00001DD6
		protected virtual global::System.Collections.Generic.List<string> PriorityProperties
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00003BD9 File Offset: 0x00001DD9
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PriorityProperties
		{
			get
			{
				return this.PriorityProperties;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003BE1 File Offset: 0x00001DE1
		protected virtual void FinishedLoadingPersistence()
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003BE3 File Offset: 0x00001DE3
		void global::Infragistics.IProvidePropertyPersistenceSettings.FinishedLoadingPersistence()
		{
			this.FinishedLoadingPersistence();
		}

		// Token: 0x0400003D RID: 61
		public static readonly global::System.Windows.DependencyProperty HierarchicalItemTemplateProperty = global::System.Windows.DependencyProperty.Register("HierarchicalItemTemplate", typeof(global::Infragistics.Controls.HierarchicalDataTemplate), typeof(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.OnHierarchicalItemTemplateChanged)));

		// Token: 0x0400003E RID: 62
		public static readonly global::System.Windows.DependencyProperty DefaultItemsContainerProperty = global::System.Windows.DependencyProperty.Register("DefaultItemsContainer", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl), null);

		// Token: 0x0400003F RID: 63
		public static readonly global::System.Windows.DependencyProperty HeaderProperty = global::System.Windows.DependencyProperty.Register("Header", typeof(object), typeof(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.OnHeaderPropertyChanged)));

		// Token: 0x04000040 RID: 64
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateProperty = global::System.Windows.DependencyProperty.Register("HeaderTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl.OnHeaderTemplatePropertyChanged)));
	}
}
