using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;
using ASK.Interface;

namespace ASK.Core
{
	// Token: 0x0200000E RID: 14
	[global::System.Xml.Serialization.XmlType("RangeField")]
	[global::System.Serializable]
	public class AccessRangeField : global::ASK.Core.AccessField, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000070E8 File Offset: 0x000052E8
		public AccessRangeField()
		{
			this.m_Ranges = new global::ASK.Core.FieldValueRangeRecSet(0);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00007108 File Offset: 0x00005308
		public AccessRangeField(string name, string uiName, int id, global::ASK.Interface.AccessElementIDType elemId, global::ASK.Interface.AccessLevelType value) : base(name, uiName, id, elemId, value)
		{
			this.m_Ranges = new global::ASK.Core.FieldValueRangeRecSet((ushort)id);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00007130 File Offset: 0x00005330
		public AccessRangeField(string name, string uiName, int id, string mapId, global::ASK.Interface.AccessElementIDType elemId, global::ASK.Interface.AccessLevelType value) : base(name, uiName, id, mapId, elemId, value)
		{
			this.m_Ranges = new global::ASK.Core.FieldValueRangeRecSet((ushort)id);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000715C File Offset: 0x0000535C
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000720C File Offset: 0x0000540C
		[global::System.Xml.Serialization.XmlIgnore]
		public global::ASK.Core.FieldValueRangeRecSet Ranges
		{
			get
			{
				short num = (short)976217618;
				short num2 = num;
				num = (short)29812242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)96337920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1333592064;
				if (num != 0)
				{
				}
				num = (short)975831041;
				if (num != 0)
				{
				}
				return this.m_Ranges;
			}
			set
			{
				int a_ = 15;
				short num = (short)1916207105;
				if (num != 0)
				{
				}
				num = (short)2047934464;
				short num2 = num;
				num = (short)470710986;
				short num3 = num;
				num = (short)1415805642;
				switch (num3 == num)
				{
				}
				num = (short)178257920;
				if (num != 0)
				{
				}
				this.m_Ranges = value;
				this.a(global::ASK.Core.StatusMsg.b("᥊ⱌⅎ㙐㙒♔", a_));
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000054 RID: 84 RVA: 0x000072D8 File Offset: 0x000054D8
		// (remove) Token: 0x06000055 RID: 85 RVA: 0x00007410 File Offset: 0x00005610
		public new event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1637744640;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_61;
					}
					case 2:
						goto IL_61;
					}
					goto IL_1C;
					IL_61:
					num2 = (short)1621245014;
					short num3 = num2;
					num2 = (short)1690909782;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1288503297;
						if (num2 != 0)
						{
						}
						num2 = (short)1199833088;
						if (num2 != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
						num2 = (short)1704198145;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				num2 = (short)1659568128;
				short num4 = num2;
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)218300418;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						num2 = (short)71303169;
						if (num2 != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1052442624;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_63;
					}
					case 2:
						goto IL_63;
					}
					goto IL_1C;
					IL_63:
					num2 = (short)1454785664;
					short num3 = num2;
					num2 = (short)1837122688;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1115553792;
						if (num2 != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
						num2 = (short)1446838273;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				num2 = (short)1379467264;
				short num4 = num2;
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)1178861570;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000754C File Offset: 0x0000574C
		private void a(string A_0)
		{
			short num = (short)1460469762;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(A_0));
					num = (short)1443168256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_14;
				}
				goto IL_59;
				IL_14:
				num = (short)53608449;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
				{
					IL_59:
					if (this.PropertyChanged == null)
					{
						return;
					}
					num = (short)723348730;
					short num3 = num;
					num = (short)1900965114;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
					{
						num = (short)1977286656;
						short num4 = num;
						num = (short)274595840;
						if (num != 0)
						{
						}
						num = (short)811794433;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
					break;
				}
				}
			}
		}

		// Token: 0x04000022 RID: 34
		private global::ASK.Core.FieldValueRangeRecSet m_Ranges;
	}
}
