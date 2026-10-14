using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter.Internal
{
	// Token: 0x020002C3 RID: 707
	internal class ReportLayoutInfo
	{
		// Token: 0x060021A0 RID: 8608 RVA: 0x00091F2C File Offset: 0x0009012C
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

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x060021A1 RID: 8609 RVA: 0x00092438 File Offset: 0x00090638
		internal double OffsetWithinPanel
		{
			get
			{
				return this._offsetWithinPanel;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x00092440 File Offset: 0x00090640
		internal double OverallExtent
		{
			get
			{
				return this._overallExtent;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x00092448 File Offset: 0x00090648
		internal int PageCount
		{
			get
			{
				return this._pages.Count;
			}
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00092458 File Offset: 0x00090658
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

		// Token: 0x060021A5 RID: 8613 RVA: 0x00092518 File Offset: 0x00090718
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

		// Token: 0x0400106E RID: 4206
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageInfo> _pages;

		// Token: 0x0400106F RID: 4207
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo> _fieldsTooLargeToFit;

		// Token: 0x04001070 RID: 4208
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo> _allFields;

		// Token: 0x04001071 RID: 4209
		private double _overallExtent;

		// Token: 0x04001072 RID: 4210
		private double _offsetWithinPanel;

		// Token: 0x020002C4 RID: 708
		internal class PageInfo
		{
			// Token: 0x060021A6 RID: 8614 RVA: 0x00092599 File Offset: 0x00090799
			internal PageInfo(double overallPanelExtent)
			{
				this._overallPanelExtent = overallPanelExtent;
				this._fieldInfos = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo>();
				this._firstSlot = -1;
				this._lastSlot = -1;
			}

			// Token: 0x060021A7 RID: 8615 RVA: 0x000925C1 File Offset: 0x000907C1
			internal void AddFieldInfo(global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo pfi)
			{
				this._fieldInfos.Add(pfi);
				this.UpdateFirstAndLastSlots(pfi);
			}

			// Token: 0x060021A8 RID: 8616 RVA: 0x000925D8 File Offset: 0x000907D8
			internal global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo GetPageFieldInfo(global::Infragistics.Windows.DataPresenter.Field fld)
			{
				global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo result;
				this._finalFieldInfos.TryGetValue(fld, out result);
				return result;
			}

			// Token: 0x060021A9 RID: 8617 RVA: 0x000925F8 File Offset: 0x000907F8
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

			// Token: 0x060021AA RID: 8618 RVA: 0x00092650 File Offset: 0x00090850
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

			// Token: 0x060021AB RID: 8619 RVA: 0x00092698 File Offset: 0x00090898
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

			// Token: 0x060021AC RID: 8620 RVA: 0x0009298C File Offset: 0x00090B8C
			internal void RemoveFieldInfo(global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo pfi)
			{
				this._fieldInfos.Remove(pfi);
			}

			// Token: 0x060021AD RID: 8621 RVA: 0x0009299C File Offset: 0x00090B9C
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

			// Token: 0x060021AE RID: 8622 RVA: 0x000929E1 File Offset: 0x00090BE1
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

			// Token: 0x170009DF RID: 2527
			// (get) Token: 0x060021AF RID: 8623 RVA: 0x00092A20 File Offset: 0x00090C20
			internal double ExtentUsed
			{
				get
				{
					return this._extentUsed;
				}
			}

			// Token: 0x170009E0 RID: 2528
			// (get) Token: 0x060021B0 RID: 8624 RVA: 0x00092A28 File Offset: 0x00090C28
			internal int FieldCount
			{
				get
				{
					return this._fieldInfos.Count;
				}
			}

			// Token: 0x170009E1 RID: 2529
			// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00092A35 File Offset: 0x00090C35
			internal int FirstSlot
			{
				get
				{
					return this._firstSlot;
				}
			}

			// Token: 0x170009E2 RID: 2530
			// (get) Token: 0x060021B2 RID: 8626 RVA: 0x00092A3D File Offset: 0x00090C3D
			internal int LastSlot
			{
				get
				{
					return this._lastSlot;
				}
			}

			// Token: 0x170009E3 RID: 2531
			// (get) Token: 0x060021B3 RID: 8627 RVA: 0x00092A45 File Offset: 0x00090C45
			internal double OverallPanelExent
			{
				get
				{
					return this._overallPanelExtent;
				}
			}

			// Token: 0x170009E4 RID: 2532
			// (get) Token: 0x060021B4 RID: 8628 RVA: 0x00092A4D File Offset: 0x00090C4D
			internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo> FieldInfos
			{
				get
				{
					return this._fieldInfos;
				}
			}

			// Token: 0x04001073 RID: 4211
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo> _finalFieldInfos;

			// Token: 0x04001074 RID: 4212
			private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo.PageFieldInfo> _fieldInfos;

			// Token: 0x04001075 RID: 4213
			private double _overallPanelExtent;

			// Token: 0x04001076 RID: 4214
			private int _firstSlot;

			// Token: 0x04001077 RID: 4215
			private int _lastSlot;

			// Token: 0x04001078 RID: 4216
			private double _extentUsed;

			// Token: 0x04001079 RID: 4217
			private double[] _slotExtents;
		}

		// Token: 0x020002C5 RID: 709
		internal class PageFieldInfo
		{
			// Token: 0x060021B5 RID: 8629 RVA: 0x00092A55 File Offset: 0x00090C55
			internal PageFieldInfo(double extent, int beginSlot, int endSlot, global::Infragistics.Windows.DataPresenter.Field field)
			{
				this._extent = extent;
				this._beginSlot = beginSlot;
				this._endSlot = endSlot;
				this._field = field;
			}

			// Token: 0x060021B6 RID: 8630 RVA: 0x00092A89 File Offset: 0x00090C89
			internal void InitializeOffset(double offset)
			{
				if (!double.IsNaN(this._offset))
				{
					throw new global::System.InvalidOperationException();
				}
				this._offset = offset;
			}

			// Token: 0x060021B7 RID: 8631 RVA: 0x00092AA5 File Offset: 0x00090CA5
			internal void InitializeExtent(double extent)
			{
				if (!double.IsNaN(this._offset))
				{
					throw new global::System.InvalidOperationException();
				}
				this._extent = extent;
			}

			// Token: 0x170009E5 RID: 2533
			// (get) Token: 0x060021B8 RID: 8632 RVA: 0x00092AC1 File Offset: 0x00090CC1
			internal int BeginSlot
			{
				get
				{
					return this._beginSlot;
				}
			}

			// Token: 0x170009E6 RID: 2534
			// (get) Token: 0x060021B9 RID: 8633 RVA: 0x00092AC9 File Offset: 0x00090CC9
			internal int EndSlot
			{
				get
				{
					return this._endSlot;
				}
			}

			// Token: 0x170009E7 RID: 2535
			// (get) Token: 0x060021BA RID: 8634 RVA: 0x00092AD1 File Offset: 0x00090CD1
			internal double Extent
			{
				get
				{
					return this._extent;
				}
			}

			// Token: 0x170009E8 RID: 2536
			// (get) Token: 0x060021BB RID: 8635 RVA: 0x00092AD9 File Offset: 0x00090CD9
			internal global::Infragistics.Windows.DataPresenter.Field Field
			{
				get
				{
					return this._field;
				}
			}

			// Token: 0x170009E9 RID: 2537
			// (get) Token: 0x060021BC RID: 8636 RVA: 0x00092AE1 File Offset: 0x00090CE1
			internal double Offset
			{
				get
				{
					return this._offset;
				}
			}

			// Token: 0x0400107A RID: 4218
			private double _extent;

			// Token: 0x0400107B RID: 4219
			private double _offset = double.NaN;

			// Token: 0x0400107C RID: 4220
			private global::Infragistics.Windows.DataPresenter.Field _field;

			// Token: 0x0400107D RID: 4221
			private int _beginSlot;

			// Token: 0x0400107E RID: 4222
			private int _endSlot;
		}
	}
}
