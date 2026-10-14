using System;
using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005CA RID: 1482
	public class WrappedGeneratorStream : global::Org.BouncyCastle.Utilities.IO.FilterStream
	{
		// Token: 0x060037E6 RID: 14310 RVA: 0x00108483 File Offset: 0x00106683
		public WrappedGeneratorStream(global::Org.BouncyCastle.Bcpg.OpenPgp.IStreamGenerator gen, global::System.IO.Stream str) : base(str)
		{
			this.gen = gen;
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x00108493 File Offset: 0x00106693
		public override void Close()
		{
			this.gen.Close();
		}

		// Token: 0x0400191A RID: 6426
		private readonly global::Org.BouncyCastle.Bcpg.OpenPgp.IStreamGenerator gen;
	}
}
