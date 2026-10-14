using System;
using System.Text;
using NPOI.OpenXmlFormats.Shared;
using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.WP.UserModel;
using NPOI.XWPF.UserModel;

namespace NPOI.XWPF.Usermodel
{
	// Token: 0x02000014 RID: 20
	public class XWPFSharedRun : global::NPOI.WP.UserModel.ICharacterRun
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00004A83 File Offset: 0x00002C83
		public XWPFSharedRun(global::NPOI.OpenXmlFormats.Shared.CT_R ctR, global::NPOI.XWPF.UserModel.IRunBody p)
		{
			this.run = ctR;
			this.parent = p;
			this.SetFontFamily("Cambria Math", global::NPOI.XWPF.UserModel.FontCharRange.None);
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00004AA5 File Offset: 0x00002CA5
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00004AAD File Offset: 0x00002CAD
		public bool IsBold { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00004AB8 File Offset: 0x00002CB8
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00004AEC File Offset: 0x00002CEC
		public bool IsItalic
		{
			get
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr1;
				return rPr != null && rPr.IsSetI() && this.IsCTOnOff(rPr.i);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr1() ? this.run.rPr1 : this.run.AddNewRPr1();
				(ct_RPr.IsSetI() ? ct_RPr.i : ct_RPr.AddNewI()).val = value;
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004B3B File Offset: 0x00002D3B
		private bool IsCTOnOff(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff onoff)
		{
			return !onoff.IsSetVal() || onoff.val;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00004B4D File Offset: 0x00002D4D
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00004B55 File Offset: 0x00002D55
		public bool IsSmallCaps { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00004B5E File Offset: 0x00002D5E
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00004B66 File Offset: 0x00002D66
		public bool IsCapitalized { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00004B6F File Offset: 0x00002D6F
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00004B77 File Offset: 0x00002D77
		public bool IsStrikeThrough { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00004B80 File Offset: 0x00002D80
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00004B88 File Offset: 0x00002D88
		public bool IsDoubleStrikeThrough { get; set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00004B91 File Offset: 0x00002D91
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00004B99 File Offset: 0x00002D99
		public bool IsShadowed { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00004BA2 File Offset: 0x00002DA2
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00004BAA File Offset: 0x00002DAA
		public bool IsEmbossed { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00004BB3 File Offset: 0x00002DB3
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00004BBB File Offset: 0x00002DBB
		public bool IsImprinted { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00004BC4 File Offset: 0x00002DC4
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00004BCC File Offset: 0x00002DCC
		public int CharacterSpacing { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00004BD5 File Offset: 0x00002DD5
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00004BDD File Offset: 0x00002DDD
		public int Kerning { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00004BE6 File Offset: 0x00002DE6
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00004BEE File Offset: 0x00002DEE
		public bool IsHighlighted { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00004BF7 File Offset: 0x00002DF7
		public string FontName
		{
			get
			{
				return this.FontFamily;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00004BFF File Offset: 0x00002DFF
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00004C08 File Offset: 0x00002E08
		public string FontFamily
		{
			get
			{
				return this.GetFontFamily(global::NPOI.XWPF.UserModel.FontCharRange.None);
			}
			set
			{
				this.SetFontFamily(value, global::NPOI.XWPF.UserModel.FontCharRange.None);
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004C14 File Offset: 0x00002E14
		public void SetFontFamily(string fontFamily, global::NPOI.XWPF.UserModel.FontCharRange fcr)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = this.run.IsSetRPr1() ? this.run.rPr1 : this.run.AddNewRPr1();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts ct_Fonts = ct_RPr.IsSetRFonts() ? ct_RPr.rFonts : ct_RPr.AddNewRFonts();
			if (fcr == global::NPOI.XWPF.UserModel.FontCharRange.None)
			{
				ct_Fonts.ascii = fontFamily;
				if (!ct_Fonts.IsSetHAnsi())
				{
					ct_Fonts.hAnsi = fontFamily;
				}
				if (!ct_Fonts.IsSetCs())
				{
					ct_Fonts.cs = fontFamily;
				}
				if (!ct_Fonts.IsSetEastAsia())
				{
					ct_Fonts.eastAsia = fontFamily;
					return;
				}
			}
			else
			{
				switch (fcr)
				{
				case global::NPOI.XWPF.UserModel.FontCharRange.Ascii:
					ct_Fonts.ascii = fontFamily;
					return;
				case global::NPOI.XWPF.UserModel.FontCharRange.CS:
					ct_Fonts.cs = fontFamily;
					return;
				case global::NPOI.XWPF.UserModel.FontCharRange.EastAsia:
					ct_Fonts.eastAsia = fontFamily;
					return;
				case global::NPOI.XWPF.UserModel.FontCharRange.HAnsi:
					ct_Fonts.hAnsi = fontFamily;
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00004CD0 File Offset: 0x00002ED0
		public string GetFontFamily(global::NPOI.XWPF.UserModel.FontCharRange fcr)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr = this.run.rPr1;
			if (rPr == null || !rPr.IsSetRFonts())
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts rFonts = rPr.rFonts;
			switch ((fcr == global::NPOI.XWPF.UserModel.FontCharRange.None) ? global::NPOI.XWPF.UserModel.FontCharRange.Ascii : fcr)
			{
			default:
				return rFonts.ascii;
			case global::NPOI.XWPF.UserModel.FontCharRange.CS:
				return rFonts.cs;
			case global::NPOI.XWPF.UserModel.FontCharRange.EastAsia:
				return rFonts.eastAsia;
			case global::NPOI.XWPF.UserModel.FontCharRange.HAnsi:
				return rFonts.hAnsi;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00004D38 File Offset: 0x00002F38
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00004D40 File Offset: 0x00002F40
		public double FontSize { get; set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00004D4C File Offset: 0x00002F4C
		public string Text
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				for (int i = 0; i < this.run.Items.Count; i++)
				{
					object obj = this.run.Items[i];
					if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Text1)
					{
						stringBuilder.Append(((global::NPOI.OpenXmlFormats.Shared.CT_Text1)obj).Value);
					}
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004DAC File Offset: 0x00002FAC
		public global::NPOI.XWPF.Usermodel.XWPFSharedRun SetText(string value)
		{
			this.SetText(value, 0);
			return this;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004DB8 File Offset: 0x00002FB8
		private global::NPOI.XWPF.Usermodel.XWPFSharedRun SetText(string value, int pos)
		{
			int num = this.run.SizeOfTArray();
			if (pos > num)
			{
				throw new global::System.IndexOutOfRangeException("Value too large for the parameter position");
			}
			global::NPOI.OpenXmlFormats.Shared.CT_Text1 ct_Text = (pos < num && pos >= 0) ? this.run.GetTArray(pos) : this.run.AddNewT();
			ct_Text.Value = value;
			global::NPOI.XWPF.Usermodel.XWPFSharedRun.preserveSpaces(ct_Text);
			return this;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00004E10 File Offset: 0x00003010
		private static void preserveSpaces(global::NPOI.OpenXmlFormats.Shared.CT_Text1 xs)
		{
			string value = xs.Value;
			if (value != null && (value.StartsWith(" ") || value.EndsWith(" ")))
			{
				xs.space = "preserve";
			}
		}

		// Token: 0x0400003E RID: 62
		private global::NPOI.OpenXmlFormats.Shared.CT_R run;

		// Token: 0x0400003F RID: 63
		private global::NPOI.XWPF.UserModel.IRunBody parent;
	}
}
