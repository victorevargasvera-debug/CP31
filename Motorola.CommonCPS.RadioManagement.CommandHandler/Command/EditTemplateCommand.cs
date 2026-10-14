using System;
using System.Collections;
using System.Collections.Generic;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000D0 RID: 208
	internal class EditTemplateCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x00048578 File Offset: 0x00046778
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1750335497;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1098973185;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> list;
					if (list == null)
					{
						return false;
					}
					num = (short)630081947;
					short num3 = num;
					num = (short)546064795;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1BE;
					default:
					{
						num = (short)1074659328;
						if (num != 0)
						{
						}
						num = (short)1811480576;
						short num4 = num;
						num = (short)1834352647;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					return false;
				case 2:
				{
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> list;
					if (list.Count != 1)
					{
						num = (short)308871173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 3:
					num = (short)567017478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1FA;
				case 5:
					goto IL_1BE;
				case 6:
				{
					global::System.Collections.ICollection collection;
					if (collection.Count == 0)
					{
						num = (short)1314914308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> list = paras[0] as global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>;
					num = (short)755105792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					num = (short)170786818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					global::System.Collections.ICollection collection;
					if (collection != null)
					{
						num = (short)247398403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 9:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				}
				IL_4C:
				if (paras.Length == 0)
				{
					num = (short)1402798081;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Collections.ICollection collection = paras[0] as global::System.Collections.ICollection;
					num = (short)1381564424;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
			IL_1BE:
			return false;
			IL_1FA:
			return false;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00048788 File Offset: 0x00046988
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)18546688;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				string empty;
				global::System.Collections.ICollection collection;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> list;
					switch (num2)
					{
					case 0:
					{
						if (list.Count != 1)
						{
							num = (short)1020985351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.Command.SaveTemplateCommandFromCPS @object = new global::Motorola.CommonCPS.RadioManagement.Command.SaveTemplateCommandFromCPS();
						((global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance()).SaveCodeplugDelegate = new global::Motorola.CommonCPS.RadioManagement.SharedServices.SaveCodeplugToRMCDelegate(@object.Execute);
						global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.TemplateService;
						empty = string.Empty;
						templateService.EditTemplate(list[0], out empty);
						num = (short)1420689410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1535639560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!string.IsNullOrEmpty(empty))
						{
							num = (short)1931476992;
							short num3 = num;
							num = (short)941752325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_282;
					case 3:
						goto IL_11E;
					case 4:
						num = (short)1153564672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1C5;
					case 6:
					{
						num = (short)514916353;
						if (num != 0)
						{
						}
						if (list == null)
						{
							goto IL_8F;
						}
						num = (short)315104046;
						short num4 = num;
						num = (short)2032933678;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1CA;
						default:
							num = (short)884604928;
							if (num != 0)
							{
							}
							num = (short)1725825028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_D1;
					case 8:
						if (collection.Count == 0)
						{
							num = (short)857276419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CA;
					case 9:
						if (collection != null)
						{
							num = (short)1296039937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D3;
					}
					goto IL_56;
					IL_1CA:
					list = (paras[0] as global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>);
					num = (short)456589318;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_8F:
				return false;
				IL_D1:
				goto IL_8F;
				IL_D3:
				return false;
				IL_11E:
				goto IL_D3;
				IL_1C5:
				throw new global::Motorola.Common.CustomException.CommonException(empty);
				IL_282:
				return null;
				IL_56:
				collection = (paras[0] as global::System.Collections.ICollection);
				num = (short)1831534601;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
