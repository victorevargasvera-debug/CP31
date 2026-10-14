using System;

namespace Motorola.Security.SamlCommonUtility.DMHttpClients
{
	// Token: 0x02000026 RID: 38
	public abstract class DMClientBase
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00009F10 File Offset: 0x00008110
		public DMClientBase(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IHttpHandler httpHandler)
		{
			if (httpHandler == null)
			{
				throw new global::System.ArgumentNullException();
			}
			this.handler = httpHandler;
		}

		// Token: 0x040000D0 RID: 208
		protected global::Motorola.Security.SamlCommonUtility.DMHttpClients.IHttpHandler handler;
	}
}
