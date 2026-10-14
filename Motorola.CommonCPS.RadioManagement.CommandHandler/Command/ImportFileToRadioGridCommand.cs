using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.Common.CommonUtility.CSV;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000A8 RID: 168
	public class ImportFileToRadioGridCommand : global::Motorola.CommonCPS.RadioManagement.Command.ImportFileToGridCommandBase
	{
		// Token: 0x060003BF RID: 959 RVA: 0x0003D7E4 File Offset: 0x0003B9E4
		protected override void ProcessParameters(params object[] paras)
		{
			short num = (short)1918828546;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (paras.Count<object>() != 1)
					{
						num = (short)1467547649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_128;
				case 1:
				{
					num = (short)704380929;
					if (num != 0)
					{
					}
					num = (short)122068141;
					short num3 = num;
					num = (short)2105515181;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7C;
					default:
						goto IL_10E;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
				{
					num = (short)1815019520;
					short num4 = num;
					goto IL_7C;
				}
				}
				IL_34:
				if (paras != null)
				{
					num = (short)1403060227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7C:
				num = (short)1764687872;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_76:
			throw new global::System.ArgumentException();
			IL_10E:
			num = (short)937295872;
			if (num != 0)
			{
			}
			goto IL_76;
			IL_128:
			this.a = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.Group);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0003D928 File Offset: 0x0003BB28
		protected override void PreprocessImportData(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile)
		{
			short num = (short)1307377665;
			if (num != 0)
			{
			}
			num = (short)701242459;
			short num2 = num;
			num = (short)1817320539;
			switch (num2 == num)
			{
			}
			num = (short)683147264;
			short num3 = num;
			num = (short)149028864;
			if (num != 0)
			{
			}
			this.a(csvFile);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0003D9D8 File Offset: 0x0003BBD8
		protected override bool HasHeaderAliasRow()
		{
			short num = (short)265660513;
			short num2 = num;
			num = (short)546416737;
			switch (num2 == num)
			{
			}
			num = (short)979501057;
			if (num != 0)
			{
			}
			num = (short)1642397696;
			short num3 = num;
			num = (short)127729664;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0003DA84 File Offset: 0x0003BC84
		protected override global::System.Collections.Generic.IEnumerable<string> GetRequiredHeadersList()
		{
			int a_ = 7;
			short num = (short)1426525383;
			short num2 = num;
			num = (short)1402801351;
			switch (num2 == num)
			{
			}
			num = (short)84934657;
			if (num != 0)
			{
			}
			num = (short)1522663424;
			short num3 = num;
			num = (short)1958215680;
			if (num != 0)
			{
			}
			return new global::System.Collections.Generic.List<string>
			{
				global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("꯷鿹軻韽懿渁䨃猅攇栉椋簍", a_)
			};
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0003DB50 File Offset: 0x0003BD50
		protected override global::System.Collections.Generic.IEnumerable<string> GetValidHeadersList()
		{
			int a_ = 15;
			short num = (short)1545001662;
			short num2 = num;
			num = (short)1239341758;
			switch (num2 == num)
			{
			}
			num = (short)2115174401;
			if (num != 0)
			{
			}
			num = (short)694288384;
			short num3 = num;
			num = (short)449576960;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IList<string> allCSVHeaderList = global::Motorola.CommonCPS.RadioManagement.SharedServices.CSVHeaderConverter.GetAllCSVHeaderList();
			allCSVHeaderList.Add(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("哿朁椃瘅搇欉砋欍帏猑礓猕", a_));
			return allCSVHeaderList;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0003DC20 File Offset: 0x0003BE20
		protected override global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string> GetImportBatchOp(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile)
		{
			short num = (short)608095712;
			short num2 = num;
			num = (short)1818742240;
			switch (num2 == num)
			{
			}
			num = (short)573833217;
			if (num != 0)
			{
			}
			num = (short)1684275200;
			short num3 = num;
			num = (short)121962496;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp astroimportCSVBatchOp = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp(this.a, global::System.Threading.Thread.CurrentThread.CurrentCulture, csvFile);
			astroimportCSVBatchOp.RunWorkerCompleted += this.a;
			astroimportCSVBatchOp.DataGridInfo = base.Interaction.GetDataGridInfoForRadios();
			return astroimportCSVBatchOp;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0003DD04 File Offset: 0x0003BF04
		private void a(object A_0, global::System.ComponentModel.RunWorkerCompletedEventArgs A_1)
		{
			short num = (short)1201852366;
			short num2 = num;
			num = (short)2059128782;
			switch (num2 == num)
			{
			}
			num = (short)400556033;
			if (num != 0)
			{
			}
			num = (short)596508672;
			short num3 = num;
			num = (short)1562968064;
			if (num != 0)
			{
			}
			global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Events.IEventAggregator>().GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.RefreshGroupsTree>().Publish(null);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0003DDC4 File Offset: 0x0003BFC4
		private void a(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile A_0)
		{
			int a_ = 7;
			short num = (short)1407909888;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BB;
				}
				int configurationOrTemplateNameIndex;
				for (;;)
				{
					IL_30:
					int num3;
					string text2;
					string text3;
					global::System.Collections.Generic.List<string>.Enumerator enumerator2;
					switch (num2)
					{
					case 0:
						num = (short)524025865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_909;
					case 2:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnodeContainedByConfiguration;
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode = global::Motorola.CommonCPS.Common.CommonUtility.Utility.BFSNodeByNodeName(dbnodeContainedByConfiguration, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("볷鯹裻鿽埿欁怃挅弇䌉䨋䜍唏簑甓琕琗缙䌛⨝ሟᜡᐣဥ", a_));
						num = (short)1151467533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::System.Collections.Generic.List<string> templateNameList = A_0.Records.Select(delegate(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord x)
						{
							short num6 = (short)553518100;
							short num7 = num6;
							num6 = (short)220202004;
							switch (num7 == num6)
							{
							}
							num6 = (short)288358400;
							if (num6 != 0)
							{
							}
							num6 = (short)1915617280;
							short num8 = num6;
							num6 = (short)1767833601;
							if (num6 != 0)
							{
							}
							return x.Fields[configurationOrTemplateNameIndex].Trim();
						}).Distinct<string>().ToList<string>();
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Template>.Enumerator enumerator = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetTemplateListByNameList(templateNameList).GetEnumerator();
						num = (short)397869070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						A_0.Records[num3].Fields[configurationOrTemplateNameIndex] = string.Empty;
						num = (short)591134721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::Motorola.CommonCPS.Server.EntityModel.RecordSummary configRecordByName;
						if (!global::System.Convert.ToBoolean(new global::Motorola.CommonCPS.RadioManagement.Command.PrepareWiFiPasswordValidationCommand().Execute(new object[]
						{
							configRecordByName
						}), global::System.Globalization.CultureInfo.CurrentCulture))
						{
							num = (short)1538916352;
							short num4 = num;
							num = (short)1916665860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_909;
					}
					case 6:
						num = (short)653525014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_280;
					case 8:
					{
						if (num3 >= A_0.RecordCount)
						{
							num = (short)586874912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = A_0[num3, text2].Trim();
						num = (short)58064907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::Motorola.CommonCPS.Server.EntityModel.RecordSummary configRecordByName;
						if (!string.IsNullOrEmpty(configRecordByName.UUID))
						{
							num = (short)1346502674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_909;
					}
					case 10:
						if (configurationOrTemplateNameIndex != 0)
						{
							num = (short)1807941656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
					{
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1869938704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_909;
					}
					case 12:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
						{
							num = (short)161480724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7BD;
					case 13:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
						if (dbnode != null)
						{
							num = (short)1312161820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_909;
					}
					case 14:
						try
						{
							num = (short)970063879;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Template>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)353304578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1672774364;
									short num5 = num;
									num = (short)283017948;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_712;
									default:
									{
										num = (short)1102708736;
										if (num != 0)
										{
										}
										global::Motorola.CommonCPS.Server.EntityModel.Template template = enumerator.Current;
										bool? wiFiEnable = (template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate).WiFiEnable;
										bool flag = true;
										num = (short)778371075;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 2:
									num = (short)313851909;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									bool? wiFiEnable;
									bool flag;
									if (wiFiEnable.GetValueOrDefault() == flag & wiFiEnable != null)
									{
										num = (short)534446086;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									A_0.Records.ForEach(delegate(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord x)
									{
										short num6 = (short)57868289;
										if (num6 != 0)
										{
										}
										num6 = (short)544473089;
										int num7 = (int)((global::System.IntPtr)num6);
										for (;;)
										{
											switch (num7)
											{
											case 0:
												return;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_59;
												}
												continue;
											case 2:
											{
												x.Fields[CS$<>8__locals2.CS$<>8__locals1.configurationOrTemplateNameIndex] = string.Empty;
												num6 = (short)303144665;
												short num8 = num6;
												num6 = (short)1366662873;
												switch ((num8 == num6) ? 1 : 0)
												{
												case 0:
												case 2:
													return;
												default:
													num6 = (short)1534722048;
													if (num6 != 0)
													{
													}
													num6 = (short)374145024;
													num7 = (int)((global::System.IntPtr)num6);
													continue;
												}
												break;
											}
											}
											IL_59:
											num6 = (short)39518208;
											short num9 = num6;
											if (!(x.Fields[CS$<>8__locals2.CS$<>8__locals1.configurationOrTemplateNameIndex] == CS$<>8__locals2.template.Name))
											{
												break;
											}
											num6 = (short)816054274;
											num7 = (int)((global::System.IntPtr)num6);
										}
									});
									num = (short)832503809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_766;
								case 6:
									goto IL_712;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_5A3;
									}
									continue;
								case 8:
									if (!global::System.Convert.ToBoolean(new global::Motorola.CommonCPS.RadioManagement.Command.PrepareWiFiPasswordValidationCommand().Execute(new object[]
									{
										CS$<>8__locals2.template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate
									}), global::System.Globalization.CultureInfo.CurrentCulture))
									{
										num = (short)686424068;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_5A8:
								num = (short)1174732800;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5A3:
								goto IL_5A8;
								IL_712:
								num = (short)2050686984;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_766:
							return;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Template>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_779;
					case 15:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnodeContainedByConfiguration;
						if (dbnodeContainedByConfiguration != null)
						{
							num = (short)2135293954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_909;
					}
					case 16:
					{
						string text;
						global::Motorola.CommonCPS.Server.EntityModel.RecordSummary configRecordByName = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetConfigRecordByName(text);
						num = (short)1487405079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (configurationOrTemplateNameIndex == -1)
						{
							num = (short)1606483999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_779;
					case 18:
					{
						global::Motorola.CommonCPS.Server.EntityModel.RecordSummary configRecordByName;
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnodeContainedByConfiguration = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetDBNodeContainedByConfiguration(new global::System.Guid(configRecordByName.UUID), global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("볷鯹裻鿽埿欁怃挅", a_));
						num = (short)239796239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier != global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
						{
							num = (short)957218822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_504;
					case 20:
						num3 = 0;
						num = (short)1056964633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)466354181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						text3 = global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("곷鿹釻軽泿持瀃挅䘇欉愋欍", a_);
						goto IL_7FC;
					case 23:
					{
						global::Motorola.CommonCPS.Server.EntityModel.RecordSummary configRecordByName;
						if (configRecordByName != null)
						{
							num = (short)704446464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_909;
					}
					case 24:
						num = (short)2111963153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_280;
					case 26:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template)
						{
							num = (short)677707779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 27:
						try
						{
							num = (short)2016346120;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (A_0.Headers.Count == configurationOrTemplateNameIndex)
									{
										num = (short)213188609;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									configurationOrTemplateNameIndex = -1;
									num = (short)1543372804;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									if (enumerator2.Current == text2)
									{
										num = (short)281804803;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int configurationOrTemplateNameIndex2 = configurationOrTemplateNameIndex;
									configurationOrTemplateNameIndex = configurationOrTemplateNameIndex2 + 1;
									num = (short)1434320896;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1167130633;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (!enumerator2.MoveNext())
									{
										num = (short)1487405063;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)955187202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_4F1;
								case 7:
									num = (short)2100625414;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_3B9;
									}
									continue;
								case 9:
									goto IL_438;
								}
								IL_43D:
								num = (short)1655373829;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3B9:
								goto IL_43D;
							}
							IL_438:
							IL_4F1:
							goto IL_14A;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_504;
						IL_14A:
						num = (short)343605258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
						bool flag2 = global::System.Convert.ToBoolean((dbnode as global::Motorola.CommonCPS.Server.EntityModel.DBField).Value, global::System.Globalization.CultureInfo.CurrentCulture);
						num = (short)192938014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						text3 = global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("믷闹鋻飽槿攁焃琅椇縉攋愍縏少甓笕紗", a_);
						goto IL_7FC;
					case 30:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnodeContainedByConfiguration;
						bool flag2;
						if (dbnodeContainedByConfiguration != null && flag2)
						{
							num = (short)1931149333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_909;
					}
					case 31:
						return;
					case 32:
						goto IL_7BD;
					}
					goto IL_BB;
					IL_280:
					num = (short)1083899912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_504:
					num = (short)1345388545;
					if (num != 0)
					{
					}
					num = (short)1733885981;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_779:
					num = (short)1999437836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7BD:
					num = (short)1472593946;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7FC:
					text2 = text3;
					enumerator2 = A_0.Headers.GetEnumerator();
					num = (short)321585179;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_909:
					num3++;
					num = (short)342032391;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_BB:
				configurationOrTemplateNameIndex = 0;
				num = (short)1319043091;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x040000B6 RID: 182
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Group a;
	}
}
