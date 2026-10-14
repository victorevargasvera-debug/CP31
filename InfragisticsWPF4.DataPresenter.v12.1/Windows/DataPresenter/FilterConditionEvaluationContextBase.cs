using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200013C RID: 316
	internal abstract class FilterConditionEvaluationContextBase : global::Infragistics.Windows.Controls.ConditionEvaluationContext
	{
		// Token: 0x0600111B RID: 4379 RVA: 0x0004A84C File Offset: 0x00048A4C
		protected FilterConditionEvaluationContextBase(global::Infragistics.Windows.DataPresenter.Field field, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> allValuesRecords)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
			this._field = field;
			this._allValuesRecords = allValuesRecords;
			this._filterComparer = this._field.FilterComparerResolved;
			this._filterEvaluator = this._field.FilterEvaluatorResolved;
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0004A88C File Offset: 0x00048A8C
		internal object GetCellValueForFilterComparison(global::Infragistics.Windows.DataPresenter.DataRecord dr)
		{
			global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(this._field);
			string text;
			return global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.GetCellValueForFilterComparisonHelper(cachedConverter, dr, false, out text);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0004A8B0 File Offset: 0x00048AB0
		internal static object GetCellValueForFilterComparisonHelper(global::Infragistics.Windows.DataPresenter.CellTextConverterInfo info, global::Infragistics.Windows.DataPresenter.DataRecord dr, bool getText, out string cellText)
		{
			cellText = null;
			object obj = dr.GetCellValue(info.Field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
			if (info.CompareByText)
			{
				string text = info.ConvertCellValue(obj);
				obj = text;
				if (getText)
				{
					cellText = text;
				}
			}
			else
			{
				if (obj is global::System.DateTime)
				{
					obj = info.GetVisiblePortion((global::System.DateTime)obj);
				}
				if (getText)
				{
					cellText = info.ConvertCellValue(obj);
				}
			}
			return obj;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0004A910 File Offset: 0x00048B10
		internal static global::System.Type GetValueTypeForQuantitativeFilterComparison(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(field);
			if (cachedConverter == null || !cachedConverter.CompareByText)
			{
				return field.EditAsTypeResolved;
			}
			return typeof(string);
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x0004A940 File Offset: 0x00048B40
		public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Controls.ValueEntry> AllValues
		{
			get
			{
				if (this._cachedAllValues == null)
				{
					this._cachedAllValues = new global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.AllValuesEnumerable(this, this._allValuesRecords);
				}
				return this._cachedAllValues;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001120 RID: 4384 RVA: 0x0004A962 File Offset: 0x00048B62
		public override global::System.Collections.IComparer Comparer
		{
			get
			{
				return this._filterComparer;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x0004A96A File Offset: 0x00048B6A
		internal override global::Infragistics.Windows.Controls.IFilterEvaluator FilterEvaluator
		{
			get
			{
				return this._filterEvaluator;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x0004A972 File Offset: 0x00048B72
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x0004A97A File Offset: 0x00048B7A
		public override bool IgnoreCase
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseInsensitive == this._field.FilterStringComparisonTypeResolved;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x0004A98C File Offset: 0x00048B8C
		public override global::System.Type PreferredComparisonDataType
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(this._field);
				if (cachedConverter != null && cachedConverter.CompareByText)
				{
					return typeof(string);
				}
				global::System.Type type = this._field.EditAsTypeResolved;
				if (typeof(string) == type)
				{
					type = null;
				}
				return type;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x0004A9DC File Offset: 0x00048BDC
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x0004A9E4 File Offset: 0x00048BE4
		internal object CurrentCellValueForFilterComparison
		{
			get
			{
				return this._currentCellValueForFilterComparison;
			}
			set
			{
				this._currentCellValueForFilterComparison = value;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x0004A9ED File Offset: 0x00048BED
		internal bool WasAllValuesUsed
		{
			get
			{
				return null != this._cachedAllValues;
			}
		}

		// Token: 0x040006BF RID: 1727
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x040006C0 RID: 1728
		private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> _allValuesRecords;

		// Token: 0x040006C1 RID: 1729
		private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Controls.ValueEntry> _cachedAllValues;

		// Token: 0x040006C2 RID: 1730
		private object _currentCellValueForFilterComparison;

		// Token: 0x040006C3 RID: 1731
		private global::System.Collections.IComparer _filterComparer;

		// Token: 0x040006C4 RID: 1732
		private global::Infragistics.Windows.Controls.IFilterEvaluator _filterEvaluator;

		// Token: 0x0200013D RID: 317
		private class AllValuesEnumerable : global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Controls.ValueEntry>, global::System.Collections.IEnumerable
		{
			// Token: 0x06001128 RID: 4392 RVA: 0x0004A9FB File Offset: 0x00048BFB
			internal AllValuesEnumerable(global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase context, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> records)
			{
				this._e = new global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.AllValuesEnumerable.Enumerator(context, records.GetEnumerator());
			}

			// Token: 0x06001129 RID: 4393 RVA: 0x0004AA15 File Offset: 0x00048C15
			public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Controls.ValueEntry> GetEnumerator()
			{
				return this._e.Clone();
			}

			// Token: 0x0600112A RID: 4394 RVA: 0x0004AA22 File Offset: 0x00048C22
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x040006C5 RID: 1733
			private global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.AllValuesEnumerable.Enumerator _e;

			// Token: 0x0200013E RID: 318
			private class Enumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Controls.ValueEntry>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x0600112B RID: 4395 RVA: 0x0004AA2A File Offset: 0x00048C2A
				internal Enumerator(global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase context, global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.DataRecord> records)
				{
					this._context = context;
					this._field = context._field;
					this._records = records;
					this.Reset();
				}

				// Token: 0x170003E2 RID: 994
				// (get) Token: 0x0600112C RID: 4396 RVA: 0x0004AA52 File Offset: 0x00048C52
				public global::Infragistics.Windows.Controls.ValueEntry Current
				{
					get
					{
						return this._current;
					}
				}

				// Token: 0x0600112D RID: 4397 RVA: 0x0004AA5A File Offset: 0x00048C5A
				public void Dispose()
				{
				}

				// Token: 0x170003E3 RID: 995
				// (get) Token: 0x0600112E RID: 4398 RVA: 0x0004AA5C File Offset: 0x00048C5C
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x0600112F RID: 4399 RVA: 0x0004AA64 File Offset: 0x00048C64
				public bool MoveNext()
				{
					if (this._records.MoveNext())
					{
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._records.Current;
						this._current = new global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.FilterValueEntry(this._field, dataRecord, this._context.GetCellValueForFilterComparison(dataRecord));
						return true;
					}
					this._current = null;
					return false;
				}

				// Token: 0x06001130 RID: 4400 RVA: 0x0004AAB2 File Offset: 0x00048CB2
				public void Reset()
				{
					this._current = null;
					this._records.Reset();
				}

				// Token: 0x06001131 RID: 4401 RVA: 0x0004AAC6 File Offset: 0x00048CC6
				internal global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.AllValuesEnumerable.Enumerator Clone()
				{
					return new global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.AllValuesEnumerable.Enumerator(this._context, this._records);
				}

				// Token: 0x040006C6 RID: 1734
				private global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.DataRecord> _records;

				// Token: 0x040006C7 RID: 1735
				private global::Infragistics.Windows.DataPresenter.Field _field;

				// Token: 0x040006C8 RID: 1736
				private global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.FilterValueEntry _current;

				// Token: 0x040006C9 RID: 1737
				private global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase _context;
			}
		}

		// Token: 0x0200013F RID: 319
		internal abstract class FilterValueEntryBase : global::Infragistics.Windows.Controls.ValueEntry
		{
			// Token: 0x06001132 RID: 4402 RVA: 0x0004AAD9 File Offset: 0x00048CD9
			internal FilterValueEntryBase(global::Infragistics.Windows.DataPresenter.Field field, object value)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
				this._field = field;
				this._value = value;
			}

			// Token: 0x170003E4 RID: 996
			// (get) Token: 0x06001133 RID: 4403 RVA: 0x0004AAF5 File Offset: 0x00048CF5
			public override global::System.Globalization.CultureInfo Culture
			{
				get
				{
					return global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.FilterValueEntryBase.GetCulture(this._field);
				}
			}

			// Token: 0x170003E5 RID: 997
			// (get) Token: 0x06001134 RID: 4404 RVA: 0x0004AB02 File Offset: 0x00048D02
			public global::Infragistics.Windows.DataPresenter.Field Field
			{
				get
				{
					return this._field;
				}
			}

			// Token: 0x170003E6 RID: 998
			// (get) Token: 0x06001135 RID: 4405 RVA: 0x0004AB0A File Offset: 0x00048D0A
			public override string Format
			{
				get
				{
					return global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.FilterValueEntryBase.GetFormat(this._field);
				}
			}

			// Token: 0x170003E7 RID: 999
			// (get) Token: 0x06001136 RID: 4406 RVA: 0x0004AB17 File Offset: 0x00048D17
			public override object Value
			{
				get
				{
					return this._value;
				}
			}

			// Token: 0x06001137 RID: 4407 RVA: 0x0004AB1F File Offset: 0x00048D1F
			internal static global::System.Globalization.CultureInfo GetCulture(global::Infragistics.Windows.DataPresenter.Field field)
			{
				return global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture(field);
			}

			// Token: 0x06001138 RID: 4408 RVA: 0x0004AB27 File Offset: 0x00048D27
			internal static string GetFormat(global::Infragistics.Windows.DataPresenter.Field field)
			{
				return null;
			}

			// Token: 0x040006CA RID: 1738
			private global::Infragistics.Windows.DataPresenter.Field _field;

			// Token: 0x040006CB RID: 1739
			private object _value;
		}

		// Token: 0x02000140 RID: 320
		internal class FilterValueEntry : global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.FilterValueEntryBase
		{
			// Token: 0x06001139 RID: 4409 RVA: 0x0004AB2A File Offset: 0x00048D2A
			internal FilterValueEntry(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.DataRecord record, object value) : base(field, value)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(record);
				this._record = record;
			}

			// Token: 0x170003E8 RID: 1000
			// (get) Token: 0x0600113A RID: 4410 RVA: 0x0004AB41 File Offset: 0x00048D41
			public override object Context
			{
				get
				{
					return this._record.Cells[base.Field];
				}
			}

			// Token: 0x040006CC RID: 1740
			private global::Infragistics.Windows.DataPresenter.DataRecord _record;
		}
	}
}
