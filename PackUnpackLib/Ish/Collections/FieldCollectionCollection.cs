using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Motorola.Acp.PackUnpack.Ish.Collections
{
	// Token: 0x02000096 RID: 150
	public class FieldCollectionCollection : global::System.Collections.ObjectModel.Collection<global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection>, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection>
	{
		// Token: 0x060005B5 RID: 1461 RVA: 0x0005E478 File Offset: 0x0005C678
		internal FieldCollectionCollection()
		{
			this.a = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection>();
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0005E498 File Offset: 0x0005C698
		protected override void InsertItem(int index, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection item)
		{
			short num = (short)1113522177;
			if (num != 0)
			{
			}
			num = (short)38305580;
			short num2 = num;
			num = (short)275676972;
			switch (num2 == num)
			{
			}
			num = (short)999555072;
			if (num != 0)
			{
			}
			num = (short)1327431680;
			short num3 = num;
			base.InsertItem(index, item);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0005E54C File Offset: 0x0005C74C
		protected override void SetItem(int index, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection item)
		{
			short num = (short)1182072833;
			if (num != 0)
			{
			}
			num = (short)973386210;
			short num2 = num;
			num = (short)389788130;
			switch (num2 == num)
			{
			}
			num = (short)1664155648;
			if (num != 0)
			{
			}
			num = (short)473825280;
			short num3 = num;
			base.SetItem(index, item);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0005E5FC File Offset: 0x0005C7FC
		protected override void RemoveItem(int index)
		{
			short num = (short)808158610;
			short num2 = num;
			num = (short)279086482;
			switch (num2 == num)
			{
			}
			num = (short)1521025024;
			if (num != 0)
			{
			}
			num = (short)1947992065;
			if (num != 0)
			{
			}
			num = (short)1183383552;
			short num3 = num;
			base.RemoveItem(index);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0005E6AC File Offset: 0x0005C8AC
		protected override void ClearItems()
		{
			short num = (short)1370161153;
			if (num != 0)
			{
			}
			num = (short)1708758110;
			short num2 = num;
			num = (short)1559991390;
			switch (num2 == num)
			{
			}
			num = (short)1390608384;
			if (num != 0)
			{
			}
			num = (short)1438777344;
			short num3 = num;
			base.ClearItems();
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0005E75C File Offset: 0x0005C95C
		public global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection> match)
		{
			int a_ = 7;
			short num = (short)1750925313;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_236;
				case 1:
					num = (short)533069825;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 2:
					goto IL_7D;
				}
				IL_63:
				if (match == null)
				{
					num = (short)896401410;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1012989952;
					short num3 = num;
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection>.Enumerator enumerator = this.a.GetEnumerator();
					num = (short)622592000;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_7D:
			IL_1D2:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솟횡잣캥", a_));
			IL_236:
			try
			{
				num = (short)2005336067;
				num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection>.Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)2084962310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2077808325;
						short num4 = num;
						num = (short)707253957;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FC;
						default:
						{
							num = (short)1187643392;
							if (num != 0)
							{
							}
							global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection fieldCollection = enumerator.Current;
							num = (short)1044119553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
					{
						global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection fieldCollection;
						if (match(fieldCollection))
						{
							num = (short)131399684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_111;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_C2;
						}
						continue;
					case 4:
					{
						global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection fieldCollection;
						result = fieldCollection;
						goto IL_FC;
					}
					case 5:
						goto IL_1C2;
					case 6:
						num = (short)1605435397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C4:
					num = (short)1230045184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C2:
					goto IL_C4;
					IL_FC:
					num = (short)1013186562;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_111:
				return result;
				IL_1C2:
				goto IL_1E6;
			}
			finally
			{
				global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection>.Enumerator enumerator;
				((global::System.IDisposable)enumerator).Dispose();
			}
			goto IL_1D2;
			IL_1E6:
			return null;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0005E9C4 File Offset: 0x0005CBC4
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection> match)
		{
			short num = (short)1837653362;
			short num2 = num;
			num = (short)973626738;
			switch (num2 == num)
			{
			}
			num = (short)1756102657;
			if (num != 0)
			{
			}
			num = (short)53084160;
			if (num != 0)
			{
			}
			num = (short)1170538496;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000196 RID: 406
		private global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection> a;
	}
}
