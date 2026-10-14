using System;
using System.ComponentModel;

namespace Infragistics
{
	// Token: 0x0200009C RID: 156
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class FontInfo
	{
		// Token: 0x060006CA RID: 1738 RVA: 0x0001E67E File Offset: 0x0001C87E
		public FontInfo()
		{
			this.FontSize = double.NaN;
			this.LineHeight = double.NaN;
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x0001E6A4 File Offset: 0x0001C8A4
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x0001E6AC File Offset: 0x0001C8AC
		public string FontStyle { get; set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x0001E6B5 File Offset: 0x0001C8B5
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x0001E6BD File Offset: 0x0001C8BD
		public string FontVariant { get; set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x0001E6C6 File Offset: 0x0001C8C6
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x0001E6CE File Offset: 0x0001C8CE
		public string FontWeight { get; set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0001E6D7 File Offset: 0x0001C8D7
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x0001E6DF File Offset: 0x0001C8DF
		public double FontSize { get; set; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x0001E6E8 File Offset: 0x0001C8E8
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x0001E6F0 File Offset: 0x0001C8F0
		public double LineHeight { get; set; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x0001E6F9 File Offset: 0x0001C8F9
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x0001E701 File Offset: 0x0001C901
		public string FontFamily { get; set; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0001E70A File Offset: 0x0001C90A
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x0001E712 File Offset: 0x0001C912
		public string FontStretch { get; set; }
	}
}
