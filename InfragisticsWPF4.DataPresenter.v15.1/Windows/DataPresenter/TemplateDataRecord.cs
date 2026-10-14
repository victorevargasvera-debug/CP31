using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000344 RID: 836
	internal class TemplateDataRecord : global::Infragistics.Windows.DataPresenter.DataRecord
	{
		// Token: 0x060027E9 RID: 10217 RVA: 0x000B1AB9 File Offset: 0x000AFCB9
		internal TemplateDataRecord(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection) : base(fieldLayout, parentCollection)
		{
			this._values = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, object>();
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x000B1AD0 File Offset: 0x000AFCD0
		public override object GetCellValue(global::Infragistics.Windows.DataPresenter.Field field, bool useConverter)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
			if (field.Owner != base.FieldLayout)
			{
				throw new global::System.ArgumentException();
			}
			object defaultDataForType;
			if (!this._values.TryGetValue(field, out defaultDataForType))
			{
				defaultDataForType = global::Infragistics.Windows.DataPresenter.Field.GetDefaultDataForType(field.EditAsTypeResolved, field.DataType);
			}
			return defaultDataForType;
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x000B1B1A File Offset: 0x000AFD1A
		internal override bool IsTemplateDataRecord
		{
			get
			{
				return base.FieldLayout != null && base.FieldLayout.TemplateDataRecord == this;
			}
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x000B1B34 File Offset: 0x000AFD34
		internal override bool SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter, out global::Infragistics.Windows.DataPresenter.DataErrorInfo errorInfo, bool dontSetDataChanged)
		{
			errorInfo = null;
			return false;
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x060027ED RID: 10221 RVA: 0x000B1B3B File Offset: 0x000AFD3B
		internal override global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableChildRecordsIfNeeded
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x000B1B40 File Offset: 0x000AFD40
		internal void ClearAll()
		{
			global::Infragistics.Windows.DataPresenter.Field[] array = new global::Infragistics.Windows.DataPresenter.Field[this._values.Keys.Count];
			this._values.Keys.CopyTo(array, 0);
			foreach (global::Infragistics.Windows.DataPresenter.Field field in array)
			{
				this.ClearValue(field);
			}
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x000B1B90 File Offset: 0x000AFD90
		internal void ClearValue(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._values.ContainsKey(field))
			{
				this._values.Remove(field);
				this.UpdateCell(field);
			}
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x000B1BB4 File Offset: 0x000AFDB4
		internal void SetValue(global::Infragistics.Windows.DataPresenter.Field field, object value)
		{
			this._values[field] = value;
			this.UpdateCell(field);
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x000B1BCC File Offset: 0x000AFDCC
		private void UpdateCell(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.Cell cell = base.Cells[field];
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = cell.AssociatedCellValuePresenterInternal;
			if (cellValuePresenter == null)
			{
				cellValuePresenter = global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetCellPresenter(field, base.FieldLayout.TemplateDataRecordCache);
				cell.AssociatedCellValuePresenterInternal = cellValuePresenter;
			}
			if (cellValuePresenter != null)
			{
				cellValuePresenter.SetValueInternal(base.GetCellValue(field), false);
			}
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x000B1C1C File Offset: 0x000AFE1C
		internal void VerifyCachedCellElements()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
			if (this._lastCacheVersion != fieldLayout.TemplateDataRecordCache.CacheVersion)
			{
				this._lastCacheVersion = fieldLayout.TemplateDataRecordCache.CacheVersion;
				global::Infragistics.Windows.DataPresenter.FieldCollection fields = fieldLayout.Fields;
				int i = 0;
				int count = fields.Count;
				while (i < count)
				{
					global::Infragistics.Windows.DataPresenter.Cell cellIfAllocated = base.GetCellIfAllocated(fields[i]);
					if (cellIfAllocated != null)
					{
						cellIfAllocated.AssociatedCellValuePresenterInternal = null;
					}
					i++;
				}
			}
		}

		// Token: 0x040013A2 RID: 5026
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, object> _values;

		// Token: 0x040013A3 RID: 5027
		private int _lastCacheVersion;
	}
}
