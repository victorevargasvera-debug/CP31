using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using DevComponents.WpfDock.Converters;

namespace DevComponents.WpfDock
{
	// Token: 0x0200001C RID: 28
	internal class d : global::DevComponents.WpfDock.IDockSiteLayoutSerializer
	{
		// Token: 0x06000121 RID: 289 RVA: 0x000246DC File Offset: 0x000228DC
		public string SaveLayout(global::DevComponents.WpfDock.DockSite ds)
		{
			short num = (short)1932197888;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				global::System.Xml.XmlElement xmlElement;
				global::System.Xml.XmlDocument xmlDocument;
				global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfDock.SplitPanel> enumerator3;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::DevComponents.WpfDock.FloatingWindow>.Enumerator enumerator;
					global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow>.Enumerator enumerator2;
					global::System.Xml.XmlElement xmlElement2;
					global::DevComponents.WpfDock.SplitPanel splitPanel;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1525219334;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1669050870;
									short num3 = num;
									num = (short)226275830;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
									{
										num = (short)620494848;
										if (num != 0)
										{
										}
										if (!enumerator.MoveNext())
										{
											num = (short)1548550147;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::DevComponents.WpfDock.FloatingWindow floatingWindow = enumerator.Current;
										num = (short)216203269;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 1:
									goto IL_56A;
								case 3:
									num = (short)807993345;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::DevComponents.WpfDock.FloatingWindow floatingWindow;
									this.a(floatingWindow, xmlElement);
									num = (short)67371010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::DevComponents.WpfDock.FloatingWindow floatingWindow;
									if (global::DevComponents.WpfDock.DockSite.GetSaveLayout(floatingWindow))
									{
										num = (short)300154884;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_45A;
									}
									continue;
								}
								IL_45C:
								num = (short)1584267264;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_45A:
								goto IL_45C;
							}
							IL_56A:
							goto IL_331;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_57D;
					case 1:
						try
						{
							num = (short)1873281028;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1AA;
								case 2:
									num = (short)1932787712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)421330946;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfDock.DockWindow a_ = enumerator2.Current;
									this.a(a_, xmlElement2);
									num = (short)2129592321;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_130;
									}
									continue;
								}
								IL_15C:
								num = (short)1759969283;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_130:
								goto IL_15C;
							}
							IL_1AA:
							goto IL_5BE;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto Block_2;
					case 2:
						this.d(splitPanel, xmlElement).SetAttribute(global::DevComponents.WpfDock.e.o, global::System.Xml.XmlConvert.ToString(true));
						num = (short)2092957700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (global::DevComponents.WpfDock.DockSite.GetSaveLayout(splitPanel))
						{
							num = (short)616366082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A1;
					case 4:
						goto IL_A1;
					case 5:
						goto IL_57D;
					case 6:
						num = (short)1652883457;
						if (num != 0)
						{
						}
						if (splitPanel != null)
						{
							num = (short)588382213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A1;
					case 7:
						goto IL_1BD;
					}
					goto IL_4E;
					IL_A1:
					enumerator = ds.GetFloatingWindows().GetEnumerator();
					num = (short)1329856512;
					short num4 = num;
					num = (short)632160256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_331:
					global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow> dockWindows = ds.GetDockWindows(global::DevComponents.WpfDock.eDockList.AutoHide);
					xmlElement2 = xmlDocument.CreateElement(global::DevComponents.WpfDock.e.g);
					xmlElement.AppendChild(xmlElement2);
					enumerator2 = dockWindows.GetEnumerator();
					num = (short)1516765185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_2:
					try
					{
						IL_1BD:
						num = (short)1147797510;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::DevComponents.WpfDock.SplitPanel splitPanel2;
								if (global::DevComponents.WpfDock.DockSite.GetSaveLayout(splitPanel2))
								{
									num = (short)1124139011;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_2BE;
							case 3:
							{
								global::DevComponents.WpfDock.SplitPanel splitPanel2;
								this.d(splitPanel2, xmlElement);
								num = (short)504692738;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)1734279169;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								if (!enumerator3.MoveNext())
								{
									num = (short)1080295428;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::DevComponents.WpfDock.SplitPanel splitPanel2 = enumerator3.Current;
								num = (short)1981546496;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_1FF;
								}
								continue;
							}
							IL_267:
							num = (short)836501509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1FF:
							goto IL_267;
						}
						IL_2BE:
						goto IL_3A7;
					}
					finally
					{
						num = (short)189005826;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_32E;
							case 1:
								enumerator3.Dispose();
								num = (short)1537998848;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_2F5;
								}
								continue;
							}
							IL_2F5:
							if (enumerator3 == null)
							{
								break;
							}
							num = (short)36765697;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_32E:;
					}
					goto IL_331;
					IL_3A7:
					splitPanel = (ds.Content as global::DevComponents.WpfDock.SplitPanel);
					num = (short)1981546502;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_57D:
					num = (short)810483715;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_5BE:
				return xmlDocument.InnerXml;
				IL_4E:
				xmlDocument = new global::System.Xml.XmlDocument();
				xmlElement = xmlDocument.CreateElement(global::DevComponents.WpfDock.e.a);
				xmlElement.SetAttribute(global::DevComponents.WpfDock.e.h, global::System.Xml.XmlConvert.ToString(1));
				xmlDocument.AppendChild(xmlElement);
				enumerator3 = ds.SplitPanels.GetEnumerator();
				num = (short)325844999;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00024CFC File Offset: 0x00022EFC
		private void a(global::DevComponents.WpfDock.FloatingWindow A_0, global::System.Xml.XmlElement A_1)
		{
			short num = (short)1131806721;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_47;
			}
			int num2;
			global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
				{
					num = (short)2015252952;
					short num3 = num;
					num = (short)879907288;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2135425024;
						if (num != 0)
						{
						}
						num = (short)266076160;
						short num4 = num;
						break;
					}
					}
					num = (short)1946157057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (!global::DevComponents.WpfDock.DockSite.GetSaveLayout(dockWindowGroup))
					{
						num = (short)1131675651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_134;
				case 2:
					if (dockWindowGroup != null)
					{
						num = (short)500432896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_132;
				}
				goto IL_47;
			}
			return;
			IL_132:
			return;
			IL_134:
			global::System.Xml.XmlElement xmlElement = A_1.OwnerDocument.CreateElement(global::DevComponents.WpfDock.e.f);
			A_1.AppendChild(xmlElement);
			this.a(dockWindowGroup, xmlElement);
			xmlElement.SetAttribute(global::DevComponents.WpfDock.e.k, global::DevComponents.WpfDock.d.a(new global::System.Windows.Rect(A_0.Left, A_0.Top, A_0.Width, A_0.Height)));
			return;
			IL_47:
			dockWindowGroup = (A_0.Content as global::DevComponents.WpfDock.DockWindowGroup);
			num = (short)1458110466;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00024E8C File Offset: 0x0002308C
		private global::System.Xml.XmlElement d(global::DevComponents.WpfDock.SplitPanel A_0, global::System.Xml.XmlElement A_1)
		{
			short num = (short)654704640;
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
				global::System.Xml.XmlElement xmlElement;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_545;
					case 1:
						goto IL_47D;
					case 2:
						if (A_0.Parent is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)1468596225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_545;
					case 3:
						goto IL_545;
					case 4:
						xmlElement.SetAttribute(global::DevComponents.WpfDock.e.i, global::DevComponents.WpfDock.DockSite.GetDock(A_0).ToString());
						xmlElement.SetAttribute(global::DevComponents.WpfDock.e.l, global::System.Xml.XmlConvert.ToString(global::DevComponents.WpfDock.DockSite.GetDockSize(A_0)));
						num = (short)1846214659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (A_0.Parent is global::DevComponents.WpfDock.DockSite)
						{
							num = (short)1524563972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2093416450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						try
						{
							num = (short)1862533124;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Windows.UIElement uielement;
									this.a(uielement as global::DevComponents.WpfDock.DockWindowGroup, xmlElement);
									num = (short)1387921413;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1462894604;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Windows.UIElement uielement;
									this.a(uielement as global::DevComponents.WpfDock.DockWindow, xmlElement);
									num = (short)296222737;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Windows.UIElement uielement;
									if (uielement is global::DevComponents.WpfDock.DockWindow)
									{
										num = (short)1509687298;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)493158410;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_16A;
									}
									continue;
								case 6:
								{
									global::System.Windows.UIElement uielement;
									this.d(uielement as global::DevComponents.WpfDock.SplitPanel, xmlElement);
									num = (short)1808400395;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::System.Windows.UIElement uielement;
									if (global::DevComponents.WpfDock.DockSite.GetSaveLayout(uielement))
									{
										num = (short)871170062;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::System.Windows.UIElement uielement;
									this.a(uielement as global::System.Windows.FrameworkElement, xmlElement);
									num = (short)1738866695;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									num = (short)605805888;
									short num3 = num;
									num = (short)1398857024;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)1253179392;
										if (num != 0)
										{
										}
										global::System.Windows.UIElement uielement;
										if (uielement is global::DevComponents.WpfDock.SplitPanel)
										{
											num = (short)473759750;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1005584397;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 12:
									goto IL_409;
								case 13:
								{
									global::System.Windows.UIElement uielement;
									if (uielement is global::System.Windows.FrameworkElement)
									{
										num = (short)1773207561;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 14:
									num = (short)812974095;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
								{
									global::System.Windows.UIElement uielement;
									if (uielement is global::DevComponents.WpfDock.DockWindowGroup)
									{
										num = (short)1215234048;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1866334211;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1801191425;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = enumerator.Current;
									num = (short)1208418312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_16C:
								num = (short)1715929104;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16A:
								goto IL_16C;
							}
							IL_409:
							return xmlElement;
						}
						finally
						{
							num = (short)2083127297;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)216399874;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_441;
									}
									continue;
								case 2:
									goto IL_47A;
								}
								IL_441:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1290141696;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_47A:;
						}
						goto IL_47D;
					}
					goto IL_4B;
					IL_47D:
					global::System.Windows.Size relativeSize = global::DevComponents.WpfDock.SplitPanel.GetRelativeSize(A_0);
					xmlElement.SetAttribute(global::DevComponents.WpfDock.e.n, global::DevComponents.WpfDock.d.a(relativeSize));
					num = (short)123142144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_545:
					xmlElement.SetAttribute(global::DevComponents.WpfDock.e.p, A_0.Orientation.ToString());
					enumerator = A_0.Children.GetEnumerator();
					num = (short)1299906566;
					num2 = (int)((global::System.IntPtr)num);
				}
				return xmlElement;
				IL_4B:
				num = (short)647495681;
				if (num != 0)
				{
				}
				xmlElement = A_1.OwnerDocument.CreateElement(global::DevComponents.WpfDock.e.b);
				A_1.AppendChild(xmlElement);
				num = (short)461570048;
				short num4 = num;
				num = (short)1166344197;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00025444 File Offset: 0x00023644
		private void a(global::System.Windows.FrameworkElement A_0, global::System.Xml.XmlElement A_1)
		{
			int a_ = 18;
			short num = (short)945553413;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Xml.XmlElement xmlElement;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)258670593;
					if (num != 0)
					{
					}
					if (A_0.Parent is global::DevComponents.WpfDock.SplitPanel)
					{
						num = (short)137363459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EC;
				case 1:
					goto IL_1B7;
				case 2:
				{
					if (A_0.Name == null)
					{
						num = (short)254410753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1218707456;
					short num3 = num;
					xmlElement = A_1.OwnerDocument.CreateElement(global::DevComponents.WpfDock.e.e);
					num = (short)124649472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					xmlElement.SetAttribute(global::DevComponents.WpfDock.e.n, global::DevComponents.WpfDock.d.a(global::DevComponents.WpfDock.SplitPanel.GetRelativeSize(A_0)));
					num = (short)240123910;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1272780729;
					short num4 = num;
					num = (short)451680185;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11E;
					default:
						num = (short)1796538368;
						if (num != 0)
						{
						}
						num = (short)659947522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 6:
					goto IL_1EA;
				}
				IL_49:
				if (A_0.Name == "")
				{
					break;
				}
				num = (short)1981415428;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11E:
			throw new global::System.InvalidOperationException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("藐믒냔鿘꧚볜닞蓠铢諤闦苨껪臬諮鳰雲鯴菶\ud9f8飺闼雾洀朂┄栆漈⬊希缎紐稒愔䜖砘甚砜猞Ġ䜢䨤䈦娨ପ䌬䀮䔰ጲ崴嘶伸帺ᴼ儾⁀⹂⁄杆⡈㡊㹌♎㙐㵒ご㍖祘㩚㍜㭞䅠੢ᅤᑦ䥨ݪ౬᙮ṰٲŴ坶᩸᩺፼ᅾꖄꮊﺌ朗ﮖﮞ辠", a_));
			IL_1B7:
			goto IL_11E;
			IL_1EA:
			IL_1EC:
			xmlElement.SetAttribute(global::DevComponents.WpfDock.e.q, A_0.Name);
			A_1.AppendChild(xmlElement);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00025658 File Offset: 0x00023858
		private void a(global::DevComponents.WpfDock.DockWindow A_0, global::System.Xml.XmlElement A_1)
		{
			int a_ = 11;
			short num = (short)1880909496;
			short num2 = num;
			num = (short)940205752;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1DD:
				num = (short)189071368;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)398065664;
				if (num != 0)
				{
				}
				num = (short)2035875840;
				switch (num)
				{
				default:
					num = (short)1120927755;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			}
			global::System.Xml.XmlElement xmlElement;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_511;
				case 1:
					goto IL_40F;
				case 2:
					goto IL_584;
				case 3:
					num = (short)911409175;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_40F;
				case 5:
				{
					global::System.Windows.Size a_2 = new global::System.Windows.Size((A_0.LastAutoHideSize.Width > 0.0) ? A_0.LastAutoHideSize.Width : A_0.LastDockedSize.Width, (A_0.LastAutoHideSize.Height > 0.0) ? A_0.LastAutoHideSize.Height : A_0.LastDockedSize.Height);
					num = (short)846987277;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_161;
				case 7:
					xmlElement.SetAttribute(global::DevComponents.WpfDock.e.r, A_0.Visibility.ToString());
					num = (short)115736588;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1F7;
				case 9:
					if (A_0.Parent is global::DevComponents.WpfDock.SplitPanel)
					{
						num = (short)211353617;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F7;
				case 10:
					xmlElement.SetAttribute(global::DevComponents.WpfDock.e.i, global::DevComponents.WpfDock.DockSite.GetDock(A_0).ToString());
					num = (short)82182145;
					if (num != 0)
					{
					}
					num = (short)1196425217;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_FB;
					}
					continue;
				case 12:
					goto IL_2E3;
				case 13:
				{
					global::System.Windows.Size a_2;
					if (!a_2.IsEmpty)
					{
						num = (short)1922957333;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_511;
				}
				case 14:
				{
					global::DevComponents.WpfDock.FloatingWindow floatingWindow = A_0.GetDockSite().a(A_0);
					global::System.Windows.Rect floatingRect = new global::System.Windows.Rect(floatingWindow.Left, floatingWindow.Top, floatingWindow.Width, floatingWindow.Height);
					A_0.FloatingRect = floatingRect;
					num = (short)1125318660;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 15:
					if (!A_0.IsAutoHide)
					{
						num = (short)855638023;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E3;
				case 16:
					if (A_0.IsAutoHide)
					{
						num = (short)443744266;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_40F;
				case 17:
					goto IL_1C5;
				case 18:
					xmlElement.SetAttribute(global::DevComponents.WpfDock.e.k, global::DevComponents.WpfDock.d.a(A_0.FloatingRect));
					num = (short)803864578;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)1241251855;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (A_0.IsFloating)
					{
						num = (short)239927310;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)204341264;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
				{
					global::System.Windows.Size a_2;
					xmlElement.SetAttribute(global::DevComponents.WpfDock.e.m, global::DevComponents.WpfDock.d.a(a_2));
					num = (short)1176240128;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 22:
					if (A_0.Visibility != global::System.Windows.Visibility.Visible)
					{
						num = (short)230162451;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E3;
				case 23:
					if (A_0.Name == null)
					{
						num = (short)1202847750;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					xmlElement = A_1.OwnerDocument.CreateElement(global::DevComponents.WpfDock.e.d);
					num = (short)293011465;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (A_0.FloatingRect != global::DevComponents.WpfDock.DockWindow.a)
					{
						num = (short)801767442;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_586;
				}
				IL_FB:
				if (!(A_0.Name == ""))
				{
					num = (short)2046427139;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1F7:
				num = (short)138412032;
				short num4 = num;
				xmlElement.SetAttribute(global::DevComponents.WpfDock.e.q, A_0.Name);
				num = (short)1659437078;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E3:
				num = (short)835518484;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_40F:
				num = (short)1162412037;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_511:
				num = (short)700252184;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_161:
			throw new global::System.InvalidOperationException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("黉꓋ꯍ雑믓뗕돗跙뗛냝蓟跡鏣웥诧苩藫苭铯틱鯳郵\ud8f7꧹賻鋽槿瘁吃朅昇漉怋⸍缏怑㐓刕眗礙眛䤝䤟䰡䀣䤥弧洩師䄭䔯䈱ᐳ刵圷弹伻ḽ⸿ⵁぃ晅⁇⭉㩋⭍灏㱑㕓㭕㵗穙㵛ⵝ፟ୡͣࡥ൧๩䱫཭ṯᙱ味ή౷ॹ屻ችﮁﲇꪉﺏﲑﮓ뢗鍊뺝펟잡횣쾥즧용얫풭햯횱骳", a_));
			IL_1C5:
			xmlElement.SetAttribute(global::DevComponents.WpfDock.e.n, global::DevComponents.WpfDock.d.a(global::DevComponents.WpfDock.SplitPanel.GetRelativeSize(A_0)));
			goto IL_1DD;
			IL_584:
			IL_586:
			A_1.AppendChild(xmlElement);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00025BF4 File Offset: 0x00023DF4
		private void a(global::DevComponents.WpfDock.DockWindowGroup A_0, global::System.Xml.XmlElement A_1)
		{
			short num = (short)66650112;
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
				global::System.Xml.XmlElement xmlElement;
				for (;;)
				{
					IL_28:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_341;
					case 1:
					{
						num = (short)392691712;
						short num3 = num;
						xmlElement.SetAttribute(global::DevComponents.WpfDock.e.r, A_0.Visibility.ToString());
						num = (short)790888448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						try
						{
							num = (short)2035089410;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									object obj;
									if (obj is global::System.Windows.FrameworkElement)
									{
										num = (short)484442120;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_14F;
									}
									continue;
								case 3:
									num = (short)706150406;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									object obj;
									if (obj is global::DevComponents.WpfDock.DockWindow)
									{
										num = (short)1366556681;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1928724480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_277;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)875036675;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj = enumerator.Current;
									num = (short)314638340;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									object obj;
									this.a(obj as global::System.Windows.FrameworkElement, xmlElement);
									num = (short)168820737;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									object obj;
									this.a(obj as global::DevComponents.WpfDock.DockWindow, xmlElement);
									num = (short)1473183749;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1BA:
								num = (short)817692679;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_14F:
								goto IL_1BA;
							}
							IL_277:
							return;
						}
						finally
						{
							for (;;)
							{
								switch (0)
								{
								case 0:
									goto IL_299;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_286:
									switch (num2)
									{
									case 0:
										goto IL_33E;
									case 1:
										disposable.Dispose();
										num = (short)1041563648;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										if (disposable != null)
										{
											num = (short)1460011009;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_340;
									}
									break;
								}
								IL_299:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1907693297;
								short num4 = num;
								num = (short)1132795633;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1448869888;
									if (num != 0)
									{
									}
									num = (short)393871362;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_286;
								}
							}
							IL_33E:
							IL_340:;
						}
						goto IL_341;
					case 3:
						if (A_0.Visibility != global::System.Windows.Visibility.Visible)
						{
							num = (short)191627265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_341;
					}
					goto IL_3F;
					IL_341:
					enumerator = ((global::System.Collections.IEnumerable)A_0.Items).GetEnumerator();
					num = (short)1225850882;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3F:
				xmlElement = A_1.OwnerDocument.CreateElement(global::DevComponents.WpfDock.e.c);
				A_1.AppendChild(xmlElement);
				xmlElement.SetAttribute(global::DevComponents.WpfDock.e.n, global::DevComponents.WpfDock.d.a(global::DevComponents.WpfDock.SplitPanel.GetRelativeSize(A_0)));
				num = (short)1033502721;
				if (num != 0)
				{
				}
				num = (short)499384323;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00025FC4 File Offset: 0x000241C4
		public void LoadLayout(global::DevComponents.WpfDock.DockSite ds, string layout)
		{
			int a_ = 15;
			short num = (short)779091968;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)537395201;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Xml.XmlElement xmlElement;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_68;
						}
						continue;
					case 2:
					{
						global::System.Windows.Window window;
						window.Activate();
						num = (short)1779892224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)974716929;
						if (num != 0)
						{
						}
						num = (short)1136263168;
						short num3 = num;
						try
						{
							global::System.Collections.IEnumerator enumerator = xmlElement.ChildNodes.GetEnumerator();
							try
							{
								num = (short)242679809;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Xml.XmlElement xmlElement2;
										this.a(ds, xmlElement2);
										num = (short)725549061;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										switch (0)
										{
										case 0:
											goto IL_FB;
										}
										continue;
									case 2:
									{
										global::System.Xml.XmlElement xmlElement2;
										this.b(ds, xmlElement2);
										num = (short)171835403;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										global::System.Xml.XmlElement xmlElement2;
										if (xmlElement2.Name == global::DevComponents.WpfDock.e.g)
										{
											num = (short)1827471367;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1922367500;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlElement xmlElement2 = ((global::System.Xml.XmlNode)enumerator.Current) as global::System.Xml.XmlElement;
										num = (short)171311112;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
									{
										global::System.Xml.XmlElement xmlElement2;
										this.c(ds, xmlElement2);
										num = (short)263520260;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
									{
										global::System.Xml.XmlElement xmlElement2;
										if (xmlElement2.Name == global::DevComponents.WpfDock.e.b)
										{
											num = (short)1516109824;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)235077642;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
										goto IL_2AA;
									case 10:
									{
										global::System.Xml.XmlElement xmlElement2;
										if (xmlElement2.Name == global::DevComponents.WpfDock.e.f)
										{
											num = (short)1972436994;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1769668611;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
										num = (short)1612644361;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_11D:
									num = (short)1881341958;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_FB:
									goto IL_11D;
								}
								IL_2AA:
								goto IL_40C;
							}
							finally
							{
								for (;;)
								{
									switch (0)
									{
									case 0:
										goto IL_2CC;
									}
									global::System.IDisposable disposable;
									for (;;)
									{
										IL_2B9:
										switch (num2)
										{
										case 0:
											goto IL_371;
										case 1:
											disposable.Dispose();
											num = (short)1036517376;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											if (disposable != null)
											{
												num = (short)228458497;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_373;
										}
										break;
									}
									IL_2CC:
									disposable = (enumerator as global::System.IDisposable);
									num = (short)1340749489;
									short num4 = num;
									num = (short)617952945;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)267780096;
										if (num != 0)
										{
										}
										num = (short)1999306754;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_2B9;
									}
								}
								IL_371:
								IL_373:;
							}
						}
						finally
						{
							this.b = null;
						}
						goto IL_37C;
						IL_40C:
						global::System.Windows.Window window = global::System.Windows.Window.GetWindow(ds);
						num = (short)1226702853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_3CE;
					case 5:
					{
						global::System.Windows.Window window;
						if (window != null)
						{
							num = (short)40173570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 6:
						if (global::System.Xml.XmlConvert.ToInt32(xmlElement.GetAttribute(global::DevComponents.WpfDock.e.h)) > 1)
						{
							num = (short)344981508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.c = ds.IgnoreLoadLayoutElementNotFoundErrors;
						this.b = ds.GetDockWindows();
						num = (short)196673539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_68;
					IL_37C:
					global::System.Xml.XmlDocument xmlDocument;
					xmlElement = (xmlDocument.FirstChild as global::System.Xml.XmlElement);
					num = (short)2012545030;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_68:
					xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.LoadXml(layout);
					if (xmlDocument.FirstChild.Name != global::DevComponents.WpfDock.e.a)
					{
						break;
					}
					goto IL_37C;
				}
				throw new global::System.InvalidOperationException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("苍뇏ꯑ믓ꏕ곗龎蓛鏝곟싡諣觥鳧쫩藫胭탯蓱闳髵釷黹\udcfb飽濿瀁椃朅簇␉Ⰻ䨍缏焑缓䔕焗渙礛㸝䔟両䄣䬥䴧䐩堫อ崯嬱䜳䔵儷吹嬻ွ", a_));
				IL_3CE:
				throw new global::System.InvalidOperationException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("苍뇏ꯑ믓ꏕ곗龎蓛鏝곟싡諣觥鳧쫩藫胭탯臱至蛵裷闹軻諽旿昁␃瀅洇砉缋服缏簑㨓", a_));
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000264EC File Offset: 0x000246EC
		private void c(global::DevComponents.WpfDock.DockSite A_0, global::System.Xml.XmlElement A_1)
		{
			short num = (short)835649536;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)644874241;
				if (num != 0)
				{
				}
				global::System.Collections.IEnumerator enumerator = A_1.ChildNodes.GetEnumerator();
				try
				{
					num = (short)601686022;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::DevComponents.WpfDock.DockWindow dockWindow;
						global::System.Xml.XmlElement xmlElement;
						switch (num2)
						{
						case 0:
							num = (short)1230831631;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_10F;
						case 3:
							goto IL_380;
						case 4:
							num = (short)234618897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (dockWindow != null)
							{
								num = (short)250478605;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_CD;
							}
							continue;
						case 7:
							dockWindow.IsAutoHide = false;
							num = (short)1706688515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (!enumerator.MoveNext())
							{
								num = (short)551682052;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							xmlElement = (((global::System.Xml.XmlNode)enumerator.Current) as global::System.Xml.XmlElement);
							num = (short)1238695955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (dockWindow.IsAutoHide)
							{
								num = (short)265814023;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_380;
						case 10:
						{
							global::System.Windows.Controls.Dock dock;
							A_0.DockWindow(dockWindow.ParentGroup, global::DevComponents.WpfDock.DockSite.b(dock));
							num = (short)1464401921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
						{
							string attribute = xmlElement.GetAttribute(global::DevComponents.WpfDock.e.q);
							dockWindow = this.c(attribute);
							num = (short)1041825806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							num = (short)1550974992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							global::System.Windows.Controls.Dock dock = global::DevComponents.WpfDock.DockSite.GetDock(dockWindow);
							num = (short)659554322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							if (dockWindow != null)
							{
								num = (short)1379008532;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_380;
						case 15:
						{
							global::System.Windows.Controls.Dock dock;
							if (A_0.f(dockWindow.ParentGroup) != dock)
							{
								num = (short)1371078666;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10F;
						}
						case 16:
							if (dockWindow.ParentGroup.Items.Count == 1)
							{
								num = (short)1528365056;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10F;
						case 17:
							goto IL_3DC;
						case 18:
							if (dockWindow.ParentGroup != null)
							{
								num = (short)307494924;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10F;
						case 19:
							if (xmlElement.Name == global::DevComponents.WpfDock.e.d)
							{
								num = (short)2017132555;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 20:
							num = (short)1019215881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CD;
						IL_10F:
						A_0.a(dockWindow, true, global::DevComponents.WpfDock.eEventActionSource.Code, false, global::DevComponents.WpfDock.DockSite.GetDock(dockWindow));
						dockWindow.LastDock = global::DevComponents.WpfDock.DockSite.GetDock(dockWindow);
						dockWindow.m = true;
						dockWindow.IsAutoHide = true;
						dockWindow.m = false;
						num = (short)61407234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F8:
						num = (short)1311047688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_CD:
						goto IL_1F8;
						IL_380:
						dockWindow = this.a(xmlElement);
						num = (short)867434501;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3DC:;
				}
				finally
				{
					for (;;)
					{
						switch (0)
						{
						case 0:
							goto IL_3FE;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_3EB:
							switch (num2)
							{
							case 0:
								goto IL_4A8;
							case 1:
								disposable.Dispose();
								num = (short)1740701696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (disposable != null)
								{
									num = (short)1284308993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4AA;
							}
							break;
						}
						IL_3FE:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1308868794;
						short num3 = num;
						num = (short)385532090;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)42926080;
							if (num != 0)
							{
							}
							num = (short)2019557378;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_3EB;
						}
					}
					IL_4A8:
					IL_4AA:;
				}
				num = (short)1882062848;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000269EC File Offset: 0x00024BEC
		private void b(global::DevComponents.WpfDock.DockSite A_0, global::System.Xml.XmlElement A_1)
		{
			short num = (short)1866399744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.IEnumerator enumerator = A_1.ChildNodes.GetEnumerator();
				try
				{
					num = (short)607387650;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Xml.XmlElement xmlElement;
							global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup = this.c(xmlElement);
							num = (short)1322844164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1487863815;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.XmlElement xmlElement = ((global::System.Xml.XmlNode)enumerator.Current) as global::System.Xml.XmlElement;
							num = (short)2015232003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_79;
							}
							continue;
						case 3:
						{
							global::System.Xml.XmlElement xmlElement;
							if (xmlElement.Name == global::DevComponents.WpfDock.e.c)
							{
								num = (short)2000683008;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
							if (dockWindowGroup != null)
							{
								num = (short)318308361;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_150;
						}
						case 5:
							goto IL_150;
						case 6:
							goto IL_1AB;
						case 7:
							num = (short)216662022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_169;
						case 9:
						{
							global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
							A_0.FloatWindow(dockWindowGroup);
							num = (short)1369899013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_BA:
						num = (short)1351876609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_79:
						goto IL_BA;
						IL_150:
						num = (short)695926792;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_169:
					IL_1AB:;
				}
				finally
				{
					for (;;)
					{
						switch (0)
						{
						case 0:
							goto IL_1CD;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1BA:
							switch (num2)
							{
							case 0:
								goto IL_29A;
							case 1:
								disposable.Dispose();
								num = (short)1219035136;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (disposable != null)
								{
									num = (short)238944257;
									if (num != 0)
									{
									}
									num = (short)610992129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_29C;
							}
							break;
						}
						IL_1CD:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1513606575;
						short num3 = num;
						num = (short)1330826671;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)685375488;
							if (num != 0)
							{
							}
							num = (short)949288962;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1BA;
						}
					}
					IL_29A:
					IL_29C:;
				}
				num = (short)2108424192;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00026CDC File Offset: 0x00024EDC
		private global::DevComponents.WpfDock.DockWindowGroup c(global::System.Xml.XmlElement A_0)
		{
			short num = (short)1934491649;
			if (num != 0)
			{
			}
			num = (short)1567920005;
			short num2 = num;
			num = (short)2006290309;
			switch (num2 == num)
			{
			default:
			{
				num = (short)44630016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1708457984;
			if (num != 0)
			{
			}
			return this.a(null, A_0);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00026D90 File Offset: 0x00024F90
		private void a(global::DevComponents.WpfDock.DockSite A_0, global::System.Xml.XmlElement A_1)
		{
			short num = (short)1855782912;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::DevComponents.WpfDock.SplitPanel splitPanel;
				bool flag;
				global::System.Windows.Controls.Dock d;
				double d2;
				global::System.Windows.Controls.Orientation orientation;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					object content;
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
						{
							num = (short)1796631330;
							short num3 = num;
							num = (short)734423842;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_BC;
							default:
								num = (short)2121990144;
								if (num != 0)
								{
								}
								if (splitPanel.Children.Count == 0)
								{
									num = (short)427360267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_352;
							}
							break;
						}
						case 1:
							if (A_1.HasAttribute(global::DevComponents.WpfDock.e.o))
							{
								num = (short)984481797;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2FF;
						case 2:
							num = (short)416940033;
							if (num != 0)
							{
							}
							if (global::System.Xml.XmlConvert.ToBoolean(A_1.GetAttribute(global::DevComponents.WpfDock.e.o)))
							{
								num = (short)735445000;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2FF;
						case 3:
							goto IL_22A;
						case 4:
							goto IL_22A;
						case 5:
						{
							num = (short)1172242432;
							short num4 = num;
							num = (short)1811546114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							if (flag)
							{
								num = (short)290717708;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C4;
						case 7:
							if (flag)
							{
								num = (short)2130706441;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							A_0.SplitPanels.Add(splitPanel);
							num = (short)2034434052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							flag = true;
							num = (short)614268938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							content = A_0.Content;
							A_0.Content = splitPanel;
							num = (short)1513422851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_2FF;
						case 11:
							num = (short)2079391750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_165;
						}
						goto IL_62;
						IL_22A:
						this.b(splitPanel, A_1);
						num = (short)508493824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2FF:
						global::DevComponents.WpfDock.DockSite.SetDock(splitPanel, d);
						global::DevComponents.WpfDock.DockSite.SetDockSize(splitPanel, d2);
						splitPanel.Orientation = orientation;
						content = null;
						num = (short)965672967;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_165:
					A_0.Content = content;
					return;
					IL_2C4:
					A_0.SplitPanels.Remove(splitPanel);
					return;
					IL_352:
					splitPanel.UpdateAutoVisibility();
					return;
				}
				}
				IL_62:
				splitPanel = new global::DevComponents.WpfDock.SplitPanel();
				d = (global::System.Windows.Controls.Dock)global::System.Enum.Parse(typeof(global::System.Windows.Controls.Dock), A_1.GetAttribute(global::DevComponents.WpfDock.e.i));
				d2 = global::System.Xml.XmlConvert.ToDouble(A_1.GetAttribute(global::DevComponents.WpfDock.e.l));
				orientation = (global::System.Windows.Controls.Orientation)global::System.Enum.Parse(typeof(global::System.Windows.Controls.Orientation), A_1.GetAttribute(global::DevComponents.WpfDock.e.p));
				flag = false;
				IL_BC:
				num = (short)1516634113;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000270F8 File Offset: 0x000252F8
		private void c(global::DevComponents.WpfDock.SplitPanel A_0, global::System.Xml.XmlElement A_1)
		{
			global::DevComponents.WpfDock.SplitPanel splitPanel = new global::DevComponents.WpfDock.SplitPanel();
			global::System.Windows.Size d = global::DevComponents.WpfDock.d.b(A_1.GetAttribute(global::DevComponents.WpfDock.e.n));
			global::DevComponents.WpfDock.SplitPanel.SetRelativeSize(splitPanel, d);
			global::System.Windows.Controls.Orientation orientation = (global::System.Windows.Controls.Orientation)global::System.Enum.Parse(typeof(global::System.Windows.Controls.Orientation), A_1.GetAttribute(global::DevComponents.WpfDock.e.p));
			splitPanel.Orientation = orientation;
			A_0.Children.Add(splitPanel);
			this.b(splitPanel, A_1);
			short num;
			if (splitPanel.Children.Count != 0)
			{
				num = (short)2100112043;
				short num2 = num;
				num = (short)1714170539;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)294649857;
					if (num != 0)
					{
					}
					num = (short)1388642304;
					if (num != 0)
					{
					}
					splitPanel.UpdateAutoVisibility();
					return;
				}
			}
			num = (short)650313728;
			short num3 = num;
			A_0.Children.Remove(splitPanel);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0002721C File Offset: 0x0002541C
		private void b(global::DevComponents.WpfDock.SplitPanel A_0, global::System.Xml.XmlElement A_1)
		{
			short num = (short)1140456642;
			short num2 = num;
			num = (short)977206466;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1645215744;
				short num3 = num;
				break;
			}
			}
			num = (short)1760559105;
			if (num != 0)
			{
			}
			num = (short)371916800;
			if (num != 0)
			{
			}
			num = (short)1179648000;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				global::System.Collections.IEnumerator enumerator = A_1.ChildNodes.GetEnumerator();
				try
				{
					num = (short)1064108040;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
						{
							global::System.Windows.FrameworkElement frameworkElement;
							if (frameworkElement != null)
							{
								num = (short)1114963983;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							global::System.Xml.XmlElement xmlElement;
							if (xmlElement.Name == global::DevComponents.WpfDock.e.c)
							{
								num = (short)1299841030;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1750335495;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::System.Xml.XmlElement xmlElement;
							global::System.Windows.FrameworkElement frameworkElement = this.b(xmlElement);
							num = (short)1798045697;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)1494220813;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::System.Xml.XmlElement xmlElement;
							this.a(A_0, xmlElement);
							num = (short)356057088;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							global::System.Xml.XmlElement xmlElement;
							if (xmlElement.Name == global::DevComponents.WpfDock.e.d)
							{
								num = (short)868614156;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)130809872;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							switch (0)
							{
							case 0:
								goto IL_13B;
							}
							continue;
						case 9:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)174456837;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.XmlElement xmlElement = ((global::System.Xml.XmlNode)enumerator.Current) as global::System.Xml.XmlElement;
							num = (short)27262994;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
						{
							global::DevComponents.WpfDock.DockWindow dockWindow;
							this.a(dockWindow);
							A_0.Children.Add(dockWindow);
							num = (short)1972633610;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
						{
							global::System.Xml.XmlElement xmlElement;
							global::DevComponents.WpfDock.DockWindow dockWindow = this.a(xmlElement);
							num = (short)1899495441;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							goto IL_3F2;
						case 14:
						{
							global::System.Xml.XmlElement xmlElement;
							this.c(A_0, xmlElement);
							num = (short)814219283;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
						{
							global::System.Windows.FrameworkElement frameworkElement;
							A_0.Children.Add(frameworkElement);
							num = (short)61800450;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
						{
							global::System.Xml.XmlElement xmlElement;
							if (xmlElement.Name == global::DevComponents.WpfDock.e.e)
							{
								num = (short)877527044;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 17:
						{
							global::DevComponents.WpfDock.DockWindow dockWindow;
							if (dockWindow != null)
							{
								num = (short)1634271243;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 18:
						{
							global::System.Xml.XmlElement xmlElement;
							if (xmlElement.Name == global::DevComponents.WpfDock.e.b)
							{
								num = (short)1673134094;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1316618243;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_219:
						num = (short)278331401;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_13B:
						goto IL_219;
					}
					IL_3F2:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_411;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_3FE:
						switch (num4)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)1338638338;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_468;
						case 1:
							goto IL_466;
						case 2:
							disposable.Dispose();
							num = (short)2046099457;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_411;
					}
					IL_466:
					IL_468:
					break;
					IL_411:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1241776128;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_3FE;
				}
				break;
			}
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000276B0 File Offset: 0x000258B0
		private void a(global::DevComponents.WpfDock.DockWindow A_0)
		{
			short num = (short)1247215623;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::DevComponents.WpfDock.SplitPanel splitPanel;
					this.a(splitPanel);
					num = (short)1821704200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (dockWindowGroup.Items.Count == 0)
					{
						num = (short)1552351241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_251;
				case 2:
					if (A_0.Parent is global::DevComponents.WpfDock.DockWindowGroup)
					{
						num = (short)1629093898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1031274502;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					global::DevComponents.WpfDock.SplitPanel splitPanel = A_0.Parent as global::DevComponents.WpfDock.SplitPanel;
					splitPanel.Children.Remove(A_0);
					num = (short)125698053;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					A_0.IsAutoHide = false;
					num = (short)719978507;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					IL_1CE:
					global::DevComponents.WpfDock.SplitPanel splitPanel;
					if (splitPanel.Children.Count == 0)
					{
						num = (short)1570701312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_251;
				}
				case 6:
					if (A_0.Parent is global::DevComponents.WpfDock.SplitPanel)
					{
						num = (short)382599169;
						if (num != 0)
						{
						}
						num = (short)152240131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_251;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 8:
				{
					num = (short)860291072;
					short num3 = num;
					goto IL_251;
				}
				case 9:
					goto IL_24C;
				case 10:
					dockWindowGroup = (A_0.Parent as global::DevComponents.WpfDock.DockWindowGroup);
					dockWindowGroup.Items.Remove(A_0);
					num = (short)2045313025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_E9;
				}
				IL_55:
				if (A_0.IsAutoHide)
				{
					num = (short)685506564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E9:
				num = (short)79298562;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_251:
				num = (short)2028323804;
				short num4 = num;
				num = (short)2003813340;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1CE;
				default:
					goto IL_286;
				}
			}
			IL_24C:
			this.a(dockWindowGroup);
			return;
			IL_286:
			num = (short)1833107456;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00027958 File Offset: 0x00025B58
		private void a(global::DevComponents.WpfDock.DockWindowGroup A_0)
		{
			short num = (short)1223360514;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfDock.SplitPanel splitPanel;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					splitPanel = (A_0.Parent as global::DevComponents.WpfDock.SplitPanel);
					splitPanel.Children.Remove(A_0);
					num = (short)1282998278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 3:
					if (A_0.Parent is global::DevComponents.WpfDock.FloatingWindow)
					{
						num = (short)1027080192;
						short num3 = num;
						num = (short)1842085893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					goto IL_1A1;
				case 5:
					A_0.GetDockSite().Detach(A_0);
					num = (short)681902081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)244731189;
					short num4 = num;
					num = (short)227102005;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)916586496;
						if (num != 0)
						{
						}
						if (splitPanel.Children.Count == 0)
						{
							num = (short)1361903620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				}
				IL_40:
				if (A_0.Parent is global::DevComponents.WpfDock.SplitPanel)
				{
					num = (short)1444806657;
					if (num != 0)
					{
					}
					num = (short)1166147584;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)419037187;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_1A1:
			this.a(splitPanel);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00027B34 File Offset: 0x00025D34
		private void a(global::DevComponents.WpfDock.SplitPanel A_0)
		{
			short num = (short)1218183174;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfDock.DockSite dockSite;
			global::DevComponents.WpfDock.SplitPanel splitPanel;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F3;
				case 1:
					num = (short)2014052353;
					if (num != 0)
					{
					}
					dockSite.SplitPanels.Remove(A_0);
					num = (short)1170800642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_121;
				case 3:
				{
					splitPanel = (A_0.Parent as global::DevComponents.WpfDock.SplitPanel);
					splitPanel.Children.Remove(A_0);
					num = (short)1369498927;
					short num3 = num;
					num = (short)1244521775;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_253;
					default:
						num = (short)2125791232;
						if (num != 0)
						{
						}
						num = (short)941359113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (dockSite.SplitPanels.Contains(A_0))
					{
						num = (short)1928724481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					if (dockSite.Content == A_0)
					{
						num = (short)115671040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)966656004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 7:
					goto IL_253;
				case 8:
					dockSite = (A_0.Parent as global::DevComponents.WpfDock.DockSite);
					num = (short)969539589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (splitPanel.Children.Count == 0)
					{
						num = (short)1204748298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					goto IL_1C9;
				}
				IL_50:
				num = (short)1134297088;
				short num4 = num;
				if (A_0.Parent is global::DevComponents.WpfDock.SplitPanel)
				{
					num = (short)1133641731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1228537863;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_253:
				if (!(A_0.Parent is global::DevComponents.WpfDock.DockSite))
				{
					return;
				}
				num = (short)1686306824;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F3:
			dockSite.Content = null;
			return;
			IL_121:
			return;
			IL_1C9:
			this.a(splitPanel);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00027DC0 File Offset: 0x00025FC0
		private global::System.Windows.FrameworkElement b(global::System.Xml.XmlElement A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::System.Windows.Size size;
			global::System.Windows.FrameworkElement frameworkElement;
			string attribute;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1319763968;
					short num3 = num2;
					if (!global::DevComponents.WpfDock.i.a(size))
					{
						num2 = (short)575864838;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return frameworkElement;
				}
				case 1:
					num2 = (short)1840644097;
					if (num2 != 0)
					{
					}
					num2 = (short)1846542336;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					size = global::DevComponents.WpfDock.d.b(A_0.GetAttribute(global::DevComponents.WpfDock.e.n));
					num2 = (short)1916600324;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)132378515;
					short num4 = num2;
					num2 = (short)1364193171;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1CD;
					default:
						num2 = (short)558432256;
						if (num2 != 0)
						{
						}
						if (A_0.HasAttribute(global::DevComponents.WpfDock.e.n))
						{
							num2 = (short)928120834;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_136;
					}
					break;
				}
				case 4:
					goto IL_136;
				case 5:
					return frameworkElement;
				case 6:
					goto IL_1CD;
				case 7:
					if (frameworkElement != null)
					{
						num2 = (short)1253048321;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return frameworkElement;
				}
				goto IL_30;
				IL_136:
				frameworkElement = this.d(attribute);
				num2 = (short)6619143;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1CD:
				global::DevComponents.WpfDock.SplitPanel.SetRelativeSize(frameworkElement, size);
				num2 = (short)1334968325;
				num = (int)((global::System.IntPtr)num2);
			}
			return frameworkElement;
			IL_30:
			attribute = A_0.GetAttribute(global::DevComponents.WpfDock.e.q);
			size = default(global::System.Windows.Size);
			num2 = (short)1602813955;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00027FBC File Offset: 0x000261BC
		private global::System.Windows.FrameworkElement d(string A_0)
		{
			int a_ = 12;
			short num = (short)570294272;
			short num2 = num;
			num = (short)1144540381;
			short num3 = num;
			num = (short)1320963293;
			switch (num3 == num)
			{
			}
			num = (short)558170113;
			if (num != 0)
			{
			}
			num = (short)1807155200;
			if (num != 0)
			{
			}
			throw new global::System.Exception(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鿊ꗌ꫎뻒냔ꏖ뇘듚맜￞軠釢엤裦駨軪鿬軮藰髲髴駶\ud9f8鋺軼\udffe漀氂焄✆怈昊紌挎琐縒瀔礖洘縚礜ㄞ", a_));
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00028080 File Offset: 0x00026280
		private global::DevComponents.WpfDock.DockWindow a(global::System.Xml.XmlElement A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_74;
			}
			int num;
			global::DevComponents.WpfDock.DockWindow dockWindow;
			short num2;
			global::System.Windows.Size size;
			string attribute;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (dockWindow == null)
					{
						num2 = (short)1052180497;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_451;
				case 1:
					if (dockWindow != null)
					{
						num2 = (short)959315989;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_284;
				case 2:
					goto IL_1C3;
				case 3:
					goto IL_284;
				case 4:
					if (A_0.HasAttribute(global::DevComponents.WpfDock.e.n))
					{
						num2 = (short)535560212;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_182;
				case 5:
					goto IL_27F;
				case 6:
					if (A_0.HasAttribute(global::DevComponents.WpfDock.e.r))
					{
						num2 = (short)1397948428;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					dockWindow.Visibility = global::System.Windows.Visibility.Visible;
					num2 = (short)578289666;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_1C3;
				case 8:
					goto IL_182;
				case 9:
					goto IL_307;
				case 10:
					goto IL_374;
				case 11:
					goto IL_302;
				case 12:
					dockWindow.Visibility = (global::System.Windows.Visibility)global::System.Enum.Parse(typeof(global::System.Windows.Visibility), A_0.GetAttribute(global::DevComponents.WpfDock.e.r));
					num2 = (short)1119092743;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (!global::DevComponents.WpfDock.i.a(size))
					{
						num2 = (short)967049230;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_284;
				case 14:
					global::DevComponents.WpfDock.SplitPanel.SetRelativeSize(dockWindow, size);
					num2 = (short)2074738691;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					goto IL_141;
				case 16:
					if (A_0.HasAttribute(global::DevComponents.WpfDock.e.m))
					{
						num2 = (short)1520435224;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return dockWindow;
				case 17:
					num2 = (short)1898119191;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					dockWindow.FloatingRect = global::DevComponents.WpfDock.d.a(A_0.GetAttribute(global::DevComponents.WpfDock.e.k));
					num2 = (short)515899402;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
				{
					if (!A_0.HasAttribute(global::DevComponents.WpfDock.e.k))
					{
						goto IL_374;
					}
					num2 = (short)59363027;
					short num3 = num2;
					num2 = (short)1532874451;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_141;
					default:
						num2 = (short)617414656;
						if (num2 != 0)
						{
						}
						num2 = (short)197918738;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 20:
				{
					num2 = (short)243597312;
					short num4 = num2;
					size = global::DevComponents.WpfDock.d.b(A_0.GetAttribute(global::DevComponents.WpfDock.e.n));
					num2 = (short)2099314696;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 21:
					num2 = (short)872873997;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (A_0.HasAttribute(global::DevComponents.WpfDock.e.i))
					{
						num2 = (short)801439759;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_307;
				case 23:
					if (this.c)
					{
						num2 = (short)245366795;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_451;
				case 24:
					num2 = (short)311164929;
					if (num2 != 0)
					{
					}
					dockWindow.LastAutoHideSize = global::DevComponents.WpfDock.d.b(A_0.GetAttribute(global::DevComponents.WpfDock.e.m));
					num2 = (short)1638596613;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_74;
				IL_141:
				global::DevComponents.WpfDock.DockSite.SetDock(dockWindow, (global::System.Windows.Controls.Dock)global::System.Enum.Parse(typeof(global::System.Windows.Controls.Dock), A_0.GetAttribute(global::DevComponents.WpfDock.e.i)));
				num2 = (short)665780233;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_182:
				dockWindow = this.c(attribute);
				num2 = (short)592773120;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C3:
				num2 = (short)1071382547;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_284:
				num2 = (short)1607270406;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_307:
				num2 = (short)1734934544;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_374:
				num2 = (short)1270415382;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_451:
				num2 = (short)1506017281;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_27F:
			return dockWindow;
			IL_302:
			return null;
			IL_74:
			attribute = A_0.GetAttribute(global::DevComponents.WpfDock.e.q);
			size = default(global::System.Windows.Size);
			num2 = (short)1639645188;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00028564 File Offset: 0x00026764
		private global::DevComponents.WpfDock.DockWindow c(string A_0)
		{
			int a_ = 2;
			short num = (short)1544290305;
			if (num != 0)
			{
			}
			num = (short)1433927680;
			short num2 = num;
			num = (short)1768725975;
			short num3 = num;
			num = (short)2079301079;
			global::DevComponents.WpfDock.DockWindow result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1941831680;
				if (num != 0)
				{
				}
				using (global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow>.Enumerator enumerator = this.b.GetEnumerator())
				{
					num = (short)1047330818;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1831600131;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::DevComponents.WpfDock.DockWindow dockWindow = enumerator.Current;
							num = (short)1331232773;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_1C5;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_119;
							}
							continue;
						case 3:
							num = (short)1121845249;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_1AB;
						case 5:
						{
							global::DevComponents.WpfDock.DockWindow dockWindow;
							if (dockWindow.Name == A_0)
							{
								num = (short)1448148998;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
						{
							global::DevComponents.WpfDock.DockWindow dockWindow;
							result = dockWindow;
							num = (short)796196868;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_11B:
						num = (short)74973184;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_119:
						goto IL_11B;
					}
					IL_1AB:
					break;
					IL_1C5:
					goto IL_B0;
				}
				break;
				IL_B0:
				global::System.Diagnostics.Trace.WriteLine(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("藀곂ꛄ곆黈ꋊꏌꯎ뻐ꓒ맖룘뛚룜믞쇠쓢", a_) + A_0 + global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("ꛄ꣆볈ꟊ꧌뿐볒ꇔ믘뻚﷜맞軠離诤菦짨鳪藬蛮鷰雲헴鯶雸髺駼雾漀搂┄欆栈爊戌税攐", a_));
				return null;
			}
			return result;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0002875C File Offset: 0x0002695C
		private global::DevComponents.WpfDock.DockWindowGroup a(global::DevComponents.WpfDock.SplitPanel A_0, global::System.Xml.XmlElement A_1)
		{
			short num = (short)831258624;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
				global::System.Windows.Size d;
				for (;;)
				{
					IL_28:
					bool flag;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						num = (short)1568604161;
						if (num != 0)
						{
						}
						global::DevComponents.WpfDock.SplitPanel.SetRelativeSize(dockWindowGroup, d);
						A_0.Children.Add(dockWindowGroup);
						num = (short)652476422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (dockWindowGroup.Items.Count == 0 && flag)
						{
							num = (short)1371078669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1148846091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return dockWindowGroup;
					case 3:
						goto IL_5B6;
					case 4:
						goto IL_653;
					case 5:
						if (A_1.HasAttribute(global::DevComponents.WpfDock.e.r))
						{
							num = (short)1905393672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_592;
					case 6:
						goto IL_1C3;
					case 7:
						A_0.Children.Remove(dockWindowGroup);
						num = (short)1472528387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						dockWindowGroup.Visibility = (global::System.Windows.Visibility)global::System.Enum.Parse(typeof(global::System.Windows.Visibility), A_1.GetAttribute(global::DevComponents.WpfDock.e.r));
						num = (short)391512073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_653;
					case 10:
						dockWindowGroup.s();
						num = (short)1839005712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						num = (short)1119682560;
						short num3 = num;
						if (dockWindowGroup.SelectedItem == null)
						{
							num = (short)1630863370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dockWindowGroup;
					}
					case 12:
						if (A_0 != null)
						{
							num = (short)2105868288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C3;
					case 13:
						num = (short)1961033743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						try
						{
							num = (short)35651591;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::DevComponents.WpfDock.DockWindow dockWindow;
									this.a(dockWindow);
									dockWindowGroup.Items.Add(dockWindow);
									num = (short)660733962;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::System.Windows.FrameworkElement frameworkElement;
									dockWindowGroup.Items.Add(frameworkElement);
									num = (short)1939406859;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Xml.XmlElement xmlElement;
									global::System.Windows.FrameworkElement frameworkElement = this.b(xmlElement);
									num = (short)1497169929;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Xml.XmlElement xmlElement;
									if (xmlElement.Name == global::DevComponents.WpfDock.e.e)
									{
										num = (short)1761607683;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)1182924808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)610205701;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.XmlElement xmlElement = ((global::System.Xml.XmlNode)enumerator.Current) as global::System.Xml.XmlElement;
									num = (short)968228876;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_2C9;
									}
									continue;
								case 8:
									goto IL_4C9;
								case 9:
								{
									global::System.Windows.FrameworkElement frameworkElement;
									if (frameworkElement != null)
									{
										num = (short)1514471425;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
								{
									global::System.Xml.XmlElement xmlElement;
									if (xmlElement.Name == global::DevComponents.WpfDock.e.d)
									{
										num = (short)282066957;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)491585540;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
								{
									global::System.Xml.XmlElement xmlElement;
									global::DevComponents.WpfDock.DockWindow dockWindow = this.a(xmlElement);
									num = (short)618463246;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									global::DevComponents.WpfDock.DockWindow dockWindow;
									if (dockWindow != null)
									{
										num = (short)1121910784;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag = true;
									num = (short)1013579778;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_359:
								num = (short)247791622;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2C9:
								goto IL_359;
							}
							IL_4C9:
							goto IL_5D5;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_4EB;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_4D8:
								switch (num2)
								{
								case 0:
									goto IL_58F;
								case 1:
									disposable.Dispose();
									num = (short)1185939456;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)1246756865;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_591;
								}
								goto IL_4EB;
							}
							IL_58F:
							goto IL_591;
							IL_4EB:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1295703315;
							short num4 = num;
							num = (short)1792662803;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_591:
								break;
							default:
								num = (short)1342898176;
								if (num != 0)
								{
								}
								num = (short)2074279938;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_4D8;
							}
						}
						goto IL_592;
						IL_5D5:
						num = (short)142278657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (A_0 != null)
						{
							num = (short)1036189703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B6;
					case 16:
						return dockWindowGroup;
					}
					goto IL_73;
					IL_1C3:
					num = (short)542244869;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_592:
					dockWindowGroup.Visibility = global::System.Windows.Visibility.Visible;
					num = (short)594935812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B6:
					dockWindowGroup = null;
					num = (short)1514864642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_653:
					flag = false;
					enumerator = A_1.ChildNodes.GetEnumerator();
					num = (short)1725038606;
					num2 = (int)((global::System.IntPtr)num);
				}
				return dockWindowGroup;
				IL_73:
				dockWindowGroup = new global::DevComponents.WpfDock.DockWindowGroup();
				d = global::DevComponents.WpfDock.d.b(A_1.GetAttribute(global::DevComponents.WpfDock.e.n));
				num = (short)1503723532;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00028E08 File Offset: 0x00027008
		private static global::System.Windows.Size b(string A_0)
		{
			short num = (short)1652599535;
			short num2 = num;
			num = (short)342862575;
			switch (num2 == num)
			{
			}
			num = (short)1682702337;
			if (num != 0)
			{
			}
			num = (short)1959854080;
			if (num != 0)
			{
			}
			num = (short)1300627456;
			short num3 = num;
			string[] array = A_0.Split(new char[]
			{
				','
			});
			return new global::System.Windows.Size(global::System.Xml.XmlConvert.ToDouble(array[0]), global::System.Xml.XmlConvert.ToDouble(array[1]));
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00028ED8 File Offset: 0x000270D8
		private static string a(global::System.Windows.Size A_0)
		{
			int a_ = 9;
			short num = (short)2138428090;
			short num2 = num;
			num = (short)1021432506;
			switch (num2 == num)
			{
			}
			num = (short)1989410817;
			if (num != 0)
			{
			}
			num = (short)2011103232;
			if (num != 0)
			{
			}
			num = (short)2065039360;
			short num3 = num;
			return global::System.Xml.XmlConvert.ToString(A_0.Width) + global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("", a_) + global::System.Xml.XmlConvert.ToString(A_0.Height);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00028FB4 File Offset: 0x000271B4
		private static global::System.Windows.Rect a(string A_0)
		{
			short num = (short)1156567444;
			short num2 = num;
			num = (short)1467273620;
			switch (num2 == num)
			{
			}
			num = (short)660013056;
			if (num != 0)
			{
			}
			num = (short)60293121;
			if (num != 0)
			{
			}
			num = (short)1659568128;
			short num3 = num;
			string[] array = A_0.Split(new char[]
			{
				','
			});
			return new global::System.Windows.Rect(global::System.Xml.XmlConvert.ToDouble(array[0]), global::System.Xml.XmlConvert.ToDouble(array[1]), global::System.Xml.XmlConvert.ToDouble(array[2]), global::System.Xml.XmlConvert.ToDouble(array[3]));
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00029094 File Offset: 0x00027294
		private static string a(global::System.Windows.Rect A_0)
		{
			int a_ = 9;
			short num = (short)1622407932;
			short num2 = num;
			num = (short)555481852;
			switch (num2 == num)
			{
			}
			num = (short)1435762688;
			if (num != 0)
			{
			}
			num = (short)2059993089;
			if (num != 0)
			{
			}
			num = (short)641794048;
			short num3 = num;
			return string.Concat(new string[]
			{
				global::System.Xml.XmlConvert.ToString(A_0.X),
				global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("", a_),
				global::System.Xml.XmlConvert.ToString(A_0.Y),
				global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("", a_),
				global::System.Xml.XmlConvert.ToString(A_0.Width),
				global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("", a_),
				global::System.Xml.XmlConvert.ToString(A_0.Height)
			});
		}

		// Token: 0x040000BE RID: 190
		private const int a = 1;

		// Token: 0x040000BF RID: 191
		private global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindow> b;

		// Token: 0x040000C0 RID: 192
		private bool c;
	}
}
