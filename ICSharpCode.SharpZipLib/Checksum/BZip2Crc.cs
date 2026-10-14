using System;
using System.Runtime.CompilerServices;

namespace ICSharpCode.SharpZipLib.Checksum
{
	// Token: 0x02000071 RID: 113
	public sealed class BZip2Crc : global::ICSharpCode.SharpZipLib.Checksum.IChecksum
	{
		// Token: 0x0600049A RID: 1178 RVA: 0x000143F0 File Offset: 0x000125F0
		public BZip2Crc()
		{
			this.Reset();
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000143FE File Offset: 0x000125FE
		public void Reset()
		{
			this.checkValue = uint.MaxValue;
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00014407 File Offset: 0x00012607
		public long Value
		{
			get
			{
				return (long)((ulong)(~(ulong)this.checkValue));
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00014411 File Offset: 0x00012611
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Update(int bval)
		{
			this.checkValue = (global::ICSharpCode.SharpZipLib.Checksum.BZip2Crc.crcTable[(int)((byte)((ulong)(this.checkValue >> 24 & 255U) ^ (ulong)((long)bval)))] ^ this.checkValue << 8);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0001443C File Offset: 0x0001263C
		public void Update(byte[] buffer)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			this.Update(buffer, 0, buffer.Length);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00014457 File Offset: 0x00012657
		public void Update(global::System.ArraySegment<byte> segment)
		{
			this.Update(segment.Array, segment.Offset, segment.Count);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00014474 File Offset: 0x00012674
		private void Update(byte[] data, int offset, int count)
		{
			int num = count % 16;
			int num2 = offset + count - num;
			while (offset != num2)
			{
				this.checkValue = global::ICSharpCode.SharpZipLib.Checksum.CrcUtilities.UpdateDataForNormalPoly(data, offset, global::ICSharpCode.SharpZipLib.Checksum.BZip2Crc.crcTable, this.checkValue);
				offset += 16;
			}
			if (num != 0)
			{
				this.SlowUpdateLoop(data, offset, num2 + num);
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x000144BE File Offset: 0x000126BE
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private void SlowUpdateLoop(byte[] data, int offset, int end)
		{
			while (offset != end)
			{
				this.Update((int)data[offset++]);
			}
		}

		// Token: 0x040002AA RID: 682
		private const uint crcInit = 4294967295U;

		// Token: 0x040002AB RID: 683
		private static readonly uint[] crcTable = global::ICSharpCode.SharpZipLib.Checksum.CrcUtilities.GenerateSlicingLookupTable(79764919U, false);

		// Token: 0x040002AC RID: 684
		private uint checkValue;
	}
}
