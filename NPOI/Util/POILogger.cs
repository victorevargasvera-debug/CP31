using System;
using System.Text;

namespace NPOI.Util
{
	// Token: 0x02000288 RID: 648
	public abstract class POILogger
	{
		// Token: 0x06001162 RID: 4450 RVA: 0x0000253E File Offset: 0x0000073E
		public POILogger()
		{
		}

		// Token: 0x06001163 RID: 4451
		public abstract void Initialize(string cat);

		// Token: 0x06001164 RID: 4452
		public abstract void Log(int level, object obj1);

		// Token: 0x06001165 RID: 4453
		public abstract void Log(int level, object obj1, global::System.Exception exception);

		// Token: 0x06001166 RID: 4454
		public abstract bool Check(int level);

		// Token: 0x06001167 RID: 4455 RVA: 0x000346F4 File Offset: 0x000328F4
		public virtual void Log(int level, object obj1, object obj2)
		{
			if (this.Check(level))
			{
				this.Log(level, new global::System.Text.StringBuilder(32).Append(obj1).Append(obj2));
			}
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00034719 File Offset: 0x00032919
		public virtual void Log(int level, object obj1, object obj2, object obj3)
		{
			if (this.Check(level))
			{
				this.Log(level, new global::System.Text.StringBuilder(48).Append(obj1).Append(obj2).Append(obj3));
			}
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00034745 File Offset: 0x00032945
		public virtual void Log(int level, object obj1, object obj2, object obj3, object obj4)
		{
			if (this.Check(level))
			{
				this.Log(level, new global::System.Text.StringBuilder(64).Append(obj1).Append(obj2).Append(obj3).Append(obj4));
			}
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00034778 File Offset: 0x00032978
		public virtual void Log(int level, object obj1, object obj2, object obj3, object obj4, object obj5)
		{
			if (this.Check(level))
			{
				this.Log(level, new global::System.Text.StringBuilder(80).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5));
			}
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x000347B4 File Offset: 0x000329B4
		public virtual void Log(int level, object obj1, object obj2, object obj3, object obj4, object obj5, object obj6)
		{
			if (this.Check(level))
			{
				this.Log(level, new global::System.Text.StringBuilder(96).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5).Append(obj6));
			}
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x00034800 File Offset: 0x00032A00
		public virtual void Log(int level, object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7)
		{
			if (this.Check(level))
			{
				this.Log(level, new global::System.Text.StringBuilder(112).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5).Append(obj6).Append(obj7));
			}
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00034854 File Offset: 0x00032A54
		public virtual void Log(int level, object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7, object obj8)
		{
			if (this.Check(level))
			{
				this.Log(level, new global::System.Text.StringBuilder(128).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5).Append(obj6).Append(obj7).Append(obj8));
			}
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x000348B1 File Offset: 0x00032AB1
		public virtual void Log(int level, global::System.Exception exception)
		{
			this.Log(level, null, exception);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x000348BC File Offset: 0x00032ABC
		public virtual void Log(int level, object obj1, object obj2, global::System.Exception exception)
		{
			if (this.Check(level))
			{
				this.Log(level, new global::System.Text.StringBuilder(32).Append(obj1).Append(obj2), exception);
			}
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x000348E3 File Offset: 0x00032AE3
		public virtual void Log(int level, object obj1, object obj2, object obj3, global::System.Exception exception)
		{
			if (this.Check(level))
			{
				this.Log(level, new global::System.Text.StringBuilder(48).Append(obj1).Append(obj2).Append(obj3), exception);
			}
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00034911 File Offset: 0x00032B11
		public virtual void Log(int level, object obj1, object obj2, object obj3, object obj4, global::System.Exception exception)
		{
			if (this.Check(level))
			{
				this.Log(level, new global::System.Text.StringBuilder(64).Append(obj1).Append(obj2).Append(obj3).Append(obj4), exception);
			}
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00034946 File Offset: 0x00032B46
		public virtual void Log(int level, object obj1, object obj2, object obj3, object obj4, object obj5, global::System.Exception exception)
		{
			if (this.Check(level))
			{
				this.Log(level, new global::System.Text.StringBuilder(80).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5), exception);
			}
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00034984 File Offset: 0x00032B84
		public virtual void Log(int level, object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, global::System.Exception exception)
		{
			if (this.Check(level))
			{
				this.Log(level, new global::System.Text.StringBuilder(96).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5).Append(obj6), exception);
			}
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x000349D4 File Offset: 0x00032BD4
		public virtual void Log(int level, object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7, global::System.Exception exception)
		{
			if (this.Check(level))
			{
				this.Log(level, new global::System.Text.StringBuilder(112).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5).Append(obj6).Append(obj7), exception);
			}
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00034A2C File Offset: 0x00032C2C
		public virtual void Log(int level, object obj1, object obj2, object obj3, object obj4, object obj5, object obj6, object obj7, object obj8, global::System.Exception exception)
		{
			if (this.Check(level))
			{
				this.Log(level, new global::System.Text.StringBuilder(128).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5).Append(obj6).Append(obj7).Append(obj8), exception);
			}
		}

		// Token: 0x0400075B RID: 1883
		public const int DEBUG = 1;

		// Token: 0x0400075C RID: 1884
		public const int INFO = 3;

		// Token: 0x0400075D RID: 1885
		public const int WARN = 5;

		// Token: 0x0400075E RID: 1886
		public const int ERROR = 7;

		// Token: 0x0400075F RID: 1887
		public const int FATAL = 9;
	}
}
