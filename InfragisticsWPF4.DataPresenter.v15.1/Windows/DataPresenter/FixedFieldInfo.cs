using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000217 RID: 535
	internal class FixedFieldInfo : global::System.Windows.DependencyObject
	{
		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x0008B9D6 File Offset: 0x00089BD6
		// (set) Token: 0x0600200C RID: 8204 RVA: 0x0008B9E8 File Offset: 0x00089BE8
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

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x0008B9FB File Offset: 0x00089BFB
		// (set) Token: 0x0600200E RID: 8206 RVA: 0x0008BA03 File Offset: 0x00089C03
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

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x0008BA0C File Offset: 0x00089C0C
		// (set) Token: 0x06002010 RID: 8208 RVA: 0x0008BA1E File Offset: 0x00089C1E
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

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x0008BA31 File Offset: 0x00089C31
		// (set) Token: 0x06002012 RID: 8210 RVA: 0x0008BA43 File Offset: 0x00089C43
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

		// Token: 0x06002013 RID: 8211 RVA: 0x0008BA56 File Offset: 0x00089C56
		internal void AddPanel(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel panel)
		{
			if (this._cellPanels == null)
			{
				this._cellPanels = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel>();
			}
			this._cellPanels.Add(panel);
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x0008BA78 File Offset: 0x00089C78
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

		// Token: 0x06002015 RID: 8213 RVA: 0x0008BB24 File Offset: 0x00089D24
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

		// Token: 0x06002016 RID: 8214 RVA: 0x0008BBAC File Offset: 0x00089DAC
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

		// Token: 0x06002017 RID: 8215 RVA: 0x0008BBFA File Offset: 0x00089DFA
		internal void RemovePanel(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel panel)
		{
			if (this._cellPanels != null)
			{
				this._cellPanels.Remove(panel);
			}
		}

		// Token: 0x04000D7A RID: 3450
		private global::System.Windows.Media.TranslateTransform[] _transforms;

		// Token: 0x04000D7B RID: 3451
		private global::System.Windows.FrameworkElement _fixedAreaElement;

		// Token: 0x04000D7C RID: 3452
		private global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel> _cellPanels;

		// Token: 0x04000D7D RID: 3453
		public static readonly global::System.Windows.DependencyProperty ExtentProperty = global::System.Windows.DependencyProperty.Register("Extent", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldInfo), new global::System.Windows.FrameworkPropertyMetadata(0.0));

		// Token: 0x04000D7E RID: 3454
		public static readonly global::System.Windows.DependencyProperty OffsetProperty = global::System.Windows.DependencyProperty.Register("Offset", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldInfo), new global::System.Windows.FrameworkPropertyMetadata(0.0));

		// Token: 0x04000D7F RID: 3455
		public static readonly global::System.Windows.DependencyProperty ViewportExtentProperty = global::System.Windows.DependencyProperty.Register("ViewportExtent", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FixedFieldInfo), new global::System.Windows.FrameworkPropertyMetadata(0.0));
	}
}
