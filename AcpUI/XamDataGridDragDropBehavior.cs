using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonResources;
using Infragistics.DragDrop;
using Infragistics.Windows;
using Infragistics.Windows.DataPresenter;

namespace AcpUI
{
	// Token: 0x02000055 RID: 85
	public class XamDataGridDragDropBehavior : global::System.Windows.Interactivity.Behavior<global::AcpUI.AcpXamDataPresenter>
	{
		// Token: 0x060004BE RID: 1214 RVA: 0x0005A4BC File Offset: 0x000586BC
		static XamDataGridDragDropBehavior()
		{
			short num = (short)1104491403;
			short num2 = num;
			num = (short)307573643;
			switch (num2 == num)
			{
			}
			num = (short)79429633;
			if (num != 0)
			{
			}
			num = (short)155189248;
			if (num != 0)
			{
			}
			num = (short)1249640448;
			short num3 = num;
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::AcpUI.AcpXamDataPresenter), global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::AcpUI.XamDataGridDragDropBehavior.a));
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0005A584 File Offset: 0x00058784
		protected override void OnAttached()
		{
			short num = (short)1924849551;
			short num2 = num;
			num = (short)190111631;
			switch (num2 == num)
			{
			}
			num = (short)270729216;
			if (num != 0)
			{
			}
			num = (short)753270785;
			if (num != 0)
			{
			}
			num = (short)2000617472;
			short num3 = num;
			base.OnAttached();
			global::System.Windows.Style style = new global::System.Windows.Style(typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter));
			style.Setters.Add(new global::System.Windows.EventSetter(global::System.Windows.FrameworkElement.LoadedEvent, new global::System.Windows.RoutedEventHandler(this.a)));
			style.Setters.Add(new global::System.Windows.EventSetter(global::System.Windows.FrameworkElement.UnloadedEvent, new global::System.Windows.RoutedEventHandler(this.b)));
			base.AssociatedObject.Resources.Add(typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), style);
			global::Infragistics.DragDrop.DropTarget value = new global::Infragistics.DragDrop.DropTarget
			{
				IsDropTarget = true
			};
			global::Infragistics.DragDrop.DragDropManager.SetDropTarget(base.AssociatedObject, value);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0005A6BC File Offset: 0x000588BC
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1255395687;
			short num2 = num;
			num = (short)961335655;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)148766720;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				int num3;
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter;
				for (;;)
				{
					IL_53:
					switch (num3)
					{
					case 0:
					{
						global::Infragistics.DragDrop.DragSource dragSource;
						dragSource.DragStart -= this.a;
						dragSource.Drop -= this.a;
						dragSource.DragOver -= this.a;
						dragSource.DragCancel -= this.a;
						dragSource.DragEnter -= this.a;
						dragSource.DragLeave -= this.b;
						num = (short)2026700802;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						if (dataRecordPresenter.DataRecord.GetType() == typeof(global::Infragistics.Windows.DataPresenter.HeaderRecord))
						{
							num = (short)1708589060;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Infragistics.DragDrop.DragSource dragSource = global::Infragistics.DragDrop.DragDropManager.GetDragSource(dataRecordPresenter);
						num = (short)942931971;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return;
					case 3:
					{
						num = (short)1641742337;
						if (num != 0)
						{
						}
						num = (short)815988736;
						short num4 = num;
						global::Infragistics.DragDrop.DragSource dragSource;
						if (dragSource != null)
						{
							num = (short)253886464;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						return;
					}
					goto IL_6D;
				}
				return;
				IL_6D:
				dataRecordPresenter = (A_0 as global::Infragistics.Windows.DataPresenter.DataRecordPresenter);
				num = (short)181010433;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_53;
			}
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0005A8A4 File Offset: 0x00058AA4
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1186529280;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4B;
			}
			int num3;
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter;
			for (;;)
			{
				IL_35:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_E6;
				case 2:
					if (global::Infragistics.DragDrop.DragDropManager.GetDragSource(dataRecordPresenter) != null)
					{
						num = (short)2069430272;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14C;
				case 3:
				{
					num = (short)1909106635;
					short num4 = num;
					num = (short)1689364427;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1850474496;
						if (num != 0)
						{
						}
						if (dataRecordPresenter.DataRecord.GetType() == typeof(global::Infragistics.Windows.DataPresenter.HeaderRecord))
						{
							num = (short)806879233;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2072182786;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_4B;
			}
			IL_E6:
			num = (short)1333329921;
			if (num != 0)
			{
			}
			return;
			IL_14C:
			global::Infragistics.DragDrop.DragSource dragSource = new global::Infragistics.DragDrop.DragSource
			{
				IsDraggable = true
			};
			dragSource.DragStart += this.a;
			dragSource.Drop += this.a;
			dragSource.DragOver += this.a;
			dragSource.DragCancel += this.a;
			dragSource.DragEnter += this.a;
			dragSource.DragLeave += this.b;
			global::Infragistics.DragDrop.DragDropManager.SetDragSource(dataRecordPresenter, dragSource);
			return;
			IL_4B:
			dataRecordPresenter = (A_0 as global::Infragistics.Windows.DataPresenter.DataRecordPresenter);
			num = (short)1385103363;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_35;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0005AA80 File Offset: 0x00058C80
		internal void a(int A_0)
		{
			for (;;)
			{
				IL_00:
				short num = (short)500891648;
				short num2 = num;
				num = (short)58392579;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_150;
					case 1:
						this.f = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.Normal);
						this.f.Tick += this.b;
						num = (short)1378091008;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_113;
					case 3:
						num = (short)167444481;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_85;
						}
						continue;
					}
					IL_85:
					num = (short)1038742524;
					short num4 = num;
					num = (short)593818620;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)1300889600;
						if (num != 0)
						{
						}
						if (this.f == null)
						{
							num = (short)1791229953;
							num3 = (int)((global::System.IntPtr)num);
						}
						else
						{
							this.f.Stop();
							num = (short)616890370;
							num3 = (int)((global::System.IntPtr)num);
						}
						break;
					}
				}
			}
			IL_113:
			IL_150:
			this.f.Interval = global::System.TimeSpan.FromMilliseconds((double)A_0);
			this.f.Start();
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0005ABFC File Offset: 0x00058DFC
		internal void b()
		{
			short num = (short)645332994;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_12F;
				case 1:
					goto IL_ED;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (this.f == null)
				{
					break;
				}
				num = (short)58982400;
				short num3 = num;
				num = (short)2122842113;
				if (num != 0)
				{
				}
				num = (short)554642617;
				short num4 = num;
				num = (short)27143353;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1873739776;
					if (num != 0)
					{
					}
					num = (short)466616321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_ED:
				this.f.Stop();
				this.f.Tick -= this.b;
				this.f = null;
				num = (short)1910767616;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_12F:
			global::System.Windows.Input.Mouse.SetCursor(global::System.Windows.Input.Cursors.Arrow);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0005AD48 File Offset: 0x00058F48
		private void b(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)311296000;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_68;
					}
					continue;
				case 1:
				{
					int index;
					int index2;
					if (index == index2)
					{
						num = (short)1639907335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37C;
				}
				case 2:
					goto IL_237;
				case 3:
					return;
				case 4:
				{
					num = (short)2103115776;
					short num3 = num;
					global::System.Windows.Controls.ScrollViewer scrollViewer;
					scrollViewer.LineUp();
					num = (short)1203896322;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					num = (short)691601409;
					if (num != 0)
					{
					}
					this.b();
					num = (short)2117074956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					if (this.g)
					{
						num = (short)1362165768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					base.AssociatedObject.ScrollInfo.LineUp();
					int index2 = base.AssociatedObject.GetRecordsInView(false)[0].Index;
					num = (short)272695297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					num = (short)2023489549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					base.AssociatedObject.ScrollInfo.LineDown();
					int index2 = base.AssociatedObject.GetRecordsInView(false)[0].Index;
					num = (short)2027880462;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
				{
					global::System.Windows.Controls.ScrollViewer scrollViewer;
					if (scrollViewer != null)
					{
						num = (short)592445456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B2;
				}
				case 10:
					goto IL_306;
				case 11:
				{
					if (base.AssociatedObject == null)
					{
						num = (short)1808334851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.Controls.ScrollViewer scrollViewer = (global::System.Windows.Controls.ScrollViewer)global::Infragistics.Windows.Utilities.GetAncestorFromType(base.AssociatedObject, typeof(global::System.Windows.Controls.ScrollViewer), false);
					int index = base.AssociatedObject.GetRecordsInView(false)[0].Index;
					num = (short)1811742726;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					goto IL_F6;
				case 13:
				{
					global::System.Windows.Controls.ScrollViewer scrollViewer;
					if (scrollViewer != null)
					{
						num = (short)1708982276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37C;
				}
				case 14:
				{
					num = (short)224813926;
					short num4 = num;
					num = (short)2014208870;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)740884480;
						if (num != 0)
						{
						}
						int index;
						int index2;
						if (index == index2)
						{
							num = (short)571932687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B2;
					}
					}
					break;
				}
				case 15:
					num = (short)2009858057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
				{
					global::System.Windows.Controls.ScrollViewer scrollViewer;
					scrollViewer.LineDown();
					num = (short)1993867274;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_68:
				if (global::System.Windows.Input.Mouse.LeftButton == global::System.Windows.Input.MouseButtonState.Released)
				{
					num = (short)1272315909;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F6:
				num = (short)162398219;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B2:
			global::System.Windows.Input.Mouse.SetCursor(global::System.Windows.Input.Cursors.ScrollS);
			return;
			IL_237:
			goto IL_37C;
			IL_306:
			goto IL_B2;
			IL_37C:
			global::System.Windows.Input.Mouse.SetCursor(global::System.Windows.Input.Cursors.ScrollN);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0005B0DC File Offset: 0x000592DC
		private void b(object A_0, global::Infragistics.DragDrop.DragDropEventArgs A_1)
		{
			short num = (short)1797093125;
			short num2 = num;
			num = (short)689731333;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B3;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)1110245376;
				short num3 = num;
				goto IL_5E;
			}
			}
			int num4;
			global::System.Windows.Point position;
			global::AcpBusinessLayer.Recordset recordset;
			for (;;)
			{
				IL_7D:
				switch (num4)
				{
				case 0:
					if (position.X > 0.0)
					{
						num = (short)1553006596;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F6;
				case 1:
					return;
				case 2:
					goto IL_115;
				case 3:
					if (recordset != null)
					{
						num = (short)2099576841;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F6;
				case 4:
					num = (short)1328218115;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.a();
					num = (short)178782209;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_115;
				case 7:
					this.g = true;
					num = (short)1001390086;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (position.Y > global::AcpUI.XamDataGridDragDropBehavior.h)
					{
						num = (short)1495334919;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.g = false;
					num = (short)1410990082;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)327688;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (this.a != null)
					{
						num = (short)1992228869;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					goto IL_1F6;
				}
				goto IL_B3;
				IL_115:
				this.a(50);
				num = (short)1015873547;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F6:
				num = (short)364445697;
				if (num != 0)
				{
				}
				A_1.OperationType = new global::Infragistics.DragDrop.OperationType?(global::Infragistics.DragDrop.OperationType.DropNotAllowed);
				num = (short)120389642;
				num4 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_5E:
			num = (short)1429536768;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_B3;
			}
			goto IL_7D;
			IL_B3:
			recordset = (base.AssociatedObject.DataSource as global::AcpBusinessLayer.Recordset);
			position = global::System.Windows.Input.Mouse.GetPosition(base.AssociatedObject);
			num = (short)1523318784;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7D;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0005B374 File Offset: 0x00059574
		private void a(object A_0, global::Infragistics.DragDrop.DragDropCancelEventArgs A_1)
		{
			short num = (short)1394627292;
			short num2 = num;
			num = (short)9655004;
			switch (num2 == num)
			{
			}
			num = (short)800653313;
			if (num != 0)
			{
			}
			num = (short)1109852160;
			if (num != 0)
			{
			}
			num = (short)2098921472;
			short num3 = num;
			this.b();
			A_1.OperationType = new global::Infragistics.DragDrop.OperationType?(global::Infragistics.DragDrop.OperationType.Move);
			global::AcpUI.XamDataGridDragDropBehavior.h = global::System.Windows.Input.Mouse.GetPosition(base.AssociatedObject).Y;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0005B448 File Offset: 0x00059648
		private void a()
		{
			short num = (short)1458962434;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_F1;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (this.a == null)
				{
					break;
				}
				num = (short)1780482048;
				short num3 = num;
				num = (short)539033601;
				if (num != 0)
				{
				}
				num = (short)155390499;
				short num4 = num;
				num = (short)1279726115;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1043791872;
					if (num != 0)
					{
					}
					num = (short)1998323713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F1:
				this.c.BorderBrush = this.a;
				this.c.BorderThickness = this.b;
				this.c = null;
				this.a = null;
				num = (short)1663762432;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0005B594 File Offset: 0x00059794
		private void a(global::AcpCommonLib.StatusMsgType A_0, string A_1)
		{
			short num = (short)852012567;
			short num2 = num;
			num = (short)1934929431;
			switch (num2 == num)
			{
			}
			num = (short)2100494337;
			if (num != 0)
			{
			}
			num = (short)957349888;
			if (num != 0)
			{
			}
			num = (short)354222080;
			short num3 = num;
			global::AcpCommonLib.AppInfoManager.StatusMsgReport.Clear();
			global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(A_0, A_1);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0005B654 File Offset: 0x00059854
		private void a(object A_0, global::Infragistics.DragDrop.DragDropEventArgs A_1)
		{
			short num = (short)1658334563;
			short num2 = num;
			num = (short)1603480931;
			switch (num2 == num)
			{
			}
			num = (short)1973747712;
			if (num != 0)
			{
			}
			num = (short)751370241;
			if (num != 0)
			{
			}
			num = (short)2116222976;
			short num3 = num;
			this.a();
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0005B704 File Offset: 0x00059904
		private void a(object A_0, global::Infragistics.DragDrop.DragDropMoveEventArgs A_1)
		{
			short num = (short)1568113544;
			short num2 = num;
			num = (short)2006352776;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_2A4:
				num = (short)2066415641;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)270204928;
				if (num != 0)
				{
				}
				num = (short)1930231808;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_105;
					}
					break;
				}
				break;
			}
			for (;;)
			{
				IL_76:
				global::System.Windows.Point position;
				switch (num3)
				{
				case 0:
					if (this.e)
					{
						num = (short)1737752592;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_504;
				case 1:
					num = (short)1762525212;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					global::Infragistics.Windows.DataPresenter.DataRecordCellArea dataRecordCellArea;
					if (dataRecordCellArea != null)
					{
						num = (short)1247739905;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_708;
				}
				case 3:
					num = (short)968818718;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return;
				case 5:
				{
					global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter;
					if (dataRecordPresenter == null)
					{
						num = (short)573440029;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1779433489;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					A_1.OperationType = new global::Infragistics.DragDrop.OperationType?(global::Infragistics.DragDrop.OperationType.DropNotAllowed);
					num = (short)650248214;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_701;
				case 8:
					return;
				case 9:
					goto IL_425;
				case 10:
					goto IL_69A;
				case 11:
					goto IL_504;
				case 12:
					if (this.a != null)
					{
						num = (short)1584005141;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 13:
				{
					if (!base.AssociatedObject.CanDragDrop)
					{
						num = (short)1522204676;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = this.a(A_1);
					num = (short)1044447237;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					num = (short)634650657;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
				{
					global::AcpUI.DraggingData draggingData;
					if (draggingData != null)
					{
						num = (short)370475022;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_708;
				}
				case 16:
					num = (short)1502085147;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
				{
					global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter;
					if (this.a(A_1.Data, dataRecordPresenter, false))
					{
						num = (short)1393098758;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					A_1.OperationType = new global::Infragistics.DragDrop.OperationType?(global::Infragistics.DragDrop.OperationType.Move);
					global::Infragistics.Windows.DataPresenter.DataRecordCellArea dataRecordCellArea = global::Infragistics.Windows.Utilities.GetDescendantFromType(dataRecordPresenter, typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), false) as global::Infragistics.Windows.DataPresenter.DataRecordCellArea;
					num = (short)1291124738;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 18:
					goto IL_476;
				case 19:
					if (position.Y < 50.0)
					{
						num = (short)406061087;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_386;
				case 20:
					goto IL_386;
				case 21:
					this.a();
					num = (short)607911968;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (this.a != null)
					{
						num = (short)822870042;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 23:
					position = A_1.GetPosition(base.AssociatedObject);
					num = (short)1565458456;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (base.AssociatedObject.ActualHeight - 25.0 < position.Y)
					{
						num = (short)1520566279;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)379060243;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_386;
				case 26:
					this.a();
					num = (short)1384251402;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					if (base.AssociatedObject != null)
					{
						num = (short)498204695;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_504;
				case 28:
				{
					global::Infragistics.Windows.DataPresenter.DataRecordCellArea dataRecordCellArea;
					if (dataRecordCellArea.Equals(this.c))
					{
						num = (short)985726984;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a();
					this.c = dataRecordCellArea;
					this.a = this.c.BorderBrush;
					this.c.BorderBrush = global::System.Windows.Media.Brushes.Orange;
					this.b = this.c.BorderThickness;
					global::AcpUI.DraggingData draggingData = A_1.Data as global::AcpUI.DraggingData;
					num = (short)875954191;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 29:
					num = (short)1623457804;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
				{
					global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter;
					global::AcpUI.DraggingData draggingData;
					if (dataRecordPresenter.Record.Index > draggingData.DataRecords[0].Index)
					{
						num = (short)262799369;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.c.BorderThickness = new global::System.Windows.Thickness(0.0, 1.5, 0.0, 0.0);
					num = (short)705757202;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 31:
					base.AssociatedObject.ScrollInfo.LineUp();
					global::System.Threading.Thread.Sleep(50);
					global::System.Windows.Input.Mouse.SetCursor(global::System.Windows.Input.Cursors.ScrollN);
					num = (short)878313492;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					goto IL_639;
				case 33:
				{
					global::AcpUI.DraggingData draggingData;
					if (draggingData.DataRecords.Count > 0)
					{
						num = (short)1329266691;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_708;
				}
				}
				goto IL_105;
				IL_386:
				global::AcpUI.XamDataGridDragDropBehavior.h = position.Y;
				num = (short)1239089153;
				if (num != 0)
				{
				}
				num = (short)256573451;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_504:
				num = (short)1943928845;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_425:
			this.c.BorderThickness = new global::System.Windows.Thickness(0.0, 0.0, 0.0, 1.5);
			return;
			IL_476:
			goto IL_708;
			IL_639:
			return;
			IL_69A:
			return;
			IL_701:
			base.AssociatedObject.ScrollInfo.LineDown();
			global::System.Threading.Thread.Sleep(50);
			global::System.Windows.Input.Mouse.SetCursor(global::System.Windows.Input.Cursors.ScrollS);
			goto IL_2A4;
			IL_708:
			num = (short)431947776;
			short num4 = num;
			return;
			IL_105:
			this.b();
			num = (short)1236664320;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_76;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0005BE44 File Offset: 0x0005A044
		private global::Infragistics.Windows.DataPresenter.DataRecordPresenter a(global::Infragistics.DragDrop.DragDropMoveEventArgs A_0)
		{
			short num = (short)1475739648;
			short num2 = num;
			int num3;
			int num4;
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_33:
					switch (num3)
					{
					case 0:
						if (num4 > 0)
						{
							num = (short)1924726786;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_114;
					case 1:
						goto IL_C9;
					case 2:
						num4--;
						num = (short)552730625;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45;
				}
				IL_C9:
				num = (short)1258040528;
				short num5 = num;
				num = (short)530590928;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_7E;
				default:
					num = (short)1469054976;
					if (num != 0)
					{
					}
					break;
				}
				IL_114:
				num = (short)2048327681;
				if (num != 0)
				{
				}
				return global::System.Windows.Media.VisualTreeHelper.GetChild(dataRecordPresenter.Parent, num4) as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
			}
			}
			IL_45:
			global::System.Windows.Point position = A_0.GetPosition(A_0.DropTarget);
			dataRecordPresenter = (global::Infragistics.Windows.Utilities.GetDescendantFromType(A_0.DropTarget, typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), true) as global::Infragistics.Windows.DataPresenter.DataRecordPresenter);
			num4 = (int)(position.Y / dataRecordPresenter.ActualHeight);
			IL_7E:
			num = (short)1657077760;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0005BFA0 File Offset: 0x0005A1A0
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)173998080;
			short num2 = num;
			num = (short)614465537;
			if (num != 0)
			{
			}
			num = (short)320074945;
			short num3 = num;
			num = (short)947385537;
			switch (num3 == num)
			{
			}
			num = (short)1102643200;
			if (num != 0)
			{
			}
			this.d.Opened -= this.a;
			this.d.Child.Opacity = 0.3;
			this.d.MaxWidth = 512.0;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0005C08C File Offset: 0x0005A28C
		private bool a(global::Infragistics.DragDrop.DragDropStartEventArgs A_0, bool A_1)
		{
			short num;
			bool result;
			try
			{
				num = (short)1970470912;
				switch (num)
				{
				default:
				{
					num = (short)73662483;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_616;
						case 1:
							this.a(global::AcpCommonLib.StatusMsgType.Warning, global::AcpCommonResources.AcpResources.Illegal_Move_Operation);
							num = (short)284557327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_151;
						case 3:
							goto IL_72D;
						case 4:
							if (A_1)
							{
								num = (short)1627389997;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_713;
						case 5:
							num = (short)918945823;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records;
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = records[0] as global::Infragistics.Windows.DataPresenter.DataRecord;
							num = (short)269418538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							num = (short)1641676829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_637;
						case 9:
							num = (short)1053425678;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (A_1)
							{
								num = (short)38993952;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_68F;
						case 11:
							if (!base.AssociatedObject.CanDragDrop)
							{
								num = (short)1946615829;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)45744158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							if (A_1)
							{
								num = (short)745996311;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_137;
						case 13:
							this.a(global::AcpCommonLib.StatusMsgType.Warning, global::AcpCommonResources.AcpResources.MultiSelection_DnD_Move_not_Allowed);
							num = (short)1384054802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightCtrl))
							{
								num = (short)1318125596;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_61B;
						case 15:
							goto IL_2FE;
						case 16:
						{
							global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records;
							if (records.Count > 1)
							{
								num = (short)1624178693;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2143879217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							num = (short)1154285604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							goto IL_4AF;
						case 19:
							switch (0)
							{
							case 0:
								goto IL_113;
							}
							continue;
						case 20:
							goto IL_137;
						case 21:
							num = (short)1695023116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
						{
							global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records;
							if (records.Count == 1)
							{
								num = (short)633667590;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7D8;
						}
						case 23:
							this.a(global::AcpCommonLib.StatusMsgType.Warning, global::AcpCommonResources.AcpResources.Special_tables_DnD_Move_not_Allowed);
							num = (short)356450324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							num = (short)1907425284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							result = true;
							num = (short)242941979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							goto IL_61B;
						case 27:
							goto IL_526;
						case 28:
							num = (short)270073894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
							if (A_1)
							{
								num = (short)1507262465;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2FE;
						case 30:
							if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl))
							{
								num = (short)533331977;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_61B;
						case 31:
							if (A_1)
							{
								num = (short)186056717;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4AF;
						case 32:
							this.a(global::AcpCommonLib.StatusMsgType.Warning, global::AcpCommonResources.AcpResources.Illegal_Move_Operation);
							num = (short)766705712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.DragDisabled, acpFeatureNode.Permissions))
							{
								num = (short)1287847943;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7D8;
						}
						case 34:
							num = (short)1198718986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 35:
							goto IL_319;
						case 36:
							if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightShift))
							{
								num = (short)267321370;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)838336562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
						{
							if ((base.AssociatedObject.DataSource as global::System.Collections.IList).Count == 1)
							{
								num = (short)2146893848;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records = base.AssociatedObject.SelectedItems.Records;
							num = (short)419102736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 38:
							if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftShift))
							{
								num = (short)974716945;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_61B;
						case 39:
							goto IL_4CA;
						case 40:
							result = true;
							num = (short)776994816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 41:
							goto IL_7F1;
						case 42:
						{
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
							if (dataRecord != null)
							{
								num = (short)613613611;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7D8;
						}
						case 43:
						{
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = dataRecord.DataItem as global::AcpCommonLib.IAcpFeatureNode;
							num = (short)1110573089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 44:
							goto IL_713;
						case 45:
							this.a(global::AcpCommonLib.StatusMsgType.Warning, global::AcpCommonResources.AcpResources.Illegal_Move_Operation);
							num = (short)1543700524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 46:
							if (global::Infragistics.Windows.Utilities.GetAncestorFromType(A_0.OriginalDragSource, typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), true) is global::Infragistics.Windows.DataPresenter.DataRecordCellArea)
							{
								num = (short)1916010521;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_63C;
						case 47:
							goto IL_6AA;
						case 48:
							goto IL_68F;
						case 49:
						{
							global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records;
							if (records.Count < 1)
							{
								num = (short)1595342888;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1864695830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 50:
							if (A_0 != null)
							{
								num = (short)549453875;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_63C;
						case 51:
							num = (short)1111490606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_113:
						if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
						{
							num = (short)2097741858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1632960523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_137:
						result = true;
						num = (short)1916862466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2FE:
						result = true;
						num = (short)121700387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4AF:
						result = true;
						num = (short)285147175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_61B:
						result = true;
						num = (short)1558446088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_63C:
						num = (short)428015653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_68F:
						result = true;
						num = (short)1291517999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_713:
						result = true;
						num = (short)1129971715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_7D8:
						num = (short)2061959209;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_151:
					IL_319:
					IL_4CA:
					IL_526:
					IL_616:
					IL_637:
					IL_6AA:
					IL_72D:
					return result;
					IL_7F1:
					break;
				}
				}
			}
			catch
			{
				return true;
			}
			num = (short)1840971776;
			short num3 = num;
			num = (short)561826400;
			short num4 = num;
			num = (short)1579534944;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			default:
				num = (short)934412289;
				if (num != 0)
				{
				}
				num = (short)1223098368;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0005C950 File Offset: 0x0005AB50
		private void a(object A_0, global::Infragistics.DragDrop.DragDropStartEventArgs A_1)
		{
			short num = (short)7667714;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord> list;
			for (;;)
			{
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter;
				switch (num2)
				{
				case 0:
					goto IL_1D1;
				case 1:
					if (dataRecordPresenter.DataRecord != null)
					{
						goto IL_B9;
					}
					goto IL_243;
				case 2:
				{
					num = (short)1125122048;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_77;
					}
					continue;
				}
				case 3:
					list.Add(dataRecordPresenter.DataRecord);
					num = (short)430440457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_98;
				case 5:
					num = (short)1255473153;
					if (num != 0)
					{
					}
					if (dataRecordPresenter != null)
					{
						num = (short)1178599432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_243;
				case 6:
					if (this.d != null)
					{
						num = (short)732495879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D1;
				case 7:
					this.d.Opened += this.a;
					num = (short)438763520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)108789761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_12F;
				}
				IL_77:
				if (this.a(A_1, true))
				{
					num = (short)2092695556;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.e = true;
				this.d = (global::Infragistics.DragDrop.DragDropManager.DragPopup as global::System.Windows.Controls.Primitives.Popup);
				num = (short)452523199;
				short num4 = num;
				num = (short)515962047;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)680919040;
					if (num != 0)
					{
					}
					num = (short)1403912198;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B9:
				num = (short)1167982595;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D1:
				list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>();
				dataRecordPresenter = (A_1.DragSource as global::Infragistics.Windows.DataPresenter.DataRecordPresenter);
				num = (short)1688535045;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_98:
			global::Infragistics.DragDrop.DragDropManager.EndDrag(true);
			return;
			IL_12F:
			IL_243:
			A_1.Data = new global::AcpUI.DraggingData
			{
				DataRecords = list,
				parentRecordset = (base.AssociatedObject.DataSource as global::AcpBusinessLayer.Recordset)
			};
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0005CBCC File Offset: 0x0005ADCC
		private bool a(object A_0, global::Infragistics.Windows.DataPresenter.DataRecordPresenter A_1, bool A_2)
		{
			short num;
			bool result;
			try
			{
				num = (short)1946812416;
				switch (num)
				{
				default:
				{
					num = (short)754515987;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::AcpUI.DraggingData draggingData;
						switch (num2)
						{
						case 0:
							result = true;
							num = (short)719781905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							this.a(global::AcpCommonLib.StatusMsgType.Warning, global::AcpCommonResources.AcpResources.Illegal_Move_Operation);
							num = (short)1260453891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							this.a(global::AcpCommonLib.StatusMsgType.Warning, global::AcpCommonResources.AcpResources.Illegal_Move_Operation);
							num = (short)109576206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_1B8;
						case 4:
							this.a(global::AcpCommonLib.StatusMsgType.Warning, global::AcpCommonResources.AcpResources.CrossTable_DnD_Move_not_Allowed);
							num = (short)94437409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							this.a(global::AcpCommonLib.StatusMsgType.Warning, global::AcpCommonResources.AcpResources.Illegal_Move_Operation);
							num = (short)1822162957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							this.a(global::AcpCommonLib.StatusMsgType.Warning, global::AcpCommonResources.AcpResources.Illegal_Move_Operation);
							num = (short)1270546443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							if (draggingData == null)
							{
								num = (short)834994218;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = A_1.DataRecord;
							num = (short)1055195162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							if (A_2)
							{
								num = (short)554827781;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_13E;
						case 9:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.DropBeforeDisabled, acpFeatureNode.Permissions))
							{
								num = (short)1564147727;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1115095075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							if (A_2)
							{
								num = (short)1110900742;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4BB;
						case 11:
							goto IL_4BB;
						case 12:
							num = (short)438632488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_13E;
						case 14:
							goto IL_5D4;
						case 15:
							num = (short)1141637148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							goto IL_56C;
						case 17:
							goto IL_383;
						case 18:
							goto IL_1D3;
						case 19:
							switch (0)
							{
							case 0:
								goto IL_F0;
							}
							continue;
						case 20:
							if (A_2)
							{
								num = (short)148045854;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_388;
						case 21:
						{
							object dataItem;
							object dataItem2;
							if (!dataItem.GetType().IsInstanceOfType(dataItem2))
							{
								num = (short)2136473612;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)995950629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
							goto IL_5F1;
						case 23:
							goto IL_3A3;
						case 24:
							if (A_2)
							{
								num = (short)489619457;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B8;
						case 25:
						{
							global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord> dataRecords;
							if (dataRecords.Count == 0)
							{
								num = (short)1935081499;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							object dataItem2 = dataRecords[0].DataItem;
							num = (short)383189013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 26:
						{
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
							if (dataRecord.GetType() == typeof(global::Infragistics.Windows.DataPresenter.HeaderRecord))
							{
								num = (short)1067122719;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							object dataItem = dataRecord.DataItem;
							num = (short)1006632994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 27:
							num = (short)1867382792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							if (A_2)
							{
								num = (short)227672066;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5D4;
						case 29:
							goto IL_4D7;
						case 30:
							this.a(global::AcpCommonLib.StatusMsgType.Warning, global::AcpCommonResources.AcpResources.Illegal_Move_Operation);
							num = (short)2079916068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							num = (short)1186988052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
							goto IL_312;
						case 33:
							goto IL_2F6;
						case 34:
						{
							object dataItem;
							if (dataItem == null)
							{
								num = (short)2129592359;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = dataItem as global::AcpCommonLib.IAcpFeatureNode;
							num = (short)750845961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 35:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.DropAfterDisabled, acpFeatureNode.Permissions))
							{
								num = (short)981925929;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord> dataRecords = draggingData.DataRecords;
							num = (short)379191321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 36:
							goto IL_388;
						case 37:
							goto IL_6A3;
						case 38:
							goto IL_15A;
						case 39:
							num = (short)331677706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 40:
							if (A_2)
							{
								num = (short)946470916;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F6;
						case 41:
							num = (short)617414680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 42:
							result = true;
							num = (short)1494679568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_F0:
						if (A_1 == null)
						{
							num = (short)322961408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						draggingData = (A_0 as global::AcpUI.DraggingData);
						num = (short)1348993031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_13E:
						result = true;
						num = (short)1495203878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1B8:
						result = true;
						num = (short)1544028178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2F6:
						result = true;
						num = (short)498532384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_388:
						result = true;
						num = (short)516554775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4BB:
						result = true;
						num = (short)183894045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5D4:
						result = true;
						num = (short)587595798;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_15A:
					IL_1D3:
					IL_312:
					IL_383:
					IL_3A3:
					IL_4D7:
					IL_56C:
					IL_5F1:
					return result;
					IL_6A3:
					break;
				}
				}
			}
			catch
			{
				return true;
			}
			num = (short)1767650850;
			short num3 = num;
			num = (short)889206306;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			default:
			{
				num = (short)264372225;
				if (num != 0)
				{
				}
				num = (short)230490112;
				if (num != 0)
				{
				}
				num = (short)1083965440;
				short num4 = num;
				return false;
			}
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0005D344 File Offset: 0x0005B544
		private bool a(global::Infragistics.Windows.DataPresenter.DataRecord A_0, global::AcpUI.DraggingData A_1)
		{
			short num = (short)923336704;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				int num6;
				global::System.Collections.IList list;
				object dataItem;
				global::AcpBusinessLayer.Recordset parentRecordset;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						int num3;
						int num4;
						while (num3 != num4)
						{
							num = (short)1194050952;
							short num5 = num;
							num = (short)2059715976;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)846462976;
								if (num != 0)
								{
								}
								num = (short)1860698114;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_27;
							}
						}
						goto IL_8B;
					}
					case 1:
					{
						int num3;
						if (num3 >= 0)
						{
							num = (short)170983432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8B;
					}
					case 2:
						num = (short)859832321;
						if (num != 0)
						{
						}
						num = (short)287178753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (num6 < 0)
						{
							num = (short)1560477701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4 = list.IndexOf(dataItem);
						int num3 = list.IndexOf(A_1.DataRecords[num6].DataItem);
						num = (short)586940416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_1D6;
					case 5:
						return true;
					case 6:
						goto IL_1D6;
					case 7:
						goto IL_8B;
					case 8:
					{
						int num3;
						int num4;
						parentRecordset.MoveRecord(num3, num4);
						this.a(global::AcpCommonLib.StatusMsgType.Info, global::AcpCommonResources.AcpResources.DnD_Move_was_Successful);
						num = (short)2088894464;
						short num7 = num;
						num = (short)256376839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_52;
					IL_8B:
					num6--;
					num = (short)1202978822;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D6:
					num = (short)48562179;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_52:
				parentRecordset = A_1.parentRecordset;
				list = parentRecordset;
				dataItem = A_0.DataItem;
				num6 = A_1.DataRecords.Count - 1;
				num = (short)2059468804;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0005D5A4 File Offset: 0x0005B7A4
		private void a(object A_0, global::Infragistics.DragDrop.DropEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)699019117;
					short num3 = num2;
					num2 = (short)1035677549;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_62;
					default:
					{
						num2 = (short)788987904;
						if (num2 != 0)
						{
						}
						num2 = (short)282853377;
						if (num2 != 0)
						{
						}
						if (this.a(A_1.Data, dataRecordPresenter, true))
						{
							num2 = (short)1466105860;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.a(dataRecordPresenter.DataRecord, A_1.Data as global::AcpUI.DraggingData);
						num2 = (short)355401728;
						short num4 = num2;
						num2 = (short)1338441729;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_BC;
				case 2:
					if (dataRecordPresenter != null)
					{
						num2 = (short)430112771;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_17B;
				case 3:
					goto IL_62;
				case 4:
					return;
				}
				goto IL_24;
				IL_62:
				num2 = (short)2142699520;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_BC:
			IL_17B:
			this.e = false;
			return;
			IL_24:
			this.a();
			dataRecordPresenter = this.a(A_1);
			num2 = (short)1326514178;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0005D734 File Offset: 0x0005B934
		private static void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)995229701;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter;
				global::AcpUI.AcpXamDataPresenter acpXamDataPresenter;
				switch (num2)
				{
				case 0:
					if (dataRecordPresenter.IsSelected)
					{
						num = (short)758448138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_261;
				case 1:
					num = (short)370409484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (global::Infragistics.Windows.Utilities.GetAncestorFromType(A_1.OriginalSource as global::System.Windows.DependencyObject, typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), true) is global::Infragistics.Windows.DataPresenter.DataRecordCellArea)
					{
						num = (short)1784348676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					dataRecordPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(A_1.OriginalSource as global::System.Windows.DependencyObject, typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), true) as global::Infragistics.Windows.DataPresenter.DataRecordPresenter);
					num = (short)1152581643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_28D;
				case 4:
					return;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_7D;
					}
					continue;
				case 6:
					if (!A_1.OriginalSource.GetType().Equals(typeof(global::System.Windows.Shapes.Path)))
					{
						num = (short)1101070337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F2;
				case 7:
					if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftShift))
					{
						num = (short)1904672776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					num = (short)1372782605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightCtrl))
					{
						num = (short)1889468430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					goto IL_353;
				case 11:
					num = (short)1256652801;
					if (num != 0)
					{
					}
					if (dataRecordPresenter != null)
					{
						num = (short)596967439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
					if (A_1.OriginalSource.GetType().Equals(typeof(global::System.Windows.Controls.Grid)))
					{
						num = (short)1782382611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 13:
				{
					num = (short)133323328;
					short num3 = num;
					num = (short)1805474368;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_353;
					default:
						num = (short)2122776576;
						if (num != 0)
						{
						}
						if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightShift))
						{
							num = (short)1007812628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)313393173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 14:
					num = (short)1090453511;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)1268318214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					acpXamDataPresenter = (A_0 as global::AcpUI.AcpXamDataPresenter);
					num = (short)1338048514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)878706697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_261;
				case 19:
					goto IL_2F2;
				case 20:
					goto IL_17C;
				case 21:
					if (A_0 is global::AcpUI.AcpXamDataPresenter)
					{
						num = (short)234487824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_7D:
				if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl))
				{
					num = (short)1933574161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_261:
				global::AcpUI.XamDataGridDragDropBehavior.h = global::System.Windows.Input.Mouse.GetPosition(acpXamDataPresenter).Y;
				num = (short)2044788739;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F2:
				acpXamDataPresenter.SelectedItems.Records.Clear();
				acpXamDataPresenter.ActiveRecord = dataRecordPresenter.DataRecord;
				acpXamDataPresenter.ActiveRecord.IsSelected = true;
				num = (short)1213333504;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_353:
				num = (short)1560412160;
				short num4 = num;
				A_1.Handled = true;
				num = (short)1492254738;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_17C:
			return;
			IL_28D:;
		}

		// Token: 0x040002A7 RID: 679
		private global::System.Windows.Media.Brush a;

		// Token: 0x040002A8 RID: 680
		private global::System.Windows.Thickness b;

		// Token: 0x040002A9 RID: 681
		private global::Infragistics.Windows.DataPresenter.DataRecordCellArea c;

		// Token: 0x040002AA RID: 682
		private global::System.Windows.Controls.Primitives.Popup d;

		// Token: 0x040002AB RID: 683
		private bool e;

		// Token: 0x040002AC RID: 684
		private global::System.Windows.Threading.DispatcherTimer f;

		// Token: 0x040002AD RID: 685
		private bool g = true;

		// Token: 0x040002AE RID: 686
		private static double h;
	}
}
