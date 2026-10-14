using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000310 RID: 784
	[global::System.Runtime.Serialization.DataContract]
	public class CSSPositionFallbackRule : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x0001A05F File Offset: 0x0001825F
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x0001A067 File Offset: 0x00018267
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public global::CefSharp.DevTools.CSS.Value Name { get; set; }

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x0001A070 File Offset: 0x00018270
		// (set) Token: 0x06001822 RID: 6178 RVA: 0x0001A078 File Offset: 0x00018278
		[global::System.Runtime.Serialization.DataMember(Name = "tryRules", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSTryRule> TryRules { get; set; }
	}
}
