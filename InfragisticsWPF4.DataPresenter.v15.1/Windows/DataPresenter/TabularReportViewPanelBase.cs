using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using Infragistics.Windows.Reporting;
using Infragistics.Windows.Selection;
using Infragistics.Windows.Virtualization;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000197 RID: 407
	public abstract class TabularReportViewPanelBase : global::Infragistics.Windows.Virtualization.RecyclingItemsPanel, global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator, global::System.Windows.Controls.Primitives.IScrollInfo
	{
		// Token: 0x060019B5 RID: 6581 RVA: 0x00075CDC File Offset: 0x00073EDC
		protected internal TabularReportViewPanelBase()
		{
			this._repeatTypeHelper = new global::System.Collections.Hashtable();
			this._currentPagePosition = new global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.TabularPagePosition();
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x00075CFA File Offset: 0x00073EFA
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x00075D02 File Offset: 0x00073F02
		internal double HorizontalOffset
		{
			get
			{
				return this._currentPagePosition.HorizontalOffset;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x00075D0F File Offset: 0x00073F0F
		internal global::Infragistics.Windows.DataPresenter.RecordListControl RecordListControl
		{
			get
			{
				if (this._recordListControl == null)
				{
					this._recordListControl = (global::System.Windows.Controls.ItemsControl.GetItemsOwner(this) as global::Infragistics.Windows.DataPresenter.RecordListControl);
				}
				return this._recordListControl;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x00075D30 File Offset: 0x00073F30
		internal double ScaleFactor
		{
			get
			{
				return this._scaleFactor;
			}
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x00075D38 File Offset: 0x00073F38
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			base.ArrangeOverride(finalSize);
			if (this._currentPagePosition == null)
			{
				return finalSize;
			}
			global::System.Collections.IList childElements = base.ChildElements;
			global::Infragistics.Windows.DataPresenter.ReportViewBase reportViewBase = this.DataPresenter.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.ReportViewBase;
			double num = this.DataPresenter.IsTreeView ? 0.0 : reportViewBase.LevelIndentationResolved;
			double num2 = -this._currentPagePosition.VerticalOffset;
			double num3 = -this._currentPagePosition.HorizontalOffset;
			bool flag = this._gridViewOrientation == global::System.Windows.Controls.Orientation.Vertical;
			bool flag2 = this._reportSettings.HorizontalPaginationMode == global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Scale && this._scaleFactor < 1.0;
			global::System.Windows.Vector vector = default(global::System.Windows.Vector);
			global::System.Collections.Generic.Stack<global::System.Windows.Vector> stack = null;
			int num4 = 0;
			if (!flag)
			{
				stack = this._currentPagePosition.ExtraOffsetStack;
				if (stack.Count > 0)
				{
					foreach (global::System.Windows.Vector vector2 in stack)
					{
						vector += vector2;
					}
				}
			}
			foreach (object obj in childElements)
			{
				global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(uielement);
				bool flag3 = recordPresenterFromContainer is global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter;
				int i = recordPresenterFromContainer.Record.NestingDepthOfGroupByRcds;
				double num5 = 0.0;
				if (recordPresenterFromContainer != null)
				{
					num5 = (double)recordPresenterFromContainer.Record.NestingDepth * num;
					if (stack != null)
					{
						while (i < stack.Count)
						{
							vector.Y -= stack.Pop().Y;
						}
						if (!flag3)
						{
							num5 -= (double)i * num;
						}
					}
					if (flag3)
					{
						num3 = num5 * this._scaleFactor + vector.X;
						if (!flag)
						{
							num2 = -this._currentPagePosition.VerticalOffset + vector.Y;
						}
					}
					else if (flag)
					{
						num3 = -this._currentPagePosition.HorizontalOffset + num5 * this._scaleFactor + vector.X;
					}
					else
					{
						num2 = -this._currentPagePosition.VerticalOffset + num5 * this._scaleFactor + vector.Y;
					}
				}
				double height = uielement.DesiredSize.Height;
				double num6 = uielement.DesiredSize.Width;
				if (flag3 && flag)
				{
					if (!flag2)
					{
						num6 = global::System.Math.Max(global::System.Math.Max(this._largestRecordExtentInPreviousMeasure, finalSize.Width + this._currentPagePosition.HorizontalOffset) - num5, 10.0);
						num3 = num5;
						num3 -= this._currentPagePosition.HorizontalOffset;
						recordPresenterFromContainer.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedNearElementTransformPropertyKey, new global::System.Windows.Media.TranslateTransform(this._currentPagePosition.HorizontalOffset, 0.0));
						recordPresenterFromContainer.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ScrollableElementTransformPropertyKey, new global::System.Windows.Media.TranslateTransform(-this._currentPagePosition.HorizontalOffset, 0.0));
					}
					else
					{
						num6 = global::System.Math.Max(num6, this._largestRecordExtentInPreviousMeasure - num5);
					}
				}
				double num7 = height;
				double num8 = num6;
				if (flag2)
				{
					num7 = height * this._scaleFactor;
					num8 = num6 * this._scaleFactor;
				}
				if (flag2)
				{
					uielement.RenderTransform = new global::System.Windows.Media.ScaleTransform(this._scaleFactor, this._scaleFactor);
				}
				else
				{
					uielement.ClearValue(global::System.Windows.UIElement.RenderTransformProperty);
				}
				if (num4 > 0 && ((num2 + num7 > finalSize.Height && flag) || (num3 + num8 > finalSize.Width && !flag)))
				{
					if (recordPresenterFromContainer != null)
					{
						recordPresenterFromContainer.IsArrangedInView = false;
					}
					uielement.Arrange(new global::System.Windows.Rect(-100000.0, -100000.0, num6, height));
				}
				else
				{
					if (recordPresenterFromContainer != null)
					{
						recordPresenterFromContainer.IsArrangedInView = true;
					}
					uielement.Arrange(new global::System.Windows.Rect(num3, num2, num6, height));
					num4++;
				}
				if (flag3)
				{
					num2 += num7;
					vector.Y += num7;
					if (stack != null)
					{
						stack.Push(new global::System.Windows.Vector(num, num7));
					}
				}
				else if (flag)
				{
					num2 += num7;
				}
				else
				{
					num3 += num8;
					if (recordPresenterFromContainer != null && recordPresenterFromContainer.Record.ParentRecord is global::Infragistics.Windows.DataPresenter.GroupByRecord)
					{
						vector.X += num8;
					}
				}
			}
			return finalSize;
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x000761B4 File Offset: 0x000743B4
		protected override bool GetCanCleanupItem(int itemIndex)
		{
			return true;
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x000761B8 File Offset: 0x000743B8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (this._currentPagePosition == null)
			{
				return new global::System.Windows.Size(1.0, 1.0);
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			global::Infragistics.Windows.DataPresenter.ReportViewBase reportViewBase = dataPresenter.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.ReportViewBase;
			bool isTreeView = dataPresenter.IsTreeView;
			global::Infragistics.Windows.Reporting.RepeatType repeatType = this._reportSettings.RepeatType;
			if (isTreeView && repeatType == global::Infragistics.Windows.Reporting.RepeatType.LevelBreak)
			{
				repeatType = global::Infragistics.Windows.Reporting.RepeatType.PageBreak;
			}
			if (repeatType == global::Infragistics.Windows.Reporting.RepeatType.PageBreak)
			{
				this._repeatTypeHelper.Clear();
			}
			this._largestRecordExtentInPreviousMeasure = 0.0;
			double num = isTreeView ? 0.0 : reportViewBase.LevelIndentationResolved;
			global::System.Windows.Size result = new global::System.Windows.Size(0.0, 0.0);
			bool flag = double.IsPositiveInfinity(availableSize.Height);
			bool flag2 = double.IsPositiveInfinity(availableSize.Width);
			int num2 = -1;
			int num3 = 0;
			int i = this._currentPagePosition.IndexOfFirstRecordOnPage;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
			global::Infragistics.Windows.DataPresenter.Record record = null;
			global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy headerPlacementInGroupBy = global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.WithDataRecords;
			bool flag3 = false;
			int num4 = 0;
			double num5 = availableSize.Width;
			double num6 = availableSize.Height;
			this._scaleFactor = 1.0;
			global::System.Windows.Vector vector = default(global::System.Windows.Vector);
			bool flag4 = this._gridViewOrientation == global::System.Windows.Controls.Orientation.Vertical;
			global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.FieldLayoutNestingLevelKey fieldLayoutNestingLevelKey = null;
			int num7 = 0;
			base.BeginGeneration(global::Infragistics.Windows.Selection.ScrollDirection.Increment);
			global::System.Windows.Controls.Primitives.GeneratorPosition generatorPositionFromItemIndex = this.GetGeneratorPositionFromItemIndex(i, out num3);
			global::System.Windows.Controls.Primitives.IItemContainerGenerator activeItemContainerGenerator = base.ActiveItemContainerGenerator;
			using (activeItemContainerGenerator.StartAt(generatorPositionFromItemIndex, global::System.Windows.Controls.Primitives.GeneratorDirection.Forward, true))
			{
				int count = this.RecordListControl.Items.Count;
				int num8 = base.ChildElements.Count;
				bool flag5 = false;
				if (count == 1)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this.RecordListControl.Items[0] as global::Infragistics.Windows.DataPresenter.DataRecord;
					flag5 = (dataRecord != null && dataRecord.IsTemplateDataRecord);
				}
				while (i < count)
				{
					bool flag6;
					global::System.Windows.UIElement uielement = activeItemContainerGenerator.GenerateNext(out flag6) as global::System.Windows.UIElement;
					uielement.Visibility = global::System.Windows.Visibility.Visible;
					if (flag6)
					{
						if (num2 < 0)
						{
							num2 = this.FindSlotForNewlyRealizedRecordPresenter(i);
						}
						if (num2 >= num8)
						{
							base.AddInternalChild(uielement);
						}
						else
						{
							base.InsertInternalChild(num2, uielement);
						}
						num2++;
						num8++;
						activeItemContainerGenerator.PrepareItemContainer(uielement);
					}
					global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(uielement);
					double num9 = 0.0;
					if (recordPresenterFromContainer != null)
					{
						bool flag7 = !flag5;
						bool addHeader = false;
						recordPresenterFromContainer.InitializeRecordContentVisibility(flag7);
						recordPresenterFromContainer.InitializeExpandableRecordContentVisibility(flag7);
						recordPresenterFromContainer.InitializeGroupByRecordContentVisibility(flag7);
						global::Infragistics.Windows.DataPresenter.Record record2 = recordPresenterFromContainer.Record;
						int nestingDepth = record2.NestingDepth;
						num9 = num * (double)nestingDepth;
						if (record2 is global::Infragistics.Windows.DataPresenter.DataRecord)
						{
							global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = record2.FieldLayout;
							if (fieldLayoutNestingLevelKey == null || !fieldLayoutNestingLevelKey.IsSameKey(fieldLayout2, nestingDepth))
							{
								fieldLayoutNestingLevelKey = new global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.FieldLayoutNestingLevelKey(fieldLayout2, nestingDepth);
							}
							if (fieldLayout2 != fieldLayout || nestingDepth != num4)
							{
								if (repeatType == global::Infragistics.Windows.Reporting.RepeatType.FirstOccurrence)
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = this._repeatTypeHelper[fieldLayoutNestingLevelKey] as global::Infragistics.Windows.DataPresenter.DataRecord;
									if (dataRecord2 == null)
									{
										if (!isTreeView || this._repeatTypeHelper.Count == 0)
										{
											addHeader = true;
											this._repeatTypeHelper[fieldLayoutNestingLevelKey] = record2;
										}
									}
									else if (dataRecord2 == record2)
									{
										addHeader = true;
									}
								}
								else if (repeatType == global::Infragistics.Windows.Reporting.RepeatType.PageBreak)
								{
									if (!(this._repeatTypeHelper[fieldLayoutNestingLevelKey] is bool?) && (!isTreeView || this._repeatTypeHelper.Count == 0))
									{
										addHeader = true;
										this._repeatTypeHelper[fieldLayoutNestingLevelKey] = true;
									}
								}
								else
								{
									addHeader = !isTreeView;
								}
								num4 = nestingDepth;
								fieldLayout = fieldLayout2;
								headerPlacementInGroupBy = fieldLayout2.HeaderPlacementInGroupByResolved;
							}
							if (record is global::Infragistics.Windows.DataPresenter.GroupByRecord)
							{
								addHeader = true;
							}
							if (flag3 && headerPlacementInGroupBy == global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.OnTopOnly && record2.ParentRecord is global::Infragistics.Windows.DataPresenter.GroupByRecord)
							{
								addHeader = false;
							}
						}
						else if (record2 is global::Infragistics.Windows.DataPresenter.GroupByRecord)
						{
							global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout3 = record2.FieldLayout;
							if (fieldLayout3 != fieldLayout)
							{
								headerPlacementInGroupBy = fieldLayout3.HeaderPlacementInGroupByResolved;
								if (headerPlacementInGroupBy == global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.OnTopOnly && (fieldLayout == null || !(record2.ParentRecord is global::Infragistics.Windows.DataPresenter.GroupByRecord)))
								{
									addHeader = true;
								}
								num4 = record2.NestingDepth;
								fieldLayout = fieldLayout3;
							}
						}
						recordPresenterFromContainer.InitializeHeaderContent(addHeader);
						record = record2;
					}
					uielement.InvalidateMeasure();
					uielement.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
					global::System.Windows.Size desiredSize = uielement.DesiredSize;
					if (flag4)
					{
						this._availableExtentInPreviousMeasure = availableSize.Width;
						if (!flag && num7 != 0 && result.Height + desiredSize.Height > num6)
						{
							break;
						}
						num7++;
						double val = num9 + desiredSize.Width;
						this._largestRecordExtentInPreviousMeasure = global::System.Math.Max(this._largestRecordExtentInPreviousMeasure, val);
						result.Width = this._largestRecordExtentInPreviousMeasure;
						result.Height += desiredSize.Height;
						if (this._reportSettings.HorizontalPaginationMode == global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Scale)
						{
							double num10 = availableSize.Width / (num9 + uielement.DesiredSize.Width);
							if (num10 < 1.0 && num10 < this._scaleFactor)
							{
								this._scaleFactor = num10;
								num6 = availableSize.Height / this._scaleFactor;
							}
						}
					}
					else
					{
						this._availableExtentInPreviousMeasure = availableSize.Height;
						bool flag8 = recordPresenterFromContainer is global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter;
						double num11;
						if (flag8)
						{
							num11 = global::System.Math.Max(result.Width, vector.X + num9 + desiredSize.Width);
						}
						else
						{
							num11 = global::System.Math.Max(result.Width, vector.X + desiredSize.Width);
						}
						if (!flag2 && num7 != 0 && num11 > num5)
						{
							break;
						}
						num7++;
						double height = desiredSize.Height;
						if (flag8 && recordPresenterFromContainer.Record.ParentRecord == null)
						{
							vector.Y = 0.0;
						}
						if (flag8)
						{
							vector.X += num9 + desiredSize.Width;
							vector.Y += desiredSize.Height;
						}
						else
						{
							vector.X += desiredSize.Width;
							vector.Y += num9;
							result.Height = this._largestRecordExtentInPreviousMeasure;
						}
						this._largestRecordExtentInPreviousMeasure = global::System.Math.Max(this._largestRecordExtentInPreviousMeasure, height);
						result.Width = num11;
						if (this._reportSettings.HorizontalPaginationMode == global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Scale)
						{
							double num10 = availableSize.Height / (num9 + desiredSize.Height);
							if (num10 < 1.0 && num10 < this._scaleFactor)
							{
								this._scaleFactor = num10;
								num5 = availableSize.Width / this._scaleFactor;
							}
						}
					}
					i++;
					flag3 = true;
				}
				if (this._currentPagePosition.IndexOfLastRecordOnPage != i - 1)
				{
					this._currentPagePosition.IndexOfLastRecordOnPage = global::System.Math.Max(this._currentPagePosition.IndexOfFirstRecordOnPage, i - 1);
				}
				this._totalVisibleGeneratedItems = this._currentPagePosition.IndexOfLastRecordOnPage - this._currentPagePosition.IndexOfFirstRecordOnPage;
			}
			base.EndGeneration();
			if (!flag2 && (result.Width == 0.0 || result.Width > availableSize.Width))
			{
				result.Width = availableSize.Width;
			}
			if (!flag && (result.Height == 0.0 || result.Height > availableSize.Height))
			{
				result.Height = availableSize.Height;
			}
			if (result.Height == 0.0 && result.Width == 0.0)
			{
				return new global::System.Windows.Size(1.0, 1.0);
			}
			return result;
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x00076940 File Offset: 0x00074B40
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataPresenterProperty)
			{
				this._dataPresenter = (e.NewValue as global::Infragistics.Windows.DataPresenter.DataPresenterBase);
				this._reportSettings = (this._dataPresenter as global::Infragistics.Windows.DataPresenter.DataPresenterReportControl).Section.Report.ReportSettings;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x00076994 File Offset: 0x00074B94
		protected override int TotalVisibleGeneratedItems
		{
			get
			{
				return this._totalVisibleGeneratedItems;
			}
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0007699C File Offset: 0x00074B9C
		private double CalculateExtraExtentNeeded()
		{
			bool flag = this._reportSettings.HorizontalPaginationMode == global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Scale && this._scaleFactor < 1.0;
			if (flag)
			{
				return 0.0;
			}
			return global::System.Math.Max(this._largestRecordExtentInPreviousMeasure - this._availableExtentInPreviousMeasure, 0.0);
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x000769F4 File Offset: 0x00074BF4
		private int FindSlotForNewlyRealizedRecordPresenter(int newItemIndex)
		{
			global::System.Collections.IList childElements = base.ChildElements;
			int count = childElements.Count;
			if (count == 0)
			{
				return 0;
			}
			global::System.Windows.Controls.Primitives.IItemContainerGenerator activeItemContainerGenerator = base.ActiveItemContainerGenerator;
			for (int i = 0; i < count; i++)
			{
				int num = activeItemContainerGenerator.IndexFromGeneratorPosition(new global::System.Windows.Controls.Primitives.GeneratorPosition(i, 0));
				if (num >= newItemIndex)
				{
					return i;
				}
			}
			return count;
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00076A40 File Offset: 0x00074C40
		private global::System.Windows.Controls.Primitives.GeneratorPosition GetGeneratorPositionFromItemIndex(int itemIndex, out int childIndex)
		{
			global::System.Windows.Controls.Primitives.IItemContainerGenerator activeItemContainerGenerator = base.ActiveItemContainerGenerator;
			global::System.Windows.Controls.Primitives.GeneratorPosition result = (activeItemContainerGenerator != null) ? activeItemContainerGenerator.GeneratorPositionFromIndex(itemIndex) : new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, itemIndex + 1);
			childIndex = ((result.Offset == 0) ? result.Index : (result.Index + 1));
			return result;
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00076A88 File Offset: 0x00074C88
		private void EstimatePageCount()
		{
			int num = 1 + this._currentPagePosition.IndexOfLastRecordOnPage - this._currentPagePosition.IndexOfFirstRecordOnPage;
			if (num < 1)
			{
				this._pageCount = 0;
				this._isEndReached = true;
				return;
			}
			int count = this._recordListControl.Items.Count;
			double a = this._largestRecordExtentInPreviousMeasure / this._availableExtentInPreviousMeasure;
			int num2 = (int)global::System.Math.Ceiling(a);
			a = (double)count / (double)num;
			this._pageCount = (int)global::System.Math.Ceiling(a);
			if (num2 > 1 && this._reportSettings.HorizontalPaginationMode != global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Scale)
			{
				this._pageCount *= num2;
			}
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00076B1C File Offset: 0x00074D1C
		void global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.BeginPagination(global::Infragistics.Windows.Reporting.ReportSection section)
		{
			global::Infragistics.Windows.DataPresenter.ReportViewBase reportViewBase = this._dataPresenter.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.ReportViewBase;
			this._gridViewOrientation = reportViewBase.LogicalOrientation;
			this._currentPagePosition = new global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.TabularPagePosition();
			this._currentPagePosition.GridViewOrientation = this._gridViewOrientation;
			this._isEndReached = false;
			this._repeatTypeHelper.Clear();
			((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)this).MoveToPosition(global::Infragistics.Windows.Reporting.PagePosition.FirstPage);
			this.EstimatePageCount();
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x00076B88 File Offset: 0x00074D88
		object global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.CurrentPageDataContext
		{
			get
			{
				if (this._currentPagePosition != null)
				{
					int indexOfFirstRecordOnPage = this._currentPagePosition.IndexOfFirstRecordOnPage;
					if (indexOfFirstRecordOnPage >= 0)
					{
						global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = this.RecordListControl;
						if (recordListControl != null && recordListControl.Items.Count > indexOfFirstRecordOnPage)
						{
							return recordListControl.Items[indexOfFirstRecordOnPage];
						}
					}
				}
				return null;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x00076BD3 File Offset: 0x00074DD3
		global::Infragistics.Windows.Reporting.PagePosition global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.CurrentPagePosition
		{
			get
			{
				if (this._currentPagePosition == null)
				{
					return global::Infragistics.Windows.Reporting.PagePosition.InvalidPage;
				}
				if (this._isEndReached)
				{
					return global::Infragistics.Windows.Reporting.PagePosition.LastPage;
				}
				return this._currentPagePosition.Clone() as global::Infragistics.Windows.Reporting.PagePosition;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x00076C01 File Offset: 0x00074E01
		int global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.LogicalPageNumber
		{
			get
			{
				return this._currentPagePosition.LogicalPageNumber;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x00076C0E File Offset: 0x00074E0E
		int global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.LogicalPagePartNumber
		{
			get
			{
				return this._currentPagePosition.LogicalPagePartNumber;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00076C1B File Offset: 0x00074E1B
		int global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.EstimatedPageCount
		{
			get
			{
				return this._pageCount;
			}
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x00076C23 File Offset: 0x00074E23
		void global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.EndPagination()
		{
			this._currentPagePosition = null;
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00076C2C File Offset: 0x00074E2C
		bool global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.MoveToNextPage()
		{
			double extraExtentNeeded = this.CalculateExtraExtentNeeded();
			this._currentPagePosition.ExtraExtentNeeded = extraExtentNeeded;
			this._currentPagePosition.TotalRowCount = this.RecordListControl.Items.Count;
			if (this._reportSettings.HorizontalPaginationMode == global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Scale)
			{
				this._currentPagePosition.ExtraExtentNeeded = 0.0;
				if (this._gridViewOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					if (!this._currentPagePosition.MoveDown(this._availableExtentInPreviousMeasure))
					{
						return false;
					}
				}
				else if (!this._currentPagePosition.MoveLeft(this._availableExtentInPreviousMeasure))
				{
					return false;
				}
			}
			else if (this._reportSettings.PagePrintOrder == global::Infragistics.Windows.Reporting.PagePrintOrder.Horizontal)
			{
				if (!this._currentPagePosition.MoveLeft(this._availableExtentInPreviousMeasure))
				{
					if (!this._currentPagePosition.MoveDownGoToStartOfRow(this._availableExtentInPreviousMeasure))
					{
						return false;
					}
				}
				else if (this._gridViewOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					base.InvalidateArrange();
					base.UpdateLayout();
					if (this._currentPagePosition.IsEndReached)
					{
						this._isEndReached = true;
					}
					return true;
				}
			}
			else
			{
				if (this._reportSettings.PagePrintOrder != global::Infragistics.Windows.Reporting.PagePrintOrder.Vertical)
				{
					throw new global::System.Exception("Invalid PagePrintOrder value!");
				}
				if (!this._currentPagePosition.MoveDown(this._availableExtentInPreviousMeasure) && !this._currentPagePosition.MoveLeftGoToTop(this._availableExtentInPreviousMeasure))
				{
					return false;
				}
			}
			base.InvalidateMeasure();
			base.UpdateLayout();
			extraExtentNeeded = this.CalculateExtraExtentNeeded();
			this._currentPagePosition.ExtraExtentNeeded = extraExtentNeeded;
			if (this._currentPagePosition.IsEndReached)
			{
				this._isEndReached = true;
			}
			return true;
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00076D98 File Offset: 0x00074F98
		bool global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.MoveToPosition(global::Infragistics.Windows.Reporting.PagePosition pagePosition)
		{
			global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.TabularPagePosition tabularPagePosition = pagePosition as global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.TabularPagePosition;
			this._isEndReached = false;
			if (tabularPagePosition == null)
			{
				if (pagePosition == global::Infragistics.Windows.Reporting.PagePosition.FirstPage)
				{
					if (this._currentPagePosition.IsOnFirstPosition())
					{
						if (this._scaleFactor * this._largestRecordExtentInPreviousMeasure - this._availableExtentInPreviousMeasure > 0.0)
						{
							this._isEndReached = false;
							return true;
						}
						if (this._currentPagePosition.IsEndReached)
						{
							this._isEndReached = true;
						}
						return true;
					}
					else
					{
						this._currentPagePosition.MoveToFirstPage();
					}
				}
				else
				{
					if (pagePosition == global::Infragistics.Windows.Reporting.PagePosition.LastPage)
					{
						return ((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)this).MoveToNextPage();
					}
					throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidMoveToPagePosition", new object[]
					{
						pagePosition
					}));
				}
			}
			else
			{
				this._currentPagePosition = (tabularPagePosition.Clone() as global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.TabularPagePosition);
			}
			double extraExtentNeeded = this.CalculateExtraExtentNeeded();
			this._currentPagePosition.ExtraExtentNeeded = extraExtentNeeded;
			this._currentPagePosition.TotalRowCount = this.RecordListControl.Items.Count;
			base.InvalidateMeasure();
			base.UpdateLayout();
			if (this._currentPagePosition.IsEndReached)
			{
				this._isEndReached = true;
			}
			return true;
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x00076EA4 File Offset: 0x000750A4
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x00076EA7 File Offset: 0x000750A7
		bool global::System.Windows.Controls.Primitives.IScrollInfo.CanHorizontallyScroll
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x00076EA9 File Offset: 0x000750A9
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x00076EAC File Offset: 0x000750AC
		bool global::System.Windows.Controls.Primitives.IScrollInfo.CanVerticallyScroll
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00076EAE File Offset: 0x000750AE
		double global::System.Windows.Controls.Primitives.IScrollInfo.ExtentHeight
		{
			get
			{
				return 1000000.0;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x00076EB9 File Offset: 0x000750B9
		double global::System.Windows.Controls.Primitives.IScrollInfo.ExtentWidth
		{
			get
			{
				return 1000000.0;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x00076EC4 File Offset: 0x000750C4
		double global::System.Windows.Controls.Primitives.IScrollInfo.HorizontalOffset
		{
			get
			{
				if (this._currentPagePosition == null)
				{
					return 0.0;
				}
				return this._currentPagePosition.HorizontalOffset;
			}
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00076EE3 File Offset: 0x000750E3
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineDown()
		{
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00076EE5 File Offset: 0x000750E5
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineLeft()
		{
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x00076EE7 File Offset: 0x000750E7
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineRight()
		{
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x00076EE9 File Offset: 0x000750E9
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineUp()
		{
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00076EEC File Offset: 0x000750EC
		global::System.Windows.Rect global::System.Windows.Controls.Primitives.IScrollInfo.MakeVisible(global::System.Windows.Media.Visual visual, global::System.Windows.Rect rectangle)
		{
			return default(global::System.Windows.Rect);
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00076F02 File Offset: 0x00075102
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelDown()
		{
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x00076F04 File Offset: 0x00075104
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelLeft()
		{
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x00076F06 File Offset: 0x00075106
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelRight()
		{
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00076F08 File Offset: 0x00075108
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelUp()
		{
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00076F0A File Offset: 0x0007510A
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageDown()
		{
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x00076F0C File Offset: 0x0007510C
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageLeft()
		{
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00076F0E File Offset: 0x0007510E
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageRight()
		{
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00076F10 File Offset: 0x00075110
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageUp()
		{
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x00076F12 File Offset: 0x00075112
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x00076F1A File Offset: 0x0007511A
		global::System.Windows.Controls.ScrollViewer global::System.Windows.Controls.Primitives.IScrollInfo.ScrollOwner
		{
			get
			{
				return this._scrollOwner;
			}
			set
			{
				this._scrollOwner = value;
			}
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00076F23 File Offset: 0x00075123
		void global::System.Windows.Controls.Primitives.IScrollInfo.SetHorizontalOffset(double offset)
		{
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00076F25 File Offset: 0x00075125
		void global::System.Windows.Controls.Primitives.IScrollInfo.SetVerticalOffset(double offset)
		{
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x00076F27 File Offset: 0x00075127
		double global::System.Windows.Controls.Primitives.IScrollInfo.VerticalOffset
		{
			get
			{
				if (this._currentPagePosition == null)
				{
					return 0.0;
				}
				return this._currentPagePosition.VerticalOffset;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x00076F46 File Offset: 0x00075146
		double global::System.Windows.Controls.Primitives.IScrollInfo.ViewportHeight
		{
			get
			{
				return base.ActualHeight;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x00076F4E File Offset: 0x0007514E
		double global::System.Windows.Controls.Primitives.IScrollInfo.ViewportWidth
		{
			get
			{
				return base.ActualWidth;
			}
		}

		// Token: 0x04000A87 RID: 2695
		private int _pageCount;

		// Token: 0x04000A88 RID: 2696
		private bool _isEndReached;

		// Token: 0x04000A89 RID: 2697
		private double _scaleFactor;

		// Token: 0x04000A8A RID: 2698
		private global::System.Collections.Hashtable _repeatTypeHelper;

		// Token: 0x04000A8B RID: 2699
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x04000A8C RID: 2700
		private global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.TabularPagePosition _currentPagePosition;

		// Token: 0x04000A8D RID: 2701
		private double _availableExtentInPreviousMeasure;

		// Token: 0x04000A8E RID: 2702
		private double _largestRecordExtentInPreviousMeasure;

		// Token: 0x04000A8F RID: 2703
		private global::Infragistics.Windows.DataPresenter.RecordListControl _recordListControl;

		// Token: 0x04000A90 RID: 2704
		private global::Infragistics.Windows.Reporting.ReportSettings _reportSettings;

		// Token: 0x04000A91 RID: 2705
		private global::System.Windows.Controls.Orientation _gridViewOrientation;

		// Token: 0x04000A92 RID: 2706
		private int _totalVisibleGeneratedItems;

		// Token: 0x04000A93 RID: 2707
		private global::System.Windows.Controls.ScrollViewer _scrollOwner;

		// Token: 0x02000198 RID: 408
		private class TabularPagePosition : global::Infragistics.Windows.Reporting.PagePosition, global::System.ICloneable
		{
			// Token: 0x060019E7 RID: 6631 RVA: 0x00076F56 File Offset: 0x00075156
			internal TabularPagePosition() : this(0, 0, 0.0, 0.0)
			{
			}

			// Token: 0x060019E8 RID: 6632 RVA: 0x00076F72 File Offset: 0x00075172
			internal TabularPagePosition(int indexOfFirstRecordOnPage) : this(indexOfFirstRecordOnPage, 0, 0.0, 0.0)
			{
			}

			// Token: 0x060019E9 RID: 6633 RVA: 0x00076F90 File Offset: 0x00075190
			internal TabularPagePosition(int indexOfFirstRecordOnPage, int indexOfLastRecordOnPage, double horizontalOffset, double verticalOffset)
			{
				this._indexOfFirstRecordOnPage = indexOfFirstRecordOnPage;
				this._indexOfLastRecordOnPage = indexOfLastRecordOnPage;
				this._horizontalOffset = horizontalOffset;
				this._verticalOffset = verticalOffset;
				this._extraExtentNeeded = 0.0;
				this._totalRowCount = 0;
				this._logicalRow = 1;
				this._logicalColumn = 1;
			}

			// Token: 0x170006FA RID: 1786
			// (get) Token: 0x060019EA RID: 6634 RVA: 0x00076FF0 File Offset: 0x000751F0
			internal bool IsEndReached
			{
				get
				{
					if (this._isLeftThenDown)
					{
						if (this._totalRowCount <= this._indexOfLastRecordOnPage + 1)
						{
							if (this._gridViewOrientation == global::System.Windows.Controls.Orientation.Vertical)
							{
								if (this._extraExtentNeeded <= this._horizontalOffset)
								{
									return true;
								}
							}
							else if (this._extraExtentNeeded <= this._verticalOffset)
							{
								return true;
							}
						}
						return false;
					}
					double num = (this._gridViewOrientation == global::System.Windows.Controls.Orientation.Vertical) ? this._horizontalOffset : this._verticalOffset;
					if (this._extraExtentNeeded <= num)
					{
						if (num == 0.0 && this._totalRowCount <= this._indexOfLastRecordOnPage + 1 && this._horizontalOptimization.Count == 0)
						{
							return true;
						}
						if (num != 0.0 && this._horizontalOptimization.Count == 0)
						{
							return true;
						}
					}
					return false;
				}
			}

			// Token: 0x170006FB RID: 1787
			// (get) Token: 0x060019EB RID: 6635 RVA: 0x000770A8 File Offset: 0x000752A8
			// (set) Token: 0x060019EC RID: 6636 RVA: 0x000770B0 File Offset: 0x000752B0
			internal global::System.Windows.Size AvailableSize
			{
				get
				{
					return this._availableSize;
				}
				set
				{
					this._availableSize = value;
				}
			}

			// Token: 0x170006FC RID: 1788
			// (get) Token: 0x060019ED RID: 6637 RVA: 0x000770B9 File Offset: 0x000752B9
			internal global::System.Collections.Generic.Stack<global::System.Windows.Vector> ExtraOffsetStack
			{
				get
				{
					if (this._extraOffsetStack == null)
					{
						this._extraOffsetStack = new global::System.Collections.Generic.Stack<global::System.Windows.Vector>();
					}
					return this._extraOffsetStack;
				}
			}

			// Token: 0x170006FD RID: 1789
			// (get) Token: 0x060019EE RID: 6638 RVA: 0x000770D4 File Offset: 0x000752D4
			// (set) Token: 0x060019EF RID: 6639 RVA: 0x000770DC File Offset: 0x000752DC
			internal global::System.Windows.Controls.Orientation GridViewOrientation
			{
				get
				{
					return this._gridViewOrientation;
				}
				set
				{
					this._gridViewOrientation = value;
				}
			}

			// Token: 0x170006FE RID: 1790
			// (get) Token: 0x060019F0 RID: 6640 RVA: 0x000770E5 File Offset: 0x000752E5
			internal int LogicalPageNumber
			{
				get
				{
					return this._logicalRow;
				}
			}

			// Token: 0x170006FF RID: 1791
			// (get) Token: 0x060019F1 RID: 6641 RVA: 0x000770ED File Offset: 0x000752ED
			internal int LogicalPagePartNumber
			{
				get
				{
					return this._logicalColumn;
				}
			}

			// Token: 0x17000700 RID: 1792
			// (get) Token: 0x060019F2 RID: 6642 RVA: 0x000770F5 File Offset: 0x000752F5
			internal int IndexOfFirstRecordOnPage
			{
				get
				{
					return this._indexOfFirstRecordOnPage;
				}
			}

			// Token: 0x17000701 RID: 1793
			// (get) Token: 0x060019F3 RID: 6643 RVA: 0x000770FD File Offset: 0x000752FD
			// (set) Token: 0x060019F4 RID: 6644 RVA: 0x00077105 File Offset: 0x00075305
			internal int IndexOfLastRecordOnPage
			{
				get
				{
					return this._indexOfLastRecordOnPage;
				}
				set
				{
					this._indexOfLastRecordOnPage = value;
				}
			}

			// Token: 0x17000702 RID: 1794
			// (get) Token: 0x060019F5 RID: 6645 RVA: 0x0007710E File Offset: 0x0007530E
			internal double HorizontalOffset
			{
				get
				{
					return this._horizontalOffset;
				}
			}

			// Token: 0x17000703 RID: 1795
			// (get) Token: 0x060019F6 RID: 6646 RVA: 0x00077116 File Offset: 0x00075316
			internal double VerticalOffset
			{
				get
				{
					return this._verticalOffset;
				}
			}

			// Token: 0x17000704 RID: 1796
			// (get) Token: 0x060019F7 RID: 6647 RVA: 0x0007711E File Offset: 0x0007531E
			// (set) Token: 0x060019F8 RID: 6648 RVA: 0x00077126 File Offset: 0x00075326
			internal double ExtraExtentNeeded
			{
				get
				{
					return this._extraExtentNeeded;
				}
				set
				{
					this._extraExtentNeeded = value;
				}
			}

			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x060019F9 RID: 6649 RVA: 0x0007712F File Offset: 0x0007532F
			// (set) Token: 0x060019FA RID: 6650 RVA: 0x00077137 File Offset: 0x00075337
			internal int TotalRowCount
			{
				get
				{
					return this._totalRowCount;
				}
				set
				{
					this._totalRowCount = value;
				}
			}

			// Token: 0x060019FB RID: 6651 RVA: 0x00077140 File Offset: 0x00075340
			public override bool Equals(object obj)
			{
				global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.TabularPagePosition tabularPagePosition = obj as global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.TabularPagePosition;
				return tabularPagePosition != null && (tabularPagePosition.IndexOfFirstRecordOnPage == this.IndexOfFirstRecordOnPage && tabularPagePosition.IndexOfLastRecordOnPage == this.IndexOfLastRecordOnPage && tabularPagePosition.HorizontalOffset == this.HorizontalOffset && tabularPagePosition.VerticalOffset == this.VerticalOffset);
			}

			// Token: 0x060019FC RID: 6652 RVA: 0x00077194 File Offset: 0x00075394
			public override int GetHashCode()
			{
				return this._indexOfFirstRecordOnPage.GetHashCode() / 4 + this._indexOfLastRecordOnPage.GetHashCode() / 4 + this._verticalOffset.GetHashCode() / 4 + this._horizontalOffset.GetHashCode() / 4;
			}

			// Token: 0x060019FD RID: 6653 RVA: 0x000771DC File Offset: 0x000753DC
			internal bool MoveLeft(double offset)
			{
				this._isLeftThenDown = true;
				if (this._gridViewOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					if (this._extraExtentNeeded <= this._horizontalOffset)
					{
						return false;
					}
					this._horizontalOffset += offset;
				}
				else
				{
					if (this._extraExtentNeeded > this._verticalOffset)
					{
						this._horizontalOptimization.Add(new global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.PositionData(this._indexOfFirstRecordOnPage, this._logicalColumn));
					}
					if (this._totalRowCount <= this._indexOfLastRecordOnPage + 1)
					{
						return false;
					}
					if (this._verticalOffset == 0.0)
					{
						this._indexOfFirstRecordOnPage = this._indexOfLastRecordOnPage + 1;
						this._indexOfLastRecordOnPage = -1;
					}
					else
					{
						if (this._horizontalOptimization.Count == 0)
						{
							return false;
						}
						this._indexOfFirstRecordOnPage = this._horizontalOptimization[0].FirstRowOnPage + 1;
						this._indexOfLastRecordOnPage = -1;
						this._logicalColumn = this._horizontalOptimization[0].LogicalRow;
						this._horizontalOptimization.RemoveAt(0);
						return true;
					}
				}
				this._logicalColumn++;
				return true;
			}

			// Token: 0x060019FE RID: 6654 RVA: 0x000772E4 File Offset: 0x000754E4
			internal bool MoveLeftGoToTop(double offset)
			{
				if (this._gridViewOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					if (this._horizontalOptimization.Count == 0)
					{
						return false;
					}
					this._indexOfFirstRecordOnPage = this._horizontalOptimization[0].FirstRowOnPage;
					this._indexOfLastRecordOnPage = -1;
					this._logicalRow = this._horizontalOptimization[0].LogicalRow;
					this._horizontalOffset += offset;
					this._verticalOffset = 0.0;
					this._horizontalOptimization.RemoveAt(0);
				}
				else
				{
					if (this._totalRowCount <= this._indexOfLastRecordOnPage + 1)
					{
						return false;
					}
					this._verticalOffset = 0.0;
					this._indexOfFirstRecordOnPage = this._indexOfLastRecordOnPage + 1;
					this._indexOfLastRecordOnPage = -1;
					this._logicalRow = 1;
				}
				this._logicalColumn++;
				return true;
			}

			// Token: 0x060019FF RID: 6655 RVA: 0x000773B8 File Offset: 0x000755B8
			internal void MoveToFirstPage()
			{
				this._indexOfFirstRecordOnPage = 0;
				this._indexOfLastRecordOnPage = -1;
				this._verticalOffset = 0.0;
				this._horizontalOffset = 0.0;
				this._extraExtentNeeded = 0.0;
				this._logicalRow = 1;
				this._logicalColumn = 1;
			}

			// Token: 0x06001A00 RID: 6656 RVA: 0x00077410 File Offset: 0x00075610
			internal bool MoveDown(double offset)
			{
				if (this._gridViewOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					if (this._extraExtentNeeded > this._horizontalOffset)
					{
						this._horizontalOptimization.Add(new global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.PositionData(this._indexOfFirstRecordOnPage, this._logicalRow));
					}
					if (this._totalRowCount <= this._indexOfLastRecordOnPage + 1)
					{
						return false;
					}
					if (this._horizontalOffset == 0.0)
					{
						this._indexOfFirstRecordOnPage = this._indexOfLastRecordOnPage + 1;
						this._indexOfLastRecordOnPage = -1;
					}
					else
					{
						if (this._horizontalOptimization.Count == 0)
						{
							return false;
						}
						this._indexOfFirstRecordOnPage = this._horizontalOptimization[0].FirstRowOnPage;
						this._indexOfLastRecordOnPage = -1;
						this._logicalRow = this._horizontalOptimization[0].LogicalRow;
						this._horizontalOptimization.RemoveAt(0);
						return true;
					}
				}
				else
				{
					if (this._extraExtentNeeded <= this._verticalOffset)
					{
						return false;
					}
					this._verticalOffset += offset;
				}
				this._logicalRow++;
				return true;
			}

			// Token: 0x06001A01 RID: 6657 RVA: 0x0007750C File Offset: 0x0007570C
			internal bool MoveDownGoToStartOfRow(double offset)
			{
				if (this._gridViewOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					if (this._totalRowCount <= this._indexOfLastRecordOnPage + 1)
					{
						return false;
					}
					this._horizontalOffset = 0.0;
					this._indexOfFirstRecordOnPage = this._indexOfLastRecordOnPage + 1;
					this._indexOfLastRecordOnPage = -1;
				}
				else
				{
					if (this._horizontalOptimization.Count == 0)
					{
						return false;
					}
					this._indexOfFirstRecordOnPage = this._horizontalOptimization[0].FirstRowOnPage;
					this._indexOfLastRecordOnPage = 0;
					this._logicalColumn = this._horizontalOptimization[0].LogicalRow;
					this._horizontalOffset = 0.0;
					this._verticalOffset += offset;
					this._horizontalOptimization.RemoveAt(0);
				}
				this._logicalRow++;
				this._logicalColumn = 1;
				return true;
			}

			// Token: 0x06001A02 RID: 6658 RVA: 0x000775DD File Offset: 0x000757DD
			internal bool IsOnFirstPosition()
			{
				return this._indexOfFirstRecordOnPage == 0 && this._indexOfLastRecordOnPage != 0 && this._verticalOffset == 0.0 && this._horizontalOffset == 0.0;
			}

			// Token: 0x06001A03 RID: 6659 RVA: 0x00077614 File Offset: 0x00075814
			public object Clone()
			{
				global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.TabularPagePosition tabularPagePosition = new global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.TabularPagePosition(this._indexOfFirstRecordOnPage, this._indexOfLastRecordOnPage, this._horizontalOffset, this._verticalOffset);
				tabularPagePosition.GridViewOrientation = this.GridViewOrientation;
				tabularPagePosition._logicalColumn = this._logicalColumn;
				tabularPagePosition._logicalRow = this._logicalRow;
				tabularPagePosition._extraExtentNeeded = this._extraExtentNeeded;
				tabularPagePosition._horizontalOptimization = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.PositionData>(this._horizontalOptimization);
				if (this._extraOffsetStack != null && this._extraOffsetStack.Count > 0)
				{
					global::System.Windows.Vector[] array = this._extraOffsetStack.ToArray();
					global::System.Array.Reverse(array, 0, array.Length);
					tabularPagePosition._extraOffsetStack = new global::System.Collections.Generic.Stack<global::System.Windows.Vector>(array);
				}
				return tabularPagePosition;
			}

			// Token: 0x04000A94 RID: 2708
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.PositionData> _horizontalOptimization = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.PositionData>();

			// Token: 0x04000A95 RID: 2709
			private int _logicalRow;

			// Token: 0x04000A96 RID: 2710
			private int _logicalColumn;

			// Token: 0x04000A97 RID: 2711
			private int _indexOfFirstRecordOnPage;

			// Token: 0x04000A98 RID: 2712
			private int _indexOfLastRecordOnPage;

			// Token: 0x04000A99 RID: 2713
			private double _horizontalOffset;

			// Token: 0x04000A9A RID: 2714
			private double _verticalOffset;

			// Token: 0x04000A9B RID: 2715
			private double _extraExtentNeeded;

			// Token: 0x04000A9C RID: 2716
			private int _totalRowCount;

			// Token: 0x04000A9D RID: 2717
			private global::System.Windows.Controls.Orientation _gridViewOrientation;

			// Token: 0x04000A9E RID: 2718
			private global::System.Windows.Size _availableSize;

			// Token: 0x04000A9F RID: 2719
			private bool _isLeftThenDown;

			// Token: 0x04000AA0 RID: 2720
			private global::System.Collections.Generic.Stack<global::System.Windows.Vector> _extraOffsetStack;
		}

		// Token: 0x02000199 RID: 409
		private class PositionData
		{
			// Token: 0x06001A04 RID: 6660 RVA: 0x000776B9 File Offset: 0x000758B9
			public PositionData(int indexRow, int logicalRow)
			{
				this.FirstRowOnPage = indexRow;
				this.LogicalRow = logicalRow;
			}

			// Token: 0x04000AA1 RID: 2721
			public int FirstRowOnPage;

			// Token: 0x04000AA2 RID: 2722
			public int LogicalRow;
		}

		// Token: 0x0200019A RID: 410
		private class FieldLayoutNestingLevelKey
		{
			// Token: 0x06001A05 RID: 6661 RVA: 0x000776CF File Offset: 0x000758CF
			internal FieldLayoutNestingLevelKey(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, int nestingLevel)
			{
				this._fieldLayout = fieldLayout;
				this._nestingLevel = nestingLevel;
			}

			// Token: 0x06001A06 RID: 6662 RVA: 0x000776E8 File Offset: 0x000758E8
			public override bool Equals(object obj)
			{
				global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.FieldLayoutNestingLevelKey fieldLayoutNestingLevelKey = obj as global::Infragistics.Windows.DataPresenter.TabularReportViewPanelBase.FieldLayoutNestingLevelKey;
				return fieldLayoutNestingLevelKey != null && fieldLayoutNestingLevelKey._nestingLevel == this._nestingLevel && fieldLayoutNestingLevelKey._fieldLayout == this._fieldLayout;
			}

			// Token: 0x06001A07 RID: 6663 RVA: 0x0007771F File Offset: 0x0007591F
			public override int GetHashCode()
			{
				return this._fieldLayout.GetHashCode() / 10 + this._nestingLevel.GetHashCode() / 10;
			}

			// Token: 0x06001A08 RID: 6664 RVA: 0x0007773E File Offset: 0x0007593E
			internal bool IsSameKey(global::Infragistics.Windows.DataPresenter.FieldLayout fl, int nestingDepth)
			{
				return nestingDepth == this._nestingLevel && fl == this._fieldLayout;
			}

			// Token: 0x04000AA3 RID: 2723
			private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

			// Token: 0x04000AA4 RID: 2724
			private int _nestingLevel;
		}
	}
}
