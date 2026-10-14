using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksum;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.GZip
{
	// Token: 0x02000054 RID: 84
	public class GZipOutputStream : global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.DeflaterOutputStream
	{
		// Token: 0x060003F2 RID: 1010 RVA: 0x0001278A File Offset: 0x0001098A
		public GZipOutputStream(global::System.IO.Stream baseOutputStream) : this(baseOutputStream, 4096)
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00012798 File Offset: 0x00010998
		public GZipOutputStream(global::System.IO.Stream baseOutputStream, int size) : base(baseOutputStream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater(-1, true), size)
		{
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000127B4 File Offset: 0x000109B4
		public void SetLevel(int level)
		{
			if (level < 0 || level > 9)
			{
				throw new global::System.ArgumentOutOfRangeException("level", "Compression level must be 0-9");
			}
			this.deflater_.SetLevel(level);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000127DB File Offset: 0x000109DB
		public int GetLevel()
		{
			return this.deflater_.GetLevel();
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x000127E8 File Offset: 0x000109E8
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x000127F0 File Offset: 0x000109F0
		public string FileName
		{
			get
			{
				return this.fileName;
			}
			set
			{
				this.fileName = global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.CleanFilename(value);
				if (string.IsNullOrEmpty(this.fileName))
				{
					this.flags &= ~global::ICSharpCode.SharpZipLib.GZip.GZipFlags.FNAME;
					return;
				}
				this.flags |= global::ICSharpCode.SharpZipLib.GZip.GZipFlags.FNAME;
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0001282C File Offset: 0x00010A2C
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this.state_ == global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Header)
			{
				this.WriteHeader();
			}
			if (this.state_ != global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Footer)
			{
				throw new global::System.InvalidOperationException("Write not permitted in current state");
			}
			this.crc.Update(new global::System.ArraySegment<byte>(buffer, offset, count));
			base.Write(buffer, offset, count);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0001286C File Offset: 0x00010A6C
		protected override void Dispose(bool disposing)
		{
			try
			{
				this.Finish();
			}
			finally
			{
				if (this.state_ != global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Closed)
				{
					this.state_ = global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Closed;
					if (base.IsStreamOwner)
					{
						this.baseOutputStream_.Dispose();
					}
				}
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000128B8 File Offset: 0x00010AB8
		public override void Flush()
		{
			if (this.state_ == global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Header)
			{
				this.WriteHeader();
			}
			base.Flush();
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000128D0 File Offset: 0x00010AD0
		public override void Finish()
		{
			if (this.state_ == global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Header)
			{
				this.WriteHeader();
			}
			if (this.state_ == global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Footer)
			{
				this.state_ = global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Finished;
				base.Finish();
				uint num = (uint)(this.deflater_.TotalIn & (long)((ulong)-1));
				uint num2 = (uint)(this.crc.Value & (long)((ulong)-1));
				byte[] array = new byte[]
				{
					(byte)num2,
					(byte)(num2 >> 8),
					(byte)(num2 >> 16),
					(byte)(num2 >> 24),
					(byte)num,
					(byte)(num >> 8),
					(byte)(num >> 16),
					(byte)(num >> 24)
				};
				this.baseOutputStream_.Write(array, 0, array.Length);
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00012970 File Offset: 0x00010B70
		private static string CleanFilename(string path)
		{
			return path.Substring(path.LastIndexOf('/') + 1);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00012984 File Offset: 0x00010B84
		private void WriteHeader()
		{
			if (this.state_ == global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Header)
			{
				this.state_ = global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Footer;
				int num = (int)((global::System.DateTime.Now.Ticks - new global::System.DateTime(1970, 1, 1).Ticks) / 10000000L);
				byte[] array = new byte[]
				{
					31,
					139,
					8,
					0,
					0,
					0,
					0,
					0,
					0,
					byte.MaxValue
				};
				array[3] = this.flags;
				array[4] = (byte)num;
				array[5] = (byte)(num >> 8);
				array[6] = (byte)(num >> 16);
				array[7] = (byte)(num >> 24);
				byte[] array2 = array;
				this.baseOutputStream_.Write(array2, 0, array2.Length);
				if (this.flags.HasFlag(global::ICSharpCode.SharpZipLib.GZip.GZipFlags.FNAME))
				{
					byte[] bytes = global::ICSharpCode.SharpZipLib.GZip.GZipConstants.Encoding.GetBytes(this.fileName);
					this.baseOutputStream_.Write(bytes, 0, bytes.Length);
					this.baseOutputStream_.Write(new byte[1], 0, 1);
				}
			}
		}

		// Token: 0x0400026F RID: 623
		protected global::ICSharpCode.SharpZipLib.Checksum.Crc32 crc = new global::ICSharpCode.SharpZipLib.Checksum.Crc32();

		// Token: 0x04000270 RID: 624
		private global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState state_;

		// Token: 0x04000271 RID: 625
		private string fileName;

		// Token: 0x04000272 RID: 626
		private global::ICSharpCode.SharpZipLib.GZip.GZipFlags flags;

		// Token: 0x0200008F RID: 143
		private enum OutputState
		{
			// Token: 0x04000370 RID: 880
			Header,
			// Token: 0x04000371 RID: 881
			Footer,
			// Token: 0x04000372 RID: 882
			Finished,
			// Token: 0x04000373 RID: 883
			Closed
		}
	}
}
