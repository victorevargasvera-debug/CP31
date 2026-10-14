using System;
using System.Data.Entity.Resources;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core
{
	// Token: 0x020002DB RID: 731
	[global::System.Serializable]
	public sealed class MetadataException : global::System.Data.Entity.Core.EntityException
	{
		// Token: 0x0600232D RID: 9005 RVA: 0x000626DA File Offset: 0x000608DA
		public MetadataException() : base(global::System.Data.Entity.Resources.Strings.Metadata_General_Error)
		{
			base.HResult = -2146232007;
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x000626F2 File Offset: 0x000608F2
		public MetadataException(string message) : base(message)
		{
			base.HResult = -2146232007;
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x00062706 File Offset: 0x00060906
		public MetadataException(string message, global::System.Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232007;
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x0006271B File Offset: 0x0006091B
		private MetadataException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000C0C RID: 3084
		private const int HResultMetadata = -2146232007;
	}
}
