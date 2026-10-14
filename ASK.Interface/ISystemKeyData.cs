using System;

namespace ASK.Interface
{
	/// <summary>
	/// An Interface to access the System Key data
	/// </summary>
	// Token: 0x02000017 RID: 23
	public interface ISystemKeyData
	{
		/// <summary>
		/// Returns the Unique Identifier of the Key .
		/// </summary>
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000012 RID: 18
		string UuId { get; }

		/// <summary>
		/// Returns the System ID of the key.
		/// </summary>
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000013 RID: 19
		int SystemID { get; }

		/// <summary>
		/// Returns the System ID in Hex format.
		/// </summary>
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000014 RID: 20
		string SystemIDHex { get; }

		/// <summary>
		/// Returns the System Key Type.
		/// </summary>
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000015 RID: 21
		global::ASK.Interface.KeyType Type { get; }

		/// <summary>
		/// Returns true if OtapEnabled flag is set in the key. Otherwise, false.
		/// </summary>
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000016 RID: 22
		bool OtapEnabled { get; }

		/// <summary>
		/// Returns true if WriteProtect flag is set in the key. Otherwise, false.
		/// </summary>
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000017 RID: 23
		bool WriteProtectEnabled { get; }

		/// <summary>
		/// Returns the Serial Number of the iButton from which the key is loaded.
		/// </summary>
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000018 RID: 24
		string iBtnSerialNum { get; }

		/// <summary>
		/// Returns the access level type of the system key.
		/// </summary>
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000019 RID: 25
		global::ASK.Interface.KeyAccessLevelType AccessLevelType { get; }

		/// <summary>
		/// Returns the source of the system key.
		/// </summary>
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600001A RID: 26
		global::ASK.Interface.KeySource Source { get; }
	}
}
