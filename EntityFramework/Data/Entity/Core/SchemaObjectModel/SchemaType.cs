using System;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x0200031C RID: 796
	internal abstract class SchemaType : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x0006B647 File Offset: 0x00069847
		public string Namespace
		{
			get
			{
				return base.Schema.Namespace;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x0006B654 File Offset: 0x00069854
		public override string Identity
		{
			get
			{
				return this.Namespace + "." + this.Name;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x0006B66C File Offset: 0x0006986C
		public override string FQName
		{
			get
			{
				return this.Namespace + "." + this.Name;
			}
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x0006B684 File Offset: 0x00069884
		internal SchemaType(global::System.Data.Entity.Core.SchemaObjectModel.Schema parentElement) : base(parentElement, null)
		{
		}
	}
}
