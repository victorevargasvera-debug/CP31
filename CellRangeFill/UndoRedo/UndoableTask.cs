using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.UI.CellRangeFill.UndoRedo
{
	// Token: 0x02000025 RID: 37
	public abstract class UndoableTask
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000BEF0 File Offset: 0x0000A0F0
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000BF9C File Offset: 0x0000A19C
		public string Description
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2078998528;
				short num2 = num;
				num = (short)1014237522;
				short num3 = num;
				num = (short)181864786;
				switch (num3 == num)
				{
				}
				num = (short)378011649;
				if (num != 0)
				{
				}
				num = (short)1228668928;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1455095808;
				short num2 = num;
				num = (short)1228996609;
				if (num != 0)
				{
				}
				num = (short)940186964;
				short num3 = num;
				num = (short)1878203732;
				switch (num3 == num)
				{
				}
				num = (short)219938816;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x060000C8 RID: 200
		public abstract void Do();

		// Token: 0x060000C9 RID: 201
		public abstract void Undo();

		// Token: 0x060000CA RID: 202 RVA: 0x0000C04C File Offset: 0x0000A24C
		public override string ToString()
		{
			short num = (short)720764928;
			short num2 = num;
			num = (short)1124018253;
			short num3 = num;
			num = (short)2144020557;
			switch (num3 == num)
			{
			}
			num = (short)361693184;
			if (num != 0)
			{
			}
			num = (short)1616576513;
			if (num != 0)
			{
			}
			return this.Description;
		}

		// Token: 0x04000047 RID: 71
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
