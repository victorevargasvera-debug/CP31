using System;
using System.Text;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000FE RID: 254
	public class AttrPtg : global::NPOI.SS.Formula.PTG.ControlPtg
	{
		// Token: 0x0600088F RID: 2191 RVA: 0x000177C3 File Offset: 0x000159C3
		public AttrPtg()
		{
			this._jumpTable = null;
			this._chooseFuncOffset = -1;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x000177DC File Offset: 0x000159DC
		public AttrPtg(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.field_1_options = (byte)in1.ReadByte();
			this.field_2_data = in1.ReadShort();
			if (this.IsOptimizedChoose)
			{
				int[] array = new int[(int)this.field_2_data];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = in1.ReadUShort();
				}
				this._jumpTable = array;
				this._chooseFuncOffset = in1.ReadUShort();
				return;
			}
			this._jumpTable = null;
			this._chooseFuncOffset = -1;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00017855 File Offset: 0x00015A55
		private AttrPtg(int options, int data, int[] jt, int chooseFuncOffset)
		{
			this.field_1_options = (byte)options;
			this.field_2_data = (short)data;
			this._jumpTable = jt;
			this._chooseFuncOffset = chooseFuncOffset;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0001787C File Offset: 0x00015A7C
		public static global::NPOI.SS.Formula.PTG.AttrPtg CreateSpace(global::NPOI.SS.Formula.PTG.AttrPtg.SpaceType type, int count)
		{
			int data = (int)((type & (global::NPOI.SS.Formula.PTG.AttrPtg.SpaceType)255) | (global::NPOI.SS.Formula.PTG.AttrPtg.SpaceType)(count << 8 & 65535));
			return new global::NPOI.SS.Formula.PTG.AttrPtg(global::NPOI.SS.Formula.PTG.AttrPtg.space.Set(0), data, null, -1);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x000178AE File Offset: 0x00015AAE
		public static global::NPOI.SS.Formula.PTG.AttrPtg CreateIf(int dist)
		{
			return new global::NPOI.SS.Formula.PTG.AttrPtg(global::NPOI.SS.Formula.PTG.AttrPtg.optiIf.Set(0), dist, null, -1);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000178C3 File Offset: 0x00015AC3
		public static global::NPOI.SS.Formula.PTG.AttrPtg CreateSkip(int dist)
		{
			return new global::NPOI.SS.Formula.PTG.AttrPtg(global::NPOI.SS.Formula.PTG.AttrPtg.optiSkip.Set(0), dist, null, -1);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000178D8 File Offset: 0x00015AD8
		public static global::NPOI.SS.Formula.PTG.AttrPtg GetSumSingle()
		{
			return new global::NPOI.SS.Formula.PTG.AttrPtg(global::NPOI.SS.Formula.PTG.AttrPtg.optiSum.Set(0), 0, null, -1);
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x000178ED File Offset: 0x00015AED
		public bool IsSemiVolatile
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.AttrPtg.semiVolatile.IsSet((int)this.field_1_options);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x000178FF File Offset: 0x00015AFF
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x00017911 File Offset: 0x00015B11
		public bool IsOptimizedIf
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.AttrPtg.optiIf.IsSet((int)this.field_1_options);
			}
			set
			{
				this.field_1_options = global::NPOI.SS.Formula.PTG.AttrPtg.optiIf.SetByteBoolean(this.field_1_options, value);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x0001792A File Offset: 0x00015B2A
		public bool IsOptimizedChoose
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.AttrPtg.optiChoose.IsSet((int)this.field_1_options);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x0001793C File Offset: 0x00015B3C
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x0001794E File Offset: 0x00015B4E
		public bool IsSum
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.AttrPtg.optiSum.IsSet((int)this.field_1_options);
			}
			set
			{
				this.field_1_options = global::NPOI.SS.Formula.PTG.AttrPtg.optiSum.SetByteBoolean(this.field_1_options, value);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00017967 File Offset: 0x00015B67
		public bool IsBaxcel
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.AttrPtg.baxcel.IsSet((int)this.field_1_options);
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x00017979 File Offset: 0x00015B79
		public bool IsSpace
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.AttrPtg.space.IsSet((int)this.field_1_options);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0001798B File Offset: 0x00015B8B
		public bool IsSkip
		{
			get
			{
				return global::NPOI.SS.Formula.PTG.AttrPtg.optiSkip.IsSet((int)this.field_1_options);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x0001799D File Offset: 0x00015B9D
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x000179A5 File Offset: 0x00015BA5
		public short Data
		{
			get
			{
				return this.field_2_data;
			}
			set
			{
				this.field_2_data = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x000179AE File Offset: 0x00015BAE
		public int[] JumpTable
		{
			get
			{
				return (int[])this._jumpTable.Clone();
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x000179C0 File Offset: 0x00015BC0
		public int ChooseFuncOffset
		{
			get
			{
				if (this._jumpTable == null)
				{
					throw new global::System.InvalidOperationException("Not tAttrChoose");
				}
				return this._chooseFuncOffset;
			}
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x000179DC File Offset: 0x00015BDC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			if (this.IsSemiVolatile)
			{
				stringBuilder.Append("volatile ");
			}
			if (this.IsSpace)
			{
				stringBuilder.Append("space count=").Append(this.field_2_data >> 8 & 255);
				stringBuilder.Append(" type=").Append((int)(this.field_2_data & 255)).Append(" ");
			}
			if (this.IsOptimizedIf)
			{
				stringBuilder.Append("if dist=").Append(this.Data);
			}
			else if (this.IsOptimizedChoose)
			{
				stringBuilder.Append("choose nCases=").Append(this.Data);
			}
			else if (this.IsSkip)
			{
				stringBuilder.Append("skip dist=").Append(this.Data);
			}
			else if (this.IsSum)
			{
				stringBuilder.Append("sum ");
			}
			else if (this.IsBaxcel)
			{
				stringBuilder.Append("assign ");
			}
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00017B10 File Offset: 0x00015D10
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(25 + base.PtgClass));
			out1.WriteByte((int)this.field_1_options);
			out1.WriteShort((int)this.field_2_data);
			int[] jumpTable = this._jumpTable;
			if (jumpTable != null)
			{
				for (int i = 0; i < jumpTable.Length; i++)
				{
					out1.WriteShort(jumpTable[i]);
				}
				out1.WriteShort(this._chooseFuncOffset);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00017B71 File Offset: 0x00015D71
		public override int Size
		{
			get
			{
				if (this._jumpTable != null)
				{
					return 4 + (this._jumpTable.Length + 1) * 2;
				}
				return 4;
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00017B8C File Offset: 0x00015D8C
		public string ToFormulaString(string[] operands)
		{
			if (global::NPOI.SS.Formula.PTG.AttrPtg.space.IsSet((int)this.field_1_options))
			{
				return operands[0];
			}
			if (global::NPOI.SS.Formula.PTG.AttrPtg.optiIf.IsSet((int)this.field_1_options))
			{
				return this.ToFormulaString() + "(" + operands[0] + ")";
			}
			if (global::NPOI.SS.Formula.PTG.AttrPtg.optiSkip.IsSet((int)this.field_1_options))
			{
				return this.ToFormulaString() + operands[0];
			}
			return this.ToFormulaString() + "(" + operands[0] + ")";
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00008875 File Offset: 0x00006A75
		public int NumberOfOperands
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00017C13 File Offset: 0x00015E13
		public int Type
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00017C18 File Offset: 0x00015E18
		public override string ToFormulaString()
		{
			if (global::NPOI.SS.Formula.PTG.AttrPtg.semiVolatile.IsSet((int)this.field_1_options))
			{
				return "ATTR(semiVolatile)";
			}
			if (global::NPOI.SS.Formula.PTG.AttrPtg.optiIf.IsSet((int)this.field_1_options))
			{
				return "IF";
			}
			if (global::NPOI.SS.Formula.PTG.AttrPtg.optiChoose.IsSet((int)this.field_1_options))
			{
				return "CHOOSE";
			}
			if (global::NPOI.SS.Formula.PTG.AttrPtg.optiSkip.IsSet((int)this.field_1_options))
			{
				return "";
			}
			if (global::NPOI.SS.Formula.PTG.AttrPtg.optiSum.IsSet((int)this.field_1_options))
			{
				return "SUM";
			}
			if (global::NPOI.SS.Formula.PTG.AttrPtg.baxcel.IsSet((int)this.field_1_options))
			{
				return "ATTR(baxcel)";
			}
			if (global::NPOI.SS.Formula.PTG.AttrPtg.space.IsSet((int)this.field_1_options))
			{
				return "";
			}
			return "UNKNOWN ATTRIBUTE";
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00017CD4 File Offset: 0x00015ED4
		public override object Clone()
		{
			int[] jt;
			if (this._jumpTable == null)
			{
				jt = null;
			}
			else
			{
				jt = (int[])this._jumpTable.Clone();
			}
			return new global::NPOI.SS.Formula.PTG.AttrPtg((int)this.field_1_options, (int)this.field_2_data, jt, this._chooseFuncOffset);
		}

		// Token: 0x04000468 RID: 1128
		public const byte sid = 25;

		// Token: 0x04000469 RID: 1129
		private const int SIZE = 4;

		// Token: 0x0400046A RID: 1130
		private byte field_1_options;

		// Token: 0x0400046B RID: 1131
		private short field_2_data;

		// Token: 0x0400046C RID: 1132
		private int[] _jumpTable;

		// Token: 0x0400046D RID: 1133
		private int _chooseFuncOffset;

		// Token: 0x0400046E RID: 1134
		private static global::NPOI.Util.BitField semiVolatile = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x0400046F RID: 1135
		private static global::NPOI.Util.BitField optiIf = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04000470 RID: 1136
		private static global::NPOI.Util.BitField optiChoose = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x04000471 RID: 1137
		private static global::NPOI.Util.BitField optiSkip = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x04000472 RID: 1138
		private static global::NPOI.Util.BitField optiSum = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x04000473 RID: 1139
		private static global::NPOI.Util.BitField baxcel = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x04000474 RID: 1140
		private static global::NPOI.Util.BitField space = global::NPOI.Util.BitFieldFactory.GetInstance(64);

		// Token: 0x04000475 RID: 1141
		public static readonly global::NPOI.SS.Formula.PTG.AttrPtg SUM = new global::NPOI.SS.Formula.PTG.AttrPtg(16, 0, null, -1);

		// Token: 0x02000568 RID: 1384
		public enum SpaceType
		{
			// Token: 0x0400189F RID: 6303
			SpaceBefore,
			// Token: 0x040018A0 RID: 6304
			CrBefore,
			// Token: 0x040018A1 RID: 6305
			SpaceBeforeOpenParen,
			// Token: 0x040018A2 RID: 6306
			CrBeforeOpenParen,
			// Token: 0x040018A3 RID: 6307
			SpaceBeforeCloseParen,
			// Token: 0x040018A4 RID: 6308
			CrBeforeCloseParen,
			// Token: 0x040018A5 RID: 6309
			SpaceAfterEquality
		}
	}
}
