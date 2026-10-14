using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	// Token: 0x0200003E RID: 62
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d00008")]
	[global::System.Serializable]
	public class SfxGenerationException : global::Ionic.Zip.ZipException
	{
		// Token: 0x060002CC RID: 716 RVA: 0x00011870 File Offset: 0x0000FA70
		public SfxGenerationException()
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00011878 File Offset: 0x0000FA78
		public SfxGenerationException(string message) : base(message)
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0001188B File Offset: 0x0000FA8B
		protected SfxGenerationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
