using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Resizing;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200005D RID: 93
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	public abstract class DataItemPresenter : global::Infragistics.Windows.Editors.ValuePresenter, global::Infragistics.Windows.Resizing.IResizableElement, global::System.Windows.IWeakEventListener
	{
		// Token: 0x060004CA RID: 1226 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		static DataItemPresenter()
		{
			global::System.Windows.UIElement.ClipProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.CoerceCellClip)));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataItemPresenter.OnVisualStatePropertyChanged)));
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0001119F File Offset: 0x0000F39F
		protected DataItemPresenter()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.DataPresenter.DataItemPresenter.CellStyleSelectorHelper(this);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000111B4 File Offset: 0x0000F3B4
		protected override global::System.Windows.Media.HitTestResult HitTestCore(global::System.Windows.Media.PointHitTestParameters hitTestParameters)
		{
			global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
			if (rect.Contains(hitTestParameters.HitPoint))
			{
				return new global::System.Windows.Media.PointHitTestResult(this, hitTestParameters.HitPoint);
			}
			return base.HitTestCore(hitTestParameters);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000111FC File Offset: 0x0000F3FC
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (this.Field == null)
			{
				global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), false, null, typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter)) as global::Infragistics.Windows.DataPresenter.CellPresenter;
				if (cellPresenter != null)
				{
					this.Field = cellPresenter.Field;
				}
			}
			return base.MeasureOverride(availableSize);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00011249 File Offset: 0x0000F449
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00011264 File Offset: 0x0000F464
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00011273 File Offset: 0x0000F473
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00011284 File Offset: 0x0000F484
		protected internal override bool ShouldSuppressEvent(global::System.Windows.RoutedEventArgs args)
		{
			if (this._dataRecord != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._dataRecord.DataPresenter;
				if (dataPresenter != null && dataPresenter.IsEventSuppressed(args.RoutedEvent))
				{
					return true;
				}
			}
			return base.ShouldSuppressEvent(args);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000112C0 File Offset: 0x0000F4C0
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (property == global::System.Windows.FrameworkElement.DataContextProperty)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = base.DataContext as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord == null)
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.RecordPropertyKey);
					base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternatePropertyKey);
					return;
				}
				this._dataRecord = dataRecord;
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.RecordPropertyKey, this.Record);
				if (this.IsWithinRecord)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternatePropertyKey, global::Infragistics.KnownBoxes.FromValue(this.IsAlternate));
					return;
				}
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternatePropertyKey);
				return;
			}
			else
			{
				if (property != global::System.Windows.FrameworkElement.StyleProperty)
				{
					if (property == global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty)
					{
						if (this._cachedField != null)
						{
							global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._cachedField, this, string.Empty);
						}
						this._cachedField = (e.NewValue as global::Infragistics.Windows.DataPresenter.Field);
						if (this._cachedField != null)
						{
							if (this._cachedField.IsUnbound)
							{
								base.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsUnboundPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
							}
							global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._cachedField.Owner;
							if (owner != null)
							{
								base.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.HasSeparateHeaderProperty, global::Infragistics.KnownBoxes.FromValue(owner.HasSeparateHeader));
							}
							global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._cachedField, this, string.Empty);
						}
						if (this.IsWithinRecord)
						{
							base.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.HighlightAsPrimaryPropertyKey, global::Infragistics.KnownBoxes.FromValue(this.HighlightAsPrimary));
						}
						else
						{
							base.ClearValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.HighlightAsPrimaryPropertyKey);
						}
						base.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsFixedPropertyKey, (this._cachedField != null && this._cachedField.IsFixed) ? global::Infragistics.KnownBoxes.TrueBox : global::System.Windows.DependencyProperty.UnsetValue);
						this.UpdateVisualStates(false);
					}
					return;
				}
				if (this.IsWithinRecord)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.HighlightAsPrimaryPropertyKey, global::Infragistics.KnownBoxes.FromValue(this.HighlightAsPrimary));
					return;
				}
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternatePropertyKey);
				return;
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0001146F File Offset: 0x0000F66F
		protected internal override bool OnValueEditorKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			return false;
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00011474 File Offset: 0x0000F674
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Field field = this.Field;
				if (field != null)
				{
					return field.Owner.DataPresenter;
				}
				return null;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00011498 File Offset: 0x0000F698
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x000114A0 File Offset: 0x0000F6A0
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._cachedField;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty, value);
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x000114AE File Offset: 0x0000F6AE
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x000114C0 File Offset: 0x0000F6C0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasSeparateHeader
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.HasSeparateHeaderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.HasSeparateHeaderProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x000114D3 File Offset: 0x0000F6D3
		public bool HighlightAsPrimary
		{
			get
			{
				return this._cachedField != null && this._cachedField.IsPrimary && this._cachedField.Owner.HighlightPrimaryFieldResolved;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00011500 File Offset: 0x0000F700
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

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0001154F File Offset: 0x0000F74F
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00011561 File Offset: 0x0000F761
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsDragIndicator
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsDragIndicatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsDragIndicatorProperty, value);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00011574 File Offset: 0x0000F774
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsFixed
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsFixedProperty);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00011586 File Offset: 0x0000F786
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsUnbound
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsUnboundProperty);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00011598 File Offset: 0x0000F798
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._dataRecord;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x000115A0 File Offset: 0x0000F7A0
		internal bool IsWithinRecord
		{
			get
			{
				global::System.Windows.DependencyObject templatedParent = base.TemplatedParent;
				if (templatedParent != null)
				{
					while (!(templatedParent is global::Infragistics.Windows.DataPresenter.DataRecordCellArea) && !(templatedParent is global::Infragistics.Windows.DataPresenter.HeaderLabelArea) && !(templatedParent is global::Infragistics.Windows.DataPresenter.DataRecordPresenter) && !(templatedParent is global::Infragistics.Windows.DataPresenter.HeaderPresenter))
					{
						if (templatedParent is global::System.Windows.FrameworkElement)
						{
							templatedParent = ((global::System.Windows.FrameworkElement)templatedParent).TemplatedParent;
							if (templatedParent != null)
							{
								continue;
							}
						}
						return false;
					}
					return true;
				}
				global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(this);
				return parent == null || parent is global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel || parent is global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase;
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00011614 File Offset: 0x0000F814
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (!base.IsEnabled)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Disabled", useTransitions);
				return;
			}
			if (base.IsMouseOver)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"MouseOver",
					"Normal"
				});
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Normal", useTransitions);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0001166C File Offset: 0x0000F86C
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataItemPresenter dataItemPresenter = target as global::Infragistics.Windows.DataPresenter.DataItemPresenter;
			if (dataItemPresenter != null)
			{
				dataItemPresenter.UpdateVisualStates();
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00011689 File Offset: 0x0000F889
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00011692 File Offset: 0x0000F892
		protected void UpdateVisualStates(bool useTransitions)
		{
			if (!this._hasVisualStateGroups)
			{
				return;
			}
			if (!base.IsLoaded)
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000116AF File Offset: 0x0000F8AF
		protected void InvalidateStyleSelector()
		{
			if (this.Field != null && this._styleSelectorHelper != null)
			{
				this._styleSelectorHelper.InvalidateStyle();
				this.OnStyleSelectorInvalidated();
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000116D2 File Offset: 0x0000F8D2
		internal virtual void OnStyleSelectorInvalidated()
		{
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000116D4 File Offset: 0x0000F8D4
		protected virtual void OnFieldPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (propertyName == "IsFixed")
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsFixedPropertyKey, (this._cachedField == null || !this._cachedField.IsFixed) ? global::System.Windows.DependencyProperty.UnsetValue : global::Infragistics.KnownBoxes.TrueBox);
					return;
				}
				if (!(propertyName == "IsSelected"))
				{
					return;
				}
				this.UpdateVisualStates();
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00011739 File Offset: 0x0000F939
		protected virtual void OnRecordPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0001173B File Offset: 0x0000F93B
		object global::Infragistics.Windows.Resizing.IResizableElement.ResizeContext
		{
			get
			{
				return this._cachedField;
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00011744 File Offset: 0x0000F944
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager))
			{
				global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = e as global::System.ComponentModel.PropertyChangedEventArgs;
				if (propertyChangedEventArgs != null)
				{
					if (sender is global::Infragistics.Windows.DataPresenter.Field)
					{
						this.OnFieldPropertyChanged(propertyChangedEventArgs);
					}
					else
					{
						if (!(sender is global::Infragistics.Windows.DataPresenter.Record))
						{
							return false;
						}
						this.OnRecordPropertyChanged(propertyChangedEventArgs);
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000142 RID: 322
		private global::Infragistics.Windows.DataPresenter.DataItemPresenter.CellStyleSelectorHelper _styleSelectorHelper;

		// Token: 0x04000143 RID: 323
		private global::Infragistics.Windows.DataPresenter.DataRecord _dataRecord;

		// Token: 0x04000144 RID: 324
		private bool _hasVisualStateGroups;

		// Token: 0x04000145 RID: 325
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::System.Windows.DependencyProperty.Register("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000146 RID: 326
		private global::Infragistics.Windows.DataPresenter.Field _cachedField;

		// Token: 0x04000147 RID: 327
		public static readonly global::System.Windows.DependencyProperty HasSeparateHeaderProperty = global::System.Windows.DependencyProperty.Register("HasSeparateHeader", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000148 RID: 328
		private static readonly global::System.Windows.DependencyPropertyKey HighlightAsPrimaryPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HighlightAsPrimary", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000149 RID: 329
		public static readonly global::System.Windows.DependencyProperty HighlightAsPrimaryProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.HighlightAsPrimaryPropertyKey.DependencyProperty;

		// Token: 0x0400014A RID: 330
		public static readonly global::System.Windows.DependencyProperty IsAlternateProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternatePropertyKey.DependencyProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter));

		// Token: 0x0400014B RID: 331
		public static readonly global::System.Windows.DependencyProperty IsDragIndicatorProperty = global::System.Windows.DependencyProperty.Register("IsDragIndicator", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataItemPresenter.OnVisualStatePropertyChanged)));

		// Token: 0x0400014C RID: 332
		private static readonly global::System.Windows.DependencyPropertyKey IsFixedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFixed", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400014D RID: 333
		public static readonly global::System.Windows.DependencyProperty IsFixedProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsFixedPropertyKey.DependencyProperty;

		// Token: 0x0400014E RID: 334
		private static readonly global::System.Windows.DependencyPropertyKey IsUnboundPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsUnbound", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400014F RID: 335
		public static readonly global::System.Windows.DependencyProperty IsUnboundProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsUnboundPropertyKey.DependencyProperty;

		// Token: 0x04000150 RID: 336
		private static readonly global::System.Windows.DependencyPropertyKey RecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Record", typeof(global::Infragistics.Windows.DataPresenter.DataRecord), typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000151 RID: 337
		public static readonly global::System.Windows.DependencyProperty RecordProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.RecordPropertyKey.DependencyProperty;

		// Token: 0x0200005E RID: 94
		private class CellStyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x060004EB RID: 1259 RVA: 0x00011794 File Offset: 0x0000F994
			internal CellStyleSelectorHelper(global::Infragistics.Windows.DataPresenter.DataItemPresenter cellBase) : base(cellBase)
			{
				this._cellBase = cellBase;
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x060004EC RID: 1260 RVA: 0x000117A4 File Offset: 0x0000F9A4
			public override global::System.Windows.Style Style
			{
				get
				{
					if (this._cellBase == null)
					{
						return null;
					}
					global::Infragistics.Windows.DataPresenter.Field field = this._cellBase.Field;
					if (field == null)
					{
						return null;
					}
					global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
					if (owner == null)
					{
						return null;
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
					if (dataPresenter == null)
					{
						return null;
					}
					if (this._cellBase is global::Infragistics.Windows.DataPresenter.LabelPresenter)
					{
						return dataPresenter.InternalLabelPresenterStyleSelector.SelectStyle(this._cellBase.Content, this._cellBase);
					}
					if (this._cellBase is global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter)
					{
						return dataPresenter.InternalExpandedCellStyleSelector.SelectStyle(((global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter)this._cellBase).Value, this._cellBase);
					}
					if (this._cellBase is global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter)
					{
						return field.FilterCellValuePresenterStyleResolved;
					}
					return dataPresenter.InternalCellValuePresenterStyleSelector.SelectStyle(this._cellBase.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueProperty), this._cellBase);
				}
			}

			// Token: 0x04000152 RID: 338
			private global::Infragistics.Windows.DataPresenter.DataItemPresenter _cellBase;
		}
	}
}
