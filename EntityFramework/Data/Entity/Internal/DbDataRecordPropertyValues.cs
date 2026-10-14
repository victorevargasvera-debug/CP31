using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000101 RID: 257
	internal class DbDataRecordPropertyValues : global::System.Data.Entity.Internal.InternalPropertyValues
	{
		// Token: 0x06001287 RID: 4743 RVA: 0x0002F964 File Offset: 0x0002DB64
		internal DbDataRecordPropertyValues(global::System.Data.Entity.Internal.InternalContext internalContext, global::System.Type type, global::System.Data.Entity.Core.Objects.DbUpdatableDataRecord dataRecord, bool isEntity) : base(internalContext, type, isEntity)
		{
			this._dataRecord = dataRecord;
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x0002F978 File Offset: 0x0002DB78
		protected override global::System.Data.Entity.Internal.IPropertyValuesItem GetItemImpl(string propertyName)
		{
			int ordinal = this._dataRecord.GetOrdinal(propertyName);
			object obj = this._dataRecord[ordinal];
			global::System.Data.Entity.Core.Objects.DbUpdatableDataRecord dbUpdatableDataRecord = obj as global::System.Data.Entity.Core.Objects.DbUpdatableDataRecord;
			if (dbUpdatableDataRecord != null)
			{
				obj = new global::System.Data.Entity.Internal.DbDataRecordPropertyValues(base.InternalContext, this._dataRecord.GetFieldType(ordinal), dbUpdatableDataRecord, false);
			}
			else if (obj == global::System.DBNull.Value)
			{
				obj = null;
			}
			return new global::System.Data.Entity.Internal.DbDataRecordPropertyValuesItem(this._dataRecord, ordinal, obj);
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x0002F9DC File Offset: 0x0002DBDC
		public override global::System.Collections.Generic.ISet<string> PropertyNames
		{
			get
			{
				if (this._names == null)
				{
					global::System.Collections.Generic.HashSet<string> hashSet = new global::System.Collections.Generic.HashSet<string>();
					for (int i = 0; i < this._dataRecord.FieldCount; i++)
					{
						hashSet.Add(this._dataRecord.GetName(i));
					}
					this._names = new global::System.Data.Entity.Internal.ReadOnlySet<string>(hashSet);
				}
				return this._names;
			}
		}

		// Token: 0x04000926 RID: 2342
		private readonly global::System.Data.Entity.Core.Objects.DbUpdatableDataRecord _dataRecord;

		// Token: 0x04000927 RID: 2343
		private global::System.Collections.Generic.ISet<string> _names;
	}
}
