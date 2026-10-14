using System;
using System.Text;
using NPOI.SS.Formula.Constant;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000FD RID: 253
	public class ArrayPtg : global::NPOI.SS.Formula.PTG.Ptg
	{
		// Token: 0x06000881 RID: 2177 RVA: 0x00017321 File Offset: 0x00015521
		private ArrayPtg(int reserved0, int reserved1, int reserved2, int nColumns, int nRows, object[] arrayValues)
		{
			this._reserved0Int = reserved0;
			this._reserved1Short = reserved1;
			this._reserved2Byte = reserved2;
			this._nColumns = nColumns;
			this._nRows = nRows;
			this._arrayValues = (object[])arrayValues.Clone();
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00017360 File Offset: 0x00015560
		public ArrayPtg(object[][] values2d)
		{
			int num = values2d[0].Length;
			int num2 = values2d.Length;
			this._nColumns = (int)((short)num);
			this._nRows = (int)((short)num2);
			object[] array = new object[this._nColumns * this._nRows];
			for (int i = 0; i < num2; i++)
			{
				object[] array2 = values2d[i];
				for (int j = 0; j < num; j++)
				{
					array[this.GetValueIndex(j, i)] = array2[j];
				}
			}
			this._arrayValues = array;
			this._reserved0Int = 0;
			this._reserved1Short = 0;
			this._reserved2Byte = 0;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000173F0 File Offset: 0x000155F0
		public object[][] GetTokenArrayValues()
		{
			if (this._arrayValues == null)
			{
				throw new global::System.InvalidOperationException("array values not read yet");
			}
			object[][] array = new object[this._nRows][];
			for (int i = 0; i < this._nRows; i++)
			{
				array[i] = new object[this._nColumns];
				for (int j = 0; j < this._nColumns; j++)
				{
					array[i][j] = this._arrayValues[this.GetValueIndex(j, i)];
				}
			}
			return array;
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool IsBaseToken
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00017464 File Offset: 0x00015664
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("[ArrayPtg]\n");
			stringBuilder.Append("columns = ").Append(this.ColumnCount).Append("\n");
			stringBuilder.Append("rows = ").Append(this.RowCount).Append("\n");
			for (int i = 0; i < this.ColumnCount; i++)
			{
				for (int j = 0; j < this.RowCount; j++)
				{
					object value = this._arrayValues.GetValue(this.GetValueIndex(i, j));
					stringBuilder.Append("[").Append(i).Append("][").Append(j).Append("] = ").Append(value).Append("\n");
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00017538 File Offset: 0x00015738
		public int GetValueIndex(int colIx, int rowIx)
		{
			if (colIx < 0 || colIx >= this._nColumns)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Specified colIx (",
					colIx.ToString(),
					") is outside the allowed range (0..",
					(this._nColumns - 1).ToString(),
					")"
				}));
			}
			if (rowIx < 0 || rowIx >= this._nRows)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Specified rowIx (",
					rowIx.ToString(),
					") is outside the allowed range (0..",
					(this._nRows - 1).ToString(),
					")"
				}));
			}
			return rowIx * this._nColumns + colIx;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x000175F5 File Offset: 0x000157F5
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(32 + base.PtgClass));
			out1.WriteInt(this._reserved0Int);
			out1.WriteShort(this._reserved1Short);
			out1.WriteByte(this._reserved2Byte);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0001762A File Offset: 0x0001582A
		public int WriteTokenValueBytes(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte(this._nColumns - 1);
			out1.WriteShort(this._nRows - 1);
			global::NPOI.SS.Formula.Constant.ConstantValueParser.Encode(out1, this._arrayValues);
			return 3 + global::NPOI.SS.Formula.Constant.ConstantValueParser.GetEncodedSize(this._arrayValues);
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x00017661 File Offset: 0x00015861
		public int RowCount
		{
			get
			{
				return this._nRows;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00017669 File Offset: 0x00015869
		public int ColumnCount
		{
			get
			{
				return this._nColumns;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x00017671 File Offset: 0x00015871
		public override int Size
		{
			get
			{
				return 11 + global::NPOI.SS.Formula.Constant.ConstantValueParser.GetEncodedSize(this._arrayValues);
			}
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00017684 File Offset: 0x00015884
		public override string ToFormulaString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("{");
			for (int i = 0; i < this._nRows; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(";");
				}
				for (int j = 0; j < this._nColumns; j++)
				{
					if (j > 0)
					{
						stringBuilder.Append(",");
					}
					object value = this._arrayValues.GetValue(this.GetValueIndex(j, i));
					stringBuilder.Append(global::NPOI.SS.Formula.PTG.ArrayPtg.GetConstantText(value));
				}
			}
			stringBuilder.Append("}");
			return stringBuilder.ToString();
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00017718 File Offset: 0x00015918
		private static string GetConstantText(object o)
		{
			if (o == null)
			{
				return "";
			}
			if (o is string)
			{
				return "\"" + (string)o + "\"";
			}
			if (o is double || o is double)
			{
				return global::NPOI.SS.Util.NumberToTextConverter.ToText((double)o);
			}
			if (o is bool || o is bool)
			{
				return ((bool)o).ToString().ToUpper();
			}
			if (o is global::NPOI.SS.Formula.Constant.ErrorConstant)
			{
				return ((global::NPOI.SS.Formula.Constant.ErrorConstant)o).Text;
			}
			throw new global::System.ArgumentException("Unexpected constant class (" + o.GetType().Name + ")");
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x000177BF File Offset: 0x000159BF
		public override byte DefaultOperandClass
		{
			get
			{
				return 64;
			}
		}

		// Token: 0x0400045F RID: 1119
		public const byte sid = 32;

		// Token: 0x04000460 RID: 1120
		private const int RESERVED_FIELD_LEN = 7;

		// Token: 0x04000461 RID: 1121
		public const int PLAIN_TOKEN_SIZE = 8;

		// Token: 0x04000462 RID: 1122
		private int _reserved0Int;

		// Token: 0x04000463 RID: 1123
		private int _reserved1Short;

		// Token: 0x04000464 RID: 1124
		private int _reserved2Byte;

		// Token: 0x04000465 RID: 1125
		private int _nColumns;

		// Token: 0x04000466 RID: 1126
		private int _nRows;

		// Token: 0x04000467 RID: 1127
		private object[] _arrayValues;

		// Token: 0x02000567 RID: 1383
		public class Initial : global::NPOI.SS.Formula.PTG.Ptg
		{
			// Token: 0x060033C6 RID: 13254 RVA: 0x000A19D7 File Offset: 0x0009FBD7
			public Initial(global::NPOI.Util.ILittleEndianInput in1)
			{
				this._reserved0 = in1.ReadInt();
				this._reserved1 = in1.ReadUShort();
				this._reserved2 = in1.ReadUByte();
			}

			// Token: 0x060033C7 RID: 13255 RVA: 0x000A1A03 File Offset: 0x0009FC03
			private static global::System.Exception Invalid()
			{
				throw new global::System.InvalidOperationException("This object is a partially initialised tArray, and cannot be used as a Ptg");
			}

			// Token: 0x17000D9B RID: 3483
			// (get) Token: 0x060033C8 RID: 13256 RVA: 0x000A1A0F File Offset: 0x0009FC0F
			public override byte DefaultOperandClass
			{
				get
				{
					throw global::NPOI.SS.Formula.PTG.ArrayPtg.Initial.Invalid();
				}
			}

			// Token: 0x17000D9C RID: 3484
			// (get) Token: 0x060033C9 RID: 13257 RVA: 0x00017DF4 File Offset: 0x00015FF4
			public override int Size
			{
				get
				{
					return 8;
				}
			}

			// Token: 0x17000D9D RID: 3485
			// (get) Token: 0x060033CA RID: 13258 RVA: 0x00006EB4 File Offset: 0x000050B4
			public override bool IsBaseToken
			{
				get
				{
					return false;
				}
			}

			// Token: 0x060033CB RID: 13259 RVA: 0x000A1A0F File Offset: 0x0009FC0F
			public override string ToFormulaString()
			{
				throw global::NPOI.SS.Formula.PTG.ArrayPtg.Initial.Invalid();
			}

			// Token: 0x060033CC RID: 13260 RVA: 0x000A1A0F File Offset: 0x0009FC0F
			public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
			{
				throw global::NPOI.SS.Formula.PTG.ArrayPtg.Initial.Invalid();
			}

			// Token: 0x060033CD RID: 13261 RVA: 0x000A1A18 File Offset: 0x0009FC18
			public global::NPOI.SS.Formula.PTG.ArrayPtg FinishReading(global::NPOI.Util.ILittleEndianInput in1)
			{
				int num = in1.ReadUByte();
				short num2 = in1.ReadShort();
				num++;
				num2 += 1;
				int nValues = (int)num2 * num;
				object[] arrayValues = global::NPOI.SS.Formula.Constant.ConstantValueParser.Parse(in1, nValues);
				return new global::NPOI.SS.Formula.PTG.ArrayPtg(this._reserved0, this._reserved1, this._reserved2, num, (int)num2, arrayValues)
				{
					PtgClass = base.PtgClass
				};
			}

			// Token: 0x0400189B RID: 6299
			private int _reserved0;

			// Token: 0x0400189C RID: 6300
			private int _reserved1;

			// Token: 0x0400189D RID: 6301
			private int _reserved2;
		}
	}
}
