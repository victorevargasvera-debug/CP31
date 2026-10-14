using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000158 RID: 344
	internal abstract class FilterConditionEvaluationContextBase : global::Infragistics.Windows.Controls.ConditionEvaluationContext
	{
		// Token: 0x06001484 RID: 5252 RVA: 0x0005BB48 File Offset: 0x00059D48
		protected FilterConditionEvaluationContextBase(global::Infragistics.Windows.DataPresenter.Field field, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> allValuesRecords)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
			this._field = field;
			this._allValuesRecords = allValuesRecords;
			this._filterComparer = this._field.FilterComparerResolved;
			this._filterEvaluator = this._field.FilterEvaluatorResolved;
			this._ignoreCase = (global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseInsensitive == this._field.FilterStringComparisonTypeResolved);
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0005BBA8 File Offset: 0x00059DA8
		public override object ConvertValue(object x, global::System.Type targetType)
		{
			if (this._field != null && !(targetType == typeof(string)) && !string.IsNullOrEmpty(x as string))
			{
				if (this._converterInfo == null)
				{
					this._converterInfo = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(this._field);
					global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = this._converterInfo.Editor as global::Infragistics.Windows.Editors.XamMaskedEditor;
					if (xamMaskedEditor != null && xamMaskedEditor.Value is global::System.DateTime)
					{
						global::System.DateTime d = (global::System.DateTime)xamMaskedEditor.Value;
						if (d.Date != d)
						{
							global::Infragistics.Windows.DataPresenter.TemplateDataRecord templateDataRecord = this._field.Owner.TemplateDataRecord as global::Infragistics.Windows.DataPresenter.TemplateDataRecord;
							if (templateDataRecord != null)
							{
								templateDataRecord.SetValue(this._field, global::System.DateTime.Now.Date);
							}
						}
					}
				}
				if (this._converterInfo != null)
				{
					global::System.Type valueType = this._converterInfo.ValueType;
					if (valueType != typeof(object) && valueType != typeof(string))
					{
						global::System.Exception ex;
						object obj = this._converterInfo.ConvertDisplayText(x as string, out ex);
						if (ex == null && obj != null)
						{
							if (obj.GetType() == targetType)
							{
								return obj;
							}
							x = obj;
						}
					}
				}
			}
			return base.ConvertValue(x, targetType);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0005BCE8 File Offset: 0x00059EE8
		internal object GetCellValueForFilterComparison(global::Infragistics.Windows.DataPresenter.DataRecord dr)
		{
			global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(this._field);
			string text;
			return global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.GetCellValueForFilterComparisonHelper(cachedConverter, dr, false, out text);
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0005BD0C File Offset: 0x00059F0C
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

		// Token: 0x06001488 RID: 5256 RVA: 0x0005BD6C File Offset: 0x00059F6C
		internal static global::System.Type GetValueTypeForQuantitativeFilterComparison(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(field);
			if (cachedConverter == null || !cachedConverter.CompareByText)
			{
				return field.EditAsTypeResolved;
			}
			return typeof(string);
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x0005BD9C File Offset: 0x00059F9C
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

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x0005BDBE File Offset: 0x00059FBE
		public override global::System.Collections.IComparer Comparer
		{
			get
			{
				return this._filterComparer;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x0005BDC6 File Offset: 0x00059FC6
		internal override global::Infragistics.Windows.Controls.IFilterEvaluator FilterEvaluator
		{
			get
			{
				return this._filterEvaluator;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0005BDCE File Offset: 0x00059FCE
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x0005BDD6 File Offset: 0x00059FD6
		public override bool IgnoreCase
		{
			get
			{
				return this._ignoreCase;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x0005BDE0 File Offset: 0x00059FE0
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

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x0005BE30 File Offset: 0x0005A030
		// (set) Token: 0x06001490 RID: 5264 RVA: 0x0005BE38 File Offset: 0x0005A038
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

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x0005BE41 File Offset: 0x0005A041
		internal bool WasAllValuesUsed
		{
			get
			{
				return null != this._cachedAllValues;
			}
		}

		// Token: 0x04000865 RID: 2149
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000866 RID: 2150
		private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> _allValuesRecords;

		// Token: 0x04000867 RID: 2151
		private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Controls.ValueEntry> _cachedAllValues;

		// Token: 0x04000868 RID: 2152
		private global::Infragistics.Windows.DataPresenter.CellTextConverterInfo _converterInfo;

		// Token: 0x04000869 RID: 2153
		private object _currentCellValueForFilterComparison;

		// Token: 0x0400086A RID: 2154
		private global::System.Collections.IComparer _filterComparer;

		// Token: 0x0400086B RID: 2155
		private global::Infragistics.Windows.Controls.IFilterEvaluator _filterEvaluator;

		// Token: 0x0400086C RID: 2156
		private bool _ignoreCase;

		// Token: 0x02000159 RID: 345
		private class AllValuesEnumerable : global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Controls.ValueEntry>, global::System.Collections.IEnumerable
		{
			// Token: 0x06001492 RID: 5266 RVA: 0x0005BE4F File Offset: 0x0005A04F
			internal AllValuesEnumerable(global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase context, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> records)
			{
				this._e = new global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.AllValuesEnumerable.Enumerator(context, records.GetEnumerator());
			}

			// Token: 0x06001493 RID: 5267 RVA: 0x0005BE69 File Offset: 0x0005A069
			public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Controls.ValueEntry> GetEnumerator()
			{
				return this._e.Clone();
			}

			// Token: 0x06001494 RID: 5268 RVA: 0x0005BE76 File Offset: 0x0005A076
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0400086D RID: 2157
			private global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.AllValuesEnumerable.Enumerator _e;

			// Token: 0x0200015A RID: 346
			private class Enumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Controls.ValueEntry>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x06001495 RID: 5269 RVA: 0x0005BE7E File Offset: 0x0005A07E
				internal Enumerator(global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase context, global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.DataRecord> records)
				{
					this._context = context;
					this._field = context._field;
					this._records = records;
					this.Reset();
				}

				// Token: 0x17000521 RID: 1313
				// (get) Token: 0x06001496 RID: 5270 RVA: 0x0005BEA6 File Offset: 0x0005A0A6
				public global::Infragistics.Windows.Controls.ValueEntry Current
				{
					get
					{
						return this._current;
					}
				}

				// Token: 0x06001497 RID: 5271 RVA: 0x0005BEAE File Offset: 0x0005A0AE
				public void Dispose()
				{
				}

				// Token: 0x17000522 RID: 1314
				// (get) Token: 0x06001498 RID: 5272 RVA: 0x0005BEB0 File Offset: 0x0005A0B0
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x06001499 RID: 5273 RVA: 0x0005BEB8 File Offset: 0x0005A0B8
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

				// Token: 0x0600149A RID: 5274 RVA: 0x0005BF06 File Offset: 0x0005A106
				public void Reset()
				{
					this._current = null;
					this._records.Reset();
				}

				// Token: 0x0600149B RID: 5275 RVA: 0x0005BF1A File Offset: 0x0005A11A
				internal global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.AllValuesEnumerable.Enumerator Clone()
				{
					return new global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.AllValuesEnumerable.Enumerator(this._context, this._records);
				}

				// Token: 0x0400086E RID: 2158
				private global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.DataRecord> _records;

				// Token: 0x0400086F RID: 2159
				private global::Infragistics.Windows.DataPresenter.Field _field;

				// Token: 0x04000870 RID: 2160
				private global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.FilterValueEntry _current;

				// Token: 0x04000871 RID: 2161
				private global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase _context;
			}
		}

		// Token: 0x0200015B RID: 347
		internal abstract class FilterValueEntryBase : global::Infragistics.Windows.Controls.ValueEntry
		{
			// Token: 0x0600149C RID: 5276 RVA: 0x0005BF2D File Offset: 0x0005A12D
			internal FilterValueEntryBase(global::Infragistics.Windows.DataPresenter.Field field, object value)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
				this._field = field;
				this._value = value;
			}

			// Token: 0x17000523 RID: 1315
			// (get) Token: 0x0600149D RID: 5277 RVA: 0x0005BF49 File Offset: 0x0005A149
			public override global::System.Globalization.CultureInfo Culture
			{
				get
				{
					return global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.FilterValueEntryBase.GetCulture(this._field);
				}
			}

			// Token: 0x17000524 RID: 1316
			// (get) Token: 0x0600149E RID: 5278 RVA: 0x0005BF56 File Offset: 0x0005A156
			public global::Infragistics.Windows.DataPresenter.Field Field
			{
				get
				{
					return this._field;
				}
			}

			// Token: 0x17000525 RID: 1317
			// (get) Token: 0x0600149F RID: 5279 RVA: 0x0005BF5E File Offset: 0x0005A15E
			public override string Format
			{
				get
				{
					return global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.FilterValueEntryBase.GetFormat(this._field);
				}
			}

			// Token: 0x17000526 RID: 1318
			// (get) Token: 0x060014A0 RID: 5280 RVA: 0x0005BF6B File Offset: 0x0005A16B
			public override object Value
			{
				get
				{
					return this._value;
				}
			}

			// Token: 0x060014A1 RID: 5281 RVA: 0x0005BF74 File Offset: 0x0005A174
			internal static global::System.Globalization.CultureInfo GetCulture(global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::System.Globalization.CultureInfo cultureInfo = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(field).FormatProvider as global::System.Globalization.CultureInfo;
				if (cultureInfo != null)
				{
					return cultureInfo;
				}
				return global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture(field);
			}

			// Token: 0x060014A2 RID: 5282 RVA: 0x0005BF9D File Offset: 0x0005A19D
			internal static string GetFormat(global::Infragistics.Windows.DataPresenter.Field field)
			{
				return global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(field).Format;
			}

			// Token: 0x04000872 RID: 2162
			private global::Infragistics.Windows.DataPresenter.Field _field;

			// Token: 0x04000873 RID: 2163
			private object _value;
		}

		// Token: 0x0200015C RID: 348
		internal class FilterValueEntry : global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.FilterValueEntryBase
		{
			// Token: 0x060014A3 RID: 5283 RVA: 0x0005BFAA File Offset: 0x0005A1AA
			internal FilterValueEntry(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.DataRecord record, object value) : base(field, value)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(record);
				this._record = record;
			}

			// Token: 0x17000527 RID: 1319
			// (get) Token: 0x060014A4 RID: 5284 RVA: 0x0005BFC1 File Offset: 0x0005A1C1
			public override object Context
			{
				get
				{
					return this._record.Cells[base.Field];
				}
			}

			// Token: 0x04000874 RID: 2164
			private global::Infragistics.Windows.DataPresenter.DataRecord _record;
		}
	}
}
