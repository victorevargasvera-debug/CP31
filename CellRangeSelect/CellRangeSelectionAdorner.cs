using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;

namespace Motorola.CommonCPS.UI.CellRangeSelect
{
	// Token: 0x0200000A RID: 10
	public class CellRangeSelectionAdorner : global::System.Windows.Documents.Adorner, global::System.IDisposable
	{
		// Token: 0x0600003F RID: 63 RVA: 0x000058D0 File Offset: 0x00003AD0
		internal CellRangeSelectionAdorner(global::System.Windows.Controls.ScrollContentPresenter A_0, global::Infragistics.Windows.DataPresenter.DataPresenterBase A_1) : this(A_0, A_1, global::System.Windows.Media.Colors.DarkGray, global::System.Windows.Input.Cursors.Cross)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000058F0 File Offset: 0x00003AF0
		internal CellRangeSelectionAdorner(global::System.Windows.Controls.ScrollContentPresenter A_0, global::Infragistics.Windows.DataPresenter.DataPresenterBase A_1, global::System.Windows.Media.Color A_2) : this(A_0, A_1, A_2, global::System.Windows.Input.Cursors.Cross)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000590C File Offset: 0x00003B0C
		internal CellRangeSelectionAdorner(global::System.Windows.Controls.ScrollContentPresenter A_0, global::Infragistics.Windows.DataPresenter.DataPresenterBase A_1, global::System.Windows.Media.Color A_2, global::System.Windows.Input.Cursor A_3)
		{
			int a_ = 0;
			base..ctor(A_0);
			if (A_1 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.b("飾猀樂愄", a_));
			}
			if (A_3 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.b("鳾琀焂瘄栆笈", a_));
			}
			this.grid = A_1;
			this.Color = A_2;
			base.Cursor = A_3;
			this.visualChildren = new global::System.Windows.Media.VisualCollection(this);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005980 File Offset: 0x00003B80
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)400996670;
				short num2 = num;
				num = (short)1262205246;
				switch (num2 == num)
				{
				}
				num = (short)860422144;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)89325569;
			if (num != 0)
			{
			}
			num = (short)57540608;
			short num3 = num;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000043 RID: 67 RVA: 0x00005A48 File Offset: 0x00003C48
		// (remove) Token: 0x06000044 RID: 68 RVA: 0x00005B80 File Offset: 0x00003D80
		internal event global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler DragSelectionStarted
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)525351216;
				short num2 = num;
				num = (short)263141680;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)337444864;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6A;
					}
					break;
				}
				int num3;
				global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler dragSelectionStartedHandler;
				for (;;)
				{
					IL_58:
					global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler dragSelectionStartedHandler2;
					switch (num3)
					{
					case 0:
						goto IL_FD;
					case 1:
						if (dragSelectionStartedHandler == dragSelectionStartedHandler2)
						{
							num = (short)700121088;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE;
					case 2:
						num = (short)1928921089;
						if (num != 0)
						{
						}
						goto IL_AE;
					}
					goto IL_6A;
					IL_AE:
					dragSelectionStartedHandler2 = dragSelectionStartedHandler;
					global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler value2 = (global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler)global::System.Delegate.Combine(dragSelectionStartedHandler2, value);
					dragSelectionStartedHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler>(ref this.DragSelectionStarted, value2, dragSelectionStartedHandler2);
					num = (short)1864957953;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_FD:
				num = (short)448987136;
				short num4 = num;
				return;
				IL_6A:
				dragSelectionStartedHandler = this.DragSelectionStarted;
				num = (short)1961361410;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_58;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1023519908;
				short num2 = num;
				num = (short)1743760548;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)955318272;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					break;
				}
				int num3;
				global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler dragSelectionStartedHandler;
				for (;;)
				{
					IL_55:
					global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler dragSelectionStartedHandler2;
					switch (num3)
					{
					case 0:
						goto IL_FE;
					case 1:
						if (dragSelectionStartedHandler == dragSelectionStartedHandler2)
						{
							num = (short)3866624;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					case 2:
						num = (short)999817217;
						if (num != 0)
						{
						}
						goto IL_AC;
					}
					goto IL_67;
					IL_AC:
					dragSelectionStartedHandler2 = dragSelectionStartedHandler;
					global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler value2 = (global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler)global::System.Delegate.Remove(dragSelectionStartedHandler2, value);
					dragSelectionStartedHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler>(ref this.DragSelectionStarted, value2, dragSelectionStartedHandler2);
					num = (short)1531183105;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_FE:
				num = (short)1744371712;
				short num4 = num;
				return;
				IL_67:
				dragSelectionStartedHandler = this.DragSelectionStarted;
				num = (short)1021640706;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000045 RID: 69 RVA: 0x00005CB8 File Offset: 0x00003EB8
		// (remove) Token: 0x06000046 RID: 70 RVA: 0x00005DEC File Offset: 0x00003FEC
		internal event global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler DragSelectionCompleted
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)553263745;
				short num2 = num;
				num = (short)2050957953;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1850015744;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8F;
					}
					break;
				}
				int num3;
				global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler dragSelectionCompletedHandler;
				for (;;)
				{
					IL_55:
					num = (short)1522597889;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler dragSelectionCompletedHandler2;
					switch (num3)
					{
					case 0:
						goto IL_FD;
					case 1:
						if (dragSelectionCompletedHandler == dragSelectionCompletedHandler2)
						{
							num = (short)2085158912;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					case 2:
						goto IL_AC;
					}
					goto IL_8F;
					IL_AC:
					dragSelectionCompletedHandler2 = dragSelectionCompletedHandler;
					global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler value2 = (global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler)global::System.Delegate.Combine(dragSelectionCompletedHandler2, value);
					dragSelectionCompletedHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler>(ref this.DragSelectionCompleted, value2, dragSelectionCompletedHandler2);
					num = (short)645791745;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_FD:
				num = (short)836632576;
				short num4 = num;
				return;
				IL_8F:
				dragSelectionCompletedHandler = this.DragSelectionCompleted;
				num = (short)1827143682;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)448055060;
				short num2 = num;
				num = (short)451987220;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1466171392;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					break;
				}
				int num3;
				global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler dragSelectionCompletedHandler;
				for (;;)
				{
					IL_54:
					global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler dragSelectionCompletedHandler2;
					switch (num3)
					{
					case 0:
						goto IL_FB;
					case 1:
						if (dragSelectionCompletedHandler == dragSelectionCompletedHandler2)
						{
							num = (short)1833107456;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_83;
					case 2:
						goto IL_83;
					}
					goto IL_66;
					IL_83:
					num = (short)971505665;
					if (num != 0)
					{
					}
					dragSelectionCompletedHandler2 = dragSelectionCompletedHandler;
					global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler value2 = (global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler)global::System.Delegate.Remove(dragSelectionCompletedHandler2, value);
					dragSelectionCompletedHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler>(ref this.DragSelectionCompleted, value2, dragSelectionCompletedHandler2);
					num = (short)279445505;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_FB:
				num = (short)1446576128;
				short num4 = num;
				return;
				IL_66:
				dragSelectionCompletedHandler = this.DragSelectionCompleted;
				num = (short)1075314690;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00005F20 File Offset: 0x00004120
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase Grid
		{
			get
			{
				short num = (short)1562305404;
				short num2 = num;
				num = (short)88597372;
				switch (num2 == num)
				{
				}
				num = (short)226623488;
				if (num != 0)
				{
				}
				num = (short)1057161217;
				if (num != 0)
				{
				}
				num = (short)673382400;
				short num3 = num;
				return this.grid;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00005FD0 File Offset: 0x000041D0
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00006080 File Offset: 0x00004280
		public global::System.Windows.Media.Color Color
		{
			get
			{
				short num = (short)157169721;
				short num2 = num;
				num = (short)1571895353;
				switch (num2 == num)
				{
				}
				num = (short)223805441;
				if (num != 0)
				{
				}
				num = (short)510590976;
				if (num != 0)
				{
				}
				num = (short)113967104;
				short num3 = num;
				return this.color;
			}
			set
			{
				short num = (short)1262260538;
				short num2 = num;
				num = (short)745312570;
				switch (num2 == num)
				{
				}
				num = (short)1032650752;
				if (num != 0)
				{
				}
				num = (short)1949368321;
				if (num != 0)
				{
				}
				num = (short)1314848768;
				short num3 = num;
				this.color = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00006130 File Offset: 0x00004330
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000061DC File Offset: 0x000043DC
		public bool IsDragging
		{
			get
			{
				short num = (short)616888700;
				short num2 = num;
				num = (short)137951612;
				switch (num2 == num)
				{
				}
				num = (short)1017708544;
				if (num != 0)
				{
				}
				num = (short)1758658561;
				if (num != 0)
				{
				}
				num = (short)2050686976;
				short num3 = num;
				return this.isDragging;
			}
			protected set
			{
				short num = (short)987971655;
				short num2 = num;
				num = (short)1663057991;
				switch (num2 == num)
				{
				}
				num = (short)380239873;
				if (num != 0)
				{
				}
				num = (short)550961152;
				if (num != 0)
				{
				}
				num = (short)1628110848;
				short num3 = num;
				this.isDragging = value;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006290 File Offset: 0x00004490
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)369886621;
			short num2 = num;
			num = (short)360908189;
			switch (num2 == num)
			{
			}
			num = (short)248971265;
			if (num != 0)
			{
			}
			num = (short)897843200;
			if (num != 0)
			{
			}
			num = (short)1832452096;
			short num3 = num;
			this.IsDragging = false;
			base.OnMouseEnter(e);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006344 File Offset: 0x00004544
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1555048284;
			short num2 = num;
			num = (short)1121331036;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)32833537;
				if (num != 0)
				{
				}
				num = (short)1217462272;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				break;
			}
			int num3;
			for (;;)
			{
				IL_7D:
				switch (num3)
				{
				case 0:
					goto IL_F4;
				case 1:
					this.a();
					num = (short)689504256;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this.IsDragging)
					{
						num = (short)401014785;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F6;
				}
				goto IL_8F;
			}
			IL_F4:
			IL_F6:
			num = (short)1444413440;
			short num4 = num;
			return;
			IL_8F:
			base.OnMouseLeave(e);
			this.IsDragging = (e.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed);
			num = (short)574160898;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7D;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006470 File Offset: 0x00004670
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1945763841;
			if (num != 0)
			{
			}
			num = (short)398244050;
			short num2 = num;
			num = (short)1179105490;
			switch (num2 == num)
			{
			}
			num = (short)49807360;
			if (num != 0)
			{
			}
			num = (short)264175616;
			short num3 = num;
			base.OnMouseLeftButtonDown(e);
			base.IsHitTestVisible = false;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006528 File Offset: 0x00004728
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)565598166;
			short num2 = num;
			num = (short)922179542;
			switch (num2 == num)
			{
			}
			num = (short)1684668416;
			if (num != 0)
			{
			}
			num = (short)2079064065;
			if (num != 0)
			{
			}
			num = (short)1846607872;
			short num3 = num;
			this.IsDragging = false;
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000065DC File Offset: 0x000047DC
		protected override void OnMouseRightButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1986400006;
			short num2 = num;
			num = (short)1610616582;
			switch (num2 == num)
			{
			}
			num = (short)1945108480;
			if (num != 0)
			{
			}
			num = (short)923009025;
			if (num != 0)
			{
			}
			num = (short)2000683008;
			short num3 = num;
			base.ContextMenu = null;
			base.OnMouseRightButtonDown(e);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006694 File Offset: 0x00004894
		private global::System.Windows.Rect f()
		{
			short num = (short)1888485376;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Rect result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 1:
				{
					global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange selectionRange;
					result = this.a(selectionRange.BottomRight);
					num = (short)2078867458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_B9;
				case 3:
					return result;
				case 4:
				{
					int count;
					if (count > 0)
					{
						num = (short)1054736389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::System.Windows.Rect.Empty;
					num = (short)463863811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					num = (short)51795043;
					short num3 = num;
					num = (short)1469863011;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B9;
					default:
					{
						num = (short)692649984;
						if (num != 0)
						{
						}
						int count;
						result = this.a(this.grid.SelectedItems.Cells[count - 1]);
						num = (short)771555336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 6:
					return result;
				case 7:
				{
					global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange selectionRange;
					if (!selectionRange.IsEmpty)
					{
						num = (short)1933180929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::System.Windows.Rect.Empty;
					num = (short)610336774;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					return result;
				case 9:
				{
					num = (short)1580400641;
					if (num != 0)
					{
					}
					int count = this.grid.SelectedItems.Cells.Count;
					num = (short)693633028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_4C:
				if (this.IsDragging)
				{
					num = (short)1225785353;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange selectionRange = this.grid.SelectedItems.Cells.GetSelectionRange();
					num = (short)1179910151;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_B9:
			num = (short)1114636288;
			short num4 = num;
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000068F4 File Offset: 0x00004AF4
		private global::System.Windows.Rect b(global::Infragistics.Windows.DataPresenter.Cell A_0)
		{
			short num = (short)501994216;
			short num2 = num;
			num = (short)995349224;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_75:
				num = (short)1720320003;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1580138496;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				break;
			}
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_103;
				case 1:
					num = (short)99221506;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)214564865;
					if (num != 0)
					{
					}
					if (!cellValuePresenter.IsVisible)
					{
						num = (short)627113984;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_105;
				case 3:
					if (cellValuePresenter != null)
					{
						num = (short)479461377;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A2;
				}
				goto IL_6E;
			}
			IL_A2:
			return global::System.Windows.Rect.Empty;
			IL_103:
			goto IL_A2;
			IL_105:
			num = (short)1606811648;
			short num4 = num;
			global::System.Windows.Point point = cellValuePresenter.TransformToAncestor(base.AdornedElement).Transform(new global::System.Windows.Point(0.0, 0.0));
			global::System.Windows.Rect descendantBounds = global::System.Windows.Media.VisualTreeHelper.GetDescendantBounds(cellValuePresenter);
			descendantBounds.Offset(point.X, point.Y);
			return descendantBounds;
			IL_6E:
			cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(A_0);
			goto IL_75;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006A74 File Offset: 0x00004C74
		private global::Infragistics.Windows.DataPresenter.Cell b(global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::Infragistics.Windows.DataPresenter.Cell result;
			global::Infragistics.Windows.DataPresenter.DataRecordCollection dataRecordCollection;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)1352335361;
					if (num2 != 0)
					{
					}
					global::Infragistics.Windows.DataPresenter.CellCollection cells;
					result = cells[A_0.Column];
					num2 = (short)122880002;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					global::Infragistics.Windows.DataPresenter.CellCollection cells = dataRecordCollection[A_0.Row].Cells;
					num2 = (short)34930691;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return result;
				case 3:
				{
					global::Infragistics.Windows.DataPresenter.CellCollection cells;
					if (A_0.Column < cells.Count)
					{
						num2 = (short)1506017280;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 4:
					goto IL_98;
				}
				goto IL_24;
			}
			IL_98:
			if (A_0.Row < dataRecordCollection.Count)
			{
				goto IL_AA;
			}
			return result;
			IL_24:
			num2 = (short)1720800498;
			short num3 = num2;
			num2 = (short)450122994;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_AA:
				num2 = (short)1487273984;
				short num4 = num2;
				num2 = (short)1301676033;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)791478272;
				if (num2 != 0)
				{
				}
				dataRecordCollection = (this.grid.Records as global::Infragistics.Windows.DataPresenter.DataRecordCollection);
				result = null;
				num2 = (short)468254724;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00006C14 File Offset: 0x00004E14
		private global::System.Windows.Rect a(global::Infragistics.Windows.DataPresenter.Cell A_0)
		{
			short num = (short)146210816;
			short num2 = num;
			num = (short)1413611521;
			if (num != 0)
			{
			}
			global::System.Windows.Rect result = this.b(A_0);
			if (!result.IsEmpty)
			{
				num = (short)39418427;
				short num3 = num;
				num = (short)2038004283;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)963969024;
					if (num != 0)
					{
					}
					result.Location = new global::System.Windows.Point(result.BottomRight.X - 6.0, result.BottomRight.Y - 6.0);
					result.Width = 5.0;
					result.Height = 5.0;
					return result;
				}
			}
			return global::System.Windows.Rect.Empty;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006D34 File Offset: 0x00004F34
		private global::System.Windows.Rect a(global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition A_0)
		{
			global::Infragistics.Windows.DataPresenter.Cell cell = this.b(A_0);
			if (cell == null)
			{
				short num = (short)1074853822;
				short num2 = num;
				num = (short)503445438;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)998965248;
					short num3 = num;
					num = (short)554172417;
					if (num != 0)
					{
					}
					num = (short)1778057216;
					if (num != 0)
					{
					}
					return global::System.Windows.Rect.Empty;
				}
				}
			}
			return this.a(cell);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00006DF8 File Offset: 0x00004FF8
		private global::System.Windows.Media.RectangleGeometry e()
		{
			short num = (short)1331556393;
			short num2 = num;
			num = (short)209842217;
			switch (num2 == num)
			{
			}
			num = (short)1260060672;
			short num3 = num;
			num = (short)1325989888;
			if (num != 0)
			{
			}
			num = (short)716767233;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.FindChildren<global::Infragistics.Windows.DataPresenter.DataRecordPresenter>(this.grid).Where(new global::System.Func<global::Infragistics.Windows.DataPresenter.DataRecordPresenter, bool>(global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeSelectionAdorner.<>c.<>9.a)).SingleOrDefault<global::Infragistics.Windows.DataPresenter.DataRecordPresenter>();
			global::System.Windows.Point point = new global::System.Windows.Point(0.0, dataRecordPresenter.ActualHeight);
			global::System.Windows.Controls.ScrollContentPresenter scrollContentPresenter = global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.FindFirstChild<global::System.Windows.Controls.ScrollContentPresenter, global::System.Windows.Controls.ItemsPresenter>(this.grid);
			global::System.Windows.Point point2 = new global::System.Windows.Point(scrollContentPresenter.RenderSize.Width, scrollContentPresenter.RenderSize.Height);
			return new global::System.Windows.Media.RectangleGeometry(new global::System.Windows.Rect(point, point2));
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00006F30 File Offset: 0x00005130
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			short num = (short)862978048;
			switch (num)
			{
			default:
			{
				num = (short)905445389;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Infragistics.Windows.DataPresenter.SelectedCellCollection cells;
					int count;
					switch (num2)
					{
					case 0:
						goto IL_1DC;
					case 1:
					{
						global::System.Windows.Media.Brush brush = new global::System.Windows.Media.SolidColorBrush(this.Color);
						global::System.Windows.Media.Pen pen = new global::System.Windows.Media.Pen(brush, 1.0);
						drawingContext.PushClip(this.e());
						global::System.Windows.Rect rectangle;
						drawingContext.DrawRectangle(brush, pen, rectangle);
						drawingContext.Pop();
						num = (short)2087976966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange selectionRange;
						global::System.Windows.Rect rectangle = this.a(selectionRange.BottomRight);
						num = (short)1098317824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						return;
					case 4:
						return;
					case 5:
					{
						global::System.Windows.Rect rectangle = this.a(cells[count - 1]);
						num = (short)478806024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return;
					case 7:
					{
						if (this.IsDragging)
						{
							num = (short)1918697477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange selectionRange = cells.GetSelectionRange();
						num = (short)983052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_1DC;
					case 9:
					{
						global::System.Windows.Rect rectangle;
						if (!rectangle.IsEmpty)
						{
							num = (short)1711341569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 10:
						goto IL_1DC;
					case 11:
					{
						num = (short)1612269033;
						short num3 = num;
						num = (short)392054249;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1DC;
						default:
							num = (short)2060976128;
							if (num != 0)
							{
							}
							if (count == 0)
							{
								num = (short)1523318787;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)973340679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
					{
						global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange selectionRange;
						if (!selectionRange.IsEmpty)
						{
							num = (short)1924464642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Rect rectangle = global::System.Windows.Rect.Empty;
						num = (short)1274544138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					}
					IL_7D:
					num = (short)741933056;
					short num4 = num;
					if (!base.IsLoaded)
					{
						num = (short)111673348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					cells = this.grid.SelectedItems.Cells;
					count = cells.Count;
					num = (short)321978379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DC:
					num = (short)953090049;
					if (num != 0)
					{
					}
					num = (short)1882259465;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00007270 File Offset: 0x00005470
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)1374617605;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Rect rect;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1183033889;
					short num3 = num;
					num = (short)583445025;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return finalSize;
					default:
					{
						num = (short)746717184;
						short num4 = num;
						num = (short)1607073792;
						if (num != 0)
						{
						}
						num = (short)1857421313;
						if (num != 0)
						{
						}
						if (this.visualChildren.Count == 1)
						{
							num = (short)762249217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					}
					}
					break;
				}
				case 1:
					goto IL_16E;
				case 2:
					num = (short)1413349376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!rect.IsEmpty)
					{
						num = (short)1614938114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return finalSize;
				case 4:
					rect = this.f();
					num = (short)1605894147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				}
				IL_3D:
				if (!base.IsLoaded)
				{
					return finalSize;
				}
				num = (short)1948450820;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_16E:
			global::System.Windows.FrameworkElement frameworkElement = this.visualChildren[0] as global::System.Windows.FrameworkElement;
			frameworkElement.Arrange(new global::System.Windows.Rect(rect.BottomRight, finalSize));
			return new global::System.Windows.Size(frameworkElement.ActualWidth, frameworkElement.ActualHeight);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00007438 File Offset: 0x00005638
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)113573897;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Rect rect;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)655884290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1ED;
				case 2:
					if (this.visualChildren.Count == 1)
					{
						num = (short)952369153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F2;
				case 3:
					if (constraint.Width != double.PositiveInfinity)
					{
						num = (short)433913860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_182;
				case 4:
					num = (short)2046689288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!rect.IsEmpty)
					{
						num = (short)1487339520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F2;
				case 6:
					rect = this.f();
					num = (short)1283260421;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_DE;
				case 8:
				{
					num = (short)2032074753;
					if (num != 0)
					{
					}
					if (constraint.Height == double.PositiveInfinity)
					{
						num = (short)1326710791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)741874833;
					short num3 = num;
					num = (short)1827085457;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F2;
					default:
						goto IL_271;
					}
					break;
				}
				case 9:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				}
				IL_4C:
				if (base.IsLoaded)
				{
					num = (short)2098659334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1F2:
				num = (short)123863043;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DE:
			IL_182:
			num = (short)142213120;
			short num4 = num;
			return global::System.Windows.Size.Empty;
			IL_1ED:
			global::System.Windows.FrameworkElement frameworkElement = this.visualChildren[0] as global::System.Windows.FrameworkElement;
			frameworkElement.Measure(constraint);
			return new global::System.Windows.Size(frameworkElement.DesiredSize.Width + rect.Size.Width, frameworkElement.DesiredSize.Height + rect.Size.Height);
			IL_271:
			num = (short)2019557376;
			if (num != 0)
			{
			}
			return constraint;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000076CC File Offset: 0x000058CC
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			base.OnVisualParentChanged(oldParent);
			if (oldParent == null)
			{
				short num = (short)875823105;
				if (num != 0)
				{
				}
				num = (short)797021424;
				short num2 = num;
				num = (short)213226736;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)322306048;
					if (num != 0)
					{
					}
					num = (short)599654400;
					short num3 = num;
					break;
				}
				}
				this.d();
				return;
			}
			this.c();
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00007790 File Offset: 0x00005990
		protected override int VisualChildrenCount
		{
			get
			{
				short num = (short)257544588;
				short num2 = num;
				num = (short)1898566028;
				switch (num2 == num)
				{
				}
				num = (short)1147404288;
				short num3 = num;
				num = (short)2069626881;
				if (num != 0)
				{
				}
				num = (short)959119360;
				if (num != 0)
				{
				}
				return this.visualChildren.Count;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00007844 File Offset: 0x00005A44
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			short num = (short)1873606899;
			short num2 = num;
			num = (short)1474361587;
			switch (num2 == num)
			{
			}
			num = (short)2026438656;
			short num3 = num;
			num = (short)742260736;
			if (num != 0)
			{
			}
			num = (short)278724609;
			if (num != 0)
			{
			}
			return this.visualChildren[index];
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000078F8 File Offset: 0x00005AF8
		private void d()
		{
			short num = (short)1993884694;
			short num2 = num;
			num = (short)748766230;
			switch (num2 == num)
			{
			}
			num = (short)1120337920;
			short num3 = num;
			num = (short)1239416833;
			if (num != 0)
			{
			}
			num = (short)96665600;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = this.Grid;
			dataPresenterBase.SelectedItemsChanged += this.a;
			dataPresenterBase.ScrollInfo.ScrollOwner.ScrollChanged += this.a;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000079D8 File Offset: 0x00005BD8
		private void c()
		{
			short num = (short)1868746816;
			short num2 = num;
			num = (short)419942464;
			switch (num2 == num)
			{
			}
			num = (short)1718747136;
			short num3 = num;
			num = (short)2026045441;
			if (num != 0)
			{
			}
			num = (short)771096576;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = this.Grid;
			dataPresenterBase.SelectedItemsChanged -= this.a;
			dataPresenterBase.ScrollInfo.ScrollOwner.ScrollChanged -= this.a;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00007AB0 File Offset: 0x00005CB0
		private void a(object A_0, global::System.Windows.Controls.ScrollChangedEventArgs A_1)
		{
			short num = (short)710408272;
			short num2 = num;
			num = (short)19920976;
			switch (num2 == num)
			{
			}
			num = (short)1448869888;
			short num3 = num;
			num = (short)1062797313;
			if (num != 0)
			{
			}
			num = (short)923336704;
			if (num != 0)
			{
			}
			base.InvalidateVisual();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007B64 File Offset: 0x00005D64
		private void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs A_1)
		{
			short num = (short)706398206;
			short num2 = num;
			num = (short)256362494;
			switch (num2 == num)
			{
			}
			num = (short)298123264;
			short num3 = num;
			num = (short)1029046273;
			if (num != 0)
			{
			}
			num = (short)1117519872;
			if (num != 0)
			{
			}
			base.InvalidateVisual();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00007C14 File Offset: 0x00005E14
		private void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num;
			try
			{
				num = (short)1652717487;
				short num2 = num;
				num = (short)271808431;
				switch (num2 == num)
				{
				}
				num = (short)1440743424;
				if (num != 0)
				{
				}
				num = (short)1620574209;
				if (num != 0)
				{
				}
				this.a(false);
			}
			catch
			{
			}
			finally
			{
				base.InvalidateVisual();
			}
			num = (short)1728905216;
			short num3 = num;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00007CF0 File Offset: 0x00005EF0
		public void Dispose()
		{
			short num = (short)614529882;
			short num2 = num;
			num = (short)2124544858;
			switch (num2 == num)
			{
			}
			num = (short)669188096;
			short num3 = num;
			num = (short)790429697;
			if (num != 0)
			{
			}
			num = (short)1686437888;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007DA8 File Offset: 0x00005FA8
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)15859713;
			if (num != 0)
			{
			}
			num = (short)1107427330;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1769414758;
					short num3 = num;
					num = (short)587407462;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1267662848;
						if (num != 0)
						{
						}
						num = (short)446496768;
						short num4 = num;
						this.c();
						break;
					}
					}
					num = (short)731381761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				}
				IL_57:
				if (!disposing)
				{
					break;
				}
				num = (short)2081357824;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00007EBC File Offset: 0x000060BC
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00007F6C File Offset: 0x0000616C
		private global::System.Windows.Input.Cursor OldCursor
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1744284151;
				short num2 = num;
				num = (short)229026295;
				switch (num2 == num)
				{
				}
				num = (short)523173888;
				short num3 = num;
				num = (short)470614016;
				if (num != 0)
				{
				}
				num = (short)298778625;
				if (num != 0)
				{
				}
				return this.<OldCursor>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1582987718;
				short num2 = num;
				num = (short)1334475206;
				switch (num2 == num)
				{
				}
				num = (short)1497432064;
				short num3 = num;
				num = (short)602472449;
				if (num != 0)
				{
				}
				num = (short)1458438144;
				if (num != 0)
				{
				}
				this.<OldCursor>k__BackingField = value;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000801C File Offset: 0x0000621C
		private void a()
		{
			short num = (short)961413121;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_42;
			}
			int num2;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
					goto IL_D1;
				case 1:
				{
					num = (short)1308164096;
					short num3 = num;
					num = (short)1242948322;
					short num4 = num;
					num = (short)27386594;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D1;
					default:
						goto IL_173;
					}
					break;
				}
				case 2:
					if (this.DragSelectionStarted != null)
					{
						num = (short)818479104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_42;
				IL_D1:
				global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange selectionRange = this.Grid.SelectedItems.Cells.GetSelectionRange();
				this.DragSelectionStarted(new global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedEventArgs(selectionRange));
				num = (short)1599078401;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_173:
			num = (short)2014707712;
			if (num != 0)
			{
			}
			return;
			IL_42:
			base.IsHitTestVisible = false;
			this.OldCursor = this.Grid.Cursor;
			this.Grid.Cursor = base.Cursor;
			this.Grid.PreviewMouseLeftButtonUp += this.a;
			this.Grid.PreviewKeyUp += this.a;
			num = (short)189399042;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000081B4 File Offset: 0x000063B4
		private void a(bool A_0)
		{
			this.Grid.PreviewMouseLeftButtonUp -= this.a;
			this.Grid.PreviewKeyUp -= this.a;
			this.IsDragging = false;
			this.Grid.Cursor = this.OldCursor;
			this.OldCursor = null;
			base.IsHitTestVisible = true;
			short num;
			try
			{
				num = (short)2037448712;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange cellRange;
					switch (num2)
					{
					case 0:
						goto IL_202;
					case 1:
					{
						if (A_0)
						{
							num = (short)1043660802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)195221594;
						short num3 = num;
						num = (short)1180751962;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_168;
						default:
							num = (short)1434189824;
							if (num != 0)
							{
							}
							cellRange = this.Grid.SelectedItems.Cells.GetSelectionRange();
							num = (short)927465478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						cellRange = global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange.Empty;
						this.Grid.SelectedItems.Cells.Clear();
						num = (short)1145569287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_21B;
					case 4:
						goto IL_202;
					case 5:
						num = (short)1664417793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_157;
					case 7:
						goto IL_157;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_9E;
						}
						continue;
					}
					IL_9E:
					if (this.DragSelectionCompleted != null)
					{
						num = (short)1205075973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.Grid.SelectedItems.Cells.Clear();
					num = (short)1006829572;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_168:
					num = (short)1428422656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_157:
					this.DragSelectionCompleted(new global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionEndedEventArgs(cellRange));
					goto IL_168;
					IL_202:
					num = (short)1833893891;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_21B:;
			}
			catch
			{
			}
			finally
			{
				base.InvalidateVisual();
			}
			num = (short)1892024320;
			short num4 = num;
			num = (short)1998651393;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000846C File Offset: 0x0000666C
		private void a(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)1104740354;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1903562320;
					short num3 = num;
					num = (short)544018000;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1181941761;
						if (num != 0)
						{
						}
						num = (short)278069248;
						if (num != 0)
						{
						}
						num = (short)1368195072;
						short num4 = num;
						this.a(true);
						break;
					}
					}
					num = (short)1694105601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (A_1.Key != global::System.Windows.Input.Key.Escape)
				{
					break;
				}
				num = (short)335347712;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0400002A RID: 42
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase grid;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Media.VisualCollection visualChildren;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Media.Color color;

		// Token: 0x0400002D RID: 45
		private bool isDragging;
	}
}
