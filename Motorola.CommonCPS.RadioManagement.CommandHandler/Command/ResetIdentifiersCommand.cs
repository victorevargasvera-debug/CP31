using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000B1 RID: 177
	internal class ResetIdentifiersCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060003DE RID: 990 RVA: 0x000402A4 File Offset: 0x0003E4A4
		public override bool CanExecute(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_69;
			}
			short num;
			int num3;
			global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext resetIdentifiersContext;
			for (;;)
			{
				IL_0A:
				num = (short)123778443;
				short num2 = num;
				num = (short)1775089035;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)970915840;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_DA;
					case 1:
						return false;
					case 2:
						if (resetIdentifiersContext.HasError())
						{
							num = (short)321585155;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						return false;
					}
					goto IL_69;
				}
				IL_DA:
				if (string.IsNullOrEmpty(resetIdentifiersContext.Password))
				{
					num = (short)842399745;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)762773506;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
			IL_69:
			num = (short)350945281;
			if (num != 0)
			{
			}
			num = (short)1490616320;
			short num4 = num;
			resetIdentifiersContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext);
			num = (short)97845248;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000403F4 File Offset: 0x0003E5F4
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)758579200;
			short num2 = num;
			num = (short)1772217730;
			short num3 = num;
			num = (short)1133962626;
			switch (num3 == num)
			{
			}
			num = (short)1099628544;
			if (num != 0)
			{
			}
			num = (short)23003137;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext resetIdentifiersContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext;
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			validateEntitySet.RelatedObject = new global::System.Guid?(resetIdentifiersContext.RadioUuid);
			validateEntitySet.ValidateEntityList.Add(new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField(resetIdentifiersContext.RadioUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio, resetIdentifiersContext.RadioTimestamp));
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary rawData = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ResetIdentifiers(resetIdentifiersContext.RadioUuid, resetIdentifiersContext.RadioID, resetIdentifiersContext.CAI, resetIdentifiersContext.Password, resetIdentifiersContext.LinkTypes, validateEntitySet);
			base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
			{
				rawData.ToUiModel(true)
			});
			return null;
		}
	}
}
