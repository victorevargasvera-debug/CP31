using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using AcpBusinessLayer;
using AcpCommonLib;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.DataExchange;
using Motorola.Acp.PackUnpack.Ish.Exceptions;
using Motorola.Acp.PackUnpack.Ish.Fields;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000018 RID: 24
	public class DataExchangeManager : global::System.IDisposable
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00010E50 File Offset: 0x0000F050
		public DataExchangeManager()
		{
			int a_ = 18;
			base..ctor();
			this.a = new global::System.Collections.Generic.Dictionary<int, global::AcpCommonLib.IAcpFeatureNode>();
			this.b = new global::System.Collections.Generic.Dictionary<int, global::AcpBusinessLayer.Recordset>();
			this.c = new global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField>>();
			this.d = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.b>();
			this.g = new global::System.Collections.Generic.List<int>();
			this.h = new global::Motorola.Acp.PackUnpack.Ish.IshTypeSortComparer();
			global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n = new global::System.Diagnostics.BooleanSwitch(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒪쪬킰잲풴솸\ud8ba햼\udebe꿀꓂ꃄ釆꣈ꟊ꓌ꯎ냐꟒볔룖럘", a_), global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얪첬춮\uddb0횲骴펶킸좺\udcbc\uddbe귀ꛂꯆꛈ곊꫌ꛎ뿐듒룖뿘ﯚ맜뻞闠苢엤苦釨裪藬軮鿰铲郴ퟶ迸髺釼雾攀戂焄渆昈攊ⴌ紎琐怒怔笖洘栚", a_));
			global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o = new global::System.Diagnostics.BooleanSwitch(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﶨ쎪\udfac삮우풴\udbb6킸\udfba\udcbc쮾ꣀ곂ꯄ苆뇈꣊꣌뿎ꗐ뫒뫔맖꫘裚ꫜ뛞闠胢跤", a_), global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얪첬춮\uddb0횲骴펶킸좺\udcbc\uddbe귀ꛂ돆ꇈ맊ꋌ룎룐뷒닔뷘뫚꧜뻞쇠蛢鷤蓦臨諪菬裮铰폲菴零闸鋺駼黾甀樂樄椆⤈渊甌氎琐挒愔縖瘘甚渜", a_));
			if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
			{
				string path = global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("螨쒬솮잰튲\ud9b4\udeb6\uddb8\ud8bc잾ꋀꯂ꓄꧆껈껊뻌ꗐꯒꇔ", a_);
				if (global::System.IO.File.Exists(path))
				{
					global::System.IO.File.Delete(path);
				}
				this.e = global::System.IO.File.CreateText(path);
				this.e.AutoFlush = true;
			}
			else
			{
				this.e = null;
			}
			this.f = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.c();
			this.i = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.IshType>();
			this.j = new global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType>>();
			this.k = new global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.a, global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType>>();
			this.l = new global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.IshType, global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>>(new global::Motorola.Acp.PackUnpack.Ish.IshTypeEqualityComparer());
			this.m = new global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.IshType, global::Motorola.Acp.PackUnpack.Ish.CompositeItem>(new global::Motorola.Acp.PackUnpack.Ish.IshTypeEqualityComparer());
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00010F98 File Offset: 0x0000F198
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1258029057;
				if (num != 0)
				{
				}
				num = (short)453910697;
				short num2 = num;
				num = (short)1481973929;
				switch (num2 == num)
				{
				}
				num = (short)498466816;
				if (num != 0)
				{
				}
				this.a(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)1993277440;
			short num3 = num;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00011060 File Offset: 0x0000F260
		internal global::Motorola.Acp.PackUnpack.Ish.DataExchange.c IshTypeExchanges
		{
			get
			{
				short num = (short)114139334;
				short num2 = num;
				num = (short)1200398534;
				switch (num2 == num)
				{
				}
				num = (short)696057856;
				if (num != 0)
				{
				}
				num = (short)1748369408;
				short num3 = num;
				num = (short)1114767361;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00011110 File Offset: 0x0000F310
		internal global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.IshType> ChildToParentRelationships
		{
			get
			{
				short num = (short)513764998;
				short num2 = num;
				num = (short)1965780614;
				switch (num2 == num)
				{
				}
				num = (short)82444288;
				if (num != 0)
				{
				}
				num = (short)1280245760;
				short num3 = num;
				num = (short)849477633;
				if (num != 0)
				{
				}
				return this.i;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000111C0 File Offset: 0x0000F3C0
		internal global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType>> ParentToChildrenRelationships
		{
			get
			{
				short num = (short)767405808;
				short num2 = num;
				num = (short)1388556016;
				switch (num2 == num)
				{
				}
				num = (short)1253244928;
				if (num != 0)
				{
				}
				num = (short)1522204672;
				short num3 = num;
				num = (short)1104740353;
				if (num != 0)
				{
				}
				return this.j;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00011270 File Offset: 0x0000F470
		public void AddExchange(int recsetId, int sectionId, string propertyName, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fieldLayout)
		{
			int a_ = 19;
			short num = (short)892928000;
			switch (num)
			{
			default:
			{
				num = (short)1366360092;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
				for (;;)
				{
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.a a;
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange;
					global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType a_3;
					switch (num2)
					{
					case 0:
						goto IL_7DF;
					case 1:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange;
						if (sectionExchange.a(propertyName))
						{
							num = (short)1740701696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange a_2 = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange(fieldLayout, propertyName);
						sectionExchange.Add(a_2);
						num = (short)1158676493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_379;
					case 3:
						if (fieldLayout is global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout)
						{
							num = (short)2053767183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1080950796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_7A0;
					case 5:
						if (ishType.IsSingleInstance)
						{
							num = (short)2035417125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46D;
					case 6:
						goto IL_115;
					case 7:
						goto IL_66E;
					case 8:
						goto IL_66E;
					case 9:
						if (a.a(recsetId))
						{
							num = (short)280559626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1700986900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						recsetExchange = a[recsetId];
						num = (short)1695678472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_7A0;
					case 12:
						if (fieldLayout is global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout)
						{
							num = (short)1442644007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
						if (fieldLayout is global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout)
						{
							num = (short)1082130468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1615265795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_522;
					case 15:
						goto IL_79B;
					case 16:
						goto IL_57C;
					case 17:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b;
						if (b.a(a_3))
						{
							num = (short)1252130847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.a(a_3);
						b.Add(a);
						num = (short)848166934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_1C1;
					case 19:
						goto IL_278;
					case 20:
						if (a.c() != 0)
						{
							num = (short)188284962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F0;
					case 21:
						num = (short)2094530565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_428;
					case 23:
					{
						if (recsetExchange.a(sectionId))
						{
							num = (short)2084503590;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange(sectionId);
						recsetExchange.Add(sectionExchange);
						num = (short)1049624587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_428;
					case 25:
						goto IL_6EB;
					case 26:
						if (ishType is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
						{
							num = (short)1610350613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46D;
					case 27:
					{
						if (fieldLayout == null)
						{
							num = (short)1484980242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ishType = this.a(fieldLayout);
						global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)this.a(recsetId);
						this.a(ishType, fieldLayout, recordset);
						global::AcpCommonLib.IAcpField a_4 = this.a(recsetId, sectionId, propertyName);
						this.a(recordset, a_4, ishType, fieldLayout);
						num = (short)29425697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						switch (0)
						{
						case 0:
							goto IL_F4;
						}
						continue;
					case 29:
						goto IL_57C;
					case 30:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b = this.f[ishType];
						num = (short)1044971536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b;
						a = b[a_3];
						num = (short)1986199576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						if (propertyName == string.Empty)
						{
							num = (short)456785922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1875181595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
					{
						if (this.f.Contains(ishType))
						{
							num = (short)1211105310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.b(ishType);
						this.f.Add(b);
						num = (short)484704285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						num = (short)867172378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (sectionId < 0)
						{
							num = (short)1461190681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)204668968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_577;
					case 37:
						goto IL_6F0;
					case 38:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange = recsetExchange[sectionId];
						num = (short)162332676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator = ((global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout)fieldLayout).ReferencedIshTypes.GetEnumerator();
						num = (short)1755381779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						if (propertyName == null)
						{
							num = (short)1071054862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2022703136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_F4:
					if (recsetId < 0)
					{
						num = (short)1721237510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1622868003;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_428:
					num = (short)2070020105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_57C:
					a_3 = fieldLayout.Parent.AreaType;
					num = (short)1824063505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_66E:
					num = (short)413532183;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F0:
					recsetExchange = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange(recsetId);
					a.Add(recsetExchange);
					num = (short)307036167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A0:
					num = (short)753336321;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_115:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\ud8a9즫춭쎯ힱ삳ﾵ\udcb7", a_));
				IL_1C1:
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첩얫쮭\udcaf횱ힵ솷햹즻쪽", a_));
				IL_278:
				try
				{
					num = (short)602144769;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)665845762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_81E;
							}
							continue;
						case 2:
							goto IL_898;
						case 4:
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)95617024;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.IshType a_5 = enumerator.Current;
							this.d(a_5);
							num = (short)1831206915;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_848:
						num = (short)1442578436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_81E:
						goto IL_848;
					}
					IL_898:
					return;
				}
				finally
				{
					num = (short)492765185;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_951;
						case 1:
						{
							num = (short)277739183;
							short num3 = num;
							num = (short)31782575;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_93C;
							default:
								num = (short)1434845184;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_919;
								}
								continue;
							}
							break;
						}
						case 2:
							enumerator.Dispose();
							goto IL_93C;
						}
						IL_919:
						if (enumerator != null)
						{
							num = (short)24051714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_93C:
						num = (short)1043464192;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_951:;
				}
				goto IL_954;
				IL_379:
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udaa9\udeab솭삯ힱ욳습솷\uddbb펽ꖿ", a_));
				IL_46D:
				num = (short)1086849025;
				if (num != 0)
				{
				}
				throw new global::System.NotSupportedException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﺩ햫\udead햯銱쾳蚵얷骹\udfbb\udfbd꺿곁ꯃ닅꣉꧋ꏏꋑ룓뿕곗龎뷛뷝鋟跡韣闥죧飩觫跭鿯胱郳藵鷷軹迻탽", a_), ishType.GetType().Name));
				IL_522:
				num = (short)281280512;
				short num4 = num;
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udaa9\udeab솭삯ힱ욳습솷\uddbb펽ꖿ", a_));
				IL_577:
				this.d(((global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout)fieldLayout).ReferencedIshType);
				this.a((global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout)fieldLayout, ishType);
				return;
				IL_6EB:
				goto IL_954;
				IL_79B:
				this.d(((global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout)fieldLayout).ReferencedIshType);
				return;
				IL_7DF:
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udaa9\udeab솭삯ힱ욳습솷\uddbb펽ꖿ", a_));
				IL_954:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\ud8a9즫춭쎯ힱ삳ﾵ\udcb7", a_));
			}
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		public void AddExchange(int parentRecsetId, int parentSectionId, int childSectionId, string propertyName, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fieldLayout)
		{
			int a_ = 12;
			short num = (short)2028470272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_EB;
				}
				global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
				global::AcpBusinessLayer.Recordset recordset;
				for (;;)
				{
					IL_30:
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange2;
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.a a;
					global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType a_4;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
					global::AcpCommonLib.IAcpRecordset embeddedRecset;
					switch (num2)
					{
					case 0:
					{
						if (this.f.Contains(ishType))
						{
							num = (short)1866530839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.b(ishType);
						this.f.Add(b);
						num = (short)92012550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange;
						if (sectionExchange.RecsetExchange == null)
						{
							num = (short)835321899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange = sectionExchange.RecsetExchange;
						num = (short)1904607266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_163;
					case 3:
						if (fieldLayout is global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout)
						{
							num = (short)673841159;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)90832917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_163;
					case 5:
					{
						num = (short)13631488;
						short num3 = num;
						goto IL_4D8;
					}
					case 6:
						goto IL_1A4;
					case 7:
						goto IL_618;
					case 8:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange = recsetExchange2[parentSectionId];
						num = (short)398589954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (ishType.IsSingleInstance)
						{
							num = (short)504496133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_683;
					case 10:
						goto IL_4BF;
					case 11:
						goto IL_9A3;
					case 12:
						goto IL_761;
					case 13:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator = ((global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout)fieldLayout).ReferencedIshTypes.GetEnumerator();
						num = (short)1306525710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						try
						{
							num = (short)956825603;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)436928516;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1400832000;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.IshType a_2 = enumerator.Current;
									this.d(a_2);
									num = (short)1408958466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_844;
									}
									continue;
								case 4:
									goto IL_90D;
								}
								IL_846:
								num = (short)1156748113;
								short num4 = num;
								num = (short)819827537;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1944059904;
									if (num != 0)
									{
									}
									num = (short)463929345;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_844:
								goto IL_846;
							}
							IL_90D:
							return;
						}
						finally
						{
							num = (short)1521287169;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)985989122;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_944;
									}
									continue;
								case 2:
									goto IL_97B;
								}
								IL_944:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1255014400;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_97B:;
						}
						goto IL_97E;
					case 15:
						goto IL_71E;
					case 16:
						goto IL_761;
					case 17:
						num = (short)614203433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_9A3;
					case 19:
						goto IL_97E;
					case 20:
						num = (short)262995977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (fieldLayout is global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout)
						{
							num = (short)893255690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)361758764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_12F;
					case 23:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b = this.f[ishType];
						num = (short)1098317855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						recsetExchange2 = a[parentRecsetId];
						num = (short)52756492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (a.a(parentRecsetId))
						{
							num = (short)246480920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)672530460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange2;
						if (sectionExchange2.a(propertyName))
						{
							num = (short)1897201691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange a_3 = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange(fieldLayout, propertyName);
						sectionExchange2.Add(a_3);
						num = (short)1056440323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_9E2;
					case 28:
						if (a.c() != 0)
						{
							num = (short)561840145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D8;
					case 29:
					{
						num = (short)1723400193;
						if (num != 0)
						{
						}
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b;
						if (b.a(a_4))
						{
							num = (short)902168609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.a(a_4);
						b.Add(a);
						num = (short)1188888611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						if (recsetExchange2.a(parentSectionId))
						{
							num = (short)1432551432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange(parentSectionId);
						recsetExchange2.Add(sectionExchange);
						num = (short)1958543364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_1A4;
					case 32:
						goto IL_231;
					case 33:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b;
						a = b[a_4];
						num = (short)1844969508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						goto IL_71E;
					case 35:
						goto IL_43E;
					case 36:
						goto IL_43E;
					case 37:
						goto IL_231;
					case 38:
						if (recordset.Count > 0)
						{
							num = (short)986578963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpFeatureNode = recordset.CreateDefaultRecordHelper();
						num = (short)1321599013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange;
						if (recsetExchange.a(childSectionId))
						{
							num = (short)703594536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange2 = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange(childSectionId);
						recsetExchange.Add(sectionExchange2);
						num = (short)1574305810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange;
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange2 = recsetExchange[childSectionId];
						num = (short)1532493835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						if (ishType is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
						{
							num = (short)1912602644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_683;
					case 42:
						if (recordset == null)
						{
							num = (short)1036582934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1128071206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange;
						sectionExchange.RecsetExchange = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange(embeddedRecset.RecsetId);
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange = sectionExchange.RecsetExchange;
						num = (short)703201295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
						if (fieldLayout is global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout)
						{
							num = (short)244580365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_EB;
					IL_163:
					num = (short)722468865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A4:
					a_4 = fieldLayout.Parent.AreaType;
					num = (short)959184925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_231:
					embeddedRecset = acpFeatureNode[parentSectionId].EmbeddedRecset;
					int recsetId = embeddedRecset.RecsetId;
					ishType = this.a(fieldLayout);
					this.a(ishType, fieldLayout, embeddedRecset);
					num = (short)453509120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43E:
					num = (short)542244889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D8:
					recsetExchange2 = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange(parentRecsetId);
					a.Add(recsetExchange2);
					num = (short)1052901392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_71E:
					num = (short)1733296167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_761:
					num = (short)1297940510;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_97E:
					acpFeatureNode = recordset[0];
					num = (short)2117140512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A3:
					num = (short)1175584794;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12F:
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펢쒤햦첨얪\ud9acﶮ풰킲운튶춸\ud9bc", a_));
				IL_4BF:
				this.d(((global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout)fieldLayout).ReferencedIshType);
				return;
				IL_618:
				this.d(((global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout)fieldLayout).ReferencedIshType);
				return;
				IL_683:
				throw new global::System.NotSupportedException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udca4힦첨讪횬龮첰鎲횴횶ힸ햺튼쮾ꇂꃄ뫈믊ꇌꛎꗐ듔듖ꯘ듚껜곞쇠釢胤蓦蛨駪觬鳮铰蟲蛴\ud9f6", a_), ishType.GetType().Name));
				IL_9E2:
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펢힤좦\ud9a8캪\udfac\udbae좰ﶲ풴\udab6\udcb8", a_));
				IL_EB:
				recordset = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(parentRecsetId);
				num = (short)1114898474;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00012608 File Offset: 0x00010808
		private void d(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			short num = (short)1239941123;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					return;
				case 1:
					return;
				case 2:
					goto IL_F8;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 4:
					this.g.Insert(~num3, A_0.Value);
					num = (short)1044185088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_38:
				num = (short)1539585607;
				short num4 = num;
				num = (short)1561998919;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_F8:
					num = (short)628424705;
					if (num != 0)
					{
					}
					num = (short)135659520;
					short num5 = num;
					if (num3 >= 0)
					{
						return;
					}
					num = (short)19202052;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)1503657984;
					if (num != 0)
					{
					}
					if (A_0 == null)
					{
						num = (short)247988225;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num3 = this.g.BinarySearch(A_0.Value);
						num = (short)254607362;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00012780 File Offset: 0x00010980
		private bool c(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			short num = (short)590145134;
			short num2 = num;
			num = (short)1364846190;
			switch (num2 == num)
			{
			}
			num = (short)295108608;
			short num3 = num;
			num = (short)1405878273;
			if (num != 0)
			{
			}
			num = (short)886112256;
			if (num != 0)
			{
			}
			return this.g.BinarySearch(A_0.Value) >= 0;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00012840 File Offset: 0x00010A40
		private bool c(global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> A_0)
		{
			short num = (short)1287738565;
			short num2 = num;
			num = (short)938038469;
			switch (num2 == num)
			{
			}
			num = (short)643891200;
			short num3 = num;
			num = (short)1973813249;
			if (num != 0)
			{
			}
			num = (short)1270415360;
			if (num != 0)
			{
			}
			return this.c(A_0[0].Type);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000128FC File Offset: 0x00010AFC
		private bool c(global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection A_0)
		{
			short num = (short)1775790288;
			short num2 = num;
			num = (short)1116891344;
			switch (num2 == num)
			{
			}
			num = (short)866320384;
			short num3 = num;
			num = (short)92733441;
			if (num != 0)
			{
			}
			num = (short)1831862272;
			if (num != 0)
			{
			}
			return this.c(((global::Motorola.Acp.PackUnpack.Ish.IshItem)A_0[0]).Type);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000129C0 File Offset: 0x00010BC0
		private bool a(global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> A_0)
		{
			short num = (short)1400023247;
			short num2 = num;
			num = (short)321956047;
			switch (num2 == num)
			{
			}
			num = (short)996278272;
			short num3 = num;
			num = (short)1406140417;
			if (num != 0)
			{
			}
			num = (short)901971968;
			if (num != 0)
			{
			}
			return this.c(A_0[0]);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00012A7C File Offset: 0x00010C7C
		private global::AcpCommonLib.IAcpField a(global::AcpCommonLib.IAcpFeatureNode A_0, int A_1, string A_2)
		{
			short num = (short)1121094417;
			short num2 = num;
			num = (short)114199313;
			switch (num2 == num)
			{
			}
			num = (short)687210496;
			short num3 = num;
			num = (short)1810432000;
			if (num != 0)
			{
			}
			num = (short)529793025;
			if (num != 0)
			{
			}
			return A_0[A_1][A_2];
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00012B30 File Offset: 0x00010D30
		private global::AcpCommonLib.IAcpField a(int A_0, int A_1, string A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpBusinessLayer.Recordset recordset;
			global::AcpBusinessLayer.FeatureNode featureNode;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					featureNode = recordset.CreateDefaultRecordHelper();
					num2 = (short)1280638979;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_FB;
				case 2:
				{
					IL_42:
					num2 = (short)1001062401;
					if (num2 != 0)
					{
					}
					if (recordset.Count == 0)
					{
						num2 = (short)1412169728;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)561905664;
					short num3 = num2;
					featureNode = (global::AcpBusinessLayer.FeatureNode)recordset[0];
					num2 = (short)1350893569;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_FB;
				}
				goto IL_20;
				IL_FB:
				num2 = (short)1904960544;
				short num4 = num2;
				num2 = (short)1872323616;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_42;
				default:
					goto IL_130;
				}
			}
			IL_130:
			num2 = (short)1170276352;
			if (num2 != 0)
			{
			}
			return featureNode[A_1][A_2];
			IL_20:
			recordset = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(A_0);
			num2 = (short)2129330178;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00012C90 File Offset: 0x00010E90
		internal void a(global::AcpCommonLib.IAcpField A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_1)
		{
			short num = (short)1126568306;
			short num2 = num;
			num = (short)551096690;
			switch (num2 == num)
			{
			}
			num = (short)1958608896;
			short num3 = num;
			num = (short)946077697;
			if (num != 0)
			{
			}
			num = (short)973340672;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00012D3C File Offset: 0x00010F3C
		private void a(global::AcpBusinessLayer.Recordset A_0, global::AcpCommonLib.IAcpField A_1, global::Motorola.Acp.PackUnpack.Ish.IshType A_2, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_3)
		{
			int a_ = 17;
			short num = (short)622788630;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			string text2;
			string text3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o.Enabled)
					{
						num = (short)275906564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_4F6;
				case 2:
					this.e.WriteLine(text);
					num = (short)1166475280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)530843861;
					short num3 = num;
					num = (short)1536428245;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3E5;
					default:
						num = (short)740753408;
						if (num != 0)
						{
						}
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o.Enabled)
						{
							num = (short)1239154698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48F;
					}
					break;
				}
				case 4:
					goto IL_326;
				case 5:
					text2 = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒩\udaab쾭\udcaf\udbb1킳隵햷\udbb9첻캽ꦿ곁ꏃﳅ诉룋뫍뗏뿑ꓓꋕ뇗듙믛ﻝ铟跡쓣该觧髩쳫闭샯迱퓳鿵雷觹裻鿽滿愁愃★簇攉Ⰻ漍』縑紓攕気㨙君娝感ȡ䴣䠥ࠧ天䔫䀭圯帱儳ᬵ儷吹伻䨽ℿⱁ❃⍅桇㡉⥋ⵍ⍏㝑⁓癕⍗歙⅛繝䡟ୡc履䡧ᅩ幫፭奯", a_), new object[]
					{
						A_1.GetType().Name,
						A_2.Name,
						A_0.RecordsetName,
						A_0.RecsetId
					});
					num = (short)1405812753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					text = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒩\udaab쾭\udcaf\udbb1킳隵햷\udbb9첻캽ꦿ곁ꏃﳅ诉룋뫍뗏뿑ꓓꋕ뇗듙믛ﻝ铟跡쓣该觧髩쳫闭샯迱퓳鿵雷觹裻鿽滿愁愃★稇漉紋笍礏怑紓砕缗㨙甛樝䔟伡У唥䴧堩䔫伭尯嬱丳圵䰷匹医倽怿⑁㙃⥅╇橉⅋㭍㱏♑㵓筕ㅗ㑙⽛⩝şౡݣͥ䡧٩իᵭѯ剱sཱུࡷό屻ս녿ﾁꒃꪉﮍﲏﶓ뮕솟첡잣쎥袧\ud8a9즫춭쎯ힱ삳隵쎷袹솻麽ꯁꃃﳅ뇉ￋ돍紐", a_), new object[]
					{
						A_1.GetType().Name,
						A_2.Name,
						A_0.RecordsetName,
						A_0.RecsetId
					});
					num = (short)1719599125;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (!A_0.SingleInstance)
					{
						num = (short)2128609286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_48F;
				case 8:
					if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
					{
						num = (short)643891200;
						short num4 = num;
						num = (short)1958739982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4F6;
				case 9:
					num = (short)326762515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_48A;
				case 11:
					goto IL_2E8;
				case 12:
					goto IL_535;
				case 13:
					if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o.Enabled)
					{
						num = (short)786300940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B9;
				case 14:
					this.e.WriteLine(text3);
					num = (short)945618945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (!(A_2 is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType))
					{
						num = (short)1958281217;
						if (num != 0)
						{
						}
						num = (short)1903558680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B9;
				case 16:
					goto IL_401;
				case 17:
					if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
					{
						num = (short)239665170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E8;
				case 18:
					this.e.WriteLine(text2);
					num = (short)372375563;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (((global::AcpBusinessLayer.AcpListField)A_1).SerializeItems)
					{
						goto IL_3E5;
					}
					return;
				case 20:
					num = (short)1234042887;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
					{
						num = (short)1311768578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_401;
				case 22:
					switch (0)
					{
					case 0:
						goto IL_92;
					}
					continue;
				case 23:
					if (A_3.Parent.AreaType != global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListHeader)
					{
						num = (short)1052180485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 24:
					text3 = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒩\udaab쾭\udcaf\udbb1킳隵햷\udbb9첻캽ꦿ곁ꏃﳅ诉룋뫍뗏뿑ꓓꋕ뇗듙믛ﻝ铟跡쓣该觧髩쳫闭샯迱퓳鿵雷觹裻鿽滿愁愃★簇攉Ⰻ怍缏簑㤓稕焗椙栛㸝吟嬡吣䌥ࠧ儩ᴫ匭", a_), A_1.GetType().Name, A_2.Name);
					num = (short)1147600904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_92:
				if (A_1 is global::AcpBusinessLayer.AcpListField)
				{
					num = (short)272826377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_B9:
				num = (short)1461780503;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E8:
				num = (short)46923776;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E5:
				num = (short)513998868;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_401:
				num = (short)1387462659;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_48F:
				num = (short)1572536335;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4F6:
				num = (short)702349325;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_326:
			throw new global::System.NotSupportedException(text2);
			IL_48A:
			throw new global::System.NotSupportedException(text);
			IL_535:
			throw new global::System.NotSupportedException(text3);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00013284 File Offset: 0x00011484
		private void a(global::Motorola.Acp.PackUnpack.Ish.IshType A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_1, global::AcpCommonLib.IAcpRecordset A_2)
		{
			int a_ = 17;
			short num = (short)1648754690;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_CE;
				case 1:
				{
					num = (short)1861419008;
					short num3 = num;
					if (A_0 is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)
					{
						num = (short)530644995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14F;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 3:
					goto IL_13E;
				}
				IL_3E:
				num = (short)1067712513;
				if (num != 0)
				{
				}
				if (A_0 is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
				{
					num = (short)1988731631;
					short num4 = num;
					num = (short)1565041391;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13E;
					default:
						num = (short)1414463488;
						if (num != 0)
						{
						}
						num = (short)1581187072;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				else
				{
					num = (short)779157505;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_CE:
			this.a((global::Motorola.Acp.PackUnpack.Ish.CompositeType)A_0, A_1, A_2);
			return;
			IL_13E:
			this.a((global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)A_0, A_1, A_2);
			return;
			IL_14F:
			throw new global::System.NotSupportedException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮩슫삭\udfaf욱钳삵\ud9b7횹햻\udabdꆿ뛁ꇃ볇돉볋ꯍ꧑ꯕ龎닛뇝铟싡韣鏥飧髩菫鳭蓯韱郳", a_), A_0.GetType().Name));
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00013404 File Offset: 0x00011604
		private void a(global::Motorola.Acp.PackUnpack.Ish.CompositeType A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_1, global::AcpCommonLib.IAcpRecordset A_2)
		{
			int a_ = 0;
			short num = (short)1772486656;
			switch (num)
			{
			default:
			{
				num = (short)323944477;
				int num2 = (int)((global::System.IntPtr)num);
				string text;
				string text2;
				string text3;
				string text4;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!A_2.SingleInstance)
						{
							num = (short)1357643790;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						num = (short)416808982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (A_2.IsEmbeddedRecset)
						{
							num = (short)1468530699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1605107717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						text = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\ude96ﲜ좠잢薤쪦좨\udbaa\uddac욮\udfb0풲辴鞶쾺즼\udabe곀돂뇄껆ꟈ곊믎뻐룔뛖꧘ﯚ믜뛞蓠迢臤쟦鋨\udbea郬쿮韰臲髴髶\ud9f8雺裼鏾甀樂⠄渆月砊礌渎缐瀒瀔㜖稘琚瀜漞丠倢䰤匦䰨ପ夬嘮䄰嘲ᔴ䰶࠸䘺ᴼ䬾⹀捂⑄⥆楈⹊⁌ⵎ㑐㝒ㅔ㉖㵘筚⽜㩞ɠၢd፦䥨᭪౬ᵮᑰᵲŴቶᵸ孺ὼپꆀꖄﲈ歷벐朗ﮔ漢ﲞ쒠莢힤슦쪨\ud8aa좬\udbae醰좲螴쪶馸鎺풼\udbbe﯀뻄듈", a_), new object[]
						{
							A_1.Name,
							A_0.Name,
							A_2.RecordsetName,
							A_2.RecsetId
						});
						num = (short)1059127316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!A_2.ParentSection.ParentRecset.SingleInstance)
						{
							num = (short)2129330179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						goto IL_541;
					case 6:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
						{
							num = (short)842465288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_270;
					case 7:
						goto IL_2B2;
					case 8:
						this.e.WriteLine(text2);
						num = (short)415694876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o.Enabled)
						{
							num = (short)1671233560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F7;
					case 10:
						goto IL_4E7;
					case 11:
						num = (short)1415249924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o.Enabled)
						{
							num = (short)1107689499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
						{
							num = (short)855965721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E7;
					case 14:
						text3 = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\ude96ﲜ좠잢薤쪦좨\udbaa\uddac욮\udfb0풲辴鞶쾺즼\udabe곀돂뇄껆ꟈ곊믎뻐룔뛖꧘ﯚ믜뛞蓠迢臤쟦鋨\udbea郬쿮韰臲髴髶\ud9f8裺铼釾昀漂怄⨆怈攊縌笎瀐紒瘔爖㤘砚爜爞儠䰢嘤並崨个ബ嬮䠰䌲倴᜶䈸਺䀼Ἶ㕀ⱂ敄⩆㱈❊㥌♎籐㩒㭔⑖ⵘ㩚㍜㱞Ѡ䍢ᝤɦ੨ᡪ࡬᭮兰ࡲ䝴੶奸卺ᑼ᭾뮀ꎂﺄ뒆ꊊ", a_), new object[]
						{
							A_1.Name,
							A_0.Name,
							A_2.RecordsetName,
							A_2.RecsetId
						});
						num = (short)402194445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o.Enabled)
						{
							num = (short)158203934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						text2 = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\ude96ﲜ좠잢薤쪦좨\udbaa\uddac욮\udfb0풲辴鞶쾺즼\udabe곀돂뇄껆ꟈ곊믎뻐룔뛖꧘ﯚ믜뛞蓠迢臤쟦鋨\udbea郬쿮韰臲髴髶\ud9f8雺裼鏾甀樂⠄渆月砊礌渎缐瀒瀔㜖稘琚瀜漞丠倢䰤匦䰨ପ夬嘮䄰嘲ᔴ䰶࠸䘺ᴼ䬾⹀捂㙄⹆❈ⱊ⅌⩎籐㩒㭔⑖ⵘ㩚㍜㱞Ѡ䍢ᝤɦ੨ᡪ࡬᭮兰ࡲ䝴੶奸卺ᑼ᭾뮀ꎂﺄ뒆ꊊ", a_), new object[]
						{
							A_1.Name,
							A_0.Name,
							A_2.RecordsetName,
							A_2.RecsetId
						});
						num = (short)1478950918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						num = (short)1949176633;
						short num3 = num;
						num = (short)1926042425;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_541;
						default:
							num = (short)1830486016;
							if (num != 0)
							{
							}
							text4 = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\ude96ﲜ좠잢薤쪦좨\udbaa\uddac욮\udfb0풲辴鞶쾺즼\udabe곀돂뇄껆ꟈ곊믎뻐룔뛖꧘ﯚ믜뛞蓠迢臤쟦鋨\udbea郬쿮韰臲髴髶\ud9f8裺铼釾昀漂怄⨆怈攊縌笎瀐紒瘔爖㤘砚爜爞儠䰢嘤並崨个ബ嬮䠰䌲倴᜶䈸਺䀼Ἶ㕀ⱂ敄≆⑈⥊⡌⭎㕐㙒ㅔ睖⭘㹚㹜ⱞѠᝢ䕤ᱦ孨ᙪ䵬䝮ᡰᝲ佴坶ɸ䡺|噾", a_), new object[]
							{
								A_1.Name,
								A_0.Name,
								A_2.RecordsetName,
								A_2.RecsetId
							});
							num = (short)707002399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 18:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o.Enabled)
						{
							num = (short)2119827463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 19:
						this.e.WriteLine(text4);
						num = (short)2100756503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
						{
							num = (short)189661205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_120;
					case 21:
						num = (short)885981185;
						if (num != 0)
						{
						}
						this.e.WriteLine(text);
						num = (short)348323866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (A_2.IsEmbeddedRecset)
						{
							num = (short)706936849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F7;
					case 23:
						goto IL_41F;
					case 24:
						goto IL_45E;
					case 25:
						this.e.WriteLine(text3);
						num = (short)1912143882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_120;
					case 27:
						goto IL_527;
					case 28:
						goto IL_270;
					case 29:
						switch (0)
						{
						case 0:
							goto IL_CC;
						}
						continue;
					case 30:
						goto IL_161;
					case 31:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
						{
							num = (short)1183514643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41F;
					}
					IL_CC:
					if (A_0.IsSingleInstance)
					{
						num = (short)41484288;
						short num4 = num;
						num = (short)947781633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)805699586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_120:
					num = (short)1825570831;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_270:
					num = (short)1160052754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F7:
					num = (short)1181548544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41F:
					num = (short)2092236809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E7:
					num = (short)1996423180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_541:
					if (!A_2.SingleInstance)
					{
						return;
					}
					num = (short)1915617296;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_161:
				throw new global::System.NotSupportedException(text);
				IL_2B2:
				throw new global::System.NotSupportedException(text2);
				IL_45E:
				throw new global::System.NotSupportedException(text4);
				IL_527:
				throw new global::System.NotSupportedException(text3);
			}
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00013AE4 File Offset: 0x00011CE4
		private void a(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_1, global::AcpCommonLib.IAcpRecordset A_2)
		{
			int a_ = 9;
			short num = (short)705036288;
			switch (num)
			{
			default:
			{
				num = (short)1432551424;
				short num2 = num;
				num = (short)194773054;
				int num3 = (int)((global::System.IntPtr)num);
				string text;
				string text2;
				string text3;
				string text4;
				string text5;
				string text6;
				string text7;
				string text8;
				for (;;)
				{
					switch (num3)
					{
					case 0:
						text = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첡튣장쒧쎩좫躭\uddaf펱쒳욵톷풹\udbbb蒽菁냃닅귇Ꟊ볋뫍맏병돓곗뗙ﳛ돝臟鋡쓣諥臧駩飫컭룯뛱뗳훵黷鏹駻鋽擿∁缃㘅甇⨉樋簍缏缑㐓笕洗瘙栛眝ട䬡䨣唥尧䬩䈫䴭唯ሱ堳張䬷丹᰻䨽㤿㉁⅃晅㍇等ㅋ湍⑏㵑瑓㍕㕗㡙㥛㩝џݡc䙥ᩧཀྵཫᵭᕯٱ味൵䩷ݹ屻噽뺃ꚅ릉Ɥ", a_), new object[]
						{
							A_1.Name,
							A_0.Name,
							A_2.RecordsetName,
							A_2.RecsetId
						});
						num = (short)912064537;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_7B6;
					case 2:
						goto IL_9BC;
					case 3:
						this.e.WriteLine(text2);
						num = (short)517013537;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (A_2.SingleInstance)
						{
							num = (short)238747676;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						if (A_2.IsEmbeddedRecset)
						{
							num = (short)729284642;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o.Enabled)
						{
							num = (short)177209357;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						goto IL_2BD;
					case 8:
						goto IL_CAA;
					case 9:
						if (!A_2.SingleInstance)
						{
							num = (short)767557682;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
						{
							num = (short)372047939;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BA2;
					case 11:
						goto IL_D09;
					case 12:
						if (A_2.IsEmbeddedRecset)
						{
							num = (short)1857749055;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C29;
					case 13:
						goto IL_1F0;
					case 14:
						if (A_1.Parent.AreaType == global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListEntry)
						{
							num = (short)23855162;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CD9;
					case 15:
						goto IL_D47;
					case 16:
						goto IL_B16;
					case 17:
						if (A_1.Parent.AreaType == global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListHeader)
						{
							num = (short)1628831801;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)331874345;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o.Enabled)
						{
							num = (short)1550254095;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D5A;
					case 19:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o.Enabled)
						{
							num = (short)501415944;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_433;
					case 20:
						this.e.WriteLine(text3);
						num = (short)771096578;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o.Enabled)
						{
							num = (short)640090166;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 22:
						if (A_1.Parent.AreaType == global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListHeader)
						{
							num = (short)266862618;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)356122638;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_9FC;
					case 24:
						if (A_2.SingleInstance)
						{
							num = (short)715259959;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 25:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
						{
							num = (short)1688535084;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D09;
					case 26:
						num = (short)105185292;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_AD4;
					case 28:
						text2 = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첡튣장쒧쎩좫躭\uddaf펱쒳욵톷풹\udbbb蒽菁냃닅귇Ꟊ볋뫍맏병돓곗뗙ﳛ돝臟鋡쓣諥臧駩飫컭룯뛱뗳훵黷鏹駻鋽擿∁缃㘅甇⨉樋簍缏缑㐓笕洗瘙栛眝ട䬡䨣唥尧䬩䈫䴭唯ሱ堳張䬷丹᰻䨽㤿㉁⅃晅㍇等ㅋ湍⑏㵑瑓╕ㅗ㑙㭛㉝՟佡ൣࡥ᭧ṩ൫m፯᝱味ѵᵷ᥹ཻ᭽ꊁﾃ뒅ꪉꒋꢑ뒓ꮗ떛", a_), new object[]
						{
							A_1.Name,
							A_0.Name,
							A_2.RecordsetName,
							A_2.RecsetId
						});
						num = (short)550305832;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
						{
							num = (short)1878654996;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9BC;
					case 30:
						num = (short)921698305;
						if (num != 0)
						{
						}
						if (!A_2.IsEmbeddedRecset)
						{
							num = (short)838336544;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_433;
					case 31:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o.Enabled)
						{
							num = (short)1012924423;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 32:
						text4 = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첡튣장쒧쎩좫躭\uddaf펱쒳욵톷풹\udbbb蒽菁냃닅귇Ꟊ볋뫍맏병돓곗뗙ﳛ돝臟鋡쓣諥臧駩飫컭볯럱냳럵\ud8f7鳹闻鯽泿昁␃紅㠇眉Ⰻ栍戏紑礓㘕甗漙瀛樝䤟༡䴣䠥嬧帩䴫䀭匯圱ᐳ娵儷䤹䠻ḽ㐿㭁㑃⍅桇ㅉ絋㍍灏♑㭓癕ⱗ㕙ⱛ獝౟ݡባͥѧ䩩ṫ୭፯űᅳɵ塷Ź乻ͽꁿꪁ늇ꪉ붍뮑", a_), new object[]
						{
							A_1.Name,
							A_0.Name,
							A_2.RecordsetName,
							A_2.RecsetId
						});
						num = (short)777912386;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_1B0;
					case 34:
						num = (short)563871796;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (A_2.SingleInstance)
						{
							num = (short)1664417835;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE7;
					case 36:
						text3 = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첡튣장쒧쎩좫躭\uddaf펱쒳욵톷풹\udbbb蒽菁냃닅귇Ꟊ볋뫍맏병돓곗뗙ﳛ돝臟鋡쓣諥臧駩飫컭볯럱냳럵\ud8f7鳹闻鯽泿昁␃紅㠇眉Ⰻ栍戏紑礓㘕欗猙爛礝䰟䜡ण伥䘧天堫伭帯儱儳ᘵ吷匹伻䨽怿㙁㵃㙅ⵇ橉㝋罍ⵏ牑⁓㥕硗㭙㉛繝՟ཡ٣ͥ౧๩५੭偯qᅳᕵ୷όࡻ幽ﺉ낏뚕聯몙첟횡춣讥솧쒩\udfab\udaad톯\udcb1ힳ펵颷좹\ud9bb\uddbd뎿ꟁ냃돇뇋믑냓ꇙꏝ짟", a_), new object[]
						{
							A_1.Name,
							A_0.Name,
							A_2.RecordsetName,
							A_2.RecsetId
						});
						num = (short)530513949;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_C6B;
					case 38:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o.Enabled)
						{
							num = (short)717619223;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 39:
						goto IL_BA2;
					case 40:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
						{
							num = (short)1506017283;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B0;
					case 41:
						if (A_1.Parent.AreaType == global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListEntry)
						{
							num = (short)807993408;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4C;
					case 42:
						goto IL_54C;
					case 43:
						text5 = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첡튣장쒧쎩좫躭\uddaf펱쒳욵톷풹\udbbb蒽菁냃닅귇Ꟊ볋뫍맏병돓곗뗙ﳛ돝臟鋡쓣諥臧駩飫컭볯럱냳럵\ud8f7鳹闻鯽泿昁␃紅㠇眉Ⰻ栍戏紑礓㘕欗猙爛礝䰟䜡ण伥䘧天堫伭帯儱儳ᘵ吷匹伻䨽怿㙁㵃㙅ⵇ橉㝋罍ⵏ牑⁓㥕硗⥙㕛そݟ๡ţ䭥ŧѩὫᩭᅯᱱᝳ፵塷ࡹ᥻ᵽꚅ뢉꺍뢏ﮑ겕뢗꾛覟", a_), new object[]
						{
							A_1.Name,
							A_0.Name,
							A_2.RecordsetName,
							A_2.RecsetId
						});
						num = (short)157876275;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						this.e.WriteLine(text);
						num = (short)1205207051;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						this.e.WriteLine(text5);
						num = (short)1375141949;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						this.e.WriteLine(text6);
						num = (short)1742143515;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						this.e.WriteLine(text4);
						num = (short)744161317;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
						{
							num = (short)1760165930;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27D;
					case 49:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
						{
							num = (short)1206648878;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AD4;
					case 50:
						text7 = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첡튣장쒧쎩좫躭\uddaf펱쒳욵톷풹\udbbb蒽菁냃닅귇Ꟊ볋뫍맏병돓곗뗙ﳛ돝臟鋡쓣諥臧駩飫컭룯뛱뗳훵黷鏹駻鋽擿∁缃㘅甇⨉樋簍缏缑㐓攕焗琙笛爝䔟༡䴣䠥嬧帩䴫䀭匯圱ᐳ娵儷䤹䠻ḽ㐿㭁㑃⍅桇ㅉ絋㍍灏♑㭓癕㕗⽙せ⩝य़佡ൣࡥ᭧ṩ൫m፯᝱味ѵᵷ᥹ཻ᭽ꊁﾃ뒅ꪉꒋꢑ뒓ꮗ떛", a_), new object[]
						{
							A_1.Name,
							A_0.Name,
							A_2.RecordsetName,
							A_2.RecsetId
						});
						num = (short)473956400;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
						{
							num = (short)1317797933;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_775;
					case 52:
						if (!A_2.ParentSection.ParentRecset.SingleInstance)
						{
							num = (short)1473314852;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 53:
						num = (short)1035862038;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						goto IL_BE2;
					case 55:
						text8 = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첡튣장쒧쎩좫躭\uddaf펱쒳욵톷풹\udbbb蒽菁냃닅귇Ꟊ볋뫍맏병돓곗뗙ﳛ돝臟鋡쓣諥臧駩飫컭볯럱냳럵\ud8f7鳹闻鯽泿昁␃紅㠇眉Ⰻ栍戏紑礓㘕甗漙瀛樝䤟༡䴣䠥嬧帩䴫䀭匯圱ᐳ娵儷䤹䠻ḽ㐿㭁㑃⍅桇ㅉ絋㍍灏♑㭓癕⭗㍙㉛㥝౟ݡ䥣ཥ٧ᥩᡫ཭ṯᅱᅳ噵੷όύൽꒃﶅ몇겋ꚍ憐꺓뚕ꦙ랝", a_), new object[]
						{
							A_1.Name,
							A_0.Name,
							A_2.RecordsetName,
							A_2.RecsetId
						});
						num = (short)114032650;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o.Enabled)
						{
							num = (short)672268304;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C29;
					case 57:
					{
						num = (short)1645706033;
						short num4 = num;
						num = (short)1525513009;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_54C;
						default:
							num = (short)1537998848;
							if (num != 0)
							{
							}
							num = (short)399376443;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 58:
						num = (short)2064973859;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						if (A_2.IsEmbeddedRecset)
						{
							num = (short)1167196160;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D5A;
					case 60:
						goto IL_27D;
					case 61:
						goto IL_775;
					case 62:
						switch (0)
						{
						case 0:
							goto IL_188;
						}
						continue;
					case 63:
						text6 = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첡튣장쒧쎩좫躭\uddaf펱쒳욵톷풹\udbbb蒽菁냃닅귇Ꟊ볋뫍맏병돓곗뗙ﳛ돝臟鋡쓣諥臧駩飫컭룯뛱뗳훵黷鏹駻鋽擿∁缃㘅甇⨉樋簍缏缑㐓攕焗琙笛爝䔟༡䴣䠥嬧帩䴫䀭匯圱ᐳ娵儷䤹䠻ḽ㐿㭁㑃⍅桇ㅉ絋㍍灏♑㭓癕㵗㝙㹛㭝џ١ţɥ䡧ᡩ५൭ͯ᝱s噵ͷ䡹Ż幽꡿벅ꢇ뾋릏", a_), new object[]
						{
							A_1.Name,
							A_0.Name,
							A_2.RecordsetName,
							A_2.RecsetId
						});
						num = (short)1343553585;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						num = (short)32112670;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.o.Enabled)
						{
							num = (short)480968705;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE7;
					case 66:
						if (global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.n.Enabled)
						{
							num = (short)1133510703;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C6B;
					case 67:
						this.e.WriteLine(text8);
						num = (short)1651048487;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_188:
					if (A_0.IsSingleInstance)
					{
						num = (short)1109196853;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)280428561;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B0:
					num = (short)1241251846;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_27D:
					num = (short)724631583;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_433:
					num = (short)149684248;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_54C:
					this.e.WriteLine(text7);
					num = (short)678166588;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_775:
					num = (short)362610753;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_9BC:
					num = (short)1338114086;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_AD4:
					num = (short)1674707000;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_BA2:
					num = (short)418119701;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_BE7:
					num = (short)362545157;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_C29:
					num = (short)1675558921;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_C6B:
					num = (short)140640275;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_D09:
					num = (short)1900150802;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_D5A:
					num = (short)661782532;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1F0:
				throw new global::System.NotSupportedException(text2);
				IL_2BD:
				throw new global::System.NotSupportedException(text7);
				IL_7B6:
				throw new global::System.NotSupportedException(text5);
				IL_9FC:
				throw new global::System.NotSupportedException(text3);
				IL_B16:
				throw new global::System.NotSupportedException(text6);
				IL_BE2:
				throw new global::System.NotSupportedException(text8);
				IL_CAA:
				throw new global::System.NotSupportedException(text4);
				IL_CD9:
				throw new global::System.InvalidCastException();
				IL_D47:
				throw new global::System.NotSupportedException(text);
				IL_D4C:
				throw new global::System.InvalidCastException();
			}
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00014890 File Offset: 0x00012A90
		private void a(global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout A_0, global::Motorola.Acp.PackUnpack.Ish.IshType A_1)
		{
			short num = (short)381747210;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType> list = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType>();
					num = (short)204996617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType> list;
					global::Motorola.Acp.PackUnpack.Ish.IshType referencedIshType;
					list.Add(referencedIshType);
					num = (short)1153433603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_93;
				case 3:
					return;
				case 4:
				{
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType> list;
					if (!this.j.TryGetValue(A_1.Value, out list))
					{
						num = (short)1550254080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C5;
				}
				case 5:
				{
					global::Motorola.Acp.PackUnpack.Ish.IshType referencedIshType;
					if (!this.i.ContainsKey(referencedIshType.Value))
					{
						num = (short)1818820608;
						short num3 = num;
						num = (short)758513672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_93;
				}
				case 6:
				{
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType> list;
					global::Motorola.Acp.PackUnpack.Ish.IshType referencedIshType;
					if (!list.Contains(referencedIshType))
					{
						num = (short)1220739073;
						if (num != 0)
						{
						}
						num = (short)1547763713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 7:
					return;
				case 8:
				{
					num = (short)1204475;
					short num4 = num;
					num = (short)697327867;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
					{
						num = (short)1715404800;
						if (num != 0)
						{
						}
						global::Motorola.Acp.PackUnpack.Ish.IshType referencedIshType;
						this.i.Add(referencedIshType.Value, A_1);
						num = (short)1180827650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 9:
					goto IL_1C5;
				case 10:
					goto IL_14;
				}
				goto IL_50;
				IL_14:
				switch (0)
				{
				case 0:
					IL_50:
					if (A_0.Relationship != global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship.Synchronization)
					{
						num = (short)211746823;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::Motorola.Acp.PackUnpack.Ish.IshType referencedIshType = A_0.ReferencedIshType;
						num = (short)1920335877;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				continue;
				IL_93:
				num = (short)961544196;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C5:
				num = (short)1461649414;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00014AF8 File Offset: 0x00012CF8
		internal void a(global::Motorola.Acp.PackUnpack.Ish.Partition A_0, global::Motorola.Acp.PackUnpack.Ish.DataExchangeDirection A_1)
		{
			int a_ = 7;
			short num = (short)1113063429;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)2026085057;
					short num3 = num;
					num = (short)901028545;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B9;
					default:
						goto IL_9C;
					}
					break;
				}
				case 1:
					if (A_1 != global::Motorola.Acp.PackUnpack.Ish.DataExchangeDirection.Pack)
					{
						num = (short)1878589442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_154;
				case 2:
					goto IL_B9;
				case 3:
				{
					num = (short)859832320;
					short num4 = num;
					num = (short)250937345;
					if (num != 0)
					{
					}
					if (A_1 == global::Motorola.Acp.PackUnpack.Ish.DataExchangeDirection.Unpack)
					{
						num = (short)1825374208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_195;
				}
				case 4:
					goto IL_62;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				}
				IL_46:
				if (A_0 == null)
				{
					num = (short)1770520580;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2086666241;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B9:
				num = (short)619708419;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_62:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솟킡킣쾥\udca7쎩쎫삭", a_));
			IL_9C:
			num = (short)2021392384;
			if (num != 0)
			{
			}
			this.DoUnpackExchange(A_0);
			return;
			IL_154:
			this.DoPackExchange(A_0);
			return;
			IL_195:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("瞧즟킡솣얥\udca7쎩쎫삭", a_));
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00014CB0 File Offset: 0x00012EB0
		internal void a(global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection A_0, global::Motorola.Acp.PackUnpack.Ish.DataExchangeDirection A_1)
		{
			int a_ = 0;
			short num = (short)1230503938;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator;
				switch (num2)
				{
				case 0:
					goto IL_7D;
				case 1:
					try
					{
						num = (short)1651245065;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)704587552;
								short num3 = num;
								num = (short)835528480;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1D9;
								default:
									num = (short)503775232;
									if (num != 0)
									{
									}
									num = (short)194707457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_1D9;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)248643588;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.Partition partition = enumerator.Current;
								num = (short)1349320712;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)440860678;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::Motorola.Acp.PackUnpack.Ish.Partition partition;
								this.DoUnpackExchange(partition);
								num = (short)648609799;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								goto IL_238;
							case 8:
							{
								if (A_1 != global::Motorola.Acp.PackUnpack.Ish.DataExchangeDirection.Pack)
								{
									num = (short)2084372480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.Partition partition;
								this.DoPackExchange(partition);
								num = (short)567607298;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								switch (0)
								{
								case 0:
									goto IL_CE;
								}
								continue;
							}
							IL_11C:
							num = (short)731185155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_CE:
							goto IL_11C;
							IL_1D9:
							if (A_1 != global::Motorola.Acp.PackUnpack.Ish.DataExchangeDirection.Unpack)
							{
								break;
							}
							num = (short)1979777029;
							num2 = (int)((global::System.IntPtr)num);
						}
						throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﲞ햠쪢쪤즦", a_));
						IL_238:
						goto IL_308;
					}
					finally
					{
						num = (short)1262354434;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)399179777;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_2A3;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_26E;
								}
								continue;
							}
							IL_26E:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1743454208;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2A3:;
					}
					goto IL_2A6;
				case 2:
					num = (short)81985537;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				}
				IL_62:
				if (A_0 == null)
				{
					num = (short)526319616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_2A6:
				enumerator = A_0.GetEnumerator();
				num = (short)1054474241;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7D:
			num = (short)5439488;
			short num4 = num;
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("햠쪢쪤즦\udaa8", a_));
			IL_308:
			this.c(A_0);
			this.c();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00014FF0 File Offset: 0x000131F0
		private void c(global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection A_0)
		{
			int num;
			global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField itemReferenceField;
			short num2;
			global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField itemReferenceField2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (itemReferenceField == null)
						{
							num2 = (short)517341186;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_109;
					case 1:
					{
						num2 = (short)2016739328;
						short num3 = num2;
						num2 = (short)1932119436;
						short num4 = num2;
						num2 = (short)454086028;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B;
						default:
							num2 = (short)1538981888;
							if (num2 != 0)
							{
							}
							num2 = (short)157220864;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_107;
					case 3:
						if (itemReferenceField2 != null)
						{
							num2 = (short)1670709249;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_D0;
					}
					goto IL_20;
				}
				IL_D0:
				throw new global::System.IO.InvalidDataException();
				IL_107:
				goto IL_D0;
				IL_109:
				num2 = (short)1093402625;
				if (num2 != 0)
				{
				}
				this.a(A_0, itemReferenceField2, itemReferenceField);
				this.a(A_0);
				this.b(A_0);
				return;
			}
			IL_20:
			this.a(A_0, out itemReferenceField2, out itemReferenceField);
			IL_2B:
			num2 = (short)617873411;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00015144 File Offset: 0x00013344
		private void a(global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection A_0, global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem A_1, global::Motorola.Acp.PackUnpack.Ish.IshItemName A_2, global::AcpCommonLib.IAcpFeatureNode A_3)
		{
			short num = (short)1739390976;
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
				global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem;
				for (;;)
				{
					IL_28:
					global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout;
					int num4;
					global::AcpBusinessLayer.Recordset recordset;
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_378;
					case 2:
						goto IL_378;
					case 3:
						try
						{
							num = (short)1902772231;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)562626564;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_23F;
								case 2:
								{
									num = (short)700123761;
									short num3 = num;
									num = (short)1310722673;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)1556217856;
										if (num != 0)
										{
										}
										global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
										if (field == null)
										{
											num = (short)1469775875;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpField a_;
										this.a(a_, field);
										num = (short)453836806;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 3:
									num = (short)102629377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_25C;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)493748224;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange = enumerator.Current;
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									global::AcpCommonLib.IAcpField a_ = acpFeatureSection[fieldExchange.PropertyName];
									int a_2;
									global::Motorola.Acp.PackUnpack.Ish.Fields.Field field = this.a(listHeaderItem.HeaderListEntries, a_2, listLayout.ListEntryLayout.FieldLayouts.Count, fieldExchange.Layout);
									num = (short)1886846978;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_FA;
									}
									continue;
								}
								IL_1E8:
								num = (short)602669061;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FA:
								goto IL_1E8;
							}
							IL_23F:
							IL_25C:
							goto IL_3E9;
						}
						finally
						{
							num = (short)2138898434;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1606025217;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2CE;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_295;
									}
									continue;
								}
								IL_295:
								if (enumerator == null)
								{
									break;
								}
								num = (short)550830080;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2CE:;
						}
						goto IL_2D1;
						IL_3E9:
						num4++;
						num = (short)809631745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (num4 >= listHeaderItem.Count)
						{
							num = (short)1739063296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = ((global::AcpBusinessLayer.FeatureNode)recordset[num4])[sectionExchange.Key];
						int a_2 = num4 * listLayout.ListEntryLayout.FieldLayouts.Count;
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator = sectionExchange.GetEnumerator();
						num = (short)1741422595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_AF;
					case 6:
						num = (short)1795293185;
						if (num != 0)
						{
						}
						if (listHeaderItem == null)
						{
							num = (short)259194885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D1;
					}
					goto IL_4B;
					IL_2D1:
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.a a_3 = this.f[listHeaderItem.Type][global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListEntry];
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange a_4 = this.b(a_3);
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange2 = this.a(a_4);
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange a_5 = sectionExchange2.RecsetExchange;
					sectionExchange = this.a(a_5);
					recordset = (A_3[sectionExchange2.Key].EmbeddedRecset as global::AcpBusinessLayer.Recordset);
					this.b.Add(listHeaderItem.Name, recordset);
					this.a(listHeaderItem.Count, recordset);
					listLayout = this.a(listHeaderItem.Type);
					num4 = 0;
					num = (short)1820262402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_378:
					num = (short)56492036;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AF:
				num = (short)1401159680;
				short num5 = num;
				throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.IshItemNotFoundException();
				IL_4B:
				listHeaderItem = this.a(A_0, A_2);
				num = (short)2133131270;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000155D4 File Offset: 0x000137D4
		private global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection a(global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection A_0, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType A_1, int A_2)
		{
			short num = (short)1164312577;
			if (num != 0)
			{
			}
			num = (short)1511915520;
			short num2 = num;
			global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection = null;
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator = A_0.GetEnumerator();
			try
			{
				num = (short)576520198;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)359727107;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_18C;
					case 2:
						num = (short)1816723457;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1A9;
					case 4:
						if (!enumerator.MoveNext())
						{
							num = (short)1335361536;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A2;
					case 5:
					{
						num = (short)328197798;
						short num4 = num;
						num = (short)493479590;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A2;
						default:
							num = (short)905117696;
							if (num != 0)
							{
							}
							if (listItemCollection != null)
							{
								num = (short)595656706;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						break;
					}
					case 6:
						switch (0)
						{
						case 0:
							goto IL_9D;
						}
						continue;
					}
					goto IL_9D;
					IL_A2:
					listItemCollection = enumerator.Current.Items.ListItems.Find(A_1, A_2);
					num = (short)226230277;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_137:
					num = (short)586022916;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_9D:
					goto IL_137;
				}
				IL_18C:
				IL_1A9:;
			}
			finally
			{
				num = (short)1443627010;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1394475009;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_20E;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1DB;
						}
						continue;
					}
					IL_1DB:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1969291264;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_20E:;
			}
			return listItemCollection;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00015810 File Offset: 0x00013A10
		private void b(global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection A_0)
		{
			short num = (short)1772748801;
			if (num != 0)
			{
			}
			num = (short)394788864;
			switch (num)
			{
			default:
			{
				num = (short)1312489472;
				short num2 = num;
				using (global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType>.Enumerator enumerator = this.k[global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.a.d].GetEnumerator())
				{
					num = (short)1232994308;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							try
							{
								num = (short)1385299972;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> enumerator2;
										if (enumerator2.MoveNext())
										{
											global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection a_ = enumerator2.Current;
											global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
											global::Motorola.Acp.PackUnpack.Ish.DataExchange.b a_2 = this.a(ishType);
											this.a((global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)ishType, a_2, a_);
											num = (short)1388249089;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)523577659;
										short num4 = num;
										num = (short)1964845371;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)1204289536;
											if (num != 0)
											{
											}
											num = (short)555220994;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										num = (short)1687420931;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_248;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_167;
										}
										continue;
									}
									IL_169:
									num = (short)218497024;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_167:
									goto IL_169;
								}
								IL_248:
								break;
							}
							finally
							{
								num = (short)1339883522;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> enumerator2;
									switch (num3)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)1177485313;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_2B7;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_280;
										}
										continue;
									}
									IL_280:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1785921536;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_2B7:;
							}
							goto IL_2BA;
						case 1:
							goto IL_2BA;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1910177793;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.IshType ishType = enumerator.Current;
							global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> enumerator2 = this.l[ishType].GetEnumerator();
							num = (short)961740800;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_2D3;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_BC;
							}
							continue;
						}
						IL_F0:
						num = (short)1194262530;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_BC:
						goto IL_F0;
						IL_2BA:
						num = (short)1197146115;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2D3:;
				}
				return;
			}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00015B34 File Offset: 0x00013D34
		private void a(global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection A_0)
		{
			int a_ = 15;
			short num = (short)1046937600;
			short num2 = num;
			num = (short)1210843136;
			switch (num)
			{
			default:
			{
				num = (short)453050369;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField = null;
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField2 = null;
				using (global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType>.Enumerator enumerator = this.k[global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.a.e].GetEnumerator())
				{
					num = (short)127991812;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> list;
							if (list == null)
							{
								num = (short)418316290;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b;
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.a a_2 = b[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListEntry];
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange = this.b(a_2);
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange = this.a(recsetExchange);
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange a_3 = this.b(sectionExchange);
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange2 = this.a(a_3);
							global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange.Key);
							this.a(list.Count, recordset);
							int num4 = 0;
							global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> enumerator2 = list.GetEnumerator();
							num = (short)1987706887;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
							global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> list = this.l[ishType];
							num = (short)755962732;
							short num5 = num;
							num = (short)347935596;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1A8;
							default:
								num = (short)1861943296;
								if (num != 0)
								{
								}
								num = (short)1383989248;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_173;
						case 3:
							num = (short)1794637829;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_DD;
							}
							continue;
						case 5:
							goto IL_9CD;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)986120195;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.IshType ishType = enumerator.Current;
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b = this.a(ishType);
							num = (short)453181448;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							try
							{
								num = (short)1554317322;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									int num4;
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem;
									global::AcpBusinessLayer.Recordset recordset2;
									int num6;
									switch (num3)
									{
									case 0:
										goto IL_80D;
									case 1:
										num = (short)1572470789;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_242;
									case 4:
										goto IL_764;
									case 5:
										goto IL_888;
									case 6:
									{
										global::AcpBusinessLayer.FeatureNode featureNode;
										this.a.Add(listHeaderItem.Name, featureNode);
										num = (short)1562509329;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
										goto IL_69B;
									case 8:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshItemName name;
										if (!name.IsNull)
										{
											num = (short)68812819;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_80D;
									}
									case 9:
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1240203265;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection = enumerator2.Current;
										global::AcpBusinessLayer.Recordset recordset;
										global::AcpBusinessLayer.FeatureNode featureNode = (global::AcpBusinessLayer.FeatureNode)recordset[num4];
										global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange;
										recordset2 = (global::AcpBusinessLayer.Recordset)featureNode[sectionExchange.Key].EmbeddedRecset;
										listHeaderItem = (global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem)listItemCollection[0];
										num = (short)43974668;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
										switch (0)
										{
										case 0:
											goto IL_23D;
										}
										continue;
									case 11:
										goto IL_86A;
									case 12:
										if (this.c(listHeaderItem.Type))
										{
											num = (short)964952070;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3AA;
									case 13:
										if (acpRecRefField == null)
										{
											num = (short)1843265540;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1220214802;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 14:
										try
										{
											num = (short)1541931013;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
												{
													global::AcpCommonLib.IAcpField acpField;
													acpRecRefField2 = (global::AcpBusinessLayer.AcpRecRefField)acpField;
													num = (short)1741422598;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 1:
													if (acpRecRefField2 != null)
													{
														num = (short)977010690;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 2:
													num = (short)742326276;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
												{
													global::AcpCommonLib.IAcpField acpField;
													acpRecRefField = (global::AcpBusinessLayer.AcpRecRefField)acpField;
													num = (short)495910919;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 4:
													goto IL_60A;
												case 5:
													switch (0)
													{
													case 0:
														goto IL_43B;
													}
													continue;
												case 6:
													goto IL_556;
												case 7:
													goto IL_556;
												case 8:
													if (acpRecRefField != null)
													{
														num = (short)1666973705;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 9:
													num = (short)1660813313;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 10:
												{
													global::AcpCommonLib.IAcpField acpField;
													if (acpField.Name.Contains(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즧용삫", a_)))
													{
														num = (short)1651113984;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_556;
												}
												case 11:
													goto IL_627;
												case 12:
												{
													global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
													if (!enumerator3.MoveNext())
													{
														num = (short)297467917;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpCommonLib.IAcpField acpField = enumerator3.Current;
													num = (short)1463484430;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 13:
													num = (short)1081475083;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 14:
												{
													global::AcpCommonLib.IAcpField acpField;
													if (acpField.Name.Contains(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("잧쒩\ud8ab쾭펯욱\udab5톷\udbb9쾻", a_)))
													{
														num = (short)138215427;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)1340342282;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												goto IL_43B;
												IL_556:
												num = (short)1049493512;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_5B2:
												num = (short)577830924;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_43B:
												goto IL_5B2;
											}
											IL_60A:
											IL_627:
											goto IL_72C;
										}
										finally
										{
											num = (short)1173356544;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
												switch (num3)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_65F;
													}
													continue;
												case 1:
													goto IL_698;
												case 2:
													enumerator3.Dispose();
													num = (short)1118568449;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_65F:
												if (enumerator3 == null)
												{
													break;
												}
												num = (short)1953759234;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_698:;
										}
										goto IL_69B;
										IL_72C:
										num = (short)209387533;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 15:
									{
										if (num6 >= listHeaderItem.Count)
										{
											num = (short)1630339079;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Acp.PackUnpack.Ish.Fields.IndexReferenceField indexReferenceField = (global::Motorola.Acp.PackUnpack.Ish.Fields.IndexReferenceField)listHeaderItem.HeaderListEntries.UnpackedData[num6];
										global::Motorola.Acp.PackUnpack.Ish.IshItemName name = indexReferenceField.Name;
										num = (short)240713736;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 16:
										goto IL_242;
									case 17:
										goto IL_3AA;
									case 18:
									{
										if (acpRecRefField2 == null)
										{
											num = (short)902496267;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Acp.PackUnpack.Ish.Fields.IndexReferenceField indexReferenceField;
										global::AcpCommonLib.IAcpRecordset acpRecordset = this.b[indexReferenceField.Name];
										acpRecRefField.ReferencedName = acpRecordset.ParentSection.Parent.Parent.IndexOf(acpRecordset.ParentSection.Parent);
										acpRecRefField2.ReferencedIndex = (int)indexReferenceField.Value;
										num = (short)1538195456;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 19:
									{
										global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange2;
										global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = ((global::AcpBusinessLayer.FeatureNode)recordset2[num6])[sectionExchange2.Key];
										acpRecRefField = null;
										acpRecRefField2 = null;
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3 = acpFeatureSection.FieldsCollection.GetEnumerator();
										num = (short)1358364686;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_23D;
									IL_242:
									num = (short)1373437967;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_281:
									num = (short)1587675145;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_23D:
									goto IL_281;
									IL_3AA:
									this.a(listHeaderItem.Count, recordset2);
									num6 = 0;
									num = (short)259457040;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_69B:
									num4++;
									num = (short)486080514;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_80D:
									num6++;
									num = (short)2022309891;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_764:
								throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.FieldNotFoundException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("잧쒩\ud8ab쾭펯욱\udab5톷\udbb9쾻", a_));
								IL_86A:
								throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.FieldNotFoundException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즧용삫", a_));
								IL_888:;
							}
							finally
							{
								num = (short)2076246016;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> enumerator2;
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_8BC;
										}
										continue;
									case 1:
										goto IL_8F5;
									case 2:
										enumerator2.Dispose();
										num = (short)1405353985;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_8BC:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)345505794;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_8F5:;
							}
							break;
						case 8:
						{
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b;
							if (b != null)
							{
								goto IL_1A8;
							}
							break;
						}
						}
						goto IL_DD;
						IL_1A8:
						num = (short)241631233;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_8F8:
						num = (short)363855878;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_DD:
						goto IL_8F8;
					}
					IL_173:
					throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.IshItemNotFoundException();
					IL_9CD:;
				}
				return;
			}
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0001656C File Offset: 0x0001476C
		private void a(global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection A_0, global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField A_1, global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField A_2)
		{
			int a_ = 2;
			short num = (short)1551564800;
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
				global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem;
				global::Motorola.Acp.PackUnpack.Ish.Partition partition;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange;
				global::AcpBusinessLayer.Recordset recordset;
				int num4;
				global::Motorola.Acp.PackUnpack.Ish.IshItemName value;
				for (;;)
				{
					IL_30:
					int num3;
					global::AcpBusinessLayer.FeatureNode featureNode;
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator2;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						if (num3 >= listHeaderItem.Count)
						{
							num = (short)2123366405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_150;
					case 2:
						goto IL_62A;
					case 3:
					{
						global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
						partition = ishType.Partition;
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.a a_2 = this.f[ishType][global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListHeader];
						recsetExchange = this.b(a_2);
						recordset = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange.Key);
						num = (short)963379213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						this.a.Add(listHeaderItem.Name, featureNode);
						num = (short)512557074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_52F;
					case 6:
						goto IL_570;
					case 7:
					{
						global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
						if (ishType.Partition != partition)
						{
							num = (short)452526083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B7;
					}
					case 8:
						goto IL_66E;
					case 9:
						featureNode = (global::AcpBusinessLayer.FeatureNode)recordset[num4];
						num = (short)1266745361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
						if (ishType.Partition.PartitionType == global::Motorola.Acp.PackUnpack.Ish.PartitionType.Application)
						{
							num = (short)53215236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_82A;
					}
					case 11:
					{
						global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
						if (ishType == null)
						{
							num = (short)2047475732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)764149767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						if (value.IsNull)
						{
							num = (short)2078081024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.IshType ishType = this.a(A_0, value.Type);
						num = (short)1852375051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_5B7;
					case 14:
						try
						{
							num = (short)373358592;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator;
								global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_21E;
									}
									continue;
								case 1:
									num = (short)1683423234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_4BC;
								case 3:
									try
									{
										num = (short)1714094085;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 1:
												num = (short)367198216;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)2039676929;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange = enumerator.Current;
												global::AcpCommonLib.IAcpField a_3 = acpFeatureSection[fieldExchange.PropertyName];
												global::Motorola.Acp.PackUnpack.Ish.Fields.Field field = this.a(listHeaderItem.HeaderDataArea, fieldExchange.Layout);
												num = (short)981991433;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												goto IL_2C1;
											case 4:
												num = (short)1970601987;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												switch (0)
												{
												case 0:
													goto IL_271;
												}
												continue;
											case 6:
											{
												global::AcpCommonLib.IAcpField a_3;
												global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
												this.a(a_3, field);
												num = (short)1637613568;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
											{
												global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
												if (!(field.Layout is global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout))
												{
													num = (short)798818310;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 8:
												goto IL_3B0;
											case 9:
											{
												global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
												if (field == null)
												{
													num = (short)73007108;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1326776327;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_273:
											num = (short)824377346;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_271:
											goto IL_273;
										}
										IL_2C1:
										IL_3B0:
										break;
									}
									finally
									{
										num = (short)671350785;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_421;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_3E8;
												}
												continue;
											case 2:
												enumerator.Dispose();
												num = (short)1024786432;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_3E8:
											if (enumerator == null)
											{
												break;
											}
											num = (short)390135810;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_421:;
									}
									goto IL_424;
								case 4:
									if (!enumerator2.MoveNext())
									{
										num = (short)2117795841;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_424;
								}
								goto IL_21E;
								IL_424:
								global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange = enumerator2.Current;
								acpFeatureSection = featureNode[sectionExchange.Key];
								enumerator = sectionExchange.GetEnumerator();
								num = (short)848494595;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_464:
								num = (short)2043346948;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_21E:
								goto IL_464;
							}
							IL_4BC:
							goto IL_80A;
						}
						finally
						{
							num = (short)1514536961;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_52C;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4F4;
									}
									continue;
								case 2:
									enumerator2.Dispose();
									num = (short)445972480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4F4:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)800456706;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_52C:;
						}
						goto IL_52F;
						IL_80A:
						num3 = 0;
						num = (short)354942995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_66E;
					case 16:
						if (num4 < recordset.Count)
						{
							num = (short)1941176329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						featureNode = recordset.CreateDefaultRecordHelper();
						recordset.AddRecord(featureNode);
						num = (short)1607008262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_570;
					case 18:
						goto IL_82A;
					case 19:
						goto IL_62A;
					case 20:
						goto IL_783;
					case 21:
						goto IL_625;
					case 22:
						if (listHeaderItem == null)
						{
							num = (short)949485589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)193527824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_93;
					IL_150:
					global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField itemReferenceField = (global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField)listHeaderItem.HeaderListEntries.UnpackedData[num3];
					this.a(A_0, listHeaderItem, itemReferenceField.Value, featureNode);
					num3++;
					num = (short)1960247298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_52F:
					value = ((global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField)listHeaderItem.HeaderDataArea.UnpackedData[1]).Value;
					num4++;
					num = (short)697040911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_570:
					num = (short)1260322826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B7:
					listHeaderItem = this.a(partition, value);
					num = (short)143196160;
					short num5 = num;
					num = (short)6357014;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_62A:
					num = (short)1472266241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_82A:
					num = (short)1913651201;
					if (num != 0)
					{
					}
					enumerator2 = recsetExchange.GetEnumerator();
					num = (short)2093023246;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_66E:
					num = (short)1505734506;
					short num6 = num;
					num = (short)1358344042;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_150;
					default:
						num = (short)928907264;
						if (num != 0)
						{
						}
						num = (short)172621836;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_625:
				throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.IshItemNotFoundException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\uda98漢캠힢薤솦삨얪즬辮ﶴ鞶킸쾺\ud8bc튾럂별럆곈뛌ￎ곐ￒ뻖뷘ﯚꛜ鳠", a_), value.Type, value.Id));
				IL_783:
				throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.IshTypeNotFoundException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\uda98漢캠힢薤솦삨얪즬辮ﾲﶴ鞶춸슺춼\udabe룂뫆", a_), value.Type));
				IL_93:
				partition = null;
				recsetExchange = null;
				recordset = null;
				value = A_1.Value;
				listHeaderItem = null;
				num4 = 0;
				num = (short)837746696;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00016E54 File Offset: 0x00015054
		private global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem a(global::Motorola.Acp.PackUnpack.Ish.Partition A_0, global::Motorola.Acp.PackUnpack.Ish.IshItemName A_1)
		{
			short num = (short)1348730880;
			short num2 = num;
			num = (short)1971048876;
			short num3 = num;
			num = (short)857395628;
			switch (num3 == num)
			{
			}
			num = (short)1060569088;
			if (num != 0)
			{
			}
			num = (short)1758396417;
			if (num != 0)
			{
			}
			return A_0.Items.ListHeaderFinder.Find(A_1);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00016F10 File Offset: 0x00015110
		private global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem a(global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection A_0, global::Motorola.Acp.PackUnpack.Ish.IshItemName A_1)
		{
			short num = (short)142409729;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem = null;
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator = A_0.GetEnumerator();
			try
			{
				num = (short)227737602;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (listHeaderItem != null)
						{
							num = (short)1400373254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 1:
						goto IL_105;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_72;
						}
						continue;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)1930952708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						listHeaderItem = enumerator.Current.Items.ListHeaderFinder.Find(A_1);
						num = (short)2052784128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)718798853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_121;
					case 6:
						num = (short)846856193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B8:
					num = (short)891289603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_72:
					goto IL_B8;
				}
				IL_105:
				IL_121:;
			}
			finally
			{
				num = (short)1204486145;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)2146748643;
						short num3 = num;
						num = (short)996591843;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_1BE;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_156;
						}
						continue;
					case 2:
						enumerator.Dispose();
						num = (short)1105264640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_156:
					if (enumerator == null)
					{
						goto IL_1D5;
					}
					num = (short)158728194;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1BE:
				num = (short)320405504;
				if (num != 0)
				{
				}
				IL_1D5:;
			}
			num = (short)1613496320;
			short num4 = num;
			return listHeaderItem;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0001712C File Offset: 0x0001532C
		private global::Motorola.Acp.PackUnpack.Ish.Partition a(global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection A_0, global::Motorola.Acp.PackUnpack.Ish.IshType A_1)
		{
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator = A_0.GetEnumerator();
			short num;
			global::Motorola.Acp.PackUnpack.Ish.Partition result;
			try
			{
				num = (short)1340145667;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.Acp.PackUnpack.Ish.Partition partition;
						result = partition;
						num = (short)1776156677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.Acp.PackUnpack.Ish.Partition partition;
						if (partition.Layouts.a(A_1))
						{
							num = (short)1979842560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						num = (short)128188420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_9A;
						}
						continue;
					case 4:
						goto IL_146;
					case 5:
						goto IL_12A;
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1808793602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.Partition partition = enumerator.Current;
						num = (short)1262878721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_9C:
					num = (short)1791754246;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A:
					goto IL_9C;
				}
				IL_12A:
				return result;
				IL_146:
				goto IL_09;
			}
			finally
			{
				num = (short)46202882;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_202;
					case 1:
						enumerator.Dispose();
						num = (short)2041839616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_161;
					}
					goto IL_17D;
					IL_161:
					switch (0)
					{
					case 0:
					{
						IL_17D:
						if (enumerator == null)
						{
							goto IL_204;
						}
						num = (short)215478815;
						short num3 = num;
						num = (short)636088863;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_161;
						default:
							num = (short)1999765504;
							if (num != 0)
							{
							}
							num = (short)69599233;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						break;
					}
					}
				}
				IL_202:
				IL_204:;
			}
			return result;
			IL_09:
			num = (short)763691008;
			short num4 = num;
			num = (short)190447617;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00017350 File Offset: 0x00015550
		private void a(global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection A_0, out global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField A_1, out global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField A_2)
		{
			short num = (short)450691072;
			switch (num)
			{
			default:
			{
				num = (short)285016064;
				short num2 = num;
				A_1 = null;
				A_2 = null;
				global::Motorola.Acp.PackUnpack.Ish.CompositeType compositeType = (global::Motorola.Acp.PackUnpack.Ish.CompositeType)this.k[global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.a.b][0];
				global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem = this.m[compositeType];
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.a a = this.a(compositeType)[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.Composite];
				A_1 = (global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField)compositeItem.DataArea.UnpackedData[0];
				A_2 = (global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField)compositeItem.DataArea.UnpackedData[1];
				global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange> enumerator = a.GetEnumerator();
				try
				{
					num = (short)1250164737;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)994902019;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange = enumerator.Current;
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange.Key)[0];
							global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator2 = recsetExchange.GetEnumerator();
							num = (short)1076363268;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_F2;
							}
							continue;
						case 2:
							goto IL_61D;
						case 3:
							goto IL_605;
						case 4:
							try
							{
								num = (short)305528833;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator2;
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator3;
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									switch (num3)
									{
									case 0:
										num = (short)1608908802;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1A7;
										}
										continue;
									case 2:
										goto IL_594;
									case 3:
										try
										{
											num = (short)1821966336;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_251;
													}
													continue;
												case 2:
												{
													global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
													if (field.Layout.Offset == 4)
													{
														num = (short)1137049611;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_3ED;
												}
												case 3:
													goto IL_478;
												case 4:
													num = (short)1038745605;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 5:
												{
													global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
													if (field.Layout.Offset == 0)
													{
														num = (short)1404764174;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)406126594;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 6:
													num = (short)139132936;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 8:
													goto IL_37F;
												case 9:
												{
													global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
													if (field.Layout is global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout)
													{
														num = (short)1873543172;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpCommonLib.IAcpField a_;
													this.a(a_, field);
													num = (short)2026110977;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 10:
													num = (short)689963011;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 11:
												{
													global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
													A_2 = (global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField)field;
													num = (short)2125856775;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 12:
												{
													if (!enumerator3.MoveNext())
													{
														num = (short)1241579530;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange = enumerator3.Current;
													global::AcpCommonLib.IAcpField a_ = acpFeatureSection[fieldExchange.PropertyName];
													global::Motorola.Acp.PackUnpack.Ish.Fields.Field field = this.a(compositeItem.DataArea, fieldExchange.Layout);
													num = (short)681574413;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 13:
												{
													global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
													if (field == null)
													{
														num = (short)244121606;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)1452539913;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 14:
												{
													global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
													A_1 = (global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField)field;
													num = (short)1256390671;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												IL_256:
												num = (short)289734668;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_251:
												goto IL_256;
											}
											IL_37F:
											break;
											IL_3ED:
											throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.FieldNotFoundException();
											IL_478:
											break;
										}
										finally
										{
											num = (short)41615362;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													goto IL_53B;
												case 1:
													enumerator3.Dispose();
													num = (short)419889152;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													goto IL_493;
												}
												goto IL_4B0;
												IL_493:
												switch (0)
												{
												case 0:
												{
													IL_4B0:
													if (enumerator3 == null)
													{
														goto IL_53D;
													}
													num = (short)77547221;
													short num4 = num;
													num = (short)248465109;
													switch ((num4 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														goto IL_493;
													default:
														num = (short)1575485440;
														if (num != 0)
														{
														}
														num = (short)255524865;
														num3 = (int)((global::System.IntPtr)num);
														break;
													}
													break;
												}
												}
											}
											IL_53B:
											IL_53D:;
										}
										goto IL_53E;
									case 4:
										if (!enumerator2.MoveNext())
										{
											num = (short)68681728;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_53E;
									}
									IL_1AC:
									num = (short)736296964;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_1A7:
									goto IL_1AC;
									IL_53E:
									global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange = enumerator2.Current;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									acpFeatureSection = acpFeatureNode[sectionExchange.Key];
									enumerator3 = sectionExchange.GetEnumerator();
									num = (short)1133707267;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_594:
								break;
							}
							finally
							{
								num = (short)1506213890;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator2;
									switch (num3)
									{
									case 0:
										goto IL_602;
									case 1:
										enumerator2.Dispose();
										num = (short)1302462464;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_5CB;
										}
										continue;
									}
									IL_5CB:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)951123969;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_602:;
							}
							goto IL_605;
						}
						IL_12E:
						num = (short)65601536;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_F2:
						goto IL_12E;
						IL_605:
						num = (short)2011037698;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_61D:;
				}
				finally
				{
					num = (short)1786904578;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_68B;
						case 1:
							enumerator.Dispose();
							num = (short)66191360;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_651;
							}
							continue;
						}
						IL_651:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1606352897;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_68B:;
				}
				num = (short)2088632321;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00017A60 File Offset: 0x00015C60
		protected virtual void DoPackExchange(global::Motorola.Acp.PackUnpack.Ish.Partition partition)
		{
			short num = (short)1886106068;
			short num2 = num;
			num = (short)240890324;
			switch (num2 == num)
			{
			}
			num = (short)1264582656;
			short num3 = num;
			num = (short)1422721025;
			if (num != 0)
			{
			}
			num = (short)1448607744;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00017B08 File Offset: 0x00015D08
		protected virtual void DoUnpackExchange(global::Motorola.Acp.PackUnpack.Ish.Partition partition)
		{
			short num = (short)843513856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3F;
				}
				global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> enumerator4;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> enumerator;
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>> enumerator2;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)977862661;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2109276164;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection = enumerator.Current;
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType = (global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)this.a(listItemCollection);
									global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b = this.a(listHeaderType);
									num = (short)624820226;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b;
									if (b != null)
									{
										num = (short)1615462406;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection;
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
									this.a(global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.a.d, listHeaderType, listItemCollection);
									num = (short)1522991105;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1636892680;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_6DE;
									}
									continue;
								case 6:
									num = (short)859963401;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_815;
								case 9:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
									if (listHeaderType is global::Motorola.Acp.PackUnpack.Ish.UclHotListAliasTextListHeaderType)
									{
										num = (short)430637059;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection;
									global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b;
									this.a(listHeaderType, b, listItemCollection);
									num = (short)2087452679;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_7BD:
								num = (short)1968701440;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6DE:
								goto IL_7BD;
							}
							IL_815:
							goto IL_631;
						}
						finally
						{
							num = (short)1347616768;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_84E;
									}
									continue;
								case 1:
									goto IL_886;
								case 2:
									enumerator.Dispose();
									num = (short)453246977;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_84E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)444792834;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_886:;
						}
						goto Block_4;
					case 1:
						goto IL_889;
					case 2:
						try
						{
							num = (short)171311106;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3CF;
								case 1:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
									global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> list;
									this.a(global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.a.d, listHeaderType, list);
									num = (short)607518733;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_15C;
									}
									continue;
								case 3:
								{
									global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b;
									if (b != null)
									{
										num = (short)1368522770;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
									if (listHeaderType is global::Motorola.Acp.PackUnpack.Ish.UclHotListAliasTextListHeaderType)
									{
										num = (short)564133889;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b;
									global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> list;
									this.a(listHeaderType, b, list);
									num = (short)815267844;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1007419403;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> list = enumerator2.Current;
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType = (global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)this.a(list);
									global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b = this.a(listHeaderType);
									num = (short)344981507;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
									global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> list;
									this.a(global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.a.a, listHeaderType, list);
									num = (short)958267402;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
									if (listHeaderType is global::Motorola.Acp.PackUnpack.Ish.UclHotListHeaderType)
									{
										num = (short)230096911;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1958346757;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
									global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> list;
									this.a(global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.a.c, listHeaderType, list);
									num = (short)684392460;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)1609826304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
									global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> list;
									this.a(global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.a.e, listHeaderType, list);
									num = (short)46858254;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
									if (listHeaderType is global::Motorola.Acp.PackUnpack.Ish.UclContactListHeaderType)
									{
										num = (short)1654325257;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)637272072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
									if (listHeaderType is global::Motorola.Acp.PackUnpack.Ish.UclCallIdListHeaderType)
									{
										num = (short)1948319751;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)177602576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
									num = (short)1412562961;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_280:
								num = (short)2096824326;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_15C:
								goto IL_280;
							}
							IL_3CF:
							return;
						}
						finally
						{
							num = (short)841416706;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_43F;
								case 1:
									enumerator2.Dispose();
									num = (short)1694040064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_406;
									}
									continue;
								}
								IL_406:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1574502401;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_43F:;
						}
						goto Block_2;
					case 3:
						goto IL_442;
					}
					goto IL_3F;
					Block_4:
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>> enumerator3;
					try
					{
						IL_889:
						num = (short)260308992;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_8C4;
								}
								continue;
							case 1:
								num = (short)1327759363;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_93E;
							case 4:
							{
								if (!enumerator3.MoveNext())
								{
									num = (short)944832513;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> a_ = enumerator3.Current;
								this.a(a_);
								num = (short)480575490;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_8EF:
							num = (short)1488977924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_8C4:
							goto IL_8EF;
						}
						IL_93E:
						goto IL_6A;
					}
					finally
					{
						num = (short)465371136;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_959;
							case 1:
								goto IL_9FF;
							case 2:
							{
								enumerator3.Dispose();
								num = (short)932563514;
								short num3 = num;
								num = (short)1224067642;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_959;
								default:
									num = (short)661979136;
									if (num != 0)
									{
									}
									num = (short)1677983745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							goto IL_976;
							IL_959:
							switch (0)
							{
							case 0:
								IL_976:
								if (enumerator3 == null)
								{
									goto IL_A01;
								}
								num = (short)1295515650;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_9FF:
						IL_A01:;
					}
					break;
					IL_6A:
					num = (short)1262157824;
					short num4 = num;
					enumerator = partition.Items.SingleInstanceLists.GetEnumerator();
					num = (short)1001979905;
					if (num != 0)
					{
					}
					num = (short)1768947712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_631:
					enumerator2 = partition.Items.MultiInstanceLists.GetEnumerator();
					num = (short)468910082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_2:
					try
					{
						IL_442:
						num = (short)1144586246;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1761148935;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem;
								if (compositeItem.Type is global::Motorola.Acp.PackUnpack.Ish.UclConfigurationCompositeType)
								{
									num = (short)650641417;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b;
								this.a(compositeItem, b);
								num = (short)1829634056;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								if (!enumerator4.MoveNext())
								{
									num = (short)1936064512;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem = enumerator4.Current;
								global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b = this.a(compositeItem.Type);
								num = (short)1240662021;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)2123694081;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b;
								if (b != null)
								{
									num = (short)31195140;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_490;
								}
								continue;
							case 7:
								goto IL_5C0;
							case 9:
							{
								global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem;
								this.a(global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.a.b, compositeItem);
								num = (short)128319491;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_4D3:
							num = (short)1049755650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_490:
							goto IL_4D3;
						}
						IL_5C0:
						goto IL_660;
					}
					finally
					{
						num = (short)863961088;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_5F7;
								}
								continue;
							case 1:
								goto IL_62E;
							case 2:
								enumerator4.Dispose();
								num = (short)864223233;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_5F7:
							if (enumerator4 == null)
							{
								break;
							}
							num = (short)945946626;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_62E:;
					}
					goto IL_631;
					IL_660:
					enumerator3 = partition.Items.MultiInstanceComposites.GetEnumerator();
					num = (short)1778057217;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3F:
				enumerator4 = partition.Items.SingleInstanceComposites.GetEnumerator();
				num = (short)1034616835;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0001857C File Offset: 0x0001677C
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout b(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			short num = (short)148897792;
			short num2 = num;
			num = (short)430742960;
			short num3 = num;
			num = (short)225877424;
			switch (num3 == num)
			{
			}
			num = (short)326041601;
			if (num != 0)
			{
			}
			num = (short)1156644864;
			if (num != 0)
			{
			}
			return A_0.Partition.Layouts.Find(A_0);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00018638 File Offset: 0x00016838
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout a(global::Motorola.Acp.PackUnpack.Ish.CompositeType A_0)
		{
			short num = (short)135987200;
			short num2 = num;
			num = (short)1476137914;
			short num3 = num;
			num = (short)1775637434;
			switch (num3 == num)
			{
			}
			num = (short)858718209;
			if (num != 0)
			{
			}
			num = (short)594149376;
			if (num != 0)
			{
			}
			return A_0.Partition.Layouts.Find(A_0);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000186F4 File Offset: 0x000168F4
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout b(global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> A_0)
		{
			short num = (short)891355136;
			short num2 = num;
			num = (short)1333965805;
			short num3 = num;
			num = (short)2049815533;
			switch (num3 == num)
			{
			}
			num = (short)1499725825;
			if (num != 0)
			{
			}
			num = (short)906887168;
			if (num != 0)
			{
			}
			return this.a(A_0[0].Type);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000187B0 File Offset: 0x000169B0
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout a(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType A_0)
		{
			short num = (short)1420558336;
			short num2 = num;
			num = (short)886787615;
			short num3 = num;
			num = (short)1027034655;
			switch (num3 == num)
			{
			}
			num = (short)477429761;
			if (num != 0)
			{
			}
			num = (short)1827536896;
			if (num != 0)
			{
			}
			return A_0.Partition.Layouts.Find(A_0);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0001886C File Offset: 0x00016A6C
		private int b(global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection A_0)
		{
			int num;
			short num2;
			int num5;
			int num6;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_3A;
					case 1:
					{
						num2 = (short)480635390;
						short num3 = num2;
						num2 = (short)830532094;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_24;
						default:
							num2 = (short)1446576128;
							if (num2 != 0)
							{
							}
							num2 = (short)1265762305;
							if (num2 != 0)
							{
							}
							goto IL_3A;
						}
						break;
					}
					case 2:
					{
						num2 = (short)878116864;
						short num4 = num2;
						if (num5 >= A_0.Count)
						{
							num2 = (short)1082523651;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num6 += A_0[num5].Count;
						num5++;
						num2 = (short)1255407617;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
						return num6;
					}
					goto IL_20;
					IL_3A:
					num2 = (short)777650178;
					num = (int)((global::System.IntPtr)num2);
				}
				return num6;
			}
			IL_20:
			num6 = 0;
			num5 = 0;
			IL_24:
			num2 = (short)1145831424;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000189B8 File Offset: 0x00016BB8
		private void a(global::Motorola.Acp.PackUnpack.Ish.CompositeItem A_0, global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_1)
		{
			short num = (short)2073165825;
			if (num != 0)
			{
			}
			num = (short)959578112;
			short num2 = num;
			num = (short)307959450;
			short num3 = num;
			num = (short)910759578;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1982136320;
				if (num != 0)
				{
				}
				num = (short)513015808;
				switch (num)
				{
				default:
				{
					this.a(A_0.Type);
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange> enumerator = A_1[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.Composite].GetEnumerator();
					try
					{
						num = (short)1263534080;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_111;
								}
								continue;
							case 1:
								goto IL_2AC;
							case 2:
								try
								{
									num = (short)1787625472;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_1BE;
											}
											continue;
										case 2:
										{
											global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)2066415620;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange a_ = enumerator2.Current;
											global::AcpCommonLib.IAcpFeatureNode a_2;
											this.a(A_0.DataArea, a_2, a_);
											num = (short)1180827649;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											goto IL_23C;
										case 4:
											num = (short)613941251;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_1C0:
										num = (short)2057699330;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_1BE:
										goto IL_1C0;
									}
									IL_23C:
									break;
								}
								finally
								{
									num = (short)1738866688;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator2;
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_274;
											}
											continue;
										case 1:
											goto IL_2A9;
										case 2:
											enumerator2.Dispose();
											num = (short)374865921;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_274:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)638255106;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_2A9:;
								}
								goto IL_2AC;
							case 3:
								goto IL_2C5;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)417005569;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange = enumerator.Current;
								global::AcpCommonLib.IAcpFeatureNode a_2 = global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange.Key)[0];
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator2 = recsetExchange.GetEnumerator();
								num = (short)973340674;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_148:
							num = (short)1224867844;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_111:
							goto IL_148;
							IL_2AC:
							num = (short)1636302851;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_2C5:;
					}
					finally
					{
						num = (short)1347485696;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2FA;
								}
								continue;
							case 1:
								goto IL_331;
							case 2:
								enumerator.Dispose();
								num = (short)806289409;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2FA:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1759182850;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_331:;
					}
					break;
				}
				}
				break;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00018D30 File Offset: 0x00016F30
		private void a(global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> A_0)
		{
			short num = (short)1412169728;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)994312193;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_61;
				}
				for (;;)
				{
					IL_4E:
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b;
					bool flag;
					int num4;
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> enumerator2;
					global::AcpCommonLib.IAcpRecordset feature;
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange;
					switch (num2)
					{
					case 0:
					{
						num = (short)766574592;
						short num3 = num;
						if (b == null)
						{
							num = (short)1034682370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DC;
					}
					case 1:
						try
						{
							num = (short)88473604;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator;
								global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
								switch (num2)
								{
								case 0:
									goto IL_369;
								case 1:
									if (flag)
									{
										num = (short)190775298;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_329;
								case 2:
									goto IL_2F3;
								case 3:
									try
									{
										num = (short)975437824;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_1FA;
												}
												continue;
											case 1:
												num = (short)266665987;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												goto IL_27F;
											case 4:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)1728643073;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange a_ = enumerator.Current;
												this.a(compositeItem.DataArea, acpFeatureNode, a_);
												num = (short)983957506;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_22D:
											num = (short)610992132;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1FA:
											goto IL_22D;
										}
										IL_27F:
										goto IL_15D;
									}
									finally
									{
										num = (short)775028736;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_2B7;
												}
												continue;
											case 1:
												goto IL_2F0;
											case 2:
												enumerator.Dispose();
												num = (short)365101057;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_2B7:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1782382594;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2F0:;
									}
									goto IL_2F3;
									IL_15D:
									num4++;
									num = (short)1907425286;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_113;
									}
									continue;
								case 5:
									goto IL_329;
								case 7:
									if (!enumerator2.MoveNext())
									{
										num = (short)773062664;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									compositeItem = enumerator2.Current;
									acpFeatureNode = feature[num4];
									num = (short)344981505;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)298713088;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_17E:
								num = (short)1389232135;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_113:
								goto IL_17E;
								IL_2F3:
								this.a.Add(compositeItem.Name.Tag, acpFeatureNode);
								num = (short)503316485;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_329:
								enumerator = recsetExchange.GetEnumerator();
								num = (short)1588396035;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_369:
							return;
						}
						finally
						{
							num = (short)1843462144;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_3A0;
									}
									continue;
								case 1:
									goto IL_3D9;
								case 2:
									enumerator2.Dispose();
									num = (short)1894514689;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3A0:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)7471106;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3D9:;
						}
						goto IL_3DC;
					case 2:
						goto IL_C4;
					}
					goto IL_61;
					IL_3DC:
					this.b(A_0);
					recsetExchange = this.c(b);
					feature = global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange.Key);
					this.a(A_0, feature);
					num4 = 0;
					flag = this.c(A_0);
					enumerator2 = A_0.GetEnumerator();
					num = (short)755695617;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C4:
				num = (short)1593139859;
				short num5 = num;
				num = (short)1130259091;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_61:
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b = this.a(A_0);
					num = (short)1100546048;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_4E;
				}
				default:
					num = (short)1523187712;
					if (num != 0)
					{
					}
					return;
				}
				return;
			}
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000191F0 File Offset: 0x000173F0
		private void a(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType A_0, global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_1, global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection A_2)
		{
			short num = (short)1519910912;
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
				global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange2;
				global::AcpCommonLib.IAcpFeatureNode a_;
				global::AcpCommonLib.IAcpRecordset acpRecordset;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (listLayout.HeaderDataAreaLayout.FieldLayouts.Count > 0)
						{
							num = (short)73269259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30F;
					case 1:
						goto IL_30A;
					case 2:
						if (recsetExchange == null)
						{
							num = (short)1926103050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30F;
					case 3:
						num = (short)1354891264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (listLayout.HeaderDataAreaLayout != null)
						{
							num = (short)1426063363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30F;
					case 5:
						if (recsetExchange2 == null)
						{
							num = (short)1154809871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C6;
					case 6:
						if (recsetExchange != null)
						{
							num = (short)1390673928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_ = null;
						num = (short)1922301961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_2BB;
					case 8:
						a_ = this.a(recsetExchange, 0)[0];
						num = (short)177078286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_27C;
					case 10:
					{
						num = (short)747962368;
						short num3 = num;
						num = (short)1655963652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_145;
					case 12:
						if (acpRecordset is global::Motorola.Acp.PackUnpack.Ish.DataExchange.SparseLOVFieldAdapter)
						{
							num = (short)8585217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)936116225;
						if (num != 0)
						{
						}
						num = (short)1546190854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (listLayout.ListCapacity > 0)
						{
							num = (short)1362755591;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C6;
					case 14:
						goto IL_173;
					case 15:
						num = (short)2080768013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6F;
					IL_2C6:
					acpRecordset = this.a(recsetExchange2, 0);
					num = (short)1423048716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30F:
					num = (short)2062745605;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E7:
				this.a(A_2, listLayout, (global::Motorola.Acp.PackUnpack.Ish.DataExchange.SparseLOVFieldAdapter)acpRecordset, recsetExchange2);
				return;
				IL_145:
				throw new global::System.InvalidOperationException();
				IL_173:
				num = (short)279531174;
				short num4 = num;
				num = (short)188763814;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E7;
				default:
					num = (short)1079640064;
					if (num != 0)
					{
					}
					break;
				}
				IL_27C:
				goto IL_349;
				IL_2BB:
				throw new global::System.InvalidOperationException();
				IL_30A:
				goto IL_E7;
				IL_349:
				this.a(A_2, listLayout, a_, recsetExchange, acpRecordset, recsetExchange2);
				return;
				IL_6F:
				listLayout = this.a(A_0);
				recsetExchange = this.b(A_1);
				recsetExchange2 = this.a(A_1);
				num = (short)1822162946;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00019554 File Offset: 0x00017754
		private void a(global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_1, global::Motorola.Acp.PackUnpack.Ish.DataExchange.SparseLOVFieldAdapter A_2, global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_3)
		{
			short num = (short)267190272;
			switch (num)
			{
			default:
			{
				num = (short)1244266496;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num5;
					global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout a_2;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					case 1:
					{
						global::Motorola.Acp.PackUnpack.Ish.IListNode listNode;
						if (listNode.Entries.UnpackedData.Count / listNode.Count <= A_1.ListEntryLayout.FieldLayouts.Count)
						{
							int num3 = 0;
							num = (short)2140471309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2052424988;
						short num4 = num;
						num = (short)379094300;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B8;
						default:
							num = (short)92012544;
							if (num != 0)
							{
							}
							num = (short)380239875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
					{
						object obj;
						if (obj != null)
						{
							num = (short)154599428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B8;
					}
					case 3:
						goto IL_332;
					case 4:
					{
						object obj;
						A_2.SparseLOVField.AddValue(global::System.Convert.ToInt32(obj));
						int num3;
						num3++;
						num = (short)223019019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						if (num5 >= A_0.Count)
						{
							num = (short)1621688330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.IListNode listNode = A_0[num5];
						num = (short)450363393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)132513793;
						if (num != 0)
						{
						}
						goto IL_23D;
					case 7:
						goto IL_23D;
					case 8:
						goto IL_A7;
					case 9:
					{
						global::Motorola.Acp.PackUnpack.Ish.IListNode listNode;
						int num3;
						if (num3 >= listNode.Count)
						{
							num = (short)187629580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.Fields.Field a_ = this.a(listNode.Entries, num3, A_1.ListEntryLayout.FieldLayouts.Count, a_2);
						object obj = this.b(a_);
						num = (short)183959554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						return;
					case 11:
						goto IL_AC;
					case 12:
						goto IL_1B8;
					case 13:
						goto IL_AC;
					}
					IL_7B:
					if (A_1.ListEntryLayout.FieldLayouts.Count > 1)
					{
						num = (short)1240203272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					a_2 = A_1.ListEntryLayout.FieldLayouts[0];
					A_2.SparseLOVField.Items.Clear();
					num5 = 0;
					num = (short)234618886;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AC:
					num = (short)1517617161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B8:
					num = (short)883359744;
					short num6 = num;
					num5++;
					num = (short)126353415;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23D:
					num = (short)1583349765;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A7:
				throw new global::System.InvalidOperationException();
				IL_332:
				throw new global::System.IO.InvalidDataException();
			}
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000198BC File Offset: 0x00017ABC
		private void a(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType A_0, global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_1, global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> A_2)
		{
			short num = (short)2113929216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7A;
				}
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange;
				global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange2;
				for (;;)
				{
					IL_27:
					global::AcpCommonLib.IAcpRecordset feature;
					int id;
					bool flag;
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> enumerator;
					int num4;
					switch (num2)
					{
					case 0:
					{
						if (recsetExchange != null)
						{
							num = (short)972488713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset acpRecordset = null;
						num = (short)574816259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_180;
					case 2:
						num = (short)586809356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_21E;
					case 4:
						if (listLayout.ListCapacity > 0)
						{
							num = (short)331874319;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25E;
					case 5:
						if (recsetExchange == null)
						{
							num = (short)271253506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29B;
					case 6:
					{
						num = (short)1956184065;
						if (num != 0)
						{
						}
						feature = global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange2.Parent.Parent.Key);
						id = recsetExchange2.Parent.Key;
						num = (short)1238958080;
						short num3 = num;
						num = (short)626130957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_219;
					case 8:
						if (recsetExchange2.Parent != null)
						{
							num = (short)1285423110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_714;
					case 9:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange.Key);
						num = (short)84344850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)1411186705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (recsetExchange2 == null)
						{
							num = (short)91619344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25E;
					case 12:
						if (listLayout.HeaderDataAreaLayout != null)
						{
							num = (short)2034696202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29B;
					case 13:
						goto IL_180;
					case 14:
						try
						{
							num = (short)1191510017;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.IAcpFeatureNode a_;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset2;
									if (acpRecordset2.Count > listLayout.ListCapacity)
									{
										num = (short)1784872978;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)848887823;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_354;
									}
									continue;
								case 2:
								{
									if (recsetExchange2.Parent != null)
									{
										num = (short)908525585;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpRecordset acpRecordset;
									global::AcpCommonLib.IAcpRecordset acpRecordset2 = acpRecordset;
									num = (short)1206648839;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)85917704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset2;
									global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection;
									this.b(listItemCollection, listLayout, a_, recsetExchange, acpRecordset2, recsetExchange2);
									num = (short)1058275333;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_372;
								case 6:
									if (flag)
									{
										num = (short)1993539603;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_484;
								case 7:
									goto IL_602;
								case 8:
									acpFeatureNode = null;
									goto IL_3C1;
								case 9:
									goto IL_372;
								case 10:
									acpFeatureNode = acpFeatureNode2;
									goto IL_3C1;
								case 11:
									goto IL_484;
								case 12:
									if (recsetExchange == null)
									{
										num = (short)618070019;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)250150922;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									goto IL_6A2;
								case 14:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1756692501;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection = enumerator.Current;
									acpFeatureNode2 = feature[num4];
									num = (short)905314310;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
								{
									if (this.b(recsetExchange2))
									{
										num = (short)749404164;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpRecordset acpRecordset2;
									global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection;
									this.a(listItemCollection, listLayout, a_, recsetExchange, acpRecordset2, recsetExchange2);
									goto IL_510;
								}
								case 17:
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset2 = acpFeatureSection.EmbeddedRecset;
									num = (short)1080135254;
									short num5 = num;
									num = (short)357404246;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_510;
									default:
										num = (short)1148125184;
										if (num != 0)
										{
										}
										num = (short)1979908116;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 18:
									goto IL_644;
								case 19:
								{
									global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection;
									this.a.Add(((global::Motorola.Acp.PackUnpack.Ish.IshItem)listItemCollection[0]).Name.Tag, acpFeatureNode2);
									num = (short)496107531;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 20:
									goto IL_602;
								case 21:
									num = (short)1471414285;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_354;
								IL_372:
								num4++;
								num = (short)1606352912;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3C1:
								a_ = acpFeatureNode;
								acpFeatureSection = acpFeatureNode2[id];
								num = (short)1912602626;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_484:
								num = (short)1869217804;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_510:
								num = (short)447938569;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_602:
								num = (short)303693824;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_649:
								num = (short)2109865998;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_354:
								goto IL_649;
							}
							IL_644:
							throw new global::System.InvalidOperationException();
							IL_6A2:
							return;
						}
						finally
						{
							num = (short)1272184833;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)643629058;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_6D9;
									}
									continue;
								case 2:
									goto IL_711;
								}
								IL_6D9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1638662144;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_711:;
						}
						goto IL_714;
					case 15:
						goto IL_783;
					case 16:
						num = (short)182583300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (listLayout.HeaderDataAreaLayout.FieldLayouts.Count > 0)
						{
							num = (short)67829767;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29B;
					case 18:
						goto IL_21E;
					}
					goto IL_7A;
					IL_180:
					this.a(A_2.Count, feature);
					A_0.Partition.IdTracker.c(A_0);
					flag = this.a(A_2);
					num4 = 0;
					enumerator = A_2.GetEnumerator();
					num = (short)1487339534;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21E:
					num = (short)1208942600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25E:
					num = (short)488833024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29B:
					num = (short)408092683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_714:
					feature = global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange2.Key);
					id = recsetExchange2.Key;
					num = (short)1654980609;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_219:
				throw new global::System.InvalidOperationException();
				IL_783:
				throw new global::System.InvalidOperationException();
				IL_7A:
				listLayout = this.a(A_0);
				recsetExchange = this.b(A_1);
				recsetExchange2 = this.a(A_1);
				num = (short)1486290949;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0001A0DC File Offset: 0x000182DC
		private void a(global::Motorola.Acp.PackUnpack.Ish.DataArea A_0, global::AcpCommonLib.IAcpFeatureNode A_1, global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange A_2)
		{
			short num = (short)70647809;
			if (num != 0)
			{
			}
			num = (short)1248264192;
			switch (num)
			{
			default:
			{
				num = (short)1550974976;
				short num2 = num;
				global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = A_1[A_2.Key];
				global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator = A_2.GetEnumerator();
				try
				{
					num = (short)776863746;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 1:
						{
							num = (short)1330012361;
							short num4 = num;
							num = (short)980771017;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_99;
							default:
							{
								num = (short)929759232;
								if (num != 0)
								{
								}
								global::AcpCommonLib.IAcpField a_;
								global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
								this.a(a_, field);
								num = (short)1833566208;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 2:
							goto IL_99;
						case 3:
							num = (short)321323014;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1348403203;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange = enumerator.Current;
							global::AcpCommonLib.IAcpField a_ = acpFeatureSection[fieldExchange.PropertyName];
							global::Motorola.Acp.PackUnpack.Ish.Fields.Field field = this.a(A_0, fieldExchange.Layout);
							num = (short)1827078149;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
							if (field != null)
							{
								num = (short)1720713217;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_1E3;
						}
						goto IL_C6;
						IL_99:
						switch (0)
						{
						case 0:
							IL_C6:
							goto IL_169;
						}
						continue;
						IL_169:
						num = (short)230686724;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1E3:;
				}
				finally
				{
					num = (short)1628438529;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1806041090;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_218;
							}
							continue;
						case 2:
							goto IL_24F;
						}
						IL_218:
						if (enumerator == null)
						{
							break;
						}
						num = (short)971440128;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_24F:;
				}
				return;
			}
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0001A358 File Offset: 0x00018558
		private void a(global::Motorola.Acp.PackUnpack.Ish.DataArea A_0, int A_1, int A_2, global::AcpCommonLib.IAcpFeatureNode A_3, global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange A_4)
		{
			short num = (short)1194262528;
			switch (num)
			{
			default:
			{
				num = (short)175505408;
				short num2 = num;
				global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = A_3[A_4.Key];
				global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator = A_4.GetEnumerator();
				try
				{
					num = (short)627769346;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 1:
						{
							num = (short)1994083623;
							short num4 = num;
							num = (short)706825511;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_78;
							default:
							{
								num = (short)1953366016;
								if (num != 0)
								{
								}
								global::AcpCommonLib.IAcpField a_;
								global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
								this.a(a_, field);
								num = (short)1616642048;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 2:
							goto IL_78;
						case 3:
							num = (short)1998585862;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)15859715;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange = enumerator.Current;
							global::AcpCommonLib.IAcpField a_ = acpFeatureSection[fieldExchange.PropertyName];
							global::Motorola.Acp.PackUnpack.Ish.Fields.Field field = this.a(A_0, A_1, A_2, fieldExchange.Layout);
							num = (short)865402885;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
							if (field != null)
							{
								num = (short)2024734721;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_1C8;
						}
						goto IL_A5;
						IL_78:
						switch (0)
						{
						case 0:
							IL_A5:
							goto IL_150;
						}
						continue;
						IL_150:
						num = (short)669188100;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1C8:;
				}
				finally
				{
					num = (short)1453522945;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)2047279106;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1FC;
							}
							continue;
						case 2:
							goto IL_231;
						}
						IL_1FC:
						if (enumerator == null)
						{
							break;
						}
						num = (short)971571200;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_231:;
				}
				num = (short)1448280065;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0001A5DC File Offset: 0x000187DC
		private void b(global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_1, global::AcpCommonLib.IAcpFeatureNode A_2, global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_3, global::AcpCommonLib.IAcpRecordset A_4, global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_5)
		{
			short num = (short)1477115904;
			switch (num)
			{
			default:
			{
				num = (short)1119354887;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)96112905;
					short num3 = num;
					num = (short)684364041;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)2110717952;
						if (num != 0)
						{
						}
						int num4;
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1783103490;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1634467843;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange a_ = enumerator.Current;
										this.a(((global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem)A_0[0]).HeaderDataArea, A_2, a_);
										num = (short)857276420;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										goto IL_257;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_1C8;
										}
										continue;
									case 3:
										num = (short)1256718337;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1CA:
									num = (short)993198080;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1C8:
									goto IL_1CA;
								}
								IL_257:
								goto IL_3EB;
							}
							finally
							{
								num = (short)1170014208;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_28E;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)1055457282;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_2C6;
									}
									IL_28E:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1217265665;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2C6:;
							}
							goto IL_2C9;
						case 1:
							goto IL_384;
						case 2:
						{
							if (A_1.ListEntryLayout.FieldLayouts.Count > 1)
							{
								num = (short)124059652;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							A_1.ListEntryLayout.FieldLayouts[0];
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange = this.a(A_5);
							global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator2 = sectionExchange.GetEnumerator();
							enumerator2.MoveNext();
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange = enumerator2.Current;
							global::AcpBusinessLayer.AcpVoiceFileField acpVoiceFileField = this.a(A_2, sectionExchange.Key, fieldExchange.PropertyName) as global::AcpBusinessLayer.AcpVoiceFileField;
							num4 = 0;
							num = (short)315293697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::Motorola.Acp.PackUnpack.Ish.IListNode listNode;
							if (listNode.Entries != null)
							{
								num = (short)805437450;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C9;
						}
						case 4:
							goto IL_431;
						case 5:
							goto IL_384;
						case 6:
						{
							num = (short)1060044801;
							if (num != 0)
							{
							}
							if (num4 >= A_0.Count)
							{
								num = (short)1572732939;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.IListNode listNode = A_0[num4];
							num = (short)1468399619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							switch (0)
							{
							case 0:
								goto IL_C1;
							}
							continue;
						case 8:
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator = A_3.GetEnumerator();
							num = (short)195559424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_2C9;
						case 10:
						{
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange;
							global::Motorola.Acp.PackUnpack.Ish.IListNode listNode;
							global::Motorola.Acp.PackUnpack.Ish.Fields.ByteArrayField byteArrayField = this.a(listNode.Entries, fieldExchange.Layout) as global::Motorola.Acp.PackUnpack.Ish.Fields.ByteArrayField;
							global::AcpBusinessLayer.AcpVoiceFileField acpVoiceFileField;
							acpVoiceFileField.VoiceData = byteArrayField.Value;
							num = (short)1548812297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_3E9;
						}
						IL_C1:
						if (A_2 != null)
						{
							num = (short)118423560;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						goto IL_3EB;
						IL_2C9:
						num4++;
						num = (short)1645608960;
						short num5 = num;
						num = (short)2005729285;
						num2 = (int)((global::System.IntPtr)num);
						break;
						IL_384:
						num = (short)1009254406;
						num2 = (int)((global::System.IntPtr)num);
						break;
						IL_3EB:
						num = (short)447217666;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_3E9:
				return;
				IL_431:
				throw new global::System.InvalidOperationException();
			}
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0001AA34 File Offset: 0x00018C34
		private int a(global::Motorola.Acp.PackUnpack.Ish.Collections.FieldLayoutCollection A_0, int A_1)
		{
			short num = (short)990707713;
			if (num != 0)
			{
			}
			num = (short)1209860096;
			short num2 = num;
			num = (short)559261822;
			short num3 = num;
			num = (short)584296574;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)89128960;
				if (num != 0)
				{
				}
				num4 = 0;
				global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)1234305028;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
							num = (short)1894514689;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_17B;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1001521158;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fieldLayout = enumerator.Current;
							num = (short)592773125;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_1B5;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_E8;
							}
							continue;
						case 5:
						{
							global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fieldLayout;
							if (fieldLayout.Offset + fieldLayout.Size > A_1)
							{
								num = (short)1614807040;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4++;
							num = (short)2081488903;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)237109251;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_12D:
						num = (short)1715142658;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_E8:
						goto IL_12D;
					}
					IL_17B:
					IL_1B5:;
				}
				finally
				{
					num = (short)284950528;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1E7;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)304021506;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_21B;
						}
						IL_1E7:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1841037313;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_21B:;
				}
				break;
			}
			}
			return num4;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0001AC7C File Offset: 0x00018E7C
		private void a(global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_1, global::AcpCommonLib.IAcpFeatureNode A_2, global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_3, global::AcpCommonLib.IAcpRecordset A_4, global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_5)
		{
			short num = (short)1193017344;
			switch (num)
			{
			default:
			{
				num = (short)38273029;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					int num4;
					int num5;
					int num7;
					int num8;
					switch (num2)
					{
					case 0:
						goto IL_2FE;
					case 1:
						if (num3 != 0)
						{
							num = (short)680394776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45C;
					case 2:
						if (!A_1.AllowEmptyList)
						{
							num = (short)307625990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C5;
					case 3:
						goto IL_4BF;
					case 4:
					{
						if (num4 >= A_0.Count)
						{
							num = (short)1621295104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.IListNode listNode = A_0[num4];
						num = (short)1836580886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_AE;
						}
						continue;
					case 6:
						goto IL_279;
					case 7:
					{
						global::Motorola.Acp.PackUnpack.Ish.IListNode listNode;
						if (listNode.Entries.UnpackedData.Count / listNode.Count > A_1.ListEntryLayout.FieldLayouts.Count)
						{
							num = (short)808845315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = 0;
						num = (short)1326252049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_2C0;
					case 9:
						try
						{
							num = (short)1790902274;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator;
									if (!enumerator.MoveNext())
									{
										goto IL_56A;
									}
									global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange a_ = enumerator.Current;
									this.a(((global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem)A_0[0]).HeaderDataArea, A_2, a_);
									num = (short)1286471684;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_5DB;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4FE;
									}
									continue;
								case 3:
									num = (short)155123713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_54C;
								}
								goto IL_4FE;
								IL_54C:
								num = (short)1287127040;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4FE:
								num = (short)415944742;
								short num6 = num;
								num = (short)326094886;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_56A:
									num = (short)1291190275;
									num2 = (int)((global::System.IntPtr)num);
									break;
								default:
									num = (short)1624309760;
									if (num != 0)
									{
									}
									goto IL_54C;
								}
							}
							IL_5DB:
							goto IL_39C;
						}
						finally
						{
							num = (short)2082406400;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_613;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)268500994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_64C;
								}
								IL_613:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1586888705;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_64C:;
						}
						goto Block_12;
					case 10:
						goto IL_64F;
					case 11:
						num = (short)1007091714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::Motorola.Acp.PackUnpack.Ish.IListNode listNode;
						if (num5 >= listNode.Count)
						{
							num = (short)1446707219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode a_2 = A_4[num7];
						int a_3 = num5 * num8;
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator = A_5.GetEnumerator();
						num = (short)1283260426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (num3 > A_1.ListEntryLayout.Size)
						{
							num = (short)1537605652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num8 = this.a(A_1.ListEntryLayout.FieldLayouts, num3);
						num = (short)218955790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (num8 == 0)
						{
							num = (short)412680210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_462;
					case 15:
						goto IL_2C0;
					case 16:
					{
						global::Motorola.Acp.PackUnpack.Ish.IListNode listNode;
						num3 = ((global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem)listNode).ListEntrySize;
						num = (short)1371799553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_27E;
					case 18:
						goto IL_236;
					case 19:
						goto IL_1C5;
					case 20:
						goto IL_45A;
					case 21:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator = A_3.GetEnumerator();
						num = (short)99483648;
						short num9 = num;
						num = (short)780468233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						global::Motorola.Acp.PackUnpack.Ish.IListNode listNode;
						if (listNode.Count == 0)
						{
							num = (short)1267925003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)744685593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						num = (short)1441136641;
						if (num != 0)
						{
						}
						goto IL_27E;
					case 24:
						num = (short)1185480717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::Motorola.Acp.PackUnpack.Ish.IListNode listNode;
						if (listNode is global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem)
						{
							num = (short)796983312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_462;
					}
					}
					IL_AE:
					if (A_2 != null)
					{
						num = (short)487325717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_39C;
					Block_12:
					try
					{
						IL_64F:
						num = (short)1341456386;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_70D;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_689;
								}
								continue;
							case 3:
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1543962628;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange a_4 = enumerator.Current;
								global::Motorola.Acp.PackUnpack.Ish.IListNode listNode;
								global::AcpCommonLib.IAcpFeatureNode a_2;
								int a_3;
								this.a(listNode.Entries, a_3, num8, a_2, a_4);
								num = (short)900333568;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)264503297;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_6BD:
							num = (short)541392899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_689:
							goto IL_6BD;
						}
						IL_70D:
						goto IL_157;
					}
					finally
					{
						num = (short)2114519040;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_744;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1847132162;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_77C;
							}
							IL_744:
							if (enumerator == null)
							{
								break;
							}
							num = (short)191954945;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_77C:;
					}
					return;
					IL_157:
					num7++;
					num5++;
					num = (short)92995607;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C5:
					num4++;
					num = (short)1806106632;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27E:
					num = (short)2143879180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C0:
					num = (short)1591410692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39C:
					this.a(A_0, A_4);
					num7 = 0;
					num8 = 0;
					num3 = 0;
					num4 = 0;
					num = (short)1063976975;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_462:
					num = (short)594804743;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_236:
				throw new global::System.IO.InvalidDataException();
				IL_279:
				throw new global::System.IO.InvalidDataException();
				IL_2FE:
				return;
				IL_45A:
				IL_45C:
				throw new global::System.IO.InvalidDataException();
				IL_4BF:
				throw new global::System.IO.InvalidDataException();
			}
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0001B43C File Offset: 0x0001963C
		private global::Motorola.Acp.PackUnpack.Ish.IshType a(global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> A_0)
		{
			short num = (short)1100668848;
			short num2 = num;
			num = (short)1503911856;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1908604928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1062141953;
			if (num != 0)
			{
			}
			num = (short)2054029312;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> enumerator = A_0.GetEnumerator();
			enumerator.MoveNext();
			return this.a(enumerator.Current);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0001B500 File Offset: 0x00019700
		private global::Motorola.Acp.PackUnpack.Ish.IshType a(global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection A_0)
		{
			short num = (short)1496193366;
			short num2 = num;
			num = (short)771037526;
			switch (num2 == num)
			{
			default:
			{
				num = (short)629211136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1156120577;
			if (num != 0)
			{
			}
			num = (short)713293824;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IListNode> enumerator = A_0.GetEnumerator();
			enumerator.MoveNext();
			return ((global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem)enumerator.Current).Type;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0001B5C8 File Offset: 0x000197C8
		private void a(global::AcpCommonLib.IAcpField A_0, global::Motorola.Acp.PackUnpack.Ish.Fields.Field A_1)
		{
			int a_ = 6;
			short num = (short)840957957;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpCommonLib.IAcpField acpField;
				switch (num2)
				{
				case 0:
				{
					num = (short)1936916480;
					short num3 = num;
					if (A_0.GetType().GUID == typeof(global::AcpBusinessLayer.AcpPointerField<>).GUID)
					{
						num = (short)927137793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23C;
				}
				case 1:
					num = (short)2100297729;
					if (num != 0)
					{
					}
					goto IL_1DE;
				case 2:
					goto IL_E6;
				case 3:
					goto IL_1C8;
				case 4:
				{
					this.a(acpField, this.b(A_1));
					num = (short)2097209992;
					short num4 = num;
					num = (short)218620552;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1DE;
					default:
						num = (short)1364000768;
						if (num != 0)
						{
						}
						num = (short)1176371202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 6:
					num = (short)1700331527;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (A_1 is global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField)
					{
						num = (short)41877507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EB;
				case 8:
					if (acpField != null)
					{
						num = (short)1240072196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_51:
				if (A_0 is global::AcpBusinessLayer.AcpRecRefField)
				{
					num = (short)392822790;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_EB:
				num = (short)601423872;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1DE:
				acpField = (global::AcpCommonLib.IAcpField)A_0.GetType().GetProperty(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("출좠춢톤슦춨쒬쪮\uddb0ힲ", a_)).GetValue(A_0, null);
				num = (short)2023358472;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E6:
			return;
			IL_1C8:
			this.a((global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField)A_1, (global::AcpBusinessLayer.AcpRecRefField)A_0);
			return;
			IL_23C:
			this.a(A_0, this.b(A_1));
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0001B820 File Offset: 0x00019A20
		private void a(global::AcpCommonLib.IAcpField A_0, object A_1)
		{
			int a_ = 12;
			short num = (short)132448256;
			switch (num)
			{
			default:
			{
				num = (short)386269187;
				int num2 = (int)((global::System.IntPtr)num);
				object value;
				global::System.Reflection.PropertyInfo property;
				for (;;)
				{
					global::System.TypeCode typeCode;
					switch (num2)
					{
					case 0:
						((global::AcpBusinessLayer.AcpRecRefField)A_0).ReferencedIndex = global::System.Convert.ToInt32(A_1);
						num = (short)116064265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_301;
					case 2:
					{
						num = (short)1807417345;
						if (num != 0)
						{
						}
						global::System.TypeCode typeCode2;
						if (typeCode != typeCode2)
						{
							num = (short)1602420742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						value = A_1;
						num = (short)643760136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					case 4:
						if (A_0 is global::AcpBusinessLayer.AcpField<string>)
						{
							num = (short)1520500737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1864564741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (A_0 is global::AcpBusinessLayer.AcpIPAddressField)
						{
							num = (short)1306066956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Type type = A_0.GetType();
						num = (short)1300103182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_1EA;
					case 7:
					{
						num = (short)2045059345;
						short num3 = num;
						num = (short)1332879633;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1EA;
						default:
							goto IL_17C;
						}
						break;
					}
					case 8:
						goto IL_22E;
					case 9:
						return;
					case 10:
						if (A_0 is global::AcpBusinessLayer.AcpField<int>)
						{
							num = (short)845348864;
							short num4 = num;
							num = (short)1736769543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1524039684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_20C;
					case 12:
						((global::AcpBusinessLayer.AcpIPAddressField)A_0).AddressBytes = (byte[])A_1;
						num = (short)1193803789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						return;
					case 14:
					{
						global::System.Type type2 = A_1.GetType();
						global::System.Type type;
						if (type.IsGenericType)
						{
							global::System.Type[] genericArguments = type.GetGenericArguments();
							property = type.GetProperty(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒤쮦\udca8캪", a_), genericArguments[0]);
						}
						else
						{
							property = type.GetProperty(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒤쮦\udca8캪", a_));
						}
						if (property == null)
						{
							goto Block_4;
						}
						typeCode = global::System.Type.GetTypeCode(property.PropertyType);
						global::System.TypeCode typeCode2 = global::System.Type.GetTypeCode(type2);
						num = (short)315293698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_88:
					if (A_0 is global::AcpBusinessLayer.AcpRecRefField)
					{
						num = (short)1404829696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1839202314;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EA:
					value = global::System.Convert.ChangeType(A_1, typeCode);
					num = (short)100663307;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_17C:
				num = (short)208207872;
				if (num != 0)
				{
				}
				((global::AcpBusinessLayer.AcpField<int>)A_0).Value = global::System.Convert.ToInt32(A_1);
				return;
				IL_20C:
				IL_22E:
				goto IL_3A8;
				Block_4:
				throw new global::System.Reflection.TargetException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒤쮦\udca8캪", a_));
				IL_301:
				((global::AcpBusinessLayer.AcpField<string>)A_0).Value = global::System.Convert.ToString(A_1);
				return;
				IL_3A8:
				property.SetValue(A_0, value, null);
				return;
			}
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0001BBE0 File Offset: 0x00019DE0
		private void a(global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> A_0, global::AcpCommonLib.IAcpRecordset A_1)
		{
			short num = (short)273164688;
			short num2 = num;
			num = (short)367274384;
			switch (num2 == num)
			{
			}
			num = (short)1618739200;
			if (num != 0)
			{
			}
			num = (short)288882689;
			if (num != 0)
			{
			}
			num = (short)552796160;
			short num3 = num;
			this.a(A_0.Count, A_1);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0001BC98 File Offset: 0x00019E98
		private void a(int A_0, global::AcpCommonLib.IAcpRecordset A_1)
		{
			short num3;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				int num2;
				global::AcpBusinessLayer.Recordset recordset;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_76;
					case 1:
						goto IL_46;
					case 2:
					{
						if (num2-- <= 0)
						{
							num3 = (short)2142240768;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)949288961;
						if (num3 != 0)
						{
						}
						num3 = (short)217055232;
						short num4 = num3;
						recordset.AddRecord(recordset.CreateDefaultRecordHelper());
						num3 = (short)560922625;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					case 3:
						goto IL_46;
					}
					goto IL_20;
					IL_46:
					num3 = (short)565968898;
					num = (int)((global::System.IntPtr)num3);
				}
				IL_76:
				num3 = (short)734834213;
				short num5 = num3;
				num3 = (short)893890085;
				switch ((num5 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_AA;
				}
				IL_20:
				num2 = A_0 - A_1.Count;
				recordset = (global::AcpBusinessLayer.Recordset)A_1;
				num3 = (short)367198211;
				num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			IL_AA:
			num3 = (short)1948254208;
			if (num3 != 0)
			{
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0001BDE0 File Offset: 0x00019FE0
		private void a(global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection A_0, global::AcpCommonLib.IAcpRecordset A_1)
		{
			short num = (short)1305388042;
			short num2 = num;
			num = (short)520725514;
			switch (num2 == num)
			{
			}
			num = (short)1196752896;
			if (num != 0)
			{
			}
			num = (short)831193089;
			if (num != 0)
			{
			}
			num = (short)416546816;
			short num3 = num;
			this.a(this.b(A_0), A_1);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0001BE98 File Offset: 0x0001A098
		private global::Motorola.Acp.PackUnpack.Ish.Fields.Field a(global::Motorola.Acp.PackUnpack.Ish.DataArea A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_1)
		{
			short num = (short)1707212801;
			if (num != 0)
			{
			}
			if (A_0 != null)
			{
				num = (short)989483804;
				short num2 = num;
				num = (short)737760028;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AF;
				case 1:
					break;
				default:
				{
					num = (short)2040463360;
					short num3 = num;
					break;
				}
				}
				num = (short)1295056896;
				if (num != 0)
				{
				}
				return A_0.UnpackedData.a(A_1);
			}
			IL_AF:
			return null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0001BF58 File Offset: 0x0001A158
		private global::Motorola.Acp.PackUnpack.Ish.Fields.Field a(global::Motorola.Acp.PackUnpack.Ish.DataArea A_0, int A_1, int A_2, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_3)
		{
			short num = (short)668374613;
			short num2 = num;
			num = (short)1033868885;
			switch (num2 == num)
			{
			}
			num = (short)1395720193;
			if (num != 0)
			{
			}
			num = (short)1816657920;
			if (num != 0)
			{
			}
			num = (short)2103246848;
			short num3 = num;
			return A_0.UnpackedData.a(A_3, A_1, A_2);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0001C010 File Offset: 0x0001A210
		private void a(global::Motorola.Acp.PackUnpack.Ish.Fields.IndexReferenceField A_0, global::AcpBusinessLayer.AcpRecRefField A_1, global::Motorola.Acp.PackUnpack.Ish.IshItem A_2)
		{
			short num = (short)564889567;
			short num2 = num;
			num = (short)1041795039;
			switch (num2 == num)
			{
			}
			num = (short)1045823489;
			if (num != 0)
			{
			}
			num = (short)1232601088;
			if (num != 0)
			{
			}
			num = (short)1609433088;
			short num3 = num;
			global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.b item = new global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.b(A_2, A_0, A_1);
			this.d.Add(item);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0001C0CC File Offset: 0x0001A2CC
		private void a(global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField A_0, global::AcpBusinessLayer.AcpRecRefField A_1)
		{
			short num = (short)1743781892;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_17F;
				case 1:
					goto IL_91;
				case 2:
				{
					if (this.c.TryGetValue(A_0.Value, out list))
					{
						goto IL_18C;
					}
					num = (short)1496876469;
					short num3 = num;
					num = (short)475825589;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17F;
					default:
					{
						num = (short)1574305793;
						if (num != 0)
						{
						}
						num = (short)1939800064;
						short num4 = num;
						num = (short)1205207040;
						if (num != 0)
						{
						}
						num = (short)2046230528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					goto IL_5B;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (A_0.Value == 0)
				{
					num = (short)1997668355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				list = null;
				num = (short)1601044482;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_17F:
				list = new global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField>();
				this.c.Add(A_0.Value, list);
				num = (short)116654081;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5B:
			A_1.ReferencedIndex = -1;
			return;
			IL_91:
			IL_18C:
			list.Add(A_1);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001C26C File Offset: 0x0001A46C
		private void c()
		{
			short num = (short)1435624258;
			short num2 = num;
			num = (short)2037048130;
			switch (num2 == num)
			{
			}
			num = (short)17629185;
			if (num != 0)
			{
			}
			num = (short)1198522368;
			if (num != 0)
			{
			}
			num = (short)124125184;
			short num3 = num;
			this.b();
			this.a();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0001C324 File Offset: 0x0001A524
		private void b()
		{
			short num = (short)384237568;
			switch (num)
			{
			default:
			{
				num = (short)762904577;
				if (num != 0)
				{
				}
				num = (short)212729856;
				short num2 = num;
				using (global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField>>.Enumerator enumerator = this.c.GetEnumerator())
				{
					num = (short)1627783170;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						int num4;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						switch (num3)
						{
						case 0:
						{
							global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField> value;
							value[num4].ReferencedIndex = 65535;
							num = (short)451739651;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)1387659273;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_DA;
							}
							continue;
						case 3:
							goto IL_186;
						case 4:
							goto IL_2D7;
						case 5:
						{
							global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField> value;
							if (num4 >= value.Count)
							{
								num = (short)1594294285;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)377021414;
							short num5 = num;
							num = (short)873784294;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2D7;
							default:
								num = (short)1457389568;
								if (num != 0)
								{
								}
								num = (short)664272900;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
						{
							int key;
							if (!this.a.TryGetValue(key, out acpFeatureNode))
							{
								num = (short)1839464459;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4 = 0;
							num = (short)1962344456;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_186;
						case 8:
							goto IL_E5;
						case 9:
							goto IL_321;
						case 10:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)760086529;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<int, global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField>> keyValuePair = enumerator.Current;
							int key = keyValuePair.Key;
							global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField> value = keyValuePair.Value;
							num = (short)390332422;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_181;
						case 12:
							goto IL_E5;
						}
						goto IL_DA;
						IL_E5:
						num = (short)1052966917;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_186:
						num4++;
						num = (short)1492779020;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1A9:
						num = (short)575602698;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_DA:
						goto IL_1A9;
						IL_2D7:
						if (acpFeatureNode.Parent.RecsetId == 2302)
						{
							num = (short)1753088000;
							num3 = (int)((global::System.IntPtr)num);
						}
						else
						{
							global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField> value;
							value[num4].ReferencedName = acpFeatureNode.Parent.IndexOf(acpFeatureNode);
							num = (short)1827930119;
							num3 = (int)((global::System.IntPtr)num);
						}
					}
					IL_181:
					throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.IshItemNotFoundException();
					IL_321:;
				}
				this.c.Clear();
				return;
			}
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0001C68C File Offset: 0x0001A88C
		private void a()
		{
			short num = (short)1990393856;
			switch (num)
			{
			default:
			{
				num = (short)1812398080;
				short num2 = num;
				global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.b>.Enumerator enumerator = this.d.GetEnumerator();
				try
				{
					num = (short)1233584130;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_245;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1245380613;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.b b = enumerator.Current;
							global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout indexReferenceFieldLayout = (global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout)b.e().Layout;
							num = (short)798949385;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_A9;
							}
							continue;
						case 4:
						{
							int key;
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (!this.a.TryGetValue(key, out acpFeatureNode))
							{
								num = (short)2023620608;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.b b;
							b.f().ReferencedIndex = acpFeatureNode.Parent.IndexOf(acpFeatureNode);
							num = (short)927989763;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)280559622;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_2A6;
						case 7:
						{
							global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout indexReferenceFieldLayout;
							int key = global::Motorola.Acp.PackUnpack.Ish.IshItemName.a(indexReferenceFieldLayout.ReferencedIshType.Value, 0);
							num = (short)589430794;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_202;
						case 9:
						{
							global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout indexReferenceFieldLayout;
							if (!indexReferenceFieldLayout.ReferencedIshType.IsSingleInstance)
							{
								global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.b b;
								int key = global::Motorola.Acp.PackUnpack.Ish.IshItemName.a(indexReferenceFieldLayout.ReferencedIshType.Value, b.d().Name.Id);
								num = (short)359268360;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)34825370;
							short num4 = num;
							num = (short)1878615194;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_245;
							default:
								num = (short)1761869824;
								if (num != 0)
								{
								}
								num = (short)904200199;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 10:
							goto IL_202;
						}
						IL_1C1:
						num = (short)484311041;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A9:
						goto IL_1C1;
						IL_202:
						num = (short)870121476;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_245:
					throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.IshItemNotFoundException();
					IL_2A6:;
				}
				finally
				{
					num = (short)1507262465;
					if (num != 0)
					{
					}
					((global::System.IDisposable)enumerator).Dispose();
				}
				this.d.Clear();
				return;
			}
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0001C99C File Offset: 0x0001AB9C
		private object b(global::Motorola.Acp.PackUnpack.Ish.Fields.Field A_0)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			global::System.Type type;
			global::System.Reflection.PropertyInfo property;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_E0;
				case 1:
				{
					num2 = (short)1178738058;
					short num3 = num2;
					num2 = (short)402988426;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8B;
					default:
						goto IL_151;
					}
					break;
				}
				case 2:
				{
					global::System.Type[] genericArguments = type.GetGenericArguments();
					property = type.GetProperty(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("욦얨\udeaa좬", a_), genericArguments[0]);
					num2 = (short)955252737;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (type.IsGenericType)
					{
						num2 = (short)972881921;
						if (num2 != 0)
						{
						}
						num2 = (short)688128002;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8B;
				}
				goto IL_29;
				IL_8B:
				property = type.GetProperty(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("욦얨\udeaa좬", a_));
				num2 = (short)1416429568;
				short num4 = num2;
				num2 = (short)71499776;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E0:
			goto IL_169;
			IL_151:
			num2 = (short)148439040;
			if (num2 != 0)
			{
			}
			IL_169:
			return property.GetValue(A_0, null);
			IL_29:
			type = A_0.GetType();
			num2 = (short)2082144259;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0001CB1C File Offset: 0x0001AD1C
		public void Dispose()
		{
			short num = (short)201941670;
			short num2 = num;
			num = (short)1098212006;
			switch (num2 == num)
			{
			}
			num = (short)299302913;
			if (num != 0)
			{
			}
			num = (short)1940455424;
			if (num != 0)
			{
			}
			num = (short)2003566592;
			short num3 = num;
			this.a(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0001CBD0 File Offset: 0x0001ADD0
		private void a(bool A_0)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)1744699394;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)424288762;
					short num3 = num;
					num = (short)1177362938;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)202768384;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							this.e.Close();
							this.e = null;
							num = (short)919535617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_C2;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_7A;
							}
							continue;
						}
						IL_7A:
						if (this.e == null)
						{
							goto IL_C4;
						}
						num = (short)1856831488;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_C2:
			IL_C4:
			num = (short)2034630656;
			short num4 = num;
			num = (short)253034497;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0001CCF4 File Offset: 0x0001AEF4
		private bool d(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0)
		{
			short num = (short)1581711360;
			switch (num)
			{
			default:
			{
				num = (short)27721730;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpCommonLib.IAcpRecordset feature;
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange;
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange;
					global::AcpCommonLib.IAcpField acpField;
					switch (num2)
					{
					case 0:
						if (feature.CanBeEmpty)
						{
							num = (short)217841673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A3;
					case 1:
						return false;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					case 3:
						goto IL_1A1;
					case 4:
						num = (short)1684733952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return false;
					case 6:
						num = (short)157483011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)78182139;
						short num3 = num;
						num = (short)2133260027;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1A1;
						default:
							num = (short)1482293248;
							if (num != 0)
							{
							}
							if (feature.RecsetId == 4228)
							{
								num = (short)1557069828;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A3;
						}
						break;
					}
					case 8:
						goto IL_1C9;
					case 9:
						num = (short)993394699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						if (sectionExchange.Count != 1)
						{
							num = (short)672333825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1890254848;
						short num4 = num;
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator = sectionExchange.GetEnumerator();
						enumerator.MoveNext();
						fieldExchange = enumerator.Current;
						feature = global::AcpCommonLib.FeatureManager.GetFeature(A_0.Key);
						num = (short)16187399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (feature.Count == 0)
						{
							num = (short)707002380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A3;
					case 12:
						return false;
					case 13:
						if (acpField is global::AcpBusinessLayer.AcpSparseLOVField)
						{
							num = (short)79691782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					IL_7D:
					if (A_0.Count != 1)
					{
						num = (short)732692485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					sectionExchange = this.a(A_0);
					num = (short)298188810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A3:
					acpField = feature[0][sectionExchange.Key][fieldExchange.PropertyName];
					num = (short)1313931277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A1:
					if (!((global::AcpBusinessLayer.AcpSparseLOVField)acpField).SerializeItems)
					{
						return false;
					}
					num = (short)741081096;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_1C9:
				num = (short)1612251137;
				if (num != 0)
				{
				}
				return true;
			}
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0001D014 File Offset: 0x0001B214
		private bool a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0, out global::AcpCommonLib.IAcpRecordset A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::AcpCommonLib.IAcpField acpField;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange;
				switch (num)
				{
				case 0:
					return false;
				case 1:
					if (A_1.RecsetId == 4228)
					{
						num2 = (short)860094469;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_89;
				case 2:
					if (((global::AcpBusinessLayer.AcpSparseLOVField)acpField).SerializeItems)
					{
						num2 = (short)1228079110;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_327;
				case 3:
					if (A_0.Count != 1)
					{
						num2 = (short)259981312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					sectionExchange = this.a(A_0);
					num2 = (short)1372061707;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_254;
				case 5:
					num2 = (short)1321402380;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					A_1 = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.SparseLOVFieldAdapter((global::AcpBusinessLayer.AcpSparseLOVField)acpField);
					num2 = (short)1665531908;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)621723863;
					short num3 = num2;
					num2 = (short)166969559;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C1;
					default:
						num2 = (short)255393792;
						if (num2 != 0)
						{
						}
						if (A_1.Count == 0)
						{
							num2 = (short)1612382221;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_89;
					}
					break;
				}
				case 8:
					goto IL_1E5;
				case 9:
				{
					num2 = (short)523436032;
					short num4 = num2;
					num2 = (short)202047495;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					num2 = (short)978386946;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_1C1;
				case 12:
					if (A_1.CanBeEmpty)
					{
						num2 = (short)57737225;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_89;
				case 13:
					return false;
				case 14:
					if (acpField is global::AcpBusinessLayer.AcpSparseLOVField)
					{
						num2 = (short)1998716938;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_327;
				}
				goto IL_4C;
				IL_89:
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange;
				acpField = A_1[0][sectionExchange.Key][fieldExchange.PropertyName];
				num2 = (short)1039335438;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C1:
				if (sectionExchange.Count != 1)
				{
					num2 = (short)1894711304;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator = sectionExchange.GetEnumerator();
					enumerator.MoveNext();
					fieldExchange = enumerator.Current;
					A_1 = global::AcpCommonLib.FeatureManager.GetFeature(A_0.Key);
					num2 = (short)1120796673;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			return false;
			IL_1E5:
			num2 = (short)21364737;
			if (num2 != 0)
			{
			}
			return false;
			IL_254:
			IL_327:
			return A_1 != null;
			IL_4C:
			A_1 = null;
			num2 = (short)27918339;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0001D350 File Offset: 0x0001B550
		private global::AcpCommonLib.IAcpRecordset c(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0)
		{
			short num = (short)246480897;
			if (num != 0)
			{
			}
			num = (short)461096559;
			short num2 = num;
			num = (short)300664431;
			switch (num2 == num)
			{
			}
			num = (short)1571225600;
			if (num != 0)
			{
			}
			num = (short)928907264;
			short num3 = num;
			return this.a(A_0, 0);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0001D404 File Offset: 0x0001B604
		private global::AcpCommonLib.IAcpRecordset a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0, int A_1)
		{
			short num = (short)790036484;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpCommonLib.IAcpRecordset feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					feature = global::AcpCommonLib.FeatureManager.GetFeature(A_0.Key);
					num = (short)847249409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_F3;
				case 2:
					goto IL_136;
				case 3:
				{
					num = (short)1316880384;
					short num3 = num;
					num = (short)842530818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)1113259448;
					short num4 = num;
					num = (short)2125528504;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_136;
					default:
						num = (short)1051656192;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_86;
						}
						continue;
					}
					break;
				}
				}
				IL_86:
				num = (short)750845953;
				if (num != 0)
				{
				}
				if (A_0.Parent == null)
				{
					num = (short)1171521539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_15E;
				IL_136:
				if (this.a(A_0, out feature))
				{
					break;
				}
				num = (short)1100677120;
				num2 = (int)((global::System.IntPtr)num);
			}
			return feature;
			IL_F3:
			return feature;
			IL_15E:
			return global::AcpCommonLib.FeatureManager.GetFeature(A_0.Parent.Parent.Key)[A_1][A_0.Parent.Key].EmbeddedRecset;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.b a(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			short num = (short)241063143;
			short num2 = num;
			num = (short)346051815;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)281935872;
				if (num != 0)
				{
				}
				if (!this.f.Contains(A_0))
				{
					return null;
				}
				break;
			}
			num = (short)470286336;
			short num3 = num;
			num = (short)1834352641;
			if (num != 0)
			{
			}
			return this.f[A_0];
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0001D66C File Offset: 0x0001B86C
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.b a(global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> A_0)
		{
			short num = (short)380174336;
			short num2 = num;
			num = (short)1096155137;
			if (num != 0)
			{
			}
			num = (short)1880380624;
			short num3 = num;
			num = (short)1699894480;
			switch (num3 == num)
			{
			}
			num = (short)885391360;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> enumerator = A_0.GetEnumerator();
			enumerator.MoveNext();
			return this.a(enumerator.Current.Type);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0001D734 File Offset: 0x0001B934
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange c(global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_0)
		{
			short num = (short)1899495425;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Acp.PackUnpack.Ish.DataExchange.a a_;
			for (;;)
			{
				num = (short)1922443579;
				short num3 = num;
				num = (short)1644374331;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_17A;
				default:
					num = (short)565575680;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						a_ = A_0[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.Composite];
						num = (short)1156317189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1079443456;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_AE;
						}
						continue;
					}
					case 2:
						goto IL_11A;
					case 3:
						a_ = A_0[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListHeader];
						num = (short)1217527810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (A_0.a() is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)
						{
							num = (short)1388969987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17C;
					case 5:
						goto IL_17A;
					}
					IL_AE:
					num = (short)730267649;
					if (num != 0)
					{
					}
					if (A_0.a() is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
					{
						num = (short)1344012288;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)908460036;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_11A:
			IL_17A:
			goto IL_182;
			IL_17C:
			throw new global::System.InvalidCastException();
			IL_182:
			return this.b(a_);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0001D8CC File Offset: 0x0001BACC
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange b(global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_0)
		{
			short num = (short)152659095;
			short num2 = num;
			num = (short)1472291991;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)714932224;
				if (num != 0)
				{
				}
				if (A_0.a(global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListHeader))
				{
					return this.b(A_0[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListHeader]);
				}
				break;
			}
			num = (short)593100800;
			short num3 = num;
			num = (short)263847937;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0001D990 File Offset: 0x0001BB90
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_0)
		{
			short num = (short)236978176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)301137921;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8A;
				}
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange result;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange;
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_4F:
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						num = (short)1988689925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						result = recsetExchange;
						num = (short)786366476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return result;
					case 4:
						if (this.d(recsetExchange))
						{
							num = (short)1527447554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = this.a(recsetExchange).RecsetExchange;
						num = (short)1846345738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (feature.SingleInstance)
						{
							goto IL_24C;
						}
						result = recsetExchange;
						num = (short)1047592960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						result = recsetExchange;
						num = (short)926875651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						if (this.b(recsetExchange))
						{
							num = (short)1863057414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)88211048;
						short num3 = num;
						num = (short)278855272;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_24C;
						default:
							num = (short)2086338560;
							if (num != 0)
							{
							}
							result = this.a(recsetExchange).RecsetExchange;
							num = (short)1294860297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						if (A_0.a().IsSingleInstance)
						{
							num = (short)1021509633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)719060999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return result;
					case 10:
						return result;
					case 11:
						num = (short)622919684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						return result;
					}
					goto IL_8A;
					IL_24C:
					num = (short)1680736267;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_8A:
				num = (short)1909063680;
				short num4 = num;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.a a_ = A_0[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListEntry];
				recsetExchange = this.b(a_);
				feature = global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange.Key);
				num = (short)2065039368;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0001DC6C File Offset: 0x0001BE6C
		private bool b(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0)
		{
			short num = (short)1601830912;
			switch (num)
			{
			default:
			{
				num = (short)1599275015;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
					global::AcpBusinessLayer.FeatureNode featureNode;
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange;
						if (acpFeatureSection[fieldExchange.PropertyName] is global::AcpBusinessLayer.AcpVoiceFileField)
						{
							num = (short)1947074568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 1:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (recordset.Count == 0)
						{
							num = (short)1648689161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						featureNode = (global::AcpBusinessLayer.FeatureNode)recordset[0];
						num = (short)1017774086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_BD;
					case 3:
						goto IL_134;
					case 4:
						if (acpFeatureSection == null)
						{
							num = (short)171245578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1659437056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (sectionExchange.Count != 1)
						{
							num = (short)495779843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator = sectionExchange.GetEnumerator();
						enumerator.MoveNext();
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange = enumerator.Current;
						global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(A_0.Key);
						num = (short)362807297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_1CF;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_74;
						}
						continue;
					case 8:
						return true;
					case 9:
					{
						global::AcpBusinessLayer.Recordset recordset;
						featureNode = recordset.CreateDefaultRecordHelper();
						num = (short)1574764555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						return false;
					case 11:
						goto IL_1CF;
					}
					IL_74:
					num = (short)939130880;
					short num3 = num;
					if (A_0.Count != 1)
					{
						num = (short)995098626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					sectionExchange = this.a(A_0);
					num = (short)94633989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CF:
					num = (short)22609921;
					if (num != 0)
					{
					}
					acpFeatureSection = featureNode[sectionExchange.Key];
					num = (short)1959395332;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BD:
				return false;
				IL_134:
				num = (short)1082477594;
				short num4 = num;
				num = (short)58936346;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
					num = (short)1811546112;
					if (num != 0)
					{
					}
					return false;
				}
				return true;
			}
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0001DF48 File Offset: 0x0001C148
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange b(global::Motorola.Acp.PackUnpack.Ish.DataExchange.a A_0)
		{
			short num = (short)1711407104;
			short num2 = num;
			num = (short)682205700;
			short num3 = num;
			num = (short)340632068;
			switch (num3 == num)
			{
			}
			num = (short)878575616;
			if (num != 0)
			{
			}
			num = (short)1248919553;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange> enumerator = A_0.GetEnumerator();
			enumerator.MoveNext();
			return enumerator.Current;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0001E004 File Offset: 0x0001C204
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0)
		{
			short num = (short)953483264;
			short num2 = num;
			num = (short)1012137985;
			if (num != 0)
			{
			}
			num = (short)1556168502;
			short num3 = num;
			num = (short)1247559478;
			switch (num3 == num)
			{
			}
			num = (short)1479344128;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator = A_0.GetEnumerator();
			enumerator.MoveNext();
			return enumerator.Current;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0001E0C0 File Offset: 0x0001C2C0
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange b(global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange A_0)
		{
			short num = (short)1947729920;
			short num2 = num;
			num = (short)1257220520;
			short num3 = num;
			num = (short)2077206952;
			switch (num3 == num)
			{
			}
			num = (short)344260609;
			if (num != 0)
			{
			}
			num = (short)67502080;
			if (num != 0)
			{
			}
			return A_0.RecsetExchange;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0001E170 File Offset: 0x0001C370
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange A_0)
		{
			short num = (short)1321926656;
			short num2 = num;
			num = (short)1035966847;
			short num3 = num;
			num = (short)798267775;
			switch (num3 == num)
			{
			}
			num = (short)1293746177;
			if (num != 0)
			{
			}
			num = (short)966590464;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange a_ = this.b(A_0);
			return this.a(a_);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0001E228 File Offset: 0x0001C428
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.a A_0)
		{
			short num = (short)984875008;
			short num2 = num;
			num = (short)1604556850;
			short num3 = num;
			num = (short)1360173106;
			switch (num3 == num)
			{
			}
			num = (short)1889271809;
			if (num != 0)
			{
			}
			num = (short)1587544064;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange a_ = this.b(A_0);
			global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange a_2 = this.a(a_);
			return this.a(a_2);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0001E2E8 File Offset: 0x0001C4E8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int a_ = 5;
			short num = (short)1135411200;
			short num2 = num;
			num = (short)1175415534;
			short num3 = num;
			num = (short)91450094;
			switch (num3 == num)
			{
			}
			num = (short)131399680;
			if (num != 0)
			{
			}
			num = (short)53411841;
			if (num != 0)
			{
			}
			global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(A_0);
			if (feature == null)
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮝ쎟톡솣튥캩", a_));
			}
			return feature;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0001E3B8 File Offset: 0x0001C5B8
		private global::AcpCommonLib.IAcpRecordset a(global::AcpCommonLib.IAcpFeatureNode A_0, int A_1)
		{
			short num = (short)2042691584;
			short num2 = num;
			num = (short)550428484;
			short num3 = num;
			num = (short)1454497604;
			switch (num3 == num)
			{
			}
			num = (short)2061303809;
			if (num != 0)
			{
			}
			num = (short)437583872;
			if (num != 0)
			{
			}
			return A_0[A_1].EmbeddedRecset;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0001E46C File Offset: 0x0001C66C
		private global::AcpCommonLib.IAcpRecordset a(global::AcpCommonLib.IAcpField A_0)
		{
			short num = (short)1670184960;
			short num2 = num;
			num = (short)1791881724;
			short num3 = num;
			num = (short)1905062396;
			switch (num3 == num)
			{
			}
			num = (short)396427265;
			if (num != 0)
			{
			}
			num = (short)1928724480;
			if (num != 0)
			{
			}
			return A_0.Parent.Parent.Parent;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0001E524 File Offset: 0x0001C724
		private global::AcpCommonLib.IAcpRecordset a(global::AcpCommonLib.IAcpRecordset A_0)
		{
			short num = (short)388366336;
			short num2 = num;
			num = (short)1299361677;
			short num3 = num;
			num = (short)105492365;
			switch (num3 == num)
			{
			}
			num = (short)228196353;
			if (num != 0)
			{
			}
			num = (short)1180303360;
			if (num != 0)
			{
			}
			return A_0.ParentSection.Parent.Parent;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0001E5E0 File Offset: 0x0001C7E0
		private global::Motorola.Acp.PackUnpack.Ish.IshType a(global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_0)
		{
			short num = (short)1231224832;
			short num2 = num;
			num = (short)754585495;
			short num3 = num;
			num = (short)1400770455;
			switch (num3 == num)
			{
			}
			num = (short)633667585;
			if (num != 0)
			{
			}
			num = (short)2062090240;
			if (num != 0)
			{
			}
			return A_0.Parent.Parent.IshTypes[0];
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0001E6A0 File Offset: 0x0001C8A0
		private global::Motorola.Acp.PackUnpack.Ish.IshType a(global::Motorola.Acp.PackUnpack.Ish.Fields.Field A_0)
		{
			short num = (short)856227840;
			short num2 = num;
			num = (short)1376265667;
			short num3 = num;
			num = (short)764421571;
			switch (num3 == num)
			{
			}
			num = (short)1252982785;
			if (num != 0)
			{
			}
			num = (short)1118109696;
			if (num != 0)
			{
			}
			return A_0.Layout.Parent.Parent.IshTypes[0];
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0001E768 File Offset: 0x0001C968
		private global::Motorola.Acp.PackUnpack.Ish.IshType a(global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection A_0, int A_1)
		{
			short num = (short)405833795;
			short num2 = num;
			num = (short)846956611;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_A4;
			case 1:
				break;
			default:
			{
				num = (short)1115422720;
				short num3 = num;
				break;
			}
			}
			num = (short)1333067776;
			if (num != 0)
			{
			}
			num = (short)2059010049;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator = A_0.GetEnumerator();
			global::Motorola.Acp.PackUnpack.Ish.IshType result;
			try
			{
				num = (short)633208834;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)594935809;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout structureLayout = enumerator.Current.Layouts.Find(A_1);
						num = (short)203489283;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)256901126;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_E7;
						}
						continue;
					case 3:
					{
						global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout structureLayout;
						if (structureLayout != null)
						{
							num = (short)1830420485;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_18C;
					case 5:
					{
						global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout structureLayout;
						result = structureLayout.IshTypes[0];
						num = (short)1714094084;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_1A8;
					}
					IL_E9:
					num = (short)694878208;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_E7:
					goto IL_E9;
				}
				IL_18C:
				return result;
				IL_1A8:
				goto IL_A4;
			}
			finally
			{
				num = (short)854327296;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_1DE;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)629932034;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_213;
					}
					IL_1DE:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1857224705;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_213:;
			}
			return result;
			IL_A4:
			return null;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0001E9A8 File Offset: 0x0001CBA8
		private void a(global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.a A_0, global::Motorola.Acp.PackUnpack.Ish.IshType A_1, global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection A_2)
		{
			short num = (short)633208832;
			short num2 = num;
			num = (short)643439636;
			short num3 = num;
			num = (short)238099476;
			switch (num3 == num)
			{
			}
			num = (short)2109472769;
			if (num != 0)
			{
			}
			num = (short)964558848;
			if (num != 0)
			{
			}
			this.a(A_0, A_1);
			global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> list = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>();
			list.Add(A_2);
			this.l[A_1] = list;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0001EA74 File Offset: 0x0001CC74
		private void a(global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.a A_0, global::Motorola.Acp.PackUnpack.Ish.IshType A_1, global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> A_2)
		{
			short num = (short)203554816;
			short num2 = num;
			num = (short)342292902;
			short num3 = num;
			num = (short)460585382;
			switch (num3 == num)
			{
			}
			num = (short)1822097409;
			if (num != 0)
			{
			}
			num = (short)110362624;
			if (num != 0)
			{
			}
			this.a(A_0, A_1);
			this.l[A_1] = A_2;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0001EB34 File Offset: 0x0001CD34
		private void a(global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.a A_0, global::Motorola.Acp.PackUnpack.Ish.CompositeItem A_1)
		{
			short num = (short)1863909376;
			short num2 = num;
			num = (short)1618657438;
			short num3 = num;
			num = (short)1913241758;
			switch (num3 == num)
			{
			}
			num = (short)763822080;
			if (num != 0)
			{
			}
			num = (short)1161232385;
			if (num != 0)
			{
			}
			this.a(A_0, A_1.Type);
			this.m[A_1.Type] = A_1;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0001EBFC File Offset: 0x0001CDFC
		private void a(global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.a A_0, global::Motorola.Acp.PackUnpack.Ish.IshType A_1)
		{
			short num = (short)408944640;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType> list;
			for (;;)
			{
				IL_1E:
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					num = (short)737869825;
					if (num != 0)
					{
					}
					list = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType>();
					this.k[A_0] = list;
					num = (short)983629826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_124;
				}
				IL_30:
				while (!this.k.TryGetValue(A_0, out list))
				{
					num = (short)1852775832;
					short num3 = num;
					num = (short)1584405912;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)486277120;
						short num4 = num;
						num = (short)382992384;
						if (num != 0)
						{
						}
						num = (short)1893793793;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1E;
					}
					}
				}
				break;
			}
			IL_124:
			list.Add(A_1);
		}

		// Token: 0x04000040 RID: 64
		private global::System.Collections.Generic.Dictionary<int, global::AcpCommonLib.IAcpFeatureNode> a;

		// Token: 0x04000041 RID: 65
		private global::System.Collections.Generic.Dictionary<int, global::AcpBusinessLayer.Recordset> b;

		// Token: 0x04000042 RID: 66
		private global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField>> c;

		// Token: 0x04000043 RID: 67
		private global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.b> d;

		// Token: 0x04000044 RID: 68
		private global::System.IO.StreamWriter e;

		// Token: 0x04000045 RID: 69
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.c f;

		// Token: 0x04000046 RID: 70
		private global::System.Collections.Generic.List<int> g;

		// Token: 0x04000047 RID: 71
		private global::Motorola.Acp.PackUnpack.Ish.IshTypeSortComparer h;

		// Token: 0x04000048 RID: 72
		private global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.IshType> i;

		// Token: 0x04000049 RID: 73
		private global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType>> j;

		// Token: 0x0400004A RID: 74
		private global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager.a, global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType>> k;

		// Token: 0x0400004B RID: 75
		private global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.IshType, global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>> l;

		// Token: 0x0400004C RID: 76
		private global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.IshType, global::Motorola.Acp.PackUnpack.Ish.CompositeItem> m;

		// Token: 0x0400004D RID: 77
		private static global::System.Diagnostics.BooleanSwitch n;

		// Token: 0x0400004E RID: 78
		private static global::System.Diagnostics.BooleanSwitch o;

		// Token: 0x02000019 RID: 25
		private enum a
		{
			// Token: 0x04000050 RID: 80
			a,
			// Token: 0x04000051 RID: 81
			b,
			// Token: 0x04000052 RID: 82
			c,
			// Token: 0x04000053 RID: 83
			d,
			// Token: 0x04000054 RID: 84
			e,
			// Token: 0x04000055 RID: 85
			f
		}

		// Token: 0x0200001A RID: 26
		private struct b
		{
			// Token: 0x06000124 RID: 292 RVA: 0x0001ED38 File Offset: 0x0001CF38
			public b(global::Motorola.Acp.PackUnpack.Ish.IshItem A_0, global::Motorola.Acp.PackUnpack.Ish.Fields.IndexReferenceField A_1, global::AcpBusinessLayer.AcpRecRefField A_2)
			{
				this.a = A_0;
				this.b = A_1;
				this.c = A_2;
			}

			// Token: 0x06000125 RID: 293 RVA: 0x0001ED5C File Offset: 0x0001CF5C
			public global::Motorola.Acp.PackUnpack.Ish.IshItem d()
			{
				short num = (short)1522204672;
				short num2 = num;
				num = (short)541050431;
				short num3 = num;
				num = (short)88983103;
				switch (num3 == num)
				{
				}
				num = (short)688586753;
				if (num != 0)
				{
				}
				num = (short)127074304;
				if (num != 0)
				{
				}
				return this.a;
			}

			// Token: 0x06000126 RID: 294 RVA: 0x0001EE0C File Offset: 0x0001D00C
			public global::Motorola.Acp.PackUnpack.Ish.Fields.IndexReferenceField e()
			{
				short num = (short)215482368;
				short num2 = num;
				num = (short)20997193;
				short num3 = num;
				num = (short)1221485641;
				switch (num3 == num)
				{
				}
				num = (short)695664640;
				if (num != 0)
				{
				}
				num = (short)1052704769;
				if (num != 0)
				{
				}
				return this.b;
			}

			// Token: 0x06000127 RID: 295 RVA: 0x0001EEBC File Offset: 0x0001D0BC
			public global::AcpBusinessLayer.AcpRecRefField f()
			{
				short num = (short)1063911424;
				short num2 = num;
				num = (short)1272656728;
				short num3 = num;
				num = (short)526005080;
				switch (num3 == num)
				{
				}
				num = (short)1171324928;
				if (num != 0)
				{
				}
				num = (short)1540489217;
				if (num != 0)
				{
				}
				return this.c;
			}

			// Token: 0x04000056 RID: 86
			private global::Motorola.Acp.PackUnpack.Ish.IshItem a;

			// Token: 0x04000057 RID: 87
			private global::Motorola.Acp.PackUnpack.Ish.Fields.IndexReferenceField b;

			// Token: 0x04000058 RID: 88
			private global::AcpBusinessLayer.AcpRecRefField c;
		}
	}
}
