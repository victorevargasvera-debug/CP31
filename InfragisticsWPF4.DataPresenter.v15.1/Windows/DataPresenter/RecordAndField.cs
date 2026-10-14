using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000208 RID: 520
	internal class RecordAndField
	{
		// Token: 0x06001F9C RID: 8092 RVA: 0x00089874 File Offset: 0x00087A74
		internal RecordAndField(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Field field, bool useWeakReferences)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(record);
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
			if (useWeakReferences)
			{
				this._record = new global::System.WeakReference(record);
				this._field = new global::System.WeakReference(field);
				return;
			}
			this._record = record;
			this._field = field;
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x000898B4 File Offset: 0x00087AB4
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				global::System.WeakReference weakReference = this._record as global::System.WeakReference;
				if (weakReference != null)
				{
					return (global::Infragistics.Windows.DataPresenter.Record)global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(weakReference);
				}
				return (global::Infragistics.Windows.DataPresenter.Record)this._record;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001F9E RID: 8094 RVA: 0x000898E8 File Offset: 0x00087AE8
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				global::System.WeakReference weakReference = this._field as global::System.WeakReference;
				if (weakReference != null)
				{
					return (global::Infragistics.Windows.DataPresenter.Field)global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(weakReference);
				}
				return (global::Infragistics.Windows.DataPresenter.Field)this._field;
			}
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x0008991C File Offset: 0x00087B1C
		public override int GetHashCode()
		{
			global::Infragistics.Windows.DataPresenter.Record record = this.Record;
			global::Infragistics.Windows.DataPresenter.Field field = this.Field;
			return ((record != null) ? record.GetHashCode() : 1) ^ ((field != null) ? field.GetHashCode() : 2);
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00089950 File Offset: 0x00087B50
		public override bool Equals(object obj)
		{
			if (obj is global::Infragistics.Windows.DataPresenter.RecordAndField)
			{
				global::Infragistics.Windows.DataPresenter.RecordAndField recordAndField = (global::Infragistics.Windows.DataPresenter.RecordAndField)obj;
				return recordAndField.Record == this.Record && recordAndField.Field == this.Field;
			}
			return false;
		}

		// Token: 0x04000D4D RID: 3405
		private object _record;

		// Token: 0x04000D4E RID: 3406
		private object _field;
	}
}
