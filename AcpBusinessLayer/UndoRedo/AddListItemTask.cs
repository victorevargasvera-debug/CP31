using System;
using AcpCommonResources;
using AcpUtility;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x0200004D RID: 77
	internal class AddListItemTask : global::AcpBusinessLayer.UndoRedo.ListItemTask
	{
		// Token: 0x060004E3 RID: 1251 RVA: 0x00068FAC File Offset: 0x000671AC
		internal AddListItemTask(global::AcpBusinessLayer.AcpListField field, string item) : base(field, item, field.Items.Count)
		{
			base.Description = global::AcpCommonResources.AcpResources.Add.AcpStringFormat(new object[]
			{
				item
			});
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00068FE8 File Offset: 0x000671E8
		public override void Do()
		{
			short num = (short)790757376;
			short num2 = num;
			num = (short)1511818413;
			short num3 = num;
			num = (short)104891565;
			switch (num3 == num)
			{
			}
			num = (short)1690632193;
			if (num != 0)
			{
			}
			num = (short)1984757760;
			if (num != 0)
			{
			}
			base.TheListField.AddItemHelper(base.ListItem);
			base.TheListField.CallConstraintsX();
			base.Do();
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000690B4 File Offset: 0x000672B4
		public override void Undo()
		{
			short num = (short)267780096;
			short num2 = num;
			num = (short)118356457;
			short num3 = num;
			num = (short)587987433;
			switch (num3 == num)
			{
			}
			num = (short)1907294209;
			if (num != 0)
			{
			}
			num = (short)1625489408;
			if (num != 0)
			{
			}
			base.TheListField.RemoveItemAt(base.Index);
			base.TheListField.CallConstraintsX();
			base.Undo();
		}
	}
}
