using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001A6 RID: 422
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryCellPresenter : global::Infragistics.Windows.DataPresenter.CellPresenterBase
	{
		// Token: 0x0600174E RID: 5966 RVA: 0x00066CD8 File Offset: 0x00064ED8
		static SummaryCellPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryCellPresenter)));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.CoerceFieldElementVisibility)));
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00066D64 File Offset: 0x00064F64
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

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x00066DB4 File Offset: 0x00064FB4
		// (set) Token: 0x06001752 RID: 5970 RVA: 0x00066DBC File Offset: 0x00064FBC
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

		// Token: 0x04000910 RID: 2320
		private global::Infragistics.Windows.DataPresenter.Field _cachedField;

		// Token: 0x04000911 RID: 2321
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.SummaryCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.SummaryCellPresenter.OnFieldChanged)));
	}
}
