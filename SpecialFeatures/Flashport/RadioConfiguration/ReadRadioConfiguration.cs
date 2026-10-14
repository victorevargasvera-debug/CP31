using System;
using System.Collections.Generic;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms;
using SpecialFeatures.Flashport.FlashRadio;
using SpecialFeatures.Model_Configuration;

namespace SpecialFeatures.Flashport.RadioConfiguration
{
	// Token: 0x020000D2 RID: 210
	public class ReadRadioConfiguration : global::System.IDisposable
	{
		// Token: 0x06000CDF RID: 3295 RVA: 0x00002F7A File Offset: 0x0000117A
		public ReadRadioConfiguration()
		{
			this.a = null;
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00108324 File Offset: 0x00106524
		public bool ReadRadio()
		{
			int a_ = 19;
			short num = (short)158859264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)188022784;
				short num3 = num;
				bool result = false;
				bool isMobilePro = global::ConstraintHelper.UtilityMack.IsMobilePro;
				global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering = null;
				string text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude95ꆗ궙좛\ud99d鮡馧", a_);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_95;
					}
					global::SpecialFeatures.Comms.RadioParams radioParams;
					for (;;)
					{
						IL_76:
						global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfiguration radioConfiguration;
						switch (num2)
						{
						case 0:
							goto IL_293;
						case 1:
							goto IL_504;
						case 2:
						{
							try
							{
								modelTiering.UpdateUtilityMackModelType();
								goto IL_1AD;
							}
							finally
							{
								num = (short)1342570498;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering2;
									switch (num2)
									{
									case 0:
										((global::System.IDisposable)modelTiering2).Dispose();
										num = (short)880410625;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_290;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_257;
										}
										continue;
									}
									IL_257:
									if (modelTiering2 == null)
									{
										break;
									}
									num = (short)600965120;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_290:;
							}
							goto Block_5;
							IL_1AD:
							string text2;
							radioConfiguration.General.RadioConfigCurrentFlashcodeValue = text2;
							radioConfiguration.RadioConfigurationFeatures.IsVisible = true;
							global::SpecialFeatures.Flashport.Recordset embeddedRecset = radioConfiguration.RadioConfigurationFeatures.EmbeddedRecset;
							global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationFeaturesInner radioConfigurationFeaturesInner = new global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationFeaturesInner(embeddedRecset);
							radioConfigurationFeaturesInner.RadioConfigurationFeaturesInnerSection.RadioConfigFeatureNameValue = global::CommonResources.AppResources.FLASHcode_Id;
							radioConfigurationFeaturesInner.RadioConfigurationFeaturesInnerSection.RadioConfigCurrentFlashcodeValueValue = text2;
							global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable(true);
							num = (short)1626996736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
							list.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(212, 901, 0));
							global::Motorola.Common.Communication.Pba.PbaObject a_2 = this.b.ReadBlock(radioParams, list, null);
							text = radioParams.ModelNumber;
							string text2 = this.a(this.a(a_2));
							this.a = new global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationRecset();
							radioConfiguration = new global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfiguration(this.a);
							radioConfiguration.General.RadioConfigCurrentModelNumberValue = text;
							global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering2;
							modelTiering = (modelTiering2 = new global::SpecialFeatures.Model_Configuration.ModelTiering(text, ""));
							num = (short)242745346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_51D;
						case 5:
							if (radioParams != null)
							{
								num = (short)1903755267;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_504;
						}
						goto IL_95;
						Block_5:
						try
						{
							IL_293:
							global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
							flashcodeTable.InitTable(false, text, false);
							global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator = flashcodeTable.FLASHcode.GetEnumerator();
							try
							{
								num = (short)39976966;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)993656833;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
										global::SpecialFeatures.Flashport.Recordset embeddedRecset;
										global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationFeaturesInner radioConfigurationFeaturesInner2 = new global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationFeaturesInner(embeddedRecset);
										num = (short)843644932;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										num = (short)1992032261;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										num = (short)1827290524;
										short num4 = num;
										num = (short)1635532188;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_420;
										default:
										{
											num = (short)1565327360;
											if (num != 0)
											{
											}
											global::SpecialFeatures.Flashport.FlashRadio.Option option;
											global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationFeaturesInner radioConfigurationFeaturesInner2;
											radioConfigurationFeaturesInner2.RadioConfigurationFeaturesInnerSection.RadioConfigFeatureNameValue = option.ToString();
											global::SpecialFeatures.Flashport.Recordset embeddedRecset;
											embeddedRecset.AddRecord(radioConfigurationFeaturesInner2);
											num = (short)2053963779;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										break;
									}
									case 4:
									{
										string text2;
										global::SpecialFeatures.Flashport.FlashRadio.Option option;
										if (flashcodeTable.IsOptionEnabledInFlashcode(option, text2))
										{
											num = (short)120258562;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										goto IL_420;
									case 6:
										switch (0)
										{
										case 0:
											goto IL_2F0;
										}
										continue;
									}
									IL_3C8:
									num = (short)132382720;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2F0:
									goto IL_3C8;
								}
								IL_420:;
							}
							finally
							{
								num = (short)516292610;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)1706622977;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_48D;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_455;
										}
										continue;
									}
									IL_455:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1214054400;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_48D:;
							}
							goto IL_176;
						}
						finally
						{
							num = (short)651624450;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)flashcodeTable).Dispose();
									num = (short)10813441;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_501;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4C8;
									}
									continue;
								}
								IL_4C8:
								if (flashcodeTable == null)
								{
									break;
								}
								num = (short)977731584;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_501:;
						}
						goto IL_504;
						IL_176:
						this.a.AddRecord(radioConfiguration);
						global::SpecialFeatures.Flashport.FlashDataManager.AddFeature(this.a);
						result = true;
						num = (short)1880358913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_504:
						num = (short)2037776388;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_51D:
					return result;
					IL_95:
					this.b();
					radioParams = this.b.ReadExtendedDeviceInfo();
					num = (short)1491795973;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_76;
				}
				catch (global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException ex)
				{
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, ex.Message);
				}
				catch (global::Motorola.Common.CustomException.CommonException)
				{
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, global::CommonResources.AppResources.Communication_with_radio_failed_Please_cycle_radio_power_and_check_connections);
				}
				catch (global::System.Exception ex2)
				{
					global::System.Exception innerException = ex2.InnerException;
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, ex2.Message);
				}
				finally
				{
					global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering2;
					modelTiering = (modelTiering2 = new global::SpecialFeatures.Model_Configuration.ModelTiering(text, ""));
					try
					{
						num = (short)1989869569;
						if (num != 0)
						{
						}
						modelTiering.RestoreUtilityMackIfErrorOccurs(isMobilePro);
					}
					finally
					{
						num = (short)892010498;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((global::System.IDisposable)modelTiering2).Dispose();
								num = (short)929431553;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_61E;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_5E6;
								}
								continue;
							}
							IL_5E6:
							if (modelTiering2 == null)
							{
								break;
							}
							num = (short)429326336;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_61E:;
					}
					this.a();
				}
				return result;
			}
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x00108A20 File Offset: 0x00106C20
		public global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationRecset RadioRecset
		{
			get
			{
				short num = (short)936180524;
				short num2 = num;
				num = (short)730528556;
				switch (num2 == num)
				{
				}
				num = (short)624689152;
				if (num != 0)
				{
				}
				num = (short)1576075264;
				short num3 = num;
				num = (short)484507649;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00108AD0 File Offset: 0x00106CD0
		private string a(byte[] A_0)
		{
			short num = (short)2088828937;
			int num2 = (int)((global::System.IntPtr)num);
			byte[] array;
			for (;;)
			{
				int sourceIndex;
				int num4;
				switch (num2)
				{
				case 0:
					num = (short)183697415;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1D0;
				case 2:
					goto IL_17B;
				case 3:
					global::System.Array.Copy(A_0, sourceIndex, array, 0, 12);
					num = (short)1824522241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_A8;
				case 5:
				{
					num = (short)7610308;
					short num3 = num;
					num = (short)22880196;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D0;
					default:
						num = (short)506658816;
						if (num != 0)
						{
						}
						if (num4 >= 24)
						{
							num = (short)1437925376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num4] = 0;
						num4++;
						num = (short)1691746308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					goto IL_A8;
				case 7:
					if (A_0.Length == 16)
					{
						num = (short)252772355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Array.Copy(A_0, sourceIndex, array, 0, 24);
					num = (short)1608843266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_68;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				}
				IL_4D:
				if (A_0 == null)
				{
					num = (short)1481375752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				sourceIndex = 2;
				array = new byte[24];
				num4 = 0;
				num = (short)454623238;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A8:
				num = (short)1997144069;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_68:
			throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Invalid_Radio_Codeplug_Data);
			IL_17B:
			num = (short)842072065;
			if (num != 0)
			{
			}
			goto IL_21E;
			IL_1D0:
			num = (short)264962048;
			short num5 = num;
			IL_21E:
			return global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(array, array.Length);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00108D04 File Offset: 0x00106F04
		private void b()
		{
			short num;
			try
			{
				num = (short)1729993105;
				short num2 = num;
				num = (short)795974033;
				switch (num2 == num)
				{
				}
				num = (short)1378746368;
				if (num != 0)
				{
				}
				global::SpecialFeatures.Comms.RadioParams radioParams = new global::SpecialFeatures.Comms.RadioParams();
				radioParams.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
				radioParams.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
				radioParams.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter;
				this.b = global::SpecialFeatures.Comms.DeviceManagerSingleTon.Instance.CreateDeviceProxy(radioParams, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Connect_Failed);
			}
			num = (short)896663553;
			if (num != 0)
			{
			}
			num = (short)162070528;
			short num3 = num;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00108E00 File Offset: 0x00107000
		private byte[] a(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)1114112000;
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
				byte[] result;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)867827712;
						short num3 = num;
						goto IL_282;
					}
					case 1:
						num = (short)2073821185;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1347289094;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									result = keyValuePair.Value.Data;
									num = (short)1554055169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_1F3;
								case 2:
									num = (short)447807493;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.IshType == 901)
									{
										num = (short)1331888128;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)783286274;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)523770272;
									short num4 = num;
									num = (short)621222304;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_212;
									default:
									{
										num = (short)1851064320;
										if (num != 0)
										{
										}
										global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
										global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
										num = (short)464781315;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 5:
									goto IL_212;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_F1;
									}
									continue;
								}
								IL_F3:
								num = (short)1852964868;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F1:
								goto IL_F3;
							}
							IL_1F3:
							IL_212:
							return result;
						}
						finally
						{
							num = (short)343212034;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2063532033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_27F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_249;
									}
									continue;
								}
								IL_249:
								if (enumerator == null)
								{
									break;
								}
								num = (short)708116480;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_27F:;
						}
						goto IL_282;
					case 2:
						if (codeplugInIshItemCollection.Count > 0)
						{
							num = (short)988348416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_3A;
					IL_282:
					enumerator = codeplugInIshItemCollection.GetEnumerator();
					num = (short)341508097;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_3A:
				result = new byte[0];
				codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				num = (short)1045692418;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x001090F8 File Offset: 0x001072F8
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)864443063;
				short num2 = num;
				num = (short)979589815;
				switch (num2 == num)
				{
				}
				num = (short)183959552;
				if (num != 0)
				{
				}
				this.a(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)1281032193;
			if (num != 0)
			{
			}
			num = (short)887422976;
			short num3 = num;
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x001091C0 File Offset: 0x001073C0
		public void Dispose()
		{
			short num = (short)1801908990;
			short num2 = num;
			num = (short)1013314302;
			switch (num2 == num)
			{
			}
			num = (short)1699479553;
			if (num != 0)
			{
			}
			num = (short)84410368;
			short num3 = num;
			num = (short)1870856192;
			if (num != 0)
			{
			}
			this.a(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00109278 File Offset: 0x00107478
		private void a(bool A_0)
		{
			short num = (short)70385669;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.b != null)
					{
						num = (short)1624375300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_88;
				case 1:
					goto IL_88;
				case 2:
					goto IL_A7;
				case 3:
					num = (short)886243328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1878173443;
					short num3 = num;
					num = (short)2105911043;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)66453504;
						if (num != 0)
						{
						}
						this.b.Dispose();
						num = (short)811270145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				}
				IL_3E:
				num = (short)117440513;
				if (num != 0)
				{
				}
				if (A_0)
				{
					num = (short)470548483;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_88:
				this.b = null;
				num = (short)1639645186;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A7:
			num = (short)1080557568;
			short num4 = num;
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00109410 File Offset: 0x00107610
		private void a()
		{
			short num = (short)1084686336;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
				{
					num = (short)801437039;
					short num3 = num;
					num = (short)1357706607;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_54;
					case 1:
						goto IL_D3;
					}
					goto Block_2;
				}
				case 2:
					goto IL_54;
				}
				IL_31:
				if (this.b != null)
				{
					num = (short)465305602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_114;
				IL_54:
				this.b.Dispose();
				num = (short)530841601;
				num2 = (int)((global::System.IntPtr)num);
			}
			Block_2:
			num = (short)1839464448;
			short num4 = num;
			IL_D3:
			num = (short)56950785;
			if (num != 0)
			{
			}
			num = (short)1378877440;
			if (num != 0)
			{
			}
			IL_114:
			this.b = null;
		}

		// Token: 0x04000639 RID: 1593
		private global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationRecset a;

		// Token: 0x0400063A RID: 1594
		private global::SpecialFeatures.Comms.IDeviceProxy b;

		// Token: 0x0400063B RID: 1595
		private const int c = 901;
	}
}
