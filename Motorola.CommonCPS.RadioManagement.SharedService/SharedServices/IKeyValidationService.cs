using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000051 RID: 81
	public interface IKeyValidationService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x0600067F RID: 1663
		bool ValidateAllOTAPAuthorizationKeys(out string error);

		// Token: 0x06000680 RID: 1664
		bool ValidateOTAPAuthorizationKeys(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey> keys, out string error);

		// Token: 0x06000681 RID: 1665
		bool ValidateOTAPAuthorizationKeyId(int? otapAuthenticationKeyID, out string error);

		// Token: 0x06000682 RID: 1666
		bool IsOtapAuthenticationKeyIDValid(int? otapAuthenticationKeyID);

		// Token: 0x06000683 RID: 1667
		bool ValidateOTAPAuthorizationKeyValue(string otapValue, out string err);

		// Token: 0x06000684 RID: 1668
		bool ValidateOTAPAuthorizationKeyAlias(string keyAlias, out string err);

		// Token: 0x06000685 RID: 1669
		bool IsOTAPAuthorizationKeyValueValid(string otapValue);

		// Token: 0x06000686 RID: 1670
		bool ValidatePrivacyKeys(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey> keys, out string err);

		// Token: 0x06000687 RID: 1671
		bool ValidatePrivacyKeyID(int? keyID, out string error);

		// Token: 0x06000688 RID: 1672
		bool IsPrivacyKeyIDValid(int? privacyKeyID);

		// Token: 0x06000689 RID: 1673
		bool IsPrivacyKeyValueValid(string privacyKeyValue);

		// Token: 0x0600068A RID: 1674
		bool ValidatePrivacyKeyAlias(string keyAlias, out string err);

		// Token: 0x0600068B RID: 1675
		bool ValidatePrivacyKeyValue(string keyValue, out string err);

		// Token: 0x0600068C RID: 1676
		bool ValidateRASKeys(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey> keys, out string err);

		// Token: 0x0600068D RID: 1677
		bool IsRASKeyValueValid(string rasKeyValue);

		// Token: 0x0600068E RID: 1678
		bool ValidateRASKeyAlias(string keyAlias, out string err);

		// Token: 0x0600068F RID: 1679
		bool ValidateRASKeyValue(string keyValue, out string err);

		// Token: 0x06000690 RID: 1680
		bool ValidateSymmetricKeys(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey> keys, out string err);

		// Token: 0x06000691 RID: 1681
		bool ValidateSymmetricKeyID(int? symmetricKeyID, out string err);

		// Token: 0x06000692 RID: 1682
		bool IsSymmetricKeyIDValid(int? symmetricKeyID);

		// Token: 0x06000693 RID: 1683
		bool IsSymmetricKeyValueValid(string symmetricKeyValue);

		// Token: 0x06000694 RID: 1684
		bool ValidateSymmetricKeyAlias(string keyAlias, out string err);

		// Token: 0x06000695 RID: 1685
		bool ValidateSymmetricKeyValue(string keyValue, out string err);

		// Token: 0x06000696 RID: 1686
		bool ValidatePreSharedKeys(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey> keys, out string err);

		// Token: 0x06000697 RID: 1687
		bool IsPreSharedKeyValueValid(string psKeyValue);

		// Token: 0x06000698 RID: 1688
		bool ValidatePreSharedKeyAlias(string keyAlias, out string err);

		// Token: 0x06000699 RID: 1689
		bool ValidatePreSharedKeyValue(string keyValue, out string err);
	}
}
