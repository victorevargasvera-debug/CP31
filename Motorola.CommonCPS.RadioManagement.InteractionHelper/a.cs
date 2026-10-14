using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using CommonUtility;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Win32;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using RFResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.InteractionHelper
{
	// Token: 0x02000003 RID: 3
	internal class a : global::Motorola.CommonCPS.RadioManagement.InteractionHelper.IInteraction
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		internal a()
		{
			this.a = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Events.IEventAggregator>();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002140 File Offset: 0x00000340
		internal a(global::Microsoft.Practices.Prism.Events.IEventAggregator A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000215C File Offset: 0x0000035C
		public string GetCurrentViewId()
		{
			short num = (short)320519207;
			short num2 = num;
			num = (short)319536167;
			switch (num2 == num)
			{
			}
			num = (short)859111424;
			short num3 = num;
			num = (short)519241728;
			if (num != 0)
			{
			}
			num = (short)953876481;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002208 File Offset: 0x00000408
		public bool Go(string moduleName)
		{
			short num = (short)575403682;
			short num2 = num;
			num = (short)1863710370;
			switch (num2 == num)
			{
			}
			num = (short)1655177216;
			short num3 = num;
			num = (short)1472659457;
			if (num != 0)
			{
			}
			num = (short)855965696;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.NavigateToMainModuleRequestedEvent>().Publish(moduleName);
			return global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == moduleName;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022CC File Offset: 0x000004CC
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo GetDataGridInfoForRadios()
		{
			short num = (short)1079649069;
			short num2 = num;
			num = (short)169419565;
			switch (num2 == num)
			{
			}
			num = (short)1934622720;
			short num3 = num;
			num = (short)533987329;
			if (num != 0)
			{
			}
			num = (short)1932001280;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo> resultPayload = new global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo>();
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GetDataGridInfoForRadiosRequestedEvent>().Publish(resultPayload);
			return resultPayload.Result;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002390 File Offset: 0x00000590
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo GetDataGridInfoForAstroSystem()
		{
			short num = (short)1726482501;
			short num2 = num;
			num = (short)189794373;
			switch (num2 == num)
			{
			}
			num = (short)1887502336;
			short num3 = num;
			num = (short)1804992513;
			if (num != 0)
			{
			}
			num = (short)698417152;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo> resultPayload = new global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo>();
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GetDataGridForASTROSystemRequestedEvent>().Publish(resultPayload);
			return resultPayload.Result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002458 File Offset: 0x00000658
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo GetDataGridInfoForDataProfile()
		{
			short num = (short)1432417714;
			short num2 = num;
			num = (short)1264842162;
			switch (num2 == num)
			{
			}
			num = (short)1825505280;
			short num3 = num;
			num = (short)1603731457;
			if (num != 0)
			{
			}
			num = (short)1949171712;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo> resultPayload = new global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo>();
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GetDataGridInfoForDataProfileRequestedEvent>().Publish(resultPayload);
			return resultPayload.Result;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002520 File Offset: 0x00000720
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo GetDataGridInfoForOtarProfile()
		{
			short num = (short)240918507;
			short num2 = num;
			num = (short)1534468075;
			switch (num2 == num)
			{
			}
			num = (short)20119552;
			short num3 = num;
			num = (short)208273408;
			if (num != 0)
			{
			}
			num = (short)266862593;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo> resultPayload = new global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo>();
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GetDataGridInfoForOtarProfileRequestedEvent>().Publish(resultPayload);
			return resultPayload.Result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000025E8 File Offset: 0x000007E8
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> GetGroupCollection()
		{
			short num = (short)384696321;
			if (num != 0)
			{
			}
			num = (short)667545471;
			short num2 = num;
			num = (short)558755711;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1745813504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)365232128;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>> list = new global::System.Collections.Generic.List<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>>();
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GetGroupCollectionRequestedEvent>().Publish(list);
			return list[0];
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000026B0 File Offset: 0x000008B0
		private void a()
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num;
			short num2;
			string activeMainModule;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)238223362;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_1D0;
				case 2:
					if (!(activeMainModule == global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("䘆娈弊弌䀎䈐樒昔挖簘瘚", a_)))
					{
						num2 = (short)276955144;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D0;
				case 3:
				{
					num2 = (short)1638662144;
					short num3 = num2;
					if (!(activeMainModule == global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("䘆娈弊弌䀎帐朒琔攖䤘椚爜礞䠠伢䀤", a_)))
					{
						num2 = (short)205651968;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D0;
				}
				case 4:
					return;
				case 5:
					num2 = (short)1009188870;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (activeMainModule == global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("匆氈昊紌挎瀐朒瀔", a_))
					{
						num2 = (short)1101660161;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
					num2 = (short)601227267;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1944846348;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					if (activeMainModule == global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("唆栈漊搌怎", a_))
					{
						goto IL_1D0;
					}
					num2 = (short)1603980665;
					short num4 = num2;
					num2 = (short)1871629689;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)131399680;
						if (num2 != 0)
						{
						}
						num2 = (short)545914885;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 10:
					num2 = (short)577175561;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (!(activeMainModule == global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("䘆娈弊弌䀎唐爒愔瘖䤘椚爜礞䠠伢䀤", a_)))
					{
						num2 = (short)773390343;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D0;
				case 12:
					if (!(activeMainModule == global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("䴆昈椊", a_)))
					{
						num2 = (short)250413066;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D0;
				}
				goto IL_4D;
				IL_1D0:
				this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.RefreshRequestedEvent>().Publish(null);
				num2 = (short)1479737348;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_4D:
			activeMainModule = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule;
			num2 = (short)448462849;
			if (num2 != 0)
			{
			}
			num2 = (short)1486028811;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000029A0 File Offset: 0x00000BA0
		public void Redirect(string moduleName)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			short num2;
			global::System.Collections.Generic.List<string> list;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2018246656;
					short num3 = num2;
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("䌐爒焔縖瘘", a_))
					{
						num2 = (short)734658561;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_298;
				}
				case 1:
					goto IL_195;
				case 2:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastPage)
					{
						num2 = (short)1552678921;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B4;
				case 3:
					num2 = (short)1684602884;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == moduleName)
					{
						num2 = (short)166592517;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23D;
				case 5:
					goto IL_1D6;
				case 6:
					if (list.Contains(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastPage))
					{
						num2 = (short)1867251719;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1963917312;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1851981826;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (!string.IsNullOrEmpty(moduleName))
					{
						num2 = (short)442433539;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1336279046;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_114;
				}
				goto IL_41;
			}
			IL_B4:
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.NavigateToMainModuleRequestedEvent>().Publish(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastPage);
			return;
			IL_114:
			this.a();
			return;
			IL_195:
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.RefreshRequestedEvent>().Publish(null);
			return;
			IL_1D6:
			this.a();
			return;
			IL_23D:
			num2 = (short)245671620;
			short num4 = num2;
			num2 = (short)2141890244;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_114;
			default:
				num2 = (short)1266089984;
				if (num2 != 0)
				{
				}
				this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.NavigateToMainModuleRequestedEvent>().Publish(moduleName);
				return;
			}
			IL_298:
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.NavigateToMainModuleRequestedEvent>().Publish(global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("䌐爒焔縖瘘", a_));
			return;
			IL_41:
			num2 = (short)572063745;
			if (num2 != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.RedirectWhenStartFromCPS = true;
			list = new global::System.Collections.Generic.List<string>(global::Motorola.CommonCPS.RadioManagement.Global.ModuleNames.TemplateLandPageArray);
			num2 = (short)374997000;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002C64 File Offset: 0x00000E64
		public void ReportStatus(string status)
		{
			short num;
			try
			{
				num = (short)523534238;
				short num2 = num;
				num = (short)1387626398;
				switch (num2 == num)
				{
				}
				num = (short)772341760;
				if (num != 0)
				{
				}
				this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ReportStatusRequestedEvent>().Publish(status);
			}
			catch (global::System.Exception)
			{
			}
			num = (short)76873729;
			if (num != 0)
			{
			}
			num = (short)1357381632;
			short num3 = num;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002D30 File Offset: 0x00000F30
		public void ShowModifyCodeplugPasswordDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext modifyContext)
		{
			short num = (short)495646866;
			short num2 = num;
			num = (short)1146288274;
			switch (num2 == num)
			{
			}
			num = (short)16384000;
			short num3 = num;
			num = (short)1553072129;
			if (num != 0)
			{
			}
			num = (short)618790912;
			if (num != 0)
			{
			}
			modifyContext.ContextIsChanged = false;
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowModifyCodeplugPasswordRequestedEvent>().Publish(modifyContext);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002DF4 File Offset: 0x00000FF4
		public void ShowResetRadioPasswordDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext resetRadioPasswordContext)
		{
			short num = (short)1329189238;
			short num2 = num;
			num = (short)99864950;
			switch (num2 == num)
			{
			}
			num = (short)1305739264;
			short num3 = num;
			num = (short)314572801;
			if (num != 0)
			{
			}
			num = (short)517079040;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowResetRadioPasswordRequestedEvent>().Publish(resetRadioPasswordContext);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002EB0 File Offset: 0x000010B0
		public void ShowAddRadioDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.AddRadioContext addRadioContext)
		{
			short num = (short)1404033340;
			short num2 = num;
			num = (short)1093196092;
			switch (num2 == num)
			{
			}
			num = (short)1937571840;
			short num3 = num;
			num = (short)1614217217;
			if (num != 0)
			{
			}
			num = (short)1628045312;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowAddRadioDialogRequestedEvent>().Publish(addRadioContext);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002F70 File Offset: 0x00001170
		public void a(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> A_0)
		{
			short num = (short)1148452865;
			if (num != 0)
			{
			}
			num = (short)1825100415;
			short num2 = num;
			num = (short)913756799;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1037303808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1427439616;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000301C File Offset: 0x0000121C
		public void ShowCompatibleTemplates(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext compatibleTemplate)
		{
			short num = (short)1029701633;
			if (num != 0)
			{
			}
			num = (short)172139469;
			short num2 = num;
			num = (short)1392485325;
			switch (num2 == num)
			{
			default:
			{
				num = (short)75300864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)770375680;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000030CC File Offset: 0x000012CC
		public bool ShowConfirmationDialog(string content, string title)
		{
			short num = (short)537405558;
			short num2 = num;
			num = (short)1877420150;
			switch (num2 == num)
			{
			}
			num = (short)7405568;
			short num3 = num;
			num = (short)1299709953;
			if (num != 0)
			{
			}
			num = (short)1220608000;
			if (num != 0)
			{
			}
			global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Confirmation confirmation = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Confirmation
			{
				Content = content,
				Title = title
			};
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowConfirmationDialogRequestedEvent>().Publish(confirmation);
			return confirmation.Confirmed;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000031A4 File Offset: 0x000013A4
		public bool ShowDeleteKeysConfirmationDialog(int itemsToDelete)
		{
			short num = (short)1783801615;
			short num2 = num;
			num = (short)740402959;
			switch (num2 == num)
			{
			}
			num = (short)1507721216;
			short num3 = num;
			num = (short)1932591104;
			if (num != 0)
			{
			}
			num = (short)634126337;
			if (num != 0)
			{
			}
			return this.ShowConfirmationDialog(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation_DeleteKeys_With_Amount, itemsToDelete), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_DeleteKeys);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000326C File Offset: 0x0000146C
		public bool ShowDeletePackagesConfirmationDialog(int itemsToDelete)
		{
			short num = (short)895508119;
			short num2 = num;
			num = (short)100884119;
			switch (num2 == num)
			{
			}
			num = (short)1234829312;
			short num3 = num;
			num = (short)17170433;
			if (num != 0)
			{
			}
			num = (short)682557440;
			if (num != 0)
			{
			}
			return this.ShowConfirmationDialog(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation_DeletePackages_With_Amount, itemsToDelete), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_DeletePackages);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003334 File Offset: 0x00001534
		public bool ShowDeleteJobsConfirmationDialog(int itemsToDelete)
		{
			short num = (short)1844051969;
			if (num != 0)
			{
			}
			num = (short)2112780189;
			short num2 = num;
			num = (short)1764063133;
			switch (num2 == num)
			{
			default:
			{
				num = (short)398000128;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1059061760;
			if (num != 0)
			{
			}
			return this.ShowConfirmationDialog(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Confirm_DeleteJob_With_Amount, itemsToDelete), global::Motorola.CommonCPS.ResourceRepository.Resources.DeleteJob);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003400 File Offset: 0x00001600
		public bool ShowDeleteRadiosConfirmationDialog(int itemsToDelete)
		{
			short num = (short)755364107;
			short num2 = num;
			num = (short)1527836939;
			switch (num2 == num)
			{
			}
			num = (short)639827968;
			short num3 = num;
			num = (short)78184449;
			if (num != 0)
			{
			}
			num = (short)1025114112;
			if (num != 0)
			{
			}
			return this.ShowConfirmationDialog(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation_DeleteRadios_With_Amount, itemsToDelete), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_DeleteRadios);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000034C8 File Offset: 0x000016C8
		public bool ShowCompleteRadioJobConfirmationDialog()
		{
			short num = (short)1484768259;
			short num2 = num;
			num = (short)1739244547;
			switch (num2 == num)
			{
			}
			num = (short)1161822208;
			short num3 = num;
			num = (short)1536688129;
			if (num != 0)
			{
			}
			num = (short)1716649984;
			if (num != 0)
			{
			}
			return this.ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation_CompleteJob_1 + global::System.Environment.NewLine + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation_CompleteJob_2, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_CompleteJob);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003590 File Offset: 0x00001790
		public bool ShowDeleteTemplatesConfirmationDialog(int itemsToDelete)
		{
			short num = (short)1022872724;
			short num2 = num;
			num = (short)965201044;
			switch (num2 == num)
			{
			}
			num = (short)935460864;
			short num3 = num;
			num = (short)248709121;
			if (num != 0)
			{
			}
			num = (short)496041984;
			if (num != 0)
			{
			}
			return this.ShowConfirmationDialog(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation_DeleteTemplates_With_Amount, itemsToDelete), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_DeleteTemplates);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003658 File Offset: 0x00001858
		public string ShowExportConfigurationDialog(string fileName)
		{
			int a_ = 3;
			global::Microsoft.Win32.SaveFileDialog saveFileDialog = new global::Microsoft.Win32.SaveFileDialog
			{
				Filter = global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("䔅朇搉樋服眏朑易眕気猙猛瀝\u001f搡䴣䨥䴧天倫Эḯ嘱嘳堵", a_),
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ExportConfiguration
			};
			if (saveFileDialog.ShowDialog().Value)
			{
				short num = (short)976945152;
				short num2 = num;
			}
			else
			{
				short num = (short)1089493208;
				short num3 = num;
				num = (short)2021349592;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)792592385;
					if (num != 0)
					{
					}
					num = (short)1888681984;
					if (num != 0)
					{
					}
					return null;
				}
			}
			return saveFileDialog.FileName;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003748 File Offset: 0x00001948
		public void ShowImportLanguagePackDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext importLanguagePackContext)
		{
			short num = (short)1302961643;
			short num2 = num;
			num = (short)2085658091;
			switch (num2 == num)
			{
			}
			num = (short)1493303296;
			short num3 = num;
			num = (short)1165230080;
			if (num != 0)
			{
			}
			num = (short)37683201;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowImportLanguagePackDialogRequestedEvent>().Publish(importLanguagePackContext);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003804 File Offset: 0x00001A04
		public void ShowImportRadiosDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ImportRadiosContext importRadiosContxt)
		{
			short num = (short)1483669505;
			if (num != 0)
			{
			}
			num = (short)1497300645;
			short num2 = num;
			num = (short)2024865445;
			switch (num2 == num)
			{
			default:
			{
				num = (short)701759488;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)610205696;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowImportRadiosDialogRequestedEvent>().Publish(importRadiosContxt);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000038BC File Offset: 0x00001ABC
		public void ShowImportTemplatesDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext importTemplatesContext)
		{
			short num = (short)401932289;
			if (num != 0)
			{
			}
			num = (short)1417843700;
			short num2 = num;
			num = (short)177771508;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1889075200;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2066808832;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowImportTemplatesDialogRequestedEvent>().Publish(importTemplatesContext);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003978 File Offset: 0x00001B78
		public void ShowLanguagePacksDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowLanguagePacksContext showLanguagePacksContext)
		{
			short num = (short)1658912769;
			if (num != 0)
			{
			}
			num = (short)1559307072;
			short num2 = num;
			num = (short)599466816;
			switch (num2 == num)
			{
			default:
			{
				num = (short)797310976;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)720896000;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowLanguagePacksDialogRequestedEvent>().Publish(showLanguagePacksContext);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003A30 File Offset: 0x00001C30
		public void ShowVAPacksDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowVAPacksContext showVAPacksContext)
		{
			short num = (short)1829765121;
			if (num != 0)
			{
			}
			num = (short)178447403;
			short num2 = num;
			num = (short)79815723;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1715273728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1193345024;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowVAPacksDialogRequestedEvent>().Publish(showVAPacksContext);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003AEC File Offset: 0x00001CEC
		public void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowCACertificatesPacksContext A_0)
		{
			short num = (short)965607425;
			if (num != 0)
			{
			}
			num = (short)2080431132;
			short num2 = num;
			num = (short)1398987804;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1029111808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1229324288;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowCACertificatesPacksDialogRequestedEvent>().Publish(A_0);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003BA4 File Offset: 0x00001DA4
		public void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowDVRSFilePacksContext A_0)
		{
			short num = (short)1396087526;
			short num2 = num;
			num = (short)1228905190;
			switch (num2 == num)
			{
			}
			num = (short)849739776;
			if (num != 0)
			{
			}
			num = (short)868679681;
			if (num != 0)
			{
			}
			num = (short)1317797888;
			short num3 = num;
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowDVRSFilesPacksDialogRequestedEvent>().Publish(A_0);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003C60 File Offset: 0x00001E60
		public void ShowTemplateLanguagePacksDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateLanguagePacksContext showTemplateLanguagePacksContext)
		{
			short num = (short)360902674;
			short num2 = num;
			num = (short)753987602;
			switch (num2 == num)
			{
			}
			num = (short)902692865;
			if (num != 0)
			{
			}
			num = (short)962396160;
			if (num != 0)
			{
			}
			num = (short)292683776;
			short num3 = num;
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowTemplateLanguagePacksDialogRequestedEvent>().Publish(showTemplateLanguagePacksContext);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003D1C File Offset: 0x00001F1C
		public void ShowTemplateVAPacksDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateVAPacksContext showTemplateVAPacksContext)
		{
			short num = (short)125326843;
			short num2 = num;
			num = (short)564811259;
			switch (num2 == num)
			{
			}
			num = (short)1619132417;
			if (num != 0)
			{
			}
			num = (short)186515456;
			if (num != 0)
			{
			}
			num = (short)1275854848;
			short num3 = num;
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowTemplateVAPacksDialogRequestedEvent>().Publish(showTemplateVAPacksContext);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003DD4 File Offset: 0x00001FD4
		public void ShowNewAstroRadioDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroRadio)
		{
			int a_ = 13;
			short num = (short)1075210363;
			short num2 = num;
			num = (short)1319725179;
			switch (num2 == num)
			{
			}
			num = (short)714080257;
			if (num != 0)
			{
			}
			num = (short)1970012160;
			if (num != 0)
			{
			}
			num = (short)819789824;
			short num3 = num;
			global::System.Random random = new global::System.Random();
			astroRadio.SerialNumber = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("欏∑椓洕⤗’堛⨝崟", a_), global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("⤏⬑ⴓ圕娗夙", a_), random.Next(9999));
			astroRadio.PeerIP = global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("ℏ⬑☓㠕⤗㐙ⴛ〝ᄟ", a_);
			astroRadio.SubscriberIP = global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("ℏ⬑☓㠕⤗㐙ⴛ〝ሟ", a_);
			astroRadio.BluetoothDUNPeerIP = global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("ℏ⬑☓㠕⤗㐙ⴛ〝ጟ", a_);
			astroRadio.BluetoothDUNSubscriberIP = global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("ℏ⬑☓㠕⤗㐙ⴛ〝ᐟ", a_);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003F18 File Offset: 0x00002118
		public void ShowNotificationDialog(string content, string title)
		{
			short num = (short)1831538234;
			short num2 = num;
			num = (short)333254202;
			switch (num2 == num)
			{
			}
			num = (short)1845100545;
			if (num != 0)
			{
			}
			num = (short)867762176;
			if (num != 0)
			{
			}
			num = (short)1422655488;
			short num3 = num;
			global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification payload = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification
			{
				Content = content,
				Title = title
			};
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowNotificationDialogRequestedEvent>().Publish(payload);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003FE4 File Offset: 0x000021E4
		public void ShowStartUpNotificationDialog(string content, string title)
		{
			short num = (short)1806041089;
			if (num != 0)
			{
			}
			num = (short)873534827;
			short num2 = num;
			num = (short)1867257195;
			switch (num2 == num)
			{
			}
			num = (short)573440000;
			if (num != 0)
			{
			}
			num = (short)306905088;
			short num3 = num;
			global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification payload = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification
			{
				Content = content,
				Title = title
			};
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowStartUpNotificationDialogRequestedEvent>().Publish(payload);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000040B4 File Offset: 0x000022B4
		public void ShowExceptionDialog(global::System.Exception exception)
		{
			int a_ = 13;
			short num = (short)2015035392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)475987968;
				short num3 = num;
				global::Motorola.Common.CustomException.CommonException ex;
				string messageBoxText;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_5A:
						string text;
						switch (num2)
						{
						case 0:
							num = (short)747044870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1846149128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)2080047113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)341442567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							text = ex.Message;
							goto IL_1F7;
						case 5:
							if (ex != null)
							{
								num = (short)729677825;
								if (num != 0)
								{
								}
								num = (short)1753612289;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2D1;
						case 6:
							if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error)
							{
								num = (short)1960837123;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_105;
						case 7:
						{
							if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.RMC_Special_Display_Msg)
							{
								goto IL_105;
							}
							num = (short)397824713;
							short num4 = num;
							num = (short)1655984841;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_A3;
							default:
								num = (short)2145320960;
								if (num != 0)
								{
								}
								num = (short)1698103298;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
							if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.GenericError)
							{
								num = (short)456589312;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_105;
						case 9:
							text = string.Concat(new string[]
							{
								global::Motorola.CommonCPS.ResourceRepository.Resources.Left_Square_Brackets,
								global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("㌏", a_),
								((int)ex.ErrorCode).ToString(),
								global::Motorola.CommonCPS.ResourceRepository.Resources.Right_Square_Brackets,
								global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null)
							});
							goto IL_1F7;
						case 10:
							goto IL_210;
						}
						goto IL_8D;
						IL_105:
						num = (short)743309316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F7:
						messageBoxText = text;
						num = (short)1288962058;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_210:
					IL_2D1:
					global::System.Windows.MessageBox.Show(messageBoxText, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_Error);
					return;
				}
				IL_8D:
				ex = (exception as global::Motorola.Common.CustomException.CommonException);
				messageBoxText = global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("䐏稑焓㘕紗栙減焝刟ȡ䤣䌥嬧天䴫䤭唯ሱ崳䔵ᠷ圹唻䴽㌿⭁⩃ⅅ晇", a_);
				IL_A3:
				num = (short)509345797;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5A;
			}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000043A0 File Offset: 0x000025A0
		public void ShowErrorMessageDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ErrorMessageContext errorMessageContext)
		{
			short num = (short)1827066186;
			short num2 = num;
			num = (short)812896586;
			switch (num2 == num)
			{
			}
			num = (short)229310465;
			if (num != 0)
			{
			}
			num = (short)775618560;
			if (num != 0)
			{
			}
			num = (short)641925120;
			short num3 = num;
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowErrorMessageDialogRequestedEvent>().Publish(errorMessageContext);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000445C File Offset: 0x0000265C
		public string[] ShowOpenFileDialogForImportAstroFWs()
		{
			short num = (short)890634240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				string[] fileNames;
				global::Microsoft.Win32.OpenFileDialog openFileDialog;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (fileNames.Length != 0)
						{
							num = (short)1136852997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileNames;
					case 1:
						goto IL_EA;
					case 2:
						goto IL_16D;
					case 3:
						fileNames = openFileDialog.FileNames;
						num = (short)1673920512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						string directoryName;
						if (!string.IsNullOrEmpty(directoryName))
						{
							num = (short)318570502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileNames;
					}
					case 5:
					{
						string directoryName = global::System.IO.Path.GetDirectoryName(fileNames[0]);
						num = (short)2098266116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						string directoryName;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_FirmwarePackgae_Folder = directoryName;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
						num = (short)1978990592;
						short num3 = num;
						num = (short)1331625986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_4A;
				}
				IL_EA:
				bool? flag;
				if (flag.Value)
				{
					goto IL_F6;
				}
				return null;
				IL_16D:
				num = (short)1954152449;
				if (num != 0)
				{
				}
				return fileNames;
				IL_4A:
				openFileDialog = new global::Microsoft.Win32.OpenFileDialog
				{
					InitialDirectory = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_FirmwarePackgae_Folder),
					Filter = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_UpgradeFileFilter,
					Multiselect = true,
					Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_ImportFirmware
				};
				flag = openFileDialog.ShowDialog();
				num = (short)364210181;
				short num4 = num;
				num = (short)1437755397;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_F6:
					num = (short)1209270275;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				default:
					num = (short)2099576832;
					if (num != 0)
					{
					}
					num = (short)1367605249;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				break;
			}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004690 File Offset: 0x00002890
		public string[] ShowFolderBrowserDialogForImportAstroFWs()
		{
			short num = (short)1837318455;
			short num2 = num;
			num = (short)482361655;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1143013377;
				if (num != 0)
				{
				}
				num = (short)1187446784;
				if (num != 0)
				{
				}
				num = (short)1498284032;
				int num3 = (int)num;
				switch (num3)
				{
				}
				break;
			}
			}
			num = (short)1509294080;
			short num4 = num;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog = new global::System.Windows.Forms.FolderBrowserDialog();
			string[] result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_101;
				}
				int num3;
				for (;;)
				{
					IL_D2:
					switch (num3)
					{
					case 0:
						goto IL_1A9;
					case 1:
						folderBrowserDialog.SelectedPath = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_FirmwarePackgae_Folder;
						num = (short)1557987335;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::System.IO.DirectoryInfo directoryInfo = new global::System.IO.DirectoryInfo(folderBrowserDialog.SelectedPath);
						num = (short)738197509;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_FirmwarePackgae_Folder = folderBrowserDialog.SelectedPath;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
						global::System.IO.DirectoryInfo directoryInfo;
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.SearchFolderForFWFiles(directoryInfo, list);
						num = (short)431161353;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (global::System.IO.Directory.Exists(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_FirmwarePackgae_Folder))
						{
							num = (short)1077542913;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_147;
					case 5:
					{
						global::System.IO.DirectoryInfo directoryInfo;
						if (directoryInfo.Exists)
						{
							num = (short)201457667;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_189;
					}
					case 6:
						if (folderBrowserDialog.ShowDialog() == global::System.Windows.Forms.DialogResult.OK)
						{
							num = (short)769589250;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = null;
						num = (short)1592983560;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_147;
					case 8:
						goto IL_281;
					case 9:
						goto IL_189;
					}
					goto IL_101;
					IL_147:
					num = (short)197787654;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_189:
					result = list.ToArray();
					num = (short)964558848;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1A9:
				IL_281:
				return result;
				IL_101:
				folderBrowserDialog.ShowNewFolderButton = false;
				num = (short)182910980;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_D2;
			}
			finally
			{
				num = (short)34275328;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_2B6;
						}
						continue;
					case 1:
						((global::System.IDisposable)folderBrowserDialog).Dispose();
						num = (short)679477250;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_2ED;
					}
					IL_2B6:
					if (folderBrowserDialog == null)
					{
						break;
					}
					num = (short)1562968065;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_2ED:;
			}
			return result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000049AC File Offset: 0x00002BAC
		public string ShowExportConfigurationSelectFolderDialog()
		{
			short num = (short)1582891008;
			short num2 = num;
			num = (short)2009658568;
			short num3 = num;
			num = (short)397669576;
			string result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2020474881;
				if (num != 0)
				{
				}
				num = (short)1039859712;
				if (num != 0)
				{
				}
				new global::System.Collections.Generic.List<string>();
				global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog = new global::System.Windows.Forms.FolderBrowserDialog();
				try
				{
					num = (short)784138244;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_17A;
						case 1:
							folderBrowserDialog.SelectedPath = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Export_Configuration_Folder;
							num = (short)270925831;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)116850693;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Export_Configuration_Folder = folderBrowserDialog.SelectedPath;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
							num = (short)1518075913;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_F6;
							}
							continue;
						case 5:
							if (new global::System.IO.DirectoryInfo(folderBrowserDialog.SelectedPath).Exists)
							{
								num = (short)578289667;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_15C;
						case 6:
							if (folderBrowserDialog.ShowDialog() == global::System.Windows.Forms.DialogResult.OK)
							{
								num = (short)1492910082;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = null;
							num = (short)679542792;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_11D;
						case 8:
							goto IL_242;
						case 9:
							goto IL_15C;
						}
						IL_F6:
						if (global::System.IO.Directory.Exists(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Export_Configuration_Folder))
						{
							num = (short)937689089;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_11D:
						num = (short)85852166;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_15C:
						result = folderBrowserDialog.SelectedPath;
						num = (short)1269563392;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_17A:
					IL_242:;
				}
				finally
				{
					num = (short)1935933440;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_274;
							}
							continue;
						case 1:
							((global::System.IDisposable)folderBrowserDialog).Dispose();
							num = (short)472711170;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_2A9;
						}
						IL_274:
						if (folderBrowserDialog == null)
						{
							break;
						}
						num = (short)1108869121;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_2A9:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004C84 File Offset: 0x00002E84
		public string[] ShowOpenFileDialog(string filter, string title, bool multiSelect)
		{
			short num = (short)160546043;
			short num2 = num;
			num = (short)515816699;
			global::Microsoft.Win32.OpenFileDialog openFileDialog;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1221984256;
				if (num != 0)
				{
				}
				openFileDialog = new global::Microsoft.Win32.OpenFileDialog
				{
					Filter = filter,
					Title = title,
					Multiselect = multiSelect
				};
				if (!openFileDialog.ShowDialog().Value)
				{
					return null;
				}
				break;
			}
			num = (short)471465984;
			short num3 = num;
			num = (short)158466049;
			if (num != 0)
			{
			}
			return openFileDialog.FileNames;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004D64 File Offset: 0x00002F64
		public string[] ShowOpenFileDialogForLTE(string filter, string title, bool multiSelect)
		{
			short num = (short)1828178870;
			short num2 = num;
			num = (short)1474677686;
			global::Microsoft.Win32.OpenFileDialog openFileDialog;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)950599680;
				if (num != 0)
				{
				}
				openFileDialog = new global::Microsoft.Win32.OpenFileDialog
				{
					Filter = filter,
					Title = title,
					Multiselect = multiSelect
				};
				if (!openFileDialog.ShowDialog().Value)
				{
					return null;
				}
				break;
			}
			num = (short)163774464;
			short num3 = num;
			num = (short)753401857;
			if (num != 0)
			{
			}
			return openFileDialog.FileNames;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004E44 File Offset: 0x00003044
		public string ShowSaveFileDialogForExportWhiteList(string fileName)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogEventParam showRMSaveFileDialogEventParam;
			short num2;
			string result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (showRMSaveFileDialogEventParam.IsSuccess)
					{
						num2 = (short)343998465;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					num2 = (short)488243981;
					short num3 = num2;
					num2 = (short)900793101;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1587085313;
						if (num2 != 0)
						{
						}
						num2 = (short)752156672;
						if (num2 != 0)
						{
						}
						result = showRMSaveFileDialogEventParam.FileName;
						num2 = (short)1659043842;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_125;
				}
				goto IL_1C;
			}
			IL_125:
			num2 = (short)919535616;
			short num4 = num2;
			return result;
			IL_1C:
			string rmc_Filter_XML = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_XML;
			result = null;
			showRMSaveFileDialogEventParam = new global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogEventParam();
			showRMSaveFileDialogEventParam.Filter = rmc_Filter_XML;
			showRMSaveFileDialogEventParam.FilterIndex = 1;
			showRMSaveFileDialogEventParam.Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ExportWhiteList;
			showRMSaveFileDialogEventParam.FileName = fileName;
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogRequestedEvent>().Publish(showRMSaveFileDialogEventParam);
			num2 = (short)1769734144;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004FA4 File Offset: 0x000031A4
		public string ShowSaveFileDialogForExportSiSeries(string fileName)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogEventParam showRMSaveFileDialogEventParam;
			short num2;
			string result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (showRMSaveFileDialogEventParam.IsSuccess)
					{
						num2 = (short)1625882625;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					num2 = (short)854775308;
					short num3 = num2;
					num2 = (short)1078384140;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)369557504;
						if (num2 != 0)
						{
						}
						result = showRMSaveFileDialogEventParam.FileName;
						num2 = (short)806289410;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_128;
				}
				goto IL_1C;
			}
			IL_128:
			num2 = (short)1098579968;
			short num4 = num2;
			return result;
			IL_1C:
			num2 = (short)51052545;
			if (num2 != 0)
			{
			}
			string rmc_Filter_XML = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_XML;
			result = null;
			showRMSaveFileDialogEventParam = new global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogEventParam();
			showRMSaveFileDialogEventParam.Filter = rmc_Filter_XML;
			showRMSaveFileDialogEventParam.FilterIndex = 1;
			showRMSaveFileDialogEventParam.Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ExportSiSeries;
			showRMSaveFileDialogEventParam.FileName = fileName;
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogRequestedEvent>().Publish(showRMSaveFileDialogEventParam);
			num2 = (short)1183842304;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005108 File Offset: 0x00003308
		public string ShowSaveFileDialogForExportSimpleTouch(string fileName)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogEventParam showRMSaveFileDialogEventParam;
			short num2;
			string result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (showRMSaveFileDialogEventParam.IsSuccess)
					{
						num2 = (short)518455297;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					num2 = (short)1477967873;
					if (num2 != 0)
					{
					}
					num2 = (short)297772017;
					short num3 = num2;
					num2 = (short)1092330481;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1725562880;
						if (num2 != 0)
						{
						}
						result = showRMSaveFileDialogEventParam.FileName;
						num2 = (short)577699842;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_127;
				}
				goto IL_1C;
			}
			IL_127:
			num2 = (short)470876160;
			short num4 = num2;
			return result;
			IL_1C:
			string rmc_Filter_XML = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_XML;
			result = null;
			showRMSaveFileDialogEventParam = new global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogEventParam();
			showRMSaveFileDialogEventParam.Filter = rmc_Filter_XML;
			showRMSaveFileDialogEventParam.FilterIndex = 1;
			showRMSaveFileDialogEventParam.Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ExportSimpleTouch;
			showRMSaveFileDialogEventParam.FileName = fileName;
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogRequestedEvent>().Publish(showRMSaveFileDialogEventParam);
			num2 = (short)579272704;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005268 File Offset: 0x00003468
		public string ShowSaveFileDialogForExportAPNList(string fileName)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogEventParam showRMSaveFileDialogEventParam;
			short num2;
			string result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (showRMSaveFileDialogEventParam.IsSuccess)
					{
						num2 = (short)1672806401;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					num2 = (short)1646255214;
					short num3 = num2;
					num2 = (short)466476142;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)2016542720;
						if (num2 != 0)
						{
						}
						result = showRMSaveFileDialogEventParam.FileName;
						num2 = (short)1867317250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_100;
				}
				goto IL_1C;
			}
			IL_100:
			num2 = (short)941096961;
			if (num2 != 0)
			{
			}
			num2 = (short)1570963456;
			short num4 = num2;
			return result;
			IL_1C:
			string rmc_Filter_XML = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_XML;
			result = null;
			showRMSaveFileDialogEventParam = new global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogEventParam();
			showRMSaveFileDialogEventParam.Filter = rmc_Filter_XML;
			showRMSaveFileDialogEventParam.FilterIndex = 1;
			showRMSaveFileDialogEventParam.Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ExportWhiteList;
			showRMSaveFileDialogEventParam.FileName = fileName;
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogRequestedEvent>().Publish(showRMSaveFileDialogEventParam);
			num2 = (short)870187008;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000053C8 File Offset: 0x000035C8
		public string ShowOpenFileDialogForImportFromCSV(bool addAllFilesOption = false)
		{
			int a_ = 10;
			short num = (short)2025783296;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)792353920;
				short num3 = num;
				num = (short)1137269888;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)87752704;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_AB;
					}
					break;
				}
				string fileName;
				string text;
				for (;;)
				{
					IL_7C:
					global::Microsoft.Win32.OpenFileDialog openFileDialog;
					bool? flag;
					switch (num2)
					{
					case 0:
					{
						string directoryName = global::System.IO.Path.GetDirectoryName(fileName);
						num = (short)2114387971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1272774657;
						if (num != 0)
						{
						}
						text = text + global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("焌", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_ALL_Files_Type;
						num = (short)1295581191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!string.IsNullOrEmpty(fileName))
						{
							num = (short)1282932736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileName;
					case 3:
					{
						string directoryName;
						if (!string.IsNullOrEmpty(directoryName))
						{
							num = (short)870252552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileName;
					}
					case 4:
						if (addAllFilesOption)
						{
							num = (short)1734803457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6;
					case 5:
						fileName = openFileDialog.FileName;
						num = (short)1768816642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return fileName;
					case 7:
						goto IL_1B6;
					case 8:
					{
						string directoryName;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_CSV_Folder = directoryName;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
						num = (short)555941894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (flag.Value)
						{
							num = (short)2000814085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29D;
					}
					goto IL_AB;
					IL_1B6:
					num = (short)1853095936;
					short num4 = num;
					openFileDialog = new global::Microsoft.Win32.OpenFileDialog
					{
						InitialDirectory = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_CSV_Folder),
						Filter = text,
						Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ImportFileToGrid
					};
					flag = openFileDialog.ShowDialog();
					num = (short)1420492809;
					num2 = (int)((global::System.IntPtr)num);
				}
				return fileName;
				IL_29D:
				return null;
				IL_AB:
				text = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Import_Filter_CSV_Excel_ALL;
				num = (short)1348206596;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_7C;
			}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005674 File Offset: 0x00003874
		public string[] ShowOpenFileDialogForImportRadios()
		{
			short num = (short)1515323392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1193541633;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				string[] fileNames;
				global::Microsoft.Win32.OpenFileDialog openFileDialog;
				bool? flag;
				for (;;)
				{
					IL_4F:
					switch (num2)
					{
					case 0:
					{
						string directoryName = global::System.IO.Path.GetDirectoryName(fileNames[0]);
						num = (short)1991901190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)1265953684;
						short num3 = num;
						num = (short)815066004;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return fileNames;
						default:
						{
							num = (short)945750016;
							if (num != 0)
							{
							}
							string directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_Radio_Folder = directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
							num = (short)200081411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						fileNames = openFileDialog.FileNames;
						num = (short)1971585028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return fileNames;
					case 4:
						if (fileNames.Length != 0)
						{
							num = (short)554565632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileNames;
					case 5:
						if (flag.Value)
						{
							num = (short)1280966658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_229;
					case 6:
					{
						string directoryName;
						if (!string.IsNullOrEmpty(directoryName))
						{
							num = (short)1102774272;
							short num4 = num;
							num = (short)1521549313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileNames;
					}
					}
					goto IL_72;
				}
				return fileNames;
				IL_229:
				return null;
				IL_72:
				string rmc_Filter_MC = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_MC;
				openFileDialog = new global::Microsoft.Win32.OpenFileDialog
				{
					InitialDirectory = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_Radio_Folder),
					Filter = rmc_Filter_MC,
					Multiselect = true,
					Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ImportRadios
				};
				flag = openFileDialog.ShowDialog();
				num = (short)1323892741;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000058AC File Offset: 0x00003AAC
		public string[] ShowOpenFileDialogForImportConfiguration()
		{
			int a_ = 10;
			short num = (short)571867136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				string[] fileNames;
				global::Microsoft.Win32.OpenFileDialog openFileDialog;
				bool? flag;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						string directoryName = global::System.IO.Path.GetDirectoryName(fileNames[0]);
						num = (short)1019281414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)457631616;
						short num3 = num;
						num = (short)1412622208;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return fileNames;
						default:
						{
							num = (short)385810432;
							if (num != 0)
							{
							}
							string directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_Configuration_Folder = directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
							num = (short)955645955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						fileNames = openFileDialog.FileNames;
						num = (short)528154628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return fileNames;
					case 4:
						if (fileNames.Length != 0)
						{
							num = (short)2102722560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileNames;
					case 5:
						if (flag.Value)
						{
							num = (short)112066562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23A;
					case 6:
					{
						string directoryName;
						if (!string.IsNullOrEmpty(directoryName))
						{
							num = (short)528351232;
							short num4 = num;
							num = (short)1471348737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileNames;
					}
					}
					goto IL_53;
				}
				return fileNames;
				IL_23A:
				return null;
				IL_53:
				openFileDialog = new global::Microsoft.Win32.OpenFileDialog
				{
					InitialDirectory = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_Configuration_Folder),
					Filter = global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("丌怎缐甒簔瀖氘椚簜欞䠠䰢䬤ܦ漨䈪䄬䨮䈰伲ἴᤶ崸夺匼", a_),
					Multiselect = true,
					Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ImportConfiguration
				};
				flag = openFileDialog.ShowDialog();
				num = (short)888930305;
				if (num != 0)
				{
				}
				num = (short)863961093;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005AF4 File Offset: 0x00003CF4
		public string[] ShowOpenFileDialogForImportTemplates()
		{
			short num = (short)1019478016;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4C;
				}
				string[] fileNames;
				global::Microsoft.Win32.OpenFileDialog openFileDialog;
				bool? flag;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
					{
						string directoryName = global::System.IO.Path.GetDirectoryName(fileNames[0]);
						num = (short)1275265030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)972826339;
						short num3 = num;
						num = (short)788342499;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return fileNames;
						default:
						{
							num = (short)1740963840;
							if (num != 0)
							{
							}
							string directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_Template_Folder = directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
							num = (short)1912799235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						fileNames = openFileDialog.FileNames;
						num = (short)768147460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return fileNames;
					case 4:
						if (fileNames.Length != 0)
						{
							num = (short)1582170112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileNames;
					case 5:
						if (flag.Value)
						{
							num = (short)539885570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_225;
					case 6:
					{
						string directoryName;
						if (!string.IsNullOrEmpty(directoryName))
						{
							num = (short)1657339905;
							if (num != 0)
							{
							}
							num = (short)745340928;
							short num4 = num;
							num = (short)1217724417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileNames;
					}
					}
					goto IL_4C;
				}
				return fileNames;
				IL_225:
				return null;
				IL_4C:
				openFileDialog = new global::Microsoft.Win32.OpenFileDialog
				{
					InitialDirectory = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_Template_Folder),
					Filter = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_MC,
					Multiselect = true,
					Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ImportTemplates
				};
				flag = openFileDialog.ShowDialog();
				num = (short)468910085;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005D28 File Offset: 0x00003F28
		public string[] ShowOpenFileDialogForImportVAFiles(string initialPath)
		{
			short num = (short)1864630272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				string[] fileNames;
				string text;
				string value;
				for (;;)
				{
					IL_27:
					bool? flag;
					global::Microsoft.Win32.OpenFileDialog openFileDialog;
					switch (num2)
					{
					case 0:
						num = (short)1515585546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (fileNames.Length != 0)
						{
							num = (short)435945475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileNames;
					case 2:
						goto IL_2BC;
					case 3:
					{
						string directoryName = global::System.IO.Path.GetDirectoryName(fileNames[0]);
						num = (short)17432584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)227868684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32B;
					case 5:
					{
						num = (short)730989814;
						short num3 = num;
						num = (short)1356924150;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E6;
						default:
						{
							num = (short)1019346944;
							if (num != 0)
							{
							}
							string directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTRO_Import_VoicePackage_Folder = directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
							num = (short)1352794121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 6:
						goto IL_1E6;
					case 7:
						if (flag.Value)
						{
							num = (short)1217855499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34A;
					case 8:
					{
						string directoryName;
						if (!string.IsNullOrEmpty(directoryName))
						{
							num = (short)178192389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileNames;
					}
					case 9:
						goto IL_2B7;
					case 10:
						if (!text.Equals(value))
						{
							num = (short)1962016781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC;
					case 11:
						fileNames = openFileDialog.FileNames;
						num = (short)320798721;
						if (num != 0)
						{
						}
						num = (short)956170241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)728301574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_32B;
					}
					goto IL_66;
					IL_1E6:
					num = (short)1585709056;
					short num4 = num;
					if (text.Equals(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.Desktop)))
					{
						num = (short)1087045632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2BC:
					openFileDialog = new global::Microsoft.Win32.OpenFileDialog
					{
						InitialDirectory = text,
						Filter = global::CommonUtility.LPVAUtitity.VAFilesFilter,
						Multiselect = true,
						Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Voice_Announcements
					};
					flag = openFileDialog.ShowDialog();
					num = (short)1642070023;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32B:
					text = initialPath;
					num = (short)757989378;
					num2 = (int)((global::System.IntPtr)num);
				}
				return fileNames;
				IL_2B7:
				return fileNames;
				IL_34A:
				return null;
				IL_66:
				text = string.Empty;
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(initialPath);
				value = string.Empty;
				text = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTRO_Import_VoicePackage_Folder);
				value = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTRO_Import_VoicePackage_Folder;
				num = (short)1482948612;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00006080 File Offset: 0x00004280
		public string[] ShowOpenFileDialogForImportCACertificateFiles(string initialPath)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			string initialDirectory;
			short num2;
			global::Microsoft.Win32.OpenFileDialog openFileDialog;
			for (;;)
			{
				IL_13:
				bool? flag;
				switch (num)
				{
				case 0:
					initialDirectory = initialPath;
					num2 = (short)333971457;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_6C;
				case 2:
				{
					num2 = (short)1384644608;
					short num3 = num2;
					num2 = (short)2094596097;
					if (num2 != 0)
					{
					}
					num2 = (short)1281687556;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (flag.Value)
					{
						num2 = (short)672530438;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E6;
				case 4:
					while (global::System.IO.Directory.Exists(initialPath))
					{
						num2 = (short)1793881227;
						short num4 = num2;
						num2 = (short)2124706955;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)2098593792;
							if (num2 != 0)
							{
							}
							num2 = (short)2047803392;
							num = (int)((global::System.IntPtr)num2);
							goto IL_13;
						}
					}
					goto IL_6C;
				case 5:
					if (initialPath != null)
					{
						num2 = (short)561577986;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6C;
				case 6:
					goto IL_E4;
				}
				goto IL_35;
				IL_6C:
				openFileDialog = new global::Microsoft.Win32.OpenFileDialog
				{
					InitialDirectory = initialDirectory,
					Filter = global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("䜃挅稇縉攋栍礏焑甓戕紗㨙稛眝䰟䜡圣إ')ȫЭ᤯丱ḳᠵሷ", a_),
					Multiselect = true,
					Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_CA_Certificates
				};
				flag = openFileDialog.ShowDialog();
				num2 = (short)2084438019;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E4:
			return openFileDialog.FileNames;
			IL_1E6:
			return null;
			IL_35:
			initialDirectory = string.Empty;
			num2 = (short)1364262917;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006274 File Offset: 0x00004474
		public string[] ShowOpenFileDialogForImportDVRSFiles(string initialPath)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			string initialDirectory;
			short num2;
			global::Microsoft.Win32.OpenFileDialog openFileDialog;
			for (;;)
			{
				IL_13:
				bool? flag;
				switch (num)
				{
				case 0:
					initialDirectory = initialPath;
					num2 = (short)1884094465;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_6E;
				case 2:
				{
					num2 = (short)693174272;
					short num3 = num2;
					num2 = (short)2032140292;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (flag.Value)
					{
						num2 = (short)1778057222;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E9;
				case 4:
					while (global::System.IO.Directory.Exists(initialPath))
					{
						num2 = (short)849852549;
						short num4 = num2;
						num2 = (short)1911208069;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1627193344;
							if (num2 != 0)
							{
							}
							num2 = (short)719912961;
							if (num2 != 0)
							{
							}
							num2 = (short)71368704;
							num = (int)((global::System.IntPtr)num2);
							goto IL_13;
						}
					}
					goto IL_6E;
				case 5:
					if (initialPath != null)
					{
						num2 = (short)2065498114;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6E;
				case 6:
					goto IL_E2;
				}
				goto IL_35;
				IL_6E:
				openFileDialog = new global::Microsoft.Win32.OpenFileDialog
				{
					InitialDirectory = initialDirectory,
					Filter = global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.b("䰇尉帋崍』琑紓稕紗椙㰛㘝ਟడ䀣䔥䰧)ԫ刭ᨯᰱ倳唵尷္", a_),
					Multiselect = true,
					Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DVRS_Files
				};
				flag = openFileDialog.ShowDialog();
				num2 = (short)554500099;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E2:
			return openFileDialog.FileNames;
			IL_1E9:
			return null;
			IL_35:
			initialDirectory = string.Empty;
			num2 = (short)2133262341;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000646C File Offset: 0x0000466C
		public string[] ShowOpenFileDialogForImportTTSFiles(string initialPath)
		{
			short num = (short)1997930496;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				string[] fileNames;
				string text;
				string import_TTS_Folder;
				for (;;)
				{
					IL_28:
					bool? flag;
					global::Microsoft.Win32.OpenFileDialog openFileDialog;
					switch (num2)
					{
					case 0:
						num = (short)497221642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (fileNames.Length != 0)
						{
							num = (short)115277827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileNames;
					case 2:
						goto IL_2B6;
					case 3:
					{
						string directoryName = global::System.IO.Path.GetDirectoryName(fileNames[0]);
						num = (short)244449288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1244397580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_326;
					case 5:
					{
						num = (short)1324092074;
						short num3 = num;
						num = (short)600443562;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E2;
						default:
						{
							num = (short)221773824;
							if (num != 0)
							{
							}
							string directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_TTS_Folder = directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
							num = (short)1618608137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 6:
						goto IL_1E2;
					case 7:
						if (flag.Value)
						{
							num = (short)1290993675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_346;
					case 8:
					{
						string directoryName;
						if (!string.IsNullOrEmpty(directoryName))
						{
							num = (short)1496973317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileNames;
					}
					case 9:
						goto IL_2B1;
					case 10:
						if (!text.Equals(import_TTS_Folder))
						{
							num = (short)648609805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B6;
					case 11:
						fileNames = openFileDialog.FileNames;
						num = (short)130023425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1776812038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_326;
					}
					goto IL_67;
					IL_1E2:
					num = (short)1274413056;
					short num4 = num;
					if (text.Equals(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.Desktop)))
					{
						num = (short)76611584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2B6:
					openFileDialog = new global::Microsoft.Win32.OpenFileDialog
					{
						InitialDirectory = text,
						Filter = global::CommonUtility.LPVAUtitity.TTSFilesFilter,
						Multiselect = true,
						Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_ImportTTSFiles
					};
					flag = openFileDialog.ShowDialog();
					num = (short)292814855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_326:
					text = initialPath;
					num = (short)1296629762;
					num2 = (int)((global::System.IntPtr)num);
				}
				return fileNames;
				IL_2B1:
				return fileNames;
				IL_346:
				return null;
				IL_67:
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(initialPath);
				text = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_TTS_Folder);
				import_TTS_Folder = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_TTS_Folder;
				num = (short)1224998913;
				if (num != 0)
				{
				}
				num = (short)448987140;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000067C0 File Offset: 0x000049C0
		public string[] ShowOpenFileDialogForImportGeneralPackageFiles()
		{
			short num = (short)171048960;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4C;
				}
				string[] fileNames;
				global::Microsoft.Win32.OpenFileDialog openFileDialog;
				bool? flag;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
					{
						string directoryName = global::System.IO.Path.GetDirectoryName(fileNames[0]);
						num = (short)334823430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)1459047661;
						short num3 = num;
						num = (short)333401325;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return fileNames;
						default:
						{
							num = (short)997064705;
							if (num != 0)
							{
							}
							num = (short)886177792;
							if (num != 0)
							{
							}
							string directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_GeneralPackage_Folder = directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
							num = (short)1066205187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						fileNames = openFileDialog.FileNames;
						num = (short)1358495748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return fileNames;
					case 4:
						if (fileNames.Length != 0)
						{
							num = (short)1662189568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileNames;
					case 5:
						if (flag.Value)
						{
							num = (short)1025376258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_229;
					case 6:
					{
						string directoryName;
						if (!string.IsNullOrEmpty(directoryName))
						{
							num = (short)1658322944;
							short num4 = num;
							num = (short)78446593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileNames;
					}
					}
					goto IL_4C;
				}
				return fileNames;
				IL_229:
				return null;
				IL_4C:
				string validFolder = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Import_GeneralPackage_Folder);
				openFileDialog = new global::Microsoft.Win32.OpenFileDialog
				{
					InitialDirectory = validFolder,
					Filter = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_PBBPackageFilter,
					Multiselect = true,
					Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_ImportPackages
				};
				flag = openFileDialog.ShowDialog();
				num = (short)101384197;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000069F8 File Offset: 0x00004BF8
		public void ShowProgressDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext progressContext)
		{
			short num = (short)115998721;
			if (num != 0)
			{
			}
			num = (short)16773011;
			short num2 = num;
			num = (short)1562636179;
			switch (num2 == num)
			{
			}
			num = (short)426901504;
			if (num != 0)
			{
			}
			num = (short)1992687616;
			short num3 = num;
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowProgressDialogRequestedEvent>().Publish(progressContext);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00006AB0 File Offset: 0x00004CB0
		public void ShowSTAProgressWindow(global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext progressContext)
		{
			short num = (short)1429642698;
			short num2 = num;
			num = (short)1378459082;
			switch (num2 == num)
			{
			}
			num = (short)1030750209;
			if (num != 0)
			{
			}
			num = (short)1389494272;
			if (num != 0)
			{
			}
			num = (short)1471479808;
			short num3 = num;
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSTAProgressWindow>().Publish(progressContext);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00006B6C File Offset: 0x00004D6C
		public void ShowProgressWindow(global::Motorola.CommonCPS.RadioManagement.UIModels.DockPanelNames dockPanelNames)
		{
			short num = (short)1846773058;
			short num2 = num;
			num = (short)299402562;
			switch (num2 == num)
			{
			}
			num = (short)1916469249;
			if (num != 0)
			{
			}
			num = (short)1020657664;
			if (num != 0)
			{
			}
			num = (short)647233536;
			short num3 = num;
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ActivateDockedPaneRequestedEvent>().Publish(dockPanelNames);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00006C28 File Offset: 0x00004E28
		public bool ShowRetryDialog(string content, string title)
		{
			short num = (short)1303054751;
			short num2 = num;
			num = (short)988154271;
			switch (num2 == num)
			{
			}
			num = (short)269811713;
			if (num != 0)
			{
			}
			num = (short)22151168;
			if (num != 0)
			{
			}
			num = (short)881786880;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RetryConfirmation retryConfirmation = new global::Motorola.CommonCPS.RadioManagement.UIModels.RetryConfirmation
			{
				Content = content,
				Title = title
			};
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowRetryDialogRequestedEvent>().Publish(retryConfirmation);
			return retryConfirmation.Confirmed;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00006CFC File Offset: 0x00004EFC
		public string ShowSaveFileDialogForExportRadio(string fileName)
		{
			short num = (short)1966080000;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				string fileName2;
				global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogEventParam showRMSaveFileDialogEventParam;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						string directoryName = global::System.IO.Path.GetDirectoryName(fileName2);
						num = (short)1269497856;
						short num3 = num;
						num = (short)2023948294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)849240509;
						short num4 = num;
						num = (short)877683133;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return fileName2;
						default:
						{
							num = (short)1114570752;
							if (num != 0)
							{
							}
							string directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Export_Codeplug_Folder = directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
							num = (short)1769668611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						num = (short)1826947073;
						if (num != 0)
						{
						}
						fileName2 = showRMSaveFileDialogEventParam.FileName;
						num = (short)1231355908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return fileName2;
					case 4:
						if (!string.IsNullOrEmpty(fileName2))
						{
							num = (short)1445724160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileName2;
					case 5:
						if (showRMSaveFileDialogEventParam.IsSuccess)
						{
							num = (short)1856765954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_243;
					case 6:
					{
						string directoryName;
						if (!string.IsNullOrEmpty(directoryName))
						{
							num = (short)540606465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return fileName2;
					}
					}
					goto IL_4B;
				}
				return fileName2;
				IL_243:
				return null;
				IL_4B:
				string rmc_Filter_MC = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_MC;
				showRMSaveFileDialogEventParam = new global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogEventParam();
				showRMSaveFileDialogEventParam.Filter = rmc_Filter_MC;
				showRMSaveFileDialogEventParam.FilterIndex = 1;
				showRMSaveFileDialogEventParam.Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ExportRadio;
				showRMSaveFileDialogEventParam.FileName = fileName;
				showRMSaveFileDialogEventParam.InitialDirectory = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Export_Codeplug_Folder);
				this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogRequestedEvent>().Publish(showRMSaveFileDialogEventParam);
				num = (short)1301413893;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00006F50 File Offset: 0x00005150
		public string ShowSaveFileDialogForExportToMNISXML(string fileName, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily)
		{
			short num = (short)2120155137;
			if (num != 0)
			{
			}
			num = (short)2087387136;
			switch (num)
			{
			default:
			{
				num = (short)905510918;
				int num2 = (int)((global::System.IntPtr)num);
				string fileName2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_279;
					case 1:
					{
						bool? flag;
						if (flag.Value)
						{
							num = (short)1822752771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C7;
					}
					case 2:
					{
						string directoryName = global::System.IO.Path.GetDirectoryName(fileName2);
						num = (short)1578565632;
						short num3 = num;
						num = (short)1930690568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Microsoft.Win32.SaveFileDialog saveFileDialog;
						fileName2 = saveFileDialog.FileName;
						num = (short)1944453125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_B1;
					case 5:
						if (!string.IsNullOrEmpty(fileName2))
						{
							goto IL_1C2;
						}
						goto IL_279;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_92;
						}
						continue;
					case 7:
					{
						global::Microsoft.Win32.SaveFileDialog saveFileDialog2 = new global::Microsoft.Win32.SaveFileDialog();
						saveFileDialog2.InitialDirectory = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Export_Devices_to_XML_Folder);
						saveFileDialog2.FileName = fileName;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily2 = productFamily;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily3 = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS;
						saveFileDialog2.Filter = ((productFamily2.GetValueOrDefault() == productFamily3 & productFamily2 != null) ? global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_GWCFG : global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_VRCCFG);
						productFamily2 = productFamily;
						productFamily3 = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS;
						saveFileDialog2.Title = ((productFamily2.GetValueOrDefault() == productFamily3 & productFamily2 != null) ? global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ExportToMNISXML : global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ExportToVRCXML);
						global::Microsoft.Win32.SaveFileDialog saveFileDialog = saveFileDialog2;
						bool? flag = saveFileDialog.ShowDialog();
						num = (short)872218625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						string directoryName;
						if (!string.IsNullOrEmpty(directoryName))
						{
							num = (short)1422786569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					}
					case 9:
					{
						string directoryName;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Export_Devices_to_XML_Folder = directoryName;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
						num = (short)998834176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_92:
					if (productFamily == null)
					{
						num = (short)627965956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1523384327;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C2:
					num = (short)746389506;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_279:
					num = (short)64879786;
					short num4 = num;
					num = (short)706018474;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C2;
					default:
						goto IL_2AE;
					}
				}
				IL_B1:
				return null;
				IL_2AE:
				num = (short)1639383040;
				if (num != 0)
				{
				}
				return fileName2;
				IL_2C7:
				return null;
			}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00007228 File Offset: 0x00005428
		public string ShowSaveFileDialogForGridToFile(string fileName)
		{
			short num = (short)998047745;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num2;
			string fileName2;
			global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogEventParam showRMSaveFileDialogEventParam;
			for (;;)
			{
				IL_33:
				string directoryName;
				switch (num2)
				{
				case 0:
					goto IL_E3;
				case 1:
					if (!string.IsNullOrEmpty(directoryName))
					{
						num = (short)847773696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return fileName2;
				case 2:
					return fileName2;
				case 3:
					if (showRMSaveFileDialogEventParam.IsSuccess)
					{
						num = (short)987496452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_211;
				case 4:
					fileName2 = showRMSaveFileDialogEventParam.FileName;
					num = (short)577896453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!string.IsNullOrEmpty(fileName2))
					{
						num = (short)873725958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return fileName2;
				case 6:
				{
					directoryName = global::System.IO.Path.GetDirectoryName(fileName2);
					num = (short)672333824;
					short num3 = num;
					num = (short)530975571;
					short num4 = num;
					num = (short)1815219027;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E3;
					default:
						num = (short)1971322880;
						if (num != 0)
						{
						}
						num = (short)279248897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_55;
				IL_E3:
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Export_Devices_to_CSV_Folder = directoryName;
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
				num = (short)956039170;
				num2 = (int)((global::System.IntPtr)num);
			}
			return fileName2;
			IL_211:
			return string.Empty;
			IL_55:
			showRMSaveFileDialogEventParam = new global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogEventParam();
			showRMSaveFileDialogEventParam.Filter = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_CSV_Excel_ALL;
			showRMSaveFileDialogEventParam.FilterIndex = 1;
			showRMSaveFileDialogEventParam.Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ExportGridToFile;
			showRMSaveFileDialogEventParam.FileName = fileName;
			showRMSaveFileDialogEventParam.InitialDirectory = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Export_Devices_to_CSV_Folder);
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogRequestedEvent>().Publish(showRMSaveFileDialogEventParam);
			num = (short)1448017923;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000744C File Offset: 0x0000564C
		public string ShowSaveFileDialogForExportDVRS(string fileName)
		{
			short num = (short)63373312;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)31064065;
				if (num != 0)
				{
				}
				bool? flag;
				global::Microsoft.Win32.SaveFileDialog saveFileDialog;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					string fileName2;
					for (;;)
					{
						IL_4F:
						switch (num2)
						{
						case 0:
						{
							string directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTRO_Export_Codeplug_Folder = directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
							num = (short)271843330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							string directoryName;
							if (string.IsNullOrEmpty(directoryName))
							{
								return fileName2;
							}
							num = (short)1339293696;
							short num3 = num;
							num = (short)1331425629;
							short num4 = num;
							num = (short)1576333661;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_B1;
							default:
								num = (short)1660682240;
								if (num != 0)
								{
								}
								num = (short)1240465408;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							return fileName2;
						case 3:
							if (flag.Value)
							{
								num = (short)381353988;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_224;
						case 4:
							fileName2 = saveFileDialog.FileName;
							num = (short)323354629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (!string.IsNullOrEmpty(fileName2))
							{
								num = (short)1729232902;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return fileName2;
						case 6:
						{
							string directoryName = global::System.IO.Path.GetDirectoryName(fileName2);
							num = (short)1084686337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_72;
					}
					return fileName2;
					IL_224:
					return null;
				}
				}
				IL_72:
				saveFileDialog = new global::Microsoft.Win32.SaveFileDialog
				{
					InitialDirectory = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTRO_Export_Codeplug_Folder),
					FileName = fileName,
					Filter = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_XML,
					Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ExportDVRS
				};
				flag = saveFileDialog.ShowDialog();
				IL_B1:
				num = (short)62193667;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00007680 File Offset: 0x00005880
		public void b()
		{
			short num = (short)1594493918;
			short num2 = num;
			num = (short)1544227806;
			switch (num2 == num)
			{
			default:
			{
				num = (short)256376832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)234356737;
			if (num != 0)
			{
			}
			num = (short)1617756160;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ActivateDockedPaneRequestedEvent>().Publish(global::Motorola.CommonCPS.RadioManagement.UIModels.DockPanelNames.SpellCheckView);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000773C File Offset: 0x0000593C
		public string ShowOpenFileDialogForLicense()
		{
			short num = (short)421986304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool? flag;
				global::Microsoft.Win32.OpenFileDialog openFileDialog;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					string fileName;
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
						{
							string directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Select_License_File_Folder = directoryName;
							global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
							num = (short)481951746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							string directoryName;
							if (!string.IsNullOrEmpty(directoryName))
							{
								num = (short)1231589260;
								short num3 = num;
								num = (short)54235020;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_85;
								case 1:
									break;
								default:
								{
									num = (short)16580608;
									short num4 = num;
									break;
								}
								}
								num = (short)929431552;
								if (num != 0)
								{
								}
								num = (short)1863843840;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return fileName;
						}
						case 2:
							return fileName;
						case 3:
							if (flag.Value)
							{
								num = (short)151715844;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_221;
						case 4:
							fileName = openFileDialog.FileName;
							num = (short)1106575365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (!string.IsNullOrEmpty(fileName))
							{
								num = (short)991166470;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return fileName;
						case 6:
						{
							num = (short)645791745;
							if (num != 0)
							{
							}
							string directoryName = global::System.IO.Path.GetDirectoryName(fileName);
							num = (short)1892024321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_4A;
					}
					return fileName;
					IL_221:
					return string.Empty;
				}
				}
				IL_4A:
				openFileDialog = new global::Microsoft.Win32.OpenFileDialog();
				openFileDialog.Filter = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_License);
				openFileDialog.InitialDirectory = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Select_License_File_Folder;
				openFileDialog.FilterIndex = 1;
				openFileDialog.RestoreDirectory = true;
				flag = openFileDialog.ShowDialog();
				IL_85:
				num = (short)1334050819;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00007970 File Offset: 0x00005B70
		public void c()
		{
			short num = (short)1554358935;
			short num2 = num;
			num = (short)669426327;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1577058304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2107899905;
			if (num != 0)
			{
			}
			num = (short)2018967552;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GoToRadioViewRequestedEvent>().Publish(null);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00007A2C File Offset: 0x00005C2C
		public void a(string A_0)
		{
			short num = (short)969435386;
			short num2 = num;
			num = (short)928016634;
			switch (num2 == num)
			{
			default:
			{
				num = (short)656146432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1562902528;
			if (num != 0)
			{
			}
			num = (short)1376256001;
			if (num != 0)
			{
			}
			this.ShowNotificationDialog(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Information_SaveAsConfigurationWithoutApply, A_0), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_SaveAsConfiguration);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00007AF4 File Offset: 0x00005CF4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext ShowSaveTemplateAsDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext saveTemplateAsContext)
		{
			short num = (short)1748945666;
			short num2 = num;
			num = (short)91605762;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1570111488;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1999699969;
			if (num != 0)
			{
			}
			num = (short)1109917696;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSaveTemplateAsDialogRequestedEvent>().Publish(saveTemplateAsContext);
			return saveTemplateAsContext;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00007BB0 File Offset: 0x00005DB0
		public bool a(int A_0)
		{
			short num = (short)1520107521;
			if (num != 0)
			{
			}
			num = (short)1280049152;
			short num2 = num;
			num = (short)1624358163;
			short num3 = num;
			num = (short)203668755;
			switch (num3 == num)
			{
			}
			num = (short)1397686272;
			if (num != 0)
			{
			}
			return this.ShowConfirmationDialog(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation_DeleteSets_With_Amount, A_0), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_DeleteSets);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00007C78 File Offset: 0x00005E78
		public bool b(int A_0)
		{
			short num = (short)1250578692;
			short num2 = num;
			num = (short)823611652;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1501757440;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)107937792;
			if (num != 0)
			{
			}
			num = (short)464191489;
			if (num != 0)
			{
			}
			return this.ShowConfirmationDialog(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation_DeleteConfigurations_With_Amount, A_0), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_DeleteConfigurations);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00007D44 File Offset: 0x00005F44
		public bool ShowTemplateRadioConversionConfirmationDialog()
		{
			short num = (short)2003959809;
			if (num != 0)
			{
			}
			num = (short)1545338880;
			short num2 = num;
			num = (short)1820284716;
			short num3 = num;
			num = (short)353654572;
			switch (num3 == num)
			{
			}
			num = (short)1233780736;
			if (num != 0)
			{
			}
			return this.ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation_TemplateRadioConversion, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_TemplateRadioConversionConfirmation);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00007DFC File Offset: 0x00005FFC
		public bool d()
		{
			short num = (short)330252042;
			short num2 = num;
			num = (short)1553547018;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2146107392;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)984743937;
			if (num != 0)
			{
			}
			num = (short)1918304256;
			if (num != 0)
			{
			}
			return this.ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobSchedule_Warning_Conversion_ModifyState, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_TemplateRadioConversionConfirmation);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00007EB8 File Offset: 0x000060B8
		public bool e()
		{
			short num = (short)415178079;
			short num2 = num;
			num = (short)1938169183;
			switch (num2 == num)
			{
			default:
			{
				num = (short)110559232;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)957349889;
			if (num != 0)
			{
			}
			num = (short)1283129344;
			if (num != 0)
			{
			}
			return this.ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation_ReplaceSet, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_AddSets);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00007F74 File Offset: 0x00006174
		public bool f()
		{
			short num = (short)2135655125;
			short num2 = num;
			num = (short)943096533;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1105264640;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)716177408;
			if (num != 0)
			{
			}
			num = (short)1645543425;
			if (num != 0)
			{
			}
			return this.ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Remove_NonShareableSetConfirmation, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00008030 File Offset: 0x00006230
		public bool g()
		{
			short num = (short)1928934415;
			short num2 = num;
			num = (short)1824142351;
			switch (num2 == num)
			{
			default:
			{
				num = (short)793313280;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1673265153;
			if (num != 0)
			{
			}
			num = (short)1909719040;
			if (num != 0)
			{
			}
			return this.ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation_ReplaceSet, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_AssignSets);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000080EC File Offset: 0x000062EC
		public bool h()
		{
			short num = (short)2099050572;
			short num2 = num;
			num = (short)1406466124;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1683226624;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1198653441;
			if (num != 0)
			{
			}
			num = (short)949616640;
			if (num != 0)
			{
			}
			return this.ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation_ReplaceSet, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_CopySetFromConfig);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000081A4 File Offset: 0x000063A4
		public void ShowRegisterApplicationLicenseDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext registerApplicationLicenseContext)
		{
			short num = (short)323406215;
			short num2 = num;
			num = (short)1708968327;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2028404736;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)826540032;
			if (num != 0)
			{
			}
			num = (short)549257217;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowRegisterApplicationLicenseDialogRequestedEvent>().Publish(registerApplicationLicenseContext);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00008260 File Offset: 0x00006460
		public void ShowRegisterRadioLicenseDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext)
		{
			short num = (short)463241931;
			short num2 = num;
			num = (short)1180533451;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1638400000;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1788542977;
			if (num != 0)
			{
			}
			num = (short)1930231808;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowRegisterRadioLicenseDialogRequestedEvent>().Publish(registerRadioLicenseContext);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000831C File Offset: 0x0000651C
		public void ShowResetIdentifiersDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext resetIdentifiersContext)
		{
			short num = (short)1129445882;
			short num2 = num;
			num = (short)1740044794;
			switch (num2 == num)
			{
			default:
			{
				num = (short)988348416;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1051000833;
			if (num != 0)
			{
			}
			num = (short)2099904512;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowResetIdentifiersDialogRequestedEvent>().Publish(resetIdentifiersContext);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000083D8 File Offset: 0x000065D8
		public void ShowScheduleJobDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext scheduleJobContext)
		{
			short num = (short)1457267255;
			short num2 = num;
			num = (short)484057655;
			switch (num2 == num)
			{
			default:
			{
				num = (short)302317568;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)268500993;
			if (num != 0)
			{
			}
			num = (short)366411776;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowScheduleJobDialogRequestedEvent>().Publish(scheduleJobContext);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00008490 File Offset: 0x00006690
		public bool ShowSelectWarningRadiostoScheduleJobDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext selectWarningRadiostoScheduleJobContext)
		{
			short num = (short)2070820724;
			short num2 = num;
			num = (short)1550595956;
			switch (num2 == num)
			{
			}
			num = (short)490143745;
			if (num != 0)
			{
			}
			num = (short)1562771456;
			short num3 = num;
			num = (short)1704460288;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSelectWarningRadiostoScheduleJobsDialogRequestedEvent>().Publish(selectWarningRadiostoScheduleJobContext);
			return selectWarningRadiostoScheduleJobContext.IsCancelled;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00008550 File Offset: 0x00006750
		public void ShowSelectRadiosDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRadiosContext selectRadiosContext)
		{
			short num = (short)461176833;
			if (num != 0)
			{
			}
			num = (short)178730924;
			short num2 = num;
			num = (short)1426864044;
			switch (num2 == num)
			{
			}
			num = (short)651952128;
			short num3 = num;
			num = (short)531759104;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSelectRadiosDialogRequestedEvent>().Publish(selectRadiosContext);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000860C File Offset: 0x0000680C
		public void ShowSelectRunningRadiosDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRunningRadiosContext selectRunningRadiosContext)
		{
			short num = (short)252574891;
			short num2 = num;
			num = (short)114949291;
			switch (num2 == num)
			{
			}
			num = (short)61800448;
			if (num != 0)
			{
			}
			num = (short)2049572864;
			short num3 = num;
			num = (short)1292828673;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSelectRunningRadiosRequestedEvent>().Publish(selectRunningRadiosContext);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000086C8 File Offset: 0x000068C8
		public void ShowSelectTemplateDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext selectTemplateContext)
		{
			short num = (short)266646840;
			short num2 = num;
			num = (short)1677899064;
			switch (num2 == num)
			{
			}
			num = (short)2084175873;
			if (num != 0)
			{
			}
			num = (short)568655872;
			short num3 = num;
			num = (short)607649792;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSelectTemplateDialogRequestedEvent>().Publish(selectTemplateContext);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00008784 File Offset: 0x00006984
		public bool ShowWiFiPasswordValidationDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext selectTemplateContext)
		{
			short num = (short)909284848;
			short num2 = num;
			num = (short)1865061872;
			switch (num2 == num)
			{
			}
			num = (short)1473904641;
			if (num != 0)
			{
			}
			num = (short)1295712256;
			short num3 = num;
			num = (short)1795883008;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowWiFiPasswordValidationDialogRequestedEvent>().Publish(selectTemplateContext);
			return selectTemplateContext.IsCancel;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00008844 File Offset: 0x00006A44
		public bool ShowSettingsDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext settingsContext)
		{
			short num = (short)1896774535;
			short num2 = num;
			num = (short)1842510727;
			switch (num2 == num)
			{
			}
			num = (short)1342570496;
			if (num != 0)
			{
			}
			num = (short)1163919360;
			short num3 = num;
			num = (short)10420225;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSettingsDialogRequestedEvent>().Publish(settingsContext);
			return settingsContext.IsSaved;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00008904 File Offset: 0x00006B04
		public void b(string A_0)
		{
			short num = (short)443194742;
			short num2 = num;
			num = (short)1575460214;
			switch (num2 == num)
			{
			}
			num = (short)1711341569;
			if (num != 0)
			{
			}
			num = (short)421134336;
			short num3 = num;
			num = (short)314310656;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ReloadMainViewRequestedEvent>().Publish(A_0);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000089C0 File Offset: 0x00006BC0
		public bool ShowDBMigrationDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext migrationContext)
		{
			short num = (short)127753681;
			short num2 = num;
			num = (short)19029457;
			switch (num2 == num)
			{
			}
			num = (short)300810241;
			if (num != 0)
			{
			}
			num = (short)1351811072;
			short num3 = num;
			num = (short)1107230720;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowDBMigrationDialogRequestedEvent>().Publish(migrationContext);
			return migrationContext.CanShowRMC;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00008A80 File Offset: 0x00006C80
		public bool ShowClearDataDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext context)
		{
			short num = (short)1026670925;
			short num2 = num;
			num = (short)1912193357;
			switch (num2 == num)
			{
			}
			num = (short)2063204353;
			if (num != 0)
			{
			}
			num = (short)1247281152;
			short num3 = num;
			num = (short)464519168;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowClearDataDialogRequestedEvent>().Publish(context);
			return context.CanShowDialog;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00008B44 File Offset: 0x00006D44
		public void ShowRadioConversionDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioConversionContext context)
		{
			short num = (short)949298648;
			short num2 = num;
			num = (short)1287726552;
			switch (num2 == num)
			{
			}
			num = (short)958922752;
			if (num != 0)
			{
			}
			num = (short)1802305536;
			short num3 = num;
			num = (short)149618689;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowRadioConversionDialogRequestedEvent>().Publish(context);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00008BFC File Offset: 0x00006DFC
		public void ShowTemplateConversionDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateConversionContext context)
		{
			short num = (short)1531819263;
			short num2 = num;
			num = (short)577680639;
			switch (num2 == num)
			{
			}
			num = (short)910884864;
			if (num != 0)
			{
			}
			num = (short)185270272;
			short num3 = num;
			num = (short)1260650497;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowTemplateConversionDialogRequestedEvent>().Publish(context);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00008CB8 File Offset: 0x00006EB8
		public void LoginUserDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext userLoginContext)
		{
			short num = (short)288377863;
			short num2 = num;
			num = (short)2009680903;
			switch (num2 == num)
			{
			}
			num = (short)860160000;
			if (num != 0)
			{
			}
			num = (short)1586888704;
			short num3 = num;
			num = (short)2000748545;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.UserLoginDialogRequestedEvent>().Publish(userLoginContext);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00008D70 File Offset: 0x00006F70
		public void ChangePasswordDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext changePasswordContext)
		{
			short num = (short)1397579365;
			short num2 = num;
			num = (short)294739557;
			switch (num2 == num)
			{
			}
			num = (short)965214209;
			if (num != 0)
			{
			}
			num = (short)1679687680;
			short num3 = num;
			num = (short)406650880;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ChangePasswordDialogRequestedEvent>().Publish(changePasswordContext);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00008E2C File Offset: 0x0000702C
		public void OAuthLoginDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginContext oauthLoginContext)
		{
			short num = (short)1516101498;
			short num2 = num;
			num = (short)1644158842;
			switch (num2 == num)
			{
			}
			num = (short)973864961;
			if (num != 0)
			{
			}
			num = (short)811466752;
			short num3 = num;
			num = (short)1406074880;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.OAuthLoginDialogRequestedEvent>().Publish(oauthLoginContext);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00008EE4 File Offset: 0x000070E4
		public void ShowSelectAgencyDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext context)
		{
			short num = (short)172359681;
			if (num != 0)
			{
			}
			num = (short)618723358;
			short num2 = num;
			num = (short)71628830;
			switch (num2 == num)
			{
			}
			num = (short)292028416;
			short num3 = num;
			num = (short)1731854336;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.SelectAgencyRequestedEvent>().Publish(context);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00008F9C File Offset: 0x0000719C
		public void ShowTestDlg(global::Motorola.CommonCPS.RadioManagement.UIModels.TestDlgContext testDlgContext)
		{
			short num = (short)594915752;
			short num2 = num;
			num = (short)337097128;
			switch (num2 == num)
			{
			}
			num = (short)88539136;
			if (num != 0)
			{
			}
			num = (short)1530068992;
			short num3 = num;
			num = (short)1186725889;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowTestDlgRequestedEvent>().Publish(testDlgContext);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00009058 File Offset: 0x00007258
		public void ShowTemplateRadiosDetectedDialog()
		{
			short num = (short)1971509849;
			short num2 = num;
			num = (short)1684200025;
			switch (num2 == num)
			{
			}
			num = (short)88866816;
			if (num != 0)
			{
			}
			num = (short)1606221824;
			short num3 = num;
			num = (short)1852375041;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowStartUpNotificationDialog(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::RFResourceRepository.PCRRFResources.RMC_HiddenWarningMessageTemplateRadiosContent, new object[]
			{
				global::Motorola.CommonCPS.ResourceRepository.Resources.Action_ID,
				global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Navigation_Advanced,
				global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ContextMenu_Radio_Conversion,
				global::Motorola.CommonCPS.ResourceRepository.Resources.Gesture_Ctrl_Shift_R,
				global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Navigation_Setting,
				global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_HiddenMessage,
				global::Motorola.CommonCPS.ResourceRepository.Resources.Gesture_Alt_E
			}), global::RFResourceRepository.PCRRFResources.RMC_HiddenWarningMessageTemplateRadios);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00009160 File Offset: 0x00007360
		public void ShowSelectFirmwareDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext)
		{
			short num = (short)699529006;
			short num2 = num;
			num = (short)1765603118;
			switch (num2 == num)
			{
			}
			num = (short)736821248;
			if (num != 0)
			{
			}
			num = (short)590020608;
			short num3 = num;
			num = (short)294649857;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSelectFirmwareDialogRequestedEvent>().Publish(selectFirmwareContext);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000921C File Offset: 0x0000741C
		public void ShowUpdateRadio(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext updateRadioContext)
		{
			short num = (short)1868318335;
			short num2 = num;
			num = (short)1341474431;
			switch (num2 == num)
			{
			}
			num = (short)1483735041;
			if (num != 0)
			{
			}
			num = (short)1202323456;
			short num3 = num;
			num = (short)1065025536;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowUpdateRadioDataRequsetedEvent>().Publish(updateRadioContext);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000092D4 File Offset: 0x000074D4
		public void ShowApplyTemplatetoRelatedRadiosDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext applyTemplatetoRelatedRadiosContext)
		{
			short num = (short)1274937690;
			short num2 = num;
			num = (short)947585370;
			switch (num2 == num)
			{
			}
			num = (short)459407360;
			if (num != 0)
			{
			}
			num = (short)668794880;
			short num3 = num;
			num = (short)1620508673;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowApplyTemplatetoRelatedRadiosDialogRequestedEvent>().Publish(applyTemplatetoRelatedRadiosContext);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00009390 File Offset: 0x00007590
		public void i()
		{
			short num = (short)1296921460;
			short num2 = num;
			num = (short)1591767924;
			switch (num2 == num)
			{
			}
			num = (short)1663369217;
			if (num != 0)
			{
			}
			num = (short)1741750272;
			short num3 = num;
			num = (short)1757413376;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00009440 File Offset: 0x00007640
		public void ShowMismatchOptionsDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowMismatchOptionsContext showMismatchOptionsContext)
		{
			short num = (short)866947454;
			short num2 = num;
			num = (short)620007806;
			switch (num2 == num)
			{
			}
			num = (short)1234239489;
			if (num != 0)
			{
			}
			num = (short)1013579776;
			short num3 = num;
			num = (short)1231421440;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowMismatchOptionsRequestedEvent>().Publish(showMismatchOptionsContext);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000094FC File Offset: 0x000076FC
		public void ShowMoveDeviceDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext moveDeviceContext)
		{
			short num = (short)1716661888;
			short num2 = num;
			num = (short)991309440;
			switch (num2 == num)
			{
			}
			num = (short)595066880;
			if (num != 0)
			{
			}
			num = (short)1188560896;
			short num3 = num;
			num = (short)1419509761;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowMoveDeviceDialogRequestedEvent>().Publish(moveDeviceContext);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000095B4 File Offset: 0x000077B4
		public void ShowWaitingIndicator()
		{
			short num = (short)1611437691;
			short num2 = num;
			num = (short)443913851;
			switch (num2 == num)
			{
			}
			num = (short)934281217;
			if (num != 0)
			{
			}
			num = (short)1671561216;
			short num3 = num;
			num = (short)2115502080;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.WaitingIndicatorVisibilityChangedEvent>().Publish(true);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000966C File Offset: 0x0000786C
		public void HideWaitingIndicator()
		{
			short num = (short)1016713143;
			short num2 = num;
			num = (short)1625608119;
			switch (num2 == num)
			{
			}
			num = (short)116654081;
			if (num != 0)
			{
			}
			num = (short)947257344;
			short num3 = num;
			num = (short)615907328;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.WaitingIndicatorVisibilityChangedEvent>().Publish(false);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00009724 File Offset: 0x00007924
		public bool ShowSelectASKDialogForCFS(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext selectASKForCFSContext)
		{
			short num = (short)1401356289;
			if (num != 0)
			{
			}
			num = (short)363513324;
			short num2 = num;
			num = (short)932169196;
			switch (num2 == num)
			{
			}
			num = (short)114491392;
			short num3 = num;
			num = (short)1083572224;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSelectASKForCFSDialogRequestedEvent>().Publish(selectASKForCFSContext);
			return selectASKForCFSContext.IsSelected;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000097E4 File Offset: 0x000079E4
		public void ShowSelectGeneralPackageDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectGeneralPackageContext context)
		{
			short num = (short)108418859;
			short num2 = num;
			num = (short)1753831211;
			switch (num2 == num)
			{
			}
			num = (short)223805441;
			if (num != 0)
			{
			}
			num = (short)631570432;
			short num3 = num;
			num = (short)1112539136;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSelectGeneralPackageRequestedEvent>().Publish(context);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000098A0 File Offset: 0x00007AA0
		public void NotifyPrintView(global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext context)
		{
			short num = (short)1287337392;
			short num2 = num;
			num = (short)858535344;
			switch (num2 == num)
			{
			}
			num = (short)277610496;
			if (num != 0)
			{
			}
			num = (short)1091960832;
			short num3 = num;
			num = (short)758448129;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PrintViewRequestedEvent>().Publish(context);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000995C File Offset: 0x00007B5C
		public void NotifyPrintViewPreview(global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext context)
		{
			short num = (short)1096275610;
			short num2 = num;
			num = (short)924898970;
			switch (num2 == num)
			{
			}
			num = (short)1802502145;
			if (num != 0)
			{
			}
			num = (short)258408448;
			short num3 = num;
			num = (short)1329594368;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PrintViewPreviewRequestedEvent>().Publish(context);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00009A18 File Offset: 0x00007C18
		public void ShowSelectCodeplugversionDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectCodeplugVersionContext context)
		{
			short num = (short)1914000544;
			short num2 = num;
			num = (short)505762976;
			switch (num2 == num)
			{
			}
			num = (short)172949504;
			if (num != 0)
			{
			}
			num = (short)32702464;
			short num3 = num;
			num = (short)1036582913;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowCodeplugVersionRequestedEvent>().Publish(context);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00009AD4 File Offset: 0x00007CD4
		public void ShowAboutDialog()
		{
			short num = (short)1476011532;
			short num2 = num;
			num = (short)628958732;
			switch (num2 == num)
			{
			}
			num = (short)1234173953;
			if (num != 0)
			{
			}
			num = (short)387121152;
			short num3 = num;
			num = (short)620625920;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowAboutDialogRequestedEvent>().Publish(null);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00009B8C File Offset: 0x00007D8C
		public void NotifyOutputPaneItemChanged(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.DockPanelNames, int> parameter)
		{
			short num = (short)1278352126;
			short num2 = num;
			num = (short)1217207038;
			switch (num2 == num)
			{
			}
			num = (short)2046689281;
			if (num != 0)
			{
			}
			num = (short)330432512;
			short num3 = num;
			num = (short)654114816;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.OutputPaneItemChangedEvent>().Publish(parameter);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00009C48 File Offset: 0x00007E48
		public void NotifyOutputPaneBackgroundWork(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.DockPanelNames, global::Motorola.CommonCPS.RadioManagement.UIModels.OutputPaneBackgroundWorkStatus> parameter)
		{
			short num = (short)1931018241;
			if (num != 0)
			{
			}
			num = (short)2123860808;
			short num2 = num;
			num = (short)659131208;
			switch (num2 == num)
			{
			}
			num = (short)886964224;
			short num3 = num;
			num = (short)284295168;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.OutputPaneBackgroundWorkEvent>().Publish(parameter);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00009D04 File Offset: 0x00007F04
		public void NotifyPopupPaneNewItemAdded(global::Motorola.CommonCPS.RadioManagement.UIModels.DockPanelNames dockPanelName)
		{
			short num = (short)213843969;
			if (num != 0)
			{
			}
			num = (short)423356264;
			short num2 = num;
			num = (short)1203562344;
			switch (num2 == num)
			{
			}
			num = (short)991952896;
			short num3 = num;
			num = (short)968228864;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PopupPaneNewItemAddedEvent>().Publish(dockPanelName);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00009DC0 File Offset: 0x00007FC0
		public void ShowCopyPasteWarningViewDialog(global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteWarningContext copyPasteWarningContext)
		{
			short num = (short)2122579969;
			if (num != 0)
			{
			}
			num = (short)1877682760;
			short num2 = num;
			num = (short)579611208;
			switch (num2 == num)
			{
			}
			num = (short)1322385408;
			short num3 = num;
			num = (short)2119892992;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowCopyPasteWarningDialogRequestedEvent>().Publish(copyPasteWarningContext);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00009E7C File Offset: 0x0000807C
		public void DatabaseSpaceWarning(global::Motorola.CommonCPS.Server.CommonDBConstants.DatabaseSpaceLevel databaseSpaceWarning)
		{
			short num = (short)722468865;
			if (num != 0)
			{
			}
			num = (short)1836041469;
			short num2 = num;
			num = (short)890684669;
			switch (num2 == num)
			{
			}
			num = (short)1460338688;
			short num3 = num;
			num = (short)929693696;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.DatabaseSpaceWarningEvent>().Publish(databaseSpaceWarning);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00009F34 File Offset: 0x00008134
		public string ShowOpenFileDialogueForMcGeofenceMapFile()
		{
			short num = (short)1460273153;
			if (num != 0)
			{
			}
			global::System.Windows.Forms.OpenFileDialog openFileDialog = new global::System.Windows.Forms.OpenFileDialog();
			string result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				int num2;
				for (;;)
				{
					IL_3A:
					switch (num2)
					{
					case 0:
						goto IL_D4;
					case 1:
						goto IL_B2;
					case 2:
						result = openFileDialog.FileName;
						num = (short)737214465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (global::System.Windows.Forms.DialogResult.OK == openFileDialog.ShowDialog())
						{
							num = (short)1165557762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = string.Empty;
						num = (short)2131165184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_50;
				}
				IL_B2:
				IL_D4:
				goto IL_190;
				IL_50:
				openFileDialog.Filter = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_KML_KMZ_FILE;
				openFileDialog.Multiselect = false;
				num = (short)1830092803;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_3A;
			}
			finally
			{
				num = (short)180224002;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_18D;
					case 1:
						for (;;)
						{
							((global::System.IDisposable)openFileDialog).Dispose();
							num = (short)2092437159;
							short num3 = num;
							num = (short)1817251495;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_160;
							}
						}
						IL_160:
						num = (short)1261043712;
						if (num != 0)
						{
						}
						num = (short)385351680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_109;
						}
						continue;
					}
					IL_109:
					if (openFileDialog == null)
					{
						break;
					}
					num = (short)841023489;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_18D:;
			}
			IL_190:
			num = (short)1106509824;
			short num4 = num;
			return result;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000A10C File Offset: 0x0000830C
		public string ShowSaveFileDialogueForMcGeofenceMapFile()
		{
			global::System.Windows.Forms.SaveFileDialog saveFileDialog = new global::System.Windows.Forms.SaveFileDialog();
			string result;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				for (;;)
				{
					IL_12:
					switch (num)
					{
					case 0:
						goto IL_A5;
					case 1:
						goto IL_83;
					case 2:
						result = saveFileDialog.FileName;
						num2 = (short)1284374529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (global::System.Windows.Forms.DialogResult.OK == saveFileDialog.ShowDialog())
						{
							num2 = (short)1273954306;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = string.Empty;
						num2 = (short)439484416;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_28;
				}
				IL_83:
				IL_A5:
				goto IL_18B;
				IL_28:
				saveFileDialog.Filter = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_KML_FILE;
				num2 = (short)795213827;
				num = (int)((global::System.IntPtr)num2);
				goto IL_12;
			}
			finally
			{
				num2 = (short)1299972098;
				int num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_161;
					case 1:
						for (;;)
						{
							((global::System.IDisposable)saveFileDialog).Dispose();
							num2 = (short)1735146532;
							short num3 = num2;
							num2 = (short)1295203364;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_133;
							}
						}
						IL_133:
						num2 = (short)113442816;
						if (num2 != 0)
						{
						}
						num2 = (short)2022375424;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_DC;
						}
						continue;
					}
					IL_DC:
					if (saveFileDialog == null)
					{
						goto IL_18A;
					}
					num2 = (short)224526337;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_161:
				num2 = (short)1195114497;
				if (num2 != 0)
				{
				}
				IL_18A:;
			}
			IL_18B:
			num2 = (short)1686700032;
			short num4 = num2;
			return result;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000A2E0 File Offset: 0x000084E0
		public void ShowImportFromConsoleResult(string message)
		{
			short num = (short)42729473;
			if (num != 0)
			{
			}
			num = (short)252737006;
			short num2 = num;
			num = (short)2102883822;
			switch (num2 == num)
			{
			}
			num = (short)1821048832;
			short num3 = num;
			num = (short)2005991424;
			if (num != 0)
			{
			}
			this.ShowNotificationDialog(message, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_ImportResult);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000A394 File Offset: 0x00008594
		public void ShowUpdateLogSettingRequestedEvent(global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting logSetting)
		{
			short num = (short)817173509;
			short num2 = num;
			num = (short)316675077;
			switch (num2 == num)
			{
			}
			num = (short)1482227713;
			if (num != 0)
			{
			}
			num = (short)958791680;
			short num3 = num;
			num = (short)182255616;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowUpdateLogSettingRequestedEvent>().Publish(logSetting);
		}

		// Token: 0x04000003 RID: 3
		private global::Microsoft.Practices.Prism.Events.IEventAggregator a;
	}
}
