using System;
using System.Runtime.CompilerServices;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x0200004E RID: 78
	internal class ListItemTask : global::AcpBusinessLayer.UndoRedo.FieldTaskBase
	{
		// Token: 0x060004E6 RID: 1254 RVA: 0x00069180 File Offset: 0x00067380
		protected ListItemTask(global::AcpBusinessLayer.AcpListField field, string listItem, int index)
		{
			this.field = field;
			this.ListItem = listItem;
			this.Index = index;
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x000691A8 File Offset: 0x000673A8
		protected global::AcpBusinessLayer.AcpListField TheListField
		{
			get
			{
				short num = (short)235916956;
				short num2 = num;
				num = (short)2085539484;
				switch (num2 == num)
				{
				}
				num = (short)1960181761;
				if (num != 0)
				{
				}
				num = (short)1922760704;
				short num3 = num;
				num = (short)1859911680;
				if (num != 0)
				{
				}
				return this.field as global::AcpBusinessLayer.AcpListField;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0006925C File Offset: 0x0006745C
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00069308 File Offset: 0x00067508
		protected string ListItem
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1003735574;
				short num2 = num;
				num = (short)1647888918;
				switch (num2 == num)
				{
				}
				num = (short)2126512129;
				if (num != 0)
				{
				}
				num = (short)1943404544;
				short num3 = num;
				num = (short)1209139200;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)291750565;
				short num2 = num;
				num = (short)990429861;
				switch (num2 == num)
				{
				}
				num = (short)291176449;
				if (num != 0)
				{
				}
				num = (short)477364224;
				short num3 = num;
				num = (short)2105737216;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x000693BC File Offset: 0x000675BC
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x0006946C File Offset: 0x0006766C
		protected int Index
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2030885506;
				short num2 = num;
				num = (short)1140841090;
				switch (num2 == num)
				{
				}
				num = (short)757727233;
				if (num != 0)
				{
				}
				num = (short)1458831360;
				short num3 = num;
				num = (short)381288448;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)729464870;
				short num2 = num;
				num = (short)669564966;
				switch (num2 == num)
				{
				}
				num = (short)2098003969;
				if (num != 0)
				{
				}
				num = (short)1184497664;
				short num3 = num;
				num = (short)863371264;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x04000151 RID: 337
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x04000152 RID: 338
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int b;
	}
}
