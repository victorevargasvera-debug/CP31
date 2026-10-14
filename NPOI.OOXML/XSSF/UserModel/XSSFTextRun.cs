using System;
using System.Drawing;
using NPOI.OpenXmlFormats.Dml;
using NPOI.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x020000A4 RID: 164
	public class XSSFTextRun
	{
		// Token: 0x06000A25 RID: 2597 RVA: 0x000254F7 File Offset: 0x000236F7
		public XSSFTextRun(global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun r, global::NPOI.XSSF.UserModel.XSSFTextParagraph p)
		{
			this._r = r;
			this._p = p;
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0002550D File Offset: 0x0002370D
		public global::NPOI.XSSF.UserModel.XSSFTextParagraph ParentParagraph
		{
			get
			{
				return this._p;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x00025515 File Offset: 0x00023715
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x00025522 File Offset: 0x00023722
		public string Text
		{
			get
			{
				return this._r.t;
			}
			set
			{
				this._r.t = value;
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00025530 File Offset: 0x00023730
		public global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun GetXmlObject()
		{
			return this._r;
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00025538 File Offset: 0x00023738
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00025598 File Offset: 0x00023798
		public global::System.Drawing.Color FontColor
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rpr = this.GetRPr();
				if (rpr.IsSetSolidFill())
				{
					global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFill = rpr.solidFill;
					if (solidFill.IsSetSrgbClr())
					{
						byte[] val = solidFill.srgbClr.val;
						return global::System.Drawing.Color.FromArgb((int)(byte.MaxValue & val[0]), (int)(byte.MaxValue & val[1]), (int)(byte.MaxValue & val[2]));
					}
				}
				return global::System.Drawing.Color.FromArgb(0, 0, 0);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rpr = this.GetRPr();
				global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties ct_SolidColorFillProperties = rpr.IsSetSolidFill() ? rpr.solidFill : rpr.AddNewSolidFill();
				(ct_SolidColorFillProperties.IsSetSrgbClr() ? ct_SolidColorFillProperties.srgbClr : ct_SolidColorFillProperties.AddNewSrgbClr()).val = new byte[]
				{
					value.R,
					value.G,
					value.B
				};
				if (ct_SolidColorFillProperties.IsSetHslClr())
				{
					ct_SolidColorFillProperties.UnsetHslClr();
				}
				if (ct_SolidColorFillProperties.IsSetPrstClr())
				{
					ct_SolidColorFillProperties.UnsetPrstClr();
				}
				if (ct_SolidColorFillProperties.IsSetSchemeClr())
				{
					ct_SolidColorFillProperties.UnsetSchemeClr();
				}
				if (ct_SolidColorFillProperties.IsSetScrgbClr())
				{
					ct_SolidColorFillProperties.UnsetScrgbClr();
				}
				if (ct_SolidColorFillProperties.IsSetSysClr())
				{
					ct_SolidColorFillProperties.UnsetSysClr();
				}
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00025648 File Offset: 0x00023848
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x000256C0 File Offset: 0x000238C0
		public double FontSize
		{
			get
			{
				double num = 1.0;
				double num2 = 11.0;
				global::NPOI.OpenXmlFormats.Dml.CT_TextNormalAutofit normAutofit = this.ParentParagraph.ParentShape.txBody.bodyPr.normAutofit;
				if (normAutofit != null)
				{
					num = (double)normAutofit.fontScale / 100000.0;
				}
				global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rpr = this.GetRPr();
				if (rpr.IsSetSz())
				{
					num2 = (double)rpr.sz * 0.01;
				}
				return num2 * num;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rpr = this.GetRPr();
				if (value == -1.0)
				{
					if (rpr.IsSetSz())
					{
						rpr.UnsetSz();
						return;
					}
				}
				else
				{
					if (value < 1.0)
					{
						throw new global::System.ArgumentException("Minimum font size is 1pt but was " + value.ToString());
					}
					rpr.sz = (int)(100.0 * value);
				}
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00025724 File Offset: 0x00023924
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x0002575C File Offset: 0x0002395C
		public double CharacterSpacing
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rpr = this.GetRPr();
				if (rpr.IsSetSpc())
				{
					return (double)rpr.spc * 0.01;
				}
				return 0.0;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rpr = this.GetRPr();
				if (value == 0.0)
				{
					if (rpr.IsSetSpc())
					{
						rpr.UnsetSpc();
						return;
					}
				}
				else
				{
					rpr.spc = (int)(100.0 * value);
				}
			}
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0002579D File Offset: 0x0002399D
		public void SetFont(string typeface)
		{
			this.SetFontFamily(typeface, byte.MaxValue, byte.MaxValue, false);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x000257B4 File Offset: 0x000239B4
		public void SetFontFamily(string typeface, byte charset, byte pictAndFamily, bool isSymbol)
		{
			global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rpr = this.GetRPr();
			if (typeface == null)
			{
				if (rpr.IsSetLatin())
				{
					rpr.UnsetLatin();
				}
				if (rpr.IsSetCs())
				{
					rpr.UnsetCs();
				}
				if (rpr.IsSetSym())
				{
					rpr.UnsetSym();
					return;
				}
			}
			else
			{
				if (isSymbol)
				{
					(rpr.IsSetSym() ? rpr.sym : rpr.AddNewSym()).typeface = typeface;
					return;
				}
				global::NPOI.OpenXmlFormats.Dml.CT_TextFont ct_TextFont = rpr.IsSetLatin() ? rpr.latin : rpr.AddNewLatin();
				ct_TextFont.typeface = typeface;
				if ((sbyte)charset != -1)
				{
					ct_TextFont.charset = (sbyte)charset;
				}
				if ((sbyte)pictAndFamily != -1)
				{
					ct_TextFont.pitchFamily = (sbyte)pictAndFamily;
				}
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00025850 File Offset: 0x00023A50
		public string FontFamily
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextFont latin = this.GetRPr().latin;
				if (latin != null)
				{
					return latin.typeface;
				}
				return "Calibri";
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00025878 File Offset: 0x00023A78
		public byte PitchAndFamily
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextFont latin = this.GetRPr().latin;
				if (latin != null)
				{
					return (byte)latin.pitchFamily;
				}
				return 0;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x000258A0 File Offset: 0x00023AA0
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x000258C7 File Offset: 0x00023AC7
		public bool IsStrikethrough
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rpr = this.GetRPr();
				return rpr.IsSetStrike() && rpr.strike > global::NPOI.OpenXmlFormats.Dml.ST_TextStrikeType.noStrike;
			}
			set
			{
				this.GetRPr().strike = (value ? global::NPOI.OpenXmlFormats.Dml.ST_TextStrikeType.sngStrike : global::NPOI.OpenXmlFormats.Dml.ST_TextStrikeType.noStrike);
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x000258DC File Offset: 0x00023ADC
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00025903 File Offset: 0x00023B03
		public bool IsSuperscript
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rpr = this.GetRPr();
				return rpr.IsSetBaseline() && rpr.baseline > 0;
			}
			set
			{
				this.SetBaselineOffset(value ? 30.0 : 0.0);
			}
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00025922 File Offset: 0x00023B22
		public void SetBaselineOffset(double baselineOffset)
		{
			this.GetRPr().baseline = (int)baselineOffset * 1000;
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00025938 File Offset: 0x00023B38
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x0002595F File Offset: 0x00023B5F
		public bool IsSubscript
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rpr = this.GetRPr();
				return rpr.IsSetBaseline() && rpr.baseline < 0;
			}
			set
			{
				this.SetBaselineOffset(value ? -25.0 : 0.0);
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x00025980 File Offset: 0x00023B80
		public global::NPOI.XSSF.UserModel.TextCap TextCap
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rpr = this.GetRPr();
				if (rpr.IsSetCap())
				{
					return global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.XSSF.UserModel.TextCap, global::NPOI.OpenXmlFormats.Dml.ST_TextCapsType>(rpr.cap);
				}
				return global::NPOI.XSSF.UserModel.TextCap.NONE;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x000259AC File Offset: 0x00023BAC
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x000259D0 File Offset: 0x00023BD0
		public bool IsBold
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rpr = this.GetRPr();
				return rpr.IsSetB() && rpr.b;
			}
			set
			{
				this.GetRPr().b = value;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x000259E0 File Offset: 0x00023BE0
		// (set) Token: 0x06000A3F RID: 2623 RVA: 0x00025A04 File Offset: 0x00023C04
		public bool IsItalic
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rpr = this.GetRPr();
				return rpr.IsSetI() && rpr.i;
			}
			set
			{
				this.GetRPr().i = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00025A14 File Offset: 0x00023C14
		// (set) Token: 0x06000A41 RID: 2625 RVA: 0x00025A3B File Offset: 0x00023C3B
		public bool IsUnderline
		{
			get
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties rpr = this.GetRPr();
				return rpr.IsSetU() && rpr.u > global::NPOI.OpenXmlFormats.Dml.ST_TextUnderlineType.none;
			}
			set
			{
				this.GetRPr().u = (value ? global::NPOI.OpenXmlFormats.Dml.ST_TextUnderlineType.sng : global::NPOI.OpenXmlFormats.Dml.ST_TextUnderlineType.none);
			}
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00025A4F File Offset: 0x00023C4F
		internal global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties GetRPr()
		{
			if (!this._r.IsSetRPr())
			{
				return this._r.AddNewRPr();
			}
			return this._r.rPr;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00025A75 File Offset: 0x00023C75
		public override string ToString()
		{
			return "[" + base.GetType().ToString() + "]" + this.Text;
		}

		// Token: 0x04000372 RID: 882
		private global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun _r;

		// Token: 0x04000373 RID: 883
		private global::NPOI.XSSF.UserModel.XSSFTextParagraph _p;
	}
}
