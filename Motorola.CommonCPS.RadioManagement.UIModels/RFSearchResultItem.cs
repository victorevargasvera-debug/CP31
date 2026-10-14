using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200005F RID: 95
	public class RFSearchResultItem : global::Motorola.CommonCPS.RadioManagement.UIModels.RfGuiPath
	{
		// Token: 0x060002BF RID: 703 RVA: 0x00029978 File Offset: 0x00027B78
		public RFSearchResultItem(global::Motorola.CommonCPS.RadioManagement.UIModels.RfGuiPath guiPath, string fieldName, string fieldValue, bool isVirtual)
		{
			if (guiPath != null)
			{
				base.ArrayFieldPath = guiPath.ArrayFieldPath;
				base.OriginalBLFullPath = guiPath.OriginalBLFullPath;
				base.Type = guiPath.Type;
				base.Path = guiPath.Path;
			}
			this.d = isVirtual;
			this.a = fieldName;
			this.b = fieldValue;
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x000299D8 File Offset: 0x00027BD8
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1799203573;
				short num2 = num;
				num = (short)287812341;
				switch (num2 == num)
				{
				}
				num = (short)199950336;
				if (num != 0)
				{
				}
				num = (short)1531445248;
				short num3 = num;
				num = (short)1192230913;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00029A88 File Offset: 0x00027C88
		public string Value
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1647264544;
				short num2 = num;
				num = (short)1827160864;
				switch (num2 == num)
				{
				}
				num = (short)873201665;
				if (num != 0)
				{
				}
				num = (short)1233387520;
				short num3 = num;
				num = (short)1586167808;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00029B38 File Offset: 0x00027D38
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00029BE4 File Offset: 0x00027DE4
		public bool Visible
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1592983553;
				if (num != 0)
				{
				}
				num = (short)677540680;
				short num2 = num;
				num = (short)448951112;
				switch (num2 == num)
				{
				}
				num = (short)728760320;
				short num3 = num;
				num = (short)521863168;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)330170369;
				if (num != 0)
				{
				}
				num = (short)672121915;
				short num2 = num;
				num = (short)2004206651;
				switch (num2 == num)
				{
				}
				num = (short)1594425344;
				short num3 = num;
				num = (short)910622720;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00029C98 File Offset: 0x00027E98
		public bool IsVirtural
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1192047721;
				short num2 = num;
				num = (short)1218196585;
				switch (num2 == num)
				{
				}
				num = (short)343539712;
				if (num != 0)
				{
				}
				num = (short)543621120;
				short num3 = num;
				num = (short)447021057;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x04000129 RID: 297
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string a;

		// Token: 0x0400012A RID: 298
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string b;

		// Token: 0x0400012B RID: 299
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c;

		// Token: 0x0400012C RID: 300
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly bool d;
	}
}
