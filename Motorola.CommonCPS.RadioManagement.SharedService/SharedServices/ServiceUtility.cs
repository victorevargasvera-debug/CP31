using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using ASK.Interface;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000BC RID: 188
	public static class ServiceUtility
	{
		// Token: 0x06000AD5 RID: 2773 RVA: 0x0008347C File Offset: 0x0008167C
		public static bool FileExist(global::System.Guid? fileUuid)
		{
			short num = (short)1016397824;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 1:
				{
					num = (short)748849851;
					short num3 = num;
					num = (short)1335462587;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_124;
					default:
						goto IL_8C;
					}
					break;
				}
				case 2:
					num = (short)423428097;
					if (num != 0)
					{
					}
					if (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetFile(fileUuid.Value) == null)
					{
						goto IL_124;
					}
					return true;
				case 3:
					return false;
				}
				IL_35:
				if (fileUuid == null)
				{
					num = (short)1693581313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)414842882;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_124:
				num = (short)1610350595;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8C:
			num = (short)404881408;
			short num4 = num;
			num = (short)1076559872;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x000835CC File Offset: 0x000817CC
		public static bool FwSubFilesExist(global::System.Collections.Generic.ICollection<global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareSub> pcrFwSubs)
		{
			short num = (short)387121153;
			if (num != 0)
			{
			}
			num = (short)117768192;
			short num2 = num;
			num = (short)527762037;
			short num3 = num;
			num = (short)462422645;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)633470976;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareSub> enumerator = pcrFwSubs.GetEnumerator();
				bool result;
				try
				{
					num = (short)1594753025;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)1575092226;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1407516676;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_E4;
							}
							continue;
						case 2:
							num = (short)436142086;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							result = false;
							num = (short)1283784709;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.FileExist(enumerator.Current.FileUuid))
							{
								num = (short)791150595;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 5:
							goto IL_174;
						case 6:
							goto IL_191;
						}
						IL_E6:
						num = (short)967311360;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_E4:
						goto IL_E6;
					}
					IL_174:
					return result;
					IL_191:
					break;
				}
				finally
				{
					num = (short)446103552;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1C8;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1759576066;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1FC;
						}
						IL_1C8:
						if (enumerator == null)
						{
							break;
						}
						num = (short)240779265;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1FC:;
				}
				return result;
			}
			}
			return true;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x000837EC File Offset: 0x000819EC
		public static string GetFileBaseName(string filePath, int cutLength)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (text.Length > cutLength)
					{
						num2 = (short)299171841;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_ED;
				case 1:
				{
					num2 = (short)157823297;
					short num3 = num2;
					num2 = (short)1105867073;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)549388288;
						short num4 = num2;
						num2 = (short)456523776;
						if (num2 != 0)
						{
						}
						text = text.Substring(0, cutLength);
						num2 = (short)1060306946;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					goto IL_EB;
				}
				goto IL_1C;
			}
			IL_EB:
			IL_ED:
			num2 = (short)1704460289;
			if (num2 != 0)
			{
			}
			return text;
			IL_1C:
			text = global::System.IO.Path.GetFileNameWithoutExtension(filePath);
			num2 = (short)831520768;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00083914 File Offset: 0x00081B14
		public static T[] XMLToEntityCollections<T>(string xmlData)
		{
			short num = (short)740032512;
			switch (num)
			{
			default:
				if (!string.IsNullOrWhiteSpace(xmlData))
				{
					num = (short)1278607360;
					short num2 = num;
					T[] result;
					try
					{
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::System.Text.Encoding.UTF8.GetBytes(xmlData));
						try
						{
							memoryStream.Flush();
							memoryStream.Position = 0L;
							global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T[]));
							global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
							xmlDocument.Load(memoryStream);
							global::System.Xml.XmlNodeReader xmlNodeReader = new global::System.Xml.XmlNodeReader(xmlDocument.DocumentElement);
							try
							{
								result = (xmlSerializer.Deserialize(xmlNodeReader) as T[]);
							}
							finally
							{
								num = (short)417458226;
								short num3 = num;
								num = (short)1999038514;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
								{
									num = (short)1051852800;
									if (num != 0)
									{
									}
									num = (short)1867448321;
									int num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num4)
										{
										case 0:
											((global::System.IDisposable)xmlNodeReader).Dispose();
											num = (short)2131755009;
											if (num != 0)
											{
											}
											num = (short)180158466;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_130;
											}
											continue;
										case 2:
											goto IL_18F;
										}
										IL_130:
										if (xmlNodeReader == null)
										{
											break;
										}
										num = (short)963182592;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_18F:
									break;
								}
								}
							}
						}
						finally
						{
							num = (short)198967297;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)255197186;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1C6;
									}
									continue;
								case 2:
									goto IL_1FC;
								}
								IL_1C6:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)60948480;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_1FC:;
						}
					}
					catch (global::System.Exception ex)
					{
						throw new global::System.Exception(global::Motorola.CommonCPS.ResourceRepository.Resources.XMLDeSerialize_Error + ex.Message);
					}
					return result;
				}
				return null;
			}
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00083B88 File Offset: 0x00081D88
		public static string EntityCollectionsToXML<T>(T[] obj)
		{
			short num = (short)1451687936;
			switch (num)
			{
			default:
			{
				string result = null;
				try
				{
					num = (short)75168797;
					short num2 = num;
					num = (short)177994781;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1642856448;
						if (num != 0)
						{
						}
						global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T[]));
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
						try
						{
							global::System.Xml.Serialization.XmlSerializerNamespaces xmlSerializerNamespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
							xmlSerializerNamespaces.Add("", "");
							xmlSerializer.Serialize(memoryStream, obj, xmlSerializerNamespaces);
							result = global::System.Text.Encoding.UTF8.GetString(memoryStream.ToArray());
							memoryStream.Close();
						}
						finally
						{
							num = (short)197066753;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)1373175810;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_EF;
									}
									continue;
								case 2:
									goto IL_125;
								}
								IL_EF:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)1484783616;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_125:;
						}
						break;
					}
					}
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(global::Motorola.CommonCPS.ResourceRepository.Resources.XMLSerialize_Error + ex.Message);
				}
				num = (short)53739521;
				if (num != 0)
				{
				}
				num = (short)2061697024;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00083D60 File Offset: 0x00081F60
		public static global::ASK.Interface.ProtectionOption GetProtectionOption(string modelNumber, string flashCode, bool fromCodeplug)
		{
			int a_ = 3;
			short num = (short)912195584;
			short num2 = num;
			num = (short)1862972984;
			short num3 = num;
			num = (short)1375581752;
			bool flag;
			bool flag2;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F5:
				flag = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroCheckHoptionEnable(flashCode, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쮙\udd9b꺝醟钡那麥", a_), modelNumber);
				flag2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroCheckHoptionEnable(flashCode, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쮙\udd9b꺝醟閡那龥", a_), modelNumber);
				num = (short)1809121292;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)469958656;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_C2;
				}
				break;
			}
			global::ASK.Interface.ProtectionOption result;
			for (;;)
			{
				IL_88:
				switch (num4)
				{
				case 0:
					result = global::ASK.Interface.ProtectionOption.LEGACY_SW;
					num = (short)824180744;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1270415366;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_F5;
				case 3:
					if (modelNumber != null)
					{
						num = (short)1166344194;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
					num = (short)826146826;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					result = global::ASK.Interface.ProtectionOption.HARDWARE;
					num = (short)634191881;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (!flag2)
					{
						num = (short)151846917;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_134;
				case 7:
					return result;
				case 8:
					return result;
				case 9:
					return result;
				case 10:
					if (!flag)
					{
						num = (short)610664448;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CB;
				case 11:
					if (flag2)
					{
						num = (short)906297348;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CB;
				case 12:
					if (flag)
					{
						num = (short)181927937;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_134;
				}
				goto IL_C2;
				IL_134:
				num = (short)924712961;
				if (num != 0)
				{
				}
				num = (short)858718219;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_1CB:
				result = global::ASK.Interface.ProtectionOption.UNSPECIFIED;
				num = (short)2064187399;
				num4 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_C2:
			result = global::ASK.Interface.ProtectionOption.UNSPECIFIED;
			num = (short)999686147;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_88;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00084000 File Offset: 0x00082200
		public static global::Motorola.Common.Communication.CommonUtil.ProductFamily ConvertProduectFamily(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily family)
		{
			short num = (short)1177092096;
			short num2 = num;
			num = (short)1043464199;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					if (family == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MatrixRepeater)
					{
						num = (short)2069954564;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1775894538;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (family == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller)
					{
						num = (short)1294073873;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.None;
				case 2:
					if (family == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS)
					{
						num = (short)213581844;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1322385427;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (family == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Paradise)
					{
						goto IL_1E2;
					}
					num = (short)1318846477;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRepeaterRadio;
				case 5:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseLightRadio;
				case 6:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_A5;
					}
					continue;
				case 8:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.VRC;
				case 9:
					if (family == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
					{
						num = (short)732758022;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1324810255;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (family == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseRepeater)
					{
						num = (short)2022047745;
						if (num != 0)
						{
						}
						num = (short)1102774288;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)63176706;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.PhoenixRadio;
				case 12:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
				case 13:
					if (family == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseLight)
					{
						num = (short)1234829317;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)376569874;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio;
				case 15:
					if (family == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Matrix)
					{
						num = (short)2010710037;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)415039491;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio;
				case 17:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.DMR3Controller;
				case 18:
					if (family == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Phoenix)
					{
						num = (short)562233355;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)228327424;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (family == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC)
					{
						num = (short)1536622600;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)900923393;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.MNIS;
				case 21:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRadio;
				}
				IL_A5:
				if (family == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX)
				{
					num = (short)1292566540;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2131818625;
				short num4 = num;
				num = (short)295434369;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1596129280;
					if (num != 0)
					{
					}
					num = (short)76677129;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1E2:
				num = (short)1517813774;
				num3 = (int)((global::System.IntPtr)num);
			}
			return global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x000843CC File Offset: 0x000825CC
		public static bool HasMVO(global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			short num = (short)1283370009;
			short num2 = num;
			num = (short)764953;
			switch (num2 == num)
			{
			}
			num = (short)1108672512;
			short num3 = num;
			num = (short)276037633;
			if (num != 0)
			{
			}
			num = (short)2093350912;
			if (num != 0)
			{
			}
			return !string.IsNullOrEmpty(radio.ModelNumber);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00084484 File Offset: 0x00082684
		public static global::System.Collections.Generic.List<string> ListVaFiles()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			string cpsVaImportPath;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)127458122;
					short num3 = num2;
					num2 = (short)319675210;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_BD;
					}
					break;
				}
				case 1:
					goto IL_118;
				case 2:
					if (!global::System.IO.Directory.Exists(cpsVaImportPath))
					{
						num2 = (short)1850081280;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1640431617;
					if (num2 != 0)
					{
					}
					num2 = (short)1869348865;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_BD:
			num2 = (short)627376128;
			if (num2 != 0)
			{
			}
			return new global::System.Collections.Generic.List<string>();
			IL_118:
			return global::System.IO.Directory.EnumerateFiles(cpsVaImportPath).Where(delegate(string file)
			{
				int a_ = 2;
				short num5 = (short)856096768;
				short num6 = num5;
				num5 = (short)1258889520;
				short num7 = num5;
				num5 = (short)979575088;
				switch (num7 == num5)
				{
				}
				num5 = (short)1294794752;
				if (num5 != 0)
				{
				}
				num5 = (short)2073493505;
				if (num5 != 0)
				{
				}
				return global::System.IO.Path.GetExtension(file).Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("래ﺞ", a_), global::System.StringComparison.OrdinalIgnoreCase);
			}).ToList<string>();
			IL_1C:
			cpsVaImportPath = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.GetCpsVaImportPath();
			num2 = (short)163905536;
			short num4 = num2;
			num2 = (short)550895618;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x000845DC File Offset: 0x000827DC
		public static global::System.Collections.Generic.List<string> ListTtsFiles()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			string ttsinstallationPath;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1769501138;
					short num3 = num2;
					num2 = (short)31158738;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_C3;
					}
					break;
				}
				case 1:
					goto IL_11D;
				case 2:
					if (!global::System.IO.Directory.Exists(ttsinstallationPath))
					{
						num2 = (short)1471479808;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)390266881;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_C3:
			num2 = (short)840564737;
			if (num2 != 0)
			{
			}
			num2 = (short)1686044672;
			if (num2 != 0)
			{
			}
			return new global::System.Collections.Generic.List<string>();
			IL_11D:
			return global::System.IO.Directory.EnumerateFiles(ttsinstallationPath).Where(delegate(string file)
			{
				int a_ = 9;
				short num5 = (short)62783488;
				short num6 = num5;
				num5 = (short)1885470721;
				if (num5 != 0)
				{
				}
				num5 = (short)1841030000;
				short num7 = num5;
				num5 = (short)319808368;
				switch (num7 == num5)
				{
				}
				num5 = (short)1378680832;
				if (num5 != 0)
				{
				}
				return global::System.IO.Path.GetExtension(file).Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("躟횡킣향\ud8a7쮩쾫얭", a_), global::System.StringComparison.OrdinalIgnoreCase);
			}).ToList<string>();
			IL_1C:
			ttsinstallationPath = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.GetTTSInstallationPath();
			num2 = (short)471990272;
			short num4 = num2;
			num2 = (short)1508966402;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0008473C File Offset: 0x0008293C
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceUtility()
		{
			short num = (short)317203536;
			short num2 = num;
			num = (short)953885776;
			switch (num2 == num)
			{
			}
			num = (short)1659043840;
			short num3 = num;
			num = (short)2147024897;
			if (num != 0)
			{
			}
			num = (short)135856128;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.a = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.QueryGroup>();
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.b = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.QuerySummary>();
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.c = new global::System.Collections.Generic.Dictionary<global::System.Guid?, global::Motorola.CommonCPS.Server.EntityModel.QuerySummary>();
		}

		// Token: 0x040001AA RID: 426
		private static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.QueryGroup> a;

		// Token: 0x040001AB RID: 427
		private static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.QuerySummary> b;

		// Token: 0x040001AC RID: 428
		private static global::System.Collections.Generic.Dictionary<global::System.Guid?, global::Motorola.CommonCPS.Server.EntityModel.QuerySummary> c;

		// Token: 0x020000BD RID: 189
		[global::System.Serializable]
		public class AstroDataProfTrunkingGroupgIDs
		{
			// Token: 0x06000AE0 RID: 2784 RVA: 0x00084804 File Offset: 0x00082A04
			public AstroDataProfTrunkingGroupgIDs(string xmlData)
			{
				int a_ = 6;
				base..ctor();
				if (!string.IsNullOrWhiteSpace(xmlData))
				{
					try
					{
						using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::System.Text.Encoding.UTF8.GetBytes(xmlData)))
						{
							memoryStream.Flush();
							memoryStream.Position = 0L;
							global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
							xmlDocument.Load(memoryStream);
							using (global::System.Xml.XmlNodeReader xmlNodeReader = new global::System.Xml.XmlNodeReader(xmlDocument.DocumentElement))
							{
								global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.AstroDataProfTrunkingGroupgIDs astroDataProfTrunkingGroupgIDs = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.AstroDataProfTrunkingGroupgIDs)new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.AstroDataProfTrunkingGroupgIDs)).Deserialize(xmlNodeReader);
								this.Version = astroDataProfTrunkingGroupgIDs.Version;
								this.Recset = astroDataProfTrunkingGroupgIDs.Recset;
							}
						}
					}
					catch (global::System.Exception ex)
					{
						throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udc9c햠톢쪤좨\udfaa첬ﾮ쎰\udcb2펴쮸캺펼풾ꣀ귂ꋄ胆믈꓊료뿎뛐髒釔ꓖ律룚닜꫞跠蟢엤触蛨鿪췬跮铰폲釴鋶諸黺迼雾怀漂氄紆氈漊ⴌ椎挐簒研㜖䄘嘚儜㼞䔠䈢儤䘦ጨପ", a_) + ex.Message);
					}
				}
				else
				{
					this.Version = 1;
					this.Recset = new global::System.Collections.ObjectModel.Collection<global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.Astro25DataGroupID>();
				}
			}

			// Token: 0x06000AE1 RID: 2785 RVA: 0x0008491C File Offset: 0x00082B1C
			internal AstroDataProfTrunkingGroupgIDs()
			{
				this.Version = 1;
				this.Recset = new global::System.Collections.ObjectModel.Collection<global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.Astro25DataGroupID>();
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00084944 File Offset: 0x00082B44
			// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x000849F4 File Offset: 0x00082BF4
			public int Version
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)1674379265;
					if (num != 0)
					{
					}
					num = (short)79000641;
					short num2 = num;
					num = (short)442790977;
					switch (num2 == num)
					{
					default:
					{
						num = (short)1504116736;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)1861746688;
					if (num != 0)
					{
					}
					return this.<Version>k__BackingField;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
					short num = (short)1551296087;
					short num2 = num;
					num = (short)660465239;
					switch (num2 == num)
					{
					}
					num = (short)1238171648;
					short num3 = num;
					num = (short)1995702273;
					if (num != 0)
					{
					}
					num = (short)728956928;
					if (num != 0)
					{
					}
					this.<Version>k__BackingField = value;
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x00084AA4 File Offset: 0x00082CA4
			// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x00084B54 File Offset: 0x00082D54
			public global::System.Collections.ObjectModel.Collection<global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.Astro25DataGroupID> Recset
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)5308417;
					if (num != 0)
					{
					}
					num = (short)1200064095;
					short num2 = num;
					num = (short)1075873375;
					switch (num2 == num)
					{
					default:
					{
						num = (short)1195114496;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)2058878976;
					if (num != 0)
					{
					}
					return this.<Recset>k__BackingField;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
					short num = (short)212721764;
					short num2 = num;
					num = (short)1792860260;
					switch (num2 == num)
					{
					}
					num = (short)1648689152;
					short num3 = num;
					num = (short)1988952064;
					if (num != 0)
					{
					}
					num = (short)1125842945;
					if (num != 0)
					{
					}
					this.<Recset>k__BackingField = value;
				}
			}

			// Token: 0x06000AE6 RID: 2790 RVA: 0x00084C04 File Offset: 0x00082E04
			internal string ToXML()
			{
				int a_ = 8;
				short num = (short)1127219200;
				switch (num)
				{
				default:
				{
					num = (short)1614872576;
					short num2 = num;
					string result = null;
					goto IL_54;
					try
					{
						for (;;)
						{
							IL_54:
							global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
							try
							{
								global::System.Xml.Serialization.XmlSerializerNamespaces xmlSerializerNamespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
								xmlSerializerNamespaces.Add("", "");
								new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.AstroDataProfTrunkingGroupgIDs)).Serialize(memoryStream, this, xmlSerializerNamespaces);
								result = global::System.Text.Encoding.UTF8.GetString(memoryStream.ToArray());
								memoryStream.Close();
							}
							finally
							{
								num = (short)1359413250;
								int num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										((global::System.IDisposable)memoryStream).Dispose();
										num = (short)1307770881;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_10B;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_D6;
										}
										continue;
									}
									IL_D6:
									if (memoryStream == null)
									{
										break;
									}
									num = (short)421658624;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_10B:;
							}
							num = (short)1666536035;
							short num4 = num;
							num = (short)1805734499;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_144;
							}
						}
						IL_144:
						num = (short)493944832;
						if (num != 0)
						{
						}
					}
					catch (global::System.Exception ex)
					{
						throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ude9e튠힢힤좦쪪\ud9ac캮솲\udab4톶즺좼톾ꫀꫂꯄꃆ軈맊ꋌ뫎ꇐ듒鳔鏖꫘ﯚ뻜냞铠迢臤쟦蟨蓪駬쿮鏰雲헴蓶鳸觺铼黾洀樂缄戆洈ㄊⴌ", a_) + ex.Message);
					}
					num = (short)592904193;
					if (num != 0)
					{
					}
					return result;
				}
				}
			}
		}

		// Token: 0x020000BE RID: 190
		[global::System.Xml.Serialization.XmlType("Node")]
		[global::System.Serializable]
		public class Astro25DataGroupID
		{
			// Token: 0x17000120 RID: 288
			// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00084DEC File Offset: 0x00082FEC
			// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x00084E98 File Offset: 0x00083098
			[global::System.Xml.Serialization.XmlAttribute]
			public int DataGroupID
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)590007441;
					short num2 = num;
					num = (short)431934609;
					switch (num2 == num)
					{
					}
					num = (short)1318715392;
					short num3 = num;
					num = (short)881917953;
					if (num != 0)
					{
					}
					num = (short)684457984;
					if (num != 0)
					{
					}
					return this.<DataGroupID>k__BackingField;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
					short num = (short)363031460;
					short num2 = num;
					num = (short)1272802212;
					switch (num2 == num)
					{
					}
					num = (short)1849819136;
					short num3 = num;
					num = (short)405602305;
					if (num != 0)
					{
					}
					num = (short)1832452096;
					if (num != 0)
					{
					}
					this.<DataGroupID>k__BackingField = value;
				}
			}
		}
	}
}
