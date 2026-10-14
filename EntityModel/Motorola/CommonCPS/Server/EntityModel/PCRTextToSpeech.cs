using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000086 RID: 134
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PCRTextToSpeech : global::Motorola.CommonCPS.Server.EntityModel.PCRPackage
	{
		// Token: 0x06000A38 RID: 2616 RVA: 0x0006E514 File Offset: 0x0006C714
		public PCRTextToSpeech()
		{
			this.MatrixTemplates = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate>();
			this.MatrixCodeplugs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug>();
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0006E540 File Offset: 0x0006C740
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x0006E5F4 File Offset: 0x0006C7F4
		[global::System.Runtime.Serialization.DataMember]
		public string LanguageID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1624840137;
				short num2 = num;
				num = (short)1901402057;
				switch (num2 == num)
				{
				}
				num = (short)171180032;
				short num3 = num;
				num = (short)1464139777;
				if (num != 0)
				{
				}
				num = (short)1403125760;
				if (num != 0)
				{
				}
				return this.<LanguageID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)647479895;
				short num2 = num;
				num = (short)1504887383;
				switch (num2 == num)
				{
				}
				num = (short)513474560;
				short num3 = num;
				num = (short)626327553;
				if (num != 0)
				{
				}
				num = (short)1851457536;
				if (num != 0)
				{
				}
				this.<LanguageID>k__BackingField = value;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0006E6A4 File Offset: 0x0006C8A4
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x0006E750 File Offset: 0x0006C950
		[global::System.Runtime.Serialization.DataMember]
		public string PackageVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1230224492;
				short num2 = num;
				num = (short)1623768172;
				switch (num2 == num)
				{
				}
				num = (short)1086128128;
				short num3 = num;
				num = (short)697171969;
				if (num != 0)
				{
				}
				num = (short)2126315520;
				if (num != 0)
				{
				}
				return this.<PackageVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)207683585;
				if (num != 0)
				{
				}
				num = (short)593550771;
				short num2 = num;
				num = (short)46194099;
				switch (num2 == num)
				{
				default:
				{
					num = (short)140378112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1021575168;
				if (num != 0)
				{
				}
				this.<PackageVersion>k__BackingField = value;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0006E800 File Offset: 0x0006CA00
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x0006E8AC File Offset: 0x0006CAAC
		[global::System.Runtime.Serialization.DataMember]
		public string MajorVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)733020515;
				short num2 = num;
				num = (short)1265238371;
				switch (num2 == num)
				{
				}
				num = (short)248774656;
				short num3 = num;
				num = (short)792526849;
				if (num != 0)
				{
				}
				num = (short)360644608;
				if (num != 0)
				{
				}
				return this.<MajorVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1225779451;
				short num2 = num;
				num = (short)179824891;
				switch (num2 == num)
				{
				}
				num = (short)1128857600;
				short num3 = num;
				num = (short)588382209;
				if (num != 0)
				{
				}
				num = (short)8192000;
				if (num != 0)
				{
				}
				this.<MajorVersion>k__BackingField = value;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0006E95C File Offset: 0x0006CB5C
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x0006EA0C File Offset: 0x0006CC0C
		[global::System.Runtime.Serialization.DataMember]
		public string MinorVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)222625793;
				if (num != 0)
				{
				}
				num = (short)1146909274;
				short num2 = num;
				num = (short)1289843290;
				switch (num2 == num)
				{
				default:
				{
					num = (short)155123712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1660616704;
				if (num != 0)
				{
				}
				return this.<MinorVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1532462277;
				short num2 = num;
				num = (short)1043432645;
				switch (num2 == num)
				{
				}
				num = (short)1923153920;
				short num3 = num;
				num = (short)1591869441;
				if (num != 0)
				{
				}
				num = (short)1787428864;
				if (num != 0)
				{
				}
				this.<MinorVersion>k__BackingField = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0006EAC0 File Offset: 0x0006CCC0
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x0006EB6C File Offset: 0x0006CD6C
		[global::System.Runtime.Serialization.DataMember]
		public int? FileSize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2126046486;
				short num2 = num;
				num = (short)1074652438;
				switch (num2 == num)
				{
				}
				num = (short)1522008064;
				short num3 = num;
				num = (short)1181679616;
				if (num != 0)
				{
				}
				num = (short)538443777;
				if (num != 0)
				{
				}
				return this.<FileSize>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1176436737;
				if (num != 0)
				{
				}
				num = (short)1089872874;
				short num2 = num;
				num = (short)2146771946;
				switch (num2 == num)
				{
				default:
				{
					num = (short)100990976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1525219328;
				if (num != 0)
				{
				}
				this.<FileSize>k__BackingField = value;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x0006EC1C File Offset: 0x0006CE1C
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x0006ECC8 File Offset: 0x0006CEC8
		[global::System.Runtime.Serialization.DataMember]
		public string PackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1030629186;
				short num2 = num;
				num = (short)561915714;
				switch (num2 == num)
				{
				}
				num = (short)830799872;
				short num3 = num;
				num = (short)1304363009;
				if (num != 0)
				{
				}
				num = (short)1088290816;
				if (num != 0)
				{
				}
				return this.<PackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)648887567;
				short num2 = num;
				num = (short)1591622927;
				switch (num2 == num)
				{
				}
				num = (short)819527680;
				short num3 = num;
				num = (short)990707713;
				if (num != 0)
				{
				}
				num = (short)17104896;
				if (num != 0)
				{
				}
				this.<PackageName>k__BackingField = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x0006ED78 File Offset: 0x0006CF78
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x0006EE28 File Offset: 0x0006D028
		[global::System.Runtime.Serialization.DataMember]
		public string SpeakerName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1291396494;
				short num2 = num;
				num = (short)739124622;
				switch (num2 == num)
				{
				}
				num = (short)1456340992;
				short num3 = num;
				num = (short)1671102464;
				if (num != 0)
				{
				}
				num = (short)1790967809;
				if (num != 0)
				{
				}
				return this.<SpeakerName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1042939905;
				if (num != 0)
				{
				}
				num = (short)963435070;
				short num2 = num;
				num = (short)123525694;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1286471680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1707540480;
				if (num != 0)
				{
				}
				this.<SpeakerName>k__BackingField = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0006EED8 File Offset: 0x0006D0D8
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x0006EF88 File Offset: 0x0006D188
		[global::System.Runtime.Serialization.DataMember]
		public byte VoiceGender
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1059978869;
				short num2 = num;
				num = (short)494796405;
				switch (num2 == num)
				{
				}
				num = (short)376242176;
				short num3 = num;
				num = (short)1711144961;
				if (num != 0)
				{
				}
				num = (short)687865856;
				if (num != 0)
				{
				}
				return this.<VoiceGender>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1744830326;
				short num2 = num;
				num = (short)1695350646;
				switch (num2 == num)
				{
				}
				num = (short)1139736576;
				short num3 = num;
				num = (short)952303616;
				if (num != 0)
				{
				}
				num = (short)1678770177;
				if (num != 0)
				{
				}
				this.<VoiceGender>k__BackingField = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x0006F038 File Offset: 0x0006D238
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x0006F0E8 File Offset: 0x0006D2E8
		[global::System.Runtime.Serialization.DataMember]
		public int? ReferenceCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)910055033;
				short num2 = num;
				num = (short)135485049;
				switch (num2 == num)
				{
				}
				num = (short)225181696;
				short num3 = num;
				num = (short)179372033;
				if (num != 0)
				{
				}
				num = (short)49020928;
				if (num != 0)
				{
				}
				return this.<ReferenceCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1998237244;
				short num2 = num;
				num = (short)1162325564;
				switch (num2 == num)
				{
				}
				num = (short)1776615424;
				short num3 = num;
				num = (short)37748737;
				if (num != 0)
				{
				}
				num = (short)1476001792;
				if (num != 0)
				{
				}
				this.<ReferenceCount>k__BackingField = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x0006F198 File Offset: 0x0006D398
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x0006F248 File Offset: 0x0006D448
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate> MatrixTemplates
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1839615728;
				short num2 = num;
				num = (short)696471280;
				switch (num2 == num)
				{
				}
				num = (short)1109786624;
				short num3 = num;
				num = (short)2046623744;
				if (num != 0)
				{
				}
				num = (short)611254273;
				if (num != 0)
				{
				}
				return this.<MatrixTemplates>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)692780854;
				short num2 = num;
				num = (short)1583939382;
				switch (num2 == num)
				{
				}
				num = (short)1706229760;
				short num3 = num;
				num = (short)1165492225;
				if (num != 0)
				{
				}
				num = (short)2045575168;
				if (num != 0)
				{
				}
				this.<MatrixTemplates>k__BackingField = value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0006F2FC File Offset: 0x0006D4FC
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x0006F3AC File Offset: 0x0006D5AC
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug> MatrixCodeplugs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1758938438;
				short num2 = num;
				num = (short)1052525894;
				switch (num2 == num)
				{
				}
				num = (short)1673789440;
				short num3 = num;
				num = (short)311623681;
				if (num != 0)
				{
				}
				num = (short)1178664960;
				if (num != 0)
				{
				}
				return this.<MatrixCodeplugs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)156962172;
				short num2 = num;
				num = (short)1923747196;
				switch (num2 == num)
				{
				}
				num = (short)1287454720;
				short num3 = num;
				num = (short)119734273;
				if (num != 0)
				{
				}
				num = (short)393936896;
				if (num != 0)
				{
				}
				this.<MatrixCodeplugs>k__BackingField = value;
			}
		}
	}
}
