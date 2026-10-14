using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000BA RID: 186
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class CfsUpgradeRadioBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0008D1D8 File Offset: 0x0008B3D8
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x0008D288 File Offset: 0x0008B488
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.RadioUpgradeRequest Request
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1066554994;
				short num2 = num;
				num = (short)1874679410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)717488128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)355270656;
				if (num != 0)
				{
				}
				num = (short)385089537;
				if (num != 0)
				{
				}
				return this.<Request>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)907995716;
				short num2 = num;
				num = (short)2010507844;
				switch (num2 == num)
				{
				default:
				{
					num = (short)423886848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1746010113;
				if (num != 0)
				{
				}
				num = (short)1635778560;
				if (num != 0)
				{
				}
				this.<Request>k__BackingField = value;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0008D338 File Offset: 0x0008B538
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x0008D3E8 File Offset: 0x0008B5E8
		[global::System.Runtime.Serialization.DataMember]
		public byte[] CLLresponce
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)834076673;
				if (num != 0)
				{
				}
				num = (short)916127744;
				short num2 = num;
				num = (short)474374397;
				short num3 = num;
				num = (short)745169149;
				switch (num3 == num)
				{
				}
				num = (short)687865856;
				if (num != 0)
				{
				}
				return this.<CLLresponce>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1525748493;
				short num2 = num;
				num = (short)1198134029;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1597374464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1267138560;
				if (num != 0)
				{
				}
				num = (short)1856045057;
				if (num != 0)
				{
				}
				this.<CLLresponce>k__BackingField = value;
			}
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0008D49C File Offset: 0x0008B69C
		public CfsUpgradeRadioBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioUpgradeRequest request) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.Request = request;
		}
	}
}
