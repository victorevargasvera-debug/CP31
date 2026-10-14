using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpUtility;
using CommonResources;
using ConstraintHelper;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.SystemCertificates.List
{
	// Token: 0x020001AA RID: 426
	internal class SystemCertificateConstraints
	{
		// Token: 0x06001406 RID: 5126 RVA: 0x001D0220 File Offset: 0x001CE420
		internal static void conSetSystemCertificateFieldsValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1086652416;
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
				global::SpecialFeatures.SystemCertificates.List.SystemCertificateGeneralSection systemCertificateGeneralSection;
				for (;;)
				{
					IL_27:
					string secSysCertGeneralCertificateFilename_A43634Value;
					switch (num2)
					{
					case 0:
						goto IL_1BB;
					case 1:
						if (global::AcpCommonLib.AppInfoManager.LoadingVoiceData)
						{
							num = (short)129761280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_251;
					case 2:
					{
						num = (short)1230252605;
						short num3 = num;
						num = (short)1223699005;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)100204544;
							if (num != 0)
							{
							}
							num = (short)1112276993;
							if (num != 0)
							{
							}
							try
							{
								switch (0)
								{
								case 0:
									goto IL_98;
								}
								for (;;)
								{
									IL_85:
									switch (num2)
									{
									case 0:
										try
										{
											global::System.IO.File.Delete(secSysCertGeneralCertificateFilename_A43634Value);
										}
										catch (global::System.Exception)
										{
										}
										goto IL_173;
									case 1:
										if (global::ConstraintHelper.UtilityMack.bOpenFromRMC)
										{
											num = (short)626458624;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_173;
									case 2:
										goto IL_18D;
									}
									goto IL_98;
									IL_173:
									num = (short)121307138;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_18D:
								goto IL_251;
								IL_98:
								global::System.IO.FileStream fileStream = new global::System.IO.FileStream(secSysCertGeneralCertificateFilename_A43634Value, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
								byte[] array = new byte[fileStream.Length];
								fileStream.Read(array, 0, (int)fileStream.Length);
								global::AcpBusinessLayer.AcpVoiceFileStruct newValue = new global::AcpBusinessLayer.AcpVoiceFileStruct(secSysCertGeneralCertificateFilename_A43634Value);
								newValue.voicefile = secSysCertGeneralCertificateFilename_A43634Value;
								newValue.voiceData = new global::System.IO.MemoryStream(array, 0, array.Length, true, true);
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<global::AcpBusinessLayer.AcpVoiceFileStruct>(systemCertificateGeneralSection.SecSysCertGeneralCertificateFileData_A43635, newValue));
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(systemCertificateGeneralSection.SecSysCertGeneralCertificateFilename_A43634Object, global::System.IO.Path.GetFileName(secSysCertGeneralCertificateFilename_A43634Value)));
								systemCertificateGeneralSection.SecSysCertGeneralCertificateFilename_A43634Object.SetValue(global::System.IO.Path.GetFileName(secSysCertGeneralCertificateFilename_A43634Value));
								systemCertificateGeneralSection.Parent.Parent.CalculateValidity();
								num = (short)1658126337;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_85;
							}
							catch (global::System.Exception)
							{
								string message = global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
								{
									secSysCertGeneralCertificateFilename_A43634Value
								});
								global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, message);
								goto IL_251;
							}
							goto IL_1BB;
						}
						break;
					}
					}
					goto IL_3A;
					IL_1BB:
					secSysCertGeneralCertificateFilename_A43634Value = systemCertificateGeneralSection.SecSysCertGeneralCertificateFilename_A43634Value;
					num = (short)1809842178;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_251:
				num = (short)282329088;
				short num4 = num;
				return;
				IL_3A:
				systemCertificateGeneralSection = (self as global::SpecialFeatures.SystemCertificates.List.SystemCertificateGeneralSection);
				num = (short)1542914049;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x001D04DC File Offset: 0x001CE6DC
		internal static bool conSetSystemCertificateFieldValidation(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1163001856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_88;
				}
				string secSysCertGeneralCertificateFilename_A43634Value;
				for (;;)
				{
					IL_28:
					num = (short)1403342026;
					short num3 = num;
					num = (short)342707402;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_485;
					default:
						num = (short)1744830464;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_D5;
						case 1:
							if (string.IsNullOrEmpty(secSysCertGeneralCertificateFilename_A43634Value))
							{
								num = (short)427556864;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1188560898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_485;
						}
						goto IL_88;
					}
				}
				IL_D5:
				IL_414:
				num = (short)677380096;
				short num4 = num;
				return false;
				IL_485:
				global::SpecialFeatures.SystemCertificates.List.SystemCertificateGeneralSection systemCertificateGeneralSection;
				bool result;
				try
				{
					result = global::SpecialFeatures.SystemCertificates.List.SystemCertificateConstraints.ValidateCertificateDataIntegrity(systemCertificateGeneralSection.SecSysCertGeneralCertificateFileData_A43635Value.voiceData);
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(4228) as global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet).GetEnumerator();
					try
					{
						num = (short)1385168896;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_13E;
								}
								continue;
							case 1:
								goto IL_39D;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1136394244;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = (enumerator.Current as global::SpecialFeatures.SystemCertificates.List.SystemCertificateList).FeatureSectionsCollection.GetEnumerator();
								num = (short)944701443;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								try
								{
									num = (short)1379401729;
									num2 = (int)((global::System.IntPtr)num);
									bool result2;
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											global::SpecialFeatures.SystemCertificates.List.SystemCertificateGeneralSection systemCertificateGeneralSection2;
											if (secSysCertGeneralCertificateFilename_A43634Value == systemCertificateGeneralSection2.SecSysCertGeneralCertificateFilename_A43634Value)
											{
												num = (short)1804206083;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 1:
											switch (0)
											{
											case 0:
												goto IL_1F7;
											}
											continue;
										case 2:
											num = (short)1150484480;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											result2 = false;
											num = (short)714276868;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											goto IL_2B6;
										case 5:
											num = (short)442040326;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
											goto IL_311;
										case 7:
										{
											global::SpecialFeatures.SystemCertificates.List.SystemCertificateGeneralSection systemCertificateGeneralSection2;
											if (systemCertificateGeneralSection2.SecSysCertGeneralKeyofSystemCertificates_A43633Value != systemCertificateGeneralSection.SecSysCertGeneralKeyofSystemCertificates_A43633Value)
											{
												num = (short)691273730;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 8:
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)1024196613;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::SpecialFeatures.SystemCertificates.List.SystemCertificateGeneralSection systemCertificateGeneralSection2 = ((global::AcpBusinessLayer.FeatureSection)enumerator2.Current) as global::SpecialFeatures.SystemCertificates.List.SystemCertificateGeneralSection;
											num = (short)559415303;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_2BB:
										num = (short)951451656;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_1F7:
										goto IL_2BB;
									}
									IL_2B6:
									return result2;
									IL_311:
									break;
								}
								finally
								{
									num = (short)161611777;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
										switch (num2)
										{
										case 0:
											enumerator2.Dispose();
											num = (short)1680343042;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_349;
											}
											continue;
										case 2:
											goto IL_382;
										}
										IL_349:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)529989632;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_382:;
								}
								goto IL_385;
							case 4:
								goto IL_385;
							}
							IL_170:
							num = (short)327811074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_13E:
							goto IL_170;
							IL_385:
							num = (short)2036531201;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_39D:;
					}
					finally
					{
						num = (short)516227073;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)600965122;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_3D1;
								}
								continue;
							case 2:
								goto IL_409;
							}
							IL_3D1:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1077018624;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_409:;
					}
					goto IL_440;
				}
				catch
				{
					return false;
				}
				goto IL_414;
				IL_440:
				num = (short)951189505;
				if (num != 0)
				{
				}
				return result;
				IL_88:
				result = false;
				systemCertificateGeneralSection = (self as global::SpecialFeatures.SystemCertificates.List.SystemCertificateGeneralSection);
				secSysCertGeneralCertificateFilename_A43634Value = systemCertificateGeneralSection.SecSysCertGeneralCertificateFilename_A43634Value;
				num = (short)510066689;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x001D09C4 File Offset: 0x001CEBC4
		public static bool ValidateCertificateDataIntegrity(global::System.IO.MemoryStream fStream)
		{
			int a_ = 14;
			short num = (short)1174994944;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 1:
					num = (short)1939996676;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_6B;
				case 3:
					return false;
				case 4:
				{
					num = (short)957743105;
					if (num != 0)
					{
					}
					string text;
					if (!text.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풐\udd92톔랖\uda98\ude9a쾜쮞ﾪ", a_)))
					{
						num = (short)1901527043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BE;
				}
				case 5:
				{
					string text;
					if (text.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펐횒튔\ude96힘뮚\ude9c\uda9eﮮ", a_)))
					{
						num = (short)788987905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				}
				IL_45:
				if (fStream.Length > 10000L)
				{
					num = (short)782434306;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.IO.TextReader textReader = new global::System.IO.StreamReader(fStream);
					fStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
					string text = textReader.ReadToEnd();
					num = (short)537520335;
					short num3 = num;
					num = (short)969205967;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6B;
					default:
						num = (short)1618935808;
						if (num != 0)
						{
						}
						num = (short)177012741;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_6B:
			num = (short)1521942528;
			short num4 = num;
			return false;
			IL_1BE:
			new global::System.Security.Cryptography.X509Certificates.X509Certificate2().Import(fStream.ToArray());
			return true;
		}
	}
}
