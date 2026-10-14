using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.UI.CellRangeFill.Constraints;
using Motorola.CommonCPS.UI.CellRangeFill.UndoRedo;
using Motorola.CommonCPS.UI.CellRangeSelect;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x02000012 RID: 18
	public class CellRangeFillManager : global::System.IDisposable
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00005A0C File Offset: 0x00003C0C
		public CellRangeFillManager(global::Motorola.CommonCPS.UI.CellRangeFill.IGridSorting gridSorting, global::System.Type setCellValueTaskType, global::Motorola.CommonCPS.UI.CellRangeFill.IPostFillActionResolver postFillActionResolver)
		{
			int a_ = 5;
			base..ctor();
			if (gridSorting == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("ꯋ볍맏뛑蟓맕꫗껙뗛냝蟟", a_));
			}
			if (setCellValueTaskType == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("뿋ꯍ꓏金뇓뫕듗賙뷛닝闟蟡냣蟥鯧臩룫韭胯韱", a_));
			}
			if (postFillActionResolver == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("볋ꇍꏏꛑ鋓뿕듗뛙鷛뷝铟诡诣裥뫧迩鿫臭鳯蓱釳蓵", a_));
			}
			this.a = gridSorting.Grid;
			this.j = gridSorting;
			this.a.KeyDown += this.a;
			this.b = new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBindingCollection();
			this.c = new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBindingCollection();
			this.d = new global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.CellValueConstraintBindingCollection();
			this.e = new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.D, global::System.Windows.Input.ModifierKeys.Control);
			this.f = new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.D, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control);
			this.g = new global::System.Windows.Input.MouseGesture(global::System.Windows.Input.MouseAction.LeftClick);
			this.h = new global::System.Windows.Input.MouseButtonEventArgs(global::System.Windows.Input.Mouse.PrimaryDevice, 0, global::System.Windows.Input.MouseButton.Left)
			{
				RoutedEvent = global::System.Windows.Input.Mouse.MouseUpEvent
			};
			this.i = new global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeSelectionManager(this.a, new global::System.Func<string, bool>(this.c));
			global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeSelectionManager cellRangeSelectionManager = this.i;
			cellRangeSelectionManager.DragSelectionStarted = (global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler)global::System.Delegate.Combine(cellRangeSelectionManager.DragSelectionStarted, new global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler(this.a));
			global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeSelectionManager cellRangeSelectionManager2 = this.i;
			cellRangeSelectionManager2.DragSelectionEnded = (global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler)global::System.Delegate.Combine(cellRangeSelectionManager2.DragSelectionEnded, new global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler(this.a));
			this.k = setCellValueTaskType;
			this.l = postFillActionResolver;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005B84 File Offset: 0x00003D84
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1030515585;
				short num2 = num;
				num = (short)114584449;
				switch (num2 == num)
				{
				}
				num = (short)2127101952;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				num = (short)1021181953;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)828440576;
			short num3 = num;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00005C4C File Offset: 0x00003E4C
		public global::System.Type SetCellValueTaskType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1341645809;
				short num2 = num;
				num = (short)1618207729;
				switch (num2 == num)
				{
				}
				num = (short)502726656;
				short num3 = num;
				num = (short)866189313;
				if (num != 0)
				{
				}
				num = (short)1109917696;
				if (num != 0)
				{
				}
				return this.k;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00005CFC File Offset: 0x00003EFC
		public global::Motorola.CommonCPS.UI.CellRangeFill.IPostFillActionResolver PostFillActionResolver
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)215154688;
				short num2 = num;
				num = (short)192961429;
				short num3 = num;
				num = (short)346315669;
				switch (num3 == num)
				{
				}
				num = (short)1938423809;
				if (num != 0)
				{
				}
				num = (short)2120548352;
				if (num != 0)
				{
				}
				return this.l;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00005DAC File Offset: 0x00003FAC
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase Grid
		{
			get
			{
				short num = (short)857014272;
				short num2 = num;
				num = (short)876632721;
				short num3 = num;
				num = (short)564026001;
				switch (num3 == num)
				{
				}
				num = (short)709689345;
				if (num != 0)
				{
				}
				num = (short)826867712;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00005E5C File Offset: 0x0000405C
		public global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeSelectionManager SelectionManager
		{
			get
			{
				short num = (short)835518464;
				short num2 = num;
				num = (short)288321999;
				short num3 = num;
				num = (short)2113761743;
				switch (num3 == num)
				{
				}
				num = (short)1498218497;
				if (num != 0)
				{
				}
				num = (short)76414976;
				if (num != 0)
				{
				}
				return this.i;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00005F0C File Offset: 0x0000410C
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00005FC0 File Offset: 0x000041C0
		public global::System.Windows.Input.KeyGesture CopyFillKeyGesture
		{
			get
			{
				short num = (short)247857152;
				short num2 = num;
				num = (short)472242493;
				short num3 = num;
				num = (short)974772541;
				switch (num3 == num)
				{
				}
				num = (short)1481506817;
				if (num != 0)
				{
				}
				num = (short)1543634944;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1999503360;
				short num2 = num;
				num = (short)1790956395;
				short num3 = num;
				num = (short)811979627;
				switch (num3 == num)
				{
				}
				num = (short)1577123840;
				if (num != 0)
				{
				}
				num = (short)1166409729;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00006070 File Offset: 0x00004270
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00006120 File Offset: 0x00004320
		public global::System.Windows.Input.KeyGesture SeriesFillKeyGesture
		{
			get
			{
				short num = (short)353042432;
				short num2 = num;
				num = (short)677897167;
				short num3 = num;
				num = (short)613999567;
				switch (num3 == num)
				{
				}
				num = (short)1520304129;
				if (num != 0)
				{
				}
				num = (short)516947968;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1382612992;
				short num2 = num;
				num = (short)1618939915;
				short num3 = num;
				num = (short)1819086859;
				switch (num3 == num)
				{
				}
				num = (short)1397686273;
				if (num != 0)
				{
				}
				num = (short)698613760;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000061D0 File Offset: 0x000043D0
		public global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.CellValueConstraintBindingCollection CellValueConstraintBindings
		{
			get
			{
				short num = (short)571015168;
				short num2 = num;
				num = (short)525898972;
				short num3 = num;
				num = (short)546477276;
				switch (num3 == num)
				{
				}
				num = (short)985923585;
				if (num != 0)
				{
				}
				num = (short)1354301440;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00006280 File Offset: 0x00004480
		public global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBindingCollection CellValueSetterBindings
		{
			get
			{
				short num = (short)272236544;
				short num2 = num;
				num = (short)960826306;
				short num3 = num;
				num = (short)1028787138;
				switch (num3 == num)
				{
				}
				num = (short)410320897;
				if (num != 0)
				{
				}
				num = (short)1558708224;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000632C File Offset: 0x0000452C
		public global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBindingCollection CellRangeFillerBindings
		{
			get
			{
				short num = (short)249495552;
				short num2 = num;
				num = (short)2094830713;
				short num3 = num;
				num = (short)893162617;
				switch (num3 == num)
				{
				}
				num = (short)1207894016;
				if (num != 0)
				{
				}
				num = (short)251658241;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000063DC File Offset: 0x000045DC
		private void a(global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedEventArgs A_0)
		{
			short num = (short)1434189824;
			short num2 = num;
			num = (short)1980862667;
			short num3 = num;
			num = (short)1955107019;
			switch (num3 == num)
			{
			}
			num = (short)682819585;
			if (num != 0)
			{
			}
			num = (short)811204608;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00006488 File Offset: 0x00004688
		private void a(global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionEndedEventArgs A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_46;
			}
			short num;
			int num3;
			global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange selectionRange;
			for (;;)
			{
				IL_0A:
				num = (short)640679936;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_D5;
				case 1:
					if (!selectionRange.IsEmpty)
					{
						num = (short)1332543489;
						if (num != 0)
						{
						}
						num = (short)1941438466;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D5;
				case 2:
					IL_A8:
					this.a(this.h, A_0.SelectionRange);
					num = (short)187629568;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_46;
				IL_D5:
				num = (short)1192384847;
				short num4 = num;
				num = (short)1320507727;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A8;
				default:
					goto IL_10A;
				}
			}
			IL_10A:
			num = (short)1054343168;
			if (num != 0)
			{
			}
			return;
			IL_46:
			selectionRange = A_0.SelectionRange;
			num = (short)413138945;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000065B4 File Offset: 0x000047B4
		private bool c(string A_0)
		{
			short num = (short)2010644480;
			short num2 = num;
			num = (short)1604583425;
			if (num != 0)
			{
			}
			num = (short)824513055;
			short num3 = num;
			num = (short)2040664607;
			switch (num3 == num)
			{
			}
			num = (short)1123942400;
			if (num != 0)
			{
			}
			return this.c.Contains(A_0);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00006668 File Offset: 0x00004868
		private void a(global::System.Windows.Input.InputEventArgs A_0, global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange A_1)
		{
			short num = (short)1611137034;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillContext[] array2;
			for (;;)
			{
				global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding[] array;
				global::Infragistics.Windows.DataPresenter.Field field;
				switch (num2)
				{
				case 0:
					goto IL_151;
				case 1:
				{
					num = (short)787218432;
					short num3 = num;
					if (!A_1.IsSingleCellRange)
					{
						num = (short)1256587272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 2:
					num = (short)1809580037;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!this.a(A_1))
					{
						num = (short)1002307593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10A;
				case 4:
					num = (short)312672257;
					if (num != 0)
					{
					}
					num = (short)1628176385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (array.Length == 0)
					{
						num = (short)2057699342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
				case 6:
					num = (short)1309540364;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)557711363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)270336016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					return;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				case 11:
					if (array != null)
					{
						num = (short)1222639618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
					if (array[0].Filler.Operation == global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation.FillSeries)
					{
						num = (short)1859780615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10A;
				case 13:
					if (array.Length == 1)
					{
						num = (short)238288902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10A;
				case 14:
				{
					num = (short)282504364;
					short num4 = num;
					num = (short)1312009388;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D0;
					default:
						goto IL_252;
					}
					break;
				}
				case 15:
					if (array2.Length == 1)
					{
						num = (short)752549888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34C;
				case 16:
					if (!A_1.IsSingleColumnRange)
					{
						num = (short)1561657361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					field = this.c(A_1);
					array = this.a(field.Name, A_0);
					num = (short)1674706955;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_191;
				}
				IL_6E:
				if (!A_1.IsEmpty)
				{
					num = (short)330432516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_D0:
				num = (short)2133917709;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10A:
				array2 = this.a(field.Name, array, A_1);
				num = (short)1326776335;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_151:
			this.a(array2[0]);
			return;
			IL_191:
			return;
			IL_252:
			num = (short)828112896;
			if (num != 0)
			{
			}
			return;
			IL_34C:
			this.a(array2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000069C8 File Offset: 0x00004BC8
		private global::Infragistics.Windows.DataPresenter.Field c(global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange A_0)
		{
			short num = (short)707919872;
			short num2 = num;
			num = (short)1739366197;
			short num3 = num;
			num = (short)1480433461;
			switch (num3 == num)
			{
			}
			num = (short)123011072;
			if (num != 0)
			{
			}
			num = (short)709492737;
			if (num != 0)
			{
			}
			return this.a.DefaultFieldLayout.Fields[A_0.StartColumn];
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00006A8C File Offset: 0x00004C8C
		private global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter b(string A_0)
		{
			short num;
			for (;;)
			{
				num = (short)2034040832;
				short num2 = num;
				if (this.b.Contains(A_0))
				{
					break;
				}
				num = (short)569586352;
				short num3 = num;
				num = (short)66532016;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_85;
				}
			}
			return this.b[A_0].ValueSetter;
			IL_85:
			num = (short)1833959424;
			if (num != 0)
			{
			}
			num = (short)1279590401;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00006B5C File Offset: 0x00004D5C
		private global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint a(string A_0)
		{
			short num;
			for (;;)
			{
				num = (short)839516160;
				short num2 = num;
				num = (short)442105857;
				if (num != 0)
				{
				}
				if (this.d.Contains(A_0))
				{
					break;
				}
				num = (short)154442843;
				short num3 = num;
				num = (short)1534041179;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A8;
				}
			}
			return this.d[A_0].Constraint;
			IL_A8:
			num = (short)110821376;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006C28 File Offset: 0x00004E28
		private global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillContext[] a(string A_0, global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding[] A_1, global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange A_2)
		{
			short num = (short)1028325376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1212219393;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_7E;
				}
				global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillContext[] array;
				for (;;)
				{
					IL_4F:
					global::Motorola.CommonCPS.UI.CellRangeFill.FillDirection fillDirection;
					int num3;
					global::Infragistics.Windows.DataPresenter.DataRecordCollection records;
					global::Motorola.CommonCPS.UI.CellRangeFill.FillDirection direction;
					global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter cellValueSetter;
					global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint constraint;
					switch (num2)
					{
					case 0:
						goto IL_298;
					case 1:
						goto IL_279;
					case 2:
						if (A_2.RowOrder != global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeOrder.Ascending)
						{
							num = (short)551157765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)86704135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_139;
					case 4:
						goto IL_139;
					case 5:
						num = (short)2087518214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						fillDirection = global::Motorola.CommonCPS.UI.CellRangeFill.FillDirection.Up;
						goto IL_247;
					case 7:
						fillDirection = global::Motorola.CommonCPS.UI.CellRangeFill.FillDirection.Down;
						goto IL_247;
					case 8:
					{
						if (num3 >= array.Length)
						{
							num = (short)1407189001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillParameter fillParameter = new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillParameter(records, A_0, A_2, direction, cellValueSetter, constraint, this.SetCellValueTaskType, this.Grid.SelectedItems.Cells.GetSelectionIndexes());
						global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding cellRangeFillerBinding = A_1[num3];
						array[num3] = new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillContext(cellRangeFillerBinding.Filler, fillParameter);
						num3++;
						num = (short)316093444;
						short num4 = num;
						num = (short)1017721860;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_279;
						default:
							num = (short)1464467456;
							if (num != 0)
							{
							}
							num = (short)1345519620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						return array;
					}
					goto IL_7E;
					IL_279:
					if (cellValueSetter == null)
					{
						num = (short)373489664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					constraint = this.a(A_0);
					A_2.Normalize();
					num3 = 0;
					num = (short)1907032067;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_139:
					num = (short)681771016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_247:
					direction = fillDirection;
					records = (this.a.Records as global::Infragistics.Windows.DataPresenter.DataRecordCollection);
					cellValueSetter = this.b(A_0);
					num = (short)634191873;
					num2 = (int)((global::System.IntPtr)num);
				}
				return array;
				IL_298:
				num = (short)2058354688;
				short num5 = num;
				throw new global::System.InvalidOperationException();
				IL_7E:
				array = new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillContext[A_1.Length];
				num = (short)1386741762;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00006ED4 File Offset: 0x000050D4
		private global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding[] a(string A_0, global::System.Windows.Input.InputEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			short num2;
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding> enumerable;
			global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager.a a;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_1A5;
				case 1:
					if (this.f.Matches(null, A_1))
					{
						num2 = (short)730398721;
						if (num2 != 0)
						{
						}
						num2 = (short)380108800;
						short num3 = num2;
						num2 = (short)2036137990;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					enumerable = null;
					num2 = (short)495648775;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (enumerable == null)
					{
						num2 = (short)1618935816;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2AC;
				case 3:
					enumerable = this.c.Where(new global::System.Func<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding, bool>(a.b));
					num2 = (short)2134900747;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (this.g.Matches(null, A_1))
					{
						goto IL_BE;
					}
					num2 = (short)392101893;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (this.e.Matches(null, A_1))
					{
						num2 = (short)863502346;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1568997377;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					enumerable = this.c.Where(new global::System.Func<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding, bool>(a.d));
					num2 = (short)925892617;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_1A5;
				case 8:
					goto IL_1DB;
				case 9:
					goto IL_1A5;
				case 10:
					enumerable = this.c.Where(new global::System.Func<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding, bool>(a.c));
					num2 = (short)388038656;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_1A5;
				}
				goto IL_40;
				IL_1A5:
				num2 = (short)150732802;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1DB:
			return null;
			IL_2AC:
			return enumerable.ToArray<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding>();
			IL_40:
			a = new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager.a();
			a.a = A_0;
			num2 = (short)958096843;
			short num4 = num2;
			num2 = (short)1856202187;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_BE:
				num2 = (short)1102315523;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)9895936;
				if (num2 != 0)
				{
				}
				num2 = (short)1271136260;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00007194 File Offset: 0x00005394
		private void a(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)1170407425;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			int num2;
			global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange selectionRange;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
				{
					num = (short)464631291;
					short num3 = num;
					num = (short)203077115;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)615579648;
						if (num != 0)
						{
						}
						break;
					}
					this.a(A_1, selectionRange);
					num = (short)1997144066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (!selectionRange.IsEmpty)
					{
						num = (short)861798400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					return;
				}
				goto IL_43;
			}
			return;
			IL_43:
			selectionRange = this.i.GetSelectionRange();
			num = (short)1600651264;
			short num4 = num;
			num = (short)1207500801;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000072C0 File Offset: 0x000054C0
		private global::System.Windows.Controls.ContextMenu a(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillContext[] A_0, bool A_1)
		{
			short num = (short)606808604;
			short num2 = num;
			num = (short)1809459740;
			global::System.Windows.Controls.ContextMenu contextMenu;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)512491521;
				if (num != 0)
				{
				}
				num = (short)1634729984;
				if (num != 0)
				{
				}
				num = (short)1852375040;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_C1;
					}
					int num4;
					for (;;)
					{
						IL_9A:
						global::System.Windows.Controls.MenuItem menuItem;
						switch (num3)
						{
						case 0:
							goto IL_1BD;
						case 1:
							menuItem.IsEnabled = true;
							num = (short)860160007;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (num4 >= A_0.Length)
							{
								num = (short)1702297604;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillContext cellRangeFillContext = A_0[num4];
							menuItem = new global::System.Windows.Controls.MenuItem
							{
								Header = this.c(cellRangeFillContext),
								InputGestureText = this.b(cellRangeFillContext),
								Tag = cellRangeFillContext
							};
							menuItem.Click += this.a;
							num = (short)1936326661;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_EC;
						case 4:
							goto IL_1F6;
						case 5:
						{
							global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillContext cellRangeFillContext;
							if (cellRangeFillContext.Filler.Operation == global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation.FillCopy)
							{
								num = (short)730923009;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							menuItem.IsEnabled = A_1;
							num = (short)1962409987;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_1BD;
						case 7:
						{
							num = (short)778698752;
							short num5 = num;
							goto IL_EC;
						}
						}
						goto IL_C1;
						IL_EC:
						contextMenu.Items.Add(menuItem);
						num4++;
						num = (short)930545670;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BD:
						num = (short)1919287298;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1F6:
					break;
					IL_C1:
					this.a();
					contextMenu = new global::System.Windows.Controls.ContextMenu();
					num4 = 0;
					num = (short)1221197824;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_9A;
				}
				}
				break;
			}
			}
			return contextMenu;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007518 File Offset: 0x00005718
		private string c(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillContext A_0)
		{
			short num = (short)192029522;
			short num2 = num;
			num = (short)1584800594;
			switch (num2 == num)
			{
			}
			num = (short)1751842816;
			short num3 = num;
			num = (short)312475649;
			if (num != 0)
			{
			}
			num = (short)683999232;
			if (num != 0)
			{
			}
			return A_0.Filler.Name;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000075C8 File Offset: 0x000057C8
		private string b(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillContext A_0)
		{
			int a_ = 6;
			short num = (short)1800273920;
			short num2 = num;
			if (A_0.Filler.Operation != global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation.FillCopy)
			{
				for (;;)
				{
					num = (short)1901055751;
					short num3 = num;
					num = (short)414895879;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7A;
					}
				}
				IL_7A:
				num = (short)452198401;
				if (num != 0)
				{
				}
				num = (short)887554048;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("軌믎ꏐ뿒ﻔ雖뗘꿚鯞", a_);
			}
			return global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("軌믎ꏐ뿒ﻔ鏖", a_);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000076A8 File Offset: 0x000058A8
		private global::Infragistics.Windows.DataPresenter.Cell b(global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange A_0)
		{
			short num = (short)264699906;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E1;
				case 1:
				{
					num = (short)367067136;
					short num3 = num;
					num = (short)389133133;
					short num4 = num;
					num = (short)1602401101;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E1;
					default:
						num = (short)1126629376;
						if (num != 0)
						{
						}
						num = (short)576782336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
					goto IL_128;
				}
				IL_34:
				if (!A_0.IsEmpty)
				{
					num = (short)857604097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_E1:
				num = (short)1560739841;
				if (num != 0)
				{
				}
				if (A_0.IsSingleColumnRange)
				{
					goto IL_12D;
				}
				num = (short)1775304707;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7D:
			return null;
			IL_128:
			goto IL_7D;
			IL_12D:
			return (this.Grid.Records as global::Infragistics.Windows.DataPresenter.DataRecordCollection)[A_0.StartRow].Cells[A_0.StartColumn];
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007810 File Offset: 0x00005A10
		private bool a(global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange A_0)
		{
			short num = (short)1684599152;
			short num2 = num;
			num = (short)141095280;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_89:
				num = (short)1514012672;
				short num3 = num;
				num = (short)1544224768;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)1352400896;
				if (num != 0)
				{
				}
				num = (short)444923905;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			object value;
			for (;;)
			{
				switch (num4)
				{
				case 0:
					goto IL_C5;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				case 2:
					goto IL_E8;
				}
				IL_7C:
				global::Infragistics.Windows.DataPresenter.Cell cell = this.b(A_0);
				if (cell == null)
				{
					goto IL_89;
				}
				value = cell.Value;
				if (value != null)
				{
					goto IL_112;
				}
				num = (short)1563099138;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_C5:
			string value2 = null;
			goto IL_119;
			IL_E8:
			num = (short)1335820289;
			if (num != 0)
			{
			}
			value2 = null;
			goto IL_119;
			IL_112:
			value2 = value.ToString();
			IL_119:
			return !string.IsNullOrEmpty(value2);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007940 File Offset: 0x00005B40
		private void a(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillContext[] A_0)
		{
			short num = (short)1543857796;
			short num2 = num;
			num = (short)1128621700;
			switch (num2 == num)
			{
			}
			num = (short)560267264;
			short num3 = num;
			num = (short)903806977;
			if (num != 0)
			{
			}
			num = (short)690814976;
			if (num != 0)
			{
			}
			this.a();
			global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange selectionRange = this.Grid.SelectedItems.Cells.GetSelectionRange();
			this.i.SelectionAdorner.ContextMenu = this.a(A_0, this.a(selectionRange));
			this.i.SelectionAdorner.ContextMenu.PlacementTarget = this.a;
			this.i.SelectionAdorner.ContextMenu.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Relative;
			global::System.Windows.Rect bounds = (this.Grid.Records as global::Infragistics.Windows.DataPresenter.DataRecordCollection)[selectionRange.BottomRight.Row].Cells[selectionRange.BottomRight.Column].GetBounds();
			this.i.SelectionAdorner.ContextMenu.HorizontalOffset = bounds.BottomRight.X;
			this.i.SelectionAdorner.ContextMenu.VerticalOffset = bounds.BottomRight.Y;
			this.i.SelectionAdorner.ContextMenu.IsOpen = true;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007AF4 File Offset: 0x00005CF4
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::System.Windows.Controls.ContextMenu contextMenu;
			for (;;)
			{
				IL_0A:
				global::System.Collections.IEnumerator enumerator;
				switch (num)
				{
				case 0:
					num2 = (short)525664257;
					if (num2 != 0)
					{
					}
					try
					{
						num2 = (short)296222723;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num2 = (short)1624436854;
									short num3 = num2;
									num2 = (short)471527542;
									switch ((num3 == num2) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num2 = (short)2012086272;
										if (num2 != 0)
										{
										}
										num2 = (short)1036582913;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
								}
								else
								{
									((global::System.Windows.Controls.MenuItem)enumerator.Current).Click -= this.a;
								}
								num2 = (short)313524226;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								num2 = (short)258080772;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_C7;
								}
								continue;
							case 4:
								goto IL_192;
							}
							IL_FC:
							num2 = (short)1957625856;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_C7:
							goto IL_FC;
						}
						IL_192:
						goto IL_254;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1B3;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1A1:
							switch (num)
							{
							case 0:
								disposable.Dispose();
								num2 = (short)73793538;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								if (disposable != null)
								{
									num2 = (short)482148352;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_204;
							case 2:
								goto IL_202;
							}
							goto IL_1B3;
						}
						IL_202:
						IL_204:
						goto EndFinally_6;
						IL_1B3:
						disposable = (enumerator as global::System.IDisposable);
						num2 = (short)1210187777;
						num = (int)((global::System.IntPtr)num2);
						goto IL_1A1;
						EndFinally_6:;
					}
					goto IL_205;
					IL_254:
					contextMenu.Items.Clear();
					num2 = (short)856096771;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_205;
				case 2:
				{
					num2 = (short)1903755264;
					short num4 = num2;
					if (contextMenu != null)
					{
						num2 = (short)542441473;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 3:
					return;
				}
				goto IL_20;
				IL_205:
				enumerator = ((global::System.Collections.IEnumerable)contextMenu.Items).GetEnumerator();
				num2 = (short)1923219456;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			contextMenu = this.i.SelectionAdorner.ContextMenu;
			num2 = (short)803078146;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00007D98 File Offset: 0x00005F98
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1312292865;
			if (num != 0)
			{
			}
			num = (short)2060120180;
			short num2 = num;
			num = (short)148893812;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1614348288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)84148224;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.MenuItem menuItem = A_1.OriginalSource as global::System.Windows.Controls.MenuItem;
			this.a((global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillContext)menuItem.Tag);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007E60 File Offset: 0x00006060
		private void a(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillContext A_0)
		{
			int a_ = 7;
			short num = (short)145883136;
			short num2 = num;
			num = (short)1576992768;
			switch (num)
			{
			default:
			{
				global::System.Exception a_2 = null;
				this.j.Disable();
				global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.StartNewAutomatic(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.Gui, global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("裍맏뻑룓跗꫙髝迟闡諣", a_)), null);
				try
				{
					try
					{
						num = (short)942080003;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor waitCursor;
							switch (num3)
							{
							case 0:
								goto IL_2CF;
							case 1:
								try
								{
									num = (short)214499332;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
										global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer3;
										switch (num3)
										{
										case 0:
											automaticPerformanceMeasurer2 = automaticPerformanceMeasurer.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.Gui, global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("词꣏럑럓ꏕ곗뿙ﳛ飝觟軡裣", a_)));
											goto IL_1AC;
										case 1:
											num = (short)1992818691;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											try
											{
												A_0.Filler.Execute(A_0.Parameter);
											}
											finally
											{
												num = (short)837287937;
												num3 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num3)
													{
													case 0:
														automaticPerformanceMeasurer3.Dispose();
														num = (short)755761154;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													case 1:
														switch (0)
														{
														case 0:
															goto IL_20D;
														}
														continue;
													case 2:
														goto IL_244;
													}
													IL_20D:
													if (automaticPerformanceMeasurer3 == null)
													{
														break;
													}
													num = (short)1933901824;
													num3 = (int)((global::System.IntPtr)num);
												}
												IL_244:;
											}
											num = (short)1934950405;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											automaticPerformanceMeasurer2 = null;
											goto IL_1AC;
										case 4:
											switch (0)
											{
											case 0:
												goto IL_148;
											}
											continue;
										case 5:
											goto IL_25F;
										}
										IL_148:
										if (automaticPerformanceMeasurer == null)
										{
											num = (short)356384769;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1735131136;
										num3 = (int)((global::System.IntPtr)num);
										continue;
										IL_1AC:
										automaticPerformanceMeasurer3 = automaticPerformanceMeasurer2;
										num = (short)924712962;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_25F:
									goto IL_2F3;
								}
								finally
								{
									num = (short)174981121;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											((global::System.IDisposable)waitCursor).Dispose();
											num = (short)1857552386;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_297;
											}
											continue;
										case 2:
											goto IL_2CC;
										}
										IL_297:
										if (waitCursor == null)
										{
											break;
										}
										num = (short)366608384;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_2CC:;
								}
								goto IL_2CF;
								IL_2F3:
								num = (short)1594949636;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_2CF;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_B4;
								}
								continue;
							case 4:
								goto IL_30C;
							}
							IL_B4:
							global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillStartedEventHandler cellFillStarted = this.CellFillStarted;
							if (cellFillStarted == null)
							{
								num = (short)1043857408;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							cellFillStarted(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillStartedEventArgs(A_0.Parameter.Range));
							num = (short)262799362;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_2CF:
							waitCursor = new global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor();
							num = (short)1209925633;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_30C:;
					}
					catch (global::System.Exception a_2)
					{
					}
					finally
					{
						num = (short)1513095169;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_37E;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_349;
								}
								continue;
							case 2:
								goto IL_397;
							}
							IL_349:
							global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler cellFillEnded = this.CellFillEnded;
							if (cellFillEnded == null)
							{
								num = (short)722206722;
								num3 = (int)((global::System.IntPtr)num);
							}
							else
							{
								cellFillEnded(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventArgs(A_0.Parameter.Range));
								num = (short)1772879872;
								num3 = (int)((global::System.IntPtr)num);
							}
						}
						IL_37E:
						IL_397:;
					}
					this.a(A_0, a_2, automaticPerformanceMeasurer);
				}
				finally
				{
					num = (short)2030960641;
					if (num != 0)
					{
					}
					num = (short)1789722625;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							num = (short)925288427;
							short num4 = num;
							num = (short)1024247787;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_48F;
							default:
								num = (short)552009728;
								if (num != 0)
								{
								}
								automaticPerformanceMeasurer.Dispose();
								num = (short)799080450;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_402;
							}
							continue;
						case 2:
							goto IL_48D;
						}
						IL_402:
						if (automaticPerformanceMeasurer == null)
						{
							break;
						}
						num = (short)1385168896;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_48D:
					IL_48F:;
				}
				return;
			}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000837C File Offset: 0x0000657C
		private void a(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillContext A_0, global::System.Exception A_1, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer A_2)
		{
			int a_ = 16;
			short num = (short)2051801098;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.UI.CellRangeFill.PostFillAction postFillAction;
				switch (num2)
				{
				case 0:
					goto IL_1DE;
				case 1:
					num = (short)1599537160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					A_2.Pause();
					num = (short)1415446535;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					try
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor waitCursor = new global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor();
						try
						{
							num = (short)146210819;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
								global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
								switch (num2)
								{
								case 0:
									goto IL_4EF;
								case 1:
									automaticPerformanceMeasurer = A_2.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.Gui, postFillAction.ToString() + global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("鿘닚뇜돞", a_)));
									goto IL_2F0;
								case 2:
									num = (short)238092292;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_279;
									}
									continue;
								case 4:
									automaticPerformanceMeasurer = null;
									goto IL_2F0;
								case 5:
									try
									{
										num = (short)1688928263;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												if (global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.CanCommit)
												{
													num = (short)1055129609;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_455;
											case 1:
												goto IL_46C;
											case 2:
												goto IL_455;
											case 3:
											{
												global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillStartedEventHandler cellFillStarted = this.CellFillStarted;
												if (cellFillStarted == null)
												{
													num = (short)1554186244;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												cellFillStarted(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillStartedEventArgs(A_0.Parameter.Range));
												num = (short)924123144;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												goto IL_437;
											case 5:
												num = (short)1141768195;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												goto IL_455;
											case 7:
												switch (0)
												{
												case 0:
													goto IL_356;
												}
												continue;
											case 8:
												goto IL_437;
											case 9:
												global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.CommitAll();
												num = (short)216596486;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_356:
											if (postFillAction == global::Motorola.CommonCPS.UI.CellRangeFill.PostFillAction.Undo)
											{
												num = (short)1343553541;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)707723264;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_437:
											global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.Undo();
											num = (short)906756098;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_455:
											num = (short)625541121;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_46C:;
									}
									finally
									{
										num = (short)181993472;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_49F;
												}
												continue;
											case 1:
												automaticPerformanceMeasurer2.Dispose();
												num = (short)321847298;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_4D4;
											}
											IL_49F:
											if (automaticPerformanceMeasurer2 == null)
											{
												break;
											}
											num = (short)770113537;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_4D4:;
									}
									num = (short)1123483648;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_279:
								if (A_2 == null)
								{
									num = (short)911081474;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1282146305;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2F0:
								automaticPerformanceMeasurer2 = automaticPerformanceMeasurer;
								num = (short)963182597;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4EF:;
						}
						finally
						{
							num = (short)417857536;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_524;
									}
									continue;
								case 1:
								{
									num = (short)196648882;
									short num3 = num;
									num = (short)1859559346;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_5A9;
									default:
										num = (short)604569600;
										if (num != 0)
										{
										}
										((global::System.IDisposable)waitCursor).Dispose();
										num = (short)2118385666;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_5A7;
								}
								IL_524:
								if (waitCursor == null)
								{
									break;
								}
								num = (short)820117505;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5A7:
							IL_5A9:;
						}
						goto IL_173;
					}
					catch
					{
						goto IL_173;
					}
					goto IL_5B5;
					IL_173:
					num = (short)1248854027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (postFillAction != global::Motorola.CommonCPS.UI.CellRangeFill.PostFillAction.None)
					{
						num = (short)1966866435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5B5;
				case 5:
				{
					num = (short)950796288;
					short num4 = num;
					if (A_2 != null)
					{
						num = (short)1541341190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DE;
				}
				case 6:
					A_2.Resume();
					num = (short)2020671488;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_A1;
				case 8:
				{
					global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler cellFillEnded = this.CellFillEnded;
					if (cellFillEnded == null)
					{
						num = (short)760152065;
						if (num != 0)
						{
						}
						num = (short)786235401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					cellFillEnded(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventArgs(A_0.Parameter.Range));
					num = (short)1350041612;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					goto IL_14B;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 11:
					if (postFillAction == global::Motorola.CommonCPS.UI.CellRangeFill.PostFillAction.Undo)
					{
						num = (short)932577281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5B5;
				case 12:
					goto IL_1D9;
				}
				IL_62:
				if (A_2 != null)
				{
					num = (short)900071426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A1:
				postFillAction = this.a(A_1);
				num = (short)1597112325;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1DE:
				num = (short)2114453508;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_14B:
			IL_1D9:
			IL_5B5:
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.Reset();
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.Reset();
			this.j.Enable(true);
			this.a.Focus();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000089AC File Offset: 0x00006BAC
		private global::Motorola.CommonCPS.UI.CellRangeFill.PostFillAction a(global::System.Exception A_0)
		{
			short num = (short)623650594;
			short num2 = num;
			num = (short)1946822434;
			switch (num2 == num)
			{
			}
			num = (short)1225523200;
			if (num != 0)
			{
			}
			num = (short)1653407745;
			if (num != 0)
			{
			}
			num = (short)1328807936;
			short num3 = num;
			return this.PostFillActionResolver.Resolve(global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.CanUndo, A_0);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00008A64 File Offset: 0x00006C64
		public void Dispose()
		{
			short num = (short)749700988;
			short num2 = num;
			num = (short)1212188540;
			switch (num2 == num)
			{
			}
			num = (short)1951596545;
			if (num != 0)
			{
			}
			num = (short)237699072;
			if (num != 0)
			{
			}
			num = (short)1950679040;
			short num3 = num;
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00008B18 File Offset: 0x00006D18
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)105250818;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)54246851;
				short num3 = num;
				num = (short)1206042051;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_14D;
				case 1:
					break;
				default:
				{
					num = (short)1666842624;
					short num4 = num;
					break;
				}
				}
				num = (short)258998272;
				if (num != 0)
				{
				}
				num = (short)529072129;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeSelectionManager cellRangeSelectionManager = this.i;
					cellRangeSelectionManager.DragSelectionStarted = (global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler)global::System.Delegate.Remove(cellRangeSelectionManager.DragSelectionStarted, new global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler(this.a));
					global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeSelectionManager cellRangeSelectionManager2 = this.i;
					cellRangeSelectionManager2.DragSelectionEnded = (global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler)global::System.Delegate.Remove(cellRangeSelectionManager2.DragSelectionEnded, new global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler(this.a));
					this.i.Dispose();
					goto IL_14D;
				}
				case 1:
					this.a.KeyDown -= this.a;
					num = (short)574947332;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_D5;
					}
					continue;
				case 3:
					return;
				case 4:
					if (this.i != null)
					{
						num = (short)455409664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_D5:
				if (disposing)
				{
					num = (short)684130305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_14D:
				num = (short)1223098371;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00008CE0 File Offset: 0x00006EE0
		public void ProcessFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			int a_ = 6;
			short num = (short)2103771136;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator;
				switch (num2)
				{
				case 0:
				{
					num = (short)757142614;
					short num3 = num;
					num = (short)2079462486;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					case 1:
						break;
					default:
					{
						num = (short)1740767232;
						short num4 = num;
						break;
					}
					}
					num = (short)1282539520;
					if (num != 0)
					{
					}
					num = (short)1838022657;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_DB;
					}
					continue;
				}
				case 1:
					goto IL_F7;
				case 2:
					try
					{
						num = (short)19660802;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1AA;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_135;
								}
								continue;
							case 3:
								if (!enumerator.MoveNext())
								{
									num = (short)2140930052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator.Current.Settings.CellClickAction = global::Infragistics.Windows.DataPresenter.CellClickAction.SelectCell;
								num = (short)235798529;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								num = (short)1097465856;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_15E:
							num = (short)1921122307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_135:
							goto IL_15E;
						}
						IL_1AA:
						return;
					}
					finally
					{
						num = (short)1387986944;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1E0;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)90112002;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_215;
							}
							IL_1E0:
							if (enumerator == null)
							{
								break;
							}
							num = (short)836239361;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_215:;
					}
					goto IL_218;
				}
				IL_DB:
				if (fieldLayout == null)
				{
					num = (short)1708130305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_218:
				fieldLayout.Settings.SelectionTypeCell = global::Infragistics.Windows.Controls.SelectionType.Range;
				fieldLayout.Settings.SelectionTypeRecord = global::Infragistics.Windows.Controls.SelectionType.Extended;
				enumerator = fieldLayout.Fields.GetEnumerator();
				num = (short)273874946;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F7:
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("ꯌꛎ듐뿒뇔鯖룘ꋚ닜꫞闠", a_));
		}

		// Token: 0x0400002A RID: 42
		private readonly global::Infragistics.Windows.DataPresenter.DataPresenterBase a;

		// Token: 0x0400002B RID: 43
		private readonly global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBindingCollection b;

		// Token: 0x0400002C RID: 44
		private readonly global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBindingCollection c;

		// Token: 0x0400002D RID: 45
		private readonly global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.CellValueConstraintBindingCollection d;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Input.KeyGesture e;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Input.KeyGesture f;

		// Token: 0x04000030 RID: 48
		private readonly global::System.Windows.Input.MouseGesture g;

		// Token: 0x04000031 RID: 49
		private readonly global::System.Windows.Input.MouseButtonEventArgs h;

		// Token: 0x04000032 RID: 50
		private readonly global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeSelectionManager i;

		// Token: 0x04000033 RID: 51
		private readonly global::Motorola.CommonCPS.UI.CellRangeFill.IGridSorting j;

		// Token: 0x04000034 RID: 52
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::System.Type k;

		// Token: 0x04000035 RID: 53
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.CommonCPS.UI.CellRangeFill.IPostFillActionResolver l;

		// Token: 0x04000036 RID: 54
		public global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillStartedEventHandler CellFillStarted;

		// Token: 0x04000037 RID: 55
		public global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler CellFillEnded;

		// Token: 0x02000013 RID: 19
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000071 RID: 113 RVA: 0x00008F80 File Offset: 0x00007180
			internal bool b(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding A_0)
			{
				while (!(A_0.ColumnName == this.a))
				{
					short num = (short)574095361;
					if (num != 0)
					{
					}
					num = (short)1232376576;
					short num2 = num;
					num = (short)535466752;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)479461376;
						if (num != 0)
						{
						}
						num = (short)811794432;
						short num3 = num;
						return false;
					}
					}
				}
				return A_0.InputType == global::System.Windows.Input.InputType.Mouse;
			}

			// Token: 0x06000072 RID: 114 RVA: 0x00009048 File Offset: 0x00007248
			internal bool c(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding A_0)
			{
				short num = (short)112525313;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1860304896;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_142;
					case 1:
						goto IL_15;
					case 2:
					{
						num = (short)11491070;
						short num4 = num;
						num = (short)1305827070;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						default:
							num = (short)205979648;
							if (num != 0)
							{
							}
							num = (short)437780481;
							if (num != 0)
							{
							}
							num = (short)1106575363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						if (A_0.InputType == global::System.Windows.Input.InputType.Keyboard)
						{
							num = (short)1723793408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_5D;
					IL_15:
					switch (0)
					{
					case 0:
						IL_5D:
						if (!(A_0.ColumnName == this.a))
						{
							return false;
						}
						num = (short)937230338;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_142:
				return A_0.Filler.Operation == global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation.FillCopy;
			}

			// Token: 0x06000073 RID: 115 RVA: 0x000091A0 File Offset: 0x000073A0
			internal bool d(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding A_0)
			{
				short num = (short)683409409;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_144;
					case 1:
						goto IL_14;
					case 2:
					{
						num = (short)1781964388;
						short num3 = num;
						num = (short)575184484;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							num = (short)620494848;
							if (num != 0)
							{
							}
							num = (short)616824835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						if (A_0.InputType == global::System.Windows.Input.InputType.Keyboard)
						{
							num = (short)1721368576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_83;
					IL_14:
					num = (short)2017591297;
					if (num != 0)
					{
					}
					num = (short)953548800;
					short num4 = num;
					switch (0)
					{
					case 0:
						IL_83:
						if (!(A_0.ColumnName == this.a))
						{
							return false;
						}
						num = (short)54394882;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_144:
				return A_0.Filler.Operation == global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation.FillSeries;
			}

			// Token: 0x04000038 RID: 56
			public string a;
		}
	}
}
