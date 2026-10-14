using System;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core
{
	// Token: 0x020002DF RID: 735
	[global::System.Serializable]
	public sealed class ProviderIncompatibleException : global::System.Data.Entity.Core.EntityException
	{
		// Token: 0x06002342 RID: 9026 RVA: 0x0006280C File Offset: 0x00060A0C
		public ProviderIncompatibleException()
		{
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x00062814 File Offset: 0x00060A14
		public ProviderIncompatibleException(string message) : base(message)
		{
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x0006281D File Offset: 0x00060A1D
		public ProviderIncompatibleException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x00062827 File Offset: 0x00060A27
		private ProviderIncompatibleException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
