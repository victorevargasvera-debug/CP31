using System;
using System.Runtime.CompilerServices;

namespace ICSharpCode.SharpZipLib.Checksum
{
	// Token: 0x02000072 RID: 114
	public sealed class Crc32 : global::ICSharpCode.SharpZipLib.Checksum.IChecksum
	{
		// Token: 0x060004A3 RID: 1187 RVA: 0x000144E6 File Offset: 0x000126E6
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		internal static uint ComputeCrc32(uint oldCrc, byte bval)
		{
			return global::ICSharpCode.SharpZipLib.Checksum.Crc32.crcTable[(int)((oldCrc ^ (uint)bval) & 255U)] ^ oldCrc >> 8;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000144FB File Offset: 0x000126FB
		public Crc32()
		{
			this.Reset();
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00014509 File Offset: 0x00012709
		public void Reset()
		{
			this.checkValue = global::ICSharpCode.SharpZipLib.Checksum.Crc32.crcInit;
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00014516 File Offset: 0x00012716
		public long Value
		{
			get
			{
				return (long)((ulong)(this.checkValue ^ global::ICSharpCode.SharpZipLib.Checksum.Crc32.crcXor));
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00014525 File Offset: 0x00012725
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Update(int bval)
		{
			this.checkValue = (global::ICSharpCode.SharpZipLib.Checksum.Crc32.crcTable[(int)(checked((global::System.IntPtr)(unchecked((ulong)this.checkValue ^ (ulong)((long)bval)) & 255UL)))] ^ this.checkValue >> 8);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0001454E File Offset: 0x0001274E
		public void Update(byte[] buffer)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			this.Update(buffer, 0, buffer.Length);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00014569 File Offset: 0x00012769
		public void Update(global::System.ArraySegment<byte> segment)
		{
			this.Update(segment.Array, segment.Offset, segment.Count);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00014588 File Offset: 0x00012788
		private void Update(byte[] data, int offset, int count)
		{
			int num = count % 16;
			int num2 = offset + count - num;
			while (offset != num2)
			{
				this.checkValue = global::ICSharpCode.SharpZipLib.Checksum.CrcUtilities.UpdateDataForReversedPoly(data, offset, global::ICSharpCode.SharpZipLib.Checksum.Crc32.crcTable, this.checkValue);
				offset += 16;
			}
			if (num != 0)
			{
				this.SlowUpdateLoop(data, offset, num2 + num);
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000145D2 File Offset: 0x000127D2
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private void SlowUpdateLoop(byte[] data, int offset, int end)
		{
			while (offset != end)
			{
				this.Update((int)data[offset++]);
			}
		}

		// Token: 0x040002AD RID: 685
		private static readonly uint crcInit = uint.MaxValue;

		// Token: 0x040002AE RID: 686
		private static readonly uint crcXor = uint.MaxValue;

		// Token: 0x040002AF RID: 687
		private static readonly uint[] crcTable = global::ICSharpCode.SharpZipLib.Checksum.CrcUtilities.GenerateSlicingLookupTable(3988292384U, true);

		// Token: 0x040002B0 RID: 688
		private uint checkValue;
	}
}
