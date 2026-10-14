using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001A7 RID: 423
	public abstract class RecordCellAreaBase : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06001753 RID: 5971 RVA: 0x00066DCC File Offset: 0x00064FCC
		static RecordCellAreaBase()
		{
			global::System.Windows.FrameworkElement.DataContextProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.OnDataContextChanged)));
			global::System.Windows.UIElement.ClipProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.CoerceClip)));
			global::System.Windows.UIElement.RenderTransformProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.CoerceRenderTransform)));
			global::Infragistics.Windows.DataPresenter.GridUtilities.SuppressBringIntoView(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase));
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00066F0C File Offset: 0x0006510C
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

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x00066F7B File Offset: 0x0006517B
		// (set) Token: 0x06001757 RID: 5975 RVA: 0x00066F83 File Offset: 0x00065183
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

		// Token: 0x06001758 RID: 5976 RVA: 0x00066FBC File Offset: 0x000651BC
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

		// Token: 0x06001759 RID: 5977 RVA: 0x00067061 File Offset: 0x00065261
		private static void OnFixedFieldOffsetsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::System.Windows.UIElement.ClipProperty);
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x0006706E File Offset: 0x0006526E
		// (set) Token: 0x0600175B RID: 5979 RVA: 0x00067078 File Offset: 0x00065278
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

		// Token: 0x0600175C RID: 5980 RVA: 0x0006715C File Offset: 0x0006535C
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

		// Token: 0x0600175D RID: 5981 RVA: 0x00067388 File Offset: 0x00065588
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

		// Token: 0x0600175E RID: 5982 RVA: 0x000673D0 File Offset: 0x000655D0
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

		// Token: 0x04000912 RID: 2322
		private global::Infragistics.Windows.DataPresenter.RecordPresenter _containingRp;

		// Token: 0x04000913 RID: 2323
		private double _minCellPanelExtent;

		// Token: 0x04000914 RID: 2324
		private global::System.Windows.Vector _renderOffset;

		// Token: 0x04000915 RID: 2325
		private global::System.Windows.Media.TranslateTransform _noScrollableTransform;

		// Token: 0x04000916 RID: 2326
		private static readonly global::System.Windows.DependencyProperty FixedFieldInfoProperty = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldInfoProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.OnFixedFieldInfoChanged)));

		// Token: 0x04000917 RID: 2327
		internal static readonly global::System.Windows.DependencyProperty FixedFieldOffsetProperty = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldOffsetProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.OnFixedFieldOffsetsChanged)));

		// Token: 0x04000918 RID: 2328
		internal static readonly global::System.Windows.DependencyProperty FixedFieldViewportExtentProperty = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldViewportExtentProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.OnFixedFieldOffsetsChanged)));

		// Token: 0x04000919 RID: 2329
		internal static readonly global::System.Windows.DependencyProperty FixedFieldExtentProperty = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldExtentProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase.OnFixedFieldOffsetsChanged)));
	}
}
