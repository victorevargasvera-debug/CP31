using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200031D RID: 797
	[global::System.Runtime.Serialization.DataContract]
	public class GetInlineStylesForNodeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x0001A2A4 File Offset: 0x000184A4
		// (set) Token: 0x06001862 RID: 6242 RVA: 0x0001A2AC File Offset: 0x000184AC
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.CSS.CSSStyle inlineStyle { get; set; }

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001863 RID: 6243 RVA: 0x0001A2B5 File Offset: 0x000184B5
		public global::CefSharp.DevTools.CSS.CSSStyle InlineStyle
		{
			get
			{
				return this.inlineStyle;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x0001A2BD File Offset: 0x000184BD
		// (set) Token: 0x06001865 RID: 6245 RVA: 0x0001A2C5 File Offset: 0x000184C5
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.CSS.CSSStyle attributesStyle { get; set; }

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x0001A2CE File Offset: 0x000184CE
		public global::CefSharp.DevTools.CSS.CSSStyle AttributesStyle
		{
			get
			{
				return this.attributesStyle;
			}
		}
	}
}
