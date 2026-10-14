using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000102 RID: 258
	public abstract class RMSetEditor : global::System.Windows.Controls.UserControl
	{
		// Token: 0x0600079C RID: 1948 RVA: 0x0007ADF8 File Offset: 0x00078FF8
		public RMSetEditor()
		{
			int a_ = 7;
			base..ctor();
			global::Motorola.CommonCPS.RadioManagement.Controls.SharedResourceDictionary item = new global::Motorola.CommonCPS.RadioManagement.Controls.SharedResourceDictionary
			{
				Source = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("낞첢톤좦\udba8쒪솬캮龰\udab4\udab6풸풺펼ﲾ釀郂闆꣈꿊꓌ꃎ鳐닒믔뛖뻘뻚냜뫞迠韢쯤ꓦ蛨藪駬鷮黰鿲蛴쳶髸铺郼迾渀洂怄椆紈␊堌簎琐愒嘔砖眘漚漜瀞䴠倢ਤ琦䰨弪栬䬮堰䜲娴䔶瀸唺匼娾㍀၂ㅄ㹆╈⹊㹌慎⥐㉒㡔㭖", a_), global::System.UriKind.Relative)
			};
			base.Resources.MergedDictionaries.Add(item);
			base.Initialized += this.RMSetEditor_Initialized;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0007AE58 File Offset: 0x00079058
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> GetFieldEditorList()
		{
			short num = (short)685723250;
			short num2 = num;
			num = (short)1915178610;
			switch (num2 == num)
			{
			}
			num = (short)21954560;
			if (num != 0)
			{
			}
			num = (short)1748959233;
			if (num != 0)
			{
			}
			num = (short)2359296;
			short num3 = num;
			global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, string> fieldEditorAndGroupList = this.GetFieldEditorAndGroupList();
			return fieldEditorAndGroupList.Keys.ToList<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>();
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0007AF14 File Offset: 0x00079114
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, string> GetFieldEditorAndGroupList()
		{
			short num = (short)519975345;
			short num2 = num;
			num = (short)1295069617;
			switch (num2 == num)
			{
			}
			num = (short)351469568;
			if (num != 0)
			{
			}
			num = (short)1018036225;
			if (num != 0)
			{
			}
			num = (short)8585216;
			short num3 = num;
			global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, string> dictionary = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, string>();
			global::System.Windows.Controls.ItemCollection items = ((global::System.Windows.Controls.ItemsControl)base.Content).Items;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.a(items, dictionary, null);
			return dictionary;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0007AFDC File Offset: 0x000791DC
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> GetAllFieldEditors(bool excludeSetNameCommentsLastModifyDate)
		{
			int a_ = 10;
			short num = (short)320929792;
			switch (num)
			{
			default:
			{
				num = (short)1434124288;
				short num2 = num;
				num = (short)816447489;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>();
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> enumerable = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.d<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>(this);
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> enumerator = enumerable.GetEnumerator();
				try
				{
					num = (short)1974534148;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
						switch (num3)
						{
						case 0:
							if (excludeSetNameCommentsLastModifyDate)
							{
								num = (short)1640497154;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B9;
						case 1:
							goto IL_29A;
						case 2:
							num = (short)897318923;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (!(rmfieldEditor.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쮣쮥얧쾩슫\udaad쎯", a_)))
							{
								num = (short)512163848;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_E9;
							}
							continue;
						case 5:
							if (!(rmfieldEditor.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("얣향\udca7쎫쪭\ud9af풱\uddb3펵\udcb7ﺹ\uddbb쪽ꖿ", a_)))
							{
								num = (short)1005715465;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 6:
							num = (short)671612933;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (!enumerator.MoveNext())
							{
								num = (short)1329201162;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							rmfieldEditor = enumerator.Current;
							num = (short)176881664;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_1B9;
						case 9:
							num = (short)448987139;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							num = (short)721420289;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							if (!(rmfieldEditor.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("솣튥쮩솫쮭", a_)))
							{
								num = (short)1257701382;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						IL_139:
						num = (short)1256259591;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_E9:
						goto IL_139;
						IL_1B9:
						list.Add(rmfieldEditor);
						num = (short)570818572;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_29A:;
				}
				finally
				{
					num = (short)788529153;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_356;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2D2;
							}
							continue;
						case 2:
						{
							enumerator.Dispose();
							num = (short)365368342;
							short num4 = num;
							num = (short)937956374;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_358;
							default:
								num = (short)1620770816;
								if (num != 0)
								{
								}
								num = (short)2012676096;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_2D2:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1664811010;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_356:
					IL_358:;
				}
				return list;
			}
			}
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0007B360 File Offset: 0x00079560
		private void RMSetEditor_Initialized(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)738373888;
			short num2 = num;
			num = (short)1448784128;
			switch (num2 == num)
			{
			}
			num = (short)2109997056;
			if (num != 0)
			{
			}
			num = (short)219742209;
			if (num != 0)
			{
			}
			num = (short)609222656;
			short num3 = num;
			global::System.Windows.Controls.ItemCollection items = ((global::System.Windows.Controls.ItemsControl)base.Content).Items;
			global::System.Windows.Controls.Label label = new global::System.Windows.Controls.Label();
			items.Add(label);
			label.Loaded += this.lastControl_Loaded;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0007B43C File Offset: 0x0007963C
		private void lastControl_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1425735681;
			if (num != 0)
			{
			}
			num = (short)971636505;
			short num2 = num;
			num = (short)1767636761;
			switch (num2 == num)
			{
			}
			num = (short)1471217664;
			if (num != 0)
			{
			}
			num = (short)1354629120;
			short num3 = num;
			global::System.Windows.FrameworkElement frameworkElement = A_0 as global::System.Windows.FrameworkElement;
			frameworkElement.Loaded -= this.lastControl_Loaded;
			this.a();
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0007B504 File Offset: 0x00079704
		private void a(global::System.Windows.Controls.ItemsControl A_0)
		{
			short num = (short)1292959744;
			short num2 = num;
			num = (short)619905024;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B0;
				}
				int num4;
				for (;;)
				{
					IL_51:
					switch (num3)
					{
					case 0:
						goto IL_33C;
					case 1:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorHeader rmspecialEditorHeader;
						global::System.Windows.Data.MultiBinding binding;
						rmspecialEditorHeader.SetBinding(global::System.Windows.UIElement.VisibilityProperty, binding);
						int num5;
						num4 = num5 - 1;
						num = (short)730988552;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (A_0.Items[num4] is global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorHeader)
						{
							num = (short)1691680786;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1139671053;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_33C;
					case 4:
						goto IL_118;
					case 5:
						goto IL_33C;
					case 6:
					{
						int num5;
						if (num5 == A_0.Items.Count - 1)
						{
							num = (short)1346109441;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5++;
						num = (short)1417084932;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_274;
					case 8:
						goto IL_33C;
					case 9:
						goto IL_274;
					case 10:
					{
						global::System.Windows.Controls.ItemsControl itemsControl;
						if (itemsControl != null)
						{
							num = (short)1543110670;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33C;
					}
					case 11:
						if (num4 >= A_0.Items.Count)
						{
							num = (short)1918173205;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F7;
					case 12:
					{
						int num5;
						if (A_0.Items[num5] is global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditor)
						{
							num = (short)296943632;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorHeader rmspecialEditorHeader;
						global::System.Windows.Data.MultiBinding binding;
						rmspecialEditorHeader.SetBinding(global::System.Windows.UIElement.VisibilityProperty, binding);
						num4 = num5 - 1;
						num = (short)367263747;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (A_0.Items[num4] is global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupBox)
						{
							num = (short)62062609;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33C;
					case 14:
					{
						global::System.Windows.Controls.ItemsControl itemsControl;
						this.a(itemsControl);
						num = (short)358547461;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						num = (short)1453354443;
						short num6 = num;
						num = (short)186215883;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3F7;
						default:
							num = (short)1957429248;
							if (num != 0)
							{
							}
							num = (short)1777664000;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
					{
						global::System.Windows.Data.MultiBinding binding;
						int num5;
						this.a((global::System.Windows.FrameworkElement)A_0.Items[num5], ref binding);
						num = (short)957939718;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupBox rmgroupBox = A_0.Items[num4] as global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupBox;
						global::System.Windows.Controls.ItemsControl itemsControl = rmgroupBox.Content as global::System.Windows.Controls.ItemsControl;
						num = (short)1538719754;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorHeader rmspecialEditorHeader = A_0.Items[num4] as global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorHeader;
						global::System.Windows.Data.MultiBinding binding = new global::System.Windows.Data.MultiBinding
						{
							Converter = new global::Motorola.CommonCPS.RadioManagement.Controls.MultiFieldsIsVisibleConverter()
						};
						int num5 = num4 + 1;
						num = (short)1664811027;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_118;
					case 20:
					{
						int num5;
						if (num5 >= A_0.Items.Count)
						{
							num = (short)339083279;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1966276620;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_2B6;
					}
					goto IL_B0;
					IL_118:
					num = (short)178585620;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_274:
					num = (short)1557004299;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_33C:
					num4++;
					num = (short)2060910601;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F7:
					num = (short)472055810;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_2B6:
				num = (short)1243414529;
				if (num != 0)
				{
				}
				return;
				IL_B0:
				num4 = 0;
				num = (short)604766215;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0007B9AC File Offset: 0x00079BAC
		private static global::System.Windows.Controls.ItemCollection a(global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor A_0)
		{
			short num;
			global::System.Windows.Controls.ItemCollection result;
			try
			{
				num = (short)1851457541;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Controls.ItemsControl itemsControl;
					switch (num2)
					{
					case 0:
						goto IL_B6;
					case 1:
					{
						num = (short)1863966187;
						short num3 = num;
						num = (short)2013060587;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B6;
						default:
							goto IL_126;
						}
						break;
					}
					case 2:
						if (itemsControl == null)
						{
							num = (short)1662320646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = itemsControl.Items;
						num = (short)622002177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_D0;
					case 4:
						goto IL_74;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_40;
						}
						continue;
					case 6:
						result = null;
						num = (short)1023868932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_40:
					if (A_0.Content == null)
					{
						num = (short)90439680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					itemsControl = (A_0.Content as global::System.Windows.Controls.ItemsControl);
					num = (short)975896578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B6:
					result = null;
					num = (short)1499398147;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_74:
				IL_D0:
				goto IL_143;
				IL_126:
				num = (short)15597568;
				if (num != 0)
				{
				}
			}
			catch (global::System.Exception)
			{
				result = null;
			}
			IL_143:
			num = (short)116654080;
			short num4 = num;
			num = (short)2009202689;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0007BB6C File Offset: 0x00079D6C
		private static void a(global::System.Collections.ICollection A_0, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, string> A_1, string A_2 = null)
		{
			int a_ = 17;
			short num = (short)239861760;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)84344832;
				short num3 = num;
				global::System.Collections.IEnumerator enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)1690107919;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor rmanchor;
						object obj;
						global::System.Windows.Controls.ItemsControl itemsControl;
						switch (num2)
						{
						case 0:
						{
							global::System.Windows.Controls.Grid grid;
							global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.a(grid.Children, A_1, A_2);
							num = (short)1000865809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							global::System.Windows.Controls.ItemCollection itemCollection;
							global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.a(itemCollection, A_1, null);
							num = (short)884146204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::System.Windows.Controls.ItemCollection itemCollection = global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.a(rmanchor);
							num = (short)755630112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)1782382610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor rmcellPresentableFieldEditor;
							A_1.Add(rmcellPresentableFieldEditor, A_2);
							num = (short)2012020739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							itemsControl = ((obj as global::System.Windows.Controls.Border).Child as global::System.Windows.Controls.ItemsControl);
							num = (short)1616642074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							global::System.Windows.Controls.ItemCollection items = itemsControl.Items;
							global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.a(items, A_1, A_2);
							num = (short)44498946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							num = (short)186187803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							if (itemsControl != null)
							{
								num = (short)338427912;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.Controls.Grid grid = obj as global::System.Windows.Controls.Grid;
							num = (short)422314007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchorNoExpander rmanchorNoExpander;
							if (rmanchorNoExpander != null)
							{
								num = (short)1462829090;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor rmcellPresentableFieldEditor = obj as global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor;
							num = (short)1423310881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							num = (short)1806499853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor rmcellPresentableFieldEditor;
							if (!string.IsNullOrEmpty(rmcellPresentableFieldEditor.Label))
							{
								num = (short)969015301;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_364;
						}
						case 14:
							goto IL_579;
						case 15:
							switch (0)
							{
							case 0:
								goto IL_10E;
							}
							continue;
						case 16:
							if (obj is global::System.Windows.Controls.GroupBox)
							{
								num = (short)2052325395;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)686293013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							goto IL_167;
						case 18:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor rmcellPresentableFieldEditor;
							if (!(rmcellPresentableFieldEditor.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("直캪\ud9ac킰\udeb2킴", a_)))
							{
								num = (short)325058580;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 19:
							itemsControl = ((obj as global::System.Windows.Controls.GroupBox).Content as global::System.Windows.Controls.ItemsControl);
							num = (short)139722766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							num = (short)813105177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							if (obj is global::System.Windows.Controls.Border)
							{
								num = (short)2055143431;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_579;
						case 22:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1370357769;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							obj = enumerator.Current;
							global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchorNoExpander rmanchorNoExpander = obj as global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchorNoExpander;
							num = (short)1521156107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
						{
							global::System.Windows.Controls.Grid grid;
							if (grid != null)
							{
								num = (short)936443904;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_167;
						}
						case 24:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor rmcellPresentableFieldEditor;
							if (!(rmcellPresentableFieldEditor.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒪사슮풰\uddb2솴쒶", a_)))
							{
								num = (short)147980294;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 25:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor rmcellPresentableFieldEditor;
							if (!(rmcellPresentableFieldEditor.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪪\udeac\udbaeﲰ\udcb2톴\udeb6\udfb8튺\ud8bc\udbbe藀ꋂ뇄ꋆ", a_)))
							{
								num = (short)748355613;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 26:
							goto IL_579;
						case 27:
							goto IL_5F4;
						case 29:
							num = (short)322371608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							if (rmanchor != null)
							{
								num = (short)1397030916;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 32:
						{
							global::System.Windows.Controls.ItemCollection itemCollection;
							if (itemCollection != null)
							{
								num = (short)831651841;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 33:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor rmcellPresentableFieldEditor;
							if (rmcellPresentableFieldEditor != null)
							{
								num = (short)43057164;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_364;
						}
						case 34:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchorNoExpander rmanchorNoExpander;
							A_2 = rmanchorNoExpander.Caption;
							num = (short)1323892767;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_10E;
						IL_167:
						rmanchor = (obj as global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor);
						num = (short)1658585118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_321:
						num = (short)9830422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_10E:
						goto IL_321;
						IL_364:
						itemsControl = null;
						num = (short)750911504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_579:
						num = (short)284688394;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_5F4:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_616;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_603:
						switch (num2)
						{
						case 0:
							goto IL_6BA;
						case 1:
						{
							num = (short)1546288161;
							short num4 = num;
							num = (short)696220705;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_6A1;
							default:
								num = (short)1246167040;
								if (num != 0)
								{
								}
								if (disposable != null)
								{
									num = (short)849608706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6BC;
							}
							break;
						}
						case 2:
							disposable.Dispose();
							goto IL_6A1;
						}
						goto IL_616;
						IL_6A1:
						num = (short)305201152;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_6BA:
					IL_6BC:
					goto EndFinally_17;
					IL_616:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)124256257;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_603;
					EndFinally_17:;
				}
				num = (short)1317666817;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0007C278 File Offset: 0x0007A478
		private void a()
		{
			short num = (short)1338245120;
			short num2 = num;
			num = (short)18954297;
			short num3 = num;
			num = (short)1383151673;
			switch (num3 == num)
			{
			}
			num = (short)1050345473;
			if (num != 0)
			{
			}
			num = (short)2052390912;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.ItemsControl a_ = (global::System.Windows.Controls.ItemsControl)base.Content;
			this.a(a_);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0007C338 File Offset: 0x0007A538
		private void a(global::System.Windows.FrameworkElement A_0, ref global::System.Windows.Data.MultiBinding A_1)
		{
			int a_ = 1;
			short num = (short)1110310914;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> enumerator;
				switch (num2)
				{
				case 0:
					goto IL_88;
				case 1:
					if (!A_0.GetType().IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields)))
					{
						num = (short)183828487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8D;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 3:
					if (!A_0.GetType().IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorHeader)))
					{
						num = (short)1315176457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8D;
				case 4:
					goto IL_4B0;
				case 5:
					num = (short)349175809;
					if (num != 0)
					{
					}
					num = (short)416743428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					try
					{
						num = (short)723517443;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
							switch (num2)
							{
							case 0:
								if (!rmfieldEditor.GetType().IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditor)))
								{
									num = (short)2065563657;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_336;
							case 1:
								if (rmfieldEditor.GetType().IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields)))
								{
									num = (short)1229979658;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								A_1.Bindings.Add(new global::System.Windows.Data.Binding
								{
									Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udf98얠킢ﺤ\udca6馨횪膮삲\udeb6쪸튺\udfbc펾꓀", a_), rmfieldEditor.Name), global::System.Array.Empty<object>())
								});
								num = (short)257425412;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num = (short)287047687;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								rmfieldEditor = enumerator.Current;
								num = (short)1112539141;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_1C2;
								}
								continue;
							case 5:
								if (!(rmfieldEditor is global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorHeader))
								{
									num = (short)733085702;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 6:
								num = (short)1088815104;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								num = (short)1179058187;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								num = (short)71892993;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								goto IL_336;
							case 11:
								goto IL_372;
							}
							IL_1C4:
							num = (short)526450690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1C2:
							goto IL_1C4;
							IL_336:
							this.a(rmfieldEditor, ref A_1);
							num = (short)337117192;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_372:
						goto IL_4E6;
					}
					finally
					{
						num = (short)1791361024;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_3A7;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)7405570;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_3DC;
							}
							IL_3A7:
							if (enumerator == null)
							{
								break;
							}
							num = (short)774438913;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_3DC:;
					}
					return;
					IL_4E6:
					num = (short)773747735;
					short num3 = num;
					num = (short)1921479703;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4B0;
					default:
						goto IL_51A;
					}
					break;
				}
				case 7:
					goto IL_FF;
				case 8:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor)
					{
						num = (short)1995243525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8D;
				case 9:
					num = (short)803340289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)798621696;
					short num4 = num;
					num = (short)466550787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_5A:
				if (A_0.GetType() == typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMLabelFieldEditor))
				{
					num = (short)1435566080;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1470889992;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8D:
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> enumerable = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.d<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>(A_0);
				enumerator = enumerable.GetEnumerator();
				num = (short)1530068998;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4B0:
				if (A_0.GetType().IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditor)))
				{
					goto IL_8D;
				}
				num = (short)1030422538;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_88:
			return;
			IL_FF:
			A_1.Bindings.Add(new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udf98얠킢ﺤ\udca6馨횪膮삲\udeb6쪸튺\udfbc펾꓀", a_), A_0.Name), global::System.Array.Empty<object>())
			});
			return;
			IL_51A:
			num = (short)2073624576;
			if (num != 0)
			{
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060007A7 RID: 1959 RVA: 0x0007C894 File Offset: 0x0007AA94
		// (remove) Token: 0x060007A8 RID: 1960 RVA: 0x0007C948 File Offset: 0x0007AB48
		public event global::System.Windows.RoutedEventHandler RelocateHelpWindowRequested
		{
			add
			{
				short num = (short)1493499904;
				short num2 = num;
				num = (short)1726545921;
				if (num != 0)
				{
				}
				num = (short)296261662;
				short num3 = num;
				num = (short)1355454494;
				switch (num3 == num)
				{
				}
				num = (short)135790592;
				if (num != 0)
				{
				}
				base.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.RelocateHelpWindowRequestedEvent, value);
			}
			remove
			{
				short num = (short)1032978432;
				short num2 = num;
				num = (short)625432984;
				short num3 = num;
				num = (short)1372608920;
				switch (num3 == num)
				{
				}
				num = (short)1709441024;
				if (num != 0)
				{
				}
				num = (short)742981633;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.RelocateHelpWindowRequestedEvent, value);
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0007C9FC File Offset: 0x0007ABFC
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x0007CAB4 File Offset: 0x0007ACB4
		public int OrderStartIndex
		{
			get
			{
				short num = (short)1651834880;
				short num2 = num;
				num = (short)942542098;
				short num3 = num;
				num = (short)1054346514;
				switch (num3 == num)
				{
				}
				num = (short)785645569;
				if (num != 0)
				{
				}
				num = (short)616955904;
				if (num != 0)
				{
				}
				return (int)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.OrderStartIndexProperty);
			}
			set
			{
				short num = (short)1757020160;
				short num2 = num;
				num = (short)2091974657;
				if (num != 0)
				{
				}
				num = (short)1784402950;
				short num3 = num;
				num = (short)751490054;
				switch (num3 == num)
				{
				}
				num = (short)791150592;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.OrderStartIndexProperty, value);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x0007CB70 File Offset: 0x0007AD70
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x0007CC2C File Offset: 0x0007AE2C
		public bool AllowMoveSet
		{
			get
			{
				short num = (short)1548419072;
				short num2 = num;
				num = (short)366486877;
				short num3 = num;
				num = (short)1321215325;
				switch (num3 == num)
				{
				}
				num = (short)1699020801;
				if (num != 0)
				{
				}
				num = (short)1944125440;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.AllowMoveSetProperty);
			}
			set
			{
				short num = (short)106430464;
				short num2 = num;
				num = (short)1234370561;
				if (num != 0)
				{
				}
				num = (short)2120874729;
				short num3 = num;
				num = (short)17758953;
				switch (num3 == num)
				{
				}
				num = (short)707264512;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.AllowMoveSetProperty, value);
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0007CCE4 File Offset: 0x0007AEE4
		// Note: this type is marked as 'beforefieldinit'.
		static RMSetEditor()
		{
			int a_ = 18;
			short num = (short)1354366976;
			short num2 = num;
			num = (short)898174418;
			short num3 = num;
			num = (short)1081282002;
			switch (num3 == num)
			{
			}
			num = (short)1734934529;
			if (num != 0)
			{
			}
			num = (short)606994432;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.RelocateHelpWindowRequestedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즫슭\udfaf톱햳습\uddb7\ud9bb튽낿闁귃ꣅ곇ꗉ믋鳍뗏ꏑꇓ돕ꯗ껙맛뫝", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.OrderStartIndexProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udeab쪭햯삱습\ud9b7좹좻꺿ꛁꇃ뻅", a_), typeof(int), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter), new global::System.Windows.FrameworkPropertyMetadata(-1));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.AllowMoveSetProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삫슭\udfaf얱靈\ud9b5캷\udfb9\udbbd뒿", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x0400037B RID: 891
		public static readonly global::System.Windows.DependencyProperty OrderStartIndexProperty;

		// Token: 0x0400037C RID: 892
		public static readonly global::System.Windows.DependencyProperty AllowMoveSetProperty;
	}
}
