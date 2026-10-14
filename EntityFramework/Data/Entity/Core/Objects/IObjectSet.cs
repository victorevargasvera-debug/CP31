using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200040E RID: 1038
	public interface IObjectSet<TEntity> : global::System.Linq.IQueryable<TEntity>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable, global::System.Linq.IQueryable where TEntity : class
	{
		// Token: 0x06003143 RID: 12611
		void AddObject(TEntity entity);

		// Token: 0x06003144 RID: 12612
		void Attach(TEntity entity);

		// Token: 0x06003145 RID: 12613
		void DeleteObject(TEntity entity);

		// Token: 0x06003146 RID: 12614
		void Detach(TEntity entity);
	}
}
