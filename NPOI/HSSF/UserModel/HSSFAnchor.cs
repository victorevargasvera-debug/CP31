using System;
using NPOI.DDF;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000367 RID: 871
	public abstract class HSSFAnchor
	{
		// Token: 0x06001A74 RID: 6772 RVA: 0x000513ED File Offset: 0x0004F5ED
		public HSSFAnchor()
		{
			this.CreateEscherAnchor();
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x000513FB File Offset: 0x0004F5FB
		public HSSFAnchor(int dx1, int dy1, int dx2, int dy2)
		{
			this.CreateEscherAnchor();
			this.Dx1 = dx1;
			this.Dy1 = dy1;
			this.Dx2 = dx2;
			this.Dy2 = dy2;
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x00051428 File Offset: 0x0004F628
		public static global::NPOI.HSSF.UserModel.HSSFAnchor CreateAnchorFromEscher(global::NPOI.DDF.EscherContainerRecord container)
		{
			if (container.GetChildById(-4081) != null)
			{
				return new global::NPOI.HSSF.UserModel.HSSFChildAnchor((global::NPOI.DDF.EscherChildAnchorRecord)container.GetChildById(-4081));
			}
			if (container.GetChildById(-4080) != null)
			{
				return new global::NPOI.HSSF.UserModel.HSSFClientAnchor((global::NPOI.DDF.EscherClientAnchorRecord)container.GetChildById(-4080));
			}
			return null;
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001A77 RID: 6775
		// (set) Token: 0x06001A78 RID: 6776
		public abstract int Dx1 { get; set; }

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001A79 RID: 6777
		// (set) Token: 0x06001A7A RID: 6778
		public abstract int Dy1 { get; set; }

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001A7B RID: 6779
		// (set) Token: 0x06001A7C RID: 6780
		public abstract int Dy2 { get; set; }

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001A7D RID: 6781
		// (set) Token: 0x06001A7E RID: 6782
		public abstract int Dx2 { get; set; }

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001A7F RID: 6783
		public abstract bool IsHorizontallyFlipped { get; }

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001A80 RID: 6784
		public abstract bool IsVerticallyFlipped { get; }

		// Token: 0x06001A81 RID: 6785
		internal abstract global::NPOI.DDF.EscherRecord GetEscherAnchor();

		// Token: 0x06001A82 RID: 6786
		protected abstract void CreateEscherAnchor();

		// Token: 0x04000B1A RID: 2842
		protected bool _isHorizontallyFlipped;

		// Token: 0x04000B1B RID: 2843
		protected bool _isVerticallyFlipped;
	}
}
