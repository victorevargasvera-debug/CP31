using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000015 RID: 21
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class LanguagePackData
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000074B4 File Offset: 0x000056B4
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00007560 File Offset: 0x00005760
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase> LanguagePacks
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1464860672;
				short num2 = num;
				num = (short)774111233;
				if (num != 0)
				{
				}
				num = (short)1260421242;
				short num3 = num;
				num = (short)227901562;
				switch (num3 == num)
				{
				}
				num = (short)265420800;
				if (num != 0)
				{
				}
				return this.<LanguagePacks>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1338900480;
				short num2 = num;
				num = (short)1106739823;
				short num3 = num;
				num = (short)828473967;
				switch (num3 == num)
				{
				}
				num = (short)481689601;
				if (num != 0)
				{
				}
				num = (short)547618816;
				if (num != 0)
				{
				}
				this.<LanguagePacks>k__BackingField = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00007614 File Offset: 0x00005814
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000076C4 File Offset: 0x000058C4
		[global::System.Runtime.Serialization.DataMember]
		public uint AvailableSpace
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)557121536;
				short num2 = num;
				num = (short)1519822370;
				short num3 = num;
				num = (short)1935320610;
				switch (num3 == num)
				{
				}
				num = (short)1365049344;
				if (num != 0)
				{
				}
				num = (short)1778778113;
				if (num != 0)
				{
				}
				return this.<AvailableSpace>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1564082176;
				short num2 = num;
				num = (short)1406271489;
				if (num != 0)
				{
				}
				num = (short)1666150179;
				short num3 = num;
				num = (short)865562403;
				switch (num3 == num)
				{
				}
				num = (short)4456448;
				if (num != 0)
				{
				}
				this.<AvailableSpace>k__BackingField = value;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00007770 File Offset: 0x00005970
		public LanguagePackData()
		{
			this.LanguagePacks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>();
			this.AvailableSpace = 0U;
			this.ModelType = global::Motorola.Common.Communication.CommonUtil.ModelType.Portable;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000779C File Offset: 0x0000599C
		public LanguagePackData(global::Motorola.Common.Communication.CommonUtil.ModelType type)
		{
			this.LanguagePacks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>();
			this.AvailableSpace = 0U;
			this.ModelType = type;
		}

		// Token: 0x04000038 RID: 56
		[global::System.Runtime.Serialization.OptionalField]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.ModelType ModelType;
	}
}
