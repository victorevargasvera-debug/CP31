using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000135 RID: 309
	public class SortingSettings : global::Infragistics.Controls.Grids.SettingsBase, global::Infragistics.IProvidePropertyPersistenceSettings
	{
		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00026E2C File Offset: 0x0002502C
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x00026E3E File Offset: 0x0002503E
		public bool AllowSorting
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.SortingSettings.AllowSortingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SortingSettings.AllowSortingProperty, value);
			}
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00026E54 File Offset: 0x00025054
		private static void AllowSortingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SortingSettings sortingSettings = (global::Infragistics.Controls.Grids.SortingSettings)obj;
			sortingSettings.OnPropertyChanged("AllowSorting");
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00026E73 File Offset: 0x00025073
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00026E85 File Offset: 0x00025085
		public bool ShowSortIndicator
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.SortingSettings.ShowSortIndicatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SortingSettings.ShowSortIndicatorProperty, value);
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00026E98 File Offset: 0x00025098
		private static void ShowSortIndicatorChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SortingSettings sortingSettings = (global::Infragistics.Controls.Grids.SortingSettings)obj;
			sortingSettings.OnPropertyChanged("ShowSortIndicator");
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00026EB7 File Offset: 0x000250B7
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00026EC9 File Offset: 0x000250C9
		public bool AllowMultipleColumnSorting
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.SortingSettings.AllowMultipleColumnSortingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SortingSettings.AllowMultipleColumnSortingProperty, value);
			}
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00026EDC File Offset: 0x000250DC
		private static void AllowMultipleColumnSortingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SortingSettings sortingSettings = (global::Infragistics.Controls.Grids.SortingSettings)obj;
			sortingSettings.OnPropertyChanged("AllowMultipleColumnSorting");
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00026EFC File Offset: 0x000250FC
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.SortedColumnsCollection SortedColumns
		{
			get
			{
				global::Infragistics.Controls.Grids.SortedColumnsCollection result = null;
				if (base.Grid != null)
				{
					result = base.Grid.RowsManager.ColumnLayout.SortingSettings.SortedColumns;
				}
				return result;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00026F2F File Offset: 0x0002512F
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00026F41 File Offset: 0x00025141
		public global::Infragistics.Controls.Grids.MultiSortingKey MultiSortingKey
		{
			get
			{
				return (global::Infragistics.Controls.Grids.MultiSortingKey)base.GetValue(global::Infragistics.Controls.Grids.SortingSettings.MultiSortingKeyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SortingSettings.MultiSortingKeyProperty, value);
			}
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00026F54 File Offset: 0x00025154
		private static void MultiSortingKeyChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SortingSettings sortingSettings = (global::Infragistics.Controls.Grids.SortingSettings)obj;
			sortingSettings.OnPropertyChanged("MultiSortingKey");
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00026F73 File Offset: 0x00025173
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x00026F85 File Offset: 0x00025185
		public global::Infragistics.Controls.Grids.SortDirection FirstSortDirection
		{
			get
			{
				return (global::Infragistics.Controls.Grids.SortDirection)base.GetValue(global::Infragistics.Controls.Grids.SortingSettings.FirstSortDirectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SortingSettings.FirstSortDirectionProperty, value);
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00026F98 File Offset: 0x00025198
		private static void FirstSortDirectionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SortingSettings sortingSettings = (global::Infragistics.Controls.Grids.SortingSettings)obj;
			sortingSettings.OnPropertyChanged("FirstSortDirection");
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00026FB8 File Offset: 0x000251B8
		protected virtual global::System.Collections.Generic.List<string> PropertiesToIgnore
		{
			get
			{
				if (this._propertiesThatShouldntBePersisted == null)
				{
					this._propertiesThatShouldntBePersisted = new global::System.Collections.Generic.List<string>
					{
						"SortedColumns"
					};
				}
				return this._propertiesThatShouldntBePersisted;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00026FEB File Offset: 0x000251EB
		protected virtual global::System.Collections.Generic.List<string> PriorityProperties
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00026FEE File Offset: 0x000251EE
		protected virtual void FinishedLoadingPersistence()
		{
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00026FF0 File Offset: 0x000251F0
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PropertiesToIgnore
		{
			get
			{
				return this.PropertiesToIgnore;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00026FF8 File Offset: 0x000251F8
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PriorityProperties
		{
			get
			{
				return this.PriorityProperties;
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00027000 File Offset: 0x00025200
		void global::Infragistics.IProvidePropertyPersistenceSettings.FinishedLoadingPersistence()
		{
			this.FinishedLoadingPersistence();
		}

		// Token: 0x04000272 RID: 626
		private global::System.Collections.Generic.List<string> _propertiesThatShouldntBePersisted;

		// Token: 0x04000273 RID: 627
		public static readonly global::System.Windows.DependencyProperty AllowSortingProperty = global::System.Windows.DependencyProperty.Register("AllowSorting", typeof(bool), typeof(global::Infragistics.Controls.Grids.SortingSettings), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SortingSettings.AllowSortingChanged)));

		// Token: 0x04000274 RID: 628
		public static readonly global::System.Windows.DependencyProperty ShowSortIndicatorProperty = global::System.Windows.DependencyProperty.Register("ShowSortIndicator", typeof(bool), typeof(global::Infragistics.Controls.Grids.SortingSettings), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SortingSettings.ShowSortIndicatorChanged)));

		// Token: 0x04000275 RID: 629
		public static readonly global::System.Windows.DependencyProperty AllowMultipleColumnSortingProperty = global::System.Windows.DependencyProperty.Register("AllowMultipleColumnSorting", typeof(bool), typeof(global::Infragistics.Controls.Grids.SortingSettings), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SortingSettings.AllowMultipleColumnSortingChanged)));

		// Token: 0x04000276 RID: 630
		public static readonly global::System.Windows.DependencyProperty MultiSortingKeyProperty = global::System.Windows.DependencyProperty.Register("MultiSortingKey", typeof(global::Infragistics.Controls.Grids.MultiSortingKey), typeof(global::Infragistics.Controls.Grids.SortingSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.MultiSortingKey.Control, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SortingSettings.MultiSortingKeyChanged)));

		// Token: 0x04000277 RID: 631
		public static readonly global::System.Windows.DependencyProperty FirstSortDirectionProperty = global::System.Windows.DependencyProperty.Register("FirstSortDirection", typeof(global::Infragistics.Controls.Grids.SortDirection), typeof(global::Infragistics.Controls.Grids.SortingSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.SortDirection.Ascending, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SortingSettings.FirstSortDirectionChanged)));
	}
}
