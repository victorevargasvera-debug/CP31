using System;
using System.Collections.ObjectModel;

namespace ASK.Core
{
	// Token: 0x02000012 RID: 18
	[global::System.Serializable]
	public class AccessRecordSetX<T> : global::System.Collections.ObjectModel.ObservableCollection<T>
	{
		// Token: 0x0600009E RID: 158 RVA: 0x0001115C File Offset: 0x0000F35C
		protected AccessRecordSetX()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00011170 File Offset: 0x0000F370
		internal AccessRecordSetX(string A_0)
		{
			this.name = A_0;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0001118C File Offset: 0x0000F38C
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0001123C File Offset: 0x0000F43C
		internal string Name
		{
			get
			{
				short num = (short)1688600576;
				short num2 = num;
				num = (short)1626908463;
				short num3 = num;
				num = (short)536192815;
				switch (num3 == num)
				{
				}
				num = (short)50069505;
				if (num != 0)
				{
				}
				num = (short)569704448;
				if (num != 0)
				{
				}
				return this.name;
			}
			set
			{
				short num = (short)594542592;
				short num2 = num;
				num = (short)1715073229;
				short num3 = num;
				num = (short)243200205;
				switch (num3 == num)
				{
				}
				num = (short)807927809;
				if (num != 0)
				{
				}
				num = (short)1757741056;
				if (num != 0)
				{
				}
				this.name = value;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000112EC File Offset: 0x0000F4EC
		internal void a(T A_0)
		{
			short num = (short)829030400;
			short num2 = num;
			num = (short)88235159;
			short num3 = num;
			num = (short)410999959;
			switch (num3 == num)
			{
			}
			num = (short)570032129;
			if (num != 0)
			{
			}
			num = (short)708902912;
			if (num != 0)
			{
			}
			base.Add(A_0);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000113A0 File Offset: 0x0000F5A0
		internal void b(T A_0)
		{
			short num = (short)376176640;
			short num2 = num;
			num = (short)2101714058;
			short num3 = num;
			num = (short)625450122;
			switch (num3 == num)
			{
			}
			num = (short)915603456;
			if (num != 0)
			{
			}
			num = (short)932118529;
			if (num != 0)
			{
			}
			base.Remove(A_0);
		}

		// Token: 0x04000034 RID: 52
		private string name;
	}
}
