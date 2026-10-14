using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace CommonUtility
{
	// Token: 0x02000035 RID: 53
	public static class FeatureNoticeUtility
	{
		// Token: 0x06000115 RID: 277 RVA: 0x0001CAD4 File Offset: 0x0001ACD4
		public static string UpdateFeatureNotice(string featureName, string featureNotice, string notice = "")
		{
			int a_ = 5;
			short num = (short)817496068;
			int num2 = (int)((global::System.IntPtr)num);
			string @string;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					byte[] bytes = global::System.Convert.FromBase64String(notice);
					@string = global::System.Text.Encoding.UTF8.GetString(bytes);
					num = (short)1093131985;
					short num3 = num;
					num = (short)1059118801;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1559166976;
						if (num != 0)
						{
						}
						num = (short)2021654531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
				{
					num = (short)47644672;
					short num4 = num;
					if (featureName == global::CommonUtility.VersionUtility.b("焵琷甹縻缽ిᵁC୅ᩇ祉ፋᵍᵏፑ", a_))
					{
						num = (short)1435828224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return notice;
				}
				case 2:
					return notice;
				case 3:
					if (global::CommonUtility.FeatureNoticeUtility.a(@string))
					{
						num = (short)1146355717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12F;
				case 4:
					num = (short)96403457;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 5:
					goto IL_128;
				}
				IL_6D:
				if (featureName == null)
				{
					num = (short)1051066370;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)417792001;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return notice;
			IL_128:
			return global::CommonUtility.FeatureNoticeUtility.a(featureNotice, @string);
			IL_12F:
			return string.Empty;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0001CC8C File Offset: 0x0001AE8C
		public static bool GetLatestNoticeValueFromBase64Str(string base64LicenceNotice, out byte returnVal)
		{
			short num = (short)521005361;
			short num2 = num;
			num = (short)1708976433;
			switch (num2 == num)
			{
			}
			num = (short)1506541568;
			short num3 = num;
			num = (short)748617728;
			if (num != 0)
			{
			}
			num = (short)53542913;
			if (num != 0)
			{
			}
			byte[] bytes = global::System.Convert.FromBase64String(base64LicenceNotice);
			return global::CommonUtility.FeatureNoticeUtility.GetLatestNoticeValue(global::System.Text.Encoding.UTF8.GetString(bytes), out returnVal);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0001CD50 File Offset: 0x0001AF50
		public static bool GetLatestNoticeValue(string licenceNotice, out byte returnVal)
		{
			int a_ = 11;
			short num = (short)453378048;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5C;
				}
				global::Newtonsoft.Json.Linq.JObject jobject;
				string text;
				bool result;
				for (;;)
				{
					IL_31:
					byte[] array;
					byte b;
					global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_36B;
					case 1:
						goto IL_2D2;
					case 2:
						if (jobject.SelectToken(global::CommonUtility.VersionUtility.b("漻猽Ŀㅁ", a_)) != null)
						{
							num = (short)104988673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_401;
					case 3:
						returnVal = byte.Parse(text);
						result = true;
						num = (short)1687027718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1330511880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						try
						{
							num = (short)1836843013;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1576927233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_20E;
								case 2:
								{
									global::Newtonsoft.Json.Linq.JToken jtoken;
									array[(int)b] = byte.Parse((string)jtoken.SelectToken(global::CommonUtility.VersionUtility.b("漻猽Ŀ", a_)));
									b += 1;
									result = true;
									num = (short)1357447171;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Newtonsoft.Json.Linq.JToken jtoken;
									if (global::CommonUtility.FeatureNoticeUtility.a(jtoken.ToString()))
									{
										num = (short)591265794;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_126;
									}
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)629211136;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Newtonsoft.Json.Linq.JToken jtoken = enumerator.Current;
									num = (short)161677316;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1BA:
								num = (short)81657862;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_126:
								goto IL_1BA;
							}
							IL_20E:
							goto IL_345;
						}
						finally
						{
							num = (short)1986199553;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2CF;
								case 1:
									goto IL_229;
								case 2:
								{
									num = (short)53095409;
									short num3 = num;
									num = (short)996944881;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_229;
									default:
										num = (short)823918592;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)775946240;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_246;
								IL_229:
								switch (0)
								{
								case 0:
									IL_246:
									if (enumerator == null)
									{
										goto IL_2D1;
									}
									num = (short)945487874;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_2CF:
							IL_2D1:;
						}
						goto IL_2D2;
						IL_345:
						global::System.Array.Sort<byte>(array);
						returnVal = array[(int)(b - 1)];
						num = (short)1335427072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_340;
					case 7:
						if (text != null)
						{
							num = (short)351272964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1058537474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (global::CommonUtility.FeatureNoticeUtility.a(licenceNotice))
						{
							num = (short)1261174787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_401;
					}
					goto IL_5C;
					IL_2D2:
					global::Newtonsoft.Json.Linq.JArray jarray = (global::Newtonsoft.Json.Linq.JArray)jobject.SelectToken(global::CommonUtility.VersionUtility.b("漻猽Ŀㅁ", a_));
					array = new byte[jarray.Count];
					b = 0;
					enumerator = jarray.GetEnumerator();
					num = (short)428670981;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_340:
				IL_36B:
				IL_401:
				num = (short)1416560640;
				short num4 = num;
				return result;
				IL_5C:
				num = (short)2119434241;
				if (num != 0)
				{
				}
				result = false;
				returnVal = 0;
				jobject = global::Newtonsoft.Json.Linq.JObject.Parse(licenceNotice);
				text = (string)jobject.SelectToken(global::CommonUtility.VersionUtility.b("漻猽Ŀ", a_));
				num = (short)82575367;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0001D1A4 File Offset: 0x0001B3A4
		private static bool a(string A_0)
		{
			int a_ = 3;
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex(global::CommonUtility.VersionUtility.b("樳樵䌷昹伻ᐽ栿恁㡃慅慇᥉ŋཌྷ硏灑⡓煕煗ٙ⽛瑝婟㹡ᝣ䱥䁧䡩ၫ䥭奯䵱屳䥵䑷౹ᵻች몃\uda85붋ꊍꎏ붓뺕몗뮛랝龟ﺡ힣貥힩", a_));
			bool result = false;
			short num;
			try
			{
				num = (short)211222533;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_143;
					case 1:
					{
						num = (short)1490339247;
						short num3 = num;
						num = (short)1366410671;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B1;
						default:
							goto IL_B9;
						}
						break;
					}
					case 2:
						num = (short)178716679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						uint num4;
						if (num4 >= 1U)
						{
							num = (short)2109865986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FC;
					}
					case 4:
						goto IL_1C9;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_65;
						}
						continue;
					case 6:
					{
						global::System.Text.RegularExpressions.MatchCollection matchCollection = regex.Matches(A_0);
						if (matchCollection.Count > 1)
						{
							goto Block_3;
						}
						uint num4 = uint.Parse(matchCollection[0].Groups[global::CommonUtility.VersionUtility.b("䈳圵吷伹夻", a_)].Value);
						num = (short)1291386883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						uint num4;
						if (num4 > 255U)
						{
							num = (short)1423310848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						goto IL_1B1;
					}
					}
					IL_65:
					if (!regex.IsMatch(A_0))
					{
						num = (short)1355218945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1245118470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B1:
					num = (short)1812332548;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B9:
				num = (short)1623392256;
				if (num != 0)
				{
				}
				throw new global::System.Exception();
				Block_3:
				throw new global::System.Exception();
				IL_FC:
				throw new global::System.Exception();
				IL_143:
				goto IL_FC;
				IL_1C9:;
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			num = (short)1577254913;
			if (num != 0)
			{
			}
			num = (short)1537277952;
			short num5 = num;
			return result;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0001D3F0 File Offset: 0x0001B5F0
		private static string a(string A_0, string A_1)
		{
			int a_ = 12;
			short num = (short)1601830912;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				string s;
				for (;;)
				{
					IL_30:
					bool flag;
					global::Newtonsoft.Json.Linq.JArray jarray2;
					global::Newtonsoft.Json.Linq.JObject jobject2;
					global::Newtonsoft.Json.Linq.JObject jobject3;
					global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator;
					string @string;
					switch (num2)
					{
					case 0:
					{
						global::Newtonsoft.Json.Linq.JObject jobject = new global::Newtonsoft.Json.Linq.JObject();
						jobject.Add(global::CommonUtility.VersionUtility.b("渼爾@あ", a_), new global::Newtonsoft.Json.Linq.JArray());
						global::Newtonsoft.Json.Linq.JArray jarray = (global::Newtonsoft.Json.Linq.JArray)jobject[global::CommonUtility.VersionUtility.b("渼爾@あ", a_)];
						global::Newtonsoft.Json.Linq.JObject item = global::Newtonsoft.Json.Linq.JObject.Parse(A_1);
						jarray.Add(item);
						s = jobject.ToString();
						num = (short)338755586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_366;
					case 2:
						goto IL_3CE;
					case 3:
						if (flag)
						{
							num = (short)1889861636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						jarray2.Add(jobject2);
						s = jobject3.ToString();
						num = (short)1173749766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						s = jobject3.ToString();
						num = (short)1285160961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_403;
					case 6:
						goto IL_3FE;
					case 7:
						try
						{
							num = (short)1684537348;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_20C;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)992804869;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1679425538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if ((string)enumerator.Current.SelectToken(global::CommonUtility.VersionUtility.b("渼爾@", a_)) == (string)jobject2[global::CommonUtility.VersionUtility.b("渼爾@", a_)])
									{
										num = (short)1642332163;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									flag = true;
									num = (short)641466374;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_123;
									}
									continue;
								case 5:
									num = (short)226164736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_125:
								num = (short)918224897;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_123:
								goto IL_125;
							}
							IL_20C:
							goto IL_A5;
						}
						finally
						{
							num = (short)595722241;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2CF;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_243;
									}
									continue;
								case 2:
								{
									num = (short)566027850;
									short num3 = num;
									num = (short)114878026;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)167968768;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)1394147328;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_243:
								if (enumerator == null)
								{
									break;
								}
								num = (short)304414722;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2CF:;
						}
						goto IL_2D2;
						IL_A5:
						num = (short)400556035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (string.IsNullOrEmpty(A_0))
						{
							num = (short)1742864384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D2;
					case 9:
						if (jarray2 == null)
						{
							num = (short)1020526602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_403;
					case 10:
					{
						num = (short)272957441;
						if (num != 0)
						{
						}
						global::Newtonsoft.Json.Linq.JObject jobject4 = new global::Newtonsoft.Json.Linq.JObject();
						jobject4.Add(global::CommonUtility.VersionUtility.b("渼爾@あ", a_), new global::Newtonsoft.Json.Linq.JArray());
						global::Newtonsoft.Json.Linq.JArray jarray3 = (global::Newtonsoft.Json.Linq.JArray)jobject4[global::CommonUtility.VersionUtility.b("渼爾@あ", a_)];
						global::Newtonsoft.Json.Linq.JObject item2 = global::Newtonsoft.Json.Linq.JObject.Parse(@string);
						jarray3.Add(item2);
						jobject3 = jobject4;
						jarray2 = (global::Newtonsoft.Json.Linq.JArray)jobject3[global::CommonUtility.VersionUtility.b("渼爾@あ", a_)];
						num = (short)103546885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_63;
					IL_2D2:
					byte[] bytes = global::System.Convert.FromBase64String(A_0);
					@string = global::System.Text.Encoding.UTF8.GetString(bytes);
					jobject3 = global::Newtonsoft.Json.Linq.JObject.Parse(@string);
					jarray2 = (global::Newtonsoft.Json.Linq.JArray)jobject3[global::CommonUtility.VersionUtility.b("渼爾@あ", a_)];
					num = (short)245563401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_403:
					jobject2 = global::Newtonsoft.Json.Linq.JObject.Parse(A_1);
					flag = false;
					enumerator = jarray2.GetEnumerator();
					num = (short)1402994695;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_366:
				IL_3CE:
				IL_3FE:
				num = (short)599982080;
				short num4 = num;
				return global::System.Convert.ToBase64String(global::System.Text.Encoding.UTF8.GetBytes(s));
				IL_63:
				s = string.Empty;
				num = (short)1557659656;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0400009F RID: 159
		private const string a = "SMAs";

		// Token: 0x040000A0 RID: 160
		private const string b = "SMA";

		// Token: 0x040000A1 RID: 161
		private const string c = "GLOBAL_DMR3_SMA";
	}
}
