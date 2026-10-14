using System;
using System.Text;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003E1 RID: 993
	internal class SpecialCachedValue
	{
		// Token: 0x06002399 RID: 9113 RVA: 0x0006B8F0 File Offset: 0x00069AF0
		private SpecialCachedValue(byte[] data)
		{
			this._variableData = data;
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x0006B8FF File Offset: 0x00069AFF
		public int GetTypeCode()
		{
			return (int)this._variableData[0];
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x0006B90C File Offset: 0x00069B0C
		public static global::NPOI.HSSF.Record.SpecialCachedValue Create(long valueLongBits)
		{
			if ((-281474976710656L & valueLongBits) != -281474976710656L)
			{
				return null;
			}
			byte[] array = new byte[6];
			long num = valueLongBits;
			for (int i = 0; i < 6; i++)
			{
				array[i] = (byte)num;
				num >>= 8;
			}
			byte b = array[0];
			if (b > 3)
			{
				throw new global::NPOI.Util.RecordFormatException("Bad special value code (" + array[0].ToString() + ")");
			}
			return new global::NPOI.HSSF.Record.SpecialCachedValue(array);
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x0006B97E File Offset: 0x00069B7E
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.Write(this._variableData);
			out1.WriteShort(65535);
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x0600239D RID: 9117 RVA: 0x0006B997 File Offset: 0x00069B97
		public string FormatDebugString
		{
			get
			{
				return this.FormatValue + " " + global::NPOI.Util.HexDump.ToHex(this._variableData);
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x0600239E RID: 9118 RVA: 0x0006B9B4 File Offset: 0x00069BB4
		private string FormatValue
		{
			get
			{
				int typeCode = this.GetTypeCode();
				switch (typeCode)
				{
				case 0:
					return "<string>";
				case 1:
					if (this.DataValue != 0)
					{
						return "TRUE";
					}
					return "FALSE";
				case 2:
					return global::NPOI.SS.Formula.Eval.ErrorEval.GetText(this.DataValue);
				case 3:
					return "<empty>";
				default:
					return "#error(type=" + typeCode.ToString() + ")#";
				}
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x0600239F RID: 9119 RVA: 0x0006BA22 File Offset: 0x00069C22
		private int DataValue
		{
			get
			{
				return (int)this._variableData[2];
			}
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x0006BA2C File Offset: 0x00069C2C
		public static global::NPOI.HSSF.Record.SpecialCachedValue CreateCachedEmptyValue()
		{
			return global::NPOI.HSSF.Record.SpecialCachedValue.Create(3, 0);
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x0006BA35 File Offset: 0x00069C35
		public static global::NPOI.HSSF.Record.SpecialCachedValue CreateForString()
		{
			return global::NPOI.HSSF.Record.SpecialCachedValue.Create(0, 0);
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x0006BA3E File Offset: 0x00069C3E
		public static global::NPOI.HSSF.Record.SpecialCachedValue CreateCachedBoolean(bool b)
		{
			return global::NPOI.HSSF.Record.SpecialCachedValue.Create(1, b ? 1 : 0);
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x0006BA4D File Offset: 0x00069C4D
		public static global::NPOI.HSSF.Record.SpecialCachedValue CreateCachedErrorCode(int errorCode)
		{
			return global::NPOI.HSSF.Record.SpecialCachedValue.Create(2, errorCode);
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x0006BA56 File Offset: 0x00069C56
		private static global::NPOI.HSSF.Record.SpecialCachedValue Create(int code, int data)
		{
			byte[] array = new byte[6];
			array[0] = (byte)code;
			array[2] = (byte)data;
			return new global::NPOI.HSSF.Record.SpecialCachedValue(array);
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x0006BA6D File Offset: 0x00069C6D
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append('[').Append(this.FormatValue).Append(']');
			return stringBuilder.ToString();
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x0006BAA8 File Offset: 0x00069CA8
		public global::NPOI.SS.UserModel.CellType GetValueType()
		{
			int typeCode = this.GetTypeCode();
			switch (typeCode)
			{
			case 0:
				return global::NPOI.SS.UserModel.CellType.String;
			case 1:
				return global::NPOI.SS.UserModel.CellType.Boolean;
			case 2:
				return global::NPOI.SS.UserModel.CellType.Error;
			case 3:
				return global::NPOI.SS.UserModel.CellType.String;
			default:
				throw new global::System.InvalidOperationException("Unexpected type id (" + typeCode.ToString() + ")");
			}
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x0006BAF7 File Offset: 0x00069CF7
		public bool GetBooleanValue()
		{
			if (this.GetTypeCode() != 1)
			{
				throw new global::System.InvalidOperationException("Not a bool cached value - " + this.FormatValue);
			}
			return this.DataValue != 0;
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x0006BB21 File Offset: 0x00069D21
		public int GetErrorValue()
		{
			if (this.GetTypeCode() != 2)
			{
				throw new global::System.InvalidOperationException("Not an error cached value - " + this.FormatValue);
			}
			return this.DataValue;
		}

		// Token: 0x04000EFB RID: 3835
		private const long BIT_MARKER = -281474976710656L;

		// Token: 0x04000EFC RID: 3836
		private const int VARIABLE_DATA_LENGTH = 6;

		// Token: 0x04000EFD RID: 3837
		private const int DATA_INDEX = 2;

		// Token: 0x04000EFE RID: 3838
		public const int STRING = 0;

		// Token: 0x04000EFF RID: 3839
		public const int BOOLEAN = 1;

		// Token: 0x04000F00 RID: 3840
		public const int ERROR_CODE = 2;

		// Token: 0x04000F01 RID: 3841
		public const int EMPTY = 3;

		// Token: 0x04000F02 RID: 3842
		private byte[] _variableData;
	}
}
