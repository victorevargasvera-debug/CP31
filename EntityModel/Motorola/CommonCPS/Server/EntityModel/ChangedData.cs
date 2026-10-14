using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000044 RID: 68
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ChangedData
	{
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0004251C File Offset: 0x0004071C
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x000425CC File Offset: 0x000407CC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeType Type
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1965359105;
				if (num != 0)
				{
				}
				num = (short)521793526;
				short num2 = num;
				num = (short)2134110198;
				switch (num2 == num)
				{
				}
				num = (short)1352794112;
				short num3 = num;
				num = (short)360906752;
				if (num != 0)
				{
				}
				return this.<Type>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)724843134;
				short num2 = num;
				num = (short)1323121278;
				switch (num2 == num)
				{
				}
				num = (short)1049821185;
				if (num != 0)
				{
				}
				num = (short)1245052928;
				short num3 = num;
				num = (short)1624768512;
				if (num != 0)
				{
				}
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00042680 File Offset: 0x00040880
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x0004272C File Offset: 0x0004092C
		[global::System.Runtime.Serialization.DataMember]
		public bool ConfigRelationShipChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1035154964;
				short num2 = num;
				num = (short)310261268;
				switch (num2 == num)
				{
				}
				num = (short)756482049;
				if (num != 0)
				{
				}
				num = (short)198180864;
				short num3 = num;
				num = (short)1995046912;
				if (num != 0)
				{
				}
				return this.<ConfigRelationShipChanged>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)987772794;
				short num2 = num;
				num = (short)1604466554;
				switch (num2 == num)
				{
				}
				num = (short)197918720;
				if (num != 0)
				{
				}
				num = (short)1077542912;
				short num3 = num;
				num = (short)614465537;
				if (num != 0)
				{
				}
				this.<ConfigRelationShipChanged>k__BackingField = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x000427DC File Offset: 0x000409DC
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x0004288C File Offset: 0x00040A8C
		[global::System.Runtime.Serialization.DataMember]
		public bool OrderUpdated
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)669562754;
				short num2 = num;
				num = (short)1310963586;
				switch (num2 == num)
				{
				}
				num = (short)2116943873;
				if (num != 0)
				{
				}
				num = (short)1457455104;
				short num3 = num;
				num = (short)1827536896;
				if (num != 0)
				{
				}
				return this.<OrderUpdated>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1377892311;
				short num2 = num;
				num = (short)1688336343;
				switch (num2 == num)
				{
				}
				num = (short)139395073;
				if (num != 0)
				{
				}
				num = (short)1454112768;
				short num3 = num;
				num = (short)680132608;
				if (num != 0)
				{
				}
				this.<OrderUpdated>k__BackingField = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0004293C File Offset: 0x00040B3C
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x000429E8 File Offset: 0x00040BE8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ChangedRecord> Records
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)625693782;
				short num2 = num;
				num = (short)4609110;
				switch (num2 == num)
				{
				}
				num = (short)797900801;
				if (num != 0)
				{
				}
				num = (short)513540096;
				short num3 = num;
				num = (short)774307840;
				if (num != 0)
				{
				}
				return this.<Records>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1268321032;
				short num2 = num;
				num = (short)1107561224;
				switch (num2 == num)
				{
				}
				num = (short)98631680;
				if (num != 0)
				{
				}
				num = (short)202244096;
				short num3 = num;
				num = (short)269942785;
				if (num != 0)
				{
				}
				this.<Records>k__BackingField = value;
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00042A98 File Offset: 0x00040C98
		public ChangedData()
		{
			this.<Type>k__BackingField = global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeType.Modify;
			base..ctor();
		}
	}
}
