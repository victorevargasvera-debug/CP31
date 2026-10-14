using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000075 RID: 117
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PBBRadio : global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.IPBBRadio
	{
		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x000602F0 File Offset: 0x0005E4F0
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x0006039C File Offset: 0x0005E59C
		[global::System.Runtime.Serialization.DataMember]
		public string IMEI
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1046154278;
				short num2 = num;
				num = (short)1374751782;
				switch (num2 == num)
				{
				}
				num = (short)736886784;
				short num3 = num;
				num = (short)1205272577;
				if (num != 0)
				{
				}
				num = (short)1773207552;
				if (num != 0)
				{
				}
				return this.<IMEI>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)920807748;
				short num2 = num;
				num = (short)123169092;
				switch (num2 == num)
				{
				}
				num = (short)1528627201;
				if (num != 0)
				{
				}
				num = (short)701628416;
				if (num != 0)
				{
				}
				num = (short)444530688;
				short num3 = num;
				this.<IMEI>k__BackingField = value;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x0006044C File Offset: 0x0005E64C
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x00060500 File Offset: 0x0005E700
		[global::System.Runtime.Serialization.DataMember]
		public string ProductIdentifier
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1721029641;
				short num2 = num;
				num = (short)2141180937;
				switch (num2 == num)
				{
				}
				num = (short)345309185;
				if (num != 0)
				{
				}
				num = (short)1260060672;
				if (num != 0)
				{
				}
				num = (short)1253769216;
				short num3 = num;
				return this.<ProductIdentifier>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)216928951;
				short num2 = num;
				num = (short)1266356919;
				switch (num2 == num)
				{
				}
				num = (short)1958608897;
				if (num != 0)
				{
				}
				num = (short)1415839744;
				if (num != 0)
				{
				}
				num = (short)94175232;
				short num3 = num;
				this.<ProductIdentifier>k__BackingField = value;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x000605B4 File Offset: 0x0005E7B4
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x00060664 File Offset: 0x0005E864
		[global::System.Runtime.Serialization.DataMember]
		public string ManufacturerName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)516837720;
				short num2 = num;
				num = (short)113529176;
				switch (num2 == num)
				{
				}
				num = (short)800063488;
				if (num != 0)
				{
				}
				num = (short)1471741953;
				if (num != 0)
				{
				}
				num = (short)1606615040;
				short num3 = num;
				return this.<ManufacturerName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)657300808;
				short num2 = num;
				num = (short)895327560;
				switch (num2 == num)
				{
				}
				num = (short)121372672;
				if (num != 0)
				{
				}
				num = (short)129826817;
				if (num != 0)
				{
				}
				num = (short)1060569088;
				short num3 = num;
				this.<ManufacturerName>k__BackingField = value;
			}
		}
	}
}
