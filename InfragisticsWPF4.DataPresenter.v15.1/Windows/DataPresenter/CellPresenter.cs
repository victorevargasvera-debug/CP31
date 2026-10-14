using System;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Data;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200005A RID: 90
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CellPresenter : global::Infragistics.Windows.DataPresenter.CellPresenterBase, global::System.Windows.IWeakEventListener
	{
		// Token: 0x060004B0 RID: 1200 RVA: 0x00010658 File Offset: 0x0000E858
		static CellPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000109A7 File Offset: 0x0000EBA7
		public CellPresenter()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.DataPresenter.CellPresenter.CellPresenterStyleSelectorHelper(this);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000109BC File Offset: 0x0000EBBC
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

		// Token: 0x060004B3 RID: 1203 RVA: 0x00010A5C File Offset: 0x0000EC5C
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

		// Token: 0x060004B4 RID: 1204 RVA: 0x00010C24 File Offset: 0x0000EE24
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

		// Token: 0x060004B5 RID: 1205 RVA: 0x00010CAC File Offset: 0x0000EEAC
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

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00010D11 File Offset: 0x0000EF11
		public global::Infragistics.Windows.Controls.RelativeContentLocation ContentLocation
		{
			get
			{
				return (global::Infragistics.Windows.Controls.RelativeContentLocation)base.GetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.ContentLocationProperty);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00010D23 File Offset: 0x0000EF23
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

		// Token: 0x060004B8 RID: 1208 RVA: 0x00010D40 File Offset: 0x0000EF40
		private static void OnFieldChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = (global::Infragistics.Windows.DataPresenter.CellPresenter)dependencyObject;
			global::Infragistics.Windows.DataPresenter.Field cachedField = (global::Infragistics.Windows.DataPresenter.Field)e.NewValue;
			cellPresenter._cachedField = cachedField;
			cellPresenter.InvalidateLayoutElement();
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00010D6E File Offset: 0x0000EF6E
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00010D76 File Offset: 0x0000EF76
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

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00010D84 File Offset: 0x0000EF84
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00010D96 File Offset: 0x0000EF96
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x060004BD RID: 1213 RVA: 0x00010DAC File Offset: 0x0000EFAC
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

		// Token: 0x060004BE RID: 1214 RVA: 0x00010E10 File Offset: 0x0000F010
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

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00010EA4 File Offset: 0x0000F0A4
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00010EF1 File Offset: 0x0000F0F1
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

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00010F04 File Offset: 0x0000F104
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

		// Token: 0x060004C2 RID: 1218 RVA: 0x00010F54 File Offset: 0x0000F154
		private static void OnIsDragIndicatorChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = target as global::Infragistics.Windows.DataPresenter.CellPresenter;
			cellPresenter._isDragIndicator = (bool)e.NewValue;
			cellPresenter.SynchronizeChildElements();
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00010F80 File Offset: 0x0000F180
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00010F88 File Offset: 0x0000F188
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

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00010F9B File Offset: 0x0000F19B
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00010FAD File Offset: 0x0000F1AD
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

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00010FBE File Offset: 0x0000F1BE
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsFixed
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsFixedProperty);
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00010FD0 File Offset: 0x0000F1D0
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

		// Token: 0x060004C9 RID: 1225 RVA: 0x00011034 File Offset: 0x0000F234
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

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x000110B0 File Offset: 0x0000F2B0
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x000110FF File Offset: 0x0000F2FF
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

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00011112 File Offset: 0x0000F312
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsUnbound
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.IsUnboundProperty);
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00011124 File Offset: 0x0000F324
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._dataRecord;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x0001112C File Offset: 0x0000F32C
		public global::Infragistics.Windows.Controls.SortStatus SortStatus
		{
			get
			{
				return (global::Infragistics.Windows.Controls.SortStatus)base.GetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.SortStatusProperty);
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0001113E File Offset: 0x0000F33E
		private static void OnValueChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0001114B File Offset: 0x0000F34B
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00011171 File Offset: 0x0000F371
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

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00011198 File Offset: 0x0000F398
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

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x000111C2 File Offset: 0x0000F3C2
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

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x000111D9 File Offset: 0x0000F3D9
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

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x000111F0 File Offset: 0x0000F3F0
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00011202 File Offset: 0x0000F402
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

		// Token: 0x060004D7 RID: 1239 RVA: 0x00011215 File Offset: 0x0000F415
		internal void OnRecordResized()
		{
			this.InvalidateMeasureWithChildren();
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00011220 File Offset: 0x0000F420
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

		// Token: 0x060004D9 RID: 1241 RVA: 0x000112C8 File Offset: 0x0000F4C8
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

		// Token: 0x060004DA RID: 1242 RVA: 0x00011328 File Offset: 0x0000F528
		protected void InvalidateStyleSelector()
		{
			if (this._styleSelectorHelper != null && this._cachedField != null && this._dataRecord != null)
			{
				this._styleSelectorHelper.InvalidateStyle();
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00011350 File Offset: 0x0000F550
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

		// Token: 0x060004DC RID: 1244 RVA: 0x000113D0 File Offset: 0x0000F5D0
		private void UnhookAndClearRecord()
		{
			if (this._dataRecord != null)
			{
				global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._dataRecord, this, string.Empty);
				this._dataRecord = null;
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x000113F4 File Offset: 0x0000F5F4
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

		// Token: 0x0400013C RID: 316
		private global::Infragistics.Windows.DataPresenter.CellPresenter.CellPresenterStyleSelectorHelper _styleSelectorHelper;

		// Token: 0x0400013D RID: 317
		private global::Infragistics.Windows.DataPresenter.DataRecord _dataRecord;

		// Token: 0x0400013E RID: 318
		private global::Infragistics.Windows.DataPresenter.Field _cachedField;

		// Token: 0x0400013F RID: 319
		private bool _isDragIndicator;

		// Token: 0x04000140 RID: 320
		private global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElement _layoutElement;

		// Token: 0x04000141 RID: 321
		private bool _recordOrFieldHasChangedSinceLastMeasure;

		// Token: 0x04000142 RID: 322
		private static readonly global::System.Windows.DependencyPropertyKey ContentLocationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ContentLocation", typeof(global::Infragistics.Windows.Controls.RelativeContentLocation), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.RelativeContentLocation.AboveContentLeft));

		// Token: 0x04000143 RID: 323
		public static readonly global::System.Windows.DependencyProperty ContentLocationProperty = global::Infragistics.Windows.DataPresenter.CellPresenter.ContentLocationPropertyKey.DependencyProperty;

		// Token: 0x04000144 RID: 324
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellPresenter.OnFieldChanged)));

		// Token: 0x04000145 RID: 325
		public static readonly global::System.Windows.DependencyProperty HasSeparateHeaderProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.HasSeparateHeaderProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000146 RID: 326
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty = global::System.Windows.DependencyProperty.Register("IsActive", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellPresenter.OnIsActiveChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CellPresenter.CoerceIsActive)));

		// Token: 0x04000147 RID: 327
		public static readonly global::System.Windows.DependencyProperty IsAlternateProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternatePropertyKey.DependencyProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter));

		// Token: 0x04000148 RID: 328
		public static readonly global::System.Windows.DependencyProperty IsDragIndicatorProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsDragIndicatorProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellPresenter.OnIsDragIndicatorChanged)));

		// Token: 0x04000149 RID: 329
		public static readonly global::System.Windows.DependencyProperty IsFieldSelectedProperty = global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsFieldSelectedProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400014A RID: 330
		private static readonly global::System.Windows.DependencyPropertyKey IsFixedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFixed", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400014B RID: 331
		public static readonly global::System.Windows.DependencyProperty IsFixedProperty = global::Infragistics.Windows.DataPresenter.CellPresenter.IsFixedPropertyKey.DependencyProperty;

		// Token: 0x0400014C RID: 332
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::System.Windows.DependencyProperty.Register("IsSelected", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellPresenter.OnIsSelectedChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CellPresenter.CoerceIsSelected)));

		// Token: 0x0400014D RID: 333
		private static readonly global::System.Windows.DependencyPropertyKey IsUnboundPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsUnbound", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400014E RID: 334
		public static readonly global::System.Windows.DependencyProperty IsUnboundProperty = global::Infragistics.Windows.DataPresenter.CellPresenter.IsUnboundPropertyKey.DependencyProperty;

		// Token: 0x0400014F RID: 335
		private static readonly global::System.Windows.DependencyPropertyKey RecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Record", typeof(global::Infragistics.Windows.DataPresenter.DataRecord), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000150 RID: 336
		public static readonly global::System.Windows.DependencyProperty RecordProperty = global::Infragistics.Windows.DataPresenter.CellPresenter.RecordPropertyKey.DependencyProperty;

		// Token: 0x04000151 RID: 337
		private static readonly global::System.Windows.DependencyPropertyKey SortStatusPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SortStatus", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted));

		// Token: 0x04000152 RID: 338
		public static readonly global::System.Windows.DependencyProperty SortStatusProperty = global::Infragistics.Windows.DataPresenter.CellPresenter.SortStatusPropertyKey.DependencyProperty;

		// Token: 0x04000153 RID: 339
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellPresenter.OnValueChanged)));

		// Token: 0x04000154 RID: 340
		private static readonly global::System.Windows.DependencyProperty IsFixedInternalProperty = global::System.Windows.DependencyProperty.Register("IsFixedInternal", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000155 RID: 341
		private static readonly global::System.Windows.DependencyProperty SortStatusInternalProperty = global::System.Windows.DependencyProperty.Register("SortStatusInternal", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted));

		// Token: 0x0200005B RID: 91
		private class CellPresenterStyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x060004DE RID: 1246 RVA: 0x00011427 File Offset: 0x0000F627
			internal CellPresenterStyleSelectorHelper(global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter) : base(cellPresenter)
			{
				this._cellPresenter = cellPresenter;
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x060004DF RID: 1247 RVA: 0x00011438 File Offset: 0x0000F638
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

			// Token: 0x04000156 RID: 342
			private global::Infragistics.Windows.DataPresenter.CellPresenter _cellPresenter;
		}
	}
}
