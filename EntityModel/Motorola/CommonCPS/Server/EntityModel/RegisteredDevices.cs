using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000129 RID: 297
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class RegisteredDevices
	{
		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x000B7F3C File Offset: 0x000B613C
		// (set) Token: 0x06001136 RID: 4406 RVA: 0x000B7FEC File Offset: 0x000B61EC
		[global::System.Runtime.Serialization.DataMember]
		public string ComputerName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)258015233;
				if (num != 0)
				{
				}
				num = (short)963403081;
				short num2 = num;
				num = (short)1308712265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)153485312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1672413184;
				if (num != 0)
				{
				}
				return this.<ComputerName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1483866113;
				if (num != 0)
				{
				}
				num = (short)1439084564;
				short num2 = num;
				num = (short)1839968276;
				switch (num2 == num)
				{
				default:
				{
					num = (short)955318272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)689242112;
				if (num != 0)
				{
				}
				this.<ComputerName>k__BackingField = value;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x000B809C File Offset: 0x000B629C
		// (set) Token: 0x06001138 RID: 4408 RVA: 0x000B814C File Offset: 0x000B634C
		[global::System.Runtime.Serialization.DataMember]
		public string SerialNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)108332192;
				short num2 = num;
				num = (short)2125726880;
				switch (num2 == num)
				{
				}
				num = (short)39518208;
				short num3 = num;
				num = (short)792723457;
				if (num != 0)
				{
				}
				num = (short)230096896;
				if (num != 0)
				{
				}
				return this.<SerialNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)131523005;
				short num2 = num;
				num = (short)1194975677;
				switch (num2 == num)
				{
				}
				num = (short)170852352;
				short num3 = num;
				num = (short)1812594689;
				if (num != 0)
				{
				}
				num = (short)747438080;
				if (num != 0)
				{
				}
				this.<SerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x000B81FC File Offset: 0x000B63FC
		public RegisteredDevices(string computerName, string serialNumber)
		{
			this.ComputerName = computerName;
			this.SerialNumber = serialNumber;
		}
	}
}
