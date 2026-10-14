using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200006E RID: 110
	[global::System.Windows.TemplatePart(Name = "FilterGrid", Type = typeof(global::Infragistics.Controls.Grids.XamGrid))]
	public class CompoundFilterDialogControl : global::System.Windows.Controls.Control, global::Infragistics.ICommandTarget, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x060003BD RID: 957 RVA: 0x000109C4 File Offset: 0x0000EBC4
		static CompoundFilterDialogControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl)));
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00010C64 File Offset: 0x0000EE64
		public CompoundFilterDialogControl()
		{
			this._dialogPopup = new global::System.Windows.Controls.Primitives.Popup();
			this._dialogPopup.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Relative;
			this._dialogPopup.AllowsTransparency = true;
			this._dialogPopup.StaysOpen = false;
			this._dialogPopup.Closed += this.DialogPopup_Closed;
			this._dialogPopup.Opened += this.DialogPopup_Opened;
			this._dialogPopup.SizeChanged += this.DialogPopup_SizeChanged;
			this.CancelButtonText = global::Infragistics.SRGrid.GetString("CustomFilterDialog_CancelButtonText");
			this.OKButtonText = global::Infragistics.SRGrid.GetString("CustomFilterDialog_OKButtonText");
			this.SelectedGroupText = global::Infragistics.SRGrid.GetString("CompoundFilterDialog_SelectedGroupText");
			this.AndButtonText = global::Infragistics.SRGrid.GetString("CompoundFilterDialog_AndButtonText");
			this.OrButtonText = global::Infragistics.SRGrid.GetString("CompoundFilterDialog_OrButtonText");
			this.AddConditionButtonText = global::Infragistics.SRGrid.GetString("CompoundFilterDialog_AddConditionButtonText");
			this.RemoveConditionButtonText = global::Infragistics.SRGrid.GetString("CompoundFilterDialog_RemoveConditionButtonText");
			this.UngroupButtonText = global::Infragistics.SRGrid.GetString("CompoundFilterDialog_UngroupButtonText");
			this.ToggleButtonText = global::Infragistics.SRGrid.GetString("CompoundFilterDialog_ToggleButtonText");
			this.AndColorLabelText = global::Infragistics.SRGrid.GetString("CompoundFilterDialog_AndColorLabelText");
			this.OrColorLabelText = global::Infragistics.SRGrid.GetString("CompoundFilterDialog_OrColorLabelText");
			base.IsTabStop = false;
			base.Unloaded += this.CompoundFilterDialogControl_Unloaded;
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00010DDD File Offset: 0x0000EFDD
		internal global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Grids.XamGridConditionInfo> InfoObjects
		{
			get
			{
				return this._infoObjects;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00010DE5 File Offset: 0x0000EFE5
		protected internal global::Infragistics.Controls.Grids.XamGrid FilterGrid
		{
			get
			{
				return this._filterGrid;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00010DED File Offset: 0x0000EFED
		internal global::Infragistics.Controls.Grids.XamGridConditionInfoGroup MasterParentGroup
		{
			get
			{
				return this._masterParentGroup;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00010DF5 File Offset: 0x0000EFF5
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00010E00 File Offset: 0x0000F000
		public global::Infragistics.Controls.Grids.CellBase Cell
		{
			get
			{
				return this._cell;
			}
			set
			{
				if (this._cell != value)
				{
					this._cell = value;
					this._defaultFilterOperand = null;
					if (this._proxyColumn != null)
					{
						this._proxyColumn.ProxiedSource = value;
					}
				}
				global::System.Windows.Style style = null;
				if (this._cell != null)
				{
					style = this.Cell.Column.ColumnLayout.FilteringSettings.CustomFilterDialogStyleResolved;
				}
				global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this, style);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00010E64 File Offset: 0x0000F064
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00010E76 File Offset: 0x0000F076
		public string CancelButtonText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.CancelButtonTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.CancelButtonTextProperty, value);
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00010E84 File Offset: 0x0000F084
		private static void CancelButtonTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl)obj;
			compoundFilterDialogControl.OnPropertyChanged("CancelButtonText");
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00010EA3 File Offset: 0x0000F0A3
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00010EB5 File Offset: 0x0000F0B5
		public string OKButtonText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.OKButtonTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.OKButtonTextProperty, value);
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00010EC4 File Offset: 0x0000F0C4
		private static void OKButtonTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl)obj;
			compoundFilterDialogControl.OnPropertyChanged("OKButtonText");
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00010EE3 File Offset: 0x0000F0E3
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00010EF5 File Offset: 0x0000F0F5
		public string SelectedGroupText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.SelectedGroupTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.SelectedGroupTextProperty, value);
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00010F04 File Offset: 0x0000F104
		private static void SelectedGroupTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl)obj;
			compoundFilterDialogControl.OnPropertyChanged("SelectedGroupText");
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00010F23 File Offset: 0x0000F123
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00010F35 File Offset: 0x0000F135
		public string AndButtonText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.AndButtonTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.AndButtonTextProperty, value);
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00010F44 File Offset: 0x0000F144
		private static void AndButtonTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl)obj;
			compoundFilterDialogControl.OnPropertyChanged("AndButtonText");
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00010F63 File Offset: 0x0000F163
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00010F75 File Offset: 0x0000F175
		public string OrButtonText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.OrButtonTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.OrButtonTextProperty, value);
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00010F84 File Offset: 0x0000F184
		private static void OrButtonTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl)obj;
			compoundFilterDialogControl.OnPropertyChanged("OrButtonText");
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00010FA3 File Offset: 0x0000F1A3
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00010FB5 File Offset: 0x0000F1B5
		public string AddConditionButtonText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.AddConditionButtonTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.AddConditionButtonTextProperty, value);
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00010FC4 File Offset: 0x0000F1C4
		private static void AddConditionButtonTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl)obj;
			compoundFilterDialogControl.OnPropertyChanged("AddConditionButtonText");
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00010FE3 File Offset: 0x0000F1E3
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00010FF5 File Offset: 0x0000F1F5
		public string RemoveConditionButtonText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.RemoveConditionButtonTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.RemoveConditionButtonTextProperty, value);
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00011004 File Offset: 0x0000F204
		private static void RemoveConditionButtonTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl)obj;
			compoundFilterDialogControl.OnPropertyChanged("RemoveConditionButtonText");
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00011023 File Offset: 0x0000F223
		// (set) Token: 0x060003DA RID: 986 RVA: 0x00011035 File Offset: 0x0000F235
		public string ToggleButtonText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.ToggleButtonTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.ToggleButtonTextProperty, value);
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00011044 File Offset: 0x0000F244
		private static void ToggleButtonTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl)obj;
			compoundFilterDialogControl.OnPropertyChanged("ToggleButtonText");
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00011063 File Offset: 0x0000F263
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00011075 File Offset: 0x0000F275
		public string UngroupButtonText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.UngroupButtonTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.UngroupButtonTextProperty, value);
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00011084 File Offset: 0x0000F284
		private static void UngroupButtonTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl)obj;
			compoundFilterDialogControl.OnPropertyChanged("UngroupButtonText");
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003DF RID: 991 RVA: 0x000110A3 File Offset: 0x0000F2A3
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x000110B5 File Offset: 0x0000F2B5
		public string AndColorLabelText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.AndColorLabelTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.AndColorLabelTextProperty, value);
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x000110C4 File Offset: 0x0000F2C4
		private static void AndColorLabelTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl)obj;
			compoundFilterDialogControl.OnPropertyChanged("AndColorLabelText");
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x000110E3 File Offset: 0x0000F2E3
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x000110F5 File Offset: 0x0000F2F5
		public string OrColorLabelText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.OrColorLabelTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.OrColorLabelTextProperty, value);
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00011104 File Offset: 0x0000F304
		private static void OrColorLabelTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl)obj;
			compoundFilterDialogControl.OnPropertyChanged("OrColorLabelText");
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00011123 File Offset: 0x0000F323
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x00011135 File Offset: 0x0000F335
		public string FilterDescription
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.FilterDescriptionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.FilterDescriptionProperty, value);
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00011144 File Offset: 0x0000F344
		private static void FilterDescriptionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = (global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl)obj;
			compoundFilterDialogControl.OnPropertyChanged("FilterDescription");
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00011163 File Offset: 0x0000F363
		private void Grid_SizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			this.Hide();
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0001116B File Offset: 0x0000F36B
		private void DialogPopup_SizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			this.AlignPopup();
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00011173 File Offset: 0x0000F373
		private void CompoundFilterDialogControl_SizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			this.AlignPopup();
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0001117B File Offset: 0x0000F37B
		private void MouseLeftButtonDownHandler(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0001117D File Offset: 0x0000F37D
		private void KeyDownHandler(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			if (!e.Handled)
			{
				if (e.Key == global::System.Windows.Input.Key.Escape)
				{
					this.Hide();
					e.Handled = true;
					return;
				}
				if (e.Key == global::System.Windows.Input.Key.Return)
				{
					this.AcceptChanges();
					this.Hide();
					e.Handled = true;
				}
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000111BB File Offset: 0x0000F3BB
		private void CompoundFilterDialogControl_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this.FilterGrid != null)
			{
				this._ignoreCellExitingEditMode = true;
				this.FilterGrid.ItemsSource = null;
				this._ignoreCellExitingEditMode = false;
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000111E0 File Offset: 0x0000F3E0
		private void AlignPopup()
		{
			if (this._dialogPopup.IsOpen)
			{
				global::Infragistics.Controls.Grids.XamGrid grid = this.Cell.Row.ColumnLayout.Grid;
				double num = grid.ActualWidth / 2.0;
				double num2 = grid.ActualHeight / 2.0;
				double num3 = this._dialogPopup.Child.DesiredSize.Width / 2.0;
				double num4 = this._dialogPopup.Child.DesiredSize.Height / 2.0;
				double num5 = num - num3;
				this._dialogPopup.HorizontalOffset = ((num5 < 0.0) ? 0.0 : num5);
				double num6 = num2 - num4;
				this._dialogPopup.VerticalOffset = ((num6 < 0.0) ? 0.0 : num6);
				global::System.Windows.UIElement rootVisual = global::Infragistics.PlatformProxy.GetRootVisual(this._dialogPopup);
				global::System.Windows.Rect rect = new global::System.Windows.Rect(0.0, 0.0, rootVisual.RenderSize.Width, rootVisual.RenderSize.Height);
				if (this._dialogPopup.HorizontalOffset > rect.Right)
				{
					this._dialogPopup.HorizontalOffset = rect.Right / 2.0 - num3;
				}
				if (this._dialogPopup.VerticalOffset > rect.Bottom)
				{
					this._dialogPopup.VerticalOffset = rect.Bottom / 2.0 - num4;
				}
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00011380 File Offset: 0x0000F580
		private void SetupCurrentView()
		{
			if (this._cell != null && this._filterGrid != null && this._needSetupGrid)
			{
				global::Infragistics.Controls.Grids.RowsManager rowsManager = this.Cell.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
				global::Infragistics.Controls.Grids.RowsFilter rowsFilter = null;
				if (rowsManager != null)
				{
					rowsFilter = rowsManager.RowFiltersCollectionResolved[this.Cell.Column.Key];
					if (rowsFilter == null && rowsManager.DataManager != null)
					{
						rowsFilter = new global::Infragistics.Controls.Grids.RowsFilter(rowsManager.DataManager.CachedType, this.Cell.Column);
						rowsManager.RowFiltersCollectionResolved.Add(rowsFilter);
					}
					if (rowsFilter != null)
					{
						this._masterParentGroup.Operator = rowsFilter.Conditions.LogicalOperator;
					}
				}
				this.BuildInfoObjectTree(rowsFilter);
				global::Infragistics.Controls.Grids.ComboBoxColumn comboBoxColumn = this._filterGrid.Columns["FilterOperand"] as global::Infragistics.Controls.Grids.ComboBoxColumn;
				comboBoxColumn.ItemsSource = this._cell.Column.FilterColumnSettings.RowFilterOperands;
				this.SetupGroupColumns();
				if (this._infoObjects.Count == 0 && this._defaultFilterOperand != null && this._defaultFilterOperand.Count > 0)
				{
					this._masterParentGroup.Operator = global::Infragistics.LogicalOperator.And;
					foreach (global::Infragistics.Controls.Grids.FilterOperand fo in this._defaultFilterOperand)
					{
						global::Infragistics.Controls.Grids.FilterOperand filterOperand = this.FindFilterOperand(fo);
						if (filterOperand != null)
						{
							global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = new global::Infragistics.Controls.Grids.XamGridConditionInfo(this._masterParentGroup);
							xamGridConditionInfo.FilterOperand = filterOperand;
							this._infoObjects.Add(xamGridConditionInfo);
						}
					}
				}
				this._needSetupGrid = false;
				this.BuildFilterDescription();
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00011524 File Offset: 0x0000F724
		private void BuildInfoObjectTree(global::Infragistics.Controls.Grids.RowsFilter rowsFilter)
		{
			this._infoObjects = null;
			this._infoObjects = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Grids.XamGridConditionInfo>();
			this._filterGrid.ItemsSource = this.InfoObjects;
			if (rowsFilter != null && rowsFilter.Conditions.Count > 0)
			{
				this.BuildInfoObjectTree(rowsFilter.Conditions, this._masterParentGroup);
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00011578 File Offset: 0x0000F778
		private void BuildInfoObjectTree(global::Infragistics.ConditionCollection collection, global::Infragistics.Controls.Grids.XamGridConditionInfoGroup group)
		{
			foreach (global::Infragistics.IFilterCondition filterCondition in collection)
			{
				if (filterCondition is global::Infragistics.ComparisonCondition)
				{
					global::Infragistics.ComparisonCondition comparisonCondition = (global::Infragistics.ComparisonCondition)filterCondition;
					global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = new global::Infragistics.Controls.Grids.XamGridConditionInfo(group);
					global::Infragistics.Controls.Grids.FilterOperand filterOperand = this.FindFilterOperand(comparisonCondition.Operator);
					if (filterOperand != null)
					{
						xamGridConditionInfo.FilterValue = comparisonCondition.FilterValue;
						xamGridConditionInfo.FilterOperand = filterOperand;
						this._infoObjects.Add(xamGridConditionInfo);
					}
				}
				else if (filterCondition is global::Infragistics.Controls.Grids.ConditionGroup)
				{
					global::Infragistics.Controls.Grids.ConditionGroup conditionGroup = (global::Infragistics.Controls.Grids.ConditionGroup)filterCondition;
					global::Infragistics.Controls.Grids.XamGridConditionInfoGroup xamGridConditionInfoGroup = new global::Infragistics.Controls.Grids.XamGridConditionInfoGroup(group);
					xamGridConditionInfoGroup.Operator = conditionGroup.Conditions.LogicalOperator;
					this.BuildInfoObjectTree(conditionGroup.Conditions, xamGridConditionInfoGroup);
				}
				else if (filterCondition is global::Infragistics.CustomComparisonCondition)
				{
					global::Infragistics.CustomComparisonCondition customComparisonCondition = (global::Infragistics.CustomComparisonCondition)filterCondition;
					global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo2 = new global::Infragistics.Controls.Grids.XamGridConditionInfo(group);
					global::Infragistics.Controls.Grids.FilterOperand filterOperand2 = this.FindFilterOperand(customComparisonCondition.FilterOperand);
					if (filterOperand2 != null)
					{
						xamGridConditionInfo2.FilterValue = customComparisonCondition.FilterValue;
						xamGridConditionInfo2.FilterOperand = filterOperand2;
						this._infoObjects.Add(xamGridConditionInfo2);
					}
				}
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0001169C File Offset: 0x0000F89C
		private global::Infragistics.Controls.Grids.FilterOperand FindFilterOperand(global::Infragistics.ComparisonOperator op)
		{
			foreach (global::Infragistics.Controls.Grids.FilterOperand filterOperand in this._cell.Column.FilterColumnSettings.RowFilterOperands)
			{
				if (filterOperand.ComparisonOperatorValue == op)
				{
					return filterOperand;
				}
			}
			return null;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0001171C File Offset: 0x0000F91C
		private global::Infragistics.Controls.Grids.FilterOperand FindFilterOperand(global::Infragistics.Controls.Grids.FilterOperand fo)
		{
			foreach (global::Infragistics.Controls.Grids.FilterOperand filterOperand in this._cell.Column.FilterColumnSettings.RowFilterOperands)
			{
				if (filterOperand.GetType() == fo.GetType())
				{
					return filterOperand;
				}
			}
			return null;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0001178C File Offset: 0x0000F98C
		private global::Infragistics.Controls.Grids.FilterOperand FindFilterOperand(global::System.Type type)
		{
			foreach (global::Infragistics.Controls.Grids.FilterOperand filterOperand in this._cell.Column.FilterColumnSettings.RowFilterOperands)
			{
				if (filterOperand.GetType() == type)
				{
					return filterOperand;
				}
			}
			return null;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000117F8 File Offset: 0x0000F9F8
		private void SetupGroupColumns()
		{
			if (this._filterGrid != null)
			{
				int num = 0;
				foreach (global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo in this._infoObjects)
				{
					num = global::System.Math.Max(num, xamGridConditionInfo.Group.Level);
				}
				num++;
				int num2 = 0;
				foreach (global::Infragistics.Controls.Grids.Column column in this._filterGrid.Columns.DataColumns)
				{
					if (column is global::Infragistics.Controls.Grids.GroupDisplayColumn)
					{
						num2++;
					}
				}
				if (num2 > num)
				{
					for (int i = num2; i > num; i--)
					{
						global::Infragistics.Controls.Grids.GroupDisplayColumn groupDisplayColumn = null;
						foreach (global::Infragistics.Controls.Grids.Column column2 in this._filterGrid.Columns.DataColumns)
						{
							groupDisplayColumn = (column2 as global::Infragistics.Controls.Grids.GroupDisplayColumn);
							if (groupDisplayColumn != null)
							{
								break;
							}
						}
						if (groupDisplayColumn != null)
						{
							this._filterGrid.Columns.Remove(groupDisplayColumn);
						}
					}
					return;
				}
				if (num2 < num)
				{
					for (int j = num2; j < num; j++)
					{
						this._filterGrid.Columns.Insert(0, new global::Infragistics.Controls.Grids.GroupDisplayColumn
						{
							HeaderText = " ",
							Key = "A" + this._groupColumnKeyCounter
						});
						this._groupColumnKeyCounter++;
					}
				}
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000119A0 File Offset: 0x0000FBA0
		private void RemoveInfoFromCollection(global::Infragistics.Controls.Grids.XamGridConditionInfo removedObject)
		{
			this._infoObjects.Remove(removedObject);
			removedObject.Group = null;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000119C4 File Offset: 0x0000FBC4
		private void CreateDeeperLogicalGroup(global::Infragistics.LogicalOperator op)
		{
			if (this._isOpen && this._filterGrid != null && this._filterGrid.Rows.Count > 0)
			{
				if (this._filterGrid.SelectionSettings.SelectedRows.Count > 1)
				{
					global::Infragistics.Controls.Grids.XamGridConditionInfoGroup xamGridConditionInfoGroup = null;
					bool flag = true;
					global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfo>();
					foreach (global::Infragistics.Controls.Grids.Row row in this._filterGrid.SelectionSettings.SelectedRows)
					{
						global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = (global::Infragistics.Controls.Grids.XamGridConditionInfo)row.Data;
						list.Add(xamGridConditionInfo);
						if (xamGridConditionInfoGroup == null)
						{
							xamGridConditionInfoGroup = xamGridConditionInfo.Group;
						}
						else if (xamGridConditionInfoGroup != xamGridConditionInfo.Group)
						{
							flag = false;
							break;
						}
					}
					if (flag && xamGridConditionInfoGroup.InfoObjects.Count + xamGridConditionInfoGroup.ChildGroups.Count > list.Count)
					{
						global::Infragistics.Controls.Grids.XamGridConditionInfoGroup xamGridConditionInfoGroup2 = new global::Infragistics.Controls.Grids.XamGridConditionInfoGroup(xamGridConditionInfoGroup);
						xamGridConditionInfoGroup2.Operator = op;
						global::System.Linq.IOrderedEnumerable<global::Infragistics.Controls.Grids.XamGridConditionInfo> orderedEnumerable = from a in list
						select a into a
						orderby a.InfoObjectName
						select a;
						foreach (global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo2 in orderedEnumerable)
						{
							xamGridConditionInfo2.Group = xamGridConditionInfoGroup2;
						}
						this.SetupGroupColumns();
					}
				}
				this.BuildFilterDescription();
				this.FilterGrid.InvalidateData();
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00011B70 File Offset: 0x0000FD70
		private void BuildFilters(global::Infragistics.ConditionCollection conditions, global::Infragistics.Controls.Grids.XamGridConditionInfoGroup group)
		{
			conditions.LogicalOperator = group.Operator;
			global::Infragistics.Controls.Grids.RowsManager rowsManager = this.Cell.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
			global::Infragistics.Controls.Grids.XamGrid grid = this.Cell.Column.ColumnLayout.Grid;
			foreach (global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo in group.InfoObjects)
			{
				if (xamGridConditionInfo.FilterOperand != null && !xamGridConditionInfo.HasError)
				{
					if (xamGridConditionInfo.FilterOperand.RequiresFilteringInput)
					{
						global::Infragistics.Controls.Grids.FilterOperand filterOperand = xamGridConditionInfo.FilterOperand;
						object filterValue = xamGridConditionInfo.FilterValue;
						global::System.Type dataType = this._proxyColumn.ProxiedSource.Column.DataType;
						bool flag = filterValue != null || global::Infragistics.Controls.Grids.Primitives.FilterRow.IsNullableValueType(dataType) || !(dataType != typeof(string));
						if (flag)
						{
							if (filterOperand.ComparisonOperatorValue != null)
							{
								if (!grid.OnFiltering(this._proxyColumn.ProxiedSource.Column, xamGridConditionInfo.FilterOperand, rowsManager.RowFiltersCollectionResolved, filterValue))
								{
									conditions.AddItemSilently(new global::Infragistics.ComparisonCondition
									{
										Operator = filterOperand.ComparisonOperatorValue.Value,
										FilterValue = this._proxyColumn.ProxiedSource.Column.ResolveValue(filterValue)
									});
								}
							}
							else
							{
								global::System.Linq.Expressions.Expression expression = xamGridConditionInfo.FilterOperand.FilteringExpression(xamGridConditionInfo.FilterValue);
								if (expression != null && !grid.OnFiltering(this._proxyColumn.ProxiedSource.Column, xamGridConditionInfo.FilterOperand, rowsManager.RowFiltersCollectionResolved, filterValue))
								{
									conditions.AddItemSilently(new global::Infragistics.CustomComparisonCondition
									{
										FilterOperand = filterOperand.GetType(),
										FilterValue = this._proxyColumn.ProxiedSource.Column.ResolveValue(filterValue),
										Expression = expression
									});
								}
							}
						}
					}
					else if (!xamGridConditionInfo.FilterOperand.RequiresFilteringInput)
					{
						global::Infragistics.Controls.Grids.FilterOperand filterOperand2 = xamGridConditionInfo.FilterOperand;
						if (filterOperand2.ComparisonOperatorValue != null)
						{
							if (!grid.OnFiltering(this._proxyColumn.ProxiedSource.Column, xamGridConditionInfo.FilterOperand, rowsManager.RowFiltersCollectionResolved, null))
							{
								conditions.AddItemSilently(new global::Infragistics.ComparisonCondition
								{
									Operator = filterOperand2.ComparisonOperatorValue.Value,
									FilterValue = null
								});
							}
						}
						else
						{
							global::System.Linq.Expressions.Expression expression2 = xamGridConditionInfo.FilterOperand.FilteringExpression(xamGridConditionInfo.FilterValue);
							if (expression2 != null && !grid.OnFiltering(this._proxyColumn.ProxiedSource.Column, xamGridConditionInfo.FilterOperand, rowsManager.RowFiltersCollectionResolved, null))
							{
								conditions.AddItemSilently(new global::Infragistics.CustomComparisonCondition
								{
									FilterOperand = filterOperand2.GetType(),
									FilterValue = null,
									Expression = expression2
								});
							}
						}
					}
				}
			}
			foreach (global::Infragistics.Controls.Grids.XamGridConditionInfoGroup group2 in group.ChildGroups)
			{
				global::Infragistics.Controls.Grids.ConditionGroup conditionGroup = new global::Infragistics.Controls.Grids.ConditionGroup(conditions.Parent);
				this.BuildFilters(conditionGroup.Conditions, group2);
				if (conditionGroup.Conditions.Count > 0)
				{
					conditions.AddItemSilently(conditionGroup);
				}
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00011EF8 File Offset: 0x000100F8
		private void BuildFilterDescription()
		{
			if (this._masterParentGroup.ChildGroups.Count == 0 && this._masterParentGroup.InfoObjects.Count == 0)
			{
				this.FilterDescription = string.Empty;
				return;
			}
			string @string = global::Infragistics.SRGrid.GetString("LogicalAND");
			string string2 = global::Infragistics.SRGrid.GetString("LogicalOR");
			string text = string.Empty;
			if (this._masterParentGroup.InfoObjects.Count > 0)
			{
				text += this.BuildFilterDescriptionFromInfoObjects(this._masterParentGroup.Operator, this._masterParentGroup.InfoObjects);
			}
			if (this._masterParentGroup.ChildGroups.Count > 0)
			{
				bool flag = false;
				if (text.Length > 0)
				{
					if (this._masterParentGroup.Operator == global::Infragistics.LogicalOperator.And)
					{
						text = text + " " + @string + " (";
					}
					else
					{
						text = text + " " + string2 + " (";
					}
					flag = true;
				}
				text += this.BuildFilterDescriptionFromInfoGroups(this._masterParentGroup.Operator, this._masterParentGroup.ChildGroups);
				if (flag)
				{
					text += " )";
				}
			}
			this.FilterDescription = text;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00012014 File Offset: 0x00010214
		private string BuildFilterDescriptionFromInfoObjects(global::Infragistics.LogicalOperator op, global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfo> list)
		{
			string text = string.Empty;
			if (this.Cell != null)
			{
				string displayNameResolved = this._cell.Column.DisplayNameResolved;
				string @string = global::Infragistics.SRGrid.GetString("LogicalAND");
				string string2 = global::Infragistics.SRGrid.GetString("LogicalOR");
				foreach (global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo in list)
				{
					if (text.Length > 0)
					{
						if (op == global::Infragistics.LogicalOperator.And)
						{
							text = text + " " + @string + " ";
						}
						else
						{
							text = text + " " + string2 + " ";
						}
					}
					if (xamGridConditionInfo.FilterOperand != null)
					{
						string arg = (xamGridConditionInfo.FilterValue == null) ? "" : xamGridConditionInfo.FilterValue.ToString();
						if (xamGridConditionInfo.FilterOperand.RequiresFilteringInput)
						{
							text = text + displayNameResolved + " " + string.Format(xamGridConditionInfo.FilterOperand.DisplayNameWithInputFormat, arg);
						}
						else
						{
							text = text + displayNameResolved + " " + xamGridConditionInfo.FilterOperand.DisplayName;
						}
					}
				}
			}
			return text;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00012140 File Offset: 0x00010340
		private string BuildFilterDescriptionFromInfoGroups(global::Infragistics.LogicalOperator op, global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup> list)
		{
			string text = string.Empty;
			string @string = global::Infragistics.SRGrid.GetString("LogicalAND");
			string string2 = global::Infragistics.SRGrid.GetString("LogicalOR");
			foreach (global::Infragistics.Controls.Grids.XamGridConditionInfoGroup xamGridConditionInfoGroup in list)
			{
				if (text.Length > 0)
				{
					text = "(" + text + ")";
				}
				if (text.Length > 0)
				{
					if (op == global::Infragistics.LogicalOperator.And)
					{
						text = text + " " + @string + " ";
					}
					else
					{
						text = text + " " + string2 + " ";
					}
				}
				bool flag = text.Length > 0;
				if (flag)
				{
					text += "(";
				}
				if (xamGridConditionInfoGroup.InfoObjects.Count > 0)
				{
					text += this.BuildFilterDescriptionFromInfoObjects(xamGridConditionInfoGroup.Operator, xamGridConditionInfoGroup.InfoObjects);
				}
				if (xamGridConditionInfoGroup.ChildGroups.Count > 0)
				{
					bool flag2 = false;
					if (text.Length > 0)
					{
						if (xamGridConditionInfoGroup.Operator == global::Infragistics.LogicalOperator.And)
						{
							text = text + " " + @string + " (";
						}
						else
						{
							text = text + " " + string2 + " (";
						}
						flag2 = true;
					}
					text += this.BuildFilterDescriptionFromInfoGroups(xamGridConditionInfoGroup.Operator, xamGridConditionInfoGroup.ChildGroups);
					if (flag2)
					{
						text += ")";
					}
				}
				if (flag)
				{
					text += ")";
				}
			}
			return text;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000122CC File Offset: 0x000104CC
		public virtual void Show(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand> initialOperands)
		{
			this._defaultFilterOperand = initialOperands;
			this.Show();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000122E4 File Offset: 0x000104E4
		public virtual void Show()
		{
			this._infoObjects.Clear();
			this._masterParentGroup.ChildGroups.Clear();
			this._masterParentGroup.InfoObjects.Clear();
			if (this._dialogPopup != null && !this._isOpen)
			{
				this._isOpen = true;
				this._dialogPopup.Child = this;
				if (!this.Cell.Row.ColumnLayout.Grid.Panel.Children.Contains(this._dialogPopup))
				{
					this.Cell.Row.ColumnLayout.Grid.Panel.Children.Add(this._dialogPopup);
				}
				global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)this._dialogPopup.Child;
				if (frameworkElement != null)
				{
					frameworkElement.SizeChanged += this.CompoundFilterDialogControl_SizeChanged;
				}
				this._dialogPopup.IsOpen = true;
				this.SetupCurrentView();
				global::Infragistics.Controls.Grids.Column column = this.Cell.Column;
				global::Infragistics.Controls.Grids.XamGrid grid = this.Cell.Row.ColumnLayout.Grid;
				global::System.Windows.VisualStateManager.GoToState(grid, "ReadOnly", false);
				global::System.Windows.UIElement rootVisual = global::Infragistics.PlatformProxy.GetRootVisual(grid);
				this._rootVis = rootVisual;
				global::Infragistics.Controls.PresentationUtilities.AddHandler(rootVisual, this, global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(this.KeyDownHandler), true);
				rootVisual.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.MouseLeftButtonDownHandler), true);
				grid.SizeChanged += this.Grid_SizeChanged;
				if (grid.ColumnChooserDialog.IsOpen)
				{
					grid.ColumnChooserDialog.IsOpen = false;
					this._columnChooserWasOpen = true;
				}
				global::Infragistics.Controls.PresentationUtilities.AddHandler(this, this, global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(this.KeyDownHandler), true);
				base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
				{
					base.Focus();
				}), new object[0]);
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000124B4 File Offset: 0x000106B4
		public virtual void Hide()
		{
			this._defaultFilterOperand = null;
			if (this._dialogPopup != null && this._isOpen)
			{
				this._dialogPopup.IsOpen = false;
				this._isOpen = false;
				global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)this._dialogPopup.Child;
				if (frameworkElement != null)
				{
					frameworkElement.SizeChanged -= this.CompoundFilterDialogControl_SizeChanged;
				}
				global::Infragistics.Controls.Grids.XamGrid grid = this.Cell.Row.ColumnLayout.Grid;
				if (this._rootVis != null)
				{
					global::Infragistics.Controls.PresentationUtilities.RemoveHandler(this._rootVis, this, global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(this.KeyDownHandler));
					this._rootVis.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.MouseLeftButtonDownHandler));
				}
				global::Infragistics.Controls.PresentationUtilities.RemoveHandler(this, this, global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(this.KeyDownHandler));
				grid.SizeChanged -= this.Grid_SizeChanged;
				this._dialogPopup.Child = null;
				if (this.Cell.Row.ColumnLayout.Grid.Panel.Children.Contains(this._dialogPopup))
				{
					this.Cell.Row.ColumnLayout.Grid.Panel.Children.Remove(this._dialogPopup);
				}
				global::System.Windows.VisualStateManager.GoToState(grid, "Active", false);
			}
			if (this._columnChooserWasOpen)
			{
				if (this.Cell != null && this.Cell.Row != null && this.Cell.Row.ColumnLayout != null)
				{
					this.Cell.Row.ColumnLayout.Grid.ColumnChooserDialog.IsOpen = true;
				}
				this._columnChooserWasOpen = false;
			}
			this._needSetupGrid = true;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00012664 File Offset: 0x00010864
		internal void AcceptChanges()
		{
			if (this._filterGrid.CurrentEditCell != null)
			{
				this._filterGrid.ExitEditMode(false);
			}
			global::Infragistics.Controls.Grids.RowsManager rowsManager = this.Cell.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
			global::Infragistics.Controls.Grids.RowsFilter rowsFilter = null;
			if (rowsManager != null)
			{
				rowsFilter = rowsManager.RowFiltersCollectionResolved[this.Cell.Column.Key];
				if (rowsFilter == null && rowsManager.DataManager != null)
				{
					rowsFilter = new global::Infragistics.Controls.Grids.RowsFilter(rowsManager.DataManager.CachedType, this.Cell.Column);
					rowsManager.RowFiltersCollectionResolved.Add(rowsFilter);
				}
			}
			rowsFilter.Conditions.ClearSilently();
			this.BuildFilters(rowsFilter.Conditions, this._masterParentGroup);
			this.Cell.Column.ColumnLayout.Grid.OnFiltered(rowsManager.RowFiltersCollectionResolved);
			rowsManager.ColumnLayout.InvalidateFiltering();
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0001273D File Offset: 0x0001093D
		protected virtual object GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00012740 File Offset: 0x00010940
		internal void AddNewFilterCondition()
		{
			if (this._isOpen && this._filterGrid != null)
			{
				this._filterGrid.ExitEditMode(false);
				global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo;
				if (this._filterGrid.ActiveCell == null)
				{
					xamGridConditionInfo = new global::Infragistics.Controls.Grids.XamGridConditionInfo(this._masterParentGroup);
				}
				else
				{
					xamGridConditionInfo = new global::Infragistics.Controls.Grids.XamGridConditionInfo(((global::Infragistics.Controls.Grids.XamGridConditionInfo)this._filterGrid.ActiveCell.Row.Data).Group);
				}
				xamGridConditionInfo.FilterOperand = this._cell.Column.FilterColumnSettings.RowFilterOperands[0];
				this._infoObjects.Add(xamGridConditionInfo);
				this.BuildFilterDescription();
				this.EnsureVisualState();
				this.FilterGrid.InvalidateData();
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00012828 File Offset: 0x00010A28
		internal void RemoveConditions()
		{
			if (this._isOpen && this._filterGrid != null && this._filterGrid.Rows.Count > 0)
			{
				this._filterGrid.ExitEditMode(false);
				if (this._filterGrid.SelectionSettings.SelectedRows.Count > 0)
				{
					global::Infragistics.Controls.Grids.XamGridConditionInfoGroup xamGridConditionInfoGroup = null;
					bool flag = true;
					global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfo>();
					foreach (global::Infragistics.Controls.Grids.Row row in this._filterGrid.SelectionSettings.SelectedRows)
					{
						global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = (global::Infragistics.Controls.Grids.XamGridConditionInfo)row.Data;
						list.Add(xamGridConditionInfo);
						if (xamGridConditionInfoGroup == null)
						{
							xamGridConditionInfoGroup = xamGridConditionInfo.Group;
						}
						else if (xamGridConditionInfoGroup != xamGridConditionInfo.Group)
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup> list2 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup>();
						foreach (global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo2 in list)
						{
							list2.Add(xamGridConditionInfo2.Group);
							this.RemoveInfoFromCollection(xamGridConditionInfo2);
						}
						global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup> list3 = (from s in (from s in list2
						where s.InfoObjects.Count == 1
						select s).Distinct<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup>()
						orderby s.Level descending
						select s).ToList<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup>();
						if (list3.Count > 0)
						{
							foreach (global::Infragistics.Controls.Grids.XamGridConditionInfoGroup xamGridConditionInfoGroup2 in list3)
							{
								if (xamGridConditionInfoGroup2.InfoObjects.Count == 1)
								{
									global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo3 = xamGridConditionInfoGroup2.InfoObjects[0];
									if (xamGridConditionInfo3.Group != this._masterParentGroup)
									{
										xamGridConditionInfo3.Group = xamGridConditionInfo3.Group.ParentGroup;
									}
								}
							}
						}
						global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup> list4 = (from s in (from s in list2
						where s.InfoObjects.Count == 0
						select s).Distinct<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup>()
						orderby s.Level descending
						select s).ToList<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup>();
						if (list4.Count > 0)
						{
							foreach (global::Infragistics.Controls.Grids.XamGridConditionInfoGroup xamGridConditionInfoGroup3 in list4)
							{
								xamGridConditionInfoGroup3.ParentGroup = null;
							}
						}
					}
				}
				this.BuildFilterDescription();
				this.SetupGroupColumns();
				this.EnsureVisualState();
				this.FilterGrid.InvalidateData();
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00012AF8 File Offset: 0x00010CF8
		internal void CreateOrGroup()
		{
			this.CreateDeeperLogicalGroup(global::Infragistics.LogicalOperator.Or);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00012B01 File Offset: 0x00010D01
		internal void CreateAndGroup()
		{
			this.CreateDeeperLogicalGroup(global::Infragistics.LogicalOperator.And);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00012B4C File Offset: 0x00010D4C
		internal void Ungroup()
		{
			if (this._isOpen && this._filterGrid != null && this._filterGrid.Rows.Count > 0 && this._filterGrid.SelectionSettings.SelectedRows.Count > 0)
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup>();
				foreach (global::Infragistics.Controls.Grids.Row row in this._filterGrid.SelectionSettings.SelectedRows)
				{
					global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = (global::Infragistics.Controls.Grids.XamGridConditionInfo)row.Data;
					if (xamGridConditionInfo.Group != this._masterParentGroup)
					{
						list.Add(xamGridConditionInfo.Group);
						xamGridConditionInfo.Group = xamGridConditionInfo.Group.ParentGroup;
					}
				}
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup> list2 = (from s in (from s in list
				where s.InfoObjects.Count == 1
				select s).Distinct<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup>()
				orderby s.Level descending
				select s).ToList<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup>();
				if (list2.Count > 0)
				{
					foreach (global::Infragistics.Controls.Grids.XamGridConditionInfoGroup xamGridConditionInfoGroup in list2)
					{
						if (xamGridConditionInfoGroup.InfoObjects.Count == 1)
						{
							global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo2 = xamGridConditionInfoGroup.InfoObjects[0];
							if (xamGridConditionInfo2.Group != this._masterParentGroup)
							{
								xamGridConditionInfo2.Group = xamGridConditionInfo2.Group.ParentGroup;
							}
						}
					}
				}
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup> list3 = (from s in (from s in list
				where s.InfoObjects.Count == 0 && s.ChildGroups.Count == 0
				select s).Distinct<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup>()
				orderby s.Level descending
				select s).ToList<global::Infragistics.Controls.Grids.XamGridConditionInfoGroup>();
				if (list3.Count > 0)
				{
					foreach (global::Infragistics.Controls.Grids.XamGridConditionInfoGroup xamGridConditionInfoGroup2 in list3)
					{
						xamGridConditionInfoGroup2.ParentGroup = null;
					}
				}
				this.SetupGroupColumns();
				this._filterGrid.InvalidateData();
			}
			this.BuildFilterDescription();
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00012DAC File Offset: 0x00010FAC
		internal void ToggleGroup()
		{
			if (this._isOpen && this._filterGrid != null && this._filterGrid.Rows.Count > 0)
			{
				this._filterGrid.ExitEditMode(false);
				if (this._filterGrid.SelectionSettings.SelectedRows.Count > 0)
				{
					global::Infragistics.Controls.Grids.XamGridConditionInfoGroup xamGridConditionInfoGroup = null;
					bool flag = true;
					foreach (global::Infragistics.Controls.Grids.Row row in this._filterGrid.SelectionSettings.SelectedRows)
					{
						global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = (global::Infragistics.Controls.Grids.XamGridConditionInfo)row.Data;
						if (xamGridConditionInfoGroup == null)
						{
							xamGridConditionInfoGroup = xamGridConditionInfo.Group;
						}
						else if (xamGridConditionInfoGroup != xamGridConditionInfo.Group)
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						xamGridConditionInfoGroup.Operator = ((xamGridConditionInfoGroup.Operator == global::Infragistics.LogicalOperator.And) ? global::Infragistics.LogicalOperator.Or : global::Infragistics.LogicalOperator.And);
						this._filterGrid.InvalidateData();
					}
				}
				this.BuildFilterDescription();
				this.EnsureVisualState();
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00012EAC File Offset: 0x000110AC
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._filterGrid != null)
			{
				this._filterGrid.SelectedRowsCollectionChanged -= this.FilterGrid_SelectedRowsCollectionChanged;
				this._filterGrid.CellEnteringEditMode -= this.FilterGrid_CellEnteringEditMode;
				this._filterGrid.CellExitingEditMode -= this.FilterGrid_CellExitingEditMode;
				this._filterGrid.CellExitedEditMode -= this.FilterGrid_CellExitedEditMode;
			}
			this._filterGrid = (base.GetTemplateChild("FilterGrid") as global::Infragistics.Controls.Grids.XamGrid);
			if (this._filterGrid != null)
			{
				this._filterGrid.ItemsSource = this._infoObjects;
				this._filterGrid.SelectedRowsCollectionChanged += this.FilterGrid_SelectedRowsCollectionChanged;
				this._filterGrid.CellEnteringEditMode += this.FilterGrid_CellEnteringEditMode;
				this._filterGrid.CellExitingEditMode += this.FilterGrid_CellExitingEditMode;
				this._filterGrid.CellExitedEditMode += this.FilterGrid_CellExitedEditMode;
				this._proxyColumn = (this._filterGrid.Columns["FilterValue"] as global::Infragistics.Controls.Grids.ProxyColumn);
				this._proxyColumn.ProxiedSource = this.Cell;
				if (this._cell != null)
				{
					global::Infragistics.Controls.Grids.ComboBoxColumn comboBoxColumn = this._filterGrid.Columns["FilterOperand"] as global::Infragistics.Controls.Grids.ComboBoxColumn;
					if (comboBoxColumn != null)
					{
						comboBoxColumn.ItemsSource = this._cell.Column.FilterColumnSettings.RowFilterOperands;
					}
				}
			}
			this.SetupCurrentView();
			this.EnsureVisualState();
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0001302F File Offset: 0x0001122F
		private void EnsureVisualState()
		{
			this.CheckButtonState();
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00013038 File Offset: 0x00011238
		protected virtual void CheckButtonState()
		{
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Grids.Primitives.AddToCurrentCompoundFilterDialogCommand));
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Grids.Primitives.RemoveConditionsCompoundFilterDialogCommand));
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Grids.Primitives.CreateAndGroupCompoundFilterDialogCommand));
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Grids.Primitives.CreateOrGroupCompoundFilterDialogCommand));
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Grids.Primitives.UngroupCompoundFilterDialogCommand));
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Grids.Primitives.ToggleGroupCompoundFilterDialogCommand));
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0001309F File Offset: 0x0001129F
		private void FilterGrid_SelectedRowsCollectionChanged(object sender, global::Infragistics.Controls.Grids.SelectionCollectionChangedEventArgs<global::Infragistics.Controls.Grids.SelectedRowsCollection> e)
		{
			this.EnsureVisualState();
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000130A8 File Offset: 0x000112A8
		private void FilterGrid_CellEnteringEditMode(object sender, global::Infragistics.Controls.Grids.BeginEditingCellEventArgs e)
		{
			if (e.Cell.Column.Key == "FilterValue")
			{
				global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = (global::Infragistics.Controls.Grids.XamGridConditionInfo)e.Cell.Row.Data;
				if (!xamGridConditionInfo.FilterOperand.RequiresFilteringInput)
				{
					e.Cancel = true;
				}
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000130FC File Offset: 0x000112FC
		private void FilterGrid_CellExitingEditMode(object sender, global::Infragistics.Controls.Grids.ExitEditingCellEventArgs e)
		{
			if (!this._ignoreCellExitingEditMode && e.Cell.Column.Key == "FilterValue")
			{
				global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = (global::Infragistics.Controls.Grids.XamGridConditionInfo)e.Cell.Row.Data;
				try
				{
					this._proxyColumn.ProxiedSource.Column.ResolveValue(e.NewValue);
					xamGridConditionInfo.ErrorMessage = string.Empty;
				}
				catch (global::System.Exception ex)
				{
					xamGridConditionInfo.ErrorMessage = ex.Message;
					e.Cancel = true;
				}
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00013194 File Offset: 0x00011394
		private void FilterGrid_CellExitedEditMode(object sender, global::Infragistics.Controls.Grids.CellExitedEditingEventArgs e)
		{
			this.BuildFilterDescription();
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0001319C File Offset: 0x0001139C
		private void DialogPopup_Closed(object sender, global::System.EventArgs e)
		{
			this.Hide();
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000131A4 File Offset: 0x000113A4
		private void DialogPopup_Opened(object sender, global::System.EventArgs e)
		{
			this.AlignPopup();
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000131AC File Offset: 0x000113AC
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogCommandBase;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000131B7 File Offset: 0x000113B7
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.GetParameter(source);
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000412 RID: 1042 RVA: 0x000131C0 File Offset: 0x000113C0
		// (remove) Token: 0x06000413 RID: 1043 RVA: 0x000131F8 File Offset: 0x000113F8
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000414 RID: 1044 RVA: 0x0001322D File Offset: 0x0001142D
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x040000E7 RID: 231
		private bool _columnChooserWasOpen;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Controls.Primitives.Popup _dialogPopup;

		// Token: 0x040000E9 RID: 233
		private global::Infragistics.Controls.Grids.CellBase _cell;

		// Token: 0x040000EA RID: 234
		private bool _isOpen;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.UIElement _rootVis;

		// Token: 0x040000EC RID: 236
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand> _defaultFilterOperand;

		// Token: 0x040000ED RID: 237
		private global::Infragistics.Controls.Grids.XamGrid _filterGrid;

		// Token: 0x040000EE RID: 238
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Grids.XamGridConditionInfo> _infoObjects = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Grids.XamGridConditionInfo>();

		// Token: 0x040000EF RID: 239
		private global::Infragistics.Controls.Grids.XamGridConditionInfoGroup _masterParentGroup = new global::Infragistics.Controls.Grids.XamGridConditionInfoGroup(null);

		// Token: 0x040000F0 RID: 240
		private bool _needSetupGrid = true;

		// Token: 0x040000F1 RID: 241
		private int _groupColumnKeyCounter;

		// Token: 0x040000F2 RID: 242
		private global::Infragistics.Controls.Grids.ProxyColumn _proxyColumn;

		// Token: 0x040000F3 RID: 243
		private string _filterDescription = string.Empty;

		// Token: 0x040000F4 RID: 244
		public static readonly global::System.Windows.DependencyProperty CancelButtonTextProperty = global::System.Windows.DependencyProperty.Register("CancelButtonText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.CancelButtonTextChanged)));

		// Token: 0x040000F5 RID: 245
		public static readonly global::System.Windows.DependencyProperty OKButtonTextProperty = global::System.Windows.DependencyProperty.Register("OKButtonText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.OKButtonTextChanged)));

		// Token: 0x040000F6 RID: 246
		public static readonly global::System.Windows.DependencyProperty SelectedGroupTextProperty = global::System.Windows.DependencyProperty.Register("SelectedGroupText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.SelectedGroupTextChanged)));

		// Token: 0x040000F7 RID: 247
		public static readonly global::System.Windows.DependencyProperty AndButtonTextProperty = global::System.Windows.DependencyProperty.Register("AndButtonText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.AndButtonTextChanged)));

		// Token: 0x040000F8 RID: 248
		public static readonly global::System.Windows.DependencyProperty OrButtonTextProperty = global::System.Windows.DependencyProperty.Register("OrButtonText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.OrButtonTextChanged)));

		// Token: 0x040000F9 RID: 249
		public static readonly global::System.Windows.DependencyProperty AddConditionButtonTextProperty = global::System.Windows.DependencyProperty.Register("AddConditionButtonText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.AddConditionButtonTextChanged)));

		// Token: 0x040000FA RID: 250
		public static readonly global::System.Windows.DependencyProperty RemoveConditionButtonTextProperty = global::System.Windows.DependencyProperty.Register("RemoveConditionButtonText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.RemoveConditionButtonTextChanged)));

		// Token: 0x040000FB RID: 251
		public static readonly global::System.Windows.DependencyProperty ToggleButtonTextProperty = global::System.Windows.DependencyProperty.Register("ToggleButtonText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.ToggleButtonTextChanged)));

		// Token: 0x040000FC RID: 252
		public static readonly global::System.Windows.DependencyProperty UngroupButtonTextProperty = global::System.Windows.DependencyProperty.Register("UngroupButtonText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.UngroupButtonTextChanged)));

		// Token: 0x040000FD RID: 253
		public static readonly global::System.Windows.DependencyProperty AndColorLabelTextProperty = global::System.Windows.DependencyProperty.Register("AndColorLabelText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.AndColorLabelTextChanged)));

		// Token: 0x040000FE RID: 254
		public static readonly global::System.Windows.DependencyProperty OrColorLabelTextProperty = global::System.Windows.DependencyProperty.Register("OrColorLabelText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.OrColorLabelTextChanged)));

		// Token: 0x040000FF RID: 255
		public static readonly global::System.Windows.DependencyProperty FilterDescriptionProperty = global::System.Windows.DependencyProperty.Register("FilterDescription", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl.FilterDescriptionChanged)));

		// Token: 0x04000100 RID: 256
		private bool _ignoreCellExitingEditMode;
	}
}
