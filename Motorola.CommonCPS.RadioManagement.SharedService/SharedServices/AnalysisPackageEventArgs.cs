using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000092 RID: 146
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AnalysisPackageEventArgs : global::System.EventArgs
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00064B60 File Offset: 0x00062D60
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x00064C10 File Offset: 0x00062E10
		[global::System.Runtime.Serialization.DataMember]
		public string filePath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1758593025;
				if (num != 0)
				{
				}
				num = (short)550268184;
				short num2 = num;
				num = (short)132607256;
				switch (num2 == num)
				{
				}
				num = (short)1598423040;
				short num3 = num;
				num = (short)1134624768;
				if (num != 0)
				{
				}
				return this.<filePath>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1911961721;
				short num2 = num;
				num = (short)5585017;
				switch (num2 == num)
				{
				}
				num = (short)268500992;
				if (num != 0)
				{
				}
				num = (short)2115305472;
				short num3 = num;
				num = (short)300285953;
				if (num != 0)
				{
				}
				this.<filePath>k__BackingField = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x00064CC0 File Offset: 0x00062EC0
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x00064D70 File Offset: 0x00062F70
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Package PackageInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)140534390;
				short num2 = num;
				num = (short)1462985334;
				switch (num2 == num)
				{
				}
				num = (short)669515777;
				if (num != 0)
				{
				}
				num = (short)1455161344;
				short num3 = num;
				num = (short)846921728;
				if (num != 0)
				{
				}
				return this.<PackageInfo>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1079121743;
				short num2 = num;
				num = (short)1151801167;
				switch (num2 == num)
				{
				}
				num = (short)511967232;
				if (num != 0)
				{
				}
				num = (short)250871808;
				short num3 = num;
				num = (short)324665345;
				if (num != 0)
				{
				}
				this.<PackageInfo>k__BackingField = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00064E20 File Offset: 0x00063020
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x00064F48 File Offset: 0x00063148
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Package> AstroFWPackageInfos
		{
			get
			{
				short num = (short)853934082;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)842203136;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_EC;
					case 1:
						goto IL_C8;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					}
					IL_58:
					if (this.astroFWPackageInfos != null)
					{
						goto IL_115;
					}
					num = (short)721379228;
					short num4 = num;
					num = (short)1141333916;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1706557440;
						if (num != 0)
						{
						}
						num = (short)1644363777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C8:
					this.astroFWPackageInfos = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>();
					num = (short)865206272;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_EC:
				num = (short)865730561;
				if (num != 0)
				{
				}
				IL_115:
				return this.astroFWPackageInfos;
			}
			set
			{
				short num = (short)119275756;
				short num2 = num;
				num = (short)364118252;
				switch (num2 == num)
				{
				}
				num = (short)566755329;
				if (num != 0)
				{
				}
				num = (short)2048393216;
				short num3 = num;
				num = (short)1424556032;
				if (num != 0)
				{
				}
				this.astroFWPackageInfos = value;
			}
		}

		// Token: 0x040000FE RID: 254
		[global::System.Runtime.Serialization.DataMember]
		private global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Package> astroFWPackageInfos;
	}
}
