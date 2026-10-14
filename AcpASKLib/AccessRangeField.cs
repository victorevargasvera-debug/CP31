using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;

namespace AcpASKLib
{
	// Token: 0x02000011 RID: 17
	[global::System.Xml.Serialization.XmlType("RangeField")]
	[global::System.Serializable]
	public class AccessRangeField : global::AcpASKLib.AccessField, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x0600004F RID: 79 RVA: 0x00007410 File Offset: 0x00005610
		public AccessRangeField()
		{
			this.m_Ranges = new global::AcpASKLib.FieldValueRangeRecSet(0);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00007430 File Offset: 0x00005630
		public AccessRangeField(string name, string uiName, int id, global::AcpASKLib.AccessElementIDType elemId, global::AcpASKLib.AccessLevelType value) : base(name, uiName, id, elemId, value)
		{
			this.m_Ranges = new global::AcpASKLib.FieldValueRangeRecSet((ushort)id);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00007458 File Offset: 0x00005658
		public AccessRangeField(string name, string uiName, int id, string mapId, global::AcpASKLib.AccessElementIDType elemId, global::AcpASKLib.AccessLevelType value) : base(name, uiName, id, mapId, elemId, value)
		{
			this.m_Ranges = new global::AcpASKLib.FieldValueRangeRecSet((ushort)id);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00007484 File Offset: 0x00005684
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00007534 File Offset: 0x00005734
		[global::System.Xml.Serialization.XmlIgnore]
		public global::AcpASKLib.FieldValueRangeRecSet Ranges
		{
			get
			{
				short num = (short)1248067584;
				short num2 = num;
				num = (short)410226771;
				short num3 = num;
				num = (short)1306431571;
				switch (num3 == num)
				{
				}
				num = (short)953024512;
				if (num != 0)
				{
				}
				num = (short)389480449;
				if (num != 0)
				{
				}
				return this.m_Ranges;
			}
			set
			{
				int a_ = 15;
				short num = (short)185401344;
				short num2 = num;
				num = (short)916062209;
				if (num != 0)
				{
				}
				num = (short)2104144391;
				short num3 = num;
				num = (short)888910343;
				switch (num3 == num)
				{
				}
				num = (short)1037500416;
				if (num != 0)
				{
				}
				this.m_Ranges = value;
				this.a(global::AcpASKLib.SystemKeyLoadedEventArgs.b("㹫཭ṯᕱᅳյ", a_));
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000054 RID: 84 RVA: 0x00007604 File Offset: 0x00005804
		// (remove) Token: 0x06000055 RID: 85 RVA: 0x00007738 File Offset: 0x00005938
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
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_3B;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)541327361;
							if (num2 != 0)
							{
							}
							num2 = (short)650706944;
							short num3 = num2;
							num2 = (short)950796290;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3B;
					case 2:
					{
						num2 = (short)930139821;
						short num4 = num2;
						num2 = (short)391499437;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_58;
						default:
							goto IL_10E;
						}
						break;
					}
					}
					goto IL_1C;
					IL_58:
					num2 = (short)1458503681;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_3B:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					goto IL_58;
				}
				IL_10E:
				num2 = (short)2024210432;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)924516352;
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
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_3B;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1866268674;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3B;
					case 2:
					{
						num2 = (short)444727296;
						short num3 = num2;
						num2 = (short)257997942;
						short num4 = num2;
						num2 = (short)299482230;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_58;
						default:
							goto IL_E3;
						}
						break;
					}
					}
					goto IL_1C;
					IL_58:
					num2 = (short)135528449;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_3B:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					goto IL_58;
				}
				IL_E3:
				num2 = (short)311689217;
				if (num2 != 0)
				{
				}
				num2 = (short)384958464;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)252903424;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000786C File Offset: 0x00005A6C
		private void a(string A_0)
		{
			short num = (short)836632576;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)889192449;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 1:
				{
					num = (short)316589681;
					short num3 = num;
					num = (short)1703396977;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)276889600;
						short num4 = num;
						num = (short)1489829888;
						if (num != 0)
						{
						}
						this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(A_0));
						num = (short)954466306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					return;
				}
				IL_58:
				if (this.PropertyChanged == null)
				{
					break;
				}
				num = (short)2019098625;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x040000DF RID: 223
		private global::AcpASKLib.FieldValueRangeRecSet m_Ranges;
	}
}
