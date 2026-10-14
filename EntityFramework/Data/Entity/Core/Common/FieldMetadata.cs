using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common
{
	// Token: 0x020005EF RID: 1519
	public struct FieldMetadata
	{
		// Token: 0x06004A63 RID: 19043 RVA: 0x00106B92 File Offset: 0x00104D92
		public FieldMetadata(int ordinal, global::System.Data.Entity.Core.Metadata.Edm.EdmMember fieldType)
		{
			if (ordinal < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("ordinal");
			}
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(fieldType, "fieldType");
			this._fieldType = fieldType;
			this._ordinal = ordinal;
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06004A64 RID: 19044 RVA: 0x00106BBD File Offset: 0x00104DBD
		public global::System.Data.Entity.Core.Metadata.Edm.EdmMember FieldType
		{
			get
			{
				return this._fieldType;
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06004A65 RID: 19045 RVA: 0x00106BC5 File Offset: 0x00104DC5
		public int Ordinal
		{
			get
			{
				return this._ordinal;
			}
		}

		// Token: 0x04001A37 RID: 6711
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmMember _fieldType;

		// Token: 0x04001A38 RID: 6712
		private readonly int _ordinal;
	}
}
