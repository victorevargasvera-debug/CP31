using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200006A RID: 106
	internal class UndeleteRecordsAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x060005A4 RID: 1444 RVA: 0x000157C3 File Offset: 0x000139C3
		internal UndeleteRecordsAction(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo> oldRecords, global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy strategy) : base(dp)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(oldRecords);
			this._oldRecords = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>(oldRecords);
			this._strategy = strategy;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000157E8 File Offset: 0x000139E8
		protected internal override void AddUndeleteDescendantInfo(global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo)
		{
			foreach (global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo recordInfo in this._oldRecords)
			{
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager = recordInfo.RecordManager;
				if (recordManager != null)
				{
					descendantInfo.AddRecord(recordManager.ParentRecord);
				}
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00015848 File Offset: 0x00013A48
		protected internal sealed override bool CanPerform(object context)
		{
			return this._strategy != null && this._strategy.CanUndelete(this._oldRecords);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00015868 File Offset: 0x00013A68
		protected internal override void OnRecordsUndeleted(global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> oldDataTimeToRecords)
		{
			foreach (global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo recordInfo in this._oldRecords)
			{
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager = recordInfo.RecordManager;
				if (recordManager != null)
				{
					global::Infragistics.Windows.DataPresenter.Field field = recordManager.Field;
					if (global::Infragistics.Windows.DataPresenter.DataPresenterAction.IsValid(field))
					{
						global::Infragistics.Windows.DataPresenter.DataRecord parentDataRecord = recordManager.ParentDataRecord;
						object dataItem = parentDataRecord.DataItem;
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
						if (dataItem != null && oldDataTimeToRecords.TryGetValue(dataItem, out dataRecord) && dataRecord.FieldLayout == field.Owner)
						{
							global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = dataRecord.ChildRecords[field];
							recordInfo.RecordManager = expandableFieldRecord.ChildRecordManager;
						}
					}
				}
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00015918 File Offset: 0x00013B18
		protected internal sealed override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			if (!this.CanPerform(context))
			{
				return null;
			}
			global::System.Collections.Generic.IDictionary<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo, object> dictionary = this._strategy.Undelete(this._oldRecords);
			if (dictionary == null || dictionary.Count == 0)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>();
			global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> dictionary2 = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord>();
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordManager, global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>> dictionary3 = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordManager, global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>>();
			foreach (global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo recordInfo in this._oldRecords)
			{
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager = recordInfo.RecordManager;
				object obj;
				if (recordManager != null && recordManager.List != null && dictionary.TryGetValue(recordInfo, out obj) && obj != null)
				{
					global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo> dictionary4;
					if (!dictionary3.TryGetValue(recordManager, out dictionary4))
					{
						dictionary4 = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>();
						dictionary3[recordManager] = dictionary4;
					}
					dictionary4[obj] = recordInfo;
				}
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.RecordManager, global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>> keyValuePair in dictionary3)
			{
				global::Infragistics.Windows.DataPresenter.RecordManager key = keyValuePair.Key;
				global::System.Collections.IList list2 = key.List;
				global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo> value = keyValuePair.Value;
				global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord> unsorted = key.Unsorted;
				object[] array = new object[keyValuePair.Value.Keys.Count];
				keyValuePair.Value.Keys.CopyTo(array, 0);
				foreach (object obj2 in array)
				{
					global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo recordInfo2 = value[obj2];
					int dataItemIndex = recordInfo2.DataItemIndex;
					if (dataItemIndex >= 0 && dataItemIndex < list2.Count && global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsSameDataItem(obj2, list2[dataItemIndex]))
					{
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = unsorted[dataItemIndex];
						list.Add(dataRecord);
						dictionary2[recordInfo2.DataItem] = dataRecord;
						value.Remove(obj2);
						if (recordInfo2.Children != null)
						{
							global::Infragistics.Windows.DataPresenter.UndeleteRecordsAction.ProcessDescendants(this._strategy, dictionary2, dataRecord, recordInfo2.Children);
						}
					}
				}
				if (value.Count != 0)
				{
					for (int j = list2.Count - 1; j >= 0; j--)
					{
						object obj3 = list2[j];
						global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo recordInfo3;
						if (obj3 != null && value.TryGetValue(obj3, out recordInfo3))
						{
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = unsorted[j];
							list.Add(dataRecord2);
							dictionary2[recordInfo3.DataItem] = dataRecord2;
							value.Remove(obj3);
							if (recordInfo3.Children != null)
							{
								global::Infragistics.Windows.DataPresenter.UndeleteRecordsAction.ProcessDescendants(this._strategy, dictionary2, dataRecord2, recordInfo3.Children);
							}
							if (value.Count == 0)
							{
								break;
							}
						}
					}
				}
			}
			this._strategy.ProcessUndeletedRecords(new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.DataRecord>(list));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			dataPresenter.History.FixHistoryAfterUndelete(dictionary2);
			if (list.Count == 0)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataRecord[] array2 = list.ToArray();
			global::Infragistics.Windows.DataPresenter.DataPresenterAction.SelectRecords(dataPresenter, array2, true, true);
			return new global::Infragistics.Windows.DataPresenter.DeleteRecordsAction(dataPresenter, array2, false);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00015C14 File Offset: 0x00013E14
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine("UndeleteRecords:");
			foreach (global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo recordInfo in this._oldRecords)
			{
				if (recordInfo == null)
				{
					stringBuilder.AppendLine("\t{null}");
				}
				else
				{
					stringBuilder.AppendLine("\t" + recordInfo.ToString());
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00015C9C File Offset: 0x00013E9C
		private static void ProcessDescendants(global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy _strategy, global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> oldDataItemToNewRecord, global::Infragistics.Windows.DataPresenter.DataRecord dataRecord, global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>> children)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>> keyValuePair in children)
			{
				if (dataRecord.FieldLayout == keyValuePair.Key.Owner)
				{
					global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = dataRecord.ChildRecords[keyValuePair.Key];
					global::Infragistics.Windows.DataPresenter.RecordManager childRecordManager = expandableFieldRecord.ChildRecordManager;
					foreach (global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo recordInfo in keyValuePair.Value)
					{
						recordInfo.RecordManager = childRecordManager;
					}
					global::System.Collections.Generic.IDictionary<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo, object> dictionary = _strategy.ProvideDescendantMapping(keyValuePair.Value);
					if (dictionary != null && dictionary.Count > 0)
					{
						global::System.Collections.IList list = childRecordManager.List;
						global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord> unsorted = childRecordManager.Unsorted;
						int i = 0;
						int count = keyValuePair.Value.Count;
						while (i < count)
						{
							global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo recordInfo2 = keyValuePair.Value[i];
							object item;
							if (dictionary.TryGetValue(recordInfo2, out item))
							{
								int dataItemIndex = recordInfo2.DataItemIndex;
								if (dataItemIndex >= 0 && dataItemIndex < list.Count && global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsSameDataItem(item, list[dataItemIndex]))
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = unsorted[dataItemIndex];
									oldDataItemToNewRecord[recordInfo2.DataItem] = dataRecord2;
									dictionary.Remove(recordInfo2);
									if (recordInfo2.Children != null)
									{
										global::Infragistics.Windows.DataPresenter.UndeleteRecordsAction.ProcessDescendants(_strategy, oldDataItemToNewRecord, dataRecord2, recordInfo2.Children);
									}
								}
							}
							i++;
						}
						if (dictionary.Count != 0)
						{
							global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo> dictionary2 = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>();
							foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo, object> keyValuePair2 in dictionary)
							{
								if (keyValuePair2.Value != null)
								{
									dictionary2[keyValuePair2.Value] = keyValuePair2.Key;
								}
							}
							int j = 0;
							int count2 = list.Count;
							while (j < count2)
							{
								object key = list[j];
								global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo recordInfo3;
								if (dictionary2.TryGetValue(key, out recordInfo3))
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord3 = unsorted[j];
									oldDataItemToNewRecord[recordInfo3.DataItem] = dataRecord3;
									if (recordInfo3.Children != null)
									{
										global::Infragistics.Windows.DataPresenter.UndeleteRecordsAction.ProcessDescendants(_strategy, oldDataItemToNewRecord, dataRecord3, recordInfo3.Children);
									}
								}
								j++;
							}
						}
					}
				}
			}
		}

		// Token: 0x040001A2 RID: 418
		private global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy _strategy;

		// Token: 0x040001A3 RID: 419
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo> _oldRecords;
	}
}
