using System;
using System.Collections.Generic;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002B5 RID: 693
	public interface IDbDependencyResolver
	{
		// Token: 0x060021D4 RID: 8660
		object GetService(global::System.Type type, object key);

		// Token: 0x060021D5 RID: 8661
		global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key);
	}
}
