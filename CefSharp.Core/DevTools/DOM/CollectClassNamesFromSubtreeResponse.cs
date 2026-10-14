using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002CA RID: 714
	[global::System.Runtime.Serialization.DataContract]
	public class CollectClassNamesFromSubtreeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x00017C16 File Offset: 0x00015E16
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x00017C1E File Offset: 0x00015E1E
		[global::System.Runtime.Serialization.DataMember]
		internal string[] classNames { get; set; }

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x00017C27 File Offset: 0x00015E27
		public string[] ClassNames
		{
			get
			{
				return this.classNames;
			}
		}
	}
}
