using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using AcpBusinessLayer;
using AcpUI.Common;

namespace AcpUI.DragDrop
{
	// Token: 0x0200006C RID: 108
	public class ListBoxDragDropManager<TItemType> where TItemType : class
	{
		// Token: 0x06000585 RID: 1413 RVA: 0x0006F26C File Offset: 0x0006D46C
		internal ListBoxDragDropManager()
		{
			this.a = false;
			this.c = 0.7;
			this.d = -1;
			this.i = true;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0006F2A4 File Offset: 0x0006D4A4
		internal ListBoxDragDropManager(global::System.Windows.Controls.ListBox A_0) : this()
		{
			this.ListBox = A_0;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0006F2C0 File Offset: 0x0006D4C0
		internal ListBoxDragDropManager(global::System.Windows.Controls.ListBox A_0, double A_1) : this(A_0)
		{
			this.DragAdornerOpacity = A_1;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0006F2DC File Offset: 0x0006D4DC
		internal ListBoxDragDropManager(global::System.Windows.Controls.ListBox A_0, bool A_1) : this(A_0)
		{
			this.ShowDragAdorner = A_1;
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0006F2F8 File Offset: 0x0006D4F8
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x0006F3A8 File Offset: 0x0006D5A8
		internal double DragAdornerOpacity
		{
			get
			{
				short num = (short)567540390;
				short num2 = num;
				num = (short)1612970662;
				switch (num2 == num)
				{
				}
				num = (short)1219428353;
				if (num != 0)
				{
				}
				num = (short)139919360;
				short num3 = num;
				num = (short)1676083200;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				int a_ = 2;
				short num = (short)1299513345;
				if (num != 0)
				{
				}
				num = (short)183500805;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1166054712;
						short num3 = num;
						num = (short)1307809080;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_198;
						default:
							num = (short)1864957952;
							if (num != 0)
							{
							}
							if (value >= 0.0)
							{
								num = (short)1194852356;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_198;
						}
						break;
					}
					case 1:
						goto IL_B4;
					case 2:
						goto IL_F6;
					case 3:
						if (value > 1.0)
						{
							num = (short)1795424258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C0;
					case 4:
						num = (short)1575354371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_6C;
						}
						continue;
					}
					IL_6C:
					num = (short)1862270976;
					short num4 = num;
					if (this.IsDragInProgress)
					{
						num = (short)1316945921;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)34603008;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_B4:
				throw new global::System.InvalidOperationException(global::AcpUI.Common.Utility.c("\udb97ﮙ쾟횡蒣향춧\udea9貫\udaad\ud8afힱ钳쪷\udbb9\udbbbﾽ꒿귁뛃ꣅ귇룉菋뻍뇏뇑뷓ꋕꇗ龎곛곝迟鋡臣铥鳧鏩쳫諭藯胱鷳飵鿷\udaf9鷻\udefd擿瀁攃愅⠇攉簋欍戏猑怓缕眗琙㈛", a_));
				IL_F6:
				IL_198:
				throw new global::System.ArgumentOutOfRangeException(global::AcpUI.Common.Utility.c("\udc97ﶛ劣욡쮣풥욧쾩\udeab삯펱ힳ\udfb5첷쎹", a_), value, global::AcpUI.Common.Utility.c("햗肟삡솣蚥쪧쾩\ud8ab\ud9ad햯ힱ\udab3隵袷骹\uddbb킽꒿", a_));
				IL_1C0:
				this.c = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0006F57C File Offset: 0x0006D77C
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x0006F628 File Offset: 0x0006D828
		internal bool IsDragInProgress
		{
			get
			{
				short num = (short)1927906292;
				short num2 = num;
				num = (short)338527220;
				switch (num2 == num)
				{
				}
				num = (short)1720451072;
				if (num != 0)
				{
				}
				num = (short)454295552;
				short num3 = num;
				num = (short)1018757121;
				if (num != 0)
				{
				}
				return this.e;
			}
			private set
			{
				short num = (short)209125377;
				if (num != 0)
				{
				}
				num = (short)1217355313;
				short num2 = num;
				num = (short)1906597425;
				switch (num2 == num)
				{
				}
				num = (short)770048000;
				short num3 = num;
				num = (short)213778432;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0006F6DC File Offset: 0x0006D8DC
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x0006F78C File Offset: 0x0006D98C
		internal global::System.Windows.Controls.ListBox ListBox
		{
			get
			{
				short num = (short)907795034;
				short num2 = num;
				num = (short)1999624794;
				switch (num2 == num)
				{
				}
				num = (short)199163904;
				if (num != 0)
				{
				}
				num = (short)656932864;
				short num3 = num;
				num = (short)2022375425;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				int a_ = 13;
				short num = (short)942276618;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)28049409;
						if (num != 0)
						{
						}
						if (!this.g.AllowDrop)
						{
							num = (short)120717317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E1;
					case 1:
						goto IL_1E1;
					case 2:
						goto IL_2C3;
					case 3:
						if (this.g != null)
						{
							num = (short)1191575558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						goto IL_15E;
					case 5:
					{
						num = (short)2012860283;
						short num3 = num;
						num = (short)2137313147;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2C3;
						default:
						{
							num = (short)159514624;
							if (num != 0)
							{
							}
							num = (short)1814102016;
							short num4 = num;
							this.g.AllowDrop = true;
							num = (short)653328385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 6:
						num = (short)1118699520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return;
					case 8:
						if (this.g != null)
						{
							num = (short)416808962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E;
					case 9:
						goto IL_79;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					IL_59:
					if (this.IsDragInProgress)
					{
						num = (short)1896480777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)267059208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15E:
					this.g = value;
					num = (short)234553347;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E1:
					this.g.PreviewMouseLeftButtonDown += this.a;
					this.g.PreviewMouseMove += this.a;
					this.g.DragOver += this.d;
					this.g.DragLeave += this.c;
					this.g.DragEnter += this.b;
					this.g.Drop += this.a;
					num = (short)249495559;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C3:
					this.g.PreviewMouseLeftButtonDown -= this.a;
					this.g.PreviewMouseMove -= this.a;
					this.g.DragOver -= this.d;
					this.g.DragLeave -= this.c;
					this.g.DragEnter -= this.b;
					this.g.Drop -= this.a;
					num = (short)926547972;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_79:
				throw new global::System.InvalidOperationException(global::AcpUI.Common.Utility.c("쒤즦잨쒪\ud9ac辮슰횲솴鞶춸펺\ud8bc龾跀ꫂ뛄돆诈꓊뗌ꇐꇒ뫔Ꟗ볘꧚꧜ꛞ쇠蟢郤闦胨藪諬쿮郰폲釴藶飸鳺\uddfc郾焀昂眄昆紈戊戌愎㼐", a_));
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600058F RID: 1423 RVA: 0x0006FB04 File Offset: 0x0006DD04
		// (remove) Token: 0x06000590 RID: 1424 RVA: 0x0006FC3C File Offset: 0x0006DE3C
		public event global::System.EventHandler<global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType>> ProcessDrop
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType>> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_8B;
					case 1:
						return;
					case 2:
					{
						global::System.EventHandler<global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType>> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1287389185;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_8B;
					}
					}
					goto IL_1C;
					IL_8B:
					num2 = (short)311276378;
					short num3 = num2;
					num2 = (short)769962842;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)638058496;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType>> eventHandler2 = eventHandler;
						global::System.EventHandler<global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType>> value2 = (global::System.EventHandler<global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType>>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType>>>(ref this.j, value2, eventHandler2);
						num2 = (short)178913282;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				num2 = (short)1312227329;
				if (num2 != 0)
				{
				}
				num2 = (short)65536;
				short num4 = num2;
				eventHandler = this.j;
				num2 = (short)151519232;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType>> eventHandler;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)773849089;
						if (num2 != 0)
						{
						}
						goto IL_8B;
					case 1:
						return;
					case 2:
					{
						global::System.EventHandler<global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType>> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							num2 = (short)161808385;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_8B;
					}
					}
					goto IL_1C;
					IL_8B:
					num2 = (short)764215775;
					short num3 = num2;
					num2 = (short)132055519;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)827326464;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType>> eventHandler2 = eventHandler;
						global::System.EventHandler<global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType>> value2 = (global::System.EventHandler<global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType>>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType>>>(ref this.j, value2, eventHandler2);
						num2 = (short)187301890;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.j;
				num2 = (short)676003840;
				short num4 = num2;
				num2 = (short)253689856;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0006FD74 File Offset: 0x0006DF74
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x0006FE24 File Offset: 0x0006E024
		internal bool ShowDragAdorner
		{
			get
			{
				short num = (short)962002945;
				if (num != 0)
				{
				}
				num = (short)345964544;
				short num2 = num;
				num = (short)1378994617;
				short num3 = num;
				num = (short)1357695417;
				switch (num3 == num)
				{
				}
				num = (short)1127284736;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				int a_ = 3;
				short num = (short)1552272753;
				short num2 = num;
				num = (short)1931857265;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2084503552;
					short num3 = num;
					num = (short)1523318784;
					if (num != 0)
					{
					}
					num = (short)301006849;
					if (num != 0)
					{
					}
					if (this.IsDragInProgress)
					{
						throw new global::System.InvalidOperationException(global::AcpUI.Common.Utility.c("\uda98漢캠힢薤풦첨\udfaa趬\udbae\ud9b0횲閴톸풺쪼﮾돀ꋂꋄ蛆귈꓊뿌ꇎ듐ꇒꟖꯘ듚규뫞鏠韢鳤쟦跨黪鿬蛮鿰铲헴零\ud9f8鿺迼黾昀⌂樄眆氈礊氌笎砐簒笔㤖", a_));
					}
					break;
				}
				}
				this.i = value;
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0006FEFC File Offset: 0x0006E0FC
		private void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)20578304;
			int num2 = (int)((global::System.IntPtr)num);
			int num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
					goto IL_B3;
				case 2:
					if (this.a)
					{
						num = (short)842072065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12E;
				case 3:
					goto IL_51;
				}
				IL_34:
				if (this.IsMouseOverScrollbar)
				{
					num = (short)563281923;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num3 = this.IndexUnderDragCursor;
					this.a = (num3 > -1);
					num = (short)1223884802;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_51:
			num = (short)1883105945;
			short num4 = num;
			num = (short)788064921;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_53:
				this.h = global::AcpUI.DragDrop.MouseUtilities.GetMousePosition(this.g);
				this.d = num3;
				return;
			default:
				num = (short)169738241;
				if (num != 0)
				{
				}
				num = (short)2061238272;
				if (num != 0)
				{
				}
				this.a = false;
				return;
			}
			IL_B3:
			goto IL_53;
			IL_12E:
			num = (short)1668218880;
			short num5 = num;
			this.h = new global::System.Windows.Point(-10000.0, -10000.0);
			this.d = -1;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00070088 File Offset: 0x0006E288
		private void a(object A_0, global::System.Windows.Input.MouseEventArgs A_1)
		{
			short num = (short)1776197770;
			short num2 = num;
			num = (short)1529061514;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_CE:
				if (!this.CanStartDragOperation)
				{
					num = (short)1800732681;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1593507841;
					num3 = (int)((global::System.IntPtr)num);
				}
				break;
			default:
				num = (short)121765888;
				if (num != 0)
				{
				}
				num = (short)878968837;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			global::System.Windows.Controls.ListBoxItem listBoxItem;
			for (;;)
			{
				num = (short)826540032;
				short num4 = num;
				switch (num3)
				{
				case 0:
					if (!this.ShowDragAdornerResolved)
					{
						num = (short)1787428871;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2003173386;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.g.SelectedIndex != this.d)
					{
						num = (short)1325596675;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_205;
				case 2:
					if (listBoxItem == null)
					{
						num = (short)55771148;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1821310976;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.g.SelectedIndex = this.d;
					num = (short)502136836;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_205;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_CE;
					}
					continue;
				case 6:
					return;
				case 7:
					num = (short)61997064;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1D9;
				case 9:
					return;
				case 10:
					goto IL_1F9;
				case 11:
					if (this.g.SelectedItem == null)
					{
						num = (short)218038273;
						if (num != 0)
						{
						}
						num = (short)1546518534;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					listBoxItem = this.a(this.g.SelectedIndex);
					num = (short)132710402;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					return;
				}
				goto IL_CE;
				IL_205:
				num = (short)514916363;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_1D9:
			global::System.Windows.Documents.AdornerLayer adornerLayer = null;
			goto IL_29D;
			IL_1F9:
			adornerLayer = this.b(listBoxItem);
			IL_29D:
			global::System.Windows.Documents.AdornerLayer a_ = adornerLayer;
			this.a(listBoxItem);
			this.c();
			this.a(listBoxItem, a_);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00070348 File Offset: 0x0006E548
		private void d(object A_0, global::System.Windows.DragEventArgs A_1)
		{
			short num = (short)1485963267;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					A_1.Effects = global::System.Windows.DragDropEffects.Move;
					num = (short)443613190;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_118;
				case 2:
					goto IL_199;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 4:
					goto IL_13A;
				case 5:
					this.ItemUnderDragCursor = ((num3 < 0) ? default(TItemType) : (this.ListBox.Items[num3] as TItemType));
					num = (short)1619591170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)1609302017;
					if (num != 0)
					{
					}
					if (!this.ShowDragAdornerResolved)
					{
						goto IL_13A;
					}
					num = (short)1030419521;
					short num4 = num;
					num = (short)1686631489;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_118;
					default:
						num = (short)1931018240;
						if (num != 0)
						{
						}
						num = (short)984875009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_41:
				if (this.e(A_0, A_1))
				{
					num = (short)2082930688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_118:
				this.a();
				num = (short)969015300;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13A:
				num3 = this.IndexUnderDragCursor;
				num = (short)1792606213;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_199:
			num = (short)886964224;
			short num5 = num;
			A_1.Handled = true;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00070530 File Offset: 0x0006E730
		private void c(object A_0, global::System.Windows.DragEventArgs A_1)
		{
			short num = (short)165937155;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2093350913;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)1977629498;
					short num3 = num;
					num = (short)792410938;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_111;
					default:
						num = (short)1312096256;
						if (num != 0)
						{
						}
						num = (short)2100232199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					this.ItemUnderDragCursor = default(TItemType);
					goto IL_111;
				case 2:
				{
					num = (short)1795489792;
					short num4 = num;
					this.b.Visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)608829448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_74;
					}
					continue;
				case 4:
					if (this.b != null)
					{
						num = (short)1023279106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_223;
				case 5:
					if (!this.a(this.g))
					{
						num = (short)1748959232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_223;
				case 6:
					num = (short)728629253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (this.ItemUnderDragCursor != null)
					{
						num = (short)720437249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9A;
				case 8:
					goto IL_1DE;
				case 9:
					goto IL_9A;
				}
				IL_74:
				if (this.e(A_0, A_1))
				{
					num = (short)1865023494;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9A:
				num = (short)721092612;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_111:
				num = (short)463339529;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1DE:
			IL_223:
			A_1.Handled = true;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00070768 File Offset: 0x0006E968
		private void b(object A_0, global::System.Windows.DragEventArgs A_1)
		{
			short num = (short)1635581955;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1688928261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.b.Visibility != global::System.Windows.Visibility.Visible)
					{
						num = (short)1119682564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_164;
				case 2:
					num = (short)1782775809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				case 4:
					num = (short)1595801601;
					if (num != 0)
					{
					}
					this.a();
					this.b.Visibility = global::System.Windows.Visibility.Visible;
					num = (short)584646662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (this.b != null)
					{
						num = (short)1089208322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_164;
				case 6:
					goto IL_B9;
				}
				IL_42:
				if (!this.e(A_0, A_1))
				{
					break;
				}
				num = (short)1926168576;
				short num3 = num;
				num = (short)886374400;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B9:
			IL_164:
			num = (short)225927491;
			short num4 = num;
			num = (short)425681219;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B9;
			default:
				num = (short)1780875264;
				if (num != 0)
				{
				}
				A_1.Handled = true;
				return;
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00070930 File Offset: 0x0006EB30
		private void a(object A_0, global::System.Windows.DragEventArgs A_1)
		{
			short num = (short)1627848704;
			switch (num)
			{
			default:
			{
				num = (short)858324995;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						num = (short)5898264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						int num3;
						if (num3 < 0)
						{
							num = (short)1189478426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_DD;
						}
						continue;
					case 4:
						num = (short)1639383059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						TItemType titemType;
						if (titemType == null)
						{
							num = (short)637665297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.ObjectModel.ObservableCollection<TItemType> observableCollection = this.g.ItemsSource as global::System.Collections.ObjectModel.ObservableCollection<TItemType>;
						int num3 = observableCollection.IndexOf(titemType);
						int num4 = this.IndexUnderDragCursor;
						num = (short)1866792967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return;
					case 7:
					{
						int num4;
						if (num4 < 0)
						{
							num = (short)611844108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_60E;
					}
					case 8:
					{
						global::System.Collections.ObjectModel.ObservableCollection<TItemType> observableCollection;
						if (observableCollection.Count == 0)
						{
							num = (short)969080857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1886650370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_3B5;
					case 10:
						goto IL_60E;
					case 11:
						goto IL_2C4;
					case 12:
						num = (short)1018822664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_64A;
					case 14:
					{
						global::AcpUI.AcpListBox acpListBox = A_0 as global::AcpUI.AcpListBox;
						num = (short)1149131490;
						short num5 = num;
						num = (short)1233672930;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)433061888;
							if (num != 0)
							{
							}
							num = (short)1341980694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
					{
						int num3;
						if (num3 > -1)
						{
							num = (short)292749326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						TItemType titemType;
						global::System.Collections.ObjectModel.ObservableCollection<TItemType> observableCollection;
						int num4;
						observableCollection.Insert(num4, titemType);
						num = (short)1792147491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::AcpUI.AcpListBox acpListBox;
						global::AcpBusinessLayer.AcpListField acpListField = acpListBox.MyBLObject as global::AcpBusinessLayer.AcpListField;
						num = (short)937033729;
						if (num != 0)
						{
						}
						num = (short)2093219871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						return;
					case 18:
					{
						int num3;
						TItemType titemType;
						global::System.Collections.ObjectModel.ObservableCollection<TItemType> observableCollection;
						int num4;
						global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType> processDropEventArgs = new global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType>(observableCollection, titemType, num3, num4, A_1.AllowedEffects);
						this.j(this, processDropEventArgs);
						A_1.Effects = processDropEventArgs.Effects;
						num = (short)209321995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (!A_1.Data.GetDataPresent(typeof(global::AcpUI.AcpOrderableListBox)))
						{
							num = (short)441253894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16C;
					case 20:
						goto IL_396;
					case 21:
						this.ItemUnderDragCursor = default(TItemType);
						num = (short)264503309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						global::AcpUI.AcpListBox acpListBox;
						if (acpListBox != null)
						{
							num = (short)1180303376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3;
						global::System.Collections.ObjectModel.ObservableCollection<TItemType> observableCollection;
						int num4;
						observableCollection.Move(num3, num4);
						num = (short)541655060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						if (!A_1.Data.GetDataPresent(typeof(global::AcpUI.AcpListBox)))
						{
							num = (short)826277892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16C;
					case 24:
						if (this.ItemUnderDragCursor != null)
						{
							num = (short)1495597077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_64A;
					case 25:
					{
						int num4 = 0;
						num = (short)447938596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
					{
						global::System.Collections.ObjectModel.ObservableCollection<TItemType> observableCollection;
						int num4 = observableCollection.Count;
						num = (short)1814757386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
					{
						int num3;
						int num4;
						global::AcpBusinessLayer.AcpListField acpListField;
						acpListField.MoveItem(num3, num4);
						num = (short)1679097893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						goto IL_4A7;
					case 29:
					{
						if (A_1.Data.GetDataPresent(typeof(global::AcpUI.AcpListBox)))
						{
							num = (short)50200610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						TItemType titemType = (A_1.Data.GetData(typeof(global::AcpUI.AcpOrderableListBox)) as global::AcpUI.AcpOrderableListBox).SelectedItem as TItemType;
						num = (short)522780700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						if (this.j != null)
						{
							num = (short)1747910674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)868286479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						global::AcpBusinessLayer.AcpListField acpListField;
						if (acpListField != null)
						{
							num = (short)1108672539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_396;
					}
					case 32:
						goto IL_4A7;
					case 33:
					{
						int num3;
						int num4;
						if (num3 == num4)
						{
							num = (short)1637744640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1243021342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
					{
						TItemType titemType = (A_1.Data.GetData(typeof(global::AcpUI.AcpListBox)) as global::AcpUI.AcpListBox).SelectedItem as TItemType;
						num = (short)1476329504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						goto IL_396;
					case 36:
						goto IL_60E;
					case 37:
						goto IL_396;
					}
					IL_DD:
					if (this.e(A_0, A_1))
					{
						num = (short)1233453057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_724;
					IL_16C:
					num = (short)1415249949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_396:
					A_1.Effects = global::System.Windows.DragDropEffects.Move;
					num = (short)1541144585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A7:
					num = (short)723255301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_60E:
					num = (short)1253179425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_64A:
					A_1.Effects = global::System.Windows.DragDropEffects.None;
					num = (short)86114304;
					short num6 = num;
					num = (short)1592328215;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_2C4:
				IL_3B5:
				IL_724:
				A_1.Handled = true;
				return;
			}
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00071068 File Offset: 0x0006F268
		private bool CanStartDragOperation
		{
			get
			{
				short num = (short)1935802372;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (this.d == -1)
						{
							num = (short)1928658951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1880031237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!this.a)
						{
							goto IL_15E;
						}
						num = (short)943325184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1073938433;
						if (num != 0)
						{
						}
						num = (short)2045864558;
						short num3 = num;
						num = (short)1134979694;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15E;
						default:
							goto IL_C3;
						}
						break;
					}
					case 3:
						return false;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_44;
						}
						continue;
					case 5:
						if (!this.HasCursorLeftDragThreshold)
						{
							num = (short)1452015619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 6:
						return false;
					case 7:
						return false;
					}
					IL_44:
					if (global::System.Windows.Input.Mouse.LeftButton != global::System.Windows.Input.MouseButtonState.Pressed)
					{
						num = (short)1671954434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1968898049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15E:
					num = (short)1321009158;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C3:
				num = (short)23134208;
				if (num != 0)
				{
				}
				num = (short)1314127872;
				short num4 = num;
				return false;
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0007122C File Offset: 0x0006F42C
		private void a(global::System.Windows.Controls.ListBoxItem A_0, global::System.Windows.Documents.AdornerLayer A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_EF;
				case 1:
					this.ItemUnderDragCursor = default(TItemType);
					num2 = (short)2118451200;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)370868224;
					short num3 = num2;
					if (this.ItemUnderDragCursor != null)
					{
						num2 = (short)1053163521;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EF;
				}
				case 3:
					if (A_1 != null)
					{
						num2 = (short)1699086340;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_150;
				case 4:
					A_1.Remove(this.b);
					this.b = null;
					goto IL_B0;
				case 5:
					goto IL_150;
				}
				goto IL_28;
				IL_B0:
				num2 = (short)1929445377;
				if (num2 != 0)
				{
				}
				num2 = (short)959643653;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_150:
				num2 = (short)1299551977;
				short num4 = num2;
				num2 = (short)216241897;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B0;
				default:
					goto IL_186;
				}
				IL_EF:
				num2 = (short)2144600067;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_186:
			num2 = (short)424673280;
			if (num2 != 0)
			{
			}
			return;
			IL_28:
			global::AcpUI.DragDrop.ListBoxItemDragState.SetIsBeingDragged(A_0, false);
			this.IsDragInProgress = false;
			num2 = (short)1350369282;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000713D8 File Offset: 0x0006F5D8
		private global::System.Windows.Controls.ListBoxItem a(int A_0)
		{
			short num = (short)337055525;
			short num2 = num;
			num = (short)1097338661;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)138739712;
				short num3 = num;
				num = (short)1335885825;
				if (num != 0)
				{
				}
				num = (short)1379532800;
				if (num != 0)
				{
				}
				if (this.g.ItemContainerGenerator.Status != global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
				{
					return null;
				}
				break;
			}
			}
			return this.g.ItemContainerGenerator.ContainerFromIndex(A_0) as global::System.Windows.Controls.ListBoxItem;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000714B0 File Offset: 0x0006F6B0
		private global::System.Windows.Controls.ListBoxItem b(TItemType A_0)
		{
			short num = (short)1017765325;
			short num2 = num;
			num = (short)1208868301;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)181141504;
				short num3 = num;
				num = (short)1832910849;
				if (num != 0)
				{
				}
				num = (short)1704198144;
				if (num != 0)
				{
				}
				if (this.g.ItemContainerGenerator.Status != global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
				{
					return null;
				}
				break;
			}
			}
			return this.g.ItemContainerGenerator.ContainerFromItem(A_0) as global::System.Windows.Controls.ListBoxItem;
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00071588 File Offset: 0x0006F788
		private bool HasCursorLeftDragThreshold
		{
			get
			{
				short num = (short)2072969216;
				short num2 = num;
				if (this.d >= 0)
				{
					num = (short)1803469782;
					short num3 = num;
					num = (short)913294294;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1950416897;
						if (num != 0)
						{
						}
						num = (short)769523712;
						if (num != 0)
						{
						}
						global::System.Windows.Controls.ListBoxItem listBoxItem = this.a(this.d);
						global::System.Windows.Rect descendantBounds = global::System.Windows.Media.VisualTreeHelper.GetDescendantBounds(listBoxItem);
						global::System.Windows.Point point = this.g.TranslatePoint(this.h, listBoxItem);
						double val = global::System.Math.Abs(point.Y);
						double val2 = global::System.Math.Abs(descendantBounds.Height - point.Y);
						double val3 = global::System.Math.Min(val, val2);
						double width = global::System.Windows.SystemParameters.MinimumHorizontalDragDistance * 2.0;
						double height = global::System.Math.Min(global::System.Windows.SystemParameters.MinimumVerticalDragDistance, val3) * 2.0;
						global::System.Windows.Size size = new global::System.Windows.Size(width, height);
						global::System.Windows.Rect rect = new global::System.Windows.Rect(this.h, size);
						rect.Offset(size.Width / -2.0, size.Height / -2.0);
						global::System.Windows.Point mousePosition = global::AcpUI.DragDrop.MouseUtilities.GetMousePosition(this.g);
						return !rect.Contains(mousePosition);
					}
					}
				}
				return false;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00071714 File Offset: 0x0006F914
		private int IndexUnderDragCursor
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_58;
				}
				short num;
				int num3;
				int num4;
				int result;
				for (;;)
				{
					IL_0A:
					num = (short)1098514432;
					short num2 = num;
					switch (num3)
					{
					case 0:
						goto IL_EC;
					case 1:
					{
						global::System.Windows.Controls.ListBoxItem a_;
						if (this.a(a_))
						{
							num = (short)875167747;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)807862278;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return result;
					case 3:
						result = num4;
						num = (short)2127429634;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)920718523;
						short num5 = num;
						num = (short)984943803;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_EC;
						default:
						{
							num = (short)1166999552;
							if (num != 0)
							{
							}
							if (num4 >= this.g.Items.Count)
							{
								num = (short)398589957;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.Controls.ListBoxItem a_ = this.a(num4);
							num = (short)1696202753;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 5:
						return result;
					case 6:
						goto IL_EC;
					}
					goto IL_58;
					IL_EC:
					num = (short)977534977;
					if (num != 0)
					{
					}
					num = (short)1869545476;
					num3 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_58:
				result = -1;
				num4 = 0;
				num = (short)135135232;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000718C8 File Offset: 0x0006FAC8
		private global::System.Windows.Documents.AdornerLayer b(global::System.Windows.Controls.ListBoxItem A_0)
		{
			short num = (short)1441837483;
			short num2 = num;
			num = (short)1423094187;
			switch (num2 == num)
			{
			}
			num = (short)1932722176;
			short num3 = num;
			num = (short)591069184;
			if (num != 0)
			{
			}
			num = (short)297336833;
			if (num != 0)
			{
			}
			global::System.Windows.Media.VisualBrush a_ = new global::System.Windows.Media.VisualBrush(A_0);
			this.b = new global::AcpUI.DragDrop.ListBoxDragAdorner(this.g, A_0.RenderSize, a_);
			this.b.Opacity = this.DragAdornerOpacity;
			global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this.g);
			adornerLayer.Add(this.b);
			this.h = global::AcpUI.DragDrop.MouseUtilities.GetMousePosition(this.g);
			return adornerLayer;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000719CC File Offset: 0x0006FBCC
		private void a(global::System.Windows.Controls.ListBoxItem A_0)
		{
			short num = (short)1946227758;
			short num2 = num;
			num = (short)369759278;
			switch (num2 == num)
			{
			}
			num = (short)168689664;
			short num3 = num;
			num = (short)1034289153;
			if (num != 0)
			{
			}
			num = (short)592314368;
			if (num != 0)
			{
			}
			this.IsDragInProgress = true;
			this.a = false;
			global::AcpUI.DragDrop.ListBoxItemDragState.SetIsBeingDragged(A_0, true);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00071A8C File Offset: 0x0006FC8C
		private bool a(global::System.Windows.Media.Visual A_0)
		{
			short num = (short)169564572;
			short num2 = num;
			num = (short)256858524;
			switch (num2 == num)
			{
			}
			num = (short)1206779904;
			short num3 = num;
			num = (short)1683357697;
			if (num != 0)
			{
			}
			num = (short)670105600;
			if (num != 0)
			{
			}
			global::System.Windows.Rect descendantBounds = global::System.Windows.Media.VisualTreeHelper.GetDescendantBounds(A_0);
			global::System.Windows.Point mousePosition = global::AcpUI.DragDrop.MouseUtilities.GetMousePosition(A_0);
			return descendantBounds.Contains(mousePosition);
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00071B4C File Offset: 0x0006FD4C
		private bool IsMouseOverScrollbar
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				int num;
				short num2;
				global::System.Windows.Media.HitTestResult hitTestResult;
				for (;;)
				{
					IL_0A:
					global::System.Windows.DependencyObject dependencyObject;
					switch (num)
					{
					case 0:
					{
						num2 = (short)981283911;
						short num3 = num2;
						num2 = (short)471282759;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return false;
						default:
							num2 = (short)495058944;
							if (num2 != 0)
							{
							}
							if (dependencyObject is global::System.Windows.Controls.Primitives.ScrollBar)
							{
								num2 = (short)1626865669;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1534918668;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						if (dependencyObject is global::System.Windows.Media.Media3D.Visual3D)
						{
							num2 = (short)571277318;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
						num2 = (short)1788936200;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_198;
					case 3:
						return false;
					case 4:
						if (hitTestResult == null)
						{
							num2 = (short)1926299651;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						dependencyObject = hitTestResult.VisualHit;
						num2 = (short)1836253186;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						return true;
					case 6:
						goto IL_94;
					case 7:
						if (dependencyObject == null)
						{
							num2 = (short)521601025;
							if (num2 != 0)
							{
							}
							num2 = (short)1547632649;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)250740736;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						goto IL_198;
					case 9:
						return false;
					case 10:
						num2 = (short)1226899457;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 11:
						goto IL_198;
					case 12:
						if (!(dependencyObject is global::System.Windows.Media.Visual))
						{
							num2 = (short)1747320842;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_94;
					}
					goto IL_44;
					IL_94:
					num2 = (short)561315840;
					short num4 = num2;
					dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
					num2 = (short)1605828619;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_198:
					num2 = (short)1910571015;
					num = (int)((global::System.IntPtr)num2);
				}
				return false;
				IL_44:
				global::System.Windows.Point mousePosition = global::AcpUI.DragDrop.MouseUtilities.GetMousePosition(this.g);
				hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(this.g, mousePosition);
				num2 = (short)1700462596;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00071DE0 File Offset: 0x0006FFE0
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00071E90 File Offset: 0x00070090
		private TItemType ItemUnderDragCursor
		{
			get
			{
				short num = (short)1305431897;
				short num2 = num;
				num = (short)1291210585;
				switch (num2 == num)
				{
				}
				num = (short)340262912;
				short num3 = num;
				num = (short)1298726912;
				if (num != 0)
				{
				}
				num = (short)1651703809;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)490995717;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						if (num3 == 1)
						{
							num = (short)2039021580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B4;
					case 1:
						goto IL_139;
					case 2:
					{
						global::System.Windows.Controls.ListBoxItem listBoxItem;
						global::AcpUI.DragDrop.ListBoxItemDragState.SetIsUnderDragCursor(listBoxItem, num3 == 1);
						num = (short)1117519873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_1EC;
					case 4:
						return;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_5D;
						}
						continue;
					case 6:
						return;
					case 7:
					{
						if (num3 >= 2)
						{
							num = (short)921436166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1812529152;
						short num4 = num;
						num = (short)818806784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_1EC;
					case 9:
					{
						global::System.Windows.Controls.ListBoxItem listBoxItem;
						if (listBoxItem != null)
						{
							num = (short)741015554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_139;
					}
					case 10:
						goto IL_B4;
					case 11:
					{
						global::System.Windows.Controls.ListBoxItem listBoxItem = this.b(this.f);
						num = (short)1695194557;
						short num5 = num;
						num = (short)1776524733;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)672333824;
							if (num != 0)
							{
							}
							num = (short)1021968393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						this.f = value;
						num = (short)369033226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)211025921;
						if (num != 0)
						{
						}
						if (this.f != null)
						{
							num = (short)255066123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_139;
					}
					IL_5D:
					if (this.f == value)
					{
						num = (short)664797188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 = 0;
					num = (short)545390600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B4:
					num = (short)10354701;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_139:
					num3++;
					num = (short)229376003;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EC:
					num = (short)1753743367;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0007214C File Offset: 0x0007034C
		private void c()
		{
			switch (0)
			{
			case 0:
				goto IL_8E;
			}
			short num;
			int num3;
			object data;
			global::System.Windows.DragDropEffects allowedEffects;
			TItemType titemType;
			for (;;)
			{
				IL_0A:
				num = (short)66255576;
				short num2 = num;
				num = (short)177273560;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1023410177;
					if (num != 0)
					{
					}
					num = (short)1610678272;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_EB;
					case 1:
						goto IL_115;
					case 2:
						if (global::System.Windows.DragDrop.DoDragDrop(this.g, data, allowedEffects) != global::System.Windows.DragDropEffects.None)
						{
							num = (short)1330315264;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_8E;
				}
				IL_EB:
				this.g.SelectedItem = titemType;
				num = (short)1113325569;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_115:
			num = (short)1482686464;
			short num4 = num;
			return;
			IL_8E:
			data = this.g;
			titemType = (this.g.SelectedItem as TItemType);
			allowedEffects = global::System.Windows.DragDropEffects.Move;
			num = (short)106364930;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00072298 File Offset: 0x00070498
		private bool ShowDragAdornerResolved
		{
			get
			{
				short num = (short)473104384;
				short num2 = num;
				if (!this.ShowDragAdorner)
				{
					num = (short)1406570845;
					short num3 = num;
					num = (short)201036125;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2097217537;
						if (num != 0)
						{
						}
						num = (short)1328939008;
						if (num != 0)
						{
						}
						return false;
					}
				}
				return this.DragAdornerOpacity > 0.0;
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00072364 File Offset: 0x00070564
		private void a()
		{
			short num = (short)1690959872;
			switch (num)
			{
			default:
			{
				num = (short)889285430;
				short num2 = num;
				num = (short)2121689910;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_BA:
					global::System.Windows.Point mousePosition = global::AcpUI.DragDrop.MouseUtilities.GetMousePosition(this.ListBox);
					double a_ = mousePosition.X - this.h.X;
					double a_2 = this.a(this.d).TranslatePoint(new global::System.Windows.Point(0.0, 0.0), this.ListBox).Y + mousePosition.Y - this.h.Y;
					this.b.a(a_, a_2);
					num = (short)276430849;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)17694720;
					if (num != 0)
					{
					}
					num = (short)314310658;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_BA;
					case 1:
						goto IL_14C;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_9A;
						}
						continue;
					}
					IL_9A:
					if (this.b == null)
					{
						return;
					}
					num = (short)779091968;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_14C:
				num = (short)1839595521;
				if (num != 0)
				{
				}
				num = (short)709427200;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00072510 File Offset: 0x00070710
		internal bool e(object A_0, global::System.Windows.DragEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_56;
			}
			short num;
			int num3;
			global::AcpUI.AcpListBox acpListBox;
			for (;;)
			{
				IL_0A:
				num = (short)1765801984;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (acpListBox == null)
					{
						num = (short)20119558;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_151;
				case 1:
					goto IL_109;
				case 2:
					if ((A_1.AllowedEffects & global::System.Windows.DragDropEffects.Move) == global::System.Windows.DragDropEffects.None)
					{
						num = (short)798162945;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DB;
				case 3:
					goto IL_151;
				case 4:
				{
					num = (short)1896626688;
					short num4 = num;
					num = (short)236796416;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_151;
					default:
						num = (short)1239089152;
						if (num != 0)
						{
						}
						if (acpListBox != this.g)
						{
							num = (short)1146224645;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1840513025;
						if (num != 0)
						{
						}
						num = (short)676265986;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					goto IL_1D6;
				case 6:
					acpListBox = (A_1.Data.GetData(typeof(global::AcpUI.AcpOrderableListBox)) as global::AcpUI.AcpListBox);
					num = (short)614334467;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_56;
				IL_151:
				num = (short)1969422340;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_109:
			A_1.Effects = global::System.Windows.DragDropEffects.None;
			return false;
			IL_1D6:
			A_1.Effects = global::System.Windows.DragDropEffects.None;
			return false;
			IL_1DB:
			A_1.Effects = global::System.Windows.DragDropEffects.Move;
			return true;
			IL_56:
			acpListBox = (A_1.Data.GetData(typeof(global::AcpUI.AcpListBox)) as global::AcpUI.AcpListBox);
			num = (short)2022572032;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x040002F4 RID: 756
		private bool a;

		// Token: 0x040002F5 RID: 757
		private global::AcpUI.DragDrop.ListBoxDragAdorner b;

		// Token: 0x040002F6 RID: 758
		private double c;

		// Token: 0x040002F7 RID: 759
		private int d;

		// Token: 0x040002F8 RID: 760
		private bool e;

		// Token: 0x040002F9 RID: 761
		private TItemType f;

		// Token: 0x040002FA RID: 762
		private global::System.Windows.Controls.ListBox g;

		// Token: 0x040002FB RID: 763
		private global::System.Windows.Point h;

		// Token: 0x040002FC RID: 764
		private bool i;

		// Token: 0x040002FD RID: 765
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::AcpUI.DragDrop.ProcessDropEventArgs<TItemType>> j;
	}
}
