using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200009A RID: 154
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class IsSameFWVersionUpgradeSupportedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000905 RID: 2309 RVA: 0x000664D4 File Offset: 0x000646D4
		public IsSameFWVersionUpgradeSupportedEventArgs(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug, byte[] codeplugContent)
		{
			this.Codeplug = codeplug;
			this.CodeplugContent = codeplugContent;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x000664F8 File Offset: 0x000646F8
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x000665A4 File Offset: 0x000647A4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Codeplug Codeplug
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2087463998;
				short num2 = num;
				num = (short)1011166270;
				switch (num2 == num)
				{
				}
				num = (short)1578172417;
				if (num != 0)
				{
				}
				num = (short)1346043904;
				short num3 = num;
				num = (short)1683750912;
				if (num != 0)
				{
				}
				return this.<Codeplug>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1550319617;
				if (num != 0)
				{
				}
				num = (short)209996790;
				short num2 = num;
				num = (short)45239286;
				switch (num2 == num)
				{
				}
				num = (short)255787008;
				short num3 = num;
				num = (short)1440874496;
				if (num != 0)
				{
				}
				this.<Codeplug>k__BackingField = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00066654 File Offset: 0x00064854
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x00066700 File Offset: 0x00064900
		[global::System.Runtime.Serialization.DataMember]
		public byte[] CodeplugContent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1735327745;
				if (num != 0)
				{
				}
				num = (short)483545315;
				short num2 = num;
				num = (short)1842499811;
				switch (num2 == num)
				{
				}
				num = (short)863436800;
				short num3 = num;
				num = (short)178192384;
				if (num != 0)
				{
				}
				return this.<CodeplugContent>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1514577073;
				short num2 = num;
				num = (short)1419418801;
				switch (num2 == num)
				{
				}
				num = (short)552140801;
				if (num != 0)
				{
				}
				num = (short)1291976704;
				short num3 = num;
				num = (short)414449664;
				if (num != 0)
				{
				}
				this.<CodeplugContent>k__BackingField = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x000667B0 File Offset: 0x000649B0
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x00066864 File Offset: 0x00064A64
		[global::System.Runtime.Serialization.DataMember]
		public bool IsSupported
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)766797574;
				short num2 = num;
				num = (short)2078041862;
				switch (num2 == num)
				{
				}
				num = (short)925499393;
				if (num != 0)
				{
				}
				num = (short)695533568;
				short num3 = num;
				num = (short)1821704192;
				if (num != 0)
				{
				}
				return this.<IsSupported>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)904427202;
				short num2 = num;
				num = (short)493975234;
				switch (num2 == num)
				{
				}
				num = (short)474873857;
				if (num != 0)
				{
				}
				num = (short)371785728;
				short num3 = num;
				num = (short)865927168;
				if (num != 0)
				{
				}
				this.<IsSupported>k__BackingField = value;
			}
		}
	}
}
