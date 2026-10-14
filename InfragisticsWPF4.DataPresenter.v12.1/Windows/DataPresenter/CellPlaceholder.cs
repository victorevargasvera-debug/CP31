using System;
using System.Collections;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Infragistics.Collections;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200005B RID: 91
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public sealed class CellPlaceholder : global::System.Windows.FrameworkElement, global::System.Windows.IWeakEventListener
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x00010A73 File Offset: 0x0000EC73
		public CellPlaceholder()
		{
			global::System.Windows.NameScope.SetNameScope(this, new global::Infragistics.Windows.DataPresenter.CellPlaceholder.OwnerNameScope(this));
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00010A87 File Offset: 0x0000EC87
		internal CellPlaceholder(bool alwaysCreateElement) : this()
		{
			this._alwaysCreateElement = alwaysCreateElement;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00010A96 File Offset: 0x0000EC96
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this._isChildControlOwnedByThisPlaceholder && this._childCellElement != null)
			{
				this._childCellElement.Arrange(new global::System.Windows.Rect(finalSize));
			}
			return finalSize;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00010ABA File Offset: 0x0000ECBA
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index == 0 && this._isChildControlOwnedByThisPlaceholder)
			{
				return this._childCellElement;
			}
			throw new global::System.IndexOutOfRangeException();
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00010AD4 File Offset: 0x0000ECD4
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (this._childCellElement == null)
			{
				if (double.IsPositiveInfinity(availableSize.Width))
				{
					availableSize.Width = 0.0;
				}
				if (double.IsPositiveInfinity(availableSize.Height))
				{
					availableSize.Height = 0.0;
				}
				return availableSize;
			}
			global::System.Windows.Size desiredSize;
			try
			{
				global::Infragistics.Windows.DataPresenter.CellPlaceholder._measureCounter++;
				if (this._isChildControlOwnedByThisPlaceholder)
				{
					this._childCellElement.Measure(availableSize);
				}
				desiredSize = this._childCellElement.DesiredSize;
			}
			finally
			{
				global::Infragistics.Windows.DataPresenter.CellPlaceholder._measureCounter--;
			}
			return desiredSize;
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00010B74 File Offset: 0x0000ED74
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				if (this._isChildControlOwnedByThisPlaceholder)
				{
					return new global::Infragistics.Collections.SingleItemEnumerator(this._childCellElement);
				}
				return base.LogicalChildren;
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00010B90 File Offset: 0x0000ED90
		protected override void OnRenderSizeChanged(global::System.Windows.SizeChangedInfo sizeInfo)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (this.Field != null) ? this.Field.Owner : null;
			if (fieldLayout != null && this._isChildControlOwnedByThisPlaceholder)
			{
				fieldLayout.BumpLayoutItemVersionAsync();
			}
			base.OnRenderSizeChanged(sizeInfo);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00010BCC File Offset: 0x0000EDCC
		protected override void OnInitialized(global::System.EventArgs e)
		{
			this.VerifyCachedElement();
			base.OnInitialized(e);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00010BDC File Offset: 0x0000EDDC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("CellPlaceholder: ");
			if (this._cachedField != null)
			{
				stringBuilder.Append(this._cachedField.ToString());
				stringBuilder.Append(", ");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00010C27 File Offset: 0x0000EE27
		protected override int VisualChildrenCount
		{
			get
			{
				if (this._isChildControlOwnedByThisPlaceholder)
				{
					return 1;
				}
				return 0;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00010C34 File Offset: 0x0000EE34
		internal global::System.Windows.Controls.Control ChildCellElement
		{
			get
			{
				return this._childCellElement;
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00010C3C File Offset: 0x0000EE3C
		private static object OnCoerceField(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.CellPlaceholder cellPlaceholder = target as global::Infragistics.Windows.DataPresenter.CellPlaceholder;
			if (cellPlaceholder != null)
			{
				cellPlaceholder._cachedField = (value as global::Infragistics.Windows.DataPresenter.Field);
				return value;
			}
			return null;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00010C64 File Offset: 0x0000EE64
		private static void OnFieldChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CellPlaceholder cellPlaceholder = target as global::Infragistics.Windows.DataPresenter.CellPlaceholder;
			if (cellPlaceholder != null)
			{
				cellPlaceholder._cachedField = (e.NewValue as global::Infragistics.Windows.DataPresenter.Field);
				cellPlaceholder.VerifyCachedElement();
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00010C93 File Offset: 0x0000EE93
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00010C9B File Offset: 0x0000EE9B
		internal global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._cachedField;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellPlaceholder.FieldProperty, value);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00010CA9 File Offset: 0x0000EEA9
		internal static bool IsInMeasure
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellPlaceholder._measureCounter != 0;
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00010CB8 File Offset: 0x0000EEB8
		private void CreateCachedElement(bool cacheInTemplateRecord)
		{
			if (this._cachedField == null || this._isChildControlOwnedByThisPlaceholder)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._cachedField.Owner;
			if (owner == null)
			{
				return;
			}
			bool flag = (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellPlaceholder.IsLabelProperty);
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter rp = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), true) as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
			if (!owner.TemplateDataRecordCache.IsTemplateRecordPresenter(rp))
			{
				return;
			}
			this._isChildControlOwnedByThisPlaceholder = true;
			if (flag)
			{
				this._childCellElement = new global::Infragistics.Windows.DataPresenter.LabelPresenter();
			}
			else if (owner.UseCellPresenters)
			{
				this._childCellElement = new global::Infragistics.Windows.DataPresenter.CellPresenter();
			}
			else
			{
				this._childCellElement = new global::Infragistics.Windows.DataPresenter.CellValuePresenter();
			}
			base.AddLogicalChild(this._childCellElement);
			base.AddVisualChild(this._childCellElement);
			this._childCellElement.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty, this._cachedField);
			this.HookUnhookFieldProperties();
			if (cacheInTemplateRecord)
			{
				owner.TemplateDataRecordCache.CacheCellElement(this._cachedField, this._childCellElement, flag);
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00010DA4 File Offset: 0x0000EFA4
		internal void EnsureHasOwnControl()
		{
			this.VerifyCachedElement();
			if (this._cachedField == null || this._childCellElement == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Field fieldFromControl = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldFromControl(this._childCellElement);
			if (fieldFromControl == this._cachedField)
			{
				return;
			}
			this.CreateCachedElement(false);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		private void HookUnhookFieldProperties()
		{
			bool flag = this._cachedField != null && this._childCellElement is global::Infragistics.Windows.DataPresenter.CellPresenterBase && this._isChildControlOwnedByThisPlaceholder;
			if (flag == this._isHooked)
			{
				return;
			}
			this._isHooked = flag;
			if (flag)
			{
				global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._cachedField, this, "LabelWidthResolved");
				return;
			}
			global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._cachedField, this, "LabelWidthResolved");
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00010E4C File Offset: 0x0000F04C
		private void VerifyCachedElement()
		{
			if (base.IsInitialized && this._cachedField != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._cachedField.Owner;
				if (owner == null)
				{
					return;
				}
				bool label = (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellPlaceholder.IsLabelProperty);
				this._childCellElement = owner.TemplateDataRecordCache.GetCellElement(this._cachedField, label);
				if (this._childCellElement == null)
				{
					this.CreateCachedElement(true);
					return;
				}
				if (this._alwaysCreateElement)
				{
					this.CreateCachedElement(false);
				}
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00010EC4 File Offset: 0x0000F0C4
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager))
			{
				global::Infragistics.Windows.DataPresenter.CellPresenterBase cellPresenterBase = this._childCellElement as global::Infragistics.Windows.DataPresenter.CellPresenterBase;
				if (cellPresenterBase != null)
				{
					cellPresenterBase.InvalidateLayoutElement();
				}
				base.InvalidateMeasure();
				return true;
			}
			return false;
		}

		// Token: 0x04000139 RID: 313
		private global::Infragistics.Windows.DataPresenter.Field _cachedField;

		// Token: 0x0400013A RID: 314
		private global::System.Windows.Controls.Control _childCellElement;

		// Token: 0x0400013B RID: 315
		private bool _isChildControlOwnedByThisPlaceholder;

		// Token: 0x0400013C RID: 316
		private bool _isHooked;

		// Token: 0x0400013D RID: 317
		[global::System.ThreadStatic]
		private static int _measureCounter;

		// Token: 0x0400013E RID: 318
		private bool _alwaysCreateElement;

		// Token: 0x0400013F RID: 319
		internal static readonly global::System.Windows.DependencyProperty FieldProperty = global::System.Windows.DependencyProperty.Register("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.CellPlaceholder), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellPlaceholder.OnFieldChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CellPlaceholder.OnCoerceField)));

		// Token: 0x04000140 RID: 320
		internal static readonly global::System.Windows.DependencyProperty IsLabelProperty = global::System.Windows.DependencyProperty.Register("IsLabel", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellPlaceholder), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0200005C RID: 92
		private class OwnerNameScope : global::Infragistics.Windows.Helpers.NameScopeProxy
		{
			// Token: 0x060004C8 RID: 1224 RVA: 0x00010F7F File Offset: 0x0000F17F
			internal OwnerNameScope(global::Infragistics.Windows.DataPresenter.CellPlaceholder cp)
			{
				this._cp = cp;
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00010F8E File Offset: 0x0000F18E
			protected override global::System.Windows.DependencyObject StartingElement
			{
				get
				{
					if (this._cp.Field == null)
					{
						return null;
					}
					return this._cp.Field.DataPresenter;
				}
			}

			// Token: 0x04000141 RID: 321
			private global::Infragistics.Windows.DataPresenter.CellPlaceholder _cp;
		}
	}
}
