using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000059 RID: 89
	internal class PrepareWiFiPasswordValidationCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060002DA RID: 730 RVA: 0x0002A7B8 File Offset: 0x000289B8
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)511913978;
			short num2 = num;
			num = (short)1325346810;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1765539840;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)582025217;
			if (num != 0)
			{
			}
			num = (short)1268514816;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0002A864 File Offset: 0x00028A64
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1719533568;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_64;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext wiFiPasswordValidationContext;
				for (;;)
				{
					IL_29:
					global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
					global::Motorola.CommonCPS.RadioManagement.Command.ASTROWiFiPWDValidation astrowiFiPWDValidation;
					switch (num2)
					{
					case 0:
						goto IL_2BD;
					case 1:
						while (apxtemplate == null)
						{
							num = (short)833485926;
							short num3 = num;
							num = (short)1093991526;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)350158848;
								if (num != 0)
								{
								}
								num = (short)427294732;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_29;
							}
						}
						goto IL_2BD;
					case 2:
						goto IL_EB;
					case 3:
						if (global::System.Windows.Application.Current != null)
						{
							num = (short)460324865;
							if (num != 0)
							{
							}
							num = (short)1480851462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						base.Interaction.ShowWiFiPasswordValidationDialog(wiFiPasswordValidationContext);
						num = (short)179634178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)889061384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_154;
					case 6:
						global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(delegate()
						{
							short num5 = (short)500096027;
							short num6 = num5;
							num5 = (short)1895685147;
							switch (num6 == num5)
							{
							default:
							{
								num5 = (short)706019328;
								short num7 = num5;
								break;
							}
							case true:
								break;
							}
							num5 = (short)2057764864;
							if (num5 != 0)
							{
							}
							num5 = (short)289996801;
							if (num5 != 0)
							{
							}
							this.Interaction.ShowWiFiPasswordValidationDialog(wiFiPasswordValidationContext);
						}), global::System.Array.Empty<object>()).Wait();
						num = (short)1079509002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)196804611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (paras[0].GetType().Equals(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext)))
						{
							num = (short)1754726405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_390;
					case 9:
						if (!paras[0].GetType().Equals(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate)))
						{
							num = (short)167706628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_154;
					case 10:
						goto IL_288;
					case 11:
						if (astrowiFiPWDValidation.NeedValidation(apxtemplate))
						{
							num = (short)1292042247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28D;
					case 12:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext).SelectedTemplates[0];
						apxtemplate = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetTemplate(templateBase.TemplateID, false) as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate);
						num = (short)785317888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_64;
					IL_154:
					apxtemplate = (paras[0] as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate);
					num = (short)1062404097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BD:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork> listAPXWiFiNetwork = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().XMLToEntityCollections<global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork>(apxtemplate.WiFiNetworks).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork>();
					wiFiPasswordValidationContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext(listAPXWiFiNetwork, apxtemplate);
					astrowiFiPWDValidation = new global::Motorola.CommonCPS.RadioManagement.Command.ASTROWiFiPWDValidation(wiFiPasswordValidationContext);
					wiFiPasswordValidationContext.WiFiNetworks = global::System.Windows.Data.CollectionViewSource.GetDefaultView(astrowiFiPWDValidation.WifiNetworkItemSource);
					num = (short)1804468235;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_EB:
				IL_1E4:
				return wiFiPasswordValidationContext.IsValidationPass;
				IL_288:
				goto IL_1E4;
				IL_28D:
				num = (short)900988928;
				short num4 = num;
				return true;
				IL_390:
				return null;
				IL_64:
				num = (short)1009909769;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0002AC04 File Offset: 0x00028E04
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork> a(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0)
		{
			int a_ = 18;
			short num;
			for (;;)
			{
				IL_09:
				num = (short)613744640;
				switch (num)
				{
				default:
				{
					num = (short)1055391757;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2;
						switch (num2)
						{
						case 0:
						{
							if (global::Motorola.CommonCPS.Common.CommonUtility.Utility.BFSNodeByNodeName(A_0, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䜂搄猆栈尊搌欎琐䐒尔儖倘帚猜縞䌠伢䀤砦ᴨᤪᠬἮܰ", a_)) == null)
							{
								num = (short)308412422;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode = global::Motorola.CommonCPS.Common.CommonUtility.Utility.BFSNodeByNodeName(dbnode2, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䀂樄椆漈戊樌税挐瘒焔外簘漚樜瀞匠䠢嘤欦䀨堪夬", a_));
							num = (short)728236040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_247;
						case 2:
							goto IL_125;
						case 3:
							if (!string.IsNullOrEmpty(A_0.Name))
							{
								num = (short)1080295436;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7F1;
						case 4:
						{
							dbnode2 = A_0;
							num = (short)291603327;
							short num3 = num;
							num = (short)179340159;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)10682368;
								if (num != 0)
								{
								}
								num = (short)410976271;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							if (dbnode2 == null)
							{
								num = (short)117702663;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1481244672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_175;
						case 7:
							goto IL_27E;
						case 8:
						{
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
							if (dbnode == null)
							{
								num = (short)15532032;
								short num4 = num;
								num = (short)182845442;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork>();
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator = dbnode.ChildNodesList.GetEnumerator();
							num = (short)609550352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							if (dbnode2 == null)
							{
								num = (short)617873422;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_247;
						case 10:
							if (A_0.Name == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䜂搄猆栈尊搌欎琐", a_))
							{
								num = (short)789839876;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7F1;
						case 11:
							goto IL_AC;
						case 12:
							num = (short)738066442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							switch (0)
							{
							case 0:
								goto IL_91;
							}
							continue;
						case 14:
							dbnode2 = global::Motorola.CommonCPS.Common.CommonUtility.Utility.BFSNodeByNodeName(A_0, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䜂搄猆栈尊搌欎琐", a_));
							num = (short)1113128961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							goto IL_7F1;
						case 16:
							goto IL_1F9;
						}
						IL_91:
						if (A_0 == null)
						{
							num = (short)165281803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dbnode2 = null;
						num = (short)2002649091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_247:
						num = (short)13631493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_7F1:
						num = (short)1473576969;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_AC:
			return null;
			IL_125:
			goto IL_7EF;
			IL_175:
			return null;
			IL_1F9:
			try
			{
				num = (short)109641730;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork> list;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1587609603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)1761345536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode3 = enumerator.Current;
						global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork apxwiFiNetwork = new global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork();
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator2 = dbnode3.ChildNodesList.GetEnumerator();
						num = (short)2083127300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_354;
						}
						continue;
					case 3:
						goto IL_7DC;
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork apxwiFiNetwork;
						try
						{
							num = (short)733282317;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_64A;
								case 1:
									num = (short)1339817992;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.CommonCPS.Server.EntityModel.DBField dbfield;
									if (dbfield.Value == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䨂䄄堆师上崌", a_))
									{
										num = (short)807862292;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D8;
								}
								case 3:
									goto IL_719;
								case 4:
								{
									global::Motorola.CommonCPS.Server.EntityModel.DBField dbfield;
									if (dbfield.Name == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䜂搄猆栈尊搌欎琐䐒簔儖瀘唚砜欞嘠䰢圤䰦稨个丬娮䌰娲䄴丶洸䈺䴼娾Ṁ睂睄牆硈絊", a_))
									{
										num = (short)1225392129;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_64A;
								}
								case 5:
								{
									global::Motorola.CommonCPS.Server.EntityModel.DBField dbfield;
									if (dbfield.Name == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䜂搄猆栈尊搌欎琐䐒簔儖瀘唚砜欞嘠䰢圤䰦稨砪搬欮渰ܴܲȶ࠸Ⱥ", a_))
									{
										num = (short)557645840;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_480;
								}
								case 7:
								{
									global::Motorola.CommonCPS.Server.EntityModel.DBField dbfield;
									if (dbfield.Name == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䜂搄猆栈尊搌欎琐䐒簔儖瀘唚砜欞嘠䰢圤䰦氨䔪丬崮䠰䌲䄴制崸町堼䬾㙀ⱂ㝄ⱆ᥈⩊㹌㱎♐㱒❔㍖٘潚潜橞偠呢", a_))
									{
										num = (short)406519819;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::Motorola.CommonCPS.Server.EntityModel.DBField dbfield;
									if (dbfield.Value == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䨂䄄堆䜈䐊䌌䨎", a_))
									{
										num = (short)479526924;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_550;
								}
								case 9:
									apxwiFiNetwork.NetworkSecureType = 2;
									num = (short)707657728;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_550;
								case 11:
								{
									global::Motorola.CommonCPS.Server.EntityModel.DBField dbfield;
									apxwiFiNetwork.NetworkPWD = dbfield.Value;
									num = (short)1892417542;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									apxwiFiNetwork.NetworkSecureType = 0;
									num = (short)928776202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									switch (0)
									{
									case 0:
										goto IL_3D3;
									}
									continue;
								case 14:
									goto IL_480;
								case 15:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1423179794;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBField dbfield = enumerator2.Current as global::Motorola.CommonCPS.Server.EntityModel.DBField;
									dbfield.Name == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䜂搄猆栈尊搌欎琐䐒簔儖瀘唚砜欞嘠䰢圤䰦礨太䐬䀮䌰娲䄴丶昸༺༼ਾ灀煂", a_);
									num = (short)125960197;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
								{
									global::Motorola.CommonCPS.Server.EntityModel.DBField dbfield;
									apxwiFiNetwork.NetworkSSID = dbfield.Value;
									num = (short)1211695118;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
								{
									global::Motorola.CommonCPS.Server.EntityModel.DBField dbfield;
									if (dbfield.Value == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䨂䄄堆师嬊䰌㴎䘐䌒吔", a_))
									{
										num = (short)1949237257;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_64A;
								}
								case 18:
									num = (short)1944977411;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									goto IL_3D8;
								case 20:
									apxwiFiNetwork.NetworkSecureType = 1;
									num = (short)610664467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3D3;
								IL_3D8:
								num = (short)1575878673;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_480:
								num = (short)1592721412;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_550:
								num = (short)1915551746;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_64A:
								num = (short)3932167;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6C2:
								num = (short)665255951;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3D3:
								goto IL_6C2;
							}
							IL_719:
							goto IL_769;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						break;
						IL_769:
						list.Add(apxwiFiNetwork);
						num = (short)1266221061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_729:
					num = (short)2067136513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_354:
					goto IL_729;
				}
				IL_7DC:
				return list;
			}
			finally
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator;
				((global::System.IDisposable)enumerator).Dispose();
			}
			goto IL_7EF;
			IL_27E:
			num = (short)721289217;
			if (num != 0)
			{
			}
			return null;
			IL_7EF:
			return null;
		}

		// Token: 0x0400005C RID: 92
		public bool ExtendRet;
	}
}
