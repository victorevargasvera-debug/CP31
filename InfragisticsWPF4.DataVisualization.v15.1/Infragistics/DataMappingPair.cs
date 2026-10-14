using System;

namespace Infragistics
{
	// Token: 0x02000093 RID: 147
	public sealed class DataMappingPair
	{
		// Token: 0x06000681 RID: 1665 RVA: 0x0001C10B File Offset: 0x0001A30B
		public DataMappingPair()
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001C113 File Offset: 0x0001A313
		public DataMappingPair(string internalName, string externalName)
		{
			this.InternalName = internalName;
			this.ExternalName = externalName;
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0001C129 File Offset: 0x0001A329
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x0001C131 File Offset: 0x0001A331
		public string InternalName { get; set; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x0001C13A File Offset: 0x0001A33A
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x0001C142 File Offset: 0x0001A342
		public string ExternalName { get; set; }
	}
}
