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
	// Token: 0x02000061 RID: 97
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	public abstract class DataItemPresenter : global::Infragistics.Windows.Editors.ValuePresenter, global::Infragistics.Windows.Resizing.IResizableElement, global::System.Windows.IWeakEventListener
	{
		// Token: 0x06000529 RID: 1321 RVA: 0x00012808 File Offset: 0x00010A08
		static DataItemPresenter()
		{
			global::System.Windows.UIElement.ClipProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.CoerceCellClip)));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataItemPresenter.OnVisualStatePropertyChanged)));
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000129F7 File Offset: 0x00010BF7
		protected DataItemPresenter()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.DataPresenter.DataItemPresenter.CellStyleSelectorHelper(this);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00012A0C File Offset: 0x00010C0C
		protected override global::System.Windows.Media.HitTestResult HitTestCore(global::System.Windows.Media.PointHitTestParameters hitTestParameters)
		{
			global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
			if (rect.Contains(hitTestParameters.HitPoint))
			{
				return new global::System.Windows.Media.PointHitTestResult(this, hitTestParameters.HitPoint);
			}
			return base.HitTestCore(hitTestParameters);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00012A54 File Offset: 0x00010C54
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

		// Token: 0x0600052D RID: 1325 RVA: 0x00012AA1 File Offset: 0x00010CA1
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00012ABC File Offset: 0x00010CBC
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00012ACB File Offset: 0x00010CCB
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00012ADC File Offset: 0x00010CDC
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

		// Token: 0x06000531 RID: 1329 RVA: 0x00012B18 File Offset: 0x00010D18
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
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternatePropertyKey, global::Infragistics.KnownBoxes.FromValue(this.GetIsAlternate()));
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
							if (this._cachedField.BindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding)
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

		// Token: 0x06000532 RID: 1330 RVA: 0x00012CC7 File Offset: 0x00010EC7
		protected internal override bool OnValueEditorKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			return false;
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00012CCC File Offset: 0x00010ECC
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

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00012CF0 File Offset: 0x00010EF0
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00012CF8 File Offset: 0x00010EF8
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

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00012D06 File Offset: 0x00010F06
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00012D18 File Offset: 0x00010F18
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

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00012D2B File Offset: 0x00010F2B
		public bool HighlightAsPrimary
		{
			get
			{
				return this._cachedField != null && this._cachedField.IsPrimary && this._cachedField.Owner.HighlightPrimaryFieldResolved;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00012D56 File Offset: 0x00010F56
		public bool IsAlternate
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsAlternateProperty);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00012D68 File Offset: 0x00010F68
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x00012D7A File Offset: 0x00010F7A
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

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00012D8D File Offset: 0x00010F8D
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsFixed
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsFixedProperty);
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00012D9F File Offset: 0x00010F9F
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsUnbound
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsUnboundProperty);
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00012DB1 File Offset: 0x00010FB1
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._dataRecord;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00012DB9 File Offset: 0x00010FB9
		internal bool IsFieldValid
		{
			get
			{
				return this._cachedField != null && this._cachedField.IsValid;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x00012DD0 File Offset: 0x00010FD0
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

		// Token: 0x06000541 RID: 1345 RVA: 0x00012E44 File Offset: 0x00011044
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

		// Token: 0x06000542 RID: 1346 RVA: 0x00012E9C File Offset: 0x0001109C
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataItemPresenter dataItemPresenter = target as global::Infragistics.Windows.DataPresenter.DataItemPresenter;
			if (dataItemPresenter != null)
			{
				dataItemPresenter.UpdateVisualStates();
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00012EB9 File Offset: 0x000110B9
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00012EC2 File Offset: 0x000110C2
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

		// Token: 0x06000545 RID: 1349 RVA: 0x00012EDF File Offset: 0x000110DF
		protected void InvalidateStyleSelector()
		{
			if (this.Field != null && this._styleSelectorHelper != null)
			{
				this._styleSelectorHelper.InvalidateStyle();
				this.OnStyleSelectorInvalidated();
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00012F02 File Offset: 0x00011102
		internal virtual void OnStyleSelectorInvalidated()
		{
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00012F04 File Offset: 0x00011104
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

		// Token: 0x06000548 RID: 1352 RVA: 0x00012F69 File Offset: 0x00011169
		protected virtual void OnRecordPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00012F6C File Offset: 0x0001116C
		private bool GetIsAlternate()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (this._cachedField != null) ? this._cachedField.Owner : ((this._dataRecord != null) ? this._dataRecord.FieldLayout : null);
			if (fieldLayout != null && fieldLayout.HighlightAlternateRecordsResolved)
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true, this) as global::Infragistics.Windows.DataPresenter.RecordPresenter;
				if (recordPresenter != null)
				{
					recordPresenter.InitializeIsAlternate(false);
					return recordPresenter.IsAlternate;
				}
			}
			return false;
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00012FDA File Offset: 0x000111DA
		object global::Infragistics.Windows.Resizing.IResizableElement.ResizeContext
		{
			get
			{
				return this._cachedField;
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00012FE4 File Offset: 0x000111E4
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

		// Token: 0x0400016D RID: 365
		private global::Infragistics.Windows.DataPresenter.DataItemPresenter.CellStyleSelectorHelper _styleSelectorHelper;

		// Token: 0x0400016E RID: 366
		private global::Infragistics.Windows.DataPresenter.DataRecord _dataRecord;

		// Token: 0x0400016F RID: 367
		private bool _hasVisualStateGroups;

		// Token: 0x04000170 RID: 368
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::System.Windows.DependencyProperty.Register("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000171 RID: 369
		private global::Infragistics.Windows.DataPresenter.Field _cachedField;

		// Token: 0x04000172 RID: 370
		public static readonly global::System.Windows.DependencyProperty HasSeparateHeaderProperty = global::System.Windows.DependencyProperty.Register("HasSeparateHeader", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000173 RID: 371
		private static readonly global::System.Windows.DependencyPropertyKey HighlightAsPrimaryPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HighlightAsPrimary", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000174 RID: 372
		public static readonly global::System.Windows.DependencyProperty HighlightAsPrimaryProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.HighlightAsPrimaryPropertyKey.DependencyProperty;

		// Token: 0x04000175 RID: 373
		public static readonly global::System.Windows.DependencyProperty IsAlternateProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternatePropertyKey.DependencyProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter));

		// Token: 0x04000176 RID: 374
		public static readonly global::System.Windows.DependencyProperty IsDragIndicatorProperty = global::System.Windows.DependencyProperty.Register("IsDragIndicator", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataItemPresenter.OnVisualStatePropertyChanged)));

		// Token: 0x04000177 RID: 375
		private static readonly global::System.Windows.DependencyPropertyKey IsFixedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFixed", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000178 RID: 376
		public static readonly global::System.Windows.DependencyProperty IsFixedProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsFixedPropertyKey.DependencyProperty;

		// Token: 0x04000179 RID: 377
		private static readonly global::System.Windows.DependencyPropertyKey IsUnboundPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsUnbound", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400017A RID: 378
		public static readonly global::System.Windows.DependencyProperty IsUnboundProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.IsUnboundPropertyKey.DependencyProperty;

		// Token: 0x0400017B RID: 379
		private static readonly global::System.Windows.DependencyPropertyKey RecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Record", typeof(global::Infragistics.Windows.DataPresenter.DataRecord), typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0400017C RID: 380
		public static readonly global::System.Windows.DependencyProperty RecordProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.RecordPropertyKey.DependencyProperty;

		// Token: 0x02000062 RID: 98
		private class CellStyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x0600054C RID: 1356 RVA: 0x00013034 File Offset: 0x00011234
			internal CellStyleSelectorHelper(global::Infragistics.Windows.DataPresenter.DataItemPresenter cellBase) : base(cellBase)
			{
				this._cellBase = cellBase;
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x0600054D RID: 1357 RVA: 0x00013044 File Offset: 0x00011244
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

			// Token: 0x0400017D RID: 381
			private global::Infragistics.Windows.DataPresenter.DataItemPresenter _cellBase;
		}
	}
}
