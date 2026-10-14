using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200002A RID: 42
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class PcrMemoryImage : global::Motorola.Common.Communication.Pba.RadioImage
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000179C4 File Offset: 0x00015BC4
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00017A70 File Offset: 0x00015C70
		[global::System.Runtime.Serialization.DataMember]
		public int StartAddress
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)151562499;
				short num2 = num;
				num = (short)32090371;
				switch (num2 == num)
				{
				}
				num = (short)1211301888;
				short num3 = num;
				num = (short)1543897088;
				if (num != 0)
				{
				}
				num = (short)1074069505;
				if (num != 0)
				{
				}
				return this.<StartAddress>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1071862602;
				short num2 = num;
				num = (short)1668502346;
				switch (num2 == num)
				{
				}
				num = (short)1646133248;
				short num3 = num;
				num = (short)411762689;
				if (num != 0)
				{
				}
				num = (short)1018953728;
				if (num != 0)
				{
				}
				this.<StartAddress>k__BackingField = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00017B24 File Offset: 0x00015D24
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00017BD8 File Offset: 0x00015DD8
		[global::System.Runtime.Serialization.DataMember]
		public int EndAddress
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1634566696;
				short num2 = num;
				num = (short)1190691368;
				switch (num2 == num)
				{
				}
				num = (short)887881728;
				short num3 = num;
				num = (short)1072234497;
				if (num != 0)
				{
				}
				num = (short)1292566528;
				if (num != 0)
				{
				}
				return this.<EndAddress>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)580499304;
				short num2 = num;
				num = (short)2115483496;
				switch (num2 == num)
				{
				}
				num = (short)1645871104;
				short num3 = num;
				num = (short)1710227457;
				if (num != 0)
				{
				}
				num = (short)246677504;
				if (num != 0)
				{
				}
				this.<EndAddress>k__BackingField = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00017C88 File Offset: 0x00015E88
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00017D38 File Offset: 0x00015F38
		[global::System.Runtime.Serialization.DataMember]
		public bool RemoteImage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1732906236;
				short num2 = num;
				num = (short)551750908;
				switch (num2 == num)
				{
				}
				num = (short)1810169856;
				short num3 = num;
				num = (short)219283456;
				if (num != 0)
				{
				}
				num = (short)94175233;
				if (num != 0)
				{
				}
				return this.<RemoteImage>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1207736065;
				short num2 = num;
				num = (short)1864668929;
				switch (num2 == num)
				{
				}
				num = (short)887422976;
				short num3 = num;
				num = (short)1965686784;
				if (num != 0)
				{
				}
				num = (short)1096548353;
				if (num != 0)
				{
				}
				this.<RemoteImage>k__BackingField = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00017DE8 File Offset: 0x00015FE8
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00017E98 File Offset: 0x00016098
		[global::System.Runtime.Serialization.DataMember]
		public int ImageSize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1319901981;
				short num2 = num;
				num = (short)191306525;
				switch (num2 == num)
				{
				}
				num = (short)1108606976;
				short num3 = num;
				num = (short)1222508545;
				if (num != 0)
				{
				}
				num = (short)130416640;
				if (num != 0)
				{
				}
				return this.<ImageSize>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1747554390;
				short num2 = num;
				num = (short)2133102678;
				switch (num2 == num)
				{
				}
				num = (short)1061421056;
				short num3 = num;
				num = (short)1687683073;
				if (num != 0)
				{
				}
				num = (short)290390016;
				if (num != 0)
				{
				}
				this.<ImageSize>k__BackingField = value;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00017F48 File Offset: 0x00016148
		public PcrMemoryImage()
		{
			base.FilePath = null;
			base.FileType = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.Unknown;
			this.StartAddress = 0;
			this.EndAddress = 0;
			this.RemoteImage = false;
			this.ImageSize = 0;
		}
	}
}
