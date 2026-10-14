using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000008 RID: 8
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.PcrMemoryImage))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage))]
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.AstroMemoryImage))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.TetraMemoryImage))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.AstroMemoryImage))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.PcrMemoryImage))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.TetraMemoryImage))]
	[global::System.Serializable]
	public class RadioImage
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000030D0 File Offset: 0x000012D0
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00003180 File Offset: 0x00001380
		[global::System.Runtime.Serialization.DataMember]
		public string FilePath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2059337729;
				if (num != 0)
				{
				}
				num = (short)55987903;
				short num2 = num;
				num = (short)206065343;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1613430784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1266286592;
				if (num != 0)
				{
				}
				return this.<FilePath>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1026924196;
				short num2 = num;
				num = (short)439197348;
				switch (num2 == num)
				{
				}
				num = (short)998178816;
				short num3 = num;
				num = (short)1828061185;
				if (num != 0)
				{
				}
				num = (short)327745536;
				if (num != 0)
				{
				}
				this.<FilePath>k__BackingField = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00003230 File Offset: 0x00001430
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000032DC File Offset: 0x000014DC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType FileType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)948526760;
				short num2 = num;
				num = (short)360341160;
				switch (num2 == num)
				{
				}
				num = (short)917307392;
				short num3 = num;
				num = (short)626720769;
				if (num != 0)
				{
				}
				num = (short)1081802752;
				if (num != 0)
				{
				}
				return this.<FileType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1002700801;
				if (num != 0)
				{
				}
				num = (short)1601152490;
				short num2 = num;
				num = (short)664839658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1236074496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)801898496;
				if (num != 0)
				{
				}
				this.<FileType>k__BackingField = value;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000338C File Offset: 0x0000158C
		public RadioImage()
		{
			this.FilePath = null;
			this.FileType = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.Unknown;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000033B0 File Offset: 0x000015B0
		public RadioImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType, string filePath)
		{
			this.FilePath = filePath;
			this.FileType = fileType;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000033D4 File Offset: 0x000015D4
		public static global::Motorola.Common.Communication.Pba.RadioImage GetImageFromList(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> radioImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			short num = (short)191409015;
			short num2 = num;
			num = (short)454404983;
			switch (num2 == num)
			{
			}
			num = (short)1413087232;
			short num3 = num;
			num = (short)300089345;
			if (num != 0)
			{
			}
			num = (short)459866112;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Pba.RadioImage.a a = new global::Motorola.Common.Communication.Pba.RadioImage.a();
			a.a = fileType;
			return radioImages.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.RadioImage>(a.b));
		}

		// Token: 0x04000015 RID: 21
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Runtime.Serialization.OptionalField]
		public byte[] fileData;

		// Token: 0x0200002B RID: 43
		[global::System.Runtime.Serialization.DataContract]
		public enum UpdateFileType
		{
			// Token: 0x040000DC RID: 220
			[global::System.Runtime.Serialization.EnumMember]
			Unknown,
			// Token: 0x040000DD RID: 221
			[global::System.Runtime.Serialization.EnumMember]
			ACCY,
			// Token: 0x040000DE RID: 222
			[global::System.Runtime.Serialization.EnumMember]
			BOOT,
			// Token: 0x040000DF RID: 223
			[global::System.Runtime.Serialization.EnumMember]
			CPG_APP,
			// Token: 0x040000E0 RID: 224
			[global::System.Runtime.Serialization.EnumMember]
			DSP,
			// Token: 0x040000E1 RID: 225
			[global::System.Runtime.Serialization.EnumMember]
			FLASHSTP,
			// Token: 0x040000E2 RID: 226
			[global::System.Runtime.Serialization.EnumMember]
			HOST,
			// Token: 0x040000E3 RID: 227
			[global::System.Runtime.Serialization.EnumMember]
			MACE,
			// Token: 0x040000E4 RID: 228
			[global::System.Runtime.Serialization.EnumMember]
			OPTION,
			// Token: 0x040000E5 RID: 229
			[global::System.Runtime.Serialization.EnumMember]
			PSDT,
			// Token: 0x040000E6 RID: 230
			[global::System.Runtime.Serialization.EnumMember]
			SEC,
			// Token: 0x040000E7 RID: 231
			[global::System.Runtime.Serialization.EnumMember]
			TUNE,
			// Token: 0x040000E8 RID: 232
			[global::System.Runtime.Serialization.EnumMember]
			UCL,
			// Token: 0x040000E9 RID: 233
			[global::System.Runtime.Serialization.EnumMember]
			TARGET_VERSION,
			// Token: 0x040000EA RID: 234
			[global::System.Runtime.Serialization.EnumMember]
			CONTROLLER_FPGA,
			// Token: 0x040000EB RID: 235
			[global::System.Runtime.Serialization.EnumMember]
			WIRELINE_FPGA,
			// Token: 0x040000EC RID: 236
			[global::System.Runtime.Serialization.EnumMember]
			FILESYSTEM,
			// Token: 0x040000ED RID: 237
			[global::System.Runtime.Serialization.EnumMember]
			FTL,
			// Token: 0x040000EE RID: 238
			[global::System.Runtime.Serialization.EnumMember]
			NAND,
			// Token: 0x040000EF RID: 239
			[global::System.Runtime.Serialization.EnumMember]
			CP_CFS,
			// Token: 0x040000F0 RID: 240
			[global::System.Runtime.Serialization.EnumMember]
			CONFIGURATION,
			// Token: 0x040000F1 RID: 241
			[global::System.Runtime.Serialization.EnumMember]
			KERNEL,
			// Token: 0x040000F2 RID: 242
			[global::System.Runtime.Serialization.EnumMember]
			L2,
			// Token: 0x040000F3 RID: 243
			[global::System.Runtime.Serialization.EnumMember]
			L3,
			// Token: 0x040000F4 RID: 244
			[global::System.Runtime.Serialization.EnumMember]
			RFS,
			// Token: 0x040000F5 RID: 245
			[global::System.Runtime.Serialization.EnumMember]
			APP,
			// Token: 0x040000F6 RID: 246
			[global::System.Runtime.Serialization.EnumMember]
			APP_UTILITIES,
			// Token: 0x040000F7 RID: 247
			[global::System.Runtime.Serialization.EnumMember]
			PARTITION_TABLE,
			// Token: 0x040000F8 RID: 248
			[global::System.Runtime.Serialization.EnumMember]
			CONTROL_HEAD,
			// Token: 0x040000F9 RID: 249
			[global::System.Runtime.Serialization.EnumMember]
			BLUETOOTH_GPS,
			// Token: 0x040000FA RID: 250
			[global::System.Runtime.Serialization.EnumMember]
			DATA_IMAGE,
			// Token: 0x040000FB RID: 251
			[global::System.Runtime.Serialization.EnumMember]
			FILE_CHANGE_LIST,
			// Token: 0x040000FC RID: 252
			[global::System.Runtime.Serialization.EnumMember]
			GLOBAL_MARKER,
			// Token: 0x040000FD RID: 253
			[global::System.Runtime.Serialization.EnumMember]
			FTL_APPSECCFS,
			// Token: 0x040000FE RID: 254
			[global::System.Runtime.Serialization.EnumMember]
			FTL_TUNING,
			// Token: 0x040000FF RID: 255
			[global::System.Runtime.Serialization.EnumMember]
			CPG_UDP,
			// Token: 0x04000100 RID: 256
			[global::System.Runtime.Serialization.EnumMember]
			FLASHTOFILESYSTEM,
			// Token: 0x04000101 RID: 257
			[global::System.Runtime.Serialization.EnumMember]
			SCRIPT_PRE_INIT = 38,
			// Token: 0x04000102 RID: 258
			[global::System.Runtime.Serialization.EnumMember]
			SCRIPT_INIT,
			// Token: 0x04000103 RID: 259
			[global::System.Runtime.Serialization.EnumMember]
			SCRIPT_RC,
			// Token: 0x04000104 RID: 260
			[global::System.Runtime.Serialization.EnumMember]
			SCRIPT_UPGRADE,
			// Token: 0x04000105 RID: 261
			[global::System.Runtime.Serialization.EnumMember]
			DTP_FIRMWARE,
			// Token: 0x04000106 RID: 262
			[global::System.Runtime.Serialization.EnumMember]
			FRU_PA,
			// Token: 0x04000107 RID: 263
			[global::System.Runtime.Serialization.EnumMember]
			FRU_PSU,
			// Token: 0x04000108 RID: 264
			[global::System.Runtime.Serialization.EnumMember]
			FRU_FP,
			// Token: 0x04000109 RID: 265
			[global::System.Runtime.Serialization.EnumMember]
			SCRIPT_OVERWRITE,
			// Token: 0x0400010A RID: 266
			[global::System.Runtime.Serialization.EnumMember]
			PSMARKER,
			// Token: 0x0400010B RID: 267
			[global::System.Runtime.Serialization.EnumMember]
			RAMDOWNLOADER,
			// Token: 0x0400010C RID: 268
			[global::System.Runtime.Serialization.EnumMember]
			CPG_APP_DEFAULT,
			// Token: 0x0400010D RID: 269
			[global::System.Runtime.Serialization.EnumMember]
			CP_CFS_DEFAULT
		}

		// Token: 0x0200002C RID: 44
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600015E RID: 350 RVA: 0x00017F9C File Offset: 0x0001619C
			internal bool b(global::Motorola.Common.Communication.Pba.RadioImage A_0)
			{
				short num = (short)395865783;
				short num2 = num;
				num = (short)2103930551;
				switch (num2 == num)
				{
				}
				num = (short)1378615296;
				short num3 = num;
				num = (short)1516699649;
				if (num != 0)
				{
				}
				num = (short)47579136;
				if (num != 0)
				{
				}
				return A_0.FileType == this.a;
			}

			// Token: 0x0400010E RID: 270
			public global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType a;
		}
	}
}
