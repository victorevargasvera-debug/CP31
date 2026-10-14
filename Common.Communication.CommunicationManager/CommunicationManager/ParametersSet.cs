using System;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200002F RID: 47
	public sealed class ParametersSet : global::System.IEquatable<global::Motorola.Common.Communication.CommunicationManager.ParametersSet>
	{
		// Token: 0x06000107 RID: 263 RVA: 0x00015BB4 File Offset: 0x00013DB4
		public ParametersSet(global::Motorola.Common.Communication.CommonUtil.ConnectionType connectionType, global::Motorola.Common.Communication.CommonUtil.ProductFamily family, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.CommonUtil.RadioStorage storage)
		{
			this.a = connectionType;
			this.b = family;
			this.c = operation;
			this.d = storage;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00015BE4 File Offset: 0x00013DE4
		public global::Motorola.Common.Communication.CommonUtil.ConnectionType ConnectionType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)729437636;
				short num2 = num;
				num = (short)1865766340;
				switch (num2 == num)
				{
				}
				num = (short)1582235649;
				if (num != 0)
				{
				}
				num = (short)426835968;
				short num3 = num;
				num = (short)62193664;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00015C94 File Offset: 0x00013E94
		public global::Motorola.Common.Communication.CommonUtil.ProductFamily Family
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1791565259;
				short num2 = num;
				num = (short)2134318539;
				switch (num2 == num)
				{
				}
				num = (short)1241907201;
				if (num != 0)
				{
				}
				num = (short)982122496;
				short num3 = num;
				num = (short)251723776;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00015D44 File Offset: 0x00013F44
		public global::Motorola.Common.Communication.CommonUtil.RadioOperation Operation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1058248678;
				short num2 = num;
				num = (short)1998034918;
				switch (num2 == num)
				{
				}
				num = (short)2051538945;
				if (num != 0)
				{
				}
				num = (short)406323200;
				short num3 = num;
				num = (short)670105600;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00015DF4 File Offset: 0x00013FF4
		public global::Motorola.Common.Communication.CommonUtil.RadioStorage Storage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2020550106;
				short num2 = num;
				num = (short)1427383770;
				switch (num2 == num)
				{
				}
				num = (short)974061569;
				if (num != 0)
				{
				}
				num = (short)1733820416;
				short num3 = num;
				num = (short)797900800;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00015EA4 File Offset: 0x000140A4
		public bool Supports(global::Motorola.Common.Communication.CommonUtil.ConnectionType connectionType, global::Motorola.Common.Communication.CommonUtil.ProductFamily family, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.CommonUtil.RadioStorage storage)
		{
			short num = (short)794099714;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)474284033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.Family.HasFlag(family))
					{
						goto IL_172;
					}
					goto IL_18E;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
					num = (short)1525481477;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_141;
				case 5:
					if (this.Operation.HasFlag(operation))
					{
						num = (short)1066008580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18E;
				}
				IL_3D:
				num = (short)10737759;
				short num3 = num;
				num = (short)2074925151;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_172:
					num = (short)327024643;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)359137281;
					if (num != 0)
					{
					}
					num = (short)226164736;
					if (num != 0)
					{
					}
					if (!this.ConnectionType.HasFlag(connectionType))
					{
						goto IL_18E;
					}
					num = (short)306053120;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_141:
			return this.Storage.HasFlag(storage);
			IL_18E:
			num = (short)985399296;
			short num4 = num;
			return false;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0001606C File Offset: 0x0001426C
		public bool Equals(global::Motorola.Common.Communication.CommunicationManager.ParametersSet other)
		{
			short num = (short)638517254;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1122923686;
					short num3 = num;
					num = (short)1599698086;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6B;
					default:
						goto IL_197;
					}
					break;
				}
				case 1:
					goto IL_214;
				case 2:
					if (this.Operation == other.Operation)
					{
						num = (short)580911105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					goto IL_125;
				case 4:
					if (this == other)
					{
						num = (short)1297285123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2093219847;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (this.Family == other.Family)
					{
						num = (short)384958473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 7:
					if (this.ConnectionType == other.ConnectionType)
					{
						num = (short)336396296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 8:
					goto IL_6B;
				case 9:
					num = (short)1333067778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4C:
				if (other == null)
				{
					num = (short)774176768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)451411972;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6B:
				num = (short)23724037;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_125:
			num = (short)791019521;
			if (num != 0)
			{
			}
			return true;
			IL_197:
			num = (short)1644167168;
			if (num != 0)
			{
			}
			num = (short)1742405632;
			short num4 = num;
			return false;
			IL_214:
			return this.Storage == other.Storage;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00016298 File Offset: 0x00014498
		public override bool Equals(object obj)
		{
			short num = (short)878379010;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					num = (short)1348141057;
					if (num != 0)
					{
					}
					if (this == obj)
					{
						num = (short)697565187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1214447621;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
					return true;
				case 4:
					goto IL_DD;
				case 5:
				{
					if (!(obj is global::Motorola.Common.Communication.CommunicationManager.ParametersSet))
					{
						return false;
					}
					num = (short)1657787964;
					short num3 = num;
					num = (short)1056691772;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_119;
					default:
						num = (short)1370357760;
						if (num != 0)
						{
						}
						num = (short)1720516612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_3D:
				if (obj == null)
				{
					num = (short)741801984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_119:
				num = (short)860291073;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_DD:
			num = (short)722272256;
			short num4 = num;
			return this.Equals((global::Motorola.Common.Communication.CommunicationManager.ParametersSet)obj);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00016424 File Offset: 0x00014624
		public override int GetHashCode()
		{
			short num = (short)35305552;
			short num2 = num;
			num = (short)1602730064;
			switch (num2 == num)
			{
			}
			num = (short)1613692929;
			if (num != 0)
			{
			}
			num = (short)901840896;
			short num3 = num;
			num = (short)1666383872;
			if (num != 0)
			{
			}
			return (int)(((this.ConnectionType * (global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM | global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter | global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork | global::Motorola.Common.Communication.CommonUtil.ConnectionType.Fudally | global::Motorola.Common.Communication.CommonUtil.ConnectionType.Provisioning) ^ (global::Motorola.Common.Communication.CommonUtil.ConnectionType)this.Family) * (global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM | global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter | global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork | global::Motorola.Common.Communication.CommonUtil.ConnectionType.Fudally | global::Motorola.Common.Communication.CommonUtil.ConnectionType.Provisioning) ^ (global::Motorola.Common.Communication.CommonUtil.ConnectionType)this.Operation.GetHashCode()) * (global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM | global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter | global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork | global::Motorola.Common.Communication.CommonUtil.ConnectionType.Fudally | global::Motorola.Common.Communication.CommonUtil.ConnectionType.Provisioning) ^ (global::Motorola.Common.Communication.CommonUtil.ConnectionType)this.Storage);
		}

		// Token: 0x0400003B RID: 59
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.Common.Communication.CommonUtil.ConnectionType a;

		// Token: 0x0400003C RID: 60
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.Common.Communication.CommonUtil.ProductFamily b;

		// Token: 0x0400003D RID: 61
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.Common.Communication.CommonUtil.RadioOperation c;

		// Token: 0x0400003E RID: 62
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.Common.Communication.CommonUtil.RadioStorage d;
	}
}
