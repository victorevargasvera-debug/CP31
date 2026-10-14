using System;
using System.Runtime.Serialization;

namespace System.Data.Entity.Spatial
{
	// Token: 0x02000092 RID: 146
	[global::System.Runtime.Serialization.DataContract]
	public sealed class DbGeographyWellKnownValue
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00010F0A File Offset: 0x0000F10A
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00010F12 File Offset: 0x0000F112
		[global::System.Runtime.Serialization.DataMember(Order = 1, IsRequired = false, EmitDefaultValue = false)]
		public int CoordinateSystemId { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00010F1B File Offset: 0x0000F11B
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00010F23 File Offset: 0x0000F123
		[global::System.Runtime.Serialization.DataMember(Order = 2, IsRequired = false, EmitDefaultValue = false)]
		public string WellKnownText { get; set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00010F2C File Offset: 0x0000F12C
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00010F34 File Offset: 0x0000F134
		[global::System.Runtime.Serialization.DataMember(Order = 3, IsRequired = false, EmitDefaultValue = false)]
		public byte[] WellKnownBinary { get; set; }
	}
}
