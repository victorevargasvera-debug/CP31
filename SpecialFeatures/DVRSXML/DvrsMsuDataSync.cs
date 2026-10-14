using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
using Motorola.MackinawCPS.CoreFeatures.DVRSProfiles;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DVRSXML
{
	// Token: 0x02000121 RID: 289
	public class DvrsMsuDataSync
	{
		// Token: 0x06000F60 RID: 3936 RVA: 0x00153BE8 File Offset: 0x00151DE8
		public uint CalculateHashCode()
		{
			int a_ = 15;
			short num = (short)1362296832;
			switch (num)
			{
			default:
			{
				num = (short)581632001;
				if (num != 0)
				{
				}
				uint result = 0U;
				try
				{
					this.b = new global::System.Xml.XmlDocument();
					this.b.AppendChild(this.b.CreateXmlDeclaration(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎑ몓ꚕ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("작삓킕떗ꊙ", a_), null));
					global::SpecialFeatures.DVRSXML.DvrsElementItem a_2 = this.BuildDvrsExportData();
					global::System.Xml.XmlElement newChild = this.a(this.b, a_2);
					this.b.AppendChild(newChild);
					global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter();
					try
					{
						global::System.Xml.XmlTextWriter xmlTextWriter = new global::System.Xml.XmlTextWriter(stringWriter);
						try
						{
							this.b.WriteTo(xmlTextWriter);
							result = global::SpecialFeatures.DVRSXML.CRC32.CalculateHashCode(stringWriter.ToString());
							this.b.SelectSingleNode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붑뮓\ud895ﺙ鍊놝잡잣튥솧얩슫膭\udbb1톳\udab5\udcb7ﲻꆿ꿁ꇃ﯅軉髋鳍菏鋓뿕뷗뛙룛ﻝ꣟菡韣軥쿧럩", a_)).InnerText = result.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪑겓", a_));
						}
						finally
						{
							num = (short)1550909441;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)xmlTextWriter).Dispose();
									num = (short)157286402;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_145;
									}
									continue;
								case 2:
									goto IL_17D;
								}
								IL_145:
								if (xmlTextWriter == null)
								{
									break;
								}
								num = (short)764018688;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_17D:;
						}
						this.b.SelectSingleNode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붑뮓\uda95聯ﮛ솟얡솣", a_)).InnerText = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("望", a_);
						global::System.Xml.XmlNode xmlNode = this.b.SelectSingleNode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붑뮓킕ﾙ瞧ﮟ장얧쾩醫覭ﲯ펱잳습햹\ud8bbힽꚿꯁꇃꋅ資ꯉ룋ꯍ蓏믑맓돕ￗ蟙", a_));
						global::System.Globalization.CultureInfo provider = new global::System.Globalization.CultureInfo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("望", a_));
						xmlNode.InnerText = global::System.DateTime.Now.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf91\ud993뮕ﲗﺙ놛\ud99f\udba1\udda3蚥삧슩隫쎭\uddaf銱삳습", a_), provider);
					}
					finally
					{
						num = (short)605290497;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((global::System.IDisposable)stringWriter).Dispose();
								num = (short)2000224258;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_234;
								}
								continue;
							case 2:
								goto IL_26C;
							}
							IL_234:
							if (stringWriter != null)
							{
								num = (short)1391525888;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_26C:
							num = (short)359960458;
							short num3 = num;
							num = (short)1569820554;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_2A1;
							}
						}
						IL_2A1:
						num = (short)903872512;
						if (num != 0)
						{
						}
					}
					this.c = true;
				}
				catch (global::System.Exception)
				{
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, global::CommonResources.AppResources.Export_DVRS_MSU_Data_Failed_Unable_To_Calculate_Hash_Code);
				}
				num = (short)289538048;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00153F40 File Offset: 0x00152140
		public string BuildFileName(string radioSerialNumber = null)
		{
			int a_ = 6;
			short num = (short)1097138176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				string text;
				string result;
				string text2;
				for (;;)
				{
					IL_30:
					int num3;
					switch (num2)
					{
					case 0:
					{
						char[] array;
						if (num3 >= array.Length)
						{
							num = (short)1925054465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						char value = array[num3];
						num = (short)837615620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)201129999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						text = radioInformation.General.RadInfoGeneralSerialNumber_A9122Value;
						num = (short)398655494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_105;
					case 4:
						goto IL_146;
					case 5:
						return result;
					case 6:
						goto IL_335;
					case 7:
						goto IL_146;
					case 8:
						goto IL_335;
					case 9:
						goto IL_105;
					case 10:
						return result;
					case 11:
					{
						if (radioSerialNumber == null)
						{
							num = (short)1532755970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)693706826;
						short num4 = num;
						num = (short)1272586314;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4CD;
						default:
							num = (short)1879310336;
							if (num != 0)
							{
							}
							text = radioSerialNumber;
							num = (short)1372848136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						goto IL_4CD;
					case 13:
						if (radioInformation == null)
						{
							num = (short)1625423891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1176305675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						if (string.IsNullOrEmpty(text2))
						{
							num = (short)663027735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						char[] array = new char[]
						{
							'\\',
							'/',
							':',
							'*',
							'?',
							'"',
							'<',
							'>',
							'|'
						};
						num3 = 0;
						num = (short)864944131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (string.IsNullOrEmpty(text2))
						{
							num = (short)1823932437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)850591761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						result = string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춈\udd8a\udf8c\udc8e캐ꖔ욘겜辠\udba2좤쮦", a_), text2, text);
						num = (short)1777139717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (this.a(text2))
						{
							num = (short)598671376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춈\udd8a\udf8c\udc8e캐ꖔ래", a_), text);
						num = (short)1416429588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						return result;
					case 19:
						return result;
					case 20:
						return result;
					case 21:
						result = string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춈\udd8a\udf8c\udc8e캐ꖔ래", a_), text);
						num = (short)1215037450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						num = (short)1725431809;
						if (num != 0)
						{
						}
						char value;
						if (!text2.Contains(value))
						{
							num = (short)282918924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text2 = text2.Remove(text2.IndexOf(value), 1);
						num = (short)536150023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						result = string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춈\udd8a\udf8c\udc8e캐ꖔ래", a_), text);
						num = (short)1514668032;
						short num5 = num;
						num = (short)325976082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_97;
					IL_105:
					num = (short)1239482368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_146:
					num = (short)480182294;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_335:
					text2 = radioInformation.General.RadInfoGeneralCodeplugAlias_A7684Value;
					num = (short)2049638414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CD:
					num3++;
					num = (short)1987772425;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_97:
				result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춈\udd8a\udf8c\udc8e캐킒얔횖ﲜﺠ삤햦삨쪪솬쒰\udeb2ힴ튶쮸", a_);
				text = "";
				text2 = "";
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)353894413;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00154440 File Offset: 0x00152640
		public bool ExportToXmlDoc(string xmlFullPath)
		{
			int num;
			short num2;
			bool result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					global::System.Xml.XmlTextWriter xmlTextWriter;
					switch (num)
					{
					case 0:
						goto IL_1C0;
					case 1:
						if (this.c)
						{
							num2 = (short)1210787100;
							short num3 = num2;
							num2 = (short)700982556;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E;
							case 1:
								break;
							default:
							{
								num2 = (short)591003648;
								short num4 = num2;
								break;
							}
							}
							num2 = (short)1478230016;
							if (num2 != 0)
							{
							}
							num2 = (short)1755774977;
							if (num2 != 0)
							{
							}
							num2 = (short)1293549568;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 2:
						try
						{
							xmlTextWriter = new global::System.Xml.XmlTextWriter(xmlFullPath, null);
							xmlTextWriter.Formatting = global::System.Xml.Formatting.Indented;
							this.b.WriteContentTo(xmlTextWriter);
							xmlTextWriter.Flush();
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, global::CommonResources.AppResources.Export_DVRS_MSU_Data_Completed);
							return true;
						}
						catch (global::System.IO.DirectoryNotFoundException)
						{
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, global::CommonResources.AppResources.DVRS_Export_Location_Not_Exist_Or_Not_Reachable);
							return result;
						}
						catch (global::System.Exception)
						{
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, global::CommonResources.AppResources.Export_DVRS_MSU_Data_Failed_Error_Writing_File);
							return result;
						}
						finally
						{
							num2 = (short)221511681;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
									xmlTextWriter.Close();
									num2 = (short)1641414658;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_189;
									}
									continue;
								case 2:
									goto IL_1BD;
								}
								IL_189:
								if (xmlTextWriter == null)
								{
									break;
								}
								num2 = (short)1712324608;
								num = (int)((global::System.IntPtr)num2);
							}
							IL_1BD:;
						}
						goto IL_1C0;
					}
					goto IL_1C;
					IL_1C0:
					xmlTextWriter = null;
					num2 = (short)912195586;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
			}
			IL_1C:
			result = false;
			IL_1E:
			num2 = (short)990248961;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00154654 File Offset: 0x00152854
		private bool a(string A_0)
		{
			bool result = false;
			global::System.IO.FileInfo fileInfo = null;
			global::System.IO.FileStream fileStream = null;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_38;
				}
				int num;
				for (;;)
				{
					IL_12:
					bool flag;
					switch (num)
					{
					case 0:
						flag = true;
						goto IL_154;
					case 1:
						goto IL_B7;
					case 2:
						goto IL_16E;
					case 3:
						if (fileInfo != null)
						{
							num2 = (short)750780422;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B7;
					case 4:
						if (fileStream != null)
						{
							num2 = (short)613875719;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)529334277;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						flag = false;
						goto IL_154;
					case 6:
						goto IL_79;
					case 7:
					{
						num2 = (short)1358574791;
						short num3 = num2;
						num2 = (short)1727739079;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_79;
						default:
							num2 = (short)1845493760;
							if (num2 != 0)
							{
							}
							num2 = (short)1371078656;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_38;
					IL_79:
					fileStream = fileInfo.Create();
					num2 = (short)1793654785;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_B7:
					num2 = (short)392822788;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_154:
					result = flag;
					num2 = (short)142671874;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_16E:
				goto IL_223;
				IL_38:
				fileInfo = new global::System.IO.FileInfo(global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), A_0));
				num2 = (short)207945731;
				num = (int)((global::System.IntPtr)num2);
				goto IL_12;
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			finally
			{
				num2 = (short)1475805187;
				int num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
						fileInfo.Delete();
						num2 = (short)851968001;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_1E7;
					case 2:
						fileStream.Close();
						num2 = (short)825229316;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_1B3;
						}
						continue;
					case 4:
						if (fileInfo != null)
						{
							num2 = (short)94633984;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_222;
					}
					IL_1B3:
					if (fileStream == null)
					{
						break;
					}
					num2 = (short)1777598466;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1E7:
				IL_222:;
			}
			IL_223:
			num2 = (short)967376896;
			short num4 = num2;
			num2 = (short)1221459969;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0015490C File Offset: 0x00152B0C
		private global::System.Xml.XmlElement a(global::System.Xml.XmlDocument A_0, global::SpecialFeatures.DVRSXML.DvrsElementItem A_1)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			short num2;
			global::System.Xml.XmlElement xmlElement;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					try
					{
						num2 = (short)725352451;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_2B0;
							case 1:
								num2 = (short)1249312768;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
							{
								global::System.Collections.Generic.List<global::SpecialFeatures.DVRSXML.DvrsElementItem>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num2 = (short)1721171969;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::SpecialFeatures.DVRSXML.DvrsElementItem a_2 = enumerator.Current;
								xmlElement.AppendChild(this.a(A_0, a_2));
								num2 = (short)485031940;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_235;
								}
								continue;
							}
							IL_237:
							num2 = (short)1543110658;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_235:
							goto IL_237;
						}
						IL_2B0:
						return xmlElement;
					}
					finally
					{
						global::System.Collections.Generic.List<global::SpecialFeatures.DVRSXML.DvrsElementItem>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_2C0;
				case 1:
					goto IL_14E;
				case 2:
					goto IL_18B;
				case 3:
				{
					global::System.Collections.Generic.List<global::SpecialFeatures.DVRSXML.DvrsElementItem>.Enumerator enumerator = A_1.ChildList.GetEnumerator();
					num2 = (short)980090880;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					num2 = (short)751763457;
					if (num2 != 0)
					{
					}
					if (A_1.AttrValue != null)
					{
						num2 = (short)161611783;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18B;
				case 5:
					if (A_1.ElementValue != null)
					{
						num2 = (short)305659912;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14E;
				case 6:
					goto IL_167;
				case 7:
					xmlElement.SetAttribute(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욇", a_), A_1.AttrValue);
					num2 = (short)734789634;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_2C0;
				}
				break;
				IL_14E:
				num2 = (short)253952006;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_18B:
				num2 = (short)814940165;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2C0:
				xmlElement.InnerText = A_1.ElementValue;
				num2 = (short)1579089921;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_3D:
			xmlElement = A_0.CreateElement(A_1.ElementName);
			num2 = (short)518238778;
			short num3 = num2;
			num2 = (short)1516810810;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_167:
				if (A_1.ChildList != null)
				{
					num2 = (short)63832067;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				break;
			default:
			{
				num2 = (short)1875247104;
				if (num2 != 0)
				{
				}
				num2 = (short)798883840;
				short num4 = num2;
				num2 = (short)1898708996;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
			return xmlElement;
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00154C14 File Offset: 0x00152E14
		internal string CovertDispMenuLanguage(int value)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			short num2;
			string result;
			global::System.Globalization.CultureInfo culture;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)1972961281;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
					return result;
				case 4:
					return result;
				case 5:
					return result;
				case 6:
					return result;
				case 7:
					switch (value)
					{
					case 0:
					case 9:
						result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캊﶐朗ﾖ", a_);
						num2 = (short)1226702851;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
					{
						result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊ﾌﾐﶔ", a_);
						num2 = (short)1121124352;
						short num3 = num2;
						num2 = (short)1226506245;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
					case 10:
					case 11:
					case 12:
					{
						num2 = (short)471528978;
						short num4 = num2;
						num2 = (short)1889400338;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1615003648;
							if (num2 != 0)
							{
							}
							result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88aﶌﾐ朗ﾖ", a_);
							num2 = (short)1734803460;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						break;
					case 4:
						result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎펐튒\udd94횖쪘\uda9a", a_), culture);
						num2 = (short)338034690;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎\ud990횒힔얖\udc98첚", a_), culture);
						num2 = (short)1314127880;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎쎐욒요쒖킘\uda9a펜", a_), culture);
						num2 = (short)1095106570;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎튐\udb92\udc94\ud996\udc98좚\ud89c쮞ﶨﾲ", a_), culture);
						num2 = (short)758120457;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎킐솒풔햖킘\ud89a", a_), culture);
						num2 = (short)996409355;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)433389568;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8aﶎﲘ", a_);
					num2 = (short)2116878342;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return result;
				case 9:
					return result;
				case 10:
					goto IL_FF;
				case 11:
					return result;
				}
				goto IL_49;
			}
			IL_FF:
			num2 = (short)144441345;
			if (num2 != 0)
			{
			}
			return result;
			IL_49:
			result = string.Empty;
			culture = new global::System.Globalization.CultureInfo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			num2 = (short)1415643143;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00154F60 File Offset: 0x00153160
		internal string CovertTransmitPowerLevelsBandSplitOverride(int value)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			string result;
			global::System.Globalization.CultureInfo culture;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					switch (value)
					{
					case 0:
						break;
					case 1:
						result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솇캉펋\udb8d\ud88f풑욓ꞕ", a_), culture);
						num2 = (short)651689987;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
					{
						result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솇캉펋\udb8d\ud88f풑욓꒕", a_), culture);
						num2 = (short)788618948;
						short num3 = num2;
						num2 = (short)2126274244;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)263389185;
							if (num2 != 0)
							{
							}
							num2 = (short)128974848;
							if (num2 != 0)
							{
							}
							num2 = (short)1946288128;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					default:
						num2 = (short)2141913092;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솇캉펋삍\udf8f\udc91톓", a_), culture);
					num2 = (short)614596610;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
					return result;
				case 4:
					num2 = (short)215810053;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					return result;
				}
				goto IL_31;
			}
			return result;
			IL_31:
			num2 = (short)1155858432;
			short num4 = num2;
			result = string.Empty;
			culture = new global::System.Globalization.CultureInfo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			num2 = (short)1930166273;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00155154 File Offset: 0x00153354
		internal string CovertRxVoiceSignalType(int value)
		{
			int a_ = 10;
			int num;
			short num2;
			global::System.Globalization.CultureInfo culture;
			string result;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						goto IL_18F;
					case 1:
						switch (value)
						{
						case 0:
							num2 = (short)713752577;
							if (num2 != 0)
							{
							}
							result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒌쮎캐\udd92\uda94\ud996\ud898좚즜춞", a_), culture);
							num2 = (short)2039742466;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
						{
							num2 = (short)2069692416;
							short num3 = num2;
							result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒌쮎캐\ude92\udc94쾖\udc98\udf9a킜킞", a_), culture);
							num2 = (short)800129027;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						case 2:
							result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒌쮎캐튒요쎖쮘풚", a_), culture);
							num2 = (short)416677888;
							num = (int)((global::System.IntPtr)num2);
							continue;
						default:
							num2 = (short)408223748;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					case 2:
						goto IL_143;
					case 3:
						goto IL_E4;
					case 4:
						num2 = (short)1247674373;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						goto IL_15C;
					}
					goto IL_31;
				}
				IL_E4:
				IL_143:
				IL_15C:
				IL_18F:
				num2 = (short)40665518;
				short num4 = num2;
				num2 = (short)279609774;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_4B;
				default:
					num2 = (short)1923809280;
					if (num2 != 0)
					{
					}
					return result;
				}
				break;
			}
			}
			IL_31:
			result = string.Empty;
			culture = new global::System.Globalization.CultureInfo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			IL_4B:
			num2 = (short)977666049;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00155340 File Offset: 0x00153540
		internal string CovertSignalingSignalingType(int value)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			short num2;
			global::System.Globalization.CultureInfo culture;
			string result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (value != 4)
					{
						num2 = (short)1483997191;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1979121665;
					if (num2 != 0)
					{
					}
					result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춃슅힇잉좋춍", a_), culture);
					num2 = (short)1476132867;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_150;
				case 2:
					if (value != 10)
					{
						num2 = (short)1467940872;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춃슅힇\udb89\ud98b잍\udb8f톑햓\uda95풗펙햛", a_), culture);
					num2 = (short)2010120197;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_133;
				case 4:
					return result;
				case 5:
					goto IL_1BF;
				case 6:
					num2 = (short)188284928;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1709441026;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)2143617025;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					num2 = (short)704616719;
					short num3 = num2;
					num2 = (short)601987343;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_133;
					default:
						num2 = (short)1732837376;
						if (num2 != 0)
						{
						}
						if (value != 0)
						{
							num2 = (short)1574371334;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춃슅힇쒉쎋삍햏", a_), culture);
						num2 = (short)1090322436;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_41;
			}
			IL_133:
			IL_150:
			return result;
			IL_1BF:
			num2 = (short)825425920;
			short num4 = num2;
			return result;
			IL_41:
			result = string.Empty;
			culture = new global::System.Globalization.CultureInfo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			num2 = (short)1174274057;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x001555A8 File Offset: 0x001537A8
		internal string CovertTxVoiceSignalType(int value)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			short num2;
			string result;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					if (value != 1)
					{
						num2 = (short)1038024709;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A5;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
					num2 = (short)1613365248;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return result;
				case 5:
					num2 = (short)1445855236;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					if (value != 0)
					{
						num2 = (short)1087766531;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Globalization.CultureInfo culture;
					result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삈쾊튌솎\ude90\udd92풔쒖춘즚튜", a_), culture);
					num2 = (short)1908539392;
					short num3 = num2;
					num2 = (short)1950220289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_35;
			}
			return result;
			IL_35:
			num2 = (short)2019497536;
			short num4 = num2;
			num2 = (short)955323968;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1A5:
				global::System.Globalization.CultureInfo culture;
				result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삈쾊튌캎슐잒잔\ud896", a_), culture);
				num2 = (short)647233538;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)267255809;
				if (num2 != 0)
				{
				}
				num2 = (short)1850146816;
				if (num2 != 0)
				{
				}
				result = string.Empty;
				global::System.Globalization.CultureInfo culture = new global::System.Globalization.CultureInfo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
				num2 = (short)1331429382;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00155790 File Offset: 0x00153990
		internal string CovertTalkgroup(int value)
		{
			int a_ = 14;
			int num;
			short num2;
			global::System.Globalization.CultureInfo culture;
			string result;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						num2 = (short)708837380;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_13B;
					case 2:
						result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud890힒쪔펖삘햚", a_), culture);
						num2 = (short)1350631425;
						if (num2 != 0)
						{
						}
						num2 = (short)103022593;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_DD;
					case 4:
						if (value == 65535)
						{
							num2 = (short)1107951618;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_178;
					case 5:
						if (value != 0)
						{
							num2 = (short)1222246400;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud890힒쪔횖춘\udc9a", a_), culture);
						num2 = (short)487653379;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_31;
				}
				IL_DD:
				IL_13B:
				IL_178:
				num2 = (short)843576559;
				short num3 = num2;
				num2 = (short)1669330159;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_4B;
				default:
					num2 = (short)1591345152;
					if (num2 != 0)
					{
					}
					return result;
				}
				break;
			}
			}
			IL_31:
			result = string.Empty;
			culture = new global::System.Globalization.CultureInfo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶒ", a_));
			IL_4B:
			num2 = (short)1862467584;
			short num4 = num2;
			num2 = (short)958005253;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00155960 File Offset: 0x00153B60
		internal string CovertChannelType(int value)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			short num2;
			string result;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					if (value != 1)
					{
						num2 = (short)465108997;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A8;
				case 1:
					goto IL_100;
				case 2:
					return result;
				case 3:
					num2 = (short)292552704;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return result;
				case 5:
					num2 = (short)1310326785;
					if (num2 != 0)
					{
					}
					num2 = (short)1794048004;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					if (value != 0)
					{
						num2 = (short)677576707;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Globalization.CultureInfo culture;
					result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎튐\udd92쎔", a_), culture);
					num2 = (short)347406337;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_35;
			}
			IL_100:
			num2 = (short)1590493184;
			short num3 = num2;
			return result;
			IL_35:
			num2 = (short)1595141373;
			short num4 = num2;
			num2 = (short)1151069437;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1A8:
				global::System.Globalization.CultureInfo culture;
				result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎얐솒\ude94", a_), culture);
				num2 = (short)359858178;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)338493440;
				if (num2 != 0)
				{
				}
				result = string.Empty;
				global::System.Globalization.CultureInfo culture = new global::System.Globalization.CultureInfo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
				num2 = (short)358744070;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00155B4C File Offset: 0x00153D4C
		internal string CovertProtocolType(int value)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			short num2;
			string result;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					if (value != 7)
					{
						num2 = (short)2088304645;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A8;
				case 1:
					goto IL_104;
				case 2:
					return result;
				case 3:
					num2 = (short)1677131776;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_149;
				case 5:
					num2 = (short)2018312196;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					if (value != 2)
					{
						num2 = (short)218234883;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Globalization.CultureInfo culture;
					result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첄쎆횈슊쒌", a_), culture);
					num2 = (short)1112211457;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_35;
			}
			IL_104:
			num2 = (short)1914568704;
			short num3 = num2;
			return result;
			IL_149:
			num2 = (short)2122055681;
			if (num2 != 0)
			{
			}
			return result;
			IL_35:
			num2 = (short)506414405;
			short num4 = num2;
			num2 = (short)237192517;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1A8:
				global::System.Globalization.CultureInfo culture;
				result = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첄쎆횈쪊\ude8c\udb8e쎐\udc92ꞔꊖ", a_), culture);
				num2 = (short)101580802;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)748158976;
				if (num2 != 0)
				{
				}
				result = string.Empty;
				global::System.Globalization.CultureInfo culture = new global::System.Globalization.CultureInfo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
				num2 = (short)1665073158;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00155D38 File Offset: 0x00153F38
		internal global::SpecialFeatures.DVRSXML.DvrsElementItem BuildDvrsExportData()
		{
			int a_ = 15;
			short num = (short)1125056512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)725417985;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				string elementValue;
				global::SpecialFeatures.DVRSXML.DvrsElementItem dvrsElementItem4;
				global::SpecialFeatures.DVRSXML.DvrsElementItem dvrsElementItem5;
				for (;;)
				{
					IL_56:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_1992;
					case 1:
						elementValue = this.CovertTransmitPowerLevelsBandSplitOverride(features.RadWideTransmitPowerLevelsBandSplitOverride_A41064.Value);
						num = (short)1538523136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							num = (short)795738119;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)965672965;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator.Current;
									bool flag = false;
									global::SpecialFeatures.DVRSXML.DvrsElementItem dvrsElementItem = new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91ﮓﶗ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좑ﮓﶗ몙\udf9b솟첡쪣쎥쒧誩\uddad쎯\udbb1펳\ud8b5햷\udfb9튻쪽", a_), null);
									global::SpecialFeatures.DVRSXML.DvrsElementItem dvrsElementItem2 = new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좑ﮓﶗ", a_), null);
									dvrsElementItem.Add(dvrsElementItem2);
									dvrsElementItem2.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좑ﮓﶗ몙튛ﾝ춟잡", a_), zoneChannelAssignment.Zone.ZnChanCfgZoneZoneName_A9724.Value));
									dvrsElementItem2.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좑ﮓﶗ몙튛춟삡솣풥", a_), zoneChannelAssignment.Position.ToString()));
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (zoneChannelAssignment[10114].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset).GetEnumerator();
									num = (short)1454309380;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_191F;
								case 3:
								{
									bool flag;
									if (flag)
									{
										num = (short)193724422;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									try
									{
										num = (short)1588854791;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											string elementValue2;
											string elementValue3;
											global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
											global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand;
											global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
											global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
											global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles dvrsprofiles;
											global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
											int num3;
											global::SpecialFeatures.DVRSXML.DvrsElementItem dvrsElementItem3;
											global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner talkgroupInner;
											global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
											string elementValue4;
											string elementValue5;
											string elementValue6;
											global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles;
											string elementValue7;
											string elementValue8;
											switch (num2)
											{
											case 0:
												goto IL_650;
											case 1:
												goto IL_650;
											case 2:
												elementValue2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊑ", a_);
												elementValue3 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊑ", a_);
												num = (short)475398192;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												frequencyBand = this.a(frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsRxFrequency_A8911.Value);
												num = (short)549715969;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												trunkingPersonality.General.TrkPerGeneralEmergencyRevertType_A41914.CalculateApplicability();
												num = (short)1822425135;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												if (conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.Value)
												{
													num = (short)1045299203;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												frequencyBand = this.a(frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsRxFrequency_A8911.Value, frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxFrequency_A9414.Value);
												num = (short)1581383680;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												goto IL_54B;
											case 7:
												switch (0)
												{
												case 0:
													goto IL_546;
												}
												continue;
											case 8:
												num = (short)1469644832;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
												if (dvrsprofiles == null)
												{
													num = (short)407633984;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_122A;
											case 10:
												elementValue = trunkingSystem.ASTRO26.TrkSysASTRO25Phase2VoiceCapable_A37972.Value.ToString();
												num = (short)1978531893;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 12:
												num3 = conventionalPersonality.Signaling.CnvPerSignalingRevertType_A8953.Value;
												num = (short)1186136132;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 13:
												dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삑뚕캗ﶝ얟芡讣蚥ﮧ쎩쮫삭톯\udeb1钳솷쪹\ud9bb", a_), this.CovertRxVoiceSignalType(conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value)));
												dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욑뚕캗ﶝ얟芡讣蚥ﮧ쎩쮫삭톯\udeb1钳솷쪹\ud9bb", a_), this.CovertTxVoiceSignalType(conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.Value)));
												elementValue = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91뮓힕", a_);
												conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.CalculateApplicability();
												num = (short)936312897;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 14:
												if (talkgroupInner != null)
												{
													num = (short)2048655387;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												elementValue4 = this.CovertTalkgroup(channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276.Value);
												num = (short)2132082694;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 15:
												elementValue = trunkingSystem.ASTRO26.TrkSysASTRO25F2VoiceCapable_A1395.Value.ToString();
												num = (short)560267320;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 16:
												goto IL_1099;
											case 17:
												if (trunkingSystem.ASTRO26.TrkSysASTRO25F2VoiceCapable_A1395.Applicable)
												{
													num = (short)410124303;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_16C3;
											case 19:
												goto IL_54B;
											case 20:
												goto IL_857;
											case 21:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInner talkgroupTableInner;
												if (talkgroupTableInner != null)
												{
													num = (short)1561985048;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_1099;
											}
											case 22:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInner talkgroupTableInner = frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInner;
												num = (short)592969749;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 23:
												num = (short)426901532;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 24:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInner talkgroupTableInner;
												elementValue5 = talkgroupTableInner.TalkgroupTableInnerSection.AstTlkgrpLstTalkgroupListTalkgroupID_A9282.Value.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪑ꂓ", a_));
												num = (short)1483472912;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 25:
												if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Applicable)
												{
													num = (short)908001302;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_1099;
											case 26:
												elementValue6 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊑ", a_);
												num = (short)2047475732;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 27:
												elementValue4 = talkgroupInner.TalkgroupInnerSection.TrkPerTalkgroupTalkgroup_A9274.Value.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪑ꂓ", a_));
												num = (short)1048182803;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 28:
												if (trunkingEmergencyProfiles.General.TrkEmerProfGeneralEmergencyTalkback_A9268.Value == 1)
												{
													num = (short)767033370;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)766902308;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 29:
												goto IL_857;
											case 30:
												num = (short)559284281;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 31:
												if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
												{
													num = (short)2047344692;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_139B;
											case 32:
												if (!trunkingSystem.ASTRO26.TrkSysASTRO25F2VoiceCapable_A1395.HiddenStatic)
												{
													num = (short)680067118;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_16C3;
											case 33:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)988807198;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												channelAssignmentListInner = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner)enumerator2.Current;
												conventionalPersonality = null;
												trunkingPersonality = null;
												bool flag2 = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 0;
												num = (short)14483522;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 34:
												num = (short)1316225091;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 35:
												goto IL_857;
											case 36:
												if (trunkingEmergencyProfiles.General.TrkEmerProfGeneralEmergencyTalkback_A9268.Value == 0)
												{
													num = (short)1169752068;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_857;
											case 37:
												if (num3 == 4)
												{
													num = (short)1879703602;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_BA5;
											case 38:
												elementValue6 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊑ", a_);
												elementValue7 = (trunkingPersonality.General.TrkPerGeneralRevertZone_A41916.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Position.ToString();
												elementValue8 = (trunkingPersonality.General.TrkPerGeneralRevertChannel_A41917.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner).Position.ToString();
												num = (short)1787166755;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 39:
											{
												bool flag2;
												if (flag2)
												{
													num = (short)951386125;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑ﾙ뺝첡슣즥睊\udeab솭쒯\uddb1ힳ\ud9b5풷骹잽낿ꟁ", a_), this.CovertProtocolType(trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.Value)));
												trunkingSystem = (trunkingPersonality.General.TrkPerGeneralSystem_A9237.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
												num = (short)938606632;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 40:
												if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
												{
													num = (short)952631340;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횑聯肟袧", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91뮓힕", a_)));
												num = (short)1498742853;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 41:
												if (!frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.HiddenStatic)
												{
													num = (short)774045741;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_1099;
											case 42:
												goto IL_122A;
											case 43:
												if (conventionalPersonality.Signaling.CnvPerSignalingRevertType_A8953.Applicable)
												{
													num = (short)500039692;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_BA5;
											case 44:
												dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횑聯肟袧", a_), trunkingSystem.ASTRO26.TrkSysASTRO25DefaultRCMAddress_A7813.Value.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪑ꊓ", a_))));
												num = (short)477036593;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 45:
												frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.CalculateApplicability();
												num = (short)604438553;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 46:
												trunkingSystem.ASTRO26.TrkSysASTRO25F2VoiceCapable_A1395.CalculateApplicability();
												num = (short)748879889;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 47:
												if (trunkingPersonality.General.TrkPerGeneralEmergencyRevertType_A41914.Applicable)
												{
													num = (short)1229520930;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_F12;
											case 48:
												goto IL_BA5;
											case 49:
												goto IL_144C;
											case 50:
												elementValue2 = (conventionalPersonality.Signaling.CnvPerSignalingRevertZone_A13269.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Position.ToString();
												elementValue3 = (conventionalPersonality.Signaling.CnvPerSignalingRevertChannel_A13267.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner).Position.ToString();
												num = (short)1803878454;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 51:
												if (dvrsprofiles != null)
												{
													num = (short)1101135914;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 52:
												num = (short)1321336891;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 53:
												goto IL_139B;
											case 54:
												goto IL_BA5;
											case 55:
												if (trunkingSystem.ASTRO26.TrkSysASTRO25Phase2VoiceCapable_A37972.Applicable)
												{
													num = (short)258932746;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_139B;
											case 56:
												goto IL_16C3;
											case 57:
												goto IL_1808;
											case 59:
												if (!trunkingSystem.ASTRO26.TrkSysASTRO25Phase2VoiceCapable_A37972.HiddenStatic)
												{
													num = (short)829423686;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_139B;
											case 60:
												if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
												{
													num = (short)2083454984;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_16C3;
											case 61:
												if (trunkingEmergencyProfiles != null)
												{
													num = (short)898433047;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_857;
											case 62:
												elementValue = this.CovertSignalingSignalingType(conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.Value);
												num = (short)1786445887;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 63:
												goto IL_741;
											case 64:
												num = (short)190513163;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 65:
												if (conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.Applicable)
												{
													num = (short)1789132862;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_741;
											case 66:
											{
												bool flag2;
												if (flag2)
												{
													num = (short)1149501511;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												trunkingPersonality = (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality);
												dvrsprofiles = (trunkingPersonality.General.TrkPerFeaturesDVRSProf_A41796.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles);
												num = (short)1524039731;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 67:
												if (trunkingPersonality.General.TrkPerGeneralEmergencyRevertType_A41914.Value == 1)
												{
													num = (short)1543897126;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_F12;
											case 68:
												if (num3 == 0)
												{
													num = (short)1952514050;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1087766565;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 69:
												goto IL_144C;
											case 70:
												trunkingSystem.ASTRO26.TrkSysASTRO25Phase2VoiceCapable_A37972.CalculateApplicability();
												num = (short)2030698551;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 71:
												conventionalPersonality = (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality);
												dvrsprofiles = (conventionalPersonality.General.CnvPerFeaturesDVRSProf_A41794.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles);
												num = (short)1606615049;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_546;
											IL_54B:
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욑歹ﶙ햟튡蒣", a_), elementValue4));
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd91流쒟芡\udfa5\udba7\udea9즫쎭邯톳욵\uddb7\udbb9좻麽ꦿ곁諅Ꟈ꧉귋ꋍ鿑믓닕뷗", a_), dvrsprofiles.General.DVRSProfGeneralOutSysRepLocalMode_A41804.Value.ToString()));
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf91잓쎕뢗즙풟잡즣蚥ﺩ躭\ud9af\udcb1钳蝹ힷ\ud9b9\uddbb튽迁ꯃꋅ귇", a_), dvrsprofiles.General.DVRSProfGeneralMSUSysPTTInLocalMode_A41803.Value.ToString()));
											global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand2 = this.a(trunkingSystem);
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑鍊쎟\udba1蒣즧쒩좫", a_), global::SpecialFeatures.DVRSXML.DvrsMsuDataSync.a[(int)frequencyBand2]));
											num = (short)2013528122;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_650:
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑鍊쎟\udba1蒣즧쒩좫", a_), global::SpecialFeatures.DVRSXML.DvrsMsuDataSync.a[(int)frequencyBand]));
											num = (short)853671954;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_741:
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91ﮓ떗\udb99쾛쪝솧충슫쾭\udcaf\udbb1\udab3통颷얻캽ꖿ", a_), elementValue));
											num3 = 0;
											elementValue2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91뮓힕", a_);
											elementValue3 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91뮓힕", a_);
											conventionalPersonality.Signaling.CnvPerSignalingRevertType_A8953.CalculateApplicability();
											num = (short)1552744491;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_857:
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힑煉ﶙ鍊쎟\udba1蒣즧용잫청톯톱\udfb3隵\udfb9쪻\udbbd늿뛁飃鋅꧇ꛉꟋ꧍ꋏ뷑ꇓꛕ鏙飛", a_), elementValue6));
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힑煉ﶙ鍊쎟\udba1蒣톧\ud9a9\ud8ab쮭\uddaf銱펵캷\udfb9캻쪽鲿郁ꇃ냅귇룉룋諏뷑뫓돕", a_), elementValue7));
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힑煉ﶙ鍊쎟\udba1蒣톧\ud9a9\ud8ab쮭\uddaf銱펵캷\udfb9캻쪽鲿郁ꇃ냅귇룉룋鏏뫑뗓룕뛗뿙냛", a_), elementValue8));
											talkgroupInner = (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner);
											num = (short)497745934;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_BA5:
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힑煉ﶙ鍊쎟\udba1蒣춧\udca9즫\udcad쒯펵캷\udfb9캻쪽飁ꯃꣅ귇", a_), elementValue2));
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힑煉ﶙ鍊쎟\udba1蒣춧\udca9즫\udcad쒯펵캷\udfb9캻쪽臁곃Ʂꛇ꓉꧋ꋍ", a_), elementValue3));
											elementValue5 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91뮓힕", a_);
											frequencyOptionsInner = (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner);
											num = (short)2007498793;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_F12:
											elementValue6 = trunkingPersonality.General.TrkEmerProfGeneralTalkgroup_A8969.Value.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪑ꂓ", a_));
											num = (short)2052194333;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1099:
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욑歹ﶙ햟튡蒣", a_), elementValue5));
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd91流쒟芡\udfa5\udba7\udea9즫쎭邯톳욵\uddb7\udbb9좻麽ꦿ곁諅Ꟈ꧉귋ꋍ鿑믓닕뷗", a_), dvrsprofiles.General.DVRSProfGeneralOutSysRepLocalMode_A41804.Value.ToString()));
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf91잓쎕뢗즙풟잡즣蚥ﺩ躭\ud9af\udcb1钳蝹ힷ\ud9b9\uddbb튽迁ꯃꋅ귇", a_), dvrsprofiles.General.DVRSProfGeneralMSUSysPTTInLocalMode_A41803.Value.ToString()));
											num = (short)571146245;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_122A:
											bool flag = true;
											dvrsElementItem3 = new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톑ﲓ鍊펟", a_), null);
											global::SpecialFeatures.DVRSXML.DvrsElementItem dvrsElementItem;
											dvrsElementItem.Add(dvrsElementItem3);
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톑ﲓ鍊肟얣쮥춧", a_), channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelName_A7659.Value));
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톑ﲓ鍊肟톣쮥쪧쾩\udeab", a_), channelAssignmentListInner.Position.ToString()));
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톑ﲓ鍊肟\udda3횥춧", a_), this.CovertChannelType(channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value)));
											num = (short)1333133351;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_139B:
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슑ﲓﾙ벛겝肟쮣쾥쮧쾩貫톯슱햳풵풷\udfb9", a_), elementValue));
											trunkingEmergencyProfiles = (trunkingPersonality.General.TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles);
											elementValue6 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91뮓힕", a_);
											elementValue7 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91뮓힕", a_);
											elementValue8 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91뮓힕", a_);
											num = (short)1718288445;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_144C:
											elementValue = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91뮓힕", a_);
											num = (short)956301372;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_15B7:
											num = (short)326565921;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_546:
											goto IL_15B7;
											IL_16C3:
											dvrsElementItem3.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪑ꚓ뚕캗ﶝ얟芡장\ud8a7쮩캫슭햯", a_), elementValue));
											elementValue = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91뮓힕", a_);
											num = (short)654114847;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_1808:;
									}
									finally
									{
										num = (short)584777729;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_185E;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_1840;
												}
												continue;
											case 2:
											{
												num = (short)302675910;
												short num4 = num;
												num = (short)1833990086;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_185E;
												default:
													goto IL_18B1;
												}
												break;
											}
											}
											IL_1840:
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											if (enumerator2 != null)
											{
												num = (short)198705152;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_18C9;
											IL_185E:
											enumerator2.Dispose();
											num = (short)1494745090;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_18B1:
										num = (short)958464000;
										if (num != 0)
										{
										}
										IL_18C9:;
									}
									num = (short)406126595;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)1753481218;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::SpecialFeatures.DVRSXML.DvrsElementItem dvrsElementItem;
									dvrsElementItem4.Add(dvrsElementItem);
									num = (short)1558315008;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_28B;
									}
									continue;
								}
								IL_3BD:
								num = (short)1665269761;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_28B:
								goto IL_3BD;
							}
							IL_191F:
							return dvrsElementItem4;
						}
						finally
						{
							num = (short)527368193;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1827405826;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1957;
									}
									continue;
								case 2:
									goto IL_198F;
								}
								IL_1957:
								if (enumerator == null)
								{
									break;
								}
								num = (short)881917952;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_198F:;
						}
						goto IL_1992;
					case 3:
						if (!features.RadWideTransmitPowerLevelsBandSplitOverride_A41064.HiddenStatic)
						{
							num = (short)2076311552;
							short num5 = num;
							num = (short)1153433601;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1992;
					}
					goto IL_6D;
					IL_1992:
					dvrsElementItem5.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd91ﶛ肟솣솥솧얩슫躭펱\udab3튵颷캻\udbbdꚿꟁ뛃ꏅꛇ꧉꧋", a_), elementValue));
					dvrsElementItem5.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횑슓쒕쮗몙\uda9b얟캡삣蚥쮩\udfab욭", a_), ""));
					enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset).GetEnumerator();
					num = (short)94961666;
					num2 = (int)((global::System.IntPtr)num);
				}
				return dvrsElementItem4;
				IL_6D:
				dvrsElementItem4 = new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횑슓쒕쮗얙첟ﶡ삣즥쮧", a_), null, null);
				dvrsElementItem4.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒑", a_), null, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎑ", a_)));
				dvrsElementItem4.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude91ﾗﶛ劣얟", a_), null, ""));
				dvrsElementItem4.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude91힙瞧즟쒡춣쎥첧춫\udaad햯\uddb3\udbb5\uddb7", a_), ""));
				global::SpecialFeatures.DVRSXML.DvrsElementItem dvrsElementItem6 = new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91ﮓﶗ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삑벛증즟욡솣", a_), null);
				dvrsElementItem4.Add(dvrsElementItem6);
				dvrsElementItem5 = new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햑ﶗﶛ", a_), null);
				dvrsElementItem6.Add(dvrsElementItem5);
				global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced advanced = global::AcpCommonLib.FeatureManager.GetFeature(2010)[0][10019] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced;
				dvrsElementItem5.Add(new global::SpecialFeatures.DVRSXML.DvrsElementItem(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﺙ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삑벛\uda9d즟톡풣쪥즧펩貫톯\udcb1펳쎵\ud9b7\uddb9\ud9bb", a_), this.CovertDispMenuLanguage(advanced.DispMenuAdvancedLanguageSelection_A8386.Value)));
				features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				elementValue = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91뮓힕", a_);
				num = (short)258932739;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
			}
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x001577C8 File Offset: 0x001559C8
		private global::ConstraintHelper.UtilityMack.FrequencyBand a(int A_0, int A_1)
		{
			short num = (short)1350959104;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1AF;
				}
				global::ConstraintHelper.UtilityMack.FrequencyBand result;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				for (;;)
				{
					IL_28:
					bool flag;
					bool flag2;
					bool flag3;
					bool flag4;
					switch (num2)
					{
					case 0:
						if (global::ConstraintHelper.UtilityMack.IsUHF1Supported())
						{
							num = (short)699859033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_839;
					case 1:
						return result;
					case 2:
						if (global::ConstraintHelper.UtilityMack.IsUHF2RxFrequency(A_1))
						{
							num = (short)1848311901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_392;
					case 3:
						if (global::ConstraintHelper.UtilityMack.Is900MHzSupported())
						{
							num = (short)497090600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E4A;
					case 4:
						num = (short)1362296866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return result;
					case 6:
						if (global::ConstraintHelper.UtilityMack.IsUHF2Supported())
						{
							num = (short)1649803333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7FF;
					case 7:
						result = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF2;
						num = (short)1495859201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (features.RadWideTransmitPowerLevelsBandSplitOverride_A41064.Value == 1)
						{
							num = (short)2048786481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_557;
					case 9:
						return result;
					case 10:
						num = (short)527761408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)271646723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (flag && flag2)
						{
							num = (short)61341744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)464715868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)339214400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (global::ConstraintHelper.UtilityMack.Is7800MHzSupported())
						{
							num = (short)1271267374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9A;
					case 15:
						if (global::ConstraintHelper.UtilityMack.IsUHF2Supported())
						{
							num = (short)530972705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_659;
					case 16:
						if (global::ConstraintHelper.UtilityMack.Is800MHzRxFrequency(A_0))
						{
							num = (short)786300928;
							short num3 = num;
							num = (short)1473773587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D3;
					case 17:
						if (global::ConstraintHelper.UtilityMack.Is700MHzRxFrequency(A_0))
						{
							num = (short)1571225676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9A;
					case 18:
						num = (short)1597702204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1803943987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (global::ConstraintHelper.UtilityMack.IsUHF1Supported())
						{
							num = (short)870187074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_557;
					case 21:
						if (global::ConstraintHelper.UtilityMack.IsUHF1TxFrequency(A_1))
						{
							num = (short)1997209647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_240;
					case 22:
						goto IL_392;
					case 23:
						if (global::ConstraintHelper.UtilityMack.Is900MHzTxFrequency(A_1))
						{
							num = (short)404226059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E4A;
					case 24:
						if (global::ConstraintHelper.UtilityMack.IsUHF1Supported())
						{
							num = (short)1311178837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BF2;
					case 25:
						goto IL_392;
					case 26:
						if (global::ConstraintHelper.UtilityMack.IsUHF1TxFrequency(A_1))
						{
							num = (short)1591541848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E0;
					case 27:
						if (global::ConstraintHelper.UtilityMack.IsVHFSupported())
						{
							num = (short)1423704107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E09;
					case 28:
						if (global::ConstraintHelper.UtilityMack.IsUHF2Supported())
						{
							num = (short)2066874442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_392;
					case 29:
						return result;
					case 30:
						if (global::ConstraintHelper.UtilityMack.IsUHF2TxFrequency(A_1))
						{
							num = (short)1064763436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BF2;
					case 31:
						if (global::ConstraintHelper.UtilityMack.IsUHF1Supported())
						{
							num = (short)747044917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E0;
					case 32:
						num = (short)744292358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						flag3 = true;
						num = (short)531234861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (global::ConstraintHelper.UtilityMack.IsUHF2RxFrequency(A_0))
						{
							num = (short)584515655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1209532433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (features.RadWideTransmitPowerLevelsBandSplitOverride_A41064.Value == 1)
						{
							num = (short)622395429;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BF2;
					case 36:
						num = (short)1282539547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)129368141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (global::ConstraintHelper.UtilityMack.Is700MHzTxFrequency(A_1))
						{
							num = (short)1620770884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9A;
					case 39:
						num = (short)1182400570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						result = global::ConstraintHelper.UtilityMack.FrequencyBand.P900;
						num = (short)1334902813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_392;
					case 42:
						if (global::ConstraintHelper.UtilityMack.IsUHF1RxFrequency(A_0))
						{
							num = (short)1293287434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_839;
					case 43:
						result = global::ConstraintHelper.UtilityMack.FrequencyBand.VHF;
						num = (short)1283129425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						num = (short)46661656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						goto IL_659;
					case 46:
					{
						num = (short)2056954209;
						short num4 = num;
						num = (short)1925685601;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
							num = (short)314376192;
							if (num != 0)
							{
							}
							result = global::ConstraintHelper.UtilityMack.FrequencyBand.P700;
							num = (short)959578198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 47:
						num = (short)1173618744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						result = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF1;
						num = (short)479920137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						num = (short)1216741377;
						if (num != 0)
						{
						}
						num = (short)1728249940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						result = global::ConstraintHelper.UtilityMack.FrequencyBand.P800;
						num = (short)1400504398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						if (global::ConstraintHelper.UtilityMack.Is800MHzTxFrequency(A_1))
						{
							num = (short)1522860071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D3;
					case 52:
						num = (short)1626406942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						flag2 = true;
						num = (short)382664787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						goto IL_659;
					case 55:
						flag4 = true;
						num = (short)1627914281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						if (global::ConstraintHelper.UtilityMack.IsUHF2TxFrequency(A_1))
						{
							num = (short)321716289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_240;
					case 57:
						if (features.RadWideTransmitPowerLevelsBandSplitOverride_A41064.Value == 2)
						{
							num = (short)1413611581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_240;
					case 58:
						if (global::ConstraintHelper.UtilityMack.Is7800MHzSupported())
						{
							num = (short)1280770098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D3;
					case 59:
						goto IL_659;
					case 60:
						if (global::ConstraintHelper.UtilityMack.IsUHF2RxFrequency(A_0))
						{
							num = (short)1420754976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7FF;
					case 61:
						num = (short)110886933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						if (global::ConstraintHelper.UtilityMack.IsVHFTxFrequency(A_1))
						{
							num = (short)930545700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E09;
					case 63:
						if (!global::ConstraintHelper.UtilityMack.IsUHF1RxFrequency(A_0))
						{
							num = (short)1623195652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9FE;
					case 64:
						if (global::ConstraintHelper.UtilityMack.IsUHF2RxFrequency(A_0))
						{
							num = (short)75432008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_557;
					case 65:
						num = (short)10485847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						flag = true;
						num = (short)306905142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						num = (short)1719664655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						num = (short)1686437902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						flag3 = true;
						num = (short)1325727835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (global::ConstraintHelper.UtilityMack.IsUHF2RxFrequency(A_0))
						{
							num = (short)2033451075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_659;
					case 71:
						goto IL_9FE;
					case 72:
						num = (short)698286100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						num = (short)431226942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						flag4 = true;
						num = (short)44433433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						return result;
					case 76:
						num = (short)1651703846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						if (global::ConstraintHelper.UtilityMack.IsUHF1TxFrequency(A_1))
						{
							num = (short)1560936500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BF2;
					case 78:
						return result;
					case 79:
						if (features.RadWideTransmitPowerLevelsBandSplitOverride_A41064.Value == 2)
						{
							num = (short)138936415;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7FF;
					case 80:
						if (global::ConstraintHelper.UtilityMack.IsUHF1RxFrequency(A_0))
						{
							num = (short)42074130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7FF;
					case 81:
						return result;
					case 82:
						num = (short)71303191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						goto IL_392;
					case 84:
						if (global::ConstraintHelper.UtilityMack.IsUHF1RxFrequency(A_0))
						{
							num = (short)763625485;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_557;
					case 85:
						flag2 = true;
						num = (short)574619670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						return result;
					case 87:
						if (global::ConstraintHelper.UtilityMack.IsUHF2Supported())
						{
							num = (short)2119893047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_240;
					case 88:
						num = (short)49283103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						flag = true;
						num = (short)436338747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						if (global::ConstraintHelper.UtilityMack.Is900MHzRxFrequency(A_0))
						{
							num = (short)1074397266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E4A;
					case 91:
						goto IL_659;
					case 92:
						if (flag3 && flag4)
						{
							num = (short)1187512327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = global::ConstraintHelper.UtilityMack.FrequencyBand.Unknown;
						num = (short)1516568581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
						num = (short)90308636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 94:
						if (global::ConstraintHelper.UtilityMack.IsVHFRxFrequency(A_0))
						{
							num = (short)524353609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E09;
					case 95:
						num = (short)97386576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AF;
					IL_240:
					num = (short)432078874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_392:
					num = (short)200212492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D3:
					num = (short)1829109850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_557:
					num = (short)1125187663;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_659:
					num = (short)1034485795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6E0:
					num = (short)1221984258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7FF:
					num = (short)1718878250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_839:
					num = (short)1128857670;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9FE:
					flag = false;
					flag3 = false;
					flag2 = false;
					flag4 = false;
					num = (short)272236552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BF2:
					num = (short)1701052473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C9A:
					num = (short)436142096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E09:
					num = (short)644350015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E4A:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.Unknown;
					num = (short)1785987147;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_1AF:
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0];
				features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				num = (short)1896415326;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00158680 File Offset: 0x00156880
		private global::ConstraintHelper.UtilityMack.FrequencyBand a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_E8;
			}
			int num;
			short num2;
			global::ConstraintHelper.UtilityMack.FrequencyBand result;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (global::ConstraintHelper.UtilityMack.Is700MHzRxFrequency(A_0))
					{
						num2 = (short)954531867;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_644;
				case 1:
					num2 = (short)1559035955;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)393216022;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_45B;
				case 4:
				{
					num2 = (short)207785907;
					short num3 = num2;
					num2 = (short)1846906803;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D4;
					default:
						num2 = (short)1855062016;
						if (num2 != 0)
						{
						}
						num2 = (short)1627521050;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					return result;
				case 6:
					return result;
				case 7:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF2;
					num2 = (short)94240777;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (global::ConstraintHelper.UtilityMack.Is900MHzSupported())
					{
						num2 = (short)457179165;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_384;
				case 9:
					return result;
				case 10:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.P700;
					num2 = (short)2116026411;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (global::ConstraintHelper.UtilityMack.IsVHFRxFrequency(A_0))
					{
						num2 = (short)1709506577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_604;
				case 12:
					if (global::ConstraintHelper.UtilityMack.IsUHF2RxFrequency(A_0))
					{
						num2 = (short)534904866;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4C6;
				case 13:
					if (global::ConstraintHelper.UtilityMack.IsUHF1RxFrequency(A_0))
					{
						num2 = (short)2028994593;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6EC;
				case 14:
					if (global::ConstraintHelper.UtilityMack.Is900MHzRxFrequency(A_0))
					{
						num2 = (short)1145765933;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_384;
				case 15:
					return result;
				case 16:
					goto IL_1D4;
				case 17:
					num2 = (short)1522925605;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num2 = (short)1417871412;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					return result;
				case 20:
					return result;
				case 21:
					num2 = (short)624295983;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (global::ConstraintHelper.UtilityMack.IsUHF1RxFrequency(A_0))
					{
						num2 = (short)463929360;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4C6;
				case 23:
					if (features.RadWideTransmitPowerLevelsBandSplitOverride_A41064.Value == 2)
					{
						num2 = (short)810024995;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6EC;
				case 24:
					if (global::ConstraintHelper.UtilityMack.Is7800MHzSupported())
					{
						num2 = (short)998047754;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_644;
				case 25:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF2;
					num2 = (short)1647640581;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					if (global::ConstraintHelper.UtilityMack.Is7800MHzSupported())
					{
						num2 = (short)719454236;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_349;
				case 27:
					num2 = (short)744882200;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.P800;
					num2 = (short)828178447;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.P900;
					num2 = (short)1291649074;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					return result;
				case 31:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF1;
					num2 = (short)272564230;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					if (global::ConstraintHelper.UtilityMack.IsUHF1RxFrequency(A_0))
					{
						num2 = (short)1574961153;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_195;
				case 33:
					num2 = (short)100859946;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					num2 = (short)1182728233;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 35:
					num2 = (short)1644298253;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 36:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.VHF;
					num2 = (short)1936326686;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 37:
					if (global::ConstraintHelper.UtilityMack.IsVHFSupported())
					{
						num2 = (short)1749811236;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_604;
				case 38:
					if (global::ConstraintHelper.UtilityMack.Is800MHzRxFrequency(A_0))
					{
						num2 = (short)1029636100;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_349;
				case 39:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF1;
					num2 = (short)315162644;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 40:
					if (!global::ConstraintHelper.UtilityMack.IsUHF1RxFrequency(A_0))
					{
						num2 = (short)1210384405;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_45B;
				case 41:
					if (global::ConstraintHelper.UtilityMack.IsUHF1Supported())
					{
						num2 = (short)888209439;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4C6;
				case 42:
					if (global::ConstraintHelper.UtilityMack.IsUHF2RxFrequency(A_0))
					{
						num2 = (short)1901002770;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6EC;
				case 43:
					return result;
				case 44:
					if (global::ConstraintHelper.UtilityMack.IsUHF2Supported())
					{
						num2 = (short)1987903495;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_28F;
				case 45:
					num2 = (short)735576072;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 46:
					if (features.RadWideTransmitPowerLevelsBandSplitOverride_A41064.Value == 1)
					{
						num2 = (short)760086530;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4C6;
				case 47:
					if (global::ConstraintHelper.UtilityMack.IsUHF2RxFrequency(A_0))
					{
						num2 = (short)209256451;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)899874816;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 48:
					return result;
				case 49:
					if (global::ConstraintHelper.UtilityMack.IsUHF2RxFrequency(A_0))
					{
						num2 = (short)222560309;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_28F;
				case 50:
					return result;
				case 51:
					if (global::ConstraintHelper.UtilityMack.IsUHF1Supported())
					{
						num2 = (short)2040725543;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_195;
				case 52:
					if (global::ConstraintHelper.UtilityMack.IsUHF2Supported())
					{
						num2 = (short)300548121;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6EC;
				case 53:
					num2 = (short)1154809857;
					if (num2 != 0)
					{
					}
					num2 = (short)1964245036;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_E8;
				IL_195:
				num2 = (short)218693681;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1D4:
				num2 = (short)578355212;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_28F:
				result = global::ConstraintHelper.UtilityMack.FrequencyBand.Unknown;
				num2 = (short)1939341360;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_349:
				num2 = (short)1727856654;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_384:
				result = global::ConstraintHelper.UtilityMack.FrequencyBand.Unknown;
				num2 = (short)251723795;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_45B:
				num2 = (short)1272381440;
				short num4 = num2;
				num2 = (short)777388078;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4C6:
				num2 = (short)2059010071;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_604:
				num2 = (short)426573864;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_644:
				num2 = (short)508559398;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_6EC:
				num2 = (short)701759520;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_E8:
			global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0];
			features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
			num2 = (short)1812463627;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00158ED8 File Offset: 0x001570D8
		private global::ConstraintHelper.UtilityMack.FrequencyBand a(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem A_0)
		{
			short num = (short)1143472128;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_158;
				}
				global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand;
				for (;;)
				{
					IL_29:
					int num3;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset astro25ChannelIDInnerRecset;
					int num4;
					int num5;
					bool flag;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					bool flag2;
					int num11;
					int num12;
					int num13;
					int num14;
					int num15;
					switch (num2)
					{
					case 0:
						num = (short)349896752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num3 = 1;
						goto IL_1561;
					case 2:
						return frequencyBand;
					case 3:
						frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.P900;
						num = (short)1673723970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return frequencyBand;
					case 5:
						num = (short)1632305169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)2079850504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_121D;
					case 8:
						if (global::ConstraintHelper.UtilityMack.IsUHF1Supported())
						{
							num = (short)229376070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A9;
					case 9:
						if (A_0.General.TrkSysGeneralSystemType_A9252.Value == 2)
						{
							num = (short)433455135;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						astro25ChannelIDInnerRecset = (A_0[10160].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset);
						num = (short)1238958141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.P800;
						num = (short)1035665447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.P700;
						num = (short)12320772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (num4 == 1)
						{
							num = (short)169017407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)436731969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.Unknown;
						num = (short)636682277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.P900;
						num = (short)162463746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (num5 == 1)
						{
							num = (short)715784254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)864419889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_244;
					case 17:
						num3 = 0;
						goto IL_1561;
					case 18:
						if (flag)
						{
							num = (short)1602682940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76C;
					case 19:
						frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF2;
						num = (short)30867484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_767;
					case 21:
						if (A_0.General.TrkSysGeneralTypeIIFrequencyBand_A12491.Value == 4)
						{
							num = (short)1918304312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return frequencyBand;
					case 22:
						if (A_0.General.TrkSysGeneralTypeIIFrequencyBand_A12491.Value == 0)
						{
							num = (short)2044264448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_834;
					case 23:
						try
						{
							num = (short)1497890816;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_346;
									}
									continue;
								case 1:
									goto IL_48E;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection;
									if (!global::ConstraintHelper.UtilityMack.IsNextToUHF1RxFrequency(astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value, astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value))
									{
										num = (short)2049114118;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_34B;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection;
									if (global::ConstraintHelper.UtilityMack.IsNextToUHF1RxFrequencyWithoutUHF2(astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value, astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value))
									{
										num = (short)723582984;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1183121415;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection;
									num = (short)1473314833;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
									if (features.RadWideTransmitPowerLevelsBandSplitOverride_A41064.Value == 2)
									{
										num = (short)1363148811;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_48E;
								}
								case 6:
									goto IL_5FB;
								case 7:
									num = (short)1760624649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_34B;
								case 9:
									goto IL_66B;
								case 10:
									num = (short)1717108738;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									num = (short)85786640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
									if (features.RadWideTransmitPowerLevelsBandSplitOverride_A41064.Value == 1)
									{
										num = (short)1642135562;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5FB;
								}
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection;
									if (!astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDIdentifierEnable_A8222.Value)
									{
										num = (short)1759051790;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 14:
									num = (short)841416709;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									num = (short)915341325;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection;
									if (!global::ConstraintHelper.UtilityMack.IsNextToUHF2RxFrequency(astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value, astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value))
									{
										num = (short)933756929;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_368;
								}
								case 17:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection;
									if (astro25ChannelIDInnerSection != null)
									{
										num = (short)86966287;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 18:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection;
									if (global::ConstraintHelper.UtilityMack.IsNextToUHF2RxFrequencyWithoutUHF1(astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value, astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value))
									{
										num = (short)1276379157;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_56D;
								}
								case 20:
									goto IL_56D;
								case 21:
									goto IL_368;
								}
								goto IL_346;
								IL_34B:
								int num6 = 1;
								num = (short)767819795;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_368:
								int num7 = 1;
								num = (short)766378004;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_48E:
								num = (short)1681588242;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_529:
								num = (short)294584324;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_346:
								goto IL_529;
								IL_56D:
								num = (short)631635980;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5FB:
								num = (short)1997275139;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_66B:
							goto IL_11E2;
						}
						finally
						{
							for (;;)
							{
								IL_670:
								num = (short)1145110529;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_72B;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_6A2;
										}
										continue;
									case 2:
									{
										num = (short)774085819;
										short num8 = num;
										num = (short)2081397947;
										switch ((num8 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_670;
										default:
											num = (short)904003584;
											if (num != 0)
											{
											}
											enumerator.Dispose();
											num = (short)1761607680;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									IL_6A2:
									if (enumerator == null)
									{
										goto IL_72D;
									}
									num = (short)1586561026;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_72B:
							IL_72D:;
						}
						goto IL_72E;
						IL_11E2:
						num = (short)1670774813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						return frequencyBand;
					case 25:
						goto IL_900;
					case 26:
						num = (short)943718443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (frequencyBand != global::ConstraintHelper.UtilityMack.FrequencyBand.UHF2)
						{
							num = (short)244842501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1028;
					case 28:
						return frequencyBand;
					case 29:
					{
						int num6;
						int num7;
						int num9;
						if (num6 + num7 + num9 >= 2)
						{
							num = (short)1420230663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)512884769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						return frequencyBand;
					case 31:
						num = (short)1981349960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (global::ConstraintHelper.UtilityMack.Is900MHzSupported())
						{
							num = (short)823459843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return frequencyBand;
					case 33:
					{
						int num6;
						if (num6 == 1)
						{
							num = (short)1767768121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1305673773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						if (A_0.General.TrkSysGeneralTypeIIFrequencyBand_A12491.Value == 2)
						{
							num = (short)1787494467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15B0;
					case 35:
						flag2 = false;
						goto IL_14AB;
					case 36:
						if (global::ConstraintHelper.UtilityMack.IsUHF2Supported())
						{
							num = (short)24576042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15B0;
					case 37:
						goto IL_1D1;
					case 38:
					{
						num = (short)1216610304;
						short num10 = num;
						if (num11 == 1)
						{
							num = (short)580583443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)520880201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						goto IL_1160;
					case 40:
						num = (short)763035689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (global::ConstraintHelper.UtilityMack.Is7800MHzSupported())
						{
							num = (short)411303946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_163C;
					case 42:
						frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF2;
						num = (short)1997930526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						num12 = 0;
						goto IL_1165;
					case 44:
						flag2 = global::ConstraintHelper.UtilityMack.IsUHF2Supported();
						goto IL_14AB;
					case 45:
					{
						int num7;
						if (num7 == 1)
						{
							num = (short)1007419456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_244;
					}
					case 46:
						return frequencyBand;
					case 47:
						return frequencyBand;
					case 48:
						if (global::ConstraintHelper.UtilityMack.IsVHFSupported())
						{
							num = (short)1642135611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_834;
					case 49:
						if (num13 == 1)
						{
							num = (short)72744974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return frequencyBand;
					case 50:
						num12 = 1;
						goto IL_1165;
					case 51:
						frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF1;
						num = (short)195493912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						if (num4 + num14 + num11 + num15 + num5 + num13 >= 2)
						{
							num = (short)100532237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1773535244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						goto IL_244;
					case 54:
						if (frequencyBand != global::ConstraintHelper.UtilityMack.FrequencyBand.UHF1)
						{
							num = (short)1894907930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72E;
					case 55:
						return frequencyBand;
					case 56:
						num = (short)695730208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF1;
						num = (short)385875984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						num = (short)1537212460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.VHF;
						num = (short)853540919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features;
						int num6 = 0;
						int num7 = 0;
						int num9 = 0;
						enumerator = astro25ChannelIDInnerRecset.GetEnumerator();
						num = (short)1599537175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 61:
						if (global::ConstraintHelper.UtilityMack.IsUHF1Supported())
						{
							num = (short)1738997818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1724121123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.P800;
						num = (short)1340473390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.VHF;
						num = (short)214302740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF2;
						num = (short)1493434421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						if (num14 == 1)
						{
							num = (short)1833828403;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1751973926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						return frequencyBand;
					case 67:
						num = (short)1512046628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						num = (short)891092993;
						if (num != 0)
						{
						}
						if (A_0.General.TrkSysGeneralTypeIIFrequencyBand_A12491.Value == 1)
						{
							num = (short)1874657286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A9;
					case 69:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1798832175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76C;
					case 70:
						frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF1;
						num = (short)610730009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						try
						{
							num = (short)1871314944;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_9F5;
									}
									continue;
								case 1:
									if (!flag)
									{
										num = (short)1784545315;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BC4;
								case 2:
									goto IL_FB3;
								case 3:
									num11 = 1;
									num = (short)2013528076;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)726401038;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num5 = 1;
									num = (short)2107637779;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection2;
									if (!astro25ChannelIDInnerSection2.TrkSysASTRO25ChannelIDIdentifierEnable_A8222.Value)
									{
										num = (short)1610022922;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									num = (short)1058930706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_B8A;
								case 10:
									num = (short)1317470229;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_E26;
								case 12:
									goto IL_A98;
								case 13:
									num = (short)1983709220;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									if (global::ConstraintHelper.UtilityMack.Is7800MHzSupported())
									{
										num = (short)1885995048;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E26;
								case 15:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1766260777;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection2 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection;
									num = (short)1860042780;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
									if (global::ConstraintHelper.UtilityMack.Is900MHzSupported())
									{
										num = (short)20512805;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 17:
									if (global::ConstraintHelper.UtilityMack.IsVHFSupported())
									{
										num = (short)558039079;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B8A;
								case 18:
									if (global::ConstraintHelper.UtilityMack.Is7800MHzSupported())
									{
										num = (short)1741946885;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C01;
								case 19:
									goto IL_C01;
								case 20:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection2;
									if (global::ConstraintHelper.UtilityMack.IsNextTo800MHzRxFrequency(astro25ChannelIDInnerSection2.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value, astro25ChannelIDInnerSection2.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value))
									{
										num = (short)694812680;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C01;
								}
								case 21:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection2;
									if (global::ConstraintHelper.UtilityMack.IsNextToVHFRxFrequency(astro25ChannelIDInnerSection2.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value, astro25ChannelIDInnerSection2.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value))
									{
										num = (short)795869209;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B8A;
								}
								case 22:
									num14 = 1;
									num = (short)260374561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection2;
									if (global::ConstraintHelper.UtilityMack.IsNextTo700MHzRxFrequency(astro25ChannelIDInnerSection2.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value, astro25ChannelIDInnerSection2.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value))
									{
										num = (short)819331076;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E26;
								}
								case 24:
									if (!flag)
									{
										num = (short)1452081165;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A98;
								case 25:
									num = (short)356450321;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									if (global::ConstraintHelper.UtilityMack.IsUHF1Supported())
									{
										num = (short)936837142;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BC4;
								case 27:
									if (global::ConstraintHelper.UtilityMack.IsUHF2Supported())
									{
										num = (short)1944125443;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A98;
								case 28:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection2;
									if (astro25ChannelIDInnerSection2 != null)
									{
										num = (short)1349845021;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 29:
									num = (short)1256259591;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
									num = (short)870973467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection2;
									if (global::ConstraintHelper.UtilityMack.IsNextTo900MHzRxFrequency(astro25ChannelIDInnerSection2.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value, astro25ChannelIDInnerSection2.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value))
									{
										num = (short)1170735136;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 32:
									num = (short)226951184;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
									goto IL_BC4;
								case 34:
									num = (short)1325989914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 35:
									num = (short)326041638;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection2;
									if (global::ConstraintHelper.UtilityMack.IsNextToUHF2RxFrequency(astro25ChannelIDInnerSection2.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value, astro25ChannelIDInnerSection2.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value))
									{
										num = (short)54198302;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A98;
								}
								case 37:
									num13 = 1;
									num = (short)1407647750;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 38:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection2;
									if (global::ConstraintHelper.UtilityMack.IsNextToUHF1RxFrequency(astro25ChannelIDInnerSection2.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value, astro25ChannelIDInnerSection2.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value))
									{
										num = (short)997916706;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BC4;
								}
								case 39:
									num4 = 1;
									num = (short)1458962441;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 40:
									num15 = 1;
									num = (short)1122566155;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 41:
									num = (short)1090125826;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_9F5;
								IL_A98:
								num = (short)317063191;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B8A:
								num = (short)1270677505;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BC4:
								num = (short)1092419608;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C01:
								num = (short)1854079007;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C55:
								num = (short)704708623;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9F5:
								goto IL_C55;
								IL_E26:
								num = (short)784793620;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FB3:
							goto IL_12E0;
						}
						finally
						{
							num = (short)192675840;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_FEC;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1259012098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1025;
								}
								IL_FEC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1378091009;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1025:;
						}
						goto IL_1028;
						IL_12E0:
						num = (short)1894514740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						if (A_0.General.TrkSysGeneralTypeIIFrequencyBand_A12491.Value == 3)
						{
							num = (short)2052390952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_163C;
					case 73:
						if (num15 == 1)
						{
							num = (short)42926091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1971716111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_158;
					IL_244:
					num = (short)85983301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_72E:
					num = (short)56623154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_76C:
					num4 = 0;
					num = (short)1264123958;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A9:
					num = (short)804257826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_834:
					num = (short)180944964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1028:
					num = (short)1344798721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1165:
					num14 = num12;
					num = (short)1267073051;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14AB:
					flag = flag2;
					num = (short)266797074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1561:
					num11 = num3;
					num15 = 0;
					num5 = 0;
					num13 = 0;
					enumerator = astro25ChannelIDInnerRecset.GetEnumerator();
					num = (short)1823146055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15B0:
					num = (short)224985109;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_163C:
					num = (short)640614422;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1D1:
				return frequencyBand;
				IL_767:
				IL_900:
				IL_1160:
				return frequencyBand;
				IL_121D:
				frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.Unknown;
				return frequencyBand;
				IL_158:
				frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.Unknown;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0];
				num = (short)1678573577;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0015A604 File Offset: 0x00158804
		// Note: this type is marked as 'beforefieldinit'.
		static DvrsMsuDataSync()
		{
			int a_ = 10;
			short num = (short)1579025315;
			short num2 = num;
			num = (short)901841827;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1287847936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)458031105;
			if (num != 0)
			{
			}
			num = (short)1364787200;
			if (num != 0)
			{
			}
			global::SpecialFeatures.DVRSXML.DvrsMsuDataSync.a = new string[]
			{
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삌搜﶐ﲔ列", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8c잎힐", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88c잎힐ꊒ", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88c잎힐ꆒ", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("몌뾎ꆐ", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("떌뾎ꆐ", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뒌뾎ꆐ", a_)
			};
		}

		// Token: 0x04000809 RID: 2057
		private static string[] a;

		// Token: 0x0400080A RID: 2058
		private global::System.Xml.XmlDocument b;

		// Token: 0x0400080B RID: 2059
		private bool c;
	}
}
