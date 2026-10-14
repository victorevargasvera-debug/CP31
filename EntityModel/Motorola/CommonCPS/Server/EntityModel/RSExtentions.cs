using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000172 RID: 370
	[global::System.Serializable]
	public class RSExtentions
	{
		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x000D77FC File Offset: 0x000D59FC
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x000D78AC File Offset: 0x000D5AAC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection MinimumOptions
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)700225651;
				short num2 = num;
				num = (short)1576114291;
				switch (num2 == num)
				{
				}
				num = (short)1355218944;
				short num3 = num;
				num = (short)1773797377;
				if (num != 0)
				{
				}
				num = (short)454033408;
				if (num != 0)
				{
				}
				return this.<MinimumOptions>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)774653552;
				short num2 = num;
				num = (short)873809520;
				switch (num2 == num)
				{
				}
				num = (short)684589056;
				short num3 = num;
				num = (short)1372913665;
				if (num != 0)
				{
				}
				num = (short)629669888;
				if (num != 0)
				{
				}
				this.<MinimumOptions>k__BackingField = value;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x000D7960 File Offset: 0x000D5B60
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x000D7A10 File Offset: 0x000D5C10
		[global::System.Runtime.Serialization.DataMember]
		public string OriginalCPVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)987918346;
				short num2 = num;
				num = (short)1062367242;
				switch (num2 == num)
				{
				}
				num = (short)816119808;
				short num3 = num;
				num = (short)1144258561;
				if (num != 0)
				{
				}
				num = (short)661520384;
				if (num != 0)
				{
				}
				return this.<OriginalCPVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)506638770;
				short num2 = num;
				num = (short)1133294002;
				switch (num2 == num)
				{
				}
				num = (short)469958656;
				short num3 = num;
				num = (short)470679553;
				if (num != 0)
				{
				}
				num = (short)1876492288;
				if (num != 0)
				{
				}
				this.<OriginalCPVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x000D7AC4 File Offset: 0x000D5CC4
		public bool IsNeedSerialize
		{
			get
			{
				if (this.MinimumOptions == null)
				{
					short num = (short)1413651472;
					short num2 = num;
					num = (short)903519248;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_0A;
					case 1:
						break;
					default:
					{
						num = (short)1941438464;
						short num3 = num;
						break;
					}
					}
					num = (short)1518075904;
					if (num != 0)
					{
					}
					num = (short)1313013761;
					if (num != 0)
					{
					}
					return false;
				}
				IL_0A:
				return this.MinimumOptions.IsNeedToSerialize;
			}
		}
	}
}
