using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000319 RID: 793
	[global::System.Runtime.Serialization.DataContract]
	public class CollectClassNamesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x0001A1EE File Offset: 0x000183EE
		// (set) Token: 0x0600184C RID: 6220 RVA: 0x0001A1F6 File Offset: 0x000183F6
		[global::System.Runtime.Serialization.DataMember]
		internal string[] classNames { get; set; }

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x0001A1FF File Offset: 0x000183FF
		public string[] ClassNames
		{
			get
			{
				return this.classNames;
			}
		}
	}
}
