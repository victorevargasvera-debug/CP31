using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000042 RID: 66
	[global::System.Runtime.Serialization.DataContract]
	public class CallArgument : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00005625 File Offset: 0x00003825
		// (set) Token: 0x060002AE RID: 686 RVA: 0x0000562D File Offset: 0x0000382D
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = false)]
		public object Value { get; set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00005636 File Offset: 0x00003836
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x0000563E File Offset: 0x0000383E
		[global::System.Runtime.Serialization.DataMember(Name = "unserializableValue", IsRequired = false)]
		public string UnserializableValue { get; set; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00005647 File Offset: 0x00003847
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x0000564F File Offset: 0x0000384F
		[global::System.Runtime.Serialization.DataMember(Name = "objectId", IsRequired = false)]
		public string ObjectId { get; set; }
	}
}
