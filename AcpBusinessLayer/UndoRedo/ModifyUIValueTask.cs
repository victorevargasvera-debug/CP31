using System;
using AcpCommonResources;
using AcpUtility;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x0200005A RID: 90
	public class ModifyUIValueTask<TUIValue> : global::AcpBusinessLayer.UndoRedo.FieldTaskBase
	{
		// Token: 0x06000518 RID: 1304 RVA: 0x0006DB38 File Offset: 0x0006BD38
		private ModifyUIValueTask()
		{
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0006DB4C File Offset: 0x0006BD4C
		public ModifyUIValueTask(global::AcpBusinessLayer.AcpFieldBase field, TUIValue newValue)
		{
			int a_ = 1;
			base..ctor();
			this.field = field;
			this.b = field.UIInvalid;
			this.a = newValue.ToString();
			base.Description = global::AcpCommonResources.AcpResources.Change.AcpStringFormat(new object[]
			{
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_) + field.UIName + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_)
			});
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0006DBD0 File Offset: 0x0006BDD0
		public override void Do()
		{
			short num = (short)1615745490;
			short num2 = num;
			num = (short)574640594;
			switch (num2 == num)
			{
			}
			num = (short)920322048;
			if (num != 0)
			{
			}
			num = (short)1929117696;
			short num3 = num;
			num = (short)1144848385;
			if (num != 0)
			{
			}
			this.SwapValues();
			base.Do();
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0006DC88 File Offset: 0x0006BE88
		public override void Undo()
		{
			short num = (short)1419568846;
			short num2 = num;
			num = (short)1586554574;
			switch (num2 == num)
			{
			}
			num = (short)1803550721;
			if (num != 0)
			{
			}
			num = (short)571932672;
			short num3 = num;
			num = (short)1942487040;
			if (num != 0)
			{
			}
			this.SwapValues();
			base.Undo();
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0006DD3C File Offset: 0x0006BF3C
		protected virtual void SwapValues()
		{
			short num = (short)1060847435;
			short num2 = num;
			num = (short)1337278283;
			switch (num2 == num)
			{
			}
			num = (short)494206977;
			if (num != 0)
			{
			}
			num = (short)2038038528;
			short num3 = num;
			num = (short)1820459008;
			if (num != 0)
			{
			}
			string text = this.field.ToString();
			bool uiinvalid = this.field.UIInvalid;
			this.field.ParseValueFrom(this.a.ToString());
			this.field.CallConstraintsX();
			this.field.FirePropertyChangedEvent();
			this.b = uiinvalid;
			this.a = text;
		}

		// Token: 0x04000171 RID: 369
		private string a;

		// Token: 0x04000172 RID: 370
		private bool b;
	}
}
