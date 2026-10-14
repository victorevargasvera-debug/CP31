using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200001B RID: 27
	public static class CopyPasteUtility
	{
		// Token: 0x060000AF RID: 175 RVA: 0x0000A348 File Offset: 0x00008548
		public static bool IsSecuritySet(string name)
		{
			int a_ = 17;
			short num = (short)249152650;
			short num2 = num;
			num = (short)1509606538;
			switch (num2 == num)
			{
			}
			num = (short)2023358465;
			if (num != 0)
			{
			}
			num = (short)1073283072;
			if (num != 0)
			{
			}
			num = (short)1939865600;
			short num3 = num;
			return name == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ὃ⭍㍏❑♓㽕ⱗ⍙", a_);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000A410 File Offset: 0x00008610
		public static bool IsIdentifiedByColumn(global::Motorola.CommonCPS.RadioManagement.UIModels.Set row)
		{
			short num = (short)1163476483;
			short num2 = num;
			num = (short)2027175427;
			switch (num2 == num)
			{
			}
			num = (short)1883701249;
			if (num != 0)
			{
			}
			num = (short)1738539008;
			if (num != 0)
			{
			}
			num = (short)1979973632;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.a(row.SetType);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000A4C4 File Offset: 0x000086C4
		private static bool a(string setType)
		{
			short num = (short)1944890404;
			short num2 = num;
			num = (short)756722724;
			switch (num2 == num)
			{
			}
			num = (short)172490752;
			if (num != 0)
			{
			}
			num = (short)1510342657;
			if (num != 0)
			{
			}
			num = (short)1934753792;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.a.ContainsKey(setType);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000A578 File Offset: 0x00008778
		public static bool IsIdentifiedByAlias(global::Motorola.CommonCPS.RadioManagement.UIModels.Set set)
		{
			short num = (short)725108040;
			short num2 = num;
			num = (short)1282884936;
			switch (num2 == num)
			{
			}
			num = (short)1808072704;
			if (num != 0)
			{
			}
			num = (short)552140801;
			if (num != 0)
			{
			}
			num = (short)1478098944;
			short num3 = num;
			return !string.Equals(set.Alias, set.Name);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000A634 File Offset: 0x00008834
		public static global::System.Xml.Linq.XElement GetMatchXElement(global::Motorola.CommonCPS.RadioManagement.UIModels.Set set, global::System.Xml.Linq.XElement parent, global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory, bool isSubSet)
		{
			short num = (short)2145845248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_D7;
				}
				global::System.Func<global::System.Xml.Linq.XElement, bool> predicate;
				for (;;)
				{
					IL_27:
					num = (short)1407528651;
					short num3 = num;
					num = (short)5844683;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_37F;
					default:
					{
						num = (short)624754688;
						short num4 = num;
						num = (short)1830944768;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							num = (short)405602308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1DD;
						case 2:
							if (global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.IsIdentifiedByAlias(CS$<>8__locals1.CS$<>8__locals2.set))
							{
								num = (short)843513866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							predicate = delegate(global::System.Xml.Linq.XElement xEl)
							{
								int a_ = 1;
								short num5 = (short)334626819;
								int num6 = (int)((global::System.IntPtr)num5);
								global::System.Xml.Linq.XAttribute xattribute;
								for (;;)
								{
									string text;
									string text2;
									switch (num6)
									{
									case 0:
										xattribute = xEl.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("唻倽␿❁㱃", a_));
										if (xattribute == null)
										{
											num5 = (short)532480002;
											num6 = (int)((global::System.IntPtr)num5);
											continue;
										}
										goto IL_231;
									case 1:
										num5 = (short)1322385408;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
									case 2:
										goto IL_22E;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_4D;
										}
										continue;
									case 4:
										text = null;
										goto IL_8B;
									case 5:
										num5 = (short)1477443591;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
									case 6:
										num5 = (short)1303117825;
										if (num5 != 0)
										{
										}
										text2 = null;
										goto IL_1B5;
									case 7:
									{
										num5 = (short)1266860057;
										short num7 = num5;
										num5 = (short)345948185;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											return false;
										default:
										{
											num5 = (short)2043346944;
											short num8 = num5;
											num5 = (short)848494592;
											if (num5 != 0)
											{
											}
											global::System.Xml.Linq.XAttribute xattribute2 = xEl.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("圻嬽㤿", a_));
											if (xattribute2 == null)
											{
												num5 = (short)1719533574;
												num6 = (int)((global::System.IntPtr)num5);
												continue;
											}
											text2 = xattribute2.Value;
											goto IL_1B5;
										}
										}
										break;
									}
									}
									IL_4D:
									global::System.Xml.Linq.XAttribute xattribute3 = xEl.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("刻弽ⴿ❁", a_));
									if (xattribute3 == null)
									{
										num5 = (short)1205796868;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
									}
									text = xattribute3.Value;
									IL_8B:
									if (string.Equals(text, CS$<>8__locals1.CS$<>8__locals2.set.SetType))
									{
										num5 = (short)276430853;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
									}
									return false;
									IL_1B5:
									if (!string.Equals(text2, CS$<>8__locals1.setKeyFieldVal))
									{
										return false;
									}
									num5 = (short)1549271041;
									num6 = (int)((global::System.IntPtr)num5);
								}
								IL_22E:
								string text3 = null;
								goto IL_238;
								IL_231:
								text3 = xattribute.Value;
								IL_238:
								return string.Equals(text3, CS$<>8__locals1.CS$<>8__locals2.set.Position.ToString());
							};
							num = (short)950403079;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							if (global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.IsIdentifiedByColumn(set))
							{
								num = (short)67895308;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string fieldName = "";
							global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase = set.Fields[fieldName];
							num = (short)1709703181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							if (global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.IsIdentifiedByAlias(set))
							{
								num = (short)1489567749;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							predicate = delegate(global::System.Xml.Linq.XElement xEl)
							{
								int a_ = 12;
								short num5 = (short)2058436251;
								short num6 = num5;
								num5 = (short)1836596891;
								switch (num6 == num5)
								{
								}
								num5 = (short)1153630209;
								if (num5 != 0)
								{
								}
								num5 = (short)849281024;
								short num7 = num5;
								num5 = (short)783024128;
								if (num5 != 0)
								{
								}
								global::System.Xml.Linq.XAttribute xattribute = xEl.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("⥆⡈♊⡌", a_));
								return string.Equals((xattribute != null) ? xattribute.Value : null, set.SetType);
							};
							num = (short)1102839809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							predicate = delegate(global::System.Xml.Linq.XElement xEl)
							{
								int a_ = 17;
								short num5 = (short)2143944708;
								int num6 = (int)((global::System.IntPtr)num5);
								global::System.Xml.Linq.XAttribute xattribute;
								for (;;)
								{
									string text;
									switch (num6)
									{
									case 0:
										goto IL_131;
									case 1:
										text = null;
										goto IL_14F;
									case 2:
										num5 = (short)691798016;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
									case 3:
										goto IL_19B;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_41;
										}
										continue;
									}
									IL_41:
									num5 = (short)434538336;
									short num7 = num5;
									num5 = (short)635733856;
									switch ((num7 == num5) ? 1 : 0)
									{
									case 0:
									case 2:
										IL_131:
										xattribute = xEl.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ⵋ≍㥏㍑❓", a_));
										if (xattribute == null)
										{
											num5 = (short)1459421187;
											num6 = (int)((global::System.IntPtr)num5);
											continue;
										}
										goto IL_17B;
									default:
									{
										num5 = (short)1846476800;
										short num8 = num5;
										num5 = (short)362741760;
										if (num5 != 0)
										{
										}
										num5 = (short)1235222529;
										if (num5 != 0)
										{
										}
										global::System.Xml.Linq.XAttribute xattribute2 = xEl.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("≋⽍㵏㝑", a_));
										if (xattribute2 == null)
										{
											num5 = (short)1989672961;
											num6 = (int)((global::System.IntPtr)num5);
											continue;
										}
										text = xattribute2.Value;
										break;
									}
									}
									IL_14F:
									if (!string.Equals(text, set.SetType))
									{
										return false;
									}
									num5 = (short)1599275010;
									num6 = (int)((global::System.IntPtr)num5);
								}
								IL_17B:
								string text2 = xattribute.Value;
								goto IL_19E;
								IL_19B:
								text2 = null;
								IL_19E:
								return string.Equals(text2, set.Alias);
							};
							num = (short)1484521481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_2F6;
						case 7:
							goto IL_2CA;
						case 8:
							if (!isSubSet)
							{
								num = (short)72286208;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1832321027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_37F;
						case 10:
							predicate = delegate(global::System.Xml.Linq.XElement xEl)
							{
								int a_ = 2;
								short num5 = (short)1927806977;
								if (num5 != 0)
								{
								}
								num5 = (short)592642051;
								int num6 = (int)((global::System.IntPtr)num5);
								global::System.Xml.Linq.XAttribute xattribute;
								for (;;)
								{
									string text;
									string text2;
									switch (num6)
									{
									case 0:
										xattribute = xEl.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("尼匾⡀≂㙄", a_));
										if (xattribute == null)
										{
											num5 = (short)2118778882;
											num6 = (int)((global::System.IntPtr)num5);
											continue;
										}
										goto IL_234;
									case 1:
										num5 = (short)2080047104;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
									case 2:
										goto IL_231;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_76;
										}
										continue;
									case 4:
										text = null;
										goto IL_B3;
									case 5:
										num5 = (short)971898887;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
									case 6:
										text2 = null;
										goto IL_1B6;
									case 7:
									{
										num5 = (short)2037947802;
										short num7 = num5;
										num5 = (short)588160410;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											return false;
										case 1:
											break;
										default:
										{
											num5 = (short)832372736;
											short num8 = num5;
											break;
										}
										}
										num5 = (short)1969094656;
										if (num5 != 0)
										{
										}
										global::System.Xml.Linq.XAttribute xattribute2 = xEl.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("嘼娾㡀", a_));
										if (xattribute2 == null)
										{
											num5 = (short)1198194694;
											num6 = (int)((global::System.IntPtr)num5);
											continue;
										}
										text2 = xattribute2.Value;
										goto IL_1B6;
									}
									}
									IL_76:
									global::System.Xml.Linq.XAttribute xattribute3 = xEl.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("匼帾ⱀ♂", a_));
									if (xattribute3 == null)
									{
										num5 = (short)1940062212;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
									}
									text = xattribute3.Value;
									IL_B3:
									if (string.Equals(text, CS$<>8__locals1.CS$<>8__locals2.set.SetType))
									{
										num5 = (short)298516485;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
									}
									return false;
									IL_1B6:
									if (!string.Equals(text2, CS$<>8__locals1.setKeyFieldVal))
									{
										return false;
									}
									num5 = (short)1890254849;
									num6 = (int)((global::System.IntPtr)num5);
								}
								IL_231:
								string text3 = null;
								goto IL_23B;
								IL_234:
								text3 = xattribute.Value;
								IL_23B:
								return string.Equals(text3, CS$<>8__locals1.CS$<>8__locals2.set.Alias);
							};
							num = (short)1051066374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_29F;
						case 12:
						{
							num = (short)2112225281;
							if (num != 0)
							{
							}
							string setKeyColumn = global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.a[set.SetType];
							global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase, bool> <>9__3;
							global::System.Func<global::System.Xml.Linq.XElement, bool> <>9__4;
							predicate = delegate(global::System.Xml.Linq.XElement xEl)
							{
								short num5 = (short)1549402113;
								if (num5 != 0)
								{
								}
								num5 = (short)613670964;
								short num6 = num5;
								num5 = (short)1664016436;
								switch (num6 == num5)
								{
								}
								num5 = (short)1093533696;
								short num7 = num5;
								num5 = (short)917307392;
								if (num5 != 0)
								{
								}
								global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase> fields = set.Fields;
								global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase, bool> predicate2;
								if ((predicate2 = <>9__3) == null)
								{
									predicate2 = (<>9__3 = delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase field)
									{
										short num8 = (short)70756762;
										short num9 = num8;
										num8 = (short)569485722;
										switch (num9 == num8)
										{
										}
										num8 = (short)1346568192;
										if (num8 != 0)
										{
										}
										num8 = (short)38862848;
										short num10 = num8;
										num8 = (short)86638593;
										if (num8 != 0)
										{
										}
										return string.Equals(field.Name, setKeyColumn);
									});
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase2 = fields.FirstOrDefault(predicate2);
								string text = (fieldBase2 != null) ? fieldBase2.ValueForCompare : null;
								global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> source = xEl.Elements();
								global::System.Func<global::System.Xml.Linq.XElement, bool> predicate3;
								if ((predicate3 = <>9__4) == null)
								{
									predicate3 = (<>9__4 = delegate(global::System.Xml.Linq.XElement field)
									{
										int a_ = 8;
										short num8 = (short)594717363;
										short num9 = num8;
										num8 = (short)464825011;
										switch (num9 == num8)
										{
										}
										num8 = (short)1104609281;
										if (num8 != 0)
										{
										}
										num8 = (short)1735196672;
										short num10 = num8;
										num8 = (short)1018626048;
										if (num8 != 0)
										{
										}
										global::System.Xml.Linq.XAttribute xattribute = field.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ⵂ⑄⩆ⱈ", a_));
										return string.Equals((xattribute != null) ? xattribute.Value : null, setKeyColumn);
									});
								}
								global::System.Xml.Linq.XElement xelement = source.FirstOrDefault(predicate3);
								return string.Equals(text, (xelement != null) ? xelement.Value : null);
							};
							num = (short)614858763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
							CS$<>8__locals1.setKeyFieldVal = ((fieldBase is global::Motorola.CommonCPS.RadioManagement.UIModels.NullField) ? null : fieldBase.ToString());
							num = (short)1127022594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_D7;
					}
					}
				}
				IL_1DD:
				IL_29F:
				IL_2CA:
				IL_2F6:
				IL_37F:
				return parent.Elements().FirstOrDefault(predicate);
				IL_D7:
				num = (short)1158217736;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000A9D4 File Offset: 0x00008BD4
		public static string GetSetMatchingAttribute(global::System.Xml.Linq.XElement setXElement)
		{
			int a_ = 11;
			global::System.Xml.Linq.XElement xelement;
			string result;
			for (;;)
			{
				IL_09:
				short num = (short)1731854336;
				switch (num)
				{
				default:
				{
					num = (short)1913782281;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string text;
						string text2;
						string text3;
						string text4;
						switch (num2)
						{
						case 0:
							if (text == null)
							{
								num = (short)1379860485;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)151453697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.a(text))
							{
								num = (short)1383661581;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1807876100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)845545486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							xelement = setXElement.Elements(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("⁅ⅇ⽉⁋⩍", a_)).FirstOrDefault(delegate(global::System.Xml.Linq.XElement f)
							{
								int a_2 = 13;
								short num5 = (short)23823014;
								short num6 = num5;
								num5 = (short)1398309542;
								switch (num6 == num5)
								{
								}
								num5 = (short)703660032;
								if (num5 != 0)
								{
								}
								num5 = (short)1479606272;
								short num7 = num5;
								num5 = (short)252772353;
								if (num5 != 0)
								{
								}
								global::System.Xml.Linq.XAttribute xattribute3 = f.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("♇⭉⅋⭍", a_2));
								return ((xattribute3 != null) ? xattribute3.Value : null) == CS$<>8__locals1.setKeyColumn;
							});
							if (xelement == null)
							{
								num = (short)795344903;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_280;
						case 4:
						{
							global::System.Xml.Linq.XAttribute xattribute = setXElement.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("❅⑇⍉ⵋ㵍", a_));
							if (xattribute == null)
							{
								num = (short)1658650635;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text2 = xattribute.Value;
							goto IL_2E4;
						}
						case 5:
							goto IL_1C3;
						case 6:
							text3 = null;
							goto IL_18F;
						case 7:
							goto IL_27D;
						case 8:
						{
							global::System.Xml.Linq.XAttribute xattribute2 = setXElement.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("⡅⥇❉⥋", a_));
							if (xattribute2 == null)
							{
								num = (short)159514630;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text3 = xattribute2.Value;
							goto IL_18F;
						}
						case 9:
						{
							num = (short)940965888;
							short num3 = num;
							switch (0)
							{
							case 0:
								goto IL_B7;
							}
							continue;
						}
						case 10:
							goto IL_345;
						case 11:
							text2 = null;
							goto IL_2E4;
						case 12:
							if ((result = text4) == null)
							{
								num = (short)907214858;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 13:
						{
							string setKeyColumn = global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.a[text];
							num = (short)182517763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
						{
							num = (short)744422444;
							short num4 = num;
							num = (short)1723464748;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)1756692480;
								if (num != 0)
								{
								}
								text3 = null;
								goto IL_18F;
							}
							break;
						}
						}
						IL_B7:
						if (setXElement == null)
						{
							num = (short)903675906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1906376712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_18F:
						text = text3;
						num = (short)1258684416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2E4:
						text4 = text2;
						num = (short)1138229249;
						if (num != 0)
						{
						}
						num = (short)1768751116;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_1C3:
			return null;
			IL_27D:
			return null;
			IL_280:
			return xelement.Value;
			IL_345:
			result = "";
			return result;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000AD30 File Offset: 0x00008F30
		public static string GetSetMatchingAttribute(global::Motorola.CommonCPS.RadioManagement.UIModels.Set set)
		{
			short num = (short)1327562753;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
			for (;;)
			{
				num = (short)1989804032;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_18F;
				case 1:
					goto IL_14;
				case 2:
					if (!string.Equals(set.Alias, set.Name))
					{
						num = (short)32702464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_191;
				case 3:
					fieldBase = set.Fields.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase f)
					{
						short num5 = (short)390685734;
						short num6 = num5;
						num5 = (short)1023501350;
						switch (num6 == num5)
						{
						}
						num5 = (short)1110900737;
						if (num5 != 0)
						{
						}
						num5 = (short)1624178688;
						short num7 = num5;
						num5 = (short)1140719616;
						if (num5 != 0)
						{
						}
						return f.Name == CS$<>8__locals1.setKeyColumn;
					});
					if (fieldBase == null)
					{
						num = (short)1293287428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13D;
				case 4:
					goto IL_13A;
				case 5:
				{
					string setKeyColumn = global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.a[set.SetType];
					num = (short)923323616;
					short num4 = num;
					num = (short)335400160;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)220266496;
						if (num != 0)
						{
						}
						num = (short)2135228419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_64;
				IL_14:
				switch (0)
				{
				case 0:
					IL_64:
					if (global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.IsIdentifiedByColumn(set))
					{
						num = (short)830865413;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1578434562;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_13A:
			return null;
			IL_13D:
			return fieldBase.ToString();
			IL_18F:
			return set.Alias;
			IL_191:
			num = (short)962854913;
			if (num != 0)
			{
			}
			return "";
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000AEFC File Offset: 0x000090FC
		public static bool ValidateSingleCategoryOnSingleCategory(global::System.Xml.Linq.XDocument doc, global::System.Collections.Generic.IDictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>> selection)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			short num2;
			global::System.Xml.Linq.XElement root;
			for (;;)
			{
				IL_13:
				global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>> keyValuePair;
				global::System.Xml.Linq.XElement xelement;
				global::System.Xml.Linq.XElement xelement2;
				string text;
				switch (num)
				{
				case 0:
					if (!global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.IsSecuritySet(keyValuePair.Key.Name))
					{
						num2 = (short)1110769672;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					if (xelement == null)
					{
						num2 = (short)822870019;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1240530955;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					xelement2 = null;
					goto IL_100;
				case 3:
					num2 = (short)1793392645;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					text = null;
					goto IL_1CB;
				case 5:
					text = null;
					goto IL_1CB;
				case 6:
					if (root == null)
					{
						num2 = (short)18677767;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)305856522;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1660420098;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_1C6;
				case 9:
					keyValuePair = selection.First<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>>();
					num2 = (short)317718528;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					xelement2 = root.Elements().First<global::System.Xml.Linq.XElement>();
					goto IL_100;
				case 11:
				{
					IL_C5:
					global::System.Xml.Linq.XAttribute xattribute = xelement.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("╊ⱌ≎㑐", a_));
					if (xattribute == null)
					{
						num2 = (short)66977796;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = xattribute.Value;
					goto IL_1CB;
				}
				}
				goto IL_49;
				IL_1CB:
				keyValuePair = selection.First<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>>();
				if (!(text == keyValuePair.Key.Name))
				{
					return false;
				}
				num2 = (short)369643261;
				short num3 = num2;
				num2 = (short)1107185405;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C5;
				default:
					num2 = (short)1778319360;
					if (num2 != 0)
					{
					}
					num2 = (short)1444347905;
					if (num2 != 0)
					{
					}
					num2 = (short)1005256713;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_100:
				xelement = xelement2;
				num2 = (short)1872887809;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1C6:
			num2 = (short)1584398336;
			short num4 = num2;
			return true;
			IL_49:
			root = doc.Root;
			num2 = (short)2096889862;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000B1AC File Offset: 0x000093AC
		public static bool ValidateConfiguration(global::System.Xml.Linq.XDocument doc)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			global::System.Xml.Linq.XElement root;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_140;
				case 1:
					goto IL_108;
				case 2:
					num2 = (short)639369217;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)2144923463;
					short num3 = num2;
					num2 = (short)413724487;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_108;
					default:
					{
						num2 = (short)1216217088;
						if (num2 != 0)
						{
						}
						num2 = (short)2027749376;
						short num4 = num2;
						if (root != null)
						{
							num2 = (short)554696706;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					}
					break;
				}
				}
				goto IL_29;
				IL_108:
				if (root.Elements(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ⵍㅏ♑ㅓㅕ㝗⡙╛", a_)).Count<global::System.Xml.Linq.XElement>() <= 1)
				{
					return false;
				}
				num2 = (short)1524498432;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_140:
			num2 = (short)2023686145;
			if (num2 != 0)
			{
			}
			return root.Elements().All(new global::System.Func<global::System.Xml.Linq.XElement, bool>(global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.a));
			IL_29:
			root = doc.Root;
			num2 = (short)825294851;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000B328 File Offset: 0x00009528
		private static bool e(global::System.Xml.Linq.XElement A_0)
		{
			int a_ = 8;
			short num = (short)259653633;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1A2;
				case 1:
					goto IL_1E;
				case 2:
					if (A_0.Name != global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("╂ⱄ≆╈⽊", a_))
					{
						num = (short)1568407552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)457572355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1841020034;
					short num3 = num;
					num = (short)1163115650;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E;
					default:
						num = (short)1981153280;
						if (num != 0)
						{
						}
						if (A_0.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ⵂ⑄⩆ⱈ", a_)) == null)
						{
							num = (short)368312324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					break;
				}
				case 4:
					return false;
				case 5:
					num = (short)724303874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_97;
				IL_1E:
				num = (short)914685953;
				if (num != 0)
				{
				}
				num = (short)1556283392;
				short num4 = num;
				switch (0)
				{
				case 0:
					IL_97:
					if (A_0 == null)
					{
						return false;
					}
					num = (short)523370501;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return false;
			IL_1A2:
			return false;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000B4DC File Offset: 0x000096DC
		private static bool d(global::System.Xml.Linq.XElement A_0)
		{
			int a_ = 6;
			short num = (short)493158402;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)534446080;
				short num3 = num;
				global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					goto IL_32E;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_72;
					}
					continue;
				case 3:
					try
					{
						num = (short)2077491203;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1922105349;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)297795591;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Xml.Linq.XElement xelement = enumerator.Current;
								num = (short)1291583496;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_185;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_FF;
								}
								continue;
							case 4:
								goto IL_1F6;
							case 5:
							{
								global::System.Xml.Linq.XElement xelement;
								if (xelement.Name != global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("㝀≂⥄㉆ⱈ", a_))
								{
									num = (short)319225862;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								goto IL_16B;
							case 7:
								num = (short)1633681412;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								global::System.Xml.Linq.XElement xelement;
								if (xelement != null)
								{
									num = (short)957612032;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_16B;
							}
							}
							IL_136:
							num = (short)1346371585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_FF:
							goto IL_136;
							IL_16B:
							result = false;
							num = (short)1325268994;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_185:
						return result;
						IL_1F6:
						return true;
					}
					finally
					{
						num = (short)1629880322;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							num = (short)763843449;
							short num4 = num;
							num = (short)1580880761;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)878379008;
								if (num != 0)
								{
								}
								switch (num2)
								{
								case 0:
									goto IL_2AE;
								case 1:
									enumerator.Dispose();
									num = (short)1973354496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_276;
									}
									continue;
								}
								break;
							}
							IL_276:
							if (enumerator == null)
							{
								break;
							}
							num = (short)262340609;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2AE:;
					}
					goto IL_2B1;
				case 4:
					if (A_0.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("⽀≂⡄≆", a_)) == null)
					{
						num = (short)65536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B1;
				case 5:
					if (A_0.Name != global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ⱀ㙂⥄㍆⁈ⵊ⑌⩎㵐㝒", a_))
					{
						num = (short)409731073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)45547524;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1190854657;
					if (num != 0)
					{
					}
					num = (short)333053957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_72:
				if (A_0 != null)
				{
					num = (short)205717510;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2B1:
				enumerator = A_0.Elements().GetEnumerator();
				num = (short)1608122371;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_32E:
			return false;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000B888 File Offset: 0x00009A88
		private static bool c(global::System.Xml.Linq.XElement A_0)
		{
			int a_ = 17;
			short num = (short)693043206;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
				switch (num2)
				{
				case 0:
					num = (short)1958805507;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_2DF;
				case 2:
					try
					{
						num = (short)627310598;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)1401341389;
								short num3 = num;
								num = (short)2125645261;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_15A;
								default:
								{
									num = (short)1146748928;
									if (num != 0)
									{
									}
									global::System.Xml.Linq.XElement a_2;
									if (!global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.b(a_2))
									{
										num = (short)916979714;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								break;
							}
							case 1:
								num = (short)1762197509;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_15A;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1571880961;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Xml.Linq.XElement a_2 = enumerator.Current;
								num = (short)1237385216;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_1B3;
							case 5:
								goto IL_1CF;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_D0;
								}
								continue;
							}
							goto IL_D0;
							IL_15A:
							result = false;
							num = (short)1130692612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_15C:
							num = (short)1447821315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_D0:
							goto IL_15C;
						}
						IL_1B3:
						return result;
						IL_1CF:
						return true;
					}
					finally
					{
						num = (short)467992578;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1314979841;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_237;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_204;
								}
								continue;
							}
							IL_204:
							if (enumerator == null)
							{
								break;
							}
							num = (short)392888320;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_237:;
					}
					goto IL_23A;
				case 3:
					if (A_0.Name != global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("⽋⅍㱏㹑ㅓ㕕ⱗ㍙㍛そ", a_))
					{
						num = (short)137428993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)950534148;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (A_0.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("≋⽍㵏㝑", a_)) == null)
					{
						num = (short)210698245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23A;
				case 5:
					return false;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				}
				IL_4A:
				if (A_0 != null)
				{
					num = (short)496107521;
					if (num != 0)
					{
					}
					num = (short)2075066368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_23A:
				enumerator = A_0.Elements().GetEnumerator();
				num = (short)1664614402;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_263:
			num = (short)2128019456;
			short num4 = num;
			return false;
			IL_2DF:
			goto IL_263;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000BBE4 File Offset: 0x00009DE4
		private static bool b(global::System.Xml.Linq.XElement A_0)
		{
			int a_ = 16;
			short num = (short)592248838;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1692139521;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
				switch (num2)
				{
				case 0:
					num = (short)2100428803;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_370;
				case 2:
					try
					{
						num = (short)276889610;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)1493866097;
								short num3 = num;
								num = (short)479696497;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1BC;
								default:
									num = (short)1959002112;
									if (num != 0)
									{
									}
									num = (short)357302274;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								num = (short)1394475017;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								global::System.Xml.Linq.XElement a_2;
								if (!global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.d(a_2))
								{
									num = (short)1875836933;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)833421313;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Xml.Linq.XElement a_2 = enumerator.Current;
								num = (short)1977417734;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_1BC;
							case 5:
								result = false;
								num = (short)34275332;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
							{
								global::System.Xml.Linq.XElement a_2;
								if (!global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.e(a_2))
								{
									num = (short)2036400135;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 7:
								num = (short)1910702088;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								global::System.Xml.Linq.XElement a_2;
								if (!global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.c(a_2))
								{
									num = (short)963837952;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 9:
								goto IL_25E;
							case 10:
								switch (0)
								{
								case 0:
									goto IL_DF;
								}
								continue;
							}
							IL_166:
							num = (short)54001667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_DF:
							goto IL_166;
						}
						IL_1BC:
						return result;
						IL_25E:
						return true;
					}
					finally
					{
						num = (short)2051735554;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1380450305;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_2C8;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_293;
								}
								continue;
							}
							IL_293:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1824129024;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2C8:;
					}
					goto IL_2CB;
				case 3:
					if (A_0.Name != global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("㡊⡌㭎", a_))
					{
						num = (short)777060353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)12124164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (A_0.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("╊ⱌ≎㑐", a_)) == null)
					{
						num = (short)1738014725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CB;
				case 5:
					return false;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					continue;
				}
				IL_70:
				if (A_0 != null)
				{
					num = (short)1291190272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2CB:
				enumerator = A_0.Elements().GetEnumerator();
				num = (short)1327169538;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2F3:
			num = (short)1079705600;
			short num4 = num;
			return false;
			IL_370:
			goto IL_2F3;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000BFD4 File Offset: 0x0000A1D4
		private static bool a(global::System.Xml.Linq.XElement A_0)
		{
			int a_ = 1;
			short num = (short)1695023105;
			if (num != 0)
			{
			}
			num = (short)494927878;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
				switch (num2)
				{
				case 0:
					num = (short)1695547395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_2E0;
				case 2:
					try
					{
						num = (short)1210908678;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)1852893786;
								short num3 = num;
								num = (short)1240853082;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_159;
								default:
								{
									num = (short)71434240;
									if (num != 0)
									{
									}
									global::System.Xml.Linq.XElement a_2;
									if (!global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.b(a_2))
									{
										num = (short)1735065602;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								break;
							}
							case 1:
								num = (short)2046623749;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_159;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)774438913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Xml.Linq.XElement a_2 = enumerator.Current;
								num = (short)1751973888;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_1B4;
							case 5:
								goto IL_1D0;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_D0;
								}
								continue;
							}
							goto IL_D0;
							IL_159:
							result = false;
							num = (short)981336068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_15B:
							num = (short)1051721731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_D0:
							goto IL_15B;
						}
						IL_1B4:
						return result;
						IL_1D0:
						return true;
					}
					finally
					{
						num = (short)1546321922;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)950796289;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_238;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_205;
								}
								continue;
							}
							IL_205:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1069809664;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_238:;
					}
					goto IL_23B;
				case 3:
					if (A_0.Name != global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("弻弽㐿❁⍃⥅㩇㍉", a_))
					{
						num = (short)2082603009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1255931908;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (A_0.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("刻弽ⴿ❁", a_)) == null)
					{
						num = (short)717029381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23B;
				case 5:
					return false;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					continue;
				}
				IL_70:
				if (A_0 != null)
				{
					num = (short)1461714944;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_23B:
				enumerator = A_0.Elements().GetEnumerator();
				num = (short)1932787714;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_263:
			num = (short)8454144;
			short num4 = num;
			return false;
			IL_2E0:
			goto IL_263;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000C334 File Offset: 0x0000A534
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.XmlContentType DetectXmlContent(global::System.Xml.Linq.XDocument doc)
		{
			int a_ = 0;
			short num = (short)1334837248;
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
				global::System.Xml.Linq.XElement root;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if (root.IsEmpty)
						{
							num = (short)673513475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1780547589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!(root.Name != global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("堺刼儾❀⩂≄", a_)))
						{
							num = (short)495124484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.CommonCPS.RadioManagement.UIModels.XmlContentType.None;
					case 2:
						goto IL_391;
					case 3:
						goto IL_2C2;
					case 4:
						num = (short)261816320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (root.Elements().Count<global::System.Xml.Linq.XElement>() == 1)
						{
							num = (short)616693769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator = root.Elements().GetEnumerator();
						num = (short)544538626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.a(root.Elements().First<global::System.Xml.Linq.XElement>()))
						{
							num = (short)1334509575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.CommonCPS.RadioManagement.UIModels.XmlContentType.None;
					case 7:
						goto IL_365;
					case 8:
						num = (short)1926496257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						num = (short)856489984;
						short num3 = num;
						num = (short)911147014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (root != null)
						{
							num = (short)1612578824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.CommonCPS.RadioManagement.UIModels.XmlContentType.None;
					}
					goto IL_63;
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.XmlContentType.SingleCategory;
				IL_2C2:
				return global::Motorola.CommonCPS.RadioManagement.UIModels.XmlContentType.None;
				IL_365:
				return global::Motorola.CommonCPS.RadioManagement.UIModels.XmlContentType.SingleCategory;
				IL_391:
				try
				{
					num = (short)87162886;
					num2 = (int)((global::System.IntPtr)num);
					global::Motorola.CommonCPS.RadioManagement.UIModels.XmlContentType result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)835505560;
							short num4 = num;
							num = (short)885247384;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_17F;
							default:
								goto IL_15D;
							}
							break;
						}
						case 1:
						{
							global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1932197892;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.Linq.XElement a_2 = enumerator.Current;
							goto IL_17F;
						}
						case 2:
						{
							global::System.Xml.Linq.XElement a_2;
							if (!global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.a(a_2))
							{
								num = (short)7864323;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							result = global::Motorola.CommonCPS.RadioManagement.UIModels.XmlContentType.None;
							num = (short)1208549376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)770441221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_211;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_10C;
							}
							continue;
						}
						goto IL_10C;
						IL_17F:
						num = (short)2007629826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BC:
						num = (short)1309999105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_10C:
						goto IL_1BC;
					}
					IL_15D:
					num = (short)1348730880;
					if (num != 0)
					{
					}
					return result;
					IL_211:
					return global::Motorola.CommonCPS.RadioManagement.UIModels.XmlContentType.Configuration;
				}
				finally
				{
					num = (short)1769340930;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)182779905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_281;
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
						num = (short)861929472;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_281:;
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.XmlContentType.SingleCategory;
				IL_63:
				num = (short)57671681;
				if (num != 0)
				{
				}
				root = doc.Root;
				num = (short)699727882;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000C764 File Offset: 0x0000A964
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.SelectedType DetectSelectedItemsType(global::System.Collections.Generic.IDictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>> selection)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			int count;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1748434953;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)764477440;
					short num3 = num2;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> value;
					if (value.Count == 1)
					{
						num2 = (short)2096431112;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.UIModels.SelectedType.MultipleSets;
				}
				case 2:
					goto IL_E1;
				case 3:
					num2 = (short)2079784962;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> value;
					if (value != null)
					{
						num2 = (short)1132462080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.UIModels.SelectedType.SingleCategory;
				}
				case 5:
				{
					if (count != 1)
					{
						num2 = (short)1831141379;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>> keyValuePair = selection.Single<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>>();
					num2 = (short)1019478022;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
				{
					global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>> keyValuePair;
					if (keyValuePair.Key.IsRoot)
					{
						num2 = (short)613875723;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					keyValuePair = selection.Single<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>>();
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> value = keyValuePair.Value;
					num2 = (short)575668228;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					goto IL_1EE;
				case 8:
					return global::Motorola.CommonCPS.RadioManagement.UIModels.SelectedType.SingleSet;
				case 9:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> value;
					if (value.Count == 0)
					{
						num2 = (short)1638072327;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)583729153;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					num2 = (short)1528430597;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_23B;
				case 12:
					if (count != 0)
					{
						num2 = (short)118030346;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.UIModels.SelectedType.None;
				}
				goto IL_44;
			}
			return global::Motorola.CommonCPS.RadioManagement.UIModels.SelectedType.SingleCategory;
			IL_E1:
			num2 = (short)1254752257;
			if (num2 != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.UIModels.SelectedType.MultipleCategories;
			IL_1EE:
			return global::Motorola.CommonCPS.RadioManagement.UIModels.SelectedType.SingleCategory;
			IL_23B:
			num2 = (short)134084944;
			short num4 = num2;
			num2 = (short)1562573136;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return global::Motorola.CommonCPS.RadioManagement.UIModels.SelectedType.SingleSet;
			default:
				num2 = (short)1815871488;
				if (num2 != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.SelectedType.Configuration;
			}
			IL_44:
			count = selection.Count;
			num2 = (short)1734541324;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000CA00 File Offset: 0x0000AC00
		// Note: this type is marked as 'beforefieldinit'.
		static CopyPasteUtility()
		{
			int a_ = 16;
			short num = (short)1382629126;
			short num2 = num;
			num = (short)420888326;
			switch (num2 == num)
			{
			}
			num = (short)1692663808;
			short num3 = num;
			num = (short)1501822977;
			if (num != 0)
			{
			}
			num = (short)1230766080;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.a = new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ъ⍌⩎Ր㱒⁔㑖ㅘᩚ㹜㱞Ѡၢᙤ⹦ᵨ๪lᱮ", a_),
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ъ᥌౎๐᭒ၔᙖᵘṚཛྷ", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ὂ⡌⍎㑐㹒ご⍖⭘≚ᅜ㙞በᝢⱤ፦౨٪Ṭ", a_),
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ὂࡌ͎๐᭒ၔᙖᵘṚཛྷ", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("يौ౎ɐ❒㑔⍖ⱘ⡚ᅜ㙞በᝢⱤ፦౨٪Ṭ", a_),
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᭊɌᱎᡐݒ᱔ᡖ᝘", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("يौ౎᱐㙒♔⑖㡘㱚㡜፞ࡠၢᅤ⹦ᵨ๪lᱮ", a_),
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᭊɌᱎᡐݒ᱔ᡖ᝘", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ɋौ୎㡐⁒╔㭖㡘≚ड़㹞͠རd", a_),
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᭊ㽌⩎㝐㩒ⵔࡖᡘ楚湜潞剠噢", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ࡊ≌ⅎ❐㙒㭔⍖じ㑚㍜㹞ൠⱢ୤ɦ㵨Ѫᡬ౮ᥰ", a_),
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ࡊ⍌㥎Ő㙒❔ᡖ㝘㹚ड़ぞᑠb൤╦ᱨὪᥬnὰⱲ㑴䙶䁸䱺䭼䩾", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ࡊ≌ⅎ═㉒㙔⍖ᵘ㩚⥜㹞⹠ᅢŤɦ᭨", a_),
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ṋ⹌⍎ِ㩒ㅔ㉖Ṙ㹚㍜^≠ౢ୤፦ࡨࡪᥬ⭮ၰݲᑴ㡶୸ὺ᡼ൾ\ude80슂떄랆릈뮊뢌", a_)
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᭊ์ᵎᵐ㉒㭔ざⱘ㩚㩜㩞ⵠ੢ᙤ፦", a_),
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("݊ⱌⅎ㙐♒㑔ざ㱘ቚᥜ", a_)
				}
			};
		}

		// Token: 0x0400004C RID: 76
		private static readonly global::System.Collections.Generic.Dictionary<string, string> a;
	}
}
