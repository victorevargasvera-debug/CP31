using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000AC RID: 172
	internal class PrepareImportRadiosCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060003CF RID: 975 RVA: 0x0003EFD0 File Offset: 0x0003D1D0
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)2037776385;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)895811584;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)1847656450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1748055053;
					short num4 = num;
					num = (short)583087117;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E1;
					default:
						num = (short)781123584;
						if (num != 0)
						{
						}
						num = (short)303693825;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D5;
						}
						continue;
					}
					break;
				}
				case 2:
					if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsMaintenanceMode)
					{
						num = (short)1616314371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					return false;
				}
				goto IL_D5;
				IL_E1:
				num = (short)1648427008;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D5:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
				{
					goto IL_E1;
				}
				return true;
			}
			return false;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0003F110 File Offset: 0x0003D310
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)166789120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				global::Motorola.CommonCPS.RadioManagement.InteractionHelper.IInteraction instance;
				string[] array;
				global::System.Guid? id;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<string> enumerator;
					global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> observableCollection;
					global::Motorola.CommonCPS.RadioManagement.UIModels.ImportRadiosContext importRadiosContext;
					global::System.Collections.Generic.IList<string> list;
					switch (num2)
					{
					case 0:
					{
						num = (short)432687702;
						short num3 = num;
						num = (short)1602374230;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1939472384;
							if (num != 0)
							{
							}
							try
							{
								num = (short)582090754;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)2034434051;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)200081408;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										string path = enumerator.Current;
										observableCollection.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword
										{
											Password = null,
											FileName = global::System.IO.Path.GetFileNameWithoutExtension(path)
										});
										num = (short)972816388;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_EE;
										}
										continue;
									case 3:
										goto IL_188;
									}
									IL_F0:
									num = (short)200933377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_EE:
									goto IL_F0;
								}
								IL_188:
								break;
							}
							finally
							{
								num = (short)1193017344;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_1C0;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)594280450;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_1F7;
									}
									IL_1C0:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1238564865;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1F7:;
							}
							goto IL_1FA;
						}
						importRadiosContext.FilePasswords = observableCollection;
						instance.ShowImportRadiosDialog(importRadiosContext);
						num = (short)1213988871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_3C6;
					case 2:
						goto IL_3C6;
					case 3:
					{
						list = array.ToList<string>();
						importRadiosContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.ImportRadiosContext();
						importRadiosContext.OverrideOption = null;
						importRadiosContext.GroupID = id;
						importRadiosContext.FileNames = list.ToArray<string>();
						bool flag = false;
						num = (short)1503395849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						array = ((global::System.Collections.Generic.List<string>)paras[1]).ToArray();
						num = (short)1433665537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_2B3;
					case 6:
						num = (short)653787137;
						if (num != 0)
						{
						}
						if (array.Length != 0)
						{
							num = (short)1370226691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48A;
					case 7:
						goto IL_361;
					case 8:
						goto IL_1FA;
					case 9:
					{
						bool flag;
						if (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.IsInitializeImportRadio(out flag) && flag)
						{
							num = (short)2089746440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B3;
					}
					case 10:
						if (paras.Length == 2)
						{
							num = (short)228261892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array = instance.ShowOpenFileDialogForImportRadios();
						num = (short)1539178498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (array != null)
						{
							num = (short)912982028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48A;
					case 12:
						num = (short)905838598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_63;
					IL_1FA:
					num = (short)1885077504;
					short num4 = num;
					importRadiosContext.IsAlwaysOverrideEditable = true;
					importRadiosContext.IsNeverOverrideEditable = true;
					importRadiosContext.IsOverrideWhenFlashcodeNotChangedEditable = true;
					importRadiosContext.OverrideOption = new global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption?(global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption.Overwrite_Always);
					num = (short)25755653;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B3:
					importRadiosContext.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.ImportRadioContextValidator();
					observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword>();
					enumerator = list.GetEnumerator();
					num = (short)1088421888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C6:
					num = (short)1647902731;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_361:
				IL_48A:
				return null;
				IL_63:
				id = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.Group).ID;
				instance = global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance();
				array = null;
				num = (short)1725169674;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
