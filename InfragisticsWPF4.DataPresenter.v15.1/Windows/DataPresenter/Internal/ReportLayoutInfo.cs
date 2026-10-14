using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter.Internal
{
	// Token: 0x02000302 RID: 770
	internal class ReportLayoutInfo
	{
		// Token: 0x06002532 RID: 9522 RVA: 0x000A4F78 File Offset: 0x000A3178
		internal ReportLayoutInfo(double offsetWithinPanel, double panelExtent, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			this._offsetWithinPanel = offsetWithinPanel;
			this._allFields = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo>();
			global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache templateDataRecordCache = fieldLayout.TemplateDataRecordCache;
			global::Infragistics.Windows.DataPresenter.DataPresenterReportControl dataPresenterReportControl = fieldLayout.DataPresenter as global::Infragistics.Windows.DataPresenter.DataPresenterReportControl;
			if (dataPresenterReportControl == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.ReportViewBase reportViewBase = dataPresenterReportControl.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.ReportViewBase;
			if (reportViewBase == null)
			{
				return;
			}
			this._fieldsTooLargeToFit = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo>();
			global::Infragistics.Windows.DataPresenter.CellPageSpanStrategy cellPageSpanStrategy = reportViewBase.CellPageSpanStrategy;
			bool flag = reportViewBase.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical;
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager cellLayoutManager = fieldLayout.CellLayoutManager;
			cellLayoutManager.VerifyLayout();
			cellLayoutManager.CalculatePreferredSize();
			global::System.Collections.Generic.List<global::System.Windows.Controls.Control> cellElementsInReportOrder = templateDataRecordCache.CellElementsInReportOrder;
			double num = global::System.Math.Max(panelExtent - offsetWithinPanel, 0.0);
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo>();
			this._pages = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageInfo>();
			this._pages.Add(new global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageInfo(num));
			foreach (global::System.Windows.Controls.Control ctrl in cellElementsInReportOrder)
			{
				global::Infragistics.Windows.DataPresenter.Field fieldFromControl = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldFromControl(ctrl);
				if (fieldFromControl != null)
				{
					global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition = fieldFromControl.GridPosition;
					int num2;
					int num3;
					if (flag)
					{
						num2 = gridPosition.Column;
						num3 = gridPosition.ColumnSpan;
					}
					else
					{
						num2 = gridPosition.Row;
						num3 = gridPosition.RowSpan;
					}
					int endSlot = num2 + num3 - 1;
					double preferredExtent = cellLayoutManager.GetPreferredExtent(num2, num3, flag);
					global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo pageFieldInfo = new global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo(preferredExtent, num2, endSlot, fieldFromControl);
					if (preferredExtent > panelExtent || (preferredExtent > num && num2 == 0))
					{
						this._fieldsTooLargeToFit.Add(fieldFromControl, pageFieldInfo);
					}
					list.Add(pageFieldInfo);
				}
			}
			if (this._fieldsTooLargeToFit.Count > 0)
			{
				if (list.Count == 0)
				{
					foreach (global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo item in this._fieldsTooLargeToFit.Values)
					{
						list.Add(item);
					}
					this._fieldsTooLargeToFit.Clear();
				}
				else
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo>(this._fieldsTooLargeToFit.Values);
					foreach (global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo pageFieldInfo2 in list2)
					{
						bool flag2 = false;
						int i = 0;
						int count = list.Count;
						while (i < count)
						{
							global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo pageFieldInfo3 = list[i];
							if (pageFieldInfo3 != pageFieldInfo2)
							{
								if (pageFieldInfo3.BeginSlot > pageFieldInfo2.BeginSlot)
								{
									break;
								}
								if (pageFieldInfo3.BeginSlot == pageFieldInfo2.BeginSlot)
								{
									flag2 = true;
									break;
								}
							}
							i++;
						}
						if (!flag2)
						{
							this._fieldsTooLargeToFit.Remove(pageFieldInfo2.Field);
						}
						else
						{
							list.Remove(pageFieldInfo2);
						}
					}
				}
			}
			int num4 = 0;
			int num5 = 0;
			int j = 0;
			int count2 = list.Count;
			while (j < count2)
			{
				global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo pageFieldInfo4 = list[j];
				global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageInfo pageInfo = this._pages[num4];
				if (pageInfo.FieldCount < 1)
				{
					pageInfo.AddFieldInfo(pageFieldInfo4);
					num5 = j;
				}
				else if (pageFieldInfo4.BeginSlot >= pageInfo.FirstSlot && pageFieldInfo4.EndSlot <= pageInfo.LastSlot)
				{
					pageInfo.AddFieldInfo(pageFieldInfo4);
				}
				else
				{
					double num6 = 0.0;
					if (pageFieldInfo4.BeginSlot > pageInfo.FirstSlot)
					{
						num6 = cellLayoutManager.GetPreferredExtent(pageInfo.FirstSlot, pageFieldInfo4.BeginSlot - pageInfo.FirstSlot, flag);
					}
					if (num6 + pageFieldInfo4.Extent > pageInfo.OverallPanelExent)
					{
						int beginSlot = pageFieldInfo4.BeginSlot;
						global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageInfo pageInfo2;
						if (num4 < this._pages.Count)
						{
							pageInfo2 = new global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageInfo(panelExtent);
							this._pages.Add(pageInfo2);
						}
						else
						{
							pageInfo2 = this._pages[num4 + 1];
						}
						bool flag3 = false;
						for (int k = num5; k < j; k++)
						{
							global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo pageFieldInfo5 = list[k];
							if (pageFieldInfo5.BeginSlot >= pageFieldInfo4.BeginSlot)
							{
								pageInfo.RemoveFieldInfo(pageFieldInfo5);
								pageInfo2.AddFieldInfo(pageFieldInfo5);
								flag3 = true;
							}
						}
						pageInfo2.AddFieldInfo(pageFieldInfo4);
						num5 = j + 1;
						if (flag3)
						{
							pageInfo.RefreshFirstAndLastSlots();
						}
						num4++;
					}
					else
					{
						pageInfo.AddFieldInfo(pageFieldInfo4);
					}
				}
				j++;
			}
			this._overallExtent = 0.0;
			int l = 0;
			int count3 = this._pages.Count;
			while (l < count3)
			{
				bool flag4 = l == count3 - 1;
				this._pages[l].InitializeFieldOffsets(cellLayoutManager, flag, this._fieldsTooLargeToFit.Values, this._allFields, cellPageSpanStrategy == global::Infragistics.Windows.DataPresenter.CellPageSpanStrategy.NextPageFillWithPreviousCell && !flag4);
				if (flag4)
				{
					this._overallExtent += this._pages[l].ExtentUsed;
				}
				else
				{
					this._overallExtent += this._pages[l].OverallPanelExent;
				}
				l++;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002533 RID: 9523 RVA: 0x000A5484 File Offset: 0x000A3684
		internal double OffsetWithinPanel
		{
			get
			{
				return this._offsetWithinPanel;
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x000A548C File Offset: 0x000A368C
		internal double OverallExtent
		{
			get
			{
				return this._overallExtent;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002535 RID: 9525 RVA: 0x000A5494 File Offset: 0x000A3694
		internal int PageCount
		{
			get
			{
				return this._pages.Count;
			}
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x000A54A4 File Offset: 0x000A36A4
		internal double GetExtent(global::Infragistics.Windows.DataPresenter.Field field, int beginSlot, int span)
		{
			int num = beginSlot + span - 1;
			double num2 = 0.0;
			bool flag = false;
			int i = 0;
			int count = this._pages.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageInfo pageInfo = this._pages[i];
				if (pageInfo.LastSlot >= beginSlot)
				{
					bool flag2 = pageInfo.GetPageFieldInfo(field) != null;
					if (flag2)
					{
						flag = true;
					}
					if (pageInfo.FirstSlot <= num)
					{
						if (flag2)
						{
							double num3 = pageInfo.GetExtent(beginSlot, num);
							if (beginSlot == num && pageInfo.FirstSlot == pageInfo.LastSlot)
							{
								num3 = global::System.Math.Min(num3, pageInfo.OverallPanelExent);
							}
							num2 += num3;
						}
						else if (flag)
						{
							num2 += pageInfo.OverallPanelExent;
						}
					}
				}
				i++;
			}
			return num2;
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000A5564 File Offset: 0x000A3764
		internal double GetOffset(global::Infragistics.Windows.DataPresenter.Field field, int slot)
		{
			double num = 0.0;
			int i = 0;
			int count = this._pages.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageInfo pageInfo = this._pages[i];
				bool flag = pageInfo.GetPageFieldInfo(field) != null;
				if (slot > pageInfo.LastSlot || !flag)
				{
					num += pageInfo.OverallPanelExent;
					i++;
				}
				else
				{
					if (slot < pageInfo.FirstSlot)
					{
						return num;
					}
					return num + pageInfo.GetOffset(slot);
				}
			}
			return 0.0;
		}

		// Token: 0x04001281 RID: 4737
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageInfo> _pages;

		// Token: 0x04001282 RID: 4738
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo> _fieldsTooLargeToFit;

		// Token: 0x04001283 RID: 4739
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo> _allFields;

		// Token: 0x04001284 RID: 4740
		private double _overallExtent;

		// Token: 0x04001285 RID: 4741
		private double _offsetWithinPanel;

		// Token: 0x02000303 RID: 771
		internal class PageInfo
		{
			// Token: 0x06002538 RID: 9528 RVA: 0x000A55E5 File Offset: 0x000A37E5
			internal PageInfo(double overallPanelExtent)
			{
				this._overallPanelExtent = overallPanelExtent;
				this._fieldInfos = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo>();
				this._firstSlot = -1;
				this._lastSlot = -1;
			}

			// Token: 0x06002539 RID: 9529 RVA: 0x000A560D File Offset: 0x000A380D
			internal void AddFieldInfo(global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo pfi)
			{
				this._fieldInfos.Add(pfi);
				this.UpdateFirstAndLastSlots(pfi);
			}

			// Token: 0x0600253A RID: 9530 RVA: 0x000A5624 File Offset: 0x000A3824
			internal global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo GetPageFieldInfo(global::Infragistics.Windows.DataPresenter.Field fld)
			{
				global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo result;
				this._finalFieldInfos.TryGetValue(fld, out result);
				return result;
			}

			// Token: 0x0600253B RID: 9531 RVA: 0x000A5644 File Offset: 0x000A3844
			internal double GetExtent(int beginSlot, int endSlot)
			{
				int num = global::System.Math.Max(0, beginSlot - this._firstSlot);
				int num2 = global::System.Math.Min(this._slotExtents.Length - 1, endSlot - this._firstSlot);
				double num3 = 0.0;
				for (int i = num; i <= num2; i++)
				{
					num3 += this._slotExtents[i];
				}
				return num3;
			}

			// Token: 0x0600253C RID: 9532 RVA: 0x000A569C File Offset: 0x000A389C
			internal double GetOffset(int slot)
			{
				int num = global::System.Math.Min(this._slotExtents.Length - 1, slot - this._firstSlot);
				double num2 = 0.0;
				for (int i = 0; i < num; i++)
				{
					num2 += this._slotExtents[i];
				}
				return num2;
			}

			// Token: 0x0600253D RID: 9533 RVA: 0x000A56E4 File Offset: 0x000A38E4
			internal void InitializeFieldOffsets(global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager lm, bool isVertical, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo> fieldsTooLargeToFit, global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo> allFields, bool extendEndingFieldsToFill)
			{
				if (this._finalFieldInfos != null)
				{
					throw new global::System.InvalidOperationException("PageInfo is already initialized");
				}
				this._finalFieldInfos = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo>(this._fieldInfos.Count);
				int num = -1;
				this._extentUsed = 0.0;
				foreach (global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo pageFieldInfo in this._fieldInfos)
				{
					int beginSlot = pageFieldInfo.BeginSlot;
					if (beginSlot != num)
					{
						num = beginSlot;
						double num2;
						if (beginSlot > this._firstSlot)
						{
							num2 = lm.GetPreferredExtent(this._firstSlot, beginSlot - this._firstSlot, isVertical);
						}
						else
						{
							num2 = 0.0;
						}
						if (extendEndingFieldsToFill && pageFieldInfo.EndSlot == this._lastSlot)
						{
							pageFieldInfo.InitializeExtent(this._overallPanelExtent - num2);
						}
						pageFieldInfo.InitializeOffset(num2);
						this._extentUsed = global::System.Math.Max(this._extentUsed, num2 + pageFieldInfo.Extent);
					}
					this._finalFieldInfos.Add(pageFieldInfo.Field, pageFieldInfo);
					allFields.Add(pageFieldInfo.Field, pageFieldInfo);
				}
				this._slotExtents = new double[this._lastSlot - this._firstSlot + 1];
				double num3 = 0.0;
				int i = 0;
				int num4 = this._slotExtents.Length;
				while (i < num4)
				{
					double preferredExtent = lm.GetPreferredExtent(this._firstSlot + i, 1, isVertical);
					this._slotExtents[i] = preferredExtent;
					num3 += preferredExtent;
					i++;
				}
				if (extendEndingFieldsToFill)
				{
					this._slotExtents[this._slotExtents.Length - 1] += global::System.Math.Max(this._overallPanelExtent - num3, 0.0);
				}
				foreach (global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo pageFieldInfo2 in fieldsTooLargeToFit)
				{
					int beginSlot2 = pageFieldInfo2.BeginSlot;
					double num2;
					if (beginSlot2 == this._firstSlot)
					{
						num2 = 0.0;
					}
					else if (beginSlot2 > this._firstSlot)
					{
						if (beginSlot2 > this._lastSlot)
						{
							continue;
						}
						num2 = lm.GetPreferredExtent(this._firstSlot, beginSlot2 - this._firstSlot, isVertical);
					}
					else
					{
						if (pageFieldInfo2.EndSlot < this._firstSlot)
						{
							continue;
						}
						num2 = -lm.GetPreferredExtent(beginSlot2, this._firstSlot - beginSlot2, isVertical);
					}
					global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo pageFieldInfo3 = new global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo(pageFieldInfo2.Extent, pageFieldInfo2.BeginSlot, pageFieldInfo2.EndSlot, pageFieldInfo2.Field);
					pageFieldInfo3.InitializeOffset(num2);
					this._finalFieldInfos.Add(pageFieldInfo2.Field, pageFieldInfo3);
					this._fieldInfos.Add(pageFieldInfo3);
					this._extentUsed = global::System.Math.Max(this._extentUsed, num2 + pageFieldInfo3.Extent);
				}
				this._fieldInfos = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo>(this._fieldInfos);
			}

			// Token: 0x0600253E RID: 9534 RVA: 0x000A59D8 File Offset: 0x000A3BD8
			internal void RemoveFieldInfo(global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo pfi)
			{
				this._fieldInfos.Remove(pfi);
			}

			// Token: 0x0600253F RID: 9535 RVA: 0x000A59E8 File Offset: 0x000A3BE8
			internal void RefreshFirstAndLastSlots()
			{
				this._firstSlot = -1;
				this._lastSlot = -1;
				int count = this._fieldInfos.Count;
				for (int i = 0; i < count; i++)
				{
					this.UpdateFirstAndLastSlots(this._fieldInfos[i]);
				}
			}

			// Token: 0x06002540 RID: 9536 RVA: 0x000A5A2D File Offset: 0x000A3C2D
			private void UpdateFirstAndLastSlots(global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo pfi)
			{
				if (this._firstSlot < 0 || this._firstSlot > pfi.BeginSlot)
				{
					this._firstSlot = pfi.BeginSlot;
				}
				if (pfi.EndSlot > this._lastSlot)
				{
					this._lastSlot = pfi.EndSlot;
				}
			}

			// Token: 0x17000B0A RID: 2826
			// (get) Token: 0x06002541 RID: 9537 RVA: 0x000A5A6C File Offset: 0x000A3C6C
			internal double ExtentUsed
			{
				get
				{
					return this._extentUsed;
				}
			}

			// Token: 0x17000B0B RID: 2827
			// (get) Token: 0x06002542 RID: 9538 RVA: 0x000A5A74 File Offset: 0x000A3C74
			internal int FieldCount
			{
				get
				{
					return this._fieldInfos.Count;
				}
			}

			// Token: 0x17000B0C RID: 2828
			// (get) Token: 0x06002543 RID: 9539 RVA: 0x000A5A81 File Offset: 0x000A3C81
			internal int FirstSlot
			{
				get
				{
					return this._firstSlot;
				}
			}

			// Token: 0x17000B0D RID: 2829
			// (get) Token: 0x06002544 RID: 9540 RVA: 0x000A5A89 File Offset: 0x000A3C89
			internal int LastSlot
			{
				get
				{
					return this._lastSlot;
				}
			}

			// Token: 0x17000B0E RID: 2830
			// (get) Token: 0x06002545 RID: 9541 RVA: 0x000A5A91 File Offset: 0x000A3C91
			internal double OverallPanelExent
			{
				get
				{
					return this._overallPanelExtent;
				}
			}

			// Token: 0x17000B0F RID: 2831
			// (get) Token: 0x06002546 RID: 9542 RVA: 0x000A5A99 File Offset: 0x000A3C99
			internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo> FieldInfos
			{
				get
				{
					return this._fieldInfos;
				}
			}

			// Token: 0x04001286 RID: 4742
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo> _finalFieldInfos;

			// Token: 0x04001287 RID: 4743
			private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo> _fieldInfos;

			// Token: 0x04001288 RID: 4744
			private double _overallPanelExtent;

			// Token: 0x04001289 RID: 4745
			private int _firstSlot;

			// Token: 0x0400128A RID: 4746
			private int _lastSlot;

			// Token: 0x0400128B RID: 4747
			private double _extentUsed;

			// Token: 0x0400128C RID: 4748
			private double[] _slotExtents;
		}

		// Token: 0x02000304 RID: 772
		internal class PageFieldInfo
		{
			// Token: 0x06002547 RID: 9543 RVA: 0x000A5AA1 File Offset: 0x000A3CA1
			internal PageFieldInfo(double extent, int beginSlot, int endSlot, global::Infragistics.Windows.DataPresenter.Field field)
			{
				this._extent = extent;
				this._beginSlot = beginSlot;
				this._endSlot = endSlot;
				this._field = field;
			}

			// Token: 0x06002548 RID: 9544 RVA: 0x000A5AD5 File Offset: 0x000A3CD5
			internal void InitializeOffset(double offset)
			{
				if (!double.IsNaN(this._offset))
				{
					throw new global::System.InvalidOperationException();
				}
				this._offset = offset;
			}

			// Token: 0x06002549 RID: 9545 RVA: 0x000A5AF1 File Offset: 0x000A3CF1
			internal void InitializeExtent(double extent)
			{
				if (!double.IsNaN(this._offset))
				{
					throw new global::System.InvalidOperationException();
				}
				this._extent = extent;
			}

			// Token: 0x17000B10 RID: 2832
			// (get) Token: 0x0600254A RID: 9546 RVA: 0x000A5B0D File Offset: 0x000A3D0D
			internal int BeginSlot
			{
				get
				{
					return this._beginSlot;
				}
			}

			// Token: 0x17000B11 RID: 2833
			// (get) Token: 0x0600254B RID: 9547 RVA: 0x000A5B15 File Offset: 0x000A3D15
			internal int EndSlot
			{
				get
				{
					return this._endSlot;
				}
			}

			// Token: 0x17000B12 RID: 2834
			// (get) Token: 0x0600254C RID: 9548 RVA: 0x000A5B1D File Offset: 0x000A3D1D
			internal double Extent
			{
				get
				{
					return this._extent;
				}
			}

			// Token: 0x17000B13 RID: 2835
			// (get) Token: 0x0600254D RID: 9549 RVA: 0x000A5B25 File Offset: 0x000A3D25
			internal global::Infragistics.Windows.DataPresenter.Field Field
			{
				get
				{
					return this._field;
				}
			}

			// Token: 0x17000B14 RID: 2836
			// (get) Token: 0x0600254E RID: 9550 RVA: 0x000A5B2D File Offset: 0x000A3D2D
			internal double Offset
			{
				get
				{
					return this._offset;
				}
			}

			// Token: 0x0400128D RID: 4749
			private double _extent;

			// Token: 0x0400128E RID: 4750
			private double _offset = double.NaN;

			// Token: 0x0400128F RID: 4751
			private global::Infragistics.Windows.DataPresenter.Field _field;

			// Token: 0x04001290 RID: 4752
			private int _beginSlot;

			// Token: 0x04001291 RID: 4753
			private int _endSlot;
		}
	}
}
