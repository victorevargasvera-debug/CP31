using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Xml.Serialization;

namespace Motorola.CommonCPS.RadioManagement.ActivityBuilderLib
{
	// Token: 0x02000008 RID: 8
	public class WidgetsConstant
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002F6C File Offset: 0x0000116C
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000301C File Offset: 0x0000121C
		public static global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsDefine WD
		{
			get
			{
				short num = (short)1570504572;
				short num2 = num;
				num = (short)610598780;
				switch (num2 == num)
				{
				}
				num = (short)1798832128;
				short num3 = num;
				num = (short)1797718017;
				if (num != 0)
				{
				}
				num = (short)1365442560;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._wd;
			}
			set
			{
				short num = (short)1137794326;
				short num2 = num;
				num = (short)1666473238;
				switch (num2 == num)
				{
				}
				num = (short)1933901824;
				short num3 = num;
				num = (short)1119617025;
				if (num != 0)
				{
				}
				num = (short)1423245312;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._wd = value;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000030CC File Offset: 0x000012CC
		private static global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsDefine ReadWidgetsDefine()
		{
			int a_ = 3;
			short num = (short)1987051520;
			switch (num)
			{
			default:
			{
				string path = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟톡쎥캧쎩슫쮭麯쪱\ud9b3\udab5", a_);
				global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsDefine result = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsDefine();
				global::System.IO.FileStream fileStream = null;
				try
				{
					fileStream = new global::System.IO.FileStream(path, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.ReadWrite);
					global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsDefine));
					result = (global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsDefine)xmlSerializer.Deserialize(fileStream);
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				finally
				{
					num = (short)666632194;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_12C;
						case 1:
						{
							num = (short)1079296520;
							short num3 = num;
							num = (short)1330692616;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_155;
							default:
								num = (short)469958656;
								if (num != 0)
								{
								}
								fileStream.Close();
								num = (short)1512701952;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_A4;
							}
							continue;
						}
						IL_A4:
						if (fileStream == null)
						{
							goto IL_155;
						}
						num = (short)554172417;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_12C:
					num = (short)1926627329;
					if (num != 0)
					{
					}
					IL_155:;
				}
				num = (short)1525612544;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003278 File Offset: 0x00001478
		public static global::System.Windows.Controls.Canvas GetItemDefatulContentByTypeSize(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType itemType, int _XSpan, int _YSpan)
		{
			global::System.Windows.Controls.Canvas result;
			short num;
			for (;;)
			{
				result = null;
				try
				{
					string itemDefaultXamlFileByTypeSize = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant.GetItemDefaultXamlFileByTypeSize(itemType, _XSpan, _YSpan);
					result = new global::System.Windows.Controls.Canvas();
					global::System.IO.FileStream stream = new global::System.IO.FileStream(itemDefaultXamlFileByTypeSize, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					result = (global::System.Windows.Markup.XamlReader.Load(stream) as global::System.Windows.Controls.Canvas);
				}
				catch (global::System.Exception)
				{
				}
				num = (short)1162523876;
				short num2 = num;
				num = (short)1512223972;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_94;
				}
				break;
			}
			num = (short)1946353664;
			short num3 = num;
			IL_94:
			num = (short)1772683265;
			if (num != 0)
			{
			}
			num = (short)1972371456;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003368 File Offset: 0x00001568
		public static global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityType GetActivityTypeByString(string activityType)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_7F;
			}
			short num;
			int num2;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityType result;
			for (;;)
			{
				IL_13:
				num = (short)588775425;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					num = (short)1122828297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return result;
				case 2:
				{
					if (!(activityType == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﮑ聯ﾛ얟욡", a_)))
					{
						num = (short)268566535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)731709440;
					short num3 = num;
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityType.AT_Dispatched;
					num = (short)1283260426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (!(activityType == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﶗ", a_)))
					{
						num = (short)1935343627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityType.AT_Aware;
					num = (short)1175650317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1D8;
				case 5:
					if (!(activityType == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﾏﲑ쮓ﮗﾙﮝ", a_)))
					{
						num = (short)515899406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityType.AT_Onsence;
					num = (short)2063007752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_E7;
				case 7:
					num = (short)1855979521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_16D;
				case 9:
					if (!(activityType == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("ﾑﾗﾙﶝ\ud99f", a_)))
					{
						num = (short)1719468047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityType.AT_Emergency;
					num = (short)247005190;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)207765965;
					short num4 = num;
					num = (short)1285505485;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C8;
					default:
						goto IL_256;
					}
					break;
				}
				case 11:
					goto IL_C8;
				case 12:
					if (!(activityType == global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("﶑煉잗ﶛ얟", a_)))
					{
						num = (short)927531008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityType.AT_Homebase;
					num = (short)1840644100;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_106;
				case 14:
					num = (short)1403191298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)190251013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_7F;
				IL_C8:
				num = (short)1401880588;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E7:
			IL_106:
			IL_16D:
			IL_1D8:
			return result;
			IL_256:
			num = (short)1920270336;
			if (num != 0)
			{
			}
			return result;
			IL_7F:
			result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityType.AT_Aware;
			num = (short)65273859;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003698 File Offset: 0x00001898
		public static string GetDefaultActivityType()
		{
			int a_ = 19;
			short num = (short)1257306931;
			short num2 = num;
			num = (short)1287584563;
			switch (num2 == num)
			{
			}
			num = (short)127205376;
			short num3 = num;
			num = (short)862191616;
			if (num != 0)
			{
			}
			num = (short)2007040001;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("쎡펣장\udaa7쾩", a_);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003758 File Offset: 0x00001958
		public static global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityPanelSetting GetAPSByActivityType(string at)
		{
			short num = (short)398129230;
			short num2 = num;
			num = (short)1843722318;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityPanelSetting result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1678508032;
				if (num != 0)
				{
				}
				result = null;
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityPanelSetting>.Enumerator enumerator = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant.WD.activities.GetEnumerator())
				{
					num = (short)989396995;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 1:
							goto IL_14B;
						case 2:
						{
							global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityPanelSetting activityPanelSetting;
							if (activityPanelSetting.State_id == at)
							{
								num = (short)937230340;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_9D;
							}
							continue;
						case 4:
						{
							global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityPanelSetting activityPanelSetting;
							result = activityPanelSetting;
							num = (short)2109538304;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)145620998;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ActivityPanelSetting activityPanelSetting = enumerator.Current;
							num = (short)290390018;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)527433729;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E0:
						num = (short)1934622725;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_9D:
						goto IL_E0;
					}
					IL_14B:;
				}
				break;
			}
			num = (short)1186660353;
			if (num != 0)
			{
			}
			num = (short)139526144;
			short num4 = num;
			return result;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003924 File Offset: 0x00001B24
		public static string GetActivityEventByActivityType(string at)
		{
			short num = (short)1925953326;
			short num2 = num;
			num = (short)1841215278;
			string result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)463732737;
				if (num != 0)
				{
				}
				num = (short)630915072;
				if (num != 0)
				{
				}
				result = "";
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.TransitionSetting>.Enumerator enumerator = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant.WD.transitionlist.GetEnumerator())
				{
					num = (short)1122304003;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 1:
							goto IL_17F;
						case 2:
						{
							global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.TransitionSetting transitionSetting;
							if (transitionSetting.Target == at)
							{
								num = (short)388956164;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_CA;
							}
							continue;
						case 4:
						{
							global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.TransitionSetting transitionSetting;
							result = transitionSetting._Event;
							num = (short)955056128;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1679753222;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.TransitionSetting transitionSetting = enumerator.Current;
							num = (short)1379270658;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)1744437249;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_10D:
						num = (short)2113208325;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_CA:
						goto IL_10D;
					}
					IL_17F:;
				}
				break;
			}
			num = (short)64946176;
			short num4 = num;
			return result;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003AFC File Offset: 0x00001CFC
		public static string GetItemDefaultXamlFileByTypeSize(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType itemType, int _XSpan, int _YSpan)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_F1;
			}
			int num;
			string result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					goto IL_221;
				case 2:
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭톯슱쒳\udfb5횷\uddb9誽뢿뻅꧇Ꟊꃋ", a_);
					num2 = (short)1588264973;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
					return result;
				case 5:
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫춭톯\udeb1톳\ud8b5\udcb7\udbb9캻뫁냇ꯉꇋꋍ", a_);
					num2 = (short)338231315;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (_YSpan == 3)
					{
						num2 = (short)451018757;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2023817236;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					return result;
				case 8:
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭햯솱잳ힵ\udfb7펹튻\ud9bd龿볃닉귋ꏍ볏", a_);
					num2 = (short)354418739;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					return result;
				case 10:
					return result;
				case 11:
					goto IL_2B6;
				case 12:
					goto IL_1A0;
				case 13:
					return result;
				case 14:
					num2 = (short)865861661;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (_YSpan >= 6)
					{
						num2 = (short)1469055025;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫춭톯\udeb1톳\ud8b5\udcb7\udbb9캻뫁냇ꯉꇋꋍ", a_);
					num2 = (short)1948909593;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (_YSpan == 4)
					{
						num2 = (short)847904802;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1124007977;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					return result;
				case 18:
					return result;
				case 19:
					return result;
				case 20:
					if (_YSpan == 4)
					{
						num2 = (short)1273692208;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)257818664;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					if (_YSpan == 3)
					{
						num2 = (short)1633419310;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2091778087;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					goto IL_24C;
				case 23:
					return result;
				case 24:
					return result;
				case 25:
					goto IL_30C;
				case 26:
					goto IL_1CB;
				case 27:
					return result;
				case 28:
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭톯슱쒳\udfb5횷\uddb9誽뢿뻅꧇Ꟊꃋ", a_);
					num2 = (short)344326187;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					return result;
				case 30:
					if (_YSpan >= 6)
					{
						num2 = (short)509476909;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭톯슱쒳\udfb5횷\uddb9誽뢿뻅꧇Ꟊꃋ", a_);
					num2 = (short)488898592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					goto IL_1F6;
				case 32:
					goto IL_2E1;
				case 33:
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭햯솱잳ힵ\udfb7펹튻\ud9bd龿볃닉귋ꏍ볏", a_);
					num2 = (short)754647063;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭햯솱잳ힵ\udfb7펹튻\ud9bd龿볃닉귋ꏍ볏", a_);
					num2 = (short)1882652699;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 35:
					return result;
				case 36:
					return result;
				case 37:
					if (_YSpan >= 6)
					{
						num2 = (short)1728053256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭햯솱잳ힵ\udfb7펹튻\ud9bd龿볃닉귋ꏍ볏", a_);
					num2 = (short)781189130;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 38:
					if (_YSpan == 5)
					{
						num2 = (short)1901527042;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)632029214;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 39:
					if (_YSpan == 4)
					{
						num2 = (short)1463615516;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1395327014;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 40:
					if (_YSpan == 5)
					{
						num2 = (short)1370488832;
						short num3 = num2;
						num2 = (short)1689190447;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1438973967;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 41:
					if (_YSpan == 5)
					{
						num2 = (short)1488977964;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)136773669;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 42:
					return result;
				case 43:
					return result;
				case 44:
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭햯솱잳ힵ\udfb7펹튻\ud9bd龿볃닉귋ꏍ볏", a_);
					num2 = (short)1234042892;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 45:
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭톯슱쒳\udfb5횷\uddb9誽뢿뻅꧇Ꟊꃋ", a_);
					num2 = (short)1100349440;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 46:
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭톯슱쒳\udfb5횷\uddb9誽뢿뻅꧇Ꟊꃋ", a_);
					num2 = (short)1581383715;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 47:
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫춭톯\udeb1톳\ud8b5\udcb7\udbb9캻뫁냇ꯉꇋꋍ", a_);
					num2 = (short)1370750980;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 48:
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫춭톯\udeb1톳\ud8b5\udcb7\udbb9캻뫁냇ꯉꇋꋍ", a_);
					num2 = (short)859439126;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 49:
					result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫춭톯\udeb1톳\ud8b5\udcb7\udbb9캻뫁냇ꯉꇋꋍ", a_);
					num2 = (short)1607073823;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 50:
					switch (itemType)
					{
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyStatus:
						result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫\uddad쒯펱삳쎵쮷袻욽볃Ʂꗇꛉ", a_);
						num2 = (short)1942355971;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wQuery:
						result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫\udfad얯ힱ욳쾵躹쒻辽뫁ꗃꯅ꓇", a_);
						num2 = (short)453443595;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyIncident:
						result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭즯\udbb1\udab3햵톷\udeb9\ud9bb킽뒿鷁뻅難듋꿍뷏뻑", a_);
						num2 = (short)1661992969;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wStatusMonitor:
						result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫\uddad쒯펱삳쎵쮷ힹ펻킽ꦿ뛁ꯃ듅韇ﻉ듋鬒ﻏ꫑뗓믕듗", a_);
						num2 = (short)346816548;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wRadio:
						result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫\udcad톯횱\uddb3\ud9b5躹쒻辽뫁ꗃꯅ꓇", a_);
						num2 = (short)955514922;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wSearch:
						result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫\uddad햯펱욳햵킷袻욽볃Ʂꗇꛉ", a_);
						num2 = (short)343867409;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingSimple:
						result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭톯슱쒳\udfb5횷\uddb9誽뢿뻅꧇Ꟊꃋ", a_);
						num2 = (short)215613466;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingAdv:
					{
						num2 = (short)2110645895;
						short num4 = num2;
						num2 = (short)811525767;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
							num2 = (short)1922891776;
							if (num2 != 0)
							{
							}
							num2 = (short)1726349333;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingSimple:
						result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭햯솱잳ힵ\udfb7펹튻\ud9bd뇁귃ꯅ룇ꛉ꧋重꫑ꃗ믙뇛닝", a_);
						num2 = (short)1024720903;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingAdv:
						num2 = (short)1448476725;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarSimple:
						result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫춭톯\udeb1톳\ud8b5\udcb7\udbb9캻鎽뎿ꯁ꧃뛅꓇꿉鏋鬒꣏䀘껕맗럙냛", a_);
						num2 = (short)87359540;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarAdv:
						num2 = (short)202768390;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyApps:
						result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭즯펱쒳욵躹쒻辽뫁ꗃꯅ꓇", a_);
						num2 = (short)251920385;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMapNoType:
						result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭톯슱쒳\udfb5횷\uddb9誽뢿뻅꧇Ꟊꃋ", a_);
						num2 = (short)1198391314;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCoreApp:
						result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫춭\udfaf삱톳ힵ좷쪹誽뢿뻅꧇Ꟊꃋ", a_);
						num2 = (short)1498939416;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)1077739534;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 51:
					return result;
				case 52:
					return result;
				case 53:
					if (_YSpan == 3)
					{
						num2 = (short)1431306273;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)746586128;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_F1;
			}
			IL_1A0:
			IL_1CB:
			IL_1F6:
			IL_221:
			IL_24C:
			IL_2B6:
			IL_2E1:
			return result;
			IL_30C:
			num2 = (short)1199177729;
			if (num2 != 0)
			{
			}
			return result;
			IL_F1:
			result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("벑뮓솕ﺙﮛﮝ풟킣쎥얧\ud9a9莫쎭톯슱쒳\udfb5횷\uddb9誽뢿뻅꧇Ꟊꃋ", a_);
			num2 = (short)583401522;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00004498 File Offset: 0x00002698
		public static global::System.Windows.Size GetItemDefaultSizeByType(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType itemType)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::System.Windows.Size result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_213;
				case 1:
					goto IL_1CA;
				case 2:
					num2 = (short)701169667;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_198;
				case 4:
				{
					num2 = (short)387904242;
					short num3 = num2;
					num2 = (short)597291762;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19D;
					default:
						goto IL_277;
					}
					break;
				}
				case 5:
					goto IL_122;
				case 6:
					goto IL_17B;
				case 7:
					switch (itemType)
					{
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.sShortcut:
						result.Height = 1.0 * global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultCellSize;
						result.Width = 1.0 * global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultCellSize;
						num2 = (short)2092040192;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyStatus:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wQuery:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wRadio:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wSearch:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingSimple:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingSimple:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyApps:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMapNoType:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCoreApp:
						result.Height = 1.0 * global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultCellSize;
						num2 = (short)405471236;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyIncident:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarSimple:
						result.Height = 2.0 * global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultCellSize;
						num2 = (short)374341637;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wStatusMonitor:
						goto IL_19D;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingAdv:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingAdv:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarAdv:
						num2 = (short)1331560449;
						if (num2 != 0)
						{
						}
						result.Height = 3.0 * global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultCellSize;
						num2 = (short)983236614;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)893124610;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				goto IL_30;
				IL_19D:
				result.Height = 4.0 * global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultCellSize;
				num2 = (short)1865023489;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_122:
			IL_17B:
			IL_198:
			IL_1CA:
			IL_213:
			return result;
			IL_277:
			num2 = (short)652738560;
			if (num2 != 0)
			{
			}
			return result;
			IL_30:
			num2 = (short)1776943104;
			short num4 = num2;
			result = default(global::System.Windows.Size);
			result.Width = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultItemWidth;
			result.Height = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultCellSize;
			num2 = (short)1640824839;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00004738 File Offset: 0x00002938
		public static bool WidgetCouldResize(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType itemType)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_AE;
				case 1:
				{
					num2 = (short)2109145088;
					short num3 = num2;
					num2 = (short)440632175;
					short num4 = num2;
					num2 = (short)38044527;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_38;
					default:
						goto IL_128;
					}
					break;
				}
				case 2:
					num2 = (short)907280385;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_38;
				}
				goto IL_20;
				IL_38:
				num2 = (short)428605441;
				if (num2 != 0)
				{
				}
				switch (itemType)
				{
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingAdv:
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingAdv:
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarAdv:
					result = true;
					num2 = (short)662503424;
					num = (int)((global::System.IntPtr)num2);
					break;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingSimple:
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarSimple:
					return result;
				default:
					num2 = (short)1774977026;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			IL_AE:
			return result;
			IL_128:
			num2 = (short)1328414720;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			result = false;
			num2 = (short)1194655747;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00004888 File Offset: 0x00002A88
		public static double WidgetCouldResizeMinHeight(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType itemType)
		{
			switch (0)
			{
			case 0:
				goto IL_6C;
			}
			short num;
			int num3;
			double result;
			for (;;)
			{
				IL_0A:
				num = (short)433465013;
				short num2 = num;
				num = (short)1040197301;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1756758016;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_10B;
					case 1:
						goto IL_125;
					case 2:
						goto IL_86;
					case 3:
						num = (short)276496385;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C;
				}
				IL_86:
				switch (itemType)
				{
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingAdv:
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingAdv:
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarAdv:
					result = 3.0 * global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultCellSize;
					num = (short)964689920;
					num3 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingSimple:
				case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarSimple:
					return result;
				default:
					num = (short)1226375169;
					if (num != 0)
					{
					}
					num = (short)320864259;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_10B:
			return result;
			IL_125:
			num = (short)1165164544;
			short num4 = num;
			return result;
			IL_6C:
			result = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultCellSize;
			num = (short)1200422914;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000049E8 File Offset: 0x00002BE8
		public static int GetSpanYByTypeSize(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType itemType, int YSpan)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			int result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)655364083;
					short num3 = num2;
					num2 = (short)807735283;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_20E;
					default:
						num2 = (short)1794244608;
						if (num2 != 0)
						{
						}
						num2 = (short)532414470;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return result;
				case 2:
					num2 = (short)1693515777;
					if (num2 != 0)
					{
					}
					switch (itemType)
					{
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.sShortcut:
						result = 1;
						num2 = (short)167641089;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyStatus:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wQuery:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wRadio:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wSearch:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingSimple:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingSimple:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyApps:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCoreApp:
						result = 1;
						num2 = (short)1040646156;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyIncident:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarSimple:
						result = 2;
						num2 = (short)1383399435;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wStatusMonitor:
						goto IL_20E;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingAdv:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingAdv:
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarAdv:
						num2 = (short)359137284;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMapNoType:
						return result;
					default:
						num2 = (short)848822272;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 3:
					if (YSpan <= 6)
					{
						num2 = (short)1170931717;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F0;
				case 4:
					if (YSpan >= 3)
					{
						num2 = (short)7929865;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F0;
				case 5:
					result = YSpan;
					num2 = (short)1181810696;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return result;
				case 7:
					return result;
				case 8:
					return result;
				case 9:
					num2 = (short)1926037507;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					return result;
				case 11:
					goto IL_14A;
				case 12:
					return result;
				}
				goto IL_44;
				IL_1F0:
				result = 3;
				num2 = (short)91488266;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_20E:
				result = 4;
				num2 = (short)1079574535;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_14A:
			num2 = (short)1953890304;
			short num4 = num2;
			return result;
			IL_44:
			result = 1;
			num2 = (short)334954498;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00004CA4 File Offset: 0x00002EA4
		// Note: this type is marked as 'beforefieldinit'.
		static WidgetsConstant()
		{
			short num = (short)129994829;
			short num2 = num;
			num = (short)2021888077;
			switch (num2 == num)
			{
			}
			num = (short)1284702208;
			if (num != 0)
			{
			}
			num = (short)1124073472;
			short num3 = num;
			num = (short)1152843777;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultItemWidth = 480.0;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultItemHeight = 120.0;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultCellSize = 120.0;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultMinWidth = 480.0;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._canvasMaxWidth = 480.0;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._defaultcanvasHeight = 720.0;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._maxColumn = 4;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._shortcutsMaxColumn = 3;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._homelayoutMaxRow = 6;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._couldDrop = true;
			global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant._wd = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsConstant.ReadWidgetsDefine();
		}

		// Token: 0x0400000A RID: 10
		public static double _defaultItemWidth;

		// Token: 0x0400000B RID: 11
		public static double _defaultItemHeight;

		// Token: 0x0400000C RID: 12
		public static double _defaultCellSize;

		// Token: 0x0400000D RID: 13
		public static double _defaultMinWidth;

		// Token: 0x0400000E RID: 14
		public static double _canvasMaxWidth;

		// Token: 0x0400000F RID: 15
		public static double _defaultcanvasHeight;

		// Token: 0x04000010 RID: 16
		public static int _maxColumn;

		// Token: 0x04000011 RID: 17
		public static int _shortcutsMaxColumn;

		// Token: 0x04000012 RID: 18
		public static int _homelayoutMaxRow;

		// Token: 0x04000013 RID: 19
		public static bool _couldDrop;

		// Token: 0x04000014 RID: 20
		private static global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetsDefine _wd;
	}
}
