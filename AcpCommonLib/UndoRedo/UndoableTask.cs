using System;
using System.Runtime.CompilerServices;
using AcpCommonResources;

namespace AcpCommonLib.UndoRedo
{
	// Token: 0x02000033 RID: 51
	public class UndoableTask
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00012330 File Offset: 0x00010530
		protected bool Done
		{
			get
			{
				short num = (short)1759596841;
				short num2 = num;
				num = (short)818565417;
				switch (num2 == num)
				{
				}
				num = (short)53149697;
				if (num != 0)
				{
				}
				num = (short)22413312;
				short num3 = num;
				num = (short)1224998912;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000201 RID: 513 RVA: 0x000123E0 File Offset: 0x000105E0
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00012494 File Offset: 0x00010694
		public bool Seamless
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)675828032;
				short num2 = num;
				num = (short)99832128;
				switch (num2 == num)
				{
				}
				num = (short)113311744;
				if (num != 0)
				{
				}
				num = (short)394461184;
				short num3 = num;
				num = (short)58589185;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)426746888;
				short num2 = num;
				num = (short)1526178824;
				switch (num2 == num)
				{
				}
				num = (short)403832832;
				if (num != 0)
				{
				}
				num = (short)153944064;
				short num3 = num;
				num = (short)455409665;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00012544 File Offset: 0x00010744
		// (set) Token: 0x06000204 RID: 516 RVA: 0x000125F4 File Offset: 0x000107F4
		protected string Description
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)340206166;
				short num2 = num;
				num = (short)1119691350;
				switch (num2 == num)
				{
				}
				num = (short)1725366273;
				if (num != 0)
				{
				}
				num = (short)465829888;
				short num3 = num;
				num = (short)677511168;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)24233474;
				short num2 = num;
				num = (short)1145554434;
				switch (num2 == num)
				{
				}
				num = (short)1031208961;
				if (num != 0)
				{
				}
				num = (short)500039680;
				short num3 = num;
				num = (short)2076639232;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000126A4 File Offset: 0x000108A4
		protected UndoableTask()
		{
			this.Description = global::AcpCommonResources.AcpResources.No_Info;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000126C4 File Offset: 0x000108C4
		public virtual void Do()
		{
			short num = (short)1479981771;
			short num2 = num;
			num = (short)99334859;
			switch (num2 == num)
			{
			}
			num = (short)1002110977;
			if (num != 0)
			{
			}
			num = (short)1117454336;
			short num3 = num;
			num = (short)609353728;
			if (num != 0)
			{
			}
			this.a = true;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00012774 File Offset: 0x00010974
		public virtual void Undo()
		{
			short num = (short)963057248;
			short num2 = num;
			num = (short)2086278752;
			switch (num2 == num)
			{
			}
			num = (short)626982913;
			if (num != 0)
			{
			}
			num = (short)1256587264;
			short num3 = num;
			num = (short)1951072256;
			if (num != 0)
			{
			}
			this.a = false;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00012824 File Offset: 0x00010A24
		public override string ToString()
		{
			short num = (short)1994333134;
			short num2 = num;
			num = (short)1218714574;
			switch (num2 == num)
			{
			}
			num = (short)1487077377;
			if (num != 0)
			{
			}
			num = (short)984809472;
			short num3 = num;
			num = (short)1406402560;
			if (num != 0)
			{
			}
			return this.Description;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000128D4 File Offset: 0x00010AD4
		public virtual void LaunchUI()
		{
			short num = (short)2111436148;
			short num2 = num;
			num = (short)659617140;
			switch (num2 == num)
			{
			}
			num = (short)8847361;
			if (num != 0)
			{
			}
			num = (short)634781696;
			short num3 = num;
			num = (short)378601472;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000A3 RID: 163
		private bool a;

		// Token: 0x040000A4 RID: 164
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;

		// Token: 0x040000A5 RID: 165
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;
	}
}
