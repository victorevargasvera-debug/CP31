using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon.KeyTips
{
	// Token: 0x020000CC RID: 204
	internal class AppMenuKeyTipRenderer : global::DevComponents.WpfRibbon.KeyTips.ButtonPopupKeyRenderer
	{
		// Token: 0x060008A7 RID: 2215 RVA: 0x000C38B4 File Offset: 0x000C1AB4
		public override void Render(global::System.Windows.Media.DrawingContext dc, object elem, global::DevComponents.WpfRibbon.KeyTipRenderInfo info)
		{
			int a_ = 15;
			short num = (short)1439236096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
				for (;;)
				{
					IL_30:
					global::System.Windows.Controls.ItemsControl itemsControl;
					global::System.Windows.Size renderSize;
					int num4;
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.UIElement uielement;
						this.ProcessPanel(uielement as global::System.Windows.Controls.Panel, dc, info, itemsControl, renderSize);
						num = (short)674103315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_C3C;
					case 2:
						num = (short)332660744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)519176209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_11B;
					case 5:
						try
						{
							num = (short)1361117188;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)691208200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Windows.UIElement uielement2;
									if (uielement2 != null)
									{
										num = (short)1305739266;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)568262662;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Windows.UIElement uielement2;
									global::System.Windows.Size renderSize2;
									this.ProcessPanel(uielement2 as global::System.Windows.Controls.Panel, dc, info, applicationMenu.Popup, renderSize2);
									num = (short)1805582349;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_2EF;
									}
									continue;
								case 5:
								{
									global::System.Windows.UIElement uielement2;
									if (uielement2 is global::System.Windows.Controls.Panel)
									{
										num = (short)452722691;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.Size renderSize2;
									this.ProcessUIElement(uielement2, dc, info, applicationMenu.Popup, renderSize2);
									num = (short)574619655;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::System.Windows.UIElement uielement2;
									if (uielement2.Visibility == global::System.Windows.Visibility.Visible)
									{
										num = (short)1301741577;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_4A8;
								case 9:
									num = (short)1622081547;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::System.Collections.Generic.IEnumerator<object> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)395902976;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement2 = enumerator.Current as global::System.Windows.UIElement;
									num = (short)1188495361;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::System.Windows.UIElement uielement2;
									if (uielement2.IsVisible)
									{
										num = (short)375193612;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									num = (short)1018167301;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_452:
								num = (short)742588426;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2EF:
								goto IL_452;
							}
							IL_4A8:
							return;
						}
						finally
						{
							num = (short)1446838272;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<object> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4E1;
									}
									continue;
								case 1:
									goto IL_519;
								case 2:
									enumerator.Dispose();
									num = (short)312147969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4E1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1698562050;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_519:;
						}
						goto IL_51C;
					case 6:
						goto IL_C3E;
					case 7:
						return;
					case 8:
					{
						global::System.Windows.UIElement uielement;
						if (uielement.IsVisible)
						{
							num = (short)1131020306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3E;
					}
					case 9:
						num = (short)687669252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::System.Windows.UIElement uielement;
						if (uielement != null)
						{
							num = (short)2126839811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3E;
					}
					case 11:
					{
						global::System.Collections.Generic.IEnumerator<object> enumerator;
						try
						{
							num = (short)1022427140;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1077149697;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Windows.UIElement uielement3;
									if (uielement3.Visibility == global::System.Windows.Visibility.Visible)
									{
										num = (short)2126249986;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)803864583;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Windows.UIElement uielement3;
									if (uielement3 is global::System.Windows.Controls.Panel)
									{
										num = (short)744357899;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.Size renderSize2;
									this.ProcessUIElement(uielement3, dc, info, applicationMenu.Popup, renderSize2);
									num = (short)1867120653;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_60E;
									}
									continue;
								case 5:
									num = (short)321388547;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1813118985;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement3 = enumerator.Current as global::System.Windows.UIElement;
									num = (short)762445834;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::System.Windows.UIElement uielement3;
									if (uielement3.IsVisible)
									{
										num = (short)396886021;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_7D1;
								case 9:
									num = (short)1437073416;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::System.Windows.UIElement uielement3;
									if (uielement3 != null)
									{
										num = (short)1348141056;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
								{
									global::System.Windows.Size renderSize2;
									global::System.Windows.UIElement uielement3;
									this.ProcessPanel(uielement3 as global::System.Windows.Controls.Panel, dc, info, applicationMenu.Popup, renderSize2);
									num = (short)17104908;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_610:
								num = (short)1073020934;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_60E:
								goto IL_610;
							}
							IL_7D1:
							goto IL_221;
						}
						finally
						{
							num = (short)85852160;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_7EC;
								case 1:
									goto IL_88E;
								case 2:
									enumerator.Dispose();
									num = (short)1498349569;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_809;
								IL_7EC:
								switch (0)
								{
								case 0:
								{
									IL_809:
									num = (short)1177769773;
									short num3 = num;
									num = (short)674518829;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_7EC;
									default:
										num = (short)1230307328;
										if (num != 0)
										{
										}
										if (enumerator == null)
										{
											goto IL_890;
										}
										num = (short)1747648514;
										num2 = (int)((global::System.IntPtr)num);
										break;
									}
									break;
								}
								}
							}
							IL_88E:
							IL_890:;
						}
						goto IL_891;
						IL_221:
						enumerator = applicationMenu.AppItems.GetEnumerator();
						num = (short)756809733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						try
						{
							num = (short)234094602;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1745879052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)78446600;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.IEnumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)444661765;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement4 = enumerator2.Current as global::System.Windows.UIElement;
									num = (short)785252358;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Windows.UIElement uielement4;
									if (uielement4.IsVisible)
									{
										num = (short)58327041;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)753467405;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::System.Windows.UIElement uielement4;
									if (uielement4 != null)
									{
										num = (short)1497104384;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::System.Windows.UIElement uielement4;
									if (uielement4 is global::System.Windows.Controls.Panel)
									{
										num = (short)901054475;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.Size renderSize2;
									this.ProcessUIElement(uielement4, dc, info, applicationMenu.Popup, renderSize2);
									num = (short)583335939;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)1101725700;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_9B1;
									}
									continue;
								case 11:
								{
									global::System.Windows.Size renderSize2;
									global::System.Windows.UIElement uielement4;
									this.ProcessPanel(uielement4 as global::System.Windows.Controls.Panel, dc, info, applicationMenu.Popup, renderSize2);
									num = (short)250478599;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									global::System.Windows.UIElement uielement4;
									if (uielement4.Visibility == global::System.Windows.Visibility.Visible)
									{
										num = (short)458883081;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									goto IL_B73;
								}
								IL_AED:
								num = (short)2119892994;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9B1:
								goto IL_AED;
							}
							IL_B73:
							goto IL_1B4;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_B95;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_B82:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)978255874;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)2038038528;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BEE;
								case 2:
									goto IL_BEC;
								}
								goto IL_B95;
							}
							IL_BEC:
							IL_BEE:
							goto EndFinally_34;
							IL_B95:
							global::System.Collections.IEnumerator enumerator2;
							disposable = (enumerator2 as global::System.IDisposable);
							num = (short)888078337;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_B82;
							EndFinally_34:;
						}
						goto IL_BEF;
						IL_1B4:
						global::System.Collections.Generic.IEnumerator<object> enumerator = applicationMenu.MruItems.GetEnumerator();
						num = (short)168820747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_BFA;
					case 14:
						if (applicationMenu == null)
						{
							num = (short)357171209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)342949909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						if (num4 >= itemsControl.Items.Count)
						{
							num = (short)404946945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement uielement = itemsControl.ItemContainerGenerator.ContainerFromIndex(num4) as global::System.Windows.UIElement;
						num = (short)1142620170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::System.Windows.UIElement uielement;
						if (uielement is global::System.Windows.Controls.Panel)
						{
							num = (short)231669760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.ProcessUIElement(uielement, dc, info, itemsControl, renderSize);
						num = (short)852557830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::System.Windows.UIElement uielement;
						if (uielement.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)121110530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3E;
					}
					case 18:
						num = (short)1018298384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_C3E;
					case 20:
					{
						num = (short)709754880;
						short num5 = num;
						goto IL_BFA;
					}
					case 21:
					{
						if (applicationMenu.IsBackstageActive)
						{
							num = (short)1806172182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Size renderSize2 = applicationMenu.Popup.RenderSize;
						global::System.Collections.IEnumerator enumerator2 = ((global::System.Collections.IEnumerable)applicationMenu.Items).GetEnumerator();
						num = (short)432865292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						itemsControl = (applicationMenu.BackstageTab as global::System.Windows.Controls.ItemsControl);
						num = (short)398786583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (itemsControl == null)
						{
							num = (short)1346109447;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51C;
					}
					goto IL_97;
					IL_51C:
					renderSize = itemsControl.RenderSize;
					num4 = 0;
					num = (short)1041694740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BFA:
					num = (short)762511375;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C3E:
					num4++;
					num = (short)69468173;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11B:
				string str = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㕦౨ժ६੮Ͱᙲݴ坶᩸᩺፼彾力권ﾐﾒ랖連爵슠힢횤螦욨춪趬\udbae좰쎲킴鞶쮺춼펾ꣀꃂ꓄돆ꃈ꓊ꏌ苎듐뷒ꃔ께돚드돞蓠쏢胤详賨蛪췬鯮裰菲郴ퟶ郸裺\uddfc", a_);
				global::System.Type type = elem.GetType();
				string str2;
				if (type == null)
				{
					str2 = null;
					goto IL_BEF;
				}
				IL_891:
				str2 = type.ToString();
				IL_BEF:
				throw new global::System.InvalidOperationException(str + str2);
				IL_C3C:
				num = (short)1661468673;
				if (num != 0)
				{
				}
				return;
				IL_97:
				applicationMenu = (elem as global::DevComponents.WpfRibbon.ApplicationMenu);
				num = (short)1946550286;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}
	}
}
