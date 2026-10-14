using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.BatchOperationJobParameter
{
	// Token: 0x020001F7 RID: 503
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MoveQuerysBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x0010C038 File Offset: 0x0010A238
		// (set) Token: 0x060018CA RID: 6346 RVA: 0x0010C0E8 File Offset: 0x0010A2E8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? QueryGroupUuidTo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)912984674;
				short num2 = num;
				num = (short)1012861538;
				switch (num2 == num)
				{
				}
				num = (short)903020544;
				short num3 = num;
				num = (short)217251840;
				if (num != 0)
				{
				}
				num = (short)1758724097;
				if (num != 0)
				{
				}
				return this.<QueryGroupUuidTo>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1604561481;
				short num2 = num;
				num = (short)1601940041;
				switch (num2 == num)
				{
				}
				num = (short)1695940608;
				short num3 = num;
				num = (short)740950017;
				if (num != 0)
				{
				}
				num = (short)370999296;
				if (num != 0)
				{
				}
				this.<QueryGroupUuidTo>k__BackingField = value;
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x0010C198 File Offset: 0x0010A398
		// (set) Token: 0x060018CC RID: 6348 RVA: 0x0010C24C File Offset: 0x0010A44C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid QueryUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)256283744;
				short num2 = num;
				num = (short)1415222368;
				switch (num2 == num)
				{
				}
				num = (short)1587347456;
				short num3 = num;
				num = (short)953221121;
				if (num != 0)
				{
				}
				num = (short)34799616;
				if (num != 0)
				{
				}
				return this.<QueryUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1648385096;
				short num2 = num;
				num = (short)1260149832;
				switch (num2 == num)
				{
				}
				num = (short)1391132672;
				short num3 = num;
				num = (short)946077697;
				if (num != 0)
				{
				}
				num = (short)2066022400;
				if (num != 0)
				{
				}
				this.<QueryUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x0010C2FC File Offset: 0x0010A4FC
		// (set) Token: 0x060018CE RID: 6350 RVA: 0x0010C3AC File Offset: 0x0010A5AC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet EntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1709480280;
				short num2 = num;
				num = (short)29989208;
				switch (num2 == num)
				{
				}
				num = (short)1340276736;
				short num3 = num;
				num = (short)288161792;
				if (num != 0)
				{
				}
				num = (short)894566401;
				if (num != 0)
				{
				}
				return this.<EntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1355615273;
				short num2 = num;
				num = (short)1798966313;
				switch (num2 == num)
				{
				}
				num = (short)633864192;
				short num3 = num;
				num = (short)1000734721;
				if (num != 0)
				{
				}
				num = (short)377749504;
				if (num != 0)
				{
				}
				this.<EntitySet>k__BackingField = value;
			}
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0010C460 File Offset: 0x0010A660
		public MoveQuerysBatchJobParameter(global::System.Guid batchJobContainerUuid) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
		}
	}
}
