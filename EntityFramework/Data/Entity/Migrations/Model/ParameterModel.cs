using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000C2 RID: 194
	public class ParameterModel : global::System.Data.Entity.Migrations.Model.PropertyModel
	{
		// Token: 0x06000F97 RID: 3991 RVA: 0x0001FC31 File Offset: 0x0001DE31
		public ParameterModel(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type) : this(type, null)
		{
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0001FC3B File Offset: 0x0001DE3B
		public ParameterModel(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage) : base(type, typeUsage)
		{
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x0001FC45 File Offset: 0x0001DE45
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x0001FC4D File Offset: 0x0001DE4D
		public bool IsOutParameter { get; set; }
	}
}
