using System;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000121 RID: 289
	[global::System.Serializable]
	public abstract class Ref2DPtgBase : global::NPOI.SS.Formula.PTG.RefPtgBase
	{
		// Token: 0x06000988 RID: 2440 RVA: 0x00019138 File Offset: 0x00017338
		protected Ref2DPtgBase(string cellref) : base(cellref)
		{
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00019141 File Offset: 0x00017341
		protected Ref2DPtgBase(global::NPOI.SS.Util.CellReference cr) : base(cr)
		{
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0001914A File Offset: 0x0001734A
		protected Ref2DPtgBase(int row, int column, bool isRowRelative, bool isColumnRelative)
		{
			base.Row = row;
			base.Column = column;
			base.IsRowRelative = isRowRelative;
			base.IsColRelative = isColumnRelative;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0001916F File Offset: 0x0001736F
		protected Ref2DPtgBase(global::NPOI.Util.ILittleEndianInput in1)
		{
			base.ReadCoordinates(in1);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0001917E File Offset: 0x0001737E
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(this.Sid + base.PtgClass));
			base.WriteCoordinates(out1);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x000165E0 File Offset: 0x000147E0
		public override string ToFormulaString()
		{
			return base.FormatReferenceAsString();
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600098E RID: 2446
		protected abstract byte Sid { get; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x000181D5 File Offset: 0x000163D5
		public override int Size
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0001919C File Offset: 0x0001739C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append(" [");
			stringBuilder.Append(base.FormatReferenceAsString());
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x040004DC RID: 1244
		private const int SIZE = 5;
	}
}
