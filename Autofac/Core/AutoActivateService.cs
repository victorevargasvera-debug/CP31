using System;

namespace Autofac.Core
{
	// Token: 0x0200005C RID: 92
	internal class AutoActivateService : global::Autofac.Core.Service
	{
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00008464 File Offset: 0x00006664
		public override string Description
		{
			get
			{
				return "AutoActivate";
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000846B File Offset: 0x0000666B
		public override bool Equals(object obj)
		{
			return obj as global::Autofac.Core.AutoActivateService != null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00008479 File Offset: 0x00006679
		public override int GetHashCode()
		{
			return 0;
		}
	}
}
