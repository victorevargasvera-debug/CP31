using System;
using NPOI.OpenXmlFormats.Dml;
using NPOI.OpenXmlFormats.Dml.Spreadsheet;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200009C RID: 156
	public abstract class XSSFShape : global::NPOI.SS.UserModel.IShape
	{
		// Token: 0x0600085C RID: 2140 RVA: 0x0001CA34 File Offset: 0x0001AC34
		public global::NPOI.XSSF.UserModel.XSSFDrawing GetDrawing()
		{
			return this.drawing;
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x0001CA3C File Offset: 0x0001AC3C
		public global::NPOI.SS.UserModel.IShape Parent
		{
			get
			{
				return this.parent;
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0001CA44 File Offset: 0x0001AC44
		public global::NPOI.XSSF.UserModel.XSSFAnchor GetAnchor()
		{
			return this.anchor;
		}

		// Token: 0x0600085F RID: 2143
		protected internal abstract global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties GetShapeProperties();

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x0001CA4C File Offset: 0x0001AC4C
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x0001CA5C File Offset: 0x0001AC5C
		public bool IsNoFill
		{
			get
			{
				return this.GetShapeProperties().noFill != null;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties shapeProperties = this.GetShapeProperties();
				if (shapeProperties.IsSetPattFill())
				{
					shapeProperties.unsetPattFill();
				}
				if (shapeProperties.IsSetSolidFill())
				{
					shapeProperties.unsetSolidFill();
				}
				shapeProperties.noFill = new global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties();
			}
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0001CA98 File Offset: 0x0001AC98
		public void SetFillColor(int red, int green, int blue)
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties shapeProperties = this.GetShapeProperties();
			global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties ct_SolidColorFillProperties = shapeProperties.IsSetSolidFill() ? shapeProperties.solidFill : shapeProperties.AddNewSolidFill();
			ct_SolidColorFillProperties.srgbClr = new global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor
			{
				val = new byte[]
				{
					(byte)red,
					(byte)green,
					(byte)blue
				}
			};
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0001CAEC File Offset: 0x0001ACEC
		public void SetLineStyleColor(int red, int green, int blue)
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties shapeProperties = this.GetShapeProperties();
			global::NPOI.OpenXmlFormats.Dml.CT_LineProperties ct_LineProperties = shapeProperties.IsSetLn() ? shapeProperties.ln : shapeProperties.AddNewLn();
			global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties ct_SolidColorFillProperties = ct_LineProperties.IsSetSolidFill() ? ct_LineProperties.solidFill : ct_LineProperties.AddNewSolidFill();
			ct_SolidColorFillProperties.srgbClr = new global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor
			{
				val = new byte[]
				{
					(byte)red,
					(byte)green,
					(byte)blue
				}
			};
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x000065E4 File Offset: 0x000047E4
		public int CountOfAllChildren
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x000065E4 File Offset: 0x000047E4
		public int FillColor
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x0001CB58 File Offset: 0x0001AD58
		public virtual global::NPOI.SS.UserModel.LineStyle LineStyle
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties shapeProperties = this.GetShapeProperties();
				(shapeProperties.IsSetLn() ? shapeProperties.ln : shapeProperties.AddNewLn()).prstDash = new global::NPOI.OpenXmlFormats.Dml.CT_PresetLineDashProperties
				{
					val = (global::NPOI.OpenXmlFormats.Dml.ST_PresetLineDashVal)(value + 1)
				};
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x000065E4 File Offset: 0x000047E4
		public virtual int LineStyleColor
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0001CB98 File Offset: 0x0001AD98
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x0001CBDC File Offset: 0x0001ADDC
		public virtual double LineWidth
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties shapeProperties = this.GetShapeProperties();
				if (shapeProperties.IsSetLn())
				{
					return (double)shapeProperties.ln.w * 1.0 / (double)global::NPOI.XSSF.UserModel.XSSFShape.EMU_PER_POINT;
				}
				return 0.0;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties shapeProperties = this.GetShapeProperties();
				(shapeProperties.IsSetLn() ? shapeProperties.ln : shapeProperties.AddNewLn()).w = (int)(value * (double)global::NPOI.XSSF.UserModel.XSSFShape.EMU_PER_POINT);
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x000065E4 File Offset: 0x000047E4
		public void SetLineStyleColor(int lineStyleColor)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000344 RID: 836
		public static int EMU_PER_PIXEL = 9525;

		// Token: 0x04000345 RID: 837
		public static int EMU_PER_POINT = 12700;

		// Token: 0x04000346 RID: 838
		public static int POINT_DPI = 72;

		// Token: 0x04000347 RID: 839
		public static int PIXEL_DPI = 96;

		// Token: 0x04000348 RID: 840
		protected global::NPOI.XSSF.UserModel.XSSFDrawing drawing;

		// Token: 0x04000349 RID: 841
		public global::NPOI.XSSF.UserModel.XSSFShapeGroup parent;

		// Token: 0x0400034A RID: 842
		internal global::NPOI.XSSF.UserModel.XSSFAnchor anchor;
	}
}
