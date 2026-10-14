using System;
using System.Collections.Generic;
using System.Media;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;
using DevComponents.WpfRibbon.KeyTips;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000055 RID: 85
	internal class KeyTipsAdorner : global::System.Windows.Documents.Adorner
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x000571DC File Offset: 0x000553DC
		public KeyTipsAdorner(global::System.Windows.UIElement elem) : base(elem)
		{
			this.m_RootControl = (elem as global::System.Windows.Controls.Control);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00057214 File Offset: 0x00055414
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			int a_ = 2;
			short num = (short)1936523264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A5;
				}
				global::DevComponents.WpfRibbon.KeyTipRenderInfo keyTipRenderInfo;
				for (;;)
				{
					IL_31:
					num = (short)1376059392;
					short num3 = num;
					global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer keyTipRenderer;
					object obj;
					switch (num2)
					{
					case 0:
						if (this.m_ContextObject is global::System.Windows.Controls.Control)
						{
							num = (short)1507000327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1715208193;
						if (num != 0)
						{
						}
						keyTipRenderInfo.Typeface = new global::System.Windows.Media.Typeface(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᭙⹛㝝ş๡", a_));
						keyTipRenderInfo.FontSize = 8.25;
						num = (short)902561803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						keyTipRenderInfo.UseSpecKeyTipPositioning = ((global::DevComponents.WpfRibbon.Ribbon)this.m_RootControl).UseSpecKeyTipPositioning;
						num = (short)593952772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.m_ContextObject != null)
						{
							goto IL_372;
						}
						goto IL_38F;
					case 3:
						goto IL_425;
					case 4:
						keyTipRenderInfo.RibbonMenuMode = (((global::DevComponents.WpfRibbon.Ribbon)this.m_RootControl).IsRibbonMenuOpen && this.m_ContextObject is global::DevComponents.WpfRibbon.RibbonTab);
						num = (short)53542925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						keyTipRenderer.Render(drawingContext, obj, keyTipRenderInfo);
						num = (short)758972428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (this.m_RootControl is global::DevComponents.WpfRibbon.Ribbon)
						{
							num = (short)878051329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33C;
					case 7:
					{
						global::System.Windows.Controls.Control control = this.m_ContextObject as global::System.Windows.Controls.Control;
						keyTipRenderInfo.Typeface = new global::System.Windows.Media.Typeface(control.FontFamily, control.FontStyle, control.FontWeight, control.FontStretch);
						keyTipRenderInfo.FontSize = control.FontSize;
						num = (short)464977936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						obj = this.m_ContextObject;
						num = (short)932184079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.m_RootControl != null)
						{
							num = (short)1208352782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1607532544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (keyTipRenderer != null)
						{
							num = (short)1546387461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						goto IL_425;
					case 12:
						return;
					case 13:
						goto IL_33C;
					case 14:
						keyTipRenderInfo.Typeface = new global::System.Windows.Media.Typeface(this.m_RootControl.FontFamily, this.m_RootControl.FontStyle, this.m_RootControl.FontWeight, this.m_RootControl.FontStretch);
						keyTipRenderInfo.FontSize = this.m_RootControl.FontSize;
						num = (short)1684799491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						num = (short)34748469;
						short num4 = num;
						num = (short)841496629;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_372;
						default:
							num = (short)115605504;
							if (num != 0)
							{
							}
							goto IL_38F;
						}
						break;
					}
					case 16:
						goto IL_425;
					}
					goto IL_A5;
					IL_33C:
					keyTipRenderInfo.ActiveKeyTipsElements = this.m_ActiveKeyTipElements;
					keyTipRenderer = null;
					obj = this.m_RootControl;
					num = (short)969998338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_372:
					num = (short)2028797960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38F:
					keyTipRenderer = global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderFactory.GetRenderer(obj);
					num = (short)215023626;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_425:
					keyTipRenderInfo.KeyTipsStack = this.KeyTipsStack;
					keyTipRenderInfo.Adorner = this;
					num = (short)1007484934;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_A5:
				global::DevComponents.WpfRibbon.KeyTipColors enabledColors = this.GetEnabledColors();
				global::DevComponents.WpfRibbon.KeyTipColors disabledColors = this.GetDisabledColors();
				this.m_ActiveKeyTipElements.Clear();
				keyTipRenderInfo = new global::DevComponents.WpfRibbon.KeyTipRenderInfo();
				keyTipRenderInfo.EnabledColors = enabledColors;
				keyTipRenderInfo.DisabledColors = disabledColors;
				num = (short)1422721033;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000576A0 File Offset: 0x000558A0
		protected override global::System.Windows.Media.HitTestResult HitTestCore(global::System.Windows.Media.PointHitTestParameters hitTestParameters)
		{
			short num = (short)226723234;
			short num2 = num;
			num = (short)1087210914;
			switch (num2 == num)
			{
			}
			num = (short)1947860993;
			if (num != 0)
			{
			}
			num = (short)429457408;
			short num3 = num;
			num = (short)872611840;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0005774C File Offset: 0x0005594C
		private global::DevComponents.WpfRibbon.KeyTipColors GetDisabledColors()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::DevComponents.WpfRibbon.KeyTipColors keyTipColors;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_16B;
				case 1:
				{
					global::System.Windows.Media.Brush brush;
					keyTipColors.Border = new global::System.Windows.Media.Pen(brush, 1.0);
					keyTipColors.Border.Freeze();
					num2 = (short)409600000;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					global::System.Windows.Media.Brush brush;
					if (brush != null)
					{
						num2 = (short)1217986561;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16D;
				}
				}
				break;
			}
			IL_1C:
			num2 = (short)51380225;
			if (num2 != 0)
			{
			}
			num2 = (short)520239938;
			short num3 = num2;
			num2 = (short)1651260226;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_16B:
				break;
			default:
			{
				num2 = (short)79626240;
				short num4 = num2;
				num2 = (short)1307312128;
				if (num2 != 0)
				{
				}
				keyTipColors = new global::DevComponents.WpfRibbon.KeyTipColors();
				keyTipColors.Background = (base.FindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.RibbonColors.KeyTipsDisabledBackground)) as global::System.Windows.Media.Brush);
				global::System.Windows.Media.Brush brush = base.FindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.RibbonColors.KeyTipsDisabledBorder)) as global::System.Windows.Media.Brush;
				num2 = (short)191430658;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			IL_16D:
			keyTipColors.Foreground = (base.FindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.RibbonColors.KeyTipsDisabledForeground)) as global::System.Windows.Media.Brush);
			return keyTipColors;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000578EC File Offset: 0x00055AEC
		private global::DevComponents.WpfRibbon.KeyTipColors GetEnabledColors()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::DevComponents.WpfRibbon.KeyTipColors keyTipColors;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_14B;
				case 1:
				{
					global::System.Windows.Media.Brush brush;
					keyTipColors.Border = new global::System.Windows.Media.Pen(brush, 1.0);
					keyTipColors.Border.Freeze();
					num2 = (short)556924928;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					global::System.Windows.Media.Brush brush;
					if (brush != null)
					{
						num2 = (short)1066139649;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14D;
				}
				}
				break;
			}
			IL_1C:
			num2 = (short)1227589665;
			short num3 = num2;
			num2 = (short)1515096097;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_14B:
				break;
			default:
			{
				num2 = (short)381550592;
				if (num2 != 0)
				{
				}
				num2 = (short)607322112;
				short num4 = num2;
				keyTipColors = new global::DevComponents.WpfRibbon.KeyTipColors();
				keyTipColors.Background = (base.FindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.RibbonColors.KeyTipsEnabledBackground)) as global::System.Windows.Media.Brush);
				global::System.Windows.Media.Brush brush = base.FindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.RibbonColors.KeyTipsEnabledBorder)) as global::System.Windows.Media.Brush;
				num2 = (short)2103705602;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			IL_14D:
			num2 = (short)1066991617;
			if (num2 != 0)
			{
			}
			keyTipColors.Foreground = (base.FindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.RibbonColors.KeyTipsEnabledForeground)) as global::System.Windows.Media.Brush);
			return keyTipColors;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00057A94 File Offset: 0x00055C94
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x00057B48 File Offset: 0x00055D48
		public string KeyTipsStack
		{
			get
			{
				short num = (short)923926529;
				if (num != 0)
				{
				}
				num = (short)2046893626;
				short num2 = num;
				num = (short)1467751994;
				switch (num2 == num)
				{
				}
				num = (short)1732640768;
				short num3 = num;
				num = (short)678821888;
				if (num != 0)
				{
				}
				return this.m_KeyTipsStack;
			}
			set
			{
				short num = (short)1959985155;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_F4;
					case 1:
						if (this.m_KeyTipsStack != value)
						{
							num = (short)1287585794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						this.m_KeyTipsStack = value;
						base.InvalidateVisual();
						num = (short)1004666884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 4:
						return;
					case 5:
					{
						num = (short)1585643521;
						if (num != 0)
						{
						}
						value = "";
						num = (short)581632000;
						short num3 = num;
						num = (short)325124096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_3D:
					num = (short)1811767717;
					short num4 = num;
					num = (short)644899237;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)176160768;
						if (num != 0)
						{
						}
						if (value == null)
						{
							num = (short)789839877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_F4:
					num = (short)1381892097;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00057CD8 File Offset: 0x00055ED8
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x00057D88 File Offset: 0x00055F88
		public object ContextObject
		{
			get
			{
				short num = (short)1422753664;
				short num2 = num;
				num = (short)489848704;
				switch (num2 == num)
				{
				}
				num = (short)20709377;
				if (num != 0)
				{
				}
				num = (short)680132608;
				short num3 = num;
				num = (short)792395776;
				if (num != 0)
				{
				}
				return this.m_ContextObject;
			}
			set
			{
				short num = (short)1951108790;
				short num2 = num;
				num = (short)895717046;
				switch (num2 == num)
				{
				}
				num = (short)1663238145;
				if (num != 0)
				{
				}
				num = (short)1932918784;
				short num3 = num;
				num = (short)1669726208;
				if (num != 0)
				{
				}
				this.m_ContextObject = value;
				base.InvalidateVisual();
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00057E40 File Offset: 0x00056040
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x00057EF0 File Offset: 0x000560F0
		public global::System.Windows.Controls.Control RootControl
		{
			get
			{
				short num = (short)2085192421;
				short num2 = num;
				num = (short)1560773349;
				switch (num2 == num)
				{
				}
				num = (short)2104623104;
				if (num != 0)
				{
				}
				num = (short)464977920;
				short num3 = num;
				num = (short)536674305;
				if (num != 0)
				{
				}
				return this.m_RootControl;
			}
			set
			{
				short num = (short)789184513;
				if (num != 0)
				{
				}
				num = (short)2109069625;
				short num2 = num;
				num = (short)1662245177;
				switch (num2 == num)
				{
				}
				num = (short)1747058688;
				short num3 = num;
				num = (short)796852224;
				if (num != 0)
				{
				}
				this.m_RootControl = value;
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00057F9C File Offset: 0x0005619C
		internal bool ProcessTextInput(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			short num = (short)506929088;
			short num2 = num;
			num = (short)66527168;
			switch (num2 == num)
			{
			}
			num = (short)82116608;
			if (num != 0)
			{
			}
			num = (short)898170880;
			short num3 = num;
			num = (short)328335361;
			if (num != 0)
			{
			}
			bool handled = e.Handled;
			bool result = this.ProcessKeyInput(this.GetInputText(e), ref handled);
			e.Handled = handled;
			return result;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00058060 File Offset: 0x00056260
		private string GetInputText(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			if (e.SystemText != "")
			{
				short num = (short)1518701635;
				short num2 = num;
				num = (short)473336899;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1403518976;
					short num3 = num;
					num = (short)1820786689;
					if (num != 0)
					{
					}
					num = (short)1776222208;
					if (num != 0)
					{
					}
					return e.SystemText;
				}
				}
			}
			return e.Text;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0005812C File Offset: 0x0005632C
		private bool ProcessKeyInput(string textInput, ref bool markAsHandled)
		{
			short num = (short)796196864;
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
				bool flag;
				string text;
				global::System.Collections.Generic.List<global::System.Windows.UIElement>.Enumerator enumerator;
				bool result;
				for (;;)
				{
					IL_27:
					num = (short)345571329;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return false;
					case 1:
					{
						num = (short)1831774802;
						short num3 = num;
						num = (short)435989074;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)722403328;
							if (num != 0)
							{
							}
							if (flag)
							{
								num = (short)1160642564;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Media.SystemSounds.Beep.Play();
							num = (short)1979973632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_2F7;
					case 3:
						try
						{
							num = (short)1674838018;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									string keyTip;
									if (keyTip.StartsWith(text))
									{
										num = (short)61014019;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									string keyTip;
									if (keyTip == text)
									{
										num = (short)1974468617;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1443299328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_19F;
									}
									continue;
								case 3:
									flag = true;
									num = (short)727121926;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)566951944;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = enumerator.Current;
									string keyTip = global::DevComponents.WpfRibbon.Ribbon.GetKeyTip(uielement);
									num = (short)1318322177;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_2C0;
								case 7:
									goto IL_2A6;
								case 8:
									num = (short)1973944325;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									markAsHandled = true;
									global::System.Windows.UIElement uielement;
									result = this.ExecuteAction(uielement);
									num = (short)1239678983;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1A1:
								num = (short)896860164;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_19F:
								goto IL_1A1;
							}
							IL_2A6:
							goto IL_2F9;
							IL_2C0:
							goto IL_CC;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						return false;
						IL_CC:
						num = (short)638189569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						this.KeyTipsStack = text;
						markAsHandled = true;
						num = (short)1682702338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6A;
				}
				return false;
				IL_2F7:
				return false;
				IL_2F9:
				num = (short)298975232;
				short num4 = num;
				return result;
				IL_6A:
				text = this.m_KeyTipsStack + textInput.ToUpper();
				flag = false;
				enumerator = this.m_ActiveKeyTipElements.GetEnumerator();
				num = (short)1195180035;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0005847C File Offset: 0x0005667C
		public bool ExecuteAction(global::System.Windows.UIElement elem)
		{
			short num = (short)2010513408;
			switch (num)
			{
			default:
			{
				num = (short)1300758538;
				int num2 = (int)((global::System.IntPtr)num);
				global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
				global::System.Windows.Automation.Provider.IExpandCollapseProvider expandCollapseProvider;
				global::System.Windows.Automation.Provider.IToggleProvider toggleProvider;
				global::DevComponents.WpfRibbon.Ribbon ribbon2;
				for (;;)
				{
					global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
					switch (num2)
					{
					case 0:
						goto IL_5AA;
					case 1:
						if (buttonDropDown.HasItems)
						{
							num = (short)103677959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C3;
					case 2:
						goto IL_790;
					case 3:
					{
						global::System.Windows.Automation.Peers.AutomationPeer automationPeer;
						if (automationPeer.IsEnabled())
						{
							num = (short)2098528265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 4:
						goto IL_5E2;
					case 5:
						goto IL_70C;
					case 6:
					{
						global::System.Windows.Automation.InvokePattern invokePattern;
						invokePattern.Invoke();
						num = (short)1426391083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_620;
					case 8:
					{
						global::System.Windows.Controls.RadioButton radioButton = (global::System.Windows.Controls.RadioButton)elem;
						num = (short)232325143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::System.Windows.Automation.Peers.AutomationPeer automationPeer;
						expandCollapseProvider = (automationPeer.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse) as global::System.Windows.Automation.Provider.IExpandCollapseProvider);
						num = (short)1105592351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						switch (0)
						{
						case 0:
							goto IL_102;
						}
						continue;
					case 11:
					{
						global::System.Windows.Automation.Peers.AutomationPeer automationPeer;
						if (automationPeer.IsControlElement())
						{
							num = (short)2012086318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 12:
					{
						global::System.Windows.Controls.CheckBox checkBox = (global::System.Windows.Controls.CheckBox)elem;
						num = (short)1907556380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						global::System.Windows.Automation.Peers.AutomationPeer automationPeer;
						if (automationPeer != null)
						{
							num = (short)427294755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 14:
					{
						global::DevComponents.WpfRibbon.Ribbon ribbon;
						ribbon.ShowKeyTipsForContext(elem as global::DevComponents.WpfRibbon.RibbonTab);
						num = (short)1096286213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)474939405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						(elem as global::System.Windows.Controls.TabItem).IsSelected = true;
						num = (short)616038439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						buttonDropDown = (elem as global::DevComponents.WpfRibbon.ButtonDropDown);
						num = (short)175243285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (elem is global::System.Windows.Controls.RadioButton)
						{
							num = (short)1926955016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)576258093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::DevComponents.WpfRibbon.Ribbon ribbon = this.m_RootControl as global::DevComponents.WpfRibbon.Ribbon;
						num = (short)1927872549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						if (toggleProvider != null)
						{
							num = (short)1999110146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Automation.Peers.AutomationPeer automationPeer;
						global::System.Windows.Automation.InvokePattern invokePattern = automationPeer.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Invoke) as global::System.Windows.Automation.InvokePattern;
						num = (short)46071840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						if (buttonDropDown.Role != global::DevComponents.WpfRibbon.eButtonRole.DropDown)
						{
							num = (short)1127350308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E7;
					case 22:
					{
						num = (short)1740995057;
						short num3 = num;
						num = (short)822901233;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6A2;
						case 1:
							break;
						default:
						{
							num = (short)399245312;
							short num4 = num;
							break;
						}
						}
						num = (short)2006974464;
						if (num != 0)
						{
						}
						if (elem is global::DevComponents.WpfRibbon.ButtonDropDown)
						{
							num = (short)1049362449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)395444258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						global::System.Windows.Controls.RadioButton radioButton;
						radioButton.SetValue(global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, !radioButton.IsChecked);
						num = (short)1047789597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_221;
					case 25:
						if (buttonDropDown.Role == global::DevComponents.WpfRibbon.eButtonRole.SplitButton)
						{
							num = (short)1810300968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C3;
					case 26:
						ribbonTab.IsSelected = true;
						num = (short)1924923416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_733;
					case 28:
					{
						global::System.Windows.Controls.CheckBox checkBox;
						checkBox.SetValue(global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, !checkBox.IsChecked);
						num = (short)1090256923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						return true;
					case 30:
						goto IL_507;
					case 31:
					{
						if (expandCollapseProvider != null)
						{
							num = (short)1331167262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Automation.Peers.AutomationPeer automationPeer;
						toggleProvider = (automationPeer.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Toggle) as global::System.Windows.Automation.Provider.IToggleProvider);
						num = (short)1948254228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
					{
						global::System.Windows.Automation.InvokePattern invokePattern;
						if (invokePattern != null)
						{
							num = (short)1027604486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 33:
						goto IL_6A2;
					case 34:
						if (elem is global::DevComponents.WpfRibbon.RibbonBar)
						{
							num = (short)787611681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)451805202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)1853816843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)586874905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
					{
						num = (short)275841025;
						if (num != 0)
						{
						}
						global::DevComponents.WpfRibbon.Ribbon ribbon;
						if (ribbon != null)
						{
							num = (short)1998389262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ribbonTab = (elem as global::DevComponents.WpfRibbon.RibbonTab);
						num = (short)1405091882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
						goto IL_241;
					case 39:
						goto IL_150;
					case 40:
						goto IL_5E7;
					case 41:
					{
						if (elem is global::System.Windows.Controls.TabItem)
						{
							num = (short)886702096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ribbon2 = (this.m_RootControl as global::DevComponents.WpfRibbon.Ribbon);
						global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(elem);
						num = (short)853671980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
						if (!ribbonTab.IsSelected)
						{
							num = (short)1606352922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_221;
					case 43:
						goto IL_346;
					case 44:
						if (ribbon2 != null)
						{
							num = (short)2100232207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 45:
						if (elem is global::System.Windows.Controls.CheckBox)
						{
							num = (short)1149566988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)257949737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						num = (short)1510146051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_102:
					if (elem is global::DevComponents.WpfRibbon.RibbonTab)
					{
						num = (short)877789203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1965359126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_221:
					this.ContextObject = ribbonTab;
					num = (short)1229455398;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C3:
					buttonDropDown.InternalOnClick(true);
					num = (short)1032454148;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E7:
					num = (short)475398145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6A2:
					(elem as global::DevComponents.WpfRibbon.RibbonBar).InvokeLaunchDialog();
					num = (short)1557987328;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_150:
				return true;
				IL_241:
				return false;
				IL_346:
				return true;
				IL_507:
				ribbon2.ShowKeyTips = false;
				elem.Focus();
				expandCollapseProvider.Expand();
				return false;
				IL_5AA:
				IL_5E2:
				return true;
				IL_620:
				buttonDropDown.ClickHeader();
				return false;
				IL_70C:
				return false;
				IL_733:
				return true;
				IL_790:
				toggleProvider.Toggle();
				return true;
			}
			}
		}

		// Token: 0x040001D9 RID: 473
		private global::System.Windows.Controls.Control m_RootControl;

		// Token: 0x040001DA RID: 474
		private string m_KeyTipsStack = "";

		// Token: 0x040001DB RID: 475
		private object m_ContextObject;

		// Token: 0x040001DC RID: 476
		private global::System.Collections.Generic.List<global::System.Windows.UIElement> m_ActiveKeyTipElements = new global::System.Collections.Generic.List<global::System.Windows.UIElement>(50);
	}
}
