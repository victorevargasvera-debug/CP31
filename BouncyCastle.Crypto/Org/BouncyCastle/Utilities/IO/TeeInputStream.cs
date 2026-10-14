using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x02000055 RID: 85
	public class TeeInputStream : global::Org.BouncyCastle.Utilities.IO.BaseInputStream
	{
		// Token: 0x060003C9 RID: 969 RVA: 0x00013FD8 File Offset: 0x000121D8
		public TeeInputStream(global::System.IO.Stream input, global::System.IO.Stream tee)
		{
			this.input = input;
			this.tee = tee;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00013FEE File Offset: 0x000121EE
		public override void Close()
		{
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.input);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.tee);
			base.Close();
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0001400C File Offset: 0x0001220C
		public override int Read(byte[] buf, int off, int len)
		{
			int i = this.input.Read(buf, off, len);
			if (i > 0)
			{
				this.tee.Write(buf, off, i);
			}
			return i;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0001403C File Offset: 0x0001223C
		public override int ReadByte()
		{
			int i = this.input.ReadByte();
			if (i >= 0)
			{
				this.tee.WriteByte((byte)i);
			}
			return i;
		}

		// Token: 0x0400027B RID: 635
		private readonly global::System.IO.Stream input;

		// Token: 0x0400027C RID: 636
		private readonly global::System.IO.Stream tee;
	}
}
