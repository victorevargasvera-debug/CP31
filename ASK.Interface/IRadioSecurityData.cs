using System;
using System.Collections.Generic;

namespace ASK.Interface
{
	/// <summary>
	/// An Interface to access radio security data
	/// </summary>
	// Token: 0x02000019 RID: 25
	public interface IRadioSecurityData
	{
		/// <summary>
		/// Returns the System Key protection option of the radio.
		/// </summary>
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600002A RID: 42
		global::ASK.Interface.ProtectionOption ProtectionOptn { get; }

		/// <summary>
		/// Returns the ASK Required status of the radio.
		/// </summary>
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600002B RID: 43
		// (set) Token: 0x0600002C RID: 44
		bool ASKRequired { get; set; }

		/// <summary>
		/// Returns the Owner Advanced Key Type.
		/// </summary>
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600002D RID: 45
		// (set) Token: 0x0600002E RID: 46
		int OwnerAdvancedKeyType { get; set; }

		/// <summary>
		/// Returns the Owner System ID.
		/// </summary>
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600002F RID: 47
		// (set) Token: 0x06000030 RID: 48
		int OwnerSystemID { get; set; }

		/// <summary>
		/// Returns the Owner WACN ID.
		/// </summary>
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000031 RID: 49
		// (set) Token: 0x06000032 RID: 50
		int OwnerWACNID { get; set; }

		/// <summary>
		/// True, if Write Protect flag is set. Otherwise false.
		/// </summary>
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000033 RID: 51
		// (set) Token: 0x06000034 RID: 52
		bool WriteProtected { get; set; }

		/// <summary>
		/// True, if the radio is Conventional-Only. Otherwise false.
		/// </summary>
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000035 RID: 53
		bool IsConventionalOnly { get; }

		/// <summary>
		/// True, if the 800MzBand is enabled. Otherwise false.
		/// </summary>
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000036 RID: 54
		bool Is800MHzBandEnabled { get; }

		/// <summary>
		/// Returns a list of Systems in the radio.
		/// </summary>
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000037 RID: 55
		global::System.Collections.Generic.List<global::ASK.Interface.IAskSystem> Systems { get; }

		/// <summary>
		/// Returns ASK programming history of the radio.
		/// </summary>
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000038 RID: 56
		// (set) Token: 0x06000039 RID: 57
		string AskProgLog { get; set; }
	}
}
