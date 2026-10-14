using System;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula
{
	// Token: 0x020000C2 RID: 194
	public class Formula
	{
		// Token: 0x0600067B RID: 1659 RVA: 0x0000F0D8 File Offset: 0x0000D2D8
		private Formula(byte[] byteEncoding, int encodedTokenLen)
		{
			this._byteEncoding = (byte[])byteEncoding.Clone();
			this._encodedTokenLen = encodedTokenLen;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0000F0F8 File Offset: 0x0000D2F8
		public static global::NPOI.SS.Formula.Formula Read(int encodedTokenLen, global::NPOI.Util.ILittleEndianInput in1)
		{
			return global::NPOI.SS.Formula.Formula.Read(encodedTokenLen, in1, encodedTokenLen);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0000F104 File Offset: 0x0000D304
		public static global::NPOI.SS.Formula.Formula Read(int encodedTokenLen, global::NPOI.Util.ILittleEndianInput in1, int totalEncodedLen)
		{
			byte[] array = new byte[totalEncodedLen];
			in1.ReadFully(array);
			return new global::NPOI.SS.Formula.Formula(array, encodedTokenLen);
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x0000F128 File Offset: 0x0000D328
		public global::NPOI.SS.Formula.PTG.Ptg[] Tokens
		{
			get
			{
				global::NPOI.Util.ILittleEndianInput @in = new global::NPOI.Util.LittleEndianByteArrayInputStream(this._byteEncoding);
				return global::NPOI.SS.Formula.PTG.Ptg.ReadTokens(this._encodedTokenLen, @in);
			}
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0000F14D File Offset: 0x0000D34D
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this._encodedTokenLen);
			out1.Write(this._byteEncoding);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0000F167 File Offset: 0x0000D367
		public void SerializeTokens(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.Write(this._byteEncoding, 0, this._encodedTokenLen);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0000F17C File Offset: 0x0000D37C
		public void SerializeArrayConstantData(global::NPOI.Util.ILittleEndianOutput out1)
		{
			int len = this._byteEncoding.Length - this._encodedTokenLen;
			out1.Write(this._byteEncoding, this._encodedTokenLen, len);
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x0000F1AC File Offset: 0x0000D3AC
		public int EncodedSize
		{
			get
			{
				return 2 + this._byteEncoding.Length;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0000F1B8 File Offset: 0x0000D3B8
		public int EncodedTokenSize
		{
			get
			{
				return this._encodedTokenLen;
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0000F1C0 File Offset: 0x0000D3C0
		public static global::NPOI.SS.Formula.Formula Create(global::NPOI.SS.Formula.PTG.Ptg[] ptgs)
		{
			if (ptgs == null || ptgs.Length < 1)
			{
				return global::NPOI.SS.Formula.Formula.EMPTY;
			}
			byte[] array = new byte[global::NPOI.SS.Formula.PTG.Ptg.GetEncodedSize(ptgs)];
			global::NPOI.SS.Formula.PTG.Ptg.SerializePtgs(ptgs, array, 0);
			int encodedSizeWithoutArrayData = global::NPOI.SS.Formula.PTG.Ptg.GetEncodedSizeWithoutArrayData(ptgs);
			return new global::NPOI.SS.Formula.Formula(array, encodedSizeWithoutArrayData);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0000F1FF File Offset: 0x0000D3FF
		public static global::NPOI.SS.Formula.PTG.Ptg[] GetTokens(global::NPOI.SS.Formula.Formula formula)
		{
			if (formula == null)
			{
				return null;
			}
			return formula.Tokens;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0000F20C File Offset: 0x0000D40C
		public global::NPOI.SS.Formula.Formula Copy()
		{
			return this;
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x0000F210 File Offset: 0x0000D410
		public global::NPOI.SS.Util.CellReference ExpReference
		{
			get
			{
				byte[] byteEncoding = this._byteEncoding;
				if (byteEncoding.Length != 5)
				{
					return null;
				}
				byte b = byteEncoding[0];
				if (b != 1 && b != 2)
				{
					return null;
				}
				int @ushort = global::NPOI.Util.LittleEndian.GetUShort(byteEncoding, 1);
				int ushort2 = global::NPOI.Util.LittleEndian.GetUShort(byteEncoding, 3);
				return new global::NPOI.SS.Util.CellReference(@ushort, ushort2);
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0000F251 File Offset: 0x0000D451
		public bool IsSame(global::NPOI.SS.Formula.Formula other)
		{
			return global::NPOI.Util.Arrays.Equals(this._byteEncoding, other._byteEncoding);
		}

		// Token: 0x040003A9 RID: 937
		private static readonly global::NPOI.SS.Formula.Formula EMPTY = new global::NPOI.SS.Formula.Formula(new byte[0], 0);

		// Token: 0x040003AA RID: 938
		private byte[] _byteEncoding;

		// Token: 0x040003AB RID: 939
		private int _encodedTokenLen;
	}
}
