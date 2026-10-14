using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001AC RID: 428
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ValidateEntitySet
	{
		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x000EDDF0 File Offset: 0x000EBFF0
		// (set) Token: 0x06001651 RID: 5713 RVA: 0x000EDEA0 File Offset: 0x000EC0A0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? RelatedObject
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1319895040;
				short num2 = num;
				num = (short)1831246477;
				short num3 = num;
				num = (short)935959181;
				switch (num3 == num)
				{
				}
				num = (short)1441202176;
				if (num != 0)
				{
				}
				num = (short)1268449281;
				if (num != 0)
				{
				}
				return this.<RelatedObject>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1260781568;
				short num2 = num;
				num = (short)955559433;
				short num3 = num;
				num = (short)698658313;
				switch (num3 == num)
				{
				}
				num = (short)1435172865;
				if (num != 0)
				{
				}
				num = (short)1466236928;
				if (num != 0)
				{
				}
				this.<RelatedObject>k__BackingField = value;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x000EDF50 File Offset: 0x000EC150
		// (set) Token: 0x06001653 RID: 5715 RVA: 0x000EDFFC File Offset: 0x000EC1FC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType Type
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)873660416;
				short num2 = num;
				num = (short)1646440883;
				short num3 = num;
				num = (short)1061925299;
				switch (num3 == num)
				{
				}
				num = (short)135135232;
				if (num != 0)
				{
				}
				num = (short)2119106561;
				if (num != 0)
				{
				}
				return this.<Type>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1954611200;
				short num2 = num;
				num = (short)1201363129;
				short num3 = num;
				num = (short)1308317881;
				switch (num3 == num)
				{
				}
				num = (short)2026438657;
				if (num != 0)
				{
				}
				num = (short)1466171392;
				if (num != 0)
				{
				}
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x000EE0A8 File Offset: 0x000EC2A8
		// (set) Token: 0x06001655 RID: 5717 RVA: 0x000EE158 File Offset: 0x000EC358
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> ValidateEntityList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1532690432;
				short num2 = num;
				num = (short)141772717;
				short num3 = num;
				num = (short)2127644589;
				switch (num3 == num)
				{
				}
				num = (short)725942273;
				if (num != 0)
				{
				}
				num = (short)740753408;
				if (num != 0)
				{
				}
				return this.<ValidateEntityList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1096613888;
				short num2 = num;
				num = (short)1278938107;
				short num3 = num;
				num = (short)388434939;
				switch (num3 == num)
				{
				}
				num = (short)1759051777;
				if (num != 0)
				{
				}
				num = (short)755433472;
				if (num != 0)
				{
				}
				this.<ValidateEntityList>k__BackingField = value;
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x000EE20C File Offset: 0x000EC40C
		public ValidateEntitySet()
		{
			this.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
			this.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x000EE234 File Offset: 0x000EC434
		public ValidateEntitySet(global::System.Guid relatedObject, global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType type) : this(relatedObject, type, new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>())
		{
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x000EE250 File Offset: 0x000EC450
		public ValidateEntitySet(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> validateEntityList)
		{
			this.ValidateEntityList = validateEntityList;
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x000EE26C File Offset: 0x000EC46C
		public ValidateEntitySet(global::System.Guid relatedObject, global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType type, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> validateEntityList)
		{
			this.RelatedObject = new global::System.Guid?(relatedObject);
			this.Type = type;
			this.ValidateEntityList = validateEntityList;
		}
	}
}
