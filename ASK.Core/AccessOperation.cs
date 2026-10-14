using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;
using ASK.Interface;

namespace ASK.Core
{
	// Token: 0x0200000C RID: 12
	[global::System.Xml.Serialization.XmlType("Operation")]
	[global::System.Serializable]
	public class AccessOperation : global::ASK.Core.AccessElement, global::ASK.Core.IOperationAccessLevel, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00006B90 File Offset: 0x00004D90
		public AccessOperation()
		{
			this.bValue = false;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00006BAC File Offset: 0x00004DAC
		public AccessOperation(string strName, string strUiName, int id, global::ASK.Interface.AccessElementIDType elemId, bool value) : base(strName, strUiName, id, elemId)
		{
			this.bValue = value;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00006BCC File Offset: 0x00004DCC
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00006C7C File Offset: 0x00004E7C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool AccessLevel
		{
			get
			{
				short num = (short)1350118188;
				short num2 = num;
				num = (short)344009516;
				switch (num2 == num)
				{
				default:
				{
					num = (short)228196352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)625082369;
				if (num != 0)
				{
				}
				num = (short)1653473280;
				if (num != 0)
				{
				}
				return this.bValue;
			}
			set
			{
				int a_ = 9;
				short num = (short)1838707012;
				short num2 = num;
				num = (short)1006793028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)620691456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1377828865;
				if (num != 0)
				{
				}
				num = (short)1585643520;
				if (num != 0)
				{
				}
				this.bValue = value;
				this.a(global::ASK.Core.StatusMsg.b("ф⑆⩈⹊㹌㱎ᵐ㙒⍔㉖㕘", a_));
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600004A RID: 74 RVA: 0x00006D48 File Offset: 0x00004F48
		// (remove) Token: 0x0600004B RID: 75 RVA: 0x00006E84 File Offset: 0x00005084
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
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
							num2 = (short)895549440;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_89;
					}
					case 2:
						num2 = (short)1197670401;
						if (num2 != 0)
						{
						}
						goto IL_89;
					}
					goto IL_1C;
					IL_89:
					num2 = (short)112521873;
					short num3 = num2;
					num2 = (short)137032337;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1607860224;
						if (num2 != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
						num2 = (short)1382350849;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				num2 = (short)105578496;
				short num4 = num2;
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)1457586178;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)20709377;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_31:
					num = (short)1420820480;
					short num2 = num;
					switch (num3)
					{
					case 0:
						return;
					case 1:
					{
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num = (short)1045495808;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D;
					}
					case 2:
						goto IL_8D;
					}
					goto IL_6E;
					IL_8D:
					num = (short)541000746;
					short num4 = num;
					num = (short)1093862442;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)310116352;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
						num = (short)4587521;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_6E:
				propertyChangedEventHandler = this.PropertyChanged;
				num = (short)1388904450;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006FBC File Offset: 0x000051BC
		private void a(string A_0)
		{
			short num = (short)1789984770;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F2;
				case 1:
					this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(A_0));
					num = (short)229310464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_15;
				}
				goto IL_31;
				IL_15:
				switch (0)
				{
				case 0:
				{
					IL_31:
					if (this.PropertyChanged == null)
					{
						return;
					}
					num = (short)268852156;
					short num3 = num;
					num = (short)1802722236;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
					{
						num = (short)65339392;
						if (num != 0)
						{
						}
						num = (short)1433272320;
						short num4 = num;
						num = (short)891551745;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
					break;
				}
				}
			}
			IL_F2:
			num = (short)568983553;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000020 RID: 32
		private bool bValue;
	}
}
