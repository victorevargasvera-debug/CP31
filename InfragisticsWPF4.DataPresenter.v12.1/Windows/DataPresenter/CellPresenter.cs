using System;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Data;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000056 RID: 86
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CellPresenter : global::Infragistics.Windows.DataPresenter.CellPresenterBase, global::System.Windows.IWeakEventListener
	{
		// Token: 0x06000451 RID: 1105 RVA: 0x0000EE24 File Offset: 0x0000D024
		static CellPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000F173 File Offset: 0x0000D373
		public CellPresenter()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.DataPresenter.CellPresenter.CellPresenterStyleSelectorHelper(this);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000F188 File Offset: 0x0000D388
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (this._layoutElement == null)
			{
				this._layoutElement = (global::Infragistics.Windows.Utilities.GetDescendantFromType(this, typeof(global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElement), false) as global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElement);
				this.SynchronizeChildElements();
			}
			if (this._recordOrFieldHasChangedSinceLastMeasure)
			{
				this._recordOrFieldHasChangedSinceLastMeasure = false;
				if (this._cachedField != null && this._dataRecord != null)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternatePropertyKey, global::Infragistics.KnownBoxes.FromValue(this.IsAlternate));
					base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsActiveProperty, global::Infragistics.KnownBoxes.FromValue(this.IsActive));
					base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsSelectedProperty, global::Infragistics.KnownBoxes.FromValue(this.IsSelected));
				}
			}
			return base.MeasureOverride(availableSize);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000F228 File Offset: 0x0000D428
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (property == global::System.Windows.FrameworkElement.DataContextProperty)
			{
				this._recordOrFieldHasChangedSinceLastMeasure = true;
				this.InitializeRecord();
				return;
			}
			if (property == global::Infragistics.Windows.DataPresenter.CellPresenter.SortStatusInternalProperty)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.SortStatusPropertyKey, this.SortStatusInternal);
				return;
			}
			if (property == global::Infragistics.Windows.DataPresenter.CellPresenter.FieldProperty)
			{
				this._cachedField = (e.NewValue as global::Infragistics.Windows.DataPresenter.Field);
				this._recordOrFieldHasChangedSinceLastMeasure = true;
				if (this._cachedField == null)
				{
					this.UnhookAndClearRecord();
					global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DataPresenter.CellPresenter.SortStatusInternalProperty);
					global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DataPresenter.CellPresenter.IsFieldSelectedProperty);
					global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DataPresenter.GridUtilities.FieldVisibilityProperty);
					global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DataPresenter.CellPresenter.IsFixedInternalProperty);
				}
				else
				{
					if (this._dataRecord != null && this._cachedField != null)
					{
						base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.ValueProperty, this.Value);
					}
					global::Infragistics.Windows.Controls.RelativeContentLocation relativeContentLocation = global::Infragistics.Windows.Controls.RelativeContentLocation.AboveContentLeft;
					int num = (int)this._cachedField.CellContentAlignmentResolved;
					num -= 3;
					if (num >= 0)
					{
						relativeContentLocation = (global::Infragistics.Windows.Controls.RelativeContentLocation)num;
					}
					base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.ContentLocationPropertyKey, relativeContentLocation);
					base.SetBinding(global::Infragistics.Windows.DataPresenter.GridUtilities.FieldVisibilityProperty, this._cachedField.VisibilityBinding);
					base.SetBinding(global::Infragistics.Windows.DataPresenter.CellPresenter.SortStatusInternalProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.Field.SortStatusProperty, global::System.Windows.Data.BindingMode.OneWay, this._cachedField));
					base.SetBinding(global::Infragistics.Windows.DataPresenter.CellPresenter.IsFieldSelectedProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.Field.IsSelectedProperty, global::System.Windows.Data.BindingMode.OneWay, this._cachedField));
					base.SetBinding(global::Infragistics.Windows.DataPresenter.CellPresenter.IsFixedInternalProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.Field.IsFixedProperty, global::System.Windows.Data.BindingMode.OneWay, this._cachedField));
					global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._cachedField.Owner;
					if (owner != null)
					{
						base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.HasSeparateHeaderProperty, owner.HasSeparateHeader);
					}
				}
				this.InvalidateStyleSelector();
				return;
			}
			if (e.Property == global::Infragistics.Windows.DataPresenter.CellPresenter.IsFixedInternalProperty)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsFixedPropertyKey, (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsFixedInternalProperty));
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		internal override void SynchronizeChildElements()
		{
			global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = this.LabelPresenter;
			if (labelPresenter != null && this._isDragIndicator != labelPresenter.IsDragIndicator)
			{
				if (this._isDragIndicator)
				{
					labelPresenter.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsDragIndicatorProperty, global::Infragistics.KnownBoxes.TrueBox);
				}
				else
				{
					labelPresenter.ClearValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsDragIndicatorProperty);
				}
			}
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = this.CellValuePresenter;
			if (cellValuePresenter != null && this._isDragIndicator != cellValuePresenter.IsDragIndicator)
			{
				if (this._isDragIndicator)
				{
					cellValuePresenter.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsDragIndicatorProperty, global::Infragistics.KnownBoxes.TrueBox);
					return;
				}
				cellValuePresenter.ClearValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsDragIndicatorProperty);
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000F478 File Offset: 0x0000D678
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("CellPresenter: ");
			if (this._cachedField != null)
			{
				stringBuilder.Append(this._cachedField.ToString());
				stringBuilder.Append(", ");
			}
			if (this._dataRecord != null)
			{
				stringBuilder.Append(this._dataRecord.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0000F4DD File Offset: 0x0000D6DD
		public global::Infragistics.Windows.Controls.RelativeContentLocation ContentLocation
		{
			get
			{
				return (global::Infragistics.Windows.Controls.RelativeContentLocation)base.GetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.ContentLocationProperty);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0000F4EF File Offset: 0x0000D6EF
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				if (this._cachedField != null)
				{
					return this._cachedField.Owner.DataPresenter;
				}
				return null;
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000F50C File Offset: 0x0000D70C
		private static void OnFieldChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = (global::Infragistics.Windows.DataPresenter.CellPresenter)dependencyObject;
			global::Infragistics.Windows.DataPresenter.Field cachedField = (global::Infragistics.Windows.DataPresenter.Field)e.NewValue;
			cellPresenter._cachedField = cachedField;
			cellPresenter.InvalidateLayoutElement();
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0000F53A File Offset: 0x0000D73A
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x0000F542 File Offset: 0x0000D742
		public override global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._cachedField;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.FieldProperty, value);
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0000F550 File Offset: 0x0000D750
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x0000F562 File Offset: 0x0000D762
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasSeparateHeader
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.HasSeparateHeaderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.HasSeparateHeaderProperty, value);
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000F578 File Offset: 0x0000D778
		private static void OnIsActiveChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = target as global::Infragistics.Windows.DataPresenter.CellPresenter;
			if (cellPresenter != null && cellPresenter.ReadLocalValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsActiveProperty) == global::System.Windows.DependencyProperty.UnsetValue)
			{
				bool flag = (bool)e.NewValue;
				global::Infragistics.Windows.DataPresenter.CellPresenter.CoerceIsActive(cellPresenter, global::Infragistics.KnownBoxes.FromValue(flag));
				if (cellPresenter.IsActive != flag)
				{
					cellPresenter.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsActiveProperty, global::Infragistics.KnownBoxes.FromValue(cellPresenter.IsActive));
				}
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000F5DC File Offset: 0x0000D7DC
		private static object CoerceIsActive(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = target as global::Infragistics.Windows.DataPresenter.CellPresenter;
			if (cellPresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = cellPresenter.DataPresenter;
				if (dataPresenter != null)
				{
					if (!(bool)value)
					{
						global::Infragistics.Windows.DataPresenter.Cell activeCell = dataPresenter.ActiveCell;
						if (activeCell != null && cellPresenter._cachedField == activeCell.Field && cellPresenter._dataRecord == activeCell.Record)
						{
							dataPresenter.ActiveCell = null;
						}
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = cellPresenter._dataRecord;
						global::Infragistics.Windows.DataPresenter.Field cachedField = cellPresenter._cachedField;
						if (dataRecord != null && cachedField != null)
						{
							dataPresenter.ActiveCell = dataRecord.Cells[cachedField];
						}
					}
					return global::Infragistics.KnownBoxes.FromValue(cellPresenter.IsActive);
				}
			}
			return global::Infragistics.KnownBoxes.FalseBox;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0000F670 File Offset: 0x0000D870
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x0000F6BD File Offset: 0x0000D8BD
		public bool IsActive
		{
			get
			{
				if (this._dataRecord == null || !this._dataRecord.IsActive)
				{
					return false;
				}
				if (this._cachedField == null)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.Cell activeCell = this.DataPresenter.ActiveCell;
				return activeCell != null && activeCell.Field == this._cachedField;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsActiveProperty, value);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0000F6D0 File Offset: 0x0000D8D0
		public bool IsAlternate
		{
			get
			{
				if (this._cachedField != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._cachedField.Owner;
					if (owner != null && owner.HighlightAlternateRecordsResolved)
					{
						global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true, this) as global::Infragistics.Windows.DataPresenter.RecordPresenter;
						if (recordPresenter != null)
						{
							return recordPresenter.IsAlternate;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000F720 File Offset: 0x0000D920
		private static void OnIsDragIndicatorChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = target as global::Infragistics.Windows.DataPresenter.CellPresenter;
			cellPresenter._isDragIndicator = (bool)e.NewValue;
			cellPresenter.SynchronizeChildElements();
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0000F74C File Offset: 0x0000D94C
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x0000F754 File Offset: 0x0000D954
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsDragIndicator
		{
			get
			{
				return this._isDragIndicator;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsDragIndicatorProperty, value);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0000F767 File Offset: 0x0000D967
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x0000F779 File Offset: 0x0000D979
		public bool IsFieldSelected
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsFieldSelectedProperty);
			}
			set
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_2"));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0000F78A File Offset: 0x0000D98A
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsFixed
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsFixedProperty);
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0000F79C File Offset: 0x0000D99C
		private static void OnIsSelectedChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = target as global::Infragistics.Windows.DataPresenter.CellPresenter;
			if (cellPresenter != null && cellPresenter.ReadLocalValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsSelectedProperty) == global::System.Windows.DependencyProperty.UnsetValue)
			{
				bool flag = (bool)e.NewValue;
				global::Infragistics.Windows.DataPresenter.CellPresenter.CoerceIsSelected(cellPresenter, global::Infragistics.KnownBoxes.FromValue(flag));
				if (cellPresenter.IsSelected != flag)
				{
					cellPresenter.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsSelectedProperty, global::Infragistics.KnownBoxes.FromValue(cellPresenter.IsSelected));
				}
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000F800 File Offset: 0x0000DA00
		private static object CoerceIsSelected(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = target as global::Infragistics.Windows.DataPresenter.CellPresenter;
			if (cellPresenter != null && cellPresenter.DataPresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = cellPresenter._dataRecord;
				global::Infragistics.Windows.DataPresenter.Field cachedField = cellPresenter._cachedField;
				if (!(bool)value)
				{
					if (dataRecord.IsCellAllocated(cachedField))
					{
						dataRecord.Cells[cachedField].IsSelected = false;
					}
				}
				else if (dataRecord != null && cachedField != null)
				{
					dataRecord.Cells[cachedField].IsSelected = true;
				}
				return global::Infragistics.KnownBoxes.FromValue(cellPresenter.IsSelected);
			}
			return global::Infragistics.KnownBoxes.FalseBox;
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0000F87C File Offset: 0x0000DA7C
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x0000F8CB File Offset: 0x0000DACB
		public bool IsSelected
		{
			get
			{
				return this._dataRecord != null && this._cachedField != null && this._dataRecord.IsCellAllocated(this._cachedField) && this._dataRecord.Cells[this._cachedField].IsSelected;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsSelectedProperty, value);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0000F8DE File Offset: 0x0000DADE
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsUnbound
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsUnboundProperty);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0000F8F0 File Offset: 0x0000DAF0
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._dataRecord;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0000F8F8 File Offset: 0x0000DAF8
		public global::Infragistics.Windows.Controls.SortStatus SortStatus
		{
			get
			{
				return (global::Infragistics.Windows.Controls.SortStatus)base.GetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.SortStatusProperty);
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000F90A File Offset: 0x0000DB0A
		private static void OnValueChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0000F917 File Offset: 0x0000DB17
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x0000F93D File Offset: 0x0000DB3D
		public virtual object Value
		{
			get
			{
				if (this._cachedField == null || this._dataRecord == null)
				{
					return null;
				}
				return this._dataRecord.GetCellValue(this._cachedField, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
			}
			set
			{
				if (this._cachedField == null || this._dataRecord == null)
				{
					return;
				}
				this._dataRecord.SetCellValue(this._cachedField, value, true);
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0000F964 File Offset: 0x0000DB64
		internal global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				if (this._cachedField == null || this._dataRecord == null)
				{
					return null;
				}
				return this._dataRecord.Cells[this._cachedField];
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0000F98E File Offset: 0x0000DB8E
		internal global::Infragistics.Windows.DataPresenter.CellValuePresenter CellValuePresenter
		{
			get
			{
				if (this._layoutElement == null)
				{
					return null;
				}
				return this._layoutElement.CellValuePresenter;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0000F9A5 File Offset: 0x0000DBA5
		internal global::Infragistics.Windows.DataPresenter.LabelPresenter LabelPresenter
		{
			get
			{
				if (this._layoutElement == null)
				{
					return null;
				}
				return this._layoutElement.LabelPresenter;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0000F9BC File Offset: 0x0000DBBC
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x0000F9CE File Offset: 0x0000DBCE
		private global::Infragistics.Windows.Controls.SortStatus SortStatusInternal
		{
			get
			{
				return (global::Infragistics.Windows.Controls.SortStatus)base.GetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.SortStatusInternalProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.SortStatusInternalProperty, value);
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0000F9E1 File Offset: 0x0000DBE1
		internal void OnRecordResized()
		{
			this.InvalidateMeasureWithChildren();
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000F9EC File Offset: 0x0000DBEC
		private void InitializeRecord()
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = base.DataContext as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord == this._dataRecord)
			{
				return;
			}
			if (this._dataRecord != null)
			{
				this.UnhookAndClearRecord();
			}
			this._dataRecord = dataRecord;
			if (this._dataRecord == null)
			{
				return;
			}
			global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._dataRecord, this, string.Empty);
			base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.RecordPropertyKey, this._dataRecord);
			if (this._cachedField != null)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.ValueProperty, this.Value);
			}
			if (this._dataRecord.FieldLayout.IsEmptyCellCollapsingSupportedByView)
			{
				base.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
			}
			this.InvalidateStyleSelector();
			base.InvalidateLayoutElement();
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0000FA94 File Offset: 0x0000DC94
		private void InvalidateMeasureWithChildren()
		{
			base.InvalidateMeasure();
			if (this._layoutElement != null)
			{
				this._layoutElement.InvalidateMeasure();
				if (this._layoutElement.CellValuePresenter != null)
				{
					this._layoutElement.CellValuePresenter.InvalidateMeasure();
				}
				if (this._layoutElement.LabelPresenter != null)
				{
					this._layoutElement.LabelPresenter.InvalidateMeasure();
				}
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0000FAF4 File Offset: 0x0000DCF4
		protected void InvalidateStyleSelector()
		{
			if (this._styleSelectorHelper != null && this._cachedField != null && this._dataRecord != null)
			{
				this._styleSelectorHelper.InvalidateStyle();
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0000FB1C File Offset: 0x0000DD1C
		private void OnRecordPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			if (this._dataRecord != null && (propertyName = e.PropertyName) != null)
			{
				if (propertyName == "ActiveCell")
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsActiveProperty, global::Infragistics.KnownBoxes.FromValue(this.IsActive));
					return;
				}
				if (propertyName == "CellSelection")
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsSelectedProperty, global::Infragistics.KnownBoxes.FromValue(this.IsSelected));
					return;
				}
				if (!(propertyName == "ShouldCollapseEmptyCells"))
				{
					return;
				}
				base.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		private void UnhookAndClearRecord()
		{
			if (this._dataRecord != null)
			{
				global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._dataRecord, this, string.Empty);
				this._dataRecord = null;
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0000FBC0 File Offset: 0x0000DDC0
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager))
			{
				global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = e as global::System.ComponentModel.PropertyChangedEventArgs;
				if (propertyChangedEventArgs != null)
				{
					this.OnRecordPropertyChanged(propertyChangedEventArgs);
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000111 RID: 273
		private global::Infragistics.Windows.DataPresenter.CellPresenter.CellPresenterStyleSelectorHelper _styleSelectorHelper;

		// Token: 0x04000112 RID: 274
		private global::Infragistics.Windows.DataPresenter.DataRecord _dataRecord;

		// Token: 0x04000113 RID: 275
		private global::Infragistics.Windows.DataPresenter.Field _cachedField;

		// Token: 0x04000114 RID: 276
		private bool _isDragIndicator;

		// Token: 0x04000115 RID: 277
		private global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElement _layoutElement;

		// Token: 0x04000116 RID: 278
		private bool _recordOrFieldHasChangedSinceLastMeasure;

		// Token: 0x04000117 RID: 279
		private static readonly global::System.Windows.DependencyPropertyKey ContentLocationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ContentLocation", typeof(global::Infragistics.Windows.Controls.RelativeContentLocation), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.RelativeContentLocation.AboveContentLeft));

		// Token: 0x04000118 RID: 280
		public static readonly global::System.Windows.DependencyProperty ContentLocationProperty = global::Infragistics.Windows.DataPresenter.CellPresenter.ContentLocationPropertyKey.DependencyProperty;

		// Token: 0x04000119 RID: 281
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellPresenter.OnFieldChanged)));

		// Token: 0x0400011A RID: 282
		public static readonly global::System.Windows.DependencyProperty HasSeparateHeaderProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.HasSeparateHeaderProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400011B RID: 283
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty = global::System.Windows.DependencyProperty.Register("IsActive", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellPresenter.OnIsActiveChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CellPresenter.CoerceIsActive)));

		// Token: 0x0400011C RID: 284
		public static readonly global::System.Windows.DependencyProperty IsAlternateProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternatePropertyKey.DependencyProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter));

		// Token: 0x0400011D RID: 285
		public static readonly global::System.Windows.DependencyProperty IsDragIndicatorProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsDragIndicatorProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellPresenter.OnIsDragIndicatorChanged)));

		// Token: 0x0400011E RID: 286
		public static readonly global::System.Windows.DependencyProperty IsFieldSelectedProperty = global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsFieldSelectedProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400011F RID: 287
		private static readonly global::System.Windows.DependencyPropertyKey IsFixedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFixed", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000120 RID: 288
		public static readonly global::System.Windows.DependencyProperty IsFixedProperty = global::Infragistics.Windows.DataPresenter.CellPresenter.IsFixedPropertyKey.DependencyProperty;

		// Token: 0x04000121 RID: 289
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::System.Windows.DependencyProperty.Register("IsSelected", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellPresenter.OnIsSelectedChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CellPresenter.CoerceIsSelected)));

		// Token: 0x04000122 RID: 290
		private static readonly global::System.Windows.DependencyPropertyKey IsUnboundPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsUnbound", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000123 RID: 291
		public static readonly global::System.Windows.DependencyProperty IsUnboundProperty = global::Infragistics.Windows.DataPresenter.CellPresenter.IsUnboundPropertyKey.DependencyProperty;

		// Token: 0x04000124 RID: 292
		private static readonly global::System.Windows.DependencyPropertyKey RecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Record", typeof(global::Infragistics.Windows.DataPresenter.DataRecord), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000125 RID: 293
		public static readonly global::System.Windows.DependencyProperty RecordProperty = global::Infragistics.Windows.DataPresenter.CellPresenter.RecordPropertyKey.DependencyProperty;

		// Token: 0x04000126 RID: 294
		private static readonly global::System.Windows.DependencyPropertyKey SortStatusPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SortStatus", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted));

		// Token: 0x04000127 RID: 295
		public static readonly global::System.Windows.DependencyProperty SortStatusProperty = global::Infragistics.Windows.DataPresenter.CellPresenter.SortStatusPropertyKey.DependencyProperty;

		// Token: 0x04000128 RID: 296
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellPresenter.OnValueChanged)));

		// Token: 0x04000129 RID: 297
		private static readonly global::System.Windows.DependencyProperty IsFixedInternalProperty = global::System.Windows.DependencyProperty.Register("IsFixedInternal", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400012A RID: 298
		private static readonly global::System.Windows.DependencyProperty SortStatusInternalProperty = global::System.Windows.DependencyProperty.Register("SortStatusInternal", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted));

		// Token: 0x02000057 RID: 87
		private class CellPresenterStyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x0600047F RID: 1151 RVA: 0x0000FBF3 File Offset: 0x0000DDF3
			internal CellPresenterStyleSelectorHelper(global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter) : base(cellPresenter)
			{
				this._cellPresenter = cellPresenter;
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x06000480 RID: 1152 RVA: 0x0000FC04 File Offset: 0x0000DE04
			public override global::System.Windows.Style Style
			{
				get
				{
					if (this._cellPresenter == null)
					{
						return null;
					}
					global::Infragistics.Windows.DataPresenter.Field cachedField = this._cellPresenter._cachedField;
					if (cachedField == null)
					{
						return null;
					}
					global::Infragistics.Windows.DataPresenter.FieldLayout owner = cachedField.Owner;
					if (owner == null)
					{
						return null;
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
					if (dataPresenter == null)
					{
						return null;
					}
					return dataPresenter.InternalCellPresenterStyleSelector.SelectStyle(this._cellPresenter.Value, this._cellPresenter);
				}
			}

			// Token: 0x0400012B RID: 299
			private global::Infragistics.Windows.DataPresenter.CellPresenter _cellPresenter;
		}
	}
}
