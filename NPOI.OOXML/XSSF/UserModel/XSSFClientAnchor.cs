using System;
using NPOI.OpenXmlFormats.Dml.Spreadsheet;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200006E RID: 110
	public class XSSFClientAnchor : global::NPOI.XSSF.UserModel.XSSFAnchor, global::NPOI.SS.UserModel.IClientAnchor
	{
		// Token: 0x0600053B RID: 1339 RVA: 0x00014624 File Offset: 0x00012824
		public XSSFClientAnchor()
		{
			this.cell1 = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker();
			this.cell1.col = 0;
			this.cell1.colOff = 0L;
			this.cell1.row = 0;
			this.cell1.rowOff = 0L;
			this.cell2 = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker();
			this.cell2.col = 0;
			this.cell2.colOff = 0L;
			this.cell2.row = 0;
			this.cell2.rowOff = 0L;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000146B4 File Offset: 0x000128B4
		public XSSFClientAnchor(int dx1, int dy1, int dx2, int dy2, int col1, int row1, int col2, int row2) : this()
		{
			this.cell1.col = col1;
			this.cell1.colOff = (long)dx1;
			this.cell1.row = row1;
			this.cell1.rowOff = (long)dy1;
			this.cell2.col = col2;
			this.cell2.colOff = (long)dx2;
			this.cell2.row = row2;
			this.cell2.rowOff = (long)dy2;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00014730 File Offset: 0x00012930
		internal XSSFClientAnchor(global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker cell1, global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker cell2)
		{
			this.cell1 = cell1;
			this.cell2 = cell2;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00014748 File Offset: 0x00012948
		public override bool Equals(object o)
		{
			if (o == null || !(o is global::NPOI.XSSF.UserModel.XSSFClientAnchor))
			{
				return false;
			}
			global::NPOI.XSSF.UserModel.XSSFClientAnchor xssfclientAnchor = (global::NPOI.XSSF.UserModel.XSSFClientAnchor)o;
			return this.Dx1 == xssfclientAnchor.Dx1 && this.Dx2 == xssfclientAnchor.Dx2 && this.Dy1 == xssfclientAnchor.Dy1 && this.Dy2 == xssfclientAnchor.Dy2 && this.Col1 == xssfclientAnchor.Col1 && this.Col2 == xssfclientAnchor.Col2 && this.Row1 == xssfclientAnchor.Row1 && this.Row2 == xssfclientAnchor.Row2;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000147DB File Offset: 0x000129DB
		public override string ToString()
		{
			return "from : " + this.cell1.ToString() + "; to: " + this.cell2.ToString();
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x00014802 File Offset: 0x00012A02
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x0001480A File Offset: 0x00012A0A
		internal global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker From
		{
			get
			{
				return this.cell1;
			}
			set
			{
				this.cell1 = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00014813 File Offset: 0x00012A13
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x0001481B File Offset: 0x00012A1B
		internal global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker To
		{
			get
			{
				return this.cell2;
			}
			set
			{
				this.cell2 = value;
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00014824 File Offset: 0x00012A24
		internal bool IsSet()
		{
			return this.cell1.col != 0 || this.cell2.col != 0 || this.cell1.row != 0 || this.cell2.row != 0;
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0001485D File Offset: 0x00012A5D
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x0001486B File Offset: 0x00012A6B
		public override int Dx1
		{
			get
			{
				return (int)this.cell1.colOff;
			}
			set
			{
				this.cell1.colOff = (long)value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0001487A File Offset: 0x00012A7A
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00014888 File Offset: 0x00012A88
		public override int Dy1
		{
			get
			{
				return (int)this.cell1.rowOff;
			}
			set
			{
				this.cell1.rowOff = (long)value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00014897 File Offset: 0x00012A97
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x000148A5 File Offset: 0x00012AA5
		public override int Dy2
		{
			get
			{
				return (int)this.cell2.rowOff;
			}
			set
			{
				this.cell2.rowOff = (long)value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x000148B4 File Offset: 0x00012AB4
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x000148C2 File Offset: 0x00012AC2
		public override int Dx2
		{
			get
			{
				return (int)this.cell2.colOff;
			}
			set
			{
				this.cell2.colOff = (long)value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x000148D1 File Offset: 0x00012AD1
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x000148D9 File Offset: 0x00012AD9
		public global::NPOI.SS.UserModel.AnchorType AnchorType
		{
			get
			{
				return (global::NPOI.SS.UserModel.AnchorType)this.anchorType;
			}
			set
			{
				this.anchorType = (int)value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x000148E2 File Offset: 0x00012AE2
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x000148EF File Offset: 0x00012AEF
		public int Col1
		{
			get
			{
				return this.cell1.col;
			}
			set
			{
				this.cell1.col = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x000148FD File Offset: 0x00012AFD
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x0001490A File Offset: 0x00012B0A
		public int Col2
		{
			get
			{
				return this.cell2.col;
			}
			set
			{
				this.cell2.col = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00014918 File Offset: 0x00012B18
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00014925 File Offset: 0x00012B25
		public int Row1
		{
			get
			{
				return this.cell1.row;
			}
			set
			{
				this.cell1.row = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00014933 File Offset: 0x00012B33
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00014940 File Offset: 0x00012B40
		public int Row2
		{
			get
			{
				return this.cell2.row;
			}
			set
			{
				this.cell2.row = value;
			}
		}

		// Token: 0x040002AB RID: 683
		private int anchorType;

		// Token: 0x040002AC RID: 684
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker cell1;

		// Token: 0x040002AD RID: 685
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Marker cell2;
	}
}
