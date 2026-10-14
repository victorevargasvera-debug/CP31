using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.Security.SamlCommonUtility.DMHttpClients;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000014 RID: 20
	internal class AstroUploadCodeplugCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000057 RID: 87 RVA: 0x000072C0 File Offset: 0x000054C0
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 4;
			short num = (short)1941897216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				string[] array;
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IDMServiceAccessor idmserviceAccessor;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						string text;
						if (!string.Equals(global::System.IO.Path.GetExtension(text), global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("\udbf4髶髸", a_), global::System.StringComparison.OrdinalIgnoreCase))
						{
							num = (short)1721368578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> headers = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
						{
							new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("꛴鋶诸跺铼鳾搀䈂昄搆昈縊挌笎䐐怒瀔攖", a_), global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.PreferredUsernameFromToken),
							new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("꛴飶賸觺黼髾䀀猂甄", a_), global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꟴ뫶뫸韺铼髾漀眂", a_)),
							new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("跴\udaf6铸裺탼鷾洀氂朄⨆紈爊紌樎", a_), global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("럴鯶雸飺雼뷾洀氂朄", a_))
						};
						num = (short)700841985;
						if (num != 0)
						{
						}
						num = (short)109379588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (array != null)
						{
							num = (short)738918409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EC;
					case 2:
						goto IL_33C;
					case 3:
					{
						if (!array.Any<string>())
						{
							num = (short)1172176904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1259824097;
						short num3 = num;
						num = (short)88171489;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_BD;
						default:
						{
							num = (short)852492288;
							if (num != 0)
							{
							}
							string text = array.Single<string>();
							num = (short)412155904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
					{
						num = (short)769196032;
						short num4 = num;
						string text;
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> headers;
						if (!idmserviceAccessor.UploadMotorolaCodeplug(global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMHttpClientFactory<global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMStorageServiceClient>.Create(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingJwtToken, headers), text))
						{
							num = (short)2113536006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.InternalInstances.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_UploadCodeplugCommand_SuccessfullyUploadedCodeplug, global::Motorola.CommonCPS.ResourceRepository.Resources.SuccessInfo);
						num = (short)1803550725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_220;
					case 6:
						this.InternalInstances.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_UploadCodeplugCommand_FailedToUploadCodeplugs, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
						num = (short)284033031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_294;
					case 8:
						goto IL_25F;
					case 9:
						goto IL_BD;
					}
					goto IL_5F;
					IL_BD:
					num = (short)1452015619;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1EC:
				return null;
				IL_220:
				goto IL_341;
				IL_25F:
				goto IL_1EC;
				IL_294:
				goto IL_341;
				IL_33C:
				this.InternalInstances.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_UploadCodeplugCommand_FileExtensionError, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
				return null;
				IL_341:
				return null;
				IL_5F:
				idmserviceAccessor = (global::Motorola.CommonCPS.RadioManagement.SharedServices.IDMServiceAccessor)paras.Single<object>();
				array = this.InternalInstances.Interaction.ShowOpenFileDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_MC, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_UploadCodeplugCommand_SelectCodeplugsToUpload, false);
				num = (short)544735233;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}
	}
}
