using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000533 RID: 1331
	public class CmsProcessableInputStream : global::Org.BouncyCastle.Cms.CmsProcessable, global::Org.BouncyCastle.Cms.CmsReadable
	{
		// Token: 0x06003355 RID: 13141 RVA: 0x000F4AEF File Offset: 0x000F2CEF
		public CmsProcessableInputStream(global::System.IO.Stream input)
		{
			this.input = input;
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x000F4AFE File Offset: 0x000F2CFE
		public virtual global::System.IO.Stream GetInputStream()
		{
			this.CheckSingleUsage();
			return this.input;
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x000F4B0C File Offset: 0x000F2D0C
		public virtual void Write(global::System.IO.Stream output)
		{
			this.CheckSingleUsage();
			global::Org.BouncyCastle.Utilities.IO.Streams.PipeAll(this.input, output);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.input);
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x000F4B2B File Offset: 0x000F2D2B
		[global::System.Obsolete]
		public virtual object GetContent()
		{
			return this.GetInputStream();
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x000F4B34 File Offset: 0x000F2D34
		protected virtual void CheckSingleUsage()
		{
			lock (this)
			{
				if (this.used)
				{
					throw new global::System.InvalidOperationException("CmsProcessableInputStream can only be used once");
				}
				this.used = true;
			}
		}

		// Token: 0x040016EB RID: 5867
		private readonly global::System.IO.Stream input;

		// Token: 0x040016EC RID: 5868
		private bool used;
	}
}
