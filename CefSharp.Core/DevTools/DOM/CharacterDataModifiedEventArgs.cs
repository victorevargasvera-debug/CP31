using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002BF RID: 703
	[global::System.Runtime.Serialization.DataContract]
	public class CharacterDataModifiedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x00017A48 File Offset: 0x00015C48
		// (set) Token: 0x060015B9 RID: 5561 RVA: 0x00017A50 File Offset: 0x00015C50
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public int NodeId { get; private set; }

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x00017A59 File Offset: 0x00015C59
		// (set) Token: 0x060015BB RID: 5563 RVA: 0x00017A61 File Offset: 0x00015C61
		[global::System.Runtime.Serialization.DataMember(Name = "characterData", IsRequired = true)]
		public string CharacterData { get; private set; }
	}
}
