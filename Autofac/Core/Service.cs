using System;

namespace Autofac.Core
{
	// Token: 0x02000078 RID: 120
	public abstract class Service
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002AE RID: 686
		public abstract string Description { get; }

		// Token: 0x060002AF RID: 687 RVA: 0x00008C48 File Offset: 0x00006E48
		public override string ToString()
		{
			return this.Description;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00008C50 File Offset: 0x00006E50
		public static bool operator ==(global::Autofac.Core.Service left, global::Autofac.Core.Service right)
		{
			return object.Equals(left, right);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00008C59 File Offset: 0x00006E59
		public static bool operator !=(global::Autofac.Core.Service left, global::Autofac.Core.Service right)
		{
			return !(left == right);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00008C65 File Offset: 0x00006E65
		public override bool Equals(object obj)
		{
			throw new global::System.NotImplementedException(global::Autofac.Core.ServiceResources.MustOverrideEquals);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00008C71 File Offset: 0x00006E71
		public override int GetHashCode()
		{
			throw new global::System.NotImplementedException(global::Autofac.Core.ServiceResources.MustOverrideGetHashCode);
		}
	}
}
