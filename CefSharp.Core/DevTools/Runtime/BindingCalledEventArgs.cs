using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000048 RID: 72
	[global::System.Runtime.Serialization.DataContract]
	public class BindingCalledEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00005842 File Offset: 0x00003A42
		// (set) Token: 0x060002EE RID: 750 RVA: 0x0000584A File Offset: 0x00003A4A
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; private set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00005853 File Offset: 0x00003A53
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x0000585B File Offset: 0x00003A5B
		[global::System.Runtime.Serialization.DataMember(Name = "payload", IsRequired = true)]
		public string Payload { get; private set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00005864 File Offset: 0x00003A64
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x0000586C File Offset: 0x00003A6C
		[global::System.Runtime.Serialization.DataMember(Name = "executionContextId", IsRequired = true)]
		public int ExecutionContextId { get; private set; }
	}
}
