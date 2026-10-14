using System;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000125 RID: 293
	[global::System.Serializable]
	public class RefPtg : global::NPOI.SS.Formula.PTG.Ref2DPtgBase
	{
		// Token: 0x060009A8 RID: 2472 RVA: 0x00019466 File Offset: 0x00017666
		public RefPtg(string cellref) : base(new global::NPOI.SS.Util.CellReference(cellref))
		{
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00019474 File Offset: 0x00017674
		public RefPtg(int row, int column, bool isRowRelative, bool isColumnRelative) : base(row, column, isRowRelative, isColumnRelative)
		{
			base.Row = row;
			base.Column = column;
			base.IsRowRelative = isRowRelative;
			base.IsColRelative = isColumnRelative;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00019459 File Offset: 0x00017659
		public RefPtg(global::NPOI.Util.ILittleEndianInput in1) : base(in1)
		{
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0001949E File Offset: 0x0001769E
		public RefPtg(global::NPOI.SS.Util.CellReference cr) : base(cr)
		{
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x000194A7 File Offset: 0x000176A7
		protected override byte Sid
		{
			get
			{
				return 36;
			}
		}

		// Token: 0x040004E6 RID: 1254
		public const byte sid = 36;
	}
}
