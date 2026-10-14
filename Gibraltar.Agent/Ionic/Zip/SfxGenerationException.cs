using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip
{
	// Token: 0x02000459 RID: 1113
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d00008")]
	[global::System.Serializable]
	internal class SfxGenerationException : global::Ionic.Zip.ZipException
	{
		// Token: 0x06002FF4 RID: 12276 RVA: 0x000A9E68 File Offset: 0x000A8068
		public SfxGenerationException()
		{
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x000A9E70 File Offset: 0x000A8070
		public SfxGenerationException(string message) : base(message)
		{
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x000A9E7C File Offset: 0x000A807C
		protected SfxGenerationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
