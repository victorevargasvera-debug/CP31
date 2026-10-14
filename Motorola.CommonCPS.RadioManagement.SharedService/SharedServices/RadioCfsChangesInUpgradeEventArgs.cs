using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000AA RID: 170
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class RadioCfsChangesInUpgradeEventArgs : global::System.EventArgs
	{
		// Token: 0x06000A2B RID: 2603 RVA: 0x00077824 File Offset: 0x00075A24
		public RadioCfsChangesInUpgradeEventArgs(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug, global::Motorola.CommonCPS.Server.EntityModel.Template template)
		{
			this.Radio = radio;
			this.Codeplug = codeplug;
			this.Template = template;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0007784C File Offset: 0x00075A4C
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x000778FC File Offset: 0x00075AFC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Radio Radio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)240028462;
				short num2 = num;
				num = (short)636586798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1199898624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)321978369;
				if (num != 0)
				{
				}
				num = (short)2019164160;
				if (num != 0)
				{
				}
				return this.<Radio>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)834377515;
				short num2 = num;
				num = (short)905877291;
				switch (num2 == num)
				{
				default:
				{
					num = (short)320798720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1741750273;
				if (num != 0)
				{
				}
				num = (short)268435456;
				if (num != 0)
				{
				}
				this.<Radio>k__BackingField = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x000779AC File Offset: 0x00075BAC
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00077A5C File Offset: 0x00075C5C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Codeplug Codeplug
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1087099658;
				short num2 = num;
				num = (short)391828234;
				switch (num2 == num)
				{
				default:
				{
					num = (short)522846208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)391774208;
				if (num != 0)
				{
				}
				num = (short)1130430465;
				if (num != 0)
				{
				}
				return this.<Codeplug>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1331789519;
				short num2 = num;
				num = (short)1049198287;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2016935936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)651755521;
				if (num != 0)
				{
				}
				num = (short)828047360;
				if (num != 0)
				{
				}
				this.<Codeplug>k__BackingField = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00077B0C File Offset: 0x00075D0C
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00077BBC File Offset: 0x00075DBC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Template Template
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)592037264;
				short num2 = num;
				num = (short)423871888;
				switch (num2 == num)
				{
				default:
				{
					num = (short)97910784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1083899905;
				if (num != 0)
				{
				}
				num = (short)1444020224;
				if (num != 0)
				{
				}
				return this.<Template>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)857784453;
				short num2 = num;
				num = (short)1242022021;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1745879040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1577451521;
				if (num != 0)
				{
				}
				num = (short)2022768640;
				if (num != 0)
				{
				}
				this.<Template>k__BackingField = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00077C70 File Offset: 0x00075E70
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00077D20 File Offset: 0x00075F20
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> FeaturesChanges
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1028547513;
				short num2 = num;
				num = (short)1750229945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1594228736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)178782209;
				if (num != 0)
				{
				}
				num = (short)1469775872;
				if (num != 0)
				{
				}
				return this.<FeaturesChanges>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1576928058;
				short num2 = num;
				num = (short)1582564154;
				switch (num2 == num)
				{
				default:
				{
					num = (short)438370304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1872560128;
				if (num != 0)
				{
				}
				num = (short)843382785;
				if (num != 0)
				{
				}
				this.<FeaturesChanges>k__BackingField = value;
			}
		}
	}
}
