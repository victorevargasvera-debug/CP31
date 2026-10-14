using System;
using System.Windows;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000123 RID: 291
	public class FieldChooserEntry : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x0600113D RID: 4413 RVA: 0x0004C614 File Offset: 0x0004A814
		public FieldChooserEntry(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
			this._field = field;
			this._isVisible = global::Infragistics.Windows.DataPresenter.FieldChooserEntry.IsFieldVisible(field);
			this._fieldVisibilityTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._field, "VisibilityResolved", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnFieldVisibilityChanged));
			this._fieldActualPositionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._field, "ActualPosition", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnFieldActualPositionChanged));
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x0004C684 File Offset: 0x0004A884
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x0004C68C File Offset: 0x0004A88C
		public bool IsSelected
		{
			get
			{
				return this._isSelected;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x0004C694 File Offset: 0x0004A894
		// (set) Token: 0x06001141 RID: 4417 RVA: 0x0004C69C File Offset: 0x0004A89C
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

		// Token: 0x06001142 RID: 4418 RVA: 0x0004C6CF File Offset: 0x0004A8CF
		internal void InitializeFieldChooser(global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser)
		{
			this._fieldChooser = fieldChooser;
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0004C6D8 File Offset: 0x0004A8D8
		internal void InternalSetIsSelected(bool isSelected)
		{
			if (this._isSelected != isSelected)
			{
				this._isSelected = isSelected;
				base.RaisePropertyChangedEvent("IsSelected");
			}
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x0004C6F5 File Offset: 0x0004A8F5
		private static bool IsFieldVisible(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return global::System.Windows.Visibility.Visible == field.VisibilityResolved;
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0004C700 File Offset: 0x0004A900
		private void OnFieldActualPositionChanged()
		{
			if (this._fieldChooser != null && global::Infragistics.Windows.DataPresenter.FieldChooserDisplayOrder.SameAsDataPresenter == this._fieldChooser.FieldDisplayOrder)
			{
				this._fieldChooser.ReInitializeCurrentFieldsAsync();
			}
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x0004C724 File Offset: 0x0004A924
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

		// Token: 0x040006FC RID: 1788
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x040006FD RID: 1789
		private bool _isVisible;

		// Token: 0x040006FE RID: 1790
		private bool _isSelected;

		// Token: 0x040006FF RID: 1791
		private global::Infragistics.Windows.DataPresenter.FieldChooser _fieldChooser;

		// Token: 0x04000700 RID: 1792
		private global::Infragistics.Windows.Internal.PropertyValueTracker _fieldVisibilityTracker;

		// Token: 0x04000701 RID: 1793
		private global::Infragistics.Windows.Internal.PropertyValueTracker _fieldActualPositionTracker;
	}
}
