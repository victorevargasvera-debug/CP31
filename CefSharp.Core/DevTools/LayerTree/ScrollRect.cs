using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.LayerTree
{
	// Token: 0x02000255 RID: 597
	[global::System.Runtime.Serialization.DataContract]
	public class ScrollRect : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x0001409C File Offset: 0x0001229C
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x000140A4 File Offset: 0x000122A4
		[global::System.Runtime.Serialization.DataMember(Name = "rect", IsRequired = true)]
		public global::CefSharp.DevTools.DOM.Rect Rect { get; set; }

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x000140AD File Offset: 0x000122AD
		// (set) Token: 0x06001271 RID: 4721 RVA: 0x000140C9 File Offset: 0x000122C9
		public global::CefSharp.DevTools.LayerTree.ScrollRectType Type
		{
			get
			{
				return (global::CefSharp.DevTools.LayerTree.ScrollRectType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.LayerTree.ScrollRectType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x000140DC File Offset: 0x000122DC
		// (set) Token: 0x06001273 RID: 4723 RVA: 0x000140E4 File Offset: 0x000122E4
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }
	}
}
