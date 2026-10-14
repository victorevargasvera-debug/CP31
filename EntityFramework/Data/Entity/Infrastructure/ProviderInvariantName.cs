using System;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200025A RID: 602
	internal class ProviderInvariantName : global::System.Data.Entity.Infrastructure.IProviderInvariantName
	{
		// Token: 0x06001ED6 RID: 7894 RVA: 0x00054BF0 File Offset: 0x00052DF0
		public ProviderInvariantName(string name)
		{
			this.Name = name;
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x00054BFF File Offset: 0x00052DFF
		// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x00054C07 File Offset: 0x00052E07
		public string Name { get; private set; }
	}
}
