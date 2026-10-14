using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.EntityClient.Internal
{
	// Token: 0x020005E8 RID: 1512
	internal interface IEntityAdapter
	{
		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x060049FA RID: 18938
		// (set) Token: 0x060049FB RID: 18939
		global::System.Data.Common.DbConnection Connection { get; set; }

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x060049FC RID: 18940
		// (set) Token: 0x060049FD RID: 18941
		bool AcceptChangesDuringUpdate { get; set; }

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x060049FE RID: 18942
		// (set) Token: 0x060049FF RID: 18943
		int? CommandTimeout { get; set; }

		// Token: 0x06004A00 RID: 18944
		int Update();

		// Token: 0x06004A01 RID: 18945
		global::System.Threading.Tasks.Task<int> UpdateAsync(global::System.Threading.CancellationToken cancellationToken);
	}
}
