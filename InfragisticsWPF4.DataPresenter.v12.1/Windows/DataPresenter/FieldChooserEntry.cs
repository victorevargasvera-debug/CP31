using System;
using System.Windows;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000107 RID: 263
	public class FieldChooserEntry : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06000DDC RID: 3548 RVA: 0x0003BB54 File Offset: 0x00039D54
		public FieldChooserEntry(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
			this._field = field;
			this._isVisible = global::Infragistics.Windows.DataPresenter.FieldChooserEntry.IsFieldVisible(field);
			this._fieldVisibilityTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._field, "VisibilityResolved", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnFieldVisibilityChanged));
			this._fieldActualPositionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._field, "ActualPosition", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnFieldActualPositionChanged));
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x0003BBC4 File Offset: 0x00039DC4
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x0003BBCC File Offset: 0x00039DCC
		public bool IsSelected
		{
			get
			{
				return this._isSelected;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x0003BBD4 File Offset: 0x00039DD4
		// (set) Token: 0x06000DE0 RID: 3552 RVA: 0x0003BBDC File Offset: 0x00039DDC
		public bool IsVisible
		{
			get
			{
				return this._isVisible;
			}
			set
			{
				if (this._isVisible != value)
				{
					global::Infragistics.Windows.DataPresenter.FieldDragManager.ChangeFieldVisibilityViaFieldChooser(this._field, value);
					this._isVisible = global::Infragistics.Windows.DataPresenter.FieldChooserEntry.IsFieldVisible(this._field);
					base.RaisePropertyChangedEvent("IsVisible");
				}
			}
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0003BC0F File Offset: 0x00039E0F
		internal void InitializeFieldChooser(global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser)
		{
			this._fieldChooser = fieldChooser;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0003BC18 File Offset: 0x00039E18
		internal void InternalSetIsSelected(bool isSelected)
		{
			if (this._isSelected != isSelected)
			{
				this._isSelected = isSelected;
				base.RaisePropertyChangedEvent("IsSelected");
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0003BC35 File Offset: 0x00039E35
		private static bool IsFieldVisible(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return global::System.Windows.Visibility.Visible == field.VisibilityResolved;
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0003BC40 File Offset: 0x00039E40
		private void OnFieldActualPositionChanged()
		{
			if (this._fieldChooser != null && global::Infragistics.Windows.DataPresenter.FieldChooserDisplayOrder.SameAsDataPresenter == this._fieldChooser.FieldDisplayOrder)
			{
				this._fieldChooser.ReInitializeCurrentFieldsAsync();
			}
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0003BC64 File Offset: 0x00039E64
		private void OnFieldVisibilityChanged()
		{
			bool flag = global::Infragistics.Windows.DataPresenter.FieldChooserEntry.IsFieldVisible(this._field);
			if (flag != this._isVisible)
			{
				this._isVisible = flag;
				base.RaisePropertyChangedEvent("IsVisible");
				if (this._fieldChooser != null)
				{
					this._fieldChooser.OnFieldVisibilityChanged(this._field);
				}
			}
		}

		// Token: 0x0400055D RID: 1373
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x0400055E RID: 1374
		private bool _isVisible;

		// Token: 0x0400055F RID: 1375
		private bool _isSelected;

		// Token: 0x04000560 RID: 1376
		private global::Infragistics.Windows.DataPresenter.FieldChooser _fieldChooser;

		// Token: 0x04000561 RID: 1377
		private global::Infragistics.Windows.Internal.PropertyValueTracker _fieldVisibilityTracker;

		// Token: 0x04000562 RID: 1378
		private global::Infragistics.Windows.Internal.PropertyValueTracker _fieldActualPositionTracker;
	}
}
