using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000DB RID: 219
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ImportPackageBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00092F10 File Offset: 0x00091110
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x00092FC4 File Offset: 0x000911C4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Package Package
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1737707008;
				short num2 = num;
				num = (short)2043104768;
				switch (num2 == num)
				{
				}
				num = (short)1745747968;
				short num3 = num;
				num = (short)1038352384;
				if (num != 0)
				{
				}
				num = (short)1383464961;
				if (num != 0)
				{
				}
				return this.<Package>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1711696420;
				short num2 = num;
				num = (short)20015652;
				switch (num2 == num)
				{
				}
				num = (short)991035392;
				short num3 = num;
				num = (short)201064449;
				if (num != 0)
				{
				}
				num = (short)1162870784;
				if (num != 0)
				{
				}
				this.<Package>k__BackingField = value;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00093074 File Offset: 0x00091274
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x00093124 File Offset: 0x00091324
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> ASTROFirmwares
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)797174724;
				short num2 = num;
				num = (short)1119480772;
				switch (num2 == num)
				{
				}
				num = (short)203751424;
				short num3 = num;
				num = (short)1713897472;
				if (num != 0)
				{
				}
				num = (short)1506607105;
				if (num != 0)
				{
				}
				return this.<ASTROFirmwares>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2106157915;
				short num2 = num;
				num = (short)897084251;
				switch (num2 == num)
				{
				}
				num = (short)925630464;
				short num3 = num;
				num = (short)2100101120;
				if (num != 0)
				{
				}
				num = (short)915931137;
				if (num != 0)
				{
				}
				this.<ASTROFirmwares>k__BackingField = value;
			}
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x000931D8 File Offset: 0x000913D8
		public ImportPackageBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Package package) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.Package = package;
			this.ASTROFirmwares = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware>();
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0009320C File Offset: 0x0009140C
		public ImportPackageBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> AstroFirmwares) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.Package = null;
			if (AstroFirmwares == null)
			{
				this.ASTROFirmwares = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware>();
				return;
			}
			this.ASTROFirmwares = AstroFirmwares;
		}
	}
}
