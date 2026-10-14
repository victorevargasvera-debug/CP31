using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000066 RID: 102
	public class ExpandedCellPresenter : global::Infragistics.Windows.DataPresenter.CellValuePresenter
	{
		// Token: 0x060005CD RID: 1485 RVA: 0x00015B84 File Offset: 0x00013D84
		static ExpandedCellPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter)));
			global::System.Windows.FrameworkElement.HorizontalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Left));
			global::System.Windows.FrameworkElement.VerticalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.VerticalAlignment.Top));
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00015C4E File Offset: 0x00013E4E
		internal ExpandedCellPresenter(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter, global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord record)
		{
			this._presenter = dataPresenter;
			this._record = record;
			global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._record, this, string.Empty);
			base.SetBinding(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter.RenderVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RenderVersionProperty, global::System.Windows.Data.BindingMode.OneWay, dataPresenter));
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00015C90 File Offset: 0x00013E90
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

		// Token: 0x060005D0 RID: 1488 RVA: 0x00015CB8 File Offset: 0x00013EB8
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

		// Token: 0x060005D1 RID: 1489 RVA: 0x00015CEA File Offset: 0x00013EEA
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00015CF3 File Offset: 0x00013EF3
		protected override void OnRecordPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "IsExpanded" && !this._record.IsExpanded)
			{
				base.ClearValue(global::System.Windows.Controls.ContentControl.ContentProperty);
				global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._record, this, string.Empty);
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00015D30 File Offset: 0x00013F30
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00015D42 File Offset: 0x00013F42
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

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00015D55 File Offset: 0x00013F55
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00015D67 File Offset: 0x00013F67
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

		// Token: 0x040001B6 RID: 438
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _presenter;

		// Token: 0x040001B7 RID: 439
		private global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord _record;

		// Token: 0x040001B8 RID: 440
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Horizontal));

		// Token: 0x040001B9 RID: 441
		internal static readonly global::System.Windows.DependencyProperty RenderVersionProperty = global::System.Windows.DependencyProperty.Register("RenderVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter), new global::System.Windows.FrameworkPropertyMetadata(0));
	}
}
