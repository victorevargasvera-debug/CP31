using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000086 RID: 134
	[global::System.Runtime.Serialization.DataContract]
	public class ScriptFailedToParseEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x000075D1 File Offset: 0x000057D1
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x000075D9 File Offset: 0x000057D9
		[global::System.Runtime.Serialization.DataMember(Name = "scriptId", IsRequired = true)]
		public string ScriptId { get; private set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x000075E2 File Offset: 0x000057E2
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x000075EA File Offset: 0x000057EA
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; private set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x000075F3 File Offset: 0x000057F3
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x000075FB File Offset: 0x000057FB
		[global::System.Runtime.Serialization.DataMember(Name = "startLine", IsRequired = true)]
		public int StartLine { get; private set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00007604 File Offset: 0x00005804
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x0000760C File Offset: 0x0000580C
		[global::System.Runtime.Serialization.DataMember(Name = "startColumn", IsRequired = true)]
		public int StartColumn { get; private set; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00007615 File Offset: 0x00005815
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x0000761D File Offset: 0x0000581D
		[global::System.Runtime.Serialization.DataMember(Name = "endLine", IsRequired = true)]
		public int EndLine { get; private set; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00007626 File Offset: 0x00005826
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x0000762E File Offset: 0x0000582E
		[global::System.Runtime.Serialization.DataMember(Name = "endColumn", IsRequired = true)]
		public int EndColumn { get; private set; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00007637 File Offset: 0x00005837
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x0000763F File Offset: 0x0000583F
		[global::System.Runtime.Serialization.DataMember(Name = "executionContextId", IsRequired = true)]
		public int ExecutionContextId { get; private set; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00007648 File Offset: 0x00005848
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00007650 File Offset: 0x00005850
		[global::System.Runtime.Serialization.DataMember(Name = "hash", IsRequired = true)]
		public string Hash { get; private set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00007659 File Offset: 0x00005859
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00007661 File Offset: 0x00005861
		[global::System.Runtime.Serialization.DataMember(Name = "executionContextAuxData", IsRequired = false)]
		public object ExecutionContextAuxData { get; private set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x0000766A File Offset: 0x0000586A
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00007672 File Offset: 0x00005872
		[global::System.Runtime.Serialization.DataMember(Name = "sourceMapURL", IsRequired = false)]
		public string SourceMapURL { get; private set; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0000767B File Offset: 0x0000587B
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00007683 File Offset: 0x00005883
		[global::System.Runtime.Serialization.DataMember(Name = "hasSourceURL", IsRequired = false)]
		public bool? HasSourceURL { get; private set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x0000768C File Offset: 0x0000588C
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00007694 File Offset: 0x00005894
		[global::System.Runtime.Serialization.DataMember(Name = "isModule", IsRequired = false)]
		public bool? IsModule { get; private set; }

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x0000769D File Offset: 0x0000589D
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x000076A5 File Offset: 0x000058A5
		[global::System.Runtime.Serialization.DataMember(Name = "length", IsRequired = false)]
		public int? Length { get; private set; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x000076AE File Offset: 0x000058AE
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x000076B6 File Offset: 0x000058B6
		[global::System.Runtime.Serialization.DataMember(Name = "stackTrace", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.StackTrace StackTrace { get; private set; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x000076BF File Offset: 0x000058BF
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x000076C7 File Offset: 0x000058C7
		[global::System.Runtime.Serialization.DataMember(Name = "codeOffset", IsRequired = false)]
		public int? CodeOffset { get; private set; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x000076D0 File Offset: 0x000058D0
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x000076EC File Offset: 0x000058EC
		public global::CefSharp.DevTools.Debugger.ScriptLanguage? ScriptLanguage
		{
			get
			{
				return (global::CefSharp.DevTools.Debugger.ScriptLanguage?)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Debugger.ScriptLanguage?), this.scriptLanguage);
			}
			set
			{
				this.scriptLanguage = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x000076FF File Offset: 0x000058FF
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00007707 File Offset: 0x00005907
		[global::System.Runtime.Serialization.DataMember(Name = "scriptLanguage", IsRequired = false)]
		internal string scriptLanguage { get; private set; }

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00007710 File Offset: 0x00005910
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00007718 File Offset: 0x00005918
		[global::System.Runtime.Serialization.DataMember(Name = "embedderName", IsRequired = false)]
		public string EmbedderName { get; private set; }
	}
}
