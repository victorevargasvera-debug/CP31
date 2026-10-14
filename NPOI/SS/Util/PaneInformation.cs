using System;

namespace NPOI.SS.Util
{
	// Token: 0x02000029 RID: 41
	public class PaneInformation
	{
		// Token: 0x060001A8 RID: 424 RVA: 0x00007C5E File Offset: 0x00005E5E
		public PaneInformation(short x, short y, short top, short left, byte active, bool frozen)
		{
			this.x = x;
			this.y = y;
			this.topRow = top;
			this.leftColumn = left;
			this.activePane = active;
			this.frozen = frozen;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00007C93 File Offset: 0x00005E93
		public short VerticalSplitPosition
		{
			get
			{
				return this.x;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00007C9B File Offset: 0x00005E9B
		public short HorizontalSplitPosition
		{
			get
			{
				return this.y;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00007CA3 File Offset: 0x00005EA3
		public short HorizontalSplitTopRow
		{
			get
			{
				return this.topRow;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00007CAB File Offset: 0x00005EAB
		public short VerticalSplitLeftColumn
		{
			get
			{
				return this.leftColumn;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00007CB3 File Offset: 0x00005EB3
		public byte ActivePane
		{
			get
			{
				return this.activePane;
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00007CBB File Offset: 0x00005EBB
		public bool IsFreezePane()
		{
			return this.frozen;
		}

		// Token: 0x04000096 RID: 150
		public const byte PANE_LOWER_RIGHT = 0;

		// Token: 0x04000097 RID: 151
		public const byte PANE_UPPER_RIGHT = 1;

		// Token: 0x04000098 RID: 152
		public const byte PANE_LOWER_LEFT = 2;

		// Token: 0x04000099 RID: 153
		public const byte PANE_UPPER_LEFT = 3;

		// Token: 0x0400009A RID: 154
		private short x;

		// Token: 0x0400009B RID: 155
		private short y;

		// Token: 0x0400009C RID: 156
		private short topRow;

		// Token: 0x0400009D RID: 157
		private short leftColumn;

		// Token: 0x0400009E RID: 158
		private byte activePane;

		// Token: 0x0400009F RID: 159
		private bool frozen;
	}
}
