using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.Operation.RadioConversion;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000018 RID: 24
	public class RadioConversionBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x0000C680 File Offset: 0x0000A880
		public RadioConversionBatchOp(global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios)
		{
			base.SelectedItems = radios.OrderBy(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase q)
			{
				short num = (short)129731504;
				short num2 = num;
				num = (short)1294044080;
				switch (num2 == num)
				{
				}
				num = (short)1922826240;
				short num3 = num;
				num = (short)1849491456;
				if (num != 0)
				{
				}
				num = (short)1918828545;
				if (num != 0)
				{
				}
				return q.HasPBA;
			}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)827785216;
				short num2 = num;
				num = (short)780156834;
				short num3 = num;
				num = (short)1909407650;
				switch (num3 == num)
				{
				}
				num = (short)96010241;
				if (num != 0)
				{
				}
				num = (short)1430061056;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.RadioConversion;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000C774 File Offset: 0x0000A974
		public override string JobName
		{
			get
			{
				short num = (short)1456996352;
				short num2 = num;
				num = (short)850389992;
				short num3 = num;
				num = (short)443345896;
				switch (num3 == num)
				{
				}
				num = (short)635371521;
				if (num != 0)
				{
				}
				num = (short)1817116672;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_Radio_Conversion;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000C824 File Offset: 0x0000AA24
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)780140544;
			short num2 = num;
			num = (short)273481729;
			if (num != 0)
			{
			}
			num = (short)1995446136;
			short num3 = num;
			num = (short)618338168;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)730923008;
				if (num != 0)
				{
				}
				if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsNewConvertTemplateToConfigEnabled)
				{
					this.OnDoWorkLegacy(e);
					return;
				}
				break;
			}
			this.OnDoWorkNew(e);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		protected void OnDoWorkLegacy(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)778960896;
			short num2 = num;
			num = (short)1960236976;
			short num3 = num;
			num = (short)1641207728;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)128843777;
				if (num != 0)
				{
				}
				num = (short)772145152;
				if (num != 0)
				{
				}
				num = (short)656080896;
				switch (num)
				{
				}
				break;
			}
			int num4 = 0;
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = base.SelectedItems.GetEnumerator();
			try
			{
				num = (short)426180608;
				int num5 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num5)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_123;
						}
						continue;
					case 1:
					{
						if (base.CancellationPending)
						{
							num = (short)1273888771;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService;
						num = (short)732037128;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)2092433413;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1559691271;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
						num = (short)887881729;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_208;
					case 6:
						goto IL_A03;
					case 7:
						goto IL_9EB;
					case 8:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_2BA;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
							global::System.Guid? guid;
							string configurationBaseName;
							string comment;
							for (;;)
							{
								IL_217:
								bool flag;
								global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionResult radioConvertionResult;
								bool flag2;
								switch (num5)
								{
								case 0:
									num = (short)965345308;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (radio.WorkingCodeplug.Configuration != null)
									{
										num = (short)2118713361;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_871;
								case 2:
									num = (short)118226959;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_871;
								case 4:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ConvertTRadioInfo convertTRadioFileInfo;
									if (convertTRadioFileInfo == null)
									{
										num = (short)829685789;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									guid = convertTRadioFileInfo.ArchiveFileUuid;
									num = (short)1894449184;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									if (guid == null)
									{
										num = (short)98435072;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1246036005;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)1935409166;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_5C9;
								case 8:
								{
									guid = radioBase.WorkingTemplateUuid;
									global::System.Guid empty = global::System.Guid.Empty;
									num = (short)1125711908;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_4FD;
								case 10:
									goto IL_952;
								case 11:
									flag = true;
									goto IL_698;
								case 12:
								{
									guid = radioConvertionResult.ReadWriteJobContainerUuid;
									global::System.Guid empty = global::System.Guid.Empty;
									num = (short)1864564770;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = radioConvertionResult.RadioSummary.ToUiModel(true);
									base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
									{
										item
									});
									num = (short)1382350872;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									flag = false;
									goto IL_698;
								case 15:
									if (radio.WorkingCodeplug != null)
									{
										num = (short)10420246;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_871;
								case 16:
									if (radio != null)
									{
										num = (short)822804482;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_871;
								case 17:
									radio.WorkMode = global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Configuration;
									radio.DeviceID = radio.SerialNumber;
									radio.WorkingCodeplug.Configuration.ConfigurationBaseName = configurationBaseName;
									radio.WorkingCodeplug.Configuration.Comment = comment;
									num = (short)1222705155;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									if (guid == null)
									{
										num = (short)1732640774;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1354956827;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									if (guid != null)
									{
										num = (short)1140391948;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_93A;
								case 20:
									num = (short)737935383;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									if (guid != null)
									{
										num = (short)973340680;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4FD;
								case 22:
									num = (short)847314945;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									if (radioConvertionResult.RadioSummary != null)
									{
										num = (short)1578237965;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_634;
								case 24:
									goto IL_634;
								case 25:
								{
									global::Motorola.CommonCPS.Server.EntityModel.RadioConversionRelationshipParameter parameter = new global::Motorola.CommonCPS.Server.EntityModel.RadioConversionRelationshipParameter
									{
										UuidType = global::Motorola.CommonCPS.Server.CommonDBConstants.ProcessType.Radio,
										Uuid = radioBase.DeviceUuid
									};
									global::Motorola.CommonCPS.Server.EntityModel.ConvertTRadioInfo convertTRadioFileInfo = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetConvertTRadioFileInfo(parameter);
									num = (short)1663565828;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 26:
									flag2 = true;
									goto IL_38F;
								case 27:
								{
									global::System.Guid empty;
									flag = (guid.GetValueOrDefault() != empty);
									goto IL_698;
								}
								case 28:
									flag2 = false;
									goto IL_38F;
								case 29:
									goto IL_62F;
								case 30:
									goto IL_93A;
								case 31:
									if (radioConvertionResult != null)
									{
										num = (short)1244463124;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_93A;
								case 32:
								{
									if (guid == null)
									{
										num = (short)1228079111;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.ConvertTRadioInfo convertTRadioFileInfo;
									configurationBaseName = this.a(convertTRadioFileInfo.TemplateName);
									comment = convertTRadioFileInfo.TemplateComment;
									radio = global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility.Instance.CreateConversionRadioByArchiveFile(convertTRadioFileInfo);
									num = (short)846528521;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 33:
									this.a = radioConvertionResult.ReadWriteJobContainerUuid;
									num = (short)1886912542;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 34:
									if (guid == null)
									{
										num = (short)1787297830;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1736310802;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 35:
									num = (short)1741226010;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
									if (guid == null)
									{
										num = (short)332464163;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2017656837;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
								{
									global::System.Guid empty;
									flag2 = (guid.GetValueOrDefault() != empty);
									goto IL_38F;
								}
								case 38:
									num = (short)699990027;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2BA;
								IL_38F:
								if (flag2)
								{
									num = (short)922222617;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4FD:
								num = (short)1229586448;
								num5 = (int)((global::System.IntPtr)num);
								continue;
								IL_634:
								guid = radioConvertionResult.ReadWriteJobContainerUuid;
								num = (short)1130889235;
								num5 = (int)((global::System.IntPtr)num);
								continue;
								IL_698:
								if (flag)
								{
									num = (short)1269235745;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_93A;
								IL_871:
								global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
								global::Motorola.CommonCPS.Server.EntityModel.ValidatedField item2 = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField(radioBase.DeviceUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio, radioBase.RadioTimestamp);
								validateEntitySet.ValidateEntityList.Add(item2);
								global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionOpJobParameter parameter2 = new global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionOpJobParameter
								{
									BatchJobContainerUuid = base.JobContainerGuid,
									RadioUuid = radioBase.DeviceUuid,
									Radio = radio,
									JobType = this.Type,
									JobDescription = radioBase.SerialNumber,
									ReadWriteJobContainerUuid = this.a,
									ValidateEntitySets = validateEntitySet
								};
								radioConvertionResult = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ConvertRadioFromTModeToCMode(parameter2);
								num = (short)777781279;
								num5 = (int)((global::System.IntPtr)num);
								continue;
								IL_93A:
								num = (short)204013578;
								num5 = (int)((global::System.IntPtr)num);
							}
							IL_5C9:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_TEMPLATE_NOT_FOUND);
							IL_62F:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DBMIGRATION_RADIO_CONVERSION_INFO_MISSING);
							IL_952:
							goto IL_128;
							IL_2BA:
							radio = null;
							configurationBaseName = "";
							comment = "";
							guid = radioBase.WorkingTemplateUuid;
							num = (short)1568931861;
							num5 = (int)((global::System.IntPtr)num);
							goto IL_217;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							batchOperationJob.JobDescription = global::System.IO.Path.GetFileNameWithoutExtension(radioBase.SerialNumber);
							batchOperationJob.ErrorCode = new int?((int)ex.ErrorCode);
							batchOperationJob.ErrorMessage = ex.Message;
							if (ex.CommonExceptionData != null)
							{
								batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
							}
							batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
							batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
							global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService;
							radioService.AddBatchOperationJob(batchOperationJob);
							num4++;
							base.ReportProgress(num4);
							break;
						}
						goto IL_9EB;
						IL_128:
						num4++;
						base.ReportProgress(num4);
						num = (short)925630466;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_188:
					num = (short)252772356;
					num5 = (int)((global::System.IntPtr)num);
					continue;
					IL_123:
					goto IL_188;
					IL_9EB:
					num = (short)762118150;
					num5 = (int)((global::System.IntPtr)num);
				}
				IL_208:
				return;
				IL_A03:
				goto IL_C8;
			}
			finally
			{
				num = (short)1549926400;
				int num5 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num5)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A3A;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)639107074;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_A6F;
					}
					IL_A3A:
					if (enumerator == null)
					{
						break;
					}
					num = (short)149356545;
					num5 = (int)((global::System.IntPtr)num);
				}
				IL_A6F:;
			}
			return;
			IL_C8:
			global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility.Instance.ClearLocalFolder(global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.CpdFile);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000D39C File Offset: 0x0000B59C
		protected void OnDoWorkNew(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)1277558785;
			if (num != 0)
			{
			}
			num = (short)1193345024;
			short num2 = num;
			num = (short)2076180480;
			switch (num)
			{
			default:
			{
				int num3 = 0;
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService;
				global::System.Collections.IDictionaryEnumerator enumerator = this.a().GetEnumerator();
				global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.RadioConversionSequence radioConversionSequence = new global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.RadioConversionSequence();
				try
				{
					num = (short)647495683;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1476526084;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list = enumerator.Value as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>;
							global::Motorola.CommonCPS.Server.EntityModel.Radio radio = null;
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.Enumerator enumerator2 = list.GetEnumerator();
							num = (short)1214644226;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_8B6;
						case 2:
							try
							{
								num = (short)2118647814;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
									{
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)814874629;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator2.Current;
										num = (short)1284308999;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										goto IL_88B;
									case 2:
										try
										{
											switch (0)
											{
											case 0:
												goto IL_2C1;
											}
											global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionResult radioConvertionResult;
											for (;;)
											{
												IL_22E:
												global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
												global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
												bool flag;
												bool flag2;
												bool flag3;
												global::Motorola.CommonCPS.Server.EntityModel.Radio radio2;
												switch (num4)
												{
												case 0:
													if (radioConvertionResult == null)
													{
														num = (short)1033502747;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)1802633249;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													if (radio != null)
													{
														num = (short)462880789;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_692;
												case 2:
												{
													this.a(radioConvertionResult);
													global::System.Guid? guid = radioConvertionResult.ReadWriteJobContainerUuid;
													num = (short)1579483140;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 3:
													radioConvertionResult = radioConversionSequence.ConvertRadio(radioBase, new global::System.Guid?(base.JobContainerGuid), this.a, radio);
													num = (short)1374552075;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 4:
												{
													global::System.Guid? guid;
													if (guid != null)
													{
														num = (short)1747386397;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_7A3;
												}
												case 5:
												{
													global::System.Guid? guid;
													if (guid == null)
													{
														num = (short)1411907615;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)1726545929;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 6:
													if (radioConvertionResult == null)
													{
														num = (short)436600850;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)1370619921;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 7:
													num = (short)1817313310;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 8:
													num = (short)1423704064;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 9:
												{
													global::System.Guid? guid;
													global::System.Guid empty;
													flag = (guid.GetValueOrDefault() != empty);
													goto IL_5FB;
												}
												case 10:
													goto IL_578;
												case 11:
													goto IL_578;
												case 12:
													if (radioConvertionResult != null)
													{
														num = (short)960299010;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_7A3;
												case 13:
													flag = true;
													goto IL_5FB;
												case 14:
													goto IL_7A3;
												case 15:
													this.a = radioConvertionResult.ReadWriteJobContainerUuid;
													num = (short)1418199054;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 16:
													goto IL_7BC;
												case 17:
													flag2 = (radioConvertionResult.ConvertedRadio != null);
													goto IL_3FE;
												case 18:
													num = (short)2088501282;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 19:
												{
													global::System.Guid? guid;
													global::System.Guid? workingTemplateUuid;
													if (workingTemplateUuid != null != (guid != null))
													{
														num = (short)1862991892;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)852295706;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 20:
													num = (short)718471191;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 21:
												{
													global::System.Guid? workingTemplateUuid = radioBase.WorkingTemplateUuid;
													global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
													global::System.Guid? guid = list[0].WorkingTemplateUuid;
													num = (short)333578259;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 22:
												{
													global::System.Guid? guid;
													global::System.Guid? workingTemplateUuid;
													flag3 = (workingTemplateUuid.GetValueOrDefault() == guid.GetValueOrDefault());
													goto IL_761;
												}
												case 23:
													flag3 = false;
													goto IL_761;
												case 24:
													radio2 = null;
													goto IL_784;
												case 25:
												{
													global::System.Guid? guid;
													if (guid == null)
													{
														num = (short)118489116;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)743047173;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 26:
												{
													global::System.Guid? workingTemplateUuid;
													if (workingTemplateUuid == null)
													{
														num = (short)1418788871;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)1321926678;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 27:
													num = (short)1901789208;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 28:
													num = (short)665976845;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 29:
												{
													global::System.Guid? guid = radioConvertionResult.ReadWriteJobContainerUuid;
													global::System.Guid empty = global::System.Guid.Empty;
													num = (short)294715417;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 30:
													flag3 = true;
													goto IL_761;
												case 31:
													num = (short)895877152;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												case 32:
													flag = false;
													goto IL_5FB;
												case 33:
													radio2 = radioConvertionResult.ConvertedRadio;
													goto IL_784;
												case 34:
													flag2 = (null != null);
													goto IL_3FE;
												}
												goto IL_2C1;
												IL_3FE:
												if (flag2)
												{
													num = (short)1606615048;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_578:
												num = (short)853868556;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_5FB:
												if (flag)
												{
													num = (short)709623823;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_7A3;
												IL_692:
												radioConvertionResult = radioConversionSequence.ConvertRadio(radioBase, new global::System.Guid?(base.JobContainerGuid), this.a, null);
												num = (short)1102446598;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_761:
												if (flag3)
												{
													num = (short)1405419523;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_692;
												IL_784:
												radio = radio2;
												num = (short)1709244426;
												num4 = (int)((global::System.IntPtr)num);
												continue;
												IL_7A3:
												num = (short)1779957776;
												num4 = (int)((global::System.IntPtr)num);
											}
											IL_7BC:
											break;
											IL_2C1:
											radioConvertionResult = null;
											num = (short)2107441153;
											num4 = (int)((global::System.IntPtr)num);
											goto IL_22E;
										}
										catch (global::Motorola.Common.CustomException.CommonException ex)
										{
											global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
											global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
											{
												JobDescription = global::System.IO.Path.GetFileNameWithoutExtension(radioBase.SerialNumber),
												ErrorCode = new int?((int)ex.ErrorCode),
												ErrorMessage = ex.Message
											};
											if (ex.CommonExceptionData != null)
											{
												batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
											}
											batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
											batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
											radioService.AddBatchOperationJob(batchOperationJob);
											break;
										}
										finally
										{
											num3++;
											base.ReportProgress(num3);
										}
										goto IL_854;
									case 3:
										goto IL_854;
									case 4:
										goto IL_86C;
									case 5:
										num = (short)1106116609;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										switch (0)
										{
										case 0:
											goto IL_184;
										}
										continue;
									case 7:
										if (base.CancellationPending)
										{
											num = (short)1076756483;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)550043650;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_189:
									num = (short)1875247104;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_184:
									goto IL_189;
									IL_854:
									num = (short)1249050628;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_86C:
								return;
								IL_88B:
								break;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_89E;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_CB;
							}
							continue;
						case 4:
							goto IL_89E;
						}
						IL_101:
						num = (short)262340608;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_CB:
						goto IL_101;
						IL_89E:
						num = (short)1082523649;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_8B6:;
				}
				finally
				{
					num = (short)2095382529;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_977;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_8EE;
							}
							continue;
						case 2:
						{
							((global::System.IDisposable)radioConversionSequence).Dispose();
							num = (short)857375346;
							short num5 = num;
							num = (short)737575538;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_8F4;
							default:
								num = (short)191365120;
								if (num != 0)
								{
								}
								num = (short)2030895104;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_8EE;
						IL_8F4:
						num = (short)1105068034;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_8EE:
						if (radioConversionSequence != null)
						{
							goto IL_8F4;
						}
						break;
					}
					IL_977:;
				}
				return;
			}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000DD88 File Offset: 0x0000BF88
		private global::System.Collections.Specialized.OrderedDictionary a()
		{
			short num = (short)89391105;
			if (num != 0)
			{
			}
			num = (short)1722286080;
			short num2 = num;
			num = (short)2066153472;
			switch (num)
			{
			default:
			{
				global::System.Collections.Specialized.OrderedDictionary orderedDictionary = new global::System.Collections.Specialized.OrderedDictionary();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)1490550794;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Guid guid;
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						global::System.Guid guid2;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
						switch (num3)
						{
						case 0:
							num = (short)1631387657;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::System.Guid? workingTemplateUuid;
							guid = workingTemplateUuid.GetValueOrDefault();
							goto IL_243;
						}
						case 2:
						{
							num = (short)277791641;
							short num4 = num;
							num = (short)1022804889;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_28B;
							default:
								num = (short)273678336;
								if (num != 0)
								{
								}
								break;
							}
							break;
						}
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2032402440;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							radioBase = enumerator.Current;
							global::System.Guid? workingTemplateUuid = radioBase.WorkingTemplateUuid;
							num = (short)493420551;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_2CA;
						case 5:
							goto IL_28B;
						case 6:
							if (orderedDictionary.Contains(guid2))
							{
								num = (short)1216741381;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
							{
								radioBase
							};
							orderedDictionary.Add(guid2, list);
							num = (short)2012741643;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::System.Guid? workingTemplateUuid;
							if (workingTemplateUuid == null)
							{
								num = (short)1575157760;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1492910081;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							num = (short)1523908612;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							guid = global::System.Guid.Empty;
							goto IL_243;
						case 10:
							switch (0)
							{
							case 0:
								goto IL_D8;
							}
							continue;
						}
						IL_206:
						num = (short)1115488259;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D8:
						goto IL_206;
						IL_243:
						guid2 = guid;
						num = (short)1615003654;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_28B:
						list = (orderedDictionary[guid2] as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>);
						list.Add(radioBase);
						num = (short)1243414530;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2CA:;
				}
				finally
				{
					num = (short)233504770;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)965935105;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_335;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2FF;
							}
							continue;
						}
						IL_2FF:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1040842752;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_335:;
				}
				return orderedDictionary;
			}
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000E0EC File Offset: 0x0000C2EC
		private void a(global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionResult A_0)
		{
			short num = (short)910884866;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = A_0.RadioSummary.ToUiModel(true);
					base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
					{
						item
					});
					num = (short)617709868;
					short num3 = num;
					num = (short)287408428;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3C;
					case 1:
						break;
					default:
					{
						num = (short)299827200;
						short num4 = num;
						break;
					}
					}
					num = (short)323551233;
					if (num != 0)
					{
					}
					num = (short)1758724096;
					if (num != 0)
					{
					}
					num = (short)1984102401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				goto IL_31;
				IL_3C:
				num = (short)1849032704;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_31:
				if (A_0.RadioSummary != null)
				{
					goto IL_3C;
				}
				break;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000E228 File Offset: 0x0000C428
		private string a(string A_0)
		{
			int a_ = 4;
			short num = (short)110297089;
			if (num != 0)
			{
			}
			num = (short)396010453;
			short num2 = num;
			num = (short)854893525;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1730543616;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1575485440;
			if (num != 0)
			{
			}
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("諈꓊ꏌ꧎룐듒ꃔꗖ룘꿚드냞迠쯢뇤苦蓨鯪臬軮藰雲\ud8f4賶째蛺퓼", a_), A_0);
		}

		// Token: 0x0400002B RID: 43
		private global::System.Guid? a;
	}
}
