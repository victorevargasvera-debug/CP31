using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Infragistics.Shared;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200031A RID: 794
	internal static class GroupByEvaluatorFactory
	{
		// Token: 0x0600269B RID: 9883 RVA: 0x000AC34C File Offset: 0x000AA54C
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

		// Token: 0x0600269C RID: 9884 RVA: 0x000AC3C4 File Offset: 0x000AA5C4
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

		// Token: 0x0600269D RID: 9885 RVA: 0x000AC4B4 File Offset: 0x000AA6B4
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

		// Token: 0x04001313 RID: 4883
		private static global::Infragistics.Windows.DataPresenter.IGroupByEvaluator[] g_CachedEvaluators;

		// Token: 0x0200031B RID: 795
		private abstract class DateComparerBase : global::System.Collections.IComparer, global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo>
		{
			// Token: 0x0600269E RID: 9886 RVA: 0x000AC4FC File Offset: 0x000AA6FC
			public virtual int Compare(global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo x, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo y)
			{
				return this.CompareHelper(x._value, y._value);
			}

			// Token: 0x0600269F RID: 9887 RVA: 0x000AC510 File Offset: 0x000AA710
			public virtual int Compare(object x, object y)
			{
				global::Infragistics.Windows.DataPresenter.Cell cell = x as global::Infragistics.Windows.DataPresenter.Cell;
				global::Infragistics.Windows.DataPresenter.Cell cell2 = y as global::Infragistics.Windows.DataPresenter.Cell;
				object cellValue = cell.Record.GetCellValue(cell.Field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
				object cellValue2 = cell2.Record.GetCellValue(cell2.Field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
				return this.CompareHelper(cellValue, cellValue2);
			}

			// Token: 0x060026A0 RID: 9888 RVA: 0x000AC55C File Offset: 0x000AA75C
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

			// Token: 0x060026A1 RID: 9889
			protected abstract bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y);
		}

		// Token: 0x0200031C RID: 796
		internal class CellTextEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x060026A3 RID: 9891 RVA: 0x000AC5B6 File Offset: 0x000AA7B6
			internal CellTextEvaluator(global::Infragistics.Windows.DataPresenter.FieldSortComparisonType sortComparisonType)
			{
				this.isCaseInsensitive = (sortComparisonType == global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseInsensitive);
			}

			// Token: 0x060026A4 RID: 9892 RVA: 0x000AC5C8 File Offset: 0x000AA7C8
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				string cellText = record.GetCellText(groupByRecord.GroupByField);
				if (cellText != null)
				{
					return cellText;
				}
				return "";
			}

			// Token: 0x060026A5 RID: 9893 RVA: 0x000AC5EC File Offset: 0x000AA7EC
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				string text = record.GetCellText(groupByRecord.GroupByField);
				text = ((text == null) ? "" : text);
				return string.Compare(groupByRecord.Value.ToString(), text, this.isCaseInsensitive) == 0;
			}

			// Token: 0x17000B74 RID: 2932
			// (get) Token: 0x060026A6 RID: 9894 RVA: 0x000AC62C File Offset: 0x000AA82C
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

			// Token: 0x04001314 RID: 4884
			private readonly bool isCaseInsensitive;

			// Token: 0x04001315 RID: 4885
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.CellTextEvaluator.CellTextComparer _sortComparer;

			// Token: 0x0200031D RID: 797
			private class CellTextComparer : global::System.Collections.IComparer, global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo>
			{
				// Token: 0x060026A7 RID: 9895 RVA: 0x000AC648 File Offset: 0x000AA848
				internal CellTextComparer(global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.CellTextEvaluator evaluator)
				{
					this._evaluator = evaluator;
				}

				// Token: 0x060026A8 RID: 9896 RVA: 0x000AC658 File Offset: 0x000AA858
				public int Compare(global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo x, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo y)
				{
					string cellText = x.GetCellText();
					string cellText2 = y.GetCellText();
					return string.Compare(cellText, cellText2, this._evaluator.isCaseInsensitive);
				}

				// Token: 0x060026A9 RID: 9897 RVA: 0x000AC688 File Offset: 0x000AA888
				int global::System.Collections.IComparer.Compare(object x, object y)
				{
					global::Infragistics.Windows.DataPresenter.Cell cell = x as global::Infragistics.Windows.DataPresenter.Cell;
					global::Infragistics.Windows.DataPresenter.Cell cell2 = y as global::Infragistics.Windows.DataPresenter.Cell;
					string cellText = cell.Record.GetCellText(cell.Field);
					string cellText2 = cell2.Record.GetCellText(cell2.Field);
					return string.Compare(cellText, cellText2, this._evaluator.isCaseInsensitive);
				}

				// Token: 0x04001316 RID: 4886
				private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.CellTextEvaluator _evaluator;
			}
		}

		// Token: 0x0200031E RID: 798
		private class DateEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x060026AA RID: 9898 RVA: 0x000AC6DC File Offset: 0x000AA8DC
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.GetGroupByValueHelper(groupByRecord, record).Date;
			}

			// Token: 0x060026AB RID: 9899 RVA: 0x000AC6FD File Offset: 0x000AA8FD
			internal static global::System.DateTime GetGroupByValueHelper(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				if (!(groupByRecord.Value is global::System.DateTime))
				{
					return global::System.DateTime.MinValue;
				}
				return (global::System.DateTime)groupByRecord.Value;
			}

			// Token: 0x060026AC RID: 9900 RVA: 0x000AC720 File Offset: 0x000AA920
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime dateTime;
				global::System.DateTime dateTime2;
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.DoesGroupContainRecordHelper(groupByRecord, record, out dateTime, out dateTime2) || dateTime2.Date == dateTime.Date;
			}

			// Token: 0x060026AD RID: 9901 RVA: 0x000AC750 File Offset: 0x000AA950
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

			// Token: 0x17000B75 RID: 2933
			// (get) Token: 0x060026AE RID: 9902 RVA: 0x000AC7C3 File Offset: 0x000AA9C3
			public global::System.Collections.IComparer SortComparer
			{
				get
				{
					if (this._comparer == null)
					{
						this._comparer = new global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.Comparer();
					}
					return this._comparer;
				}
			}

			// Token: 0x04001317 RID: 4887
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.Comparer _comparer;

			// Token: 0x0200031F RID: 799
			private class Comparer : global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateComparerBase
			{
				// Token: 0x060026B0 RID: 9904 RVA: 0x000AC7E6 File Offset: 0x000AA9E6
				protected override bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y)
				{
					return x.Date == y.Date;
				}
			}
		}

		// Token: 0x02000320 RID: 800
		private class FirstCharactersEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x060026B2 RID: 9906 RVA: 0x000AC803 File Offset: 0x000AAA03
			internal FirstCharactersEvaluator(int numChars, global::Infragistics.Windows.DataPresenter.FieldSortComparisonType sortComparisonType)
			{
				this.numChars = numChars;
				this.isCaseInsensitive = (sortComparisonType == global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseInsensitive);
			}

			// Token: 0x060026B3 RID: 9907 RVA: 0x000AC81C File Offset: 0x000AAA1C
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				return this.GetFirstCharactersOfCellText(groupByRecord, record);
			}

			// Token: 0x060026B4 RID: 9908 RVA: 0x000AC828 File Offset: 0x000AAA28
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				string strA = (groupByRecord.Value == null) ? "" : groupByRecord.Value.ToString();
				string firstCharactersOfCellText = this.GetFirstCharactersOfCellText(groupByRecord, record);
				return string.Compare(strA, firstCharactersOfCellText, this.isCaseInsensitive) == 0;
			}

			// Token: 0x060026B5 RID: 9909 RVA: 0x000AC86C File Offset: 0x000AAA6C
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

			// Token: 0x060026B6 RID: 9910 RVA: 0x000AC89D File Offset: 0x000AAA9D
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

			// Token: 0x17000B76 RID: 2934
			// (get) Token: 0x060026B7 RID: 9911 RVA: 0x000AC8C9 File Offset: 0x000AAAC9
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

			// Token: 0x04001318 RID: 4888
			private readonly int numChars;

			// Token: 0x04001319 RID: 4889
			private readonly bool isCaseInsensitive;

			// Token: 0x0400131A RID: 4890
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.FirstCharactersEvaluator.FirstCharactersComparer _sortComparer;

			// Token: 0x02000321 RID: 801
			private class FirstCharactersComparer : global::System.Collections.IComparer, global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo>
			{
				// Token: 0x060026B8 RID: 9912 RVA: 0x000AC8E5 File Offset: 0x000AAAE5
				internal FirstCharactersComparer(global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.FirstCharactersEvaluator evaluator)
				{
					this._evaluator = evaluator;
				}

				// Token: 0x060026B9 RID: 9913 RVA: 0x000AC8F4 File Offset: 0x000AAAF4
				public int Compare(global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo x, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo y)
				{
					string cellText = x.GetCellText();
					string cellText2 = y.GetCellText();
					return this.CompareHelper(cellText, cellText2);
				}

				// Token: 0x060026BA RID: 9914 RVA: 0x000AC918 File Offset: 0x000AAB18
				private int CompareHelper(string x, string y)
				{
					string firstCharactersOfText = this._evaluator.GetFirstCharactersOfText(x);
					string firstCharactersOfText2 = this._evaluator.GetFirstCharactersOfText(y);
					return string.Compare(firstCharactersOfText, firstCharactersOfText2, this._evaluator.isCaseInsensitive);
				}

				// Token: 0x060026BB RID: 9915 RVA: 0x000AC954 File Offset: 0x000AAB54
				int global::System.Collections.IComparer.Compare(object x, object y)
				{
					global::Infragistics.Windows.DataPresenter.Cell cell = x as global::Infragistics.Windows.DataPresenter.Cell;
					global::Infragistics.Windows.DataPresenter.Cell cell2 = y as global::Infragistics.Windows.DataPresenter.Cell;
					string cellText = cell.Record.GetCellText(cell.Field);
					string cellText2 = cell2.Record.GetCellText(cell2.Field);
					return this.CompareHelper(cellText, cellText2);
				}

				// Token: 0x0400131B RID: 4891
				private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.FirstCharactersEvaluator _evaluator;
			}
		}

		// Token: 0x02000322 RID: 802
		private class HourEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x060026BC RID: 9916 RVA: 0x000AC99C File Offset: 0x000AAB9C
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime groupByValueHelper = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.GetGroupByValueHelper(groupByRecord, record);
				return new global::System.DateTime(groupByValueHelper.Year, groupByValueHelper.Month, groupByValueHelper.Day, groupByValueHelper.Hour, 0, 0);
			}

			// Token: 0x060026BD RID: 9917 RVA: 0x000AC9DC File Offset: 0x000AABDC
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime dateTime;
				global::System.DateTime dateTime2;
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.DoesGroupContainRecordHelper(groupByRecord, record, out dateTime, out dateTime2) || (dateTime2.Date == dateTime.Date && dateTime2.Hour == dateTime.Hour);
			}

			// Token: 0x17000B77 RID: 2935
			// (get) Token: 0x060026BE RID: 9918 RVA: 0x000ACA1F File Offset: 0x000AAC1F
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

			// Token: 0x0400131C RID: 4892
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.HourEvaluator.Comparer _comparer;

			// Token: 0x02000323 RID: 803
			private class Comparer : global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateComparerBase
			{
				// Token: 0x060026C0 RID: 9920 RVA: 0x000ACA42 File Offset: 0x000AAC42
				protected override bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y)
				{
					return x.Date == y.Date && x.Hour == y.Hour;
				}
			}
		}

		// Token: 0x02000324 RID: 804
		private class MinuteEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x060026C2 RID: 9922 RVA: 0x000ACA74 File Offset: 0x000AAC74
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime groupByValueHelper = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.GetGroupByValueHelper(groupByRecord, record);
				return new global::System.DateTime(groupByValueHelper.Year, groupByValueHelper.Month, groupByValueHelper.Day, groupByValueHelper.Hour, groupByValueHelper.Minute, 0);
			}

			// Token: 0x060026C3 RID: 9923 RVA: 0x000ACAB8 File Offset: 0x000AACB8
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime dateTime;
				global::System.DateTime dateTime2;
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.DoesGroupContainRecordHelper(groupByRecord, record, out dateTime, out dateTime2) || (dateTime2.Date == dateTime.Date && dateTime2.Hour == dateTime.Hour && dateTime2.Minute == dateTime.Minute);
			}

			// Token: 0x17000B78 RID: 2936
			// (get) Token: 0x060026C4 RID: 9924 RVA: 0x000ACB0B File Offset: 0x000AAD0B
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

			// Token: 0x0400131D RID: 4893
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.MinuteEvaluator.Comparer _comparer;

			// Token: 0x02000325 RID: 805
			private class Comparer : global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateComparerBase
			{
				// Token: 0x060026C6 RID: 9926 RVA: 0x000ACB2E File Offset: 0x000AAD2E
				protected override bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y)
				{
					return x.Date == y.Date && x.Hour == y.Hour && x.Minute == y.Minute;
				}
			}
		}

		// Token: 0x02000326 RID: 806
		private class MonthEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x060026C8 RID: 9928 RVA: 0x000ACB70 File Offset: 0x000AAD70
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime groupByValueHelper = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.GetGroupByValueHelper(groupByRecord, record);
				return new global::System.DateTime(groupByValueHelper.Year, groupByValueHelper.Month, 1);
			}

			// Token: 0x060026C9 RID: 9929 RVA: 0x000ACBA0 File Offset: 0x000AADA0
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime dateTime;
				global::System.DateTime dateTime2;
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.DoesGroupContainRecordHelper(groupByRecord, record, out dateTime, out dateTime2) || (dateTime2.Year == dateTime.Year && dateTime2.Month == dateTime.Month);
			}

			// Token: 0x17000B79 RID: 2937
			// (get) Token: 0x060026CA RID: 9930 RVA: 0x000ACBDE File Offset: 0x000AADDE
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

			// Token: 0x0400131E RID: 4894
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.MonthEvaluator.Comparer _comparer;

			// Token: 0x02000327 RID: 807
			private class Comparer : global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateComparerBase
			{
				// Token: 0x060026CC RID: 9932 RVA: 0x000ACC01 File Offset: 0x000AAE01
				protected override bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y)
				{
					return x.Year == y.Year && x.Month == y.Month;
				}
			}
		}

		// Token: 0x02000328 RID: 808
		private class OutlookDateEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x060026CE RID: 9934 RVA: 0x000ACC2D File Offset: 0x000AAE2D
			internal OutlookDateEvaluator()
			{
			}

			// Token: 0x060026CF RID: 9935 RVA: 0x000ACC38 File Offset: 0x000AAE38
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

			// Token: 0x060026D0 RID: 9936 RVA: 0x000ACCAC File Offset: 0x000AAEAC
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

			// Token: 0x060026D1 RID: 9937 RVA: 0x000ACD1C File Offset: 0x000AAF1C
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

			// Token: 0x17000B7A RID: 2938
			// (get) Token: 0x060026D2 RID: 9938 RVA: 0x000ACDB5 File Offset: 0x000AAFB5
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

			// Token: 0x0400131F RID: 4895
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.Comparer _comparer;

			// Token: 0x04001320 RID: 4896
			private static global::System.Collections.Generic.Dictionary<global::System.Globalization.CultureInfo, global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.CultureCache> g_cultureCache;

			// Token: 0x02000329 RID: 809
			private class Comparer : global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateComparerBase
			{
				// Token: 0x060026D3 RID: 9939 RVA: 0x000ACDD1 File Offset: 0x000AAFD1
				internal Comparer(global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator evaluator)
				{
					this._evaluator = evaluator;
				}

				// Token: 0x060026D4 RID: 9940 RVA: 0x000ACDE0 File Offset: 0x000AAFE0
				public override int Compare(object x, object y)
				{
					global::Infragistics.Windows.DataPresenter.Cell cell = x as global::Infragistics.Windows.DataPresenter.Cell;
					this._cic = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.GetCultureInfoCache(cell.Record);
					return base.Compare(x, y);
				}

				// Token: 0x060026D5 RID: 9941 RVA: 0x000ACE0D File Offset: 0x000AB00D
				public override int Compare(global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo x, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo y)
				{
					this._cic = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.GetCultureInfoCache(x._record);
					return base.Compare(x, y);
				}

				// Token: 0x060026D6 RID: 9942 RVA: 0x000ACE28 File Offset: 0x000AB028
				protected override bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y)
				{
					global::Infragistics.Shared.DynamicResourceString dateLabel = this._cic.GetDateLabel(x);
					global::Infragistics.Shared.DynamicResourceString dateLabel2 = this._cic.GetDateLabel(y);
					return object.ReferenceEquals(dateLabel, dateLabel2);
				}

				// Token: 0x04001321 RID: 4897
				private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator _evaluator;

				// Token: 0x04001322 RID: 4898
				private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.OutlookDateEvaluator.CultureCache _cic;
			}

			// Token: 0x0200032A RID: 810
			private class CultureCache
			{
				// Token: 0x060026D7 RID: 9943 RVA: 0x000ACE58 File Offset: 0x000AB058
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

				// Token: 0x17000B7B RID: 2939
				// (get) Token: 0x060026D8 RID: 9944 RVA: 0x000AD1B0 File Offset: 0x000AB3B0
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

				// Token: 0x060026D9 RID: 9945 RVA: 0x000AD258 File Offset: 0x000AB458
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

				// Token: 0x060026DA RID: 9946 RVA: 0x000AD2DC File Offset: 0x000AB4DC
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

				// Token: 0x04001323 RID: 4899
				private global::System.Globalization.CultureInfo _culture;

				// Token: 0x04001324 RID: 4900
				internal readonly global::Infragistics.Shared.DynamicResourceString BEYOND_NEXT_MONTH;

				// Token: 0x04001325 RID: 4901
				internal readonly global::Infragistics.Shared.DynamicResourceString NEXT_MONTH;

				// Token: 0x04001326 RID: 4902
				internal readonly global::Infragistics.Shared.DynamicResourceString LATER_THIS_MONTH;

				// Token: 0x04001327 RID: 4903
				internal readonly global::Infragistics.Shared.DynamicResourceString THREE_WEEKS_AWAY;

				// Token: 0x04001328 RID: 4904
				internal readonly global::Infragistics.Shared.DynamicResourceString TWO_WEEKS_AWAY;

				// Token: 0x04001329 RID: 4905
				internal readonly global::Infragistics.Shared.DynamicResourceString NEXT_WEEK;

				// Token: 0x0400132A RID: 4906
				internal readonly global::Infragistics.Shared.DynamicResourceString TODAY;

				// Token: 0x0400132B RID: 4907
				internal readonly global::Infragistics.Shared.DynamicResourceString YESTERDAY;

				// Token: 0x0400132C RID: 4908
				internal readonly global::Infragistics.Shared.DynamicResourceString SUNDAY;

				// Token: 0x0400132D RID: 4909
				internal readonly global::Infragistics.Shared.DynamicResourceString MONDAY;

				// Token: 0x0400132E RID: 4910
				internal readonly global::Infragistics.Shared.DynamicResourceString TUESDAY;

				// Token: 0x0400132F RID: 4911
				internal readonly global::Infragistics.Shared.DynamicResourceString WEDNESDAY;

				// Token: 0x04001330 RID: 4912
				internal readonly global::Infragistics.Shared.DynamicResourceString THURSDAY;

				// Token: 0x04001331 RID: 4913
				internal readonly global::Infragistics.Shared.DynamicResourceString FRIDAY;

				// Token: 0x04001332 RID: 4914
				internal readonly global::Infragistics.Shared.DynamicResourceString SATURDAY;

				// Token: 0x04001333 RID: 4915
				internal readonly global::Infragistics.Shared.DynamicResourceString LAST_WEEK;

				// Token: 0x04001334 RID: 4916
				internal readonly global::Infragistics.Shared.DynamicResourceString TWO_WEEKS_AGO;

				// Token: 0x04001335 RID: 4917
				internal readonly global::Infragistics.Shared.DynamicResourceString THREE_WEEKS_AGO;

				// Token: 0x04001336 RID: 4918
				internal readonly global::Infragistics.Shared.DynamicResourceString EARLIER_THIS_MONTH;

				// Token: 0x04001337 RID: 4919
				internal readonly global::Infragistics.Shared.DynamicResourceString LAST_MONTH;

				// Token: 0x04001338 RID: 4920
				internal readonly global::Infragistics.Shared.DynamicResourceString OLDER;

				// Token: 0x04001339 RID: 4921
				internal readonly global::Infragistics.Shared.DynamicResourceString NONE;

				// Token: 0x0400133A RID: 4922
				private global::System.Collections.ArrayList dateInfos;

				// Token: 0x0400133B RID: 4923
				private global::System.DateTime lastUpdated;

				// Token: 0x0400133C RID: 4924
				private global::System.Collections.Generic.Dictionary<global::System.DayOfWeek, global::Infragistics.Shared.DynamicResourceString> dayMap;
			}

			// Token: 0x0200032B RID: 811
			private class DateInfo
			{
				// Token: 0x060026DB RID: 9947 RVA: 0x000AD6DA File Offset: 0x000AB8DA
				internal DateInfo(global::System.DateTime begin, global::System.DateTime end, global::Infragistics.Shared.DynamicResourceString label)
				{
					this.beginDate = begin;
					this.endDate = end;
					this.dateLabel = label;
				}

				// Token: 0x060026DC RID: 9948 RVA: 0x000AD6F8 File Offset: 0x000AB8F8
				internal bool Contains(global::System.DateTime date)
				{
					return this.beginDate.Date <= date.Date && date.Date <= this.endDate.Date;
				}

				// Token: 0x17000B7C RID: 2940
				// (get) Token: 0x060026DD RID: 9949 RVA: 0x000AD73D File Offset: 0x000AB93D
				internal global::Infragistics.Shared.DynamicResourceString DateLabel
				{
					get
					{
						return this.dateLabel;
					}
				}

				// Token: 0x0400133D RID: 4925
				private readonly global::System.DateTime beginDate;

				// Token: 0x0400133E RID: 4926
				private readonly global::System.DateTime endDate;

				// Token: 0x0400133F RID: 4927
				private readonly global::Infragistics.Shared.DynamicResourceString dateLabel;
			}
		}

		// Token: 0x0200032C RID: 812
		private class QuarterEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x060026DE RID: 9950 RVA: 0x000AD748 File Offset: 0x000AB948
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

			// Token: 0x060026DF RID: 9951 RVA: 0x000AD798 File Offset: 0x000AB998
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime dateTime;
				global::System.DateTime dateTime2;
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.DoesGroupContainRecordHelper(groupByRecord, record, out dateTime, out dateTime2) || (dateTime2.Year == dateTime.Year && dateTime2.Month >= dateTime.Month && dateTime2.Month < dateTime.Month + 3);
			}

			// Token: 0x17000B7D RID: 2941
			// (get) Token: 0x060026E0 RID: 9952 RVA: 0x000AD7E8 File Offset: 0x000AB9E8
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

			// Token: 0x04001340 RID: 4928
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.QuarterEvaluator.Comparer _comparer;

			// Token: 0x0200032D RID: 813
			private class Comparer : global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateComparerBase
			{
				// Token: 0x060026E2 RID: 9954 RVA: 0x000AD80B File Offset: 0x000ABA0B
				protected override bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y)
				{
					return x.Year == y.Year && (x.Month - 1) / 3 == (y.Month - 1) / 3;
				}
			}
		}

		// Token: 0x0200032E RID: 814
		private class SecondEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x060026E4 RID: 9956 RVA: 0x000AD840 File Offset: 0x000ABA40
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime groupByValueHelper = global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.GetGroupByValueHelper(groupByRecord, record);
				return new global::System.DateTime(groupByValueHelper.Year, groupByValueHelper.Month, groupByValueHelper.Day, groupByValueHelper.Hour, groupByValueHelper.Minute, groupByValueHelper.Second);
			}

			// Token: 0x060026E5 RID: 9957 RVA: 0x000AD88C File Offset: 0x000ABA8C
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime dateTime;
				global::System.DateTime dateTime2;
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.DoesGroupContainRecordHelper(groupByRecord, record, out dateTime, out dateTime2) || (dateTime2.Date == dateTime.Date && dateTime2.Hour == dateTime.Hour && dateTime2.Minute == dateTime.Minute && dateTime2.Second == dateTime.Second);
			}

			// Token: 0x17000B7E RID: 2942
			// (get) Token: 0x060026E6 RID: 9958 RVA: 0x000AD8EF File Offset: 0x000ABAEF
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

			// Token: 0x04001341 RID: 4929
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.SecondEvaluator.Comparer _comparer;

			// Token: 0x0200032F RID: 815
			private class Comparer : global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateComparerBase
			{
				// Token: 0x060026E8 RID: 9960 RVA: 0x000AD914 File Offset: 0x000ABB14
				protected override bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y)
				{
					return x.Date == y.Date && x.Hour == y.Hour && x.Minute == y.Minute && x.Second == y.Second;
				}
			}
		}

		// Token: 0x02000330 RID: 816
		internal class ValueEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x060026EA RID: 9962 RVA: 0x000AD970 File Offset: 0x000ABB70
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				return groupByRecord.Value;
			}

			// Token: 0x060026EB RID: 9963 RVA: 0x000AD978 File Offset: 0x000ABB78
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

			// Token: 0x17000B7F RID: 2943
			// (get) Token: 0x060026EC RID: 9964 RVA: 0x000AD9C1 File Offset: 0x000ABBC1
			public global::System.Collections.IComparer SortComparer
			{
				get
				{
					return null;
				}
			}
		}

		// Token: 0x02000331 RID: 817
		private class YearEvaluator : global::Infragistics.Windows.DataPresenter.IGroupByEvaluator
		{
			// Token: 0x060026EE RID: 9966 RVA: 0x000AD9CC File Offset: 0x000ABBCC
			object global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				return new global::System.DateTime(global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.GetGroupByValueHelper(groupByRecord, record).Year, 1, 1);
			}

			// Token: 0x060026EF RID: 9967 RVA: 0x000AD9F4 File Offset: 0x000ABBF4
			bool global::Infragistics.Windows.DataPresenter.IGroupByEvaluator.DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::System.DateTime dateTime;
				global::System.DateTime dateTime2;
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateEvaluator.DoesGroupContainRecordHelper(groupByRecord, record, out dateTime, out dateTime2) || dateTime2.Year == dateTime.Year;
			}

			// Token: 0x17000B80 RID: 2944
			// (get) Token: 0x060026F0 RID: 9968 RVA: 0x000ADA20 File Offset: 0x000ABC20
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

			// Token: 0x04001342 RID: 4930
			private global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.YearEvaluator.Comparer _comparer;

			// Token: 0x02000332 RID: 818
			private class Comparer : global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.DateComparerBase
			{
				// Token: 0x060026F2 RID: 9970 RVA: 0x000ADA43 File Offset: 0x000ABC43
				protected override bool AreInSameGroupBy(global::System.DateTime x, global::System.DateTime y)
				{
					return x.Year == y.Year;
				}
			}
		}
	}
}
