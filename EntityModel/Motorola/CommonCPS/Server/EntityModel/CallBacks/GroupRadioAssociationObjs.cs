using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel.CallBacks
{
	// Token: 0x02000203 RID: 515
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class GroupRadioAssociationObjs
	{
		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x00110118 File Offset: 0x0010E318
		// (set) Token: 0x06001936 RID: 6454 RVA: 0x001101C8 File Offset: 0x0010E3C8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? GroupFromUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1270655599;
				short num2 = num;
				num = (short)718580335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)944177152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)763494401;
				if (num != 0)
				{
				}
				num = (short)1860239360;
				if (num != 0)
				{
				}
				return this.<GroupFromUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1471065685;
				short num2 = num;
				num = (short)2049945173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)346161152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1802371073;
				if (num != 0)
				{
				}
				num = (short)1594687488;
				if (num != 0)
				{
				}
				this.<GroupFromUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06001937 RID: 6455 RVA: 0x00110278 File Offset: 0x0010E478
		// (set) Token: 0x06001938 RID: 6456 RVA: 0x00110324 File Offset: 0x0010E524
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? GroupToUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1306883831;
				short num2 = num;
				num = (short)154498807;
				switch (num2 == num)
				{
				default:
				{
					num = (short)583794688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)308805633;
				if (num != 0)
				{
				}
				num = (short)109903872;
				if (num != 0)
				{
				}
				return this.<GroupToUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)117559636;
				short num2 = num;
				num = (short)1203032404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)312082432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1539047425;
				if (num != 0)
				{
				}
				num = (short)789577728;
				if (num != 0)
				{
				}
				this.<GroupToUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x001103D4 File Offset: 0x0010E5D4
		// (set) Token: 0x0600193A RID: 6458 RVA: 0x00110480 File Offset: 0x0010E680
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid DeviceUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)400014429;
				short num2 = num;
				num = (short)943373405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1487077376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)508887040;
				if (num != 0)
				{
				}
				num = (short)1628962817;
				if (num != 0)
				{
				}
				return this.<DeviceUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1648061300;
				short num2 = num;
				num = (short)1868458868;
				switch (num2 == num)
				{
				default:
				{
					num = (short)276037632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)723255296;
				if (num != 0)
				{
				}
				num = (short)195362817;
				if (num != 0)
				{
				}
				this.<DeviceUuid>k__BackingField = value;
			}
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00110544 File Offset: 0x0010E744
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(111655967 + A_1) + (global::System.IntPtr)60 + (global::System.IntPtr)66 + (global::System.IntPtr)67 + (global::System.IntPtr)24 + (global::System.IntPtr)5);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}
	}
}
