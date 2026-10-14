using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200008A RID: 138
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class RadioActivityData : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00070978 File Offset: 0x0006EB78
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00070A28 File Offset: 0x0006EC28
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? LastContactTime
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)636511445;
				short num2 = num;
				num = (short)1496802517;
				switch (num2 == num)
				{
				}
				num = (short)1694892033;
				if (num != 0)
				{
				}
				num = (short)522125312;
				if (num != 0)
				{
				}
				num = (short)1539375104;
				short num3 = num;
				return this.<LastContactTime>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)828862421;
				short num2 = num;
				num = (short)1116827605;
				switch (num2 == num)
				{
				}
				num = (short)877592576;
				if (num != 0)
				{
				}
				num = (short)88014849;
				if (num != 0)
				{
				}
				num = (short)2026897408;
				short num3 = num;
				this.<LastContactTime>k__BackingField = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00070AD8 File Offset: 0x0006ECD8
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00070B88 File Offset: 0x0006ED88
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.APXRadio Radio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2101129066;
				short num2 = num;
				num = (short)931180394;
				switch (num2 == num)
				{
				}
				num = (short)90701825;
				if (num != 0)
				{
				}
				num = (short)1046806528;
				if (num != 0)
				{
				}
				num = (short)341114880;
				short num3 = num;
				return this.<Radio>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1392814445;
				short num2 = num;
				num = (short)550283629;
				switch (num2 == num)
				{
				}
				num = (short)805568513;
				if (num != 0)
				{
				}
				num = (short)1775173632;
				if (num != 0)
				{
				}
				num = (short)1533280256;
				short num3 = num;
				this.<Radio>k__BackingField = value;
			}
		}
	}
}
