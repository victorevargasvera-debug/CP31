using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.MenuItems
{
	// Token: 0x020002F9 RID: 761
	public class PageMenuItems : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06007AA1 RID: 31393 RVA: 0x006F9E64 File Offset: 0x006F8064
		public PageMenuItems()
		{
			try
			{
				this.InitializeComponent();
				global::AcpUI.Common.Utility.SetDirection(this);
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06007AA2 RID: 31394 RVA: 0x006F9E9C File Offset: 0x006F809C
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1887502337;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpUI.AcpExpander acpExpander;
				global::System.Collections.IEnumerator enumerator;
				switch (num2)
				{
				case 0:
					goto IL_2BD;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
					goto IL_A8;
				case 3:
				{
					try
					{
						num = (short)479461378;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1654980609;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1A4;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_ED;
								}
								continue;
							case 3:
								base.Expanders.Add(acpExpander);
								num = (short)566231046;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								if (acpExpander != null)
								{
									num = (short)38076419;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 5:
								if (!enumerator.MoveNext())
								{
									num = (short)1091567616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)944963588;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_12E:
							num = (short)681115653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_ED:
							goto IL_12E;
						}
						IL_1A4:
						goto IL_249;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1C5;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1B3:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)1882128385;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_217;
							case 1:
								disposable.Dispose();
								num = (short)106102786;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_215;
							}
							goto IL_1C5;
						}
						IL_215:
						IL_217:
						goto EndFinally_7;
						IL_1C5:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1567227904;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1B3;
						EndFinally_7:;
					}
					goto IL_218;
					IL_249:
					base.OnLoaded(sender, e);
					this.a = true;
					num = (short)194579552;
					short num3 = num;
					num = (short)394136672;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A8;
					default:
						num = (short)1449525248;
						if (num != 0)
						{
						}
						num = (short)1377697792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_35:
				num = (short)1358823425;
				if (num != 0)
				{
				}
				num = (short)882245632;
				short num4 = num;
				if (!this.a)
				{
					num = (short)51249154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_218:
				acpExpander = null;
				enumerator = this.MyStackPanel.Children.GetEnumerator();
				num = (short)931201027;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A8:
				goto IL_218;
			}
			IL_2BD:
			this.MyStackPanel.Children[0].Focus();
		}

		// Token: 0x06007AA3 RID: 31395 RVA: 0x006FA190 File Offset: 0x006F8390
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)153747456;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)677640312;
				short num3 = num;
				num = (short)277411960;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C7;
				case 1:
					break;
				default:
				{
					num = (short)1760165888;
					short num4 = num;
					break;
				}
				}
				num = (short)1138294784;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A5;
					}
					continue;
				case 1:
					goto IL_C7;
				case 2:
					goto IL_EE;
				}
				IL_A5:
				if (this.a)
				{
					num = (short)1780154369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_C7:
				base.OnUnloaded(sender, e);
				this.a = false;
				num = (short)225312770;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EE:
			num = (short)1527906305;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007AA4 RID: 31396 RVA: 0x006FA2B8 File Offset: 0x006F84B8
		public override void SetDataContext()
		{
			short num = (short)1606483970;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_63;
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1436221440;
						short num3 = num;
						num = (short)1276510213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2088);
					num = (short)1384120326;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					for (;;)
					{
						global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2088);
						num = (short)1503193350;
						short num4 = num;
						num = (short)1553656070;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_167;
						}
					}
					IL_167:
					num = (short)1030029312;
					if (num != 0)
					{
					}
					num = (short)1461256193;
					if (num != 0)
					{
					}
					num = (short)2080571393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_63;
				}
				IL_41:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1889009668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2088);
				num = (short)362414080;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_63:
				num = (short)541065219;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06007AA5 RID: 31397 RVA: 0x006FA484 File Offset: 0x006F8684
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)835792750;
			short num2 = num;
			num = (short)1809854318;
			switch (num2 == num)
			{
			}
			num = (short)844038144;
			if (num != 0)
			{
			}
			num = (short)719519745;
			if (num != 0)
			{
			}
			num = (short)1868562432;
			short num3 = num;
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06007AA6 RID: 31398 RVA: 0x006FA534 File Offset: 0x006F8734
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)241101651;
			short num2 = num;
			num = (short)1770711891;
			switch (num2 == num)
			{
			}
			num = (short)318504960;
			if (num != 0)
			{
			}
			num = (short)259915777;
			if (num != 0)
			{
			}
			num = (short)350158848;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06007AA7 RID: 31399 RVA: 0x006FA5E4 File Offset: 0x006F87E4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 4;
			short num;
			while (!this.b)
			{
				num = (short)374908717;
				short num2 = num;
				num = (short)1102554925;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)428539905;
					if (num != 0)
					{
					}
					num = (short)714276864;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("蛆ꗈꟊ诌꫎냐꟒ꃔꗖ볘꣚볞軠転闤裦蟨軪菬鯮\udef0臲铴鏶郸铺\ud8fc췾㄀昂眄怆昈攊戌戎砐瀒昔㈖⬘⬚縜瀞传䔢䰤䀦尨太䰬嬮堰尲嬴ᠶ娸吺匼䬾㍀ⱂ⥄㑆晈♊⡌ⅎ⑐癒杔杖じ⽚㡜㉞በ䱢ࡤɦݨṪѬ᭮ᑰṲٴ奶Ÿ᩺ၼ፾", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)490471424;
			short num3 = num;
		}

		// Token: 0x06007AA8 RID: 31400 RVA: 0x006FA6C0 File Offset: 0x006F88C0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)555220992;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					num = (short)1422131202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_23A;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_17F;
				case 2:
					goto IL_267;
				case 3:
					goto IL_C4;
				case 4:
					goto IL_1D7;
				case 5:
					goto IL_215;
				case 6:
					goto IL_274;
				case 7:
					goto IL_1CA;
				case 8:
					goto IL_281;
				case 9:
					goto IL_A0;
				case 10:
					goto IL_2A5;
				case 11:
					goto IL_93;
				case 12:
					goto IL_1B0;
				case 13:
					goto IL_1E4;
				case 14:
					goto IL_E8;
				case 15:
					goto IL_1BD;
				case 16:
					goto IL_208;
				default:
					num = (short)733872129;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_93:
			this.DispMenuConventionalSelectedMenuItems_A21736Comp = (global::AcpUI.AcpMenuItems)target;
			return;
			IL_A0:
			this.DispMenuConventionalSelectedMenuItems_A21736 = (global::AcpUI.AcpMenuItems)target;
			this.DispMenuConventionalSelectedMenuItems_A21736.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C4:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_E8:
			num = (short)951279860;
			short num3 = num;
			num = (short)494625012;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_17F:
				((global::Motorola.MackinawCPS.CoreFeatures.MenuItems.PageMenuItems)target).Loaded += this.OnLoaded;
				((global::Motorola.MackinawCPS.CoreFeatures.MenuItems.PageMenuItems)target).Unloaded += this.OnUnloaded;
				return;
			default:
			{
				num = (short)1736048640;
				if (num != 0)
				{
				}
				num = (short)348913664;
				short num4 = num;
				this.DispMenuTrunkingSelectedMenuItems_A21735 = (global::AcpUI.AcpMenuItems)target;
				this.DispMenuTrunkingSelectedMenuItems_A21735.GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			}
			IL_1B0:
			this.CVBtnDispMenuTrunkingSelectedMenuItems_A21735 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1BD:
			this.CpyBtnDispMenuTrunkingSelectedMenuItems_A21735 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1CA:
			this.CVBtnDispMenuConventionalSelectedMenuItems_A21736 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D7:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_1E4:
			this.LblDispMenuTrunkingSelectedMenuItems_A21735 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuTrunkingSelectedMenuItems_A21735.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_208:
			this.DispMenuTrunkingSelectedMenuItems_A21735Comp = (global::AcpUI.AcpMenuItems)target;
			return;
			IL_215:
			this.ExpanderMenuItemsGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_23A:
			num = (short)1711669249;
			if (num != 0)
			{
			}
			this.b = true;
			return;
			IL_267:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_274:
			this.GrpBoxExpanderMenuItemsGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_281:
			this.LblDispMenuConventionalSelectedMenuItems_A21736 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuConventionalSelectedMenuItems_A21736.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2A5:
			this.CpyBtnDispMenuConventionalSelectedMenuItems_A21736 = (global::AcpUI.AcpCopyButton)target;
		}

		// Token: 0x04003574 RID: 13684
		private bool a;

		// Token: 0x04003575 RID: 13685
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04003576 RID: 13686
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04003577 RID: 13687
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04003578 RID: 13688
		internal global::AcpUI.AcpExpander ExpanderMenuItemsGeneral;

		// Token: 0x04003579 RID: 13689
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderMenuItemsGeneralPseudo0;

		// Token: 0x0400357A RID: 13690
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuConventionalSelectedMenuItems_A21736;

		// Token: 0x0400357B RID: 13691
		internal global::AcpUI.AcpLabel LblDispMenuConventionalSelectedMenuItems_A21736;

		// Token: 0x0400357C RID: 13692
		internal global::AcpUI.AcpMenuItems DispMenuConventionalSelectedMenuItems_A21736;

		// Token: 0x0400357D RID: 13693
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuConventionalSelectedMenuItems_A21736;

		// Token: 0x0400357E RID: 13694
		internal global::AcpUI.AcpMenuItems DispMenuConventionalSelectedMenuItems_A21736Comp;

		// Token: 0x0400357F RID: 13695
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuTrunkingSelectedMenuItems_A21735;

		// Token: 0x04003580 RID: 13696
		internal global::AcpUI.AcpLabel LblDispMenuTrunkingSelectedMenuItems_A21735;

		// Token: 0x04003581 RID: 13697
		internal global::AcpUI.AcpMenuItems DispMenuTrunkingSelectedMenuItems_A21735;

		// Token: 0x04003582 RID: 13698
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuTrunkingSelectedMenuItems_A21735;

		// Token: 0x04003583 RID: 13699
		internal global::AcpUI.AcpMenuItems DispMenuTrunkingSelectedMenuItems_A21735Comp;

		// Token: 0x04003584 RID: 13700
		private bool b;
	}
}
