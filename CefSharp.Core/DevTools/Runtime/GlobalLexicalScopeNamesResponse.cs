using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000057 RID: 87
	[global::System.Runtime.Serialization.DataContract]
	public class GlobalLexicalScopeNamesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00005B9B File Offset: 0x00003D9B
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00005BA3 File Offset: 0x00003DA3
		[global::System.Runtime.Serialization.DataMember]
		internal string[] names { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00005BAC File Offset: 0x00003DAC
		public string[] Names
		{
			get
			{
				return this.names;
			}
		}
	}
}
