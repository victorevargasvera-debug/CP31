using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000017 RID: 23
	public class ButtonDropDownAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IExpandCollapseProvider, global::System.Windows.Automation.Provider.IInvokeProvider, global::System.Windows.Automation.Provider.IToggleProvider
	{
		// Token: 0x0600020F RID: 527 RVA: 0x00032308 File Offset: 0x00030508
		public ButtonDropDownAutomationPeer(global::DevComponents.WpfRibbon.ButtonDropDown owner) : base(owner)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0003231C File Offset: 0x0003051C
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse()
		{
			int a_ = 14;
			short num = (short)908394496;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 1:
					goto IL_10F;
				case 2:
					goto IL_55;
				}
				IL_39:
				if (!base.IsEnabled())
				{
					num = (short)363855874;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)165791389;
					short num3 = num;
					num = (short)335267485;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_57;
					default:
					{
						num = (short)76873729;
						if (num != 0)
						{
						}
						num = (short)1654915072;
						short num4 = num;
						num = (short)224919552;
						if (num != 0)
						{
						}
						num = (short)1555955713;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
			IL_55:
			IL_57:
			throw new global::System.Windows.Automation.ElementNotEnabledException();
			IL_10F:
			global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = (global::DevComponents.WpfRibbon.ButtonDropDown)base.Owner;
			if (!buttonDropDown.HasItems)
			{
				throw new global::System.InvalidOperationException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⥥ᡧཀྵṫ཭ѯ᭱᭳ᡵ塷᥹ᵻၽꚅ겋ﺍ秊鍊瞧", a_));
			}
			buttonDropDown.IsPopupOpen = false;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00032468 File Offset: 0x00030668
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			short num = (short)1915653871;
			short num2 = num;
			num = (short)878087919;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2010054656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2019164160;
			if (num != 0)
			{
			}
			num = (short)1965031425;
			if (num != 0)
			{
			}
			return global::System.Windows.Automation.Peers.AutomationControlType.Button;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00032514 File Offset: 0x00030714
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Expand()
		{
			int a_ = 17;
			short num = (short)2044329985;
			if (num != 0)
			{
			}
			num = (short)1053425664;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 1:
					goto IL_111;
				case 2:
					goto IL_7C;
				}
				IL_60:
				if (!base.IsEnabled())
				{
					num = (short)909312002;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)315788462;
					short num3 = num;
					num = (short)1689226414;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7E;
					default:
					{
						num = (short)2146172928;
						short num4 = num;
						num = (short)513736704;
						if (num != 0)
						{
						}
						num = (short)1071906817;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
			IL_7C:
			IL_7E:
			throw new global::System.Windows.Automation.ElementNotEnabledException();
			IL_111:
			global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = (global::DevComponents.WpfRibbon.ButtonDropDown)base.Owner;
			if (!buttonDropDown.HasItems)
			{
				throw new global::System.InvalidOperationException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("♨᭪࡬ᵮၰݲᱴᡶ᝸孺ṼṾꦈ꾎爵얠", a_));
			}
			buttonDropDown.OpenPopup();
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00032664 File Offset: 0x00030864
		global::System.Windows.Automation.ExpandCollapseState global::System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
				global::System.Windows.Automation.ExpandCollapseState result;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1737175199;
						short num3 = num2;
						num2 = (short)1192571039;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4E;
						default:
							goto IL_F2;
						}
						break;
					}
					case 1:
						if (buttonDropDown.IsPopupOpen)
						{
							num2 = (short)215089155;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 2:
						if (!buttonDropDown.HasItems)
						{
							goto IL_4E;
						}
						num2 = (short)1075970049;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						result = global::System.Windows.Automation.ExpandCollapseState.Expanded;
						num2 = (short)760217604;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						goto IL_7A;
					}
					goto IL_24;
					IL_4E:
					num2 = (short)1783103488;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_7A:
				return result;
				IL_F2:
				num2 = (short)593559552;
				short num4 = num2;
				num2 = (short)1624965121;
				if (num2 != 0)
				{
				}
				num2 = (short)1295187968;
				if (num2 != 0)
				{
				}
				return global::System.Windows.Automation.ExpandCollapseState.LeafNode;
				IL_24:
				result = global::System.Windows.Automation.ExpandCollapseState.Collapsed;
				buttonDropDown = (global::DevComponents.WpfRibbon.ButtonDropDown)base.Owner;
				num2 = (short)551747586;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000327D0 File Offset: 0x000309D0
		void global::System.Windows.Automation.Provider.IInvokeProvider.Invoke()
		{
			short num = (short)1495465985;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (buttonDropDown.Role == global::DevComponents.WpfRibbon.eButtonRole.MenuItem)
					{
						num = (short)2090795012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D6;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 2:
					if (buttonDropDown.Role != global::DevComponents.WpfRibbon.eButtonRole.SplitButton)
					{
						num = (short)79298566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_187;
				case 3:
					if (!buttonDropDown.HasItems)
					{
						num = (short)1363542023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D6;
				case 4:
					goto IL_156;
				case 5:
				{
					num = (short)1896604521;
					short num3 = num;
					num = (short)1805902697;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_156;
					default:
						goto IL_9A;
					}
					break;
				}
				case 6:
					num = (short)888340480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_11A;
				}
				IL_44:
				if (!base.IsEnabled())
				{
					num = (short)1958739973;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				buttonDropDown = (global::DevComponents.WpfRibbon.ButtonDropDown)base.Owner;
				num = (short)1447231490;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_156:
				num = (short)879099904;
				short num4 = num;
				num = (short)1102512131;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9A:
			num = (short)760283136;
			if (num != 0)
			{
			}
			num = (short)12845057;
			if (num != 0)
			{
			}
			throw new global::System.Windows.Automation.ElementNotEnabledException();
			IL_11A:
			IL_187:
			buttonDropDown.InternalOnClick(false);
			return;
			IL_1D6:
			buttonDropDown.ClickHeader();
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000329BC File Offset: 0x00030BBC
		void global::System.Windows.Automation.Provider.IToggleProvider.Toggle()
		{
			int a_ = 13;
			short num = (short)1438777344;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 1:
					goto IL_112;
				case 2:
					goto IL_7E;
				}
				IL_3A:
				if (!base.IsEnabled())
				{
					num = (short)1459814401;
					if (num != 0)
					{
					}
					num = (short)1555628034;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)995475806;
					short num3 = num;
					num = (short)1341964638;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_80;
					default:
					{
						num = (short)869597184;
						short num4 = num;
						num = (short)1613758464;
						if (num != 0)
						{
						}
						num = (short)1063583745;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
			IL_7E:
			IL_80:
			throw new global::System.Windows.Automation.ElementNotEnabledException();
			IL_112:
			global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = (global::DevComponents.WpfRibbon.ButtonDropDown)base.Owner;
			if (!buttonDropDown.IsCheckable)
			{
				throw new global::System.InvalidOperationException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⩤ᝦ౨ᥪ౬᭮ᡰᱲ᭴坶᩸᩺፼ᅾꖄꮊﶌ杖ﺚ列놞", a_));
			}
			buttonDropDown.IsChecked = !buttonDropDown.IsChecked;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00032B14 File Offset: 0x00030D14
		global::System.Windows.Automation.ToggleState global::System.Windows.Automation.Provider.IToggleProvider.ToggleState
		{
			get
			{
				while (!((global::DevComponents.WpfRibbon.ButtonDropDown)base.Owner).IsChecked)
				{
					short num = (short)929074936;
					short num2 = num;
					num = (short)412847864;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1702494208;
						short num3 = num;
						num = (short)2106130433;
						if (num != 0)
						{
						}
						num = (short)1948385280;
						if (num != 0)
						{
						}
						return global::System.Windows.Automation.ToggleState.Off;
					}
					}
				}
				return global::System.Windows.Automation.ToggleState.On;
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00032BD8 File Offset: 0x00030DD8
		internal void RaiseExpandCollapseAutomationEvent(bool oldValue, bool newValue)
		{
			short num = (short)1177944065;
			if (num != 0)
			{
			}
			num = (short)1995636736;
			short num2 = num;
			num = (short)429534553;
			short num3 = num;
			num = (short)960769369;
			switch (num3 == num)
			{
			}
			num = (short)724500480;
			if (num != 0)
			{
			}
			base.RaisePropertyChangedEvent(global::System.Windows.Automation.ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty, oldValue ? global::System.Windows.Automation.ExpandCollapseState.Expanded : global::System.Windows.Automation.ExpandCollapseState.Collapsed, newValue ? global::System.Windows.Automation.ExpandCollapseState.Expanded : global::System.Windows.Automation.ExpandCollapseState.Collapsed);
		}
	}
}
