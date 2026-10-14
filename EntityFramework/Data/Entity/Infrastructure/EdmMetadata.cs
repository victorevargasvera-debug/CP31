using System;
using System.Data.Entity.Internal;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200023F RID: 575
	[global::System.Obsolete("EdmMetadata is no longer used. The Code First Migrations <see cref=\"EdmModelDiffer\" /> is used instead.")]
	public class EdmMetadata
	{
		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x00053651 File Offset: 0x00051851
		// (set) Token: 0x06001E3A RID: 7738 RVA: 0x00053659 File Offset: 0x00051859
		public int Id { get; set; }

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x00053662 File Offset: 0x00051862
		// (set) Token: 0x06001E3C RID: 7740 RVA: 0x0005366A File Offset: 0x0005186A
		public string ModelHash { get; set; }

		// Token: 0x06001E3D RID: 7741 RVA: 0x00053674 File Offset: 0x00051874
		public static string TryGetModelHash(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			global::System.Data.Entity.Infrastructure.DbCompiledModel codeFirstModel = context.InternalContext.CodeFirstModel;
			if (codeFirstModel != null)
			{
				return new global::System.Data.Entity.Internal.ModelHashCalculator().Calculate(codeFirstModel);
			}
			return null;
		}
	}
}
