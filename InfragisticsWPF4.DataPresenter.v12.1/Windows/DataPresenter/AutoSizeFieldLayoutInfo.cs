using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using Infragistics.Collections;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200003A RID: 58
	internal class AutoSizeFieldLayoutInfo
	{
		// Token: 0x06000249 RID: 585 RVA: 0x000094F0 File Offset: 0x000076F0
		internal AutoSizeFieldLayoutInfo(global::Infragistics.Windows.DataPresenter.FieldLayout owner)
		{
			this._owner = owner;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00009556 File Offset: 0x00007756
		private int DPMaxAutoSizeAllRecordsDepth
		{
			get
			{
				if (this._owner.DataPresenter == null)
				{
					return -1;
				}
				return this._owner.DataPresenter.AllRecordsAutoSizeMaxDepth;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00009577 File Offset: 0x00007777
		private bool DPHasAllRecordFields
		{
			get
			{
				return this._owner.DataPresenter != null && this._owner.DataPresenter.HasAutoSizeAllRecordFields;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00009598 File Offset: 0x00007798
		// (set) Token: 0x0600024D RID: 589 RVA: 0x000095A0 File Offset: 0x000077A0
		internal bool HasAllRecordFields
		{
			get
			{
				return this._hasAllRecordFields;
			}
			set
			{
				if (value != this._hasAllRecordFields)
				{
					this._hasAllRecordFields = value;
					if (this._owner.DataPresenter != null)
					{
						this._owner.DataPresenter.OnAutoSizeAllRecordsChanged(this._owner, value);
					}
				}
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000095D6 File Offset: 0x000077D6
		private bool DPHasViewableRecordFields
		{
			get
			{
				return this._owner.DataPresenter != null && this._owner.DataPresenter.FieldLayoutAutoSizeViewableCount > 0;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600024F RID: 591 RVA: 0x000095FA File Offset: 0x000077FA
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00009602 File Offset: 0x00007802
		internal bool HasViewableRecordFields
		{
			get
			{
				return this._hasViewableRecordFields;
			}
			set
			{
				if (value != this._hasViewableRecordFields)
				{
					this._hasViewableRecordFields = value;
					if (this._owner.DataPresenter != null)
					{
						this._owner.DataPresenter.FieldLayoutAutoSizeViewableCount += (value ? 1 : -1);
					}
				}
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000963F File Offset: 0x0000783F
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00009647 File Offset: 0x00007847
		internal bool HasRecordsInViewFields
		{
			get
			{
				return this._hasRecordsInViewFields;
			}
			set
			{
				if (value != this._hasRecordsInViewFields)
				{
					this._hasRecordsInViewFields = value;
					if (this._owner.DataPresenter != null)
					{
						this._owner.DataPresenter.FieldLayoutAutoSizeRecordsInViewCount += (value ? 1 : -1);
					}
				}
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00009684 File Offset: 0x00007884
		private void AddViewableRecordFieldLayouts(global::Infragistics.Windows.DataPresenter.FieldLayout parent, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout> fieldLayouts, global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout>> ancestorMap)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout> list;
			if (ancestorMap.TryGetValue(parent, out list))
			{
				ancestorMap.Remove(parent);
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in list)
				{
					if (fieldLayout.IsInitialRecordLoaded)
					{
						fieldLayout.AutoSizeInfo.Verify();
						if (fieldLayout.AutoSizeInfo._hasViewableRecordFields)
						{
							fieldLayouts.Add(fieldLayout);
						}
						this.AddViewableRecordFieldLayouts(fieldLayout, fieldLayouts, ancestorMap);
					}
				}
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00009710 File Offset: 0x00007910
		private void AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType operationType)
		{
			this.AddPendingOperation(operationType, null);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000971C File Offset: 0x0000791C
		private void AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType operationType, object parameter)
		{
			if (this._pendingOperations == null)
			{
				this._pendingOperations = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.AutoSizeFieldOperation[global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationTypeCount];
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
				if (dataPresenter == null)
				{
					return;
				}
				dataPresenter.OnAutoSizePending(this._owner);
				int val = (int)((double)((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)dataPresenter).OverallScrollCount * 0.1);
				this._maxPendingParameters = global::System.Math.Max(500, val);
			}
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.AutoSizeFieldOperation autoSizeFieldOperation = this._pendingOperations[(int)operationType];
			if (autoSizeFieldOperation == null)
			{
				autoSizeFieldOperation = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.AutoSizeFieldOperation(operationType);
				if (parameter != null)
				{
					autoSizeFieldOperation.Parameters = new global::Infragistics.Windows.Helpers.HashSet();
					global::Infragistics.Windows.Helpers.HashSet hashSet = parameter as global::Infragistics.Windows.Helpers.HashSet;
					if (hashSet == null)
					{
						autoSizeFieldOperation.Parameters.Add(parameter);
					}
					else
					{
						autoSizeFieldOperation.Parameters.AddItems(hashSet);
					}
				}
				this._pendingOperationTypes |= 1 << (int)operationType;
				this._pendingOperations[(int)operationType] = autoSizeFieldOperation;
				return;
			}
			if (autoSizeFieldOperation.Parameters != null)
			{
				if (parameter == null)
				{
					autoSizeFieldOperation.Parameters = null;
					return;
				}
				global::Infragistics.Windows.Helpers.HashSet hashSet2 = parameter as global::Infragistics.Windows.Helpers.HashSet;
				int num = autoSizeFieldOperation.Parameters.Count;
				if (hashSet2 != null)
				{
					num += hashSet2.Count;
				}
				else
				{
					num++;
				}
				if (num >= this.GetMaxParameterCount(operationType))
				{
					autoSizeFieldOperation.Parameters = null;
					return;
				}
				if (hashSet2 != null)
				{
					autoSizeFieldOperation.Parameters.AddItems(hashSet2);
					return;
				}
				autoSizeFieldOperation.Parameters.Add(parameter);
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000985C File Offset: 0x00007A5C
		private static void ApplyAutoSize(global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo info, global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo resizeInfo, bool increaseOnly, bool isHorizontal, global::Infragistics.Windows.DataPresenter.ItemSizeType sizeType)
		{
			double extent = info.GetExtent(true);
			double extent2 = info.GetExtent(false);
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.ApplyAutoSize(resizeInfo, increaseOnly, !isHorizontal, sizeType, extent, true);
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.ApplyAutoSize(resizeInfo, increaseOnly, !isHorizontal, sizeType, extent2, false);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00009898 File Offset: 0x00007A98
		private static void ApplyAutoSize(global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo resizeInfo, bool increaseOnly, bool isWidth, global::Infragistics.Windows.DataPresenter.ItemSizeType sizeType, double extent, bool label)
		{
			if (!double.IsNaN(extent))
			{
				if (increaseOnly)
				{
					global::Infragistics.Windows.DataPresenter.FieldSize size = resizeInfo.GetSize(label, isWidth);
					if (size.Type == sizeType)
					{
						extent = global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.Max(extent, size.Value);
					}
				}
				resizeInfo.SetSize(label, isWidth, new global::Infragistics.Windows.DataPresenter.FieldSize(extent, sizeType));
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000098E8 File Offset: 0x00007AE8
		private static global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope? GetAutoSizeScope(bool isHorz, global::Infragistics.Windows.DataPresenter.Field field, bool? isLabel)
		{
			global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope? result = null;
			if (field.GetWidthOrHeight(!isHorz).IsAuto)
			{
				bool flag = false;
				global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo explicitResizeInfoIfAllocated = field.ExplicitResizeInfoIfAllocated;
				if (explicitResizeInfoIfAllocated == null)
				{
					flag = true;
				}
				else
				{
					bool hasExplicitSize = explicitResizeInfoIfAllocated.GetSize(true, !isHorz).HasExplicitSize;
					bool hasExplicitSize2 = explicitResizeInfoIfAllocated.GetSize(false, !isHorz).HasExplicitSize;
					if (isLabel == null)
					{
						flag = (!hasExplicitSize2 || !hasExplicitSize);
					}
					else if (isLabel.Value && !hasExplicitSize)
					{
						flag = true;
					}
					else if (!isLabel.Value && !hasExplicitSize2)
					{
						flag = true;
					}
				}
				if (flag)
				{
					result = new global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope?(field.AutoSizeScopeResolved);
				}
			}
			return result;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000999C File Offset: 0x00007B9C
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> GetFieldList(global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope scope)
		{
			switch (scope)
			{
			case global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.RecordsInView:
				return this._recordsInViewFields;
			case global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.ViewableRecords:
				return this._viewableRecordFields;
			case global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.AllRecords:
				return this._allRecordFields;
			default:
				return this._recordsInViewFields;
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000099DC File Offset: 0x00007BDC
		private int GetMaxParameterCount(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType operationType)
		{
			switch (operationType)
			{
			case global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.Initial:
			case global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.RecordsInView:
				return 1;
			case global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.EditModeChange:
			case global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.LabelsChanged:
				return int.MaxValue;
			case global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.OutOfViewRecords:
			case global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.ViewableRecordsChanged:
			case global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.TraverseAllRecords:
				return this._maxPendingParameters;
			default:
				return 1;
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00009A1F File Offset: 0x00007C1F
		private bool HasPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType operationType)
		{
			return 0 != (this._pendingOperationTypes & 1 << (int)operationType);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00009A34 File Offset: 0x00007C34
		private void InitializeAutoSizedFieldsImpl(global::Infragistics.Windows.DataPresenter.RecordsInViewHelper recordsInViewHelper)
		{
			if (this._pendingInitialSizeFields.Count == 0)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Field[] array = this._pendingInitialSizeFields.ToArray();
			this._pendingInitialSizeFields.Clear();
			bool isHorizontal = this._owner.IsHorizontal;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			foreach (global::Infragistics.Windows.DataPresenter.Field field in array)
			{
				global::Infragistics.Windows.DataPresenter.FieldLength widthOrHeight = field.GetWidthOrHeight(!isHorizontal);
				field._hasPendingInitialAutoSize = false;
				if (widthOrHeight.IsAnyAuto && field.AutoSizeOptionsResolved != global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None)
				{
					list.Add(field);
				}
			}
			if (list.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
				int nestingDepth = global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetNestingDepth(this._owner);
				this.PerformAutoSize(isHorizontal, list, dataPresenter.Records, nestingDepth, null, true, global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.Initial, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.All, recordsInViewHelper);
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00009AF8 File Offset: 0x00007CF8
		private bool IsValid(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp)
		{
			return cvp != null && this.IsValid(cvp.Field) && this.IsValid(cvp.Record);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00009B20 File Offset: 0x00007D20
		private bool IsValid(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return field != null && field.Index >= 0 && field.Owner == this._owner;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00009B3E File Offset: 0x00007D3E
		private bool IsValid(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return record != null && record.IsStillValid;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00009B4B File Offset: 0x00007D4B
		private void OnRecordChanged(global::Infragistics.Windows.DataPresenter.Record recordContext)
		{
			if (this._hasOutOfViewAutoSizeFields)
			{
				this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.OutOfViewRecords, recordContext);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00009B60 File Offset: 0x00007D60
		private void OnRemoveField(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope fieldAutoSizeScope;
			if (this._scopes.TryGetValue(field, out fieldAutoSizeScope))
			{
				this._scopes.Remove(field);
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> fieldList = this.GetFieldList(fieldAutoSizeScope);
				fieldList.Remove(field);
				if (this._recordsInView != null && fieldAutoSizeScope == global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.RecordsInView)
				{
					this._recordsInView.Remove(field);
				}
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00009BB3 File Offset: 0x00007DB3
		private void OnViewableRecordChanged(global::Infragistics.Windows.DataPresenter.Record recordContext)
		{
			if (!this._hasViewableRecordFields && !this.DPHasViewableRecordFields)
			{
				return;
			}
			this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.ViewableRecordsChanged, recordContext);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00009BD0 File Offset: 0x00007DD0
		private void PerformAutoSize(bool isHorz, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> autoFields, global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, int recordManagerDepth, global::Infragistics.Windows.Helpers.HashSet recordsSubset, bool increaseOnly, global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType operationType, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions allowedOptions, global::Infragistics.Windows.DataPresenter.RecordsInViewHelper recordsInViewHelper)
		{
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper autoSizeFieldHelper = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper(autoFields, this._owner, allowedOptions);
			global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags flags = global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags.SkipEditCell;
			bool flag;
			if (operationType == global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.RecordsInView)
			{
				int version = this._owner.Fields.Version;
				if (this._lastFieldsVersion != version)
				{
					this._recordsInView = null;
				}
				this._lastFieldsVersion = version;
				flag = autoSizeFieldHelper.Calculate(flags, ref this._recordsInView, true, recordsInViewHelper);
			}
			else if (recordsSubset != null)
			{
				bool recursive = operationType == global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.ViewableRecordsChanged;
				global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> outOfViewRecords = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OutOfViewRecordEnumerable(recordsSubset);
				flag = autoSizeFieldHelper.Calculate(outOfViewRecords, recursive, this._owner.MaxRecordManagerDepth, flags);
			}
			else
			{
				flag = autoSizeFieldHelper.Calculate(records, recordManagerDepth, flags, recordsInViewHelper);
			}
			bool flag2 = operationType == global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.Initial;
			if (!flag && !flag2)
			{
				return;
			}
			foreach (global::Infragistics.Windows.DataPresenter.Field field in autoSizeFieldHelper.GetFields())
			{
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo = autoSizeFieldHelper.GetFieldInfo(field);
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.ApplyAutoSize(fieldInfo, field.ExplicitResizeInfo, increaseOnly, isHorz, global::Infragistics.Windows.DataPresenter.ItemSizeType.AutoMode);
				if (flag2 && double.IsNaN(fieldInfo.CellExtent) && (fieldInfo.Options & ~global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Label) != global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None)
				{
					if (field.GetWidthOrHeight(!isHorz).IsInitialAuto)
					{
						field._hasPendingInitialAutoSize = true;
						this._pendingInitialSizeFields.Add(field);
					}
				}
				else if (field._hasPendingInitialAutoSize && (!double.IsNaN(fieldInfo.CellExtent) || (fieldInfo.Options & ~global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Label) == global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None))
				{
					field._hasPendingInitialAutoSize = false;
					this._pendingInitialSizeFields.Remove(field);
				}
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00009D60 File Offset: 0x00007F60
		private void ProcessEditCellValueChanged(global::Infragistics.Windows.Helpers.HashSet editChangeInfo)
		{
			if (editChangeInfo == null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
				if (dataPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = dataPresenter.EditHelper.CellValuePresenter;
					global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo preEditAutoSize = dataPresenter.EditHelper.PreEditAutoSize;
					if (preEditAutoSize != null && this.IsValid(cellValuePresenter))
					{
						this.ProcessEditCellValueChanged(cellValuePresenter, preEditAutoSize);
						return;
					}
				}
			}
			else
			{
				foreach (object obj in editChangeInfo)
				{
					global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.EditModeChangeInfo editModeChangeInfo = (global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.EditModeChangeInfo)obj;
					this.ProcessEditCellValueChanged(editModeChangeInfo.CVP, editModeChangeInfo.PreEditAutoSize);
				}
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00009E08 File Offset: 0x00008008
		private void ProcessEditCellValueChanged(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp, global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo preEditAutoSize)
		{
			global::Infragistics.Windows.DataPresenter.Field field = cvp.Field;
			if (!this.IsValid(cvp))
			{
				return;
			}
			bool isHorizontal = this._owner.IsHorizontal;
			if (!this.IsInAutoSizeMode(field, false))
			{
				return;
			}
			cvp.UpdateLayout();
			cvp.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
			global::System.Windows.Size desiredSize = cvp.DesiredSize;
			double extent = isHorizontal ? desiredSize.Height : desiredSize.Width;
			cvp.InvalidateMeasure();
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo(field);
			fieldInfo.AddCellExtent(preEditAutoSize.GetSize(false, !isHorizontal).Value);
			fieldInfo.AddLabelExtent(preEditAutoSize.GetSize(true, !isHorizontal).Value);
			fieldInfo.AddCellExtent(extent);
			fieldInfo.RoundExtents();
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.ApplyAutoSize(fieldInfo, field.ExplicitResizeInfo, false, isHorizontal, global::Infragistics.Windows.DataPresenter.ItemSizeType.AutoMode);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00009ED8 File Offset: 0x000080D8
		private void TransferViewableRecords(global::Infragistics.Windows.Helpers.HashSet records)
		{
			if (this._owner.Fields.ExpandableFieldsCount > 0)
			{
				global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout>> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout>>();
				global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout = this._owner.ParentFieldLayout;
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this._owner.DataPresenter.FieldLayouts)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout2 = fieldLayout.ParentFieldLayout;
					if (parentFieldLayout2 != null && parentFieldLayout2 != parentFieldLayout)
					{
						global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout> list;
						if (!dictionary.TryGetValue(parentFieldLayout2, out list))
						{
							list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout>();
							dictionary[parentFieldLayout2] = list;
						}
						list.Add(fieldLayout);
					}
				}
				if (dictionary.Count == 0)
				{
					return;
				}
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout>();
				this.AddViewableRecordFieldLayouts(this._owner, list2, dictionary);
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 in list2)
				{
					fieldLayout2.AutoSizeInfo.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.ViewableRecordsChanged, records);
				}
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00009FEC File Offset: 0x000081EC
		private void VerifyFixedFieldInfo()
		{
			this._fixedFieldVersion = this._owner.FixedFieldVersion;
			int num = 0;
			if (this._recordsInViewFields != null)
			{
				int i = 0;
				int count = this._recordsInViewFields.Count;
				while (i < count)
				{
					if (this._recordsInViewFields[i].FixedLocation != global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
					{
						num++;
					}
					i++;
				}
			}
			this._fixedRecordInViewFieldCount = num;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000A064 File Offset: 0x00008264
		internal static global::Infragistics.Windows.Helpers.HashSet GetAutoSizeFieldLayouts(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
		{
			new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout>>();
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = dp.RecordManager.FieldLayout;
			global::System.Predicate<global::Infragistics.Windows.DataPresenter.FieldLayout> predicate = delegate(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
			{
				fl.AutoSizeInfo.Verify();
				return fl.AutoSizeInfo._hasOutOfViewAutoSizeFields;
			};
			global::Infragistics.Windows.Helpers.HashSet fieldLayoutsInUse = global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.GetFieldLayoutsInUse(dp, new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteria_Predicate<global::Infragistics.Windows.DataPresenter.FieldLayout>(predicate));
			global::Infragistics.Windows.Helpers.HashSet fieldLayoutsInUse2 = global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.GetFieldLayoutsInUse(dp, null);
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
			foreach (object obj in fieldLayoutsInUse)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = (global::Infragistics.Windows.DataPresenter.FieldLayout)obj;
				if (!hashSet.Exists(fieldLayout2))
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout = fieldLayout2.ParentFieldLayout;
					while (parentFieldLayout != null && fieldLayoutsInUse2.Exists(parentFieldLayout) && !hashSet.Exists(parentFieldLayout))
					{
						hashSet.Add(parentFieldLayout);
						parentFieldLayout = parentFieldLayout.ParentFieldLayout;
					}
				}
			}
			return hashSet;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000A144 File Offset: 0x00008344
		internal static global::Infragistics.Windows.Helpers.HashSet GetFieldLayoutsInUse(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria criteria)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = dp.RecordManager.FieldLayout;
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 in dp.FieldLayouts)
			{
				if ((fieldLayout2.IsInitialRecordLoaded || fieldLayout2 == fieldLayout) && (criteria == null || criteria.MeetsCriteria(fieldLayout2)))
				{
					hashSet.Add(fieldLayout2);
				}
			}
			return hashSet;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000A1BC File Offset: 0x000083BC
		internal bool IsInAutoSizeMode(global::Infragistics.Windows.DataPresenter.Field field, bool isLabel)
		{
			bool width = !this._owner.IsHorizontal;
			return global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.IsInAutoSizeMode(field, isLabel, width);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000A1E0 File Offset: 0x000083E0
		internal static bool IsInAutoSizeMode(global::Infragistics.Windows.DataPresenter.Field field, bool isLabel, bool width)
		{
			return field.GetWidthOrHeight(width).IsAuto && !field.GetResizeSize(isLabel, width).HasExplicitSize;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000A215 File Offset: 0x00008415
		internal void OnAutoSizeSettingsChanged()
		{
			if (this._layoutManagerVersion == this._owner.LayoutManagerVersion)
			{
				this._layoutManagerVersion--;
				this._lastTemplateVersion--;
				this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.Initial);
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000A24D File Offset: 0x0000844D
		internal void OnCellPanelChange(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel cellPanel)
		{
			if (this._pendingInitialSizeFields.Count > 0)
			{
				this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.Initial);
			}
			if (this._recordsInViewFields.Count > this._fixedRecordInViewFieldCount)
			{
				this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.RecordsInView);
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000A280 File Offset: 0x00008480
		internal void OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType dataChangeType, global::Infragistics.Windows.DataPresenter.DataRecord recordContext, global::Infragistics.Windows.DataPresenter.Field fieldContext, global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			switch (dataChangeType)
			{
			case global::Infragistics.Windows.DataPresenter.DataChangeType.Reset:
				rm.FieldAutoSizeVersion++;
				if (this.DPMaxAutoSizeAllRecordsDepth > rm.NestingDepth)
				{
					this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.TraverseAllRecords, rm);
				}
				if (this._hasOutOfViewAutoSizeFields)
				{
					this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.OutOfViewRecords, rm);
					return;
				}
				break;
			case global::Infragistics.Windows.DataPresenter.DataChangeType.CellDataChange:
			case global::Infragistics.Windows.DataPresenter.DataChangeType.RecordDataChange:
			{
				if (fieldContext != null && fieldContext.IsExpandableByDefault && fieldContext.IsExpandableResolved)
				{
					if (recordContext != null && fieldContext.VisibilityResolved != global::System.Windows.Visibility.Collapsed)
					{
						this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.TraverseAllRecords, new global::Infragistics.Windows.DataPresenter.CellKey(recordContext, fieldContext));
					}
					return;
				}
				if (this._autoSizeCount == 0)
				{
					return;
				}
				bool isHorizontal = this._owner.IsHorizontal;
				if (fieldContext != null && !fieldContext.GetWidthOrHeight(!isHorizontal).IsAuto)
				{
					return;
				}
				if (recordContext != null)
				{
					this.OnDataChanged(recordContext, fieldContext);
				}
				break;
			}
			case global::Infragistics.Windows.DataPresenter.DataChangeType.AddRecord:
				if (this.DPMaxAutoSizeAllRecordsDepth > rm.NestingDepth)
				{
					this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.TraverseAllRecords, recordContext);
				}
				if (this._hasOutOfViewAutoSizeFields)
				{
					this.OnRecordChanged(recordContext);
					return;
				}
				break;
			default:
				return;
			case global::Infragistics.Windows.DataPresenter.DataChangeType.Unknown:
				break;
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000A380 File Offset: 0x00008580
		private void OnDataChanged(global::Infragistics.Windows.DataPresenter.DataRecord recordContext, global::Infragistics.Windows.DataPresenter.Field fieldContext)
		{
			if (this._recordsInView != null && this._recordsInView.Remove(recordContext, fieldContext))
			{
				this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.RecordsInView);
			}
			global::Infragistics.Windows.DataPresenter.CellCollection cells = recordContext.Cells;
			if (fieldContext != null)
			{
				cells[fieldContext].DirtyFieldAutoSizeVersion();
			}
			else
			{
				cells.DirtyFieldAutoSizeVersion();
			}
			this.OnRecordChanged(recordContext);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000A3D0 File Offset: 0x000085D0
		internal void OnEditCellValueChanged(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp, global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo preEditAutoSize)
		{
			if (preEditAutoSize == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Field field = cvp.Field;
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			if (!field.GetWidthOrHeight(!owner.IsHorizontal).IsAuto)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions cellOption = global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetCellOption(cvp.Record, cvp.Field);
			if ((field.GetCurrentAutoSizeOptions() & cellOption) == global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None)
			{
				return;
			}
			this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.EditModeChange, new global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.EditModeChangeInfo
			{
				CVP = cvp,
				PreEditAutoSize = preEditAutoSize
			});
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000A44C File Offset: 0x0000864C
		internal void OnFieldElementDesiredSizeChanged(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._recordsInView != null && this._recordsInView.Remove(record, field))
			{
				this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.RecordsInView);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000A46C File Offset: 0x0000866C
		internal void OnFilterCellChanged(global::Infragistics.Windows.DataPresenter.FilterCell cell)
		{
			if (this._autoSizeCount == 0)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataRecord record = cell.Record;
			cell.DirtyFieldAutoSizeVersion();
			if (this._recordsInView != null && this._recordsInView.Remove(record, cell.Field))
			{
				this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.RecordsInView);
			}
			this.OnRecordChanged(record);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000A4BC File Offset: 0x000086BC
		internal void OnLabelChanged(global::Infragistics.Windows.DataPresenter.Field f)
		{
			if (this._autoSizeCount == 0)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope fieldAutoSizeScope;
			if (this._scopes.TryGetValue(f, out fieldAutoSizeScope))
			{
				this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.LabelsChanged, f);
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000A4EC File Offset: 0x000086EC
		internal void OnMaxDepthChanged()
		{
			if (this._hasAllRecordFields)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
				if (dataPresenter != null && dataPresenter.AllRecordsAutoSizeMaxDepth < this._owner.MaxRecordManagerDepth)
				{
					dataPresenter.ResetAllRecordsAutoSizeMaxDepth();
				}
			}
			if (this._hasOutOfViewAutoSizeFields)
			{
				this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.OutOfViewRecords);
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000A538 File Offset: 0x00008738
		internal void OnRecordExpanded(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record.IsExpanded)
			{
				this.OnViewableRecordChanged(record);
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000A549 File Offset: 0x00008749
		internal void OnRecordsInViewChanged()
		{
			if (this._hasRecordsInViewFields)
			{
				this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.RecordsInView);
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000A55A File Offset: 0x0000875A
		internal void OnRecordVisibilityChanged(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record.GetVisibilityResolved(false) != global::System.Windows.Visibility.Collapsed)
			{
				this.OnViewableRecordChanged(record);
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000A570 File Offset: 0x00008770
		internal void OnSummaryChanged(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			if (this._autoSizeCount == 0)
			{
				return;
			}
			summaryResult.FieldAutoSizeVersion--;
			if (this._recordsInView != null && this._recordsInView.Remove(global::Infragistics.Windows.DataPresenter.RecordType.SummaryRecord))
			{
				this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.RecordsInView);
			}
			if (this._hasOutOfViewAutoSizeFields)
			{
				global::Infragistics.Windows.DataPresenter.Field positionFieldResolved = summaryResult.PositionFieldResolved;
				global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope fieldAutoSizeScope;
				if (positionFieldResolved != null && this.IsInAutoSizeMode(positionFieldResolved, false) && this._scopes.TryGetValue(positionFieldResolved, out fieldAutoSizeScope) && fieldAutoSizeScope != global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.RecordsInView && (positionFieldResolved.AutoSizeOptionsResolved & global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Summaries) != global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None)
				{
					this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.OutOfViewRecords, summaryResult.ParentCollection);
				}
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000A5F8 File Offset: 0x000087F8
		internal static void ProcessPendingOperations(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout> pendingAutoSize, global::Infragistics.Windows.DataPresenter.RecordsInViewHelper recordsInViewHelper)
		{
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in pendingAutoSize)
			{
				fieldLayout.AutoSizeInfo.ProcessPendingOperationsImpl(recordsInViewHelper);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000A64C File Offset: 0x0000884C
		private void ProcessPendingOperationsImpl(global::Infragistics.Windows.DataPresenter.RecordsInViewHelper recordsInViewHelper)
		{
			this.Verify();
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.AutoSizeFieldOperation[] pendingOperations = this._pendingOperations;
			this._pendingOperations = null;
			this._pendingOperationTypes = 0;
			foreach (global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.AutoSizeFieldOperation autoSizeFieldOperation in pendingOperations)
			{
				if (autoSizeFieldOperation != null)
				{
					switch (autoSizeFieldOperation.OperationType)
					{
					case global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.Initial:
						this.InitializeAutoSizedFieldsImpl(recordsInViewHelper);
						break;
					case global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.RecordsInView:
						this.PerformAutoSize(this._owner.IsHorizontal, this._recordsInViewFields, null, 0, null, true, global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.RecordsInView, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.All, recordsInViewHelper);
						break;
					case global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.EditModeChange:
						this.ProcessEditCellValueChanged(autoSizeFieldOperation.Parameters);
						break;
					case global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.OutOfViewRecords:
						this.PerformAutoSize(this._owner.IsHorizontal, new global::Infragistics.Windows.DataPresenter.GridUtilities.AggregateEnumerable<global::Infragistics.Windows.DataPresenter.Field>(new global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field>[]
						{
							this._allRecordFields,
							this._viewableRecordFields
						}), null, this._owner.MaxRecordManagerDepth, autoSizeFieldOperation.Parameters, true, global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.OutOfViewRecords, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.All, null);
						break;
					case global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.ViewableRecordsChanged:
						this.PerformAutoSize(this._owner.IsHorizontal, this._viewableRecordFields, null, this._owner.MaxRecordManagerDepth, autoSizeFieldOperation.Parameters, true, global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.ViewableRecordsChanged, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.All, null);
						break;
					case global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.LabelsChanged:
					{
						global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> autoFields;
						if (autoSizeFieldOperation.Parameters != null)
						{
							autoFields = new global::Infragistics.Collections.TypedEnumerable<global::Infragistics.Windows.DataPresenter.Field>(autoSizeFieldOperation.Parameters);
						}
						else
						{
							autoFields = new global::Infragistics.Windows.DataPresenter.GridUtilities.AggregateEnumerable<global::Infragistics.Windows.DataPresenter.Field>(new global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field>[]
							{
								this._recordsInViewFields,
								this._allRecordFields,
								this._viewableRecordFields
							});
						}
						this.PerformAutoSize(this._owner.IsHorizontal, autoFields, null, 0, null, true, global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.LabelsChanged, global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Label, null);
						break;
					}
					}
				}
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000A7E0 File Offset: 0x000089E0
		internal static void TransferViewableRecords(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout> autoSizePendingList)
		{
			if (!global::Infragistics.Windows.DataPresenter.GridUtilities.HasItems(autoSizePendingList))
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout[] array = autoSizePendingList.ToArray();
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in array)
			{
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo autoSizeInfo = fieldLayout.AutoSizeInfo;
				if (autoSizeInfo.HasPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.ViewableRecordsChanged))
				{
					global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.AutoSizeFieldOperation autoSizeFieldOperation = autoSizeInfo._pendingOperations[4];
					if (autoSizeFieldOperation.Parameters != null)
					{
						autoSizeInfo.TransferViewableRecords(autoSizeFieldOperation.Parameters);
					}
				}
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000A846 File Offset: 0x00008A46
		internal void Verify()
		{
			if (this._layoutManagerVersion == this._owner.LayoutManagerVersion)
			{
				if (this._fixedFieldVersion != this._owner.FixedFieldVersion)
				{
					this.VerifyFixedFieldInfo();
				}
				return;
			}
			this.VerifyImpl();
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000A87C File Offset: 0x00008A7C
		private void VerifyImpl()
		{
			this._layoutManagerVersion = this._owner.LayoutManagerVersion;
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings>();
			this._pendingInitialSizeFields.Clear();
			this._autoSizeCount = 0;
			bool flag = this._lastTemplateVersion != this._owner.TemplateVersion;
			if (flag)
			{
				this._lastTemplateVersion = this._owner.TemplateVersion;
				this._recordsInView = null;
				foreach (global::Infragistics.Windows.DataPresenter.Field field in this._owner.Fields)
				{
					field.AutoSizeVersion++;
				}
			}
			int version = this._owner.Fields.Version;
			bool flag2 = this._lastFieldsVersion != this._owner.Fields.Version;
			if (flag2)
			{
				this._lastFieldsVersion = version;
				this._recordsInView = null;
				global::Infragistics.Windows.DataPresenter.Field[] array = new global::Infragistics.Windows.DataPresenter.Field[this._scopes.Count];
				this._scopes.Keys.CopyTo(array, 0);
				foreach (global::Infragistics.Windows.DataPresenter.Field field2 in array)
				{
					if (!this.IsValid(field2))
					{
						this.OnRemoveField(field2);
					}
				}
			}
			bool isHorizontal = this._owner.IsHorizontal;
			foreach (global::Infragistics.Windows.DataPresenter.Field field3 in this._owner.Fields)
			{
				if (field3.VisibilityResolved == global::System.Windows.Visibility.Collapsed)
				{
					this.OnRemoveField(field3);
				}
				else
				{
					if (field3._hasPendingInitialAutoSize)
					{
						this._pendingInitialSizeFields.Add(field3);
					}
					global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope? autoSizeScope = global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.GetAutoSizeScope(isHorizontal, field3, null);
					if (autoSizeScope == null)
					{
						this.OnRemoveField(field3);
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope value = autoSizeScope.Value;
						this._autoSizeCount++;
						global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope fieldAutoSizeScope;
						if (this._scopes.TryGetValue(field3, out fieldAutoSizeScope))
						{
							if (value == fieldAutoSizeScope)
							{
								continue;
							}
							this.OnRemoveField(field3);
						}
						field3.AutoSizeVersion++;
						this._scopes[field3] = value;
						this.GetFieldList(value).Add(field3);
						if (value != global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.RecordsInView)
						{
							dictionary[field3] = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings(field3);
						}
					}
				}
			}
			this._hasOutOfViewAutoSizeFields = (this._allRecordFields.Count > 0 || this._viewableRecordFields.Count > 0);
			this.HasViewableRecordFields = (this._viewableRecordFields.Count > 0);
			this.HasRecordsInViewFields = (this._recordsInViewFields.Count > 0);
			this.HasAllRecordFields = (this._allRecordFields.Count > 0);
			if (this._pendingInitialSizeFields.Count > 0)
			{
				this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.Initial);
			}
			if (this._recordsInViewFields.Count > 0)
			{
				this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.RecordsInView);
			}
			if ((dictionary.Count > 0 || flag) && this._hasOutOfViewAutoSizeFields)
			{
				this.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.OutOfViewRecords);
			}
			this.VerifyFixedFieldInfo();
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000ABBC File Offset: 0x00008DBC
		internal static void WalkAllRecordItems(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout> autoSizePendingList)
		{
			if (!global::Infragistics.Windows.DataPresenter.GridUtilities.HasItems(autoSizePendingList))
			{
				return;
			}
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = autoSizePendingList[0].DataPresenter;
			if (dataPresenter == null)
			{
				return;
			}
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in autoSizePendingList)
			{
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo autoSizeInfo = fieldLayout.AutoSizeInfo;
				if (autoSizeInfo.HasPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.TraverseAllRecords))
				{
					global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.AutoSizeFieldOperation autoSizeFieldOperation = autoSizeInfo._pendingOperations[6];
					if (autoSizeFieldOperation.Parameters != null)
					{
						hashSet.AddItems(autoSizeFieldOperation.Parameters);
					}
					else
					{
						autoSizeInfo.AddPendingOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType.OutOfViewRecords);
					}
					autoSizeInfo._pendingOperations[6] = null;
					autoSizeInfo._pendingOperationTypes &= -65;
				}
			}
			if (hashSet.Count == 0)
			{
				return;
			}
			global::Infragistics.Windows.Helpers.HashSet hashSet2 = new global::Infragistics.Windows.Helpers.HashSet();
			global::Infragistics.Windows.Helpers.HashSet autoSizeFieldLayouts = global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.GetAutoSizeFieldLayouts(dataPresenter);
			foreach (object obj in hashSet)
			{
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager = obj as global::Infragistics.Windows.DataPresenter.RecordManager;
				if (recordManager != null)
				{
					if (autoSizeFieldLayouts.Exists(recordManager.FieldLayout))
					{
						hashSet2.Add(recordManager);
					}
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = obj as global::Infragistics.Windows.DataPresenter.DataRecord;
					if (dataRecord != null)
					{
						if (!dataRecord.HasChildrenInternal)
						{
							continue;
						}
						using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord> enumerator3 = dataRecord.ChildRecords.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = enumerator3.Current;
								if (autoSizeFieldLayouts.Exists(expandableFieldRecord.FieldLayout))
								{
									global::Infragistics.Windows.DataPresenter.RecordManager childRecordManagerIfNeeded = expandableFieldRecord.ChildRecordManagerIfNeeded;
									if (childRecordManagerIfNeeded != null)
									{
										hashSet2.Add(childRecordManagerIfNeeded);
									}
								}
							}
							continue;
						}
					}
					if (obj is global::Infragistics.Windows.DataPresenter.CellKey)
					{
						global::Infragistics.Windows.DataPresenter.CellKey cellKey = (global::Infragistics.Windows.DataPresenter.CellKey)obj;
						int num = cellKey.Record.ChildRecords.IndexOf(cellKey.Field);
						if (num >= 0)
						{
							global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord2 = cellKey.Record.ChildRecords[num];
							if (autoSizeFieldLayouts.Exists(expandableFieldRecord2.FieldLayout))
							{
								global::Infragistics.Windows.DataPresenter.RecordManager childRecordManagerIfNeeded2 = expandableFieldRecord2.ChildRecordManagerIfNeeded;
								if (childRecordManagerIfNeeded2 != null)
								{
									hashSet2.Add(childRecordManagerIfNeeded2);
								}
							}
						}
					}
				}
			}
			if (hashSet2.Count == 0)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager[] array = hashSet2.ToArray<global::Infragistics.Windows.DataPresenter.RecordManager>();
			global::System.Comparison<global::Infragistics.Windows.DataPresenter.RecordManager> comparison = (global::Infragistics.Windows.DataPresenter.RecordManager rm1, global::Infragistics.Windows.DataPresenter.RecordManager rm2) => rm1.NestingDepth.CompareTo(rm2.NestingDepth);
			global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Windows.DataPresenter.RecordManager>(array, global::Infragistics.CoreUtilities.CreateComparer<global::Infragistics.Windows.DataPresenter.RecordManager>(comparison));
			int nestingDepth = array[0].NestingDepth;
			int allRecordsAutoSizeMaxDepth = dataPresenter.AllRecordsAutoSizeMaxDepth;
			foreach (global::Infragistics.Windows.DataPresenter.RecordManager recordManager2 in array)
			{
				int nestingDepth2 = recordManager2.NestingDepth;
				if (nestingDepth2 != allRecordsAutoSizeMaxDepth)
				{
					if (nestingDepth != nestingDepth2)
					{
						bool flag = false;
						for (int j = nestingDepth2; j > nestingDepth; j--)
						{
							if (hashSet2.Exists(recordManager2.ParentDataRecord.RecordManager))
							{
								flag = true;
								break;
							}
						}
						if (flag)
						{
							goto IL_2A8;
						}
					}
					global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.WalkAllRecordItems(recordManager2, allRecordsAutoSizeMaxDepth, autoSizeFieldLayouts);
				}
				IL_2A8:;
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000AECC File Offset: 0x000090CC
		private static void WalkAllRecordItems(global::Infragistics.Windows.DataPresenter.RecordManager rm, int maxRecordManagerDepth, global::Infragistics.Windows.Helpers.HashSet fieldLayoutsToTraverse)
		{
			if (rm.NestingDepth == maxRecordManagerDepth)
			{
				return;
			}
			foreach (global::Infragistics.Windows.DataPresenter.DataRecord dataRecord in rm.Unsorted)
			{
				if (dataRecord.HasChildrenInternal)
				{
					foreach (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord in dataRecord.ChildRecords)
					{
						if (fieldLayoutsToTraverse.Exists(expandableFieldRecord.FieldLayout))
						{
							global::Infragistics.Windows.DataPresenter.RecordManager childRecordManagerIfNeeded = expandableFieldRecord.ChildRecordManagerIfNeeded;
							if (childRecordManagerIfNeeded != null)
							{
								global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.WalkAllRecordItems(childRecordManagerIfNeeded, maxRecordManagerDepth, fieldLayoutsToTraverse);
							}
						}
					}
				}
			}
		}

		// Token: 0x04000085 RID: 133
		private const bool DebugAutoSize = false;

		// Token: 0x04000086 RID: 134
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _recordsInViewFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();

		// Token: 0x04000087 RID: 135
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _allRecordFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();

		// Token: 0x04000088 RID: 136
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _viewableRecordFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();

		// Token: 0x04000089 RID: 137
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _pendingInitialSizeFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();

		// Token: 0x0400008A RID: 138
		private global::Infragistics.Windows.DataPresenter.FieldLayout _owner;

		// Token: 0x0400008B RID: 139
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope> _scopes = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope>();

		// Token: 0x0400008C RID: 140
		internal static readonly int OperationTypeCount = global::System.Enum.GetValues(typeof(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType)).Length;

		// Token: 0x0400008D RID: 141
		private global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.AutoSizeFieldOperation[] _pendingOperations;

		// Token: 0x0400008E RID: 142
		private int _pendingOperationTypes;

		// Token: 0x0400008F RID: 143
		private global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.RecordFieldList _recordsInView;

		// Token: 0x04000090 RID: 144
		private int _layoutManagerVersion = -1;

		// Token: 0x04000091 RID: 145
		private int _lastFieldsVersion;

		// Token: 0x04000092 RID: 146
		private int _lastTemplateVersion;

		// Token: 0x04000093 RID: 147
		private int _autoSizeCount;

		// Token: 0x04000094 RID: 148
		private bool _hasOutOfViewAutoSizeFields;

		// Token: 0x04000095 RID: 149
		private bool _hasViewableRecordFields;

		// Token: 0x04000096 RID: 150
		private bool _hasAllRecordFields;

		// Token: 0x04000097 RID: 151
		private int _maxPendingParameters = -1;

		// Token: 0x04000098 RID: 152
		private int _fixedRecordInViewFieldCount;

		// Token: 0x04000099 RID: 153
		private int _fixedFieldVersion = -1;

		// Token: 0x0400009A RID: 154
		private bool _hasRecordsInViewFields;

		// Token: 0x0200003B RID: 59
		internal enum OperationType
		{
			// Token: 0x0400009E RID: 158
			Initial,
			// Token: 0x0400009F RID: 159
			RecordsInView,
			// Token: 0x040000A0 RID: 160
			EditModeChange,
			// Token: 0x040000A1 RID: 161
			OutOfViewRecords,
			// Token: 0x040000A2 RID: 162
			ViewableRecordsChanged,
			// Token: 0x040000A3 RID: 163
			LabelsChanged,
			// Token: 0x040000A4 RID: 164
			TraverseAllRecords
		}

		// Token: 0x0200003C RID: 60
		internal class AutoSizeFieldOperation
		{
			// Token: 0x06000282 RID: 642 RVA: 0x0000AF80 File Offset: 0x00009180
			internal AutoSizeFieldOperation(global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType operationType)
			{
				this.OperationType = operationType;
			}

			// Token: 0x040000A5 RID: 165
			internal global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OperationType OperationType;

			// Token: 0x040000A6 RID: 166
			internal global::Infragistics.Windows.Helpers.HashSet Parameters;
		}

		// Token: 0x0200003D RID: 61
		internal struct EditModeChangeInfo
		{
			// Token: 0x040000A7 RID: 167
			internal global::Infragistics.Windows.DataPresenter.CellValuePresenter CVP;

			// Token: 0x040000A8 RID: 168
			internal global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo PreEditAutoSize;
		}

		// Token: 0x0200003E RID: 62
		private class OutOfViewRecordEnumerable : global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000283 RID: 643 RVA: 0x0000AF8F File Offset: 0x0000918F
			internal OutOfViewRecordEnumerable(global::Infragistics.Windows.Helpers.HashSet items)
			{
				this._items = items;
			}

			// Token: 0x06000284 RID: 644 RVA: 0x0000AF9E File Offset: 0x0000919E
			public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> GetEnumerator()
			{
				return new global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.OutOfViewRecordEnumerable.Enumerator(this._items.GetEnumerator());
			}

			// Token: 0x06000285 RID: 645 RVA: 0x0000AFB0 File Offset: 0x000091B0
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x040000A9 RID: 169
			private global::Infragistics.Windows.Helpers.HashSet _items;

			// Token: 0x0200003F RID: 63
			private class Enumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x06000286 RID: 646 RVA: 0x0000AFB8 File Offset: 0x000091B8
				internal Enumerator(global::System.Collections.IEnumerator enumerator)
				{
					this._enumerator = enumerator;
					this.Reset();
				}

				// Token: 0x17000080 RID: 128
				// (get) Token: 0x06000287 RID: 647 RVA: 0x0000AFCD File Offset: 0x000091CD
				public global::Infragistics.Windows.DataPresenter.Record Current
				{
					get
					{
						return this._currentRecord;
					}
				}

				// Token: 0x06000288 RID: 648 RVA: 0x0000AFD5 File Offset: 0x000091D5
				public void Dispose()
				{
				}

				// Token: 0x17000081 RID: 129
				// (get) Token: 0x06000289 RID: 649 RVA: 0x0000AFD7 File Offset: 0x000091D7
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this._currentRecord;
					}
				}

				// Token: 0x0600028A RID: 650 RVA: 0x0000AFE0 File Offset: 0x000091E0
				public bool MoveNext()
				{
					if (this._currentEnumerator != null)
					{
						if (this._currentEnumerator.MoveNext())
						{
							this._currentRecord = (this._currentEnumerator.Current as global::Infragistics.Windows.DataPresenter.Record);
							return true;
						}
						this._currentEnumerator = null;
					}
					while (this._enumerator.MoveNext())
					{
						object obj = this._enumerator.Current;
						this._currentRecord = (obj as global::Infragistics.Windows.DataPresenter.Record);
						if (this._currentRecord != null)
						{
							return true;
						}
						if (obj is global::Infragistics.Windows.DataPresenter.RecordManager)
						{
							global::Infragistics.Windows.DataPresenter.RecordManager recordManager = obj as global::Infragistics.Windows.DataPresenter.RecordManager;
							this._currentEnumerator = recordManager.Unsorted.GetEnumerator();
						}
						else
						{
							if (!(obj is global::Infragistics.Windows.DataPresenter.SummaryResultCollection))
							{
								continue;
							}
							global::Infragistics.Windows.DataPresenter.SummaryResultCollection summaryResultCollection = (global::Infragistics.Windows.DataPresenter.SummaryResultCollection)obj;
							global::Infragistics.Windows.DataPresenter.RecordCollectionBase records = summaryResultCollection.Records;
							if (records != null)
							{
								this._currentEnumerator = records.GetSpecialRecords().GetEnumerator();
							}
						}
						if (this._currentEnumerator != null && this._currentEnumerator.MoveNext())
						{
							this._currentRecord = (this._currentEnumerator.Current as global::Infragistics.Windows.DataPresenter.Record);
							return true;
						}
					}
					this._currentRecord = null;
					return false;
				}

				// Token: 0x0600028B RID: 651 RVA: 0x0000B0DC File Offset: 0x000092DC
				public void Reset()
				{
					this._currentEnumerator = null;
					this._currentRecord = null;
				}

				// Token: 0x040000AA RID: 170
				private global::System.Collections.IEnumerator _enumerator;

				// Token: 0x040000AB RID: 171
				private global::System.Collections.IEnumerator _currentEnumerator;

				// Token: 0x040000AC RID: 172
				private global::Infragistics.Windows.DataPresenter.Record _currentRecord;
			}
		}
	}
}
