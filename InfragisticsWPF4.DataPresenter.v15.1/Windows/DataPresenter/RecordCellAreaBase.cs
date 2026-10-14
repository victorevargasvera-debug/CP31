using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001CA RID: 458
	public abstract class RecordCellAreaBase : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06001B11 RID: 6929 RVA: 0x000799F8 File Offset: 0x00077BF8
		static RecordCellAreaBase()
		{
			global::System.Windows.FrameworkElement.DataContextProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.OnDataContextChanged)));
			global::System.Windows.UIElement.ClipProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.CoerceClip)));
			global::System.Windows.UIElement.RenderTransformProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.CoerceRenderTransform)));
			global::Infragistics.Windows.DataPresenter.GridUtilities.SuppressBringIntoView(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase));
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x00079B38 File Offset: 0x00077D38
		protected override void OnRenderSizeChanged(global::System.Windows.SizeChangedInfo sizeInfo)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (this._containingRp != null) ? this._containingRp.FieldLayout : null;
			if (fieldLayout != null)
			{
				bool isHorizontal = fieldLayout.IsHorizontal;
				base.CoerceValue(global::System.Windows.UIElement.ClipProperty);
				if (((isHorizontal && sizeInfo.HeightChanged) || (!isHorizontal && sizeInfo.WidthChanged)) && this._containingRp.CellArea == this)
				{
					this._containingRp.VerifyFixedFarTransform();
				}
			}
			base.OnRenderSizeChanged(sizeInfo);
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x00079BA7 File Offset: 0x00077DA7
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x00079BAF File Offset: 0x00077DAF
		internal double MinCellPanelExtent
		{
			get
			{
				return this._minCellPanelExtent;
			}
			set
			{
				if (value != this._minCellPanelExtent && !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(value, this._minCellPanelExtent))
				{
					this._minCellPanelExtent = value;
					if (base.GetValue(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.FixedFieldInfoProperty) != null)
					{
						base.CoerceValue(global::System.Windows.UIElement.ClipProperty);
					}
				}
			}
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x00079BE8 File Offset: 0x00077DE8
		private static void OnFixedFieldInfoChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordCellAreaBase recordCellAreaBase = (global::Infragistics.Windows.DataPresenter.RecordCellAreaBase)d;
			global::Infragistics.Windows.DataPresenter.FixedFieldInfo fixedFieldInfo = (global::Infragistics.Windows.DataPresenter.FixedFieldInfo)e.NewValue;
			if (fixedFieldInfo != null)
			{
				recordCellAreaBase.SetBinding(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.FixedFieldOffsetProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.OffsetProperty, global::System.Windows.Data.BindingMode.OneWay, fixedFieldInfo));
				recordCellAreaBase.SetBinding(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.FixedFieldViewportExtentProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.ViewportExtentProperty, global::System.Windows.Data.BindingMode.OneWay, fixedFieldInfo));
				recordCellAreaBase.SetBinding(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.FixedFieldExtentProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.ExtentProperty, global::System.Windows.Data.BindingMode.OneWay, fixedFieldInfo));
			}
			else
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(recordCellAreaBase, global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.FixedFieldOffsetProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(recordCellAreaBase, global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.FixedFieldViewportExtentProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(recordCellAreaBase, global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.FixedFieldExtentProperty);
			}
			recordCellAreaBase.CoerceValue(global::System.Windows.UIElement.ClipProperty);
			recordCellAreaBase.CoerceValue(global::System.Windows.UIElement.RenderTransformProperty);
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x00079C8D File Offset: 0x00077E8D
		private static void OnFixedFieldOffsetsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::System.Windows.UIElement.ClipProperty);
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x00079C9A File Offset: 0x00077E9A
		// (set) Token: 0x06001B19 RID: 6937 RVA: 0x00079CA4 File Offset: 0x00077EA4
		internal global::System.Windows.Vector RenderOffset
		{
			get
			{
				return this._renderOffset;
			}
			set
			{
				if (value != this._renderOffset)
				{
					this._renderOffset = value;
					global::System.Windows.Media.TranslateTransform noScrollableTransform = this._noScrollableTransform;
					if (value.X == 0.0 && value.Y == 0.0)
					{
						this._noScrollableTransform = null;
					}
					else if (this._noScrollableTransform == null)
					{
						this._noScrollableTransform = new global::System.Windows.Media.TranslateTransform(-value.X, -value.Y);
					}
					else
					{
						this._noScrollableTransform.X = -value.X;
						this._noScrollableTransform.Y = -value.Y;
					}
					if (noScrollableTransform != this._noScrollableTransform)
					{
						base.CoerceValue(global::System.Windows.UIElement.RenderTransformProperty);
					}
					base.CoerceValue(global::System.Windows.UIElement.ClipProperty);
					if (this._containingRp != null && this == this._containingRp.CellArea)
					{
						this._containingRp.VerifyFixedFarTransform();
					}
				}
			}
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x00079D88 File Offset: 0x00077F88
		private static object CoerceClip(global::System.Windows.DependencyObject d, object newValue)
		{
			if (newValue != null)
			{
				return newValue;
			}
			global::Infragistics.Windows.DataPresenter.RecordCellAreaBase recordCellAreaBase = (global::Infragistics.Windows.DataPresenter.RecordCellAreaBase)d;
			global::System.Windows.Size renderSize = recordCellAreaBase.RenderSize;
			global::Infragistics.Windows.DataPresenter.RecordPresenter containingRp = recordCellAreaBase._containingRp;
			if (renderSize.Width > 0.0 && renderSize.Height > 0.0 && containingRp != null)
			{
				global::Infragistics.Windows.DataPresenter.FixedFieldInfo fixedFieldInfo = (global::Infragistics.Windows.DataPresenter.FixedFieldInfo)d.GetValue(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.FixedFieldInfoProperty);
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = containingRp.FieldLayout;
				if (fixedFieldInfo != null && fieldLayout != null)
				{
					bool isHorizontal = fieldLayout.IsHorizontal;
					global::System.Windows.Rect rect = new global::System.Windows.Rect(renderSize);
					double cellAreaExtent = isHorizontal ? renderSize.Height : renderSize.Width;
					object dataContext = recordCellAreaBase.DataContext;
					double num = global::System.Math.Min(fixedFieldInfo.Extent, global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.CalculateFixedRecordAreaEdge(isHorizontal, cellAreaExtent, containingRp, dataContext as global::Infragistics.Windows.DataPresenter.Record, recordCellAreaBase, dataContext is global::Infragistics.Windows.DataPresenter.FieldLayout));
					double viewportExtent = fixedFieldInfo.ViewportExtent;
					double num2 = fixedFieldInfo.Offset;
					double num3 = -global::System.Math.Max(num - viewportExtent - num2, 0.0);
					double val = global::System.Math.Max(recordCellAreaBase._minCellPanelExtent, 0.0);
					if (isHorizontal)
					{
						num2 += recordCellAreaBase._renderOffset.Y;
						rect.Y += num2;
						rect.Height = global::System.Math.Max(val, rect.Height - num2 + num3);
						rect.X -= 1.0;
						rect.Width += 2.0;
					}
					else
					{
						num2 += recordCellAreaBase._renderOffset.X;
						rect.X += num2;
						rect.Width = global::System.Math.Max(val, rect.Width - num2 + num3);
						rect.Y -= 1.0;
						rect.Height += 2.0;
					}
					if (rect.Width == 0.0 || rect.Height == 0.0)
					{
						return global::System.Windows.Media.Geometry.Empty;
					}
					global::System.Windows.Media.Geometry geometry = new global::System.Windows.Media.RectangleGeometry(rect);
					geometry.Freeze();
					return geometry;
				}
			}
			return newValue;
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x00079FB4 File Offset: 0x000781B4
		private static object CoerceRenderTransform(global::System.Windows.DependencyObject d, object newValue)
		{
			global::System.Windows.Media.Transform transform = newValue as global::System.Windows.Media.Transform;
			if (transform != null && transform != global::System.Windows.Media.Transform.Identity)
			{
				return newValue;
			}
			global::Infragistics.Windows.DataPresenter.RecordCellAreaBase recordCellAreaBase = (global::Infragistics.Windows.DataPresenter.RecordCellAreaBase)d;
			if (recordCellAreaBase._noScrollableTransform != null && recordCellAreaBase.GetValue(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.FixedFieldInfoProperty) != null)
			{
				return recordCellAreaBase._noScrollableTransform;
			}
			return newValue;
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x00079FFC File Offset: 0x000781FC
		private static void OnDataContextChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordCellAreaBase recordCellAreaBase = d as global::Infragistics.Windows.DataPresenter.RecordCellAreaBase;
			if (e.NewValue != null)
			{
				global::Infragistics.Windows.DataPresenter.Record record = e.NewValue as global::Infragistics.Windows.DataPresenter.Record;
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = null;
				if (record != null)
				{
					recordPresenter = global::Infragistics.Windows.DataPresenter.RecordPresenter.FromRecord(record);
				}
				if (recordPresenter == null)
				{
					recordPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(recordCellAreaBase, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
				}
				recordCellAreaBase._containingRp = recordPresenter;
				global::System.Windows.Data.Binding binding;
				if (recordPresenter != null)
				{
					recordPresenter.CellArea = recordCellAreaBase;
					binding = global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldInfoProperty, global::System.Windows.Data.BindingMode.OneWay, recordPresenter);
				}
				else
				{
					global::System.Windows.Data.RelativeSource relativeSource = new global::System.Windows.Data.RelativeSource(global::System.Windows.Data.RelativeSourceMode.FindAncestor, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), 1);
					binding = global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldInfoProperty, global::System.Windows.Data.BindingMode.OneWay, relativeSource);
				}
				recordCellAreaBase.SetBinding(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.FixedFieldInfoProperty, binding);
				if (recordPresenter != null)
				{
					recordCellAreaBase.CoerceValue(global::System.Windows.UIElement.ClipProperty);
					return;
				}
			}
			else
			{
				recordCellAreaBase.ClearValue(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.FixedFieldInfoProperty);
			}
		}

		// Token: 0x04000ADC RID: 2780
		private global::Infragistics.Windows.DataPresenter.RecordPresenter _containingRp;

		// Token: 0x04000ADD RID: 2781
		private double _minCellPanelExtent;

		// Token: 0x04000ADE RID: 2782
		private global::System.Windows.Vector _renderOffset;

		// Token: 0x04000ADF RID: 2783
		private global::System.Windows.Media.TranslateTransform _noScrollableTransform;

		// Token: 0x04000AE0 RID: 2784
		private static readonly global::System.Windows.DependencyProperty FixedFieldInfoProperty = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldInfoProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.OnFixedFieldInfoChanged)));

		// Token: 0x04000AE1 RID: 2785
		internal static readonly global::System.Windows.DependencyProperty FixedFieldOffsetProperty = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldOffsetProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.OnFixedFieldOffsetsChanged)));

		// Token: 0x04000AE2 RID: 2786
		internal static readonly global::System.Windows.DependencyProperty FixedFieldViewportExtentProperty = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldViewportExtentProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.OnFixedFieldOffsetsChanged)));

		// Token: 0x04000AE3 RID: 2787
		internal static readonly global::System.Windows.DependencyProperty FixedFieldExtentProperty = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldExtentProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.OnFixedFieldOffsetsChanged)));
	}
}
