using System;

namespace ASK.Interface
{
	/// <summary>
	/// Defines Hardware Key status.
	/// </summary>
	// Token: 0x02000009 RID: 9
	public enum HardwareKeyStatus
	{
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000CE RID: 206
		Valid = 1,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000CF RID: 207
		Invalid,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000D0 RID: 208
		Expired,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000D1 RID: 209
		Unformatted
	}
}
