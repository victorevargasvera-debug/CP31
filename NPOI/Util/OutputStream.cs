using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x02000285 RID: 645
	public abstract class OutputStream : global::System.IO.Stream
	{
		// Token: 0x06001157 RID: 4439
		public abstract void Write(int b);

		// Token: 0x06001158 RID: 4440 RVA: 0x0002BC27 File Offset: 0x00029E27
		public virtual void Write(byte[] b)
		{
			this.Write(b, 0, b.Length);
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00034540 File Offset: 0x00032740
		public override void Write(byte[] b, int off, int len)
		{
			if (b == null)
			{
				throw new global::System.NullReferenceException();
			}
			if (off < 0 || off > b.Length || len < 0 || off + len > b.Length || off + len < 0)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			if (len == 0)
			{
				return;
			}
			for (int i = 0; i < len; i++)
			{
				this.Write((int)b[off + i]);
			}
		}
	}
}
