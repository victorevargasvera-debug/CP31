using System;
using System.Xml.Linq;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200022C RID: 556
	public abstract class DbModelStore
	{
		// Token: 0x06001D3C RID: 7484
		public abstract global::System.Data.Entity.Infrastructure.DbCompiledModel TryLoad(global::System.Type contextType);

		// Token: 0x06001D3D RID: 7485
		public abstract global::System.Xml.Linq.XDocument TryGetEdmx(global::System.Type contextType);

		// Token: 0x06001D3E RID: 7486
		public abstract void Save(global::System.Type contextType, global::System.Data.Entity.Infrastructure.DbModel model);

		// Token: 0x06001D3F RID: 7487 RVA: 0x00052332 File Offset: 0x00050532
		protected virtual string GetDefaultSchema(global::System.Type contextType)
		{
			return "dbo";
		}
	}
}
