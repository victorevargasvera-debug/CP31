using System;
using AcpCommonResources;
using AcpUtility;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x0200005D RID: 93
	internal class RemoveListItemTask : global::AcpBusinessLayer.UndoRedo.ListItemTask
	{
		// Token: 0x06000528 RID: 1320 RVA: 0x0006EB30 File Offset: 0x0006CD30
		internal RemoveListItemTask(global::AcpBusinessLayer.AcpListField field, int index) : base(field, field.Items[index].ItemName, index)
		{
			base.Description = global::AcpCommonResources.AcpResources.Remove.AcpStringFormat(new object[]
			{
				base.ListItem
			});
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0006EB78 File Offset: 0x0006CD78
		public override void Do()
		{
			short num = (short)751856484;
			short num2 = num;
			num = (short)1797942116;
			switch (num2 == num)
			{
			}
			num = (short)2092761089;
			if (num != 0)
			{
			}
			num = (short)859373568;
			short num3 = num;
			num = (short)721551360;
			if (num != 0)
			{
			}
			base.TheListField.RemoveItemAt(base.Index);
			base.TheListField.CallConstraintsX();
			base.Do();
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0006EC44 File Offset: 0x0006CE44
		public override void Undo()
		{
			short num = (short)1277253332;
			short num2 = num;
			num = (short)663115476;
			switch (num2 == num)
			{
			}
			num = (short)1748631553;
			if (num != 0)
			{
			}
			num = (short)1796800512;
			short num3 = num;
			num = (short)1103233024;
			if (num != 0)
			{
			}
			base.TheListField.InsertItem(base.Index, base.ListItem);
			base.TheListField.CallConstraintsX();
			base.Undo();
		}
	}
}
