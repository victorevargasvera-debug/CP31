using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel
{
	// Token: 0x020001D3 RID: 467
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	public class SyncTypesDescription
	{
		// Token: 0x06001796 RID: 6038 RVA: 0x000FEFD0 File Offset: 0x000FD1D0
		public SyncTypesDescription()
		{
			this.Types_IfMandatory = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes, bool>();
			this.TypesFieldsItems = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes, global::System.Collections.Generic.List<string>>();
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x000FEFFC File Offset: 0x000FD1FC
		// (set) Token: 0x06001798 RID: 6040 RVA: 0x000FF0B0 File Offset: 0x000FD2B0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PACType PacType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)731381761;
				if (num != 0)
				{
				}
				num = (short)845561025;
				short num2 = num;
				num = (short)430456001;
				switch (num2 == num)
				{
				}
				num = (short)869400576;
				if (num != 0)
				{
				}
				num = (short)1219100672;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)777185478;
				short num2 = num;
				num = (short)1704323270;
				switch (num2 == num)
				{
				}
				num = (short)1657536513;
				if (num != 0)
				{
				}
				num = (short)866975744;
				if (num != 0)
				{
				}
				num = (short)1887043584;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x000FF164 File Offset: 0x000FD364
		// (set) Token: 0x0600179A RID: 6042 RVA: 0x000FF214 File Offset: 0x000FD414
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes, global::System.Collections.Generic.List<string>> TypesFieldsItems
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1648323481;
				short num2 = num;
				num = (short)1704618905;
				switch (num2 == num)
				{
				}
				num = (short)1556152321;
				if (num != 0)
				{
				}
				num = (short)1659109376;
				if (num != 0)
				{
				}
				num = (short)1013055488;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1672150221;
				short num2 = num;
				num = (short)1611201741;
				switch (num2 == num)
				{
				default:
				{
					num = (short)719585280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1521156097;
				if (num != 0)
				{
				}
				num = (short)1249247232;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x000FF2C4 File Offset: 0x000FD4C4
		// (set) Token: 0x0600179C RID: 6044 RVA: 0x000FF374 File Offset: 0x000FD574
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes, bool> Types_IfMandatory
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1680533743;
				short num2 = num;
				num = (short)2037836015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1698496512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1468661760;
				if (num != 0)
				{
				}
				num = (short)736952321;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1938771039;
				short num2 = num;
				num = (short)879053919;
				switch (num2 == num)
				{
				default:
				{
					num = (short)171114496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)477954049;
				if (num != 0)
				{
				}
				num = (short)1536229376;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x04000AFA RID: 2810
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.PACType a;

		// Token: 0x04000AFB RID: 2811
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes, global::System.Collections.Generic.List<string>> b;

		// Token: 0x04000AFC RID: 2812
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes, bool> c;
	}
}
