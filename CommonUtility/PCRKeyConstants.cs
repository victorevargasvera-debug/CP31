using System;

namespace CommonUtility
{
	// Token: 0x0200003F RID: 63
	public static class PCRKeyConstants
	{
		// Token: 0x040000CD RID: 205
		public const string InvalidKeyDisplayValue = "∅";

		// Token: 0x040000CE RID: 206
		public const string MAX_OTAP_AND_PRIVACY_KEY_VALUE = "FFFFFFFFFF";

		// Token: 0x040000CF RID: 207
		public const string MAX_SYMMETRIC_KEY_VALUE = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";

		// Token: 0x040000D0 RID: 208
		public const ulong MAX_RAS_KEY_VALUE = 72057594037927935UL;

		// Token: 0x040000D1 RID: 209
		public const string SECURITY_SET = "Security";

		// Token: 0x040000D2 RID: 210
		public const string MNIS_SECURITY_SET = "MNISSecurity";

		// Token: 0x040000D3 RID: 211
		public const string DMR3_SECURITY = "DMR3Security";

		// Token: 0x040000D4 RID: 212
		public const string SYNC_ID = "Id";

		// Token: 0x040000D5 RID: 213
		public const string SYNC_ALIAS = "Alias";

		// Token: 0x040000D6 RID: 214
		public const string SYNC_VALUE = "Value";

		// Token: 0x040000D7 RID: 215
		public const string MAX_PRESHARED_KEY_VALUE = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";

		// Token: 0x040000D8 RID: 216
		public const string MIN_PRESHARED_KEY_VALUE = "00000000000000000000000000000000";

		// Token: 0x02000040 RID: 64
		public static class OTAPKey
		{
			// Token: 0x040000D9 RID: 217
			public const string Sync_ID = "MatrixOTAPKey";

			// Token: 0x040000DA RID: 218
			public const string Set_Name = "OTAPAuthenticationKey";

			// Token: 0x040000DB RID: 219
			public const string Field_Id = "OC_OTAPAUTHKEYID";

			// Token: 0x040000DC RID: 220
			public const string Field_Alias = "OC_OTAPCTMKYALS";

			// Token: 0x040000DD RID: 221
			public const string Field_Value = "OC_OTAPCTMKEY";
		}

		// Token: 0x02000041 RID: 65
		public static class PrivacyKey
		{
			// Token: 0x040000DE RID: 222
			public const string Sync_ID = "MatrixPrivacyKeys";

			// Token: 0x040000DF RID: 223
			public const string Set_Name = "EnhancedPrivacyKeys";

			// Token: 0x040000E0 RID: 224
			public const string Field_Id = "ENHPRI_PKEYID";

			// Token: 0x040000E1 RID: 225
			public const string Field_Alias = "ENHPRI_PKEYALIAS";

			// Token: 0x040000E2 RID: 226
			public const string Field_Value = "ENHPRI_PKEY";

			// Token: 0x040000E3 RID: 227
			public const string Field_PrivacyType = "RC_PRVCYSVCTP";

			// Token: 0x040000E4 RID: 228
			public const string Type_Enhanced = "ENHPRVCY";
		}

		// Token: 0x02000042 RID: 66
		public static class MNISPrivacyKey
		{
			// Token: 0x040000E5 RID: 229
			public const string Sync_ID = "MNISMatrixPrivacyKeys";

			// Token: 0x040000E6 RID: 230
			public const string Set_Name = "MNISEnhancedPrivacyKeys";

			// Token: 0x040000E7 RID: 231
			public const string Field_Id = "MNISENHPRI_PKEYID";

			// Token: 0x040000E8 RID: 232
			public const string Field_Alias = "MNISENHPRI_PKEYALIAS";

			// Token: 0x040000E9 RID: 233
			public const string Field_Value = "MNISENHPRI_PKEY";

			// Token: 0x040000EA RID: 234
			public const string Field_PrivacyType = "MNISENHPRI_PRIVACY_TYPE";

			// Token: 0x040000EB RID: 235
			public const string Type_Enhanced = "ENHPRVCY";
		}

		// Token: 0x02000043 RID: 67
		public static class MNISSymmetricKey
		{
			// Token: 0x040000EC RID: 236
			public const string Sync_ID = "MNISMatrixSymmetricKeys";

			// Token: 0x040000ED RID: 237
			public const string Set_Name = "MNISSymmetricKeys";

			// Token: 0x040000EE RID: 238
			public const string Field_Id = "MNISSYM_PKEYID";

			// Token: 0x040000EF RID: 239
			public const string Field_Alias = "MNISSYM_PKEYALIAS";

			// Token: 0x040000F0 RID: 240
			public const string Field_Value = "MNISSYM_PKEY";
		}

		// Token: 0x02000044 RID: 68
		public static class RASKey
		{
			// Token: 0x040000F1 RID: 241
			public const string Sync_ID = "MatrixRASKeys";

			// Token: 0x040000F2 RID: 242
			public const string Set_Name = "RASKeys";

			// Token: 0x040000F3 RID: 243
			public const string Field_Alias = "RASDATA_RASALIAS";

			// Token: 0x040000F4 RID: 244
			public const string Field_Value = "RASDATA_RASKEY";
		}

		// Token: 0x02000045 RID: 69
		public static class SymmetricKey
		{
			// Token: 0x040000F5 RID: 245
			public const string Sync_ID = "MatrixSymmetricKeys";

			// Token: 0x040000F6 RID: 246
			public const string Set_Name = "AESKeys";

			// Token: 0x040000F7 RID: 247
			public const string Field_Id = "AESPRI_PKEYID";

			// Token: 0x040000F8 RID: 248
			public const string Field_Alias = "AESPRI_PKEYALIAS";

			// Token: 0x040000F9 RID: 249
			public const string Field_Value = "AESPRI_PKEY";
		}

		// Token: 0x02000046 RID: 70
		public static class PreSharedKey
		{
			// Token: 0x040000FA RID: 250
			public const string Sync_ID = "MatrixPreSharedKey";

			// Token: 0x040000FB RID: 251
			public const string Set_Name = "PreSharedKeys";

			// Token: 0x040000FC RID: 252
			public const string Field_Alias = "PSKDATA_PSKID";

			// Token: 0x040000FD RID: 253
			public const string Field_Value = "PSKDATA_PSKDATA";
		}

		// Token: 0x02000047 RID: 71
		public static class DMR3PreSharedKey
		{
			// Token: 0x040000FE RID: 254
			public const string Sync_ID = "DMR3MatrixPreSharedKey";

			// Token: 0x040000FF RID: 255
			public const string Set_Name = "DMR3PreSharedKeys";

			// Token: 0x04000100 RID: 256
			public const string Field_Alias = "DMR3PSKDATA_PSKID";

			// Token: 0x04000101 RID: 257
			public const string Field_Value = "DMR3PSKDATA_PSKDATA";
		}
	}
}
