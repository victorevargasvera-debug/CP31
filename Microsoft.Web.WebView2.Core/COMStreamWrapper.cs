using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000012 RID: 18
	internal class COMStreamWrapper : global::System.IO.Stream
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x00006E45 File Offset: 0x00005045
		public COMStreamWrapper(global::System.Runtime.InteropServices.ComTypes.IStream source)
		{
			this.istream = source;
			this.mInt64 = global::System.Runtime.InteropServices.Marshal.AllocCoTaskMem(8);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00006E64 File Offset: 0x00005064
		~COMStreamWrapper()
		{
			global::System.Runtime.InteropServices.Marshal.FreeCoTaskMem(this.mInt64);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00006E9C File Offset: 0x0000509C
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00006EB0 File Offset: 0x000050B0
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00006EC4 File Offset: 0x000050C4
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00006ED7 File Offset: 0x000050D7
		public override void Flush()
		{
			this.istream.Commit(0);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00006EE8 File Offset: 0x000050E8
		public override long Length
		{
			get
			{
				global::System.Runtime.InteropServices.ComTypes.STATSTG statstg;
				this.istream.Stat(out statstg, 1);
				return statstg.cbSize;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00005F0B File Offset: 0x0000410B
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00005F0B File Offset: 0x0000410B
		public override long Position
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00006F10 File Offset: 0x00005110
		public override int Read(byte[] buffer, int offset, int count)
		{
			bool flag = offset != 0;
			if (flag)
			{
				throw new global::System.NotImplementedException();
			}
			this.istream.Read(buffer, count, this.mInt64);
			return global::System.Runtime.InteropServices.Marshal.ReadInt32(this.mInt64);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00006F50 File Offset: 0x00005150
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			this.istream.Seek(offset, (int)origin, this.mInt64);
			return global::System.Runtime.InteropServices.Marshal.ReadInt64(this.mInt64);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00006F81 File Offset: 0x00005181
		public override void SetLength(long value)
		{
			this.istream.SetSize(value);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00006F94 File Offset: 0x00005194
		public override void Write(byte[] buffer, int offset, int count)
		{
			bool flag = offset != 0;
			if (flag)
			{
				throw new global::System.NotImplementedException();
			}
			this.istream.Write(buffer, count, global::System.IntPtr.Zero);
		}

		// Token: 0x0400004A RID: 74
		private global::System.Runtime.InteropServices.ComTypes.IStream istream;

		// Token: 0x0400004B RID: 75
		private global::System.IntPtr mInt64;
	}
}
