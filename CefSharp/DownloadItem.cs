using System;

namespace CefSharp
{
	// Token: 0x02000023 RID: 35
	public sealed class DownloadItem
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002F94 File Offset: 0x00001194
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002F9C File Offset: 0x0000119C
		public bool IsValid { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002FA5 File Offset: 0x000011A5
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002FAD File Offset: 0x000011AD
		public bool IsInProgress { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00002FB6 File Offset: 0x000011B6
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002FBE File Offset: 0x000011BE
		public bool IsComplete { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00002FC7 File Offset: 0x000011C7
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002FCF File Offset: 0x000011CF
		public bool IsCancelled { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00002FD8 File Offset: 0x000011D8
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002FE0 File Offset: 0x000011E0
		public long CurrentSpeed { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00002FE9 File Offset: 0x000011E9
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002FF1 File Offset: 0x000011F1
		public int PercentComplete { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002FFA File Offset: 0x000011FA
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00003002 File Offset: 0x00001202
		public long TotalBytes { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000300B File Offset: 0x0000120B
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00003013 File Offset: 0x00001213
		public long ReceivedBytes { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000301C File Offset: 0x0000121C
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00003024 File Offset: 0x00001224
		public global::System.DateTime? StartTime { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000302D File Offset: 0x0000122D
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00003035 File Offset: 0x00001235
		public global::System.DateTime? EndTime { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000303E File Offset: 0x0000123E
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00003046 File Offset: 0x00001246
		public string FullPath { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000304F File Offset: 0x0000124F
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00003057 File Offset: 0x00001257
		public int Id { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00003060 File Offset: 0x00001260
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00003068 File Offset: 0x00001268
		public string Url { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00003071 File Offset: 0x00001271
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00003079 File Offset: 0x00001279
		public string OriginalUrl { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00003082 File Offset: 0x00001282
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000308A File Offset: 0x0000128A
		public string SuggestedFileName { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00003093 File Offset: 0x00001293
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000309B File Offset: 0x0000129B
		public string ContentDisposition { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000030A4 File Offset: 0x000012A4
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x000030AC File Offset: 0x000012AC
		public string MimeType { get; set; }
	}
}
