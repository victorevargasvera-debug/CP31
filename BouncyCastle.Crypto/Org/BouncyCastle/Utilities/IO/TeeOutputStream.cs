using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x02000056 RID: 86
	public class TeeOutputStream : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
	{
		// Token: 0x060003CD RID: 973 RVA: 0x00014067 File Offset: 0x00012267
		public TeeOutputStream(global::System.IO.Stream output, global::System.IO.Stream tee)
		{
			this.output = output;
			this.tee = tee;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0001407D File Offset: 0x0001227D
		public override void Close()
		{
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.output);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.tee);
			base.Close();
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0001409B File Offset: 0x0001229B
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.output.Write(buffer, offset, count);
			this.tee.Write(buffer, offset, count);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000140B9 File Offset: 0x000122B9
		public override void WriteByte(byte b)
		{
			this.output.WriteByte(b);
			this.tee.WriteByte(b);
		}

		// Token: 0x0400027D RID: 637
		private readonly global::System.IO.Stream output;

		// Token: 0x0400027E RID: 638
		private readonly global::System.IO.Stream tee;
	}
}
