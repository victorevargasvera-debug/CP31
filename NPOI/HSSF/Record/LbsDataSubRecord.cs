using System;
using System.Globalization;
using System.Text;
using NPOI.SS.Formula.PTG;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200042A RID: 1066
	public class LbsDataSubRecord : global::NPOI.HSSF.Record.SubRecord, global::System.ICloneable
	{
		// Token: 0x06002731 RID: 10033 RVA: 0x000618AB File Offset: 0x0005FAAB
		private LbsDataSubRecord()
		{
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x00075CE4 File Offset: 0x00073EE4
		public LbsDataSubRecord(global::NPOI.Util.ILittleEndianInput in1, int cbFContinued, int cmoOt)
		{
			this._cbFContinued = cbFContinued;
			int num = in1.ReadUShort();
			if (num > 0)
			{
				int num2 = in1.ReadUShort();
				this._unknownPreFormulaInt = in1.ReadInt();
				global::NPOI.SS.Formula.PTG.Ptg[] array = global::NPOI.SS.Formula.PTG.Ptg.ReadTokens(num2, in1);
				if (array.Length != 1)
				{
					throw new global::NPOI.Util.RecordFormatException("Read " + array.Length.ToString() + " tokens but expected exactly 1");
				}
				this._linkPtg = array[0];
				int num3 = num - num2 - 6;
				if (num3 != 0)
				{
					if (num3 != 1)
					{
						throw new global::NPOI.Util.RecordFormatException("Unexpected leftover bytes");
					}
					this._unknownPostFormulaByte = new byte?((byte)in1.ReadByte());
				}
				else
				{
					this._unknownPostFormulaByte = null;
				}
			}
			this._cLines = in1.ReadUShort();
			this._iSel = in1.ReadUShort();
			this._flags = in1.ReadUShort();
			this._idEdit = in1.ReadUShort();
			if (cmoOt == 20)
			{
				this._dropData = new global::NPOI.HSSF.Record.LbsDropData(in1);
			}
			if ((this._flags & 2) != 0)
			{
				this._rgLines = new string[this._cLines];
				for (int i = 0; i < this._cLines; i++)
				{
					this._rgLines[i] = global::NPOI.Util.StringUtil.ReadUnicodeString(in1);
				}
			}
			if ((this._flags >> 4 & 2) != 0)
			{
				this._bsels = new bool[this._cLines];
				for (int j = 0; j < this._cLines; j++)
				{
					this._bsels[j] = (in1.ReadByte() == 1);
				}
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06002733 RID: 10035 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool IsTerminating
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x00075E54 File Offset: 0x00074054
		public global::NPOI.SS.Formula.PTG.Ptg Formula
		{
			get
			{
				return this._linkPtg;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06002735 RID: 10037 RVA: 0x00075E5C File Offset: 0x0007405C
		public int NumberOfItems
		{
			get
			{
				return this._cLines;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06002736 RID: 10038 RVA: 0x000199B2 File Offset: 0x00017BB2
		public override short Sid
		{
			get
			{
				return 19;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06002737 RID: 10039 RVA: 0x00075E64 File Offset: 0x00074064
		public override int DataSize
		{
			get
			{
				int num = 2;
				if (this._linkPtg != null)
				{
					num += 2;
					num += 4;
					num += this._linkPtg.Size;
					if (this._unknownPostFormulaByte != null)
					{
						num++;
					}
				}
				num += 8;
				if (this._dropData != null)
				{
					num += this._dropData.DataSize;
				}
				if (this._rgLines != null)
				{
					foreach (string value in this._rgLines)
					{
						num += global::NPOI.Util.StringUtil.GetEncodedSize(value);
					}
				}
				if (this._bsels != null)
				{
					num += this._bsels.Length;
				}
				return num;
			}
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x00075EFC File Offset: 0x000740FC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(19);
			out1.WriteShort(this._cbFContinued);
			if (this._linkPtg == null)
			{
				out1.WriteShort(0);
			}
			else
			{
				int size = this._linkPtg.Size;
				int num = size + 6;
				if (this._unknownPostFormulaByte != null)
				{
					num++;
				}
				out1.WriteShort(num);
				out1.WriteShort(size);
				out1.WriteInt(this._unknownPreFormulaInt);
				this._linkPtg.Write(out1);
				if (this._unknownPostFormulaByte != null)
				{
					out1.WriteByte((int)global::System.Convert.ToByte(this._unknownPostFormulaByte, global::System.Globalization.CultureInfo.InvariantCulture));
				}
			}
			out1.WriteShort(this._cLines);
			out1.WriteShort(this._iSel);
			out1.WriteShort(this._flags);
			out1.WriteShort(this._idEdit);
			if (this._dropData != null)
			{
				this._dropData.Serialize(out1);
			}
			if (this._rgLines != null)
			{
				foreach (string value in this._rgLines)
				{
					global::NPOI.Util.StringUtil.WriteUnicodeString(out1, value);
				}
			}
			if (this._bsels != null)
			{
				bool[] bsels = this._bsels;
				for (int i = 0; i < bsels.Length; i++)
				{
					out1.WriteByte(bsels[i] ? 1 : 0);
				}
			}
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x00076040 File Offset: 0x00074240
		private static global::NPOI.SS.Formula.PTG.Ptg ReadRefPtg(byte[] formulaRawBytes)
		{
			global::NPOI.Util.ILittleEndianInput littleEndianInput = new global::NPOI.Util.LittleEndianByteArrayInputStream(formulaRawBytes);
			byte b = (byte)littleEndianInput.ReadByte();
			if (b <= 37)
			{
				if (b == 36)
				{
					return new global::NPOI.SS.Formula.PTG.RefPtg(littleEndianInput);
				}
				if (b == 37)
				{
					return new global::NPOI.SS.Formula.PTG.AreaPtg(littleEndianInput);
				}
			}
			else
			{
				if (b == 58)
				{
					return new global::NPOI.SS.Formula.PTG.Ref3DPtg(littleEndianInput);
				}
				if (b == 59)
				{
					return new global::NPOI.SS.Formula.PTG.Area3DPtg(littleEndianInput);
				}
			}
			return null;
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x0000F20C File Offset: 0x0000D40C
		public override object Clone()
		{
			return this;
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x00076098 File Offset: 0x00074298
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(256);
			stringBuilder.Append("[ftLbsData]\n");
			stringBuilder.Append("    .unknownshort1 =").Append(global::NPOI.Util.HexDump.ShortToHex(this._cbFContinued)).Append("\n");
			stringBuilder.Append("    .formula        = ").Append('\n');
			if (this._linkPtg != null)
			{
				stringBuilder.Append(this._linkPtg.ToString()).Append(this._linkPtg.RVAType).Append('\n');
			}
			stringBuilder.Append("    .nEntryCount   =").Append(global::NPOI.Util.HexDump.ShortToHex(this._cLines)).Append("\n");
			stringBuilder.Append("    .selEntryIx    =").Append(global::NPOI.Util.HexDump.ShortToHex(this._iSel)).Append("\n");
			stringBuilder.Append("    .style         =").Append(global::NPOI.Util.HexDump.ShortToHex(this._flags)).Append("\n");
			stringBuilder.Append("    .unknownshort10=").Append(global::NPOI.Util.HexDump.ShortToHex(this._idEdit)).Append("\n");
			if (this._dropData != null)
			{
				stringBuilder.Append('\n').Append(this._dropData.ToString());
			}
			stringBuilder.Append("[/ftLbsData]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x000761F4 File Offset: 0x000743F4
		public static global::NPOI.HSSF.Record.LbsDataSubRecord CreateAutoFilterInstance()
		{
			return new global::NPOI.HSSF.Record.LbsDataSubRecord
			{
				_cbFContinued = 8174,
				_iSel = 0,
				_flags = 769,
				_dropData = new global::NPOI.HSSF.Record.LbsDropData(),
				_dropData = 
				{
					_wStyle = 2,
					_cLine = 8
				}
			};
		}

		// Token: 0x04001085 RID: 4229
		public const int sid = 19;

		// Token: 0x04001086 RID: 4230
		private int _cbFContinued;

		// Token: 0x04001087 RID: 4231
		private int _unknownPreFormulaInt;

		// Token: 0x04001088 RID: 4232
		private global::NPOI.SS.Formula.PTG.Ptg _linkPtg;

		// Token: 0x04001089 RID: 4233
		private byte? _unknownPostFormulaByte;

		// Token: 0x0400108A RID: 4234
		private int _cLines;

		// Token: 0x0400108B RID: 4235
		private int _iSel;

		// Token: 0x0400108C RID: 4236
		private int _flags;

		// Token: 0x0400108D RID: 4237
		private int _idEdit;

		// Token: 0x0400108E RID: 4238
		private global::NPOI.HSSF.Record.LbsDropData _dropData;

		// Token: 0x0400108F RID: 4239
		private string[] _rgLines;

		// Token: 0x04001090 RID: 4240
		private bool[] _bsels;
	}
}
