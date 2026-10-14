using System;
using System.Drawing;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000362 RID: 866
	public class EscherGraphics : global::System.IDisposable
	{
		// Token: 0x06001A07 RID: 6663 RVA: 0x0005024C File Offset: 0x0004E44C
		public EscherGraphics(global::NPOI.HSSF.UserModel.HSSFShapeGroup escherGroup, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook, global::System.Drawing.Color forecolor, float verticalPointsPerPixel)
		{
			this.escherGroup = escherGroup;
			this.workbook = workbook;
			this.verticalPointsPerPixel = verticalPointsPerPixel;
			this.verticalPixelsPerPoint = 1f / verticalPointsPerPixel;
			this.font = new global::System.Drawing.Font("Arial", 10f);
			this.foreground = forecolor;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x000502B8 File Offset: 0x0004E4B8
		private EscherGraphics(global::NPOI.HSSF.UserModel.HSSFShapeGroup escherGroup, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook, global::System.Drawing.Color foreground, global::System.Drawing.Font font, float verticalPointsPerPixel)
		{
			this.escherGroup = escherGroup;
			this.workbook = workbook;
			this.foreground = foreground;
			this.font = font;
			this.verticalPointsPerPixel = verticalPointsPerPixel;
			this.verticalPixelsPerPoint = 1f / verticalPointsPerPixel;
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00050314 File Offset: 0x0004E514
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00050323 File Offset: 0x0004E523
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this.font != null)
			{
				this.font.Dispose();
				this.font = null;
			}
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00050344 File Offset: 0x0004E544
		public void ClearRect(int x, int y, int width, int height)
		{
			global::System.Drawing.Color color = this.foreground;
			this.SetColor(this.background);
			this.FillRect(x, y, width, height);
			this.SetColor(color);
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00050376 File Offset: 0x0004E576
		public void ClipRect(int x, int y, int width, int height)
		{
			if (global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Check(5))
			{
				global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Log(5, "clipRect not supported");
			}
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00050395 File Offset: 0x0004E595
		public void CopyArea(int x, int y, int width, int height, int dx, int dy)
		{
			if (global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Check(5))
			{
				global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Log(5, "copyArea not supported");
			}
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x000503B4 File Offset: 0x0004E5B4
		public global::NPOI.HSSF.UserModel.EscherGraphics Create()
		{
			return new global::NPOI.HSSF.UserModel.EscherGraphics(this.escherGroup, this.workbook, this.foreground, this.font, this.verticalPointsPerPixel);
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x000503D9 File Offset: 0x0004E5D9
		public void DrawArc(int x, int y, int width, int height, int startAngle, int arcAngle)
		{
			if (global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Check(5))
			{
				global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Log(5, "DrawArc not supported");
			}
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x000503F8 File Offset: 0x0004E5F8
		public bool DrawImage(global::System.Drawing.Image img, int dx1, int dy1, int dx2, int dy2, int sx1, int sy1, int sx2, int sy2, global::System.Drawing.Color bgcolor)
		{
			if (global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Check(5))
			{
				global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Log(5, "DrawImage not supported");
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x000503F8 File Offset: 0x0004E5F8
		public bool DrawImage(global::System.Drawing.Image img, int dx1, int dy1, int dx2, int dy2, int sx1, int sy1, int sx2, int sy2)
		{
			if (global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Check(5))
			{
				global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Log(5, "DrawImage not supported");
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x0005041C File Offset: 0x0004E61C
		public bool DrawImage(global::System.Drawing.Image image, int i, int j, int k, int l, global::System.Drawing.Color color)
		{
			return this.DrawImage(image, i, j, i + k, j + l, 0, 0, image.Width, image.Height, color);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0005044C File Offset: 0x0004E64C
		public bool DrawImage(global::System.Drawing.Image image, int i, int j, int k, int l)
		{
			return this.DrawImage(image, i, j, i + k, j + l, 0, 0, image.Width, image.Height);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00050478 File Offset: 0x0004E678
		public bool DrawImage(global::System.Drawing.Image image, int i, int j, global::System.Drawing.Color color)
		{
			return this.DrawImage(image, i, j, image.Width, image.Height, color);
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00050491 File Offset: 0x0004E691
		public bool DrawImage(global::System.Drawing.Image image, int i, int j)
		{
			return this.DrawImage(image, i, j, image.Width, image.Height);
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x000504A8 File Offset: 0x0004E6A8
		public void DrawLine(int x1, int y1, int x2, int y2)
		{
			this.DrawLine(x1, y1, x2, y2, 0);
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x000504B8 File Offset: 0x0004E6B8
		public void DrawLine(int x1, int y1, int x2, int y2, int width)
		{
			global::NPOI.HSSF.UserModel.HSSFSimpleShape hssfsimpleShape = this.escherGroup.CreateShape(new global::NPOI.HSSF.UserModel.HSSFChildAnchor(x1, y1, x2, y2));
			hssfsimpleShape.ShapeType = 20;
			hssfsimpleShape.LineWidth = width;
			hssfsimpleShape.SetLineStyleColor((int)this.foreground.R, (int)this.foreground.G, (int)this.foreground.B);
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00050510 File Offset: 0x0004E710
		public void DrawOval(int x, int y, int width, int height)
		{
			global::NPOI.HSSF.UserModel.HSSFSimpleShape hssfsimpleShape = this.escherGroup.CreateShape(new global::NPOI.HSSF.UserModel.HSSFChildAnchor(x, y, x + width, y + height));
			hssfsimpleShape.ShapeType = 3;
			hssfsimpleShape.LineWidth = 0;
			hssfsimpleShape.SetLineStyleColor((int)this.foreground.R, (int)this.foreground.G, (int)this.foreground.B);
			hssfsimpleShape.IsNoFill = true;
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x00050574 File Offset: 0x0004E774
		public void DrawPolygon(int[] xPoints, int[] yPoints, int nPoints)
		{
			int num = this.FindBiggest(xPoints);
			int num2 = this.FindBiggest(yPoints);
			int num3 = this.FindSmallest(xPoints);
			int num4 = this.FindSmallest(yPoints);
			global::NPOI.HSSF.UserModel.HSSFPolygon hssfpolygon = this.escherGroup.CreatePolygon(new global::NPOI.HSSF.UserModel.HSSFChildAnchor(num3, num4, num, num2));
			hssfpolygon.SetPolygonDrawArea(num - num3, num2 - num4);
			hssfpolygon.SetPoints(this.AddToAll(xPoints, -num3), this.AddToAll(yPoints, -num4));
			hssfpolygon.SetLineStyleColor((int)this.foreground.R, (int)this.foreground.G, (int)this.foreground.B);
			hssfpolygon.LineWidth = 0;
			hssfpolygon.IsNoFill = true;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x00050610 File Offset: 0x0004E810
		private int[] AddToAll(int[] values, int amount)
		{
			int[] array = new int[values.Length];
			for (int i = 0; i < values.Length; i++)
			{
				array[i] = values[i] + amount;
			}
			return array;
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x0005063D File Offset: 0x0004E83D
		public void DrawPolyline(int[] xPoints, int[] yPoints, int nPoints)
		{
			if (global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Check(5))
			{
				global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Log(5, "DrawPolyline not supported");
			}
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0005065C File Offset: 0x0004E85C
		public void DrawRect(int x, int y, int width, int height)
		{
			if (global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Check(5))
			{
				global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Log(5, "DrawRect not supported");
			}
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x0005067B File Offset: 0x0004E87B
		public void DrawRoundRect(int x, int y, int width, int height, int arcWidth, int arcHeight)
		{
			if (global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Check(5))
			{
				global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Log(5, "DrawRoundRect not supported");
			}
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x0005069C File Offset: 0x0004E89C
		public void DrawString(string str, int x, int y)
		{
			if (string.IsNullOrEmpty(str))
			{
				return;
			}
			using (global::System.Drawing.Font font = new global::System.Drawing.Font(this.font.Name.Equals("SansSerif") ? "Arial" : this.font.Name, (float)((int)(this.font.Size / this.verticalPixelsPerPoint)), this.font.Style))
			{
				int num = global::NPOI.HSSF.UserModel.StaticFontMetrics.GetFontDetails(font).GetStringWidth(str) * 8 + 12;
				int num2 = (int)(this.font.Size / this.verticalPixelsPerPoint + 6f) * 2;
				y -= global::System.Convert.ToInt32(this.font.Size / this.verticalPixelsPerPoint + 2f * this.verticalPixelsPerPoint);
				global::NPOI.HSSF.UserModel.HSSFTextbox hssftextbox = this.escherGroup.CreateTextbox(new global::NPOI.HSSF.UserModel.HSSFChildAnchor(x, y, x + num, y + num2));
				hssftextbox.IsNoFill = true;
				hssftextbox.LineStyle = global::NPOI.SS.UserModel.LineStyle.None;
				global::NPOI.HSSF.UserModel.HSSFRichTextString hssfrichTextString = new global::NPOI.HSSF.UserModel.HSSFRichTextString(str);
				global::NPOI.HSSF.UserModel.HSSFFont hssffont = this.MatchFont(font);
				hssfrichTextString.ApplyFont(hssffont);
				hssftextbox.String = hssfrichTextString;
			}
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x000507B8 File Offset: 0x0004E9B8
		private global::NPOI.HSSF.UserModel.HSSFFont MatchFont(global::System.Drawing.Font font)
		{
			global::NPOI.HSSF.Util.HSSFColor hssfcolor = this.workbook.GetCustomPalette().FindColor(this.foreground.R, this.foreground.G, this.foreground.B);
			if (hssfcolor == null)
			{
				hssfcolor = this.workbook.GetCustomPalette().FindSimilarColor(this.foreground.R, this.foreground.G, this.foreground.B);
			}
			bool bold = font.Bold;
			bool italic = font.Italic;
			global::NPOI.HSSF.UserModel.HSSFFont hssffont = (global::NPOI.HSSF.UserModel.HSSFFont)this.workbook.FindFont(bold ? 700 : 400, hssfcolor.Indexed, (short)(font.Size * 20f), font.Name, italic, false, global::NPOI.SS.UserModel.FontSuperScript.None, global::NPOI.SS.UserModel.FontUnderlineType.None);
			if (hssffont == null)
			{
				hssffont = (global::NPOI.HSSF.UserModel.HSSFFont)this.workbook.CreateFont();
				hssffont.Boldweight = (bold ? 700 : 0);
				hssffont.Color = hssfcolor.Indexed;
				hssffont.FontHeight = (double)((short)(font.Size * 20f));
				hssffont.FontName = font.Name;
				hssffont.IsItalic = italic;
				hssffont.IsStrikeout = false;
				hssffont.TypeOffset = global::NPOI.SS.UserModel.FontSuperScript.None;
				hssffont.Underline = global::NPOI.SS.UserModel.FontUnderlineType.None;
			}
			return hssffont;
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x000508E5 File Offset: 0x0004EAE5
		public void FillArc(int x, int y, int width, int height, int startAngle, int arcAngle)
		{
			if (global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Check(5))
			{
				global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Log(5, "FillArc not supported");
			}
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00050904 File Offset: 0x0004EB04
		public void FillOval(int x, int y, int width, int height)
		{
			global::NPOI.HSSF.UserModel.HSSFSimpleShape hssfsimpleShape = this.escherGroup.CreateShape(new global::NPOI.HSSF.UserModel.HSSFChildAnchor(x, y, x + width, y + height));
			hssfsimpleShape.ShapeType = 3;
			hssfsimpleShape.LineStyle = global::NPOI.SS.UserModel.LineStyle.None;
			hssfsimpleShape.SetFillColor((int)this.foreground.R, (int)this.foreground.G, (int)this.foreground.B);
			hssfsimpleShape.SetLineStyleColor((int)this.foreground.R, (int)this.foreground.G, (int)this.foreground.B);
			hssfsimpleShape.IsNoFill = false;
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x0005098C File Offset: 0x0004EB8C
		public void FillPolygon(int[] xPoints, int[] yPoints, int nPoints)
		{
			int num = this.FindBiggest(xPoints);
			int num2 = this.FindBiggest(yPoints);
			int num3 = this.FindSmallest(xPoints);
			int num4 = this.FindSmallest(yPoints);
			global::NPOI.HSSF.UserModel.HSSFPolygon hssfpolygon = this.escherGroup.CreatePolygon(new global::NPOI.HSSF.UserModel.HSSFChildAnchor(num3, num4, num, num2));
			hssfpolygon.SetPolygonDrawArea(num - num3, num2 - num4);
			hssfpolygon.SetPoints(this.AddToAll(xPoints, -num3), this.AddToAll(yPoints, -num4));
			hssfpolygon.SetLineStyleColor((int)this.foreground.R, (int)this.foreground.G, (int)this.foreground.B);
			hssfpolygon.SetFillColor((int)this.foreground.R, (int)this.foreground.G, (int)this.foreground.B);
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00050A40 File Offset: 0x0004EC40
		private int FindBiggest(int[] values)
		{
			int num = int.MinValue;
			for (int i = 0; i < values.Length; i++)
			{
				if (values[i] > num)
				{
					num = values[i];
				}
			}
			return num;
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00050A6C File Offset: 0x0004EC6C
		private int FindSmallest(int[] values)
		{
			int num = int.MaxValue;
			for (int i = 0; i < values.Length; i++)
			{
				if (values[i] < num)
				{
					num = values[i];
				}
			}
			return num;
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x00050A98 File Offset: 0x0004EC98
		public void FillRect(int x, int y, int width, int height)
		{
			global::NPOI.HSSF.UserModel.HSSFSimpleShape hssfsimpleShape = this.escherGroup.CreateShape(new global::NPOI.HSSF.UserModel.HSSFChildAnchor(x, y, x + width, y + height));
			hssfsimpleShape.ShapeType = 1;
			hssfsimpleShape.LineStyle = global::NPOI.SS.UserModel.LineStyle.None;
			hssfsimpleShape.SetFillColor((int)this.foreground.R, (int)this.foreground.G, (int)this.foreground.B);
			hssfsimpleShape.SetLineStyleColor((int)this.foreground.R, (int)this.foreground.G, (int)this.foreground.B);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00050B19 File Offset: 0x0004ED19
		public void FillRoundRect(int x, int y, int width, int height, int arcWidth, int arcHeight)
		{
			if (global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Check(5))
			{
				global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Log(5, "FillRoundRect not supported");
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x00050B38 File Offset: 0x0004ED38
		public global::System.Drawing.Rectangle Clip
		{
			get
			{
				return this.ClipBounds;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x00050B40 File Offset: 0x0004ED40
		public global::System.Drawing.Rectangle ClipBounds
		{
			get
			{
				return global::System.Drawing.Rectangle.Empty;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x00050B47 File Offset: 0x0004ED47
		public global::System.Drawing.Color Color
		{
			get
			{
				return this.foreground;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x00050B4F File Offset: 0x0004ED4F
		public global::System.Drawing.Font Font
		{
			get
			{
				return this.font;
			}
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x00050B57 File Offset: 0x0004ED57
		public void SetClip(int x, int y, int width, int height)
		{
			this.SetClip(new global::System.Drawing.Rectangle(x, y, width, height));
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x00008C75 File Offset: 0x00006E75
		public void SetClip(global::System.Drawing.Rectangle shape)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00050B69 File Offset: 0x0004ED69
		public void SetColor(global::System.Drawing.Color color)
		{
			this.foreground = color;
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00050B72 File Offset: 0x0004ED72
		public void SetFont(global::System.Drawing.Font f)
		{
			this.font = f;
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00050B7B File Offset: 0x0004ED7B
		public void SetPaintMode()
		{
			if (global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Check(5))
			{
				global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Log(5, "SetPaintMode not supported");
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00050B9F File Offset: 0x0004ED9F
		public void SetXORMode(global::System.Drawing.Color color)
		{
			if (global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Check(5))
			{
				global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Log(5, "SetXORMode not supported");
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x00050BC3 File Offset: 0x0004EDC3
		public void Translate(int x, int y)
		{
			if (global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Check(5))
			{
				global::NPOI.HSSF.UserModel.EscherGraphics.Logger.Log(5, "translate not supported");
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x00050BE7 File Offset: 0x0004EDE7
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x00050BEF File Offset: 0x0004EDEF
		public global::System.Drawing.Color Background
		{
			get
			{
				return this.background;
			}
			set
			{
				this.background = value;
			}
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00050BF8 File Offset: 0x0004EDF8
		private global::NPOI.HSSF.UserModel.HSSFShapeGroup GetEscherGraphics()
		{
			return this.escherGroup;
		}

		// Token: 0x04000B0C RID: 2828
		private global::NPOI.HSSF.UserModel.HSSFShapeGroup escherGroup;

		// Token: 0x04000B0D RID: 2829
		private global::NPOI.HSSF.UserModel.HSSFWorkbook workbook;

		// Token: 0x04000B0E RID: 2830
		private float verticalPointsPerPixel = 1f;

		// Token: 0x04000B0F RID: 2831
		private float verticalPixelsPerPoint;

		// Token: 0x04000B10 RID: 2832
		private global::System.Drawing.Color foreground;

		// Token: 0x04000B11 RID: 2833
		private global::System.Drawing.Color background = global::System.Drawing.Color.White;

		// Token: 0x04000B12 RID: 2834
		private global::System.Drawing.Font font;

		// Token: 0x04000B13 RID: 2835
		private static global::NPOI.Util.POILogger Logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.UserModel.EscherGraphics));
	}
}
