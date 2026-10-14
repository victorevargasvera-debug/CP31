using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Tracing
{
	// Token: 0x020000F5 RID: 245
	[global::System.Runtime.Serialization.DataContract]
	public class BufferUsageEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x0000A82C File Offset: 0x00008A2C
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x0000A834 File Offset: 0x00008A34
		[global::System.Runtime.Serialization.DataMember(Name = "percentFull", IsRequired = false)]
		public double? PercentFull { get; private set; }

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x0000A83D File Offset: 0x00008A3D
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x0000A845 File Offset: 0x00008A45
		[global::System.Runtime.Serialization.DataMember(Name = "eventCount", IsRequired = false)]
		public double? EventCount { get; private set; }

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x0000A84E File Offset: 0x00008A4E
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x0000A856 File Offset: 0x00008A56
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = false)]
		public double? Value { get; private set; }
	}
}
