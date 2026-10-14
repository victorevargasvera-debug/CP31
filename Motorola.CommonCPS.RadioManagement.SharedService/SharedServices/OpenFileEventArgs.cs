using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000091 RID: 145
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class OpenFileEventArgs : global::System.EventArgs
	{
		// Token: 0x060008CE RID: 2254 RVA: 0x000642F0 File Offset: 0x000624F0
		public OpenFileEventArgs(string filePath, bool IgnorePassword, string password)
		{
			this.FilePath = filePath;
			this.Password = password;
			this.IgnorePassword = IgnorePassword;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x00064318 File Offset: 0x00062518
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x000643C8 File Offset: 0x000625C8
		[global::System.Runtime.Serialization.DataMember]
		public string FilePath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)506149172;
				short num2 = num;
				num = (short)795818292;
				switch (num2 == num)
				{
				}
				num = (short)2139357185;
				if (num != 0)
				{
				}
				num = (short)1495334912;
				short num3 = num;
				num = (short)1640628224;
				if (num != 0)
				{
				}
				return this.<FilePath>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)301520375;
				short num2 = num;
				num = (short)417322487;
				switch (num2 == num)
				{
				}
				num = (short)816250881;
				if (num != 0)
				{
				}
				num = (short)2068119552;
				short num3 = num;
				num = (short)1928069120;
				if (num != 0)
				{
				}
				this.<FilePath>k__BackingField = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x00064478 File Offset: 0x00062678
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x00064528 File Offset: 0x00062728
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Radio ImportingRadio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1345572037;
				short num2 = num;
				num = (short)230739141;
				switch (num2 == num)
				{
				}
				num = (short)319422465;
				if (num != 0)
				{
				}
				num = (short)912261120;
				short num3 = num;
				num = (short)1318912000;
				if (num != 0)
				{
				}
				return this.<ImportingRadio>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1058275329;
				if (num != 0)
				{
				}
				num = (short)1392797509;
				short num2 = num;
				num = (short)470837061;
				switch (num2 == num)
				{
				}
				num = (short)1816002560;
				short num3 = num;
				num = (short)1099628544;
				if (num != 0)
				{
				}
				this.<ImportingRadio>k__BackingField = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x000645D8 File Offset: 0x000627D8
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x00064688 File Offset: 0x00062888
		[global::System.Runtime.Serialization.DataMember]
		public bool IgnorePassword
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)265625021;
				short num2 = num;
				num = (short)1190665661;
				switch (num2 == num)
				{
				}
				num = (short)2064187393;
				if (num != 0)
				{
				}
				num = (short)1804206080;
				short num3 = num;
				num = (short)771620864;
				if (num != 0)
				{
				}
				return this.<IgnorePassword>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1622640052;
				short num2 = num;
				num = (short)1668908468;
				switch (num2 == num)
				{
				}
				num = (short)328073217;
				if (num != 0)
				{
				}
				num = (short)1468858368;
				short num3 = num;
				num = (short)578027520;
				if (num != 0)
				{
				}
				this.<IgnorePassword>k__BackingField = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00064738 File Offset: 0x00062938
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x000647E8 File Offset: 0x000629E8
		[global::System.Runtime.Serialization.DataMember]
		public string Password
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1551695873;
				if (num != 0)
				{
				}
				num = (short)999088225;
				short num2 = num;
				num = (short)1222762593;
				switch (num2 == num)
				{
				}
				num = (short)535494656;
				short num3 = num;
				num = (short)919863296;
				if (num != 0)
				{
				}
				return this.<Password>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)391110250;
				short num2 = num;
				num = (short)1837882986;
				switch (num2 == num)
				{
				}
				num = (short)1641086976;
				if (num != 0)
				{
				}
				num = (short)841023488;
				short num3 = num;
				num = (short)1674313729;
				if (num != 0)
				{
				}
				this.<Password>k__BackingField = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x00064898 File Offset: 0x00062A98
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x00064948 File Offset: 0x00062B48
		[global::System.Runtime.Serialization.DataMember]
		public object PBAObject
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)681580744;
				short num2 = num;
				num = (short)2141198536;
				switch (num2 == num)
				{
				}
				num = (short)2135359488;
				if (num != 0)
				{
				}
				num = (short)1155661824;
				short num3 = num;
				num = (short)2113208321;
				if (num != 0)
				{
				}
				return this.<PBAObject>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)18047434;
				short num2 = num;
				num = (short)2065588682;
				switch (num2 == num)
				{
				}
				num = (short)1502478336;
				if (num != 0)
				{
				}
				num = (short)827064320;
				short num3 = num;
				num = (short)220987393;
				if (num != 0)
				{
				}
				this.<PBAObject>k__BackingField = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x000649FC File Offset: 0x00062BFC
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x00064AAC File Offset: 0x00062CAC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Template ImportingTemplate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1614436372;
				short num2 = num;
				num = (short)85612564;
				switch (num2 == num)
				{
				}
				num = (short)1869283329;
				if (num != 0)
				{
				}
				num = (short)1014366208;
				short num3 = num;
				num = (short)1439956992;
				if (num != 0)
				{
				}
				return this.<ImportingTemplate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1041974186;
				short num2 = num;
				num = (short)650658730;
				switch (num2 == num)
				{
				}
				num = (short)1221525504;
				if (num != 0)
				{
				}
				num = (short)668139520;
				short num3 = num;
				num = (short)739835905;
				if (num != 0)
				{
				}
				this.<ImportingTemplate>k__BackingField = value;
			}
		}
	}
}
