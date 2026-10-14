using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x0200004A RID: 74
	[global::System.Runtime.Serialization.DataContract]
	public class ConsoleAPICalledEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000587D File Offset: 0x00003A7D
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00005899 File Offset: 0x00003A99
		public global::CefSharp.DevTools.Runtime.ConsoleAPICalledType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Runtime.ConsoleAPICalledType)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Runtime.ConsoleAPICalledType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x000058AC File Offset: 0x00003AAC
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x000058B4 File Offset: 0x00003AB4
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; private set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x000058BD File Offset: 0x00003ABD
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x000058C5 File Offset: 0x00003AC5
		[global::System.Runtime.Serialization.DataMember(Name = "args", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Runtime.RemoteObject> Args { get; private set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002FA RID: 762 RVA: 0x000058CE File Offset: 0x00003ACE
		// (set) Token: 0x060002FB RID: 763 RVA: 0x000058D6 File Offset: 0x00003AD6
		[global::System.Runtime.Serialization.DataMember(Name = "executionContextId", IsRequired = true)]
		public int ExecutionContextId { get; private set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002FC RID: 764 RVA: 0x000058DF File Offset: 0x00003ADF
		// (set) Token: 0x060002FD RID: 765 RVA: 0x000058E7 File Offset: 0x00003AE7
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002FE RID: 766 RVA: 0x000058F0 File Offset: 0x00003AF0
		// (set) Token: 0x060002FF RID: 767 RVA: 0x000058F8 File Offset: 0x00003AF8
		[global::System.Runtime.Serialization.DataMember(Name = "stackTrace", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.StackTrace StackTrace { get; private set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00005901 File Offset: 0x00003B01
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00005909 File Offset: 0x00003B09
		[global::System.Runtime.Serialization.DataMember(Name = "context", IsRequired = false)]
		public string Context { get; private set; }
	}
}
