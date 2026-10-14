using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000043 RID: 67
	[global::System.Runtime.Serialization.DataContract]
	public class ExecutionContextDescription : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00005660 File Offset: 0x00003860
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00005668 File Offset: 0x00003868
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public int Id { get; set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00005671 File Offset: 0x00003871
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00005679 File Offset: 0x00003879
		[global::System.Runtime.Serialization.DataMember(Name = "origin", IsRequired = true)]
		public string Origin { get; set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00005682 File Offset: 0x00003882
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0000568A File Offset: 0x0000388A
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00005693 File Offset: 0x00003893
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0000569B File Offset: 0x0000389B
		[global::System.Runtime.Serialization.DataMember(Name = "uniqueId", IsRequired = true)]
		public string UniqueId { get; set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002BC RID: 700 RVA: 0x000056A4 File Offset: 0x000038A4
		// (set) Token: 0x060002BD RID: 701 RVA: 0x000056AC File Offset: 0x000038AC
		[global::System.Runtime.Serialization.DataMember(Name = "auxData", IsRequired = false)]
		public object AuxData { get; set; }
	}
}
