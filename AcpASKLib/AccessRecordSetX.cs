using System;
using System.Collections.ObjectModel;

namespace AcpASKLib
{
	// Token: 0x02000015 RID: 21
	[global::System.Serializable]
	public class AccessRecordSetX<T> : global::System.Collections.ObjectModel.ObservableCollection<T>
	{
		// Token: 0x0600009B RID: 155 RVA: 0x0000FCE0 File Offset: 0x0000DEE0
		protected AccessRecordSetX()
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000FCF4 File Offset: 0x0000DEF4
		internal AccessRecordSetX(string A_0)
		{
			this.name = A_0;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000FD10 File Offset: 0x0000DF10
		// (set) Token: 0x0600009E RID: 158 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
		internal string Name
		{
			get
			{
				short num = (short)1691289422;
				short num2 = num;
				num = (short)1919223630;
				switch (num2 == num)
				{
				}
				num = (short)1631911937;
				if (num != 0)
				{
				}
				num = (short)141361152;
				if (num != 0)
				{
				}
				num = (short)1682636800;
				short num3 = num;
				return this.name;
			}
			set
			{
				short num = (short)354022522;
				short num2 = num;
				num = (short)343864442;
				switch (num2 == num)
				{
				}
				num = (short)1331888129;
				if (num != 0)
				{
				}
				num = (short)1484521472;
				if (num != 0)
				{
				}
				num = (short)615055360;
				short num3 = num;
				this.name = value;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000FE70 File Offset: 0x0000E070
		internal void a(T A_0)
		{
			short num = (short)1507119315;
			short num2 = num;
			num = (short)218484947;
			switch (num2 == num)
			{
			}
			num = (short)625737729;
			if (num != 0)
			{
			}
			num = (short)2047868928;
			if (num != 0)
			{
			}
			num = (short)1053163520;
			short num3 = num;
			base.Add(A_0);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000FF20 File Offset: 0x0000E120
		internal void b(T A_0)
		{
			short num = (short)2057717554;
			short num2 = num;
			num = (short)1758021426;
			switch (num2 == num)
			{
			}
			num = (short)778043393;
			if (num != 0)
			{
			}
			num = (short)137494528;
			if (num != 0)
			{
			}
			num = (short)1085341696;
			short num3 = num;
			base.Remove(A_0);
		}

		// Token: 0x040000F1 RID: 241
		private string name;
	}
}
