using System;
using System.ComponentModel;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core
{
	// Token: 0x020002D3 RID: 723
	[global::System.AttributeUsage(global::System.AttributeTargets.All)]
	internal sealed class EntityResDescriptionAttribute : global::System.ComponentModel.DescriptionAttribute
	{
		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060022F7 RID: 8951 RVA: 0x0006227C File Offset: 0x0006047C
		public override string Description
		{
			get
			{
				if (!this._replaced)
				{
					this._replaced = true;
					base.DescriptionValue = global::System.Data.Entity.Resources.EntityRes.GetString(base.Description);
				}
				return base.Description;
			}
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x000622A4 File Offset: 0x000604A4
		public EntityResDescriptionAttribute(string description) : base(description)
		{
		}

		// Token: 0x04000C05 RID: 3077
		private bool _replaced;
	}
}
