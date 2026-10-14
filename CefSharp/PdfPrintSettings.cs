using System;

namespace CefSharp
{
	// Token: 0x0200008E RID: 142
	public sealed class PdfPrintSettings
	{
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00003900 File Offset: 0x00001B00
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00003908 File Offset: 0x00001B08
		public bool Landscape { get; set; }

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00003911 File Offset: 0x00001B11
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00003919 File Offset: 0x00001B19
		public bool PrintBackground { get; set; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00003922 File Offset: 0x00001B22
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x0000392A File Offset: 0x00001B2A
		public double Scale { get; set; } = 1.0;

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00003933 File Offset: 0x00001B33
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x0000393B File Offset: 0x00001B3B
		public double PaperWidth { get; set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00003944 File Offset: 0x00001B44
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x0000394C File Offset: 0x00001B4C
		public double PaperHeight { get; set; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00003955 File Offset: 0x00001B55
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0000395D File Offset: 0x00001B5D
		public bool PreferCssPageSize { get; set; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00003966 File Offset: 0x00001B66
		// (set) Token: 0x060003DD RID: 989 RVA: 0x0000396E File Offset: 0x00001B6E
		public global::CefSharp.CefPdfPrintMarginType MarginType { get; set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00003977 File Offset: 0x00001B77
		// (set) Token: 0x060003DF RID: 991 RVA: 0x0000397F File Offset: 0x00001B7F
		public double MarginLeft { get; set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00003988 File Offset: 0x00001B88
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x00003990 File Offset: 0x00001B90
		public double MarginTop { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00003999 File Offset: 0x00001B99
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x000039A1 File Offset: 0x00001BA1
		public double MarginRight { get; set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x000039AA File Offset: 0x00001BAA
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x000039B2 File Offset: 0x00001BB2
		public double MarginBottom { get; set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x000039BB File Offset: 0x00001BBB
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x000039C3 File Offset: 0x00001BC3
		public string PageRanges { get; set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x000039CC File Offset: 0x00001BCC
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x000039D4 File Offset: 0x00001BD4
		public bool DisplayHeaderFooter { get; set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x000039DD File Offset: 0x00001BDD
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x000039E5 File Offset: 0x00001BE5
		public string HeaderTemplate { get; set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x000039EE File Offset: 0x00001BEE
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x000039F6 File Offset: 0x00001BF6
		public string FooterTemplate { get; set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x000039FF File Offset: 0x00001BFF
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00003A07 File Offset: 0x00001C07
		[global::System.Obsolete("Use PrintBackground instead")]
		public bool BackgroundsEnabled
		{
			get
			{
				return this.PrintBackground;
			}
			set
			{
				this.PrintBackground = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00003A10 File Offset: 0x00001C10
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00003A18 File Offset: 0x00001C18
		[global::System.Obsolete("Use DisplayHeaderFooter instead")]
		public bool HeaderFooterEnabled
		{
			get
			{
				return this.DisplayHeaderFooter;
			}
			set
			{
				this.DisplayHeaderFooter = value;
			}
		}
	}
}
