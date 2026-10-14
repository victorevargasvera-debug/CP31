using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Microsoft.Practices.Prism.Commands;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000012 RID: 18
	public class GridSortByColumnBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Windows.DataPresenter.XamDataGrid>
	{
		// Token: 0x06000036 RID: 54 RVA: 0x000054F0 File Offset: 0x000036F0
		public GridSortByColumnBehavior(global::Infragistics.Windows.DataPresenter.XamDataGrid grid) : base(grid)
		{
			grid.Sorting += this.a;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005518 File Offset: 0x00003718
		private void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs A_1)
		{
			short num = (short)1868728103;
			short num2 = num;
			num = (short)1949992743;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)55377920;
				if (num != 0)
				{
				}
				num = (short)1289027584;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_B8;
					}
					break;
				}
				break;
			}
			global::Infragistics.Windows.DataPresenter.Field field;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSortByColumnBehavior.a a;
			for (;;)
			{
				IL_71:
				switch (num3)
				{
				case 0:
					num = (short)95420417;
					if (num != 0)
					{
					}
					goto IL_23C;
				case 1:
					if (field != null)
					{
						num = (short)1092550665;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2BE;
				case 2:
					a.a.Field.Tag = global::System.ComponentModel.ListSortDirection.Ascending.ToString();
					num = (short)1970864140;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (a.a.Field.Tag != null)
					{
						num = (short)875888648;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)974389255;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_23C;
				case 5:
					goto IL_2BE;
				case 6:
					goto IL_254;
				case 7:
					if (a.a.SortDescription.Direction == global::System.ComponentModel.ListSortDirection.Ascending)
					{
						num = (short)1533542402;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					a.a.Field.Tag = global::System.ComponentModel.ListSortDirection.Descending.ToString();
					num = (short)985333760;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)548732928;
					short num4 = num;
					num = (short)922943501;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					field.Tag = null;
					num = (short)1537343493;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_23C;
				case 11:
					a.a.Field.Tag = global::System.ComponentModel.ListSortDirection.Ascending.ToString();
					num = (short)965541898;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_23C;
				case 13:
					if ((string)a.a.Field.Tag == global::System.ComponentModel.ListSortDirection.Ascending.ToString())
					{
						num = (short)1464139791;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)684589070;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if ((string)a.a.Field.Tag == global::System.ComponentModel.ListSortDirection.Descending.ToString())
					{
						num = (short)1498611723;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23C;
				case 15:
					a.a.Field.Tag = global::System.ComponentModel.ListSortDirection.Descending.ToString();
					num = (short)331218948;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_B8;
				IL_23C:
				num = (short)1296564230;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2BE:
				num = (short)1169096707;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_254:
			global::Infragistics.Windows.DataPresenter.XamDataGrid xamDataGrid;
			object[] commandParameter = new object[]
			{
				a.a.Field.Name,
				a.a.Field.Tag,
				(xamDataGrid.SelectedItems.Records.Count == 1) ? xamDataGrid.SelectedItems.Records[0].Index : -1
			};
			base.CommandParameter = commandParameter;
			this.ExecuteCommand();
			return;
			IL_B8:
			a = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSortByColumnBehavior.a();
			a.a = A_1;
			a.a.Cancel = true;
			xamDataGrid = (A_0 as global::Infragistics.Windows.DataPresenter.XamDataGrid);
			field = xamDataGrid.FieldLayouts[0].Fields.FirstOrDefault(new global::System.Func<global::Infragistics.Windows.DataPresenter.Field, bool>(a.b));
			num = (short)800718849;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_71;
		}

		// Token: 0x02000013 RID: 19
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000039 RID: 57 RVA: 0x000059D0 File Offset: 0x00003BD0
			internal bool b(global::Infragistics.Windows.DataPresenter.Field A_0)
			{
				short num = (short)1818165248;
				short num2 = num;
				if (A_0.Name != this.a.Field.Name)
				{
					num = (short)1213579011;
					short num3 = num;
					num = (short)1072545539;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1115422721;
						if (num != 0)
						{
						}
						num = (short)1513095168;
						if (num != 0)
						{
						}
						break;
					}
					return A_0.Tag != null;
				}
				return false;
			}

			// Token: 0x04000010 RID: 16
			public global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs a;
		}
	}
}
