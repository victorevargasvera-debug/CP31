using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.CommonBase.Enums;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000C7 RID: 199
	internal class ApplyTemplateCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000420 RID: 1056 RVA: 0x000463D4 File Offset: 0x000445D4
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1093992451;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext selectTemplateContext;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)356253701;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_79;
				case 2:
					goto IL_170;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
				{
					num = (short)892010496;
					short num3 = num;
					num = (short)983888054;
					short num4 = num;
					num = (short)601551030;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_79;
					default:
						goto IL_11B;
					}
					break;
				}
				case 5:
					if (paras.Count<object>() < 1)
					{
						num = (short)389021698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					selectTemplateContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext);
					num = (short)1864105985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C:
				if (paras != null)
				{
					num = (short)1249968128;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_79:
				num = (short)1779105793;
				if (num != 0)
				{
				}
				if (selectTemplateContext != null)
				{
					goto IL_174;
				}
				num = (short)1464729604;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11B:
			num = (short)1089077248;
			if (num != 0)
			{
			}
			return false;
			IL_170:
			return false;
			IL_174:
			return selectTemplateContext.SelectedTemplates.Count == 1;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00046564 File Offset: 0x00044764
		protected override object ExecuteCmd(params object[] paras)
		{
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios;
			global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase;
			for (;;)
			{
				IL_00:
				num = (short)1191575552;
				switch (num)
				{
				default:
				{
					num = (short)1454637062;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)876806144;
						short num3 = num;
						switch (num2)
						{
						case 0:
							num = (short)337575947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							num = (short)1093563513;
							short num4 = num;
							num = (short)1854436473;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1415643136;
								if (num != 0)
								{
								}
								num = (short)1457848324;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_147;
						case 3:
							goto IL_1D8;
						case 4:
							if (radios.Count<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>() == 0)
							{
								num = (short)76939267;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_268;
						case 5:
						{
							if (!this.a(paras))
							{
								num = (short)742326274;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext selectTemplateContext;
							radios = selectTemplateContext.Radios;
							templateBase = selectTemplateContext.SelectedTemplates[0];
							num = (short)1608581129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_A0;
							}
							continue;
						case 7:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext selectTemplateContext;
							if (selectTemplateContext == null)
							{
								num = (short)1601110026;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1881473029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_213;
						case 9:
							if (templateBase != null)
							{
								num = (short)1684930561;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_21A;
						case 10:
							goto IL_266;
						case 11:
						{
							if (paras.Count<object>() < 1)
							{
								num = (short)244318216;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext selectTemplateContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext;
							num = (short)843513863;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_A0:
						if (paras == null)
						{
							goto IL_14C;
						}
						num = (short)827785216;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_147:
			return null;
			IL_14C:
			throw new global::System.ArgumentNullException();
			IL_1D8:
			goto IL_21A;
			IL_213:
			goto IL_14C;
			IL_21A:
			throw new global::System.ArgumentNullException();
			IL_266:
			throw new global::System.ArgumentNullException();
			IL_268:
			num = (short)19660801;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.BatchOp.ApplyTemplateBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ApplyTemplateBatchOp(radios, templateBase.TemplateID, global::Motorola.CommonCPS.RadioManagement.CommonBase.Enums.CommandType.SelectTemplate);
			base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op);
			return null;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00046818 File Offset: 0x00044A18
		private bool a(params object[] A_0)
		{
			short num = (short)1899823104;
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
				global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
				global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext wiFiPasswordValidationContext;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						bool? wiFiEnable;
						bool flag;
						if (wiFiEnable.GetValueOrDefault() == flag & wiFiEnable != null)
						{
							num = (short)568721412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 1:
						goto IL_17C;
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.Command.ASTROWiFiPWDValidation astrowiFiPWDValidation;
						if (astrowiFiPWDValidation.NeedValidation(apxtemplate))
						{
							num = (short)1813250048;
							short num3 = num;
							num = (short)1757347841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 3:
						if (apxtemplate == null)
						{
							num = (short)174718982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25D;
					case 4:
					{
						wiFiPasswordValidationContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext(global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().XMLToEntityCollections<global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork>(apxtemplate.WiFiNetworks).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork>(), apxtemplate);
						global::Motorola.CommonCPS.RadioManagement.Command.ASTROWiFiPWDValidation astrowiFiPWDValidation = new global::Motorola.CommonCPS.RadioManagement.Command.ASTROWiFiPWDValidation(wiFiPasswordValidationContext);
						wiFiPasswordValidationContext.WiFiNetworks = global::System.Windows.Data.CollectionViewSource.GetDefaultView(astrowiFiPWDValidation.WifiNetworkItemSource);
						num = (short)966643383;
						short num4 = num;
						num = (short)2099170999;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B1;
						default:
							num = (short)673054720;
							if (num != 0)
							{
							}
							num = (short)1168769026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						if (apxtemplate != null)
						{
							num = (short)887488519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 6:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase = (A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext).SelectedTemplates[0];
						apxtemplate = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetTemplate(templateBase.TemplateID, false) as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate);
						num = (short)1044447240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						bool? wiFiEnable = apxtemplate.WiFiEnable;
						bool flag = true;
						goto IL_1B1;
					}
					case 8:
						goto IL_25D;
					}
					goto IL_53;
					IL_1B1:
					num = (short)690159616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25D:
					num = (short)2144993285;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_17C:
				num = (short)1518272513;
				if (num != 0)
				{
				}
				base.Interaction.ShowWiFiPasswordValidationDialog(wiFiPasswordValidationContext);
				return wiFiPasswordValidationContext.IsValidationPass;
				IL_53:
				apxtemplate = (A_0[0] as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate);
				num = (short)1668349955;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
