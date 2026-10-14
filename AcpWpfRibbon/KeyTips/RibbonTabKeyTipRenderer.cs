using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon.KeyTips
{
	// Token: 0x020000D2 RID: 210
	internal class RibbonTabKeyTipRenderer : global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer
	{
		// Token: 0x060008C0 RID: 2240 RVA: 0x000C79B8 File Offset: 0x000C5BB8
		public override void Render(global::System.Windows.Media.DrawingContext dc, object elem, global::DevComponents.WpfRibbon.KeyTipRenderInfo info)
		{
			int a_ = 15;
			short num = (short)2011496448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_57;
				}
				global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
				for (;;)
				{
					IL_30:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1043988489;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Windows.UIElement uielement;
									if (uielement.IsVisible)
									{
										num = (short)510656516;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1306984456;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1527316481;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)1182793734;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Windows.UIElement uielement;
									global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer renderer = global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderFactory.GetRenderer(uielement);
									num = (short)1997864965;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer renderer;
									if (renderer != null)
									{
										num = (short)1253900295;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::System.Windows.UIElement uielement;
									if (uielement.Visibility == global::System.Windows.Visibility.Visible)
									{
										num = (short)623706122;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::System.Windows.UIElement uielement;
									global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer renderer;
									renderer.Render(dc, uielement, info);
									num = (short)461570050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_30F;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_1CC;
									}
									continue;
								case 10:
									num = (short)1026686976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_27B:
								num = (short)2136735747;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1CC:
								goto IL_27B;
							}
							IL_30F:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_331;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_31E:
								switch (num2)
								{
								case 0:
									goto IL_3D6;
								case 1:
									if (disposable != null)
									{
										num = (short)626196482;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D8;
								case 2:
									goto IL_3B5;
								}
								goto IL_331;
							}
							IL_3B5:
							goto IL_3B7;
							IL_3D6:
							IL_3D8:
							goto EndFinally_12;
							IL_331:
							num = (short)1434527018;
							short num3 = num;
							num = (short)1547576618;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_3B7:
								disposable.Dispose();
								num = (short)1443692544;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_31E;
							default:
								num = (short)860028928;
								if (num != 0)
								{
								}
								disposable = (enumerator as global::System.IDisposable);
								num = (short)888668161;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_31E;
							}
							EndFinally_12:;
						}
						goto IL_3D9;
					case 1:
						num = (short)1542062087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1355350017;
						if (num != 0)
						{
						}
						if (!(ribbonTab.Content is global::System.Windows.Controls.Panel))
						{
							num = (short)52101124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D9;
					case 3:
						if (ribbonTab.Content != null)
						{
							num = (short)2029518853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						return;
					case 5:
						num = (short)963969026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (ribbonTab == null)
						{
							num = (short)473235457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1753088003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_E4;
					}
					goto IL_57;
					IL_3D9:
					enumerator = (ribbonTab.Content as global::System.Windows.Controls.Panel).Children.GetEnumerator();
					num = (short)1685520384;
					short num4 = num;
					num = (short)599457792;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E4:
				string str = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㕦౨ժ६੮Ͱᙲݴ坶᩸᩺፼彾力권ﾐﾒ랖連爵슠힢횤螦욨춪趬\udbae좰쎲킴鞶튺\udfbc\uddbe껀귂釄ꛆꯈ뫌꟎룐뿒냔볘럚룜닞쇠韢鳤韦賨쯪蓬鳮퇰", a_);
				global::System.Type type = elem.GetType();
				throw new global::System.InvalidOperationException(str + ((type != null) ? type.ToString() : null));
				IL_57:
				ribbonTab = (elem as global::DevComponents.WpfRibbon.RibbonTab);
				num = (short)612302854;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}
	}
}
