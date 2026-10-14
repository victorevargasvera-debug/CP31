using System;
using System.Collections.Generic;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport.FlashkeyLib;
using SpecialFeatures.Flashport.FlashRadio;
using SpecialFeatures.Model_Configuration;

namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
	// Token: 0x0200010E RID: 270
	public class ReadFlashkeyConfiguration : global::System.IDisposable
	{
		// Token: 0x06000EE9 RID: 3817 RVA: 0x0000335A File Offset: 0x0000155A
		public ReadFlashkeyConfiguration()
		{
			this.b = false;
			this.a = null;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0014CAA4 File Offset: 0x0014ACA4
		public bool ReadFlashkey()
		{
			int a_ = 3;
			short num = (short)1098252288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool result = false;
				bool isMobilePro = global::ConstraintHelper.UtilityMack.IsMobilePro;
				global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering = null;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_6F;
					}
					global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager flashkeyManager;
					for (;;)
					{
						IL_3C:
						global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfiguration flashkeyConfiguration;
						global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
						string text;
						global::SpecialFeatures.Flashport.Recordset embeddedRecset;
						string text2;
						string text3;
						switch (num2)
						{
						case 0:
							goto IL_782;
						case 1:
							if (flashkeyManager.IsRefreshKey())
							{
								num = (short)1521942538;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6EF;
						case 2:
							if (flashkeyManager.FindFlashkey("", "", global::SpecialFeatures.Flashport.FlashkeyLib.FindType.FindAny))
							{
								num = (short)1570701320;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_782;
						case 3:
							if (flashkeyManager.IsModelUpgradeKey())
							{
								num = (short)202113029;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_30F;
						case 4:
							goto IL_2D0;
						case 5:
						{
							string fkeyConfigNewModelNumberValue;
							flashkeyConfiguration.General.FkeyConfigNewModelNumberValue = fkeyConfigNewModelNumberValue;
							num = (short)763101193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_79C;
						case 7:
							try
							{
								bool flag = false;
								bool flag2 = false;
								string fkeyConfigCurrentFlashcodeValueValue = global::CommonResources.AppResources.Disabled_Id;
								string fkeyConfigNewFlashcodeValueValue = global::CommonResources.AppResources.Disabled_Id;
								flashcodeTable.InitTable(false, text, false);
								global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator = flashcodeTable.FLASHcode.GetEnumerator();
								try
								{
									num = (short)1642332162;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											num = (short)181600264;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											flag = true;
											fkeyConfigCurrentFlashcodeValueValue = global::CommonResources.AppResources.Enabled_Id;
											num = (short)724041731;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_3D0;
											}
											continue;
										case 3:
											goto IL_439;
										case 4:
											if (flag || flag2)
											{
												num = (short)731512841;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										case 5:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)1224736768;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
											flag = false;
											flag2 = false;
											fkeyConfigCurrentFlashcodeValueValue = global::CommonResources.AppResources.Disabled_Id;
											fkeyConfigNewFlashcodeValueValue = global::CommonResources.AppResources.Disabled_Id;
											global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationFeaturesInner flashkeyConfigurationFeaturesInner = new global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationFeaturesInner(embeddedRecset);
											num = (short)811925514;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 6:
										{
											global::SpecialFeatures.Flashport.FlashRadio.Option option;
											if (flashcodeTable.IsOptionEnabledInFlashcode(option, text2))
											{
												num = (short)24313867;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_560;
										}
										case 8:
											goto IL_5B9;
										case 9:
										{
											global::SpecialFeatures.Flashport.FlashRadio.Option option;
											global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationFeaturesInner flashkeyConfigurationFeaturesInner;
											flashkeyConfigurationFeaturesInner.FlashkeyConfigurationFeaturesInnerSection.FkeyConfigFeatureNameValue = option.ToString();
											flashkeyConfigurationFeaturesInner.FlashkeyConfigurationFeaturesInnerSection.FkeyConfigCurrentFlashcodeValueValue = fkeyConfigCurrentFlashcodeValueValue;
											flashkeyConfigurationFeaturesInner.FlashkeyConfigurationFeaturesInnerSection.FkeyConfigNewFlashcodeValueValue = fkeyConfigNewFlashcodeValueValue;
											embeddedRecset.AddRecord(flashkeyConfigurationFeaturesInner);
											num = (short)1245904903;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 10:
										{
											global::SpecialFeatures.Flashport.FlashRadio.Option option;
											if (flashcodeTable.IsOptionEnabledInFlashcode(option, text3))
											{
												num = (short)1174994945;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_439;
										}
										case 11:
											flag2 = true;
											fkeyConfigNewFlashcodeValueValue = global::CommonResources.AppResources.Enabled_Id;
											num = (short)11927564;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 12:
											goto IL_560;
										}
										goto IL_3D0;
										IL_439:
										num = (short)1617231878;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_4CA:
										num = (short)763822085;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_3D0:
										goto IL_4CA;
										IL_560:
										num = (short)973144068;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_5B9:;
								}
								finally
								{
									for (;;)
									{
										IL_5BE:
										num = (short)1607794689;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_679;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_5F0;
												}
												continue;
											case 2:
											{
												num = (short)1776011153;
												short num3 = num;
												num = (short)1366542225;
												switch ((num3 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_5BE;
												default:
													num = (short)1010237440;
													if (num != 0)
													{
													}
													enumerator.Dispose();
													num = (short)908460032;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_5F0:
											if (enumerator == null)
											{
												goto IL_67B;
											}
											num = (short)914161666;
											num2 = (int)((global::System.IntPtr)num);
										}
									}
									IL_679:
									IL_67B:;
								}
								goto IL_2D0;
							}
							finally
							{
								num = (short)1806106625;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_6EC;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_6B3;
										}
										continue;
									case 2:
										((global::System.IDisposable)flashcodeTable).Dispose();
										num = (short)72220672;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_6B3:
									if (flashcodeTable == null)
									{
										break;
									}
									num = (short)1089470466;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_6EC:;
							}
							goto IL_6EF;
						case 8:
						{
							flashkeyManager.ValidateKey();
							string fkeyConfigFactoryOrderNumberValue = (string)flashkeyManager.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FactOrderNo);
							text3 = (string)flashkeyManager.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.Flashcode);
							text2 = (string)flashkeyManager.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FlashcodeNew);
							text = (string)flashkeyManager.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.ModelNumber);
							string fkeyConfigNewModelNumberValue = (string)flashkeyManager.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.ModelNumberNew);
							string text4 = (string)flashkeyManager.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.DateCode);
							string fkeyConfigUpgradesPurchasedValue = global::System.Convert.ToString((int)flashkeyManager.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.UpgradesPurchased), 10);
							string fkeyConfigUpgradesRemainingValue = global::System.Convert.ToString((int)flashkeyManager.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.UpgradesRemaining), 10);
							this.a = new global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationRecset();
							flashkeyConfiguration = new global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfiguration(this.a);
							flashkeyConfiguration.General.FkeyConfigNewModelNumberValue = global::CommonResources.AppResources.N_A;
							flashkeyConfiguration.General.FkeyConfigFactoryOrderNumberValue = fkeyConfigFactoryOrderNumberValue;
							char[] trimChars = new char[]
							{
								'\0',
								' ',
								'\r',
								'\n'
							};
							text = text.TrimEnd(trimChars);
							flashkeyConfiguration.General.FkeyConfigCurrentModelNumberValue = text;
							flashkeyConfiguration.General.FkeyConfigCurrentFlashcodeValue = text3;
							flashkeyConfiguration.General.FkeyConfigNewFlashcodeValue = text2;
							flashkeyConfiguration.General.FkeyConfigUpgradesRemainingValue = fkeyConfigUpgradesRemainingValue;
							flashkeyConfiguration.General.FkeyConfigUpgradesPurchasedValue = fkeyConfigUpgradesPurchasedValue;
							num = (short)571277313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_30F;
						case 10:
						{
							string fkeyConfigFactoryOrderNumberValue;
							flashkeyConfiguration.General.FkeyConfigFactoryOrderNumberValue = fkeyConfigFactoryOrderNumberValue;
							flashkeyConfiguration.General.FkeyConfigCurrentModelNumberValue = global::CommonResources.AppResources.REFRESH_KEY;
							flashkeyConfiguration.General.FkeyConfigCurrentFlashcodeValue = global::CommonResources.AppResources.N_A;
							flashkeyConfiguration.General.FkeyConfigNewFlashcodeValue = global::CommonResources.AppResources.N_A;
							string fkeyConfigUpgradesRemainingValue;
							flashkeyConfiguration.General.FkeyConfigUpgradesRemainingValue = fkeyConfigUpgradesRemainingValue;
							string fkeyConfigUpgradesPurchasedValue;
							flashkeyConfiguration.General.FkeyConfigUpgradesPurchasedValue = fkeyConfigUpgradesPurchasedValue;
							flashkeyConfiguration.FlashkeyConfigurationFeatures.IsVisible = false;
							num = (short)1938554884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_6F;
						IL_2D0:
						num = (short)1080098819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_30F:
						this.a.AddRecord(flashkeyConfiguration);
						global::SpecialFeatures.Flashport.FlashDataManager.AddFeature(this.a);
						result = true;
						num = (short)1556021248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6EF:
						flashkeyConfiguration.FlashkeyConfigurationFeatures.IsVisible = true;
						embeddedRecset = flashkeyConfiguration.FlashkeyConfigurationFeatures.EmbeddedRecset;
						embeddedRecset.AddRecord(new global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationFeaturesInner(embeddedRecset)
						{
							FlashkeyConfigurationFeaturesInnerSection = 
							{
								FkeyConfigFeatureNameValue = global::CommonResources.AppResources.FLASHcode_Id,
								FkeyConfigNewFlashcodeValueValue = text2,
								FkeyConfigCurrentFlashcodeValueValue = text3
							}
						});
						modelTiering = new global::SpecialFeatures.Model_Configuration.ModelTiering(text, "");
						modelTiering.UpdateUtilityMackModelType();
						flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable(true);
						num = (short)2093613063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_782:
						num = (short)676593670;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_79C:
					goto IL_88C;
					IL_6F:
					flashkeyManager = new global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager();
					num = (short)680656898;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_3C;
				}
				catch (global::System.Exception ex)
				{
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, ex.Message);
				}
				finally
				{
					num = (short)122421249;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_828;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_7F1;
							}
							continue;
						case 2:
							goto IL_889;
						case 3:
							modelTiering.RestoreUtilityMackIfErrorOccurs(isMobilePro);
							num = (short)911736832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_7F1:
						if (modelTiering != null)
						{
							num = (short)1827930115;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							modelTiering = new global::SpecialFeatures.Model_Configuration.ModelTiering(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캅놇붉\ud88b즍풏ꮑ쒓솕ꦗ\udb99튛", a_), "");
							modelTiering.RestoreUtilityMackIfErrorOccurs(isMobilePro);
							num = (short)141426690;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_828:
					num = (short)691404801;
					if (num != 0)
					{
					}
					IL_889:;
				}
				IL_88C:
				num = (short)1823801344;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x0014D3CC File Offset: 0x0014B5CC
		public global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationRecset FlashkeyRecset
		{
			get
			{
				short num = (short)2020653556;
				short num2 = num;
				num = (short)1986050548;
				switch (num2 == num)
				{
				}
				num = (short)144572417;
				if (num != 0)
				{
				}
				num = (short)1810038784;
				short num3 = num;
				num = (short)1815216128;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0014D480 File Offset: 0x0014B680
		public void Dispose()
		{
			short num;
			while (this.b)
			{
				num = (short)782089331;
				short num2 = num;
				num = (short)3456115;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)551354369;
					if (num != 0)
					{
					}
					num = (short)1631977472;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)1400373248;
			short num3 = num;
			this.Dispose(true);
			this.b = true;
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0014D548 File Offset: 0x0014B748
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)927187016;
			short num2 = num;
			num = (short)627163208;
			switch (num2 == num)
			{
			}
			num = (short)29425665;
			if (num != 0)
			{
			}
			num = (short)1214775296;
			short num3 = num;
			num = (short)1574305792;
			if (num != 0)
			{
			}
		}

		// Token: 0x040007CC RID: 1996
		private global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationRecset a;

		// Token: 0x040007CD RID: 1997
		private bool b;
	}
}
