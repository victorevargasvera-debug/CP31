using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001DF RID: 479
	internal class RecordAndField
	{
		// Token: 0x06001B85 RID: 7045 RVA: 0x00075910 File Offset: 0x00073B10
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

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x00075950 File Offset: 0x00073B50
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

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x00075984 File Offset: 0x00073B84
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

		// Token: 0x06001B88 RID: 7048 RVA: 0x000759B8 File Offset: 0x00073BB8
		public override int GetHashCode()
		{
			global::Infragistics.Windows.DataPresenter.Record record = this.Record;
			global::Infragistics.Windows.DataPresenter.Field field = this.Field;
			return ((record != null) ? record.GetHashCode() : 1) ^ ((field != null) ? field.GetHashCode() : 2);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x000759EC File Offset: 0x00073BEC
		public override bool Equals(object obj)
		{
			if (obj is global::Infragistics.Windows.DataPresenter.RecordAndField)
			{
				global::Infragistics.Windows.DataPresenter.RecordAndField recordAndField = (global::Infragistics.Windows.DataPresenter.RecordAndField)obj;
				return recordAndField.Record == this.Record && recordAndField.Field == this.Field;
			}
			return false;
		}

		// Token: 0x04000B5C RID: 2908
		private object _record;

		// Token: 0x04000B5D RID: 2909
		private object _field;
	}
}
