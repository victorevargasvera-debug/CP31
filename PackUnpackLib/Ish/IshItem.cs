using System;
using System.Collections.Generic;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000010 RID: 16
	public abstract class IshItem
	{
		// Token: 0x0600009F RID: 159 RVA: 0x0000EB34 File Offset: 0x0000CD34
		private IshItem(global::Motorola.Acp.PackUnpack.Ish.IshType A_0, int A_1)
		{
			int a_ = 12;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪢횤쾦ﶨ튪\uddac쪮", a_));
			}
			this.b = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(A_0.Value, A_1);
			this.a = A_0;
			this.c = null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000EB8C File Offset: 0x0000CD8C
		protected IshItem(global::Motorola.Acp.PackUnpack.Ish.IshType ishType, int id, global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout layout)
		{
			int a_ = 19;
			base..ctor();
			if (ishType == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쎩\udfab욭쮱쒳펵", a_));
			}
			if (layout == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("용춫힭\udfaf잱삳", a_));
			}
			this.b = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(ishType.Value, id);
			this.a = ishType;
			this.c = layout;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000EBFC File Offset: 0x0000CDFC
		internal global::Motorola.Acp.PackUnpack.Ish.IshType Type
		{
			get
			{
				short num = (short)968385035;
				short num2 = num;
				num = (short)183132683;
				switch (num2 == num)
				{
				}
				num = (short)1137508353;
				if (num != 0)
				{
				}
				num = (short)1659568128;
				short num3 = num;
				num = (short)449642496;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000ECAC File Offset: 0x0000CEAC
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000ED5C File Offset: 0x0000CF5C
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout Layout
		{
			get
			{
				short num = (short)1283523078;
				short num2 = num;
				num = (short)29557254;
				switch (num2 == num)
				{
				}
				num = (short)1506738177;
				if (num != 0)
				{
				}
				num = (short)1456078848;
				short num3 = num;
				num = (short)1679884288;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				int a_ = 17;
				short num = (short)33226754;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_B9;
					case 1:
					{
						num = (short)1135804417;
						if (num != 0)
						{
						}
						bool flag;
						if (!flag)
						{
							num = (short)844890112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C7;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_41;
						}
						continue;
					case 3:
						try
						{
							num = (short)1387986948;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)56688646;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)810680323;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									bool flag = true;
									num = (short)1759444994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_1B2;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
									if (enumerator.Current == this.a)
									{
										num = (short)521011201;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_166;
									}
									continue;
								case 5:
									goto IL_20C;
								case 6:
									num = (short)1251082245;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_168:
								num = (short)258080768;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_166:
								goto IL_168;
							}
							IL_1B2:
							IL_20C:
							goto IL_61;
						}
						finally
						{
							num = (short)1644429313;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_27A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_242;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1389428736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_242:
								if (enumerator == null)
								{
									goto IL_2C6;
								}
								num = (short)1836843010;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_27A:
							num = (short)2141590502;
							short num3 = num;
							num = (short)703468518;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1935212544;
								if (num != 0)
								{
								}
								break;
							}
							IL_2C6:;
						}
						goto IL_2C7;
						IL_61:
						num = (short)2126512129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						bool flag = false;
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator = this.c.IshTypes.GetEnumerator();
						num = (short)740163587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_41:
					if (value == null)
					{
						goto IL_2C7;
					}
					num = (short)178585604;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B9:
				num = (short)706871296;
				short num4 = num;
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udea7쮩삫\udbad햯", a_));
				IL_2C7:
				this.c = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000F048 File Offset: 0x0000D248
		internal int Id
		{
			get
			{
				short num = (short)1142156460;
				short num2 = num;
				num = (short)1906240684;
				switch (num2 == num)
				{
				}
				num = (short)1651900417;
				if (num != 0)
				{
				}
				num = (short)660209664;
				short num3 = num;
				num = (short)440467456;
				if (num != 0)
				{
				}
				return this.b.Id;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000F0FC File Offset: 0x0000D2FC
		internal global::Motorola.Acp.PackUnpack.Ish.IshItemName Name
		{
			get
			{
				short num = (short)557772384;
				short num2 = num;
				num = (short)1216409184;
				switch (num2 == num)
				{
				}
				num = (short)1898577921;
				if (num != 0)
				{
				}
				num = (short)572063744;
				short num3 = num;
				num = (short)1036451840;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A6 RID: 166
		public abstract int Length { get; }

		// Token: 0x04000030 RID: 48
		private global::Motorola.Acp.PackUnpack.Ish.IshType a;

		// Token: 0x04000031 RID: 49
		private global::Motorola.Acp.PackUnpack.Ish.IshItemName b;

		// Token: 0x04000032 RID: 50
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout c;
	}
}
