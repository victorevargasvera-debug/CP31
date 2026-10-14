using System;
using NPOI.OpenXmlFormats.Dml;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200006D RID: 109
	public class XSSFChildAnchor : global::NPOI.XSSF.UserModel.XSSFAnchor
	{
		// Token: 0x06000530 RID: 1328 RVA: 0x000144E0 File Offset: 0x000126E0
		public XSSFChildAnchor(int x, int y, int cx, int cy)
		{
			this.t2d = new global::NPOI.OpenXmlFormats.Dml.CT_Transform2D();
			global::NPOI.OpenXmlFormats.Dml.CT_Point2D ct_Point2D = this.t2d.AddNewOff();
			global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D ct_PositiveSize2D = this.t2d.AddNewExt();
			ct_Point2D.x = (long)x;
			ct_Point2D.y = (long)y;
			ct_PositiveSize2D.cx = (long)global::System.Math.Abs(cx - x);
			ct_PositiveSize2D.cy = (long)global::System.Math.Abs(cy - y);
			if (x > cx)
			{
				this.t2d.flipH = true;
			}
			if (y > cy)
			{
				this.t2d.flipV = true;
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00014564 File Offset: 0x00012764
		public XSSFChildAnchor(global::NPOI.OpenXmlFormats.Dml.CT_Transform2D t2d)
		{
			this.t2d = t2d;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00014573 File Offset: 0x00012773
		public global::NPOI.OpenXmlFormats.Dml.CT_Transform2D GetCTTransform2D()
		{
			return this.t2d;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x0001457B File Offset: 0x0001277B
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x0001458E File Offset: 0x0001278E
		public override int Dx1
		{
			get
			{
				return (int)this.t2d.off.x;
			}
			set
			{
				this.t2d.off.y = (long)value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x000145A2 File Offset: 0x000127A2
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x0001458E File Offset: 0x0001278E
		public override int Dy1
		{
			get
			{
				return (int)this.t2d.off.y;
			}
			set
			{
				this.t2d.off.y = (long)value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x000145B5 File Offset: 0x000127B5
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x000145D0 File Offset: 0x000127D0
		public override int Dy2
		{
			get
			{
				return (int)((long)this.Dy1 + this.t2d.ext.cy);
			}
			set
			{
				this.t2d.ext.cy = (long)(value - this.Dy1);
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x000145EB File Offset: 0x000127EB
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00014606 File Offset: 0x00012806
		public override int Dx2
		{
			get
			{
				return (int)((long)this.Dx1 + this.t2d.ext.cx);
			}
			set
			{
				this.t2d.ext.cx = (long)(value - this.Dx1);
			}
		}

		// Token: 0x040002AA RID: 682
		private global::NPOI.OpenXmlFormats.Dml.CT_Transform2D t2d;
	}
}
