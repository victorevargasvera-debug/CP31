using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x0200007E RID: 126
	[global::System.Runtime.Serialization.DataContract]
	public class BreakLocation : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x000073FB File Offset: 0x000055FB
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00007403 File Offset: 0x00005603
		[global::System.Runtime.Serialization.DataMember(Name = "scriptId", IsRequired = true)]
		public string ScriptId { get; set; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x0000740C File Offset: 0x0000560C
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00007414 File Offset: 0x00005614
		[global::System.Runtime.Serialization.DataMember(Name = "lineNumber", IsRequired = true)]
		public int LineNumber { get; set; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x0000741D File Offset: 0x0000561D
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00007425 File Offset: 0x00005625
		[global::System.Runtime.Serialization.DataMember(Name = "columnNumber", IsRequired = false)]
		public int? ColumnNumber { get; set; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x0000742E File Offset: 0x0000562E
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x0000744A File Offset: 0x0000564A
		public global::CefSharp.DevTools.Debugger.BreakLocationType? Type
		{
			get
			{
				return (global::CefSharp.DevTools.Debugger.BreakLocationType?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Debugger.BreakLocationType?), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0000745D File Offset: 0x0000565D
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00007465 File Offset: 0x00005665
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = false)]
		internal string type { get; set; }
	}
}
