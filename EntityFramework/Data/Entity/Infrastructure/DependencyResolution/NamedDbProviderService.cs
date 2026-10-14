using System;
using System.Data.Entity.Core.Common;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002B9 RID: 697
	internal class NamedDbProviderService
	{
		// Token: 0x060021F6 RID: 8694 RVA: 0x0005E77D File Offset: 0x0005C97D
		public NamedDbProviderService(string invariantName, global::System.Data.Entity.Core.Common.DbProviderServices providerServices)
		{
			this._invariantName = invariantName;
			this._providerServices = providerServices;
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x0005E793 File Offset: 0x0005C993
		public string InvariantName
		{
			get
			{
				return this._invariantName;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060021F8 RID: 8696 RVA: 0x0005E79B File Offset: 0x0005C99B
		public global::System.Data.Entity.Core.Common.DbProviderServices ProviderServices
		{
			get
			{
				return this._providerServices;
			}
		}

		// Token: 0x04000BCE RID: 3022
		private readonly string _invariantName;

		// Token: 0x04000BCF RID: 3023
		private readonly global::System.Data.Entity.Core.Common.DbProviderServices _providerServices;
	}
}
