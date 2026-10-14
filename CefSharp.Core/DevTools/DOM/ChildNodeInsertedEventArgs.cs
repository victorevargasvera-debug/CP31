using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002C1 RID: 705
	[global::System.Runtime.Serialization.DataContract]
	public class ChildNodeInsertedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x00017A9C File Offset: 0x00015C9C
		// (set) Token: 0x060015C3 RID: 5571 RVA: 0x00017AA4 File Offset: 0x00015CA4
		[global::System.Runtime.Serialization.DataMember(Name = "parentNodeId", IsRequired = true)]
		public int ParentNodeId { get; private set; }

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x00017AAD File Offset: 0x00015CAD
		// (set) Token: 0x060015C5 RID: 5573 RVA: 0x00017AB5 File Offset: 0x00015CB5
		[global::System.Runtime.Serialization.DataMember(Name = "previousNodeId", IsRequired = true)]
		public int PreviousNodeId { get; private set; }

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x00017ABE File Offset: 0x00015CBE
		// (set) Token: 0x060015C7 RID: 5575 RVA: 0x00017AC6 File Offset: 0x00015CC6
		[global::System.Runtime.Serialization.DataMember(Name = "node", IsRequired = true)]
		public global::CefSharp.DevTools.DOM.Node Node { get; private set; }
	}
}
