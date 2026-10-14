using System;
using System.Data.Entity.Resources;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core
{
	// Token: 0x020002DA RID: 730
	[global::System.Serializable]
	public sealed class MappingException : global::System.Data.Entity.Core.EntityException
	{
		// Token: 0x06002329 RID: 9001 RVA: 0x000626B0 File Offset: 0x000608B0
		public MappingException() : base(global::System.Data.Entity.Resources.Strings.Mapping_General_Error)
		{
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x000626BD File Offset: 0x000608BD
		public MappingException(string message) : base(message)
		{
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x000626C6 File Offset: 0x000608C6
		public MappingException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x000626D0 File Offset: 0x000608D0
		private MappingException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
