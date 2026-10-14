using System;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.UI.CellRangeFill.Constraints;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x02000016 RID: 22
	public abstract class CellValueSetterBase : global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter
	{
		// Token: 0x0600007A RID: 122 RVA: 0x000093C4 File Offset: 0x000075C4
		protected CellValueSetterBase(global::Motorola.CommonCPS.UI.CellRangeFill.ICellEditabilityResolver editabilityResolver)
		{
			int a_ = 9;
			base..ctor();
			if (editabilityResolver == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("뗏뛑뷓ꋕ맗룙뗛닝觟雡鷣듥跧駩菫苭蛯韱蛳", a_));
			}
			this.a = editabilityResolver;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00009400 File Offset: 0x00007600
		public bool IsEditable(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			int a_ = 10;
			while (cell != null)
			{
				short num = (short)1919300270;
				short num2 = num;
				num = (short)1643852462;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1633812480;
					if (num != 0)
					{
					}
					num = (short)31522817;
					if (num != 0)
					{
					}
					num = (short)695009280;
					short num3 = num;
					return this.a.CanEdit(cell);
				}
				}
			}
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("닐뛒맔믖", a_));
		}

		// Token: 0x0600007C RID: 124
		public abstract bool CanSetValue(global::Infragistics.Windows.DataPresenter.Cell cell, object value);

		// Token: 0x0600007D RID: 125
		public abstract void SetValue(global::Infragistics.Windows.DataPresenter.Cell cell, object value, bool supressNotification, bool commit, bool refresh);

		// Token: 0x0600007E RID: 126
		public abstract bool TrySetValue(global::Infragistics.Windows.DataPresenter.Cell cell, object value, bool supressNotification, bool commit, bool refresh, out global::System.Exception ex);

		// Token: 0x0600007F RID: 127 RVA: 0x000094D8 File Offset: 0x000076D8
		public virtual bool AreValuesEqual(global::Infragistics.Windows.DataPresenter.Cell cell, object value)
		{
			int a_ = 13;
			short num = (short)418643977;
			int num2 = (int)((global::System.IntPtr)num);
			object value2;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)631504903;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_78;
				case 2:
				{
					num = (short)1149514515;
					short num3 = num;
					num = (short)746337043;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_227;
					default:
						goto IL_E8;
					}
					break;
				}
				case 3:
					goto IL_227;
				case 4:
					return true;
				case 5:
					return true;
				case 6:
					if (value != null)
					{
						num = (short)1682046978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15B;
				case 7:
					if (value2 == null)
					{
						num = (short)1732575237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_195;
				case 8:
					if (value2 == value)
					{
						num = (short)1932853252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)235995147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				case 10:
					if (value == null)
					{
						num = (short)805830656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 11:
				{
					num = (short)1727725569;
					if (num != 0)
					{
					}
					num = (short)1442971648;
					short num4 = num;
					if (value2 != null)
					{
						num = (short)1444544515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15B;
				}
				}
				IL_5E:
				if (cell == null)
				{
					num = (short)1311440897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				value2 = cell.Value;
				num = (short)349306888;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15B:
				num = (short)1291649034;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_227:
				num = (short)1853620230;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_78:
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("럓돕듗뛙", a_));
			IL_E8:
			num = (short)893779968;
			if (num != 0)
			{
			}
			return value2.Equals(value);
			IL_195:
			return string.IsNullOrEmpty(value2.ToString());
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00009748 File Offset: 0x00007948
		protected void EnsureCellIsInView(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			short num = (short)1436756164;
			short num2 = num;
			num = (short)524167364;
			switch (num2 == num)
			{
			}
			num = (short)9961472;
			short num3 = num;
			num = (short)2088566784;
			if (num != 0)
			{
			}
			num = (short)1456734209;
			if (num != 0)
			{
			}
			cell.DataPresenter.BringRecordIntoView(cell.Record);
			cell.DataPresenter.BringCellIntoView(cell);
		}

		// Token: 0x0400003A RID: 58
		private global::Motorola.CommonCPS.UI.CellRangeFill.ICellEditabilityResolver a;
	}
}
