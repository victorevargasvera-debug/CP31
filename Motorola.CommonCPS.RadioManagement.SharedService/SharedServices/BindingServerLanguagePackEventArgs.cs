using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200009B RID: 155
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class BindingServerLanguagePackEventArgs : global::System.EventArgs
	{
		// Token: 0x0600090C RID: 2316 RVA: 0x00066918 File Offset: 0x00064B18
		public BindingServerLanguagePackEventArgs(string firmwareVersion)
		{
			this.FirmwareVersion = firmwareVersion;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x00066934 File Offset: 0x00064B34
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x000669E4 File Offset: 0x00064BE4
		[global::System.Runtime.Serialization.DataMember]
		public string FirmwareVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1782701991;
				short num2 = num;
				num = (short)1611980711;
				switch (num2 == num)
				{
				}
				num = (short)751566849;
				if (num != 0)
				{
				}
				num = (short)1500315648;
				short num3 = num;
				num = (short)1296498688;
				if (num != 0)
				{
				}
				return this.<FirmwareVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1075815204;
				short num2 = num;
				num = (short)1580770084;
				switch (num2 == num)
				{
				}
				num = (short)1827995648;
				if (num != 0)
				{
				}
				num = (short)1671757824;
				short num3 = num;
				num = (short)411041793;
				if (num != 0)
				{
				}
				this.<FirmwareVersion>k__BackingField = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x00066A98 File Offset: 0x00064C98
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x00066B44 File Offset: 0x00064D44
		[global::System.Runtime.Serialization.DataMember]
		public bool IsNeedBinding
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1504537333;
				short num2 = num;
				num = (short)1264872181;
				switch (num2 == num)
				{
				}
				num = (short)1333854209;
				if (num != 0)
				{
				}
				num = (short)143196160;
				short num3 = num;
				num = (short)386465792;
				if (num != 0)
				{
				}
				return this.<IsNeedBinding>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)398262273;
				if (num != 0)
				{
				}
				num = (short)1609335087;
				short num2 = num;
				num = (short)523338031;
				switch (num2 == num)
				{
				}
				num = (short)921632768;
				short num3 = num;
				num = (short)1755643904;
				if (num != 0)
				{
				}
				this.<IsNeedBinding>k__BackingField = value;
			}
		}
	}
}
