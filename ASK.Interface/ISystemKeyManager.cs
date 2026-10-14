using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ASK.Interface
{
	/// <summary>
	/// An Interface to load and access permissions granted by the loaded system keys
	/// </summary>
	// Token: 0x02000018 RID: 24
	public interface ISystemKeyManager
	{
		/// <summary>
		/// Loads all System Key permissions granted to the user.
		/// </summary>
		/// <param name="userSysKeyPermissions">The list of SystemKeyPermissions granted to the user.&gt; </param>
		/// <returns>The number of system keys loaded.</returns>
		// Token: 0x0600001B RID: 27
		int LoadUserKeys(global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> userSysKeyPermissions);

		/// <summary>
		/// Add System Key permissions to list of permissions granted to the user.
		/// </summary>
		/// <param name="userSysKeyPermissions">The list of SystemKeyPermissions granted to the user.&gt; </param>
		/// <returns></returns>
		// Token: 0x0600001C RID: 28
		void AddUserKeys(global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> userSysKeyPermissions);

		/// <summary>
		/// Clear all System Key permissions from the list.
		/// </summary>
		/// <returns></returns>
		// Token: 0x0600001D RID: 29
		void ClearUserKeys();

		/// <summary>
		/// Clear all System Key permissions except the default.
		/// </summary>
		/// <returns></returns>
		// Token: 0x0600001E RID: 30
		void ClearNonDefaultUserKeys();

		/// <summary>
		/// Returns a collection of all loaded System Keys.
		/// </summary>
		/// <remarks>The collection will be refreshed whenever the LoadUserKeys method is invoked.</remarks>
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600001F RID: 31
		global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::ASK.Interface.ISystemKeyData> LoadedUserSystemKeys { get; }

		/// <summary>
		/// Returns a collection of all loaded Advanced System Keys.
		/// </summary>
		/// <remarks>The collection will be refreshed whenever the LoadUserKeys method is invoked.</remarks>
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000020 RID: 32
		global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::ASK.Interface.ISystemKeyData> LoadedASKs { get; }

		/// <summary>
		/// Loads all software keys from a default directory path.
		/// </summary>
		/// <param name="path">The path to load software keys from.</param>
		/// <returns></returns>
		// Token: 0x06000021 RID: 33
		int LoadKeysFromPath(string path);

		/// <summary>
		/// Checks if a system key of a given System ID and System Type is loaded.
		/// </summary>
		/// <param name="systemId">System ID</param>
		/// <param name="keyType">The key type to check.</param>
		/// <param name="bAskOnly">True, if only ASK should be checked.</param>
		/// <returns>True, if loaded. Otherwise, false.</returns>
		// Token: 0x06000022 RID: 34
		bool IsSystemKeyLoaded(int systemId, global::ASK.Interface.KeyType keyType, bool bAskOnly);

		/// <summary>
		/// Checks if an unlimited Advanced System Key of a given System ID and System Type is loaded.
		/// </summary>
		/// <param name="systemId">System ID</param>
		/// <param name="keyType">The key type to check.</param>
		/// <param name="bSearchWriteProtectOnly">True, if only unlimited ASK with Write Protect enabled should be checked.</param>
		/// <returns>True, if loaded. Otherwise, false.</returns>
		// Token: 0x06000023 RID: 35
		bool IsUnLimitedASKLoaded(int systemId, global::ASK.Interface.KeyType keyType, bool bSearchWriteProtectOnly);

		/// <summary>
		/// Checks if any unlimited Advanced System Key is loaded.
		/// </summary>        
		/// <returns>True, if loaded. Otherwise, false.</returns>
		// Token: 0x06000024 RID: 36
		bool IsAnyUnLimitedASKLoaded();

		/// <summary>
		/// Checks if editability access is granted to a field by the loaded system key.
		/// </summary>
		/// <param name="id">The ID of the field in the key layout.</param>
		/// <param name="type">The key type to check.</param>
		/// <param name="sysId">The ID of the trunking system the field belongs to.</param>
		/// <param name="bAskOnly">True, if only ASK should be checked.</param>
		/// <returns>True, if the field is editable. Otherwise, false.</returns>
		// Token: 0x06000025 RID: 37
		bool IsFieldEditable(global::ASK.Interface.AccessElementIDType id, global::ASK.Interface.KeyType type, int sysId, bool bAskOnly);

		/// <summary>
		/// Checks if a field's value is within the range granted by the loaded system key.
		/// </summary>
		/// <param name="id">The ID of the field in the key layout.</param>
		/// <param name="type">The key type to check.</param>
		/// <param name="sysId">The ID of the trunking system the field belongs to.</param>
		/// <param name="value">The field's value to validate.</param>
		/// <param name="bAskOnly">True, if only ASK should be checked.</param>
		/// <returns>True, if valid. Otherwise, false.</returns>
		// Token: 0x06000026 RID: 38
		bool IsRangeValueValid(global::ASK.Interface.AccessElementIDType id, global::ASK.Interface.KeyType type, int sysId, int value, bool bAskOnly);

		/// <summary>
		/// Checks if the field is a protected range field.
		/// </summary>
		/// <param name="id">The ID of the field in the key layout.</param>
		/// <returns>True, if the field is a protected range field. Otherwise, false.</returns>
		// Token: 0x06000027 RID: 39
		bool IsRangeField(global::ASK.Interface.AccessElementIDType id);

		/// <summary>
		/// Reads all hardware keys attached to the host machine
		/// </summary>
		/// <returns>List of SystemKeyPermissionData </returns>
		/// <remarks>Only hardware key containing ASK will be read.</remarks>
		// Token: 0x06000028 RID: 40
		global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> ReadHardwareKeys();

		/// <summary>
		/// Reads the system keys in the given list of Legacy Software Key files
		/// </summary>
		/// <param name="keyFileNames">Full path of the key files to read.</param>
		/// <returns>List of SystemKeyPermissionData (one item for each Legacy Software key file)</returns>
		// Token: 0x06000029 RID: 41
		global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> ReadLegacySoftwareKeys(string[] keyFileNames);
	}
}
