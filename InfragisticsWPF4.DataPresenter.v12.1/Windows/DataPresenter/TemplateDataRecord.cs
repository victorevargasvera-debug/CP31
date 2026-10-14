using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000303 RID: 771
	internal class TemplateDataRecord : global::Infragistics.Windows.DataPresenter.DataRecord
	{
		// Token: 0x06002439 RID: 9273 RVA: 0x0009DD51 File Offset: 0x0009BF51
		internal TemplateDataRecord(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection) : base(fieldLayout, parentCollection)
		{
			this._values = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, object>();
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x0009DD68 File Offset: 0x0009BF68
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

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x0600243B RID: 9275 RVA: 0x0009DDB2 File Offset: 0x0009BFB2
		internal override bool IsTemplateDataRecord
		{
			get
			{
				return base.FieldLayout != null && base.FieldLayout.TemplateDataRecord == this;
			}
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x0009DDCC File Offset: 0x0009BFCC
		internal override bool SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter, out global::Infragistics.Windows.DataPresenter.DataErrorInfo errorInfo, bool dontSetDataChanged)
		{
			errorInfo = null;
			return false;
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x0600243D RID: 9277 RVA: 0x0009DDD3 File Offset: 0x0009BFD3
		internal override global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableChildRecordsIfNeeded
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x0009DDD8 File Offset: 0x0009BFD8
		internal void ClearAll()
		{
			global::Infragistics.Windows.DataPresenter.Field[] array = new global::Infragistics.Windows.DataPresenter.Field[this._values.Keys.Count];
			this._values.Keys.CopyTo(array, 0);
			foreach (global::Infragistics.Windows.DataPresenter.Field field in array)
			{
				this.ClearValue(field);
			}
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x0009DE28 File Offset: 0x0009C028
		internal void ClearValue(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._values.ContainsKey(field))
			{
				this._values.Remove(field);
				this.UpdateCell(field);
			}
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x0009DE4C File Offset: 0x0009C04C
		internal void SetValue(global::Infragistics.Windows.DataPresenter.Field field, object value)
		{
			this._values[field] = value;
			this.UpdateCell(field);
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x0009DE64 File Offset: 0x0009C064
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

		// Token: 0x06002442 RID: 9282 RVA: 0x0009DEB4 File Offset: 0x0009C0B4
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

		// Token: 0x04001182 RID: 4482
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, object> _values;

		// Token: 0x04001183 RID: 4483
		private int _lastCacheVersion;
	}
}
