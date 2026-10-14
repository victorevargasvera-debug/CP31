using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200032B RID: 811
	[global::System.Runtime.Serialization.DataContract]
	public class SetStyleTextsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x0001A553 File Offset: 0x00018753
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x0001A55B File Offset: 0x0001875B
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSStyle> styles { get; set; }

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x0001A564 File Offset: 0x00018764
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSStyle> Styles
		{
			get
			{
				return this.styles;
			}
		}
	}
}
