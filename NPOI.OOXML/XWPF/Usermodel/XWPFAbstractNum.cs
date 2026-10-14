using System;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.Util;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200002E RID: 46
	public class XWPFAbstractNum
	{
		// Token: 0x0600014D RID: 333 RVA: 0x000054D5 File Offset: 0x000036D5
		protected XWPFAbstractNum()
		{
			this.ctAbstractNum = null;
			this.numbering = null;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00005502 File Offset: 0x00003702
		public XWPFAbstractNum(global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum abstractNum)
		{
			this.ctAbstractNum = abstractNum;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00005528 File Offset: 0x00003728
		public XWPFAbstractNum(global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum ctAbstractNum, global::NPOI.XWPF.UserModel.XWPFNumbering numbering)
		{
			this.ctAbstractNum = ctAbstractNum;
			this.numbering = numbering;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00005555 File Offset: 0x00003755
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum GetAbstractNum()
		{
			return this.ctAbstractNum;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000555D File Offset: 0x0000375D
		public global::NPOI.XWPF.UserModel.XWPFNumbering GetNumbering()
		{
			return this.numbering;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00005555 File Offset: 0x00003755
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum GetCTAbstractNum()
		{
			return this.ctAbstractNum;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00005565 File Offset: 0x00003765
		public void SetNumbering(global::NPOI.XWPF.UserModel.XWPFNumbering numbering)
		{
			this.numbering = numbering;
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0000556E File Offset: 0x0000376E
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00005585 File Offset: 0x00003785
		public global::NPOI.XWPF.UserModel.MultiLevelType MultiLevelType
		{
			get
			{
				return global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.XWPF.UserModel.MultiLevelType, global::NPOI.OpenXmlFormats.Wordprocessing.ST_MultiLevelType>(this.ctAbstractNum.multiLevelType.val);
			}
			set
			{
				this.ctAbstractNum.multiLevelType.val = global::NPOI.Util.EnumConverter.ValueOf<global::NPOI.OpenXmlFormats.Wordprocessing.ST_MultiLevelType, global::NPOI.XWPF.UserModel.MultiLevelType>(value);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000559D File Offset: 0x0000379D
		// (set) Token: 0x06000157 RID: 343 RVA: 0x000055AA File Offset: 0x000037AA
		public string AbstractNumId
		{
			get
			{
				return this.ctAbstractNum.abstractNumId;
			}
			set
			{
				this.ctAbstractNum.abstractNumId = value;
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000055B8 File Offset: 0x000037B8
		internal void InitLvl()
		{
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl> list = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl>();
			for (int i = 0; i < 9; i++)
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl ct_Lvl = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lvl();
				ct_Lvl.start.val = "1";
				ct_Lvl.tentative = ((i == 0) ? global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.on : global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off);
				ct_Lvl.ilvl = i.ToString();
				ct_Lvl.lvlJc.val = global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc.left;
				ct_Lvl.numFmt.val = global::NPOI.OpenXmlFormats.Wordprocessing.ST_NumberFormat.bullet;
				ct_Lvl.lvlText.val = this.lvlText[i % 3].ToString();
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ind ct_Ind = ct_Lvl.pPr.AddNewInd();
				ct_Ind.left = (420 * (i + 1)).ToString();
				ct_Ind.hanging = 420UL;
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts ct_Fonts = ct_Lvl.rPr.AddNewRFonts();
				ct_Fonts.ascii = "Wingdings";
				ct_Fonts.hAnsi = "Wingdings";
				ct_Fonts.hint = global::NPOI.OpenXmlFormats.Wordprocessing.ST_Hint.@default;
				list.Add(ct_Lvl);
			}
			this.ctAbstractNum.lvl = list;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000056AC File Offset: 0x000038AC
		internal void SetLevelTentative(int lvl, bool tentative)
		{
			if (tentative)
			{
				this.ctAbstractNum.lvl[lvl].tentative = global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.on;
				return;
			}
			this.ctAbstractNum.lvl[lvl].tentative = global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off;
		}

		// Token: 0x0400016B RID: 363
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum ctAbstractNum;

		// Token: 0x0400016C RID: 364
		protected global::NPOI.XWPF.UserModel.XWPFNumbering numbering;

		// Token: 0x0400016D RID: 365
		private char[] lvlText = new char[]
		{
			'n',
			'l',
			'u'
		};
	}
}
