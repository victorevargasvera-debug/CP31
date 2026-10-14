using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001BD RID: 445
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ClientVersion
	{
		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x000F5A68 File Offset: 0x000F3C68
		// (set) Token: 0x060016D2 RID: 5842 RVA: 0x000F5B18 File Offset: 0x000F3D18
		[global::System.Runtime.Serialization.DataMember]
		public string ClientRMVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)851527398;
				short num2 = num;
				num = (short)2051491558;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1056112640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)567541760;
				if (num != 0)
				{
				}
				num = (short)1286799361;
				if (num != 0)
				{
				}
				return this.<ClientRMVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)435257564;
				short num2 = num;
				num = (short)535462108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)393543680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1618804737;
				if (num != 0)
				{
				}
				num = (short)240386048;
				if (num != 0)
				{
				}
				this.<ClientRMVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x000F5BCC File Offset: 0x000F3DCC
		// (set) Token: 0x060016D4 RID: 5844 RVA: 0x000F5C7C File Offset: 0x000F3E7C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> ClientCpVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)73555818;
				short num2 = num;
				num = (short)1382309738;
				switch (num2 == num)
				{
				default:
				{
					num = (short)857079808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2008940544;
				if (num != 0)
				{
				}
				num = (short)1243086849;
				if (num != 0)
				{
				}
				return this.<ClientCpVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)79205586;
				short num2 = num;
				num = (short)625841362;
				switch (num2 == num)
				{
				default:
				{
					num = (short)166330368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1797390337;
				if (num != 0)
				{
				}
				num = (short)108593152;
				if (num != 0)
				{
				}
				this.<ClientCpVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x000F5D2C File Offset: 0x000F3F2C
		// (set) Token: 0x060016D6 RID: 5846 RVA: 0x000F5DDC File Offset: 0x000F3FDC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<string> CompatibleServerRMVersions
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1893662721;
				if (num != 0)
				{
				}
				num = (short)442826752;
				short num2 = num;
				num = (short)599902198;
				short num3 = num;
				num = (short)575064054;
				switch (num3 == num)
				{
				}
				num = (short)604045312;
				if (num != 0)
				{
				}
				return this.<CompatibleServerRMVersions>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)200064734;
				short num2 = num;
				num = (short)788446942;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1113128960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)501743616;
				if (num != 0)
				{
				}
				num = (short)1537605633;
				if (num != 0)
				{
				}
				this.<CompatibleServerRMVersions>k__BackingField = value;
			}
		}
	}
}
