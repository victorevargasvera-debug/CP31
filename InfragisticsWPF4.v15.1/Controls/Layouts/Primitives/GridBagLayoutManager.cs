using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x02000053 RID: 83
	public class GridBagLayoutManager : global::Infragistics.Controls.Layouts.Primitives.LayoutManagerBase
	{
		// Token: 0x0600033F RID: 831 RVA: 0x0000CB08 File Offset: 0x0000AD08
		public override global::System.Windows.Size CalculateMaximumSize(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutCache gridBagLayoutCache = this.GetGridBagLayoutCache();
			return global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GetTotalSize(gridBagLayoutCache._colWidthsMax, gridBagLayoutCache._rowHeightsMax);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000CB30 File Offset: 0x0000AD30
		public override global::System.Windows.Size CalculateMinimumSize(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutCache gridBagLayoutCache = this.GetGridBagLayoutCache();
			return global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GetTotalSize(gridBagLayoutCache._colWidthsMin, gridBagLayoutCache._rowHeightsMin);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000CB58 File Offset: 0x0000AD58
		public override global::System.Windows.Size CalculatePreferredSize(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutCache gridBagLayoutCache = this.GetGridBagLayoutCache();
			return global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GetTotalSize(gridBagLayoutCache._colWidthsPref, gridBagLayoutCache._rowHeightsPref);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000CB80 File Offset: 0x0000AD80
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager Clone(bool copyLayoutItems)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutManager = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager();
			gridBagLayoutManager._expandToFitHeight = this._expandToFitHeight;
			gridBagLayoutManager._expandToFitWidth = this._expandToFitWidth;
			gridBagLayoutManager._gridBagMode = this._gridBagMode;
			gridBagLayoutManager._includeMarginInPositionRect = this._includeMarginInPositionRect;
			gridBagLayoutManager._preferredSizeIncludesMargin = this._preferredSizeIncludesMargin;
			gridBagLayoutManager._interItemSpacingHorizontal = this._interItemSpacingHorizontal;
			gridBagLayoutManager._interItemSpacingVertical = this._interItemSpacingVertical;
			gridBagLayoutManager._horizontalContentAlignment = this._horizontalContentAlignment;
			gridBagLayoutManager._verticalContentAlignment = this._verticalContentAlignment;
			gridBagLayoutManager._shrinkToFitHeight = this._shrinkToFitHeight;
			gridBagLayoutManager._shrinkToFitWidth = this._shrinkToFitWidth;
			if (copyLayoutItems)
			{
				global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection layoutItems = base.LayoutItems;
				foreach (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)layoutItems))
				{
					gridBagLayoutManager.LayoutItems.Add(item, layoutItems.GetConstraint(item));
				}
			}
			return gridBagLayoutManager;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000CC6C File Offset: 0x0000AE6C
		public override void InvalidateLayout()
		{
			this._gridBagLayoutCache = null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000CC78 File Offset: 0x0000AE78
		public override void LayoutContainer(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext)
		{
			object obj = null;
			this.GridBagHelper(container, containerContext, true, false, ref obj);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000CC94 File Offset: 0x0000AE94
		public void LayoutContainer(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext, out global::System.Windows.Rect layoutRect)
		{
			object value = global::System.DBNull.Value;
			this.GridBagHelper(container, containerContext, true, false, ref value);
			layoutRect = (global::System.Windows.Rect)value;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		protected override void ValidateConstraintObject(object constraint)
		{
			if (!(constraint is global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint))
			{
				throw new global::System.ArgumentException(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GetString("LE_GridBag_InvalidConstraint"), "constraint");
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000CCE0 File Offset: 0x0000AEE0
		public global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection CalculateAutoLayout(global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> items, global::System.Windows.Controls.Orientation layoutOrientation, bool autoFitAllItems, global::System.Windows.Size constraint, int minRows, int minColumns, int maxRows, int maxColumns, global::System.Windows.Controls.Orientation? constraintedOrientation)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc autoLayoutCalc = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc(this, layoutOrientation, autoFitAllItems, constraint, minRows, minColumns, maxRows, maxColumns, constraintedOrientation);
			return autoLayoutCalc.AutoCalculateLayout(items);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000CD0C File Offset: 0x0000AF0C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection GetLayoutItemDimensions(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext)
		{
			object obj = null;
			return this.GridBagHelper(container, containerContext, false, true, ref obj);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000CD28 File Offset: 0x0000AF28
		public void GetResizeRange(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer layoutContainer, object containerContext, global::Infragistics.Controls.Layouts.Primitives.ILayoutItem resizeItem, out double maxDeltaLeft, out double maxDeltaRight, out double maxDeltaTop, out double maxDeltaBottom)
		{
			this.GetResizeRange(layoutContainer, containerContext, resizeItem, out maxDeltaLeft, out maxDeltaRight, out maxDeltaTop, out maxDeltaBottom, false, false, null);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		public void GetResizeRange(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer layoutContainer, object containerContext, global::Infragistics.Controls.Layouts.Primitives.ILayoutItem resizeItem, out double maxDeltaLeft, out double maxDeltaRight, out double maxDeltaTop, out double maxDeltaBottom, bool autoFitWidth, bool autoFitHeight, global::System.Collections.Generic.IList<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> synchronizedItems)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager resizeManager = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager(this, layoutContainer, containerContext, autoFitWidth, autoFitHeight);
			resizeManager.GetResizeRange(resizeItem, out maxDeltaLeft, out maxDeltaRight, out maxDeltaTop, out maxDeltaBottom, synchronizedItems);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000CD78 File Offset: 0x0000AF78
		public global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> PerformAutoSize(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer layoutContainer, object containerContext, global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> preferredSizes, bool autoFitWidth, bool autoFitHeight, out global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> newIsWidthAutoState, out global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> newIsHeightAutoState)
		{
			return this.PerformAutoSize(layoutContainer, containerContext, preferredSizes, autoFitWidth, autoFitHeight, out newIsWidthAutoState, out newIsHeightAutoState, true, true);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000CD98 File Offset: 0x0000AF98
		internal global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> PerformAutoSize(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer layoutContainer, object containerContext, global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> preferredSizes, bool autoFitWidth, bool autoFitHeight, out global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> newIsWidthAutoState, out global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> newIsHeightAutoState, bool xDimension, bool yDimension)
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> dictionary;
			newIsHeightAutoState = (dictionary = null);
			newIsWidthAutoState = dictionary;
			if (preferredSizes == null || preferredSizes.Count == 0)
			{
				return new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size>();
			}
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager resizeManager = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager(this, layoutContainer, containerContext, autoFitWidth, autoFitHeight);
			resizeManager._isAutoSizing = true;
			resizeManager.ResizeItems(preferredSizes);
			return resizeManager.GetNewPreferredSizes(out newIsWidthAutoState, out newIsHeightAutoState, xDimension, yDimension);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000CDEC File Offset: 0x0000AFEC
		public global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> ResizeItem(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer layoutContainer, object containerContext, global::Infragistics.Controls.Layouts.Primitives.ILayoutItem resizeItem, double deltaWidth, double deltaHeight, bool autoFitWidth, bool autoFitHeight)
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> dictionary;
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> dictionary2;
			return this.ResizeItem(layoutContainer, containerContext, resizeItem, deltaWidth, deltaHeight, autoFitWidth, autoFitHeight, null, out dictionary, out dictionary2);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000CE10 File Offset: 0x0000B010
		public global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> ResizeItem(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer layoutContainer, object containerContext, global::Infragistics.Controls.Layouts.Primitives.ILayoutItem resizeItem, double deltaWidth, double deltaHeight, bool autoFitWidth, bool autoFitHeight, global::System.Collections.Generic.IList<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> synchronizedItems, out global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> newIsWidthAutoState, out global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> newIsHeightAutoState)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager manager = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager(this, layoutContainer, containerContext, autoFitWidth, autoFitHeight);
			return this.ResizeItemHelper(manager, resizeItem, deltaWidth, deltaHeight, synchronizedItems, out newIsWidthAutoState, out newIsHeightAutoState);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000CE3C File Offset: 0x0000B03C
		private global::System.Windows.Rect ApplyAlignments(double x, double y, double width, double height, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gcc)
		{
			double num = gcc._prefWidth;
			double num2 = gcc._prefHeight;
			double num3 = gcc._maxWidth;
			double num4 = gcc._maxHeight;
			global::System.Windows.Thickness margin = gcc._margin;
			double num5 = margin.Left + margin.Right;
			double num6 = margin.Top + margin.Bottom;
			if (this._includeMarginInPositionRect)
			{
				if (!this._preferredSizeIncludesMargin)
				{
					num += num5;
					num2 += num6;
				}
				num3 += num5;
				num4 += num6;
			}
			else
			{
				if (this._preferredSizeIncludesMargin)
				{
					num -= num5;
					num2 -= num6;
				}
				x += margin.Left;
				width -= num5;
				y += margin.Top;
				height -= num6;
			}
			if (gcc._hasSpacing != global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.None)
			{
				global::System.Windows.Thickness spacing = gcc.GetSpacing(this);
				x += spacing.Left;
				width -= spacing.Left + spacing.Right;
				y += spacing.Top;
				height -= spacing.Top + spacing.Bottom;
			}
			if (num > width)
			{
				num = width;
			}
			if (num2 > height)
			{
				num2 = height;
			}
			global::System.Windows.HorizontalAlignment horizontalAlignment = gcc._gc.HorizontalAlignment;
			global::System.Windows.VerticalAlignment verticalAlignment = gcc._gc.VerticalAlignment;
			switch (horizontalAlignment)
			{
			case global::System.Windows.HorizontalAlignment.Left:
				goto IL_160;
			case global::System.Windows.HorizontalAlignment.Right:
				x += width - num;
				goto IL_160;
			}
			if (global::System.Windows.HorizontalAlignment.Stretch == horizontalAlignment)
			{
				num = global::System.Math.Min(width, num3);
			}
			x += (width - num) / 2.0;
			IL_160:
			switch (verticalAlignment)
			{
			case global::System.Windows.VerticalAlignment.Top:
				goto IL_1A3;
			case global::System.Windows.VerticalAlignment.Bottom:
				y += height - num2;
				goto IL_1A3;
			}
			if (global::System.Windows.VerticalAlignment.Stretch == verticalAlignment)
			{
				num2 = global::System.Math.Min(height, num4);
			}
			y += (height - num2) / 2.0;
			IL_1A3:
			return new global::System.Windows.Rect(x, y, global::System.Math.Max(num, 0.0), global::System.Math.Max(num2, 0.0));
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000D011 File Offset: 0x0000B211
		private static void ArrInit(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IntExpandableArray arr, int val)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrInit(arr, val, 0, arr.Length);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000D024 File Offset: 0x0000B224
		private static void ArrInit(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IntExpandableArray arr, int val, int startIndex, int len)
		{
			for (int i = 0; i < len; i++)
			{
				arr[startIndex + i] = val;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000D048 File Offset: 0x0000B248
		private static void ArrInitIndeces(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = i;
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000D068 File Offset: 0x0000B268
		private static int ArrMax(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IntExpandableArray arr, int startIndex, int len)
		{
			int num = arr[startIndex];
			for (int i = 1; i < len; i++)
			{
				num = global::System.Math.Max(num, arr[startIndex + i]);
			}
			return num;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000D09C File Offset: 0x0000B29C
		private static void ArrSet<T>(T[] arr, T value, int startIndex, int count)
		{
			for (int i = 0; i < count; i++)
			{
				arr[startIndex + i] = value;
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000D0C0 File Offset: 0x0000B2C0
		private static float ArrSum(float[] arr, int startIndex, int len)
		{
			float num = 0f;
			for (int i = 0; i < len; i++)
			{
				num += arr[startIndex + i];
			}
			return num;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000D0E8 File Offset: 0x0000B2E8
		private static double ArrSum(double[] arr)
		{
			return global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSum(arr, 0, arr.Length);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000D0F4 File Offset: 0x0000B2F4
		private static double ArrSum_SkipItems(double[] arr, bool[] skipItems)
		{
			double num = 0.0;
			int i = 0;
			int num2 = arr.Length;
			while (i < num2)
			{
				if (!skipItems[i])
				{
					num += arr[i];
				}
				i++;
			}
			return num;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000D128 File Offset: 0x0000B328
		private static double ArrSum(double[] arr, int startIndex, int len)
		{
			double num = 0.0;
			for (int i = 0; i < len; i++)
			{
				num += arr[startIndex + i];
			}
			return num;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000D154 File Offset: 0x0000B354
		private static double[] CalculateCoordinatesHelper(double[] extents, double[] minExtents, double[] maxExtents, float[] weightsFloat, bool[] isAuto, double containerExtent, bool expandToFit, bool? shrinkToFit, out double[] calculatedExtents)
		{
			double[] array = new double[extents.Length];
			extents.CopyTo(array, 0);
			double[] array2 = null;
			double num = containerExtent - global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSum(array);
			int num2 = (isAuto != null) ? 3 : 2;
			int num3 = 0;
			while (num3 < num2 && !global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IsCloseToZero(num))
			{
				if (num3 != 0)
				{
					goto IL_6E;
				}
				float num4 = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSum(weightsFloat, 0, weightsFloat.Length);
				if (0f != num4)
				{
					array2 = new double[extents.Length];
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i] = (double)weightsFloat[i];
					}
					goto IL_6E;
				}
				IL_195:
				num3++;
				continue;
				IL_6E:
				if (num3 > 0)
				{
					bool flag = (num < 0.0) ? ((shrinkToFit != null) ? shrinkToFit.Value : expandToFit) : expandToFit;
					if (!flag)
					{
						goto IL_195;
					}
					if (array2 == null)
					{
						array2 = new double[extents.Length];
					}
					for (int j = 0; j < array2.Length; j++)
					{
						array2[j] = (((isAuto != null && isAuto[j]) ^ 1 == num3) ? extents[j] : 0.0);
					}
				}
				while (!global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IsCloseToZero(num) && array2 != null && global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.NormalizeRatios(array2))
				{
					int num5 = 0;
					for (int k = 0; k < array2.Length; k++)
					{
						double num6 = array2[k] * num;
						if (0.0 != num6)
						{
							double num7 = array[k] + num6;
							double num8 = global::System.Math.Max(num7, minExtents[k]);
							double num9 = maxExtents[k];
							if (0.0 != num9)
							{
								num8 = global::System.Math.Min(num8, num9);
							}
							array[k] = num8;
							if (num8 != num7)
							{
								array2[k] = 0.0;
								num5++;
							}
						}
					}
					num = containerExtent - global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSum(array);
					if (num5 == 0 || num5 == array2.Length)
					{
						break;
					}
				}
				goto IL_195;
			}
			calculatedExtents = array;
			double[] array3 = new double[array.Length + 1];
			array.CopyTo(array3, 0);
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ConvertToCoordinates(array3);
			return array3;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000D330 File Offset: 0x0000B530
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutCache CalculateGridBagLayout()
		{
			int num = 0;
			int num2 = 0;
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache[] tempArray = null;
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache[] gridBagCacheHelper = this.GetGridBagCacheHelper(out tempArray);
			this.ResolveOrigins(gridBagCacheHelper, out num, out num2);
			float[] array = new float[num];
			float[] array2 = new float[num2];
			double[] array3 = new double[num];
			double[] array4 = new double[num2];
			double[] array5 = new double[num];
			double[] array6 = new double[num2];
			double[] array7 = new double[num];
			double[] array8 = new double[num2];
			bool[] array9 = null;
			bool[] array10 = null;
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache[] gccArr = (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache[])gridBagCacheHelper.Clone();
			global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache>(gridBagCacheHelper, tempArray, new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.LayoutItemComparer(this, false));
			foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gridBagConstraintCache in gridBagCacheHelper)
			{
				if (gridBagConstraintCache._isAutoWidth)
				{
					if (array9 == null)
					{
						array9 = new bool[num2];
					}
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSet<bool>(array9, true, gridBagConstraintCache._column, gridBagConstraintCache._columnSpan);
				}
				if (gridBagConstraintCache._isAutoHeight)
				{
					if (array10 == null)
					{
						array10 = new bool[num];
					}
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSet<bool>(array10, true, gridBagConstraintCache._row, gridBagConstraintCache._rowSpan);
				}
			}
			this.CalculateInterItemSpacing(gridBagCacheHelper, array4, array3);
			foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gridBagConstraintCache2 in gridBagCacheHelper)
			{
				this.ResolveWeightsHelper(array2, gridBagConstraintCache2._column, gridBagConstraintCache2._columnSpan, gridBagConstraintCache2._columnWeight);
			}
			for (int j = 0; j < 3; j++)
			{
				double[] extents = (j == 0) ? array6 : ((1 == j) ? array8 : array4);
				foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gridBagConstraintCache3 in gridBagCacheHelper)
				{
					double num3 = (j == 0) ? ((!gridBagConstraintCache3._isAutoWidth) ? gridBagConstraintCache3._minWidth : gridBagConstraintCache3._prefWidth) : ((1 == j) ? gridBagConstraintCache3._maxWidth : gridBagConstraintCache3._prefWidth);
					if (2 != j || !this._preferredSizeIncludesMargin)
					{
						num3 += gridBagConstraintCache3._margin.Left + gridBagConstraintCache3._margin.Right;
					}
					if (((global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.Left | global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.Right) & gridBagConstraintCache3._hasSpacing) != global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.None)
					{
						global::System.Windows.Thickness spacing = gridBagConstraintCache3.GetSpacing(this);
						num3 += spacing.Left + spacing.Right;
					}
					this.ResolveExtentsHelper(extents, array2, gridBagConstraintCache3._column, gridBagConstraintCache3._columnSpan, num3);
				}
			}
			global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache>(gridBagCacheHelper, tempArray, new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.LayoutItemComparer(this, true));
			foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gridBagConstraintCache4 in gridBagCacheHelper)
			{
				this.ResolveWeightsHelper(array, gridBagConstraintCache4._row, gridBagConstraintCache4._rowSpan, gridBagConstraintCache4._rowWeight);
			}
			for (int j = 0; j < 3; j++)
			{
				double[] extents2 = (j == 0) ? array5 : ((1 == j) ? array7 : array3);
				foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gridBagConstraintCache5 in gridBagCacheHelper)
				{
					double num4 = (j == 0) ? ((!gridBagConstraintCache5._isAutoHeight) ? gridBagConstraintCache5._minHeight : gridBagConstraintCache5._prefHeight) : ((1 == j) ? gridBagConstraintCache5._maxHeight : gridBagConstraintCache5._prefHeight);
					if (2 != j || !this._preferredSizeIncludesMargin)
					{
						num4 += gridBagConstraintCache5._margin.Top + gridBagConstraintCache5._margin.Bottom;
					}
					if (((global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.Top | global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.Bottom) & gridBagConstraintCache5._hasSpacing) != global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.None)
					{
						global::System.Windows.Thickness spacing2 = gridBagConstraintCache5.GetSpacing(this);
						num4 += spacing2.Top + spacing2.Bottom;
					}
					this.ResolveExtentsHelper(extents2, array, gridBagConstraintCache5._row, gridBagConstraintCache5._rowSpan, num4);
				}
			}
			return new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutCache(gccArr, array2, array, array4, array3, array6, array5, array8, array7, array9, array10);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000D688 File Offset: 0x0000B888
		private void CalculateInterItemSpacing(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache[] gccArr, double[] colWidthsPref, double[] rowHeightsPref)
		{
			if (this.HasInterItemSpacingHorizontal || this.HasInterItemSpacingVertical)
			{
				double interItemSpacingHorizontal = this.InterItemSpacingHorizontal;
				double interItemSpacingVertical = this.InterItemSpacingVertical;
				foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gridBagConstraintCache in gccArr)
				{
					if (gridBagConstraintCache._column > 0)
					{
						gridBagConstraintCache._hasSpacing |= global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.Left;
					}
					if (gridBagConstraintCache._column + gridBagConstraintCache._columnSpan < colWidthsPref.Length)
					{
						gridBagConstraintCache._hasSpacing |= global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.Right;
					}
					if (gridBagConstraintCache._row > 0)
					{
						gridBagConstraintCache._hasSpacing |= global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.Top;
					}
					if (gridBagConstraintCache._row + gridBagConstraintCache._rowSpan < rowHeightsPref.Length)
					{
						gridBagConstraintCache._hasSpacing |= global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.Bottom;
					}
				}
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000D738 File Offset: 0x0000B938
		private static void ConvertToCoordinates(double[] arr)
		{
			double num = 0.0;
			for (int i = 0; i < arr.Length; i++)
			{
				double num2 = num + arr[i];
				arr[i] = num;
				num = num2;
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000D76C File Offset: 0x0000B96C
		private void GetContentOffset(global::System.Windows.Rect containerRect, out double offsetX, out double offsetY, double[] colCoordinates, double[] rowCoordinates)
		{
			offsetX = containerRect.X;
			offsetY = containerRect.Y;
			double num = containerRect.Width - (colCoordinates[colCoordinates.Length - 1] - colCoordinates[0]);
			double num2 = containerRect.Height - (rowCoordinates[rowCoordinates.Length - 1] - rowCoordinates[0]);
			if (num > 0.0)
			{
				switch (this._horizontalContentAlignment)
				{
				case global::System.Windows.HorizontalAlignment.Center:
					offsetX += num / 2.0;
					break;
				case global::System.Windows.HorizontalAlignment.Right:
					offsetX += num;
					break;
				}
			}
			if (num2 > 0.0)
			{
				switch (this._verticalContentAlignment)
				{
				case global::System.Windows.VerticalAlignment.Center:
					offsetY += num2 / 2.0;
					break;
				case global::System.Windows.VerticalAlignment.Bottom:
					offsetY += num2;
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000D834 File Offset: 0x0000BA34
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache[] GetGridBagCacheHelper(out global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache[] tmpGccArr)
		{
			global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection layoutItems = base.LayoutItems;
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache[] array = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache[layoutItems.Count];
			int num = 0;
			int i = 0;
			int count = layoutItems.Count;
			while (i < count)
			{
				global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem = layoutItems[i];
				global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gc = (global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)layoutItems.GetConstraint(layoutItem);
				if (global::System.Windows.Visibility.Collapsed != layoutItem.Visibility)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gridBagConstraintCache = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache(layoutItem, gc);
					if ((gridBagConstraintCache._gcColumn >= 0 || -1 == gridBagConstraintCache._gcColumn) && (gridBagConstraintCache._gcRow >= 0 || -1 == gridBagConstraintCache._gcRow) && (gridBagConstraintCache._gcColumnSpan >= 1 || -1 == gridBagConstraintCache._gcColumnSpan || gridBagConstraintCache._gcColumnSpan == 0) && (gridBagConstraintCache._gcRowSpan >= 1 || -1 == gridBagConstraintCache._gcRowSpan || gridBagConstraintCache._gcRowSpan == 0))
					{
						array[num++] = gridBagConstraintCache;
					}
				}
				i++;
			}
			tmpGccArr = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache[num];
			if (num != array.Length)
			{
				global::System.Array.Copy(array, tmpGccArr, num);
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache[] array2 = array;
				array = tmpGccArr;
				tmpGccArr = array2;
			}
			return array;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000D92B File Offset: 0x0000BB2B
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutCache GetGridBagLayoutCache()
		{
			if (this._gridBagLayoutCache == null)
			{
				this._gridBagLayoutCache = this.CalculateGridBagLayout();
			}
			return this._gridBagLayoutCache;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000D947 File Offset: 0x0000BB47
		private static global::System.Windows.Size GetTotalSize(double[] widths, double[] heights)
		{
			return new global::System.Windows.Size(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSum(widths), global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSum(heights));
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000D95C File Offset: 0x0000BB5C
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection GridBagHelper(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext, bool layoutContainer, bool returnItemDimensions, ref object layoutRect)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutCache gridBagLayoutCache = this.GetGridBagLayoutCache();
			global::System.Windows.Rect containerBoundsHelper = global::Infragistics.Controls.Layouts.Primitives.LayoutManagerBase.GetContainerBoundsHelper(container, containerContext, this);
			double[] array = gridBagLayoutCache._colCoordinates;
			double[] array2 = gridBagLayoutCache._rowCoordinates;
			double[] colCoordinateExtents = gridBagLayoutCache._colCoordinateExtents;
			double[] rowCoordinateExtents = gridBagLayoutCache._rowCoordinateExtents;
			bool flag = array != null && array2 != null && array.Length == 1 + gridBagLayoutCache._colWidthsPref.Length && array2.Length == 1 + gridBagLayoutCache._rowHeightsPref.Length;
			if (!flag || containerBoundsHelper.Width != gridBagLayoutCache._lastContainerWidth)
			{
				array = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.CalculateCoordinatesHelper(gridBagLayoutCache._colWidthsPref, gridBagLayoutCache._colWidthsMin, gridBagLayoutCache._colWidthsMax, gridBagLayoutCache._colWeights, gridBagLayoutCache._colIsAuto, containerBoundsHelper.Width, this.ExpandToFitWidth, this.ShrinkToFitWidth, out colCoordinateExtents);
				gridBagLayoutCache._colCoordinateExtents = colCoordinateExtents;
				gridBagLayoutCache._lastContainerWidth = containerBoundsHelper.Width;
				gridBagLayoutCache._colCoordinates = array;
			}
			if (!flag || containerBoundsHelper.Height != gridBagLayoutCache._lastContainerHeight)
			{
				array2 = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.CalculateCoordinatesHelper(gridBagLayoutCache._rowHeightsPref, gridBagLayoutCache._rowHeightsMin, gridBagLayoutCache._rowHeightsMax, gridBagLayoutCache._rowWeights, gridBagLayoutCache._rowIsAuto, containerBoundsHelper.Height, this.ExpandToFitHeight, this.ShrinkToFitHeight, out rowCoordinateExtents);
				gridBagLayoutCache._rowCoordinateExtents = rowCoordinateExtents;
				gridBagLayoutCache._lastContainerHeight = containerBoundsHelper.Height;
				gridBagLayoutCache._rowCoordinates = array2;
			}
			double num;
			double num2;
			this.GetContentOffset(containerBoundsHelper, out num, out num2, array, array2);
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection gridBagLayoutItemDimensionsCollection = null;
			if (returnItemDimensions)
			{
				gridBagLayoutItemDimensionsCollection = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection((double[])array.Clone(), (double[])array2.Clone());
				gridBagLayoutItemDimensionsCollection.InitializeLayoutSizes(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GetTotalSize(gridBagLayoutCache._colWidthsPref, gridBagLayoutCache._rowHeightsPref), global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GetTotalSize(gridBagLayoutCache._colWidthsMin, gridBagLayoutCache._rowHeightsMin), global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GetTotalSize(gridBagLayoutCache._colWidthsMax, gridBagLayoutCache._rowHeightsMax));
				this.OffsetEachElem(gridBagLayoutItemDimensionsCollection.ColumnDims, num - containerBoundsHelper.X);
				this.OffsetEachElem(gridBagLayoutItemDimensionsCollection.RowDims, num2 - containerBoundsHelper.Y);
			}
			if (layoutRect != null)
			{
				layoutRect = new global::System.Windows.Rect(array[0] + num, array2[0] + num2, array[array.Length - 1] - array[0], array2[array2.Length - 1] - array2[0]);
			}
			foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gridBagConstraintCache in gridBagLayoutCache._gccArr)
			{
				double num3 = array[gridBagConstraintCache._column];
				double num4 = array2[gridBagConstraintCache._row];
				double width = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSum(colCoordinateExtents, gridBagConstraintCache._column, gridBagConstraintCache._columnSpan);
				double height = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSum(rowCoordinateExtents, gridBagConstraintCache._row, gridBagConstraintCache._rowSpan);
				num3 += num;
				num4 += num2;
				global::System.Windows.Rect rect = this.ApplyAlignments(num3, num4, width, height, gridBagConstraintCache);
				if (gridBagLayoutItemDimensionsCollection != null)
				{
					gridBagLayoutItemDimensionsCollection.Add(gridBagConstraintCache._item, new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions(gridBagConstraintCache._column, gridBagConstraintCache._row, gridBagConstraintCache._columnSpan, gridBagConstraintCache._rowSpan, rect));
				}
				if (layoutContainer)
				{
					container.PositionItem(gridBagConstraintCache._item, rect, containerContext);
				}
			}
			return gridBagLayoutItemDimensionsCollection;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000DC3D File Offset: 0x0000BE3D
		private static bool IsCloseToZero(double d)
		{
			return global::Infragistics.CoreUtilities.AreClose(d, 0.0);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000DC50 File Offset: 0x0000BE50
		private static bool NormalizeRatios(double[] ratios)
		{
			double num = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSum(ratios);
			if (!global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IsCloseToZero(num))
			{
				if (num != 1.0)
				{
					for (int i = 0; i < ratios.Length; i++)
					{
						ratios[i] /= num;
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000DCA0 File Offset: 0x0000BEA0
		private void OffsetEachElem(double[] arr, double offset)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] += offset;
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000DCCF File Offset: 0x0000BECF
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> ResizeItemHelper(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager manager, global::Infragistics.Controls.Layouts.Primitives.ILayoutItem resizeItem, double deltaWidth, double deltaHeight, global::System.Collections.Generic.IList<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> synchronizedItems, out global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> newIsWidthAutoState, out global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> newIsHeightAutoState)
		{
			manager.ResizeItem(resizeItem, deltaWidth, deltaHeight, synchronizedItems);
			return manager.GetNewPreferredSizes(out newIsWidthAutoState, out newIsHeightAutoState, 0.0 != deltaWidth, 0.0 != deltaHeight);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000DD08 File Offset: 0x0000BF08
		private void ResolveExtentsHelper(double[] extents, float[] weights, int origin, int span, double layoutItemExtent)
		{
			double num = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSum(extents, origin, span);
			if (num < layoutItemExtent)
			{
				double num2 = layoutItemExtent - num;
				double num3 = 0.0;
				float num4 = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSum(weights, origin, span);
				if (num4 > 0f)
				{
					for (int i = origin; i < origin + span; i++)
					{
						extents[i] += (double)((int)(num2 * (double)weights[i] / (double)num4));
						num3 += extents[i];
					}
				}
				else
				{
					num3 = num;
				}
				if (num3 < layoutItemExtent)
				{
					if (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutMode.Uniform == this._gridBagMode)
					{
						num2 = layoutItemExtent - num3;
						for (int j = 0; j < span; j++)
						{
							extents[origin + j] += num2 / (double)span;
						}
						return;
					}
					extents[origin + span - 1] += layoutItemExtent - num3;
				}
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
		private void ResolveOrigins(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache[] gccArr, out int rowCount, out int columnCount)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IntExpandableArray intExpandableArray = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IntExpandableArray(64);
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IntExpandableArray intExpandableArray2 = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IntExpandableArray(64);
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < 4; i++)
			{
				intExpandableArray.Reset();
				intExpandableArray2.Reset();
				int num3 = num2;
				int num4 = num;
				int num5 = 0;
				int num6 = 0;
				bool flag = false;
				foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gridBagConstraintCache in gccArr)
				{
					if (gridBagConstraintCache._gcColumn < 0 || gridBagConstraintCache._gcRow < 0 || gridBagConstraintCache._gcColumnSpan <= 0 || gridBagConstraintCache._gcRowSpan <= 0)
					{
						flag = true;
					}
					gridBagConstraintCache._column = gridBagConstraintCache._gcColumn;
					gridBagConstraintCache._row = gridBagConstraintCache._gcRow;
					gridBagConstraintCache._columnSpan = gridBagConstraintCache._gcColumnSpan;
					gridBagConstraintCache._rowSpan = gridBagConstraintCache._gcRowSpan;
					if (gridBagConstraintCache._column < 0 && gridBagConstraintCache._row < 0)
					{
						if (num5 >= 0)
						{
							gridBagConstraintCache._row = num5;
						}
						else if (num6 >= 0)
						{
							gridBagConstraintCache._column = num6;
						}
					}
					if (gridBagConstraintCache._column < 0)
					{
						if (gridBagConstraintCache._gcRowSpan <= 0)
						{
							gridBagConstraintCache._rowSpan = global::System.Math.Max(1, num - gridBagConstraintCache._row - ((-1 == gridBagConstraintCache._gcRowSpan) ? 1 : 0));
						}
						gridBagConstraintCache._column = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrMax(intExpandableArray, gridBagConstraintCache._row, gridBagConstraintCache._rowSpan);
					}
					else if (gridBagConstraintCache._row < 0)
					{
						if (gridBagConstraintCache._gcColumnSpan <= 0)
						{
							gridBagConstraintCache._columnSpan = global::System.Math.Max(1, num2 - gridBagConstraintCache._column - ((-1 == gridBagConstraintCache._gcColumnSpan) ? 1 : 0));
						}
						gridBagConstraintCache._row = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrMax(intExpandableArray2, gridBagConstraintCache._column, gridBagConstraintCache._columnSpan);
					}
					if (gridBagConstraintCache._gcColumnSpan <= 0)
					{
						gridBagConstraintCache._columnSpan = global::System.Math.Max(1, num2 - gridBagConstraintCache._column - ((-1 == gridBagConstraintCache._gcColumnSpan) ? 1 : 0));
					}
					if (gridBagConstraintCache._gcRowSpan <= 0)
					{
						gridBagConstraintCache._rowSpan = global::System.Math.Max(1, num - gridBagConstraintCache._row - ((-1 == gridBagConstraintCache._gcRowSpan) ? 1 : 0));
					}
					num3 = global::System.Math.Max(num3, gridBagConstraintCache._column + gridBagConstraintCache._columnSpan);
					num4 = global::System.Math.Max(num4, gridBagConstraintCache._row + gridBagConstraintCache._rowSpan);
					if (i < 3)
					{
						num2 = num3;
						num = num4;
					}
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrInit(intExpandableArray, gridBagConstraintCache._column + gridBagConstraintCache._columnSpan, gridBagConstraintCache._row, gridBagConstraintCache._rowSpan);
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrInit(intExpandableArray2, gridBagConstraintCache._row + gridBagConstraintCache._rowSpan, gridBagConstraintCache._column, gridBagConstraintCache._columnSpan);
					if (gridBagConstraintCache._gcColumnSpan == 0 && gridBagConstraintCache._gcRowSpan == 0)
					{
						num5 = gridBagConstraintCache._row;
					}
					else if (gridBagConstraintCache._gcColumnSpan == 0)
					{
						num5 = gridBagConstraintCache._row + gridBagConstraintCache._rowSpan;
					}
					else if (gridBagConstraintCache._gcRowSpan == 0)
					{
						num6 = gridBagConstraintCache._column + gridBagConstraintCache._columnSpan;
						num5 = -1;
					}
				}
				num = num4;
				num2 = num3;
				if (!flag)
				{
					break;
				}
			}
			rowCount = num;
			columnCount = num2;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000E0D8 File Offset: 0x0000C2D8
		private void ResolveWeightsHelper(float[] weights, int origin, int span, float layoutItemWeight)
		{
			float num = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSum(weights, origin, span);
			if (num < layoutItemWeight)
			{
				float num2 = layoutItemWeight - num;
				float num3 = 0f;
				if (num > 0f)
				{
					for (int i = origin; i < origin + span; i++)
					{
						weights[i] += weights[i] * num2 / num;
						num3 += weights[i];
					}
				}
				if (num3 < layoutItemWeight)
				{
					weights[origin + span - 1] += layoutItemWeight - num3;
				}
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000E154 File Offset: 0x0000C354
		internal static string GetString(string name)
		{
			return global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GetString(name, null);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000E15D File Offset: 0x0000C35D
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0000E168 File Offset: 0x0000C368
		public float[] ColumnWeights
		{
			get
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutCache gridBagLayoutCache = this.GetGridBagLayoutCache();
				if (gridBagLayoutCache != null)
				{
					return gridBagLayoutCache._colWeights;
				}
				return null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000E188 File Offset: 0x0000C388
		public double[] ColumnWidths
		{
			get
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutCache gridBagLayoutCache = this.GetGridBagLayoutCache();
				if (gridBagLayoutCache != null)
				{
					return gridBagLayoutCache._colWidthsPref;
				}
				return null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000E1A7 File Offset: 0x0000C3A7
		// (set) Token: 0x0600036E RID: 878 RVA: 0x0000E1AF File Offset: 0x0000C3AF
		public bool ExpandToFitHeight
		{
			get
			{
				return this._expandToFitHeight;
			}
			set
			{
				this._expandToFitHeight = value;
				this.InvalidateLayout();
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0000E1BE File Offset: 0x0000C3BE
		// (set) Token: 0x06000370 RID: 880 RVA: 0x0000E1C6 File Offset: 0x0000C3C6
		public bool ExpandToFitWidth
		{
			get
			{
				return this._expandToFitWidth;
			}
			set
			{
				this._expandToFitWidth = value;
				this.InvalidateLayout();
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0000E1D5 File Offset: 0x0000C3D5
		// (set) Token: 0x06000372 RID: 882 RVA: 0x0000E1E0 File Offset: 0x0000C3E0
		public bool? ShrinkToFitHeight
		{
			get
			{
				return this._shrinkToFitHeight;
			}
			set
			{
				if (value != this._shrinkToFitHeight)
				{
					this._shrinkToFitHeight = value;
					this.InvalidateLayout();
				}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000373 RID: 883 RVA: 0x0000E22B File Offset: 0x0000C42B
		// (set) Token: 0x06000374 RID: 884 RVA: 0x0000E234 File Offset: 0x0000C434
		public bool? ShrinkToFitWidth
		{
			get
			{
				return this._shrinkToFitWidth;
			}
			set
			{
				if (value != this._shrinkToFitWidth)
				{
					this._shrinkToFitWidth = value;
					this.InvalidateLayout();
				}
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0000E27F File Offset: 0x0000C47F
		// (set) Token: 0x06000376 RID: 886 RVA: 0x0000E287 File Offset: 0x0000C487
		public global::System.Windows.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return this._horizontalContentAlignment;
			}
			set
			{
				if (this._horizontalContentAlignment != value)
				{
					this._horizontalContentAlignment = value;
					this.InvalidateLayout();
				}
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0000E29F File Offset: 0x0000C49F
		// (set) Token: 0x06000378 RID: 888 RVA: 0x0000E2A7 File Offset: 0x0000C4A7
		public global::System.Windows.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return this._verticalContentAlignment;
			}
			set
			{
				if (this._verticalContentAlignment != value)
				{
					this._verticalContentAlignment = value;
					this.InvalidateLayout();
				}
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0000E2BF File Offset: 0x0000C4BF
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0000E2C7 File Offset: 0x0000C4C7
		public bool IncludeMarginInPositionRect
		{
			get
			{
				return this._includeMarginInPositionRect;
			}
			set
			{
				if (this._includeMarginInPositionRect != value)
				{
					this._includeMarginInPositionRect = value;
					this.InvalidateLayout();
				}
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0000E2DF File Offset: 0x0000C4DF
		// (set) Token: 0x0600037C RID: 892 RVA: 0x0000E2E7 File Offset: 0x0000C4E7
		public double InterItemSpacingHorizontal
		{
			get
			{
				return this._interItemSpacingHorizontal;
			}
			set
			{
				if (this._interItemSpacingHorizontal != value)
				{
					this._interItemSpacingHorizontal = value;
					this.InvalidateLayout();
				}
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600037D RID: 893 RVA: 0x0000E2FF File Offset: 0x0000C4FF
		// (set) Token: 0x0600037E RID: 894 RVA: 0x0000E307 File Offset: 0x0000C507
		public double InterItemSpacingVertical
		{
			get
			{
				return this._interItemSpacingVertical;
			}
			set
			{
				if (this._interItemSpacingVertical != value)
				{
					this._interItemSpacingVertical = value;
					this.InvalidateLayout();
				}
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0000E31F File Offset: 0x0000C51F
		// (set) Token: 0x06000380 RID: 896 RVA: 0x0000E328 File Offset: 0x0000C528
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutMode LayoutMode
		{
			get
			{
				return this._gridBagMode;
			}
			set
			{
				if (this._gridBagMode != value)
				{
					if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutMode), value))
					{
						throw new global::System.ComponentModel.InvalidEnumArgumentException("LayoutMode", (int)value, typeof(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutMode));
					}
					this._gridBagMode = value;
					this.InvalidateLayout();
				}
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0000E378 File Offset: 0x0000C578
		// (set) Token: 0x06000382 RID: 898 RVA: 0x0000E380 File Offset: 0x0000C580
		public bool PreferredSizeIncludesMargin
		{
			get
			{
				return this._preferredSizeIncludesMargin;
			}
			set
			{
				if (this._preferredSizeIncludesMargin != value)
				{
					this._preferredSizeIncludesMargin = value;
					this.InvalidateLayout();
				}
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0000E398 File Offset: 0x0000C598
		public double[] RowHeights
		{
			get
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutCache gridBagLayoutCache = this.GetGridBagLayoutCache();
				if (gridBagLayoutCache != null)
				{
					return gridBagLayoutCache._rowHeightsPref;
				}
				return null;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		public float[] RowWeights
		{
			get
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutCache gridBagLayoutCache = this.GetGridBagLayoutCache();
				if (gridBagLayoutCache != null)
				{
					return gridBagLayoutCache._rowWeights;
				}
				return null;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0000E3D7 File Offset: 0x0000C5D7
		internal bool HasInterItemSpacingHorizontal
		{
			get
			{
				return !global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IsCloseToZero(this._interItemSpacingHorizontal);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000E3E7 File Offset: 0x0000C5E7
		internal bool HasInterItemSpacingVertical
		{
			get
			{
				return !global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IsCloseToZero(this._interItemSpacingVertical);
			}
		}

		// Token: 0x04000105 RID: 261
		private bool _expandToFitWidth;

		// Token: 0x04000106 RID: 262
		private bool _expandToFitHeight;

		// Token: 0x04000107 RID: 263
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutMode _gridBagMode;

		// Token: 0x04000108 RID: 264
		private bool _preferredSizeIncludesMargin;

		// Token: 0x04000109 RID: 265
		private bool _includeMarginInPositionRect;

		// Token: 0x0400010A RID: 266
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutCache _gridBagLayoutCache;

		// Token: 0x0400010B RID: 267
		private double _interItemSpacingHorizontal;

		// Token: 0x0400010C RID: 268
		private double _interItemSpacingVertical;

		// Token: 0x0400010D RID: 269
		private global::System.Windows.HorizontalAlignment _horizontalContentAlignment = global::System.Windows.HorizontalAlignment.Center;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.VerticalAlignment _verticalContentAlignment = global::System.Windows.VerticalAlignment.Center;

		// Token: 0x0400010F RID: 271
		private bool? _shrinkToFitWidth;

		// Token: 0x04000110 RID: 272
		private bool? _shrinkToFitHeight;

		// Token: 0x02000054 RID: 84
		internal class AutoLayoutCalc
		{
			// Token: 0x06000387 RID: 903 RVA: 0x0000E3F8 File Offset: 0x0000C5F8
			internal AutoLayoutCalc(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager lm, global::System.Windows.Controls.Orientation layoutOrientation, bool autoFitAllItems, global::System.Windows.Size layoutExtent, int minRows, int minColumns, int maxRows, int maxColumns, global::System.Windows.Controls.Orientation? constraintedOrientation)
			{
				this._lm = lm;
				this._layoutOrientation = layoutOrientation;
				this._autoFitAllItems = autoFitAllItems;
				this._constraintedOrientation = constraintedOrientation;
				if (layoutOrientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					this._layoutExtentX = layoutExtent.Width;
					this._layoutExtentY = layoutExtent.Height;
					this._minCellsX = minColumns;
					this._minCellsY = minRows;
					this._maxCellsX = maxColumns;
					this._maxCellsY = maxRows;
					return;
				}
				this._layoutExtentX = layoutExtent.Height;
				this._layoutExtentY = layoutExtent.Width;
				this._minCellsX = minRows;
				this._minCellsY = minColumns;
				this._maxCellsX = maxRows;
				this._maxCellsY = maxColumns;
			}

			// Token: 0x06000388 RID: 904 RVA: 0x0000E4E4 File Offset: 0x0000C6E4
			private static int GetNumberOfItems(global::System.Collections.IEnumerator enumerator)
			{
				int num = 0;
				enumerator.Reset();
				while (enumerator.MoveNext())
				{
					num++;
				}
				return num;
			}

			// Token: 0x06000389 RID: 905 RVA: 0x0000E508 File Offset: 0x0000C708
			internal global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection AutoCalculateLayout(global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> enumerator)
			{
				enumerator = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc.EnumeratorWrapper<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>(enumerator);
				int num = global::System.Math.Max(1, this._minCellsX);
				int num2 = this._maxCellsX;
				int num3 = 0;
				double num4 = -1.0;
				int num5 = 0;
				for (;;)
				{
					global::System.Windows.Size size;
					global::System.Windows.Size size2;
					this.AutoCalculateLayoutHelper(enumerator, out size, out size2);
					if (this._autoFitAllItems)
					{
						double num6 = global::System.Math.Max(this._layoutExtentX, size2.Width) / size.Width;
						double num7 = global::System.Math.Max(this._layoutExtentY, size2.Height) / size.Height;
						double num8 = global::Infragistics.CoreUtilities.AreClose(num6, num7) ? 0.0 : global::System.Math.Abs((num6 - num7) / global::System.Math.Max(num6, num7));
						double num9 = (double)this._cellExtentsX.Count * global::System.Math.Ceiling((double)this._fittedItems.Count / (double)this._cellExtentsX.Count) / (double)this._fittedItems.Count;
						double num10 = num8 + num9;
						if (num3 == 0 || -1.0 == num4 || num4 > num10)
						{
							num3 = this._cellExtentsX.Count;
							num4 = num10;
						}
						if (num2 == 0)
						{
							num2 = this._fittedItems.Count;
						}
						if (this._constraintedOrientation != null && this._constraintedOrientation.Value != this._layoutOrientation && size2.Width > this._layoutExtentX && this._cellExtentsX.Count > global::System.Math.Max(1, this._minCellsX))
						{
							num2 = this._cellExtentsX.Count - 1;
							num = global::System.Math.Min(num, num2);
							if (num3 > num2)
							{
								num4 = -1.0;
							}
						}
						else if (this._constraintedOrientation != null && this._constraintedOrientation.Value == this._layoutOrientation && size2.Height > this._layoutExtentY && (this._maxCellsX <= 0 || this._cellExtentsX.Count < this._maxCellsX))
						{
							num = this._cellExtentsX.Count + 1;
							num2 = global::System.Math.Max(num, num2);
							if (num3 < num)
							{
								num4 = -1.0;
							}
						}
						else if (num6 > num7)
						{
							num = this._cellExtentsX.Count + 1;
						}
						else
						{
							if (num6 >= num7)
							{
								break;
							}
							num2 = this._cellExtentsX.Count - 1;
						}
						if (num > num2)
						{
							break;
						}
						if (this._autoFitAllItems && this._maxCellsY > 0)
						{
							int numberOfItems = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc.GetNumberOfItems(enumerator);
							int val = (int)global::System.Math.Ceiling((double)numberOfItems / (double)this._maxCellsY);
							num = global::System.Math.Max(num, val);
							num2 = global::System.Math.Max(num2, val);
						}
						int num11 = (num + num2) / 2;
						if (num11 == this._forceCellsX)
						{
							break;
						}
						this._forceCellsX = num11;
					}
					else
					{
						if (size.Width > this._layoutExtentX)
						{
							num2 = this._cellExtentsX.Count - 1;
						}
						else
						{
							if (size.Width >= this._layoutExtentX || num5 <= 0)
							{
								break;
							}
							num = this._cellExtentsX.Count + 1;
							num3 = this._cellExtentsX.Count;
						}
						if (num > num2)
						{
							break;
						}
						int num12 = (int)((double)this._cellExtentsX.Count * (this._layoutExtentX / size.Width));
						if (num12 < num || num12 > num2)
						{
							num12 = (num + num2) / 2;
						}
						this._forceCellsX = num12;
					}
					num5++;
				}
				if (num3 > 0 && num3 != this._cellExtentsX.Count)
				{
					this._forceCellsX = num3;
					global::System.Windows.Size size;
					global::System.Windows.Size size2;
					this.AutoCalculateLayoutHelper(enumerator, out size, out size2);
				}
				return this.GetLayoutItemDimensionsHelper();
			}

			// Token: 0x0600038A RID: 906 RVA: 0x0000E864 File Offset: 0x0000CA64
			private void AutoCalculateLayoutHelper(global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> enumerator, out global::System.Windows.Size actualLayoutExtent, out global::System.Windows.Size actualMinLayoutExtent)
			{
				this._lines.Clear();
				this._fittedItems.Clear();
				this._cellExtentsX.Clear();
				this._cellMinExtentsX.Clear();
				global::System.Collections.Generic.List<double> list = null;
				global::System.Collections.Generic.List<double> cellMinExtentsX = null;
				bool flag = (this._layoutOrientation == global::System.Windows.Controls.Orientation.Horizontal) ? (!this._lm.ExpandToFitHeight) : (!this._lm.ExpandToFitWidth);
				double num = 0.0;
				double num2 = 0.0;
				enumerator.Reset();
				global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem = enumerator.MoveNext() ? enumerator.Current : null;
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gridBagConstraintCache = (layoutItem != null) ? this.GetGCC(layoutItem) : null;
				while (gridBagConstraintCache != null)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc.Line line = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc.Line(this);
					this._lines.Add(line);
					while (gridBagConstraintCache != null && line.FitItem(gridBagConstraintCache))
					{
						layoutItem = (enumerator.MoveNext() ? enumerator.Current : null);
						gridBagConstraintCache = ((layoutItem != null) ? this.GetGCC(layoutItem) : null);
					}
					double num4;
					double num3 = line.CalcExtentY(1 == this._lines.Count, out num4);
					num += num3;
					num2 += num4;
					if (this._maxCellsY > 0 && this._lines.Count >= this._maxCellsY)
					{
						break;
					}
					if (!this._autoFitAllItems && num >= this._layoutExtentY && this._lines.Count >= this._minCellsY)
					{
						if (!flag && list != null)
						{
							this._lines.RemoveAt(this._lines.Count - 1);
							this._fittedItems.RemoveRange(line._startIndexInFittedItemsList, this._fittedItems.Count - line._startIndexInFittedItemsList);
							this._cellExtentsX = list;
							this._cellMinExtentsX = cellMinExtentsX;
							break;
						}
						break;
					}
					else if (!flag)
					{
						global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc.CloneValuesHelper<double>(this._cellExtentsX, ref list);
						global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc.CloneValuesHelper<double>(this._cellMinExtentsX, ref cellMinExtentsX);
					}
				}
				actualLayoutExtent = new global::System.Windows.Size(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc.Sum(this._cellExtentsX), num);
				actualMinLayoutExtent = new global::System.Windows.Size(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc.Sum(this._cellMinExtentsX), num2);
			}

			// Token: 0x0600038B RID: 907 RVA: 0x0000EA64 File Offset: 0x0000CC64
			private static void CloneValuesHelper<T>(global::System.Collections.Generic.List<T> source, ref global::System.Collections.Generic.List<T> dest)
			{
				if (dest == null)
				{
					dest = new global::System.Collections.Generic.List<T>(source.Count);
				}
				int i = 0;
				int count = source.Count;
				while (i < count)
				{
					if (i == dest.Count)
					{
						dest.Add(source[i]);
					}
					else
					{
						dest[i] = source[i];
					}
					i++;
				}
			}

			// Token: 0x0600038C RID: 908 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache GetGCC(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item)
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gridBagConstraintCache;
				if (this._gccCache.TryGetValue(item, out gridBagConstraintCache))
				{
					return gridBagConstraintCache;
				}
				gridBagConstraintCache = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache(item, this.g_emptyGCC);
				this._gccCache[item] = gridBagConstraintCache;
				return gridBagConstraintCache;
			}

			// Token: 0x0600038D RID: 909 RVA: 0x0000EAFC File Offset: 0x0000CCFC
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection GetLayoutItemDimensionsHelper()
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache> fittedItems = this._fittedItems;
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutManager = this._lm.Clone(false);
				int i = 0;
				int count = this._lines.Count;
				while (i < count)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc.Line line = this._lines[i];
					int startIndexInFittedItemsList = line._startIndexInFittedItemsList;
					int endIndexInFittedItemsList = line._endIndexInFittedItemsList;
					for (int j = startIndexInFittedItemsList; j <= endIndexInFittedItemsList; j++)
					{
						global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gridBagConstraintCache = fittedItems[j];
						global::Infragistics.Controls.Layouts.Primitives.GridBagConstraint gridBagConstraint = new global::Infragistics.Controls.Layouts.Primitives.GridBagConstraint();
						if (this._layoutOrientation == global::System.Windows.Controls.Orientation.Horizontal)
						{
							gridBagConstraint.Row = i;
							gridBagConstraint.Column = j - startIndexInFittedItemsList;
						}
						else
						{
							gridBagConstraint.Row = j - startIndexInFittedItemsList;
							gridBagConstraint.Column = i;
						}
						gridBagLayoutManager.LayoutItems.Add(gridBagConstraintCache._item, gridBagConstraint);
					}
					i++;
				}
				global::System.Windows.Size size;
				if (this._layoutOrientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					size = new global::System.Windows.Size(this._layoutExtentX, this._layoutExtentY);
				}
				else
				{
					size = new global::System.Windows.Size(this._layoutExtentY, this._layoutExtentX);
				}
				return gridBagLayoutManager.GetLayoutItemDimensions(new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc.CalcSizeLayoutContainer(), new global::System.Windows.Rect(0.0, 0.0, size.Width, size.Height));
			}

			// Token: 0x0600038E RID: 910 RVA: 0x0000EC2C File Offset: 0x0000CE2C
			private double GetItemMinExtent(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gcc, bool oppositeOrientation, bool includeSpacing)
			{
				bool flag = global::System.Windows.Controls.Orientation.Horizontal == this._layoutOrientation ^ oppositeOrientation;
				double num = flag ? gcc._minWidth : gcc._minHeight;
				global::System.Windows.Thickness margin = gcc._margin;
				num += (flag ? (margin.Left + margin.Right) : (margin.Top + margin.Bottom));
				if (includeSpacing)
				{
					num += (flag ? this._lm._interItemSpacingHorizontal : this._lm._interItemSpacingVertical);
				}
				return num;
			}

			// Token: 0x0600038F RID: 911 RVA: 0x0000ECA8 File Offset: 0x0000CEA8
			private double GetItemPreferredExtent(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gcc, bool oppositeOrientation, bool includeSpacing)
			{
				bool flag = global::System.Windows.Controls.Orientation.Horizontal == this._layoutOrientation ^ oppositeOrientation;
				double num = flag ? gcc._prefWidth : gcc._prefHeight;
				if (!this._lm._preferredSizeIncludesMargin)
				{
					global::System.Windows.Thickness margin = gcc._margin;
					num += (flag ? (margin.Left + margin.Right) : (margin.Top + margin.Bottom));
				}
				if (includeSpacing)
				{
					num += (flag ? this._lm._interItemSpacingHorizontal : this._lm._interItemSpacingVertical);
				}
				return num;
			}

			// Token: 0x06000390 RID: 912 RVA: 0x0000ED30 File Offset: 0x0000CF30
			private static double Sum(global::System.Collections.Generic.List<double> list)
			{
				double num = 0.0;
				int i = 0;
				int count = list.Count;
				while (i < count)
				{
					num += list[i];
					i++;
				}
				return num;
			}

			// Token: 0x06000391 RID: 913 RVA: 0x0000ED68 File Offset: 0x0000CF68
			private void UpdateCellExtentX(int cellX, double itemExtentX, double itemMinExtentX)
			{
				if (cellX == this._cellExtentsX.Count)
				{
					this._cellExtentsX.Add(0.0);
					this._cellMinExtentsX.Add(0.0);
				}
				this._cellExtentsX[cellX] = global::System.Math.Max(this._cellExtentsX[cellX], itemExtentX);
				this._cellMinExtentsX[cellX] = global::System.Math.Max(this._cellMinExtentsX[cellX], itemMinExtentX);
			}

			// Token: 0x06000392 RID: 914 RVA: 0x0000EDE7 File Offset: 0x0000CFE7
			private double GetCellExtentX(int cellX, double itemExtentX)
			{
				if (cellX < this._cellExtentsX.Count)
				{
					return global::System.Math.Max(itemExtentX, this._cellExtentsX[cellX]);
				}
				return itemExtentX;
			}

			// Token: 0x04000111 RID: 273
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _lm;

			// Token: 0x04000112 RID: 274
			private global::System.Windows.Controls.Orientation _layoutOrientation;

			// Token: 0x04000113 RID: 275
			private bool _autoFitAllItems;

			// Token: 0x04000114 RID: 276
			private double _layoutExtentX;

			// Token: 0x04000115 RID: 277
			private double _layoutExtentY;

			// Token: 0x04000116 RID: 278
			private int _minCellsX;

			// Token: 0x04000117 RID: 279
			private int _minCellsY;

			// Token: 0x04000118 RID: 280
			private int _maxCellsX;

			// Token: 0x04000119 RID: 281
			private int _maxCellsY;

			// Token: 0x0400011A RID: 282
			private int _forceCellsX;

			// Token: 0x0400011B RID: 283
			private global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc.Line> _lines = new global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc.Line>();

			// Token: 0x0400011C RID: 284
			private global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache> _fittedItems = new global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache>();

			// Token: 0x0400011D RID: 285
			private global::System.Collections.Generic.List<double> _cellExtentsX = new global::System.Collections.Generic.List<double>();

			// Token: 0x0400011E RID: 286
			private global::System.Collections.Generic.List<double> _cellMinExtentsX = new global::System.Collections.Generic.List<double>();

			// Token: 0x0400011F RID: 287
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache> _gccCache = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache>();

			// Token: 0x04000120 RID: 288
			private global::System.Windows.Controls.Orientation? _constraintedOrientation;

			// Token: 0x04000121 RID: 289
			private global::Infragistics.Controls.Layouts.Primitives.GridBagConstraint g_emptyGCC = new global::Infragistics.Controls.Layouts.Primitives.GridBagConstraint();

			// Token: 0x02000056 RID: 86
			private class CalcSizeLayoutContainer : global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer
			{
				// Token: 0x06000395 RID: 917 RVA: 0x0000EE0B File Offset: 0x0000D00B
				public global::System.Windows.Rect GetBounds(object containerContext)
				{
					return (global::System.Windows.Rect)containerContext;
				}

				// Token: 0x06000396 RID: 918 RVA: 0x0000EE13 File Offset: 0x0000D013
				public void PositionItem(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, global::System.Windows.Rect rect, object containerContext)
				{
				}
			}

			// Token: 0x02000057 RID: 87
			private class EnumeratorWrapper<T> : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x06000398 RID: 920 RVA: 0x0000EE1D File Offset: 0x0000D01D
				internal EnumeratorWrapper(global::System.Collections.Generic.IEnumerator<T> enumerator)
				{
					this._enumerator = enumerator;
					this._list = new global::System.Collections.Generic.List<T>();
					this.Reset();
				}

				// Token: 0x1700007F RID: 127
				// (get) Token: 0x06000399 RID: 921 RVA: 0x0000EE3D File Offset: 0x0000D03D
				public T Current
				{
					get
					{
						return this._list[this._currentIndex];
					}
				}

				// Token: 0x0600039A RID: 922 RVA: 0x0000EE50 File Offset: 0x0000D050
				public bool MoveNext()
				{
					this._currentIndex++;
					if (this._currentIndex < this._list.Count)
					{
						return true;
					}
					if (!this._enumeratorExhausted)
					{
						if (this._enumerator.MoveNext())
						{
							this._list.Add(this._enumerator.Current);
							return true;
						}
						this._enumeratorExhausted = true;
					}
					return false;
				}

				// Token: 0x0600039B RID: 923 RVA: 0x0000EEB5 File Offset: 0x0000D0B5
				public void Reset()
				{
					this._currentIndex = -1;
				}

				// Token: 0x17000080 RID: 128
				// (get) Token: 0x0600039C RID: 924 RVA: 0x0000EEBE File Offset: 0x0000D0BE
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x0600039D RID: 925 RVA: 0x0000EECB File Offset: 0x0000D0CB
				public void Dispose()
				{
				}

				// Token: 0x04000122 RID: 290
				private global::System.Collections.Generic.IEnumerator<T> _enumerator;

				// Token: 0x04000123 RID: 291
				private global::System.Collections.Generic.List<T> _list;

				// Token: 0x04000124 RID: 292
				private int _currentIndex;

				// Token: 0x04000125 RID: 293
				private bool _enumeratorExhausted;
			}

			// Token: 0x02000058 RID: 88
			private class Line
			{
				// Token: 0x0600039E RID: 926 RVA: 0x0000EECD File Offset: 0x0000D0CD
				internal Line(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc layout)
				{
					this._layout = layout;
					this._startIndexInFittedItemsList = layout._fittedItems.Count;
					this._endIndexInFittedItemsList = this._startIndexInFittedItemsList - 1;
				}

				// Token: 0x0600039F RID: 927 RVA: 0x0000EEFC File Offset: 0x0000D0FC
				internal double CalcExtentY(bool isFirstLine, out double minExtentY)
				{
					double num = 0.0;
					minExtentY = 0.0;
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc layout = this._layout;
					global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache> fittedItems = layout._fittedItems;
					for (int i = this._startIndexInFittedItemsList; i <= this._endIndexInFittedItemsList; i++)
					{
						global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gcc = fittedItems[i];
						double itemPreferredExtent = layout.GetItemPreferredExtent(gcc, true, !isFirstLine);
						double itemMinExtent = layout.GetItemMinExtent(gcc, true, !isFirstLine);
						num = global::System.Math.Max(num, itemPreferredExtent);
						minExtentY = global::System.Math.Max(minExtentY, itemMinExtent);
					}
					return num;
				}

				// Token: 0x17000081 RID: 129
				// (get) Token: 0x060003A0 RID: 928 RVA: 0x0000EF7E File Offset: 0x0000D17E
				internal int ItemCount
				{
					get
					{
						return 1 + this._endIndexInFittedItemsList - this._startIndexInFittedItemsList;
					}
				}

				// Token: 0x060003A1 RID: 929 RVA: 0x0000EF90 File Offset: 0x0000D190
				internal bool FitItem(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gcc)
				{
					int itemCount = this.ItemCount;
					bool flag = (this._layout._forceCellsX > 0) ? (itemCount >= this._layout._forceCellsX) : (this._layout._maxCellsX > 0 && itemCount >= this._layout._maxCellsX);
					if (flag)
					{
						return false;
					}
					bool includeSpacing = itemCount > 0;
					double itemPreferredExtent = this._layout.GetItemPreferredExtent(gcc, false, includeSpacing);
					double itemMinExtent = this._layout.GetItemMinExtent(gcc, false, includeSpacing);
					double cellExtentX = this._layout.GetCellExtentX(itemCount, itemPreferredExtent);
					if (this._layout._forceCellsX <= 0 && !this._layout._autoFitAllItems && this._extent + cellExtentX > this._layout._layoutExtentX && itemCount > 0 && itemCount + 1 > this._layout._minCellsX)
					{
						return false;
					}
					this._layout._fittedItems.Add(gcc);
					this._endIndexInFittedItemsList++;
					this._layout.UpdateCellExtentX(itemCount, itemPreferredExtent, itemMinExtent);
					this._extent += cellExtentX;
					return true;
				}

				// Token: 0x04000126 RID: 294
				private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.AutoLayoutCalc _layout;

				// Token: 0x04000127 RID: 295
				internal double _extent;

				// Token: 0x04000128 RID: 296
				internal int _startIndexInFittedItemsList;

				// Token: 0x04000129 RID: 297
				internal int _endIndexInFittedItemsList;
			}
		}

		// Token: 0x02000059 RID: 89
		private class GridBagConstraintCache
		{
			// Token: 0x060003A2 RID: 930 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
			internal GridBagConstraintCache(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gc)
			{
				this._item = item;
				this._gc = gc;
				this._gcColumn = (this._column = gc.Column);
				this._gcRow = (this._row = gc.Row);
				this._gcColumnSpan = (this._columnSpan = gc.ColumnSpan);
				this._gcRowSpan = (this._rowSpan = gc.RowSpan);
				this._columnWeight = gc.ColumnWeight;
				this._rowWeight = gc.RowWeight;
				this._margin = gc.Margin;
				global::System.Windows.Size minimumSize = item.MinimumSize;
				global::System.Windows.Size preferredSize = item.PreferredSize;
				global::System.Windows.Size maximumSize = item.MaximumSize;
				this._minWidth = minimumSize.Width;
				this._minHeight = minimumSize.Height;
				this._maxWidth = global::System.Math.Max(maximumSize.Width, this._minWidth);
				this._maxHeight = global::System.Math.Max(maximumSize.Height, this._minHeight);
				this._prefWidth = global::System.Math.Max(global::System.Math.Min(preferredSize.Width, this._maxWidth), this._minWidth);
				this._prefHeight = global::System.Math.Max(global::System.Math.Min(preferredSize.Height, this._maxHeight), this._minHeight);
				global::Infragistics.Controls.Layouts.Primitives.IAutoSizeLayoutItem autoSizeLayoutItem = item as global::Infragistics.Controls.Layouts.Primitives.IAutoSizeLayoutItem;
				this._isAutoWidth = (autoSizeLayoutItem != null && autoSizeLayoutItem.IsWidthAutoSized);
				this._isAutoHeight = (autoSizeLayoutItem != null && autoSizeLayoutItem.IsHeightAutoSized);
			}

			// Token: 0x060003A3 RID: 931 RVA: 0x0000F21C File Offset: 0x0000D41C
			internal global::System.Windows.Thickness GetMarginWithSpacing(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager lm)
			{
				global::System.Windows.Thickness margin = this._margin;
				if (this._hasSpacing != global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.None)
				{
					global::System.Windows.Thickness spacing = this.GetSpacing(lm);
					margin.Left += spacing.Left;
					margin.Top += spacing.Top;
					margin.Right += spacing.Right;
					margin.Bottom += spacing.Bottom;
				}
				return margin;
			}

			// Token: 0x060003A4 RID: 932 RVA: 0x0000F298 File Offset: 0x0000D498
			internal global::System.Windows.Thickness GetSpacing(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager lm)
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side hasSpacing = this._hasSpacing;
				global::System.Windows.Thickness result = new global::System.Windows.Thickness(((global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.Left & hasSpacing) != global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.None) ? (lm._interItemSpacingHorizontal / 2.0) : 0.0, ((global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.Top & hasSpacing) != global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.None) ? (lm._interItemSpacingVertical / 2.0) : 0.0, ((global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.Right & hasSpacing) != global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.None) ? (lm._interItemSpacingHorizontal / 2.0) : 0.0, ((global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.Bottom & hasSpacing) != global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side.None) ? (lm._interItemSpacingVertical / 2.0) : 0.0);
				return result;
			}

			// Token: 0x0400012A RID: 298
			internal global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint _gc;

			// Token: 0x0400012B RID: 299
			internal global::Infragistics.Controls.Layouts.Primitives.ILayoutItem _item;

			// Token: 0x0400012C RID: 300
			internal int _column;

			// Token: 0x0400012D RID: 301
			internal int _row;

			// Token: 0x0400012E RID: 302
			internal int _columnSpan;

			// Token: 0x0400012F RID: 303
			internal int _rowSpan;

			// Token: 0x04000130 RID: 304
			internal global::System.Windows.Thickness _margin;

			// Token: 0x04000131 RID: 305
			internal double _minWidth;

			// Token: 0x04000132 RID: 306
			internal double _minHeight;

			// Token: 0x04000133 RID: 307
			internal double _maxWidth;

			// Token: 0x04000134 RID: 308
			internal double _maxHeight;

			// Token: 0x04000135 RID: 309
			internal double _prefWidth;

			// Token: 0x04000136 RID: 310
			internal double _prefHeight;

			// Token: 0x04000137 RID: 311
			internal int _gcColumn;

			// Token: 0x04000138 RID: 312
			internal int _gcRow;

			// Token: 0x04000139 RID: 313
			internal int _gcColumnSpan;

			// Token: 0x0400013A RID: 314
			internal int _gcRowSpan;

			// Token: 0x0400013B RID: 315
			internal float _columnWeight;

			// Token: 0x0400013C RID: 316
			internal float _rowWeight;

			// Token: 0x0400013D RID: 317
			internal bool _isAutoWidth;

			// Token: 0x0400013E RID: 318
			internal bool _isAutoHeight;

			// Token: 0x0400013F RID: 319
			internal global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.Side _hasSpacing;
		}

		// Token: 0x0200005A RID: 90
		private class GridBagLayoutCache
		{
			// Token: 0x060003A5 RID: 933 RVA: 0x0000F334 File Offset: 0x0000D534
			internal GridBagLayoutCache(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache[] gccArr, float[] colWeights, float[] rowWeights, double[] colWidthsPref, double[] rowHeightsPref, double[] colWidthsMin, double[] rowHeightsMin, double[] colWidthsMax, double[] rowHeightsMax, bool[] colIsAuto, bool[] rowIsAuto)
			{
				this._gccArr = gccArr;
				this._colWeights = colWeights;
				this._rowWeights = rowWeights;
				this._colWidthsPref = colWidthsPref;
				this._rowHeightsPref = rowHeightsPref;
				this._colWidthsMin = colWidthsMin;
				this._rowHeightsMin = rowHeightsMin;
				this._colWidthsMax = colWidthsMax;
				this._rowHeightsMax = rowHeightsMax;
				this._colIsAuto = colIsAuto;
				this._rowIsAuto = rowIsAuto;
			}

			// Token: 0x04000140 RID: 320
			internal global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache[] _gccArr;

			// Token: 0x04000141 RID: 321
			internal float[] _colWeights;

			// Token: 0x04000142 RID: 322
			internal float[] _rowWeights;

			// Token: 0x04000143 RID: 323
			internal double[] _colWidthsPref;

			// Token: 0x04000144 RID: 324
			internal double[] _rowHeightsPref;

			// Token: 0x04000145 RID: 325
			internal double[] _colWidthsMin;

			// Token: 0x04000146 RID: 326
			internal double[] _rowHeightsMin;

			// Token: 0x04000147 RID: 327
			internal double[] _colWidthsMax;

			// Token: 0x04000148 RID: 328
			internal double[] _rowHeightsMax;

			// Token: 0x04000149 RID: 329
			internal double _lastContainerWidth;

			// Token: 0x0400014A RID: 330
			internal double _lastContainerHeight;

			// Token: 0x0400014B RID: 331
			internal double[] _colCoordinates;

			// Token: 0x0400014C RID: 332
			internal double[] _rowCoordinates;

			// Token: 0x0400014D RID: 333
			internal double[] _colCoordinateExtents;

			// Token: 0x0400014E RID: 334
			internal double[] _rowCoordinateExtents;

			// Token: 0x0400014F RID: 335
			internal bool[] _colIsAuto;

			// Token: 0x04000150 RID: 336
			internal bool[] _rowIsAuto;
		}

		// Token: 0x0200005B RID: 91
		private class IntExpandableArray
		{
			// Token: 0x060003A6 RID: 934 RVA: 0x0000F39C File Offset: 0x0000D59C
			internal IntExpandableArray(int initialCapacity)
			{
				this._list = new global::System.Collections.Generic.List<int[]>((initialCapacity - 1) / 64 + 1);
			}

			// Token: 0x060003A7 RID: 935 RVA: 0x0000F3B8 File Offset: 0x0000D5B8
			private int[] GetArr(int index)
			{
				int num = index / 64;
				while (this._list.Count <= num)
				{
					this._list.Add(new int[64]);
				}
				return this._list[num];
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000F3F8 File Offset: 0x0000D5F8
			internal int Length
			{
				get
				{
					return this._length;
				}
			}

			// Token: 0x17000083 RID: 131
			internal int this[int index]
			{
				get
				{
					this._length = global::System.Math.Max(1 + index, this._length);
					int[] arr = this.GetArr(index);
					return arr[index % 64];
				}
				set
				{
					this._length = global::System.Math.Max(1 + index, this._length);
					int[] arr = this.GetArr(index);
					arr[index % 64] = value;
				}
			}

			// Token: 0x060003AB RID: 939 RVA: 0x0000F460 File Offset: 0x0000D660
			internal void Reset()
			{
				int i = 0;
				int count = this._list.Count;
				while (i < count)
				{
					this._list[i].Initialize();
					i++;
				}
			}

			// Token: 0x04000151 RID: 337
			private const int ELEMS_PER_ARR = 64;

			// Token: 0x04000152 RID: 338
			private global::System.Collections.Generic.List<int[]> _list;

			// Token: 0x04000153 RID: 339
			private int _length;
		}

		// Token: 0x0200005C RID: 92
		private class IntPoint
		{
			// Token: 0x060003AC RID: 940 RVA: 0x0000F496 File Offset: 0x0000D696
			public IntPoint() : this(0, 0)
			{
			}

			// Token: 0x060003AD RID: 941 RVA: 0x0000F4A0 File Offset: 0x0000D6A0
			public IntPoint(int x, int y)
			{
				this._x = x;
				this._y = y;
			}

			// Token: 0x060003AE RID: 942 RVA: 0x0000F4B6 File Offset: 0x0000D6B6
			internal void SetXY(int x, int y)
			{
				this._x = x;
				this._y = y;
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x060003AF RID: 943 RVA: 0x0000F4C6 File Offset: 0x0000D6C6
			internal int X
			{
				get
				{
					return this._x;
				}
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x060003B0 RID: 944 RVA: 0x0000F4CE File Offset: 0x0000D6CE
			internal int Y
			{
				get
				{
					return this._y;
				}
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x0000F4D6 File Offset: 0x0000D6D6
			public override int GetHashCode()
			{
				return this._x ^ this._y;
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
			public override bool Equals(object obj)
			{
				if (obj is global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IntPoint)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IntPoint intPoint = (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IntPoint)obj;
					return this._x == intPoint._x && this._y == intPoint._y;
				}
				return false;
			}

			// Token: 0x04000154 RID: 340
			private int _x;

			// Token: 0x04000155 RID: 341
			private int _y;
		}

		// Token: 0x0200005D RID: 93
		private class LayoutItemComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache>
		{
			// Token: 0x060003B3 RID: 947 RVA: 0x0000F524 File Offset: 0x0000D724
			internal LayoutItemComparer(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gblm, bool yWise)
			{
				this._yWise = yWise;
				this._gblm = gblm;
			}

			// Token: 0x060003B4 RID: 948 RVA: 0x0000F53C File Offset: 0x0000D73C
			internal static int Compare(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gcc1, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gcc2, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gblm, bool yWise, bool flag)
			{
				if (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutMode.Uniform == gblm.LayoutMode)
				{
					if (yWise)
					{
						if (gcc1._rowSpan < gcc2._rowSpan)
						{
							return -1;
						}
						if (gcc1._rowSpan > gcc2._rowSpan)
						{
							return 1;
						}
						if (gcc1._row < gcc2._row)
						{
							return -1;
						}
						if (gcc1._row > gcc2._row)
						{
							return 1;
						}
					}
					else
					{
						if (gcc1._columnSpan < gcc2._columnSpan)
						{
							return -1;
						}
						if (gcc1._columnSpan > gcc2._columnSpan)
						{
							return 1;
						}
						if (gcc1._column < gcc2._column)
						{
							return -1;
						}
						if (gcc1._column > gcc2._column)
						{
							return 1;
						}
					}
				}
				else if (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutMode.LeftToRight == gblm.LayoutMode)
				{
					if (yWise)
					{
						if (gcc1._row + gcc1._rowSpan < gcc2._row + gcc2._rowSpan)
						{
							return -1;
						}
						if (gcc1._row + gcc1._rowSpan > gcc2._row + gcc2._rowSpan)
						{
							return 1;
						}
						if (gcc1._row < gcc2._row)
						{
							return -1;
						}
						if (gcc1._row > gcc2._row)
						{
							return 1;
						}
					}
					else
					{
						if (gcc1._column + gcc1._columnSpan < gcc2._column + gcc2._columnSpan)
						{
							return -1;
						}
						if (gcc1._column + gcc1._columnSpan > gcc2._column + gcc2._columnSpan)
						{
							return 1;
						}
						if (gcc1._column < gcc2._column)
						{
							return -1;
						}
						if (gcc1._column > gcc2._column)
						{
							return 1;
						}
					}
				}
				else if (yWise)
				{
					if (gcc1._rowSpan < gcc2._rowSpan)
					{
						return -1;
					}
					if (gcc1._rowSpan > gcc2._rowSpan)
					{
						return 1;
					}
					if (gcc1._row < gcc2._row)
					{
						return -1;
					}
					if (gcc1._row > gcc2._row)
					{
						return 1;
					}
				}
				else
				{
					if (gcc1._columnSpan < gcc2._columnSpan)
					{
						return -1;
					}
					if (gcc1._columnSpan > gcc2._columnSpan)
					{
						return 1;
					}
					if (gcc1._column < gcc2._column)
					{
						return -1;
					}
					if (gcc1._column > gcc2._column)
					{
						return 1;
					}
				}
				if (flag)
				{
					return global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.LayoutItemComparer.Compare(gcc1, gcc2, gblm, !yWise, false);
				}
				return 0;
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x0000F741 File Offset: 0x0000D941
			public int Compare(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache o1, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache o2)
			{
				return global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.LayoutItemComparer.Compare(o1, o2, this._gblm, this._yWise, true);
			}

			// Token: 0x04000156 RID: 342
			private bool _yWise;

			// Token: 0x04000157 RID: 343
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _gblm;
		}

		// Token: 0x0200005E RID: 94
		private class ResizeManager
		{
			// Token: 0x060003B6 RID: 950 RVA: 0x0000F758 File Offset: 0x0000D958
			internal ResizeManager(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager layoutManager, global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer layoutContainer, object containerContext, bool autoFitWidth, bool autoFitHeight)
			{
				this._layoutContainer = layoutContainer;
				this._containerContext = containerContext;
				this._autoFitWidth = autoFitWidth;
				this._autoFitHeight = autoFitHeight;
				this._layoutManager = this.CloneLayoutManagerHelper(layoutManager);
				this.ReCalculateLayout();
			}

			// Token: 0x060003B7 RID: 951 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
			public void GetResizeRange(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem resizeItem, out double maxDeltaLeft, out double maxDeltaRight, out double maxDeltaTop, out double maxDeltaBottom, global::System.Collections.Generic.IList<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> synchronizedItems)
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] resizeItems;
				this.GetResizeItemInfosHelper(resizeItem, synchronizedItems, out resizeItems);
				this.GetResizeRangeHelper(resizeItems, out maxDeltaLeft, out maxDeltaRight, out maxDeltaTop, out maxDeltaBottom);
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x0000F7D8 File Offset: 0x0000D9D8
			public void ResizeItems(global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> newSizes)
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo>();
				global::System.Collections.Generic.List<global::System.Windows.Size> list2 = new global::System.Collections.Generic.List<global::System.Windows.Size>();
				global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo> list3 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo>();
				global::System.Collections.Generic.List<global::System.Windows.Size> list4 = new global::System.Collections.Generic.List<global::System.Windows.Size>();
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> keyValuePair in newSizes)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo mappedItem = this.GetMappedItem(keyValuePair.Key);
					global::System.Windows.Size value = keyValuePair.Value;
					if (mappedItem != null)
					{
						if (value.Width > 0.0)
						{
							list.Add(mappedItem);
							list2.Add(value);
						}
						if (value.Height > 0.0)
						{
							list3.Add(mappedItem);
							list4.Add(value);
						}
					}
				}
				this.ResizeItemsHelper(list.ToArray(), list2.ToArray(), true, false);
				this.ResizeItemsHelper(list3.ToArray(), list4.ToArray(), false, true);
			}

			// Token: 0x060003B9 RID: 953 RVA: 0x0000F8C4 File Offset: 0x0000DAC4
			public void ResizeItem(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, double deltaX, double deltaY, global::System.Collections.Generic.IList<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> synchronizedItems)
			{
				this.ResizeItemHelper(item, deltaX, deltaY, synchronizedItems);
			}

			// Token: 0x060003BA RID: 954 RVA: 0x0000F8D4 File Offset: 0x0000DAD4
			private void AddMargin(ref global::System.Windows.Size sz, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo ii)
			{
				global::System.Windows.Thickness marginWithSpacing = ii._gcc.GetMarginWithSpacing(this._layoutManager);
				sz.Width += marginWithSpacing.Left + marginWithSpacing.Right;
				sz.Height += marginWithSpacing.Top + marginWithSpacing.Bottom;
			}

			// Token: 0x060003BB RID: 955 RVA: 0x0000F92B File Offset: 0x0000DB2B
			private static bool AreClose(global::System.Windows.Size x, global::System.Windows.Size y, double threshold)
			{
				return global::System.Math.Abs(x.Width - y.Width) <= threshold && global::System.Math.Abs(x.Height - y.Height) <= threshold;
			}

			// Token: 0x060003BC RID: 956 RVA: 0x0000F960 File Offset: 0x0000DB60
			private static bool AreClose(double x, double y, double threshold)
			{
				return global::System.Math.Abs(x - y) <= threshold;
			}

			// Token: 0x060003BD RID: 957 RVA: 0x0000F970 File Offset: 0x0000DB70
			private static bool AreSame(global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> xx, global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> yy)
			{
				if (xx.Count != yy.Count)
				{
					return false;
				}
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> keyValuePair in xx)
				{
					global::System.Windows.Size y;
					if (!yy.TryGetValue(keyValuePair.Key, out y) || !global::Infragistics.CoreUtilities.AreClose(keyValuePair.Value, y))
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x060003BE RID: 958 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
			private static void ArrayMove<X, Y>(X[] xxArr, Y[] yyArr, int[] indeces)
			{
				for (int i = 0; i < indeces.Length; i++)
				{
					int x = indeces[i];
					global::Infragistics.CoreUtilities.Swap<X>(xxArr, x, i);
					global::Infragistics.CoreUtilities.Swap<Y>(yyArr, x, i);
					global::Infragistics.CoreUtilities.Swap<int>(indeces, x, i);
				}
			}

			// Token: 0x060003BF RID: 959 RVA: 0x0000FA28 File Offset: 0x0000DC28
			private static double CalcAbsoluteDelta(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo item, global::System.Windows.Size size, bool yDimension)
			{
				double value = (!yDimension) ? (item._dim.Size.Width - size.Width) : (item._dim.Size.Height - size.Height);
				return global::System.Math.Abs(value);
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x0000FA78 File Offset: 0x0000DC78
			private double CalcDeltaHelper(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] resizeItems, global::System.Windows.Size[] newSizes, ref int startIndex, bool yDelta)
			{
				double num = double.NaN;
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo = resizeItems[startIndex];
				int num2 = (!yDelta) ? layoutItemInfo._dim.ColumnRight : layoutItemInfo._dim.RowBottom;
				while (startIndex < resizeItems.Length)
				{
					layoutItemInfo = resizeItems[startIndex];
					int num3 = (!yDelta) ? layoutItemInfo._dim.ColumnRight : layoutItemInfo._dim.RowBottom;
					if (num3 != num2)
					{
						break;
					}
					global::System.Windows.Size size = newSizes[startIndex];
					double num4 = (!yDelta) ? (size.Width - layoutItemInfo._dim.Bounds.Width) : (size.Height - layoutItemInfo._dim.Bounds.Height);
					if (double.IsNaN(num))
					{
						num = num4;
					}
					else if (num < num4)
					{
						num = num4;
					}
					startIndex++;
				}
				return global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.CloseToZeroHelper(num);
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x0000FB58 File Offset: 0x0000DD58
			private global::System.Windows.Size CalcNewSizeHelper(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo item, double deltaX, double deltaY)
			{
				global::System.Windows.Size size = item._dim.Size;
				size.Width = global::System.Math.Max(size.Width + deltaX, 0.0);
				size.Height = global::System.Math.Max(size.Height + deltaY, 0.0);
				return size;
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x0000FBB0 File Offset: 0x0000DDB0
			private bool ClearIsAutoState(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] items, bool clearAutoWidthState, bool clearAutoHeightState, bool alsoClearAlignedItems, bool recalcLayout)
			{
				bool flag = false;
				if (!alsoClearAlignedItems)
				{
					foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo in items)
					{
						if (clearAutoWidthState && layoutItemInfo._isAutoWidth)
						{
							layoutItemInfo._isAutoWidth = false;
							flag = true;
						}
						if (clearAutoHeightState && layoutItemInfo._isAutoHeight)
						{
							layoutItemInfo._isAutoHeight = false;
							flag = true;
						}
					}
				}
				else
				{
					global::System.Collections.Generic.HashSet<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo> hashSet = new global::System.Collections.Generic.HashSet<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo>();
					global::System.Collections.Generic.HashSet<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo> hashSet2 = new global::System.Collections.Generic.HashSet<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo>();
					foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo2 in items)
					{
						if (clearAutoWidthState && !hashSet.Contains(layoutItemInfo2))
						{
							global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] itemsEndingAt = this.GetItemsEndingAt(layoutItemInfo2._dim.ColumnRight, false);
							flag = (this.ClearIsAutoState(itemsEndingAt, true, false, false, false) || flag);
							for (int k = 0; k < itemsEndingAt.Length; k++)
							{
								hashSet.Add(itemsEndingAt[k]);
							}
						}
						if (clearAutoHeightState && !hashSet2.Contains(layoutItemInfo2))
						{
							global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] itemsEndingAt2 = this.GetItemsEndingAt(layoutItemInfo2._dim.RowBottom, true);
							flag = (this.ClearIsAutoState(itemsEndingAt2, false, true, false, false) || flag);
							for (int l = 0; l < itemsEndingAt2.Length; l++)
							{
								hashSet2.Add(itemsEndingAt2[l]);
							}
						}
					}
				}
				if (recalcLayout && flag)
				{
					this.ReCalculateLayout();
				}
				return flag;
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x0000FCE8 File Offset: 0x0000DEE8
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager CloneLayoutManagerHelper(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager source)
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutManager = source.Clone(false);
				gridBagLayoutManager.IncludeMarginInPositionRect = false;
				global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection layoutItems = source.LayoutItems;
				global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection layoutItems2 = gridBagLayoutManager.LayoutItems;
				foreach (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)layoutItems))
				{
					layoutItems2.Add(new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo(layoutItem), layoutItems.GetConstraint(layoutItem));
				}
				return gridBagLayoutManager;
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x0000FD60 File Offset: 0x0000DF60
			private static double CloseToZeroHelper(double d)
			{
				if (global::Infragistics.CoreUtilities.AreClose(d, 0.0))
				{
					d = 0.0;
				}
				return d;
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x0000FD80 File Offset: 0x0000DF80
			private double[] CreateCoordinates(double[] extents)
			{
				double[] array = new double[1 + extents.Length];
				global::System.Array.Copy(extents, array, extents.Length);
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ConvertToCoordinates(array);
				return array;
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x0000FDAC File Offset: 0x0000DFAC
			private global::System.Windows.Size[] CreateSizeArr(global::System.Windows.Size size, int len)
			{
				global::System.Windows.Size[] array = new global::System.Windows.Size[len];
				for (int i = 0; i < len; i++)
				{
					array[i] = size;
				}
				return array;
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x0000FDDA File Offset: 0x0000DFDA
			private double GetCellExtent(double[] coordinates, int origin, int span)
			{
				return coordinates[origin + span] - coordinates[origin];
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x0000FDE8 File Offset: 0x0000DFE8
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> GetCurrentItemSizes()
			{
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size>();
				foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo in this._infos)
				{
					dictionary[layoutItemInfo] = layoutItemInfo._dim.Size;
				}
				return dictionary;
			}

			// Token: 0x060003C9 RID: 969 RVA: 0x0000FE28 File Offset: 0x0000E028
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] GetItemsEndingAt(int edge, bool yDimension)
			{
				int key = (!yDimension) ? edge : (-edge - 1);
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] array;
				if (this._itemsEndingAtCache.TryGetValue(key, out array))
				{
					return array;
				}
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] infos = this._infos;
				global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo>();
				foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo in infos)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions dim = layoutItemInfo._dim;
					int num = (!yDimension) ? layoutItemInfo._dim.ColumnRight : layoutItemInfo._dim.RowBottom;
					if (num == edge)
					{
						list.Add(layoutItemInfo);
					}
				}
				array = list.ToArray();
				this._itemsEndingAtCache[key] = array;
				return array;
			}

			// Token: 0x060003CA RID: 970 RVA: 0x0000FEC0 File Offset: 0x0000E0C0
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo GetMappedItem(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item)
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo;
				if (!this._mappings.TryGetValue(item, out layoutItemInfo))
				{
					throw new global::System.ArgumentException(global::SR.GetString("LE_GridBag_ItemNotInLayoutItems", new object[]
					{
						item
					}));
				}
				if (layoutItemInfo._dim == null)
				{
					throw new global::System.ArgumentException(global::SR.GetString("LE_GridBag_ItemNotVisible", new object[]
					{
						item
					}));
				}
				return layoutItemInfo;
			}

			// Token: 0x060003CB RID: 971 RVA: 0x0000FF20 File Offset: 0x0000E120
			internal global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> GetNewPreferredSizes(out global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> newIsWidthAutoState, out global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> newIsHeightAutoState, bool xDimension, bool yDimension)
			{
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size>();
				newIsWidthAutoState = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool>();
				newIsHeightAutoState = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool>();
				foreach (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)this._layoutManager.LayoutItems))
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo = (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo)layoutItem;
					if (layoutItemInfo._gcc != null)
					{
						global::Infragistics.Controls.Layouts.Primitives.IAutoSizeLayoutItem autoSizeLayoutItem = layoutItemInfo._i as global::Infragistics.Controls.Layouts.Primitives.IAutoSizeLayoutItem;
						bool flag = autoSizeLayoutItem != null && autoSizeLayoutItem.IsWidthAutoSized;
						bool flag2 = autoSizeLayoutItem != null && autoSizeLayoutItem.IsHeightAutoSized;
						global::System.Windows.Size preferredSize = layoutItemInfo._i.PreferredSize;
						global::System.Windows.Size size = preferredSize;
						if (xDimension)
						{
							if (preferredSize.Width != layoutItemInfo._preferredSize.Width)
							{
								size.Width = layoutItemInfo._preferredSize.Width;
							}
							if (flag != layoutItemInfo._isAutoWidth)
							{
								newIsWidthAutoState[layoutItemInfo._i] = layoutItemInfo._isAutoWidth;
							}
						}
						if (yDimension)
						{
							if (preferredSize.Height != layoutItemInfo._preferredSize.Height)
							{
								size.Height = layoutItemInfo._preferredSize.Height;
							}
							if (flag2 != layoutItemInfo._isAutoHeight)
							{
								newIsHeightAutoState[layoutItemInfo._i] = layoutItemInfo._isAutoHeight;
							}
						}
						if (size != preferredSize)
						{
							dictionary[layoutItemInfo._i] = size;
						}
					}
				}
				return dictionary;
			}

			// Token: 0x060003CC RID: 972 RVA: 0x00010084 File Offset: 0x0000E284
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> GetPreferredSizes(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] items)
			{
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size>();
				foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo in items)
				{
					dictionary[layoutItemInfo] = layoutItemInfo._preferredSize;
				}
				return dictionary;
			}

			// Token: 0x060003CD RID: 973 RVA: 0x000100B8 File Offset: 0x0000E2B8
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo GetResizeItemInfosHelper(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem resizeItem, global::System.Collections.Generic.IList<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> synchronizedItems, out global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] itemInfos)
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo mappedItem = this.GetMappedItem(resizeItem);
				global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo>();
				list.Add(mappedItem);
				if (synchronizedItems != null)
				{
					int i = 0;
					int count = synchronizedItems.Count;
					while (i < count)
					{
						global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem = synchronizedItems[i];
						if (layoutItem != resizeItem)
						{
							list.Add(this.GetMappedItem(layoutItem));
						}
						i++;
					}
				}
				itemInfos = list.ToArray();
				return mappedItem;
			}

			// Token: 0x060003CE RID: 974 RVA: 0x00010118 File Offset: 0x0000E318
			private void GetResizeRangeHelper(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] resizeItems, out double maxDeltaLeft, out double maxDeltaRight, out double maxDeltaTop, out double maxDeltaBottom)
			{
				maxDeltaLeft = (maxDeltaRight = (maxDeltaTop = (maxDeltaBottom = double.MaxValue)));
				this.ClearIsAutoState(resizeItems, true, true, true, true);
				global::System.Collections.Generic.HashSet<int> hashSet = new global::System.Collections.Generic.HashSet<int>();
				global::System.Collections.Generic.HashSet<int> hashSet2 = new global::System.Collections.Generic.HashSet<int>();
				foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo in resizeItems)
				{
					if (!hashSet.Contains(layoutItemInfo._dim.ColumnRight) || !hashSet2.Contains(layoutItemInfo._dim.RowBottom))
					{
						hashSet.Add(layoutItemInfo._dim.ColumnRight);
						hashSet2.Add(layoutItemInfo._dim.RowBottom);
						double val;
						double val2;
						double val3;
						double val4;
						this.GetResizeRangeHelperHelper(layoutItemInfo, out val, out val2, out val3, out val4);
						maxDeltaLeft = global::System.Math.Min(maxDeltaLeft, val);
						maxDeltaRight = global::System.Math.Min(maxDeltaRight, val2);
						maxDeltaTop = global::System.Math.Min(maxDeltaTop, val3);
						maxDeltaBottom = global::System.Math.Min(maxDeltaBottom, val4);
					}
				}
				if (this._autoFitWidth)
				{
					maxDeltaLeft = -this.GetResizeRangeHelper_AdjustDeltaHelper(resizeItems, -maxDeltaLeft, false);
					maxDeltaRight = this.GetResizeRangeHelper_AdjustDeltaHelper(resizeItems, maxDeltaRight, false);
				}
				if (this._autoFitHeight)
				{
					maxDeltaTop = -this.GetResizeRangeHelper_AdjustDeltaHelper(resizeItems, -maxDeltaTop, true);
					maxDeltaBottom = this.GetResizeRangeHelper_AdjustDeltaHelper(resizeItems, maxDeltaBottom, true);
				}
			}

			// Token: 0x060003CF RID: 975 RVA: 0x00010248 File Offset: 0x0000E448
			private void GetResizeRangeHelperHelper(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo resizeItem, out double maxDeltaLeft, out double maxDeltaRight, out double maxDeltaTop, out double maxDeltaBottom)
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutCache glc = this._glc;
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] infos = this._infos;
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions dim = resizeItem._dim;
				int num = dim.Column;
				int num2 = dim.Row;
				double num3 = double.MaxValue;
				double num4 = double.MaxValue;
				foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo in infos)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions dim2 = layoutItemInfo._dim;
					if (dim2.ColumnRight < dim.ColumnRight && dim2.ColumnRight > dim.Column)
					{
						num = global::System.Math.Max(num, dim2.ColumnRight);
					}
					if (dim2.RowBottom < dim.RowBottom && dim2.RowBottom > dim.Row)
					{
						num2 = global::System.Math.Max(num2, dim2.RowBottom);
					}
					global::System.Windows.Thickness marginWithSpacing = layoutItemInfo._gcc.GetMarginWithSpacing(this._layoutManager);
					if (dim2.ColumnRight == dim.ColumnRight && global::System.Windows.HorizontalAlignment.Stretch == layoutItemInfo._gcc._gc.HorizontalAlignment)
					{
						num3 = global::System.Math.Min(num3, dim2.Bounds.Left + layoutItemInfo._gcc._maxWidth + marginWithSpacing.Right);
					}
					if (dim2.RowBottom == dim.RowBottom && global::System.Windows.VerticalAlignment.Stretch == layoutItemInfo._gcc._gc.VerticalAlignment)
					{
						num4 = global::System.Math.Min(num4, dim2.Bounds.Top + layoutItemInfo._gcc._maxHeight + marginWithSpacing.Bottom);
					}
				}
				double num5 = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSum(glc._colWidthsMin, num, dim.ColumnRight - num);
				double num6 = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrSum(glc._rowHeightsMin, num2, dim.RowBottom - num2);
				double num7 = glc._colCoordinates[num] + num5;
				double num8 = glc._rowCoordinates[num2] + num6;
				num7 = global::System.Math.Max(num7, dim.Bounds.Left + resizeItem._gcc._minWidth);
				num8 = global::System.Math.Max(num8, dim.Bounds.Top + resizeItem._gcc._minHeight);
				maxDeltaLeft = dim.Bounds.Right - num7;
				maxDeltaTop = dim.Bounds.Bottom - num8;
				maxDeltaRight = num3 - dim.Bounds.Right;
				maxDeltaBottom = num4 - dim.Bounds.Bottom;
				global::System.Windows.Rect containerBoundsHelper = global::Infragistics.Controls.Layouts.Primitives.LayoutManagerBase.GetContainerBoundsHelper(this._layoutContainer, this._containerContext, this._layoutManager);
				if (this._autoFitWidth && containerBoundsHelper.Width > 0.0)
				{
					maxDeltaRight = global::System.Math.Min(maxDeltaRight, containerBoundsHelper.Width);
				}
				if (this._autoFitHeight && containerBoundsHelper.Height > 0.0)
				{
					maxDeltaBottom = global::System.Math.Min(maxDeltaBottom, containerBoundsHelper.Height);
				}
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x00010518 File Offset: 0x0000E718
			private double GetResizeRangeHelper_AdjustDeltaHelper(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] resizeItems, double delta, bool yDimension)
			{
				double num = 0.0;
				double num2 = delta;
				int num3 = 0;
				int num4 = 20;
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> preferredSizes = this.GetPreferredSizes(this._infos);
				while (!global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.AreClose(num, num2, 0.05) && num3++ < num4)
				{
					double num5 = num + 0.33 * (num2 - num);
					double delta2 = num + 0.66 * (num2 - num);
					global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> resizeResultsHelper = this.GetResizeResultsHelper(resizeItems, num5, yDimension, preferredSizes);
					global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> resizeResultsHelper2 = this.GetResizeResultsHelper(resizeItems, delta2, yDimension, preferredSizes);
					if (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.AreSame(resizeResultsHelper, resizeResultsHelper2))
					{
						num2 = num5;
					}
					else
					{
						num = num5;
					}
				}
				return global::System.Math.Round(num2, 1);
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x000105BC File Offset: 0x0000E7BC
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> GetResizeResultsHelper(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] resizeItems, double delta, bool yDimension, global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> restorePreferredSizes)
			{
				global::System.Windows.Size size = this.CalcNewSizeHelper(resizeItems[0], (!yDimension) ? delta : 0.0, yDimension ? delta : 0.0);
				this.ResizeItemsHelper(resizeItems, this.CreateSizeArr(size, resizeItems.Length), yDimension);
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size>();
				foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo in resizeItems)
				{
					dictionary[layoutItemInfo] = layoutItemInfo._dim.Size;
				}
				if (restorePreferredSizes != null)
				{
					this.SetPreferredSizes(restorePreferredSizes);
				}
				this.ReCalculateLayout();
				return dictionary;
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x00010640 File Offset: 0x0000E840
			private bool IsExtentDifferent(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] resizeItems, global::System.Windows.Size[] newSizes, bool yDimension)
			{
				bool flag = false;
				int num = 0;
				while (num < resizeItems.Length && !flag)
				{
					global::System.Windows.Size size = resizeItems[num]._dim.Size;
					global::System.Windows.Size size2 = newSizes[num];
					flag = ((!yDimension) ? (!global::Infragistics.CoreUtilities.AreClose(size.Width, size2.Width)) : (!global::Infragistics.CoreUtilities.AreClose(size.Height, size2.Height)));
					num++;
				}
				return flag;
			}

			// Token: 0x060003D3 RID: 979 RVA: 0x000106AE File Offset: 0x0000E8AE
			private void ReCalculateLayout()
			{
				this.ReCalculateLayout(true);
			}

			// Token: 0x060003D4 RID: 980 RVA: 0x000106B8 File Offset: 0x0000E8B8
			private void ReCalculateLayout(bool invalidateLayout)
			{
				if (invalidateLayout)
				{
					this._layoutManager.InvalidateLayout();
				}
				this._glc = this._layoutManager.GetGridBagLayoutCache();
				if (!invalidateLayout)
				{
					this._glc._lastContainerWidth = (this._glc._lastContainerHeight = 0.0);
				}
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache[] gccArr = this._glc._gccArr;
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection layoutItemDimensions = this._layoutManager.GetLayoutItemDimensions(this._layoutContainer, this._containerContext);
				if (this._mappings == null || this._infos == null)
				{
					this._mappings = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo>();
					global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo>();
					foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gridBagConstraintCache in gccArr)
					{
						global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo = (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo)gridBagConstraintCache._item;
						this._mappings[layoutItemInfo._i] = layoutItemInfo;
						list.Add(layoutItemInfo);
					}
					this._infos = list.ToArray();
				}
				foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache gridBagConstraintCache2 in gccArr)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo2 = (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo)gridBagConstraintCache2._item;
					if (layoutItemDimensions.Exists(layoutItemInfo2))
					{
						layoutItemInfo2._gcc = gridBagConstraintCache2;
						layoutItemInfo2._dim = layoutItemDimensions[layoutItemInfo2];
					}
				}
			}

			// Token: 0x060003D5 RID: 981 RVA: 0x000107E4 File Offset: 0x0000E9E4
			private void RemoveMargin(ref global::System.Windows.Size sz, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo ii)
			{
				global::System.Windows.Thickness marginWithSpacing = ii._gcc.GetMarginWithSpacing(this._layoutManager);
				sz.Width -= marginWithSpacing.Left + marginWithSpacing.Right;
				sz.Height -= marginWithSpacing.Top + marginWithSpacing.Bottom;
			}

			// Token: 0x060003D6 RID: 982 RVA: 0x0001083C File Offset: 0x0000EA3C
			private void ResizeLogicalDims(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo item, double targetExtent, bool yDimension)
			{
				double[] array = (!yDimension) ? this._layoutManager.ColumnWidths : this._layoutManager.RowHeights;
				int num = (!yDimension) ? item._dim.Column : item._dim.Row;
				int num2 = (!yDimension) ? item._dim.ColumnSpan : item._dim.RowSpan;
				global::System.Windows.Rect bounds = item._dim.Bounds;
				double num3 = (!yDimension) ? bounds.Width : bounds.Height;
				double num4 = targetExtent - num3;
				for (int i = 0; i < num2; i++)
				{
					array[num + i] = global::System.Math.Max(array[num + i] + num4 / (double)num2, (!yDimension) ? item._gcc._minWidth : item._gcc._minHeight);
				}
			}

			// Token: 0x060003D7 RID: 983 RVA: 0x00010908 File Offset: 0x0000EB08
			private void ResizeItemHelper(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, double deltaX, double deltaY, global::System.Collections.Generic.IList<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> synchronizedItems)
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] array;
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo resizeItemInfosHelper = this.GetResizeItemInfosHelper(item, synchronizedItems, out array);
				global::System.Windows.Size size = this.CalcNewSizeHelper(resizeItemInfosHelper, deltaX, deltaY);
				this.ResizeItemsHelper(array, this.CreateSizeArr(size, array.Length), !global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IsCloseToZero(deltaX), !global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IsCloseToZero(deltaY));
			}

			// Token: 0x060003D8 RID: 984 RVA: 0x00010950 File Offset: 0x0000EB50
			private void ResizeItemsHelper(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] resizeItems, global::System.Windows.Size[] newSizes, bool yDimension)
			{
				global::System.Windows.Rect containerBoundsHelper = global::Infragistics.Controls.Layouts.Primitives.LayoutManagerBase.GetContainerBoundsHelper(this._layoutContainer, this._containerContext, this._layoutManager);
				global::System.Windows.Size size = this._layoutManager.CalculatePreferredSize(this._layoutContainer, this._containerContext);
				bool flag = (!yDimension) ? (this._autoFitWidth || (this._layoutManager.ExpandToFitWidth && !global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.AreClose(containerBoundsHelper.Width, size.Width, 1.0))) : (this._autoFitHeight || (this._layoutManager.ExpandToFitHeight && !global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.AreClose(containerBoundsHelper.Height, size.Height, 1.0)));
				if (flag && 1 == this._resizeStrategy)
				{
					this.SetPreferredSizesToActual(yDimension, true);
				}
				this.ClearIsAutoState(resizeItems, !yDimension, yDimension, true, true);
				if (this._isAutoSizing)
				{
					this.SetIsAutoState(resizeItems, (!yDimension) ? new bool?(true) : null, yDimension ? new bool?(true) : null);
				}
				this.SortResizeItemsHelper(resizeItems, newSizes, false);
				int num = (!flag) ? 1 : 20;
				if (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutMode.Uniform == this._layoutManager.LayoutMode)
				{
					global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> currentItemSizes = this.GetCurrentItemSizes();
					double num2 = 0.0;
					for (int i = 0; i < num; i++)
					{
						this.SetPreferredSizesToActual(yDimension, true);
						for (int j = 0; j < resizeItems.Length; j++)
						{
							global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo item = resizeItems[0];
							global::System.Windows.Size size2 = newSizes[j];
							if (i == 0)
							{
								num2 = global::System.Math.Max(num2, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.CalcAbsoluteDelta(item, size2, yDimension));
							}
							if (!yDimension)
							{
								this.ResizeLogicalDims(item, size2.Width, false);
							}
							else
							{
								this.ResizeLogicalDims(item, size2.Height, true);
							}
						}
						if (i > 0 && flag)
						{
							bool flag2 = false;
							global::System.Collections.Generic.HashSet<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo> hashSet = new global::System.Collections.Generic.HashSet<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo>(resizeItems);
							foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo in this._infos)
							{
								if (!hashSet.Contains(layoutItemInfo))
								{
									double num3 = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.CalcAbsoluteDelta(layoutItemInfo, currentItemSizes[layoutItemInfo], yDimension);
									if (num3 > num2)
									{
										flag2 = true;
										break;
									}
								}
							}
							if (flag2)
							{
								return;
							}
						}
						this.SetPreferredSizesToActual(yDimension, false, false);
						this.ReCalculateLayout(true);
					}
					return;
				}
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, double> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, double>();
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, double> dictionary2 = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, double>();
				for (int l = 0; l < num; l++)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutCache glc = this._glc;
					if (yDimension)
					{
						double[] rowCoordinates = glc._rowCoordinates;
					}
					else
					{
						double[] colCoordinates = glc._colCoordinates;
					}
					this.CreateCoordinates((!yDimension) ? glc._colWidthsPref : glc._rowHeightsPref);
					bool flag3 = true;
					bool flag4 = false;
					int m = 0;
					while (m < resizeItems.Length)
					{
						global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo2 = resizeItems[m];
						double num4 = this.CalcDeltaHelper(resizeItems, newSizes, ref m, yDimension);
						global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions dim = layoutItemInfo2._dim;
						if (0.0 != num4 && (l <= 0 || flag))
						{
							foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo3 in this.GetItemsEndingAt((!yDimension) ? dim.ColumnRight : dim.RowBottom, yDimension))
							{
								global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions dim2 = layoutItemInfo3._dim;
								double num5 = 1.0;
								double num6;
								if (dictionary.TryGetValue(layoutItemInfo3, out num6))
								{
									double num7 = num6 - num4;
									if (!global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IsCloseToZero(num6) && !global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.IsCloseToZero(num7))
									{
										num5 = num6 * dictionary2[layoutItemInfo3] / num7;
									}
								}
								global::System.Windows.Size preferredSize = layoutItemInfo3._preferredSize;
								if (this._layoutManager.PreferredSizeIncludesMargin)
								{
									this.RemoveMargin(ref preferredSize, layoutItemInfo3);
								}
								global::System.Windows.Size newSize = preferredSize;
								double num8 = (!yDimension) ? (preferredSize.Width + num4 * num5) : (preferredSize.Height + num4 * num5);
								if (!yDimension)
								{
									newSize.Width = global::System.Math.Max(layoutItemInfo3._gcc._minWidth, global::System.Math.Min(layoutItemInfo3._gcc._maxWidth, num8));
								}
								else
								{
									newSize.Height = global::System.Math.Max(layoutItemInfo3._gcc._minHeight, global::System.Math.Min(layoutItemInfo3._gcc._maxHeight, num8));
								}
								flag4 = (flag4 || !global::Infragistics.CoreUtilities.AreClose(num8, (!yDimension) ? newSize.Width : newSize.Height));
								this.SetPreferredSize(layoutItemInfo3, newSize, !yDimension, yDimension);
								dictionary[layoutItemInfo3] = num4;
								dictionary2[layoutItemInfo3] = num5;
								flag3 = false;
							}
						}
					}
					if (flag)
					{
						if (this._resizeStrategy == 0 || flag4 || flag3 || l == num - 1)
						{
							this.SetPreferredSizesToActual(yDimension, false);
							dictionary.Clear();
							dictionary2.Clear();
						}
						this.ReCalculateLayout();
					}
					if (flag3)
					{
						break;
					}
					if (l > 0 && !flag)
					{
						return;
					}
				}
			}

			// Token: 0x060003D9 RID: 985 RVA: 0x00010DEE File Offset: 0x0000EFEE
			private void ResizeItemsHelper(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] resizeItems, global::System.Windows.Size[] newSizes, bool resizeWidth, bool resizeHeight)
			{
				if (resizeWidth)
				{
					this.ResizeItemsHelper(resizeItems, newSizes, false);
				}
				if (resizeHeight)
				{
					this.ResizeItemsHelper(resizeItems, newSizes, true);
				}
			}

			// Token: 0x060003DA RID: 986 RVA: 0x00010E0C File Offset: 0x0000F00C
			private void SetIsAutoState(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] items, bool? isAutoWidth, bool? isAutoHeight)
			{
				foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo in items)
				{
					if (isAutoWidth != null)
					{
						layoutItemInfo._isAutoWidth = isAutoWidth.Value;
					}
					if (isAutoHeight != null)
					{
						layoutItemInfo._isAutoHeight = isAutoHeight.Value;
					}
				}
			}

			// Token: 0x060003DB RID: 987 RVA: 0x00010E58 File Offset: 0x0000F058
			private void SetPreferredSize(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo ii, global::System.Windows.Size newSize, bool modifyWidth, bool modifyHeight)
			{
				if (this._layoutManager.PreferredSizeIncludesMargin)
				{
					this.AddMargin(ref newSize, ii);
				}
				if (modifyWidth)
				{
					ii._preferredSize.Width = newSize.Width;
				}
				if (modifyHeight)
				{
					ii._preferredSize.Height = newSize.Height;
				}
			}

			// Token: 0x060003DC RID: 988 RVA: 0x00010EA8 File Offset: 0x0000F0A8
			private void SetPreferredSizes(global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> sizesToSet)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size> keyValuePair in sizesToSet)
				{
					keyValuePair.Key._preferredSize = keyValuePair.Value;
				}
			}

			// Token: 0x060003DD RID: 989 RVA: 0x00010F04 File Offset: 0x0000F104
			private void SetPreferredSizesToActual(bool yDimension, bool exceptAutoSizedItems)
			{
				this.SetPreferredSizesToActual(yDimension, exceptAutoSizedItems, true);
			}

			// Token: 0x060003DE RID: 990 RVA: 0x00010F10 File Offset: 0x0000F110
			private void SetPreferredSizesToActual(bool yDimension, bool exceptAutoSizedItems, bool invalidateLayout)
			{
				this.ReCalculateLayout(invalidateLayout);
				foreach (global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo layoutItemInfo in this._infos)
				{
					bool flag = (!yDimension) ? layoutItemInfo._isAutoWidth : layoutItemInfo._isAutoHeight;
					if (!flag || !exceptAutoSizedItems)
					{
						this.SetPreferredSize(layoutItemInfo, layoutItemInfo._dim.Bounds.Size, !yDimension, yDimension);
					}
				}
			}

			// Token: 0x060003DF RID: 991 RVA: 0x00011014 File Offset: 0x0000F214
			private void SortResizeItemsHelper(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] resizeItems, global::System.Windows.Size[] newSizes, bool yWise)
			{
				int[] array = new int[resizeItems.Length];
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ArrInitIndeces(array);
				global::Infragistics.CoreUtilities.SortMergeGeneric<int>(array, global::Infragistics.CoreUtilities.CreateComparer<int>(delegate(int x, int y)
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions dim = resizeItems[x]._dim;
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions dim2 = resizeItems[y]._dim;
					int num;
					if (!yWise)
					{
						num = dim.ColumnRight.CompareTo(dim2.ColumnRight);
						if (num == 0)
						{
							num = dim.Column.CompareTo(dim2.Column);
						}
					}
					else
					{
						num = dim.RowBottom.CompareTo(dim2.RowBottom);
						if (num == 0)
						{
							num = dim.Row.CompareTo(dim2.Row);
						}
					}
					return num;
				}));
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.ArrayMove<global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo, global::System.Windows.Size>(resizeItems, newSizes, array);
			}

			// Token: 0x04000158 RID: 344
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _layoutManager;

			// Token: 0x04000159 RID: 345
			private global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer _layoutContainer;

			// Token: 0x0400015A RID: 346
			private object _containerContext;

			// Token: 0x0400015B RID: 347
			private bool _autoFitWidth;

			// Token: 0x0400015C RID: 348
			private bool _autoFitHeight;

			// Token: 0x0400015D RID: 349
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[] _infos;

			// Token: 0x0400015E RID: 350
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutCache _glc;

			// Token: 0x0400015F RID: 351
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo> _mappings;

			// Token: 0x04000160 RID: 352
			private global::System.Collections.Generic.Dictionary<int, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[]> _itemsEndingAtCache = new global::System.Collections.Generic.Dictionary<int, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.ResizeManager.LayoutItemInfo[]>();

			// Token: 0x04000161 RID: 353
			internal bool _isAutoSizing;

			// Token: 0x04000162 RID: 354
			internal int _resizeStrategy = 1;

			// Token: 0x02000061 RID: 97
			private class LayoutItemInfo : global::Infragistics.Controls.Layouts.Primitives.IAutoSizeLayoutItem, global::Infragistics.Controls.Layouts.Primitives.ILayoutItem
			{
				// Token: 0x060003E6 RID: 998 RVA: 0x00011070 File Offset: 0x0000F270
				internal LayoutItemInfo(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem i)
				{
					this._i = i;
					this._preferredSize = i.PreferredSize;
					global::Infragistics.Controls.Layouts.Primitives.IAutoSizeLayoutItem autoSizeLayoutItem = i as global::Infragistics.Controls.Layouts.Primitives.IAutoSizeLayoutItem;
					this._isAutoWidth = (autoSizeLayoutItem != null && autoSizeLayoutItem.IsWidthAutoSized);
					this._isAutoHeight = (autoSizeLayoutItem != null && autoSizeLayoutItem.IsHeightAutoSized);
				}

				// Token: 0x1700008C RID: 140
				// (get) Token: 0x060003E7 RID: 999 RVA: 0x000110C1 File Offset: 0x0000F2C1
				public global::System.Windows.Visibility Visibility
				{
					get
					{
						return this._i.Visibility;
					}
				}

				// Token: 0x1700008D RID: 141
				// (get) Token: 0x060003E8 RID: 1000 RVA: 0x000110CE File Offset: 0x0000F2CE
				public global::System.Windows.Size MaximumSize
				{
					get
					{
						return this._i.MaximumSize;
					}
				}

				// Token: 0x1700008E RID: 142
				// (get) Token: 0x060003E9 RID: 1001 RVA: 0x000110DB File Offset: 0x0000F2DB
				public global::System.Windows.Size MinimumSize
				{
					get
					{
						return this._i.MinimumSize;
					}
				}

				// Token: 0x1700008F RID: 143
				// (get) Token: 0x060003EA RID: 1002 RVA: 0x000110E8 File Offset: 0x0000F2E8
				public global::System.Windows.Size PreferredSize
				{
					get
					{
						return this._preferredSize;
					}
				}

				// Token: 0x17000090 RID: 144
				// (get) Token: 0x060003EB RID: 1003 RVA: 0x000110F0 File Offset: 0x0000F2F0
				public bool IsWidthAutoSized
				{
					get
					{
						return this._isAutoWidth;
					}
				}

				// Token: 0x17000091 RID: 145
				// (get) Token: 0x060003EC RID: 1004 RVA: 0x000110F8 File Offset: 0x0000F2F8
				public bool IsHeightAutoSized
				{
					get
					{
						return this._isAutoHeight;
					}
				}

				// Token: 0x04000163 RID: 355
				internal global::Infragistics.Controls.Layouts.Primitives.ILayoutItem _i;

				// Token: 0x04000164 RID: 356
				internal global::System.Windows.Size _preferredSize;

				// Token: 0x04000165 RID: 357
				internal global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagConstraintCache _gcc;

				// Token: 0x04000166 RID: 358
				internal global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions _dim;

				// Token: 0x04000167 RID: 359
				internal bool _isAutoWidth;

				// Token: 0x04000168 RID: 360
				internal bool _isAutoHeight;
			}
		}

		// Token: 0x02000062 RID: 98
		[global::System.Flags]
		private enum Side
		{
			// Token: 0x0400016A RID: 362
			None = 0,
			// Token: 0x0400016B RID: 363
			Left = 1,
			// Token: 0x0400016C RID: 364
			Top = 2,
			// Token: 0x0400016D RID: 365
			Right = 4,
			// Token: 0x0400016E RID: 366
			Bottom = 8,
			// Token: 0x0400016F RID: 367
			All = 15
		}

		// Token: 0x02000063 RID: 99
		public enum GridBagLayoutMode
		{
			// Token: 0x04000171 RID: 369
			Standard,
			// Token: 0x04000172 RID: 370
			LeftToRight,
			// Token: 0x04000173 RID: 371
			Uniform
		}
	}
}
