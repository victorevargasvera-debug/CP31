using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using ASK.Interface;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000084 RID: 132
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroUpgradeCodeplugEventArgs : global::System.EventArgs
	{
		// Token: 0x06000826 RID: 2086 RVA: 0x000613EC File Offset: 0x0005F5EC
		public AstroUpgradeCodeplugEventArgs(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode data, global::ASK.Interface.ISystemKeyData systemID)
		{
			this.syncdata = data;
			this.selectedSystemID = systemID;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00061410 File Offset: 0x0005F610
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x000614C4 File Offset: 0x0005F6C4
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode Syncdata
		{
			get
			{
				short num = (short)927545726;
				short num2 = num;
				num = (short)2046507390;
				switch (num2 == num)
				{
				}
				num = (short)1360068608;
				short num3 = num;
				num = (short)1463943169;
				if (num != 0)
				{
				}
				num = (short)780992512;
				if (num != 0)
				{
				}
				return this.syncdata;
			}
			set
			{
				short num = (short)691058071;
				short num2 = num;
				num = (short)1245492631;
				switch (num2 == num)
				{
				}
				num = (short)691666944;
				short num3 = num;
				num = (short)731643904;
				if (num != 0)
				{
				}
				num = (short)1916534785;
				if (num != 0)
				{
				}
				this.syncdata = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00061574 File Offset: 0x0005F774
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x00061624 File Offset: 0x0005F824
		public global::ASK.Interface.ISystemKeyData SelectedSystemID
		{
			get
			{
				short num = (short)952172545;
				if (num != 0)
				{
				}
				num = (short)900308030;
				short num2 = num;
				num = (short)1783798846;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1129119744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)418185216;
				if (num != 0)
				{
				}
				return this.selectedSystemID;
			}
			set
			{
				short num = (short)714330418;
				short num2 = num;
				num = (short)574083378;
				switch (num2 == num)
				{
				}
				num = (short)835452928;
				short num3 = num;
				num = (short)1108082689;
				if (num != 0)
				{
				}
				num = (short)1737162752;
				if (num != 0)
				{
				}
				this.selectedSystemID = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x000616D4 File Offset: 0x0005F8D4
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00061784 File Offset: 0x0005F984
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode syncdata
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)835583463;
				short num2 = num;
				num = (short)1015807463;
				switch (num2 == num)
				{
				}
				num = (short)344850432;
				short num3 = num;
				num = (short)1941504001;
				if (num != 0)
				{
				}
				num = (short)1519452160;
				if (num != 0)
				{
				}
				return this.<syncdata>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1390347175;
				short num2 = num;
				num = (short)483460007;
				switch (num2 == num)
				{
				}
				num = (short)37617664;
				short num3 = num;
				num = (short)1864499201;
				if (num != 0)
				{
				}
				num = (short)347144192;
				if (num != 0)
				{
				}
				this.<syncdata>k__BackingField = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00061834 File Offset: 0x0005FA34
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x000618E4 File Offset: 0x0005FAE4
		[global::System.Runtime.Serialization.DataMember]
		private global::ASK.Interface.ISystemKeyData selectedSystemID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)98681607;
				short num2 = num;
				num = (short)782156551;
				switch (num2 == num)
				{
				}
				num = (short)377880576;
				short num3 = num;
				num = (short)2135490561;
				if (num != 0)
				{
				}
				num = (short)1482620928;
				if (num != 0)
				{
				}
				return this.<selectedSystemID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1309671425;
				if (num != 0)
				{
				}
				num = (short)1070776314;
				short num2 = num;
				num = (short)38453242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)364838912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)398983168;
				if (num != 0)
				{
				}
				this.<selectedSystemID>k__BackingField = value;
			}
		}
	}
}
