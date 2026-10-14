using System;

namespace ASK.Interface
{
	/// <summary>
	/// Enumerates the supported Comms Operations.
	/// </summary>
	// Token: 0x02000014 RID: 20
	public enum ASK_COMMS_OP
	{
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000102 RID: 258
		USB_READ_WRITE = 1,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000103 RID: 259
		USB_CLONE,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000104 RID: 260
		OTAP_READ_WRITE = 8,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000105 RID: 261
		OTAP_CLONE = 10,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000106 RID: 262
		BLUETOOTH_READ_WRITE = 16,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000107 RID: 263
		BLUETOOTH_CLONE = 32
	}
}
