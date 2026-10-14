using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using Infragistics.Windows.Reporting;
using Infragistics.Windows.Selection;
using Infragistics.Windows.Virtualization;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200019B RID: 411
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public sealed class TabularReportViewPanel : global::Infragistics.Windows.Virtualization.RecyclingItemsPanel, global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator, global::System.Windows.Controls.Primitives.IScrollInfo
	{
		// Token: 0x060016A6 RID: 5798 RVA: 0x00063F7C File Offset: 0x0006217C
		public TabularReportViewPanel()
		{
			this._repeatTypeHelper = new global::System.Collections.Hashtable();
			this._currentPagePosition = new global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.TabularPagePosition();
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x00063F9A File Offset: 0x0006219A
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x00063FA2 File Offset: 0x000621A2
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

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x00063FC3 File Offset: 0x000621C3
		internal double ScaleFactor
		{
			get
			{
				return this._scaleFactor;
			}
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00063FCC File Offset: 0x000621CC
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			base.ArrangeOverride(finalSize);
			if (this._currentPagePosition == null)
			{
				return finalSize;
			}
			global::System.Collections.IList childElements = base.ChildElements;
			global::Infragistics.Windows.DataPresenter.TabularReportView tabularReportView = this.DataPresenter.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.TabularReportView;
			double levelIndentation = tabularReportView.LevelIndentation;
			double num = -this._currentPagePosition.VerticalOffset;
			double num2 = -this._currentPagePosition.HorizontalOffset;
			bool flag = this._gridViewOrientation == global::System.Windows.Controls.Orientation.Vertical;
			bool flag2 = this._reportSettings.HorizontalPaginationMode == global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Scale && this._scaleFactor < 1.0;
			global::System.Windows.Vector vector = default(global::System.Windows.Vector);
			global::System.Collections.Generic.Stack<global::System.Windows.Vector> stack = null;
			int num3 = 0;
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
				double num4 = 0.0;
				if (recordPresenterFromContainer != null)
				{
					num4 = (double)recordPresenterFromContainer.Record.NestingDepth * levelIndentation;
					if (stack != null)
					{
						while (i < stack.Count)
						{
							vector.Y -= stack.Pop().Y;
						}
						if (!flag3)
						{
							num4 -= (double)i * levelIndentation;
						}
					}
					if (flag3)
					{
						num2 = num4 * this._scaleFactor + vector.X;
						if (!flag)
						{
							num = -this._currentPagePosition.VerticalOffset + vector.Y;
						}
					}
					else if (flag)
					{
						num2 = -this._currentPagePosition.HorizontalOffset + num4 * this._scaleFactor + vector.X;
					}
					else
					{
						num = -this._currentPagePosition.VerticalOffset + num4 * this._scaleFactor + vector.Y;
					}
				}
				double height = uielement.DesiredSize.Height;
				double num5 = uielement.DesiredSize.Width;
				if (flag3 && flag)
				{
					if (!flag2)
					{
						num5 = global::System.Math.Max(global::System.Math.Max(this._largestRecordExtentInPreviousMeasure, finalSize.Width + this._currentPagePosition.HorizontalOffset) - num4, 10.0);
						num2 = num4;
						num2 -= this._currentPagePosition.HorizontalOffset;
						recordPresenterFromContainer.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedNearElementTransformPropertyKey, new global::System.Windows.Media.TranslateTransform(this._currentPagePosition.HorizontalOffset, 0.0));
						recordPresenterFromContainer.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ScrollableElementTransformPropertyKey, new global::System.Windows.Media.TranslateTransform(-this._currentPagePosition.HorizontalOffset, 0.0));
					}
					else
					{
						num5 = global::System.Math.Max(num5, this._largestRecordExtentInPreviousMeasure - num4);
					}
				}
				double num6 = height;
				double num7 = num5;
				if (flag2)
				{
					num6 = height * this._scaleFactor;
					num7 = num5 * this._scaleFactor;
				}
				if (flag2)
				{
					uielement.RenderTransform = new global::System.Windows.Media.ScaleTransform(this._scaleFactor, this._scaleFactor);
				}
				else
				{
					uielement.ClearValue(global::System.Windows.UIElement.RenderTransformProperty);
				}
				if (num3 > 0 && ((num + num6 > finalSize.Height && flag) || (num2 + num7 > finalSize.Width && !flag)))
				{
					if (recordPresenterFromContainer != null)
					{
						recordPresenterFromContainer.IsArrangedInView = false;
					}
					uielement.Arrange(new global::System.Windows.Rect(-100000.0, -100000.0, num5, height));
				}
				else
				{
					if (recordPresenterFromContainer != null)
					{
						recordPresenterFromContainer.IsArrangedInView = true;
					}
					uielement.Arrange(new global::System.Windows.Rect(num2, num, num5, height));
					num3++;
				}
				if (flag3)
				{
					num += num6;
					vector.Y += num6;
					if (stack != null)
					{
						stack.Push(new global::System.Windows.Vector(levelIndentation, num6));
					}
				}
				else if (flag)
				{
					num += num6;
				}
				else
				{
					num2 += num7;
					if (recordPresenterFromContainer != null && recordPresenterFromContainer.Record.ParentRecord is global::Infragistics.Windows.DataPresenter.GroupByRecord)
					{
						vector.X += num7;
					}
				}
			}
			return finalSize;
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00064430 File Offset: 0x00062630
		protected override bool GetCanCleanupItem(int itemIndex)
		{
			return true;
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00064434 File Offset: 0x00062634
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (this._currentPagePosition == null)
			{
				return new global::System.Windows.Size(1.0, 1.0);
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			global::Infragistics.Windows.DataPresenter.TabularReportView tabularReportView = dataPresenter.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.TabularReportView;
			if (this._reportSettings.RepeatType == global::Infragistics.Windows.Reporting.RepeatType.PageBreak)
			{
				this._repeatTypeHelper.Clear();
			}
			this._largestRecordExtentInPreviousMeasure = 0.0;
			double levelIndentation = tabularReportView.LevelIndentation;
			global::System.Windows.Size result = new global::System.Windows.Size(0.0, 0.0);
			bool flag = double.IsPositiveInfinity(availableSize.Height);
			bool flag2 = double.IsPositiveInfinity(availableSize.Width);
			int num = -1;
			int num2 = 0;
			int i = this._currentPagePosition.IndexOfFirstRecordOnPage;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
			global::Infragistics.Windows.DataPresenter.Record record = null;
			global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy headerPlacementInGroupBy = global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.WithDataRecords;
			bool flag3 = false;
			int num3 = 0;
			double num4 = availableSize.Width;
			double num5 = availableSize.Height;
			this._scaleFactor = 1.0;
			global::System.Windows.Vector vector = default(global::System.Windows.Vector);
			bool flag4 = this._gridViewOrientation == global::System.Windows.Controls.Orientation.Vertical;
			global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.FieldLayoutNestingLevelKey fieldLayoutNestingLevelKey = null;
			int num6 = 0;
			base.BeginGeneration(global::Infragistics.Windows.Selection.ScrollDirection.Increment);
			global::System.Windows.Controls.Primitives.GeneratorPosition generatorPositionFromItemIndex = this.GetGeneratorPositionFromItemIndex(i, out num2);
			global::System.Windows.Controls.Primitives.IItemContainerGenerator activeItemContainerGenerator = base.ActiveItemContainerGenerator;
			using (activeItemContainerGenerator.StartAt(generatorPositionFromItemIndex, global::System.Windows.Controls.Primitives.GeneratorDirection.Forward, true))
			{
				int count = this.RecordListControl.Items.Count;
				int num7 = base.ChildElements.Count;
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
						if (num < 0)
						{
							num = this.FindSlotForNewlyRealizedRecordPresenter(i);
						}
						if (num >= num7)
						{
							base.AddInternalChild(uielement);
						}
						else
						{
							base.InsertInternalChild(num, uielement);
						}
						num++;
						num7++;
						activeItemContainerGenerator.PrepareItemContainer(uielement);
					}
					global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(uielement);
					double num8 = 0.0;
					if (recordPresenterFromContainer != null)
					{
						bool flag7 = !flag5;
						bool addHeader = false;
						recordPresenterFromContainer.InitializeRecordContentVisibility(flag7);
						recordPresenterFromContainer.InitializeExpandableRecordContentVisibility(flag7);
						recordPresenterFromContainer.InitializeGroupByRecordContentVisibility(flag7);
						global::Infragistics.Windows.DataPresenter.Record record2 = recordPresenterFromContainer.Record;
						int nestingDepth = record2.NestingDepth;
						num8 = levelIndentation * (double)nestingDepth;
						if (record2 is global::Infragistics.Windows.DataPresenter.DataRecord)
						{
							global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = record2.FieldLayout;
							if (fieldLayoutNestingLevelKey == null || !fieldLayoutNestingLevelKey.IsSameKey(fieldLayout2, nestingDepth))
							{
								fieldLayoutNestingLevelKey = new global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.FieldLayoutNestingLevelKey(fieldLayout2, nestingDepth);
							}
							if (fieldLayout2 != fieldLayout || nestingDepth != num3)
							{
								if (this._reportSettings.RepeatType == global::Infragistics.Windows.Reporting.RepeatType.FirstOccurrence)
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = this._repeatTypeHelper[fieldLayoutNestingLevelKey] as global::Infragistics.Windows.DataPresenter.DataRecord;
									if (dataRecord2 == null)
									{
										addHeader = true;
										this._repeatTypeHelper[fieldLayoutNestingLevelKey] = record2;
									}
									else if (dataRecord2 == record2)
									{
										addHeader = true;
									}
								}
								else if (this._reportSettings.RepeatType == global::Infragistics.Windows.Reporting.RepeatType.PageBreak)
								{
									if (!(this._repeatTypeHelper[fieldLayoutNestingLevelKey] is bool?))
									{
										addHeader = true;
										this._repeatTypeHelper[fieldLayoutNestingLevelKey] = true;
									}
								}
								else
								{
									addHeader = true;
								}
								num3 = nestingDepth;
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
								num3 = record2.NestingDepth;
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
						if (!flag && num6 != 0 && result.Height + desiredSize.Height > num5)
						{
							break;
						}
						num6++;
						double val = num8 + desiredSize.Width;
						this._largestRecordExtentInPreviousMeasure = global::System.Math.Max(this._largestRecordExtentInPreviousMeasure, val);
						result.Width = this._largestRecordExtentInPreviousMeasure;
						result.Height += desiredSize.Height;
						if (this._reportSettings.HorizontalPaginationMode == global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Scale)
						{
							double num9 = availableSize.Width / (num8 + uielement.DesiredSize.Width);
							if (num9 < 1.0 && num9 < this._scaleFactor)
							{
								this._scaleFactor = num9;
								num5 = availableSize.Height / this._scaleFactor;
							}
						}
					}
					else
					{
						this._availableExtentInPreviousMeasure = availableSize.Height;
						bool flag8 = recordPresenterFromContainer is global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter;
						double num10;
						if (flag8)
						{
							num10 = global::System.Math.Max(result.Width, vector.X + num8 + desiredSize.Width);
						}
						else
						{
							num10 = global::System.Math.Max(result.Width, vector.X + desiredSize.Width);
						}
						if (!flag2 && num6 != 0 && num10 > num4)
						{
							break;
						}
						num6++;
						double height = desiredSize.Height;
						if (flag8 && recordPresenterFromContainer.Record.ParentRecord == null)
						{
							vector.Y = 0.0;
						}
						if (flag8)
						{
							vector.X += num8 + desiredSize.Width;
							vector.Y += desiredSize.Height;
						}
						else
						{
							vector.X += desiredSize.Width;
							vector.Y += num8;
							result.Height = this._largestRecordExtentInPreviousMeasure;
						}
						this._largestRecordExtentInPreviousMeasure = global::System.Math.Max(this._largestRecordExtentInPreviousMeasure, height);
						result.Width = num10;
						if (this._reportSettings.HorizontalPaginationMode == global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Scale)
						{
							double num9 = availableSize.Height / (num8 + desiredSize.Height);
							if (num9 < 1.0 && num9 < this._scaleFactor)
							{
								this._scaleFactor = num9;
								num4 = availableSize.Width / this._scaleFactor;
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

		// Token: 0x060016AD RID: 5805 RVA: 0x00064B8C File Offset: 0x00062D8C
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataPresenterProperty)
			{
				this._dataPresenter = (e.NewValue as global::Infragistics.Windows.DataPresenter.DataPresenterBase);
				this._reportSettings = (this._dataPresenter as global::Infragistics.Windows.DataPresenter.DataPresenterReportControl).Section.Report.ReportSettings;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x00064BE0 File Offset: 0x00062DE0
		protected override int TotalVisibleGeneratedItems
		{
			get
			{
				return this._totalVisibleGeneratedItems;
			}
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00064BE8 File Offset: 0x00062DE8
		private double CalculateExtraExtentNeeded()
		{
			bool flag = this._reportSettings.HorizontalPaginationMode == global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Scale && this._scaleFactor < 1.0;
			if (flag)
			{
				return 0.0;
			}
			return global::System.Math.Max(this._largestRecordExtentInPreviousMeasure - this._availableExtentInPreviousMeasure, 0.0);
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00064C40 File Offset: 0x00062E40
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

		// Token: 0x060016B1 RID: 5809 RVA: 0x00064C8C File Offset: 0x00062E8C
		private global::System.Windows.Controls.Primitives.GeneratorPosition GetGeneratorPositionFromItemIndex(int itemIndex, out int childIndex)
		{
			global::System.Windows.Controls.Primitives.IItemContainerGenerator activeItemContainerGenerator = base.ActiveItemContainerGenerator;
			global::System.Windows.Controls.Primitives.GeneratorPosition result = (activeItemContainerGenerator != null) ? activeItemContainerGenerator.GeneratorPositionFromIndex(itemIndex) : new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, itemIndex + 1);
			childIndex = ((result.Offset == 0) ? result.Index : (result.Index + 1));
			return result;
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00064CD4 File Offset: 0x00062ED4
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

		// Token: 0x060016B3 RID: 5811 RVA: 0x00064D68 File Offset: 0x00062F68
		void global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.BeginPagination(global::Infragistics.Windows.Reporting.ReportSection section)
		{
			global::Infragistics.Windows.DataPresenter.TabularReportView tabularReportView = this._dataPresenter.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.TabularReportView;
			this._gridViewOrientation = tabularReportView.LogicalOrientation;
			this._currentPagePosition = new global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.TabularPagePosition();
			this._currentPagePosition.GridViewOrientation = this._gridViewOrientation;
			this._isEndReached = false;
			this._repeatTypeHelper.Clear();
			((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)this).MoveToPosition(global::Infragistics.Windows.Reporting.PagePosition.FirstPage);
			this.EstimatePageCount();
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x00064DD4 File Offset: 0x00062FD4
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

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x00064E1F File Offset: 0x0006301F
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

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x00064E4D File Offset: 0x0006304D
		int global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.LogicalPageNumber
		{
			get
			{
				return this._currentPagePosition.LogicalPageNumber;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x00064E5A File Offset: 0x0006305A
		int global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.LogicalPagePartNumber
		{
			get
			{
				return this._currentPagePosition.LogicalPagePartNumber;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x00064E67 File Offset: 0x00063067
		int global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.EstimatedPageCount
		{
			get
			{
				return this._pageCount;
			}
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00064E6F File Offset: 0x0006306F
		void global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.EndPagination()
		{
			this._currentPagePosition = null;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00064E78 File Offset: 0x00063078
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

		// Token: 0x060016BB RID: 5819 RVA: 0x00064FE4 File Offset: 0x000631E4
		bool global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.MoveToPosition(global::Infragistics.Windows.Reporting.PagePosition pagePosition)
		{
			global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.TabularPagePosition tabularPagePosition = pagePosition as global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.TabularPagePosition;
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
				this._currentPagePosition = (tabularPagePosition.Clone() as global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.TabularPagePosition);
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

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x000650F0 File Offset: 0x000632F0
		// (set) Token: 0x060016BD RID: 5821 RVA: 0x000650F3 File Offset: 0x000632F3
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

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x000650F5 File Offset: 0x000632F5
		// (set) Token: 0x060016BF RID: 5823 RVA: 0x000650F8 File Offset: 0x000632F8
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

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x000650FA File Offset: 0x000632FA
		double global::System.Windows.Controls.Primitives.IScrollInfo.ExtentHeight
		{
			get
			{
				return 1000000.0;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x00065105 File Offset: 0x00063305
		double global::System.Windows.Controls.Primitives.IScrollInfo.ExtentWidth
		{
			get
			{
				return 1000000.0;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x00065110 File Offset: 0x00063310
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

		// Token: 0x060016C3 RID: 5827 RVA: 0x0006512F File Offset: 0x0006332F
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineDown()
		{
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00065131 File Offset: 0x00063331
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineLeft()
		{
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00065133 File Offset: 0x00063333
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineRight()
		{
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00065135 File Offset: 0x00063335
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineUp()
		{
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00065138 File Offset: 0x00063338
		global::System.Windows.Rect global::System.Windows.Controls.Primitives.IScrollInfo.MakeVisible(global::System.Windows.Media.Visual visual, global::System.Windows.Rect rectangle)
		{
			return default(global::System.Windows.Rect);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x0006514E File Offset: 0x0006334E
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelDown()
		{
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00065150 File Offset: 0x00063350
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelLeft()
		{
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00065152 File Offset: 0x00063352
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelRight()
		{
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00065154 File Offset: 0x00063354
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelUp()
		{
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00065156 File Offset: 0x00063356
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageDown()
		{
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00065158 File Offset: 0x00063358
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageLeft()
		{
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0006515A File Offset: 0x0006335A
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageRight()
		{
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x0006515C File Offset: 0x0006335C
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageUp()
		{
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x0006515E File Offset: 0x0006335E
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x00065166 File Offset: 0x00063366
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

		// Token: 0x060016D2 RID: 5842 RVA: 0x0006516F File Offset: 0x0006336F
		void global::System.Windows.Controls.Primitives.IScrollInfo.SetHorizontalOffset(double offset)
		{
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00065171 File Offset: 0x00063371
		void global::System.Windows.Controls.Primitives.IScrollInfo.SetVerticalOffset(double offset)
		{
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x00065173 File Offset: 0x00063373
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

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x00065192 File Offset: 0x00063392
		double global::System.Windows.Controls.Primitives.IScrollInfo.ViewportHeight
		{
			get
			{
				return base.ActualHeight;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x0006519A File Offset: 0x0006339A
		double global::System.Windows.Controls.Primitives.IScrollInfo.ViewportWidth
		{
			get
			{
				return base.ActualWidth;
			}
		}

		// Token: 0x040008DA RID: 2266
		private int _pageCount;

		// Token: 0x040008DB RID: 2267
		private bool _isEndReached;

		// Token: 0x040008DC RID: 2268
		private double _scaleFactor;

		// Token: 0x040008DD RID: 2269
		private global::System.Collections.Hashtable _repeatTypeHelper;

		// Token: 0x040008DE RID: 2270
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x040008DF RID: 2271
		private global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.TabularPagePosition _currentPagePosition;

		// Token: 0x040008E0 RID: 2272
		private double _availableExtentInPreviousMeasure;

		// Token: 0x040008E1 RID: 2273
		private double _largestRecordExtentInPreviousMeasure;

		// Token: 0x040008E2 RID: 2274
		private global::Infragistics.Windows.DataPresenter.RecordListControl _recordListControl;

		// Token: 0x040008E3 RID: 2275
		private global::Infragistics.Windows.Reporting.ReportSettings _reportSettings;

		// Token: 0x040008E4 RID: 2276
		private global::System.Windows.Controls.Orientation _gridViewOrientation;

		// Token: 0x040008E5 RID: 2277
		private int _totalVisibleGeneratedItems;

		// Token: 0x040008E6 RID: 2278
		private global::System.Windows.Controls.ScrollViewer _scrollOwner;

		// Token: 0x0200019C RID: 412
		private class TabularPagePosition : global::Infragistics.Windows.Reporting.PagePosition, global::System.ICloneable
		{
			// Token: 0x060016D7 RID: 5847 RVA: 0x000651A2 File Offset: 0x000633A2
			internal TabularPagePosition() : this(0, 0, 0.0, 0.0)
			{
			}

			// Token: 0x060016D8 RID: 5848 RVA: 0x000651BE File Offset: 0x000633BE
			internal TabularPagePosition(int indexOfFirstRecordOnPage) : this(indexOfFirstRecordOnPage, 0, 0.0, 0.0)
			{
			}

			// Token: 0x060016D9 RID: 5849 RVA: 0x000651DC File Offset: 0x000633DC
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

			// Token: 0x17000605 RID: 1541
			// (get) Token: 0x060016DA RID: 5850 RVA: 0x0006523C File Offset: 0x0006343C
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

			// Token: 0x17000606 RID: 1542
			// (get) Token: 0x060016DB RID: 5851 RVA: 0x000652F4 File Offset: 0x000634F4
			// (set) Token: 0x060016DC RID: 5852 RVA: 0x000652FC File Offset: 0x000634FC
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

			// Token: 0x17000607 RID: 1543
			// (get) Token: 0x060016DD RID: 5853 RVA: 0x00065305 File Offset: 0x00063505
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

			// Token: 0x17000608 RID: 1544
			// (get) Token: 0x060016DE RID: 5854 RVA: 0x00065320 File Offset: 0x00063520
			// (set) Token: 0x060016DF RID: 5855 RVA: 0x00065328 File Offset: 0x00063528
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

			// Token: 0x17000609 RID: 1545
			// (get) Token: 0x060016E0 RID: 5856 RVA: 0x00065331 File Offset: 0x00063531
			internal int LogicalPageNumber
			{
				get
				{
					return this._logicalRow;
				}
			}

			// Token: 0x1700060A RID: 1546
			// (get) Token: 0x060016E1 RID: 5857 RVA: 0x00065339 File Offset: 0x00063539
			internal int LogicalPagePartNumber
			{
				get
				{
					return this._logicalColumn;
				}
			}

			// Token: 0x1700060B RID: 1547
			// (get) Token: 0x060016E2 RID: 5858 RVA: 0x00065341 File Offset: 0x00063541
			internal int IndexOfFirstRecordOnPage
			{
				get
				{
					return this._indexOfFirstRecordOnPage;
				}
			}

			// Token: 0x1700060C RID: 1548
			// (get) Token: 0x060016E3 RID: 5859 RVA: 0x00065349 File Offset: 0x00063549
			// (set) Token: 0x060016E4 RID: 5860 RVA: 0x00065351 File Offset: 0x00063551
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

			// Token: 0x1700060D RID: 1549
			// (get) Token: 0x060016E5 RID: 5861 RVA: 0x0006535A File Offset: 0x0006355A
			internal double HorizontalOffset
			{
				get
				{
					return this._horizontalOffset;
				}
			}

			// Token: 0x1700060E RID: 1550
			// (get) Token: 0x060016E6 RID: 5862 RVA: 0x00065362 File Offset: 0x00063562
			internal double VerticalOffset
			{
				get
				{
					return this._verticalOffset;
				}
			}

			// Token: 0x1700060F RID: 1551
			// (get) Token: 0x060016E7 RID: 5863 RVA: 0x0006536A File Offset: 0x0006356A
			// (set) Token: 0x060016E8 RID: 5864 RVA: 0x00065372 File Offset: 0x00063572
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

			// Token: 0x17000610 RID: 1552
			// (get) Token: 0x060016E9 RID: 5865 RVA: 0x0006537B File Offset: 0x0006357B
			// (set) Token: 0x060016EA RID: 5866 RVA: 0x00065383 File Offset: 0x00063583
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

			// Token: 0x060016EB RID: 5867 RVA: 0x0006538C File Offset: 0x0006358C
			public override bool Equals(object obj)
			{
				global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.TabularPagePosition tabularPagePosition = obj as global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.TabularPagePosition;
				return tabularPagePosition != null && (tabularPagePosition.IndexOfFirstRecordOnPage == this.IndexOfFirstRecordOnPage && tabularPagePosition.IndexOfLastRecordOnPage == this.IndexOfLastRecordOnPage && tabularPagePosition.HorizontalOffset == this.HorizontalOffset && tabularPagePosition.VerticalOffset == this.VerticalOffset);
			}

			// Token: 0x060016EC RID: 5868 RVA: 0x000653E0 File Offset: 0x000635E0
			public override int GetHashCode()
			{
				return this._indexOfFirstRecordOnPage.GetHashCode() / 4 + this._indexOfLastRecordOnPage.GetHashCode() / 4 + this._verticalOffset.GetHashCode() / 4 + this._horizontalOffset.GetHashCode() / 4;
			}

			// Token: 0x060016ED RID: 5869 RVA: 0x00065428 File Offset: 0x00063628
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
						this._horizontalOptimization.Add(new global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.PositionData(this._indexOfFirstRecordOnPage, this._logicalColumn));
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

			// Token: 0x060016EE RID: 5870 RVA: 0x00065530 File Offset: 0x00063730
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

			// Token: 0x060016EF RID: 5871 RVA: 0x00065604 File Offset: 0x00063804
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

			// Token: 0x060016F0 RID: 5872 RVA: 0x0006565C File Offset: 0x0006385C
			internal bool MoveDown(double offset)
			{
				if (this._gridViewOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					if (this._extraExtentNeeded > this._horizontalOffset)
					{
						this._horizontalOptimization.Add(new global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.PositionData(this._indexOfFirstRecordOnPage, this._logicalRow));
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

			// Token: 0x060016F1 RID: 5873 RVA: 0x00065758 File Offset: 0x00063958
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

			// Token: 0x060016F2 RID: 5874 RVA: 0x00065829 File Offset: 0x00063A29
			internal bool IsOnFirstPosition()
			{
				return this._indexOfFirstRecordOnPage == 0 && this._indexOfLastRecordOnPage != 0 && this._verticalOffset == 0.0 && this._horizontalOffset == 0.0;
			}

			// Token: 0x060016F3 RID: 5875 RVA: 0x00065860 File Offset: 0x00063A60
			public object Clone()
			{
				global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.TabularPagePosition tabularPagePosition = new global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.TabularPagePosition(this._indexOfFirstRecordOnPage, this._indexOfLastRecordOnPage, this._horizontalOffset, this._verticalOffset);
				tabularPagePosition.GridViewOrientation = this.GridViewOrientation;
				tabularPagePosition._logicalColumn = this._logicalColumn;
				tabularPagePosition._logicalRow = this._logicalRow;
				tabularPagePosition._extraExtentNeeded = this._extraExtentNeeded;
				tabularPagePosition._horizontalOptimization = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.PositionData>(this._horizontalOptimization);
				if (this._extraOffsetStack != null && this._extraOffsetStack.Count > 0)
				{
					global::System.Windows.Vector[] array = this._extraOffsetStack.ToArray();
					global::System.Array.Reverse(array, 0, array.Length);
					tabularPagePosition._extraOffsetStack = new global::System.Collections.Generic.Stack<global::System.Windows.Vector>(array);
				}
				return tabularPagePosition;
			}

			// Token: 0x040008E7 RID: 2279
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.PositionData> _horizontalOptimization = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.PositionData>();

			// Token: 0x040008E8 RID: 2280
			private int _logicalRow;

			// Token: 0x040008E9 RID: 2281
			private int _logicalColumn;

			// Token: 0x040008EA RID: 2282
			private int _indexOfFirstRecordOnPage;

			// Token: 0x040008EB RID: 2283
			private int _indexOfLastRecordOnPage;

			// Token: 0x040008EC RID: 2284
			private double _horizontalOffset;

			// Token: 0x040008ED RID: 2285
			private double _verticalOffset;

			// Token: 0x040008EE RID: 2286
			private double _extraExtentNeeded;

			// Token: 0x040008EF RID: 2287
			private int _totalRowCount;

			// Token: 0x040008F0 RID: 2288
			private global::System.Windows.Controls.Orientation _gridViewOrientation;

			// Token: 0x040008F1 RID: 2289
			private global::System.Windows.Size _availableSize;

			// Token: 0x040008F2 RID: 2290
			private bool _isLeftThenDown;

			// Token: 0x040008F3 RID: 2291
			private global::System.Collections.Generic.Stack<global::System.Windows.Vector> _extraOffsetStack;
		}

		// Token: 0x0200019D RID: 413
		private class PositionData
		{
			// Token: 0x060016F4 RID: 5876 RVA: 0x00065905 File Offset: 0x00063B05
			public PositionData(int indexRow, int logicalRow)
			{
				this.FirstRowOnPage = indexRow;
				this.LogicalRow = logicalRow;
			}

			// Token: 0x040008F4 RID: 2292
			public int FirstRowOnPage;

			// Token: 0x040008F5 RID: 2293
			public int LogicalRow;
		}

		// Token: 0x0200019E RID: 414
		private class FieldLayoutNestingLevelKey
		{
			// Token: 0x060016F5 RID: 5877 RVA: 0x0006591B File Offset: 0x00063B1B
			internal FieldLayoutNestingLevelKey(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, int nestingLevel)
			{
				this._fieldLayout = fieldLayout;
				this._nestingLevel = nestingLevel;
			}

			// Token: 0x060016F6 RID: 5878 RVA: 0x00065934 File Offset: 0x00063B34
			public override bool Equals(object obj)
			{
				global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.FieldLayoutNestingLevelKey fieldLayoutNestingLevelKey = obj as global::Infragistics.Windows.DataPresenter.TabularReportViewPanel.FieldLayoutNestingLevelKey;
				return fieldLayoutNestingLevelKey != null && fieldLayoutNestingLevelKey._nestingLevel == this._nestingLevel && fieldLayoutNestingLevelKey._fieldLayout == this._fieldLayout;
			}

			// Token: 0x060016F7 RID: 5879 RVA: 0x0006596B File Offset: 0x00063B6B
			public override int GetHashCode()
			{
				return this._fieldLayout.GetHashCode() / 10 + this._nestingLevel.GetHashCode() / 10;
			}

			// Token: 0x060016F8 RID: 5880 RVA: 0x0006598A File Offset: 0x00063B8A
			internal bool IsSameKey(global::Infragistics.Windows.DataPresenter.FieldLayout fl, int nestingDepth)
			{
				return nestingDepth == this._nestingLevel && fl == this._fieldLayout;
			}

			// Token: 0x040008F6 RID: 2294
			private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

			// Token: 0x040008F7 RID: 2295
			private int _nestingLevel;
		}
	}
}
