using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Infragistics.Shared;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002DB RID: 731
	internal static class GroupByEvaluatorFactory
	{
		// Token: 0x060022FC RID: 8956 RVA: 0x00098AC0 File Offset: 0x00096CC0
		static GroupByEvaluatorFactory()
		{
			int num = 1;
			foreach (object obj in global::System.Enum.GetValues(typeof(global::Infragistics.Windows.DataPresenter.FieldGroupByMode)))
			{
				int num2 = (int)obj;
				if (num2 > num)
				{
					num = num2;
				}
			}
			global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.g_CachedEvaluators = new global::Infragistics.Windows.DataPresenter.IGroupByEvaluator[(num + 1) * 2];
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x00098B38 File Offset: 0x00096D38
		private static global::Infragistics.Windows.DataPresenter.IGroupByEvaluator GetEvaluator(global::Infragistics.Windows.DataPresenter.FieldGroupByMode mode, global::Infragistics.Windows.DataPresenter.FieldSortComparisonType sortCompareType)
		{
			int num = (int)(mode * global::Infragistics.Windows.DataPresenter.FieldGroupByMode.FirstCharacter);
			if (sortCompareType != global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseSensitive)
			{
				num++;
			}
			global::Infragistics.Windows.DataPresenter.IGroupByEvaluator groupByEvaluator = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.g_CachedEvaluators[num];
			if (groupByEvaluator == null)
			{
				switch (mode)
				{
				case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Date:
					groupByEvaluator = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator();
					break;
				case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.FirstCharacter:
					groupByEvaluator = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.FirstCharactersEvaluator(1, sortCompareType);
					break;
				case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.First2Characters:
					groupByEvaluator = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.FirstCharactersEvaluator(2, sortCompareType);
					break;
				case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.First3Characters:
					groupByEvaluator = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.FirstCharactersEvaluator(3, sortCompareType);
					break;
				case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.First4Characters:
					groupByEvaluator = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.FirstCharactersEvaluator(4, sortCompareType);
					break;
				case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Hour:
					groupByEvaluator = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.HourEvaluator();
					break;
				case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Minute:
					groupByEvaluator = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.MinuteEvaluator();
					break;
				case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Month:
					groupByEvaluator = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.MonthEvaluator();
					break;
				case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.OutlookDate:
					groupByEvaluator = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator();
					break;
				case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Quarter:
					groupByEvaluator = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.QuarterEvaluator();
					break;
				case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Second:
					groupByEvaluator = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.SecondEvaluator();
					break;
				case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Text:
					groupByEvaluator = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.CellTextEvaluator(sortCompareType);
					break;
				case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Value:
					groupByEvaluator = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.ValueEvaluator();
					break;
				case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Year:
					groupByEvaluator = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.YearEvaluator();
					break;
				default:
					groupByEvaluator = null;
					break;
				}
				global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.g_CachedEvaluators[num] = groupByEvaluator;
			}
			return groupByEvaluator;
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x00098C28 File Offset: 0x00096E28
		internal static global::Infragistics.Windows.DataPresenter.IGroupByEvaluator CreateEvaluator(global::Infragistics.Windows.DataPresenter.Field fieldBeingGrouped)
		{
			if (fieldBeingGrouped == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.FieldGroupByMode groupByModeResolved = fieldBeingGrouped.GroupByModeResolved;
			global::Infragistics.Windows.DataPresenter.FieldSortComparisonType sortCompareType = global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseSensitive;
			global::Infragistics.Windows.DataPresenter.FieldGroupByMode fieldGroupByMode = groupByModeResolved;
			switch (fieldGroupByMode)
			{
			case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.FirstCharacter:
			case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.First2Characters:
			case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.First3Characters:
			case global::Infragistics.Windows.DataPresenter.FieldGroupByMode.First4Characters:
				break;
			default:
				if (fieldGroupByMode != global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Text)
				{
					goto IL_34;
				}
				break;
			}
			sortCompareType = fieldBeingGrouped.SortComparisonTypeResolved;
			IL_34:
			return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.GetEvaluator(groupByModeResolved, sortCompareType);
		}

		// Token: 0x040010FA RID: 4346
		private static global::Infragistics.Windows.DataPresenter.IGroupByEvaluator[] g_CachedEvaluators;

		// Token: 0x020002DC RID: 732
		private abstract class DateComparerBase : global::System.Collections.IComparer, global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo>
		{
			// Token: 0x060022FF RID: 8959 RVA: 0x00098C70 File Offset: 0x00096E70
			public virtual int Compare(global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo x, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo y)
			{
				return this.CompareHelper(x._value, y._value);
			}

			// Token: 0x06002300 RID: 8960 RVA: 0x00098C84 File Offset: 0x00096E84
			public virtual int Compare(object x, object y)
			{
				global::Infragistics.Windows.DataPresenter.Cell cell = x as global::Infragistics.Windows.DataPresenter.Cell;
				global::Infragistics.Windows.DataPresenter.Cell cell2 = y as global::Infragistics.Windows.DataPresenter.Cell;
				object cellValue = cell.Record.GetCellValue(cell.Field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
				object cellValue2 = cell2.Record.GetCellValue(cell2.Field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
				return this.CompareHelper(cellValue, cellValue2);
			}

			// Token: 0x06002301 RID: 8961 RVA: 0x00098CD0 File Offset: 0x00096ED0
			private int CompareHelper(object xValue, object yValue)
			{
				if (xValue is global::System.DateTime)
				{
					if (!(yValue is global::System.DateTime))
					{
						return 1;
					}
					int num = ((global::System.IComparable)xValue).CompareTo(yValue);
					if (num == 0 || this.AreInSameGroupBy((global::System.DateTime)xValue, (global::System.DateTime)yValue))
					{
						return 0;
					}
					return num;
				}
				else
				{
					if (yValue is global::System.DateTime)
					{
						return -1;
					}
					return 0;
				}
			}

			// Token: 0x06002302 RID: 8962
			protected abstract bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y);
		}

		// Token: 0x020002DD RID: 733
		internal class CellTextEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x06002304 RID: 8964 RVA: 0x00098D2A File Offset: 0x00096F2A
			internal CellTextEvaluator(global::Infragistics.Windows.DataPresenter.FieldSortComparisonType sortComparisonType)
			{
				this.isCaseInsensitive = (sortComparisonType == global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseInsensitive);
			}

			// Token: 0x06002305 RID: 8965 RVA: 0x00098D3C File Offset: 0x00096F3C
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				string cellText = record.GetCellText(groupByRecord.GroupByField);
				if (cellText != null)
				{
					return cellText;
				}
				return "";
			}

			// Token: 0x06002306 RID: 8966 RVA: 0x00098D60 File Offset: 0x00096F60
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				string text = record.GetCellText(groupByRecord.GroupByField);
				text = ((text == null) ? "" : text);
				return string.Compare(groupByRecord.Value.ToString(), text, this.isCaseInsensitive) == 0;
			}

			// Token: 0x17000A47 RID: 2631
			// (get) Token: 0x06002307 RID: 8967 RVA: 0x00098DA0 File Offset: 0x00096FA0
			global::System.Collections.IComparer global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.SortComparer
			{
				get
				{
					if (this._sortComparer == null)
					{
						this._sortComparer = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.CellTextEvaluator.CellTextComparer(this);
					}
					return this._sortComparer;
				}
			}

			// Token: 0x040010FB RID: 4347
			private readonly bool isCaseInsensitive;

			// Token: 0x040010FC RID: 4348
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.CellTextEvaluator.CellTextComparer _sortComparer;

			// Token: 0x020002DE RID: 734
			private class CellTextComparer : global::System.Collections.IComparer, global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo>
			{
				// Token: 0x06002308 RID: 8968 RVA: 0x00098DBC File Offset: 0x00096FBC
				internal CellTextComparer(global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.CellTextEvaluator evaluator)
				{
					this._evaluator = evaluator;
				}

				// Token: 0x06002309 RID: 8969 RVA: 0x00098DCC File Offset: 0x00096FCC
				public int Compare(global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo x, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo y)
				{
					string cellText = x.GetCellText();
					string cellText2 = y.GetCellText();
					return string.Compare(cellText, cellText2, this._evaluator.isCaseInsensitive);
				}

				// Token: 0x0600230A RID: 8970 RVA: 0x00098DFC File Offset: 0x00096FFC
				int global::System.Collections.IComparer.Compare(object x, object y)
				{
					global::Infragistics.Windows.DataPresenter.Cell cell = x as global::Infragistics.Windows.DataPresenter.Cell;
					global::Infragistics.Windows.DataPresenter.Cell cell2 = y as global::Infragistics.Windows.DataPresenter.Cell;
					string cellText = cell.Record.GetCellText(cell.Field);
					string cellText2 = cell2.Record.GetCellText(cell2.Field);
					return string.Compare(cellText, cellText2, this._evaluator.isCaseInsensitive);
				}

				// Token: 0x040010FD RID: 4349
				private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.CellTextEvaluator _evaluator;
			}
		}

		// Token: 0x020002DF RID: 735
		private class DateEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x0600230B RID: 8971 RVA: 0x00098E50 File Offset: 0x00097050
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.GetGroupByValueHelper(groupByRecord, record).Date;
			}

			// Token: 0x0600230C RID: 8972 RVA: 0x00098E71 File Offset: 0x00097071
			internal static global::System.DateTime GetGroupByValueHelper(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				if (!(groupByRecord.Value is global::System.DateTime))
				{
					return global::System.DateTime.MinValue;
				}
				return (global::System.DateTime)groupByRecord.Value;
			}

			// Token: 0x0600230D RID: 8973 RVA: 0x00098E94 File Offset: 0x00097094
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime dateTime;
				global::System.DateTime dateTime2;
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.DoesGroupContainRecordHelper(groupByRecord, record, out dateTime, out dateTime2) || dateTime2.Date == dateTime.Date;
			}

			// Token: 0x0600230E RID: 8974 RVA: 0x00098EC4 File Offset: 0x000970C4
			internal static bool DoesGroupContainRecordHelper(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record, out global::System.DateTime dateInGroup, out global::System.DateTime dateInCell)
			{
				object cellValue = record.GetCellValue(groupByRecord.GroupByField, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
				dateInGroup = (global::System.DateTime)groupByRecord.Value;
				if (cellValue is global::System.DateTime)
				{
					dateInCell = (global::System.DateTime)cellValue;
					return false;
				}
				if ((global::System.DateTime)groupByRecord.Value == global::System.DateTime.MinValue)
				{
					dateInCell = dateInGroup;
					return true;
				}
				dateInCell = global::System.DateTime.MinValue;
				return false;
			}

			// Token: 0x17000A48 RID: 2632
			// (get) Token: 0x0600230F RID: 8975 RVA: 0x00098F37 File Offset: 0x00097137
			public global::System.Collections.IComparer SortComparer
			{
				get
				{
					return null;
				}
			}
		}

		// Token: 0x020002E0 RID: 736
		private class FirstCharactersEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x06002311 RID: 8977 RVA: 0x00098F42 File Offset: 0x00097142
			internal FirstCharactersEvaluator(int numChars, global::Infragistics.Windows.DataPresenter.FieldSortComparisonType sortComparisonType)
			{
				this.numChars = numChars;
				this.isCaseInsensitive = (sortComparisonType == global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseInsensitive);
			}

			// Token: 0x06002312 RID: 8978 RVA: 0x00098F5B File Offset: 0x0009715B
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				return this.GetFirstCharactersOfCellText(groupByRecord, record);
			}

			// Token: 0x06002313 RID: 8979 RVA: 0x00098F68 File Offset: 0x00097168
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				string strA = (groupByRecord.Value == null) ? "" : groupByRecord.Value.ToString();
				string firstCharactersOfCellText = this.GetFirstCharactersOfCellText(groupByRecord, record);
				return string.Compare(strA, firstCharactersOfCellText, this.isCaseInsensitive) == 0;
			}

			// Token: 0x06002314 RID: 8980 RVA: 0x00098FAC File Offset: 0x000971AC
			private string GetFirstCharactersOfCellText(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				string result;
				if (groupByRecord.GroupByField == null)
				{
					result = "";
				}
				else
				{
					result = this.GetFirstCharactersOfText(record.GetCellText(groupByRecord.GroupByField));
				}
				return result;
			}

			// Token: 0x06002315 RID: 8981 RVA: 0x00098FDD File Offset: 0x000971DD
			private string GetFirstCharactersOfText(string text)
			{
				if (text == null)
				{
					text = string.Empty;
				}
				else if (this.numChars < text.Length)
				{
					text = text.Substring(0, this.numChars);
				}
				return text;
			}

			// Token: 0x17000A49 RID: 2633
			// (get) Token: 0x06002316 RID: 8982 RVA: 0x00099009 File Offset: 0x00097209
			global::System.Collections.IComparer global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.SortComparer
			{
				get
				{
					if (this._sortComparer == null)
					{
						this._sortComparer = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.FirstCharactersEvaluator.FirstCharactersComparer(this);
					}
					return this._sortComparer;
				}
			}

			// Token: 0x040010FE RID: 4350
			private readonly int numChars;

			// Token: 0x040010FF RID: 4351
			private readonly bool isCaseInsensitive;

			// Token: 0x04001100 RID: 4352
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.FirstCharactersEvaluator.FirstCharactersComparer _sortComparer;

			// Token: 0x020002E1 RID: 737
			private class FirstCharactersComparer : global::System.Collections.IComparer, global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo>
			{
				// Token: 0x06002317 RID: 8983 RVA: 0x00099025 File Offset: 0x00097225
				internal FirstCharactersComparer(global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.FirstCharactersEvaluator evaluator)
				{
					this._evaluator = evaluator;
				}

				// Token: 0x06002318 RID: 8984 RVA: 0x00099034 File Offset: 0x00097234
				public int Compare(global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo x, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo y)
				{
					string cellText = x.GetCellText();
					string cellText2 = y.GetCellText();
					return this.CompareHelper(cellText, cellText2);
				}

				// Token: 0x06002319 RID: 8985 RVA: 0x00099058 File Offset: 0x00097258
				private int CompareHelper(string x, string y)
				{
					string firstCharactersOfText = this._evaluator.GetFirstCharactersOfText(x);
					string firstCharactersOfText2 = this._evaluator.GetFirstCharactersOfText(y);
					return string.Compare(firstCharactersOfText, firstCharactersOfText2, this._evaluator.isCaseInsensitive);
				}

				// Token: 0x0600231A RID: 8986 RVA: 0x00099094 File Offset: 0x00097294
				int global::System.Collections.IComparer.Compare(object x, object y)
				{
					global::Infragistics.Windows.DataPresenter.Cell cell = x as global::Infragistics.Windows.DataPresenter.Cell;
					global::Infragistics.Windows.DataPresenter.Cell cell2 = y as global::Infragistics.Windows.DataPresenter.Cell;
					string cellText = cell.Record.GetCellText(cell.Field);
					string cellText2 = cell2.Record.GetCellText(cell2.Field);
					return this.CompareHelper(cellText, cellText2);
				}

				// Token: 0x04001101 RID: 4353
				private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.FirstCharactersEvaluator _evaluator;
			}
		}

		// Token: 0x020002E2 RID: 738
		private class HourEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x0600231B RID: 8987 RVA: 0x000990DC File Offset: 0x000972DC
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime groupByValueHelper = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.GetGroupByValueHelper(groupByRecord, record);
				return new global::System.DateTime(groupByValueHelper.Year, groupByValueHelper.Month, groupByValueHelper.Day, groupByValueHelper.Hour, 0, 0);
			}

			// Token: 0x0600231C RID: 8988 RVA: 0x0009911C File Offset: 0x0009731C
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime dateTime;
				global::System.DateTime dateTime2;
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.DoesGroupContainRecordHelper(groupByRecord, record, out dateTime, out dateTime2) || (dateTime2.Date == dateTime.Date && dateTime2.Hour == dateTime.Hour);
			}

			// Token: 0x17000A4A RID: 2634
			// (get) Token: 0x0600231D RID: 8989 RVA: 0x0009915F File Offset: 0x0009735F
			global::System.Collections.IComparer global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.SortComparer
			{
				get
				{
					if (this._comparer == null)
					{
						this._comparer = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.HourEvaluator.Comparer();
					}
					return this._comparer;
				}
			}

			// Token: 0x04001102 RID: 4354
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.HourEvaluator.Comparer _comparer;

			// Token: 0x020002E3 RID: 739
			private class Comparer : global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateComparerBase
			{
				// Token: 0x0600231F RID: 8991 RVA: 0x00099182 File Offset: 0x00097382
				protected override bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y)
				{
					return x.Date == y.Date && x.Hour == y.Hour;
				}
			}
		}

		// Token: 0x020002E4 RID: 740
		private class MinuteEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x06002321 RID: 8993 RVA: 0x000991B4 File Offset: 0x000973B4
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime groupByValueHelper = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.GetGroupByValueHelper(groupByRecord, record);
				return new global::System.DateTime(groupByValueHelper.Year, groupByValueHelper.Month, groupByValueHelper.Day, groupByValueHelper.Hour, groupByValueHelper.Minute, 0);
			}

			// Token: 0x06002322 RID: 8994 RVA: 0x000991F8 File Offset: 0x000973F8
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime dateTime;
				global::System.DateTime dateTime2;
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.DoesGroupContainRecordHelper(groupByRecord, record, out dateTime, out dateTime2) || (dateTime2.Date == dateTime.Date && dateTime2.Hour == dateTime.Hour && dateTime2.Minute == dateTime.Minute);
			}

			// Token: 0x17000A4B RID: 2635
			// (get) Token: 0x06002323 RID: 8995 RVA: 0x0009924B File Offset: 0x0009744B
			global::System.Collections.IComparer global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.SortComparer
			{
				get
				{
					if (this._comparer == null)
					{
						this._comparer = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.MinuteEvaluator.Comparer();
					}
					return this._comparer;
				}
			}

			// Token: 0x04001103 RID: 4355
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.MinuteEvaluator.Comparer _comparer;

			// Token: 0x020002E5 RID: 741
			private class Comparer : global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateComparerBase
			{
				// Token: 0x06002325 RID: 8997 RVA: 0x0009926E File Offset: 0x0009746E
				protected override bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y)
				{
					return x.Date == y.Date && x.Hour == y.Hour && x.Minute == y.Minute;
				}
			}
		}

		// Token: 0x020002E6 RID: 742
		private class MonthEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x06002327 RID: 8999 RVA: 0x000992B0 File Offset: 0x000974B0
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime groupByValueHelper = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.GetGroupByValueHelper(groupByRecord, record);
				return new global::System.DateTime(groupByValueHelper.Year, groupByValueHelper.Month, 1);
			}

			// Token: 0x06002328 RID: 9000 RVA: 0x000992E0 File Offset: 0x000974E0
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime dateTime;
				global::System.DateTime dateTime2;
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.DoesGroupContainRecordHelper(groupByRecord, record, out dateTime, out dateTime2) || (dateTime2.Year == dateTime.Year && dateTime2.Month == dateTime.Month);
			}

			// Token: 0x17000A4C RID: 2636
			// (get) Token: 0x06002329 RID: 9001 RVA: 0x0009931E File Offset: 0x0009751E
			global::System.Collections.IComparer global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.SortComparer
			{
				get
				{
					if (this._comparer == null)
					{
						this._comparer = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.MonthEvaluator.Comparer();
					}
					return this._comparer;
				}
			}

			// Token: 0x04001104 RID: 4356
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.MonthEvaluator.Comparer _comparer;

			// Token: 0x020002E7 RID: 743
			private class Comparer : global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateComparerBase
			{
				// Token: 0x0600232B RID: 9003 RVA: 0x00099341 File Offset: 0x00097541
				protected override bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y)
				{
					return x.Year == y.Year && x.Month == y.Month;
				}
			}
		}

		// Token: 0x020002E8 RID: 744
		private class OutlookDateEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x0600232D RID: 9005 RVA: 0x0009936D File Offset: 0x0009756D
			internal OutlookDateEvaluator()
			{
			}

			// Token: 0x0600232E RID: 9006 RVA: 0x00099378 File Offset: 0x00097578
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				object cellValue = record.GetCellValue(groupByRecord.GroupByField, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
				global::System.DateTime targetDate = global::System.DateTime.MinValue;
				global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.CultureCache cultureInfoCache = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.GetCultureInfoCache(groupByRecord);
				global::Infragistics.Shared.DynamicResourceString dynamicDesriptionString;
				if (cellValue == null || cellValue is global::System.DBNull)
				{
					dynamicDesriptionString = cultureInfoCache.NONE;
				}
				else if (cellValue is global::System.DateTime)
				{
					targetDate = (global::System.DateTime)cellValue;
					dynamicDesriptionString = cultureInfoCache.GetDateLabel(targetDate);
				}
				else
				{
					dynamicDesriptionString = cultureInfoCache.NONE;
				}
				groupByRecord.DynamicDesriptionString = dynamicDesriptionString;
				return targetDate.Date;
			}

			// Token: 0x0600232F RID: 9007 RVA: 0x000993EC File Offset: 0x000975EC
			private static global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.CultureCache GetCultureInfoCache(global::Infragistics.Windows.DataPresenter.Record rcd)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = rcd.DataPresenter;
				global::System.Globalization.CultureInfo cultureInfo = null;
				if (dataPresenter != null)
				{
					cultureInfo = dataPresenter.DefaultConverterCulture;
				}
				if (cultureInfo == null)
				{
					cultureInfo = global::System.Threading.Thread.CurrentThread.CurrentCulture;
					if (cultureInfo == null)
					{
						cultureInfo = global::System.Globalization.CultureInfo.InvariantCulture;
					}
				}
				if (global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.g_cultureCache == null)
				{
					global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.g_cultureCache = new global::System.Collections.Generic.Dictionary<global::System.Globalization.CultureInfo, global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.CultureCache>();
				}
				global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.CultureCache cultureCache;
				if (global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.g_cultureCache.TryGetValue(cultureInfo, out cultureCache))
				{
					return cultureCache;
				}
				cultureCache = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.CultureCache(cultureInfo);
				global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.g_cultureCache.Add(cultureInfo, cultureCache);
				return cultureCache;
			}

			// Token: 0x06002330 RID: 9008 RVA: 0x0009945C File Offset: 0x0009765C
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.CultureCache cultureInfoCache = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.GetCultureInfoCache(groupByRecord);
				object value = groupByRecord.Value;
				object cellValue = record.GetCellValue(groupByRecord.GroupByField, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
				global::Infragistics.Shared.DynamicResourceString dynamicDesriptionString = groupByRecord.DynamicDesriptionString;
				if (cellValue == null || cellValue is global::System.DBNull)
				{
					return dynamicDesriptionString == cultureInfoCache.NONE;
				}
				if (!(cellValue is global::System.DateTime))
				{
					return dynamicDesriptionString == cultureInfoCache.NONE;
				}
				if (dynamicDesriptionString == cultureInfoCache.NONE)
				{
					return false;
				}
				global::Infragistics.Shared.DynamicResourceString dateLabel = cultureInfoCache.GetDateLabel((global::System.DateTime)cellValue);
				global::Infragistics.Shared.DynamicResourceString dateLabel2 = cultureInfoCache.GetDateLabel((global::System.DateTime)value);
				if (object.ReferenceEquals(dateLabel, dateLabel2))
				{
					if (dynamicDesriptionString != dateLabel2)
					{
						groupByRecord.DynamicDesriptionString = dateLabel2;
					}
					return true;
				}
				return false;
			}

			// Token: 0x17000A4D RID: 2637
			// (get) Token: 0x06002331 RID: 9009 RVA: 0x000994F5 File Offset: 0x000976F5
			global::System.Collections.IComparer global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.SortComparer
			{
				get
				{
					if (this._comparer == null)
					{
						this._comparer = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.Comparer(this);
					}
					return this._comparer;
				}
			}

			// Token: 0x04001105 RID: 4357
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.Comparer _comparer;

			// Token: 0x04001106 RID: 4358
			private static global::System.Collections.Generic.Dictionary<global::System.Globalization.CultureInfo, global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.CultureCache> g_cultureCache;

			// Token: 0x020002E9 RID: 745
			private class Comparer : global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateComparerBase
			{
				// Token: 0x06002332 RID: 9010 RVA: 0x00099511 File Offset: 0x00097711
				internal Comparer(global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator evaluator)
				{
					this._evaluator = evaluator;
				}

				// Token: 0x06002333 RID: 9011 RVA: 0x00099520 File Offset: 0x00097720
				public override int Compare(object x, object y)
				{
					global::Infragistics.Windows.DataPresenter.Cell cell = x as global::Infragistics.Windows.DataPresenter.Cell;
					this._cic = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.GetCultureInfoCache(cell.Record);
					return base.Compare(x, y);
				}

				// Token: 0x06002334 RID: 9012 RVA: 0x0009954D File Offset: 0x0009774D
				public override int Compare(global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo x, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo y)
				{
					this._cic = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.GetCultureInfoCache(x._record);
					return base.Compare(x, y);
				}

				// Token: 0x06002335 RID: 9013 RVA: 0x00099568 File Offset: 0x00097768
				protected override bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y)
				{
					global::Infragistics.Shared.DynamicResourceString dateLabel = this._cic.GetDateLabel(x);
					global::Infragistics.Shared.DynamicResourceString dateLabel2 = this._cic.GetDateLabel(y);
					return object.ReferenceEquals(dateLabel, dateLabel2);
				}

				// Token: 0x04001107 RID: 4359
				private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator _evaluator;

				// Token: 0x04001108 RID: 4360
				private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.CultureCache _cic;
			}

			// Token: 0x020002EA RID: 746
			private class CultureCache
			{
				// Token: 0x06002336 RID: 9014 RVA: 0x00099598 File Offset: 0x00097798
				internal CultureCache(global::System.Globalization.CultureInfo culture)
				{
					this._culture = culture;
					global::System.DateTime dateTime = global::System.DateTime.Today;
					while (dateTime.DayOfWeek != global::System.DayOfWeek.Sunday)
					{
						dateTime = dateTime.AddDays(1.0);
					}
					this.SUNDAY = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_DayOfWeekFormatString", new object[]
					{
						dateTime
					}, this._culture);
					this.MONDAY = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_DayOfWeekFormatString", new object[]
					{
						dateTime.AddDays(1.0)
					}, this._culture);
					this.TUESDAY = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_DayOfWeekFormatString", new object[]
					{
						dateTime.AddDays(2.0)
					}, this._culture);
					this.WEDNESDAY = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_DayOfWeekFormatString", new object[]
					{
						dateTime.AddDays(3.0)
					}, this._culture);
					this.THURSDAY = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_DayOfWeekFormatString", new object[]
					{
						dateTime.AddDays(4.0)
					}, this._culture);
					this.FRIDAY = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_DayOfWeekFormatString", new object[]
					{
						dateTime.AddDays(5.0)
					}, this._culture);
					this.SATURDAY = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_DayOfWeekFormatString", new object[]
					{
						dateTime.AddDays(6.0)
					}, this._culture);
					this.BEYOND_NEXT_MONTH = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_BeyondNextMonth", new object[0], this._culture);
					this.NEXT_MONTH = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_NextMonth", new object[0], this._culture);
					this.LATER_THIS_MONTH = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_LaterThisMonth", new object[0], this._culture);
					this.THREE_WEEKS_AWAY = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_ThreeWeeksAway", new object[0], this._culture);
					this.TWO_WEEKS_AWAY = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_TwoWeeksAway", new object[0], this._culture);
					this.NEXT_WEEK = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_NextWeek", new object[0], this._culture);
					this.TODAY = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_Today", new object[0], this._culture);
					this.YESTERDAY = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_Yesterday", new object[0], this._culture);
					this.LAST_WEEK = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_LastWeek", new object[0], this._culture);
					this.TWO_WEEKS_AGO = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_TwoWeeksAgo", new object[0], this._culture);
					this.THREE_WEEKS_AGO = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_ThreeWeeksAgo", new object[0], this._culture);
					this.EARLIER_THIS_MONTH = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_EarlierThisMonth", new object[0], this._culture);
					this.LAST_MONTH = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_LastMonth", new object[0], this._culture);
					this.OLDER = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_Older", new object[0], this._culture);
					this.NONE = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("Outlook_GroupByMode_Description_None", new object[0], this._culture);
				}

				// Token: 0x17000A4E RID: 2638
				// (get) Token: 0x06002337 RID: 9015 RVA: 0x000998F0 File Offset: 0x00097AF0
				internal global::System.Collections.Generic.Dictionary<global::System.DayOfWeek, global::Infragistics.Shared.DynamicResourceString> DayMap
				{
					get
					{
						if (this.dayMap == null)
						{
							this.dayMap = new global::System.Collections.Generic.Dictionary<global::System.DayOfWeek, global::Infragistics.Shared.DynamicResourceString>(7);
							this.dayMap.Add(global::System.DayOfWeek.Sunday, this.SUNDAY);
							this.dayMap.Add(global::System.DayOfWeek.Monday, this.MONDAY);
							this.dayMap.Add(global::System.DayOfWeek.Tuesday, this.TUESDAY);
							this.dayMap.Add(global::System.DayOfWeek.Wednesday, this.WEDNESDAY);
							this.dayMap.Add(global::System.DayOfWeek.Thursday, this.THURSDAY);
							this.dayMap.Add(global::System.DayOfWeek.Friday, this.FRIDAY);
							this.dayMap.Add(global::System.DayOfWeek.Saturday, this.SATURDAY);
						}
						return this.dayMap;
					}
				}

				// Token: 0x06002338 RID: 9016 RVA: 0x00099998 File Offset: 0x00097B98
				internal global::Infragistics.Shared.DynamicResourceString GetDateLabel(global::System.DateTime targetDate)
				{
					if (this.lastUpdated.Date < global::System.DateTime.Today)
					{
						this.InitDateInfos();
					}
					foreach (object obj in this.dateInfos)
					{
						global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo dateInfo = (global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo)obj;
						if (dateInfo.Contains(targetDate))
						{
							return dateInfo.DateLabel;
						}
					}
					return null;
				}

				// Token: 0x06002339 RID: 9017 RVA: 0x00099A1C File Offset: 0x00097C1C
				private void InitDateInfos()
				{
					global::System.DayOfWeek firstDayOfWeek = this._culture.DateTimeFormat.FirstDayOfWeek;
					global::System.DateTime today = global::System.DateTime.Today;
					global::System.DateTime dateTime = new global::System.DateTime(today.Year, today.Month, 1);
					global::System.DateTime dateTime2 = today;
					while (dateTime2.DayOfWeek != firstDayOfWeek)
					{
						dateTime2 = dateTime2.AddDays(-1.0);
					}
					this.dateInfos = new global::System.Collections.ArrayList();
					global::System.DateTime d = today.AddDays(-1.0);
					global::System.DateTime begin = global::System.DateTime.MinValue;
					global::System.DateTime dateTime3 = dateTime.AddMonths(-1).AddDays(-1.0);
					this.dateInfos.Add(new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo(begin, dateTime3, this.OLDER));
					begin = dateTime2.AddDays(-21.0);
					dateTime3 = begin.AddDays(6.0);
					this.dateInfos.Add(new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo(begin, dateTime3, this.THREE_WEEKS_AGO));
					begin = dateTime2.AddDays(-14.0);
					dateTime3 = begin.AddDays(6.0);
					this.dateInfos.Add(new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo(begin, dateTime3, this.TWO_WEEKS_AGO));
					begin = dateTime2.AddDays(-7.0);
					dateTime3 = begin.AddDays(6.0);
					if (dateTime3 == d)
					{
						this.dateInfos.Add(new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo(dateTime3, dateTime3, this.YESTERDAY));
						dateTime3 = dateTime3.AddDays(-1.0);
					}
					this.dateInfos.Add(new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo(begin, dateTime3, this.LAST_WEEK));
					begin = dateTime;
					dateTime3 = dateTime2.AddDays(-1.0);
					this.dateInfos.Add(new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo(begin, dateTime3, this.EARLIER_THIS_MONTH));
					begin = dateTime.AddMonths(-1);
					dateTime3 = dateTime.AddDays(-1.0);
					this.dateInfos.Add(new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo(begin, dateTime3, this.LAST_MONTH));
					global::System.DateTime dateTime4 = dateTime2;
					for (int i = 0; i < 7; i++)
					{
						global::Infragistics.Shared.DynamicResourceString label;
						if (dateTime4 == today)
						{
							label = this.TODAY;
						}
						else if (dateTime4 == d)
						{
							label = this.YESTERDAY;
						}
						else
						{
							label = this.DayMap[dateTime4.DayOfWeek];
						}
						this.dateInfos.Add(new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo(dateTime4, dateTime4, label));
						dateTime4 = dateTime4.AddDays(1.0);
						if (dateTime4.DayOfWeek == firstDayOfWeek)
						{
							break;
						}
					}
					begin = dateTime2.AddDays(7.0);
					dateTime3 = begin.AddDays(6.0);
					this.dateInfos.Add(new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo(begin, dateTime3, this.NEXT_WEEK));
					begin = dateTime2.AddDays(14.0);
					dateTime3 = begin.AddDays(6.0);
					this.dateInfos.Add(new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo(begin, dateTime3, this.TWO_WEEKS_AWAY));
					begin = dateTime2.AddDays(21.0);
					dateTime3 = begin.AddDays(6.0);
					this.dateInfos.Add(new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo(begin, dateTime3, this.THREE_WEEKS_AWAY));
					begin = dateTime;
					dateTime3 = dateTime.AddMonths(1).AddDays(-1.0);
					this.dateInfos.Add(new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo(begin, dateTime3, this.LATER_THIS_MONTH));
					begin = dateTime.AddMonths(1);
					dateTime3 = dateTime.AddMonths(2).AddDays(-1.0);
					this.dateInfos.Add(new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo(begin, dateTime3, this.NEXT_MONTH));
					begin = dateTime.AddMonths(2);
					dateTime3 = global::System.DateTime.MaxValue;
					this.dateInfos.Add(new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.DateInfo(begin, dateTime3, this.BEYOND_NEXT_MONTH));
					this.lastUpdated = today;
				}

				// Token: 0x04001109 RID: 4361
				private global::System.Globalization.CultureInfo _culture;

				// Token: 0x0400110A RID: 4362
				internal readonly global::Infragistics.Shared.DynamicResourceString BEYOND_NEXT_MONTH;

				// Token: 0x0400110B RID: 4363
				internal readonly global::Infragistics.Shared.DynamicResourceString NEXT_MONTH;

				// Token: 0x0400110C RID: 4364
				internal readonly global::Infragistics.Shared.DynamicResourceString LATER_THIS_MONTH;

				// Token: 0x0400110D RID: 4365
				internal readonly global::Infragistics.Shared.DynamicResourceString THREE_WEEKS_AWAY;

				// Token: 0x0400110E RID: 4366
				internal readonly global::Infragistics.Shared.DynamicResourceString TWO_WEEKS_AWAY;

				// Token: 0x0400110F RID: 4367
				internal readonly global::Infragistics.Shared.DynamicResourceString NEXT_WEEK;

				// Token: 0x04001110 RID: 4368
				internal readonly global::Infragistics.Shared.DynamicResourceString TODAY;

				// Token: 0x04001111 RID: 4369
				internal readonly global::Infragistics.Shared.DynamicResourceString YESTERDAY;

				// Token: 0x04001112 RID: 4370
				internal readonly global::Infragistics.Shared.DynamicResourceString SUNDAY;

				// Token: 0x04001113 RID: 4371
				internal readonly global::Infragistics.Shared.DynamicResourceString MONDAY;

				// Token: 0x04001114 RID: 4372
				internal readonly global::Infragistics.Shared.DynamicResourceString TUESDAY;

				// Token: 0x04001115 RID: 4373
				internal readonly global::Infragistics.Shared.DynamicResourceString WEDNESDAY;

				// Token: 0x04001116 RID: 4374
				internal readonly global::Infragistics.Shared.DynamicResourceString THURSDAY;

				// Token: 0x04001117 RID: 4375
				internal readonly global::Infragistics.Shared.DynamicResourceString FRIDAY;

				// Token: 0x04001118 RID: 4376
				internal readonly global::Infragistics.Shared.DynamicResourceString SATURDAY;

				// Token: 0x04001119 RID: 4377
				internal readonly global::Infragistics.Shared.DynamicResourceString LAST_WEEK;

				// Token: 0x0400111A RID: 4378
				internal readonly global::Infragistics.Shared.DynamicResourceString TWO_WEEKS_AGO;

				// Token: 0x0400111B RID: 4379
				internal readonly global::Infragistics.Shared.DynamicResourceString THREE_WEEKS_AGO;

				// Token: 0x0400111C RID: 4380
				internal readonly global::Infragistics.Shared.DynamicResourceString EARLIER_THIS_MONTH;

				// Token: 0x0400111D RID: 4381
				internal readonly global::Infragistics.Shared.DynamicResourceString LAST_MONTH;

				// Token: 0x0400111E RID: 4382
				internal readonly global::Infragistics.Shared.DynamicResourceString OLDER;

				// Token: 0x0400111F RID: 4383
				internal readonly global::Infragistics.Shared.DynamicResourceString NONE;

				// Token: 0x04001120 RID: 4384
				private global::System.Collections.ArrayList dateInfos;

				// Token: 0x04001121 RID: 4385
				private global::System.DateTime lastUpdated;

				// Token: 0x04001122 RID: 4386
				private global::System.Collections.Generic.Dictionary<global::System.DayOfWeek, global::Infragistics.Shared.DynamicResourceString> dayMap;
			}

			// Token: 0x020002EB RID: 747
			private class DateInfo
			{
				// Token: 0x0600233A RID: 9018 RVA: 0x00099E1A File Offset: 0x0009801A
				internal DateInfo(global::System.DateTime begin, global::System.DateTime end, global::Infragistics.Shared.DynamicResourceString label)
				{
					this.beginDate = begin;
					this.endDate = end;
					this.dateLabel = label;
				}

				// Token: 0x0600233B RID: 9019 RVA: 0x00099E38 File Offset: 0x00098038
				internal bool Contains(global::System.DateTime date)
				{
					return this.beginDate.Date <= date.Date && date.Date <= this.endDate.Date;
				}

				// Token: 0x17000A4F RID: 2639
				// (get) Token: 0x0600233C RID: 9020 RVA: 0x00099E7D File Offset: 0x0009807D
				internal global::Infragistics.Shared.DynamicResourceString DateLabel
				{
					get
					{
						return this.dateLabel;
					}
				}

				// Token: 0x04001123 RID: 4387
				private readonly global::System.DateTime beginDate;

				// Token: 0x04001124 RID: 4388
				private readonly global::System.DateTime endDate;

				// Token: 0x04001125 RID: 4389
				private readonly global::Infragistics.Shared.DynamicResourceString dateLabel;
			}
		}

		// Token: 0x020002EC RID: 748
		private class QuarterEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x0600233D RID: 9021 RVA: 0x00099E88 File Offset: 0x00098088
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime groupByValueHelper = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.GetGroupByValueHelper(groupByRecord, record);
				if (groupByValueHelper == global::System.DateTime.MinValue)
				{
					return groupByValueHelper;
				}
				int month = groupByValueHelper.Month - (groupByValueHelper.Month - 1) % 3;
				return new global::System.DateTime(groupByValueHelper.Year, month, 1);
			}

			// Token: 0x0600233E RID: 9022 RVA: 0x00099ED8 File Offset: 0x000980D8
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime dateTime;
				global::System.DateTime dateTime2;
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.DoesGroupContainRecordHelper(groupByRecord, record, out dateTime, out dateTime2) || (dateTime2.Year == dateTime.Year && dateTime2.Month >= dateTime.Month && dateTime2.Month < dateTime.Month + 3);
			}

			// Token: 0x17000A50 RID: 2640
			// (get) Token: 0x0600233F RID: 9023 RVA: 0x00099F28 File Offset: 0x00098128
			global::System.Collections.IComparer global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.SortComparer
			{
				get
				{
					if (this._comparer == null)
					{
						this._comparer = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.QuarterEvaluator.Comparer();
					}
					return this._comparer;
				}
			}

			// Token: 0x04001126 RID: 4390
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.QuarterEvaluator.Comparer _comparer;

			// Token: 0x020002ED RID: 749
			private class Comparer : global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateComparerBase
			{
				// Token: 0x06002341 RID: 9025 RVA: 0x00099F4B File Offset: 0x0009814B
				protected override bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y)
				{
					return x.Year == y.Year && (x.Month - 1) / 3 == (y.Month - 1) / 3;
				}
			}
		}

		// Token: 0x020002EE RID: 750
		private class SecondEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x06002343 RID: 9027 RVA: 0x00099F80 File Offset: 0x00098180
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime groupByValueHelper = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.GetGroupByValueHelper(groupByRecord, record);
				return new global::System.DateTime(groupByValueHelper.Year, groupByValueHelper.Month, groupByValueHelper.Day, groupByValueHelper.Hour, groupByValueHelper.Minute, groupByValueHelper.Second);
			}

			// Token: 0x06002344 RID: 9028 RVA: 0x00099FCC File Offset: 0x000981CC
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime dateTime;
				global::System.DateTime dateTime2;
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.DoesGroupContainRecordHelper(groupByRecord, record, out dateTime, out dateTime2) || (dateTime2.Date == dateTime.Date && dateTime2.Hour == dateTime.Hour && dateTime2.Minute == dateTime.Minute && dateTime2.Second == dateTime.Second);
			}

			// Token: 0x17000A51 RID: 2641
			// (get) Token: 0x06002345 RID: 9029 RVA: 0x0009A02F File Offset: 0x0009822F
			global::System.Collections.IComparer global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.SortComparer
			{
				get
				{
					if (this._comparer == null)
					{
						this._comparer = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.SecondEvaluator.Comparer();
					}
					return this._comparer;
				}
			}

			// Token: 0x04001127 RID: 4391
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.SecondEvaluator.Comparer _comparer;

			// Token: 0x020002EF RID: 751
			private class Comparer : global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateComparerBase
			{
				// Token: 0x06002347 RID: 9031 RVA: 0x0009A054 File Offset: 0x00098254
				protected override bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y)
				{
					return x.Date == y.Date && x.Hour == y.Hour && x.Minute == y.Minute && x.Second == y.Second;
				}
			}
		}

		// Token: 0x020002F0 RID: 752
		private class ValueEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x06002349 RID: 9033 RVA: 0x0009A0B0 File Offset: 0x000982B0
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				return groupByRecord.Value;
			}

			// Token: 0x0600234A RID: 9034 RVA: 0x0009A0B8 File Offset: 0x000982B8
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::Infragistics.Windows.DataPresenter.Field groupByField = groupByRecord.GroupByField;
				object cellValue = record.GetCellValue(groupByField, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
				global::System.Collections.IComparer sortComparerResolved = groupByField.SortComparerResolved;
				if (sortComparerResolved != null)
				{
					return sortComparerResolved.Compare(cellValue, groupByRecord.Value) == 0;
				}
				return global::Infragistics.Windows.DataPresenter.RecordManager.RecordsSortComparer.DefaultCompare(cellValue, groupByRecord.Value, false, false) == 0;
			}

			// Token: 0x17000A52 RID: 2642
			// (get) Token: 0x0600234B RID: 9035 RVA: 0x0009A101 File Offset: 0x00098301
			public global::System.Collections.IComparer SortComparer
			{
				get
				{
					return null;
				}
			}
		}

		// Token: 0x020002F1 RID: 753
		private class YearEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x0600234D RID: 9037 RVA: 0x0009A10C File Offset: 0x0009830C
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				return new global::System.DateTime(global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.GetGroupByValueHelper(groupByRecord, record).Year, 1, 1);
			}

			// Token: 0x0600234E RID: 9038 RVA: 0x0009A134 File Offset: 0x00098334
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime dateTime;
				global::System.DateTime dateTime2;
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.DoesGroupContainRecordHelper(groupByRecord, record, out dateTime, out dateTime2) || dateTime2.Year == dateTime.Year;
			}

			// Token: 0x17000A53 RID: 2643
			// (get) Token: 0x0600234F RID: 9039 RVA: 0x0009A160 File Offset: 0x00098360
			global::System.Collections.IComparer global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.SortComparer
			{
				get
				{
					if (this._comparer == null)
					{
						this._comparer = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.YearEvaluator.Comparer();
					}
					return this._comparer;
				}
			}

			// Token: 0x04001128 RID: 4392
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.YearEvaluator.Comparer _comparer;

			// Token: 0x020002F2 RID: 754
			private class Comparer : global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateComparerBase
			{
				// Token: 0x06002351 RID: 9041 RVA: 0x0009A183 File Offset: 0x00098383
				protected override bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y)
				{
					return x.Year == y.Year;
				}
			}
		}
	}
}
