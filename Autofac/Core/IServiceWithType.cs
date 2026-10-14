using System;

namespace Autofac.Core
{
	// Token: 0x02000070 RID: 112
	public interface IServiceWithType
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000290 RID: 656
		global::System.Type ServiceType { get; }

		// Token: 0x06000291 RID: 657
		global::Autofac.Core.Service ChangeType(global::System.Type newType);
	}
}
