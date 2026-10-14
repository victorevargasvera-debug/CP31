using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200003E RID: 62
	internal class ASTROAddDeviceCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000258 RID: 600 RVA: 0x0001F460 File Offset: 0x0001D660
		public override bool CanExecute(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)39533758;
					short num3 = num2;
					num2 = (short)1987787966;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C8;
					default:
						num2 = (short)1294073857;
						if (num2 != 0)
						{
						}
						num2 = (short)423755776;
						if (num2 != 0)
						{
						}
						try
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.AddRadioContext).Radio.Clone() as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio;
							this.a(astroradio);
							string text;
							return this.ValidateFields(astroradio, out text);
						}
						catch
						{
							return result;
						}
						goto IL_B0;
					}
					break;
				}
				case 1:
					goto IL_C8;
				case 2:
					if (paras != null)
					{
						num2 = (short)1038286851;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					goto IL_B0;
				}
				goto IL_20;
				IL_B0:
				num2 = (short)699793409;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_C8:
				if (paras.Length == 0)
				{
					break;
				}
				num2 = (short)253952000;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_20:
			num2 = (short)1830617088;
			short num4 = num2;
			result = false;
			num2 = (short)1696923650;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0001F5DC File Offset: 0x0001D7DC
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)2027356160;
			switch (num)
			{
			default:
			{
				num = (short)1465647110;
				int num2 = (int)((global::System.IntPtr)num);
				string text;
				global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						if (this.ValidateFields(astroradio, out text))
						{
							goto IL_1FB;
						}
						goto IL_181;
					}
					case 1:
						if (radioSummary != null)
						{
							num = (short)927858695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D1;
					case 2:
						if (paras.Length != 0)
						{
							num = (short)1354629124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_264;
					case 3:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio = this.CreateRadio();
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
						this.AssignRadioFields(apxradio, astroradio);
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug acp = this.CreateCodeplug();
						this.AssginCodeplugFields(acp, astroradio);
						this.AttachCodeplug(acp, astroradio, apxradio);
						radioSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.AddRadio(apxradio);
						num = (short)390594561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.AddRadioContext).Radio as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio;
						this.a(astroradio);
						num = (short)403767296;
						short num3 = num;
						num = (short)985726976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)423559170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_65;
						}
						continue;
					case 7:
						goto IL_141;
					}
					IL_65:
					num = (short)1492059987;
					short num4 = num;
					num = (short)884541267;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_1FB:
						num = (short)1053818883;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1003421696;
						if (num != 0)
						{
						}
						if (paras == null)
						{
							goto IL_264;
						}
						num = (short)279248901;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_D1:
				return null;
				IL_141:
				num = (short)1728446465;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = radioSummary.ToUiModel(true);
				base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
				{
					radioBase
				});
				return radioBase;
				IL_181:
				base.Interaction.ShowNotificationDialog(text, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
				return text;
				IL_264:
				return null;
			}
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0001F850 File Offset: 0x0001DA50
		protected virtual global::Motorola.CommonCPS.Server.EntityModel.APXRadio CreateRadio()
		{
			short num = (short)686623683;
			short num2 = num;
			num = (short)2144799683;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2068185088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1616969728;
			if (num != 0)
			{
			}
			num = (short)1485701121;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.APXRadio();
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0001F900 File Offset: 0x0001DB00
		protected virtual global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug CreateCodeplug()
		{
			short num = (short)586033295;
			short num2 = num;
			num = (short)147400847;
			switch (num2 == num)
			{
			default:
			{
				num = (short)477298688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1533607937;
			if (num != 0)
			{
			}
			num = (short)1581449216;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug();
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0001F9AC File Offset: 0x0001DBAC
		protected virtual void AssignRadioFields(global::Motorola.CommonCPS.Server.EntityModel.APXRadio newRadio, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio radio)
		{
			short num = (short)1284505600;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				for (;;)
				{
					IL_28:
					global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2;
						if (productFamily.GetValueOrDefault() == productFamily2 & productFamily != null)
						{
							num = (short)1927282692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
					{
						num = (short)1706064404;
						short num3 = num;
						num = (short)292387348;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_162;
						default:
							goto IL_1E1;
						}
						break;
					}
					case 2:
						goto IL_162;
					case 3:
					{
						global::System.Guid? id = radio.CurentGroup.ID;
						global::System.Guid empty = global::System.Guid.Empty;
						newRadio.GroupUuid = ((id != null && (id == null || id.GetValueOrDefault() == empty)) ? null : radio.CurentGroup.ID);
						newRadio.ForeignIP = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(radio.ForeignIP);
						newRadio.ReadPassword = radio.PassWord;
						productFamily = radio.ProductFamily;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2 = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP;
						num = (short)1669332992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1670119426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43;
					IL_162:
					productFamily = radio.ProductFamily;
					newRadio.ProductFamily = ((productFamily != null) ? new int?((int)productFamily.GetValueOrDefault()) : null);
					num = (short)469630977;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1E1:
				num = (short)822476800;
				short num4 = num;
				num = (short)65208321;
				if (num != 0)
				{
				}
				num = (short)1976369152;
				if (num != 0)
				{
				}
				return;
				IL_43:
				newRadio.SerialNumber = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(radio.SerialNumber);
				newRadio.DeviceID = newRadio.SerialNumber;
				num = (short)749273091;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0001FC04 File Offset: 0x0001DE04
		protected virtual void AssginCodeplugFields(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug acp, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio radio)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1A4;
				case 1:
					goto IL_184;
				case 2:
					if (string.IsNullOrEmpty(radio.UserPIN))
					{
						num2 = (short)1679687683;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acp.UserPIN = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroPINPasswordConvert(radio.UserPIN, true);
					num2 = (short)1629749249;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					acp.UserPIN = null;
					num2 = (short)1002766336;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_184:
			goto IL_1CD;
			IL_20:
			num2 = (short)1473150278;
			short num3 = num2;
			num2 = (short)228490566;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1A4:
				num2 = (short)120586241;
				if (num2 != 0)
				{
				}
				goto IL_1CD;
			case 1:
				break;
			default:
			{
				num2 = (short)1596129280;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)774373376;
			if (num2 != 0)
			{
			}
			acp.BluetoothDUNSubscriberIP = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(radio.BluetoothDUNSubscriberIP);
			acp.BluetoothDUNPeerIP = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(radio.BluetoothDUNPeerIP);
			acp.BluetoothFriendlyName = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(radio.BluetoothFriendlyName);
			acp.OtarID = radio.OtarID;
			acp.PeerIP = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(radio.PeerIP);
			acp.RadioAlias = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(radio.RadioAlias);
			acp.SubscriberIP = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(radio.SubscriberIP);
			acp.UserName = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(radio.UserName);
			num2 = (short)1882062850;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
			IL_1CD:
			acp.UserLoginUnitID = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(radio.UserLoginUnitID);
			acp.VRID = radio.VRID;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0001FDFC File Offset: 0x0001DFFC
		protected virtual bool ValidateFields(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio radio, out string error)
		{
			short num = (short)306816073;
			short num2 = num;
			num = (short)921871433;
			switch (num2 == num)
			{
			default:
			{
				num = (short)161546240;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)859176960;
			if (num != 0)
			{
			}
			num = (short)1225129985;
			if (num != 0)
			{
			}
			return base.UIValidateService.ValidateNewRadio(radio, out error);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0001FEB8 File Offset: 0x0001E0B8
		protected virtual void AttachCodeplug(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug acp, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio radio, global::Motorola.CommonCPS.Server.EntityModel.APXRadio newRadio)
		{
			short num = (short)1493106691;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)646912336;
				short num3 = num;
				num = (short)1489181008;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_152;
				case 1:
					break;
				default:
				{
					num = (short)1630076928;
					short num4 = num;
					break;
				}
				}
				num = (short)1649475584;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					num = (short)1348730882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					IL_152:
					goto IL_F6;
				case 2:
					if (!string.IsNullOrEmpty(radio.UserPIN))
					{
						num = (short)1996554241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_AD;
					}
					continue;
				case 4:
					return;
				}
				IL_AD:
				num = (short)4194305;
				if (num != 0)
				{
				}
				if (!this.a(acp))
				{
					num = (short)1804075008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F6:
				newRadio.WorkingCodeplug = acp;
				num = (short)1109786628;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0002001C File Offset: 0x0001E21C
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_0)
		{
			short num = (short)2100632815;
			short num2 = num;
			num = (short)263265519;
			switch (num2 == num)
			{
			default:
			{
				num = (short)394657792;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1592655873;
			if (num != 0)
			{
			}
			num = (short)710082560;
			if (num != 0)
			{
			}
			string peerIP = A_0.PeerIP;
			string subscriberIP = A_0.SubscriberIP;
			string bluetoothDUNPeerIP = A_0.BluetoothDUNPeerIP;
			string bluetoothDUNSubscriberIP = A_0.BluetoothDUNSubscriberIP;
			(global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService).AutoGenerateRelatedIPs(ref peerIP, ref subscriberIP, ref bluetoothDUNPeerIP, ref bluetoothDUNSubscriberIP);
			A_0.PeerIP = peerIP;
			A_0.SubscriberIP = subscriberIP;
			A_0.BluetoothDUNPeerIP = bluetoothDUNPeerIP;
			A_0.BluetoothDUNSubscriberIP = bluetoothDUNSubscriberIP;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00020118 File Offset: 0x0001E318
		private bool a(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_6C;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (string.IsNullOrEmpty(A_0.PeerIP))
					{
						num2 = (short)856096780;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					int? num3;
					if (string.IsNullOrEmpty(num3.ToString()))
					{
						num2 = (short)481886213;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 2:
					num2 = (short)374800384;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1614544907;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_379;
				case 5:
					num2 = (short)1259864084;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					int? num3 = A_0.VRID;
					num2 = (short)1596653585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					if (string.IsNullOrEmpty(A_0.BluetoothDUNSubscriberIP))
					{
						num2 = (short)273809412;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 8:
					if (string.IsNullOrEmpty(A_0.BluetoothDUNPeerIP))
					{
						num2 = (short)1618935809;
						if (num2 != 0)
						{
						}
						num2 = (short)334495763;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 9:
					return result;
				case 10:
					num2 = (short)59310087;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (string.IsNullOrEmpty(A_0.CodeplugPassword))
					{
						num2 = (short)1213136902;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 12:
					num2 = (short)1187053581;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (string.IsNullOrEmpty(A_0.UserName))
					{
						num2 = (short)539492368;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 14:
					if (string.IsNullOrEmpty(A_0.RadioAlias))
					{
						num2 = (short)511115279;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 15:
				{
					int? num3 = A_0.OtarID;
					num2 = (short)1960640513;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 16:
					num2 = (short)1886978066;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
				{
					int? num3;
					if (string.IsNullOrEmpty(num3.ToString()))
					{
						num2 = (short)347078678;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 18:
				{
					num2 = (short)1496055808;
					short num4 = num2;
					if (string.IsNullOrEmpty(A_0.UserLoginUnitID))
					{
						num2 = (short)1251737610;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 19:
				{
					num2 = (short)988516727;
					short num5 = num2;
					num2 = (short)114397559;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_379;
					default:
						num2 = (short)485752832;
						if (num2 != 0)
						{
						}
						num2 = (short)593625109;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 20:
					if (string.IsNullOrEmpty(A_0.SubscriberIP))
					{
						num2 = (short)457310210;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 21:
					if (string.IsNullOrEmpty(A_0.BluetoothFriendlyName))
					{
						num2 = (short)1924923395;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 22:
					result = false;
					num2 = (short)28508169;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_6C;
				IL_379:
				num2 = (short)1347026952;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_6C:
			result = true;
			num2 = (short)300417038;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
