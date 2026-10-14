using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000094 RID: 148
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class ListTTSLpPackageEventArgs : global::System.EventArgs
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x000651FC File Offset: 0x000633FC
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00065324 File Offset: 0x00063524
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> TTSLanguagePacks
		{
			get
			{
				short num = (short)617086978;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)94830592;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_111;
					case 1:
						goto IL_C8;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					IL_59:
					if (this.ttslanguagePacks != null)
					{
						break;
					}
					num = (short)1716972509;
					short num4 = num;
					num = (short)1430121437;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)13762560;
						if (num != 0)
						{
						}
						num = (short)923533313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C8:
					this.ttslanguagePacks = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>();
					num = (short)1468268545;
					if (num != 0)
					{
					}
					num = (short)1965686784;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_111:
				return this.ttslanguagePacks;
			}
			set
			{
				short num = (short)923318277;
				short num2 = num;
				num = (short)306362373;
				switch (num2 == num)
				{
				}
				num = (short)1794572289;
				if (num != 0)
				{
				}
				num = (short)2113208320;
				short num3 = num;
				num = (short)297074688;
				if (num != 0)
				{
				}
				this.ttslanguagePacks = value;
			}
		}

		// Token: 0x04000102 RID: 258
		[global::System.Runtime.Serialization.DataMember]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> ttslanguagePacks;
	}
}
