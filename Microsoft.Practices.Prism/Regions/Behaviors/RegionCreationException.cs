using System;
using System.Runtime.Serialization;

namespace Microsoft.Practices.Prism.Regions.Behaviors
{
	// Token: 0x02000056 RID: 86
	[global::System.Serializable]
	public class RegionCreationException : global::System.Exception
	{
		// Token: 0x0600028B RID: 651 RVA: 0x00007C6C File Offset: 0x00005E6C
		public RegionCreationException()
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00007C74 File Offset: 0x00005E74
		public RegionCreationException(string message) : base(message)
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00007C7D File Offset: 0x00005E7D
		public RegionCreationException(string message, global::System.Exception inner) : base(message, inner)
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00007C87 File Offset: 0x00005E87
		protected RegionCreationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
