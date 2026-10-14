using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000060 RID: 96
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey))]
	[global::System.Serializable]
	public abstract class MatrixKey : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00053904 File Offset: 0x00051B04
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x000539B0 File Offset: 0x00051BB0
		[global::System.Runtime.Serialization.DataMember]
		public string Alias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1114210450;
				short num2 = num;
				num = (short)1413906578;
				switch (num2 == num)
				{
				}
				num = (short)885325825;
				if (num != 0)
				{
				}
				num = (short)1573388288;
				short num3 = num;
				num = (short)191299584;
				if (num != 0)
				{
				}
				return this.<Alias>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2113728136;
				short num2 = num;
				num = (short)1349250696;
				switch (num2 == num)
				{
				}
				num = (short)1032323073;
				if (num != 0)
				{
				}
				num = (short)1220542464;
				short num3 = num;
				num = (short)1955987456;
				if (num != 0)
				{
				}
				this.<Alias>k__BackingField = value;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00053A5C File Offset: 0x00051C5C
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00053B10 File Offset: 0x00051D10
		[global::System.Runtime.Serialization.DataMember]
		public int? ReferenceCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1103743531;
				short num2 = num;
				num = (short)1781385771;
				switch (num2 == num)
				{
				}
				num = (short)883818497;
				if (num != 0)
				{
				}
				num = (short)119144448;
				short num3 = num;
				num = (short)753860608;
				if (num != 0)
				{
				}
				return this.<ReferenceCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)556613825;
				short num2 = num;
				num = (short)181485761;
				switch (num2 == num)
				{
				}
				num = (short)825622529;
				if (num != 0)
				{
				}
				num = (short)1146159104;
				short num3 = num;
				num = (short)2621440;
				if (num != 0)
				{
				}
				this.<ReferenceCount>k__BackingField = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00053BC0 File Offset: 0x00051DC0
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00053C6C File Offset: 0x00051E6C
		[global::System.Runtime.Serialization.DataMember]
		public int? ConfigReferenceCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)601143676;
				short num2 = num;
				num = (short)1658632572;
				switch (num2 == num)
				{
				}
				num = (short)1076297728;
				if (num != 0)
				{
				}
				num = (short)1051590656;
				short num3 = num;
				num = (short)1557987329;
				if (num != 0)
				{
				}
				return this.<ConfigReferenceCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1351226526;
				short num2 = num;
				num = (short)176886942;
				switch (num2 == num)
				{
				}
				num = (short)1061421056;
				if (num != 0)
				{
				}
				num = (short)769982464;
				short num3 = num;
				num = (short)502923265;
				if (num != 0)
				{
				}
				this.<ConfigReferenceCount>k__BackingField = value;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00053D20 File Offset: 0x00051F20
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00053DD0 File Offset: 0x00051FD0
		[global::System.Runtime.Serialization.DataMember]
		public int? TemplateReferenceCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1535680438;
				short num2 = num;
				num = (short)175153078;
				switch (num2 == num)
				{
				}
				num = (short)919207937;
				if (num != 0)
				{
				}
				num = (short)2141519872;
				short num3 = num;
				num = (short)915079168;
				if (num != 0)
				{
				}
				return this.<TemplateReferenceCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)194576385;
				if (num != 0)
				{
				}
				num = (short)1886475841;
				short num2 = num;
				num = (short)1236096577;
				switch (num2 == num)
				{
				}
				num = (short)476250112;
				short num3 = num;
				num = (short)1117454336;
				if (num != 0)
				{
				}
				this.<TemplateReferenceCount>k__BackingField = value;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00053E80 File Offset: 0x00052080
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x00053F2C File Offset: 0x0005212C
		[global::System.Runtime.Serialization.DataMember]
		public string Comment
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1245118465;
				if (num != 0)
				{
				}
				num = (short)339699743;
				short num2 = num;
				num = (short)577988639;
				switch (num2 == num)
				{
				}
				num = (short)1604321280;
				short num3 = num;
				num = (short)873594880;
				if (num != 0)
				{
				}
				return this.<Comment>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1995716002;
				short num2 = num;
				num = (short)932656546;
				switch (num2 == num)
				{
				}
				num = (short)1706426369;
				if (num != 0)
				{
				}
				num = (short)118423552;
				short num3 = num;
				num = (short)1417347072;
				if (num != 0)
				{
				}
				this.<Comment>k__BackingField = value;
			}
		}
	}
}
