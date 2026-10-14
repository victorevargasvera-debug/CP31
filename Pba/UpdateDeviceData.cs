using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000033 RID: 51
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class UpdateDeviceData
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0001B724 File Offset: 0x00019924
		// (set) Token: 0x060001AD RID: 429 RVA: 0x0001B7D4 File Offset: 0x000199D4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> MemoryImages
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1274230570;
				short num2 = num;
				num = (short)413087530;
				switch (num2 == num)
				{
				}
				num = (short)2102329345;
				if (num != 0)
				{
				}
				num = (short)1260912640;
				if (num != 0)
				{
				}
				num = (short)1678639104;
				short num3 = num;
				return this.<MemoryImages>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)658506887;
				short num2 = num;
				num = (short)756417671;
				switch (num2 == num)
				{
				}
				num = (short)820641793;
				if (num != 0)
				{
				}
				num = (short)1416036352;
				if (num != 0)
				{
				}
				num = (short)1120468992;
				short num3 = num;
				this.<MemoryImages>k__BackingField = value;
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0001B888 File Offset: 0x00019A88
		public UpdateDeviceData()
		{
			this.MemoryImages = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0001B8A8 File Offset: 0x00019AA8
		public UpdateDeviceData(ushort tg, string fwdlVer)
		{
			this.MemoryImages = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>();
		}
	}
}
