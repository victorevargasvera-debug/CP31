using System;
using System.Collections;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200005C RID: 92
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public abstract class CellPresenterLayoutElementBase : global::System.Windows.FrameworkElement
	{
		// Token: 0x060004E0 RID: 1248 RVA: 0x00011494 File Offset: 0x0000F694
		static CellPresenterLayoutElementBase()
		{
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x000114E9 File Offset: 0x0000F6E9
		public CellPresenterLayoutElementBase()
		{
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000114F4 File Offset: 0x0000F6F4
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::Infragistics.Windows.DataPresenter.CellPresenterBase cellPresenter = this.CellPresenter;
			global::System.Windows.Rect rect = (cellPresenter != null) ? cellPresenter.CellRect : global::System.Windows.Rect.Empty;
			global::System.Windows.Rect rect2 = (cellPresenter != null) ? cellPresenter.LabelRect : global::System.Windows.Rect.Empty;
			if (rect.IsEmpty)
			{
				rect = this._measureCellRect;
			}
			if (rect2.IsEmpty)
			{
				rect2 = this._measureLabelRect;
			}
			global::System.Windows.Rect rect3 = new global::System.Windows.Rect(finalSize);
			for (int i = 0; i < 2; i++)
			{
				bool flag = i == 0;
				global::System.Windows.FrameworkElement frameworkElement = flag ? this._labelPresenter : this._cellValuePresenter;
				if (frameworkElement != null)
				{
					global::System.Windows.Rect rect4 = flag ? rect2 : rect;
					this.ArrangeHelper(frameworkElement, rect4);
					rect3.Union(rect4);
				}
			}
			return rect3.Size;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000115A5 File Offset: 0x0000F7A5
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index == 0)
			{
				if (this._cellValuePresenter != null)
				{
					return this._cellValuePresenter;
				}
				return this._labelPresenter;
			}
			else
			{
				if (index == 1)
				{
					return this._labelPresenter;
				}
				throw new global::System.IndexOutOfRangeException();
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x000115D0 File Offset: 0x0000F7D0
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				global::System.Windows.FrameworkElement[] array = new global::System.Windows.FrameworkElement[this.VisualChildrenCount];
				for (int i = 0; i < this.VisualChildrenCount; i++)
				{
					array[i] = (this.GetVisualChild(i) as global::System.Windows.FrameworkElement);
				}
				return array.GetEnumerator();
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00011610 File Offset: 0x0000F810
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::Infragistics.Windows.DataPresenter.Field cachedField = this._cachedField;
			this.GetFieldAndRecordForCaching(out this._cachedField, out this._cachedRecord);
			if (this._cachedField != cachedField)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (this._cachedField != null) ? this._cachedField.Owner : null;
				if (fieldLayout != null)
				{
					base.SetBinding(global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase.GridColumnWidthVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.GridColumnWidthVersionProperty, global::System.Windows.Data.BindingMode.OneWay, fieldLayout));
				}
			}
			global::System.Windows.Size result = default(global::System.Windows.Size);
			global::Infragistics.Windows.DataPresenter.Field cachedField2 = this._cachedField;
			global::Infragistics.Windows.DataPresenter.Record cachedRecord = this._cachedRecord;
			if (cachedField2 != null && cachedRecord != null)
			{
				this.VerifyChildElementsImpl();
				global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager cplayoutManager = cachedField2.GetCPLayoutManager(availableSize);
				global::Infragistics.Windows.DataPresenter.DragToolWindow dragToolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this) as global::Infragistics.Windows.DataPresenter.DragToolWindow;
				global::Infragistics.Windows.DataPresenter.CellPresenterBase cellPresenter = this.CellPresenter;
				if (cellPresenter != null)
				{
					cellPresenter.SynchronizeChildElements();
				}
				global::System.Windows.Rect preferredCellRect;
				global::System.Windows.Rect preferredLabelRect;
				if (dragToolWindow != null && cellPresenter != null)
				{
					preferredCellRect = cellPresenter.CellRect;
					preferredLabelRect = cellPresenter.LabelRect;
				}
				else
				{
					preferredCellRect = (preferredLabelRect = global::System.Windows.Rect.Empty);
				}
				cplayoutManager.Initialize(this, new global::System.Windows.Rect(availableSize), preferredCellRect, preferredLabelRect);
				this._measureCellRect = cplayoutManager.CellRect;
				this._measureLabelRect = cplayoutManager.LabelRect;
				object containerContext = new global::System.Windows.Rect(availableSize);
				global::System.Windows.Size size = cplayoutManager.CalculatePreferredSize(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, containerContext);
				global::System.Windows.Size size2 = cplayoutManager.CalculateMinimumSize(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, containerContext);
				global::System.Windows.Size size3 = cplayoutManager.CalculateMaximumSize(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, containerContext);
				if (!double.IsPositiveInfinity(availableSize.Width) && availableSize.Width > size.Width)
				{
					size.Width = global::System.Math.Min(availableSize.Width, size3.Width);
				}
				if (!double.IsPositiveInfinity(availableSize.Height) && availableSize.Height > size.Height)
				{
					size.Height = global::System.Math.Min(availableSize.Height, size3.Height);
				}
				if (!double.IsPositiveInfinity(availableSize.Width) && !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(size.Width, availableSize.Width) && size.Width > availableSize.Width)
				{
					size.Width = global::System.Math.Max(size2.Width, availableSize.Width);
				}
				if (!double.IsPositiveInfinity(availableSize.Height) && !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(size.Height, availableSize.Height) && size.Height > availableSize.Height)
				{
					size.Height = global::System.Math.Max(size2.Height, availableSize.Height);
				}
				cachedField2.ReleaseCPLayoutManager(cplayoutManager);
				result = size;
			}
			result.Width = global::System.Math.Max(result.Width, 1.0);
			result.Height = global::System.Math.Max(result.Height, 1.0);
			return result;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000118A1 File Offset: 0x0000FAA1
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			if (this._isMeasuring)
			{
				return;
			}
			base.OnChildDesiredSizeChanged(child);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000118B4 File Offset: 0x0000FAB4
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase.WindowServiceProperty == null && e.Property.Name == "IWindowService")
			{
				global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase.WindowServiceProperty = e.Property;
			}
			if (e.Property == global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase.WindowServiceProperty)
			{
				if (e.NewValue == null)
				{
					this.VerifyLayoutVersion();
					this.ReleaseCellValuePresenter(true);
					this.ReleaseLabelPresenter(true);
					return;
				}
				base.InvalidateMeasure();
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00011928 File Offset: 0x0000FB28
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("CellPresenterLayoutElement: ");
			global::Infragistics.Windows.DataPresenter.Field field = this.Field;
			if (field != null)
			{
				stringBuilder.Append(field.ToString());
				stringBuilder.Append(", ");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00011970 File Offset: 0x0000FB70
		protected override int VisualChildrenCount
		{
			get
			{
				int num = 0;
				if (this._cellValuePresenter != null)
				{
					num++;
				}
				if (this._labelPresenter != null)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00011998 File Offset: 0x0000FB98
		internal global::Infragistics.Windows.DataPresenter.CellContentAlignment CellContentAlignment
		{
			get
			{
				if (this._cachedField == null)
				{
					return global::Infragistics.Windows.DataPresenter.CellContentAlignment.Default;
				}
				if (this._cachedField.Owner.HasSeparateHeader)
				{
					return global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly;
				}
				return this._cachedField.CellContentAlignmentResolved;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x000119C3 File Offset: 0x0000FBC3
		internal global::Infragistics.Windows.DataPresenter.CellPresenterBase CellPresenter
		{
			get
			{
				if (this._cellPresenter == null)
				{
					this._cellPresenter = (base.TemplatedParent as global::Infragistics.Windows.DataPresenter.CellPresenterBase);
				}
				return this._cellPresenter;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x000119E4 File Offset: 0x0000FBE4
		internal global::System.Windows.FrameworkElement CellValuePresenter
		{
			get
			{
				return this._cellValuePresenter;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x000119EC File Offset: 0x0000FBEC
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				if (this._cachedField == null)
				{
					return null;
				}
				return this._cachedField.Owner.DataPresenter;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00011A08 File Offset: 0x0000FC08
		internal global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._cachedField;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00011A10 File Offset: 0x0000FC10
		internal global::System.Windows.FrameworkElement LabelPresenter
		{
			get
			{
				return this._labelPresenter;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00011A18 File Offset: 0x0000FC18
		internal global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._cachedRecord;
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00011A20 File Offset: 0x0000FC20
		private static void OnGridColumnWidthVersionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase cellPresenterLayoutElementBase = (global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase)d;
			if (cellPresenterLayoutElementBase._cachedField != null)
			{
				cellPresenterLayoutElementBase.InvalidateMeasure();
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00011A44 File Offset: 0x0000FC44
		private void ArrangeHelper(global::System.Windows.FrameworkElement child, global::System.Windows.Rect rect)
		{
			bool isMeasuring = this._isMeasuring;
			this._isMeasuring = true;
			try
			{
				global::System.Windows.Size size = rect.Size;
				child.Measure(size);
				child.Arrange(rect);
			}
			finally
			{
				this._isMeasuring = isMeasuring;
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00011A90 File Offset: 0x0000FC90
		internal static void CalculateRects(global::System.Windows.Size cellPresenterSize, global::System.Windows.Size labelDesiredSize, global::System.Windows.Size cellDesiredSize, global::Infragistics.Windows.DataPresenter.CellContentAlignment contentAlignment, out global::System.Windows.Rect labelRect, out global::System.Windows.Rect cellRect)
		{
			global::System.Windows.HorizontalAlignment horizontalAlignment = global::System.Windows.HorizontalAlignment.Left;
			global::System.Windows.VerticalAlignment verticalAlignment = global::System.Windows.VerticalAlignment.Top;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			switch (contentAlignment)
			{
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignLeft:
				flag = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Left;
				verticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignCenter:
				flag = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Center;
				verticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignRight:
				flag = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Right;
				verticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueStretch:
				flag = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
				verticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignLeft:
				flag2 = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Left;
				verticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignCenter:
				flag2 = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Center;
				verticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignRight:
				flag2 = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Right;
				verticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueStretch:
				flag2 = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
				verticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignTop:
				flag3 = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
				verticalAlignment = global::System.Windows.VerticalAlignment.Top;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignMiddle:
				flag3 = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
				verticalAlignment = global::System.Windows.VerticalAlignment.Center;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignBottom:
				flag3 = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
				verticalAlignment = global::System.Windows.VerticalAlignment.Bottom;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueStretch:
				flag3 = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
				verticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignTop:
				flag4 = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
				verticalAlignment = global::System.Windows.VerticalAlignment.Top;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignMiddle:
				flag4 = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
				verticalAlignment = global::System.Windows.VerticalAlignment.Center;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignBottom:
				flag4 = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
				verticalAlignment = global::System.Windows.VerticalAlignment.Bottom;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueStretch:
				flag4 = true;
				horizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
				verticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
				break;
			}
			labelRect = new global::System.Windows.Rect(labelDesiredSize);
			cellRect = new global::System.Windows.Rect(cellDesiredSize);
			if (flag)
			{
				cellRect.Y = labelRect.Height;
			}
			else if (flag2)
			{
				labelRect.Y = global::System.Math.Max(cellPresenterSize.Height - labelRect.Height, 0.0);
			}
			else if (flag3)
			{
				cellRect.X = labelRect.Width;
			}
			else if (flag4)
			{
				labelRect.X = global::System.Math.Max(cellPresenterSize.Width - labelRect.Width, 0.0);
			}
			switch (horizontalAlignment)
			{
			case global::System.Windows.HorizontalAlignment.Center:
				cellRect.X = global::System.Math.Max((cellPresenterSize.Width - cellRect.Width) / 2.0, 0.0);
				labelRect.X = global::System.Math.Max((cellPresenterSize.Width - labelRect.Width) / 2.0, 0.0);
				break;
			case global::System.Windows.HorizontalAlignment.Right:
				cellRect.X = global::System.Math.Max(cellPresenterSize.Width - cellRect.Width, 0.0);
				labelRect.X = global::System.Math.Max(cellPresenterSize.Width - labelRect.Width, 0.0);
				break;
			case global::System.Windows.HorizontalAlignment.Stretch:
				if (flag || flag2)
				{
					cellRect.Width = cellPresenterSize.Width;
					labelRect.Width = cellPresenterSize.Width;
				}
				else if (flag3)
				{
					cellRect.Width = global::System.Math.Max(cellPresenterSize.Width - cellRect.X, 0.0);
				}
				else
				{
					labelRect.Width = global::System.Math.Max(cellPresenterSize.Width - labelRect.X, 0.0);
				}
				break;
			}
			switch (verticalAlignment)
			{
			case global::System.Windows.VerticalAlignment.Center:
				cellRect.Y = global::System.Math.Max((cellPresenterSize.Height - cellRect.Height) / 2.0, 0.0);
				labelRect.Y = global::System.Math.Max((cellPresenterSize.Height - labelRect.Height) / 2.0, 0.0);
				return;
			case global::System.Windows.VerticalAlignment.Bottom:
				cellRect.Y = global::System.Math.Max(cellPresenterSize.Height - cellRect.Height, 0.0);
				labelRect.Y = global::System.Math.Max(cellPresenterSize.Height - labelRect.Height, 0.0);
				return;
			case global::System.Windows.VerticalAlignment.Stretch:
				if (flag3 || flag4)
				{
					cellRect.Height = cellPresenterSize.Height;
					labelRect.Height = cellPresenterSize.Height;
					return;
				}
				if (flag)
				{
					cellRect.Height = global::System.Math.Max(cellPresenterSize.Height - cellRect.Y, 0.0);
					return;
				}
				labelRect.Height = global::System.Math.Max(cellPresenterSize.Height - labelRect.Y, 0.0);
				return;
			default:
				return;
			}
		}

		// Token: 0x060004F4 RID: 1268
		internal abstract global::System.Windows.FrameworkElement CreateCellValuePresenter(global::System.Windows.FrameworkElement oldElem);

		// Token: 0x060004F5 RID: 1269
		internal abstract global::System.Windows.FrameworkElement CreateLabelPresenter(global::System.Windows.FrameworkElement oldElem);

		// Token: 0x060004F6 RID: 1270
		internal abstract void GetFieldAndRecordForCaching(out global::Infragistics.Windows.DataPresenter.Field field, out global::Infragistics.Windows.DataPresenter.Record record);

		// Token: 0x060004F7 RID: 1271
		internal abstract void InitializeCellValuePresenter(global::System.Windows.FrameworkElement cvp);

		// Token: 0x060004F8 RID: 1272 RVA: 0x00011E84 File Offset: 0x00010084
		internal void ReleaseCellValuePresenter(bool recycle)
		{
			if (this._cellValuePresenter != null)
			{
				global::System.Windows.FrameworkElement cellValuePresenter = this._cellValuePresenter;
				this._cellValuePresenter = null;
				base.RemoveLogicalChild(cellValuePresenter);
				base.RemoveVisualChild(cellValuePresenter);
				this.ReleaseCellValuePresenter(cellValuePresenter, recycle);
			}
		}

		// Token: 0x060004F9 RID: 1273
		internal abstract void ReleaseCellValuePresenter(global::System.Windows.FrameworkElement cellValuePresenter, bool recycle);

		// Token: 0x060004FA RID: 1274 RVA: 0x00011EC0 File Offset: 0x000100C0
		internal void ReleaseLabelPresenter(bool recycle)
		{
			if (this._labelPresenter != null)
			{
				global::System.Windows.FrameworkElement labelPresenter = this._labelPresenter;
				this._labelPresenter = null;
				base.RemoveLogicalChild(labelPresenter);
				base.RemoveVisualChild(labelPresenter);
				this.ReleaseLabelPresenter(labelPresenter, recycle);
			}
		}

		// Token: 0x060004FB RID: 1275
		internal abstract void ReleaseLabelPresenter(global::System.Windows.FrameworkElement labelPresenter, bool recycle);

		// Token: 0x060004FC RID: 1276 RVA: 0x00011EFC File Offset: 0x000100FC
		internal void VerifyChildElements()
		{
			this.GetFieldAndRecordForCaching(out this._cachedField, out this._cachedRecord);
			global::Infragistics.Windows.DataPresenter.Field cachedField = this._cachedField;
			global::Infragistics.Windows.DataPresenter.Record cachedRecord = this._cachedRecord;
			if (cachedField == null || cachedRecord == null)
			{
				return;
			}
			this.VerifyChildElementsImpl();
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00011F38 File Offset: 0x00010138
		private void VerifyChildElementsImpl()
		{
			global::Infragistics.Windows.DataPresenter.CellContentAlignment cellContentAlignment = this.CellContentAlignment;
			this.VerifyLayoutVersion();
			if (cellContentAlignment == global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelOnly)
			{
				this.ReleaseCellValuePresenter(true);
			}
			else
			{
				global::System.Windows.FrameworkElement frameworkElement = this.CreateCellValuePresenter(this._cellValuePresenter);
				if (frameworkElement != this._cellValuePresenter)
				{
					if (this._cellValuePresenter != null)
					{
						this.ReleaseCellValuePresenter(this._cellValuePresenter, true);
					}
					this._cellValuePresenter = frameworkElement;
					base.AddLogicalChild(this._cellValuePresenter);
					base.AddVisualChild(this._cellValuePresenter);
					this.InitializeCellValuePresenter(this._cellValuePresenter);
				}
			}
			if (cellContentAlignment == global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly)
			{
				this.ReleaseLabelPresenter(true);
				return;
			}
			global::System.Windows.FrameworkElement frameworkElement2 = this.CreateLabelPresenter(this._labelPresenter);
			if (frameworkElement2 != this._labelPresenter)
			{
				if (this._labelPresenter != null)
				{
					this.ReleaseLabelPresenter(true);
				}
				this._labelPresenter = frameworkElement2;
				base.AddLogicalChild(this._labelPresenter);
				base.AddVisualChild(this._labelPresenter);
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00012008 File Offset: 0x00010208
		private void VerifyLayoutVersion()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._cachedField.Owner;
			if (owner != null)
			{
				int internalVersion = owner.InternalVersion;
				if (internalVersion != this._layoutVersion)
				{
					this._layoutVersion = internalVersion;
					this.ReleaseCellValuePresenter(false);
					this.ReleaseLabelPresenter(false);
				}
			}
		}

		// Token: 0x04000157 RID: 343
		private global::System.Windows.FrameworkElement _cellValuePresenter;

		// Token: 0x04000158 RID: 344
		private global::System.Windows.FrameworkElement _labelPresenter;

		// Token: 0x04000159 RID: 345
		private global::Infragistics.Windows.DataPresenter.Field _cachedField;

		// Token: 0x0400015A RID: 346
		private global::Infragistics.Windows.DataPresenter.Record _cachedRecord;

		// Token: 0x0400015B RID: 347
		private int _layoutVersion;

		// Token: 0x0400015C RID: 348
		private bool _isMeasuring;

		// Token: 0x0400015D RID: 349
		private global::System.Windows.Rect _measureCellRect;

		// Token: 0x0400015E RID: 350
		private global::System.Windows.Rect _measureLabelRect;

		// Token: 0x0400015F RID: 351
		private global::Infragistics.Windows.DataPresenter.CellPresenterBase _cellPresenter;

		// Token: 0x04000160 RID: 352
		private static global::System.Windows.DependencyProperty WindowServiceProperty;

		// Token: 0x04000161 RID: 353
		private static readonly global::System.Windows.DependencyProperty GridColumnWidthVersionProperty = global::Infragistics.Windows.DataPresenter.FieldLayout.GridColumnWidthVersionProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase.OnGridColumnWidthVersionChanged)));
	}
}
