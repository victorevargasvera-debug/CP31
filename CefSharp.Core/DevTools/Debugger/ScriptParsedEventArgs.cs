using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000087 RID: 135
	[global::System.Runtime.Serialization.DataContract]
	public class ScriptParsedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00007729 File Offset: 0x00005929
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00007731 File Offset: 0x00005931
		[global::System.Runtime.Serialization.DataMember(Name = "scriptId", IsRequired = true)]
		public string ScriptId { get; private set; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x0000773A File Offset: 0x0000593A
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00007742 File Offset: 0x00005942
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; private set; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x0000774B File Offset: 0x0000594B
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00007753 File Offset: 0x00005953
		[global::System.Runtime.Serialization.DataMember(Name = "startLine", IsRequired = true)]
		public int StartLine { get; private set; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0000775C File Offset: 0x0000595C
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00007764 File Offset: 0x00005964
		[global::System.Runtime.Serialization.DataMember(Name = "startColumn", IsRequired = true)]
		public int StartColumn { get; private set; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0000776D File Offset: 0x0000596D
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00007775 File Offset: 0x00005975
		[global::System.Runtime.Serialization.DataMember(Name = "endLine", IsRequired = true)]
		public int EndLine { get; private set; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0000777E File Offset: 0x0000597E
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00007786 File Offset: 0x00005986
		[global::System.Runtime.Serialization.DataMember(Name = "endColumn", IsRequired = true)]
		public int EndColumn { get; private set; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0000778F File Offset: 0x0000598F
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00007797 File Offset: 0x00005997
		[global::System.Runtime.Serialization.DataMember(Name = "executionContextId", IsRequired = true)]
		public int ExecutionContextId { get; private set; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x000077A0 File Offset: 0x000059A0
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x000077A8 File Offset: 0x000059A8
		[global::System.Runtime.Serialization.DataMember(Name = "hash", IsRequired = true)]
		public string Hash { get; private set; }

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x000077B1 File Offset: 0x000059B1
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x000077B9 File Offset: 0x000059B9
		[global::System.Runtime.Serialization.DataMember(Name = "executionContextAuxData", IsRequired = false)]
		public object ExecutionContextAuxData { get; private set; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x000077C2 File Offset: 0x000059C2
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x000077CA File Offset: 0x000059CA
		[global::System.Runtime.Serialization.DataMember(Name = "isLiveEdit", IsRequired = false)]
		public bool? IsLiveEdit { get; private set; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x000077D3 File Offset: 0x000059D3
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x000077DB File Offset: 0x000059DB
		[global::System.Runtime.Serialization.DataMember(Name = "sourceMapURL", IsRequired = false)]
		public string SourceMapURL { get; private set; }

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x000077E4 File Offset: 0x000059E4
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x000077EC File Offset: 0x000059EC
		[global::System.Runtime.Serialization.DataMember(Name = "hasSourceURL", IsRequired = false)]
		public bool? HasSourceURL { get; private set; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x000077F5 File Offset: 0x000059F5
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x000077FD File Offset: 0x000059FD
		[global::System.Runtime.Serialization.DataMember(Name = "isModule", IsRequired = false)]
		public bool? IsModule { get; private set; }

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00007806 File Offset: 0x00005A06
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x0000780E File Offset: 0x00005A0E
		[global::System.Runtime.Serialization.DataMember(Name = "length", IsRequired = false)]
		public int? Length { get; private set; }

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00007817 File Offset: 0x00005A17
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x0000781F File Offset: 0x00005A1F
		[global::System.Runtime.Serialization.DataMember(Name = "stackTrace", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.StackTrace StackTrace { get; private set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00007828 File Offset: 0x00005A28
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x00007830 File Offset: 0x00005A30
		[global::System.Runtime.Serialization.DataMember(Name = "codeOffset", IsRequired = false)]
		public int? CodeOffset { get; private set; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00007839 File Offset: 0x00005A39
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00007855 File Offset: 0x00005A55
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

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00007868 File Offset: 0x00005A68
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00007870 File Offset: 0x00005A70
		[global::System.Runtime.Serialization.DataMember(Name = "scriptLanguage", IsRequired = false)]
		internal string scriptLanguage { get; private set; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00007879 File Offset: 0x00005A79
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00007881 File Offset: 0x00005A81
		[global::System.Runtime.Serialization.DataMember(Name = "debugSymbols", IsRequired = false)]
		public global::CefSharp.DevTools.Debugger.DebugSymbols DebugSymbols { get; private set; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0000788A File Offset: 0x00005A8A
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00007892 File Offset: 0x00005A92
		[global::System.Runtime.Serialization.DataMember(Name = "embedderName", IsRequired = false)]
		public string EmbedderName { get; private set; }
	}
}
