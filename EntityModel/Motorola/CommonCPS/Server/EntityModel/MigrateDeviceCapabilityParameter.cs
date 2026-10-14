using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000C1 RID: 193
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrateDeviceCapabilityParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x0008E824 File Offset: 0x0008CA24
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x0008E8D4 File Offset: 0x0008CAD4
		public global::Motorola.CommonCPS.Server.EntityModel.DeviceCapability DeviceCapabilityInstence
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1807624938;
				short num2 = num;
				num = (short)1575496426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1552351232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)928055297;
				if (num != 0)
				{
				}
				num = (short)1998520320;
				if (num != 0)
				{
				}
				return this.<DeviceCapabilityInstence>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1146951754;
				short num2 = num;
				num = (short)1752963146;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1907032064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1577189377;
				if (num != 0)
				{
				}
				num = (short)545193984;
				if (num != 0)
				{
				}
				this.<DeviceCapabilityInstence>k__BackingField = value;
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x0008E984 File Offset: 0x0008CB84
		public MigrateDeviceCapabilityParameter(global::Motorola.CommonCPS.Server.EntityModel.DeviceCapability deviceCapability, string jobDescription) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			this.DeviceCapabilityInstence = deviceCapability;
			base.JobDescription = jobDescription;
		}
	}
}
