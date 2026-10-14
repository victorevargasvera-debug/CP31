using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Utility
{
	// Token: 0x0200000E RID: 14
	public class ConcurrentObserverCollection<T> : global::System.Collections.ObjectModel.ObservableCollection<T>
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00006E20 File Offset: 0x00005020
		public ConcurrentObserverCollection(T fixItem, global::System.Collections.ObjectModel.ObservableCollection<T> targetCollection) : base(targetCollection)
		{
			base.Insert(0, fixItem);
			this.a = targetCollection;
			this.a.CollectionChanged += this.a;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006E5C File Offset: 0x0000505C
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)2113339392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_91;
				}
				int num4;
				T[] array;
				for (;;)
				{
					IL_29:
					num = (short)1635844096;
					short num3 = num;
					switch (num2)
					{
					case 0:
						if (num4 + 1 < base.Count)
						{
							num = (short)735051788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						base.Add(array[num4]);
						num = (short)623968258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_DF;
					case 2:
						goto IL_DF;
					case 3:
					{
						num = (short)1695416321;
						if (num != 0)
						{
						}
						int num5 = array.Length;
						num = (short)2088960008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						int num5;
						if (num5 >= this.a.Count)
						{
							num = (short)504102923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						base.RemoveAt(num5);
						num = (short)1079601826;
						short num6 = num;
						num = (short)389769890;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13D;
						default:
							num = (short)632029184;
							if (num != 0)
							{
							}
							num = (short)2056257543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						goto IL_211;
					case 6:
						if (num4 >= array.Length)
						{
							num = (short)2049703939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)313196544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_275;
					case 8:
						goto IL_275;
					case 9:
						base[num4 + 1] = array[num4];
						num = (short)624885761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						T t;
						if (!t.Equals(array[num4]))
						{
							goto IL_13D;
						}
						goto IL_DF;
					}
					case 11:
						return;
					case 12:
					{
						T t = base[num4 + 1];
						num = (short)1218248714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_211;
					}
					goto IL_91;
					IL_DF:
					num4++;
					num = (short)524156941;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13D:
					num = (short)880803849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_211:
					num = (short)407175174;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_275:
					num = (short)130285572;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_91:
				array = this.a.ToArray<T>();
				num4 = 0;
				num = (short)1428291589;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x04000028 RID: 40
		private global::System.Collections.ObjectModel.ObservableCollection<T> a;
	}
}
