using System;

namespace CefSharp
{
	// Token: 0x0200009C RID: 156
	public class UrlParts
	{
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00006C81 File Offset: 0x00004E81
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00006C89 File Offset: 0x00004E89
		public string Spec { get; set; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00006C92 File Offset: 0x00004E92
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00006C9A File Offset: 0x00004E9A
		public string Scheme { get; set; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00006CA3 File Offset: 0x00004EA3
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00006CAB File Offset: 0x00004EAB
		public string Username { get; set; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00006CB4 File Offset: 0x00004EB4
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00006CBC File Offset: 0x00004EBC
		public string Password { get; set; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00006CC5 File Offset: 0x00004EC5
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00006CCD File Offset: 0x00004ECD
		public string Host { get; set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00006CD6 File Offset: 0x00004ED6
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00006CDE File Offset: 0x00004EDE
		public int? Port { get; set; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00006CE7 File Offset: 0x00004EE7
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00006CEF File Offset: 0x00004EEF
		public string Origin { get; set; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00006CF8 File Offset: 0x00004EF8
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x00006D00 File Offset: 0x00004F00
		public string Path { get; set; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00006D09 File Offset: 0x00004F09
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00006D11 File Offset: 0x00004F11
		public string Query { get; set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00006D1A File Offset: 0x00004F1A
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00006D22 File Offset: 0x00004F22
		public string Fragment { get; set; }
	}
}
