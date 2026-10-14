using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200031B RID: 795
	[global::System.Runtime.Serialization.DataContract]
	public class GetBackgroundColorsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x0001A230 File Offset: 0x00018430
		// (set) Token: 0x06001854 RID: 6228 RVA: 0x0001A238 File Offset: 0x00018438
		[global::System.Runtime.Serialization.DataMember]
		internal string[] backgroundColors { get; set; }

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x0001A241 File Offset: 0x00018441
		public string[] BackgroundColors
		{
			get
			{
				return this.backgroundColors;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x0001A249 File Offset: 0x00018449
		// (set) Token: 0x06001857 RID: 6231 RVA: 0x0001A251 File Offset: 0x00018451
		[global::System.Runtime.Serialization.DataMember]
		internal string computedFontSize { get; set; }

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x0001A25A File Offset: 0x0001845A
		public string ComputedFontSize
		{
			get
			{
				return this.computedFontSize;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001859 RID: 6233 RVA: 0x0001A262 File Offset: 0x00018462
		// (set) Token: 0x0600185A RID: 6234 RVA: 0x0001A26A File Offset: 0x0001846A
		[global::System.Runtime.Serialization.DataMember]
		internal string computedFontWeight { get; set; }

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x0001A273 File Offset: 0x00018473
		public string ComputedFontWeight
		{
			get
			{
				return this.computedFontWeight;
			}
		}
	}
}
