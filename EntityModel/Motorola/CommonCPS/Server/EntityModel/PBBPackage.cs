using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200006A RID: 106
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBProvisioning))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBFirmware))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBHomeSet))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBApplication))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBApplicationShortcut))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBApplicationWidget))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBCertificate))]
	[global::System.Serializable]
	public class PBBPackage : global::Motorola.CommonCPS.Server.EntityModel.Package
	{
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x0005AC9C File Offset: 0x00058E9C
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x0005AD4C File Offset: 0x00058F4C
		[global::System.Runtime.Serialization.DataMember]
		public int? TargetDevice
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2073244320;
				short num2 = num;
				num = (short)1325675168;
				switch (num2 == num)
				{
				}
				num = (short)843120640;
				short num3 = num;
				num = (short)1286864897;
				if (num != 0)
				{
				}
				num = (short)2028077056;
				if (num != 0)
				{
				}
				return this.<TargetDevice>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1565942207;
				short num2 = num;
				num = (short)1582129599;
				switch (num2 == num)
				{
				}
				num = (short)453967872;
				short num3 = num;
				num = (short)570228737;
				if (num != 0)
				{
				}
				num = (short)1001848832;
				if (num != 0)
				{
				}
				this.<TargetDevice>k__BackingField = value;
			}
		}
	}
}
