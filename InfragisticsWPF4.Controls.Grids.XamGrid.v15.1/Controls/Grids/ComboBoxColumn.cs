using System;
using System.Collections;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000244 RID: 580
	public class ComboBoxColumn : global::Infragistics.Controls.Grids.ComboBoxColumnBase
	{
		// Token: 0x0600123D RID: 4669 RVA: 0x00043D88 File Offset: 0x00041F88
		public ComboBoxColumn()
		{
			base.AddNewRowItemTemplateVerticalContentAlignment = (base.VerticalContentAlignment = global::System.Windows.VerticalAlignment.Stretch);
			base.AddNewRowItemTemplateHorizontalContentAlignment = (base.HorizontalContentAlignment = global::System.Windows.HorizontalAlignment.Stretch);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00043DBB File Offset: 0x00041FBB
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return new global::Infragistics.Controls.Grids.ComboBoxColumnContentProvider();
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x00043DC2 File Offset: 0x00041FC2
		protected internal override bool RequiresFullRedrawOnEditorStyleUpdate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x00043DC5 File Offset: 0x00041FC5
		protected internal override bool AllowCellEditorValueChangedFiltering
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x00043DC8 File Offset: 0x00041FC8
		// (set) Token: 0x06001242 RID: 4674 RVA: 0x00043DDA File Offset: 0x00041FDA
		public global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				return (global::System.Collections.IEnumerable)base.GetValue(global::Infragistics.Controls.Grids.ComboBoxColumn.ItemsSourceProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ComboBoxColumn.ItemsSourceProperty, value);
			}
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00043DE8 File Offset: 0x00041FE8
		private static void ItemsSourceChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ComboBoxColumn comboBoxColumn = (global::Infragistics.Controls.Grids.ComboBoxColumn)obj;
			comboBoxColumn.OnPropertyChanged("ItemsSource");
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x00043E07 File Offset: 0x00042007
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x00043E19 File Offset: 0x00042019
		public string DisplayMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.ComboBoxColumn.DisplayMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ComboBoxColumn.DisplayMemberPathProperty, value);
			}
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00043E28 File Offset: 0x00042028
		private static void DisplayMemberPathChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ComboBoxColumn comboBoxColumn = (global::Infragistics.Controls.Grids.ComboBoxColumn)obj;
			comboBoxColumn.OnPropertyChanged("DisplayMemberPath");
			comboBoxColumn.RedrawGrid();
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x00043E4D File Offset: 0x0004204D
		// (set) Token: 0x06001248 RID: 4680 RVA: 0x00043E5F File Offset: 0x0004205F
		public string SelectedValuePath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.ComboBoxColumn.SelectedValuePathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ComboBoxColumn.SelectedValuePathProperty, value);
			}
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00043E70 File Offset: 0x00042070
		private static void SelectedValuePathChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ComboBoxColumn comboBoxColumn = (global::Infragistics.Controls.Grids.ComboBoxColumn)obj;
			comboBoxColumn.OnPropertyChanged("SelectedValuePath");
			comboBoxColumn.RedrawGrid();
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x00043E95 File Offset: 0x00042095
		// (set) Token: 0x0600124B RID: 4683 RVA: 0x00043EA7 File Offset: 0x000420A7
		public global::System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Grids.ComboBoxColumn.ItemTemplateProperty) as global::System.Windows.DataTemplate;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ComboBoxColumn.ItemTemplateProperty, value);
			}
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00043EB8 File Offset: 0x000420B8
		private static void ItemTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ComboBoxColumn comboBoxColumn = (global::Infragistics.Controls.Grids.ComboBoxColumn)obj;
			comboBoxColumn.OnPropertyChanged("ItemTemplate");
			comboBoxColumn.RedrawGrid();
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00043EDD File Offset: 0x000420DD
		private void RedrawGrid()
		{
			if (base.ColumnLayout != null && base.ColumnLayout.Grid != null && base.ColumnLayout.Grid.IsLoaded)
			{
				base.ColumnLayout.Grid.ResetPanelRows(true);
			}
		}

		// Token: 0x040005BC RID: 1468
		public static readonly global::System.Windows.DependencyProperty ItemsSourceProperty = global::System.Windows.DependencyProperty.Register("ItemsSource", typeof(global::System.Collections.IEnumerable), typeof(global::Infragistics.Controls.Grids.ComboBoxColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ComboBoxColumn.ItemsSourceChanged)));

		// Token: 0x040005BD RID: 1469
		public static readonly global::System.Windows.DependencyProperty DisplayMemberPathProperty = global::System.Windows.DependencyProperty.Register("DisplayMemberPath", typeof(string), typeof(global::Infragistics.Controls.Grids.ComboBoxColumn), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ComboBoxColumn.DisplayMemberPathChanged)));

		// Token: 0x040005BE RID: 1470
		public static readonly global::System.Windows.DependencyProperty SelectedValuePathProperty = global::System.Windows.DependencyProperty.Register("SelectedValuePath", typeof(string), typeof(global::Infragistics.Controls.Grids.ComboBoxColumn), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ComboBoxColumn.SelectedValuePathChanged)));

		// Token: 0x040005BF RID: 1471
		public static readonly global::System.Windows.DependencyProperty ItemTemplateProperty = global::System.Windows.DependencyProperty.Register("ItemTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.ComboBoxColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ComboBoxColumn.ItemTemplateChanged)));
	}
}
