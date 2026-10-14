using System;
using System.Text;
using NPOI.SS.Formula;
using NPOI.SS.Formula.Constant;
using NPOI.SS.Formula.PTG;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003D5 RID: 981
	public class ExternalNameRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060022F6 RID: 8950 RVA: 0x00069EDB File Offset: 0x000680DB
		public ExternalNameRecord()
		{
			this.field_2_ixals = 0;
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00069EEC File Offset: 0x000680EC
		public ExternalNameRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_option_flag = in1.ReadShort();
			this.field_2_ixals = in1.ReadShort();
			this.field_3_not_used = in1.ReadShort();
			int nChars = in1.ReadUByte();
			this.field_4_name = global::NPOI.Util.StringUtil.ReadUnicodeString(in1, nChars);
			if (!this.IsOLELink && !this.IsStdDocumentNameIdentifier)
			{
				if (this.IsAutomaticLink)
				{
					if (in1.Available() > 0)
					{
						int num = in1.ReadUByte() + 1;
						int num2 = (int)(in1.ReadShort() + 1);
						int nValues = num2 * num;
						this._ddeValues = global::NPOI.SS.Formula.Constant.ConstantValueParser.Parse(in1, nValues);
						this._nColumns = num;
						this._nRows = num2;
						return;
					}
				}
				else
				{
					int encodedTokenLen = in1.ReadUShort();
					this.field_5_name_definition = global::NPOI.SS.Formula.Formula.Read(encodedTokenLen, in1);
				}
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060022F8 RID: 8952 RVA: 0x00069FA0 File Offset: 0x000681A0
		public bool IsBuiltInName
		{
			get
			{
				return (this.field_1_option_flag & 1) != 0;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x00069FAD File Offset: 0x000681AD
		public bool IsAutomaticLink
		{
			get
			{
				return (this.field_1_option_flag & 2) != 0;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060022FA RID: 8954 RVA: 0x00069FBA File Offset: 0x000681BA
		public bool IsPicureLink
		{
			get
			{
				return (this.field_1_option_flag & 4) != 0;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x00069FC7 File Offset: 0x000681C7
		public bool IsStdDocumentNameIdentifier
		{
			get
			{
				return (this.field_1_option_flag & 8) != 0;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060022FC RID: 8956 RVA: 0x00069FD4 File Offset: 0x000681D4
		public bool IsOLELink
		{
			get
			{
				return (this.field_1_option_flag & 16) != 0;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x00069FE2 File Offset: 0x000681E2
		public bool IsIconifiedPictureLink
		{
			get
			{
				return ((int)this.field_1_option_flag & 32768) != 0;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x00069FF3 File Offset: 0x000681F3
		// (set) Token: 0x060022FF RID: 8959 RVA: 0x00069FFB File Offset: 0x000681FB
		public short Ix
		{
			get
			{
				return this.field_2_ixals;
			}
			set
			{
				this.field_2_ixals = value;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06002300 RID: 8960 RVA: 0x0006A004 File Offset: 0x00068204
		// (set) Token: 0x06002301 RID: 8961 RVA: 0x0006A00C File Offset: 0x0006820C
		public string Text
		{
			get
			{
				return this.field_4_name;
			}
			set
			{
				this.field_4_name = value;
			}
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0006A015 File Offset: 0x00068215
		public global::NPOI.SS.Formula.PTG.Ptg[] GetParsedExpression()
		{
			return global::NPOI.SS.Formula.Formula.GetTokens(this.field_5_name_definition);
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x0006A022 File Offset: 0x00068222
		public void SetParsedExpression(global::NPOI.SS.Formula.PTG.Ptg[] ptgs)
		{
			this.field_5_name_definition = global::NPOI.SS.Formula.Formula.Create(ptgs);
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x0006A030 File Offset: 0x00068230
		protected override int DataSize
		{
			get
			{
				int num = 6;
				num += global::NPOI.Util.StringUtil.GetEncodedSize(this.field_4_name) - 1;
				if (!this.IsOLELink && !this.IsStdDocumentNameIdentifier)
				{
					if (this.IsAutomaticLink)
					{
						if (this._ddeValues != null)
						{
							num += 3;
							num += global::NPOI.SS.Formula.Constant.ConstantValueParser.GetEncodedSize(this._ddeValues);
						}
					}
					else
					{
						num += this.field_5_name_definition.EncodedSize;
					}
				}
				return num;
			}
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x0006A094 File Offset: 0x00068294
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_option_flag);
			out1.WriteShort((int)this.field_2_ixals);
			out1.WriteShort((int)this.field_3_not_used);
			out1.WriteByte(this.field_4_name.Length);
			global::NPOI.Util.StringUtil.WriteUnicodeStringFlagAndData(out1, this.field_4_name);
			if (!this.IsOLELink && !this.IsStdDocumentNameIdentifier)
			{
				if (this.IsAutomaticLink)
				{
					if (this._ddeValues != null)
					{
						out1.WriteByte(this._nColumns - 1);
						out1.WriteShort(this._nRows - 1);
						global::NPOI.SS.Formula.Constant.ConstantValueParser.Encode(out1, this._ddeValues);
						return;
					}
				}
				else
				{
					this.field_5_name_definition.Serialize(out1);
				}
			}
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x0006A138 File Offset: 0x00068338
		private global::System.Exception ReadFail(string msg)
		{
			return new global::System.Exception(string.Concat(new string[]
			{
				msg,
				" fields: (option=",
				this.field_1_option_flag.ToString(),
				" index=",
				this.field_2_ixals.ToString(),
				" not_used=",
				this.field_3_not_used.ToString(),
				" name='",
				this.field_4_name,
				"')"
			}));
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x0006A1B6 File Offset: 0x000683B6
		private bool HasFormula
		{
			get
			{
				return !this.IsAutomaticLink;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x0006A1C3 File Offset: 0x000683C3
		public override short Sid
		{
			get
			{
				return 35;
			}
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x0006A1C8 File Offset: 0x000683C8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[EXTERNALNAME]\n");
			stringBuilder.Append("    .options      = ").Append(this.field_1_option_flag).Append("\n");
			stringBuilder.Append("    .ix      = ").Append(this.field_2_ixals).Append("\n");
			stringBuilder.Append("    .name    = ").Append(this.field_4_name).Append("\n");
			if (this.field_5_name_definition != null)
			{
				foreach (global::NPOI.SS.Formula.PTG.Ptg ptg in this.field_5_name_definition.Tokens)
				{
					stringBuilder.Append(ptg.ToString()).Append(ptg.RVAType).Append("\n");
				}
			}
			stringBuilder.Append("[/EXTERNALNAME]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04000EB7 RID: 3767
		public const short sid = 35;

		// Token: 0x04000EB8 RID: 3768
		private const int OPT_BUILTIN_NAME = 1;

		// Token: 0x04000EB9 RID: 3769
		private const int OPT_AUTOMATIC_LINK = 2;

		// Token: 0x04000EBA RID: 3770
		private const int OPT_PICTURE_LINK = 4;

		// Token: 0x04000EBB RID: 3771
		private const int OPT_STD_DOCUMENT_NAME = 8;

		// Token: 0x04000EBC RID: 3772
		private const int OPT_OLE_LINK = 16;

		// Token: 0x04000EBD RID: 3773
		private const int OPT_ICONIFIED_PICTURE_LINK = 32768;

		// Token: 0x04000EBE RID: 3774
		private short field_1_option_flag;

		// Token: 0x04000EBF RID: 3775
		private short field_2_ixals;

		// Token: 0x04000EC0 RID: 3776
		private short field_3_not_used;

		// Token: 0x04000EC1 RID: 3777
		private string field_4_name;

		// Token: 0x04000EC2 RID: 3778
		private global::NPOI.SS.Formula.Formula field_5_name_definition;

		// Token: 0x04000EC3 RID: 3779
		private object[] _ddeValues;

		// Token: 0x04000EC4 RID: 3780
		private int _nColumns;

		// Token: 0x04000EC5 RID: 3781
		private int _nRows;
	}
}
