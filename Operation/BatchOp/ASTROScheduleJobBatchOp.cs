using System;
using System.Collections.ObjectModel;
using ASK.Interface;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000022 RID: 34
	public class ASTROScheduleJobBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.ScheduleJobBatchOp
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x00018E6C File Offset: 0x0001706C
		public ASTROScheduleJobBatchOp(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext context) : base(context)
		{
			base.JobType = global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2Enum.ConverterUiJobTypeToServerJobType(context.Type, true);
			this.a = null;
			this.b = null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00018EA8 File Offset: 0x000170A8
		protected override void ValidateDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio d, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isWriteProtected, bool isGeneratingConfig, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest fieldsModifyRequest, out int supportedConnections, out global::Motorola.CommonCPS.Server.CommonDBConstants.JobType correctedJobType)
		{
			short num = (short)652628590;
			short num2 = num;
			num = (short)1317098094;
			switch (num2 == num)
			{
			}
			num = (short)1855717377;
			if (num != 0)
			{
			}
			num = (short)30736384;
			if (num != 0)
			{
			}
			num = (short)1670381568;
			short num3 = num;
			(base.ValidationServiceFactory.RadioValidationService as global::Motorola.CommonCPS.RadioManagement.LocalService.ASTRORadioValidationService).ValidateDevice(d, type, isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified, transport, isWriteProtected, isGeneratingConfig, out fieldsModifyRequest, out supportedConnections, out correctedJobType, ref this.a, ref this.b);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00018F84 File Offset: 0x00017184
		protected override void ValidateDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio d, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isWriteProtected, bool isGeneratingConfig, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest fieldsModifyRequest, out int supportedConnections)
		{
			short num = (short)1395130369;
			if (num != 0)
			{
			}
			num = (short)1416774783;
			short num2 = num;
			num = (short)1443251327;
			switch (num2 == num)
			{
			}
			num = (short)111083520;
			if (num != 0)
			{
			}
			num = (short)1121124352;
			short num3 = num;
			(base.ValidationServiceFactory.RadioValidationService as global::Motorola.CommonCPS.RadioManagement.LocalService.ASTRORadioValidationService).ValidateDevice(d, type, isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified, transport, isWriteProtected, isGeneratingConfig, out fieldsModifyRequest, out supportedConnections, ref this.a, ref this.b);
		}

		// Token: 0x04000040 RID: 64
		private global::System.Collections.ObjectModel.Collection<global::ASK.Interface.ISystemKeyData> a;

		// Token: 0x04000041 RID: 65
		private bool? b;
	}
}
