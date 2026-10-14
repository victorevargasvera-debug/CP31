using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000307 RID: 775
	[global::System.Runtime.Serialization.DataContract]
	public class CSSContainerQuery : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00019CE2 File Offset: 0x00017EE2
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x00019CEA File Offset: 0x00017EEA
		[global::System.Runtime.Serialization.DataMember(Name = "text", IsRequired = true)]
		public string Text { get; set; }

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x00019CF3 File Offset: 0x00017EF3
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x00019CFB File Offset: 0x00017EFB
		[global::System.Runtime.Serialization.DataMember(Name = "range", IsRequired = false)]
		public global::CefSharp.DevTools.CSS.SourceRange Range { get; set; }

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x00019D04 File Offset: 0x00017F04
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x00019D0C File Offset: 0x00017F0C
		[global::System.Runtime.Serialization.DataMember(Name = "styleSheetId", IsRequired = false)]
		public string StyleSheetId { get; set; }

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x00019D15 File Offset: 0x00017F15
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x00019D1D File Offset: 0x00017F1D
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = false)]
		public string Name { get; set; }

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x00019D26 File Offset: 0x00017F26
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x00019D42 File Offset: 0x00017F42
		public global::CefSharp.DevTools.DOM.PhysicalAxes? PhysicalAxes
		{
			get
			{
				return (global::CefSharp.DevTools.DOM.PhysicalAxes?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.DOM.PhysicalAxes?), this.physicalAxes);
			}
			set
			{
				this.physicalAxes = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x00019D55 File Offset: 0x00017F55
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x00019D5D File Offset: 0x00017F5D
		[global::System.Runtime.Serialization.DataMember(Name = "physicalAxes", IsRequired = false)]
		internal string physicalAxes { get; set; }

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x00019D66 File Offset: 0x00017F66
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x00019D82 File Offset: 0x00017F82
		public global::CefSharp.DevTools.DOM.LogicalAxes? LogicalAxes
		{
			get
			{
				return (global::CefSharp.DevTools.DOM.LogicalAxes?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.DOM.LogicalAxes?), this.logicalAxes);
			}
			set
			{
				this.logicalAxes = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x00019D95 File Offset: 0x00017F95
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x00019D9D File Offset: 0x00017F9D
		[global::System.Runtime.Serialization.DataMember(Name = "logicalAxes", IsRequired = false)]
		internal string logicalAxes { get; set; }
	}
}
