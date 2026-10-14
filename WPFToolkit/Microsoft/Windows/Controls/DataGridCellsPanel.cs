using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Windows.Controls.Primitives;
using MS.Internal;

namespace Microsoft.Windows.Controls
{
	// Token: 0x0200004F RID: 79
	public class DataGridCellsPanel : global::System.Windows.Controls.VirtualizingPanel
	{
		// Token: 0x06000651 RID: 1617 RVA: 0x0001924B File Offset: 0x0001744B
		static DataGridCellsPanel()
		{
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridCellsPanel), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0001926C File Offset: 0x0001746C
		public DataGridCellsPanel()
		{
			this.IsVirtualizing = false;
			this.InRecyclingMode = false;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00019290 File Offset: 0x00017490
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			global::System.Windows.Size result = default(global::System.Windows.Size);
			this.DetermineVirtualizationState();
			this.EnsureRealizedChildren();
			global::System.Collections.IList realizedChildren = this.RealizedChildren;
			if (this.RebuildRealizedColumnsBlockList)
			{
				result = this.DetermineRealizedColumnsBlockList(constraint);
			}
			else
			{
				result = this.GenerateAndMeasureChildrenForRealizedColumns(constraint);
			}
			if (this.IsVirtualizing && this.InRecyclingMode)
			{
				this.DisconnectRecycledContainers();
			}
			return result;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000192EC File Offset: 0x000174EC
		private static void MeasureChild(global::System.Windows.UIElement child, global::System.Windows.Size constraint)
		{
			global::Microsoft.Windows.Controls.IProvideDataGridColumn provideDataGridColumn = child as global::Microsoft.Windows.Controls.IProvideDataGridColumn;
			bool flag = child is global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader;
			global::System.Windows.Size availableSize = new global::System.Windows.Size(double.PositiveInfinity, constraint.Height);
			double num = 0.0;
			bool flag2 = false;
			if (provideDataGridColumn != null)
			{
				global::Microsoft.Windows.Controls.DataGridColumn column = provideDataGridColumn.Column;
				global::Microsoft.Windows.Controls.DataGridLength width = column.Width;
				if (width.IsAuto || (width.IsSizeToHeader && flag) || (width.IsSizeToCells && !flag))
				{
					child.Measure(availableSize);
					num = child.DesiredSize.Width;
					flag2 = true;
				}
				availableSize.Width = column.GetConstraintWidth(flag);
			}
			if (global::MS.Internal.DoubleUtil.AreClose(num, 0.0))
			{
				child.Measure(availableSize);
			}
			global::System.Windows.Size desiredSize = child.DesiredSize;
			if (provideDataGridColumn != null)
			{
				global::Microsoft.Windows.Controls.DataGridColumn column2 = provideDataGridColumn.Column;
				column2.UpdateDesiredWidthForAutoColumn(flag, global::MS.Internal.DoubleUtil.AreClose(num, 0.0) ? desiredSize.Width : num);
				global::Microsoft.Windows.Controls.DataGridLength width2 = column2.Width;
				if (flag2 && !global::MS.Internal.DoubleUtil.IsNaN(width2.DisplayValue) && global::MS.Internal.DoubleUtil.GreaterThan(num, width2.DisplayValue))
				{
					availableSize.Width = width2.DisplayValue;
					child.Measure(availableSize);
				}
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0001941C File Offset: 0x0001761C
		private global::System.Windows.Size GenerateAndMeasureChildrenForRealizedColumns(global::System.Windows.Size constraint)
		{
			double num = 0.0;
			double num2 = 0.0;
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			double averageColumnWidth = parentDataGrid.InternalColumns.AverageColumnWidth;
			global::System.Windows.Controls.Primitives.IItemContainerGenerator itemContainerGenerator = base.ItemContainerGenerator;
			global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> realizedColumnsBlockList = this.RealizedColumnsBlockList;
			this.VirtualizeChildren(realizedColumnsBlockList, itemContainerGenerator);
			if (realizedColumnsBlockList.Count > 0)
			{
				int i = 0;
				int count = realizedColumnsBlockList.Count;
				while (i < count)
				{
					global::Microsoft.Windows.Controls.RealizedColumnsBlock realizedColumnsBlock = realizedColumnsBlockList[i];
					global::System.Windows.Size size = this.GenerateChildren(itemContainerGenerator, realizedColumnsBlock.StartIndex, realizedColumnsBlock.EndIndex, constraint);
					num += size.Width;
					num2 = global::System.Math.Max(num2, size.Height);
					if (i != count - 1)
					{
						global::Microsoft.Windows.Controls.RealizedColumnsBlock realizedColumnsBlock2 = realizedColumnsBlockList[i + 1];
						num += this.GetColumnEstimatedMeasureWidthSum(realizedColumnsBlock.EndIndex + 1, realizedColumnsBlock2.StartIndex - 1, averageColumnWidth);
					}
					i++;
				}
				num += this.GetColumnEstimatedMeasureWidthSum(0, realizedColumnsBlockList[0].StartIndex - 1, averageColumnWidth);
				num += this.GetColumnEstimatedMeasureWidthSum(realizedColumnsBlockList[realizedColumnsBlockList.Count - 1].EndIndex + 1, parentDataGrid.Columns.Count - 1, averageColumnWidth);
			}
			else
			{
				num = 0.0;
			}
			return new global::System.Windows.Size(num, num2);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00019564 File Offset: 0x00017764
		private global::System.Windows.Size DetermineRealizedColumnsBlockList(global::System.Windows.Size constraint)
		{
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			global::System.Collections.Generic.List<int> list2 = new global::System.Collections.Generic.List<int>();
			global::System.Windows.Size result = default(global::System.Windows.Size);
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			if (parentDataGrid == null)
			{
				return result;
			}
			double horizontalScrollOffset = parentDataGrid.HorizontalScrollOffset;
			double cellsPanelHorizontalOffset = parentDataGrid.CellsPanelHorizontalOffset;
			double num = horizontalScrollOffset;
			double num2 = -cellsPanelHorizontalOffset;
			double num3 = horizontalScrollOffset - cellsPanelHorizontalOffset;
			int num4 = -1;
			int lastVisibleNonFrozenDisplayIndex = -1;
			double num5 = this.GetViewportWidth() - cellsPanelHorizontalOffset;
			double num6 = 0.0;
			if (global::MS.Internal.DoubleUtil.LessThan(num5, 0.0))
			{
				return result;
			}
			bool hasVisibleStarColumns = parentDataGrid.InternalColumns.HasVisibleStarColumns;
			double averageColumnWidth = parentDataGrid.InternalColumns.AverageColumnWidth;
			bool flag = global::MS.Internal.DoubleUtil.AreClose(averageColumnWidth, 0.0);
			bool flag2 = !this.IsVirtualizing;
			bool flag3 = flag || hasVisibleStarColumns || flag2;
			int frozenColumnCount = parentDataGrid.FrozenColumnCount;
			int num7 = -1;
			bool redeterminationNeeded = false;
			global::System.Windows.Controls.Primitives.IItemContainerGenerator itemContainerGenerator = base.ItemContainerGenerator;
			global::System.IDisposable disposable = null;
			int num8 = 0;
			try
			{
				int i = 0;
				int count = parentDataGrid.Columns.Count;
				while (i < count)
				{
					global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = parentDataGrid.ColumnFromDisplayIndex(i);
					if (dataGridColumn.IsVisible)
					{
						int num9 = parentDataGrid.ColumnIndexFromDisplayIndex(i);
						if (num9 != num8 || num7 != num9 - 1)
						{
							num8 = num9;
							if (disposable != null)
							{
								disposable.Dispose();
								disposable = null;
							}
						}
						num7 = num9;
						global::System.Windows.Size size;
						if (flag3)
						{
							if (this.GenerateChild(itemContainerGenerator, constraint, dataGridColumn, ref disposable, ref num8, out size) == null)
							{
								break;
							}
						}
						else
						{
							size = new global::System.Windows.Size(global::Microsoft.Windows.Controls.DataGridCellsPanel.GetColumnEstimatedMeasureWidth(dataGridColumn, averageColumnWidth), 0.0);
						}
						if (flag2 || hasVisibleStarColumns || global::MS.Internal.DoubleUtil.LessThan(num6, num5))
						{
							if (i < frozenColumnCount)
							{
								if (!flag3 && this.GenerateChild(itemContainerGenerator, constraint, dataGridColumn, ref disposable, ref num8, out size) == null)
								{
									break;
								}
								list.Add(num9);
								list2.Add(i);
								num6 += size.Width;
								num += size.Width;
							}
							else if (global::MS.Internal.DoubleUtil.LessThanOrClose(num2, num3))
							{
								if (global::MS.Internal.DoubleUtil.LessThanOrClose(num2 + size.Width, num3))
								{
									if (flag3)
									{
										if (flag2 || hasVisibleStarColumns)
										{
											list.Add(num9);
											list2.Add(i);
										}
										else if (flag)
										{
											redeterminationNeeded = true;
										}
									}
									else if (disposable != null)
									{
										disposable.Dispose();
										disposable = null;
									}
									num2 += size.Width;
								}
								else
								{
									if (!flag3 && this.GenerateChild(itemContainerGenerator, constraint, dataGridColumn, ref disposable, ref num8, out size) == null)
									{
										break;
									}
									double num10 = num3 - num2;
									if (global::MS.Internal.DoubleUtil.AreClose(num10, 0.0))
									{
										num2 = num + size.Width;
										num6 += size.Width;
									}
									else
									{
										double num11 = size.Width - num10;
										num2 = num + num11;
										num6 += num11;
									}
									list.Add(num9);
									list2.Add(i);
									num4 = i;
									lastVisibleNonFrozenDisplayIndex = i;
								}
							}
							else
							{
								if (!flag3 && this.GenerateChild(itemContainerGenerator, constraint, dataGridColumn, ref disposable, ref num8, out size) == null)
								{
									break;
								}
								if (num4 < 0)
								{
									num4 = i;
								}
								lastVisibleNonFrozenDisplayIndex = i;
								num2 += size.Width;
								num6 += size.Width;
								list.Add(num9);
								list2.Add(i);
							}
						}
						result.Width += size.Width;
						result.Height = global::System.Math.Max(result.Height, size.Height);
					}
					i++;
				}
			}
			finally
			{
				if (disposable != null)
				{
					disposable.Dispose();
					disposable = null;
				}
			}
			if (!hasVisibleStarColumns && !flag2)
			{
				bool flag4 = this.ParentPresenter is global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter;
				if (flag4)
				{
					global::System.Windows.Size size2 = this.EnsureAtleastOneHeader(itemContainerGenerator, constraint, list, list2);
					result.Height = global::System.Math.Max(result.Height, size2.Height);
					redeterminationNeeded = true;
				}
				else
				{
					this.EnsureFocusTrail(list, list2, num4, lastVisibleNonFrozenDisplayIndex, constraint);
				}
			}
			this.UpdateRealizedBlockLists(list, list2, redeterminationNeeded);
			this.VirtualizeChildren(this.RealizedColumnsBlockList, itemContainerGenerator);
			return result;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00019944 File Offset: 0x00017B44
		private void UpdateRealizedBlockLists(global::System.Collections.Generic.List<int> realizedColumnIndices, global::System.Collections.Generic.List<int> realizedColumnDisplayIndices, bool redeterminationNeeded)
		{
			realizedColumnIndices.Sort();
			this.RealizedColumnsBlockList = global::Microsoft.Windows.Controls.DataGridCellsPanel.BuildRealizedColumnsBlockList(realizedColumnIndices);
			this.RealizedColumnsDisplayIndexBlockList = global::Microsoft.Windows.Controls.DataGridCellsPanel.BuildRealizedColumnsBlockList(realizedColumnDisplayIndices);
			if (!redeterminationNeeded)
			{
				this.RebuildRealizedColumnsBlockList = false;
			}
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00019970 File Offset: 0x00017B70
		private static global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> BuildRealizedColumnsBlockList(global::System.Collections.Generic.List<int> indexList)
		{
			global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> list = new global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock>();
			if (indexList.Count == 1)
			{
				list.Add(new global::Microsoft.Windows.Controls.RealizedColumnsBlock(indexList[0], indexList[0], 0));
			}
			else if (indexList.Count > 0)
			{
				int startIndex = indexList[0];
				int i = 1;
				int count = indexList.Count;
				while (i < count)
				{
					if (indexList[i] != indexList[i - 1] + 1)
					{
						if (list.Count == 0)
						{
							list.Add(new global::Microsoft.Windows.Controls.RealizedColumnsBlock(startIndex, indexList[i - 1], 0));
						}
						else
						{
							global::Microsoft.Windows.Controls.RealizedColumnsBlock realizedColumnsBlock = list[list.Count - 1];
							int startIndexOffset = realizedColumnsBlock.StartIndexOffset + realizedColumnsBlock.EndIndex - realizedColumnsBlock.StartIndex + 1;
							list.Add(new global::Microsoft.Windows.Controls.RealizedColumnsBlock(startIndex, indexList[i - 1], startIndexOffset));
						}
						startIndex = indexList[i];
					}
					if (i == count - 1)
					{
						if (list.Count == 0)
						{
							list.Add(new global::Microsoft.Windows.Controls.RealizedColumnsBlock(startIndex, indexList[i], 0));
						}
						else
						{
							global::Microsoft.Windows.Controls.RealizedColumnsBlock realizedColumnsBlock2 = list[list.Count - 1];
							int startIndexOffset2 = realizedColumnsBlock2.StartIndexOffset + realizedColumnsBlock2.EndIndex - realizedColumnsBlock2.StartIndex + 1;
							list.Add(new global::Microsoft.Windows.Controls.RealizedColumnsBlock(startIndex, indexList[i], startIndexOffset2));
						}
					}
					i++;
				}
			}
			return list;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00019ABC File Offset: 0x00017CBC
		private static global::System.Windows.Controls.Primitives.GeneratorPosition IndexToGeneratorPositionForStart(global::System.Windows.Controls.Primitives.IItemContainerGenerator generator, int index, out int childIndex)
		{
			global::System.Windows.Controls.Primitives.GeneratorPosition result = (generator != null) ? generator.GeneratorPositionFromIndex(index) : new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, index + 1);
			childIndex = ((result.Offset == 0) ? result.Index : (result.Index + 1));
			return result;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00019AFD File Offset: 0x00017CFD
		private global::System.Windows.UIElement GenerateChild(global::System.Windows.Controls.Primitives.IItemContainerGenerator generator, global::System.Windows.Size constraint, global::Microsoft.Windows.Controls.DataGridColumn column, ref global::System.IDisposable generatorState, ref int childIndex, out global::System.Windows.Size childSize)
		{
			if (generatorState == null)
			{
				generatorState = generator.StartAt(global::Microsoft.Windows.Controls.DataGridCellsPanel.IndexToGeneratorPositionForStart(generator, childIndex, out childIndex), global::System.Windows.Controls.Primitives.GeneratorDirection.Forward, true);
			}
			return this.GenerateChild(generator, constraint, column, ref childIndex, out childSize);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00019B28 File Offset: 0x00017D28
		private global::System.Windows.UIElement GenerateChild(global::System.Windows.Controls.Primitives.IItemContainerGenerator generator, global::System.Windows.Size constraint, global::Microsoft.Windows.Controls.DataGridColumn column, ref int childIndex, out global::System.Windows.Size childSize)
		{
			bool newlyRealized;
			global::System.Windows.UIElement uielement = generator.GenerateNext(out newlyRealized) as global::System.Windows.UIElement;
			if (uielement == null)
			{
				childSize = default(global::System.Windows.Size);
				return null;
			}
			this.AddContainerFromGenerator(childIndex, uielement, newlyRealized);
			childIndex++;
			global::Microsoft.Windows.Controls.DataGridCellsPanel.MeasureChild(uielement, constraint);
			global::Microsoft.Windows.Controls.DataGridLength width = column.Width;
			childSize = uielement.DesiredSize;
			if (!global::MS.Internal.DoubleUtil.IsNaN(width.DisplayValue))
			{
				childSize = new global::System.Windows.Size(width.DisplayValue, childSize.Height);
			}
			return uielement;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00019BA8 File Offset: 0x00017DA8
		private global::System.Windows.Size GenerateChildren(global::System.Windows.Controls.Primitives.IItemContainerGenerator generator, int startIndex, int endIndex, global::System.Windows.Size constraint)
		{
			double num = 0.0;
			double num2 = 0.0;
			int num3;
			global::System.Windows.Controls.Primitives.GeneratorPosition position = global::Microsoft.Windows.Controls.DataGridCellsPanel.IndexToGeneratorPositionForStart(generator, startIndex, out num3);
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			using (generator.StartAt(position, global::System.Windows.Controls.Primitives.GeneratorDirection.Forward, true))
			{
				for (int i = startIndex; i <= endIndex; i++)
				{
					if (parentDataGrid.Columns[i].IsVisible)
					{
						global::System.Windows.Size size;
						if (this.GenerateChild(generator, constraint, parentDataGrid.Columns[i], ref num3, out size) == null)
						{
							return new global::System.Windows.Size(num, num2);
						}
						num += size.Width;
						num2 = global::System.Math.Max(num2, size.Height);
					}
				}
			}
			return new global::System.Windows.Size(num, num2);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00019C74 File Offset: 0x00017E74
		private void AddContainerFromGenerator(int childIndex, global::System.Windows.UIElement child, bool newlyRealized)
		{
			if (!newlyRealized)
			{
				if (this.InRecyclingMode)
				{
					global::System.Collections.IList realizedChildren = this.RealizedChildren;
					if (childIndex >= realizedChildren.Count || realizedChildren[childIndex] != child)
					{
						this.InsertRecycledContainer(childIndex, child);
						child.Measure(default(global::System.Windows.Size));
						return;
					}
				}
			}
			else
			{
				this.InsertNewContainer(childIndex, child);
			}
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00019CC6 File Offset: 0x00017EC6
		private void InsertRecycledContainer(int childIndex, global::System.Windows.UIElement container)
		{
			this.InsertContainer(childIndex, container, true);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00019CD1 File Offset: 0x00017ED1
		private void InsertNewContainer(int childIndex, global::System.Windows.UIElement container)
		{
			this.InsertContainer(childIndex, container, false);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00019CDC File Offset: 0x00017EDC
		private void InsertContainer(int childIndex, global::System.Windows.UIElement container, bool isRecycled)
		{
			global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
			int num = 0;
			if (childIndex > 0)
			{
				num = this.ChildIndexFromRealizedIndex(childIndex - 1);
				num++;
			}
			if (!isRecycled || num >= internalChildren.Count || internalChildren[num] != container)
			{
				if (num < internalChildren.Count)
				{
					int num2 = num;
					if (isRecycled && global::System.Windows.Media.VisualTreeHelper.GetParent(container) != null)
					{
						int num3 = internalChildren.IndexOf(container);
						base.RemoveInternalChildRange(num3, 1);
						if (num3 < num2)
						{
							num2--;
						}
						base.InsertInternalChild(num2, container);
					}
					else
					{
						base.InsertInternalChild(num2, container);
					}
				}
				else if (isRecycled && global::System.Windows.Media.VisualTreeHelper.GetParent(container) != null)
				{
					int index = internalChildren.IndexOf(container);
					base.RemoveInternalChildRange(index, 1);
					base.AddInternalChild(container);
				}
				else
				{
					base.AddInternalChild(container);
				}
			}
			if (this.IsVirtualizing && this.InRecyclingMode)
			{
				this._realizedChildren.Insert(childIndex, container);
			}
			base.ItemContainerGenerator.PrepareItemContainer(container);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00019DB4 File Offset: 0x00017FB4
		private int ChildIndexFromRealizedIndex(int realizedChildIndex)
		{
			if (this.IsVirtualizing && this.InRecyclingMode && realizedChildIndex < this._realizedChildren.Count)
			{
				global::System.Windows.UIElement uielement = this._realizedChildren[realizedChildIndex];
				global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
				for (int i = realizedChildIndex; i < internalChildren.Count; i++)
				{
					if (internalChildren[i] == uielement)
					{
						return i;
					}
				}
			}
			return realizedChildIndex;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00019E14 File Offset: 0x00018014
		private static bool InBlockOrNextBlock(global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> blockList, int index, ref int blockIndex, ref global::Microsoft.Windows.Controls.RealizedColumnsBlock block, out bool pastLastBlock)
		{
			pastLastBlock = false;
			bool result = true;
			if (index < block.StartIndex)
			{
				result = false;
			}
			else if (index > block.EndIndex)
			{
				if (blockIndex == blockList.Count - 1)
				{
					blockIndex++;
					pastLastBlock = true;
					result = false;
				}
				else
				{
					block = blockList[++blockIndex];
					if (index < block.StartIndex || index > block.EndIndex)
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00019E84 File Offset: 0x00018084
		private global::System.Windows.Size EnsureAtleastOneHeader(global::System.Windows.Controls.Primitives.IItemContainerGenerator generator, global::System.Windows.Size constraint, global::System.Collections.Generic.List<int> realizedColumnIndices, global::System.Collections.Generic.List<int> realizedColumnDisplayIndices)
		{
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			int count = parentDataGrid.Columns.Count;
			global::System.Windows.Size result = default(global::System.Windows.Size);
			if (this.RealizedChildren.Count == 0 && count > 0)
			{
				for (int i = 0; i < count; i++)
				{
					global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = parentDataGrid.Columns[i];
					if (dataGridColumn.IsVisible)
					{
						int index = i;
						using (generator.StartAt(global::Microsoft.Windows.Controls.DataGridCellsPanel.IndexToGeneratorPositionForStart(generator, index, out index), global::System.Windows.Controls.Primitives.GeneratorDirection.Forward, true))
						{
							global::System.Windows.UIElement uielement = this.GenerateChild(generator, constraint, dataGridColumn, ref index, out result);
							if (uielement != null)
							{
								int num = 0;
								global::Microsoft.Windows.Controls.DataGridCellsPanel.AddToIndicesListIfNeeded(realizedColumnIndices, realizedColumnDisplayIndices, i, dataGridColumn.DisplayIndex, ref num);
								return result;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00019F48 File Offset: 0x00018148
		private void EnsureFocusTrail(global::System.Collections.Generic.List<int> realizedColumnIndices, global::System.Collections.Generic.List<int> realizedColumnDisplayIndices, int firstVisibleNonFrozenDisplayIndex, int lastVisibleNonFrozenDisplayIndex, global::System.Windows.Size constraint)
		{
			if (firstVisibleNonFrozenDisplayIndex < 0)
			{
				return;
			}
			int frozenColumnCount = this.ParentDataGrid.FrozenColumnCount;
			int count = this.Columns.Count;
			global::System.Windows.Controls.ItemsControl parentPresenter = this.ParentPresenter;
			if (parentPresenter == null)
			{
				return;
			}
			global::System.Windows.Controls.ItemContainerGenerator itemContainerGenerator = parentPresenter.ItemContainerGenerator;
			int num = 0;
			int num2 = -1;
			for (int i = 0; i < firstVisibleNonFrozenDisplayIndex; i++)
			{
				if (this.GenerateChildForFocusTrail(itemContainerGenerator, realizedColumnIndices, realizedColumnDisplayIndices, constraint, i, ref num))
				{
					num2 = i;
					break;
				}
			}
			if (num2 < frozenColumnCount)
			{
				for (int j = frozenColumnCount; j < count; j++)
				{
					if (this.GenerateChildForFocusTrail(itemContainerGenerator, realizedColumnIndices, realizedColumnDisplayIndices, constraint, j, ref num))
					{
						num2 = j;
						break;
					}
				}
			}
			for (int k = firstVisibleNonFrozenDisplayIndex - 1; k > num2; k--)
			{
				if (this.GenerateChildForFocusTrail(itemContainerGenerator, realizedColumnIndices, realizedColumnDisplayIndices, constraint, k, ref num))
				{
					num2 = k;
					break;
				}
			}
			for (int l = lastVisibleNonFrozenDisplayIndex + 1; l < count; l++)
			{
				if (this.GenerateChildForFocusTrail(itemContainerGenerator, realizedColumnIndices, realizedColumnDisplayIndices, constraint, l, ref num))
				{
					num2 = l;
					break;
				}
			}
			for (int m = count - 1; m > num2; m--)
			{
				if (this.GenerateChildForFocusTrail(itemContainerGenerator, realizedColumnIndices, realizedColumnDisplayIndices, constraint, m, ref num))
				{
					return;
				}
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0001A058 File Offset: 0x00018258
		private bool GenerateChildForFocusTrail(global::System.Windows.Controls.ItemContainerGenerator generator, global::System.Collections.Generic.List<int> realizedColumnIndices, global::System.Collections.Generic.List<int> realizedColumnDisplayIndices, global::System.Windows.Size constraint, int displayIndex, ref int displayIndexListIterator)
		{
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = parentDataGrid.ColumnFromDisplayIndex(displayIndex);
			if (dataGridColumn.IsVisible)
			{
				int num = parentDataGrid.ColumnIndexFromDisplayIndex(displayIndex);
				global::System.Windows.UIElement uielement = generator.ContainerFromIndex(num) as global::System.Windows.UIElement;
				if (uielement == null)
				{
					int index = num;
					using (((global::System.Windows.Controls.Primitives.IItemContainerGenerator)generator).StartAt(global::Microsoft.Windows.Controls.DataGridCellsPanel.IndexToGeneratorPositionForStart(generator, index, out index), global::System.Windows.Controls.Primitives.GeneratorDirection.Forward, true))
					{
						global::System.Windows.Size size;
						uielement = this.GenerateChild(generator, constraint, dataGridColumn, ref index, out size);
					}
				}
				if (uielement != null && global::Microsoft.Windows.Controls.DataGridHelper.TreeHasFocusAndTabStop(uielement))
				{
					global::Microsoft.Windows.Controls.DataGridCellsPanel.AddToIndicesListIfNeeded(realizedColumnIndices, realizedColumnDisplayIndices, num, displayIndex, ref displayIndexListIterator);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0001A0F4 File Offset: 0x000182F4
		private static void AddToIndicesListIfNeeded(global::System.Collections.Generic.List<int> realizedColumnIndices, global::System.Collections.Generic.List<int> realizedColumnDisplayIndices, int columnIndex, int displayIndex, ref int displayIndexListIterator)
		{
			int count = realizedColumnDisplayIndices.Count;
			while (displayIndexListIterator < count)
			{
				if (realizedColumnDisplayIndices[displayIndexListIterator] == displayIndex)
				{
					return;
				}
				if (realizedColumnDisplayIndices[displayIndexListIterator] > displayIndex)
				{
					realizedColumnDisplayIndices.Insert(displayIndexListIterator, displayIndex);
					realizedColumnIndices.Add(columnIndex);
					return;
				}
				displayIndexListIterator++;
			}
			realizedColumnIndices.Add(columnIndex);
			realizedColumnDisplayIndices.Add(displayIndex);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0001A150 File Offset: 0x00018350
		private void VirtualizeChildren(global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> blockList, global::System.Windows.Controls.Primitives.IItemContainerGenerator generator)
		{
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Windows.Controls.DataGridColumn> columns = parentDataGrid.Columns;
			int count = columns.Count;
			int num = 0;
			global::System.Collections.IList realizedChildren = this.RealizedChildren;
			int num2 = realizedChildren.Count;
			if (num2 == 0)
			{
				return;
			}
			int index = 0;
			int count2 = blockList.Count;
			global::Microsoft.Windows.Controls.RealizedColumnsBlock realizedColumnsBlock = (count2 > 0) ? blockList[index] : new global::Microsoft.Windows.Controls.RealizedColumnsBlock(-1, -1, -1);
			bool flag = count2 <= 0;
			int num3 = -1;
			int num4 = 0;
			int num5 = -1;
			global::System.Windows.Controls.ItemsControl parentPresenter = this.ParentPresenter;
			global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter dataGridCellsPresenter = parentPresenter as global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter;
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter dataGridColumnHeadersPresenter = parentPresenter as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter;
			for (int i = 0; i < num2; i++)
			{
				int num6 = i;
				global::System.Windows.UIElement uielement = realizedChildren[i] as global::System.Windows.UIElement;
				global::Microsoft.Windows.Controls.IProvideDataGridColumn provideDataGridColumn = uielement as global::Microsoft.Windows.Controls.IProvideDataGridColumn;
				if (provideDataGridColumn != null)
				{
					global::Microsoft.Windows.Controls.DataGridColumn column = provideDataGridColumn.Column;
					while (num < count && column != columns[num])
					{
						num++;
					}
					num6 = num++;
				}
				bool flag2 = flag || !global::Microsoft.Windows.Controls.DataGridCellsPanel.InBlockOrNextBlock(blockList, num6, ref index, ref realizedColumnsBlock, out flag);
				global::Microsoft.Windows.Controls.DataGridCell dataGridCell = uielement as global::Microsoft.Windows.Controls.DataGridCell;
				if ((dataGridCell != null && (dataGridCell.IsEditing || dataGridCell.IsKeyboardFocusWithin || dataGridCell == parentDataGrid.FocusedCell)) || (dataGridCellsPresenter != null && dataGridCellsPresenter.IsItemItsOwnContainerInternal(dataGridCellsPresenter.Items[num6])) || (dataGridColumnHeadersPresenter != null && dataGridColumnHeadersPresenter.IsItemItsOwnContainerInternal(dataGridColumnHeadersPresenter.Items[num6])))
				{
					flag2 = false;
				}
				if (!columns[num6].IsVisible)
				{
					flag2 = true;
				}
				if (flag2)
				{
					if (num3 == -1)
					{
						num3 = i;
						num4 = 1;
					}
					else if (num5 == num6 - 1)
					{
						num4++;
					}
					else
					{
						this.CleanupRange(realizedChildren, generator, num3, num4);
						num2 -= num4;
						i -= num4;
						num4 = 1;
						num3 = i;
					}
					num5 = num6;
				}
				else if (num4 > 0)
				{
					this.CleanupRange(realizedChildren, generator, num3, num4);
					num2 -= num4;
					i -= num4;
					num4 = 0;
					num3 = -1;
				}
			}
			if (num4 > 0)
			{
				this.CleanupRange(realizedChildren, generator, num3, num4);
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0001A34C File Offset: 0x0001854C
		private void CleanupRange(global::System.Collections.IList children, global::System.Windows.Controls.Primitives.IItemContainerGenerator generator, int startIndex, int count)
		{
			if (count <= 0)
			{
				return;
			}
			if (this.IsVirtualizing && this.InRecyclingMode)
			{
				global::System.Windows.Controls.Primitives.GeneratorPosition position = new global::System.Windows.Controls.Primitives.GeneratorPosition(startIndex, 0);
				((global::System.Windows.Controls.Primitives.IRecyclingItemContainerGenerator)generator).Recycle(position, count);
				this._realizedChildren.RemoveRange(startIndex, count);
				return;
			}
			base.RemoveInternalChildRange(startIndex, count);
			generator.Remove(new global::System.Windows.Controls.Primitives.GeneratorPosition(startIndex, 0), count);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0001A3B0 File Offset: 0x000185B0
		private void DisconnectRecycledContainers()
		{
			int num = 0;
			global::System.Windows.UIElement uielement = (this._realizedChildren.Count > 0) ? this._realizedChildren[0] : null;
			global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
			int num2 = -1;
			int num3 = 0;
			for (int i = 0; i < internalChildren.Count; i++)
			{
				global::System.Windows.UIElement uielement2 = internalChildren[i];
				if (uielement2 == uielement)
				{
					if (num3 > 0)
					{
						base.RemoveInternalChildRange(num2, num3);
						i -= num3;
						num3 = 0;
						num2 = -1;
					}
					num++;
					if (num < this._realizedChildren.Count)
					{
						uielement = this._realizedChildren[num];
					}
					else
					{
						uielement = null;
					}
				}
				else
				{
					if (num2 == -1)
					{
						num2 = i;
					}
					num3++;
				}
			}
			if (num3 > 0)
			{
				base.RemoveInternalChildRange(num2, num3);
			}
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0001A46C File Offset: 0x0001866C
		private void InitializeArrangeState(global::Microsoft.Windows.Controls.DataGridCellsPanel.ArrangeState arrangeState)
		{
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			double horizontalScrollOffset = parentDataGrid.HorizontalScrollOffset;
			double cellsPanelHorizontalOffset = parentDataGrid.CellsPanelHorizontalOffset;
			arrangeState.NextFrozenCellStart = horizontalScrollOffset;
			arrangeState.NextNonFrozenCellStart -= cellsPanelHorizontalOffset;
			arrangeState.ViewportStartX = horizontalScrollOffset - cellsPanelHorizontalOffset;
			arrangeState.FrozenColumnCount = parentDataGrid.FrozenColumnCount;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0001A4B8 File Offset: 0x000186B8
		private void FinishArrange(global::Microsoft.Windows.Controls.DataGridCellsPanel.ArrangeState arrangeState)
		{
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			if (parentDataGrid != null)
			{
				parentDataGrid.NonFrozenColumnsViewportHorizontalOffset = arrangeState.DataGridHorizontalScrollStartX;
			}
			if (arrangeState.OldClippedChild != null)
			{
				arrangeState.OldClippedChild.CoerceValue(global::System.Windows.UIElement.ClipProperty);
			}
			this._clippedChildForFrozenBehaviour = arrangeState.NewClippedChild;
			if (this._clippedChildForFrozenBehaviour != null)
			{
				this._clippedChildForFrozenBehaviour.CoerceValue(global::System.Windows.UIElement.ClipProperty);
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0001A517 File Offset: 0x00018717
		private void SetDataGridCellPanelWidth(global::System.Collections.IList children, double newWidth)
		{
			if (children.Count != 0 && children[0] is global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader && !global::MS.Internal.DoubleUtil.AreClose(this.ParentDataGrid.CellsPanelActualWidth, newWidth))
			{
				this.ParentDataGrid.CellsPanelActualWidth = newWidth;
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0001A54E File Offset: 0x0001874E
		[global::System.Diagnostics.Conditional("DEBUG")]
		private static void Debug_VerifyRealizedIndexCountVsDisplayIndexCount(global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> blockList, global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> displayIndexBlockList)
		{
			global::Microsoft.Windows.Controls.RealizedColumnsBlock realizedColumnsBlock = blockList[blockList.Count - 1];
			global::Microsoft.Windows.Controls.RealizedColumnsBlock realizedColumnsBlock2 = displayIndexBlockList[displayIndexBlockList.Count - 1];
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0001A570 File Offset: 0x00018770
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeSize)
		{
			global::System.Collections.IList realizedChildren = this.RealizedChildren;
			global::Microsoft.Windows.Controls.DataGridCellsPanel.ArrangeState arrangeState = new global::Microsoft.Windows.Controls.DataGridCellsPanel.ArrangeState();
			arrangeState.ChildHeight = arrangeSize.Height;
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			if (parentDataGrid != null)
			{
				parentDataGrid.QueueInvalidateCellsPanelHorizontalOffset();
				this.SetDataGridCellPanelWidth(realizedChildren, arrangeSize.Width);
				this.InitializeArrangeState(arrangeState);
			}
			global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> realizedColumnsDisplayIndexBlockList = this.RealizedColumnsDisplayIndexBlockList;
			if (realizedColumnsDisplayIndexBlockList != null && realizedColumnsDisplayIndexBlockList.Count > 0)
			{
				double averageColumnWidth = parentDataGrid.InternalColumns.AverageColumnWidth;
				global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> realizedColumnsBlockList = this.RealizedColumnsBlockList;
				global::System.Collections.Generic.List<int> realizedChildrenNotInBlockList = this.GetRealizedChildrenNotInBlockList(realizedColumnsBlockList, realizedChildren);
				int num = -1;
				global::Microsoft.Windows.Controls.RealizedColumnsBlock realizedColumnsBlock = realizedColumnsDisplayIndexBlockList[++num];
				bool flag = false;
				int i = 0;
				int count = parentDataGrid.Columns.Count;
				while (i < count)
				{
					bool flag2 = global::Microsoft.Windows.Controls.DataGridCellsPanel.InBlockOrNextBlock(realizedColumnsDisplayIndexBlockList, i, ref num, ref realizedColumnsBlock, out flag);
					if (flag)
					{
						break;
					}
					if (flag2)
					{
						int num2 = parentDataGrid.ColumnIndexFromDisplayIndex(i);
						global::Microsoft.Windows.Controls.RealizedColumnsBlock realizedBlockForColumn = global::Microsoft.Windows.Controls.DataGridCellsPanel.GetRealizedBlockForColumn(realizedColumnsBlockList, num2);
						int num3 = realizedBlockForColumn.StartIndexOffset + num2 - realizedBlockForColumn.StartIndex;
						if (realizedChildrenNotInBlockList != null)
						{
							int num4 = 0;
							int count2 = realizedChildrenNotInBlockList.Count;
							while (num4 < count2 && realizedChildrenNotInBlockList[num4] <= num3)
							{
								num3++;
								num4++;
							}
						}
						this.ArrangeChild(realizedChildren[num3] as global::System.Windows.UIElement, i, arrangeState);
					}
					else
					{
						global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = parentDataGrid.ColumnFromDisplayIndex(i);
						if (dataGridColumn.IsVisible)
						{
							double columnEstimatedMeasureWidth = global::Microsoft.Windows.Controls.DataGridCellsPanel.GetColumnEstimatedMeasureWidth(dataGridColumn, averageColumnWidth);
							arrangeState.NextNonFrozenCellStart += columnEstimatedMeasureWidth;
						}
					}
					i++;
				}
				if (realizedChildrenNotInBlockList != null)
				{
					int j = 0;
					int count3 = realizedChildrenNotInBlockList.Count;
					while (j < count3)
					{
						global::System.Windows.UIElement uielement = realizedChildren[realizedChildrenNotInBlockList[j]] as global::System.Windows.UIElement;
						uielement.Arrange(default(global::System.Windows.Rect));
						j++;
					}
				}
			}
			this.FinishArrange(arrangeState);
			return arrangeSize;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0001A738 File Offset: 0x00018938
		private void ArrangeChild(global::System.Windows.UIElement child, int displayIndex, global::Microsoft.Windows.Controls.DataGridCellsPanel.ArrangeState arrangeState)
		{
			global::Microsoft.Windows.Controls.IProvideDataGridColumn provideDataGridColumn = child as global::Microsoft.Windows.Controls.IProvideDataGridColumn;
			if (child == this._clippedChildForFrozenBehaviour)
			{
				arrangeState.OldClippedChild = child;
				this._clippedChildForFrozenBehaviour = null;
			}
			double num;
			if (provideDataGridColumn != null)
			{
				num = provideDataGridColumn.Column.Width.DisplayValue;
				if (global::MS.Internal.DoubleUtil.IsNaN(num))
				{
					num = provideDataGridColumn.Column.ActualWidth;
				}
			}
			else
			{
				num = child.DesiredSize.Width;
			}
			global::System.Windows.Rect finalRect = new global::System.Windows.Rect(new global::System.Windows.Size(num, arrangeState.ChildHeight));
			if (displayIndex < arrangeState.FrozenColumnCount)
			{
				finalRect.X = arrangeState.NextFrozenCellStart;
				arrangeState.NextFrozenCellStart += num;
				arrangeState.DataGridHorizontalScrollStartX += num;
			}
			else if (global::MS.Internal.DoubleUtil.LessThanOrClose(arrangeState.NextNonFrozenCellStart, arrangeState.ViewportStartX))
			{
				if (global::MS.Internal.DoubleUtil.LessThanOrClose(arrangeState.NextNonFrozenCellStart + num, arrangeState.ViewportStartX))
				{
					finalRect.X = arrangeState.NextNonFrozenCellStart;
					arrangeState.NextNonFrozenCellStart += num;
				}
				else
				{
					double num2 = arrangeState.ViewportStartX - arrangeState.NextNonFrozenCellStart;
					if (global::MS.Internal.DoubleUtil.AreClose(num2, 0.0))
					{
						finalRect.X = arrangeState.NextFrozenCellStart;
						arrangeState.NextNonFrozenCellStart = arrangeState.NextFrozenCellStart + num;
					}
					else
					{
						finalRect.X = arrangeState.NextFrozenCellStart - num2;
						double num3 = num - num2;
						arrangeState.NewClippedChild = child;
						this._childClipForFrozenBehavior.Rect = new global::System.Windows.Rect(num2, 0.0, num3, finalRect.Height);
						arrangeState.NextNonFrozenCellStart = arrangeState.NextFrozenCellStart + num3;
					}
				}
			}
			else
			{
				finalRect.X = arrangeState.NextNonFrozenCellStart;
				arrangeState.NextNonFrozenCellStart += num;
			}
			child.Arrange(finalRect);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0001A8F0 File Offset: 0x00018AF0
		private static global::Microsoft.Windows.Controls.RealizedColumnsBlock GetRealizedBlockForColumn(global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> blockList, int columnIndex)
		{
			int i = 0;
			int count = blockList.Count;
			while (i < count)
			{
				global::Microsoft.Windows.Controls.RealizedColumnsBlock result = blockList[i];
				if (columnIndex >= result.StartIndex && columnIndex <= result.EndIndex)
				{
					return result;
				}
				i++;
			}
			return new global::Microsoft.Windows.Controls.RealizedColumnsBlock(-1, -1, -1);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0001A938 File Offset: 0x00018B38
		private global::System.Collections.Generic.List<int> GetRealizedChildrenNotInBlockList(global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> blockList, global::System.Collections.IList children)
		{
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			global::Microsoft.Windows.Controls.RealizedColumnsBlock realizedColumnsBlock = blockList[blockList.Count - 1];
			int num = realizedColumnsBlock.StartIndexOffset + realizedColumnsBlock.EndIndex - realizedColumnsBlock.StartIndex + 1;
			if (children.Count == num)
			{
				return null;
			}
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			if (blockList.Count == 0)
			{
				int i = 0;
				int count = children.Count;
				while (i < count)
				{
					list.Add(i);
					i++;
				}
			}
			else
			{
				int num2 = 0;
				global::Microsoft.Windows.Controls.RealizedColumnsBlock realizedColumnsBlock2 = blockList[num2++];
				int j = 0;
				int count2 = children.Count;
				while (j < count2)
				{
					global::Microsoft.Windows.Controls.IProvideDataGridColumn provideDataGridColumn = children[j] as global::Microsoft.Windows.Controls.IProvideDataGridColumn;
					int num3 = j;
					if (provideDataGridColumn != null)
					{
						num3 = parentDataGrid.Columns.IndexOf(provideDataGridColumn.Column);
					}
					if (num3 < realizedColumnsBlock2.StartIndex)
					{
						list.Add(j);
					}
					else if (num3 > realizedColumnsBlock2.EndIndex)
					{
						if (num2 >= blockList.Count)
						{
							for (int k = j; k < count2; k++)
							{
								list.Add(k);
							}
							break;
						}
						realizedColumnsBlock2 = blockList[num2++];
						if (num3 < realizedColumnsBlock2.StartIndex)
						{
							list.Add(j);
						}
					}
					j++;
				}
			}
			return list;
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x0001AA7C File Offset: 0x00018C7C
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x0001AAB4 File Offset: 0x00018CB4
		private bool RebuildRealizedColumnsBlockList
		{
			get
			{
				global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
				if (parentDataGrid == null)
				{
					return true;
				}
				global::Microsoft.Windows.Controls.DataGridColumnCollection internalColumns = parentDataGrid.InternalColumns;
				if (!this.IsVirtualizing)
				{
					return internalColumns.RebuildRealizedColumnsBlockListForNonVirtualizedRows;
				}
				return internalColumns.RebuildRealizedColumnsBlockListForVirtualizedRows;
			}
			set
			{
				global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
				if (parentDataGrid != null)
				{
					if (this.IsVirtualizing)
					{
						parentDataGrid.InternalColumns.RebuildRealizedColumnsBlockListForVirtualizedRows = value;
						return;
					}
					parentDataGrid.InternalColumns.RebuildRealizedColumnsBlockListForNonVirtualizedRows = value;
				}
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x0001AAEC File Offset: 0x00018CEC
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x0001AB24 File Offset: 0x00018D24
		private global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> RealizedColumnsBlockList
		{
			get
			{
				global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
				if (parentDataGrid == null)
				{
					return null;
				}
				global::Microsoft.Windows.Controls.DataGridColumnCollection internalColumns = parentDataGrid.InternalColumns;
				if (!this.IsVirtualizing)
				{
					return internalColumns.RealizedColumnsBlockListForNonVirtualizedRows;
				}
				return internalColumns.RealizedColumnsBlockListForVirtualizedRows;
			}
			set
			{
				global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
				if (parentDataGrid != null)
				{
					if (this.IsVirtualizing)
					{
						parentDataGrid.InternalColumns.RealizedColumnsBlockListForVirtualizedRows = value;
						return;
					}
					parentDataGrid.InternalColumns.RealizedColumnsBlockListForNonVirtualizedRows = value;
				}
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x0001AB5C File Offset: 0x00018D5C
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x0001AB94 File Offset: 0x00018D94
		private global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> RealizedColumnsDisplayIndexBlockList
		{
			get
			{
				global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
				if (parentDataGrid == null)
				{
					return null;
				}
				global::Microsoft.Windows.Controls.DataGridColumnCollection internalColumns = parentDataGrid.InternalColumns;
				if (!this.IsVirtualizing)
				{
					return internalColumns.RealizedColumnsDisplayIndexBlockListForNonVirtualizedRows;
				}
				return internalColumns.RealizedColumnsDisplayIndexBlockListForVirtualizedRows;
			}
			set
			{
				global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
				if (parentDataGrid != null)
				{
					if (this.IsVirtualizing)
					{
						parentDataGrid.InternalColumns.RealizedColumnsDisplayIndexBlockListForVirtualizedRows = value;
						return;
					}
					parentDataGrid.InternalColumns.RealizedColumnsDisplayIndexBlockListForNonVirtualizedRows = value;
				}
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0001ABCC File Offset: 0x00018DCC
		protected override void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost)
		{
			base.OnIsItemsHostChanged(oldIsItemsHost, newIsItemsHost);
			if (newIsItemsHost)
			{
				global::System.Windows.Controls.ItemsControl parentPresenter = this.ParentPresenter;
				if (parentPresenter != null)
				{
					global::System.Windows.Controls.Primitives.IItemContainerGenerator itemContainerGenerator = parentPresenter.ItemContainerGenerator;
					if (itemContainerGenerator != null && itemContainerGenerator == itemContainerGenerator.GetItemContainerGeneratorForPanel(this))
					{
						global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter dataGridCellsPresenter = parentPresenter as global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter;
						if (dataGridCellsPresenter != null)
						{
							dataGridCellsPresenter.InternalItemsHost = this;
							return;
						}
						global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter dataGridColumnHeadersPresenter = parentPresenter as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter;
						if (dataGridColumnHeadersPresenter != null)
						{
							dataGridColumnHeadersPresenter.InternalItemsHost = this;
							return;
						}
					}
				}
			}
			else
			{
				global::System.Windows.Controls.ItemsControl parentPresenter2 = this.ParentPresenter;
				if (parentPresenter2 != null)
				{
					global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter dataGridCellsPresenter2 = parentPresenter2 as global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter;
					if (dataGridCellsPresenter2 != null)
					{
						if (dataGridCellsPresenter2.InternalItemsHost == this)
						{
							dataGridCellsPresenter2.InternalItemsHost = null;
							return;
						}
					}
					else
					{
						global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter dataGridColumnHeadersPresenter2 = parentPresenter2 as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter;
						if (dataGridColumnHeadersPresenter2 != null && dataGridColumnHeadersPresenter2.InternalItemsHost == this)
						{
							dataGridColumnHeadersPresenter2.InternalItemsHost = null;
						}
					}
				}
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x0001AC74 File Offset: 0x00018E74
		private global::Microsoft.Windows.Controls.Primitives.DataGridRowsPresenter ParentRowsPresenter
		{
			get
			{
				global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
				if (parentDataGrid == null)
				{
					return null;
				}
				return parentDataGrid.InternalItemsHost as global::Microsoft.Windows.Controls.Primitives.DataGridRowsPresenter;
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0001AC98 File Offset: 0x00018E98
		private void DetermineVirtualizationState()
		{
			global::System.Windows.Controls.ItemsControl parentPresenter = this.ParentPresenter;
			if (parentPresenter != null)
			{
				this.IsVirtualizing = global::System.Windows.Controls.VirtualizingStackPanel.GetIsVirtualizing(parentPresenter);
				this.InRecyclingMode = (global::System.Windows.Controls.VirtualizingStackPanel.GetVirtualizationMode(parentPresenter) == global::System.Windows.Controls.VirtualizationMode.Recycling);
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x0001ACCA File Offset: 0x00018ECA
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x0001ACD2 File Offset: 0x00018ED2
		private bool IsVirtualizing { get; set; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x0001ACDB File Offset: 0x00018EDB
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x0001ACE3 File Offset: 0x00018EE3
		private bool InRecyclingMode { get; set; }

		// Token: 0x0600067F RID: 1663 RVA: 0x0001ACEC File Offset: 0x00018EEC
		private static double GetColumnEstimatedMeasureWidth(global::Microsoft.Windows.Controls.DataGridColumn column, double averageColumnWidth)
		{
			if (!column.IsVisible)
			{
				return 0.0;
			}
			double num = column.Width.DisplayValue;
			if (global::MS.Internal.DoubleUtil.IsNaN(num))
			{
				num = global::System.Math.Max(averageColumnWidth, column.MinWidth);
				num = global::System.Math.Min(num, column.MaxWidth);
			}
			return num;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0001AD40 File Offset: 0x00018F40
		private double GetColumnEstimatedMeasureWidthSum(int startIndex, int endIndex, double averageColumnWidth)
		{
			double num = 0.0;
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			for (int i = startIndex; i <= endIndex; i++)
			{
				num += global::Microsoft.Windows.Controls.DataGridCellsPanel.GetColumnEstimatedMeasureWidth(parentDataGrid.Columns[i], averageColumnWidth);
			}
			return num;
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0001AD80 File Offset: 0x00018F80
		private global::System.Collections.IList RealizedChildren
		{
			get
			{
				if (this.IsVirtualizing && this.InRecyclingMode)
				{
					return this._realizedChildren;
				}
				return base.InternalChildren;
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001ADA0 File Offset: 0x00018FA0
		private void EnsureRealizedChildren()
		{
			if (this.IsVirtualizing && this.InRecyclingMode)
			{
				if (this._realizedChildren == null)
				{
					global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
					this._realizedChildren = new global::System.Collections.Generic.List<global::System.Windows.UIElement>(internalChildren.Count);
					for (int i = 0; i < internalChildren.Count; i++)
					{
						this._realizedChildren.Add(internalChildren[i]);
					}
					return;
				}
			}
			else
			{
				this._realizedChildren = null;
			}
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0001AE08 File Offset: 0x00019008
		internal double ComputeCellsPanelHorizontalOffset()
		{
			double result = 0.0;
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			double horizontalScrollOffset = parentDataGrid.HorizontalScrollOffset;
			global::System.Windows.Controls.ScrollViewer internalScrollHost = parentDataGrid.InternalScrollHost;
			if (internalScrollHost != null)
			{
				result = horizontalScrollOffset + base.TransformToAncestor(internalScrollHost).Transform(default(global::System.Windows.Point)).X;
			}
			return result;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001AE5C File Offset: 0x0001905C
		private double GetViewportWidth()
		{
			double num = 0.0;
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			if (parentDataGrid != null)
			{
				global::System.Windows.Controls.ScrollContentPresenter internalScrollContentPresenter = parentDataGrid.InternalScrollContentPresenter;
				if (internalScrollContentPresenter != null && !internalScrollContentPresenter.CanContentScroll)
				{
					num = internalScrollContentPresenter.ViewportWidth;
				}
				else
				{
					global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = parentDataGrid.InternalItemsHost as global::System.Windows.Controls.Primitives.IScrollInfo;
					if (scrollInfo != null)
					{
						num = scrollInfo.ViewportWidth;
					}
				}
			}
			global::Microsoft.Windows.Controls.Primitives.DataGridRowsPresenter parentRowsPresenter = this.ParentRowsPresenter;
			if (global::MS.Internal.DoubleUtil.AreClose(num, 0.0) && parentRowsPresenter != null)
			{
				global::System.Windows.Size availableSize = parentRowsPresenter.AvailableSize;
				if (!global::MS.Internal.DoubleUtil.IsNaN(availableSize.Width) && !double.IsInfinity(availableSize.Width))
				{
					num = availableSize.Width;
				}
			}
			return num;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001AEFC File Offset: 0x000190FC
		protected override void OnItemsChanged(object sender, global::System.Windows.Controls.Primitives.ItemsChangedEventArgs args)
		{
			base.OnItemsChanged(sender, args);
			switch (args.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				this.OnItemsRemove(args);
				return;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				this.OnItemsReplace(args);
				return;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				this.OnItemsMove(args);
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				break;
			default:
				return;
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001AF48 File Offset: 0x00019148
		private void OnItemsRemove(global::System.Windows.Controls.Primitives.ItemsChangedEventArgs args)
		{
			this.RemoveChildRange(args.Position, args.ItemCount, args.ItemUICount);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001AF62 File Offset: 0x00019162
		private void OnItemsReplace(global::System.Windows.Controls.Primitives.ItemsChangedEventArgs args)
		{
			this.RemoveChildRange(args.Position, args.ItemCount, args.ItemUICount);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0001AF7C File Offset: 0x0001917C
		private void OnItemsMove(global::System.Windows.Controls.Primitives.ItemsChangedEventArgs args)
		{
			this.RemoveChildRange(args.OldPosition, args.ItemCount, args.ItemUICount);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0001AF98 File Offset: 0x00019198
		private void RemoveChildRange(global::System.Windows.Controls.Primitives.GeneratorPosition position, int itemCount, int itemUICount)
		{
			if (base.IsItemsHost)
			{
				global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
				int num = position.Index;
				if (position.Offset > 0)
				{
					num++;
				}
				if (num < internalChildren.Count && itemUICount > 0)
				{
					base.RemoveInternalChildRange(num, itemUICount);
					if (this.IsVirtualizing && this.InRecyclingMode)
					{
						this._realizedChildren.RemoveRange(num, itemUICount);
					}
				}
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0001AFFC File Offset: 0x000191FC
		protected override void OnClearChildren()
		{
			base.OnClearChildren();
			this._realizedChildren = null;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001B00B File Offset: 0x0001920B
		internal void InternalBringIndexIntoView(int index)
		{
			this.BringIndexIntoView(index);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0001B014 File Offset: 0x00019214
		protected override void BringIndexIntoView(int index)
		{
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			if (parentDataGrid == null)
			{
				base.BringIndexIntoView(index);
				return;
			}
			if (index < 0 || index >= parentDataGrid.Columns.Count)
			{
				throw new global::System.ArgumentOutOfRangeException("index");
			}
			global::System.Windows.Controls.ScrollContentPresenter internalScrollContentPresenter = parentDataGrid.InternalScrollContentPresenter;
			global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = null;
			if (internalScrollContentPresenter != null && !internalScrollContentPresenter.CanContentScroll)
			{
				scrollInfo = internalScrollContentPresenter;
			}
			else
			{
				global::Microsoft.Windows.Controls.Primitives.DataGridRowsPresenter parentRowsPresenter = this.ParentRowsPresenter;
				if (parentRowsPresenter != null)
				{
					scrollInfo = parentRowsPresenter;
				}
			}
			if (scrollInfo == null)
			{
				base.BringIndexIntoView(index);
				return;
			}
			double num = 0.0;
			double value = parentDataGrid.HorizontalScrollOffset;
			while (!this.IsChildInView(index, out num) && !global::MS.Internal.DoubleUtil.AreClose(value, num))
			{
				scrollInfo.SetHorizontalOffset(num);
				base.UpdateLayout();
				value = num;
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0001B0BC File Offset: 0x000192BC
		private bool IsChildInView(int index, out double newHorizontalOffset)
		{
			global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
			double horizontalScrollOffset = parentDataGrid.HorizontalScrollOffset;
			newHorizontalOffset = horizontalScrollOffset;
			double averageColumnWidth = parentDataGrid.InternalColumns.AverageColumnWidth;
			int frozenColumnCount = parentDataGrid.FrozenColumnCount;
			double cellsPanelHorizontalOffset = parentDataGrid.CellsPanelHorizontalOffset;
			double viewportWidth = this.GetViewportWidth();
			double num = horizontalScrollOffset;
			double num2 = -cellsPanelHorizontalOffset;
			double num3 = horizontalScrollOffset - cellsPanelHorizontalOffset;
			int displayIndex = this.Columns[index].DisplayIndex;
			double num4 = 0.0;
			double num5 = 0.0;
			for (int i = 0; i <= displayIndex; i++)
			{
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = parentDataGrid.ColumnFromDisplayIndex(i);
				if (dataGridColumn.IsVisible)
				{
					double columnEstimatedMeasureWidth = global::Microsoft.Windows.Controls.DataGridCellsPanel.GetColumnEstimatedMeasureWidth(dataGridColumn, averageColumnWidth);
					if (i < frozenColumnCount)
					{
						num4 = num;
						num5 = num4 + columnEstimatedMeasureWidth;
						num += columnEstimatedMeasureWidth;
					}
					else if (global::MS.Internal.DoubleUtil.LessThanOrClose(num2, num3))
					{
						if (global::MS.Internal.DoubleUtil.LessThanOrClose(num2 + columnEstimatedMeasureWidth, num3))
						{
							num4 = num2;
							num5 = num4 + columnEstimatedMeasureWidth;
							num2 += columnEstimatedMeasureWidth;
						}
						else
						{
							num4 = num;
							double num6 = num3 - num2;
							if (global::MS.Internal.DoubleUtil.AreClose(num6, 0.0))
							{
								num5 = num4 + columnEstimatedMeasureWidth;
								num2 = num + columnEstimatedMeasureWidth;
							}
							else
							{
								double num7 = columnEstimatedMeasureWidth - num6;
								num5 = num4 + num7;
								num2 = num + num7;
								if (i == displayIndex)
								{
									newHorizontalOffset = horizontalScrollOffset - num6;
									return false;
								}
							}
						}
					}
					else
					{
						num4 = num2;
						num5 = num4 + columnEstimatedMeasureWidth;
						num2 += columnEstimatedMeasureWidth;
					}
				}
			}
			double num8 = num3 + viewportWidth;
			if (global::MS.Internal.DoubleUtil.LessThan(num4, num3))
			{
				newHorizontalOffset = num4 + cellsPanelHorizontalOffset;
			}
			else
			{
				if (!global::MS.Internal.DoubleUtil.GreaterThan(num5, num8))
				{
					return true;
				}
				double num9 = num5 - num8;
				if (displayIndex < frozenColumnCount)
				{
					num -= num5 - num4;
				}
				if (global::MS.Internal.DoubleUtil.LessThan(num4 - num9, num))
				{
					num9 = num4 - num;
				}
				if (global::MS.Internal.DoubleUtil.AreClose(num9, 0.0))
				{
					return true;
				}
				newHorizontalOffset = horizontalScrollOffset + num9;
			}
			return false;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0001B286 File Offset: 0x00019486
		internal global::System.Windows.Media.Geometry GetFrozenClipForChild(global::System.Windows.UIElement child)
		{
			if (child == this._clippedChildForFrozenBehaviour)
			{
				return this._childClipForFrozenBehavior;
			}
			return null;
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x0001B29C File Offset: 0x0001949C
		private global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Windows.Controls.DataGridColumn> Columns
		{
			get
			{
				global::Microsoft.Windows.Controls.DataGrid parentDataGrid = this.ParentDataGrid;
				if (parentDataGrid != null)
				{
					return parentDataGrid.Columns;
				}
				return null;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x0001B2BC File Offset: 0x000194BC
		private global::Microsoft.Windows.Controls.DataGrid ParentDataGrid
		{
			get
			{
				if (this._parentDataGrid == null)
				{
					global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter dataGridCellsPresenter = this.ParentPresenter as global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter;
					if (dataGridCellsPresenter != null)
					{
						global::Microsoft.Windows.Controls.DataGridRow dataGridRowOwner = dataGridCellsPresenter.DataGridRowOwner;
						if (dataGridRowOwner != null)
						{
							this._parentDataGrid = dataGridRowOwner.DataGridOwner;
						}
					}
					else
					{
						global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter dataGridColumnHeadersPresenter = this.ParentPresenter as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter;
						if (dataGridColumnHeadersPresenter != null)
						{
							this._parentDataGrid = dataGridColumnHeadersPresenter.ParentDataGrid;
						}
					}
				}
				return this._parentDataGrid;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x0001B31C File Offset: 0x0001951C
		private global::System.Windows.Controls.ItemsControl ParentPresenter
		{
			get
			{
				global::System.Windows.FrameworkElement frameworkElement = base.TemplatedParent as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					return frameworkElement.TemplatedParent as global::System.Windows.Controls.ItemsControl;
				}
				return null;
			}
		}

		// Token: 0x040001CC RID: 460
		private global::Microsoft.Windows.Controls.DataGrid _parentDataGrid;

		// Token: 0x040001CD RID: 461
		private global::System.Windows.UIElement _clippedChildForFrozenBehaviour;

		// Token: 0x040001CE RID: 462
		private global::System.Windows.Media.RectangleGeometry _childClipForFrozenBehavior = new global::System.Windows.Media.RectangleGeometry();

		// Token: 0x040001CF RID: 463
		private global::System.Collections.Generic.List<global::System.Windows.UIElement> _realizedChildren;

		// Token: 0x02000050 RID: 80
		private class ArrangeState
		{
			// Token: 0x06000692 RID: 1682 RVA: 0x0001B348 File Offset: 0x00019548
			public ArrangeState()
			{
				this.FrozenColumnCount = 0;
				this.ChildHeight = 0.0;
				this.NextFrozenCellStart = 0.0;
				this.NextNonFrozenCellStart = 0.0;
				this.ViewportStartX = 0.0;
				this.DataGridHorizontalScrollStartX = 0.0;
				this.OldClippedChild = null;
				this.NewClippedChild = null;
			}

			// Token: 0x17000189 RID: 393
			// (get) Token: 0x06000693 RID: 1683 RVA: 0x0001B3BB File Offset: 0x000195BB
			// (set) Token: 0x06000694 RID: 1684 RVA: 0x0001B3C3 File Offset: 0x000195C3
			public int FrozenColumnCount { get; set; }

			// Token: 0x1700018A RID: 394
			// (get) Token: 0x06000695 RID: 1685 RVA: 0x0001B3CC File Offset: 0x000195CC
			// (set) Token: 0x06000696 RID: 1686 RVA: 0x0001B3D4 File Offset: 0x000195D4
			public double ChildHeight { get; set; }

			// Token: 0x1700018B RID: 395
			// (get) Token: 0x06000697 RID: 1687 RVA: 0x0001B3DD File Offset: 0x000195DD
			// (set) Token: 0x06000698 RID: 1688 RVA: 0x0001B3E5 File Offset: 0x000195E5
			public double NextFrozenCellStart { get; set; }

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x06000699 RID: 1689 RVA: 0x0001B3EE File Offset: 0x000195EE
			// (set) Token: 0x0600069A RID: 1690 RVA: 0x0001B3F6 File Offset: 0x000195F6
			public double NextNonFrozenCellStart { get; set; }

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x0600069B RID: 1691 RVA: 0x0001B3FF File Offset: 0x000195FF
			// (set) Token: 0x0600069C RID: 1692 RVA: 0x0001B407 File Offset: 0x00019607
			public double ViewportStartX { get; set; }

			// Token: 0x1700018E RID: 398
			// (get) Token: 0x0600069D RID: 1693 RVA: 0x0001B410 File Offset: 0x00019610
			// (set) Token: 0x0600069E RID: 1694 RVA: 0x0001B418 File Offset: 0x00019618
			public double DataGridHorizontalScrollStartX { get; set; }

			// Token: 0x1700018F RID: 399
			// (get) Token: 0x0600069F RID: 1695 RVA: 0x0001B421 File Offset: 0x00019621
			// (set) Token: 0x060006A0 RID: 1696 RVA: 0x0001B429 File Offset: 0x00019629
			public global::System.Windows.UIElement OldClippedChild { get; set; }

			// Token: 0x17000190 RID: 400
			// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0001B432 File Offset: 0x00019632
			// (set) Token: 0x060006A2 RID: 1698 RVA: 0x0001B43A File Offset: 0x0001963A
			public global::System.Windows.UIElement NewClippedChild { get; set; }
		}
	}
}
