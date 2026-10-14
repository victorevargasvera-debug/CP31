using System;

namespace ASK.Interface
{
	/// <summary>
	/// An Interface to validate modification of radio configuration information 
	/// </summary>
	// Token: 0x02000016 RID: 22
	public interface IRadioAccessValidator
	{
		/// <summary>
		/// Validates the radio security configuration to determine if radio write/clone should be allowed.
		/// </summary>
		/// <param name="radSecData">A reference to the current RadioSecurityData in the radio.</param>
		/// <param name="cpgSecurityData">A reference to the RadioSecurityData in the codeplug being written to the radio.</param>
		/// <param name="transportPreference">Indicates the transport preference of the caller.</param>
		/// <param name="bUpdated">true, if the cpgSecurityData object is updated during validation. Otherwise, false.</param> 
		/// <param name="stsMsg">The status message to be returned to the caller.</param>
		/// <param name="isRMCWriteProtectChecked">true, if Write Protected field in RMC Schedule Job is checked. Otherwise, false.</param> 
		/// <param name="writeProtectDevice">true, if current codeplug field DisableWriteProtect is false.</param> 
		/// <param name="isFlashportFromCvnToTrk">true</param>
		/// <param name="isRestoreJob">true</param>
		/// <returns>true, if the validation succeeds. Otherwise, false.</returns>
		// Token: 0x0600000F RID: 15
		bool ValidateAstroRadioWrite(global::ASK.Interface.IRadioSecurityData radSecData, global::ASK.Interface.IRadioSecurityData cpgSecurityData, int transportPreference, out bool bUpdated, out string stsMsg, bool isRMCWriteProtectChecked = false, bool writeProtectDevice = false, bool isFlashportFromCvnToTrk = false, bool isRestoreJob = false);

		/// <summary>
		/// Determines if modification of the "ASK Required" field should be allowed.
		/// </summary>
		/// <param name="ownerAdvKeyType">The Owner System Key type.</param>
		/// <param name="ownerId">The Owner System ID.</param>
		/// <param name="stsMsg">The status message to be returned to the caller.</param>
		/// <param name="askRequired"></param>
		/// <param name="protectOpt">the protection option type</param>
		/// <returns>true, if modification is allowed. Otherwise, false.</returns>
		// Token: 0x06000010 RID: 16
		bool ValidateAstroASKRequirement(int ownerAdvKeyType, int ownerId, global::ASK.Interface.ProtectionOption protectOpt, bool askRequired, out string stsMsg);

		/// <summary>
		/// Determines if modification of Individual/Unit ID should be allowed.
		/// </summary>
		/// <param name="radioSys">A reference to the System object that contains the Individual/Unit ID.</param>
		/// <param name="askRequired">The flag that indicates whether or not ASK is required to modify the radio.</param>
		/// <param name="stsMsg">The status message to be returned to the caller.</param> 
		/// <returns>true, if modification is allowed. Otherwise, false .</returns>
		// Token: 0x06000011 RID: 17
		bool ValidateAstroIndividualId(global::ASK.Interface.IAskSystem radioSys, bool askRequired, out string stsMsg);
	}
}
