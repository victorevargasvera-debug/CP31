using System;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005A7 RID: 1447
	internal class MemberMaps
	{
		// Token: 0x0600465B RID: 18011 RVA: 0x000F7650 File Offset: 0x000F5850
		internal MemberMaps(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget viewTarget, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex projectedSlotMap, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap queryDomainMap, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap updateDomainMap)
		{
			this.m_projectedSlotMap = projectedSlotMap;
			this.m_queryDomainMap = queryDomainMap;
			this.m_updateDomainMap = updateDomainMap;
			this.m_viewTarget = viewTarget;
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x0600465C RID: 18012 RVA: 0x000F7675 File Offset: 0x000F5875
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex ProjectedSlotMap
		{
			get
			{
				return this.m_projectedSlotMap;
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x0600465D RID: 18013 RVA: 0x000F767D File Offset: 0x000F587D
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap QueryDomainMap
		{
			get
			{
				return this.m_queryDomainMap;
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x0600465E RID: 18014 RVA: 0x000F7685 File Offset: 0x000F5885
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap UpdateDomainMap
		{
			get
			{
				return this.m_updateDomainMap;
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x0600465F RID: 18015 RVA: 0x000F768D File Offset: 0x000F588D
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap RightDomainMap
		{
			get
			{
				if (this.m_viewTarget != global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView)
				{
					return this.m_queryDomainMap;
				}
				return this.m_updateDomainMap;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06004660 RID: 18016 RVA: 0x000F76A4 File Offset: 0x000F58A4
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap LeftDomainMap
		{
			get
			{
				if (this.m_viewTarget != global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView)
				{
					return this.m_updateDomainMap;
				}
				return this.m_queryDomainMap;
			}
		}

		// Token: 0x0400191E RID: 6430
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex m_projectedSlotMap;

		// Token: 0x0400191F RID: 6431
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap m_queryDomainMap;

		// Token: 0x04001920 RID: 6432
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap m_updateDomainMap;

		// Token: 0x04001921 RID: 6433
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget m_viewTarget;
	}
}
