using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace CommonUtility
{
	// Token: 0x0200004D RID: 77
	public class RadioSummaryConverter
	{
		// Token: 0x06000199 RID: 409 RVA: 0x0002CF68 File Offset: 0x0002B168
		public static void PopulateFromRadio(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary changedRadioSummary, global::CommonUtility.RadioSummaryDataContext rsDataContext)
		{
			short num = (short)420216832;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1523908609;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_DB;
				}
				for (;;)
				{
					IL_50:
					num = (short)1412628480;
					short num3 = num;
					global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob readWriteJob;
					global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
					global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem ipprogramSystem;
					switch (num2)
					{
					case 0:
						if (readWriteJob != null)
						{
							num = (short)58327046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A2;
					case 1:
						global::CommonUtility.RadioSummaryConverter.PopulateColumns(changedRadioSummary, radio.Group);
						num = (short)634519556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (ipprogramSystem != null)
						{
							num = (short)358023189;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						changedRadioSummary.IPProgramSystemAlias = null;
						changedRadioSummary.IPProgramSystemType = null;
						num = (short)1963720721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (ipprogramSystem is global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystemDMR3)
						{
							num = (short)1187512338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1430388741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_3DA;
					case 5:
						if (ipprogramSystem is global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystemLE)
						{
							num = (short)601948182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E0;
					case 6:
						changedRadioSummary.LastJobTimestamp = readWriteJob.Timestamp;
						num = (short)113508360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_1E0;
					case 8:
						goto IL_37E;
					case 9:
						goto IL_1E0;
					case 10:
						if (ipprogramSystem is global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystemOther)
						{
							num = (short)12779532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)867172355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (rsDataContext.GetGroup() != null)
						{
							num = (short)1972371457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						changedRadioSummary.GroupName = null;
						num = (short)475987982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						changedRadioSummary.IPProgramSystemType = new global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType?(global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType.Other);
						num = (short)1047789575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_1E0;
					case 14:
						goto IL_3DA;
					case 15:
						return;
					case 16:
						if (radio == null)
						{
							num = (short)746455055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::CommonUtility.RadioSummaryConverter.PopulateColumns(changedRadioSummary, radio);
						changedRadioSummary.Timestamp = radio.Timestamp;
						num = (short)1573388299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_1E0;
					case 18:
						changedRadioSummary.IPProgramSystemType = new global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType?(global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType.DMR3);
						num = (short)299499533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_304;
					case 20:
						changedRadioSummary.LastJobName = readWriteJob.JobContainer.JobName;
						changedRadioSummary.JobType = new global::Motorola.CommonCPS.Server.CommonDBConstants.JobType?(readWriteJob.JobContainer.JobType);
						num = (short)1452670995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						global::CommonUtility.RadioSummaryConverter.PopulateColumns(changedRadioSummary, radio.IPProgramSystem);
						num = (short)1669595146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						changedRadioSummary.IPProgramSystemType = new global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType?(global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType.LE);
						num = (short)1898577929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DB;
					IL_1E0:
					readWriteJob = rsDataContext.GetReadWriteJob();
					global::CommonUtility.RadioSummaryConverter.PopulateColumns(changedRadioSummary, radio.LastJob);
					num = (short)33292288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DA:
					ipprogramSystem = rsDataContext.GetIPProgramSystem();
					num = (short)806354946;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_304:
				goto IL_4A2;
				IL_DB:
				num = (short)393647732;
				short num4 = num;
				num = (short)1637062260;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_37E:
					global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob readWriteJob;
					if (readWriteJob.JobContainer != null)
					{
						num = (short)32636948;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_50;
					}
					break;
				}
				default:
				{
					num = (short)79233024;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.Server.EntityModel.Radio radio = rsDataContext.Radio;
					num = (short)291110928;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_50;
				}
				}
				IL_4A2:
				global::Motorola.CommonCPS.Server.EntityModel.Codeplug workingCodeplug = rsDataContext.GetWorkingCodeplug();
				global::CommonUtility.RadioSummaryConverter.PopulateFromCodeplug(changedRadioSummary, workingCodeplug, rsDataContext);
				return;
			}
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0002D428 File Offset: 0x0002B628
		public static void PopulateFromCodeplug(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary changedRadioSummary, global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug, global::CommonUtility.RadioSummaryDataContext rsDataContext)
		{
			short num = (short)1489633285;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					changedRadioSummary.IsHasPba = new bool?(codeplug is global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug || codeplug.FileUuid != null);
					changedRadioSummary.WorkingCodeplugTimestamp = codeplug.Timestamp;
					num = (short)401211398;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_275;
				case 3:
					goto IL_ED;
				case 4:
					goto IL_105;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 6:
				{
					if (rsDataContext.GetTemplate(codeplug) != null)
					{
						num = (short)6357001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					changedRadioSummary.TemplateName = null;
					changedRadioSummary.TemplateTimestamp = null;
					num = (short)291634905;
					short num3 = num;
					num = (short)1874656985;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_197;
					default:
						num = (short)2128805888;
						if (num != 0)
						{
						}
						num = (short)1939406856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					if (configuration != null)
					{
						num = (short)1637089291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					changedRadioSummary.ConfigurationName = null;
					changedRadioSummary.OriginalConfigurationVersionStamp = null;
					changedRadioSummary.CurrentConfigurationVersionStamp = null;
					num = (short)1313603587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)87425025;
					if (num != 0)
					{
					}
					goto IL_105;
				case 9:
					goto IL_197;
				case 10:
				{
					num = (short)1450049536;
					short num4 = num;
					if (configuration.ConfigurationExt != null)
					{
						num = (short)258998274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 11:
					global::CommonUtility.RadioSummaryConverter.PopulateColumns(changedRadioSummary, configuration);
					changedRadioSummary.ConfigurationUuid = codeplug.ConfigurationUuid;
					changedRadioSummary.ConfigurationOptionsList = codeplug.ConfigurationOptionsList;
					changedRadioSummary.ConfigurationName = codeplug.Configuration.Name;
					num = (short)1940324362;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_54:
				if (codeplug == null)
				{
					num = (short)570884096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				global::CommonUtility.RadioSummaryConverter.PopulateColumns(changedRadioSummary, codeplug);
				num = (short)691339265;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_105:
				configuration = rsDataContext.GetConfiguration(codeplug);
				num = (short)2109800455;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_197:
				global::CommonUtility.RadioSummaryConverter.PopulateColumns(changedRadioSummary, codeplug.Template);
				changedRadioSummary.TemplateName = codeplug.Template.Name;
				changedRadioSummary.TemplateTimestamp = codeplug.Template.Timestamp;
				num = (short)1324744708;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_ED:
			return;
			IL_275:
			changedRadioSummary.CurrentConfigurationVersionStamp = new long?(configuration.ConfigurationExt.VersionStamp);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0002D74C File Offset: 0x0002B94C
		public static void PopulateColumns(global::Motorola.CommonCPS.Server.EntityModel.IEntity summary, global::Motorola.CommonCPS.Server.EntityModel.IEntity entity)
		{
			short num = (short)1647509504;
			switch (num)
			{
			default:
			{
				num = (short)2109734912;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::System.Reflection.PropertyInfo> enumerator;
					global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> properties;
					global::System.Func<global::System.Reflection.PropertyInfo, bool> predicate;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_5E;
						}
						continue;
					case 1:
						num = (short)601358339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							num = (short)359661572;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Type entityType;
								global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition summaryFieldDefinition;
								global::System.Reflection.PropertyInfo propertyInfo;
								switch (num2)
								{
								case 0:
									if (!(entityType == summaryFieldDefinition.SourceEntityType))
									{
										num = (short)1946353666;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2A4;
								case 1:
									if (summaryFieldDefinition != null)
									{
										num = (short)590479363;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									num = (short)315293703;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)823853056;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_182;
									}
									continue;
								case 5:
									num = (short)660209672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (entityType.IsSubclassOf(summaryFieldDefinition.SourceEntityType))
									{
										num = (short)278986762;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 8:
									goto IL_2F9;
								case 9:
									if (!enumerator.MoveNext())
									{
										num = (short)30081029;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									propertyInfo = enumerator.Current;
									summaryFieldDefinition = ((global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition[])propertyInfo.GetCustomAttributes(typeof(global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition), true)).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition>();
									num = (short)1114046465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_2A4;
								}
								IL_224:
								num = (short)1833762825;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_182:
								goto IL_224;
								IL_2A4:
								object value = entityType.GetProperty(summaryFieldDefinition.SourceEntityPropertyName).GetValue(entity, null);
								propertyInfo.SetValue(summary, value, null);
								num = (short)53084166;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2F9:
							return;
						}
						finally
						{
							num = (short)1689649152;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_332;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)488701954;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_368;
								}
								IL_332:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2057830401;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_368:;
						}
						goto IL_36B;
					case 3:
					{
						num = (short)1857814528;
						short num3 = num;
						if (entity == null)
						{
							num = (short)231407621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)825819140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::System.Type type = summary.GetType();
						global::System.Type entityType = entity.GetEntityType();
						properties = type.GetProperties();
						if ((predicate = global::CommonUtility.RadioSummaryConverter.<>c.<>9__2_0) == null)
						{
							goto IL_36B;
						}
						goto IL_3E8;
					}
					case 5:
						goto IL_3E3;
					}
					IL_5E:
					num = (short)537355970;
					short num4 = num;
					num = (short)800483010;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1677393921;
						if (num != 0)
						{
						}
						num = (short)1438253056;
						if (num != 0)
						{
						}
						if (summary == null)
						{
							return;
						}
						break;
					}
					num = (short)771227649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E8:
					enumerator = properties.Where(predicate).GetEnumerator();
					num = (short)1186725890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36B:
					predicate = (global::CommonUtility.RadioSummaryConverter.<>c.<>9__2_0 = new global::System.Func<global::System.Reflection.PropertyInfo, bool>(global::CommonUtility.RadioSummaryConverter.<>c.<>9.a));
					goto IL_3E8;
				}
				return;
				IL_3E3:
				return;
			}
			}
		}
	}
}
