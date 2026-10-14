using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000D5 RID: 213
	internal class SelectTemplateCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600044A RID: 1098 RVA: 0x00049738 File Offset: 0x00047938
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)579600384;
			switch (num)
			{
			default:
			{
				num = (short)800194562;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)109707276;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									text = radioBase.ModelNumber;
									num = (short)454164485;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_1A7;
								case 2:
									result = false;
									num = (short)1315438598;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									if (!string.IsNullOrEmpty(radioBase.ModelNumber))
									{
										num = (short)1552482312;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_27C;
								}
								case 4:
									num = (short)1898184714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_27C;
								case 6:
									goto IL_124;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2044133380;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
									num = (short)1771634699;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1619591182;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.TemplateService.IsRadioCanSelectATemplate(radioBase.ToEntity()))
									{
										num = (short)491978765;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									goto IL_2E6;
								case 11:
									if (string.IsNullOrEmpty(text))
									{
										num = (short)906035200;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1386545155;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									switch (0)
									{
									case 0:
										goto IL_10A;
									}
									continue;
								case 13:
									result = false;
									num = (short)438697985;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									if (!text.Equals(radioBase.ModelNumber))
									{
										num = (short)1377435650;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_27C;
								}
								}
								IL_14B:
								num = (short)106692615;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10A:
								goto IL_14B;
								IL_27C:
								num = (short)1887567881;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_124:
							IL_1A7:
							return result;
							IL_2E6:
							bool result2;
							return result2;
						}
						finally
						{
							num = (short)191102976;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_31E;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)789184514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_354;
								}
								IL_31E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2036727809;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_354:;
						}
						goto IL_357;
					case 1:
						return false;
					case 2:
					{
						num = (short)578486272;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					}
					case 3:
						goto IL_414;
					case 4:
						if (list.Count == 0)
						{
							num = (short)2146172931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_357;
					}
					IL_82:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier != global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template)
					{
						num = (short)472383489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)371029103;
					short num4 = num;
					num = (short)535262319;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)884146176;
						if (num != 0)
						{
						}
						list = (paras[0] as global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>);
						bool result2 = true;
						num = (short)1148715012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_364:
					num = (short)603455488;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_357:
					text = string.Empty;
					enumerator = list.GetEnumerator();
					goto IL_364;
				}
				return false;
				IL_414:
				num = (short)1600585729;
				if (num != 0)
				{
				}
				return false;
			}
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00049BA8 File Offset: 0x00047DA8
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)2106814483;
			short num2 = num;
			num = (short)1512599571;
			switch (num2 == num)
			{
			}
			num = (short)1840906240;
			short num3 = num;
			num = (short)1792212992;
			if (num != 0)
			{
			}
			num = (short)1781334017;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list = paras[0] as global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>;
			global::System.Collections.Generic.List<global::System.Guid> radioUUIDList = list.Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item)
			{
				short num4 = (short)2118123521;
				if (num4 != 0)
				{
				}
				num4 = (short)828489016;
				short num5 = num4;
				num4 = (short)779926840;
				switch (num5 == num4)
				{
				default:
				{
					num4 = (short)259588096;
					short num6 = num4;
					break;
				}
				case true:
					break;
				}
				num4 = (short)2079129600;
				if (num4 != 0)
				{
				}
				return item.DeviceUuid;
			}).ToList<global::System.Guid>();
			global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> compatibleTemplateSummaryList = base.LocalService.GetCompatibleTemplateSummaryList(radioUUIDList);
			global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext selectTemplateContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext();
			selectTemplateContext.Radios = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(list);
			selectTemplateContext.Templates = global::System.Windows.Data.CollectionViewSource.GetDefaultView(compatibleTemplateSummaryList);
			base.Interaction.ShowSelectTemplateDialog(selectTemplateContext);
			return null;
		}
	}
}
