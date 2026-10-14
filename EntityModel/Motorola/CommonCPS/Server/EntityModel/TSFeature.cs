using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000125 RID: 293
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class TSFeature
	{
		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x000B5D34 File Offset: 0x000B3F34
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x000B5DE8 File Offset: 0x000B3FE8
		[global::System.Runtime.Serialization.DataMember]
		public string featureName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1804285537;
				short num2 = num;
				num = (short)481113697;
				switch (num2 == num)
				{
				}
				num = (short)1720713217;
				if (num != 0)
				{
				}
				num = (short)2071134208;
				if (num != 0)
				{
				}
				num = (short)1279197184;
				short num3 = num;
				return this.<featureName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)614602296;
				short num2 = num;
				num = (short)804394552;
				switch (num2 == num)
				{
				}
				num = (short)2018181121;
				if (num != 0)
				{
				}
				num = (short)966459392;
				if (num != 0)
				{
				}
				num = (short)1893793792;
				short num3 = num;
				this.<featureName>k__BackingField = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x000B5E9C File Offset: 0x000B409C
		// (set) Token: 0x06001104 RID: 4356 RVA: 0x000B5F4C File Offset: 0x000B414C
		[global::System.Runtime.Serialization.DataMember]
		public string featureVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1928477333;
				short num2 = num;
				num = (short)68172437;
				switch (num2 == num)
				{
				}
				num = (short)1082064897;
				if (num != 0)
				{
				}
				num = (short)1182072832;
				if (num != 0)
				{
				}
				num = (short)668205056;
				short num3 = num;
				return this.<featureVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1097963912;
				short num2 = num;
				num = (short)1111660936;
				switch (num2 == num)
				{
				}
				num = (short)1116602368;
				short num3 = num;
				num = (short)620036097;
				if (num != 0)
				{
				}
				num = (short)1409744896;
				if (num != 0)
				{
				}
				this.<featureVersion>k__BackingField = value;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x000B5FFC File Offset: 0x000B41FC
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x000B60A8 File Offset: 0x000B42A8
		[global::System.Runtime.Serialization.DataMember]
		public int featureCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)483070168;
				short num2 = num;
				num = (short)1149833432;
				switch (num2 == num)
				{
				}
				num = (short)615448576;
				short num3 = num;
				num = (short)614727680;
				if (num != 0)
				{
				}
				num = (short)1974665217;
				if (num != 0)
				{
				}
				return this.<featureCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1289782506;
				short num2 = num;
				num = (short)143623402;
				switch (num2 == num)
				{
				}
				num = (short)639500288;
				short num3 = num;
				num = (short)103481345;
				if (num != 0)
				{
				}
				num = (short)1159462912;
				if (num != 0)
				{
				}
				this.<featureCount>k__BackingField = value;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x000B615C File Offset: 0x000B435C
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x000B620C File Offset: 0x000B440C
		[global::System.Runtime.Serialization.DataMember]
		public string activationID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1033872232;
				short num2 = num;
				num = (short)895066984;
				switch (num2 == num)
				{
				}
				num = (short)261947392;
				short num3 = num;
				num = (short)1519910912;
				if (num != 0)
				{
				}
				num = (short)1027473409;
				if (num != 0)
				{
				}
				return this.<activationID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)483166002;
				short num2 = num;
				num = (short)596608818;
				switch (num2 == num)
				{
				}
				num = (short)1946353664;
				short num3 = num;
				num = (short)196018177;
				if (num != 0)
				{
				}
				num = (short)1622671360;
				if (num != 0)
				{
				}
				this.<activationID>k__BackingField = value;
			}
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x000B62BC File Offset: 0x000B44BC
		public TSFeature(string name, string version, int count, string actID)
		{
			this.featureName = name;
			this.featureVersion = version;
			this.featureCount = count;
			this.activationID = actID;
		}
	}
}
