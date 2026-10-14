using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common
{
	// Token: 0x020005EE RID: 1518
	public class EntityRecordInfo : global::System.Data.Entity.Core.Common.DataRecordInfo
	{
		// Token: 0x06004A5E RID: 19038 RVA: 0x00106AC4 File Offset: 0x00104CC4
		public EntityRecordInfo(global::System.Data.Entity.Core.Metadata.Edm.EntityType metadata, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> memberInfo, global::System.Data.Entity.Core.EntityKey entityKey, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet) : base(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(metadata), memberInfo)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.EntityKey>(entityKey, "entityKey");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(entitySet, "entitySet");
			this._entityKey = entityKey;
			this.ValidateEntityType(entitySet);
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x00106AFB File Offset: 0x00104CFB
		internal EntityRecordInfo(global::System.Data.Entity.Core.Metadata.Edm.EntityType metadata, global::System.Data.Entity.Core.EntityKey entityKey, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet) : base(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(metadata))
		{
			this._entityKey = entityKey;
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x00106B10 File Offset: 0x00104D10
		internal EntityRecordInfo(global::System.Data.Entity.Core.Common.DataRecordInfo info, global::System.Data.Entity.Core.EntityKey entityKey, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet) : base(info)
		{
			this._entityKey = entityKey;
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06004A61 RID: 19041 RVA: 0x00106B20 File Offset: 0x00104D20
		public global::System.Data.Entity.Core.EntityKey EntityKey
		{
			get
			{
				return this._entityKey;
			}
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x00106B28 File Offset: 0x00104D28
		private void ValidateEntityType(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet)
		{
			if (this.RecordType.EdmType != null && this._entityKey != global::System.Data.Entity.Core.EntityKey.EntityNotValidKey && this._entityKey != global::System.Data.Entity.Core.EntityKey.NoEntitySetKey && this.RecordType.EdmType != entitySet.ElementType && !entitySet.ElementType.IsBaseTypeOf(this.RecordType.EdmType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityTypesDoNotAgree);
			}
		}

		// Token: 0x04001A36 RID: 6710
		private readonly global::System.Data.Entity.Core.EntityKey _entityKey;
	}
}
