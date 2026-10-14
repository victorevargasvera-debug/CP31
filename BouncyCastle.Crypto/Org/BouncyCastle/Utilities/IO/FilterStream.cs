using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x0200004E RID: 78
	public class FilterStream : global::System.IO.Stream
	{
		// Token: 0x060003A0 RID: 928 RVA: 0x00013C97 File Offset: 0x00011E97
		public FilterStream(global::System.IO.Stream s)
		{
			this.s = s;
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00013CA6 File Offset: 0x00011EA6
		public override bool CanRead
		{
			get
			{
				return this.s.CanRead;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00013CB3 File Offset: 0x00011EB3
		public override bool CanSeek
		{
			get
			{
				return this.s.CanSeek;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00013CC0 File Offset: 0x00011EC0
		public override bool CanWrite
		{
			get
			{
				return this.s.CanWrite;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00013CCD File Offset: 0x00011ECD
		public override long Length
		{
			get
			{
				return this.s.Length;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00013CDA File Offset: 0x00011EDA
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x00013CE7 File Offset: 0x00011EE7
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

		// Token: 0x060003A7 RID: 935 RVA: 0x00013CF5 File Offset: 0x00011EF5
		public override void Close()
		{
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.s);
			base.Close();
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00013D08 File Offset: 0x00011F08
		public override void Flush()
		{
			this.s.Flush();
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00013D15 File Offset: 0x00011F15
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this.s.Seek(offset, origin);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00013D24 File Offset: 0x00011F24
		public override void SetLength(long value)
		{
			this.s.SetLength(value);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00013D32 File Offset: 0x00011F32
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this.s.Read(buffer, offset, count);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00013D42 File Offset: 0x00011F42
		public override int ReadByte()
		{
			return this.s.ReadByte();
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00013D4F File Offset: 0x00011F4F
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.s.Write(buffer, offset, count);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00013D5F File Offset: 0x00011F5F
		public override void WriteByte(byte value)
		{
			this.s.WriteByte(value);
		}

		// Token: 0x04000278 RID: 632
		protected readonly global::System.IO.Stream s;
	}
}
