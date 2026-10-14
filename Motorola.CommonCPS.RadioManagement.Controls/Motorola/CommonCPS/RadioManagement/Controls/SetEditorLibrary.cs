using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000F9 RID: 249
	public static class SetEditorLibrary
	{
		// Token: 0x060006ED RID: 1773 RVA: 0x0006F458 File Offset: 0x0006D658
		public static global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor GetSetEditor(string setCategoryName, bool isTelePortMode, bool isInsertBasicFields)
		{
			short num = (short)913771673;
			short num2 = num;
			num = (short)1300106393;
			switch (num2 == num)
			{
			}
			num = (short)1366687745;
			if (num != 0)
			{
			}
			num = (short)3473408;
			short num3 = num;
			num = (short)1739849728;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.a(setCategoryName, isTelePortMode, isInsertBasicFields);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0006F510 File Offset: 0x0006D710
		private static global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor b(string A_0, bool A_1, bool A_2)
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int num;
			global::System.WeakReference<global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor> weakReference;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor rmsetEditor;
			short num2;
			string key;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (!weakReference.TryGetTarget(out rmsetEditor))
					{
						goto IL_243;
					}
					num2 = (short)405401631;
					short num3 = num2;
					num2 = (short)1050079263;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)161415168;
						if (num2 != 0)
						{
						}
						num2 = (short)49479681;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return rmsetEditor;
				case 2:
					if (weakReference == null)
					{
						num2 = (short)1109590026;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					weakReference.SetTarget(rmsetEditor);
					num2 = (short)2029780993;
					if (num2 != 0)
					{
					}
					num2 = (short)1909391364;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return rmsetEditor;
				case 4:
					goto IL_151;
				case 5:
				{
					num2 = (short)737476608;
					short num4 = num2;
					weakReference = global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.d[key];
					num2 = (short)255131648;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					if (rmsetEditor == null)
					{
						num2 = (short)1341587463;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B2;
				case 7:
					rmsetEditor = global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.a(A_0, A_2);
					num2 = (short)698941449;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.d.ContainsKey(key))
					{
						num2 = (short)1428357125;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_243;
				case 9:
					goto IL_B2;
				case 10:
					weakReference = new global::System.WeakReference<global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor>(rmsetEditor);
					global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.d.Add(key, weakReference);
					num2 = (short)1223622659;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_45;
				IL_B2:
				num2 = (short)1568210946;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_243:
				num2 = (short)70451206;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_151:
			return rmsetEditor;
			IL_45:
			key = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("튨鮪킬膮쪰芲좴馶슸覺삼", a_), A_0, A_1, A_2);
			weakReference = null;
			rmsetEditor = null;
			num2 = (short)56688648;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0006F79C File Offset: 0x0006D99C
		private static global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor a(string A_0, bool A_1, bool A_2)
		{
			int a_ = 19;
			short num = (short)2128543745;
			if (num != 0)
			{
			}
			string key = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킪鶬튮龰좲蒴쪶鞸삺込슾", a_), A_0, A_1, A_2);
			if (global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.c.ContainsKey(key))
			{
				num = (short)1468163430;
				short num2 = num;
				num = (short)1394763110;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)86048768;
					if (num != 0)
					{
					}
					return global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.c[key];
				}
			}
			num = (short)1284177920;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor rmsetEditor = global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.a(A_0, A_2);
			global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.c.Add(key, rmsetEditor);
			return rmsetEditor;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0006F8A4 File Offset: 0x0006DAA4
		private static global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor a(string A_0, bool A_1)
		{
			int a_ = 10;
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor result;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						return result;
					case 1:
					{
						num2 = (short)1627715716;
						short num3 = num2;
						num2 = (short)1148319876;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5C;
						default:
						{
							num2 = (short)665255937;
							if (num2 != 0)
							{
							}
							num2 = (short)1613824000;
							short num4 = num2;
							num2 = (short)1702363136;
							if (num2 != 0)
							{
							}
							if (A_0 != global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쮣즥\udca7", a_) && A_1)
							{
								num2 = (short)856096770;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						}
						}
						break;
					}
					case 2:
						global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.a(ref result);
						num2 = (short)1038286848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_25;
				}
				return result;
			}
			IL_25:
			result = (global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor)global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.b.CreateInstance(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud9a1钣\udba5蚧톩鶫펭", a_), global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쮣튥잧\ud8a9쎫슭톯鲱\ud9b5햷ힹ펻킽莿鋁韃髇ꯉ꣋ꟍ뿏鿑뗓룕맗뷙맛돝藟賡郣죥믧迩飫ꋭ駯郱蛳韵諷菹", a_), A_0));
			IL_5C:
			num2 = (short)1473380353;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0006FA14 File Offset: 0x0006DC14
		private static void a(ref global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor A_0)
		{
			int a_ = 3;
			short num = (short)1061703427;
			short num2 = num;
			num = (short)326586115;
			switch (num2 == num)
			{
			}
			num = (short)2114387968;
			short num3 = num;
			num = (short)187301889;
			if (num != 0)
			{
			}
			num = (short)557252608;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.ItemCollection items = ((global::System.Windows.Controls.ItemsControl)A_0.Content).Items;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor rmstringFieldEditor = new global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor
			{
				Name = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좚슢좤슦", a_),
				Label = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_Set_Name
			};
			rmstringFieldEditor.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udd9a爵춠잢횤ﲦ直캪\ud9ac킰\udeb2킴", a_));
			items.Insert(0, rmstringFieldEditor);
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor rmstringFieldEditor2 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor
			{
				Name = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("힚ﲜ햠쪤쎦삨춪쒬쪮햰풴쎶\udcb8", a_),
				Label = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_Set_LastModifiedDate
			};
			rmstringFieldEditor2.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udd9a爵춠잢횤ﲦ쪪\udeac\udbaeﲰ\udcb2톴\udeb6\udfb8튺\ud8bc\udbbe藀ꋂ뇄ꋆ铈", a_));
			items.Insert(1, rmstringFieldEditor2);
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor rmstringFieldEditor3 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor
			{
				Name = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud89a철욢쮤펦\udaa8", a_),
				Label = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_Set_Comments
			};
			rmstringFieldEditor3.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udd9a爵춠잢횤ﲦ쒪사슮풰\uddb2솴쒶", a_));
			items.Insert(2, rmstringFieldEditor3);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0006FBAC File Offset: 0x0006DDAC
		// Note: this type is marked as 'beforefieldinit'.
		static SetEditorLibrary()
		{
			int a_ = 4;
			short num = (short)1233893221;
			short num2 = num;
			num = (short)693548901;
			switch (num2 == num)
			{
			}
			num = (short)309067776;
			short num3 = num;
			num = (short)861470721;
			if (num != 0)
			{
			}
			num = (short)1090912256;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.b = global::System.Reflection.Assembly.Load(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톛풟춡횣즥쒧쮩芫\udfaf\udfb1\ud9b3\ud9b5횷惡郁ꗃꋅꇇꗉ臋꿍뻏돑돓돕뗗뿙닛ꫝ컟뇡臣鋥ꓧ菩軫鳭釯胱跳", a_));
			global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.c = new global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor>();
			global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.d = new global::System.Collections.Generic.Dictionary<string, global::System.WeakReference<global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor>>();
		}

		// Token: 0x04000334 RID: 820
		private const string a = "Motorola.CommonCPS.RadioManagement.SetLibrary";

		// Token: 0x04000335 RID: 821
		private static global::System.Reflection.Assembly b;

		// Token: 0x04000336 RID: 822
		private static global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor> c;

		// Token: 0x04000337 RID: 823
		private static global::System.Collections.Generic.Dictionary<string, global::System.WeakReference<global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor>> d;
	}
}
