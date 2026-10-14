using System;

namespace ASK.Interface
{
	/// <summary>
	/// An Interface to access a radio System
	/// </summary>
	// Token: 0x02000015 RID: 21
	public interface IAskSystem
	{
		/// <summary>
		/// Returns the name of the system
		/// </summary>
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5
		string Name { get; }

		/// <summary>
		/// Returns the System ID of the system
		/// </summary>
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6
		int SystemId { get; }

		/// <summary>
		/// Returns the Wacn ID of the system
		/// </summary>
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7
		int WacnId { get; }

		/// <summary>
		/// Returns the Radio ID of the system
		/// </summary>
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8
		int RadioId { get; }

		/// <summary>
		/// Returns the System Type
		/// </summary>
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000009 RID: 9
		global::ASK.Interface.AskSystemType SystemType { get; }

		/// <summary>
		/// Returns the System Sub-type
		/// </summary>
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000A RID: 10
		global::ASK.Interface.AskSystemSubType SystemSubType { get; }

		/// <summary>
		/// Returns the Coverage Type of the system
		/// </summary>
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000B RID: 11
		global::ASK.Interface.AskTrkSysCoverageType CoverageType { get; }

		/// <summary>
		/// Returns the type System Key used by system
		/// </summary>
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000C RID: 12
		global::ASK.Interface.KeyType SystemKeyType { get; }

		/// <summary>
		/// Indicates whether or not ExpandedMDCIDRange is used by the system
		/// </summary>
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000D RID: 13
		bool ExpandedMDCIDRange { get; }

		/// <summary>
		/// Indicates whether or not ShuffledBandPlan is enabled in the system
		/// </summary>
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600000E RID: 14
		bool ShuffledBandPlan { get; }
	}
}
