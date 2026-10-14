using System;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000052 RID: 82
	internal class ExportDVRS_Command : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x00028594 File Offset: 0x00026794
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)724566016;
			switch (num)
			{
			default:
			{
				num = (short)1680736263;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
					bool? isOutOfSync;
					bool flag;
					switch (num2)
					{
					case 0:
						return false;
					case 1:
						goto IL_FB;
					case 2:
						if (observableCollection.Count != 0)
						{
							num = (short)262406152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						goto IL_BA;
					case 4:
						if (astroradio.RadioStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus.New)
						{
							num = (short)1548419073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						if (observableCollection.Count > 1)
						{
							num = (short)1801191430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						astroradio = (observableCollection[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio);
						num = (short)1193672713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_29C;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_73;
						}
						continue;
					case 8:
					{
						num = (short)1856006051;
						short num3 = num;
						num = (short)1943365539;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FB;
						default:
							num = (short)2037907456;
							if (num != 0)
							{
							}
							num = (short)617611269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						if (astroradio == null)
						{
							num = (short)912457738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1709309956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return false;
					case 11:
						if (isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null)
						{
							num = (short)967311360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					IL_73:
					num = (short)832634880;
					short num4 = num;
					if (paras.Length == 0)
					{
						num = (short)716177411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					observableCollection = (paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>);
					num = (short)601489410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FB:
					isOutOfSync = astroradio.IsOutOfSync;
					flag = true;
					num = (short)1247870987;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BA:
				num = (short)1814953985;
				if (num != 0)
				{
				}
				return false;
				IL_29C:
				return false;
			}
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00028844 File Offset: 0x00026A44
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 17;
			short num = (short)1143209984;
			switch (num)
			{
			default:
			{
				num = (short)202571779;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService iastroradioService;
				string text;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)296812548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_B0;
					case 2:
					{
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
						if (observableCollection.Count != 0)
						{
							num = (short)1679622144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CF;
					}
					case 3:
						goto IL_3B;
					case 4:
					{
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
						if (observableCollection.Count > 1)
						{
							num = (short)1157758983;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						astroradio = (observableCollection[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio);
						iastroradioService = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService);
						string fileName = global::Motorola.CommonCPS.ResourceRepository.Resources.AstroSubSystemType_DVRS + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("崁", a_) + astroradio.SerialNumber;
						this.a(ref fileName);
						text = base.Interaction.ShowSaveFileDialogForExportDVRS(fileName);
						num = (short)1747320837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						if (string.IsNullOrEmpty(text))
						{
							num = (short)1023016966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)819797717;
						short num3 = num;
						num = (short)2138054357;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3B;
						default:
							goto IL_206;
						}
						break;
					}
					case 6:
						goto IL_145;
					case 7:
						goto IL_183;
					}
					goto IL_6C;
					IL_3B:
					switch (0)
					{
					case 0:
					{
						IL_6C:
						num = (short)301137920;
						short num4 = num;
						if (paras.Length == 0)
						{
							num = (short)118554625;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection = paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>;
							num = (short)763035650;
							num2 = (int)((global::System.IntPtr)num);
						}
						break;
					}
					}
				}
				IL_B0:
				return null;
				IL_145:
				return null;
				IL_183:
				IL_1CF:
				return null;
				IL_206:
				num = (short)1248591873;
				if (num != 0)
				{
				}
				num = (short)1521287168;
				if (num != 0)
				{
				}
				iastroradioService.ExportDVRS(astroradio.ID.Value, text);
				base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.Message_Export_successful, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ExportDVRS);
				return null;
			}
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00028AC4 File Offset: 0x00026CC4
		private void a(ref string A_0)
		{
			int a_ = 19;
			short num = (short)1400045569;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A3;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 2:
					A_0 += global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("⨃", a_);
					goto IL_118;
				case 3:
					num = (short)311820289;
					if (num != 0)
					{
					}
					num = (short)685375493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return;
				case 5:
				{
					if (A_0.EndsWith(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("⨃", a_), global::System.StringComparison.CurrentCulture))
					{
						goto IL_A3;
					}
					num = (short)2095656287;
					short num3 = num;
					num = (short)1060842847;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_118;
					default:
						num = (short)140836864;
						if (num != 0)
						{
						}
						num = (short)1699282946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_46:
				if (!A_0.EndsWith(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("⨃縅攇昉", a_), global::System.StringComparison.CurrentCultureIgnoreCase))
				{
					num = (short)1178796035;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A3:
				A_0 += global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("簃欅搇", a_);
				num = (short)1004994560;
				short num4 = num;
				num = (short)1944256516;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_118:
				num = (short)1113718784;
				num2 = (int)((global::System.IntPtr)num);
			}
		}
	}
}
