using System;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x02000644 RID: 1604
	internal struct TranslatorArg
	{
		// Token: 0x06004D46 RID: 19782 RVA: 0x00110196 File Offset: 0x0010E396
		internal TranslatorArg(global::System.Type requestedType)
		{
			this.RequestedType = requestedType;
		}

		// Token: 0x04001B71 RID: 7025
		internal readonly global::System.Type RequestedType;
	}
}
