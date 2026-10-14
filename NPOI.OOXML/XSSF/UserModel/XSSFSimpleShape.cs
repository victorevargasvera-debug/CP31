using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NPOI.HSSF.Util;
using NPOI.OpenXmlFormats.Dml;
using NPOI.OpenXmlFormats.Dml.Spreadsheet;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x020000A0 RID: 160
	public class XSSFSimpleShape : global::NPOI.XSSF.UserModel.XSSFShape, global::System.Collections.Generic.IEnumerable<global::NPOI.XSSF.UserModel.XSSFTextParagraph>, global::System.Collections.IEnumerable
	{
		// Token: 0x060009A7 RID: 2471 RVA: 0x00022E9C File Offset: 0x0002109C
		protected internal XSSFSimpleShape(global::NPOI.XSSF.UserModel.XSSFDrawing Drawing, global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape ctShape)
		{
			this.drawing = Drawing;
			this.ctShape = ctShape;
			this._paragraphs = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFTextParagraph>();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TextBody txBody = ctShape.txBody;
			if (txBody != null)
			{
				for (int i = 0; i < txBody.SizeOfPArray(); i++)
				{
					this._paragraphs.Add(new global::NPOI.XSSF.UserModel.XSSFTextParagraph(txBody.GetPArray(i), ctShape));
				}
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00022EFC File Offset: 0x000210FC
		protected internal static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape Prototype()
		{
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape ct_Shape = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeNonVisual ct_ShapeNonVisual = ct_Shape.AddNewNvSpPr();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualDrawingProps ct_NonVisualDrawingProps = ct_ShapeNonVisual.AddNewCNvPr();
			ct_NonVisualDrawingProps.id = 1U;
			ct_NonVisualDrawingProps.name = "Shape 1";
			ct_ShapeNonVisual.AddNewCNvSpPr();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties ct_ShapeProperties = ct_Shape.AddNewSpPr();
			global::NPOI.OpenXmlFormats.Dml.CT_Transform2D ct_Transform2D = ct_ShapeProperties.AddNewXfrm();
			global::NPOI.OpenXmlFormats.Dml.CT_PositiveSize2D ct_PositiveSize2D = ct_Transform2D.AddNewExt();
			ct_PositiveSize2D.cx = 0L;
			ct_PositiveSize2D.cy = 0L;
			global::NPOI.OpenXmlFormats.Dml.CT_Point2D ct_Point2D = ct_Transform2D.AddNewOff();
			ct_Point2D.x = 0L;
			ct_Point2D.y = 0L;
			global::NPOI.OpenXmlFormats.Dml.CT_PresetGeometry2D ct_PresetGeometry2D = ct_ShapeProperties.AddNewPrstGeom();
			ct_PresetGeometry2D.prst = global::NPOI.OpenXmlFormats.Dml.ST_ShapeType.rect;
			ct_PresetGeometry2D.AddNewAvLst();
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_TextBody ct_TextBody = ct_Shape.AddNewTxBody();
			global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties ct_TextBodyProperties = ct_TextBody.AddNewBodyPr();
			ct_TextBodyProperties.anchor = global::NPOI.OpenXmlFormats.Dml.ST_TextAnchoringType.t;
			ct_TextBodyProperties.rtlCol = false;
			global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph ct_TextParagraph = ct_TextBody.AddNewP();
			ct_TextParagraph.AddNewPPr().algn = global::NPOI.OpenXmlFormats.Dml.ST_TextAlignType.l;
			global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties ct_TextCharacterProperties = ct_TextParagraph.AddNewEndParaRPr();
			ct_TextCharacterProperties.lang = "en-US";
			ct_TextCharacterProperties.sz = 1100;
			ct_TextCharacterProperties.AddNewSolidFill().AddNewSrgbClr().val = new byte[3];
			ct_TextBody.AddNewLstStyle();
			global::NPOI.XSSF.UserModel.XSSFSimpleShape.prototype = ct_Shape;
			return global::NPOI.XSSF.UserModel.XSSFSimpleShape.prototype;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00022FE7 File Offset: 0x000211E7
		public global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape GetCTShape()
		{
			return this.ctShape;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00022FEF File Offset: 0x000211EF
		public global::System.Collections.Generic.IEnumerator<global::NPOI.XSSF.UserModel.XSSFTextParagraph> GetEnumerator()
		{
			return this._paragraphs.GetEnumerator();
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x000065E4 File Offset: 0x000047E4
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00023004 File Offset: 0x00021204
		public string Text
		{
			get
			{
				int num = 9;
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>(num);
				for (int i = 0; i < num; i++)
				{
					list.Add(0);
				}
				for (int j = 0; j < this._paragraphs.Count; j++)
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append('\n');
					}
					global::NPOI.XSSF.UserModel.XSSFTextParagraph xssftextParagraph = this._paragraphs[j];
					if (xssftextParagraph.IsBullet && xssftextParagraph.Text.Length > 0)
					{
						int num2 = global::System.Math.Min(xssftextParagraph.Level, num - 1);
						if (xssftextParagraph.IsBulletAutoNumber)
						{
							j = this.ProcessAutoNumGroup(j, num2, list, stringBuilder);
						}
						else
						{
							for (int k = 0; k < num2; k++)
							{
								stringBuilder.Append('\t');
							}
							string bulletCharacter = xssftextParagraph.BulletCharacter;
							stringBuilder.Append((bulletCharacter.Length > 0) ? (bulletCharacter + " ") : "- ");
							stringBuilder.Append(xssftextParagraph.Text);
						}
					}
					else
					{
						stringBuilder.Append(xssftextParagraph.Text);
						for (int l = 0; l < num; l++)
						{
							list[l] = 0;
						}
					}
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0002313C File Offset: 0x0002133C
		private int ProcessAutoNumGroup(int index, int level, global::System.Collections.Generic.List<int> levelCount, global::System.Text.StringBuilder out1)
		{
			global::NPOI.XSSF.UserModel.XSSFTextParagraph xssftextParagraph = this._paragraphs[index];
			int bulletAutoNumberStart = xssftextParagraph.BulletAutoNumberStart;
			global::NPOI.XSSF.UserModel.ListAutoNumber bulletAutoNumberScheme = xssftextParagraph.BulletAutoNumberScheme;
			if (levelCount[level] == 0)
			{
				levelCount[level] = ((bulletAutoNumberStart == 0) ? 1 : bulletAutoNumberStart);
			}
			for (int i = 0; i < level; i++)
			{
				out1.Append('\t');
			}
			if (xssftextParagraph.Text.Length > 0)
			{
				out1.Append(this.GetBulletPrefix(bulletAutoNumberScheme, levelCount[level]));
				out1.Append(xssftextParagraph.Text);
			}
			for (;;)
			{
				global::NPOI.XSSF.UserModel.XSSFTextParagraph xssftextParagraph2 = (index + 1 == this._paragraphs.Count) ? null : this._paragraphs[index + 1];
				if (xssftextParagraph2 == null || !xssftextParagraph2.IsBullet || !xssftextParagraph.IsBulletAutoNumber)
				{
					break;
				}
				if (xssftextParagraph2.Level > level)
				{
					if (out1.Length > 0)
					{
						out1.Append('\n');
					}
					index = this.ProcessAutoNumGroup(index + 1, xssftextParagraph2.Level, levelCount, out1);
				}
				else
				{
					if (xssftextParagraph2.Level < level)
					{
						break;
					}
					global::NPOI.XSSF.UserModel.ListAutoNumber bulletAutoNumberScheme2 = xssftextParagraph2.BulletAutoNumberScheme;
					int bulletAutoNumberStart2 = xssftextParagraph2.BulletAutoNumberStart;
					if (bulletAutoNumberScheme2 != bulletAutoNumberScheme || bulletAutoNumberStart2 != bulletAutoNumberStart)
					{
						break;
					}
					index++;
					if (out1.Length > 0)
					{
						out1.Append('\n');
					}
					for (int j = 0; j < level; j++)
					{
						out1.Append('\t');
					}
					if (xssftextParagraph2.Text.Length > 0)
					{
						levelCount[level]++;
						out1.Append(this.GetBulletPrefix(bulletAutoNumberScheme2, levelCount[level]));
						out1.Append(xssftextParagraph2.Text);
					}
				}
			}
			levelCount[level] = 0;
			return index;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x000232F0 File Offset: 0x000214F0
		private string GetBulletPrefix(global::NPOI.XSSF.UserModel.ListAutoNumber scheme, int value)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			switch (scheme)
			{
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ALPHA_LC_PARENT_BOTH:
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ALPHA_LC_PARENT_R:
				if (scheme == global::NPOI.XSSF.UserModel.ListAutoNumber.ALPHA_LC_PARENT_BOTH)
				{
					stringBuilder.Append('(');
				}
				stringBuilder.Append(this.valueToAlpha(value).ToLower());
				stringBuilder.Append(')');
				break;
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ALPHA_UC_PARENT_BOTH:
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ALPHA_UC_PARENT_R:
				if (scheme == global::NPOI.XSSF.UserModel.ListAutoNumber.ALPHA_UC_PARENT_BOTH)
				{
					stringBuilder.Append('(');
				}
				stringBuilder.Append(this.valueToAlpha(value));
				stringBuilder.Append(')');
				break;
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ALPHA_LC_PERIOD:
				stringBuilder.Append(this.valueToAlpha(value).ToLower());
				stringBuilder.Append('.');
				break;
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ALPHA_UC_PERIOD:
				stringBuilder.Append(this.valueToAlpha(value));
				stringBuilder.Append('.');
				break;
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ARABIC_PARENT_BOTH:
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ARABIC_PARENT_R:
				if (scheme == global::NPOI.XSSF.UserModel.ListAutoNumber.ARABIC_PARENT_BOTH)
				{
					stringBuilder.Append('(');
				}
				stringBuilder.Append(value);
				stringBuilder.Append(')');
				break;
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ARABIC_PERIOD:
				stringBuilder.Append(value);
				stringBuilder.Append('.');
				break;
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ARABIC_PLAIN:
				stringBuilder.Append(value);
				break;
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ROMAN_LC_PARENT_BOTH:
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ROMAN_LC_PARENT_R:
				if (scheme == global::NPOI.XSSF.UserModel.ListAutoNumber.ROMAN_LC_PARENT_BOTH)
				{
					stringBuilder.Append('(');
				}
				stringBuilder.Append(this.valueToRoman(value).ToLower());
				stringBuilder.Append(')');
				break;
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ROMAN_UC_PARENT_BOTH:
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ROMAN_UC_PARENT_R:
				if (scheme == global::NPOI.XSSF.UserModel.ListAutoNumber.ROMAN_UC_PARENT_BOTH)
				{
					stringBuilder.Append('(');
				}
				stringBuilder.Append(this.valueToRoman(value));
				stringBuilder.Append(')');
				break;
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ROMAN_LC_PERIOD:
				stringBuilder.Append(this.valueToRoman(value).ToLower());
				stringBuilder.Append('.');
				break;
			case global::NPOI.XSSF.UserModel.ListAutoNumber.ROMAN_UC_PERIOD:
				stringBuilder.Append(this.valueToRoman(value));
				stringBuilder.Append('.');
				break;
			default:
				stringBuilder.Append('•');
				break;
			}
			stringBuilder.Append(" ");
			return stringBuilder.ToString();
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x000234D0 File Offset: 0x000216D0
		private string valueToAlpha(int value)
		{
			string text = "";
			while (value > 0)
			{
				int num = (value - 1) % 26;
				text = ((char)(65 + num)).ToString() + text;
				value = (value - num) / 26;
			}
			return text;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00023510 File Offset: 0x00021710
		private string valueToRoman(int value)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num = 0;
			while (value > 0 && num < global::NPOI.XSSF.UserModel.XSSFSimpleShape._romanChars.Length)
			{
				while (global::NPOI.XSSF.UserModel.XSSFSimpleShape._romanAlphaValues[num] <= value)
				{
					stringBuilder.Append(global::NPOI.XSSF.UserModel.XSSFSimpleShape._romanChars[num]);
					value -= global::NPOI.XSSF.UserModel.XSSFSimpleShape._romanAlphaValues[num];
				}
				num++;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00023562 File Offset: 0x00021762
		public void ClearText()
		{
			this._paragraphs.Clear();
			this.ctShape.txBody.SetPArray(null);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00023580 File Offset: 0x00021780
		public void SetText(string text)
		{
			this.ClearText();
			this.AddNewTextParagraph().AddNewTextRun().Text = text;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0002359C File Offset: 0x0002179C
		public void SetText(global::NPOI.XSSF.UserModel.XSSFRichTextString str)
		{
			global::NPOI.XSSF.UserModel.XSSFWorkbook xssfworkbook = (global::NPOI.XSSF.UserModel.XSSFWorkbook)base.GetDrawing().GetParent().GetParent();
			str.SetStylesTableReference(xssfworkbook.GetStylesSource());
			global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph ct_TextParagraph = new global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph();
			if (str.NumFormattingRuns == 0)
			{
				global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun ct_RegularTextRun = ct_TextParagraph.AddNewR();
				global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties ct_TextCharacterProperties = ct_RegularTextRun.AddNewRPr();
				ct_TextCharacterProperties.lang = "en-US";
				ct_TextCharacterProperties.sz = 1100;
				ct_RegularTextRun.t = str.String;
			}
			else
			{
				for (int i = 0; i < str.GetCTRst().SizeOfRArray(); i++)
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt rarray = str.GetCTRst().GetRArray(i);
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt ct_RPrElt = rarray.rPr;
					if (ct_RPrElt == null)
					{
						ct_RPrElt = rarray.AddNewRPr();
					}
					global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun ct_RegularTextRun2 = ct_TextParagraph.AddNewR();
					global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties ct_TextCharacterProperties2 = ct_RegularTextRun2.AddNewRPr();
					ct_TextCharacterProperties2.lang = "en-US";
					global::NPOI.XSSF.UserModel.XSSFSimpleShape.ApplyAttributes(ct_RPrElt, ct_TextCharacterProperties2);
					ct_RegularTextRun2.t = rarray.t;
				}
			}
			this.ClearText();
			this.ctShape.txBody.SetPArray(new global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph[]
			{
				ct_TextParagraph
			});
			this._paragraphs.Add(new global::NPOI.XSSF.UserModel.XSSFTextParagraph(this.ctShape.txBody.GetPArray(0), this.ctShape));
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x000236B3 File Offset: 0x000218B3
		public global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFTextParagraph> TextParagraphs
		{
			get
			{
				return this._paragraphs;
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x000236BC File Offset: 0x000218BC
		public global::NPOI.XSSF.UserModel.XSSFTextParagraph AddNewTextParagraph()
		{
			global::NPOI.XSSF.UserModel.XSSFTextParagraph xssftextParagraph = new global::NPOI.XSSF.UserModel.XSSFTextParagraph(this.ctShape.txBody.AddNewP(), this.ctShape);
			this._paragraphs.Add(xssftextParagraph);
			return xssftextParagraph;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x000236F2 File Offset: 0x000218F2
		public global::NPOI.XSSF.UserModel.XSSFTextParagraph AddNewTextParagraph(string text)
		{
			global::NPOI.XSSF.UserModel.XSSFTextParagraph xssftextParagraph = this.AddNewTextParagraph();
			xssftextParagraph.AddNewTextRun().Text = text;
			return xssftextParagraph;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00023708 File Offset: 0x00021908
		public global::NPOI.XSSF.UserModel.XSSFTextParagraph AddNewTextParagraph(global::NPOI.XSSF.UserModel.XSSFRichTextString str)
		{
			global::NPOI.OpenXmlFormats.Dml.CT_TextParagraph ct_TextParagraph = this.ctShape.txBody.AddNewP();
			if (str.NumFormattingRuns == 0)
			{
				global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun ct_RegularTextRun = ct_TextParagraph.AddNewR();
				global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties ct_TextCharacterProperties = ct_RegularTextRun.AddNewRPr();
				ct_TextCharacterProperties.lang = "en-US";
				ct_TextCharacterProperties.sz = 1100;
				ct_RegularTextRun.t = str.String;
			}
			else
			{
				for (int i = 0; i < str.GetCTRst().SizeOfRArray(); i++)
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt rarray = str.GetCTRst().GetRArray(i);
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt ct_RPrElt = rarray.rPr;
					if (ct_RPrElt == null)
					{
						ct_RPrElt = rarray.AddNewRPr();
					}
					global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun ct_RegularTextRun2 = ct_TextParagraph.AddNewR();
					global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties ct_TextCharacterProperties2 = ct_RegularTextRun2.AddNewRPr();
					ct_TextCharacterProperties2.lang = "en-US";
					global::NPOI.XSSF.UserModel.XSSFSimpleShape.ApplyAttributes(ct_RPrElt, ct_TextCharacterProperties2);
					ct_RegularTextRun2.t = rarray.t;
				}
			}
			global::NPOI.XSSF.UserModel.XSSFTextParagraph xssftextParagraph = new global::NPOI.XSSF.UserModel.XSSFTextParagraph(ct_TextParagraph, this.ctShape);
			this._paragraphs.Add(xssftextParagraph);
			return xssftextParagraph;
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x000237DC File Offset: 0x000219DC
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x00023810 File Offset: 0x00021A10
		public global::NPOI.XSSF.UserModel.TextHorizontalOverflow TextHorizontalOverflow
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null && bodyPr.IsSetHorzOverflow())
				{
					return (global::NPOI.XSSF.UserModel.TextHorizontalOverflow)(bodyPr.horzOverflow - 1);
				}
				return global::NPOI.XSSF.UserModel.TextHorizontalOverflow.OVERFLOW;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null)
				{
					if (value == global::NPOI.XSSF.UserModel.TextHorizontalOverflow.None)
					{
						if (bodyPr.IsSetHorzOverflow())
						{
							bodyPr.UnsetHorzOverflow();
							return;
						}
					}
					else
					{
						bodyPr.horzOverflow = (global::NPOI.OpenXmlFormats.Dml.ST_TextHorzOverflowType)(value + 1);
					}
				}
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x0002384C File Offset: 0x00021A4C
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x00023880 File Offset: 0x00021A80
		public global::NPOI.XSSF.UserModel.TextVerticalOverflow TextVerticalOverflow
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null && bodyPr.IsSetVertOverflow())
				{
					return (global::NPOI.XSSF.UserModel.TextVerticalOverflow)(bodyPr.vertOverflow - 1);
				}
				return global::NPOI.XSSF.UserModel.TextVerticalOverflow.OVERFLOW;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null)
				{
					if (value == global::NPOI.XSSF.UserModel.TextVerticalOverflow.None)
					{
						if (bodyPr.IsSetVertOverflow())
						{
							bodyPr.UnsetVertOverflow();
							return;
						}
					}
					else
					{
						bodyPr.vertOverflow = (global::NPOI.OpenXmlFormats.Dml.ST_TextVertOverflowType)(value + 1);
					}
				}
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x000238BC File Offset: 0x00021ABC
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x000238F0 File Offset: 0x00021AF0
		public global::NPOI.SS.UserModel.VerticalAlignment VerticalAlignment
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null && bodyPr.IsSetAnchor())
				{
					return (global::NPOI.SS.UserModel.VerticalAlignment)bodyPr.anchor;
				}
				return global::NPOI.SS.UserModel.VerticalAlignment.Top;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null)
				{
					if (value == global::NPOI.SS.UserModel.VerticalAlignment.None)
					{
						if (bodyPr.IsSetAnchor())
						{
							bodyPr.UnsetAnchor();
							return;
						}
					}
					else
					{
						bodyPr.anchor = (global::NPOI.OpenXmlFormats.Dml.ST_TextAnchoringType)value;
					}
				}
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0002392C File Offset: 0x00021B2C
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x0002395C File Offset: 0x00021B5C
		public global::NPOI.XSSF.UserModel.TextDirection TextDirection
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null)
				{
					global::NPOI.OpenXmlFormats.Dml.ST_TextVerticalType vert = bodyPr.vert;
					if (vert != global::NPOI.OpenXmlFormats.Dml.ST_TextVerticalType.horz)
					{
						return (global::NPOI.XSSF.UserModel.TextDirection)(vert - 1);
					}
				}
				return global::NPOI.XSSF.UserModel.TextDirection.HORIZONTAL;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null)
				{
					if (value == global::NPOI.XSSF.UserModel.TextDirection.None)
					{
						if (bodyPr.IsSetVert())
						{
							bodyPr.UnsetVert();
							return;
						}
					}
					else
					{
						bodyPr.vert = (global::NPOI.OpenXmlFormats.Dml.ST_TextVerticalType)(value + 1);
					}
				}
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x00023998 File Offset: 0x00021B98
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x000239D8 File Offset: 0x00021BD8
		public double BottomInset
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null && bodyPr.IsSetBIns())
				{
					return global::NPOI.Util.Units.ToPoints((long)bodyPr.bIns);
				}
				return 3.6;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null)
				{
					if (value == -1.0)
					{
						if (bodyPr.IsSetBIns())
						{
							bodyPr.UnsetBIns();
							return;
						}
					}
					else
					{
						bodyPr.bIns = global::NPOI.Util.Units.ToEMU(value);
					}
				}
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00023A20 File Offset: 0x00021C20
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x00023A60 File Offset: 0x00021C60
		public double LeftInset
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null && bodyPr.IsSetLIns())
				{
					return global::NPOI.Util.Units.ToPoints((long)bodyPr.lIns);
				}
				return 3.6;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null)
				{
					if (value == -1.0)
					{
						if (bodyPr.IsSetLIns())
						{
							bodyPr.UnsetLIns();
							return;
						}
					}
					else
					{
						bodyPr.lIns = global::NPOI.Util.Units.ToEMU(value);
					}
				}
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00023AA8 File Offset: 0x00021CA8
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x00023AE8 File Offset: 0x00021CE8
		public double RightInset
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null && bodyPr.IsSetRIns())
				{
					return global::NPOI.Util.Units.ToPoints((long)bodyPr.rIns);
				}
				return 3.6;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null)
				{
					if (value == -1.0)
					{
						if (bodyPr.IsSetRIns())
						{
							bodyPr.UnsetRIns();
							return;
						}
					}
					else
					{
						bodyPr.rIns = global::NPOI.Util.Units.ToEMU(value);
					}
				}
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x00023B30 File Offset: 0x00021D30
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x00023B70 File Offset: 0x00021D70
		public double TopInset
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null && bodyPr.IsSetTIns())
				{
					return global::NPOI.Util.Units.ToPoints((long)bodyPr.tIns);
				}
				return 3.6;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null)
				{
					if (value == -1.0)
					{
						if (bodyPr.IsSetTIns())
						{
							bodyPr.UnsetTIns();
							return;
						}
					}
					else
					{
						bodyPr.tIns = global::NPOI.Util.Units.ToEMU(value);
					}
				}
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x00023BB8 File Offset: 0x00021DB8
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x00023BEC File Offset: 0x00021DEC
		public bool WordWrap
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				return bodyPr == null || !bodyPr.IsSetWrap() || bodyPr.wrap == global::NPOI.OpenXmlFormats.Dml.ST_TextWrappingType.square;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null)
				{
					bodyPr.wrap = (value ? global::NPOI.OpenXmlFormats.Dml.ST_TextWrappingType.square : global::NPOI.OpenXmlFormats.Dml.ST_TextWrappingType.none);
				}
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00023C1C File Offset: 0x00021E1C
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x00023C5C File Offset: 0x00021E5C
		public global::NPOI.XSSF.UserModel.TextAutofit TextAutofit
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null)
				{
					if (bodyPr.IsSetNoAutofit())
					{
						return global::NPOI.XSSF.UserModel.TextAutofit.NONE;
					}
					if (bodyPr.IsSetNormAutofit())
					{
						return global::NPOI.XSSF.UserModel.TextAutofit.NORMAL;
					}
					if (bodyPr.IsSetSpAutoFit())
					{
						return global::NPOI.XSSF.UserModel.TextAutofit.SHAPE;
					}
				}
				return global::NPOI.XSSF.UserModel.TextAutofit.NORMAL;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr = this.ctShape.txBody.bodyPr;
				if (bodyPr != null)
				{
					if (bodyPr.IsSetSpAutoFit())
					{
						bodyPr.UnsetSpAutoFit();
					}
					if (bodyPr.IsSetNoAutofit())
					{
						bodyPr.UnsetNoAutofit();
					}
					if (bodyPr.IsSetNormAutofit())
					{
						bodyPr.UnsetNormAutofit();
					}
					switch (value)
					{
					case global::NPOI.XSSF.UserModel.TextAutofit.NONE:
						bodyPr.AddNewNoAutofit();
						return;
					case global::NPOI.XSSF.UserModel.TextAutofit.NORMAL:
						bodyPr.AddNewNormAutofit();
						return;
					case global::NPOI.XSSF.UserModel.TextAutofit.SHAPE:
						bodyPr.AddNewSpAutoFit();
						break;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x00023CD1 File Offset: 0x00021ED1
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x00023CE8 File Offset: 0x00021EE8
		public int ShapeType
		{
			get
			{
				return (int)this.ctShape.spPr.prstGeom.prst;
			}
			set
			{
				this.ctShape.spPr.prstGeom.prst = (global::NPOI.OpenXmlFormats.Dml.ST_ShapeType)value;
			}
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00023D00 File Offset: 0x00021F00
		protected internal override global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_ShapeProperties GetShapeProperties()
		{
			return this.ctShape.spPr;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00023D10 File Offset: 0x00021F10
		private static void ApplyAttributes(global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt pr, global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rPr)
		{
			if (pr.SizeOfBArray() > 0)
			{
				rPr.b = pr.GetBArray(0).val;
			}
			if (pr.SizeOfUArray() > 0)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues val = pr.GetUArray(0).val;
				if (val == global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues.single)
				{
					rPr.u = global::NPOI.OpenXmlFormats.Dml.ST_TextUnderlineType.sng;
				}
				else if (val == global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues.@double)
				{
					rPr.u = global::NPOI.OpenXmlFormats.Dml.ST_TextUnderlineType.dbl;
				}
				else if (val == global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues.none)
				{
					rPr.u = global::NPOI.OpenXmlFormats.Dml.ST_TextUnderlineType.none;
				}
			}
			if (pr.SizeOfIArray() > 0)
			{
				rPr.i = pr.GetIArray(0).val;
			}
			if (pr.SizeOfRFontArray() > 0)
			{
				(rPr.IsSetLatin() ? rPr.latin : rPr.AddNewLatin()).typeface = pr.GetRFontArray(0).val;
			}
			if (pr.SizeOfSzArray() > 0)
			{
				int sz = (int)(pr.GetSzArray(0).val * 100.0);
				rPr.sz = sz;
			}
			if (pr.SizeOfColorArray() > 0)
			{
				global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties ct_SolidColorFillProperties = rPr.IsSetSolidFill() ? rPr.solidFill : rPr.AddNewSolidFill();
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color colorArray = pr.GetColorArray(0);
				if (colorArray.IsSetRgb())
				{
					(ct_SolidColorFillProperties.IsSetSrgbClr() ? ct_SolidColorFillProperties.srgbClr : ct_SolidColorFillProperties.AddNewSrgbClr()).val = colorArray.rgb;
					return;
				}
				if (colorArray.IsSetIndexed())
				{
					global::NPOI.HSSF.Util.HSSFColor hssfcolor = global::NPOI.HSSF.Util.HSSFColor.GetIndexHash()[(int)colorArray.indexed];
					if (hssfcolor != null)
					{
						byte[] val2 = new byte[]
						{
							hssfcolor.GetTriplet()[0],
							hssfcolor.GetTriplet()[1],
							hssfcolor.GetTriplet()[2]
						};
						(ct_SolidColorFillProperties.IsSetSrgbClr() ? ct_SolidColorFillProperties.srgbClr : ct_SolidColorFillProperties.AddNewSrgbClr()).val = val2;
					}
				}
			}
		}

		// Token: 0x04000363 RID: 867
		private global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFTextParagraph> _paragraphs;

		// Token: 0x04000364 RID: 868
		private static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape prototype = null;

		// Token: 0x04000365 RID: 869
		private global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape ctShape;

		// Token: 0x04000366 RID: 870
		private static string[] _romanChars = new string[]
		{
			"M",
			"CM",
			"D",
			"CD",
			"C",
			"XC",
			"L",
			"XL",
			"X",
			"IX",
			"V",
			"IV",
			"I"
		};

		// Token: 0x04000367 RID: 871
		private static int[] _romanAlphaValues = new int[]
		{
			1000,
			900,
			500,
			400,
			100,
			90,
			50,
			40,
			10,
			9,
			5,
			4,
			1
		};
	}
}
