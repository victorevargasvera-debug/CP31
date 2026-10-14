using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Collections;
using Infragistics.Controls.Layouts.Primitives;
using Infragistics.Windows.DataPresenter.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000030 RID: 48
	internal class AutoSizeFieldHelper
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x00007A40 File Offset: 0x00005C40
		internal AutoSizeFieldHelper(global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings> fields, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(fields);
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(fieldLayout);
			this._fieldLayout = fieldLayout;
			this._fieldLayout.TemplateDataRecordCache.Verify();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo>();
			this._fieldInfosByScope = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo>>();
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings> keyValuePair in fields)
			{
				global::Infragistics.Windows.DataPresenter.Field key = keyValuePair.Key;
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings value = keyValuePair.Value;
				if (key.Index >= 0)
				{
					global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo(key);
					fieldInfo.Options = value.Options;
					if (key.TemplateCellIndex < 0)
					{
						fieldInfo.Options = global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None;
					}
					list.Add(fieldInfo);
					this._options |= fieldInfo.Options;
					global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope scope = value.Scope;
					global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo> list2;
					if (!this._fieldInfosByScope.TryGetValue(scope, out list2))
					{
						list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo>();
						this._fieldInfosByScope[scope] = list2;
					}
					list2.Add(fieldInfo);
				}
			}
			this._fieldInfos = list.ToArray();
			this._dataCellValues = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldValue, double>();
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00007B74 File Offset: 0x00005D74
		internal AutoSizeFieldHelper(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> fields, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout) : this(fields, fieldLayout, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.All)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00007B7F File Offset: 0x00005D7F
		internal AutoSizeFieldHelper(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> fields, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions allowedOptions) : this(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetFieldOptions(fields, allowedOptions), fieldLayout)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00007B8F File Offset: 0x00005D8F
		internal AutoSizeFieldHelper(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions options, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope scope) : this(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetFieldOption(field, options, scope), field.Owner)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00007BA5 File Offset: 0x00005DA5
		internal static bool GetIsAutoSizeElement(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.IsAutoSizeElementProperty);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00007BB7 File Offset: 0x00005DB7
		private static void AddProcessedField(global::Infragistics.Windows.DataPresenter.Field field, ref global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList newFieldList)
		{
			if (newFieldList == null)
			{
				newFieldList = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList(field.Owner.Fields.Count);
			}
			newFieldList.Add(field);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00007BDC File Offset: 0x00005DDC
		public bool Calculate(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, int recordManagerDepth, global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags flags, global::Infragistics.Windows.DataPresenter.RecordsInViewHelper recordsInViewHelper)
		{
			if (this._options == global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
			if (dataPresenter == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordEnumeratorBase outOfViewRecords = null;
			if ((this._options & ~global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Label) != global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None)
			{
				outOfViewRecords = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordCollectionEnumerator(records ?? dataPresenter.Records, global::System.Math.Max(recordManagerDepth, 0));
			}
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordFieldList recordFieldList = null;
			return this.Calculate(outOfViewRecords, flags, ref recordFieldList, false, recordsInViewHelper);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00007C38 File Offset: 0x00005E38
		public bool Calculate(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> outOfViewRecords, bool recursive, int recordManagerDepth, global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags flags)
		{
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordFieldList recordFieldList = null;
			return this.Calculate((outOfViewRecords == null) ? null : new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordEnumerator(outOfViewRecords, recordManagerDepth, recursive), flags, ref recordFieldList, false, null);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00007C61 File Offset: 0x00005E61
		public bool Calculate(global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags flags, ref global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordFieldList recordFieldList, bool trackRecords, global::Infragistics.Windows.DataPresenter.RecordsInViewHelper recordsInViewHelper)
		{
			return this.Calculate(null, flags, ref recordFieldList, trackRecords, recordsInViewHelper);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00007C70 File Offset: 0x00005E70
		private bool Calculate(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordEnumeratorBase outOfViewRecords, global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags flags, ref global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordFieldList recordFieldList, bool trackRecords, global::Infragistics.Windows.DataPresenter.RecordsInViewHelper recordsInViewHelper)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
			if (dataPresenter == null)
			{
				return false;
			}
			if (this._options == global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None)
			{
				return false;
			}
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			bool useCellPresenters = this._fieldLayout.UseCellPresenters;
			global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache templateDataRecordCache = this._fieldLayout.TemplateDataRecordCache;
			templateDataRecordCache.Verify();
			if (this.IncludesOption(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Label))
			{
				for (int i = 0; i < this._fieldInfos.Length; i++)
				{
					global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo = this._fieldInfos[i];
					if (global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.IncludesOption(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Label, fieldInfo.Options))
					{
						global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetLabelPresenter(fieldInfo.Field, templateDataRecordCache);
						if (labelPresenter != null)
						{
							labelPresenter.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
							global::System.Windows.Size desiredSize = labelPresenter.DesiredSize;
							fieldInfo.AddLabelExtent(isHorizontal ? desiredSize.Height : desiredSize.Width);
						}
					}
				}
			}
			if (this.IncludesOption(~global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Label))
			{
				global::Infragistics.Windows.DataPresenter.TemplateDataRecord templateDataRecord = this._fieldLayout.TemplateDataRecord as global::Infragistics.Windows.DataPresenter.TemplateDataRecord;
				templateDataRecord.VerifyCachedCellElements();
				bool flag = (flags & global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags.SkipEditCell) != global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags.None;
				bool flag2 = (flags & global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags.RecalculateRecords) != global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags.None;
				bool flag3 = (flags & global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags.UseTemplateRecordAsFallback) != global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags.None;
				global::Infragistics.Windows.DataPresenter.Cell cell = flag ? dataPresenter.ActiveCell : null;
				global::Infragistics.Windows.DataPresenter.Record record = (cell != null && cell.IsInEditMode) ? cell.Record : null;
				global::Infragistics.Windows.DataPresenter.Field field = (record != null) ? cell.Field : null;
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordFieldList recordFieldList2 = null;
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordFieldList recordFieldList3 = recordFieldList;
				if (trackRecords)
				{
					recordFieldList2 = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordFieldList();
					recordFieldList = recordFieldList2;
				}
				global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter summaryResultsPresenter = null;
				global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter>();
				global::System.Collections.Generic.HashSet<global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel> hashSet = new global::System.Collections.Generic.HashSet<global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel>();
				bool flag4 = this.IncludesOption(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Summaries);
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo>> keyValuePair in this._fieldInfosByScope)
				{
					global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator2;
					bool flag5;
					bool flag6;
					bool flag7;
					switch (keyValuePair.Key)
					{
					default:
					{
						global::Infragistics.Windows.DataPresenter.Record[] array = (recordsInViewHelper != null) ? recordsInViewHelper.GetRecords() : dataPresenter.GetRecordsInView(true, true);
						enumerator2 = ((global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>)array).GetEnumerator();
						flag5 = true;
						flag6 = flag3;
						flag7 = false;
						break;
					}
					case global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.ViewableRecords:
					case global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.AllRecords:
					{
						flag5 = false;
						flag6 = true;
						flag7 = true;
						bool viewableOnly = keyValuePair.Key == global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.ViewableRecords;
						enumerator2 = outOfViewRecords;
						if (enumerator2 == null)
						{
							continue;
						}
						outOfViewRecords.SetViewableOnly(viewableOnly);
						outOfViewRecords.Reset();
						break;
					}
					}
					if (flag2)
					{
						foreach (global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo2 in keyValuePair.Value)
						{
							fieldInfo2.Field.AutoSizeVersion++;
						}
					}
					int num = 0;
					while (enumerator2.MoveNext())
					{
						global::Infragistics.Windows.DataPresenter.Record record2 = enumerator2.Current;
						if (record2.FieldLayout == this._fieldLayout)
						{
							global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = record2 as global::Infragistics.Windows.DataPresenter.GroupByRecord;
							if ((groupByRecord == null || (flag4 && global::Infragistics.Windows.DataPresenter.GroupByRecord.ShouldDisplaySummaries(groupByRecord))) && !(record2 is global::Infragistics.Windows.DataPresenter.HeaderRecord) && (!flag5 || recordsInViewHelper == null || recordFieldList3 != null || !(record2 is global::Infragistics.Windows.DataPresenter.DataRecord) || recordsInViewHelper.ShouldProcessInViewRecord(record2, keyValuePair.Value)))
							{
								global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord = record2 as global::Infragistics.Windows.DataPresenter.SummaryRecord;
								global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = null;
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record2 as global::Infragistics.Windows.DataPresenter.DataRecord;
								global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList fieldList = (recordFieldList3 != null) ? recordFieldList3[record2] : null;
								global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList fieldList2 = fieldList;
								if (flag7)
								{
									num = outOfViewRecords.RecordManagerVersion;
								}
								int j = 0;
								int count = keyValuePair.Value.Count;
								while (j < count)
								{
									global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo3 = keyValuePair.Value[j];
									if (record2 is global::Infragistics.Windows.DataPresenter.DataRecord)
									{
										if (record2 is global::Infragistics.Windows.DataPresenter.FilterRecord)
										{
											if (global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.IncludesOption(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.FilterCells, fieldInfo3.Options))
											{
												goto IL_3AF;
											}
										}
										else if (global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.IncludesOption(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.DataCells, fieldInfo3.Options))
										{
											goto IL_3AF;
										}
									}
									else if (!(record2 is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord))
									{
										if (summaryRecord != null)
										{
											if (global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.IncludesOption(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Summaries, fieldInfo3.Options))
											{
												goto IL_3AF;
											}
										}
										else if (groupByRecord != null && global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.IncludesOption(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Summaries, fieldInfo3.Options))
										{
											goto IL_3AF;
										}
									}
									IL_759:
									j++;
									continue;
									IL_3AF:
									global::Infragistics.Windows.DataPresenter.Field field2 = fieldInfo3.Field;
									if ((!flag2 && fieldList != null && fieldList.Contains(field2)) || (record2 == record && field2 == field))
									{
										goto IL_759;
									}
									if (flag5)
									{
										if (virtualizingDataRecordCellPanel == null)
										{
											virtualizingDataRecordCellPanel = global::Infragistics.Windows.DataPresenter.GridUtilities.GetCellPanel(global::Infragistics.Windows.DataPresenter.RecordPresenter.FromRecord(record2), false);
											if (virtualizingDataRecordCellPanel != null)
											{
												virtualizingDataRecordCellPanel.VerifyCellElements();
											}
										}
										if (virtualizingDataRecordCellPanel != null)
										{
											global::System.Windows.FrameworkElement cellElement = virtualizingDataRecordCellPanel.GetCellElement(field2, false);
											if (cellElement != null)
											{
												cellElement = global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetCellElement(cellElement, false);
												if (cellElement != null)
												{
													bool isPerformingAutoSizeMeasure = virtualizingDataRecordCellPanel.IsPerformingAutoSizeMeasure;
													virtualizingDataRecordCellPanel.IsPerformingAutoSizeMeasure = true;
													try
													{
														cellElement.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
													}
													finally
													{
														virtualizingDataRecordCellPanel.IsPerformingAutoSizeMeasure = isPerformingAutoSizeMeasure;
													}
													hashSet.Add(virtualizingDataRecordCellPanel);
													global::System.Windows.Size desiredSize2 = cellElement.DesiredSize;
													fieldInfo3.AddCellExtent(isHorizontal ? desiredSize2.Height : desiredSize2.Width);
													if (trackRecords)
													{
														global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.AddProcessedField(field2, ref fieldList2);
														goto IL_759;
													}
													goto IL_759;
												}
											}
										}
									}
									if (!flag6)
									{
										goto IL_759;
									}
									int num2 = field2.AutoSizeVersion;
									if (dataRecord != null)
									{
										if (flag7)
										{
											if (!(dataRecord is global::Infragistics.Windows.DataPresenter.FilterRecord))
											{
												num2 += num;
											}
											global::Infragistics.Windows.DataPresenter.Cell cell2 = dataRecord.Cells[field2];
											if (!flag2 && cell2.FieldAutoSizeVersion == num2)
											{
												goto IL_759;
											}
											cell2.FieldAutoSizeVersion = num2;
										}
										if (dataRecord is global::Infragistics.Windows.DataPresenter.FilterRecord)
										{
											global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter;
											if (!dictionary.TryGetValue(field2, out filterCellValuePresenter))
											{
												filterCellValuePresenter = new global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter();
												filterCellValuePresenter.SetValue(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.IsAutoSizeElementProperty, global::Infragistics.KnownBoxes.TrueBox);
												dictionary.Add(field2, filterCellValuePresenter);
												dataPresenter.InternalAddLogicalChild(filterCellValuePresenter);
												global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.InitializeCellElement(filterCellValuePresenter, field2, record2, false);
											}
											filterCellValuePresenter.DataContext = record2;
											filterCellValuePresenter.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
											filterCellValuePresenter.UpdateLayout();
											global::System.Windows.Size desiredSize3 = filterCellValuePresenter.DesiredSize;
											double extent = isHorizontal ? desiredSize3.Height : desiredSize3.Width;
											fieldInfo3.AddCellExtent(extent);
											if (trackRecords)
											{
												global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.AddProcessedField(field2, ref fieldList2);
												goto IL_759;
											}
											goto IL_759;
										}
										else if (dataRecord != null)
										{
											object cellValue = dataRecord.GetCellValue(field2, true);
											global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldValue key = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldValue(field2, cellValue);
											if (this._dataCellValues.ContainsKey(key))
											{
												if (trackRecords)
												{
													global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.AddProcessedField(field2, ref fieldList2);
													goto IL_759;
												}
												goto IL_759;
											}
											else
											{
												templateDataRecord.SetValue(field2, cellValue);
												global::Infragistics.Windows.DataPresenter.CellValuePresenter cellPresenter = global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetCellPresenter(field2, templateDataRecordCache);
												if (cellPresenter != null)
												{
													global::System.Windows.Size desiredSize4 = cellPresenter.DesiredSize;
													double num3 = isHorizontal ? desiredSize4.Height : desiredSize4.Width;
													fieldInfo3.AddCellExtent(num3);
													this._dataCellValues.Add(key, num3);
													if (trackRecords)
													{
														global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.AddProcessedField(field2, ref fieldList2);
														goto IL_759;
													}
													goto IL_759;
												}
											}
										}
									}
									else if (groupByRecord != null && summaryRecord == null)
									{
										summaryRecord = groupByRecord.CreateSummaryRecord();
									}
									if (summaryRecord == null)
									{
										goto IL_759;
									}
									global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> fixedSummaryResults = summaryRecord.GetFixedSummaryResults(field2, false);
									if (trackRecords)
									{
										global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.AddProcessedField(field2, ref fieldList2);
									}
									if (!flag2)
									{
										bool flag8 = false;
										foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in fixedSummaryResults)
										{
											if (summaryResult.FieldAutoSizeVersion != num2)
											{
												flag8 = true;
												summaryResult.FieldAutoSizeVersion = num2;
											}
										}
										if (!flag8)
										{
											goto IL_759;
										}
									}
									if (global::Infragistics.Windows.DataPresenter.GridUtilities.HasItems(fixedSummaryResults))
									{
										if (summaryResultsPresenter == null)
										{
											summaryResultsPresenter = new global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter();
											summaryResultsPresenter.SetValue(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.IsAutoSizeElementProperty, global::Infragistics.KnownBoxes.TrueBox);
											dataPresenter.InternalAddLogicalChild(summaryResultsPresenter);
										}
										summaryResultsPresenter.SummaryResults = fixedSummaryResults;
										summaryResultsPresenter.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
										summaryResultsPresenter.UpdateLayout();
										global::System.Windows.Size desiredSize5 = summaryResultsPresenter.DesiredSize;
										fieldInfo3.AddCellExtent(isHorizontal ? desiredSize5.Height : desiredSize5.Width);
										goto IL_759;
									}
									goto IL_759;
								}
								if (fieldList2 != null)
								{
									recordFieldList2[record2] = fieldList2;
								}
							}
						}
					}
				}
				if (summaryResultsPresenter != null)
				{
					dataPresenter.InternalRemoveLogicalChild(summaryResultsPresenter);
				}
				foreach (global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter2 in dictionary.Values)
				{
					filterCellValuePresenter2.DataContext = null;
					dataPresenter.InternalRemoveLogicalChild(filterCellValuePresenter2);
				}
				templateDataRecord.ClearAll();
				foreach (global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel2 in hashSet)
				{
					virtualizingDataRecordCellPanel2.InvalidateMeasure();
				}
			}
			bool flag9 = false;
			foreach (global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo4 in this._fieldInfos)
			{
				fieldInfo4.RoundExtents();
				if (!flag9 && (!double.IsNaN(fieldInfo4.LabelExtent) || !double.IsNaN(fieldInfo4.CellExtent)))
				{
					flag9 = true;
				}
			}
			return flag9;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000858C File Offset: 0x0000678C
		internal bool ExitEditModeIfNeeded()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
			if (dataPresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.Cell activeCell = dataPresenter.ActiveCell;
				if (activeCell != null && activeCell.IsInEditMode)
				{
					global::Infragistics.Windows.DataPresenter.Field field = activeCell.Field;
					global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo[] fieldInfos = this._fieldInfos;
					int i = 0;
					while (i < fieldInfos.Length)
					{
						global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo = fieldInfos[i];
						if (fieldInfo.Field == field)
						{
							if ((fieldInfo.Options & global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetCellOption(activeCell.Record, field)) != global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None && !dataPresenter.EndEditMode(true, false))
							{
								return false;
							}
							break;
						}
						else
						{
							i++;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00008614 File Offset: 0x00006814
		internal static global::System.Windows.FrameworkElement GetCellElement(global::System.Windows.FrameworkElement element, bool label)
		{
			if (label)
			{
				global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = element as global::Infragistics.Windows.DataPresenter.LabelPresenter;
				if (labelPresenter != null)
				{
					return labelPresenter;
				}
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = element as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
				if (cellValuePresenter != null)
				{
					return cellValuePresenter;
				}
				if (element is global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter)
				{
					return element;
				}
			}
			global::Infragistics.Windows.DataPresenter.CellPresenterBase cellPresenterBase = element as global::Infragistics.Windows.DataPresenter.CellPresenterBase;
			if (cellPresenterBase == null)
			{
				return null;
			}
			return cellPresenterBase.GetChild(label);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000865C File Offset: 0x0000685C
		internal static global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions GetCellOption(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.RecordType recordType = record.RecordType;
			if (recordType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord)
			{
				return global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.DataCells;
			}
			if (recordType == global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord)
			{
				return global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.FilterCells;
			}
			return global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000867D File Offset: 0x0000687D
		internal static global::Infragistics.Windows.DataPresenter.CellValuePresenter GetCellPresenter(global::Infragistics.Windows.DataPresenter.Field f, global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache cache)
		{
			return global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetTemplateElement(f, cache, false) as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000868C File Offset: 0x0000688C
		public double GetExtent(global::Infragistics.Windows.DataPresenter.Field field, bool isLabel)
		{
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo = this.GetFieldInfo(field);
			return fieldInfo.GetExtent(isLabel);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000086A8 File Offset: 0x000068A8
		public double GetExtent(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo = this.GetFieldInfo(field);
			return global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.Max(fieldInfo.GetExtent(true), fieldInfo.GetExtent(false));
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000086E8 File Offset: 0x000068E8
		internal global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo GetFieldInfo(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::System.Predicate<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo> match = (global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo) => fieldInfo.Field == field;
			return global::System.Array.Find<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo>(this._fieldInfos, match);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00008830 File Offset: 0x00006A30
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> GetFields()
		{
			for (int i = 0; i < this._fieldInfos.Length; i++)
			{
				yield return this._fieldInfos[i].Field;
			}
			yield break;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00008850 File Offset: 0x00006A50
		public global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> GetPreferredSizes(global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager lm, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase> layoutItems)
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size>();
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo> dictionary2 = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo>();
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			foreach (global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo in this._fieldInfos)
			{
				dictionary2[fieldInfo.Field] = fieldInfo;
			}
			bool useCellPresenters = this._fieldLayout.UseCellPresenters;
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase in layoutItems)
			{
				global::Infragistics.Windows.DataPresenter.Field field = fieldLayoutItemBase.Field;
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo2;
				if (dictionary2.TryGetValue(field, out fieldInfo2))
				{
					double num = (!useCellPresenters) ? global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.Max(fieldInfo2.LabelExtent, fieldInfo2.CellExtent) : (fieldLayoutItemBase.IsLabel ? fieldInfo2.LabelExtent : fieldInfo2.CellExtent);
					if (!double.IsNaN(num) && ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)fieldLayoutItemBase).Visibility != global::System.Windows.Visibility.Collapsed)
					{
						global::System.Windows.Size preferredSize = ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)fieldLayoutItemBase).PreferredSize;
						if (isHorizontal)
						{
							preferredSize.Height = num;
						}
						else
						{
							preferredSize.Width = num;
						}
						dictionary[fieldLayoutItemBase] = preferredSize;
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00008978 File Offset: 0x00006B78
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings> GetFieldOption(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions options, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope scope)
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings>();
			dictionary[field] = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings(options, scope);
			return dictionary;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000899C File Offset: 0x00006B9C
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings> GetFieldOptions(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> fields, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions allowedOptions)
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings>();
			foreach (global::Infragistics.Windows.DataPresenter.Field field in fields)
			{
				global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions fieldAutoSizeOptions = field.GetCurrentAutoSizeOptions();
				fieldAutoSizeOptions &= allowedOptions;
				dictionary[field] = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings(fieldAutoSizeOptions, field.AutoSizeScopeResolved);
			}
			return dictionary;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00008A04 File Offset: 0x00006C04
		internal static global::Infragistics.Windows.DataPresenter.LabelPresenter GetLabelPresenter(global::Infragistics.Windows.DataPresenter.Field f, global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache cache)
		{
			return global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetTemplateElement(f, cache, true) as global::Infragistics.Windows.DataPresenter.LabelPresenter;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00008A14 File Offset: 0x00006C14
		internal static int GetNestingDepth(global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			int num = 0;
			while (recordManager != null && recordManager.ParentRecord != null)
			{
				num += 2;
				recordManager = recordManager.ParentRecord.ParentDataRecord.RecordManager;
			}
			return num;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00008A47 File Offset: 0x00006C47
		internal static int GetNestingDepth(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			return global::System.Math.Max(fieldLayout.NestingDepth, fieldLayout.NestingDepth);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00008A5C File Offset: 0x00006C5C
		private static global::System.Windows.FrameworkElement GetTemplateElement(global::Infragistics.Windows.DataPresenter.Field f, global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache cache, bool isLabel)
		{
			global::Infragistics.Windows.DataPresenter.CellPlaceholder placeHolder = cache.GetPlaceHolder(f, isLabel, true);
			if (placeHolder == null)
			{
				return null;
			}
			global::System.Windows.Controls.Control childCellElement = placeHolder.ChildCellElement;
			childCellElement.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
			childCellElement.UpdateLayout();
			return global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetCellElement(childCellElement, isLabel);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00008AA9 File Offset: 0x00006CA9
		internal bool IncludesOption(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions option)
		{
			return global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.IncludesOption(option, this._options);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00008AB7 File Offset: 0x00006CB7
		internal static bool IncludesOption(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions option, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions options)
		{
			return global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None != (options & option);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00008AC2 File Offset: 0x00006CC2
		internal static double Max(double x, double y)
		{
			if (double.IsNaN(x))
			{
				return y;
			}
			if (double.IsNaN(y))
			{
				return x;
			}
			return global::System.Math.Max(x, y);
		}

		// Token: 0x0400005E RID: 94
		internal const global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions RecordOptions = ~global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Label;

		// Token: 0x0400005F RID: 95
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000060 RID: 96
		private global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions _options;

		// Token: 0x04000061 RID: 97
		private global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo[] _fieldInfos;

		// Token: 0x04000062 RID: 98
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldValue, double> _dataCellValues;

		// Token: 0x04000063 RID: 99
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo>> _fieldInfosByScope;

		// Token: 0x04000064 RID: 100
		public static readonly global::System.Windows.DependencyProperty IsAutoSizeElementProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsAutoSizeElement", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x02000031 RID: 49
		internal class FieldInfo
		{
			// Token: 0x0600020E RID: 526 RVA: 0x00008B10 File Offset: 0x00006D10
			internal FieldInfo(global::Infragistics.Windows.DataPresenter.Field field)
			{
				this.Field = field;
				this.CellExtent = (this.LabelExtent = double.NaN);
			}

			// Token: 0x0600020F RID: 527 RVA: 0x00008B42 File Offset: 0x00006D42
			internal void AddLabelExtent(double extent)
			{
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo.SetMax(extent, ref this.LabelExtent);
			}

			// Token: 0x06000210 RID: 528 RVA: 0x00008B50 File Offset: 0x00006D50
			internal void AddCellExtent(double extent)
			{
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo.SetMax(extent, ref this.CellExtent);
			}

			// Token: 0x06000211 RID: 529 RVA: 0x00008B60 File Offset: 0x00006D60
			internal double GetExtent(bool isLabel)
			{
				global::Infragistics.Windows.DataPresenter.LayoutItemSize size = this.Field.Owner.IsHorizontal ? global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredHeight : global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredWidth;
				if (global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.ShouldSynchronize(size, this.Field))
				{
					return global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.Max(this.LabelExtent, this.CellExtent);
				}
				if (!isLabel)
				{
					return this.CellExtent;
				}
				return this.LabelExtent;
			}

			// Token: 0x06000212 RID: 530 RVA: 0x00008BB4 File Offset: 0x00006DB4
			internal void RoundExtents()
			{
				this.CellExtent = global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo.RoundUp(this.CellExtent);
				this.LabelExtent = global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo.RoundUp(this.LabelExtent);
			}

			// Token: 0x06000213 RID: 531 RVA: 0x00008BD8 File Offset: 0x00006DD8
			private static double RoundUp(double value)
			{
				if (!double.IsNaN(value) && value != 0.0)
				{
					int num = 15 - (int)global::System.Math.Ceiling(global::System.Math.Log10(global::System.Math.Abs(value)));
					int num2 = (value >= 0.0) ? 1 : -1;
					value = global::System.Math.Abs(value);
					double num3 = global::System.Math.Pow(10.0, (double)num);
					value *= num3;
					value = global::System.Math.Ceiling(value);
					value /= num3;
					value *= (double)num2;
					if (value == 0.0)
					{
						value = 0.0;
					}
				}
				return value;
			}

			// Token: 0x06000214 RID: 532 RVA: 0x00008C68 File Offset: 0x00006E68
			private static void SetMax(double value, ref double extent)
			{
				if (double.IsNaN(extent))
				{
					extent = value;
					return;
				}
				if (!double.IsNaN(value))
				{
					extent = global::System.Math.Max(value, extent);
				}
			}

			// Token: 0x04000065 RID: 101
			internal global::Infragistics.Windows.DataPresenter.Field Field;

			// Token: 0x04000066 RID: 102
			internal global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions Options;

			// Token: 0x04000067 RID: 103
			internal double CellExtent;

			// Token: 0x04000068 RID: 104
			internal double LabelExtent;
		}

		// Token: 0x02000032 RID: 50
		private struct FieldValue : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldValue>
		{
			// Token: 0x06000215 RID: 533 RVA: 0x00008C89 File Offset: 0x00006E89
			public FieldValue(global::Infragistics.Windows.DataPresenter.Field field, object value)
			{
				this.Field = field;
				this.Value = value;
			}

			// Token: 0x06000216 RID: 534 RVA: 0x00008C99 File Offset: 0x00006E99
			public override bool Equals(object obj)
			{
				return obj != null && obj is global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldValue && this.Equals((global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldValue)obj);
			}

			// Token: 0x06000217 RID: 535 RVA: 0x00008CB4 File Offset: 0x00006EB4
			public override int GetHashCode()
			{
				int num = this.Field.GetHashCode();
				if (this.Value != null)
				{
					num |= this.Value.GetHashCode();
				}
				return num;
			}

			// Token: 0x06000218 RID: 536 RVA: 0x00008CE4 File Offset: 0x00006EE4
			public override string ToString()
			{
				return string.Format("Field='{0}', Value='{1}'", this.Field, this.Value);
			}

			// Token: 0x06000219 RID: 537 RVA: 0x00008CFC File Offset: 0x00006EFC
			public bool Equals(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldValue other)
			{
				return other.Field == this.Field && object.Equals(other.Value, this.Value);
			}

			// Token: 0x04000069 RID: 105
			internal global::Infragistics.Windows.DataPresenter.Field Field;

			// Token: 0x0400006A RID: 106
			internal object Value;
		}

		// Token: 0x02000033 RID: 51
		private abstract class RecordEnumeratorBase : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x0600021A RID: 538 RVA: 0x00008D21 File Offset: 0x00006F21
			protected RecordEnumeratorBase(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> records, global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager, bool viewableOnly, int depthCount, int currentDepth, bool checkParents)
			{
				this.Initialize(depthCount, currentDepth, parentRecordManager);
				this._viewableOnly = viewableOnly;
				this._checkParents = checkParents;
				this._records = records;
				this.Reset();
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x0600021B RID: 539 RVA: 0x00008D50 File Offset: 0x00006F50
			public int DepthCount
			{
				get
				{
					return this._depthCount;
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x0600021C RID: 540 RVA: 0x00008D58 File Offset: 0x00006F58
			public int RecordManagerVersion
			{
				get
				{
					return this._recordManagerVersion;
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x0600021D RID: 541 RVA: 0x00008D60 File Offset: 0x00006F60
			public bool ViewableOnly
			{
				get
				{
					return this._viewableOnly;
				}
			}

			// Token: 0x0600021E RID: 542
			protected abstract global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordCollectionEnumerator CreateChildEnumerator(global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecords, int newDepth);

			// Token: 0x0600021F RID: 543 RVA: 0x00008D68 File Offset: 0x00006F68
			protected void Initialize(int depthCount, int currentDepth, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
			{
				this._depthCount = depthCount;
				this._currentDepth = currentDepth;
				this._recordManager = recordManager;
				this._recordManagerVersion = ((recordManager == null) ? 0 : recordManager.FieldAutoSizeVersion);
			}

			// Token: 0x06000220 RID: 544 RVA: 0x00008D91 File Offset: 0x00006F91
			protected virtual void OnNewRootRecord(global::Infragistics.Windows.DataPresenter.Record newRootRecord)
			{
			}

			// Token: 0x06000221 RID: 545 RVA: 0x00008D93 File Offset: 0x00006F93
			protected virtual void ReinitializeRecords(ref global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> _records)
			{
			}

			// Token: 0x06000222 RID: 546 RVA: 0x00008D95 File Offset: 0x00006F95
			internal void SetViewableOnly(bool viewableRecordsOnly)
			{
				if (this._viewableOnly != viewableRecordsOnly)
				{
					this._viewableOnly = viewableRecordsOnly;
					this.ReinitializeRecords(ref this._records);
				}
			}

			// Token: 0x06000223 RID: 547 RVA: 0x00008DB3 File Offset: 0x00006FB3
			protected bool ShouldInclude(global::Infragistics.Windows.DataPresenter.Record record, bool checkParents)
			{
				if (this._viewableOnly)
				{
					if (record.VisibilityResolved != global::System.Windows.Visibility.Visible)
					{
						return false;
					}
					while (checkParents && (record = record.ParentRecord) != null)
					{
						if (!record.IsExpanded)
						{
							return false;
						}
						if (record.VisibilityResolved != global::System.Windows.Visibility.Visible)
						{
							return false;
						}
					}
				}
				return true;
			}

			// Token: 0x06000224 RID: 548 RVA: 0x00008DEC File Offset: 0x00006FEC
			protected virtual bool ShouldIncludeChildren(global::Infragistics.Windows.DataPresenter.Record record)
			{
				if (this._viewableOnly && !record.IsExpanded)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
				return (dataRecord == null || this._currentDepth != this._depthCount) && record.HasChildrenInternal;
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x06000225 RID: 549 RVA: 0x00008E2B File Offset: 0x0000702B
			public global::Infragistics.Windows.DataPresenter.Record Current
			{
				get
				{
					return this._currentRecord;
				}
			}

			// Token: 0x06000226 RID: 550 RVA: 0x00008E33 File Offset: 0x00007033
			public void Dispose()
			{
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x06000227 RID: 551 RVA: 0x00008E35 File Offset: 0x00007035
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._currentRecord;
				}
			}

			// Token: 0x06000228 RID: 552 RVA: 0x00008E40 File Offset: 0x00007040
			public bool MoveNext()
			{
				while (this._descendantEnumerator == null)
				{
					if (this._currentRecord == null || !this.ShouldIncludeChildren(this._currentRecord))
					{
						IL_C1:
						while (this._recordsEnumerator.MoveNext())
						{
							this._currentRecord = this._recordsEnumerator.Current;
							if (this.ShouldInclude(this._currentRecord, this._checkParents))
							{
								this.OnNewRootRecord(this._currentRecord);
								return true;
							}
						}
						this._currentRecord = null;
						return false;
					}
					int num = this._currentDepth;
					global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecordsInternal = this._currentRecord.ChildRecordsInternal;
					if (childRecordsInternal.ParentRecordManager != this._recordManager)
					{
						num++;
					}
					this._descendantEnumerator = this.CreateChildEnumerator(this._currentRecord.ChildRecordsInternal, num);
					if (this._currentRecord == null)
					{
						return null != this._currentRecord;
					}
				}
				if (!this._descendantEnumerator.MoveNext())
				{
					this._descendantEnumerator = null;
					goto IL_C1;
				}
				this._currentRecord = this._descendantEnumerator.Current;
				return true;
			}

			// Token: 0x06000229 RID: 553 RVA: 0x00008F3B File Offset: 0x0000713B
			public void Reset()
			{
				this._recordsEnumerator = this._records.GetEnumerator();
				this._descendantEnumerator = null;
				this._currentRecord = null;
			}

			// Token: 0x0400006B RID: 107
			private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> _records;

			// Token: 0x0400006C RID: 108
			private int _depthCount;

			// Token: 0x0400006D RID: 109
			private int _currentDepth;

			// Token: 0x0400006E RID: 110
			private bool _viewableOnly;

			// Token: 0x0400006F RID: 111
			private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

			// Token: 0x04000070 RID: 112
			private bool _checkParents;

			// Token: 0x04000071 RID: 113
			private int _recordManagerVersion;

			// Token: 0x04000072 RID: 114
			private global::Infragistics.Windows.DataPresenter.Record _currentRecord;

			// Token: 0x04000073 RID: 115
			private global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> _recordsEnumerator;

			// Token: 0x04000074 RID: 116
			private global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordCollectionEnumerator _descendantEnumerator;
		}

		// Token: 0x02000034 RID: 52
		private class RecordCollectionEnumerator : global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordEnumeratorBase
		{
			// Token: 0x0600022A RID: 554 RVA: 0x00008F5C File Offset: 0x0000715C
			internal RecordCollectionEnumerator(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, int depthCount) : this(records, depthCount, true, 0, true)
			{
			}

			// Token: 0x0600022B RID: 555 RVA: 0x00008F69 File Offset: 0x00007169
			internal RecordCollectionEnumerator(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, int depthCount, bool viewableOnly, int currentDepth, bool checkParents) : base(viewableOnly ? records.ViewableRecords : records.GetAllRecords(), records.ParentRecordManager, viewableOnly, depthCount, currentDepth, checkParents)
			{
				this._records = records;
			}

			// Token: 0x0600022C RID: 556 RVA: 0x00008F95 File Offset: 0x00007195
			protected override global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordCollectionEnumerator CreateChildEnumerator(global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecords, int newDepth)
			{
				return new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordCollectionEnumerator(childRecords, base.DepthCount, base.ViewableOnly, newDepth, false);
			}

			// Token: 0x0600022D RID: 557 RVA: 0x00008FAB File Offset: 0x000071AB
			protected override void ReinitializeRecords(ref global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> records)
			{
				records = (base.ViewableOnly ? this._records.ViewableRecords : this._records.GetAllRecords());
			}

			// Token: 0x04000075 RID: 117
			private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _records;
		}

		// Token: 0x02000035 RID: 53
		private class RecordEnumerator : global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordEnumeratorBase
		{
			// Token: 0x0600022E RID: 558 RVA: 0x00008FCF File Offset: 0x000071CF
			internal RecordEnumerator(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> records, int maxDepth, bool recursive) : base(records, null, true, 0, 0, true)
			{
				this._maxDepth = maxDepth;
				this._recursive = recursive;
			}

			// Token: 0x0600022F RID: 559 RVA: 0x00008FEB File Offset: 0x000071EB
			protected override global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordCollectionEnumerator CreateChildEnumerator(global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecords, int newDepth)
			{
				return new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordCollectionEnumerator(childRecords, base.DepthCount, base.ViewableOnly, newDepth, false);
			}

			// Token: 0x06000230 RID: 560 RVA: 0x00009004 File Offset: 0x00007204
			protected override void OnNewRootRecord(global::Infragistics.Windows.DataPresenter.Record newRootRecord)
			{
				base.OnNewRootRecord(newRootRecord);
				int num = this._maxDepth - newRootRecord.RecordManager.NestingDepth;
				num = global::System.Math.Max(0, num);
				base.Initialize(num, 0, newRootRecord.RecordManager);
			}

			// Token: 0x06000231 RID: 561 RVA: 0x00009041 File Offset: 0x00007241
			protected override bool ShouldIncludeChildren(global::Infragistics.Windows.DataPresenter.Record record)
			{
				return this._recursive && base.ShouldIncludeChildren(record);
			}

			// Token: 0x04000076 RID: 118
			private int _maxDepth;

			// Token: 0x04000077 RID: 119
			private bool _recursive;
		}

		// Token: 0x02000036 RID: 54
		internal class FieldList
		{
			// Token: 0x06000232 RID: 562 RVA: 0x00009054 File Offset: 0x00007254
			internal FieldList(int size)
			{
				this._fields = new int[size / 10 + 1];
			}

			// Token: 0x06000233 RID: 563 RVA: 0x0000906D File Offset: 0x0000726D
			internal bool Contains(global::Infragistics.Windows.DataPresenter.Field field)
			{
				return 0 != (this._fields[field.Index / 10] & 1 << field.Index % 10);
			}

			// Token: 0x06000234 RID: 564 RVA: 0x00009094 File Offset: 0x00007294
			internal void Add(global::Infragistics.Windows.DataPresenter.Field field)
			{
				this._fields[field.Index / 10] |= 1 << field.Index % 10;
			}

			// Token: 0x06000235 RID: 565 RVA: 0x000090C4 File Offset: 0x000072C4
			internal bool Remove(global::Infragistics.Windows.DataPresenter.Field field)
			{
				if (!this.Contains(field))
				{
					return false;
				}
				this._fields[field.Index / 10] &= ~(1 << field.Index % 10);
				return true;
			}

			// Token: 0x04000078 RID: 120
			private const int Factor = 10;

			// Token: 0x04000079 RID: 121
			private int[] _fields;
		}

		// Token: 0x02000037 RID: 55
		internal class RecordFieldList
		{
			// Token: 0x06000236 RID: 566 RVA: 0x00009101 File Offset: 0x00007301
			internal RecordFieldList()
			{
				this._items = new global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.Record, global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList>(true, false);
			}

			// Token: 0x17000079 RID: 121
			internal global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList this[global::Infragistics.Windows.DataPresenter.Record record]
			{
				get
				{
					global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList result;
					this._items.TryGetValue(record, out result);
					return result;
				}
				set
				{
					this._items[record] = value;
				}
			}

			// Token: 0x06000239 RID: 569 RVA: 0x00009144 File Offset: 0x00007344
			internal void Add(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList fieldList;
				if (!this._items.TryGetValue(record, out fieldList))
				{
					fieldList = (this._items[record] = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList(record.FieldLayout.Fields.Count));
				}
				fieldList.Add(field);
			}

			// Token: 0x0600023A RID: 570 RVA: 0x0000918B File Offset: 0x0000738B
			internal void Clear()
			{
				this._items.Clear();
			}

			// Token: 0x0600023B RID: 571 RVA: 0x00009198 File Offset: 0x00007398
			internal bool Contains(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList fieldList;
				return this._items.TryGetValue(record, out fieldList) && (field == null || fieldList.Contains(field));
			}

			// Token: 0x0600023C RID: 572 RVA: 0x000091C3 File Offset: 0x000073C3
			internal bool Remove(global::Infragistics.Windows.DataPresenter.Record record)
			{
				return this._items.Remove(record);
			}

			// Token: 0x0600023D RID: 573 RVA: 0x000091D4 File Offset: 0x000073D4
			internal bool Remove(global::Infragistics.Windows.DataPresenter.RecordType recordType)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = null;
				foreach (global::Infragistics.Windows.DataPresenter.Record record in this._items.Keys)
				{
					if (record.RecordType == recordType)
					{
						if (list == null)
						{
							list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
						}
						list.Add(record);
					}
				}
				if (list == null)
				{
					return false;
				}
				int i = 0;
				int count = list.Count;
				while (i < count)
				{
					this._items.Remove(list[i]);
					i++;
				}
				return true;
			}

			// Token: 0x0600023E RID: 574 RVA: 0x0000926C File Offset: 0x0000746C
			internal bool Remove(global::Infragistics.Windows.DataPresenter.Field field)
			{
				bool result = false;
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Record, global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList> keyValuePair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Record, global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList>>)this._items))
				{
					if (keyValuePair.Value.Remove(field))
					{
						result = true;
					}
				}
				return result;
			}

			// Token: 0x0600023F RID: 575 RVA: 0x000092C8 File Offset: 0x000074C8
			internal bool Remove(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Field field)
			{
				if (field == null)
				{
					return this.Remove(record);
				}
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList fieldList;
				return this._items.TryGetValue(record, out fieldList) && fieldList.Remove(field);
			}

			// Token: 0x0400007A RID: 122
			private const int Factor = 10;

			// Token: 0x0400007B RID: 123
			private global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.Record, global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList> _items;
		}
	}
}
