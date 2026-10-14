using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000093 RID: 147
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class ListLpPackageEventArgs : global::System.EventArgs
	{
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0006500C File Offset: 0x0006320C
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00065138 File Offset: 0x00063338
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> LanguagePacks
		{
			get
			{
				short num = (short)184287234;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)268369920;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_114;
					case 1:
						goto IL_F2;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					}
					IL_5A:
					if (this.languagePacks != null)
					{
						break;
					}
					num = (short)1136630664;
					short num4 = num;
					num = (short)1598593928;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)244645889;
						if (num != 0)
						{
						}
						num = (short)1078263808;
						if (num != 0)
						{
						}
						num = (short)1782972417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_F2:
					this.languagePacks = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>();
					num = (short)1814298624;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_114:
				return this.languagePacks;
			}
			set
			{
				short num = (short)107610113;
				if (num != 0)
				{
				}
				num = (short)1336086938;
				short num2 = num;
				num = (short)330502554;
				switch (num2 == num)
				{
				}
				num = (short)5177344;
				short num3 = num;
				num = (short)1302724608;
				if (num != 0)
				{
				}
				this.languagePacks = value;
			}
		}

		// Token: 0x04000101 RID: 257
		[global::System.Runtime.Serialization.DataMember]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> languagePacks;
	}
}
