using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000031 RID: 49
	public class PrepareResetRadioPasswordCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000226 RID: 550 RVA: 0x0001C4E0 File Offset: 0x0001A6E0
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 4;
			short num = (short)1820393472;
			switch (num)
			{
			default:
			{
				num = (short)1180565504;
				short num2 = num;
				num = (short)758644739;
				int num3 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext resetRadioPasswordContext;
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_E6;
					case 1:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails radioDetails;
						if (radioDetails == null)
						{
							num = (short)257818624;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FF;
					}
					case 2:
						try
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails radioDetails = ((global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService)global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService).GetRadioDetailsBySerialNumber(astroradio.SerialNumber);
							goto IL_B4;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.SERVER_DEVICE_NOT_FOUND)
							{
								while (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date)
								{
									num = (short)595779385;
									short num4 = num;
									num = (short)1888608057;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)272629760;
										if (num != 0)
										{
										}
										goto IL_11A;
									}
								}
								goto IL_18C;
							}
							IL_11A:
							base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.Device_Deleted_By_Other_User_Refresh_Try_Again, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
							IL_18C:
							goto IL_B4;
						}
						goto IL_191;
						IL_B4:
						num = (short)1161166849;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_8B;
						}
						continue;
					case 4:
						goto IL_AF;
					}
					IL_8B:
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio2;
					if (!this.a(paras, out astroradio2))
					{
						num = (short)584843268;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio = (global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)astroradio2.Clone();
						resetRadioPasswordContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext
						{
							Radio = astroradio,
							ID = astroradio.ID
						};
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails radioDetails = null;
						num = (short)2048196610;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_AF:
				goto IL_191;
				IL_E6:
				return false;
				IL_191:
				throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꃴ駶鳸菺跼髾戀眂怄挆⤈樊缌栎搐縒瀔礖洘㬚検昞儠䘢ତܦ氨匪崬䨮到䜲倴匶ᤸ娺ᴼ尾⹀⽂⥄≆⩈㽊⑌⁎㽐獒㙔㡖㝘⽚㱜㙞འ੢୤f䥨੪䵬ᱮᡰᵲቴ᭶ᱸ孺ོṾꦆ", a_), global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("藴零诸髺軼", a_));
				IL_1FF:
				num = (short)670498817;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowResetRadioPasswordDialog(resetRadioPasswordContext);
				return true;
			}
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0001C734 File Offset: 0x0001A934
		public override bool CanExecute(params object[] paras)
		{
			short num;
			bool result;
			try
			{
				num = (short)445841414;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						num = (short)2024275969;
						if (num != 0)
						{
						}
						flag = true;
						goto IL_17F;
					case 1:
					{
						int? productFamily;
						flag = (productFamily.Value == 1);
						goto IL_17F;
					}
					case 2:
						goto IL_197;
					case 3:
						num = (short)919273473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_13B;
					case 5:
					{
						int? productFamily;
						if (productFamily != null)
						{
							num = (short)767164419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)113115136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 7:
						goto IL_120;
					}
					IL_45:
					num = (short)779959358;
					short num3 = num;
					num = (short)839138366;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_120:
						result = false;
						num = (short)1156775940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
					{
						num = (short)1958281216;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (!this.a(paras, out astroradio))
						{
							num = (short)1554055175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int? productFamily = astroradio.ApxRadioSummaryEntity.ProductFamily;
						num = (short)582025221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_17F:
					result = flag;
					num = (short)1967456258;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_13B:
				IL_197:;
			}
			catch (global::System.Exception ex)
			{
				global::System.Diagnostics.Trace.TraceWarning(ex.Message);
				result = false;
			}
			num = (short)184156160;
			short num4 = num;
			return result;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0001C930 File Offset: 0x0001AB30
		private bool a(object[] A_0, out global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> list;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollectionFast;
					if (observableCollectionFast == null)
					{
						num2 = (short)1370750978;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					list = observableCollectionFast.OfType<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>();
					num2 = (short)1348665345;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (list.Count != 1)
					{
						num2 = (short)241762304;
						short num3 = num2;
						num2 = (short)201981957;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BE;
				case 2:
					goto IL_1B9;
				case 3:
					if (A_0.Length != 0)
					{
						num2 = (short)19791876;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollectionFast = A_0[0] as global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>;
					num2 = (short)582746112;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_D1;
				case 6:
					if (A_0 != null)
					{
						num2 = (short)809172999;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 7:
					num2 = (short)1375404035;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
			}
			IL_D1:
			num2 = (short)594204973;
			short num4 = num2;
			num2 = (short)1151326509;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1BE:
				A_1 = list[0];
				return true;
			default:
				num2 = (short)283639808;
				if (num2 != 0)
				{
				}
				num2 = (short)158466049;
				if (num2 != 0)
				{
				}
				return false;
			}
			return false;
			IL_1B9:
			return false;
			IL_30:
			A_1 = null;
			num2 = (short)1517027334;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
