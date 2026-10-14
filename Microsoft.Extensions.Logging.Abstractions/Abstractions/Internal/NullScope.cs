using System;

namespace Microsoft.Extensions.Logging.Abstractions.Internal
{
	// Token: 0x02000011 RID: 17
	public class NullScope : global::System.IDisposable
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002B42 File Offset: 0x00000D42
		public static global::Microsoft.Extensions.Logging.Abstractions.Internal.NullScope Instance { get; } = new global::Microsoft.Extensions.Logging.Abstractions.Internal.NullScope();

		// Token: 0x06000054 RID: 84 RVA: 0x00002A49 File Offset: 0x00000C49
		private NullScope()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002A5B File Offset: 0x00000C5B
		public void Dispose()
		{
		}
	}
}
