using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000011 RID: 17
	internal class ManagedIStream : global::System.Runtime.InteropServices.ComTypes.IStream
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x00006C7C File Offset: 0x00004E7C
		internal ManagedIStream(global::System.IO.Stream ioStream)
		{
			bool flag = ioStream == null;
			if (flag)
			{
				throw new global::System.ArgumentNullException("ioStream");
			}
			this._ioStream = ioStream;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00006CAC File Offset: 0x00004EAC
		[global::System.Security.SecurityCritical]
		void global::System.Runtime.InteropServices.ComTypes.IStream.Read(byte[] buffer, int bufferSize, global::System.IntPtr bytesReadPtr)
		{
			int val = this._ioStream.Read(buffer, 0, bufferSize);
			bool flag = bytesReadPtr != global::System.IntPtr.Zero;
			if (flag)
			{
				global::System.Runtime.InteropServices.Marshal.WriteInt32(bytesReadPtr, val);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00006CE4 File Offset: 0x00004EE4
		[global::System.Security.SecurityCritical]
		void global::System.Runtime.InteropServices.ComTypes.IStream.Seek(long offset, int origin, global::System.IntPtr newPositionPtr)
		{
			global::System.IO.SeekOrigin origin2;
			switch (origin)
			{
			case 0:
				origin2 = global::System.IO.SeekOrigin.Begin;
				break;
			case 1:
				origin2 = global::System.IO.SeekOrigin.Current;
				break;
			case 2:
				origin2 = global::System.IO.SeekOrigin.End;
				break;
			default:
				throw new global::System.ArgumentOutOfRangeException("origin");
			}
			long val = this._ioStream.Seek(offset, origin2);
			bool flag = newPositionPtr != global::System.IntPtr.Zero;
			if (flag)
			{
				global::System.Runtime.InteropServices.Marshal.WriteInt64(newPositionPtr, val);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00006D4A File Offset: 0x00004F4A
		void global::System.Runtime.InteropServices.ComTypes.IStream.SetSize(long libNewSize)
		{
			this._ioStream.SetLength(libNewSize);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00006D5C File Offset: 0x00004F5C
		void global::System.Runtime.InteropServices.ComTypes.IStream.Stat(out global::System.Runtime.InteropServices.ComTypes.STATSTG streamStats, int grfStatFlag)
		{
			streamStats = default(global::System.Runtime.InteropServices.ComTypes.STATSTG);
			streamStats.type = 2;
			streamStats.cbSize = this._ioStream.Length;
			streamStats.grfMode = 0;
			bool flag = this._ioStream.CanRead && this._ioStream.CanWrite;
			if (flag)
			{
				streamStats.grfMode |= 2;
			}
			else
			{
				bool canRead = this._ioStream.CanRead;
				if (canRead)
				{
					streamStats.grfMode |= 0;
				}
				else
				{
					bool canWrite = this._ioStream.CanWrite;
					if (!canWrite)
					{
						throw new global::System.IO.IOException();
					}
					streamStats.grfMode |= 1;
				}
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00006E04 File Offset: 0x00005004
		[global::System.Security.SecurityCritical]
		void global::System.Runtime.InteropServices.ComTypes.IStream.Write(byte[] buffer, int bufferSize, global::System.IntPtr bytesWrittenPtr)
		{
			this._ioStream.Write(buffer, 0, bufferSize);
			bool flag = bytesWrittenPtr != global::System.IntPtr.Zero;
			if (flag)
			{
				global::System.Runtime.InteropServices.Marshal.WriteInt32(bytesWrittenPtr, bufferSize);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00006E3A File Offset: 0x0000503A
		void global::System.Runtime.InteropServices.ComTypes.IStream.Clone(out global::System.Runtime.InteropServices.ComTypes.IStream streamCopy)
		{
			streamCopy = null;
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00005F0B File Offset: 0x0000410B
		void global::System.Runtime.InteropServices.ComTypes.IStream.CopyTo(global::System.Runtime.InteropServices.ComTypes.IStream targetStream, long bufferSize, global::System.IntPtr buffer, global::System.IntPtr bytesWrittenPtr)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00005F0B File Offset: 0x0000410B
		void global::System.Runtime.InteropServices.ComTypes.IStream.Commit(int flags)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005F0B File Offset: 0x0000410B
		void global::System.Runtime.InteropServices.ComTypes.IStream.LockRegion(long offset, long byteCount, int lockType)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005F0B File Offset: 0x0000410B
		void global::System.Runtime.InteropServices.ComTypes.IStream.Revert()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00005F0B File Offset: 0x0000410B
		void global::System.Runtime.InteropServices.ComTypes.IStream.UnlockRegion(long offset, long byteCount, int lockType)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0400003F RID: 63
		private global::System.IO.Stream _ioStream;

		// Token: 0x04000040 RID: 64
		private const int STGTY_STREAM = 2;

		// Token: 0x04000041 RID: 65
		private const int STGM_READ = 0;

		// Token: 0x04000042 RID: 66
		private const int STGM_WRITE = 1;

		// Token: 0x04000043 RID: 67
		private const int STGM_READWRITE = 2;

		// Token: 0x04000044 RID: 68
		private const int STREAM_SEEK_SET = 0;

		// Token: 0x04000045 RID: 69
		private const int STREAM_SEEK_CUR = 1;

		// Token: 0x04000046 RID: 70
		private const int STREAM_SEEK_END = 2;

		// Token: 0x04000047 RID: 71
		private const int STATFLAG_DEFAULT = 0;

		// Token: 0x04000048 RID: 72
		private const int STATFLAG_NONAME = 1;

		// Token: 0x04000049 RID: 73
		private const int STATFLAG_NOOPEN = 2;
	}
}
