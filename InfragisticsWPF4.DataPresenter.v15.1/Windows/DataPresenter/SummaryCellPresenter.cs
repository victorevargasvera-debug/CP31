using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001C9 RID: 457
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryCellPresenter : global::Infragistics.Windows.DataPresenter.CellPresenterBase
	{
		// Token: 0x06001B0C RID: 6924 RVA: 0x00079904 File Offset: 0x00077B04
		static SummaryCellPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryCellPresenter)));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.CoerceFieldElementVisibility)));
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00079990 File Offset: 0x00077B90
		private static void OnFieldChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.SummaryCellPresenter summaryCellPresenter = (global::Infragistics.Windows.DataPresenter.SummaryCellPresenter)dependencyObject;
			global::Infragistics.Windows.DataPresenter.Field field = (global::Infragistics.Windows.DataPresenter.Field)e.NewValue;
			summaryCellPresenter._cachedField = field;
			if (field != null)
			{
				summaryCellPresenter.SetBinding(global::Infragistics.Windows.DataPresenter.GridUtilities.FieldVisibilityProperty, field.VisibilityBinding);
			}
			else
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(summaryCellPresenter, global::Infragistics.Windows.DataPresenter.GridUtilities.FieldVisibilityProperty);
			}
			summaryCellPresenter.InvalidateLayoutElement();
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x000799E0 File Offset: 0x00077BE0
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x000799E8 File Offset: 0x00077BE8
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

		// Token: 0x04000ADA RID: 2778
		private global::Infragistics.Windows.DataPresenter.Field _cachedField;

		// Token: 0x04000ADB RID: 2779
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.SummaryCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.SummaryCellPresenter.OnFieldChanged)));
	}
}
