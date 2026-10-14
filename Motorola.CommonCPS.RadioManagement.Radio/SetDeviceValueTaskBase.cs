using System;
using System.Runtime.CompilerServices;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.UI.CellRangeFill;
using Motorola.CommonCPS.UI.CellRangeFill.UndoRedo;
using Motorola.CommonCPS.UI.CellRangeSelect;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000009 RID: 9
	public abstract class SetDeviceValueTaskBase : global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.SetCellValueTask
	{
		// Token: 0x0600001B RID: 27 RVA: 0x0000494C File Offset: 0x00002B4C
		public SetDeviceValueTaskBase(global::Infragistics.Windows.DataPresenter.DataRecordCollection records, global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition position, global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter setter, object newValue, global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation operation, global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range, bool autoCorrect) : base(records, position, setter, newValue, operation, range, autoCorrect)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00004960 File Offset: 0x00002B60
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00004A10 File Offset: 0x00002C10
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase OldDevice
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1391456675;
				short num2 = num;
				num = (short)766046627;
				switch (num2 == num)
				{
				}
				num = (short)1660682240;
				if (num != 0)
				{
				}
				num = (short)780009472;
				short num3 = num;
				num = (short)1395851265;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1862629514;
				short num2 = num;
				num = (short)1907259530;
				switch (num2 == num)
				{
				}
				num = (short)242614272;
				if (num != 0)
				{
				}
				num = (short)1359282176;
				short num3 = num;
				num = (short)2102853633;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00004AC4 File Offset: 0x00002CC4
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00004B74 File Offset: 0x00002D74
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase NewDevice
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2104986143;
				short num2 = num;
				num = (short)394758687;
				switch (num2 == num)
				{
				}
				num = (short)1223163905;
				if (num != 0)
				{
				}
				num = (short)1025835008;
				short num3 = num;
				num = (short)1642332160;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)512714142;
				short num2 = num;
				num = (short)133391774;
				switch (num2 == num)
				{
				}
				num = (short)469958656;
				if (num != 0)
				{
				}
				num = (short)498532352;
				short num3 = num;
				num = (short)771096577;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004C28 File Offset: 0x00002E28
		public override void Do()
		{
			short num = (short)1559114860;
			short num2 = num;
			num = (short)2037003372;
			switch (num2 == num)
			{
			}
			num = (short)2080833537;
			if (num != 0)
			{
			}
			num = (short)849281024;
			short num3 = num;
			num = (short)58261504;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.DataPresenter.Cell targetCell = base.GetTargetCell();
			this.NewDevice = (global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)targetCell.Record.DataItem;
			this.OldDevice = this.CreateDevice();
			this.OldDevice.CopyFrom(this.NewDevice);
			base.Do();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004D10 File Offset: 0x00002F10
		public override void Undo()
		{
			short num = (short)1084823296;
			short num2 = num;
			num = (short)2001868544;
			switch (num2 == num)
			{
			}
			num = (short)1998782465;
			if (num != 0)
			{
			}
			num = (short)295960576;
			short num3 = num;
			num = (short)25034752;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = (global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)base.GetTargetCell().Record.DataItem;
			this.NewDevice.CopyFrom(this.OldDevice);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004DE0 File Offset: 0x00002FE0
		public override void Commit()
		{
			int a_ = 7;
			global::Infragistics.Windows.DataPresenter.Cell targetCell = base.GetTargetCell();
			this.NewDevice.CopyFrom(this.OldDevice);
			if (targetCell.Field.Name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ﲺ쾼킾듀돂评ꛆ꓈껊", a_))
			{
				short num;
				for (;;)
				{
					num = (short)1523291170;
					short num2 = num;
					num = (short)1775342626;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_A4;
					}
					break;
				}
				num = (short)344326144;
				short num3 = num;
				IL_A4:
				num = (short)1889796097;
				if (num != 0)
				{
				}
				num = (short)364380160;
				if (num != 0)
				{
				}
				targetCell.IsActive = true;
				base.Setter.SetValue(targetCell, base.NewValue, true, true, true);
				return;
			}
			base.Commit();
		}

		// Token: 0x06000023 RID: 35
		protected abstract global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase CreateDevice();

		// Token: 0x0400001F RID: 31
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase a;

		// Token: 0x04000020 RID: 32
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase b;
	}
}
