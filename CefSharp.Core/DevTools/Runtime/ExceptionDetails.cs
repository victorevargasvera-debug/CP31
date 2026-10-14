using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000044 RID: 68
	[global::System.Runtime.Serialization.DataContract]
	public class ExceptionDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002BF RID: 703 RVA: 0x000056BD File Offset: 0x000038BD
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x000056C5 File Offset: 0x000038C5
		[global::System.Runtime.Serialization.DataMember(Name = "exceptionId", IsRequired = true)]
		public int ExceptionId { get; set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x000056CE File Offset: 0x000038CE
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x000056D6 File Offset: 0x000038D6
		[global::System.Runtime.Serialization.DataMember(Name = "text", IsRequired = true)]
		public string Text { get; set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x000056DF File Offset: 0x000038DF
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x000056E7 File Offset: 0x000038E7
		[global::System.Runtime.Serialization.DataMember(Name = "lineNumber", IsRequired = true)]
		public int LineNumber { get; set; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x000056F0 File Offset: 0x000038F0
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x000056F8 File Offset: 0x000038F8
		[global::System.Runtime.Serialization.DataMember(Name = "columnNumber", IsRequired = true)]
		public int ColumnNumber { get; set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00005701 File Offset: 0x00003901
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x00005709 File Offset: 0x00003909
		[global::System.Runtime.Serialization.DataMember(Name = "scriptId", IsRequired = false)]
		public string ScriptId { get; set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00005712 File Offset: 0x00003912
		// (set) Token: 0x060002CA RID: 714 RVA: 0x0000571A File Offset: 0x0000391A
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = false)]
		public string Url { get; set; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00005723 File Offset: 0x00003923
		// (set) Token: 0x060002CC RID: 716 RVA: 0x0000572B File Offset: 0x0000392B
		[global::System.Runtime.Serialization.DataMember(Name = "stackTrace", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.StackTrace StackTrace { get; set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00005734 File Offset: 0x00003934
		// (set) Token: 0x060002CE RID: 718 RVA: 0x0000573C File Offset: 0x0000393C
		[global::System.Runtime.Serialization.DataMember(Name = "exception", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.RemoteObject Exception { get; set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00005745 File Offset: 0x00003945
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x0000574D File Offset: 0x0000394D
		[global::System.Runtime.Serialization.DataMember(Name = "executionContextId", IsRequired = false)]
		public int? ExecutionContextId { get; set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00005756 File Offset: 0x00003956
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x0000575E File Offset: 0x0000395E
		[global::System.Runtime.Serialization.DataMember(Name = "exceptionMetaData", IsRequired = false)]
		public object ExceptionMetaData { get; set; }
	}
}
