using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Utilities
{
	// Token: 0x02000695 RID: 1685
	[global::System.Obsolete("Use Org.BouncyCastle.Utilities.IO.FilterStream")]
	public class FilterStream : global::System.IO.Stream
	{
		// Token: 0x06003E01 RID: 15873 RVA: 0x0011B21C File Offset: 0x0011941C
		[global::System.Obsolete("Use Org.BouncyCastle.Utilities.IO.FilterStream")]
		public FilterStream(global::System.IO.Stream s)
		{
			this.s = s;
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06003E02 RID: 15874 RVA: 0x0011B22B File Offset: 0x0011942B
		public override bool CanRead
		{
			get
			{
				return this.s.CanRead;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06003E03 RID: 15875 RVA: 0x0011B238 File Offset: 0x00119438
		public override bool CanSeek
		{
			get
			{
				return this.s.CanSeek;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06003E04 RID: 15876 RVA: 0x0011B245 File Offset: 0x00119445
		public override bool CanWrite
		{
			get
			{
				return this.s.CanWrite;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06003E05 RID: 15877 RVA: 0x0011B252 File Offset: 0x00119452
		public override long Length
		{
			get
			{
				return this.s.Length;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06003E06 RID: 15878 RVA: 0x0011B25F File Offset: 0x0011945F
		// (set) Token: 0x06003E07 RID: 15879 RVA: 0x0011B26C File Offset: 0x0011946C
		public override long Position
		{
			get
			{
				return this.s.Position;
			}
			set
			{
				this.s.Position = value;
			}
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x0011B27A File Offset: 0x0011947A
		public override void Close()
		{
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.s);
			base.Close();
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x0011B28D File Offset: 0x0011948D
		public override void Flush()
		{
			this.s.Flush();
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x0011B29A File Offset: 0x0011949A
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this.s.Seek(offset, origin);
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x0011B2A9 File Offset: 0x001194A9
		public override void SetLength(long value)
		{
			this.s.SetLength(value);
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x0011B2B7 File Offset: 0x001194B7
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this.s.Read(buffer, offset, count);
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x0011B2C7 File Offset: 0x001194C7
		public override int ReadByte()
		{
			return this.s.ReadByte();
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x0011B2D4 File Offset: 0x001194D4
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.s.Write(buffer, offset, count);
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x0011B2E4 File Offset: 0x001194E4
		public override void WriteByte(byte value)
		{
			this.s.WriteByte(value);
		}

		// Token: 0x04001BAE RID: 7086
		protected readonly global::System.IO.Stream s;
	}
}
