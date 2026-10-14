using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000BB RID: 187
	[global::System.Diagnostics.DebuggerDisplay("Label: {Label}")]
	public class CollectionField : global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase
	{
		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00068FE8 File Offset: 0x000671E8
		public int Count
		{
			get
			{
				short num = (short)716570624;
				short num2 = num;
				num = (short)1315461124;
				short num3 = num;
				num = (short)1966495748;
				switch (num3 == num)
				{
				}
				num = (short)1588985857;
				if (num != 0)
				{
				}
				num = (short)984088576;
				if (num != 0)
				{
				}
				return 0;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00069094 File Offset: 0x00067294
		public override bool IsValid
		{
			get
			{
				short num = (short)115277824;
				short num2 = num;
				num = (short)572493937;
				short num3 = num;
				num = (short)1337036913;
				switch (num3 == num)
				{
				}
				num = (short)1362558977;
				if (num != 0)
				{
				}
				num = (short)30146560;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00069140 File Offset: 0x00067340
		public override bool IsVisible
		{
			get
			{
				short num = (short)1371537408;
				short num2 = num;
				num = (short)1802970375;
				short num3 = num;
				num = (short)2052728071;
				switch (num3 == num)
				{
				}
				num = (short)197394432;
				if (num != 0)
				{
				}
				num = (short)1869414401;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x000691E8 File Offset: 0x000673E8
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00069298 File Offset: 0x00067498
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory SetCategory
		{
			get
			{
				short num = (short)1934426112;
				short num2 = num;
				num = (short)418639663;
				short num3 = num;
				num = (short)741076783;
				switch (num3 == num)
				{
				}
				num = (short)1244594176;
				if (num != 0)
				{
				}
				num = (short)2013265921;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1605894144;
				short num2 = num;
				num = (short)1286479231;
				short num3 = num;
				num = (short)1973951871;
				switch (num3 == num)
				{
				}
				num = (short)717750272;
				if (num != 0)
				{
				}
				num = (short)1705639937;
				if (num != 0)
				{
				}
				this.a = value;
				this.a.Parent = this;
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00069358 File Offset: 0x00067558
		public override void RaisePropertyChanged()
		{
			int a_ = 8;
			short num = (short)1821179904;
			short num2 = num;
			num = (short)1247495332;
			short num3 = num;
			num = (short)607077540;
			switch (num3 == num)
			{
			}
			num = (short)1604124673;
			if (num != 0)
			{
			}
			num = (short)40894464;
			if (num != 0)
			{
			}
			base.RaisePropertyChanged();
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("၂⁄㍆ੈ⩊㥌⩎㙐㱒❔⹖", a_));
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00069428 File Offset: 0x00067628
		public override void Accept(global::Motorola.CommonCPS.RadioManagement.UIModels.UIVisitor v, object context)
		{
			short num = (short)1705377792;
			short num2 = num;
			num = (short)1604077007;
			short num3 = num;
			num = (short)476530127;
			switch (num3 == num)
			{
			}
			num = (short)884146177;
			if (num != 0)
			{
			}
			num = (short)1756561408;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory = this.SetCategory;
			setCategory.Accept(v, context);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x000694E0 File Offset: 0x000676E0
		protected override global::System.Xml.Linq.XElement ToCopyOverride()
		{
			short num = (short)1247477760;
			short num2 = num;
			num = (short)627492253;
			short num3 = num;
			num = (short)1095615901;
			switch (num3 == num)
			{
			}
			num = (short)926089217;
			if (num != 0)
			{
			}
			num = (short)249364480;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00069590 File Offset: 0x00067790
		private global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult b(global::System.Xml.Linq.XElement A_0, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Xml.Linq.XElement>> A_1, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>> A_2, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.PasteContext A_3)
		{
			short num = (short)918552576;
			switch (num)
			{
			default:
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult pasteResult = global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Unchanged;
				global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.Set, int> dictionary = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.Set, int>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> enumerator = this.SetCategory.Sets.GetEnumerator();
				try
				{
					num = (short)359268353;
					if (num != 0)
					{
					}
					num = (short)253624322;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (this.SetCategory.IsSortSupported)
							{
								num = (short)792985604;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 1:
						{
							int value = this.SetCategory.Sets.Count - 1;
							global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
							dictionary.Add(set, value);
							num = (short)1043922951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_B4;
							}
							continue;
						case 3:
						{
							global::System.Xml.Linq.XElement matchXElement;
							if (matchXElement != null)
							{
								num = (short)312541189;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1117519880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::System.Xml.Linq.XElement matchXElement;
							int value2 = matchXElement.ElementsBeforeSelf().Count<global::System.Xml.Linq.XElement>();
							global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
							dictionary.Add(set, value2);
							num = (short)1614151689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
							global::System.Xml.Linq.XElement matchXElement;
							global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult pasteResult2 = set.PasteFrom(matchXElement, ref A_1, ref A_2, A_3);
							pasteResult |= pasteResult2;
							num = (short)956956672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)242548747;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.Set set = enumerator.Current;
							global::System.Xml.Linq.XElement matchXElement = global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.GetMatchXElement(set, A_0, this.SetCategory, true);
							num = (short)558235651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							if (this.SetCategory.IsSortSupported)
							{
								num = (short)1688338433;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 10:
							goto IL_267;
						case 11:
							num = (short)1075249162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_108:
						num = (short)1426915334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B4:
						goto IL_108;
					}
					IL_267:;
				}
				finally
				{
					num = (short)332050851;
					short num3 = num;
					num = (short)1695658403;
					int num2;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_30C:
						num = (short)484442112;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)157548544;
						if (num != 0)
						{
						}
						num = (short)1889927169;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_322;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2EB;
							}
							continue;
						case 2:
							goto IL_304;
						}
						IL_2EB:
						if (enumerator == null)
						{
							goto IL_324;
						}
						num = (short)787087362;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_304:
					enumerator.Dispose();
					goto IL_30C;
					IL_322:
					IL_324:;
				}
				num = (short)139198464;
				short num4 = num;
				this.a(dictionary);
				return pasteResult;
			}
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00069910 File Offset: 0x00067B10
		private void a(global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.Set, int> A_0)
		{
			short num = (short)1074593792;
			short num2 = num;
			num = (short)2076831059;
			short num3 = num;
			num = (short)1048112467;
			switch (num3 == num)
			{
			}
			num = (short)2108751872;
			if (num != 0)
			{
			}
			num = (short)1799421953;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000699B8 File Offset: 0x00067BB8
		private global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult a(global::System.Xml.Linq.XElement A_0, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Xml.Linq.XElement>> A_1, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>> A_2, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.PasteContext A_3)
		{
			int a_ = 9;
			short num = (short)2040987648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> enumerator;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> list;
				global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult pasteResult2;
				global::System.Collections.Generic.List<global::System.Tuple<string, string>> list2;
				global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.Set, int> dictionary;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						try
						{
							num = (short)1346502656;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_386;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1611661319;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.Set set = enumerator.Current;
									global::System.Xml.Linq.XElement matchXElement = global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.GetMatchXElement(set, A_0, this.SetCategory, true);
									num = (short)1694957573;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									if (this.SetCategory.IsSortSupported)
									{
										num = (short)1986985993;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
								{
									global::System.Xml.Linq.XElement matchXElement;
									if (matchXElement != null)
									{
										num = (short)1974468614;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
									list.Add(set);
									num = (short)568918018;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
									global::System.Xml.Linq.XElement matchXElement;
									global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult pasteResult = set.PasteFrom(matchXElement, ref A_1, ref A_2, A_3);
									pasteResult2 |= pasteResult;
									string setMatchingAttribute = global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.GetSetMatchingAttribute(set);
									list2.Add(new global::System.Tuple<string, string>(set.SetType, setMatchingAttribute));
									num = (short)1385431044;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)1998913544;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_504;
								case 9:
								{
									global::System.Xml.Linq.XElement matchXElement;
									int value = matchXElement.ElementsBeforeSelf().Count<global::System.Xml.Linq.XElement>();
									global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
									dictionary.Add(set, value);
									num = (short)1522991107;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_4AC:
								num = (short)68485121;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_386:
								goto IL_4AC;
							}
							IL_504:
							goto IL_5B5;
						}
						finally
						{
							num = (short)1765277697;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_575;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_53C;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1190461440;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_53C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1146159106;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_575:;
						}
						goto IL_578;
						IL_5B5:
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2 = A_0.Elements().GetEnumerator();
						num = (short)229572611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (list.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>())
						{
							num = (short)1828388866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E0;
					case 2:
						goto IL_5B0;
					case 3:
						try
						{
							num = (short)972816385;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string item;
								string setMatchingAttribute2;
								global::System.Tuple<string, string> item3;
								switch (num2)
								{
								case 0:
									item = null;
									goto IL_1BE;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_150;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1405943814;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.Linq.XElement xelement = enumerator2.Current;
									setMatchingAttribute2 = global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.GetSetMatchingAttribute(xelement);
									num = (short)1743716355;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Xml.Linq.XElement xelement;
									global::System.Xml.Linq.XAttribute xattribute = xelement.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("⩃❅╇⽉", a_));
									if (xattribute == null)
									{
										num = (short)686030848;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									item = xattribute.Value;
									goto IL_1BE;
								}
								case 4:
								{
									global::System.Xml.Linq.XElement xelement;
									global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Xml.Linq.XElement> item2 = new global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Xml.Linq.XElement>(this.SetCategory, xelement);
									A_1.Add(item2);
									pasteResult2 = global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Changed;
									num = (short)1375731717;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)16121863;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_293;
								case 8:
									if (!list2.Remove(item3))
									{
										num = (short)618266628;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								goto IL_150;
								IL_1BE:
								item3 = new global::System.Tuple<string, string>(item, setMatchingAttribute2);
								num = (short)1712783368;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_23A:
								num = (short)1133969410;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_150:
								goto IL_23A;
							}
							IL_293:
							goto IL_578;
						}
						finally
						{
							num = (short)1051656193;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_301;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2CA;
									}
									continue;
								case 2:
									enumerator2.Dispose();
									num = (short)1069350912;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2CA:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1912864770;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_301:;
						}
						goto IL_304;
					case 4:
						goto IL_332;
					}
					goto IL_4B;
					IL_578:
					num = (short)9240577;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_304:
				A_2.Add(new global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>(this.SetCategory, list));
				pasteResult2 = global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Changed;
				goto IL_319;
				IL_332:
				goto IL_5E0;
				IL_5B0:
				goto IL_304;
				IL_5E0:
				num = (short)194183169;
				if (num != 0)
				{
				}
				this.a(dictionary);
				return pasteResult2;
				IL_4B:
				num = (short)1928496796;
				short num3 = num;
				num = (short)1407747740;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_319:
					num = (short)767295492;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				case 1:
					break;
				default:
				{
					num = (short)1116209152;
					short num4 = num;
					break;
				}
				}
				num = (short)996868096;
				if (num != 0)
				{
				}
				pasteResult2 = global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Unchanged;
				list2 = new global::System.Collections.Generic.List<global::System.Tuple<string, string>>();
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>();
				dictionary = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.Set, int>();
				enumerator = this.SetCategory.Sets.GetEnumerator();
				num = (short)176881664;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0006A008 File Offset: 0x00068208
		protected override global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult PasteFromOverride(global::System.Xml.Linq.XElement xmlElement, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Xml.Linq.XElement>> setsToAdd, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>> setsToRemove, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.PasteContext pasteContext)
		{
			short num;
			for (;;)
			{
				num = (short)831782912;
				short num2 = num;
				if (this.SetCategory.MinCapacity != this.SetCategory.MaxCapacity)
				{
					goto IL_C5;
				}
				num = (short)874652077;
				short num3 = num;
				num = (short)425009581;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_7B;
				}
			}
			IL_7B:
			num = (short)1824587777;
			if (num != 0)
			{
			}
			num = (short)825491456;
			if (num != 0)
			{
			}
			return this.b(xmlElement, ref setsToAdd, ref setsToRemove, pasteContext);
			IL_C5:
			return this.a(xmlElement, ref setsToAdd, ref setsToRemove, pasteContext);
		}

		// Token: 0x04000302 RID: 770
		private global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory a;
	}
}
