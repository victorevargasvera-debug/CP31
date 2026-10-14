using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000032 RID: 50
	public class GridSorting<TItem> : global::Motorola.CommonCPS.UI.CellRangeFill.IGridSorting
	{
		// Token: 0x060000BF RID: 191 RVA: 0x0000D250 File Offset: 0x0000B450
		public GridSorting(global::Infragistics.Windows.DataPresenter.XamDataGrid grid)
		{
			int a_ = 12;
			base..ctor();
			if (grid == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䌣吥䄧丩", a_));
			}
			this.Grid = grid;
			this.IsEnabled = true;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000D294 File Offset: 0x0000B494
		public void Enable(bool refresh)
		{
			short num = (short)377056579;
			short num2 = num;
			num = (short)1272802627;
			switch (num2 == num)
			{
			}
			num = (short)1639972864;
			short num3 = num;
			num = (short)161087489;
			if (num != 0)
			{
			}
			num = (short)1423048704;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000D340 File Offset: 0x0000B540
		public void Disable()
		{
			short num = (short)1347410512;
			short num2 = num;
			num = (short)1063246416;
			switch (num2 == num)
			{
			}
			num = (short)74579968;
			short num3 = num;
			num = (short)609746945;
			if (num != 0)
			{
			}
			num = (short)655556608;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000D3EC File Offset: 0x0000B5EC
		private void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs A_1)
		{
			short num = (short)156534827;
			short num2 = num;
			num = (short)882608171;
			switch (num2 == num)
			{
			}
			num = (short)1796734976;
			short num3 = num;
			num = (short)1814757376;
			if (num != 0)
			{
			}
			num = (short)588775425;
			if (num != 0)
			{
			}
			A_1.Cancel = true;
			A_1.Handled = true;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000D4A4 File Offset: 0x0000B6A4
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000D550 File Offset: 0x0000B750
		public bool IsEnabled
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)397909450;
				short num2 = num;
				num = (short)2031132106;
				switch (num2 == num)
				{
				}
				num = (short)805109760;
				short num3 = num;
				num = (short)1132199937;
				if (num != 0)
				{
				}
				num = (short)498532352;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2103963174;
				short num2 = num;
				num = (short)1018424870;
				switch (num2 == num)
				{
				}
				num = (short)1784610816;
				short num3 = num;
				num = (short)1598554112;
				if (num != 0)
				{
				}
				num = (short)1922170881;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000D600 File Offset: 0x0000B800
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase Grid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)874971137;
				if (num != 0)
				{
				}
				num = (short)1639557407;
				short num2 = num;
				num = (short)789227807;
				switch (num2 == num)
				{
				default:
				{
					num = (short)189792256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)235143168;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1507411987;
				short num2 = num;
				num = (short)1031096339;
				switch (num2 == num)
				{
				}
				num = (short)1105920000;
				short num3 = num;
				num = (short)1135804417;
				if (num != 0)
				{
				}
				num = (short)1862336512;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000D760 File Offset: 0x0000B960
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000D810 File Offset: 0x0000BA10
		public global::System.Windows.Input.ICommand SortCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)279969793;
				if (num != 0)
				{
				}
				num = (short)1684579320;
				short num2 = num;
				num = (short)446604280;
				switch (num2 == num)
				{
				default:
				{
					num = (short)343736320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1107689472;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1746322108;
				short num2 = num;
				num = (short)1222492860;
				switch (num2 == num)
				{
				}
				num = (short)622395392;
				short num3 = num;
				num = (short)2020933632;
				if (num != 0)
				{
				}
				num = (short)1120862209;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0000D970 File Offset: 0x0000BB70
		public global::Motorola.CommonCPS.Server.EntityModel.OrderByOption[] OldOrderByOptions
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1734213633;
				if (num != 0)
				{
				}
				num = (short)2030540497;
				short num2 = num;
				num = (short)1122211537;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1119944704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1120468992;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1302722975;
				short num2 = num;
				num = (short)1324808607;
				switch (num2 == num)
				{
				}
				num = (short)1647443968;
				short num3 = num;
				num = (short)1538981888;
				if (num != 0)
				{
				}
				num = (short)1592131585;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x04000040 RID: 64
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a;

		// Token: 0x04000041 RID: 65
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase b;

		// Token: 0x04000042 RID: 66
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.Input.ICommand c;

		// Token: 0x04000043 RID: 67
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.EntityModel.OrderByOption[] d;
	}
}
