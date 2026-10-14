using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000C8 RID: 200
	public class ApplyTemplatetoRelatedRadiosCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x00046AD0 File Offset: 0x00044CD0
		public override bool CanExecute(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext applyTemplatetoRelatedRadiosContext2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext applyTemplatetoRelatedRadiosContext;
					if (applyTemplatetoRelatedRadiosContext.SelectedRadioPairs.Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair item)
					{
						short num5 = (short)1020209054;
						short num6 = num5;
						num5 = (short)693249950;
						switch (num6 == num5)
						{
						}
						num5 = (short)1891958785;
						if (num5 != 0)
						{
						}
						num5 = (short)449708032;
						if (num5 != 0)
						{
						}
						num5 = (short)1599275008;
						short num7 = num5;
						return !string.IsNullOrEmpty(item.ErrorString);
					}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair>().Count == 0)
					{
						num2 = (short)1298268174;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					bool result;
					return result;
				}
				case 1:
					num2 = (short)619446287;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					bool result;
					return result;
				}
				case 3:
				{
					bool result = false;
					num2 = (short)1798176772;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (paras != null)
					{
						num2 = (short)1732902919;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A4;
				case 5:
				{
					if (paras.Count<object>() <= 0)
					{
						num2 = (short)982974477;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext applyTemplatetoRelatedRadiosContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext;
					num2 = (short)1525743622;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext applyTemplatetoRelatedRadiosContext;
					if (applyTemplatetoRelatedRadiosContext.SelectedRadioPairs != null)
					{
						num2 = (short)1598423041;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					bool result;
					return result;
				}
				case 7:
				{
					num2 = (short)793119609;
					short num3 = num2;
					num2 = (short)1174735737;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A4;
					default:
						num2 = (short)907280384;
						if (num2 != 0)
						{
						}
						num2 = (short)1624375301;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 8:
					num2 = (short)1963196425;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					return false;
				case 10:
					if (applyTemplatetoRelatedRadiosContext2 == null)
					{
						num2 = (short)635109377;
						if (num2 != 0)
						{
						}
						num2 = (short)182845440;
						short num4 = num2;
						num2 = (short)705691656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)452591628;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)1348141056;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (applyTemplatetoRelatedRadiosContext2.ContextOperation == global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext.Operation.UpgradeLanguagePackforAPX)
					{
						num2 = (short)1807351811;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 13:
					goto IL_11B;
				case 14:
				{
					bool result = true;
					num2 = (short)366149634;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 15:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext applyTemplatetoRelatedRadiosContext;
					if (applyTemplatetoRelatedRadiosContext.SelectedRadioPairs.Count > 0)
					{
						num2 = (short)708771851;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					bool result;
					return result;
				}
				}
				goto IL_50;
			}
			IL_11B:
			IL_1A4:
			throw new global::System.ArgumentNullException();
			IL_50:
			applyTemplatetoRelatedRadiosContext2 = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext);
			num2 = (short)1993211914;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00046DF8 File Offset: 0x00044FF8
		protected override object ExecuteCmd(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext applyTemplatetoRelatedRadiosContext;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_5B;
				case 1:
					goto IL_114;
				case 2:
					if (applyTemplatetoRelatedRadiosContext == null)
					{
						num2 = (short)335937536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)450560004;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					this.a(applyTemplatetoRelatedRadiosContext);
					num2 = (short)1895170049;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (applyTemplatetoRelatedRadiosContext.ContextOperation == global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext.Operation.UpgradeLanguagePackforAPX)
					{
						num2 = (short)868155395;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_157;
				}
				goto IL_24;
			}
			IL_5B:
			num2 = (short)1982595073;
			if (num2 != 0)
			{
			}
			num2 = (short)1909618568;
			short num3 = num2;
			num2 = (short)997750664;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_114:
				break;
			default:
			{
				num2 = (short)509673472;
				short num4 = num2;
				num2 = (short)1832189952;
				if (num2 != 0)
				{
				}
				return false;
			}
			}
			IL_157:
			return true;
			IL_24:
			applyTemplatetoRelatedRadiosContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext);
			num2 = (short)511508482;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00046F64 File Offset: 0x00045164
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext A_0)
		{
			short num = (short)1146224640;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>> dictionary;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair> selectedRadioPairs;
					global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair, global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> keySelector;
					var enumerator2;
					switch (num2)
					{
					case 0:
						selectedRadioPairs = A_0.SelectedRadioPairs;
						if ((keySelector = global::Motorola.CommonCPS.RadioManagement.Command.ApplyTemplatetoRelatedRadiosCommand.<>c.<>9__2_0) == null)
						{
							goto IL_43C;
						}
						goto IL_246;
					case 1:
						try
						{
							num = (short)636420102;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (A_0.SelectedRadioPairs.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair p)
									{
										short num5 = (short)868570147;
										short num6 = num5;
										num5 = (short)1819169827;
										switch (num6 == num5)
										{
										}
										num5 = (short)79233025;
										if (num5 != 0)
										{
										}
										num5 = (short)1276444672;
										if (num5 != 0)
										{
										}
										num5 = (short)32309248;
										short num7 = num5;
										return p.TemplateUuid == CS$<>8__locals1.template.TemplateID;
									}) == null)
									{
										num = (short)647888899;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									goto IL_37E;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)917176325;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase template = enumerator.Current;
									num = (short)1746141184;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									dictionary.Add(CS$<>8__locals1.template as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, null);
									num = (short)1032323076;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)1823145985;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_298;
									}
									continue;
								}
								IL_29A:
								num = (short)2069299202;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_298:
								goto IL_29A;
							}
							IL_37E:
							goto IL_4C2;
						}
						finally
						{
							num = (short)1021837314;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)79417532;
								short num3 = num;
								num = (short)246010044;
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> enumerator;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)327876608;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)1834876929;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_439;
									case 2:
										goto IL_398;
									}
									goto IL_3FF;
								}
								IL_398:
								switch (0)
								{
								case 0:
									IL_3FF:
									if (enumerator == null)
									{
										goto IL_43B;
									}
									num = (short)576716800;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_439:
							IL_43B:;
						}
						goto IL_43C;
					case 2:
					{
						num = (short)279773184;
						short num4 = num;
						try
						{
							num = (short)1523056643;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									var <>f__AnonymousType;
									dictionary.Add(<>f__AnonymousType.template as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, <>f__AnonymousType.radioList.Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair p)
									{
										short num5 = (short)1217526125;
										short num6 = num5;
										num5 = (short)732756333;
										switch (num6 == num5)
										{
										}
										num5 = (short)562102273;
										if (num5 != 0)
										{
										}
										num5 = (short)1640235008;
										if (num5 != 0)
										{
										}
										num5 = (short)1165295616;
										short num7 = num5;
										return p.Radio;
									}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>());
									num = (short)1858732033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_1D4;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_FE;
									}
									continue;
								case 4:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1428750341;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									var <>f__AnonymousType = enumerator2.Current;
									num = (short)728367104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1711669250;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_17B:
								num = (short)1225261060;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FE:
								goto IL_17B;
							}
							IL_1D4:
							goto IL_92;
						}
						finally
						{
							num = (short)1056440322;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)439877633;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_243;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_20C;
									}
									continue;
								}
								IL_20C:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)554631168;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_243:;
						}
						goto IL_246;
						IL_92:
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> enumerator = A_0.Templates.GetEnumerator();
						num = (short)1310785537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_3A;
					IL_246:
					enumerator2 = selectedRadioPairs.GroupBy(keySelector, delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase p, global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair> v)
					{
						short num5 = (short)316801025;
						if (num5 != 0)
						{
						}
						num5 = (short)681194944;
						short num6 = num5;
						num5 = (short)1022768576;
						switch (num6 == num5)
						{
						}
						num5 = (short)2122055680;
						if (num5 != 0)
						{
						}
						num5 = (short)790298624;
						short num7 = num5;
						return new
						{
							template = p,
							radioList = v
						};
					}).GetEnumerator();
					num = (short)1173422082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43C:
					keySelector = (global::Motorola.CommonCPS.RadioManagement.Command.ApplyTemplatetoRelatedRadiosCommand.<>c.<>9__2_0 = delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair p)
					{
						short num5 = (short)937865194;
						short num6 = num5;
						num5 = (short)1568583658;
						switch (num6 == num5)
						{
						}
						num5 = (short)69271552;
						if (num5 != 0)
						{
						}
						num5 = (short)175702017;
						if (num5 != 0)
						{
						}
						num5 = (short)985989120;
						short num7 = num5;
						return p.Template;
					});
					goto IL_246;
				}
				IL_4C2:
				global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROUpgradeLanguagePackBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROUpgradeLanguagePackBatchOp(dictionary);
				base.ExecuteBatchOp<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>>(op);
				return;
				IL_3A:
				dictionary = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>();
				num = (short)138412033;
				if (num != 0)
				{
				}
				num = (short)843579392;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
