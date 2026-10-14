using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000062 RID: 98
	public class ExpandedCellPresenter : global::Infragistics.Windows.DataPresenter.CellValuePresenter
	{
		// Token: 0x06000567 RID: 1383 RVA: 0x00013DE8 File Offset: 0x00011FE8
		static ExpandedCellPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter)));
			global::System.Windows.FrameworkElement.HorizontalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Left));
			global::System.Windows.FrameworkElement.VerticalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.VerticalAlignment.Top));
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00013EB2 File Offset: 0x000120B2
		internal ExpandedCellPresenter(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter, global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord record)
		{
			this._presenter = dataPresenter;
			this._record = record;
			global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._record, this, string.Empty);
			base.SetBinding(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter.RenderVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RenderVersionProperty, global::System.Windows.Data.BindingMode.OneWay, dataPresenter));
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00013EF4 File Offset: 0x000120F4
		protected override object OnCoerceValue(object value)
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter.CVPValueWrapper cvpvalueWrapper = value as global::Infragistics.Windows.DataPresenter.CellValuePresenter.CVPValueWrapper;
			if (cvpvalueWrapper != null)
			{
				value = cvpvalueWrapper._value;
			}
			base.Content = value;
			return value;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00013F1C File Offset: 0x0001211C
		protected override void OnFieldPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnFieldPropertyChanged(e);
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (!(propertyName == "ExpandedCellStyleResolved"))
				{
					return;
				}
				base.InvalidateStyleSelector();
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00013F4E File Offset: 0x0001214E
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00013F57 File Offset: 0x00012157
		protected override void OnRecordPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "IsExpanded" && !this._record.IsExpanded)
			{
				base.ClearValue(global::System.Windows.Controls.ContentControl.ContentProperty);
				global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._record, this, string.Empty);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00013F94 File Offset: 0x00012194
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00013FA6 File Offset: 0x000121A6
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter.OrientationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter.OrientationProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00013FB9 File Offset: 0x000121B9
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00013FCB File Offset: 0x000121CB
		internal int RenderVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter.RenderVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter.RenderVersionProperty, value);
			}
		}

		// Token: 0x04000189 RID: 393
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _presenter;

		// Token: 0x0400018A RID: 394
		private global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord _record;

		// Token: 0x0400018B RID: 395
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Horizontal));

		// Token: 0x0400018C RID: 396
		internal static readonly global::System.Windows.DependencyProperty RenderVersionProperty = global::System.Windows.DependencyProperty.Register("RenderVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(0));
	}
}
