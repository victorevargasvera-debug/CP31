using System;
using System.Reflection;

namespace AcpBusinessLayer
{
	// Token: 0x02000036 RID: 54
	public static class MemoryUtility
	{
		// Token: 0x060003CB RID: 971 RVA: 0x0004E5F4 File Offset: 0x0004C7F4
		public static void RemoveEventHandler(string name, global::System.Type notfyObjType, object obj)
		{
			short num = (short)1209860096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				global::System.Reflection.EventInfo @event;
				for (;;)
				{
					IL_27:
					object obj2;
					object obj3;
					switch (num2)
					{
					case 0:
					{
						num = (short)1408040960;
						short num3 = num;
						obj2 = null;
						goto IL_268;
					}
					case 1:
					{
						global::System.Delegate @delegate = obj3 as global::System.Delegate;
						num = (short)1184628746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_1A8;
					case 3:
						goto IL_170;
					case 4:
						num = (short)1206255627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::System.Delegate @delegate;
						global::System.Delegate[] invocationList = @delegate.GetInvocationList();
						int num4 = 0;
						num = (short)1729888259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_170;
					case 7:
					{
						global::System.Delegate[] invocationList;
						int num4;
						if (num4 >= invocationList.Length)
						{
							num = (short)1727397890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Delegate handler = invocationList[num4];
						@event.RemoveEventHandler(obj, handler);
						num4++;
						num = (short)327024646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (obj3 != null)
						{
							num = (short)841154564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
					{
						num = (short)1131937793;
						if (num != 0)
						{
						}
						global::System.Reflection.FieldInfo field = notfyObjType.GetField(name, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
						if (field == null)
						{
							num = (short)377683968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						obj2 = field.GetValue(obj);
						goto IL_268;
					}
					case 10:
					{
						global::System.Delegate @delegate;
						if (@delegate != null)
						{
							num = (short)89325573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 11:
						goto IL_241;
					}
					goto IL_5E;
					IL_170:
					num = (short)375652359;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_268:
					obj3 = obj2;
					num = (short)375390216;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A8:
				return;
				IL_241:
				if (@event != null)
				{
					goto IL_24A;
				}
				return;
				IL_5E:
				@event = notfyObjType.GetEvent(name);
				num = (short)463537299;
				short num5 = num;
				num = (short)1503659155;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_24A:
					num = (short)343343105;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				default:
					num = (short)911933440;
					if (num != 0)
					{
					}
					num = (short)1514536969;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				break;
			}
			}
		}
	}
}
