using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x02000384 RID: 900
	[global::System.Runtime.Serialization.DataContract]
	public class AXProperty : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06001B22 RID: 6946 RVA: 0x0001CAD4 File Offset: 0x0001ACD4
		// (set) Token: 0x06001B23 RID: 6947 RVA: 0x0001CAF0 File Offset: 0x0001ACF0
		public global::CefSharp.DevTools.Accessibility.AXPropertyName Name
		{
			get
			{
				return (global::CefSharp.DevTools.Accessibility.AXPropertyName)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Accessibility.AXPropertyName), this.name);
			}
			set
			{
				this.name = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x0001CB03 File Offset: 0x0001AD03
		// (set) Token: 0x06001B25 RID: 6949 RVA: 0x0001CB0B File Offset: 0x0001AD0B
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		internal string name { get; set; }

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x0001CB14 File Offset: 0x0001AD14
		// (set) Token: 0x06001B27 RID: 6951 RVA: 0x0001CB1C File Offset: 0x0001AD1C
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public global::CefSharp.DevTools.Accessibility.AXValue Value { get; set; }
	}
}
