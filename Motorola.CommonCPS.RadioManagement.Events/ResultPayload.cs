using System;

namespace Motorola.CommonCPS.RadioManagement.Events
{
	// Token: 0x02000004 RID: 4
	public class ResultPayload<ReturnType>
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002130 File Offset: 0x00000330
		public ResultPayload()
		{
			this.Result = default(ReturnType);
		}

		// Token: 0x04000003 RID: 3
		public ReturnType Result;
	}
}
