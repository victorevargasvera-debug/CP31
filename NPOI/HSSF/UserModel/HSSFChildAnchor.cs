using System;
using NPOI.DDF;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200036C RID: 876
	public class HSSFChildAnchor : global::NPOI.HSSF.UserModel.HSSFAnchor
	{
		// Token: 0x06001B2E RID: 6958 RVA: 0x00053811 File Offset: 0x00051A11
		public HSSFChildAnchor(global::NPOI.DDF.EscherChildAnchorRecord escherChildAnchorRecord)
		{
			this._escherChildAnchor = escherChildAnchorRecord;
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x00053820 File Offset: 0x00051A20
		public HSSFChildAnchor()
		{
			this._escherChildAnchor = new global::NPOI.DDF.EscherChildAnchorRecord();
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x00053833 File Offset: 0x00051A33
		public HSSFChildAnchor(int dx1, int dy1, int dx2, int dy2) : base(global::System.Math.Min(dx1, dx2), global::System.Math.Min(dy1, dy2), global::System.Math.Max(dx1, dx2), global::System.Math.Max(dy1, dy2))
		{
			if (dx1 > dx2)
			{
				this._isHorizontallyFlipped = true;
			}
			if (dy1 > dy2)
			{
				this._isVerticallyFlipped = true;
			}
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x00053870 File Offset: 0x00051A70
		public void SetAnchor(int dx1, int dy1, int dx2, int dy2)
		{
			this.Dx1 = global::System.Math.Min(dx1, dx2);
			this.Dy1 = global::System.Math.Min(dy1, dy2);
			this.Dx2 = global::System.Math.Max(dx1, dx2);
			this.Dy2 = global::System.Math.Max(dy1, dy2);
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x000538A8 File Offset: 0x00051AA8
		public override bool IsHorizontallyFlipped
		{
			get
			{
				return this._isHorizontallyFlipped;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x000538B0 File Offset: 0x00051AB0
		public override bool IsVerticallyFlipped
		{
			get
			{
				return this._isVerticallyFlipped;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x000538B8 File Offset: 0x00051AB8
		// (set) Token: 0x06001B35 RID: 6965 RVA: 0x000538C5 File Offset: 0x00051AC5
		public override int Dx1
		{
			get
			{
				return this._escherChildAnchor.Dx1;
			}
			set
			{
				this._escherChildAnchor.Dx1 = (int)((short)value);
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x000538D4 File Offset: 0x00051AD4
		// (set) Token: 0x06001B37 RID: 6967 RVA: 0x000538E1 File Offset: 0x00051AE1
		public override int Dx2
		{
			get
			{
				return this._escherChildAnchor.Dx2;
			}
			set
			{
				this._escherChildAnchor.Dx2 = (int)((short)value);
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x000538F0 File Offset: 0x00051AF0
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x000538FD File Offset: 0x00051AFD
		public override int Dy1
		{
			get
			{
				return this._escherChildAnchor.Dy1;
			}
			set
			{
				this._escherChildAnchor.Dy1 = (int)((short)value);
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x0005390C File Offset: 0x00051B0C
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x00053919 File Offset: 0x00051B19
		public override int Dy2
		{
			get
			{
				return this._escherChildAnchor.Dy2;
			}
			set
			{
				this._escherChildAnchor.Dy2 = (int)((short)value);
			}
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00053928 File Offset: 0x00051B28
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (obj == this)
			{
				return true;
			}
			if (obj.GetType() != base.GetType())
			{
				return false;
			}
			global::NPOI.HSSF.UserModel.HSSFChildAnchor hssfchildAnchor = (global::NPOI.HSSF.UserModel.HSSFChildAnchor)obj;
			return hssfchildAnchor.Dx1 == this.Dx1 && hssfchildAnchor.Dx2 == this.Dx2 && hssfchildAnchor.Dy1 == this.Dy1 && hssfchildAnchor.Dy2 == this.Dy2;
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00053998 File Offset: 0x00051B98
		public override int GetHashCode()
		{
			return this.Dx1.GetHashCode() ^ this.Dx2.GetHashCode() ^ this.Dy1.GetHashCode() ^ this.Dy2.GetHashCode();
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x000539E0 File Offset: 0x00051BE0
		internal override global::NPOI.DDF.EscherRecord GetEscherAnchor()
		{
			return this._escherChildAnchor;
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x000539E8 File Offset: 0x00051BE8
		protected override void CreateEscherAnchor()
		{
			this._escherChildAnchor = new global::NPOI.DDF.EscherChildAnchorRecord();
		}

		// Token: 0x04000B33 RID: 2867
		private global::NPOI.DDF.EscherChildAnchorRecord _escherChildAnchor;
	}
}
