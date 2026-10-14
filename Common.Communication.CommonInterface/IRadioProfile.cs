using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001A RID: 26
	public interface IRadioProfile
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000BB RID: 187
		// (set) Token: 0x060000BC RID: 188
		byte[] RadioId { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000BD RID: 189
		string RadioIdString { get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000BE RID: 190
		// (set) Token: 0x060000BF RID: 191
		string PhysicalLocation { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000C0 RID: 192
		// (set) Token: 0x060000C1 RID: 193
		global::Motorola.Common.Communication.CommonUtil.DeviceMode DeviceMode { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000C2 RID: 194
		// (set) Token: 0x060000C3 RID: 195
		string PID { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000C4 RID: 196
		// (set) Token: 0x060000C5 RID: 197
		string VID { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C6 RID: 198
		// (set) Token: 0x060000C7 RID: 199
		string UniqueLocation { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000C8 RID: 200
		// (set) Token: 0x060000C9 RID: 201
		global::Motorola.Common.Communication.RadioType RadioType { get; set; }
	}
}
