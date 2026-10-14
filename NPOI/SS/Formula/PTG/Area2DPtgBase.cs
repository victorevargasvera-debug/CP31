using System;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000F5 RID: 245
	[global::System.Serializable]
	public abstract class Area2DPtgBase : global::NPOI.SS.Formula.PTG.AreaPtgBase
	{
		// Token: 0x06000835 RID: 2101 RVA: 0x00016A48 File Offset: 0x00014C48
		protected Area2DPtgBase(int firstRow, int lastRow, int firstColumn, int lastColumn, bool firstRowRelative, bool lastRowRelative, bool firstColRelative, bool lastColRelative) : base(firstRow, lastRow, firstColumn, lastColumn, firstRowRelative, lastRowRelative, firstColRelative, lastColRelative)
		{
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00016A68 File Offset: 0x00014C68
		protected Area2DPtgBase(global::NPOI.SS.Util.AreaReference ar) : base(ar)
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00016A71 File Offset: 0x00014C71
		protected Area2DPtgBase(global::NPOI.Util.ILittleEndianInput in1)
		{
			base.ReadCoordinates(in1);
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000838 RID: 2104
		protected abstract byte Sid { get; }

		// Token: 0x06000839 RID: 2105 RVA: 0x00016A80 File Offset: 0x00014C80
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(this.Sid + base.PtgClass));
			base.WriteCoordinates(out1);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00016A9C File Offset: 0x00014C9C
		public Area2DPtgBase(string arearef) : base(arearef)
		{
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x00016AA5 File Offset: 0x00014CA5
		public override int Size
		{
			get
			{
				return 9;
			}
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000160D4 File Offset: 0x000142D4
		public override string ToFormulaString()
		{
			return base.FormatReferenceAsString();
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00016AAC File Offset: 0x00014CAC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append(" [");
			stringBuilder.Append(base.FormatReferenceAsString());
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x04000449 RID: 1097
		private const int SIZE = 9;
	}
}
