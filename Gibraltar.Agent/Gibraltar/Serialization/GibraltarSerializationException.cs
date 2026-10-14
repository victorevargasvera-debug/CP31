using System;
using System.Runtime.Serialization;

namespace Gibraltar.Serialization
{
	// Token: 0x020000FA RID: 250
	[global::System.Serializable]
	internal class GibraltarSerializationException : global::Gibraltar.GibraltarException
	{
		// Token: 0x06000A67 RID: 2663 RVA: 0x0001A584 File Offset: 0x00018784
		public GibraltarSerializationException()
		{
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0001A58C File Offset: 0x0001878C
		public GibraltarSerializationException(string message) : base(message)
		{
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0001A598 File Offset: 0x00018798
		public GibraltarSerializationException(string message, bool streamFailed) : base(message)
		{
			this.StreamFailed = streamFailed;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0001A5A8 File Offset: 0x000187A8
		public GibraltarSerializationException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0001A5B4 File Offset: 0x000187B4
		public GibraltarSerializationException(string message, global::System.Exception innerException, bool streamFailed) : base(message, innerException)
		{
			this.StreamFailed = streamFailed;
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0001A5C8 File Offset: 0x000187C8
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x0001A5D0 File Offset: 0x000187D0
		public bool StreamFailed { get; private set; }

		// Token: 0x06000A6E RID: 2670 RVA: 0x0001A5DC File Offset: 0x000187DC
		protected GibraltarSerializationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
