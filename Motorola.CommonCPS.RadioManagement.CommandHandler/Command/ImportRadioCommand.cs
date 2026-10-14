using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000AB RID: 171
	internal class ImportRadioCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060003CC RID: 972 RVA: 0x0003EA4C File Offset: 0x0003CC4C
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)721682433;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1627258882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)873212375;
					short num3 = num;
					num = (short)1079060951;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A9;
					default:
						num = (short)1862991872;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					}
					break;
				}
				case 2:
					if (paras.Count<object>() <= 0)
					{
						num = (short)484048899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_127;
				case 3:
					goto IL_FD;
				}
				goto IL_7D;
				IL_A9:
				num = (short)1110114304;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7D:
				num = (short)2054750208;
				short num4 = num;
				if (paras != null)
				{
					goto IL_A9;
				}
				break;
			}
			IL_BF:
			throw new global::System.ArgumentNullException();
			IL_FD:
			num = (short)256573441;
			if (num != 0)
			{
			}
			goto IL_BF;
			IL_127:
			global::Motorola.CommonCPS.RadioManagement.UIModels.ImportRadiosContext importRadiosContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ImportRadiosContext;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.CanImportRadio(importRadiosContext.CreateRadios, importRadiosContext.CreateConfigurations);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0003EBA4 File Offset: 0x0003CDA4
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1659437056;
			switch (num)
			{
			default:
			{
				num = (short)620888072;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.RadioManagement.UIModels.ImportRadiosContext importRadiosContext;
				global::System.Collections.Generic.IList<string> list;
				global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption? overrideOption;
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> filePasswords;
				global::System.Guid? groupID;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						list = importRadiosContext.FileNames.ToList<string>();
						num = (short)1571225605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (importRadiosContext.FileNames != null)
						{
							num = (short)400293888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FA;
					case 2:
						num = (short)1240072193;
						if (num != 0)
						{
						}
						if (paras.Count<object>() <= 0)
						{
							num = (short)1633812489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						for (;;)
						{
							importRadiosContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ImportRadiosContext);
							overrideOption = importRadiosContext.OverrideOption;
							filePasswords = importRadiosContext.FilePasswords;
							num = (short)2035363476;
							short num3 = num;
							num = (short)1408773780;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_39F;
							}
						}
						IL_39F:
						num = (short)1906180096;
						if (num != 0)
						{
						}
						num = (short)849608711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1435631616;
						short num4 = num;
						num = (short)740687874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_256;
					case 5:
						if (list.Count<string>() > 0)
						{
							num = (short)132972548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FA;
					case 6:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> enumerator = filePasswords.GetEnumerator();
						num = (short)1017511946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (!string.IsNullOrEmpty(importRadiosContext.Password))
						{
							num = (short)467009542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_94;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_72;
						}
						continue;
					case 9:
						goto IL_2E7;
					case 10:
						try
						{
							num = (short)1136984066;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1697906691;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1342767104;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									enumerator.Current.Password = importRadiosContext.Password;
									num = (short)344195076;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_11B;
									}
									continue;
								case 3:
									goto IL_193;
								}
								IL_11D:
								num = (short)1310261249;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11B:
								goto IL_11D;
							}
							IL_193:
							goto IL_94;
						}
						finally
						{
							num = (short)15335424;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1CB;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1017839618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_202;
								}
								IL_1CB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1434255361;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_202:;
						}
						goto IL_205;
					}
					IL_72:
					if (paras != null)
					{
						num = (short)48693251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_94:
					groupID = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.ConvertGroupID(importRadiosContext.GroupID);
					num = (short)1931018241;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_205:
				throw new global::System.ArgumentNullException();
				IL_256:
				global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption importOption = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.GetImportOption(importRadiosContext.CreateRadios, importRadiosContext.CreateTemplates, importRadiosContext.CreateConfigurations, importRadiosContext.ApplyConfigurationsToRadios);
				global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportArchiveBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportArchiveBatchOp(list, groupID, overrideOption, filePasswords, importOption);
				base.ExecuteBatchOp<string>(op);
				return null;
				IL_2E7:
				goto IL_205;
				IL_3FA:
				return null;
			}
			}
		}
	}
}
