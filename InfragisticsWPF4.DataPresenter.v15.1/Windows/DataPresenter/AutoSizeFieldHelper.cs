using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Infragistics.Collections;
using Infragistics.Controls.Layouts.Primitives;
using Infragistics.Windows.DataPresenter.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000030 RID: 48
	internal class AutoSizeFieldHelper
	{
		// Token: 0x06000208 RID: 520 RVA: 0x00008138 File Offset: 0x00006338
		internal AutoSizeFieldHelper(global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings> fields, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(fields);
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(fieldLayout);
			if (fieldLayout.IsTreeView)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = fieldLayout.AlignmentFieldLayout;
				if (alignmentFieldLayout != null)
				{
					global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings>();
					foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings> keyValuePair in fields)
					{
						global::Infragistics.Windows.DataPresenter.Field mappedTreeField = keyValuePair.Key.MappedTreeField;
						if (mappedTreeField != null)
						{
							dictionary.Add(mappedTreeField, keyValuePair.Value);
						}
					}
					fields = dictionary;
					fieldLayout = alignmentFieldLayout;
				}
			}
			this._fieldLayout = fieldLayout;
			this._fieldLayout.TemplateDataRecordCache.Verify();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo>();
			this._fieldInfosByScope = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo>>();
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings> keyValuePair2 in fields)
			{
				global::Infragistics.Windows.DataPresenter.Field key = keyValuePair2.Key;
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings value = keyValuePair2.Value;
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

		// Token: 0x06000209 RID: 521 RVA: 0x000082E8 File Offset: 0x000064E8
		internal AutoSizeFieldHelper(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> fields, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout) : this(fields, fieldLayout, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.All)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000082F3 File Offset: 0x000064F3
		internal AutoSizeFieldHelper(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> fields, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions allowedOptions) : this(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetFieldOptions(fields, allowedOptions), fieldLayout)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00008303 File Offset: 0x00006503
		internal AutoSizeFieldHelper(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions options, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope scope) : this(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetFieldOption(field, options, scope), field.Owner)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00008319 File Offset: 0x00006519
		internal static bool GetIsAutoSizeElement(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.IsAutoSizeElementProperty);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000832B File Offset: 0x0000652B
		private static void AddProcessedField(global::Infragistics.Windows.DataPresenter.Field field, ref global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList newFieldList)
		{
			if (newFieldList == null)
			{
				newFieldList = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList(field.Owner.Fields.Count);
			}
			newFieldList.Add(field);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00008350 File Offset: 0x00006550
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

		// Token: 0x0600020F RID: 527 RVA: 0x000083AC File Offset: 0x000065AC
		public bool Calculate(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> outOfViewRecords, bool recursive, int recordManagerDepth, global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags flags)
		{
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordFieldList recordFieldList = null;
			return this.Calculate((outOfViewRecords == null) ? null : new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordEnumerator(outOfViewRecords, recordManagerDepth, recursive), flags, ref recordFieldList, false, null);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000083D5 File Offset: 0x000065D5
		public bool Calculate(global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags flags, ref global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordFieldList recordFieldList, bool trackRecords, global::Infragistics.Windows.DataPresenter.RecordsInViewHelper recordsInViewHelper)
		{
			return this.Calculate(null, flags, ref recordFieldList, trackRecords, recordsInViewHelper);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000083E4 File Offset: 0x000065E4
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
			global::System.Collections.Generic.HashSet<global::Infragistics.Windows.DataPresenter.FieldLayout> hashSet = new global::System.Collections.Generic.HashSet<global::Infragistics.Windows.DataPresenter.FieldLayout>();
			hashSet.Add(this._fieldLayout);
			bool isTreeView = dataPresenter.IsTreeView;
			double num = 0.0;
			if (isTreeView && (!dataPresenter.IsExportControl || dataPresenter.IsReportControl))
			{
				num = dataPresenter.CurrentViewInternal.LevelIndentationResolved;
			}
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
							labelPresenter.Measure(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.MeasureSize);
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
				global::System.Collections.Generic.HashSet<global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel> hashSet2 = new global::System.Collections.Generic.HashSet<global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel>();
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
					int num2 = 0;
					while (enumerator2.MoveNext())
					{
						global::Infragistics.Windows.DataPresenter.Record record2 = enumerator2.Current;
						if (isTreeView || record2.FieldLayout == this._fieldLayout)
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
									num2 = outOfViewRecords.RecordManagerVersion;
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
												goto IL_3EA;
											}
										}
										else if (global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.IncludesOption(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.DataCells, fieldInfo3.Options))
										{
											goto IL_3EA;
										}
									}
									else if (!(record2 is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord))
									{
										if (summaryRecord != null)
										{
											if (global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.IncludesOption(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Summaries, fieldInfo3.Options))
											{
												goto IL_3EA;
											}
										}
										else if (groupByRecord != null && global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.IncludesOption(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Summaries, fieldInfo3.Options))
										{
											goto IL_3EA;
										}
									}
									IL_85C:
									j++;
									continue;
									IL_3EA:
									global::Infragistics.Windows.DataPresenter.Field field2 = fieldInfo3.Field;
									if (isTreeView && record2.FieldLayout != this._fieldLayout)
									{
										field2 = record2.FieldLayout.GetFieldFromMappedField(field2);
										if (field2 == null)
										{
											goto IL_85C;
										}
									}
									if ((!flag2 && fieldList != null && fieldList.Contains(field2)) || (record2 == record && field2 == field))
									{
										goto IL_85C;
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
													if (global::System.Windows.Media.VisualTreeHelper.GetParent(cellElement) == virtualizingDataRecordCellPanel)
													{
														virtualizingDataRecordCellPanel.SetLastMeasureSize(field2, global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.MeasureSize);
													}
													bool isPerformingAutoSizeMeasure = virtualizingDataRecordCellPanel.IsPerformingAutoSizeMeasure;
													virtualizingDataRecordCellPanel.IsPerformingAutoSizeMeasure = true;
													try
													{
														cellElement.Measure(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.MeasureSize);
													}
													finally
													{
														virtualizingDataRecordCellPanel.IsPerformingAutoSizeMeasure = isPerformingAutoSizeMeasure;
													}
													hashSet2.Add(virtualizingDataRecordCellPanel);
													global::System.Windows.Size desiredSize2 = cellElement.DesiredSize;
													fieldInfo3.AddCellExtent(isHorizontal ? desiredSize2.Height : desiredSize2.Width);
													if (trackRecords)
													{
														global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.AddProcessedField(field2, ref fieldList2);
														goto IL_85C;
													}
													goto IL_85C;
												}
											}
										}
									}
									if (!flag6)
									{
										goto IL_85C;
									}
									int num3 = field2.AutoSizeVersion;
									if (dataRecord != null)
									{
										if (flag7)
										{
											if (!(dataRecord is global::Infragistics.Windows.DataPresenter.FilterRecord))
											{
												num3 += num2;
											}
											global::Infragistics.Windows.DataPresenter.Cell cell2 = dataRecord.Cells[field2];
											if (!flag2 && cell2.FieldAutoSizeVersion == num3)
											{
												goto IL_85C;
											}
											cell2.FieldAutoSizeVersion = num3;
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
											filterCellValuePresenter.Measure(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.MeasureSize);
											filterCellValuePresenter.UpdateLayout();
											global::System.Windows.Size desiredSize3 = filterCellValuePresenter.DesiredSize;
											double extent = isHorizontal ? desiredSize3.Height : desiredSize3.Width;
											fieldInfo3.AddCellExtent(extent);
											if (trackRecords)
											{
												global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.AddProcessedField(field2, ref fieldList2);
												goto IL_85C;
											}
											goto IL_85C;
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
													goto IL_85C;
												}
												goto IL_85C;
											}
											else
											{
												if (isTreeView && field2.Owner != templateDataRecord.FieldLayout)
												{
													templateDataRecordCache = field2.Owner.TemplateDataRecordCache;
													templateDataRecord = (field2.Owner.TemplateDataRecord as global::Infragistics.Windows.DataPresenter.TemplateDataRecord);
													if (!hashSet.Contains(field2.Owner))
													{
														hashSet.Add(field2.Owner);
														templateDataRecordCache.Verify();
														templateDataRecord.VerifyCachedCellElements();
													}
												}
												templateDataRecord.SetValue(field2, cellValue);
												global::Infragistics.Windows.DataPresenter.CellValuePresenter cellPresenter = global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetCellPresenter(field2, templateDataRecordCache);
												if (cellPresenter != null)
												{
													global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter treeCellValuePresenter = cellPresenter as global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter;
													if (treeCellValuePresenter != null)
													{
														int nestingDepthOfDataRcds = record2.NestingDepthOfDataRcds;
														if (nestingDepthOfDataRcds > 0)
														{
															treeCellValuePresenter.SetValue(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter.IndentPropertyKey, (double)nestingDepthOfDataRcds * num);
															treeCellValuePresenter.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
															treeCellValuePresenter.UpdateLayout();
														}
													}
													global::System.Windows.Size desiredSize4 = cellPresenter.DesiredSize;
													double num4 = isHorizontal ? desiredSize4.Height : desiredSize4.Width;
													fieldInfo3.AddCellExtent(num4);
													this._dataCellValues.Add(key, num4);
													if (trackRecords)
													{
														global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.AddProcessedField(field2, ref fieldList2);
														goto IL_85C;
													}
													goto IL_85C;
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
										goto IL_85C;
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
											if (summaryResult.FieldAutoSizeVersion != num3)
											{
												flag8 = true;
												summaryResult.FieldAutoSizeVersion = num3;
											}
										}
										if (!flag8)
										{
											goto IL_85C;
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
										summaryResultsPresenter.Measure(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.MeasureSize);
										summaryResultsPresenter.UpdateLayout();
										global::System.Windows.Size desiredSize5 = summaryResultsPresenter.DesiredSize;
										fieldInfo3.AddCellExtent(isHorizontal ? desiredSize5.Height : desiredSize5.Width);
										goto IL_85C;
									}
									goto IL_85C;
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
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in hashSet)
				{
					global::Infragistics.Windows.DataPresenter.TemplateDataRecord templateDataRecord2 = fieldLayout.TemplateDataRecord as global::Infragistics.Windows.DataPresenter.TemplateDataRecord;
					templateDataRecord2.ClearAll();
				}
				foreach (global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel2 in hashSet2)
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

		// Token: 0x06000212 RID: 530 RVA: 0x00008E54 File Offset: 0x00007054
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

		// Token: 0x06000213 RID: 531 RVA: 0x00008EDC File Offset: 0x000070DC
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

		// Token: 0x06000214 RID: 532 RVA: 0x00008F24 File Offset: 0x00007124
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

		// Token: 0x06000215 RID: 533 RVA: 0x00008F45 File Offset: 0x00007145
		internal static global::Infragistics.Windows.DataPresenter.CellValuePresenter GetCellPresenter(global::Infragistics.Windows.DataPresenter.Field f, global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache cache)
		{
			return global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetTemplateElement(f, cache, false) as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00008F54 File Offset: 0x00007154
		public double GetExtent(global::Infragistics.Windows.DataPresenter.Field field, bool isLabel)
		{
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo = this.GetFieldInfo(field);
			return fieldInfo.GetExtent(isLabel);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00008F70 File Offset: 0x00007170
		public double GetExtent(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo = this.GetFieldInfo(field);
			return global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.Max(fieldInfo.GetExtent(true), fieldInfo.GetExtent(false));
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00008FC8 File Offset: 0x000071C8
		internal global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo GetFieldInfo(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::System.Predicate<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo> match = (global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo) => fieldInfo.Field == field || fieldInfo.Field == field.MappedTreeField;
			return global::System.Array.Find<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo>(this._fieldInfos, match);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00009110 File Offset: 0x00007310
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> GetFields()
		{
			for (int i = 0; i < this._fieldInfos.Length; i++)
			{
				yield return this._fieldInfos[i].Field;
			}
			yield break;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00009130 File Offset: 0x00007330
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
				if (field.IsFieldMapped)
				{
					field = field.MappedTreeField;
				}
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

		// Token: 0x0600021B RID: 539 RVA: 0x0000926C File Offset: 0x0000746C
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings> GetFieldOption(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions options, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope scope)
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings>();
			dictionary[field] = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings(options, scope);
			return dictionary;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00009290 File Offset: 0x00007490
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

		// Token: 0x0600021D RID: 541 RVA: 0x000092F8 File Offset: 0x000074F8
		internal static global::Infragistics.Windows.DataPresenter.LabelPresenter GetLabelPresenter(global::Infragistics.Windows.DataPresenter.Field f, global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache cache)
		{
			return global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetTemplateElement(f, cache, true) as global::Infragistics.Windows.DataPresenter.LabelPresenter;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00009308 File Offset: 0x00007508
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

		// Token: 0x0600021F RID: 543 RVA: 0x0000933B File Offset: 0x0000753B
		internal static int GetNestingDepth(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			return global::System.Math.Max(fieldLayout.NestingDepth, fieldLayout.MaxRecordManagerDepth);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00009350 File Offset: 0x00007550
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

		// Token: 0x06000221 RID: 545 RVA: 0x0000939D File Offset: 0x0000759D
		internal bool IncludesOption(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions option)
		{
			return global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.IncludesOption(option, this._options);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000093AB File Offset: 0x000075AB
		internal static bool IncludesOption(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions option, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions options)
		{
			return global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None != (options & option);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000093B6 File Offset: 0x000075B6
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

		// Token: 0x0400006F RID: 111
		internal const global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions RecordOptions = ~global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Label;

		// Token: 0x04000070 RID: 112
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000071 RID: 113
		private global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions _options;

		// Token: 0x04000072 RID: 114
		private global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo[] _fieldInfos;

		// Token: 0x04000073 RID: 115
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldValue, double> _dataCellValues;

		// Token: 0x04000074 RID: 116
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo>> _fieldInfosByScope;

		// Token: 0x04000075 RID: 117
		internal static readonly global::System.Windows.Size MeasureSize = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);

		// Token: 0x04000076 RID: 118
		public static readonly global::System.Windows.DependencyProperty IsAutoSizeElementProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsAutoSizeElement", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x02000031 RID: 49
		internal class FieldInfo
		{
			// Token: 0x06000225 RID: 549 RVA: 0x0000942C File Offset: 0x0000762C
			internal FieldInfo(global::Infragistics.Windows.DataPresenter.Field field)
			{
				this.Field = field;
				this.CellExtent = (this.LabelExtent = double.NaN);
			}

			// Token: 0x06000226 RID: 550 RVA: 0x0000945E File Offset: 0x0000765E
			internal void AddLabelExtent(double extent)
			{
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo.SetMax(extent, ref this.LabelExtent);
			}

			// Token: 0x06000227 RID: 551 RVA: 0x0000946C File Offset: 0x0000766C
			internal void AddCellExtent(double extent)
			{
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo.SetMax(extent, ref this.CellExtent);
			}

			// Token: 0x06000228 RID: 552 RVA: 0x0000947C File Offset: 0x0000767C
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

			// Token: 0x06000229 RID: 553 RVA: 0x000094D0 File Offset: 0x000076D0
			internal void RoundExtents()
			{
				this.CellExtent = global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo.RoundUp(this.CellExtent);
				this.LabelExtent = global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo.RoundUp(this.LabelExtent);
			}

			// Token: 0x0600022A RID: 554 RVA: 0x000094F4 File Offset: 0x000076F4
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

			// Token: 0x0600022B RID: 555 RVA: 0x00009584 File Offset: 0x00007784
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

			// Token: 0x04000077 RID: 119
			internal global::Infragistics.Windows.DataPresenter.Field Field;

			// Token: 0x04000078 RID: 120
			internal global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions Options;

			// Token: 0x04000079 RID: 121
			internal double CellExtent;

			// Token: 0x0400007A RID: 122
			internal double LabelExtent;
		}

		// Token: 0x02000032 RID: 50
		private struct FieldValue : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldValue>
		{
			// Token: 0x0600022C RID: 556 RVA: 0x000095A5 File Offset: 0x000077A5
			public FieldValue(global::Infragistics.Windows.DataPresenter.Field field, object value)
			{
				this.Field = field;
				this.Value = value;
			}

			// Token: 0x0600022D RID: 557 RVA: 0x000095B5 File Offset: 0x000077B5
			public override bool Equals(object obj)
			{
				return obj != null && obj is global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldValue && this.Equals((global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldValue)obj);
			}

			// Token: 0x0600022E RID: 558 RVA: 0x000095D0 File Offset: 0x000077D0
			public override int GetHashCode()
			{
				int num = this.Field.GetHashCode();
				if (this.Value != null)
				{
					num |= this.Value.GetHashCode();
				}
				return num;
			}

			// Token: 0x0600022F RID: 559 RVA: 0x00009600 File Offset: 0x00007800
			public override string ToString()
			{
				return string.Format("Field='{0}', Value='{1}'", this.Field, this.Value);
			}

			// Token: 0x06000230 RID: 560 RVA: 0x00009618 File Offset: 0x00007818
			public bool Equals(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldValue other)
			{
				return other.Field == this.Field && object.Equals(other.Value, this.Value);
			}

			// Token: 0x0400007B RID: 123
			internal global::Infragistics.Windows.DataPresenter.Field Field;

			// Token: 0x0400007C RID: 124
			internal object Value;
		}

		// Token: 0x02000033 RID: 51
		private abstract class RecordEnumeratorBase : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06000231 RID: 561 RVA: 0x0000963D File Offset: 0x0000783D
			protected RecordEnumeratorBase(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> records, global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager, bool viewableOnly, int depthCount, int currentDepth, bool checkParents)
			{
				this.Initialize(depthCount, currentDepth, parentRecordManager);
				this._viewableOnly = viewableOnly;
				this._checkParents = checkParents;
				this._records = records;
				this.Reset();
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x06000232 RID: 562 RVA: 0x0000966C File Offset: 0x0000786C
			public int DepthCount
			{
				get
				{
					return this._depthCount;
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x06000233 RID: 563 RVA: 0x00009674 File Offset: 0x00007874
			public int RecordManagerVersion
			{
				get
				{
					return this._recordManagerVersion;
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x06000234 RID: 564 RVA: 0x0000967C File Offset: 0x0000787C
			public bool ViewableOnly
			{
				get
				{
					return this._viewableOnly;
				}
			}

			// Token: 0x06000235 RID: 565
			protected abstract global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordCollectionEnumerator CreateChildEnumerator(global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecords, int newDepth);

			// Token: 0x06000236 RID: 566 RVA: 0x00009684 File Offset: 0x00007884
			protected void Initialize(int depthCount, int currentDepth, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
			{
				this._depthCount = depthCount;
				this._currentDepth = currentDepth;
				this._recordManager = recordManager;
				this._recordManagerVersion = ((recordManager == null) ? 0 : recordManager.FieldAutoSizeVersion);
			}

			// Token: 0x06000237 RID: 567 RVA: 0x000096AD File Offset: 0x000078AD
			protected virtual void OnNewRootRecord(global::Infragistics.Windows.DataPresenter.Record newRootRecord)
			{
			}

			// Token: 0x06000238 RID: 568 RVA: 0x000096AF File Offset: 0x000078AF
			protected virtual void ReinitializeRecords(ref global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> _records)
			{
			}

			// Token: 0x06000239 RID: 569 RVA: 0x000096B1 File Offset: 0x000078B1
			internal void SetViewableOnly(bool viewableRecordsOnly)
			{
				if (this._viewableOnly != viewableRecordsOnly)
				{
					this._viewableOnly = viewableRecordsOnly;
					this.ReinitializeRecords(ref this._records);
				}
			}

			// Token: 0x0600023A RID: 570 RVA: 0x000096CF File Offset: 0x000078CF
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

			// Token: 0x0600023B RID: 571 RVA: 0x00009708 File Offset: 0x00007908
			protected virtual bool ShouldIncludeChildren(global::Infragistics.Windows.DataPresenter.Record record)
			{
				if (this._viewableOnly && !record.IsExpanded)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
				return (dataRecord == null || this._currentDepth != this._depthCount) && record.HasChildrenInternal;
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x0600023C RID: 572 RVA: 0x00009747 File Offset: 0x00007947
			public global::Infragistics.Windows.DataPresenter.Record Current
			{
				get
				{
					return this._currentRecord;
				}
			}

			// Token: 0x0600023D RID: 573 RVA: 0x0000974F File Offset: 0x0000794F
			public void Dispose()
			{
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x0600023E RID: 574 RVA: 0x00009751 File Offset: 0x00007951
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._currentRecord;
				}
			}

			// Token: 0x0600023F RID: 575 RVA: 0x0000975C File Offset: 0x0000795C
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

			// Token: 0x06000240 RID: 576 RVA: 0x00009857 File Offset: 0x00007A57
			public void Reset()
			{
				this._recordsEnumerator = this._records.GetEnumerator();
				this._descendantEnumerator = null;
				this._currentRecord = null;
			}

			// Token: 0x0400007D RID: 125
			private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> _records;

			// Token: 0x0400007E RID: 126
			private int _depthCount;

			// Token: 0x0400007F RID: 127
			private int _currentDepth;

			// Token: 0x04000080 RID: 128
			private bool _viewableOnly;

			// Token: 0x04000081 RID: 129
			private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

			// Token: 0x04000082 RID: 130
			private bool _checkParents;

			// Token: 0x04000083 RID: 131
			private int _recordManagerVersion;

			// Token: 0x04000084 RID: 132
			private global::Infragistics.Windows.DataPresenter.Record _currentRecord;

			// Token: 0x04000085 RID: 133
			private global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> _recordsEnumerator;

			// Token: 0x04000086 RID: 134
			private global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordCollectionEnumerator _descendantEnumerator;
		}

		// Token: 0x02000034 RID: 52
		private class RecordCollectionEnumerator : global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordEnumeratorBase
		{
			// Token: 0x06000241 RID: 577 RVA: 0x00009878 File Offset: 0x00007A78
			internal RecordCollectionEnumerator(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, int depthCount) : this(records, depthCount, true, 0, true)
			{
			}

			// Token: 0x06000242 RID: 578 RVA: 0x00009885 File Offset: 0x00007A85
			internal RecordCollectionEnumerator(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, int depthCount, bool viewableOnly, int currentDepth, bool checkParents) : base(viewableOnly ? records.ViewableRecords : records.GetAllRecords(), records.ParentRecordManager, viewableOnly, depthCount, currentDepth, checkParents)
			{
				this._records = records;
			}

			// Token: 0x06000243 RID: 579 RVA: 0x000098B1 File Offset: 0x00007AB1
			protected override global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordCollectionEnumerator CreateChildEnumerator(global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecords, int newDepth)
			{
				return new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordCollectionEnumerator(childRecords, base.DepthCount, base.ViewableOnly, newDepth, false);
			}

			// Token: 0x06000244 RID: 580 RVA: 0x000098C7 File Offset: 0x00007AC7
			protected override void ReinitializeRecords(ref global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> records)
			{
				records = (base.ViewableOnly ? this._records.ViewableRecords : this._records.GetAllRecords());
			}

			// Token: 0x04000087 RID: 135
			private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _records;
		}

		// Token: 0x02000035 RID: 53
		private class RecordEnumerator : global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordEnumeratorBase
		{
			// Token: 0x06000245 RID: 581 RVA: 0x000098EB File Offset: 0x00007AEB
			internal RecordEnumerator(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> records, int maxDepth, bool recursive) : base(records, null, true, 0, 0, true)
			{
				this._maxDepth = maxDepth;
				this._recursive = recursive;
			}

			// Token: 0x06000246 RID: 582 RVA: 0x00009907 File Offset: 0x00007B07
			protected override global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordCollectionEnumerator CreateChildEnumerator(global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecords, int newDepth)
			{
				return new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordCollectionEnumerator(childRecords, base.DepthCount, base.ViewableOnly, newDepth, false);
			}

			// Token: 0x06000247 RID: 583 RVA: 0x00009920 File Offset: 0x00007B20
			protected override void OnNewRootRecord(global::Infragistics.Windows.DataPresenter.Record newRootRecord)
			{
				base.OnNewRootRecord(newRootRecord);
				int num = this._maxDepth - newRootRecord.RecordManager.NestingDepth;
				num = global::System.Math.Max(0, num);
				base.Initialize(num, 0, newRootRecord.RecordManager);
			}

			// Token: 0x06000248 RID: 584 RVA: 0x0000995D File Offset: 0x00007B5D
			protected override bool ShouldIncludeChildren(global::Infragistics.Windows.DataPresenter.Record record)
			{
				return this._recursive && base.ShouldIncludeChildren(record);
			}

			// Token: 0x04000088 RID: 136
			private int _maxDepth;

			// Token: 0x04000089 RID: 137
			private bool _recursive;
		}

		// Token: 0x02000036 RID: 54
		internal class FieldList
		{
			// Token: 0x06000249 RID: 585 RVA: 0x00009970 File Offset: 0x00007B70
			internal FieldList(int size)
			{
				this._fields = new int[size / 10 + 1];
			}

			// Token: 0x0600024A RID: 586 RVA: 0x0000998C File Offset: 0x00007B8C
			internal bool Contains(global::Infragistics.Windows.DataPresenter.Field field)
			{
				int index = field.Index;
				int num = index / 10;
				return index >= 0 && num < this._fields.Length && 0 != (this._fields[num] & 1 << index % 10);
			}

			// Token: 0x0600024B RID: 587 RVA: 0x000099CE File Offset: 0x00007BCE
			internal void Add(global::Infragistics.Windows.DataPresenter.Field field)
			{
				this._fields[field.Index / 10] |= 1 << field.Index % 10;
			}

			// Token: 0x0600024C RID: 588 RVA: 0x000099FE File Offset: 0x00007BFE
			internal bool Remove(global::Infragistics.Windows.DataPresenter.Field field)
			{
				if (!this.Contains(field))
				{
					return false;
				}
				this._fields[field.Index / 10] &= ~(1 << field.Index % 10);
				return true;
			}

			// Token: 0x0400008A RID: 138
			private const int Factor = 10;

			// Token: 0x0400008B RID: 139
			private int[] _fields;
		}

		// Token: 0x02000037 RID: 55
		internal class RecordFieldList
		{
			// Token: 0x0600024D RID: 589 RVA: 0x00009A3B File Offset: 0x00007C3B
			internal RecordFieldList()
			{
				this._items = new global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.Record, global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList>(true, false);
			}

			// Token: 0x17000080 RID: 128
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

			// Token: 0x06000250 RID: 592 RVA: 0x00009A7C File Offset: 0x00007C7C
			internal void Add(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList fieldList;
				if (!this._items.TryGetValue(record, out fieldList))
				{
					fieldList = (this._items[record] = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList(record.FieldLayout.Fields.Count));
				}
				fieldList.Add(field);
			}

			// Token: 0x06000251 RID: 593 RVA: 0x00009AC3 File Offset: 0x00007CC3
			internal void Clear()
			{
				this._items.Clear();
			}

			// Token: 0x06000252 RID: 594 RVA: 0x00009AD0 File Offset: 0x00007CD0
			internal bool Contains(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList fieldList;
				return this._items.TryGetValue(record, out fieldList) && (field == null || fieldList.Contains(field));
			}

			// Token: 0x06000253 RID: 595 RVA: 0x00009AFB File Offset: 0x00007CFB
			internal bool Remove(global::Infragistics.Windows.DataPresenter.Record record)
			{
				return this._items.Remove(record);
			}

			// Token: 0x06000254 RID: 596 RVA: 0x00009B0C File Offset: 0x00007D0C
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

			// Token: 0x06000255 RID: 597 RVA: 0x00009BA4 File Offset: 0x00007DA4
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

			// Token: 0x06000256 RID: 598 RVA: 0x00009C00 File Offset: 0x00007E00
			internal bool Remove(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Field field)
			{
				if (field == null)
				{
					return this.Remove(record);
				}
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList fieldList;
				return this._items.TryGetValue(record, out fieldList) && fieldList.Remove(field);
			}

			// Token: 0x0400008C RID: 140
			private const int Factor = 10;

			// Token: 0x0400008D RID: 141
			private global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.Record, global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldList> _items;
		}
	}
}
