using System;

namespace ASK.Interface
{
	/// <summary>
	/// Enumerates the supported Trunking System Coverage types.
	/// </summary>
	// Token: 0x02000013 RID: 19
	public enum AskTrkSysCoverageType
	{
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000FC RID: 252
		Disabled,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000FD RID: 253
		SmartZone = 3,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000FE RID: 254
		SmartZoneOmniLink = 7,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000FF RID: 255
		IntraWACNRoaming = 5,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000100 RID: 256
		InterWACNRoaming
	}
}
