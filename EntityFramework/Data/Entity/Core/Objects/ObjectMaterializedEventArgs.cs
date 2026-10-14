using System;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000416 RID: 1046
	public class ObjectMaterializedEventArgs : global::System.EventArgs
	{
		// Token: 0x0600322F RID: 12847 RVA: 0x000A0679 File Offset: 0x0009E879
		public ObjectMaterializedEventArgs(object entity)
		{
			this._entity = entity;
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06003230 RID: 12848 RVA: 0x000A0688 File Offset: 0x0009E888
		public object Entity
		{
			get
			{
				return this._entity;
			}
		}

		// Token: 0x04001075 RID: 4213
		private readonly object _entity;
	}
}
