using System;
using AcpCommonResources;
using AcpUtility;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x0200005E RID: 94
	public class SetRefRecsetTask : global::AcpBusinessLayer.UndoRedo.FieldTaskBase
	{
		// Token: 0x0600052B RID: 1323 RVA: 0x0006ED18 File Offset: 0x0006CF18
		internal SetRefRecsetTask(global::AcpBusinessLayer.AcpRecRefField recRefField, global::AcpBusinessLayer.Recordset newRecset)
		{
			this.field = recRefField;
			this.a = newRecset;
			this.b = recRefField.UIValue;
			base.Description = global::AcpCommonResources.AcpResources.Is_Set_To.AcpStringFormat(new object[]
			{
				recRefField.UIName,
				(newRecset != null) ? newRecset.UIName : recRefField.InvalidText
			});
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0006ED7C File Offset: 0x0006CF7C
		public override void Do()
		{
			short num = (short)1513291777;
			if (num != 0)
			{
			}
			num = (short)1866460930;
			short num2 = num;
			num = (short)1412296450;
			switch (num2 == num)
			{
			}
			num = (short)393216000;
			short num3 = num;
			num = (short)2021982208;
			if (num != 0)
			{
			}
			this.SwapValues();
			base.Do();
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0006EE34 File Offset: 0x0006D034
		public override void Undo()
		{
			short num = (short)1812585538;
			short num2 = num;
			num = (short)748215362;
			switch (num2 == num)
			{
			}
			num = (short)1127874561;
			if (num != 0)
			{
			}
			num = (short)79429632;
			short num3 = num;
			num = (short)148504576;
			if (num != 0)
			{
			}
			this.SwapValues();
			base.Undo();
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0006EEEC File Offset: 0x0006D0EC
		internal void SwapValues()
		{
			short num = (short)1163788868;
			short num2 = num;
			num = (short)1242825284;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_8C:
				num = (short)1262682112;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)130809856;
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
			global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					if (base.Done)
					{
						num = (short)736165889;
						if (num != 0)
						{
						}
						num = (short)1958084609;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13C;
				case 1:
				{
					acpRecRefField.UIValue = this.b;
					num = (short)1399652352;
					short num4 = num;
					num = (short)1571880962;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_13A;
				}
				goto IL_66;
			}
			IL_13A:
			IL_13C:
			global::AcpBusinessLayer.Recordset refRecset;
			this.a = refRecset;
			string uivalue;
			this.b = uivalue;
			acpRecRefField.SetUITimer();
			return;
			IL_66:
			acpRecRefField = (this.field as global::AcpBusinessLayer.AcpRecRefField);
			refRecset = acpRecRefField.RefRecset;
			uivalue = acpRecRefField.UIValue;
			acpRecRefField.SetRecset(this.a);
			goto IL_8C;
		}

		// Token: 0x04000175 RID: 373
		private global::AcpBusinessLayer.Recordset a;

		// Token: 0x04000176 RID: 374
		private string b;
	}
}
