using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.UI.CellRangeSelect
{
	// Token: 0x0200000C RID: 12
	public class CellRangeSelectionManager : global::Motorola.CommonCPS.UI.CellRangeSelect.ICellRangeSelectionManager, global::System.IDisposable
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00008704 File Offset: 0x00006904
		public CellRangeSelectionManager(global::Infragistics.Windows.DataPresenter.DataPresenterBase grid, global::System.Func<string, bool> IsColumnSelectable) : this(grid, IsColumnSelectable, global::System.Windows.Media.Colors.SteelBlue, global::System.Windows.Input.Cursors.Hand)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00008724 File Offset: 0x00006924
		internal CellRangeSelectionManager(global::Infragistics.Windows.DataPresenter.DataPresenterBase A_0, global::System.Func<string, bool> A_1, global::System.Windows.Media.Color A_2, global::System.Windows.Input.Cursor A_3)
		{
			int a_ = 12;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.b("氊缌明甐", a_));
			}
			if (A_1 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.b("䈊縌䰎縐缒怔稖眘䠚砜猞䐠䀢儤䘦䬨䜪䠬", a_));
			}
			if (A_3 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.b("栊砌紎成簒朔", a_));
			}
			A_0.SelectedItemsChanging += this.a;
			A_0.SelectedItemsChanged += this.a;
			A_0.RecordsInViewChanged += this.a;
			A_0.Sorted += this.a;
			this.a = A_0;
			this.c = A_1;
			this.d = A_2;
			this.e = A_3;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000087F4 File Offset: 0x000069F4
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)537543238;
				short num2 = num;
				num = (short)429343302;
				switch (num2 == num)
				{
				}
				num = (short)1414135808;
				if (num != 0)
				{
				}
				num = (short)1898381313;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)226361344;
			short num3 = num;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000088C0 File Offset: 0x00006AC0
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00008970 File Offset: 0x00006B70
		public global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler DragSelectionStarted
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1087700993;
				if (num != 0)
				{
				}
				num = (short)513745128;
				short num2 = num;
				num = (short)583737576;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1432551424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)15400960;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1910955480;
				short num2 = num;
				num = (short)335732184;
				switch (num2 == num)
				{
				}
				num = (short)1663631360;
				short num3 = num;
				num = (short)62980097;
				if (num != 0)
				{
				}
				num = (short)1506213888;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00008A20 File Offset: 0x00006C20
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00008AD4 File Offset: 0x00006CD4
		public global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler DragSelectionEnded
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)508034741;
				short num2 = num;
				num = (short)895876789;
				switch (num2 == num)
				{
				}
				num = (short)1444020224;
				short num3 = num;
				num = (short)347013121;
				if (num != 0)
				{
				}
				num = (short)1537212416;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)603677156;
				short num2 = num;
				num = (short)649814500;
				switch (num2 == num)
				{
				}
				num = (short)776863744;
				short num3 = num;
				num = (short)574816257;
				if (num != 0)
				{
				}
				num = (short)43974656;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00008B84 File Offset: 0x00006D84
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1030933540;
			short num2 = num;
			num = (short)544001060;
			switch (num2 == num)
			{
			}
			num = (short)2118778880;
			short num3 = num;
			num = (short)893321216;
			if (num != 0)
			{
			}
			num = (short)1775501313;
			if (num != 0)
			{
			}
			this.b.DragSelectionStarted += this.a;
			this.b.DragSelectionCompleted += this.a;
			this.b.InvalidateVisual();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00008C68 File Offset: 0x00006E68
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)846210494;
			short num2 = num;
			num = (short)1639720382;
			switch (num2 == num)
			{
			}
			num = (short)723124224;
			short num3 = num;
			num = (short)515244033;
			if (num != 0)
			{
			}
			num = (short)2139881472;
			if (num != 0)
			{
			}
			this.b.DragSelectionStarted -= this.a;
			this.b.DragSelectionCompleted -= this.a;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00008D40 File Offset: 0x00006F40
		private void a(global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedEventArgs A_0)
		{
			short num = (short)2121859074;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)530413004;
					short num3 = num;
					num = (short)1247114700;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2122776576;
						if (num != 0)
						{
						}
						num = (short)57868288;
						short num4 = num;
						this.DragSelectionStarted(A_0);
						break;
					}
					}
					num = (short)394723329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				IL_32:
				num = (short)214827009;
				if (num != 0)
				{
				}
				if (this.DragSelectionStarted == null)
				{
					break;
				}
				num = (short)916324352;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00008E64 File Offset: 0x00007064
		private void a(global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionEndedEventArgs A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange selectionRange;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					selectionRange = A_0.SelectionRange;
					goto IL_12E;
				case 1:
					num2 = (short)751173634;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.DragSelectionEnded != null)
					{
						num2 = (short)1848639496;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					if (!selectionRange.IsEmpty)
					{
						num2 = (short)229965824;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
				{
					num2 = (short)1182072832;
					short num3 = num2;
					num2 = (short)1967381660;
					short num4 = num2;
					num2 = (short)2040257692;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12E;
					default:
						num2 = (short)1325596672;
						if (num2 != 0)
						{
						}
						if (!selectionRange.IsSingleCellRange)
						{
							num2 = (short)434438151;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 5:
					return;
				case 6:
					if (selectionRange.IsSingleColumnRange)
					{
						num2 = (short)1899560961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
					selectionRange = A_0.SelectionRange;
					num2 = (short)1507393542;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					this.DragSelectionEnded(A_0);
					num2 = (short)1818492933;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_34;
				IL_12E:
				num2 = (short)38469636;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_34:
			selectionRange = A_0.SelectionRange;
			num2 = (short)734461953;
			if (num2 != 0)
			{
			}
			num2 = (short)422903811;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00009074 File Offset: 0x00007274
		private void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangingEventArgs A_1)
		{
			short num = (short)338886666;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.c(A_1.NewSelection.Cells[0].Field.Name))
					{
						num = (short)563806215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34C;
				case 1:
					if (A_1.Type == typeof(global::Infragistics.Windows.DataPresenter.Cell))
					{
						num = (short)1059717129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34C;
				case 2:
				{
					global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange selectionRange;
					if (selectionRange.IsSingleColumnRange)
					{
						num = (short)1881145344;
						short num3 = num;
						num = (short)622133256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27E;
				}
				case 3:
					num = (short)1494482957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1096024064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)2121203727;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange selectionRange;
					if (!selectionRange.IsEmpty)
					{
						num = (short)398524427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27E;
				}
				case 7:
				{
					global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange selectionRange = A_1.NewSelection.Cells.GetSelectionRange();
					num = (short)1721761798;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					goto IL_144;
				case 9:
					num = (short)1540358158;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)1379168891;
					short num4 = num;
					num = (short)24343163;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_144;
					default:
						num = (short)695730176;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_AE;
						}
						continue;
					}
					break;
				}
				case 11:
					num = (short)1022230530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_1E6;
				case 13:
					if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl))
					{
						num = (short)965476357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D7;
				case 14:
					num = (short)91226113;
					if (num != 0)
					{
					}
					if (A_1.NewSelection.Cells.Count > 0)
					{
						num = (short)560791556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34C;
				case 15:
					if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightCtrl))
					{
						num = (short)1165623308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28C;
				}
				IL_AE:
				if (A_1.Type == typeof(global::Infragistics.Windows.DataPresenter.Cell))
				{
					num = (short)1809776643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_28C:
				num = (short)914292737;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_144:
			this.LoadSelectionAdorner();
			return;
			IL_1E6:
			goto IL_2D7;
			IL_27E:
			this.UnloadSelectionAdorner();
			A_1.Cancel = true;
			return;
			IL_2D7:
			this.UnloadSelectionAdorner();
			return;
			IL_34C:
			this.UnloadSelectionAdorner();
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000093D4 File Offset: 0x000075D4
		private void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs A_1)
		{
			short num = (short)494534656;
			short num2 = num;
			num = (short)1573034706;
			short num3 = num;
			num = (short)1606064850;
			switch (num3 == num)
			{
			}
			num = (short)493289472;
			if (num != 0)
			{
			}
			num = (short)402587649;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00009484 File Offset: 0x00007684
		private void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.RecordsInViewChangedEventArgs A_1)
		{
			short num = (short)895483904;
			short num2 = num;
			num = (short)930267506;
			short num3 = num;
			num = (short)1211548018;
			switch (num3 == num)
			{
			}
			num = (short)1626931201;
			if (num != 0)
			{
			}
			num = (short)426770432;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00009534 File Offset: 0x00007734
		private void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.SortedEventArgs A_1)
		{
			short num = (short)1823539200;
			short num2 = num;
			num = (short)1924383535;
			short num3 = num;
			num = (short)878297903;
			switch (num3 == num)
			{
			}
			num = (short)82313216;
			if (num != 0)
			{
			}
			num = (short)1080754177;
			if (num != 0)
			{
			}
			this.UnloadSelectionAdorner();
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000095E0 File Offset: 0x000077E0
		public bool IsSelectionAdornerLoaded
		{
			get
			{
				short num = (short)1492483397;
				short num2 = num;
				num = (short)367295813;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1333657600;
					short num3 = num;
					num = (short)620363777;
					if (num != 0)
					{
					}
					num = (short)1049755648;
					if (num != 0)
					{
					}
					if (this.b != null)
					{
						return this.b.IsLoaded;
					}
					break;
				}
				}
				return false;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000096A0 File Offset: 0x000078A0
		public void LoadSelectionAdorner()
		{
			short num = (short)290521088;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 1:
					goto IL_154;
				case 2:
				{
					global::System.Windows.Controls.ScrollContentPresenter a_ = global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.FindFirstChild<global::System.Windows.Controls.ScrollContentPresenter, global::System.Windows.Controls.ItemsPresenter>(this.a);
					this.b = new global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeSelectionAdorner(a_, this.a, this.d, this.e);
					this.b.ToolTip = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_FillOperation_Tooltip;
					this.b.Loaded += this.b;
					this.b.Unloaded += this.a;
					this.b.Color = this.d;
					this.b.Cursor = this.e;
					num = (short)2107965443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_13D;
				case 4:
					(this.b.AdornedElement as global::System.Windows.Controls.ScrollContentPresenter).AdornerLayer.Add(this.b);
					num = (short)785973253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				}
				IL_3D:
				num = (short)1518927872;
				short num3 = num;
				if (this.b == null)
				{
					num = (short)1407218516;
					short num4 = num;
					num = (short)343962452;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_154;
					default:
						num = (short)2080374785;
						if (num != 0)
						{
						}
						num = (short)902299648;
						if (num != 0)
						{
						}
						num = (short)862912514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
				}
				IL_13D:
				num = (short)1583022081;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_154:
				if (this.b.IsLoaded)
				{
					break;
				}
				num = (short)826277892;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000098D4 File Offset: 0x00007AD4
		public void UnloadSelectionAdorner()
		{
			short num = (short)817692672;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)929890304;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				}
				case 1:
					return;
				case 2:
				{
					num = (short)1654361870;
					short num4 = num;
					num = (short)630558478;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)87293952;
						if (num != 0)
						{
						}
						(this.b.AdornedElement as global::System.Windows.Controls.ScrollContentPresenter).AdornerLayer.Remove(this.b);
						num = (short)2113929217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_5A:
				num = (short)1852768257;
				if (num != 0)
				{
				}
				if (this.b == null)
				{
					break;
				}
				num = (short)871825410;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00009A10 File Offset: 0x00007C10
		private void a()
		{
			short num = (short)458883072;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)847511552;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				}
				case 1:
					return;
				case 2:
				{
					num = (short)1773113363;
					short num4 = num;
					num = (short)1675923475;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)560070656;
						if (num != 0)
						{
						}
						this.b.InvalidateVisual();
						num = (short)806354945;
						if (num != 0)
						{
						}
						num = (short)960561153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_59:
				if (!this.IsSelectionAdornerLoaded)
				{
					break;
				}
				num = (short)947847170;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00009B34 File Offset: 0x00007D34
		public global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeSelectionAdorner SelectionAdorner
		{
			get
			{
				short num = (short)1490223104;
				short num2 = num;
				num = (short)1129418129;
				short num3 = num;
				num = (short)1248169361;
				switch (num3 == num)
				{
				}
				num = (short)2107310081;
				if (num != 0)
				{
				}
				num = (short)910819328;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00009BE4 File Offset: 0x00007DE4
		public global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange GetSelectionRange()
		{
			short num = (short)1395720192;
			int num2 = (int)((global::System.IntPtr)num);
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
					goto IL_146;
				case 2:
					goto IL_122;
				case 3:
					num = (short)537657346;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_34:
				num = (short)556466177;
				if (num != 0)
				{
				}
				num = (short)1788215296;
				short num3 = num;
				num = (short)414512519;
				short num4 = num;
				num = (short)1912927623;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_122:
					if (!this.b.IsLoaded)
					{
						goto IL_148;
					}
					num = (short)357695489;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)947781632;
					if (num != 0)
					{
					}
					if (this.b == null)
					{
						goto IL_148;
					}
					num = (short)172490755;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_146:
			return this.a.SelectedItems.Cells.GetSelectionRange();
			IL_148:
			return global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange.Empty;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00009D40 File Offset: 0x00007F40
		public void Dispose()
		{
			short num = (short)1444610048;
			short num2 = num;
			num = (short)1146219145;
			short num3 = num;
			num = (short)1894115977;
			switch (num3 == num)
			{
			}
			num = (short)1708720129;
			if (num != 0)
			{
			}
			num = (short)1076297728;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00009DFC File Offset: 0x00007FFC
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)290390016;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14;
				case 1:
					return;
				case 2:
				{
					num = (short)1729754146;
					short num3 = num;
					num = (short)1004336162;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)580321280;
						if (num != 0)
						{
						}
						this.UnloadSelectionAdorner();
						this.b.DragSelectionStarted -= this.a;
						this.b.DragSelectionCompleted -= this.a;
						((global::System.IDisposable)this.b).Dispose();
						num = (short)1265500161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
				{
					num = (short)473497600;
					short num4 = num;
					if (this.b != null)
					{
						num = (short)1957691394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 4:
					this.a.SelectedItemsChanging -= this.a;
					this.a.SelectedItemsChanged -= this.a;
					this.a.RecordsInViewChanged -= this.a;
					num = (short)1063649283;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5E;
				IL_14:
				num = (short)652738561;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					IL_5E:
					if (!disposing)
					{
						return;
					}
					num = (short)811859972;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x04000033 RID: 51
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase a;

		// Token: 0x04000034 RID: 52
		private global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeSelectionAdorner b;

		// Token: 0x04000035 RID: 53
		private global::System.Func<string, bool> c;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Media.Color d;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Input.Cursor e;

		// Token: 0x04000038 RID: 56
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler f;

		// Token: 0x04000039 RID: 57
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler g;
	}
}
