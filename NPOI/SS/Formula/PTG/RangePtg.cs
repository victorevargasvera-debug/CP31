using System;
using System.Text;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000120 RID: 288
	public class RangePtg : global::NPOI.SS.Formula.PTG.OperationPtg
	{
		// Token: 0x06000980 RID: 2432 RVA: 0x00018525 File Offset: 0x00016725
		private RangePtg()
		{
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool IsBaseToken
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00008875 File Offset: 0x00006A75
		public override int Size
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x000190E8 File Offset: 0x000172E8
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(17 + base.PtgClass));
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x000190F9 File Offset: 0x000172F9
		public override string ToFormulaString()
		{
			return ":";
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00019100 File Offset: 0x00017300
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(operands[0]);
			stringBuilder.Append(":");
			stringBuilder.Append(operands[1]);
			return stringBuilder.ToString();
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00016A02 File Offset: 0x00014C02
		public override int NumberOfOperands
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x040004D9 RID: 1241
		public const int SIZE = 1;

		// Token: 0x040004DA RID: 1242
		public const byte sid = 17;

		// Token: 0x040004DB RID: 1243
		public static global::NPOI.SS.Formula.PTG.OperationPtg instance = new global::NPOI.SS.Formula.PTG.RangePtg();
	}
}
