using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200006E RID: 110
	internal class AstroUpgradeLanguagePackCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600030D RID: 781 RVA: 0x0002E5F8 File Offset: 0x0002C7F8
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)845152261;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.ICollection collection;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_56;
				case 1:
					if (collection.Count == 0)
					{
						num = (short)2015887360;
						short num3 = num;
						num = (short)452132868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_175;
				case 2:
					num = (short)338624513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (collection != null)
					{
						num = (short)1395261442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					return false;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				}
				IL_3C:
				if (paras == null)
				{
					num = (short)227409920;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					collection = (paras[0] as global::System.Collections.ICollection);
					num = (short)1639120899;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_56:
			num = (short)1426587649;
			if (num != 0)
			{
			}
			num = (short)1303845373;
			short num4 = num;
			num = (short)740563453;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)907608064;
				if (num != 0)
				{
				}
				break;
			}
			return false;
			IL_175:
			return collection.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate>().All(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, bool>(global::Motorola.CommonCPS.RadioManagement.Command.AstroUpgradeLanguagePackCommand.a));
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0002E798 File Offset: 0x0002C998
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)424935424;
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
				global::System.Collections.ICollection collection;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_11F;
					case 1:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate> list;
						if (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetReferencedRadiosCount(list.Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate p)
						{
							short num5 = (short)273017906;
							short num6 = num5;
							num5 = (short)596306994;
							switch (num6 == num5)
							{
							default:
							{
								num5 = (short)739442688;
								short num7 = num5;
								break;
							}
							case true:
								break;
							}
							num5 = (short)1706885120;
							if (num5 != 0)
							{
							}
							num5 = (short)1135017985;
							if (num5 != 0)
							{
							}
							return p.TemplateID;
						}).ToList<global::System.Guid>(), true, true) > 0)
						{
							num = (short)757858312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>> dictionary = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>();
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate>.Enumerator enumerator = list.GetEnumerator();
						num = (short)758972420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)287637507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (collection.Count == 0)
						{
							num = (short)1437794304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate> list = collection.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate>();
						num = (short)142671873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>> dictionary;
						try
						{
							num = (short)1995440132;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1364542484;
									short num3 = num;
									num = (short)833504276;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
									{
										num = (short)2060058624;
										if (num != 0)
										{
										}
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)333709315;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate key = enumerator.Current;
										dictionary.Add(key, null);
										num = (short)1735131138;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 1:
									goto IL_372;
								case 3:
									num = (short)352518145;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_2A2;
									}
									continue;
								}
								IL_2A4:
								num = (short)1459748864;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2A2:
								goto IL_2A4;
							}
							IL_372:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROUpgradeLanguagePackBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROUpgradeLanguagePackBatchOp(dictionary);
						base.ExecuteBatchOp<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>>(op);
						num = (short)1888092166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_239;
					case 6:
						goto IL_3AB;
					case 7:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate> list;
						global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext applyTemplatetoRelatedRadiosContext;
						applyTemplatetoRelatedRadiosContext.Templates = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(list.Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate c)
						{
							short num5 = (short)1316766305;
							short num6 = num5;
							num5 = (short)964510305;
							switch (num6 == num5)
							{
							default:
							{
								num5 = (short)1853685760;
								short num7 = num5;
								break;
							}
							case true:
								break;
							}
							num5 = (short)1565065216;
							if (num5 != 0)
							{
							}
							num5 = (short)1967652865;
							if (num5 != 0)
							{
							}
							return c.RadioReferencedCount > 0;
						}).OfType<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>());
						applyTemplatetoRelatedRadiosContext.RadioPairs = new global::Motorola.CommonCPS.RadioManagement.LocalService.TemplateRelatedRadiosViewCache(applyTemplatetoRelatedRadiosContext.Templates.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>());
						base.Interaction.ShowApplyTemplatetoRelatedRadiosDialog(applyTemplatetoRelatedRadiosContext);
						num = (short)2145189893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext applyTemplatetoRelatedRadiosContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext();
						num = (short)958398471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (collection != null)
						{
							num = (short)1913651202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_121;
					}
					goto IL_56;
				}
				IL_11F:
				IL_121:
				return false;
				IL_239:
				IL_3AB:
				return true;
				IL_56:
				num = (short)885850112;
				short num4 = num;
				collection = (paras[0] as global::System.Collections.ICollection);
				num = (short)760348673;
				if (num != 0)
				{
				}
				num = (short)518782985;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0002EB74 File Offset: 0x0002CD74
		private static bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate A_0)
		{
			short num = (short)593362955;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation templateOperation;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (!templateOperation.CheckIsSupportedLanguagePack(A_0.FirmwareVersion, A_0.CPLanguageIndex))
					{
						num = (short)4915210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)558104576;
					short num3 = num;
					num = (short)265224197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (!string.IsNullOrEmpty(A_0.FirmwareVersion))
					{
						num = (short)1731395588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					goto IL_128;
				case 3:
					goto IL_1DA;
				case 4:
					num = (short)1817182215;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (string.IsNullOrEmpty(A_0.LanguagePacksInfo))
					{
						num = (short)1545469954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					return false;
				case 7:
				{
					if (!global::Motorola.CommonCPS.RadioManagement.Command.AstroUpgradeLanguagePackCommand.a.IsMatch(A_0.FirmwareVersion))
					{
						num = (short)2006777859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)248475285;
					short num4 = num;
					num = (short)762474133;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_62;
					default:
					{
						num = (short)1445134336;
						if (num != 0)
						{
						}
						int? cplanguageIndex = A_0.CPLanguageIndex;
						int num5 = 0;
						num = (short)1669332993;
						if (num != 0)
						{
						}
						num = (short)1493434377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 8:
					return false;
				case 9:
				{
					int? cplanguageIndex;
					int num5;
					if (cplanguageIndex.GetValueOrDefault() == num5 & cplanguageIndex != null)
					{
						num = (short)702873608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					templateOperation = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance();
					num = (short)781516800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					return false;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				}
				goto IL_55;
				IL_62:
				num = (short)1516371974;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_55:
				if (global::Motorola.Common.Communication.CommonUtil.ModelNumber.IsAmp(A_0.ModelNumber))
				{
					goto IL_62;
				}
				num = (short)448266241;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_128:
			return !string.IsNullOrEmpty(templateOperation.AstroDecodeLanguageIndexToLPID(A_0.CPLanguageIndex));
			IL_1DA:
			return false;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0002EE38 File Offset: 0x0002D038
		// Note: this type is marked as 'beforefieldinit'.
		static AstroUpgradeLanguagePackCommand()
		{
			int a_ = 10;
			short num = (short)1450191731;
			short num2 = num;
			num = (short)2147101555;
			switch (num2 == num)
			{
			default:
			{
				num = (short)215810048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1889271809;
			if (num != 0)
			{
			}
			num = (short)366804992;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Command.AstroUpgradeLanguagePackCommand.a = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("폺ꇼ鯾⨀异⬄嬆洈\u200a儌ℎ䴐眒㸔㸖", a_));
		}

		// Token: 0x0400007F RID: 127
		private static readonly global::System.Text.RegularExpressions.Regex a;
	}
}
