using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000B0 RID: 176
	public class AddRestoreBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.AddReadWriteBatchJobParameter
	{
		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0008A684 File Offset: 0x00088884
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x0008A730 File Offset: 0x00088930
		public global::System.Guid HistoryCPUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)284378060;
				short num2 = num;
				num = (short)426001356;
				switch (num2 == num)
				{
				}
				num = (short)659161088;
				short num3 = num;
				num = (short)1110900737;
				if (num != 0)
				{
				}
				num = (short)989396992;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)171966465;
				if (num != 0)
				{
				}
				num = (short)1374965494;
				short num2 = num;
				num = (short)1804881654;
				switch (num2 == num)
				{
				default:
				{
					num = (short)686358528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)570359808;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x0008A7E4 File Offset: 0x000889E4
		public AddRestoreBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid? rwJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.JobRequest jobRequest, global::System.Guid histroyCPUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet) : base(batchJobContainerUuid, rwJobContainerUuid, jobRequest, validateSet, true)
		{
			this.HistoryCPUuid = histroyCPUuid;
		}

		// Token: 0x04000617 RID: 1559
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Guid a;
	}
}
