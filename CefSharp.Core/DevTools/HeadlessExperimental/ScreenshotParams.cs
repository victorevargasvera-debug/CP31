using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.HeadlessExperimental
{
	// Token: 0x02000280 RID: 640
	[global::System.Runtime.Serialization.DataContract]
	public class ScreenshotParams : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x0001594C File Offset: 0x00013B4C
		// (set) Token: 0x0600137C RID: 4988 RVA: 0x00015968 File Offset: 0x00013B68
		public global::CefSharp.DevTools.HeadlessExperimental.ScreenshotParamsFormat? Format
		{
			get
			{
				return (global::CefSharp.DevTools.HeadlessExperimental.ScreenshotParamsFormat?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.HeadlessExperimental.ScreenshotParamsFormat?), this.format);
			}
			set
			{
				this.format = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x0001597B File Offset: 0x00013B7B
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x00015983 File Offset: 0x00013B83
		[global::System.Runtime.Serialization.DataMember(Name = "format", IsRequired = false)]
		internal string format { get; set; }

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x0001598C File Offset: 0x00013B8C
		// (set) Token: 0x06001380 RID: 4992 RVA: 0x00015994 File Offset: 0x00013B94
		[global::System.Runtime.Serialization.DataMember(Name = "quality", IsRequired = false)]
		public int? Quality { get; set; }

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x0001599D File Offset: 0x00013B9D
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x000159A5 File Offset: 0x00013BA5
		[global::System.Runtime.Serialization.DataMember(Name = "optimizeForSpeed", IsRequired = false)]
		public bool? OptimizeForSpeed { get; set; }
	}
}
