using System;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000FB RID: 251
	[global::System.Serializable]
	public class AreaPtg : global::NPOI.SS.Formula.PTG.Area2DPtgBase
	{
		// Token: 0x0600085C RID: 2140 RVA: 0x00016E2C File Offset: 0x0001502C
		public AreaPtg(int firstRow, int lastRow, int firstColumn, int lastColumn, bool firstRowRelative, bool lastRowRelative, bool firstColRelative, bool lastColRelative) : base(firstRow, lastRow, firstColumn, lastColumn, firstRowRelative, lastRowRelative, firstColRelative, lastColRelative)
		{
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00016E1D File Offset: 0x0001501D
		public AreaPtg(global::NPOI.Util.ILittleEndianInput in1) : base(in1)
		{
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00016E4C File Offset: 0x0001504C
		public AreaPtg(string arearef) : base(arearef)
		{
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00016E55 File Offset: 0x00015055
		public AreaPtg(global::NPOI.SS.Util.AreaReference areaRef) : base(areaRef)
		{
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00016E5E File Offset: 0x0001505E
		protected override byte Sid
		{
			get
			{
				return 37;
			}
		}

		// Token: 0x04000457 RID: 1111
		public const byte sid = 37;
	}
}
