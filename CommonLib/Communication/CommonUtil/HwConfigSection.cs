using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000075 RID: 117
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class HwConfigSection
	{
		// Token: 0x06000341 RID: 833 RVA: 0x000396A0 File Offset: 0x000378A0
		public HwConfigSection()
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000396B4 File Offset: 0x000378B4
		public HwConfigSection(int sectionType, string value, byte[] rawData)
		{
			this.SectionType = sectionType;
			this.Value = value;
			this.RawData = rawData;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000343 RID: 835 RVA: 0x000396DC File Offset: 0x000378DC
		// (set) Token: 0x06000344 RID: 836 RVA: 0x0003978C File Offset: 0x0003798C
		[global::System.Runtime.Serialization.DataMember]
		public int SectionType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1106903040;
				short num2 = num;
				num = (short)2087492785;
				short num3 = num;
				num = (short)458005681;
				switch (num3 == num)
				{
				}
				num = (short)1552351233;
				if (num != 0)
				{
				}
				num = (short)1330905088;
				if (num != 0)
				{
				}
				return this.<SectionType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1647116288;
				short num2 = num;
				num = (short)1730415814;
				short num3 = num;
				num = (short)904006854;
				switch (num3 == num)
				{
				}
				num = (short)1866661889;
				if (num != 0)
				{
				}
				num = (short)1482227712;
				if (num != 0)
				{
				}
				this.<SectionType>k__BackingField = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0003983C File Offset: 0x00037A3C
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000398EC File Offset: 0x00037AEC
		[global::System.Runtime.Serialization.DataMember]
		public string Value
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)30539776;
				short num2 = num;
				num = (short)755421062;
				short num3 = num;
				num = (short)253218694;
				switch (num3 == num)
				{
				}
				num = (short)1533542401;
				if (num != 0)
				{
				}
				num = (short)443154432;
				if (num != 0)
				{
				}
				return this.<Value>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)940244992;
				short num2 = num;
				num = (short)1029437333;
				short num3 = num;
				num = (short)1301411733;
				switch (num3 == num)
				{
				}
				num = (short)406192129;
				if (num != 0)
				{
				}
				num = (short)520552448;
				if (num != 0)
				{
				}
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0003999C File Offset: 0x00037B9C
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00039A50 File Offset: 0x00037C50
		[global::System.Runtime.Serialization.DataMember]
		public byte[] RawData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)642646016;
				short num2 = num;
				num = (short)1672588539;
				short num3 = num;
				num = (short)1861922043;
				switch (num3 == num)
				{
				}
				num = (short)743178241;
				if (num != 0)
				{
				}
				num = (short)1096679424;
				if (num != 0)
				{
				}
				return this.<RawData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)913833984;
				short num2 = num;
				num = (short)975304858;
				short num3 = num;
				num = (short)1482094746;
				switch (num3 == num)
				{
				}
				num = (short)337248256;
				if (num != 0)
				{
				}
				num = (short)38731777;
				if (num != 0)
				{
				}
				this.<RawData>k__BackingField = value;
			}
		}
	}
}
