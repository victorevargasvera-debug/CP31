using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000024 RID: 36
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Flags]
	public enum ProductFamily
	{
		// Token: 0x040000CA RID: 202
		[global::System.Runtime.Serialization.EnumMember]
		None = 0,
		// Token: 0x040000CB RID: 203
		[global::System.Runtime.Serialization.EnumMember]
		AstroRadio = 1,
		// Token: 0x040000CC RID: 204
		[global::System.Runtime.Serialization.EnumMember]
		AMPRadio = 4096,
		// Token: 0x040000CD RID: 205
		[global::System.Runtime.Serialization.EnumMember]
		MatrixRadio = 2,
		// Token: 0x040000CE RID: 206
		[global::System.Runtime.Serialization.EnumMember]
		PhoenixRadio = 4,
		// Token: 0x040000CF RID: 207
		[global::System.Runtime.Serialization.EnumMember]
		ParadiseRadio = 8,
		// Token: 0x040000D0 RID: 208
		[global::System.Runtime.Serialization.EnumMember]
		ParadiseLightRadio = 16,
		// Token: 0x040000D1 RID: 209
		[global::System.Runtime.Serialization.EnumMember]
		ParadiseRepeaterRadio = 32,
		// Token: 0x040000D2 RID: 210
		[global::System.Runtime.Serialization.EnumMember]
		MatrixRepeaterRadio = 64,
		// Token: 0x040000D3 RID: 211
		[global::System.Runtime.Serialization.EnumMember]
		PCRRadio = 458878,
		// Token: 0x040000D4 RID: 212
		[global::System.Runtime.Serialization.EnumMember]
		PBBRadio = 128,
		// Token: 0x040000D5 RID: 213
		[global::System.Runtime.Serialization.EnumMember]
		LegacyProgRadio = 256,
		// Token: 0x040000D6 RID: 214
		[global::System.Runtime.Serialization.EnumMember]
		LegacyAppRadio = 512,
		// Token: 0x040000D7 RID: 215
		[global::System.Runtime.Serialization.EnumMember]
		FrodoProgRadio = 1024,
		// Token: 0x040000D8 RID: 216
		[global::System.Runtime.Serialization.EnumMember]
		FrodoAppRadio = 2048,
		// Token: 0x040000D9 RID: 217
		[global::System.Runtime.Serialization.EnumMember]
		GemstoneBMPProgRadio = 4096,
		// Token: 0x040000DA RID: 218
		[global::System.Runtime.Serialization.EnumMember]
		GemstoneBMPAppRadio = 8192,
		// Token: 0x040000DB RID: 219
		[global::System.Runtime.Serialization.EnumMember]
		GemstoneBMPMassStorageRadio = 16384,
		// Token: 0x040000DC RID: 220
		[global::System.Runtime.Serialization.EnumMember]
		TetraRadio = 32512,
		// Token: 0x040000DD RID: 221
		[global::System.Runtime.Serialization.EnumMember]
		DenaliRadio = 32768,
		// Token: 0x040000DE RID: 222
		[global::System.Runtime.Serialization.EnumMember]
		DMR3Controller = 65536,
		// Token: 0x040000DF RID: 223
		[global::System.Runtime.Serialization.EnumMember]
		MNIS = 131072,
		// Token: 0x040000E0 RID: 224
		[global::System.Runtime.Serialization.EnumMember]
		VRC = 262144,
		// Token: 0x040000E1 RID: 225
		[global::System.Runtime.Serialization.EnumMember]
		Any = 65535
	}
}
