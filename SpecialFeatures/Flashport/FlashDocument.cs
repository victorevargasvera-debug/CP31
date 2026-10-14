using System;
using System.Collections.Generic;

namespace SpecialFeatures.Flashport
{
	// Token: 0x020000C3 RID: 195
	public class FlashDocument
	{
		// Token: 0x06000C41 RID: 3137 RVA: 0x00002E6C File Offset: 0x0000106C
		public FlashDocument()
		{
			this.a = new global::System.Collections.Generic.Dictionary<int, global::SpecialFeatures.Flashport.Recordset>();
			global::SpecialFeatures.Flashport.FlashDataManager.FlashDoc = this;
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x000FDB0C File Offset: 0x000FBD0C
		public void Clear()
		{
			short num = (short)1966250579;
			short num2 = num;
			num = (short)2023594579;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)49938432;
				short num3 = num;
				num = (short)839778304;
				if (num != 0)
				{
				}
				num = (short)2019819521;
				if (num != 0)
				{
				}
				using (global::System.Collections.Generic.Dictionary<int, global::SpecialFeatures.Flashport.Recordset>.ValueCollection.Enumerator enumerator = this.a.Values.GetEnumerator())
				{
					num = (short)62128132;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::SpecialFeatures.Flashport.Recordset recordset;
							if (recordset != null)
							{
								num = (short)955842562;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)304873478;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::SpecialFeatures.Flashport.Recordset recordset = enumerator.Current;
							num = (short)1423900672;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::SpecialFeatures.Flashport.Recordset recordset;
							recordset.Clear();
							num = (short)692322307;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_ED;
							}
							continue;
						case 5:
							goto IL_197;
						case 6:
							num = (short)221773829;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_126:
						num = (short)1885798401;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_ED:
						goto IL_126;
					}
					IL_197:;
				}
				break;
			}
			}
			this.a.Clear();
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x000FDCDC File Offset: 0x000FBEDC
		protected internal void AddFeature(global::SpecialFeatures.Flashport.Recordset recset)
		{
			short num = (short)1907061074;
			short num2 = num;
			num = (short)2057990482;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1434451968;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1638268928;
			if (num != 0)
			{
			}
			num = (short)597098497;
			if (num != 0)
			{
			}
			this.a[recset.RecsetId] = recset;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x000FDD98 File Offset: 0x000FBF98
		internal global::SpecialFeatures.Flashport.Recordset GetFeature(int id)
		{
			while (this.a.ContainsKey(id))
			{
				short num = (short)767852536;
				short num2 = num;
				num = (short)555122680;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1023606784;
					short num3 = num;
					break;
				}
				}
				num = (short)674365441;
				if (num != 0)
				{
				}
				num = (short)1897267200;
				if (num != 0)
				{
				}
				return this.a[id];
			}
			return null;
		}

		// Token: 0x040005F8 RID: 1528
		private global::System.Collections.Generic.Dictionary<int, global::SpecialFeatures.Flashport.Recordset> a;
	}
}
