using System;
using System.Runtime.CompilerServices;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x0200005B RID: 91
	internal class MoveListItemTask : global::AcpBusinessLayer.UndoRedo.ListItemTask
	{
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0006DE38 File Offset: 0x0006C038
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x0006DEE4 File Offset: 0x0006C0E4
		private protected int NewIndex
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected get
			{
				short num = (short)478412801;
				if (num != 0)
				{
				}
				num = (short)1663339068;
				short num2 = num;
				num = (short)2116061756;
				switch (num2 == num)
				{
				}
				num = (short)759627776;
				short num3 = num;
				num = (short)626524160;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)125084633;
				short num2 = num;
				num = (short)796763097;
				switch (num2 == num)
				{
				}
				num = (short)1356201984;
				if (num != 0)
				{
				}
				num = (short)1220935680;
				short num3 = num;
				num = (short)204275713;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0006DF94 File Offset: 0x0006C194
		internal MoveListItemTask(global::AcpBusinessLayer.AcpListField field, int oldIndex, int newIndex) : base(field, field.Items[oldIndex].ItemName, oldIndex)
		{
			this.NewIndex = newIndex;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0006DFC4 File Offset: 0x0006C1C4
		public override void Do()
		{
			short num = (short)1327688257;
			short num2 = num;
			num = (short)1284434497;
			switch (num2 == num)
			{
			}
			num = (short)1567424513;
			if (num != 0)
			{
			}
			num = (short)1647050752;
			short num3 = num;
			num = (short)1796866048;
			if (num != 0)
			{
			}
			this.a();
			base.Do();
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0006E07C File Offset: 0x0006C27C
		public override void Undo()
		{
			short num = (short)341738900;
			short num2 = num;
			num = (short)227640724;
			switch (num2 == num)
			{
			}
			num = (short)103415809;
			if (num != 0)
			{
			}
			num = (short)1028718592;
			short num3 = num;
			num = (short)1687420928;
			if (num != 0)
			{
			}
			this.a();
			base.Undo();
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0006E134 File Offset: 0x0006C334
		private void a()
		{
			short num = (short)1649278977;
			if (num != 0)
			{
			}
			num = (short)1020610359;
			short num2 = num;
			num = (short)687425335;
			switch (num2 == num)
			{
			}
			num = (short)829095936;
			short num3 = num;
			num = (short)36044800;
			if (num != 0)
			{
			}
			base.TheListField.MoveItem(base.Index, this.NewIndex);
			int index = base.Index;
			base.Index = this.NewIndex;
			this.NewIndex = index;
		}

		// Token: 0x04000173 RID: 371
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int a;
	}
}
