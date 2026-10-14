using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Gibraltar
{
	// Token: 0x0200016A RID: 362
	[global::System.Serializable]
	internal class GibraltarPacketVersionException : global::Gibraltar.GibraltarException
	{
		// Token: 0x06000EF2 RID: 3826 RVA: 0x000268C8 File Offset: 0x00024AC8
		public GibraltarPacketVersionException()
		{
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x000268D0 File Offset: 0x00024AD0
		public GibraltarPacketVersionException(string message) : base(message)
		{
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x000268DC File Offset: 0x00024ADC
		public GibraltarPacketVersionException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x000268E8 File Offset: 0x00024AE8
		protected GibraltarPacketVersionException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x000268F4 File Offset: 0x00024AF4
		public GibraltarPacketVersionException(int version) : this(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Unexpected version: {0}", new object[]
		{
			version
		}))
		{
		}
	}
}
