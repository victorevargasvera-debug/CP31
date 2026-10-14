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
	// Token: 0x0200005F RID: 95
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public sealed class CellPlaceholder : global::System.Windows.FrameworkElement, global::System.Windows.IWeakEventListener
	{
		// Token: 0x06000511 RID: 1297 RVA: 0x000122A7 File Offset: 0x000104A7
		public CellPlaceholder()
		{
			global::System.Windows.NameScope.SetNameScope(this, new global::Infragistics.Windows.DataPresenter.CellPlaceholder.OwnerNameScope(this));
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000122BB File Offset: 0x000104BB
		internal CellPlaceholder(bool alwaysCreateElement) : this()
		{
			this._alwaysCreateElement = alwaysCreateElement;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x000122CA File Offset: 0x000104CA
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this._isChildControlOwnedByThisPlaceholder && this._childCellElement != null)
			{
				this._childCellElement.Arrange(new global::System.Windows.Rect(finalSize));
			}
			return finalSize;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x000122EE File Offset: 0x000104EE
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index == 0 && this._isChildControlOwnedByThisPlaceholder)
			{
				return this._childCellElement;
			}
			throw new global::System.IndexOutOfRangeException();
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00012308 File Offset: 0x00010508
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

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x000123A8 File Offset: 0x000105A8
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

		// Token: 0x06000517 RID: 1303 RVA: 0x000123C4 File Offset: 0x000105C4
		protected override void OnRenderSizeChanged(global::System.Windows.SizeChangedInfo sizeInfo)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (this.Field != null) ? this.Field.Owner : null;
			if (fieldLayout != null && this._isChildControlOwnedByThisPlaceholder)
			{
				fieldLayout.BumpLayoutItemVersionAsync();
			}
			base.OnRenderSizeChanged(sizeInfo);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00012400 File Offset: 0x00010600
		protected override void OnInitialized(global::System.EventArgs e)
		{
			this.VerifyCachedElement();
			base.OnInitialized(e);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00012410 File Offset: 0x00010610
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

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x0001245B File Offset: 0x0001065B
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

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00012468 File Offset: 0x00010668
		internal global::System.Windows.Controls.Control ChildCellElement
		{
			get
			{
				return this._childCellElement;
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00012470 File Offset: 0x00010670
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

		// Token: 0x0600051D RID: 1309 RVA: 0x00012498 File Offset: 0x00010698
		private static void OnFieldChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CellPlaceholder cellPlaceholder = target as global::Infragistics.Windows.DataPresenter.CellPlaceholder;
			if (cellPlaceholder != null)
			{
				cellPlaceholder._cachedField = (e.NewValue as global::Infragistics.Windows.DataPresenter.Field);
				cellPlaceholder.VerifyCachedElement();
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x000124C7 File Offset: 0x000106C7
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x000124CF File Offset: 0x000106CF
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

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x000124DD File Offset: 0x000106DD
		internal static bool IsInMeasure
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellPlaceholder._measureCounter != 0;
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000124EC File Offset: 0x000106EC
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
			else if (this._cachedField == this._cachedField.Owner.TreeField)
			{
				this._childCellElement = new global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter();
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

		// Token: 0x06000522 RID: 1314 RVA: 0x000125FC File Offset: 0x000107FC
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

		// Token: 0x06000523 RID: 1315 RVA: 0x00012640 File Offset: 0x00010840
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

		// Token: 0x06000524 RID: 1316 RVA: 0x000126A4 File Offset: 0x000108A4
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

		// Token: 0x06000525 RID: 1317 RVA: 0x0001271C File Offset: 0x0001091C
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

		// Token: 0x04000164 RID: 356
		private global::Infragistics.Windows.DataPresenter.Field _cachedField;

		// Token: 0x04000165 RID: 357
		private global::System.Windows.Controls.Control _childCellElement;

		// Token: 0x04000166 RID: 358
		private bool _isChildControlOwnedByThisPlaceholder;

		// Token: 0x04000167 RID: 359
		private bool _isHooked;

		// Token: 0x04000168 RID: 360
		[global::System.ThreadStatic]
		private static int _measureCounter;

		// Token: 0x04000169 RID: 361
		private bool _alwaysCreateElement;

		// Token: 0x0400016A RID: 362
		internal static readonly global::System.Windows.DependencyProperty FieldProperty = global::System.Windows.DependencyProperty.Register("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.CellPlaceholder), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellPlaceholder.OnFieldChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CellPlaceholder.OnCoerceField)));

		// Token: 0x0400016B RID: 363
		internal static readonly global::System.Windows.DependencyProperty IsLabelProperty = global::System.Windows.DependencyProperty.Register("IsLabel", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellPlaceholder), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x02000060 RID: 96
		private class OwnerNameScope : global::Infragistics.Windows.Helpers.NameScopeProxy
		{
			// Token: 0x06000527 RID: 1319 RVA: 0x000127D7 File Offset: 0x000109D7
			internal OwnerNameScope(global::Infragistics.Windows.DataPresenter.CellPlaceholder cp)
			{
				this._cp = cp;
			}

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x06000528 RID: 1320 RVA: 0x000127E6 File Offset: 0x000109E6
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

			// Token: 0x0400016C RID: 364
			private global::Infragistics.Windows.DataPresenter.CellPlaceholder _cp;
		}
	}
}
