using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E5 RID: 485
	internal class FixedFieldInfo : global::System.Windows.DependencyObject
	{
		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x00075E86 File Offset: 0x00074086
		// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x00075E98 File Offset: 0x00074098
		[global::System.ComponentModel.Bindable(true)]
		public double Extent
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.ExtentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.ExtentProperty, value);
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x00075EAB File Offset: 0x000740AB
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x00075EB3 File Offset: 0x000740B3
		public global::System.Windows.FrameworkElement FixedAreaElement
		{
			get
			{
				return this._fixedAreaElement;
			}
			set
			{
				this._fixedAreaElement = value;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x00075EBC File Offset: 0x000740BC
		// (set) Token: 0x06001BAB RID: 7083 RVA: 0x00075ECE File Offset: 0x000740CE
		[global::System.ComponentModel.Bindable(true)]
		public double Offset
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.OffsetProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.OffsetProperty, value);
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x00075EE1 File Offset: 0x000740E1
		// (set) Token: 0x06001BAD RID: 7085 RVA: 0x00075EF3 File Offset: 0x000740F3
		[global::System.ComponentModel.Bindable(true)]
		public double ViewportExtent
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.ViewportExtentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.ViewportExtentProperty, value);
			}
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00075F06 File Offset: 0x00074106
		internal void AddPanel(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel panel)
		{
			if (this._cellPanels == null)
			{
				this._cellPanels = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel>();
			}
			this._cellPanels.Add(panel);
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00075F28 File Offset: 0x00074128
		private global::System.Windows.Media.TranslateTransform CreateTransform(global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation, bool isVertical)
		{
			global::System.Windows.Media.TranslateTransform translateTransform = new global::System.Windows.Media.TranslateTransform();
			global::System.Windows.Data.BindingBase binding;
			if (fixedLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge)
			{
				binding = new global::System.Windows.Data.MultiBinding
				{
					Bindings = 
					{
						global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.OffsetProperty, global::System.Windows.Data.BindingMode.OneWay, this),
						global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.ViewportExtentProperty, global::System.Windows.Data.BindingMode.OneWay, this),
						global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.ExtentProperty, global::System.Windows.Data.BindingMode.OneWay, this)
					},
					Converter = global::Infragistics.Windows.DataPresenter.FixedFarConverter.Instance
				};
			}
			else
			{
				global::System.Windows.Data.Binding binding2 = global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.OffsetProperty, global::System.Windows.Data.BindingMode.OneWay, this);
				if (fixedLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
				{
					binding2.Converter = global::Infragistics.Windows.DataPresenter.NegateConverter.Instance;
				}
				binding = binding2;
			}
			global::System.Windows.DependencyProperty dp = isVertical ? global::System.Windows.Media.TranslateTransform.YProperty : global::System.Windows.Media.TranslateTransform.XProperty;
			global::System.Windows.Data.BindingOperations.SetBinding(translateTransform, dp, binding);
			return translateTransform;
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00075FD4 File Offset: 0x000741D4
		internal double GetScrollableViewportExtent()
		{
			double num = this.ViewportExtent;
			double viewportExtent = num;
			global::System.Windows.FrameworkElement fixedAreaElement = this.FixedAreaElement;
			if (this._cellPanels != null && fixedAreaElement != null)
			{
				global::System.Windows.Window window = global::System.Windows.Window.GetWindow(fixedAreaElement);
				for (int i = this._cellPanels.Count - 1; i >= 0; i--)
				{
					global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = this._cellPanels[i];
					if (virtualizingDataRecordCellPanel == null || window != global::System.Windows.Window.GetWindow(virtualizingDataRecordCellPanel))
					{
						this._cellPanels.RemoveAt(i);
					}
					else
					{
						num = global::System.Math.Min(num, virtualizingDataRecordCellPanel.GetScrollableViewport(viewportExtent, true));
					}
				}
			}
			return num;
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0007605C File Offset: 0x0007425C
		internal global::System.Windows.Media.Transform GetTransform(global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation, bool isFixedAreaVertical)
		{
			if (this._transforms == null)
			{
				this._transforms = new global::System.Windows.Media.TranslateTransform[6];
			}
			int num = (int)(fixedLocation * global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge);
			if (isFixedAreaVertical)
			{
				num++;
			}
			if (this._transforms[num] == null)
			{
				this._transforms[num] = this.CreateTransform(fixedLocation, isFixedAreaVertical);
			}
			return this._transforms[num];
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x000760AA File Offset: 0x000742AA
		internal void RemovePanel(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel panel)
		{
			if (this._cellPanels != null)
			{
				this._cellPanels.Remove(panel);
			}
		}

		// Token: 0x04000B69 RID: 2921
		private global::System.Windows.Media.TranslateTransform[] _transforms;

		// Token: 0x04000B6A RID: 2922
		private global::System.Windows.FrameworkElement _fixedAreaElement;

		// Token: 0x04000B6B RID: 2923
		private global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel> _cellPanels;

		// Token: 0x04000B6C RID: 2924
		public static readonly global::System.Windows.DependencyProperty ExtentProperty = global::System.Windows.DependencyProperty.Register("Extent", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldInfo), new global::System.Windows.FrameworkPropertyMetadata(0.0));

		// Token: 0x04000B6D RID: 2925
		public static readonly global::System.Windows.DependencyProperty OffsetProperty = global::System.Windows.DependencyProperty.Register("Offset", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldInfo), new global::System.Windows.FrameworkPropertyMetadata(0.0));

		// Token: 0x04000B6E RID: 2926
		public static readonly global::System.Windows.DependencyProperty ViewportExtentProperty = global::System.Windows.DependencyProperty.Register("ViewportExtent", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldInfo), new global::System.Windows.FrameworkPropertyMetadata(0.0));
	}
}
