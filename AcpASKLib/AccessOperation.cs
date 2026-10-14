using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;

namespace AcpASKLib
{
	// Token: 0x0200000F RID: 15
	[global::System.Xml.Serialization.XmlType("Operation")]
	[global::System.Serializable]
	public class AccessOperation : global::AcpASKLib.AccessElement, global::AcpASKLib.IOperationAccessLevel, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00006EC4 File Offset: 0x000050C4
		public AccessOperation()
		{
			this.bValue = false;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00006EE0 File Offset: 0x000050E0
		public AccessOperation(string strName, string strUiName, int id, global::AcpASKLib.AccessElementIDType elemId, bool value) : base(strName, strUiName, id, elemId)
		{
			this.bValue = value;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00006F00 File Offset: 0x00005100
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00006FB0 File Offset: 0x000051B0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool AccessLevel
		{
			get
			{
				short num = (short)47579136;
				short num2 = num;
				num = (short)1102722851;
				short num3 = num;
				num = (short)805779235;
				switch (num3 == num)
				{
				}
				num = (short)162725889;
				if (num != 0)
				{
				}
				num = (short)1748107264;
				if (num != 0)
				{
				}
				return this.bValue;
			}
			set
			{
				int a_ = 14;
				short num = (short)1132068864;
				short num2 = num;
				num = (short)1993803078;
				short num3 = num;
				num = (short)1865614662;
				switch (num3 == num)
				{
				}
				num = (short)211812353;
				if (num != 0)
				{
				}
				num = (short)1682833408;
				if (num != 0)
				{
				}
				this.bValue = value;
				this.a(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⩪๬౮ᑰrٴ㭶ᱸൺ᡼፾", a_));
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600004A RID: 74 RVA: 0x0000707C File Offset: 0x0000527C
		// (remove) Token: 0x0600004B RID: 75 RVA: 0x000071B4 File Offset: 0x000053B4
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
				short num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						num2 = (short)1762590721;
						if (num2 != 0)
						{
						}
						goto IL_62;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1543503872;
							short num3 = num2;
							num2 = (short)925958146;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_62;
					case 2:
					{
						num2 = (short)40924120;
						short num4 = num2;
						num2 = (short)1775596504;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7F;
						default:
							goto IL_111;
						}
						break;
					}
					}
					goto IL_1C;
					IL_7F:
					num2 = (short)1061093377;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_62:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					goto IL_7F;
				}
				IL_111:
				num2 = (short)871170048;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)162529280;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)375390209;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				int num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_30:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num2)
					{
					case 0:
						goto IL_60;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num = (short)1016659968;
							short num3 = num;
							num = (short)554565634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_60;
					case 2:
					{
						num = (short)1936928124;
						short num4 = num;
						num = (short)1996828028;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7D;
						default:
							goto IL_10D;
						}
						break;
					}
					}
					goto IL_42;
					IL_7D:
					num = (short)1647640577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_60:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					goto IL_7D;
				}
				IL_10D:
				num = (short)442105856;
				if (num != 0)
				{
				}
				return;
				IL_42:
				propertyChangedEventHandler = this.PropertyChanged;
				num = (short)575668224;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000072E8 File Offset: 0x000054E8
		private void a(string A_0)
		{
			short num = (short)420282368;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
				{
					num = (short)810699220;
					short num3 = num;
					num = (short)463358420;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)1132331008;
						if (num != 0)
						{
						}
						num = (short)581959680;
						short num4 = num;
						this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(A_0));
						num = (short)1736048642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					goto IL_F0;
				}
				IL_30:
				if (this.PropertyChanged == null)
				{
					return;
				}
				num = (short)2032861185;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F0:
			num = (short)1224278017;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000DD RID: 221
		private bool bValue;
	}
}
