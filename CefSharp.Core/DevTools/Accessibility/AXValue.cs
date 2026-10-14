using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x02000385 RID: 901
	[global::System.Runtime.Serialization.DataContract]
	public class AXValue : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x0001CB2D File Offset: 0x0001AD2D
		// (set) Token: 0x06001B2A RID: 6954 RVA: 0x0001CB49 File Offset: 0x0001AD49
		public global::CefSharp.DevTools.Accessibility.AXValueType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Accessibility.AXValueType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Accessibility.AXValueType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x0001CB5C File Offset: 0x0001AD5C
		// (set) Token: 0x06001B2C RID: 6956 RVA: 0x0001CB64 File Offset: 0x0001AD64
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x0001CB6D File Offset: 0x0001AD6D
		// (set) Token: 0x06001B2E RID: 6958 RVA: 0x0001CB75 File Offset: 0x0001AD75
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = false)]
		public object Value { get; set; }

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x0001CB7E File Offset: 0x0001AD7E
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x0001CB86 File Offset: 0x0001AD86
		[global::System.Runtime.Serialization.DataMember(Name = "relatedNodes", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Accessibility.AXRelatedNode> RelatedNodes { get; set; }

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x0001CB8F File Offset: 0x0001AD8F
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x0001CB97 File Offset: 0x0001AD97
		[global::System.Runtime.Serialization.DataMember(Name = "sources", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Accessibility.AXValueSource> Sources { get; set; }
	}
}
