using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Inspector
{
	// Token: 0x02000262 RID: 610
	[global::System.Runtime.Serialization.DataContract]
	public class DetachedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x00014680 File Offset: 0x00012880
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x00014688 File Offset: 0x00012888
		[global::System.Runtime.Serialization.DataMember(Name = "reason", IsRequired = true)]
		public string Reason { get; private set; }
	}
}
