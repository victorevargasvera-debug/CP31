using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase.Comparers;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Utility
{
	// Token: 0x0200001A RID: 26
	public static class Utility
	{
		// Token: 0x06000087 RID: 135 RVA: 0x0000C674 File Offset: 0x0000A874
		public static global::System.DateTime? UiToServerDateTime(global::System.DateTime? uiDateTime)
		{
			if (uiDateTime == null)
			{
				short num;
				for (;;)
				{
					num = (short)977797120;
					short num2 = num;
					num = (short)649938368;
					short num3 = num;
					num = (short)181487040;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6C;
					}
				}
				IL_6C:
				num = (short)1499987969;
				if (num != 0)
				{
				}
				num = (short)540409856;
				if (num != 0)
				{
				}
				return null;
			}
			return new global::System.DateTime?(uiDateTime.Value.ToUniversalTime());
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000C748 File Offset: 0x0000A948
		public static global::System.DateTime UiToServerDateTimeNoNull(global::System.DateTime? uiDateTime)
		{
			global::System.DateTime? dateTime = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.UiToServerDateTime(uiDateTime);
			if (dateTime == null)
			{
				short num;
				for (;;)
				{
					num = (short)323551232;
					short num2 = num;
					num = (short)486126241;
					short num3 = num;
					num = (short)2119545505;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_73;
					}
				}
				IL_73:
				num = (short)1706557441;
				if (num != 0)
				{
				}
				num = (short)1184694272;
				if (num != 0)
				{
				}
				return global::System.DateTime.MinValue;
			}
			return dateTime.Value;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000C814 File Offset: 0x0000AA14
		public static global::System.DateTime? ServerDateTimeToUI(global::System.DateTime? servrDateTime)
		{
			short num = (short)969474057;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.DateTime? result;
			global::System.DateTime d;
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
				{
					num = (short)1577254912;
					short num3 = num;
					num = (short)1937506307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_1B7;
				case 2:
					flag = (result.GetValueOrDefault() == d);
					goto IL_19B;
				case 3:
					flag = true;
					goto IL_19B;
				case 4:
				{
					num = (short)624652909;
					short num4 = num;
					num = (short)998011501;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D1;
					default:
						num = (short)512163840;
						if (num != 0)
						{
						}
						if (result == null)
						{
							num = (short)361234439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1653800968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					flag = false;
					goto IL_19B;
				case 6:
					return result;
				case 7:
					num = (short)1827995653;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1D1;
				case 9:
					num = (short)828702721;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					continue;
				case 10:
					result = null;
					num = (short)809762822;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_79:
				if (servrDateTime == null)
				{
					num = (short)2132344842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				result = servrDateTime;
				d = global::System.DateTime.MinValue;
				num = (short)385220612;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D1:
				if (result == null)
				{
					num = (short)1776943104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)189202434;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_19B:
				if (!flag)
				{
					goto IL_240;
				}
				num = (short)1424949249;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_1B7:
			result = null;
			return result;
			IL_240:
			d = servrDateTime.Value;
			return new global::System.DateTime?(d.ToLocalTime());
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000CA78 File Offset: 0x0000AC78
		public static string EnsureSubIPandPeerIPareSameSubNet(string sourceIP, string targetIP, out string error)
		{
			int a_ = 3;
			short num = (short)15597568;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_100;
				}
				string result;
				for (;;)
				{
					IL_31:
					byte[] array;
					byte[] array2;
					int num3;
					string[] array3;
					string[] array4;
					int num6;
					string[] array5;
					switch (num2)
					{
					case 0:
						result = targetIP;
						num = (short)542179330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (array[0] != array2[0])
						{
							num = (short)450494506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_390;
					case 2:
						return result;
					case 3:
					{
						if (num3 >= array3.Length)
						{
							num = (short)1176240153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string value = array3[num3];
						int num4;
						array2[num4++] = global::System.Convert.ToByte(value, global::System.Globalization.CultureInfo.CurrentCulture);
						num3++;
						num = (short)86704156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						num = (short)382829771;
						short num5 = num;
						num = (short)185566411;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_390;
						default:
							num = (short)455081984;
							if (num != 0)
							{
							}
							num = (short)2035351553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						if (sourceIP.Trim().Equals(targetIP.Trim()))
						{
							num = (short)856489995;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1586757653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)770768929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_555;
					case 8:
						goto IL_918;
					case 9:
						array2[3] = 1;
						num = (short)262144032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (array[0] <= 127)
						{
							num = (short)1991835652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1159004195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						error = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ݖ㱘㹚⽜ᙞㅠ㱢♤٦ݨ㑪⍬nհⱲ㡴ᙶ൸᡺ᕼ⁾튀캆\ud988", a_);
						result = "";
						num = (short)932380711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						result = "";
						array4 = sourceIP.Split(new char[]
						{
							'.'
						});
						num = (short)341049360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1202192432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_390;
					case 15:
					{
						num = (short)409796609;
						if (num != 0)
						{
						}
						if (num3 >= array3.Length)
						{
							num = (short)1952579603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string value2 = array3[num3];
						array[num6++] = global::System.Convert.ToByte(value2, global::System.Globalization.CultureInfo.CurrentCulture);
						num3++;
						num = (short)1529413676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (string.IsNullOrEmpty(targetIP))
						{
							num = (short)1989672982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_780;
					case 17:
						if (array[0] <= 191)
						{
							num = (short)1128857649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_294;
					case 18:
						num = (short)1566703633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						int num4 = 0;
						array3 = array5;
						num3 = 0;
						num = (short)881328162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						num = (short)1440415784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (result == "")
						{
							num = (short)1994194944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 22:
						targetIP = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("杖睘歚獜潞你卢", a_);
						num = (short)1219362843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (array[0] >= 192)
						{
							num = (short)58261517;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_390;
					case 24:
						goto IL_390;
					case 25:
						num = (short)4456484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (!string.IsNullOrEmpty(sourceIP))
						{
							num = (short)1009451020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 27:
						goto IL_780;
					case 28:
						goto IL_350;
					case 29:
						array2[3] = 253;
						num = (short)1170472997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_390;
					case 31:
						if (array[2] != array2[2])
						{
							num = (short)722468871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_390;
					case 32:
						goto IL_631;
					case 33:
						if (array[0] == array2[0])
						{
							num = (short)395509780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_555;
					case 34:
					{
						num = (short)1923284992;
						short num7 = num;
						goto IL_350;
					}
					case 35:
						if (array[0] >= 128)
						{
							num = (short)1851916306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_294;
					case 36:
						if (array2[3] == 255)
						{
							num = (short)2133262365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)745865261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_631;
					case 38:
						num = (short)1982988319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						return result;
					case 40:
						if (array[1] == array2[1])
						{
							num = (short)437846054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_555;
					case 41:
						num = (short)2073624622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						result = string.Concat(new string[]
						{
							array[0].ToString(),
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("祖", a_),
							array2[1].ToString(),
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("祖", a_),
							array2[2].ToString(),
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("祖", a_),
							array2[3].ToString()
						});
						num = (short)76677150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_4C8;
					case 44:
						goto IL_4C8;
					case 45:
						if (array2[3] == 0)
						{
							num = (short)593035273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_631;
					case 46:
						if (array[1] != array2[1])
						{
							num = (short)1525153800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_390;
					case 47:
						if (array[0] == array2[0])
						{
							num = (short)1125187625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_918;
					case 48:
						if (array[0] <= 223)
						{
							num = (short)14286854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_390;
					case 49:
						num = (short)948764719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_100;
					IL_294:
					num = (short)1594949655;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_350:
					num = (short)1845559299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_390:
					num = (short)148570117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C8:
					num = (short)160432143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_555:
					result = string.Concat(new string[]
					{
						array[0].ToString(),
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("祖", a_),
						array[1].ToString(),
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("祖", a_),
						array[2].ToString(),
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("祖", a_),
						array2[3].ToString()
					});
					num = (short)1028325400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_631:
					num = (short)1611923466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_780:
					array5 = targetIP.Split(new char[]
					{
						'.'
					});
					array = new byte[4];
					array2 = new byte[4];
					num6 = 0;
					array3 = array4;
					num3 = 0;
					num = (short)235470891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_918:
					result = string.Concat(new string[]
					{
						array[0].ToString(),
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("祖", a_),
						array[1].ToString(),
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("祖", a_),
						array2[2].ToString(),
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("祖", a_),
						array2[3].ToString()
					});
					num = (short)1497956366;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_100:
				result = "";
				error = string.Empty;
				num = (short)380633114;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000D4C4 File Offset: 0x0000B6C4
		public static void CopyObjectData(object source, object target, string excludedProperties, global::System.Reflection.BindingFlags memberAccess)
		{
			short num = (short)253231104;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				string[] source2;
				for (;;)
				{
					IL_28:
					int num4;
					global::System.Reflection.MemberInfo[] members;
					switch (num2)
					{
					case 0:
					{
						global::System.Reflection.MemberInfo memberInfo;
						if (memberInfo.MemberType == global::System.Reflection.MemberTypes.Field)
						{
							num = (short)241303571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1310863602;
						short num3 = num;
						num = (short)1555837170;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4B9;
						default:
							num = (short)1283522560;
							if (num != 0)
							{
							}
							num = (short)397869064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						global::System.Reflection.FieldInfo field;
						if (!(field == null))
						{
							goto IL_4B9;
						}
						goto IL_399;
					}
					case 2:
					{
						global::System.Reflection.MemberInfo memberInfo;
						global::System.Reflection.PropertyInfo propertyInfo = memberInfo as global::System.Reflection.PropertyInfo;
						string name;
						global::System.Reflection.PropertyInfo property = source.GetType().GetProperty(name, memberAccess);
						num = (short)604766212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						if (num4 >= members.Length)
						{
							num = (short)459800592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Reflection.MemberInfo memberInfo = members[num4];
						string name = memberInfo.Name;
						num = (short)1041367050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::System.Reflection.PropertyInfo property;
						if (!(property == null))
						{
							num = (short)1921712139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					}
					case 5:
					{
						string name;
						if (!source2.Contains(name))
						{
							num = (short)1189216271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					}
					case 6:
						num = (short)809041925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_399;
					case 8:
					{
						global::System.Reflection.MemberInfo memberInfo;
						if (memberInfo.MemberType == global::System.Reflection.MemberTypes.Property)
						{
							num = (short)420216834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					}
					case 9:
					{
						global::System.Reflection.PropertyInfo property;
						if (property.CanRead)
						{
							num = (short)197001240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					}
					case 10:
						if (!string.IsNullOrEmpty(excludedProperties))
						{
							num = (short)2067070982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_414;
					case 11:
						num = (short)1150943252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_2E8;
					case 13:
					{
						global::System.Reflection.FieldInfo field;
						object value = field.GetValue(source);
						global::System.Reflection.MemberInfo memberInfo;
						((global::System.Reflection.FieldInfo)memberInfo).SetValue(target, value);
						num = (short)789905425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						source2 = excludedProperties.Split(new char[]
						{
							','
						}, global::System.StringSplitOptions.RemoveEmptyEntries);
						num = (short)550109205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_414;
					case 16:
						return;
					case 17:
						goto IL_399;
					case 18:
						num = (short)1946681345;
						if (num != 0)
						{
						}
						if (!string.IsNullOrEmpty(excludedProperties))
						{
							num = (short)940769294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27B;
					case 19:
					{
						string name;
						global::System.Reflection.FieldInfo field = source.GetType().GetField(name);
						num = (short)1778843649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						if (propertyInfo.CanWrite)
						{
							num = (short)1569718272;
							short num5 = num;
							num = (short)1045102614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					}
					case 21:
						goto IL_27B;
					case 22:
						num = (short)927334409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_2E8;
					case 24:
					{
						global::System.Reflection.PropertyInfo property;
						object value2 = property.GetValue(source, null);
						global::System.Reflection.PropertyInfo propertyInfo;
						propertyInfo.SetValue(target, value2, null);
						num = (short)2089811975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_93;
					IL_27B:
					members = target.GetType().GetMembers(memberAccess);
					num4 = 0;
					num = (short)1835597836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E8:
					num = (short)1443692547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_399:
					num4++;
					num = (short)582483991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_414:
					num = (short)1550974976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B9:
					num = (short)1796341773;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_93:
				source2 = null;
				num = (short)1079509010;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000D9A8 File Offset: 0x0000BBA8
		public static void CopyObjectPublicProperties(object fromObject, object toObject, string excludedProperties = null)
		{
			short num = (short)1392443392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				string[] source;
				for (;;)
				{
					IL_28:
					int num3;
					global::System.Reflection.PropertyInfo[] properties;
					switch (num2)
					{
					case 0:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						if (propertyInfo.CanRead)
						{
							num = (short)1625358340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13F;
					}
					case 1:
						if (!string.IsNullOrEmpty(excludedProperties))
						{
							num = (short)892207112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6;
					case 2:
						goto IL_244;
					case 3:
					{
						num = (short)1541210113;
						if (num != 0)
						{
						}
						if (num3 >= properties.Length)
						{
							num = (short)1249902606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Reflection.PropertyInfo propertyInfo = properties[num3];
						num = (short)2032795649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)251592710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						propertyInfo.SetValue(toObject, propertyInfo.GetValue(fromObject, null), null);
						num = (short)1168506893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						if (propertyInfo.CanWrite)
						{
							num = (short)1356570430;
							short num4 = num;
							num = (short)1075945278;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_330;
							case 1:
								break;
							default:
							{
								num = (short)927989760;
								short num5 = num;
								break;
							}
							}
							num = (short)425328640;
							if (num != 0)
							{
							}
							num = (short)2087124997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13F;
					}
					case 7:
						goto IL_244;
					case 8:
						goto IL_330;
					case 9:
						if (!string.IsNullOrEmpty(excludedProperties))
						{
							num = (short)285540364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_114;
					case 10:
						goto IL_D6;
					case 11:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						if (!source.Contains(propertyInfo.Name))
						{
							num = (short)1850998794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13F;
					}
					case 12:
						source = excludedProperties.Split(new char[]
						{
							','
						}, global::System.StringSplitOptions.RemoveEmptyEntries);
						num = (short)596705295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_13F;
					case 14:
						return;
					case 15:
						goto IL_114;
					}
					goto IL_6F;
					IL_D6:
					num = (short)1488453632;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_114:
					properties = fromObject.GetType().GetProperties();
					num3 = 0;
					num = (short)1714552834;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13F:
					num3++;
					num = (short)1209008135;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_244:
					num = (short)1233190915;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_330:
					num = (short)1427439627;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_6F:
				source = null;
				num = (short)1175781385;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000DCEC File Offset: 0x0000BEEC
		public static bool CheckObjectPublicPropertiesMatch(object fromObject, object toObject, string excludedProperties = null)
		{
			int a_ = 19;
			short num = (short)723386368;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				string[] source;
				for (;;)
				{
					IL_31:
					int num4;
					global::System.Reflection.PropertyInfo[] properties;
					switch (num2)
					{
					case 0:
						goto IL_3CB;
					case 1:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						if (!source.Contains(propertyInfo.Name))
						{
							num = (short)2078867467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2;
					}
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_140;
							}
							global::System.Reflection.PropertyInfo propertyInfo;
							bool result;
							object value;
							object value2;
							for (;;)
							{
								IL_FD:
								bool flag;
								switch (num2)
								{
								case 0:
									num = (short)449249287;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_200;
								case 2:
									if (propertyInfo.PropertyType.Name == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㑦ᵨᥪѬŮᙰ", a_))
									{
										num = (short)477298691;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									result = false;
									num = (short)1248133125;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)1831337994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (value != null)
									{
										num = (short)1349320704;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18D;
								case 5:
									goto IL_393;
								case 6:
									flag = string.IsNullOrEmpty((string)value2);
									goto IL_2F9;
								case 7:
									if (value.Equals(value2))
									{
										num = (short)399376398;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18D;
								case 8:
									if (value != value2)
									{
										num = (short)305856524;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1E7;
								case 9:
									flag = false;
									goto IL_2F9;
								case 10:
									if (string.IsNullOrEmpty((string)value))
									{
										num = (short)1966473227;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1954283529;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									num = (short)1726808070;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									num = (short)600689637;
									short num3 = num;
									num = (short)570543077;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_18D;
									default:
										num = (short)33030144;
										if (num != 0)
										{
										}
										num = (short)1531510788;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									goto IL_315;
								case 14:
									goto IL_1E7;
								}
								goto IL_140;
								IL_18D:
								num = (short)42074114;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E7:
								num = (short)2122842113;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2F9:
								result = flag;
								num = (short)1242890253;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_200:
							goto IL_D2;
							IL_315:
							IL_393:
							return result;
							IL_140:
							value = propertyInfo.GetValue(fromObject, null);
							value2 = propertyInfo.GetValue(toObject, null);
							num = (short)1305608200;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_FD;
						}
						catch (global::System.Exception)
						{
							goto IL_D2;
						}
						goto IL_39E;
					case 3:
						return true;
					case 4:
						goto IL_3CB;
					case 5:
					{
						if (num4 >= properties.Length)
						{
							num = (short)264634371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1559035904;
						short num5 = num;
						global::System.Reflection.PropertyInfo propertyInfo = properties[num4];
						num = (short)2010382344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (!string.IsNullOrEmpty(excludedProperties))
						{
							num = (short)1098121226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39E;
					case 7:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						if (propertyInfo.CanRead)
						{
							num = (short)373161986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2;
					}
					case 8:
						if (!string.IsNullOrEmpty(excludedProperties))
						{
							num = (short)1028390921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4EA;
					case 9:
						num = (short)997982209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						source = excludedProperties.Split(new char[]
						{
							','
						}, global::System.StringSplitOptions.RemoveEmptyEntries);
						num = (short)565182476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_4EA;
					case 12:
						goto IL_39E;
					}
					goto IL_6C;
					IL_D2:
					num4++;
					num = (short)55312384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39E:
					properties = fromObject.GetType().GetProperties();
					num4 = 0;
					num = (short)205717508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CB:
					num = (short)428605445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4EA:
					num = (short)1523908615;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_6C:
				num = (short)332005377;
				if (num != 0)
				{
				}
				source = null;
				num = (short)1007091718;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000E244 File Offset: 0x0000C444
		public static global::System.Collections.Generic.IList<string> CheckObjectPublicPropertiesDifferent(object fromObject, object toObject, string excludedProperties = null)
		{
			short num = (short)1941045248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				global::System.Collections.Generic.List<string> list;
				string[] source;
				for (;;)
				{
					IL_27:
					int num3;
					global::System.Reflection.PropertyInfo[] array;
					switch (num2)
					{
					case 0:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						if (propertyInfo.CanRead)
						{
							num = (short)860880900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13A;
					}
					case 1:
					{
						if (num3 >= array.Length)
						{
							num = (short)1458372619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Reflection.PropertyInfo propertyInfo = array[num3];
						num = (short)2089615367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1417216008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_383;
					case 4:
						try
						{
							num = (short)380829702;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								object value;
								object value2;
								switch (num2)
								{
								case 0:
									goto IL_203;
								case 1:
									goto IL_378;
								case 2:
									goto IL_360;
								case 3:
									if (!value.Equals(value2))
									{
										num = (short)595394560;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_360;
								case 4:
									num = (short)1726283783;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)1812922371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1DB;
									}
									continue;
								case 7:
								{
									num = (short)71113584;
									short num4 = num;
									num = (short)1721441136;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)2082209792;
										if (num != 0)
										{
										}
										if (value == null)
										{
											goto IL_360;
										}
										break;
									}
									num = (short)10289157;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)2014117897;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_2D6;
								case 10:
									if (value == value2)
									{
										num = (short)1954480132;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_203;
								}
								IL_1DB:
								global::System.Reflection.PropertyInfo propertyInfo;
								if (propertyInfo.GetIndexParameters().Length != 0)
								{
									num = (short)1483210760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								value = propertyInfo.GetValue(fromObject, null);
								value2 = propertyInfo.GetValue(toObject, null);
								num = (short)1754595338;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_203:
								list.Add(propertyInfo.Name);
								num = (short)413925378;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_360:
								num = (short)1594621953;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2D6:
							IL_378:
							goto IL_13A;
						}
						catch (global::System.Exception)
						{
							goto IL_13A;
						}
						goto IL_383;
					case 5:
						goto IL_383;
					case 6:
						if (!string.IsNullOrEmpty(excludedProperties))
						{
							num = (short)1135149066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_109;
					case 7:
						num = (short)481034241;
						if (num != 0)
						{
						}
						if (!string.IsNullOrEmpty(excludedProperties))
						{
							num = (short)2121793538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9;
					case 8:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						if (!source.Contains(propertyInfo.Name))
						{
							num = (short)798949385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13A;
					}
					case 9:
						goto IL_C9;
					case 10:
						source = excludedProperties.Split(new char[]
						{
							','
						}, global::System.StringSplitOptions.RemoveEmptyEntries);
						num = (short)1333919756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						return list;
					case 12:
						goto IL_109;
					}
					goto IL_62;
					IL_C9:
					num = (short)651362304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_109:
					global::System.Reflection.PropertyInfo[] properties = fromObject.GetType().GetProperties();
					list = new global::System.Collections.Generic.List<string>();
					array = properties;
					num3 = 0;
					num = (short)398131205;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13A:
					num3++;
					num = (short)1166213123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_383:
					num = (short)1188429825;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_62:
				num = (short)700448768;
				short num5 = num;
				source = null;
				num = (short)295239686;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
		public static T Clone<T>(T d)
		{
			short num = (short)562860776;
			short num2 = num;
			num = (short)1092653800;
			switch (num2 == num)
			{
			}
			num = (short)1787363328;
			short num3 = num;
			num = (short)1662910465;
			if (num != 0)
			{
			}
			num = (short)6946816;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.a<T>(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.a(d));
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000E79C File Offset: 0x0000C99C
		public static global::System.Collections.Generic.IList<string> GetObjectPublicProperties(object fromObject, string excludedProperties = null)
		{
			short num = (short)1835270144;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)595525633;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8A;
				}
				string[] source;
				global::System.Collections.Generic.List<string> list;
				for (;;)
				{
					IL_4F:
					int num3;
					global::System.Reflection.PropertyInfo[] array;
					switch (num2)
					{
					case 0:
					{
						if (num3 >= array.Length)
						{
							num = (short)2046951432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Reflection.PropertyInfo propertyInfo = array[num3];
						num = (short)1961164805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)546766852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!string.IsNullOrEmpty(excludedProperties))
						{
							num = (short)1159397376;
							short num4 = num;
							num = (short)469172235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_134;
					case 3:
						goto IL_F6;
					case 4:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						if (!source.Contains(propertyInfo.Name))
						{
							num = (short)1522860035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_165;
					}
					case 5:
						if (!string.IsNullOrEmpty(excludedProperties))
						{
							num = (short)1076035585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F6;
					case 6:
						goto IL_2A4;
					case 7:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						if (propertyInfo.CanRead)
						{
							num = (short)1513553929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_165;
					}
					case 8:
						return list;
					case 9:
						goto IL_1B3;
						try
						{
							for (;;)
							{
								IL_1B3:
								num = (short)1647640578;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_224;
									case 1:
										goto IL_299;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_1E9;
										}
										continue;
									case 3:
										num = (short)1132789760;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1E9:
									global::System.Reflection.PropertyInfo propertyInfo;
									if (propertyInfo.GetIndexParameters().Length != 0)
									{
										num = (short)1219559427;
										num2 = (int)((global::System.IntPtr)num);
									}
									else
									{
										list.Add(propertyInfo.Name);
										num = (short)103481345;
										num2 = (int)((global::System.IntPtr)num);
									}
								}
								IL_224:
								num = (short)881199674;
								short num5 = num;
								num = (short)1919486522;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_259;
								}
							}
							IL_259:
							num = (short)1111883776;
							if (num != 0)
							{
							}
							IL_299:
							goto IL_165;
						}
						catch (global::System.Exception)
						{
							goto IL_165;
						}
						goto IL_2A4;
					case 10:
						goto IL_134;
					case 11:
						source = excludedProperties.Split(new char[]
						{
							','
						}, global::System.StringSplitOptions.RemoveEmptyEntries);
						num = (short)1048313866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_2A4;
					}
					goto IL_8A;
					IL_F6:
					num = (short)1479409671;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_134:
					global::System.Reflection.PropertyInfo[] properties = fromObject.GetType().GetProperties();
					list = new global::System.Collections.Generic.List<string>();
					array = properties;
					num3 = 0;
					num = (short)1030357004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_165:
					num3++;
					num = (short)1845690374;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A4:
					num = (short)1561919488;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_8A:
				source = null;
				num = (short)6881282;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000EB28 File Offset: 0x0000CD28
		private static byte[] a(object A_0)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			short num;
			byte[] result;
			try
			{
				num = (short)879755265;
				if (num != 0)
				{
				}
				new global::System.Runtime.Serialization.DataContractSerializer(A_0.GetType()).WriteObject(memoryStream, A_0);
				result = memoryStream.ToArray();
			}
			finally
			{
				num = (short)371261442;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)525043886;
						short num3 = num;
						num = (short)397379758;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_84;
						default:
							num = (short)2121400320;
							if (num != 0)
							{
							}
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)289603585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_104;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					}
					goto IL_7E;
					IL_84:
					num = (short)165937152;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E:
					if (memoryStream != null)
					{
						goto IL_84;
					}
					break;
				}
				IL_104:;
			}
			num = (short)553910272;
			short num4 = num;
			return result;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000EC78 File Offset: 0x0000CE78
		private static a a<a>(byte[] A_0)
		{
			short num = (short)1655308289;
			if (num != 0)
			{
			}
			num = (short)576913408;
			short num2 = num;
			global::System.IO.MemoryStream memoryStream = null;
			a result;
			try
			{
				memoryStream = new global::System.IO.MemoryStream(A_0);
				result = (a)((object)new global::System.Runtime.Serialization.DataContractSerializer(typeof(a)).ReadObject(memoryStream));
			}
			finally
			{
				num = (short)27328514;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						num = (short)483307521;
						short num4 = num;
						num = (short)1698017281;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B3;
						default:
							num = (short)1178796032;
							if (num != 0)
							{
							}
							memoryStream.Dispose();
							num = (short)1457913857;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_130;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_AD;
						}
						continue;
					}
					goto IL_AD;
					IL_B3:
					num = (short)359858176;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_AD:
					if (memoryStream != null)
					{
						goto IL_B3;
					}
					break;
				}
				IL_130:
				memoryStream = null;
			}
			return result;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000EDCC File Offset: 0x0000CFCC
		public static bool IPValidateHelper(string value, out string error)
		{
			short num = (short)1959067648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_FA;
				}
				byte[] array;
				int num3;
				string[] array2;
				int num6;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (array[1] == 0)
						{
							num = (short)560332814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D3;
					case 1:
						if (array[3] != 255)
						{
							num = (short)787021830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5AD;
					case 2:
						num = (short)82575391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_62D;
					case 4:
						if (array[3] != 0)
						{
							num = (short)98435089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_743;
					case 5:
					{
						byte b = array[0];
						num = (short)1943207965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_13C;
					case 7:
					{
						string text;
						byte b2;
						if (byte.TryParse(text, out b2))
						{
							num = (short)1209729051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B2;
					}
					case 8:
						num = (short)1215889428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_741;
					case 10:
						num = (short)321388588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_4ED;
					case 12:
						num = (short)238616606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						byte b;
						if (b == 128)
						{
							num = (short)473956389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62D;
					}
					case 14:
						num = (short)567607345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_5B6;
					case 16:
						if (array[3] == 255)
						{
							num = (short)1223426070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 17:
						num = (short)986841134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1964376080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						if (num3 >= array2.Length)
						{
							num = (short)1585446917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = array2[num3];
						num = (short)1115553799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						num = (short)239038247;
						short num4 = num;
						num = (short)257978151;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_283;
						default:
						{
							num = (short)1924988928;
							if (num != 0)
							{
							}
							num = (short)1058275328;
							short num5 = num;
							byte b;
							if (b != 127)
							{
								num = (short)1107755048;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6FA;
						}
						}
						break;
					}
					case 21:
						if (array[3] == 0)
						{
							num = (short)1149304875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 22:
						goto IL_85F;
					case 23:
						num = (short)521076737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)279642151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)958070818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (array[1] == 255)
						{
							num = (short)1933705218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 27:
					{
						string text;
						array[num6++] = global::System.Convert.ToByte(text, global::System.Globalization.CultureInfo.CurrentCulture);
						num = (short)1208418337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						goto IL_3CE;
					case 29:
					{
						byte b;
						if (b <= 223)
						{
							num = (short)1025507336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6FA;
					}
					case 30:
					{
						byte b;
						if (b == 192)
						{
							num = (short)697368586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B6;
					}
					case 31:
						if (array[2] == 255)
						{
							num = (short)1206517778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 32:
						if (array[2] == 255)
						{
							num = (short)1302003735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13C;
					case 33:
						num3++;
						num = (short)321191947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (array[3] != 0)
						{
							num = (short)258277424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_416;
					case 35:
						if (array[2] == 0)
						{
							num = (short)69402660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 36:
						num = (short)165085205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)1702690857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_4ED;
					case 39:
						if (array[2] != 0)
						{
							num = (short)378470415;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_743;
					case 40:
						num = (short)800981039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (array[1] != 0)
						{
							num = (short)244776963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5AD;
					case 42:
					{
						byte b;
						if (b >= 192)
						{
							num = (short)1568014348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2060058669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						goto IL_7AC;
					case 44:
						if (array[1] == 0)
						{
							num = (short)1992753176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B6;
					case 45:
					{
						byte b;
						if (b >= 128)
						{
							num = (short)1537278002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)151257088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
						if (array[3] == 255)
						{
							num = (short)1500119049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 47:
					{
						byte b;
						if (b == 0)
						{
							num = (short)1863516188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1994391594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						goto IL_3D3;
					case 49:
						goto IL_283;
					case 50:
						num = (short)566099981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FA;
					IL_13C:
					num = (short)1897594915;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_283:
					if (array[2] == 0)
					{
						num = (short)24969241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3D3:
					num = (short)605487130;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4ED:
					num = (short)1159266323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B6:
					num = (short)707657732;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_62D:
					num = (short)756285472;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3CE:
				goto IL_6FA;
				IL_416:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NotProperClassAFormat;
				return false;
				IL_5AD:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NotProperClassBFormat;
				return false;
				IL_6B2:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NotProperFormat;
				return false;
				IL_6FA:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.IPFirstPart_NotProperNumber;
				return false;
				IL_741:
				IL_743:
				num = (short)1648558081;
				if (num != 0)
				{
				}
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.IP_NotProperClassCFormat;
				return false;
				IL_7AC:
				goto IL_5AD;
				IL_85F:
				goto IL_416;
				IL_FA:
				string[] array3 = value.Split(new char[]
				{
					'.'
				});
				error = string.Empty;
				array = new byte[4];
				num6 = 0;
				array2 = array3;
				num3 = 0;
				num = (short)1002438694;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000F640 File Offset: 0x0000D840
		public static string StringToDBC(string sbcString)
		{
			short num = (short)950075395;
			int num2 = (int)((global::System.IntPtr)num);
			char[] array;
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					goto IL_17D;
				case 1:
					goto IL_1DD;
				case 2:
					array[num3] = ' ';
					num = (short)1610743808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 4:
					if (array[num3] == '\u3000')
					{
						num = (short)120193026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)749273098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_212;
				case 6:
				{
					array[num3] -= 'ﻠ';
					num = (short)1901868791;
					short num4 = num;
					num = (short)415119095;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17D;
					default:
						num = (short)511115264;
						if (num != 0)
						{
						}
						num = (short)956235784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					goto IL_1DD;
				case 8:
					goto IL_17D;
				case 9:
					if (num3 >= array.Length)
					{
						num = (short)1851392005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)511836164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)1530331136;
					short num5 = num;
					if (array[num3] > '＀')
					{
						num = (short)2115502093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17D;
				}
				case 11:
					if (array[num3] < '｟')
					{
						num = (short)1948057606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17D;
				case 12:
					goto IL_7C;
				case 13:
					num = (short)1287454731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5D:
				if (string.IsNullOrEmpty(sbcString))
				{
					num = (short)2044723212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				array = sbcString.ToCharArray();
				num3 = 0;
				num = (short)1749745665;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_17D:
				num3++;
				num = (short)1892941831;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1DD:
				num = (short)501022729;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7C:
			return null;
			IL_212:
			num = (short)1255866369;
			if (num != 0)
			{
			}
			return new string(array);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000F8F0 File Offset: 0x0000DAF0
		public static string GetKeyField(global::Motorola.CommonCPS.Server.EntityModel.Radio d)
		{
			short num = (short)1635188736;
			short num2 = num;
			num = (short)923379791;
			short num3 = num;
			num = (short)1709353039;
			switch (num3 == num)
			{
			}
			num = (short)1877803009;
			if (num != 0)
			{
			}
			num = (short)900071424;
			if (num != 0)
			{
			}
			return d.SerialNumber;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000F9A0 File Offset: 0x0000DBA0
		public static string GetDifferentIPValue(string updateIP, global::System.Collections.Generic.IList<string> referencedIPs)
		{
			int a_ = 12;
			short num = (short)1984823296;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A7;
				}
				global::System.Collections.Generic.IList<string> list2;
				int num8;
				for (;;)
				{
					IL_30:
					int num3;
					int num6;
					switch (num2)
					{
					case 0:
						goto IL_396;
					case 1:
					{
						global::System.Collections.Generic.IList<int> list;
						if (list.Count > 0)
						{
							num = (short)1746337798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return updateIP;
					}
					case 2:
					{
						bool flag = true;
						num = (short)1387331605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (num3 >= list2.Count)
						{
							num = (short)273612812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)469106708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::System.Collections.Generic.IList<int> list;
						int item;
						if (list.Contains(item))
						{
							num = (short)1520041985;
							if (num != 0)
							{
							}
							num = (short)77266967;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_216;
					}
					case 5:
						goto IL_776;
					case 6:
					{
						global::System.Collections.Generic.IList<int> list;
						string[] array;
						updateIP = string.Concat(new string[]
						{
							array[0],
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("也", a_),
							array[1],
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("也", a_),
							array[2],
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("也", a_),
							list[0].ToString()
						});
						num = (short)1781989391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						num = (short)1359413248;
						short num4 = num;
						global::System.Collections.Generic.IEnumerator<string> enumerator = referencedIPs.GetEnumerator();
						num = (short)1894514712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num3 = 0;
						num = (short)1679097856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_776;
					case 10:
						num = (short)708378628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_45E;
					case 12:
						num = (short)269221889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_216;
					case 14:
					{
						int num5;
						if (num5 >= 255)
						{
							num = (short)358154248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IList<int> list;
						list.Add(num5);
						num5++;
						num = (short)1108869129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						return updateIP;
					case 16:
						if (!string.IsNullOrEmpty(updateIP))
						{
							num = (short)706871303;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return updateIP;
					case 17:
						if (num6 >= list2.Count)
						{
							num = (short)1198981147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1858076691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_45E;
					case 19:
						if (updateIP.Equals(list2[num6]))
						{
							num = (short)361037826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_751;
					case 20:
					{
						int item;
						if (int.TryParse(list2[num3].Split(new char[]
						{
							'.'
						})[3], out item))
						{
							num = (short)700973066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_216;
					}
					case 21:
						goto IL_751;
					case 22:
						goto IL_396;
					case 23:
					{
						num = (short)431548898;
						short num7 = num;
						num = (short)196209122;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)193658880;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.IList<int> list;
							int item;
							list.Remove(item);
							num = (short)811728909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 24:
					{
						try
						{
							num = (short)893124612;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1669595141;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)1098514439;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									string text;
									if (!string.IsNullOrEmpty(text))
									{
										num = (short)341377024;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_557;
									}
									continue;
								case 5:
								{
									string text;
									if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsSameWebset(updateIP, text, ref num8))
									{
										num = (short)553844742;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									string text;
									list2.Add(text);
									num = (short)276037635;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_659;
								case 8:
								{
									global::System.Collections.Generic.IEnumerator<string> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)368508929;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = enumerator.Current;
									num = (short)300482562;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_600:
								num = (short)1434451976;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_557:
								goto IL_600;
							}
							IL_659:
							goto IL_1DD;
						}
						finally
						{
							num = (short)1897267200;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<string> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_691;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)366477314;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_6CA;
								}
								IL_691:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1909391361;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6CA:;
						}
						goto IL_6CD;
						IL_1DD:
						string[] array = updateIP.Split(new char[]
						{
							'.'
						});
						string text2 = array[3];
						bool flag = false;
						num6 = 0;
						num = (short)1328742418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						bool flag;
						if (flag)
						{
							num = (short)1809580058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return updateIP;
					}
					case 26:
					{
						string[] array;
						updateIP = string.Concat(new string[]
						{
							array[0],
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("也", a_),
							array[1],
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("也", a_),
							array[2],
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("也卡", a_)
						});
						global::System.Collections.Generic.IList<int> list = new global::System.Collections.Generic.List<int>();
						int num5 = 1;
						num = (short)1138098181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_6CD;
					}
					goto IL_A7;
					IL_216:
					num3++;
					num = (short)377421846;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_396:
					num = (short)860618755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45E:
					num = (short)634257425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6CD:
					num = (short)341180441;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_751:
					num6++;
					num = (short)1063714827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_776:
					num = (short)1251213326;
					num2 = (int)((global::System.IntPtr)num);
				}
				return updateIP;
				IL_A7:
				num8 = -1;
				new global::System.Collections.Generic.List<string>();
				list2 = new global::System.Collections.Generic.List<string>();
				num = (short)1101660176;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00010184 File Offset: 0x0000E384
		public static bool IsSameWebset(string ipA, string ipB, ref int ipClass)
		{
			short num = (short)481886208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B3;
				}
				int num3;
				string[] array;
				byte[] array2;
				int num4;
				bool result;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						if (num3 >= array.Length)
						{
							num = (short)70123550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string value = array[num3];
						array2[num4++] = global::System.Convert.ToByte(value, global::System.Globalization.CultureInfo.CurrentCulture);
						num3++;
						num = (short)1985675286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						result = true;
						ipClass = 2;
						num = (short)1792933894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)667531481;
						short num5 = num;
						num = (short)1124514009;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_581;
						default:
						{
							num = (short)507052033;
							if (num != 0)
							{
							}
							num = (short)1836843008;
							if (num != 0)
							{
							}
							if (num3 >= array.Length)
							{
								num = (short)1375272984;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string value2 = array[num3];
							byte[] array3;
							int num6;
							array3[num6++] = global::System.Convert.ToByte(value2, global::System.Globalization.CultureInfo.CurrentCulture);
							num3++;
							num = (short)1386020864;
							short num7 = num;
							num = (short)196345874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
					{
						byte[] array3;
						if (array2[2] == array3[2])
						{
							num = (short)613875713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 4:
					{
						byte[] array3;
						if (array2[0] == array3[0])
						{
							num = (short)543490071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 5:
						num = (short)1665531907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return result;
					case 7:
					{
						byte[] array3;
						if (array2[1] == array3[1])
						{
							num = (short)1926889477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 8:
						num = (short)207421459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_581;
					case 10:
						num = (short)2041774084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)595132444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (array2[0] >= 192)
						{
							num = (short)895549448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 13:
						if (array2[0] == array2[0])
						{
							num = (short)1505230865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C1;
					case 14:
						num = (short)75169805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (array2[0] <= 191)
						{
							num = (short)450494475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F1;
					case 16:
						if (array2[0] >= 128)
						{
							num = (short)2059337757;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F1;
					case 17:
						result = true;
						ipClass = 0;
						num = (short)1866661919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_305;
					case 19:
						if (array2[0] <= 223)
						{
							num = (short)466747402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 20:
					{
						byte[] array3;
						if (array2[1] == array3[1])
						{
							num = (short)380698650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F1;
					}
					case 21:
						goto IL_4DB;
					case 22:
						goto IL_4DB;
					case 23:
						num = (short)973012999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)304807968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						return result;
					case 26:
						result = true;
						ipClass = 1;
						num = (short)1606287385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_305;
					case 28:
					{
						byte[] array3;
						if (array2[0] == array3[0])
						{
							num = (short)851378185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F1;
					}
					case 29:
						num = (short)620757007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						string[] array4 = ipB.Split(new char[]
						{
							'.'
						});
						byte[] array3 = new byte[4];
						int num6 = 0;
						array = array4;
						num3 = 0;
						num = (short)1652490267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						return result;
					case 32:
						if (array2[0] <= 127)
						{
							num = (short)641466382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C1;
					}
					goto IL_B3;
					IL_F1:
					num = (short)727253004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_305:
					num = (short)280035330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DB:
					num = (short)1277165568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_581:
					num = (short)16515092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C1:
					num = (short)14286864;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_B3:
				result = false;
				string[] array5 = ipA.Split(new char[]
				{
					'.'
				});
				array2 = new byte[4];
				num4 = 0;
				array = array5;
				num3 = 0;
				num = (short)1852637205;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00010798 File Offset: 0x0000E998
		public static string GenerateRelatedIP(string oldIP)
		{
			int a_ = 12;
			short num = (short)614203392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)232914944;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_7C;
				}
				int num4;
				string text;
				int num6;
				for (;;)
				{
					IL_59:
					switch (num2)
					{
					case 0:
						if (num4 != -1)
						{
							num = (short)538509313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					case 1:
						goto IL_1BA;
					case 2:
					{
						num = (short)2031557859;
						short num5 = num;
						num = (short)724770019;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1BA;
						default:
							num = (short)1014038528;
							if (num != 0)
							{
							}
							goto IL_122;
						}
						break;
					}
					case 3:
						if (num6 >= 3)
						{
							num = (short)247791622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = oldIP.IndexOf(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("也", a_), num4 + 1, global::System.StringComparison.CurrentCulture);
						num6++;
						num = (short)1890844677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return text;
					case 5:
						num = (short)384237569;
						if (num != 0)
						{
						}
						goto IL_122;
					case 6:
						num = (short)1066008576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7C;
					IL_122:
					num = (short)1153302531;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BA:
					int num7 = global::System.Convert.ToInt32(oldIP.Substring(num4 + 1), global::System.Globalization.NumberFormatInfo.InvariantInfo);
					num7++;
					text = text.Substring(0, num4 + 1) + num7.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo);
					num = (short)1390936068;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text;
				IL_7C:
				num4 = -1;
				text = oldIP;
				num6 = 0;
				num = (short)1747124226;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_59;
			}
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000109B0 File Offset: 0x0000EBB0
		public static bool IsEquals(byte[] b1, byte[] b2)
		{
			short num = (short)1540358145;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)316735493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)180617217;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 2:
					goto IL_BE;
				case 3:
				{
					num = (short)1636987317;
					short num3 = num;
					num = (short)302739893;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BE;
					default:
						goto IL_115;
					}
					break;
				}
				case 4:
					goto IL_164;
				case 5:
					if (b2 == null)
					{
						num = (short)1686831108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)921829378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_62:
				if (b1 != null)
				{
					num = (short)216530944;
					short num4 = num;
					num = (short)1849819136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_BE:
				if (b1.Length == b2.Length)
				{
					goto IL_168;
				}
				num = (short)1485766659;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_115:
			num = (short)1043660800;
			if (num != 0)
			{
			}
			return false;
			IL_164:
			return false;
			IL_168:
			return b1.SequenceEqual(b2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00010B2C File Offset: 0x0000ED2C
		public static global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet GetValidateSet(object target, global::System.Collections.IList entityList)
		{
			short num = (short)2293760;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
				for (;;)
				{
					IL_28:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						if (entityList != null)
						{
							num = (short)726204417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return validateEntitySet;
					case 1:
						goto IL_285;
					case 2:
						try
						{
							num = (short)246939648;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_18B;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)773128194;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(enumerator.Current);
									validateEntitySet.ValidateEntityList.Add(validatedField);
									num = (short)888799236;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)660930563;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_209;
								}
								IL_18D:
								num = (short)1297416193;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18B:
								goto IL_18D;
							}
							IL_209:
							return validateEntitySet;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_22B;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_218:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)17039361;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_284;
								case 1:
									disposable.Dispose();
									num = (short)564396034;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_282;
								}
								goto IL_22B;
							}
							IL_282:
							IL_284:
							goto EndFinally_6;
							IL_22B:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1495400448;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_218;
							EndFinally_6:;
						}
						goto IL_285;
					}
					goto IL_3B;
					IL_285:
					enumerator = entityList.GetEnumerator();
					num = (short)299761666;
					num2 = (int)((global::System.IntPtr)num);
				}
				return validateEntitySet;
				IL_3B:
				num = (short)951235435;
				short num3 = num;
				num = (short)278246251;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1133772800;
					if (num != 0)
					{
					}
					num = (short)763166720;
					short num4 = num;
					num = (short)218562561;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField2 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(target);
					validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet
					{
						Type = validatedField2.Type,
						RelatedObject = new global::System.Guid?(validatedField2.Uuid),
						ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>
						{
							validatedField2
						}
					};
					break;
				}
				}
				num = (short)505020416;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00010DF4 File Offset: 0x0000EFF4
		public static global::Motorola.CommonCPS.Server.EntityModel.ValidatedField GetValidatedField(object entity)
		{
			short num = (short)1874001920;
			switch (num)
			{
			default:
			{
				num = (short)2097414148;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
				global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug;
				global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration;
				global::Motorola.CommonCPS.Server.EntityModel.Job job;
				global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
				global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem pcrradioSystem;
				global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
				global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage astropackage;
				global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary applicationFeatureSummary;
				global::Motorola.CommonCPS.Server.EntityModel.SACRecord sacrecord;
				global::Motorola.CommonCPS.Server.EntityModel.Group group;
				global::Motorola.CommonCPS.Server.EntityModel.Template template;
				global::Motorola.CommonCPS.Server.EntityModel.PCRPackage pcrpackage;
				global::Motorola.CommonCPS.Server.EntityModel.QuerySummary querySummary;
				global::Motorola.CommonCPS.Server.EntityModel.TGSARecord tgsarecord;
				global::Motorola.CommonCPS.Server.EntityModel.QueryGroup queryGroup;
				global::Motorola.CommonCPS.Server.EntityModel.MatrixKey matrixKey;
				global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_36E;
					case 1:
						goto IL_6D7;
					case 2:
						goto IL_81B;
					case 3:
						if (radio != null)
						{
							num = (short)293142529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						codeplug = (entity as global::Motorola.CommonCPS.Server.EntityModel.Codeplug);
						num = (short)1997930508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_D5;
						}
						continue;
					case 5:
						if (configuration != null)
						{
							num = (short)1182203926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						job = (entity as global::Motorola.CommonCPS.Server.EntityModel.Job);
						num = (short)908656655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (apxradioSystem != null)
						{
							num = (short)1602486279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						pcrradioSystem = (entity as global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem);
						goto IL_707;
					case 7:
						goto IL_4CC;
					case 8:
						goto IL_15C;
					case 9:
					{
						num = (short)1229196878;
						short num3 = num;
						num = (short)672075342;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_707;
						default:
							goto IL_1DC;
						}
						break;
					}
					case 10:
						if (apxdataProfile != null)
						{
							num = (short)252837896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						astropackage = (entity as global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage);
						num = (short)2063400981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (applicationFeatureSummary != null)
						{
							num = (short)1530134560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						sacrecord = (entity as global::Motorola.CommonCPS.Server.EntityModel.SACRecord);
						num = (short)840892446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (codeplug != null)
						{
							num = (short)792592401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						group = (entity as global::Motorola.CommonCPS.Server.EntityModel.Group);
						num = (short)842661921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_3D9;
					case 14:
						goto IL_765;
					case 15:
						if (job != null)
						{
							num = (short)665780252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						template = (entity as global::Motorola.CommonCPS.Server.EntityModel.Template);
						num = (short)210239523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (pcrpackage != null)
						{
							num = (short)526516247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						querySummary = (entity as global::Motorola.CommonCPS.Server.EntityModel.QuerySummary);
						num = (short)1323696153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_59B;
					case 18:
						goto IL_F4;
					case 19:
						goto IL_512;
					case 20:
						if (tgsarecord != null)
						{
							num = (short)1173225496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_882;
					case 21:
						if (astropackage != null)
						{
							num = (short)1937309715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						pcrpackage = (entity as global::Motorola.CommonCPS.Server.EntityModel.PCRPackage);
						num = (short)1965359120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_1A1;
					case 23:
						goto IL_276;
					case 24:
						goto IL_85C;
					case 25:
						if (querySummary != null)
						{
							num = (short)671744000;
							short num4 = num;
							num = (short)2024800258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						queryGroup = (entity as global::Motorola.CommonCPS.Server.EntityModel.QueryGroup);
						num = (short)1509556250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (queryGroup != null)
						{
							num = (short)1120796681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						applicationFeatureSummary = (entity as global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary);
						num = (short)318308363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_440;
					case 28:
						goto IL_649;
					case 29:
						goto IL_557;
					case 30:
						if (sacrecord != null)
						{
							num = (short)1331363867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						tgsarecord = (entity as global::Motorola.CommonCPS.Server.EntityModel.TGSARecord);
						num = (short)1293287444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)68681729;
						if (num != 0)
						{
						}
						if (pcrradioSystem != null)
						{
							num = (short)1403322382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						apxdataProfile = (entity as global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile);
						num = (short)353042442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_7AA;
					case 33:
						if (group != null)
						{
							num = (short)935002125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						configuration = (entity as global::Motorola.CommonCPS.Server.EntityModel.Configuration);
						num = (short)1391591429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (matrixKey != null)
						{
							num = (short)120193024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						apxradioSystem = (entity as global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem);
						num = (short)334168070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (template != null)
						{
							num = (short)693829661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						matrixKey = (entity as global::Motorola.CommonCPS.Server.EntityModel.MatrixKey);
						num = (short)1614872610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D5:
					if (entity == null)
					{
						num = (short)596049938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					validatedField = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField();
					radio = (entity as global::Motorola.CommonCPS.Server.EntityModel.Radio);
					num = (short)910819331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_707:
					num = (short)1509752863;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F4:
				throw new global::System.ArgumentNullException();
				IL_15C:
				validatedField.Uuid = apxdataProfile.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.APXDataProfile;
				validatedField.Timestamp = apxdataProfile.Timestamp;
				return validatedField;
				IL_1A1:
				validatedField.Uuid = configuration.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Configuration;
				validatedField.Timestamp = configuration.Timestamp;
				return validatedField;
				IL_1DC:
				num = (short)1871249408;
				if (num != 0)
				{
				}
				validatedField.Uuid = queryGroup.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.DataMiningQueryGroup;
				validatedField.Timestamp = queryGroup.Timestamp;
				return validatedField;
				IL_276:
				validatedField.Uuid = pcrpackage.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Package;
				validatedField.Timestamp = pcrpackage.Timestamp;
				return validatedField;
				IL_36E:
				validatedField.Uuid = matrixKey.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.MatrixKey;
				validatedField.Timestamp = matrixKey.Timestamp;
				return validatedField;
				IL_3D9:
				validatedField.Uuid = group.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Group;
				validatedField.Timestamp = group.Timestamp;
				return validatedField;
				IL_440:
				validatedField.Uuid = sacrecord.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.SACRecord;
				validatedField.Timestamp = sacrecord.Timestamp;
				return validatedField;
				IL_4CC:
				validatedField.Uuid = apxradioSystem.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.APXRadioSystem;
				validatedField.Timestamp = apxradioSystem.Timestamp;
				return validatedField;
				IL_512:
				validatedField.Uuid = astropackage.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Package;
				validatedField.Timestamp = astropackage.Timestamp;
				return validatedField;
				IL_557:
				validatedField.Uuid = template.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Template;
				validatedField.Timestamp = template.Timestamp;
				return validatedField;
				IL_59B:
				validatedField.Uuid = codeplug.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Codeplug;
				validatedField.Timestamp = codeplug.Timestamp;
				return validatedField;
				IL_649:
				validatedField.Uuid = job.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Job;
				validatedField.Timestamp = job.Timestamp;
				return validatedField;
				IL_6D7:
				validatedField.Uuid = radio.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
				validatedField.Timestamp = radio.Timestamp;
				return validatedField;
				IL_765:
				validatedField.Uuid = pcrradioSystem.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.PCRRadioSystem;
				validatedField.Timestamp = pcrradioSystem.Timestamp;
				return validatedField;
				IL_7AA:
				validatedField.Uuid = applicationFeatureSummary.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.ApplicationFeatureSummary;
				validatedField.Timestamp = applicationFeatureSummary.Timestamp;
				return validatedField;
				IL_81B:
				validatedField.Uuid = querySummary.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.DataMiningQuerySummary;
				validatedField.Timestamp = querySummary.Timestamp;
				return validatedField;
				IL_85C:
				validatedField.Uuid = tgsarecord.Uuid;
				validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.TGSARecord;
				validatedField.Timestamp = tgsarecord.Timestamp;
				return validatedField;
				IL_882:
				return null;
			}
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00011684 File Offset: 0x0000F884
		public static void AppendValidatedField(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> validateFieldList, object entity)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_11C;
				case 1:
					validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(entity);
					num2 = (short)646250496;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_14D;
				case 3:
					if (validatedField == null)
					{
						num2 = (short)841744385;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11C;
				case 4:
					if (validatedField == null)
					{
						num2 = (short)689176578;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_170;
				}
				goto IL_2D;
				IL_11C:
				num2 = (short)1017839620;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_170:
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateFieldList, validatedField);
			return;
			IL_2D:
			num2 = (short)837355686;
			short num3 = num2;
			num2 = (short)1682639014;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_14D:
				throw new global::System.NotImplementedException(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㹗㕙⹛㥝՟ᙡ䑣ብݧ䩩իͭoṱᅳ᭵ᵷᑹࡻ幽ꚅ뒓ﾛ즟춡쪣螥", a_));
			default:
			{
				num2 = (short)505282561;
				if (num2 != 0)
				{
				}
				num2 = (short)1168506880;
				if (num2 != 0)
				{
				}
				validatedField = (entity as global::Motorola.CommonCPS.Server.EntityModel.ValidatedField);
				num2 = (short)241303552;
				short num4 = num2;
				num2 = (short)1623326723;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00011808 File Offset: 0x0000FA08
		public static void AppendValidatedField(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> validateFieldList, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> newValidateFieldList)
		{
			short num = (short)2052849664;
			short num2 = num;
			num = (short)1971650561;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> enumerator;
				switch (num3)
				{
				case 0:
					try
					{
						num = (short)876740611;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_123;
							case 2:
								num = (short)2104819712;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_B2;
								}
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1442775042;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validateField = enumerator.Current;
								global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateFieldList, validateField);
								num = (short)827457537;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_D8:
							num = (short)2054160388;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_B2:
							goto IL_D8;
						}
						IL_123:
						return;
					}
					finally
					{
						for (;;)
						{
							IL_128:
							num = (short)251002881;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_1E2;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_158;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)863371264;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_158:
								if (enumerator == null)
								{
									goto IL_1E4;
								}
								num = (short)628891947;
								short num4 = num;
								num = (short)1978671403;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_128;
								default:
									num = (short)980221952;
									if (num != 0)
									{
									}
									num = (short)1393819650;
									num3 = (int)((global::System.IntPtr)num);
									break;
								}
							}
						}
						IL_1E2:
						IL_1E4:;
					}
					goto IL_1E5;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 2:
					goto IL_74;
				}
				IL_5A:
				if (newValidateFieldList == null)
				{
					num = (short)1941635074;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1E5:
				enumerator = newValidateFieldList.GetEnumerator();
				num = (short)1975058432;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_74:
			num = (short)1926299649;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00011A58 File Offset: 0x0000FC58
		public static void AppendValidatedField(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> validateFieldList, global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validateField)
		{
			short num = (short)327745537;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_5F;
			}
			int num2;
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.a a;
			for (;;)
			{
				IL_31:
				global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField;
				switch (num2)
				{
				case 0:
					if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(validatedField.Timestamp, a.a.Timestamp))
					{
						num = (short)417464329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					if (validateFieldList == null)
					{
						num = (short)186056708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)206110728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
					goto IL_182;
				case 4:
					return;
				case 5:
				{
					num = (short)492315402;
					short num3 = num;
					num = (short)280371978;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_137;
					default:
						goto IL_20C;
					}
					break;
				}
				case 6:
					if (validatedField == null)
					{
						num = (short)1183842307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)976224256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (a.a.Timestamp == null)
					{
						num = (short)1545207813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_137;
				case 8:
					if (a.a == null)
					{
						num = (short)2132213762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)393412615;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_134;
				}
				goto IL_5F;
				IL_137:
				validatedField = validateFieldList.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField, bool>(a.b)).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
				num = (short)10223622;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_134:
			throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Local_Data_Outof_Date, null);
			IL_182:
			validateFieldList.Add(a.a);
			return;
			IL_20C:
			num = (short)529137664;
			if (num != 0)
			{
			}
			num = (short)2017853440;
			short num4 = num;
			return;
			IL_5F:
			a = new global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.a();
			a.a = validateField;
			num = (short)1740898305;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		public static bool CompareTimeStamp(global::System.Guid uuid, byte[] timeStamp, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet)
		{
			short num = (short)356122624;
			short num2 = num;
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.b b = new global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.b();
			b.a = uuid;
			global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField = validateSet.ValidateEntityList.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField, bool>(b.b)).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
			if (validatedField == null)
			{
				num = (short)889513538;
				short num3 = num;
				num = (short)1311368770;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2087190529;
					if (num != 0)
					{
					}
					num = (short)1387266048;
					if (num != 0)
					{
					}
					return true;
				}
			}
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(timeStamp, validatedField.Timestamp);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00011DA0 File Offset: 0x0000FFA0
		public static bool CompareTimeStamp(byte[] timestamp1, byte[] timestamp2)
		{
			int a_ = 11;
			short num = (short)1383071744;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				case 1:
					goto IL_1A5;
				case 2:
					return false;
				case 3:
					num = (short)1072168964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (timestamp2 == null)
					{
						num = (short)1180434433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)241303558;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return true;
				case 6:
				{
					if (timestamp1.Length != timestamp2.Length)
					{
						num = (short)1124007938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					int num3 = 0;
					num = (short)838664202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_1E4;
				case 8:
				{
					int num3;
					if (num3 >= timestamp2.Length)
					{
						num = (short)727711749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)803799051;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					goto IL_1E9;
				case 10:
					goto IL_1E9;
				case 11:
				{
					int num3;
					if (timestamp1[num3] != timestamp2[num3])
					{
						num = (short)1854996487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3++;
					num = (short)401342465;
					if (num != 0)
					{
					}
					num = (short)114425865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_5F:
				num = (short)1273440812;
				short num4 = num;
				num = (short)149301804;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
					num = (short)182648832;
					if (num != 0)
					{
					}
					if (timestamp1 != null)
					{
						num = (short)40697859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_115;
				}
				IL_1E9:
				num = (short)401408008;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_115:
			throw new global::System.NotImplementedException(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ⱞ๠๢d፦Ũɪͬ࡮兰ᩲٴ坶๸ॺቼᅾ", a_));
			IL_1A5:
			goto IL_115;
			IL_1E4:
			num = (short)1409155072;
			short num5 = num;
			return false;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0001200C File Offset: 0x0001020C
		public static global::System.Guid GetNewUuid()
		{
			short num = (short)1133439025;
			short num2 = num;
			num = (short)818735153;
			switch (num2 == num)
			{
			}
			num = (short)374210560;
			short num3 = num;
			num = (short)1355284481;
			if (num != 0)
			{
			}
			num = (short)1057423360;
			if (num != 0)
			{
			}
			return global::System.Guid.NewGuid();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000120B8 File Offset: 0x000102B8
		public static string ConverterJobMsgParametersToString(string[] parameters)
		{
			int a_ = 13;
			short num = (short)399376384;
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
				string text;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						goto IL_17B;
					case 1:
					{
						int num3 = 0;
						num = (short)638451719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (parameters.Count<string>() > 0)
						{
							num = (short)475987969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					case 3:
					{
						num = (short)1809317888;
						short num4 = num;
						num = (short)1944584194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (parameters != null)
						{
							num = (short)1445658627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					case 5:
					{
						num = (short)1450577860;
						short num5 = num;
						num = (short)1179914180;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_17B;
						default:
						{
							num = (short)1234894848;
							if (num != 0)
							{
							}
							int num3;
							if (num3 >= parameters.Length)
							{
								num = (short)1487863814;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string str = parameters[num3];
							text = text + str + global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("䵠", a_);
							num3++;
							num = (short)1628307456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 6:
						text = text.Substring(0, text.Length - 1);
						num = (short)1537343496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_BE;
					case 8:
						return text;
					}
					goto IL_5C;
					IL_BE:
					num = (short)918945797;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17B:
					num = (short)2025979905;
					if (num != 0)
					{
					}
					goto IL_BE;
				}
				return text;
				IL_5C:
				text = null;
				num = (short)1460928516;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000122F8 File Offset: 0x000104F8
		public static string GenerateJobMsgByResource(string resource, string[] parameters)
		{
			short num = (short)1506738177;
			if (num != 0)
			{
			}
			num = (short)546025768;
			short num2 = num;
			num = (short)982626600;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1141178368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2018312192;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000123A0 File Offset: 0x000105A0
		public static string FilterInvalidChar(string value)
		{
			int a_ = 2;
			short num = (short)844824576;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_105;
				}
				string result;
				for (;;)
				{
					IL_31:
					num = (short)1042784831;
					short num3 = num;
					num = (short)877896255;
					char c;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1828585472;
						if (num != 0)
						{
						}
						string text;
						int num4;
						switch (num2)
						{
						case 0:
							if (value != null)
							{
								num = (short)555417604;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 1:
							result = text;
							num = (short)49217552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (c >= 'ؐ')
							{
								num = (short)995622929;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_335;
						case 3:
							num = (short)162332695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)827654168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (num4 >= value.Length)
							{
								num = (short)94961665;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							c = value[num4];
							num = (short)1044840450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_22D;
						case 7:
							goto IL_2B1;
						case 8:
							text = string.Empty;
							num4 = 0;
							num = (short)1923350543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							num = (short)467795982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_143;
						case 11:
							num = (short)1175977985;
							if (num != 0)
							{
							}
							if (c >= 'ﹰ')
							{
								num = (short)898957339;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_375;
						case 12:
							goto IL_335;
						case 13:
							if (c > 'ٟ')
							{
								num = (short)1933180953;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22D;
						case 14:
							if (c > 'ۭ')
							{
								num = (short)1750073354;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22D;
						case 15:
							goto IL_2B1;
						case 16:
							return result;
						case 17:
							num = (short)1466433555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							if (c != 'ٰ')
							{
								num = (short)1504968735;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22D;
						case 19:
							if (c > 'ؚ')
							{
								num = (short)1728512012;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22D;
						case 20:
							if (c >= 'ۧ')
							{
								num = (short)460062729;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_143;
						case 21:
							num = (short)65077261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							goto IL_34E;
						case 23:
							if (c > 'ۤ')
							{
								num = (short)1509163038;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22D;
						case 24:
							if (global::System.Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㝕⩗", a_))
							{
								num = (short)1009123336;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 25:
							goto IL_4D6;
						case 26:
							if (c > 'ﹿ')
							{
								num = (short)1264255004;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22D;
						case 27:
							num = (short)315949082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							goto IL_375;
						case 29:
							if (c >= 'ۖ')
							{
								num = (short)2102984707;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1AB;
						case 30:
							goto IL_1AB;
						case 31:
							num = (short)2085814301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_105;
						IL_143:
						num = (short)233701387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1AB:
						num = (short)1302069268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_22D:
						num4++;
						num = (short)687865863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2B1:
						num = (short)408944645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_335:
						num = (short)1536819222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_375:
						text += c.ToString();
						num = (short)84934656;
						short num5 = num;
						num = (short)602079238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_34E:
					if (c >= 'ً')
					{
						num = (short)395837461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_4D6:
					num = (short)1439957010;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_105:
				result = value;
				num = (short)2018312192;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0001294C File Offset: 0x00010B4C
		public static bool IsDeleteChar(string fieldValue)
		{
			short num = (short)36044800;
			short num2 = num;
			num = (short)782303233;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)1680211969;
					if (num != 0)
					{
					}
					num = (short)184781614;
					short num4 = num;
					num = (short)1491176238;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10A;
					default:
						num = (short)1127088128;
						if (num != 0)
						{
						}
						num = (short)1628766210;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 2:
					goto IL_10A;
				case 3:
					return true;
				}
				IL_5C:
				if (!string.IsNullOrEmpty(fieldValue))
				{
					num = (short)47513600;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_10A:
				if (!(fieldValue.ToString() == '\u007f'.ToString()))
				{
					return false;
				}
				num = (short)802488323;
				num3 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00012A98 File Offset: 0x00010C98
		public static void SetGeneralPropertyValue(string propertyName, string value, object modelObject)
		{
			short num = (short)1549033803;
			short num2 = num;
			num = (short)1429430603;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E8:
				num = (short)1179975681;
				if (num != 0)
				{
				}
				num = (short)534642697;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)771227648;
				if (num != 0)
				{
				}
				num = (short)1448148993;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			global::System.Reflection.PropertyInfo property;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_21A;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_A5;
					}
					continue;
				case 2:
				{
					num = (short)975241216;
					short num4 = num;
					if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(value))
					{
						num = (short)1015742464;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_293;
				}
				case 3:
					num = (short)796065794;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					property.SetValue(modelObject, string.IsNullOrEmpty(value) ? null : global::System.Convert.ChangeType(value, global::System.Nullable.GetUnderlyingType(property.PropertyType), global::System.Globalization.CultureInfo.CurrentCulture), null);
					num = (short)929562634;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1A3;
				case 6:
					num = (short)2109145093;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (!property.PropertyType.IsGenericType)
					{
						num = (short)1541341190;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E8;
				case 8:
					property = modelObject.GetType().GetProperty(propertyName);
					num = (short)987365383;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (property.PropertyType.IsValueType)
					{
						num = (short)1592328195;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_293;
				case 10:
					goto IL_186;
				case 11:
					num = (short)2031943684;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (property.PropertyType.GetGenericTypeDefinition() == typeof(global::System.Nullable<>))
					{
						num = (short)1142226955;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_A5:
				if (modelObject != null)
				{
					num = (short)1230503944;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_293:
				num = (short)1876230156;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_186:
			return;
			IL_1A3:
			property.SetValue(modelObject, string.IsNullOrEmpty(value) ? null : global::System.Convert.ChangeType(value, property.PropertyType, global::System.Globalization.CultureInfo.CurrentCulture), null);
			return;
			IL_21A:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CSVField_DelChar);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00012D90 File Offset: 0x00010F90
		public static string ReplaceInvalidCharacters(string fileName)
		{
			short num = (short)752451680;
			short num2 = num;
			num = (short)1512538208;
			switch (num2 == num)
			{
			}
			num = (short)821821440;
			short num3 = num;
			num = (short)540606465;
			if (num != 0)
			{
			}
			num = (short)1283850240;
			if (num != 0)
			{
			}
			fileName = fileName.Replace('\\', '_');
			fileName = fileName.Replace('/', '_');
			fileName = fileName.Replace(':', '_');
			fileName = fileName.Replace('*', '_');
			fileName = fileName.Replace('?', '_');
			fileName = fileName.Replace('"', '_');
			fileName = fileName.Replace('|', '_');
			fileName = fileName.Replace('<', '_');
			fileName = fileName.Replace('>', '_');
			return fileName;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00012EA8 File Offset: 0x000110A8
		public static string GetActualValue(string uiValue)
		{
			while (!string.IsNullOrEmpty(uiValue))
			{
				short num = (short)1763707055;
				short num2 = num;
				num = (short)558172335;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)386400256;
					short num3 = num;
					num = (short)1671888896;
					if (num != 0)
					{
					}
					num = (short)63569921;
					if (num != 0)
					{
					}
					return uiValue.Trim();
				}
				}
			}
			return string.Empty;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00012F68 File Offset: 0x00011168
		public static global::Motorola.CommonCPS.Server.CommonDBConstants.PACType GetBLL_PAC()
		{
			short num = (short)660416429;
			short num2 = num;
			num = (short)1083254701;
			switch (num2 == num)
			{
			}
			num = (short)1177681920;
			short num3 = num;
			num = (short)1605042177;
			if (num != 0)
			{
			}
			num = (short)83558400;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.ASTRO;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00013014 File Offset: 0x00011214
		public static bool IsAppLicense(string rawLicenseName)
		{
			int a_ = 0;
			short num2;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_49;
				}
				int num;
				string text;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						num2 = (short)2112552961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						if (!(text == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("SѕᩗᕙὛ๝㍟㵡⩣㙥㭧㩩⵫⵭", a_)))
						{
							num2 = (short)1525350405;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 2:
						if (!(text == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("SѕᩗᕙὛ๝㍟㵡噣卥⍧≩㙫", a_)))
						{
							num2 = (short)789643264;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 3:
					{
						num2 = (short)1880670081;
						short num3 = num2;
						num2 = (short)152289153;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num2 = (short)1564999680;
							if (num2 != 0)
							{
							}
							num2 = (short)1539178498;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 4:
						num2 = (short)551223307;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						num2 = (short)1874264065;
						if (num2 != 0)
						{
						}
						num2 = (short)1444478985;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						if (text == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("SѕᩗᕙὛ๝㍟㵡⩣⥥♧Ⅹ⍫㱭㕯㍱㕳㡵㥷㙹㍻㥽썿쪁얃종", a_))
						{
							num2 = (short)750452744;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 7:
						if (!(text == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ٓ᭕ୗὙ๛࡝╟ち㭣㑥╧", a_)))
						{
							num2 = (short)2017918979;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 8:
						goto IL_152;
					case 9:
						if (!(text == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("SѕᩗᕙὛ๝㍟㵡㙣㑥㡧", a_)))
						{
							num2 = (short)765132804;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 10:
						num2 = (short)1253965830;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 11:
						if (!(text == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("SѕᩗᕙὛ๝㍟㵡⩣⥥♧㥩㱫⽭㥯㱱㉳⑵㵷⭹", a_)))
						{
							num2 = (short)2076639242;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					break;
				}
				IL_49:
				int num4 = rawLicenseName.LastIndexOf('_', rawLicenseName.Length - 1);
				int num5 = rawLicenseName.LastIndexOf('_', num4 - 1);
				text = rawLicenseName.Substring(num5 + 1);
				num2 = (short)1695809543;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			IL_152:
			num2 = (short)909180928;
			short num6 = num2;
			return true;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000132F8 File Offset: 0x000114F8
		public static bool IsAppLicense_RadioManagement(string rawLicenseName)
		{
			int a_ = 3;
			while (rawLicenseName.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ֆᑘ࡚ᡜ൞㝠♢㝤㡦㭨♪", a_)))
			{
				short num = (short)41368774;
				short num2 = num;
				num = (short)1808481478;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)349110272;
					short num3 = num;
					num = (short)819527680;
					if (num != 0)
					{
					}
					num = (short)1996750849;
					if (num != 0)
					{
					}
					return true;
				}
				}
			}
			return false;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000133C8 File Offset: 0x000115C8
		public static bool IsSingleRegistrationFeature(string featureName)
		{
			int a_ = 18;
			short num = (short)1948385285;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!(featureName == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ⅵ⑧╩⹫⽭㱯⵱び㭵⩷䥹⍻㱽퉿쮁삃솅춇행좋잍쎏펑횓\uda95\udd97\ude99", a_)))
					{
						num = (short)1178337281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
				{
					num = (short)1932132352;
					short num3 = num;
					num = (short)922157062;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (!(featureName == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ⅵ⑧╩⹫⽭㱯⵱び㭵⩷䥹⍻⵽\ud97f톁\udb83입첇\udc89얋\udd8d\udf8f삑", a_)))
					{
						goto IL_1E5;
					}
					return true;
				case 3:
					num = (short)802422793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)2050293762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 6:
				{
					if (!(featureName == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ⅵ⑧╩⹫⽭㱯⵱び㭵⩷䥹⍻㱽퉿쮁삃솅춇행즋삍톏킑\ud893펕\udc97", a_)))
					{
						return false;
					}
					num = (short)1876885505;
					if (num != 0)
					{
					}
					num = (short)963576935;
					short num4 = num;
					num = (short)131531879;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E5;
					default:
						num = (short)1166671872;
						if (num != 0)
						{
						}
						num = (short)319684615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					return true;
				case 8:
					num = (short)667222016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (!(featureName == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ⅵ⑧╩⹫⽭㱯⵱び㭵⩷䥹⍻⵽\ud97f톁\udb83입첇\udc89얋\udd8d\udf8f삑쮓\ud895\uda97펙", a_)))
					{
						num = (short)1611857928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_55:
				if (!(featureName == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ⅵ⑧╩⹫⽭㱯⵱び㭵⩷䥹⍻⵽\ud97f톁\udb83얅잇쒉\ud88b\udc8d\udf8f\ude91\ud893펕쪗", a_)))
				{
					num = (short)1988886532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1E5:
				num = (short)1807220739;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00013620 File Offset: 0x00011820
		public static bool IsRegistrationFeatureHasDependency(string featureName)
		{
			int a_ = 1;
			short num;
			while (featureName == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ቔ᭖ᙘᥚᱜ፞㹠❢⡤㕦婨㑪⽬㵮㡰㝲㉴㉶♸㽺㑼Ȿ삀솂즄슆춈", a_))
			{
				num = (short)1220800664;
				short num2 = num;
				num = (short)1636561048;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)443875328;
					short num3 = num;
					num = (short)846725120;
					if (num != 0)
					{
					}
					return true;
				}
				}
			}
			num = (short)1908867073;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000136F0 File Offset: 0x000118F0
		public static bool IsSMASingleRegistrationFeature(string featureName)
		{
			int a_ = 9;
			while (featureName == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᩜ፞⹠Ⅲ⑤⭦㙨⽪⁬㵮䉰Ⱳ♴㩶㡸", a_))
			{
				short num = (short)49606574;
				short num2 = num;
				num = (short)1450176430;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)930349056;
					short num3 = num;
					num = (short)255197184;
					if (num != 0)
					{
					}
					num = (short)1394016257;
					if (num != 0)
					{
					}
					return true;
				}
				}
			}
			return false;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000137C0 File Offset: 0x000119C0
		public static bool CheckIfLocalHost(string address)
		{
			int a_ = 2;
			short num = (short)366851762;
			short num2 = num;
			num = (short)1582741170;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_27D:
				num = (short)1199964160;
				short num3 = num;
				num = (short)1295253506;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)475201536;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_7C;
				}
				break;
			}
			bool result;
			for (;;)
			{
				IL_5E:
				switch (num4)
				{
				case 0:
					try
					{
						num = (short)2046951429;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Net.IPAddress ipaddress;
							switch (num4)
							{
							case 0:
								goto IL_23C;
							case 1:
								if (global::System.Net.IPAddress.IsLoopback(ipaddress))
								{
									num = (short)1016987650;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1150943235;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								result = true;
								num = (short)194969600;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (global::System.Net.Dns.GetHostAddresses(global::System.Net.Dns.GetHostName()).Contains(ipaddress))
								{
									num = (short)1578041353;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_23C;
							case 4:
								num = (short)1710292993;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_146;
								}
								continue;
							case 6:
								goto IL_23C;
							case 7:
								goto IL_23C;
							case 8:
								goto IL_253;
							case 9:
								result = true;
								num = (short)2141519878;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_146:
							if (global::System.Net.IPAddress.TryParse(address, out ipaddress))
							{
								num = (short)308936708;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = false;
							num = (short)1546190855;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_23C:
							num = (short)242024456;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_253:
						return result;
					}
					catch
					{
						return false;
					}
					goto IL_260;
				case 1:
					if (!address.ToUpperInvariant().Equals(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㩕㝗㥙㵛㉝࡟ൡᝣብ", a_).ToUpperInvariant()))
					{
						num = (short)1444741123;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F7;
				case 2:
					if (address.ToUpperInvariant().Trim().Equals(global::System.Net.Dns.GetHostName().ToUpperInvariant().Trim()))
					{
						num = (short)1952317444;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_260;
				case 3:
					goto IL_F4;
				case 4:
					goto IL_2F7;
				case 5:
					return result;
				}
				goto IL_7C;
				IL_260:
				num = (short)2103967744;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F7:
				result = true;
				num = (short)817299461;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_F4:
			goto IL_27D;
			IL_7C:
			result = false;
			num = (short)888995841;
			if (num != 0)
			{
			}
			num = (short)2144665601;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_5E;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00013AFC File Offset: 0x00011CFC
		public static bool CheckIfActiveDirectory()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!global::System.Environment.MachineName.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture).Trim().Equals(global::System.Environment.UserDomainName.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture).Trim()))
					{
						goto IL_8C;
					}
					return result;
				case 1:
				{
					num2 = (short)175514282;
					short num3 = num2;
					num2 = (short)1171727018;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8C;
					default:
						num2 = (short)1482817537;
						if (num2 != 0)
						{
						}
						num2 = (short)709492736;
						if (num2 != 0)
						{
						}
						result = true;
						num2 = (short)107610114;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					return result;
				}
				goto IL_1C;
				IL_8C:
				num2 = (short)841351169;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_1C:
			num2 = (short)1348665344;
			short num4 = num2;
			result = false;
			num2 = (short)873594880;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00013C40 File Offset: 0x00011E40
		public static string ConvertResourceNameToModuleName(string resourceName)
		{
			int a_ = 11;
			short num;
			for (;;)
			{
				num = (short)679608320;
				short num2 = num;
				num = (short)764084229;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						if (resourceName == global::Motorola.CommonCPS.ResourceRepository.Resources.General_DVRS_Files)
						{
							num = (short)2063466497;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_270;
					case 1:
						goto IL_1BF;
					case 2:
						if (resourceName == global::Motorola.CommonCPS.ResourceRepository.Resources.General_CACertificates)
						{
							num = (short)1823145987;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1592393728;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_20D;
					case 4:
						goto IL_A5;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					case 6:
						if (resourceName == global::Motorola.CommonCPS.ResourceRepository.Resources.General_LanguagePacks)
						{
							num = (short)2117337095;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)54722569;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_17B;
					case 8:
						goto IL_25C;
					case 9:
						if (resourceName == global::Motorola.CommonCPS.ResourceRepository.Resources.General_VoiceAnnouncements)
						{
							num = (short)71434248;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1658060802;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_80:
					if (resourceName == global::Motorola.CommonCPS.ResourceRepository.Resources.General_Firmware)
					{
						num = (short)1379336196;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1499856897;
						if (num != 0)
						{
						}
						num = (short)360972294;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_20D:
				num = (short)1795239065;
				short num4 = num;
				num = (short)2022714521;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_E0;
				}
			}
			IL_A5:
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᥞࡠᅢࡤၦࡨᥪ࡬", a_);
			IL_E0:
			num = (short)1069809664;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᱞ⁠⁢dᕦᵨɪ୬ٮተቲŴቶ੸", a_);
			IL_17B:
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("፞`ൢɤቦࡨ౪࡬㽮ၰၲṴ", a_);
			IL_1BF:
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("᭞㝠ㅢ㙤Ⅶhݪ࡬ᱮ", a_);
			IL_25C:
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("फ़๠੢٤ɦ⡨ժͬnѰᵲᙴቶᑸṺ፼୾", a_);
			IL_270:
			return string.Empty;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00013EC4 File Offset: 0x000120C4
		public static string ConvertModuleNameToResourceName(string moduleName)
		{
			int a_ = 17;
			short num;
			for (;;)
			{
				num = (short)1920860161;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (moduleName == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ⅴㅦ㭨㡪⭬ٮᵰᙲٴ", a_))
						{
							num = (short)240975880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26A;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_55;
						}
						continue;
					case 2:
						if (moduleName == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("♤♦⩨๪Ὤ᭮ᡰᕲᱴᑶᡸེ᡼౾", a_))
						{
							num = (short)1941176326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2105016320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_D5;
					case 4:
						goto IL_7F;
					case 5:
						goto IL_239;
					case 6:
						goto IL_1E6;
					case 7:
						if (moduleName == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㍤ࡦhࡪ࡬⹮ὰᵲᩴɶ᝸᡺᡼ቾ", a_))
						{
							num = (short)495648773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1663500290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_123;
					case 9:
						if (moduleName == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⥤٦ݨ౪ᡬ๮ᙰᙲ╴ᙶ᩸ၺ", a_))
						{
							num = (short)711327747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2039873543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_55:
					if (moduleName == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⍤๦᭨٪ᩬ๮Ͱᙲ", a_))
					{
						num = (short)1319960580;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)607125513;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_123:
				num = (short)866712307;
				short num3 = num;
				num = (short)490797811;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_158;
				}
			}
			IL_7F:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.General_Firmware;
			IL_D5:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.General_LanguagePacks;
			IL_158:
			num = (short)290848768;
			if (num != 0)
			{
			}
			num = (short)1894645760;
			short num4 = num;
			return global::Motorola.CommonCPS.ResourceRepository.Resources.General_DVRS_Files;
			IL_1E6:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.General_CACertificates;
			IL_239:
			num = (short)2141650945;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.ResourceRepository.Resources.General_VoiceAnnouncements;
			IL_26A:
			return string.Empty;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00014140 File Offset: 0x00012340
		public static global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType GetAppLicenseTypeByName(string featureName)
		{
			int a_ = 1;
			short num = (short)77070337;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_85;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 2:
					if (featureName.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ŔՖ᭘ᑚṜཞ㉠㱢⭤⡦❨⁪≬㵮㑰㉲㑴㥶㡸㝺㉼㡾슀쮂쒄즆", a_)))
					{
						num = (short)1513291779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType.Unknown;
				case 3:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType.PCR_NONKOREAANALOGCHAN;
				case 4:
					if (featureName.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ŔՖ᭘ᑚṜཞ㉠㱢坤剦≨⍪㝬", a_)))
					{
						num = (short)852426762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1761869836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)275316736;
					short num3 = num;
					if (featureName.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ŔՖ᭘ᑚṜཞ㉠㱢⭤⡦❨㡪㵬⹮㡰㵲㍴╶㱸⩺", a_)))
					{
						num = (short)1242300429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1983512578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (featureName.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ݔᩖ੘Ṛཛྷफ़①ㅢ㩤㕦⑨", a_)))
					{
						num = (short)1942290439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1437401092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType.RadioManagement;
				case 8:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType.PCR_NPSPAC;
				case 9:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType.PCR_RRP;
				case 10:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType.PCR_25KHZ;
				case 11:
					if (featureName.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ŔՖ᭘ᑚṜཞ㉠㱢㝤㕦㥨", a_)))
					{
						num = (short)860225545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)959512581;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (featureName.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ŔՖ᭘ᑚṜཞ㉠㱢⭤㝦㩨㭪ⱬⱮ", a_)))
					{
						num = (short)1582235656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1760952331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType.PCR_NONSPAINFREQ;
				}
				IL_66:
				if (string.IsNullOrEmpty(featureName))
				{
					num = (short)346619904;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)626524166;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_85:
			num = (short)511705089;
			if (num != 0)
			{
			}
			num = (short)1319963222;
			short num4 = num;
			num = (short)716966486;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2001141760;
				if (num != 0)
				{
				}
				break;
			}
			throw new global::System.ArgumentNullException();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0001444C File Offset: 0x0001264C
		public static void LogExpToFilenEventnRethrow(global::System.Exception e, global::Motorola.Common.LogUtility.LoggingLevel loggingLevel = global::Motorola.Common.LogUtility.LoggingLevel.EventError, string sourceFuncName = "")
		{
			short num;
			try
			{
				num = (short)788156306;
				short num2 = num;
				num = (short)641421202;
				switch (num2 == num)
				{
				}
				num = (short)2132213760;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel logLevel = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogUtil.ConvertLoggingLevelToLogLevel(loggingLevel);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(sourceFuncName, e, logLevel);
				global::Motorola.Common.LogUtility.ILog logger = global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName);
				string content = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogUtil.GenLogEveArgs(sourceFuncName, e, logLevel);
				logger.WriteEventEntry(content, loggingLevel);
			}
			catch
			{
			}
			num = (short)1685127169;
			if (num != 0)
			{
			}
			num = (short)235143168;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(e);
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error.ToString(), null));
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00014560 File Offset: 0x00012760
		public static void LogExpToFilenEvent(global::System.Exception e, global::Motorola.Common.LogUtility.LoggingLevel loggingLevel = global::Motorola.Common.LogUtility.LoggingLevel.EventError, string sourceFuncName = "")
		{
			short num;
			try
			{
				num = (short)572328312;
				short num2 = num;
				num = (short)1984891256;
				switch (num2 == num)
				{
				}
				num = (short)581763072;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel logLevel = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogUtil.ConvertLoggingLevelToLogLevel(loggingLevel);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(sourceFuncName, e, logLevel);
				global::Motorola.Common.LogUtility.ILog logger = global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName);
				string content = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogUtil.GenLogEveArgs(sourceFuncName, e, logLevel);
				logger.WriteEventEntry(content, loggingLevel);
			}
			catch
			{
			}
			num = (short)869531649;
			if (num != 0)
			{
			}
			num = (short)2044395520;
			short num3 = num;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00014648 File Offset: 0x00012848
		public static void LogInfoToFilenEvent(string infoStr, global::Motorola.Common.LogUtility.LoggingLevel loggingLevel = global::Motorola.Common.LogUtility.LoggingLevel.EventInfo)
		{
			short num;
			try
			{
				num = (short)15411686;
				short num2 = num;
				num = (short)1524378086;
				switch (num2 == num)
				{
				}
				num = (short)752091137;
				if (num != 0)
				{
				}
				num = (short)1555759104;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel logLevel = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogUtil.ConvertLoggingLevelToLogLevel(loggingLevel);
				global::System.Exception exp = null;
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(infoStr, exp, logLevel);
				global::Motorola.Common.LogUtility.ILog logger = global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName);
				string content = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogUtil.GenLogEveArgs(infoStr, exp, logLevel);
				logger.WriteEventEntry(content, loggingLevel);
			}
			catch
			{
			}
			num = (short)448593920;
			short num3 = num;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00014734 File Offset: 0x00012934
		public static string GetLicensePrefixByRegion(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName region)
		{
			int a_ = 4;
			short num = (short)129999864;
			short num2 = num;
			num = (short)1186505720;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_126:
				num = (short)1044643840;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)680460289;
				if (num != 0)
				{
				}
				num = (short)2074148864;
				if (num != 0)
				{
				}
				num = (short)1672151042;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_13D;
				case 1:
					goto IL_106;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_AF;
					}
					continue;
				}
				IL_AF:
				num = (short)703397888;
				short num4 = num;
				switch (region)
				{
				case global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.NA:
					goto IL_13F;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.LA:
					goto IL_108;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.EMEA:
					goto IL_117;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.AS:
					goto IL_14E;
				default:
					num = (short)776208385;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_106:
			goto IL_126;
			IL_108:
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᑗ᭙͛", a_);
			IL_117:
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᵗ᝙͛", a_);
			IL_13D:
			return string.Empty;
			IL_13F:
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᙗ᭙͛", a_);
			IL_14E:
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᥗख़͛", a_);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000148A4 File Offset: 0x00012AA4
		public static global::System.Collections.Generic.List<string> GetDragDroppedFiles(global::System.Windows.DragEventArgs e, string extension)
		{
			int a_ = 8;
			short num = (short)943718400;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1047789569;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_92;
				}
				string searchPattern;
				global::System.Collections.Generic.List<string> list2;
				for (;;)
				{
					IL_57:
					global::System.Collections.Generic.List<string> list;
					switch (num2)
					{
					case 0:
						if (!string.IsNullOrEmpty(extension))
						{
							num = (short)1034420226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_172;
					case 1:
					{
						global::System.Collections.IEnumerator enumerator = ((global::System.Array)e.Data.GetData(global::System.Windows.DataFormats.FileDrop)).GetEnumerator();
						num = (short)2137391116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_478;
					case 3:
						num = (short)1029767179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_11A;
					case 5:
						if (!extension.StartsWith(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("牛", a_), global::System.StringComparison.Ordinal))
						{
							num = (short)306905094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)404226057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_4C2;
					case 7:
						goto IL_11A;
					case 8:
						if (e.Effects.HasFlag(global::System.Windows.DragDropEffects.Copy))
						{
							num = (short)1790377987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 9:
						if (extension.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⁛", a_)))
						{
							num = (short)989265930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						searchPattern = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("癛", a_) + extension;
						list2.Add(extension);
						num = (short)607256583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)609878016;
						short num3 = num;
						searchPattern = extension.Replace(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("牛", a_), global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("癛灝", a_));
						list2.AddRange(extension.Split(new char[]
						{
							'|'
						}, global::System.StringSplitOptions.RemoveEmptyEntries));
						num = (short)1453129732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (e.Data.GetDataPresent(global::System.Windows.DataFormats.FileDrop))
						{
							num = (short)143065089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 12:
						try
						{
							num = (short)455933953;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2038169605;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = (string)enumerator.Current;
									num = (short)1513816066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1E5;
									}
									continue;
								case 2:
								{
									string text;
									if (!string.IsNullOrEmpty(text))
									{
										num = (short)1850802179;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)305070086;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (list2.Any(new global::System.Func<string, bool>(c.b)))
									{
										num = (short)645333002;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									num = (short)1746206729;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									string text;
									if (global::System.IO.Directory.Exists(text))
									{
										num = (short)1537736711;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)30277644;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									string text;
									list.AddRange(global::System.IO.Directory.GetFiles(text, searchPattern, global::System.IO.SearchOption.AllDirectories));
									num = (short)1384579085;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									string text;
									string a = global::System.IO.Path.GetExtension(text);
									num = (short)1155661828;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_3B3;
								case 10:
								{
									string text;
									list.Add(text);
									num = (short)604110859;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									string text;
									if (global::System.IO.File.Exists(text))
									{
										num = (short)1416364040;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1E7:
								num = (short)1993867264;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E5:
								goto IL_1E7;
							}
							IL_3B3:
							return list;
						}
						finally
						{
							num = (short)79768089;
							short num4 = num;
							num = (short)670378521;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_441:
								num = (short)1459290113;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1084948480;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_420;
								}
								break;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_40D:
								switch (num2)
								{
								case 0:
									goto IL_475;
								case 1:
									disposable.Dispose();
									num = (short)428670976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_43D;
								}
								goto IL_420;
							}
							IL_43D:
							if (disposable != null)
							{
								goto IL_441;
							}
							IL_475:
							goto EndFinally_13;
							IL_420:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1840513026;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_40D;
							EndFinally_13:;
						}
						goto IL_478;
					}
					goto IL_92;
					IL_11A:
					list = new global::System.Collections.Generic.List<string>();
					num = (short)2053439496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_478:
					num = (short)96665605;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_172:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㥛♝ᑟݡ੣ᕥŧթɫ", a_), extension);
				IL_4C2:
				goto IL_172;
				IL_92:
				searchPattern = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("絛瑝也䡡", a_);
				list2 = new global::System.Collections.Generic.List<string>();
				num = (short)2094006272;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_57;
			}
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00014EE8 File Offset: 0x000130E8
		public static string GenerateTTSGUIName(string packageName)
		{
			short num = (short)692387840;
			short num2 = num;
			num = (short)1551958594;
			short num3 = num;
			num = (short)2053308994;
			switch (num3 == num)
			{
			}
			num = (short)966197249;
			if (num != 0)
			{
			}
			num = (short)1021837312;
			if (num != 0)
			{
			}
			int num4 = packageName.IndexOf('_');
			string text = packageName.Substring(num4 + 1);
			num4 = text.IndexOf('_');
			string languageID = text.Substring(0, num4);
			string text2 = text.Substring(num4 + 1);
			num4 = text2.IndexOf('_');
			string speakerName = text2.Substring(0, num4);
			byte gender = byte.Parse(text2.Substring(num4 + 1), global::System.Globalization.CultureInfo.CurrentCulture);
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GenerateTTSGUIName(languageID, speakerName, gender);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00014FE8 File Offset: 0x000131E8
		public static string GenerateTTSGUIName(string languageID, string speakerName, byte gender)
		{
			int a_ = 1;
			short num = (short)1062076416;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				string text;
				string text2;
				string text3;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if (string.IsNullOrEmpty(text))
						{
							num = (short)2021064707;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_222;
					case 1:
						goto IL_222;
					case 2:
						text2 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ፔ㉖㑘㩚ㅜ㩞", a_);
						num = (short)822345737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						text = languageID;
						num = (short)510001153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1141899265;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(text2))
						{
							num = (short)569376773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31B;
					case 5:
						num = (short)647036939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_2B2;
					case 7:
						goto IL_172;
					case 8:
						text3 = speakerName;
						num = (short)1387986951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_2FA;
					case 10:
						if (string.IsNullOrEmpty(text3))
						{
							num = (short)586874888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_172;
					case 11:
						if (gender.Equals(0))
						{
							num = (short)1741422594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text2 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᡔ㙖㕘㹚", a_);
						num = (short)2007302150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_67;
					IL_172:
					num = (short)428635741;
					short num3 = num;
					num = (short)1960867421;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2B2;
					default:
						num = (short)1712717824;
						if (num != 0)
						{
						}
						num = (short)1627586564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_222:
					num = (short)1400766464;
					short num4 = num;
					num = (short)413859850;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2B2:
				IL_2FA:
				IL_31B:
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⹔杖⑘慚絜⑞偠Ṣ䕤佦ቨ奪ၬ䙮", a_), text, text3, text2);
				IL_67:
				string empty = string.Empty;
				languageID = languageID.Replace('-', '_');
				speakerName = speakerName.Replace(' ', '-');
				string name = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ŕ͖੘᝚ᱜᅞ♠㍢⑤⑦≨㑪", a_) + gender.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				text = global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ŕ͖੘᝚ᱜᅞ♠㍢⑤⑦≨㑪", a_) + languageID);
				text3 = global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ŕ͖੘᝚ᱜᅞ♠㍢⑤⑦≨㑪", a_) + speakerName);
				text2 = global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(name);
				num = (short)1316552704;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0001532C File Offset: 0x0001352C
		public static void SearchFolderForFWFiles(global::System.IO.DirectoryInfo folderInfo, global::System.Collections.Generic.List<string> fileList)
		{
			int a_ = 8;
			short num = (short)81848573;
			short num2 = num;
			num = (short)1473243389;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1135083521;
				if (num != 0)
				{
				}
				num = (short)136314880;
				if (num != 0)
				{
				}
				num = (short)265224192;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					string[] source = new string[]
					{
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("牛㵝ᙟౡ", a_),
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("牛㱝ɟѡ", a_),
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("牛⑝य़ቡ", a_)
					};
					if (folderInfo.Exists)
					{
						num = (short)97779712;
						short num4 = num;
						try
						{
							switch (0)
							{
							case 0:
								goto IL_153;
							}
							int num5;
							global::System.IO.FileInfo[] files;
							for (;;)
							{
								IL_114:
								switch (num3)
								{
								case 0:
									goto IL_32F;
								case 1:
								{
									global::System.IO.DirectoryInfo[] directories;
									if (num5 >= directories.Length)
									{
										num = (short)1819213836;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.SearchFolderForFWFiles(directories[num5], fileList);
									num5++;
									num = (short)1800929286;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::System.IO.FileInfo fileInfo;
									fileList.Add(fileInfo.FullName);
									num = (short)131661827;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_294;
								case 4:
								{
									global::System.IO.DirectoryInfo[] directories = folderInfo.GetDirectories();
									num5 = 0;
									num = (short)1838219275;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::System.IO.FileInfo fileInfo;
									if (!fileList.Contains(fileInfo.FullName))
									{
										num = (short)1872101378;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_294;
								}
								case 6:
									goto IL_255;
								case 7:
									goto IL_2D9;
								case 8:
									num = (short)843972613;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::System.IO.FileInfo fileInfo;
									if (source.Contains(fileInfo.Extension))
									{
										num = (short)986841096;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_294;
								}
								case 10:
								{
									if (num5 >= files.Length)
									{
										num = (short)1841889284;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.IO.FileInfo fileInfo = files[num5];
									num = (short)1641611273;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									goto IL_255;
								case 12:
									num = (short)1884422144;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									goto IL_2D9;
								}
								goto IL_153;
								IL_255:
								num = (short)1987117057;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_294:
								num5++;
								num = (short)292356109;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_2D9:
								num = (short)1805123594;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_32F:
							break;
							IL_153:
							files = folderInfo.GetFiles();
							num5 = 0;
							num = (short)1232273415;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_114;
						}
						catch (global::System.Exception)
						{
						}
					}
					break;
				}
				}
				break;
			}
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0001568C File Offset: 0x0001388C
		public static string GetDisplayNameOfPAC()
		{
			int a_ = 17;
			short num = (short)1166606336;
			short num2 = num;
			num = (short)1529413633;
			if (num != 0)
			{
			}
			num = (short)184419407;
			short num3 = num;
			num = (short)459867215;
			switch (num3 == num)
			{
			}
			num = (short)750845952;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⑤㝦ㅨ", a_);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00015750 File Offset: 0x00013950
		public static void ParseAPKApplication(string file, out string name, out string appLabel, out string version, out int versionCode, out string appClassName, out string icon)
		{
			int a_ = 8;
			short num = (short)1118371840;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				string text2;
				string text5;
				string text7;
				string value;
				string text8;
				string text9;
				string value2;
				string value3;
				for (;;)
				{
					IL_30:
					global::System.Diagnostics.Process process;
					switch (num2)
					{
					case 0:
						try
						{
							process.StartInfo.FileName = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㵛㽝ၟᙡ䩣ͥၧཀྵ", a_);
							process.StartInfo.RedirectStandardInput = true;
							process.StartInfo.RedirectStandardOutput = true;
							process.StartInfo.UseShellExecute = false;
							process.StartInfo.Arguments = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("籛㩝䁟aգɥཧͩɫ७偯偱ཱི䙵շ塹", a_), file);
							process.StartInfo.StandardOutputEncoding = global::System.Text.Encoding.UTF8;
							process.StartInfo.CreateNoWindow = true;
							process.Start();
							global::System.IO.StreamReader standardOutput = process.StandardOutput;
							try
							{
								num = (short)117899302;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									int num3;
									switch (num2)
									{
									case 0:
									{
										string text;
										if (text.Contains(text2))
										{
											num = (short)1601962023;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_306;
									}
									case 1:
										goto IL_678;
									case 2:
									{
										string text3;
										if ((text3 = standardOutput.ReadLine()) == null)
										{
											num = (short)1771044876;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)910229512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										string text4;
										if (text4.Contains(text5))
										{
											num = (short)429391888;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_8A9;
									}
									case 4:
									{
										string[] array;
										if (num3 >= array.Length)
										{
											num = (short)133103631;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										string text4 = array[num3];
										num = (short)291241987;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										string[] array;
										if (num3 >= array.Length)
										{
											num = (short)2063663138;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										string text6 = array[num3];
										num = (short)1048182793;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										goto IL_2C8;
									case 7:
									{
										string text3;
										if (text3.Contains(text7))
										{
											num = (short)1188757515;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_7BD;
									}
									case 8:
									{
										string text3;
										if (text3.StartsWith(value, global::System.StringComparison.Ordinal))
										{
											num = (short)739246106;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_486;
									}
									case 9:
									{
										string text6;
										if (text6.Contains(text2))
										{
											num = (short)534118420;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_54B;
									}
									case 10:
									{
										num = (short)2000563663;
										short num4 = num;
										num = (short)736636367;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_6DB;
										default:
										{
											num = (short)2039939072;
											if (num != 0)
											{
											}
											string text6;
											if (text6.Contains(text8))
											{
												num = (short)1982398487;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_58B;
										}
										}
										break;
									}
									case 11:
									{
										string text3;
										appLabel = text3.Substring(text7.Length).Trim(new char[]
										{
											'\''
										});
										num = (short)1644822561;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
										process.WaitForExit();
										process.Close();
										standardOutput.Close();
										num = (short)784465933;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 13:
										goto IL_8FB;
									case 14:
										goto IL_2C8;
									case 15:
										goto IL_5F8;
									case 16:
									{
										string text4;
										icon = text4.Substring(text5.Length + 1).Trim(new char[]
										{
											'\''
										});
										goto IL_6DB;
									}
									case 17:
									{
										string text6;
										version = text6.Substring(text9.Length + 1).Trim(new char[]
										{
											'\''
										});
										num = (short)2030239765;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 18:
									{
										string text3;
										if (text3.Contains(value2))
										{
											num = (short)173539358;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 19:
										goto IL_869;
									case 20:
									{
										string text6;
										name = text6.Substring(text2.Length + 1).Trim(new char[]
										{
											'\''
										});
										num = (short)1215234085;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 21:
										goto IL_374;
									case 22:
									{
										string text3;
										string[] array = text3.Split(new char[]
										{
											' '
										});
										num3 = 0;
										num = (short)431161358;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 23:
									{
										string text6;
										int.TryParse(text6.Substring(text8.Length + 1).Trim(new char[]
										{
											'\''
										}), out versionCode);
										num = (short)1236598820;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 25:
										goto IL_678;
									case 26:
									{
										string text3;
										string[] array = text3.Split(new char[]
										{
											' '
										});
										num3 = 0;
										num = (short)1030422529;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 27:
									{
										string[] array;
										if (num3 >= array.Length)
										{
											num = (short)86376472;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										string text = array[num3];
										num = (short)1932394496;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 28:
									{
										string text6;
										if (text6.Contains(text9))
										{
											num = (short)279445521;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_374;
									}
									case 29:
										goto IL_8A9;
									case 30:
									{
										string text3;
										string[] array = text3.Split(new char[]
										{
											' '
										});
										num3 = 0;
										num = (short)545849363;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 31:
										goto IL_869;
									case 32:
									{
										string text3;
										if (text3.Contains(value3))
										{
											num = (short)903675926;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_5F8;
									}
									case 33:
										goto IL_7BD;
									case 34:
										goto IL_486;
									case 35:
										goto IL_306;
									case 36:
										goto IL_58B;
									case 37:
										goto IL_54B;
									case 38:
										switch (0)
										{
										case 0:
											goto IL_285;
										}
										continue;
									case 39:
									{
										string text;
										appClassName = text.Substring(text2.Length + 1).Trim(new char[]
										{
											'\''
										});
										num = (short)1065877539;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_285;
									IL_2C8:
									num = (short)2141585412;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_306:
									num3++;
									num = (short)1213923359;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_374:
									num = (short)551092234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_440:
									num = (short)1007550466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_285:
									goto IL_440;
									IL_486:
									num = (short)625868807;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_54B:
									num = (short)2000027676;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_58B:
									num3++;
									num = (short)694026265;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_5F8:
									num = (short)1239351314;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_678:
									num = (short)513671173;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_6DB:
									num = (short)169541661;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_7BD:
									num = (short)325451808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_869:
									num = (short)1722548251;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_8A9:
									num3++;
									num = (short)1475870726;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_8FB:
								goto IL_A30;
							}
							finally
							{
								num = (short)774438913;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_96B;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_933;
										}
										continue;
									case 2:
										((global::System.IDisposable)standardOutput).Dispose();
										num = (short)501088256;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_933:
									if (standardOutput == null)
									{
										break;
									}
									num = (short)94765058;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_96B:;
							}
						}
						finally
						{
							num = (short)1498218497;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_9D9;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_9A1;
									}
									continue;
								case 2:
									((global::System.IDisposable)process).Dispose();
									num = (short)1352925184;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_9A1:
								if (process == null)
								{
									break;
								}
								num = (short)950403074;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_9D9:;
						}
						goto IL_9DC;
					case 1:
						if (string.IsNullOrWhiteSpace(file))
						{
							num = (short)191365121;
							if (num != 0)
							{
							}
							num = (short)550371330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9DC;
					case 2:
						goto IL_122;
					}
					goto IL_43;
					IL_9DC:
					name = string.Empty;
					appLabel = string.Empty;
					version = string.Empty;
					versionCode = 0;
					appClassName = string.Empty;
					icon = string.Empty;
					process = new global::System.Diagnostics.Process();
					num = (short)117112832;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_122:
				throw new global::System.ArgumentNullException();
				IL_A30:
				num = (short)2020343808;
				short num5 = num;
				return;
				IL_43:
				value = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ⱛ㽝͟ॡգť൧", a_);
				text8 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⩛㭝቟ᅡൣ॥٧⥩ͫ੭ᕯ", a_);
				text9 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⩛㭝቟ᅡൣ॥٧⑩൫ͭᕯ", a_);
				text2 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㉛㽝ൟݡ", a_);
				value3 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㵛⹝ၟ๡ൣե१ṩիŭṯ䡱", a_);
				text7 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㵛⹝ၟ๡ൣե१ṩիŭṯ影ᡳ᝵᩷όၻ䑽", a_);
				value2 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("せ㽝ᕟౡݣ๥१ࡩk୭嵯፱ᝳɵᅷ౹ᕻ੽勵", a_);
				text5 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㕛㵝ཟౡ", a_);
				num = (short)1210843137;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000161EC File Offset: 0x000143EC
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.WidgetInfo> ParseWidgetsFromAPK(string apkFile)
		{
			int a_ = 16;
			short num = (short)52428800;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.WidgetInfo> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.WidgetInfo>();
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> dictionary = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.b(apkFile);
				global::System.Collections.Generic.Dictionary<string, string> dictionary2 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.c(apkFile);
				global::System.Collections.Generic.Dictionary<string, string>.KeyCollection.Enumerator enumerator = dictionary2.Keys.GetEnumerator();
				try
				{
					num = (short)2134835206;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.WidgetInfo widgetInfo = new global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.WidgetInfo();
							string key;
							string arg = dictionary[key][0];
							global::System.IO.StringReader stringReader = new global::System.IO.StringReader(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.a(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("c䙥ၧݩkᩭɯ᝱ᅳ噵婷Ź䱻ͽꉿꊁﾃ랅", a_), apkFile, arg)));
							num = (short)495845379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_539;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)286326788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string key = enumerator.Current;
							num = (short)2121072647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.WidgetInfo widgetInfo;
							try
							{
								num = (short)1459486731;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
										goto IL_354;
									case 2:
									{
										string text;
										widgetInfo.minWidth = int.Parse(text.Substring(text.LastIndexOf(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("呣ṥ", a_), global::System.StringComparison.Ordinal) + 2).Trim(), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
										num = (short)381878273;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										num = (short)2106785799;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										string text;
										if (text.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("գࡥ౧ᡩͫݭᑯ䡱ѳѵᵷ౹ᕻ᭽쮁", a_)))
										{
											num = (short)1860698122;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										goto IL_443;
									case 6:
									{
										string text;
										if (text.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ॣཥ٧≩५ݭᝯᩱs", a_)))
										{
											num = (short)564789260;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_443;
									}
									case 7:
										goto IL_4AC;
									case 8:
									{
										global::System.IO.StringReader stringReader;
										string text;
										if ((text = stringReader.ReadLine()) == null)
										{
											num = (short)131989507;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)666042377;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
									{
										string text;
										if (text.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("գࡥ౧ᡩͫݭᑯ䡱ᥳήᙷ⵹ᕻ᩽", a_)))
										{
											num = (short)1170407426;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_354;
									}
									case 10:
									{
										string text;
										widgetInfo.imagePath = dictionary[text.Substring(text.LastIndexOf(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("④", a_), global::System.StringComparison.Ordinal) + 1).Trim()][0];
										num = (short)1864433664;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
										switch (0)
										{
										case 0:
											goto IL_260;
										}
										continue;
									case 12:
									{
										string text;
										widgetInfo.minHeight = int.Parse(text.Substring(text.LastIndexOf(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("呣ṥ", a_), global::System.StringComparison.Ordinal) + 2).Trim(), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
										num = (short)2095251461;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_2BC:
									num = (short)1124663304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_260:
									goto IL_2BC;
									IL_354:
									num = (short)2087649286;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_443:
									num = (short)2101542916;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_4AC:
								goto IL_1C8;
							}
							finally
							{
								num = (short)230424577;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.IO.StringReader stringReader;
									switch (num2)
									{
									case 0:
										goto IL_51D;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_4E3;
										}
										continue;
									case 2:
										((global::System.IDisposable)stringReader).Dispose();
										num = (short)366673920;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_4E3:
									if (stringReader == null)
									{
										break;
									}
									num = (short)722534402;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_51D:;
							}
							goto IL_520;
							IL_1C8:
							widgetInfo.fileName = apkFile;
							string key;
							widgetInfo.className = dictionary2[key];
							list.Add(widgetInfo);
							num = (short)149684229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_520;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_90;
							}
							continue;
						case 7:
						{
							string key;
							if (dictionary.ContainsKey(key))
							{
								num = (short)1784020992;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_ED:
						num = (short)1747795226;
						short num3 = num;
						num = (short)788741402;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_90:
							goto IL_ED;
						default:
							num = (short)1572601856;
							if (num != 0)
							{
							}
							num = (short)1194131458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_520:
						num = (short)101777409;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_539:;
				}
				finally
				{
					num = (short)1071251457;
					if (num != 0)
					{
					}
					((global::System.IDisposable)enumerator).Dispose();
				}
				num = (short)296812544;
				short num4 = num;
				return list;
			}
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000167CC File Offset: 0x000149CC
		private static global::System.Collections.Generic.Dictionary<string, string> c(string A_0)
		{
			int a_ = 1;
			short num = (short)2011103232;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)497942528;
				short num3 = num;
				global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
				string value = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("畔睖祘筚絜罞①奢", a_);
				string value2 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("畔睖祘筚絜罞①奢䕤ᕦ౨ࡪ࡬ٮݰᙲݴ", a_);
				string value3 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("畔睖祘筚絜罞䅠䍢⑤嵦䥨੪ͬ୮Ͱᱲᱴ፶䍸ᕺᱼቾ", a_);
				string value4 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("畔睖祘筚絜罞䅠䍢⁤嵦䥨٪࡬᭮ၰ干ᅴᙶ൸᩺", a_);
				string value5 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("畔睖祘筚絜罞䅠䍢䕤䝦⡨兪䵬๮ὰᝲݴᡶၸὺ䝼ᅾ", a_);
				string value6 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("畔睖祘筚絜罞䅠䍢䕤䝦⡨兪䵬๮ὰᝲݴᡶၸὺ䝼ൾﮈ", a_);
				global::System.Diagnostics.Process process = new global::System.Diagnostics.Process();
				global::System.Collections.Generic.Dictionary<string, string> result;
				try
				{
					num = (short)1600426357;
					short num4 = num;
					num = (short)489656693;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1631453184;
						if (num != 0)
						{
						}
						process.StartInfo.FileName = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㑔㙖⥘⽚獜㩞ᥠ٢", a_);
						process.StartInfo.RedirectStandardInput = true;
						process.StartInfo.RedirectStandardOutput = true;
						process.StartInfo.UseShellExecute = false;
						process.StartInfo.Arguments = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ㅔ睖⅘㙚ㅜ⭞፠٢d䝦䭨ၪ嵬ቮ印卲㑴᥶ᵸॺቼᙾ캂ﲎ붒殺", a_), A_0);
						process.StartInfo.StandardOutputEncoding = global::System.Text.Encoding.UTF8;
						process.StartInfo.CreateNoWindow = true;
						process.Start();
						global::System.IO.StreamReader standardOutput = process.StandardOutput;
						try
						{
							switch (0)
							{
							case 0:
								goto IL_238;
							}
							string value7;
							bool flag;
							bool flag2;
							bool flag3;
							for (;;)
							{
								IL_1A9:
								switch (num2)
								{
								case 0:
									process.WaitForExit();
									process.Close();
									standardOutput.Close();
									num = (short)1180565510;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									string text;
									global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(text, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("睔ୖ੘灚罜", a_));
									value7 = match.Value.Substring(1, match.Value.Length - 2);
									num = (short)689831952;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									flag = false;
									flag2 = false;
									flag3 = false;
									num = (short)989069329;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_5B4;
								case 4:
								{
									string text;
									if (text.StartsWith(value2, global::System.StringComparison.OrdinalIgnoreCase))
									{
										num = (short)945422360;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4B8;
								}
								case 5:
									flag3 = true;
									num = (short)1509097493;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_71B;
								case 7:
									if (flag)
									{
										num = (short)1915813908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5B4;
								case 8:
								{
									string text;
									if (text.StartsWith(value, global::System.StringComparison.OrdinalIgnoreCase))
									{
										num = (short)342622237;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_476;
								}
								case 9:
									num = (short)1857224734;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									string text;
									if ((text = standardOutput.ReadLine()) == null)
									{
										num = (short)1075314688;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1914372104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									string text;
									string key = text.Substring(text.IndexOf(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("桔᝖", a_), global::System.StringComparison.OrdinalIgnoreCase) + 2).Trim();
									dictionary.Add(key, value7);
									num = (short)1981153293;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									string text;
									if (text.StartsWith(value4, global::System.StringComparison.OrdinalIgnoreCase))
									{
										num = (short)1295581203;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5B4;
								}
								case 13:
									goto IL_3D0;
								case 14:
								{
									string text;
									if (text.StartsWith(value6, global::System.StringComparison.OrdinalIgnoreCase))
									{
										num = (short)1395589131;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D0;
								}
								case 15:
									num = (short)1520762894;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									goto IL_538;
								case 17:
									goto IL_476;
								case 18:
									num = (short)1233977366;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									flag2 = true;
									num = (short)1896742915;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									num = (short)164691980;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									goto IL_57A;
								case 22:
								{
									string text;
									if (text.StartsWith(value5, global::System.StringComparison.OrdinalIgnoreCase))
									{
										num = (short)33488905;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_57A;
								}
								case 23:
									num = (short)686030873;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									flag = true;
									num = (short)307232799;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
								{
									string text;
									if (text.StartsWith(value3, global::System.StringComparison.OrdinalIgnoreCase))
									{
										num = (short)1953824769;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_538;
								}
								case 26:
									goto IL_3D0;
								case 27:
									if (flag && flag2)
									{
										num = (short)767164434;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_57A;
								case 28:
									if (flag && flag2 && flag3)
									{
										num = (short)939130895;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D0;
								case 29:
									num = (short)430571553;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
								{
									string text;
									if (text.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("桔畖㡘㕚㥜ⵞ๠੢Ť䥦ࡨ᭪ᵬᡮᡰᝲቴቶ൸啺ർൾ力꾌", a_)))
									{
										num = (short)1463222277;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_57A;
								}
								case 31:
									goto IL_4B8;
								case 32:
									if (flag)
									{
										num = (short)87883799;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_538;
								case 33:
								{
									string text;
									if (!text.StartsWith(value2, global::System.StringComparison.OrdinalIgnoreCase))
									{
										num = (short)1877671938;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_476;
								}
								}
								goto IL_238;
								IL_3D0:
								num = (short)308412426;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_476:
								num = (short)2096758788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4B8:
								num = (short)592969735;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_538:
								num = (short)1942487068;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_57A:
								num = (short)1047724064;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5B4:
								num = (short)559874075;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_71B:
							break;
							IL_238:
							value7 = string.Empty;
							flag = false;
							flag2 = false;
							flag3 = false;
							num = (short)1736048666;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1A9;
						}
						finally
						{
							num = (short)441188352;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_751;
									}
									continue;
								case 1:
									((global::System.IDisposable)standardOutput).Dispose();
									num = (short)654704642;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_789;
								}
								IL_751:
								if (standardOutput == null)
								{
									break;
								}
								num = (short)494796801;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_789:;
						}
						break;
					}
					}
					result = dictionary;
				}
				finally
				{
					num = (short)501940224;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_7C4;
							}
							continue;
						case 1:
							((global::System.IDisposable)process).Dispose();
							num = (short)984678402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_7FC;
						}
						IL_7C4:
						if (process == null)
						{
							break;
						}
						num = (short)1959657473;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_7FC:;
				}
				num = (short)2110128129;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00017038 File Offset: 0x00015238
		private static global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> b(string A_0)
		{
			int a_ = 4;
			short num = (short)354484224;
			switch (num)
			{
			default:
			{
				num = (short)1250754560;
				short num2 = num;
				num = (short)1606746113;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>();
				global::System.Diagnostics.Process process = new global::System.Diagnostics.Process();
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> result;
				try
				{
					num = (short)1583042403;
					short num3 = num;
					num = (short)1668370275;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1577975808;
						if (num != 0)
						{
						}
						process.StartInfo.FileName = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㥗㭙ⱛ⩝也ݡᱣͥ", a_);
						process.StartInfo.RedirectStandardInput = true;
						process.StartInfo.RedirectStandardOutput = true;
						process.StartInfo.UseShellExecute = false;
						process.StartInfo.Arguments = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㱗穙煛獝ᙟ͡ࡣ፥൧ᥩ䱫ᱭᕯű᭳͵੷᥹᥻ൽꁿꂁﾃ뚅ꢉ", a_), A_0);
						process.StartInfo.StandardOutputEncoding = global::System.Text.Encoding.UTF8;
						process.StartInfo.CreateNoWindow = true;
						process.Start();
						global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ٗٙ⽛畝቟ݡᝣ॥ᵧᡩཫ୭Ɐű彳幵䝷䙹⹻㭽퍿\udd81춃슅뚇몉햍ꂏ뾑궓떗ﲙ\udd9b뎝ﾡ辣辥蚧膩隫蚭풯삱햳솵\ud9b7\ud8b9킻\udbbd뻁볃ꯅ꓇", a_));
						global::System.Text.RegularExpressions.Regex regex2 = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ٗٙ⽛畝也䥡䙣乥坧噩㹫⭭⍯⵱≳㝵㑷⽹㥻䁽깿ꦁ궃ꒅ", a_));
						global::System.IO.StreamReader standardOutput = process.StandardOutput;
						try
						{
							num = (short)610992134;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									goto IL_40F;
								case 1:
								{
									global::System.Text.RegularExpressions.Match match;
									if (match.Success)
									{
										num = (short)2038497291;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_3E4;
								case 5:
								{
									string input;
									if ((input = standardOutput.ReadLine()) != null)
									{
										num = (short)1355612172;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3E4;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1E6;
									}
									continue;
								case 7:
								{
									string key;
									string item;
									dictionary[key].Add(item);
									num = (short)1502740483;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									string key;
									if (dictionary.ContainsKey(key))
									{
										num = (short)450625543;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									string item;
									dictionary.Add(key, new global::System.Collections.Generic.List<string>
									{
										item
									});
									num = (short)65994756;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									string input;
									if ((input = standardOutput.ReadLine()) == null)
									{
										num = (short)2102984706;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Text.RegularExpressions.Match match = regex.Match(input);
									num = (short)462553089;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::System.Text.RegularExpressions.Match match2;
									if (match2.Success)
									{
										num = (short)2096693261;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
									num = (short)1574371333;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									string input;
									global::System.Text.RegularExpressions.Match match2 = regex2.Match(input);
									num = (short)1363476490;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
								{
									global::System.Text.RegularExpressions.Match match;
									string key = match.Groups[global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("੗Ὑཛŝ⥟♡", a_)].ToString();
									global::System.Text.RegularExpressions.Match match2;
									string item = match2.Groups[global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("੗Ὑཛŝ㙟⍡⡣㍥ⵧ", a_)].ToString();
									num = (short)1468203016;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_263:
								num = (short)1922957321;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E6:
								goto IL_263;
								IL_3E4:
								process.WaitForExit();
								process.Close();
								standardOutput.Close();
								num = (short)182648832;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_40F:;
						}
						finally
						{
							num = (short)1172176896;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_444;
									}
									continue;
								case 1:
									((global::System.IDisposable)standardOutput).Dispose();
									num = (short)2139357186;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_47C;
								}
								IL_444:
								if (standardOutput == null)
								{
									break;
								}
								num = (short)1498087425;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_47C:;
						}
						break;
					}
					}
					result = dictionary;
				}
				finally
				{
					num = (short)1143406592;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_4B6;
							}
							continue;
						case 1:
							((global::System.IDisposable)process).Dispose();
							num = (short)563544066;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_4ED;
						}
						IL_4B6:
						if (process == null)
						{
							break;
						}
						num = (short)286261249;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_4ED:;
				}
				return result;
			}
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0001756C File Offset: 0x0001576C
		private static string a(string A_0)
		{
			int a_ = 14;
			short num = (short)1201340417;
			if (num != 0)
			{
			}
			num = (short)1360461824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6A;
				}
				string text;
				string result;
				for (;;)
				{
					IL_57:
					global::System.Diagnostics.Process process;
					switch (num2)
					{
					case 0:
						if (string.IsNullOrWhiteSpace(A_0))
						{
							num = (short)206700545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_267;
					case 1:
						goto IL_A7;
					case 2:
						try
						{
							num = (short)1437572744;
							short num3 = num;
							num = (short)1093836424;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)563871744;
								if (num != 0)
								{
								}
								process.StartInfo.FileName = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("͡գᙥᱧ䑩५᙭ᕯ", a_);
								process.StartInfo.RedirectStandardInput = true;
								process.StartInfo.RedirectStandardOutput = true;
								process.StartInfo.UseShellExecute = false;
								process.StartInfo.Arguments = A_0;
								process.StartInfo.StandardOutputEncoding = global::System.Text.Encoding.UTF8;
								process.StartInfo.CreateNoWindow = true;
								process.Start();
								global::System.IO.StreamReader standardOutput = process.StandardOutput;
								try
								{
									text = standardOutput.ReadToEnd();
									process.WaitForExit();
									process.Close();
									standardOutput.Close();
								}
								finally
								{
									num = (short)620494848;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_1BB;
											}
											continue;
										case 1:
											((global::System.IDisposable)standardOutput).Dispose();
											num = (short)1616576514;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_1F3;
										}
										IL_1BB:
										if (standardOutput == null)
										{
											break;
										}
										num = (short)1674575873;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_1F3:;
								}
								break;
							}
							}
							result = text;
							goto IL_290;
						}
						finally
						{
							num = (short)479526912;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_22F;
									}
									continue;
								case 1:
									((global::System.IDisposable)process).Dispose();
									num = (short)783548418;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_264;
								}
								IL_22F:
								if (process == null)
								{
									break;
								}
								num = (short)60489729;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_264:;
						}
						goto IL_267;
					}
					goto IL_6A;
					IL_267:
					process = new global::System.Diagnostics.Process();
					num = (short)212271106;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A7:
				throw new global::System.ArgumentNullException();
				IL_290:
				num = (short)61997056;
				short num4 = num;
				return result;
				IL_6A:
				text = string.Empty;
				num = (short)1346633728;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_57;
			}
			}
		}

		// Token: 0x0400003A RID: 58
		private const string a = "localhost";

		// Token: 0x0400003B RID: 59
		private const int b = 0;

		// Token: 0x0400003C RID: 60
		public const string TTSLANGPACKPREFIX = "TTSLANGPACK_";

		// Token: 0x0200001B RID: 27
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060000C3 RID: 195 RVA: 0x0001787C File Offset: 0x00015A7C
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.ValidatedField A_0)
			{
				short num = (short)1364920006;
				short num2 = num;
				num = (short)1030883014;
				switch (num2 == num)
				{
				default:
				{
					num = (short)228261888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)774635520;
				if (num != 0)
				{
				}
				num = (short)541655041;
				if (num != 0)
				{
				}
				return A_0.Uuid == this.a.Uuid;
			}

			// Token: 0x0400003D RID: 61
			public global::Motorola.CommonCPS.Server.EntityModel.ValidatedField a;
		}

		// Token: 0x0200001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x060000C5 RID: 197 RVA: 0x00017950 File Offset: 0x00015B50
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.ValidatedField A_0)
			{
				short num = (short)305051405;
				short num2 = num;
				num = (short)733984525;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2067333120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1719205888;
				if (num != 0)
				{
				}
				num = (short)1367867393;
				if (num != 0)
				{
				}
				return this.a.Equals(A_0.Uuid);
			}

			// Token: 0x0400003E RID: 62
			public global::System.Guid a;
		}

		// Token: 0x0200001D RID: 29
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x060000C7 RID: 199 RVA: 0x00017A20 File Offset: 0x00015C20
			internal bool b(string A_0)
			{
				short num = (short)1936505888;
				short num2 = num;
				num = (short)648920096;
				switch (num2 == num)
				{
				default:
				{
					num = (short)999358464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1340866561;
				if (num != 0)
				{
				}
				num = (short)935067648;
				if (num != 0)
				{
				}
				return A_0.Equals(this.a, global::System.StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x0400003F RID: 63
			public string a;
		}
	}
}
