using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel.CallBacks
{
	// Token: 0x02000200 RID: 512
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ClientEventInfo
	{
		// Token: 0x06001917 RID: 6423 RVA: 0x0010EF08 File Offset: 0x0010D108
		public ClientEventInfo()
		{
			this.SenderId = string.Empty;
			this.EventEntries = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry>();
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0010EF34 File Offset: 0x0010D134
		public ClientEventInfo(string senderId)
		{
			this.SenderId = senderId;
			this.EventEntries = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry>();
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x0010EF5C File Offset: 0x0010D15C
		public ClientEventInfo(string senderId, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry eventEntry)
		{
			this.SenderId = senderId;
			this.EventEntries = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry>();
			this.EventEntries.Add(eventEntry);
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x0010EF90 File Offset: 0x0010D190
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x0010F044 File Offset: 0x0010D244
		[global::System.Runtime.Serialization.DataMember]
		public string SenderId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2024334247;
				short num2 = num;
				num = (short)1623909287;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2142044160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2059796480;
				if (num != 0)
				{
				}
				num = (short)727842817;
				if (num != 0)
				{
				}
				return this.<SenderId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)699759590;
				short num2 = num;
				num = (short)685669350;
				switch (num2 == num)
				{
				default:
				{
					num = (short)836632576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)106102784;
				if (num != 0)
				{
				}
				num = (short)1362755585;
				if (num != 0)
				{
				}
				this.<SenderId>k__BackingField = value;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x0010F0F4 File Offset: 0x0010D2F4
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x0010F1A4 File Offset: 0x0010D3A4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier SourcePac
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)247857430;
				short num2 = num;
				num = (short)734593302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1872560128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1317797889;
				if (num != 0)
				{
				}
				num = (short)110231552;
				if (num != 0)
				{
				}
				return this.<SourcePac>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1333406231;
				short num2 = num;
				num = (short)1520249367;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1845035008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)116654081;
				if (num != 0)
				{
				}
				num = (short)1563164672;
				if (num != 0)
				{
				}
				this.<SourcePac>k__BackingField = value;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x0010F258 File Offset: 0x0010D458
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x0010F30C File Offset: 0x0010D50C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry> EventEntries
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1570639121;
				short num2 = num;
				num = (short)1780223249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)240254976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1332215808;
				if (num != 0)
				{
				}
				num = (short)1244135425;
				if (num != 0)
				{
				}
				return this.<EventEntries>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)937947306;
				short num2 = num;
				num = (short)1831071914;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1027473408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1923678208;
				if (num != 0)
				{
				}
				num = (short)1376452609;
				if (num != 0)
				{
				}
				this.<EventEntries>k__BackingField = value;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x0010F3BC File Offset: 0x0010D5BC
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x0010F46C File Offset: 0x0010D66C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime FireDatetime
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1670512641;
				if (num != 0)
				{
				}
				num = (short)2060845056;
				short num2 = num;
				num = (short)359367583;
				short num3 = num;
				num = (short)1660453791;
				switch (num3 == num)
				{
				}
				num = (short)1555300352;
				if (num != 0)
				{
				}
				return this.<FireDatetime>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)329071254;
				short num2 = num;
				num = (short)1186740886;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1727528960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)478871552;
				if (num != 0)
				{
				}
				num = (short)1337458689;
				if (num != 0)
				{
				}
				this.<FireDatetime>k__BackingField = value;
			}
		}
	}
}
