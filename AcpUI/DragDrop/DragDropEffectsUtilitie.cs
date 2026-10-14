using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUI.Common;

namespace AcpUI.DragDrop
{
	// Token: 0x02000065 RID: 101
	public static class DragDropEffectsUtilitie
	{
		// Token: 0x0600053E RID: 1342 RVA: 0x0006A3BC File Offset: 0x000685BC
		private static bool d(global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureNode> A_0, string A_1)
		{
			short num = (short)1833169631;
			short num2 = num;
			num = (short)1056305887;
			switch (num2 == num)
			{
			}
			num = (short)203685889;
			if (num != 0)
			{
			}
			num = (short)363986944;
			short num3 = num;
			num = (short)681377792;
			if (num != 0)
			{
			}
			global::AcpUI.DragDrop.DragDropEffectsUtilitie.a a = new global::AcpUI.DragDrop.DragDropEffectsUtilitie.a();
			a.a = A_1;
			return A_0.Any(new global::System.Func<global::AcpCommonLib.IAcpFeatureNode, bool>(a.b));
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0006A484 File Offset: 0x00068684
		private static bool a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1824534836;
			short num2 = num;
			num = (short)330838324;
			global::AcpBusinessLayer.AcpField<bool> acpField;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2015887360;
				if (num != 0)
				{
				}
				num = (short)186384389;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					switch (num3)
					{
					case 0:
					{
						num = (short)317521920;
						short num4 = num;
						obj = null;
						goto IL_199;
					}
					case 1:
						if (acpField == null)
						{
							num = (short)1641938946;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FD;
					case 2:
						goto IL_1D2;
					case 3:
						obj = null;
						goto IL_199;
					case 4:
						obj = null;
						goto IL_199;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_8B;
						}
						continue;
					case 6:
						obj = null;
						goto IL_199;
					}
					IL_8B:
					global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureSection> featureSectionsCollection = A_0.FeatureSectionsCollection;
					if (featureSectionsCollection == null)
					{
						num = (short)529399814;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = featureSectionsCollection.First(new global::System.Func<global::AcpCommonLib.IAcpFeatureSection, bool>(global::AcpUI.DragDrop.DragDropEffectsUtilitie.<>c.<>9.b));
					if (acpFeatureSection == null)
					{
						num = (short)911802368;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> fieldsCollection = acpFeatureSection.FieldsCollection;
					if (fieldsCollection == null)
					{
						num = (short)52035588;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list = fieldsCollection.ToList<global::AcpCommonLib.IAcpField>();
					if (list == null)
					{
						num = (short)594411523;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					obj = list.First(new global::System.Func<global::AcpCommonLib.IAcpField, bool>(global::AcpUI.DragDrop.DragDropEffectsUtilitie.<>c.<>9.b));
					IL_199:
					acpField = (obj as global::AcpBusinessLayer.AcpField<bool>);
					num = (short)1095827457;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1D2:
				num = (short)611450881;
				if (num != 0)
				{
				}
				return false;
			}
			}
			IL_1FD:
			return acpField.Value;
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0006A694 File Offset: 0x00068894
		private static global::AcpCommonLib.IAcpFeatureNode c(global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureNode> A_0, string A_1)
		{
			short num = (short)332717309;
			short num2 = num;
			num = (short)539614461;
			switch (num2 == num)
			{
			}
			num = (short)1717895168;
			if (num != 0)
			{
			}
			num = (short)434503680;
			short num3 = num;
			num = (short)958332929;
			if (num != 0)
			{
			}
			global::AcpUI.DragDrop.DragDropEffectsUtilitie.b b = new global::AcpUI.DragDrop.DragDropEffectsUtilitie.b();
			b.a = A_1;
			return A_0.First(new global::System.Func<global::AcpCommonLib.IAcpFeatureNode, bool>(b.b));
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0006A75C File Offset: 0x0006895C
		private static bool b(global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureNode> A_0, string A_1)
		{
			global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = global::AcpUI.DragDrop.DragDropEffectsUtilitie.c(A_0, A_1);
			short num;
			if (acpFeatureNode == null)
			{
				for (;;)
				{
					num = (short)110504249;
					short num2 = num;
					num = (short)1169762617;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_42;
					}
				}
				IL_42:
				num = (short)169934848;
				if (num != 0)
				{
				}
				return false;
			}
			num = (short)758382592;
			short num3 = num;
			num = (short)478085121;
			if (num != 0)
			{
			}
			return global::AcpUI.DragDrop.DragDropEffectsUtilitie.a(acpFeatureNode);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0006A81C File Offset: 0x00068A1C
		private static string a(global::System.Collections.Generic.Dictionary<string, object> A_0)
		{
			int a_ = 15;
			short num = (short)139161355;
			short num2 = num;
			num = (short)74870539;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)295567360;
				if (num != 0)
				{
				}
				num = (short)2012545029;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					switch (num3)
					{
					case 0:
					{
						object obj = A_0[global::AcpUI.Common.Utility.c("햦욨쾪\ud8ac첮풰솲﮴\ud8b6\uddb8\udeba\udabeꋀ냂ꃄ돆胈迊", a_)];
						if (obj == null)
						{
							num = (short)1725956100;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = obj.ToString();
						goto IL_152;
					}
					case 1:
						if (A_0[global::AcpUI.Common.Utility.c("햦욨쾪\ud8ac첮풰솲﮴\ud8b6\uddb8\udeba\udabeꟀꛂ럄ꋆꟈ꣊꣌蓎듐꫒", a_)] is string)
						{
							num = (short)493551618;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F9;
					case 2:
						goto IL_1F7;
					case 3:
						num = (short)391249921;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						text = null;
						goto IL_152;
					case 5:
						num = (short)1058275329;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_BB;
						}
						continue;
					case 6:
					{
						num = (short)2140602368;
						short num4 = num;
						num = (short)555220992;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_BB:
					if (A_0 != null)
					{
						num = (short)2052653062;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F9;
					IL_152:
					if (!(text == global::AcpUI.Common.Utility.c("鞤鞦鲨骪", a_)))
					{
						goto IL_1F9;
					}
					num = (short)851902467;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1F7:
				string text2 = A_0[global::AcpUI.Common.Utility.c("햦욨쾪\ud8ac첮풰솲﮴\ud8b6\uddb8\udeba\udabeꟀꛂ럄ꋆꟈ꣊꣌蓎듐꫒", a_)] as string;
				return text2.Substring(text2.IndexOf('-') + 1);
			}
			}
			IL_1F9:
			return null;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0006AA24 File Offset: 0x00068C24
		private static bool a(global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureNode> A_0)
		{
			short num = (short)226202851;
			short num2 = num;
			num = (short)1146852579;
			switch (num2 == num)
			{
			}
			num = (short)2118254593;
			if (num != 0)
			{
			}
			num = (short)621477888;
			short num3 = num;
			num = (short)381222912;
			if (num != 0)
			{
			}
			return A_0.Any(new global::System.Func<global::AcpCommonLib.IAcpFeatureNode, bool>(global::AcpUI.DragDrop.DragDropEffectsUtilitie.<>c.<>9.a));
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0006AAF4 File Offset: 0x00068CF4
		private static bool a(global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureNode> A_0, string A_1)
		{
			if (global::AcpUI.DragDrop.DragDropEffectsUtilitie.d(A_0, A_1))
			{
				short num;
				for (;;)
				{
					num = (short)550938704;
					short num2 = num;
					num = (short)1657579600;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_43;
					}
				}
				IL_43:
				num = (short)899678209;
				if (num != 0)
				{
				}
				num = (short)1192165376;
				if (num != 0)
				{
				}
				num = (short)1358495744;
				short num3 = num;
				return global::AcpUI.DragDrop.DragDropEffectsUtilitie.b(A_0, A_1);
			}
			return false;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0006ABB8 File Offset: 0x00068DB8
		public static bool IsZoneChannelAssignmentRecsetDragDropDisable(global::AcpCommonLib.IAcpRecordset recordSet, global::System.Collections.Generic.Dictionary<string, object> producerTreeData)
		{
			short num2;
			if (recordSet.Count > 0)
			{
				bool result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_7D;
					}
					int num;
					string text;
					for (;;)
					{
						IL_67:
						switch (num)
						{
						case 0:
							goto IL_125;
						case 1:
						{
							result = global::AcpUI.DragDrop.DragDropEffectsUtilitie.a(recordSet as global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureNode>, text);
							num2 = (short)143256322;
							short num3 = num2;
							num2 = (short)1375464194;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num2 = (short)1660223488;
								if (num2 != 0)
								{
								}
								num2 = (short)938803200;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 2:
							goto IL_14A;
						case 3:
							if (text != null)
							{
								num2 = (short)1164115969;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							result = global::AcpUI.DragDrop.DragDropEffectsUtilitie.a(recordSet as global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureNode>);
							num2 = (short)1865875458;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_7D;
					}
					IL_125:
					IL_14A:
					return result;
					IL_7D:
					text = global::AcpUI.DragDrop.DragDropEffectsUtilitie.a(producerTreeData);
					num2 = (short)1645805571;
					num = (int)((global::System.IntPtr)num2);
					goto IL_67;
				}
				catch (global::System.NullReferenceException)
				{
					result = false;
				}
				return result;
			}
			num2 = (short)1345519617;
			if (num2 != 0)
			{
			}
			num2 = (short)763297792;
			short num4 = num2;
			return false;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0006AD28 File Offset: 0x00068F28
		public static bool IsZoneDragDropDisble(global::AcpCommonLib.IAcpFeatureNode section)
		{
			short num = (short)1224798669;
			short num2 = num;
			num = (short)187560397;
			switch (num2 == num)
			{
			}
			num = (short)332791809;
			if (num != 0)
			{
			}
			num = (short)1362231296;
			short num3 = num;
			num = (short)384958464;
			if (num != 0)
			{
			}
			return global::AcpUI.DragDrop.DragDropEffectsUtilitie.a(section);
		}

		// Token: 0x040002D4 RID: 724
		private const int a = 10116;

		// Token: 0x040002D5 RID: 725
		private const string b = "2051";

		// Token: 0x040002D6 RID: 726
		private const string c = "ZnChanCfgZoneZoneCloningEnable_43119";

		// Token: 0x040002D7 RID: 727
		private const string d = "ZnChanCfgZoneZoneName_A9724";

		// Token: 0x040002D8 RID: 728
		private const string e = "ProducerNodeRecsetID";

		// Token: 0x040002D9 RID: 729
		private const string f = "ProducerNodeReferenceKey";

		// Token: 0x02000066 RID: 102
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000548 RID: 1352 RVA: 0x0006ADEC File Offset: 0x00068FEC
			internal bool b(global::AcpCommonLib.IAcpFeatureNode A_0)
			{
				global::AcpBusinessLayer.AcpField<string> acpField;
				for (;;)
				{
					IL_00:
					short num = (short)310050816;
					short num2 = num;
					num = (short)869335048;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)25755649;
						if (num != 0)
						{
						}
						object obj;
						switch (num3)
						{
						case 0:
							obj = null;
							goto IL_245;
						case 1:
							obj = null;
							goto IL_245;
						case 2:
							obj = null;
							goto IL_245;
						case 3:
						{
							global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureSection> featureSectionsCollection = A_0.FeatureSectionsCollection;
							if (featureSectionsCollection == null)
							{
								num = (short)844790106;
								short num4 = num;
								num = (short)1767405914;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_00;
								default:
									num = (short)533921792;
									if (num != 0)
									{
									}
									num = (short)760086530;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
							}
							else
							{
								global::System.Collections.Generic.List<global::AcpCommonLib.IAcpFeatureSection> list = featureSectionsCollection.ToList<global::AcpCommonLib.IAcpFeatureSection>();
								if (list == null)
								{
									num = (short)2038890503;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = list.First(new global::System.Func<global::AcpCommonLib.IAcpFeatureSection, bool>(global::AcpUI.DragDrop.DragDropEffectsUtilitie.<>c.<>9.a));
								if (acpFeatureSection == null)
								{
									num = (short)1419968518;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> fieldsCollection = acpFeatureSection.FieldsCollection;
								if (fieldsCollection == null)
								{
									num = (short)818741249;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list2 = fieldsCollection.ToList<global::AcpCommonLib.IAcpField>();
								if (list2 == null)
								{
									num = (short)1638924288;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								obj = list2.First(new global::System.Func<global::AcpCommonLib.IAcpField, bool>(global::AcpUI.DragDrop.DragDropEffectsUtilitie.<>c.<>9.a));
								goto IL_245;
							}
							break;
						}
						case 4:
							goto IL_268;
						case 5:
							obj = null;
							goto IL_245;
						case 6:
							obj = null;
							goto IL_245;
						case 7:
							obj = null;
							goto IL_245;
						case 8:
							switch (0)
							{
							case 0:
								goto IL_9D;
							}
							continue;
						case 9:
							num = (short)1387528197;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_9D:
						if (A_0 == null)
						{
							num = (short)1249574921;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)336461827;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_245:
						acpField = (obj as global::AcpBusinessLayer.AcpField<string>);
						if (acpField != null)
						{
							goto IL_26B;
						}
						num = (short)1634598916;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_268:
				string text = null;
				goto IL_272;
				IL_26B:
				text = acpField.Value;
				IL_272:
				return text == this.a;
			}

			// Token: 0x040002DA RID: 730
			public string a;
		}

		// Token: 0x02000068 RID: 104
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x06000555 RID: 1365 RVA: 0x0006BBA8 File Offset: 0x00069DA8
			internal bool b(global::AcpCommonLib.IAcpFeatureNode A_0)
			{
				short num = (short)298188800;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1816985600;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_5F;
						}
						continue;
					}
					case 1:
						goto IL_AC;
					case 2:
						goto IL_100;
					case 3:
						goto IL_D5;
					}
					IL_5F:
					global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = A_0.FeatureSectionsCollection.ToList<global::AcpCommonLib.IAcpFeatureSection>().First(new global::System.Func<global::AcpCommonLib.IAcpFeatureSection, bool>(global::AcpUI.DragDrop.DragDropEffectsUtilitie.<>c.<>9.c));
					if (acpFeatureSection == null)
					{
						num = (short)872939521;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> fieldsCollection = acpFeatureSection.FieldsCollection;
						if (fieldsCollection == null)
						{
							num = (short)1200357379;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							list = fieldsCollection.ToList<global::AcpCommonLib.IAcpField>();
							if (list != null)
							{
								goto IL_178;
							}
							num = (short)844300290;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
				}
				IL_AC:
				object obj = null;
				goto IL_1A2;
				IL_D5:
				obj = null;
				goto IL_1A2;
				IL_100:
				num = (short)2123628545;
				if (num != 0)
				{
				}
				num = (short)128014470;
				short num4 = num;
				num = (short)466376838;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D5;
				default:
					num = (short)877068288;
					if (num != 0)
					{
					}
					obj = null;
					goto IL_1A2;
				}
				IL_178:
				obj = list.First(new global::System.Func<global::AcpCommonLib.IAcpField, bool>(global::AcpUI.DragDrop.DragDropEffectsUtilitie.<>c.<>9.c));
				IL_1A2:
				return (obj as global::AcpBusinessLayer.AcpField<string>).Value == this.a;
			}

			// Token: 0x040002E5 RID: 741
			public string a;
		}
	}
}
