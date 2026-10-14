using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel
{
	// Token: 0x020001CB RID: 459
	public class NameAndValue
	{
		// Token: 0x06001765 RID: 5989 RVA: 0x000FD37C File Offset: 0x000FB57C
		private NameAndValue()
		{
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x000FD390 File Offset: 0x000FB590
		public NameAndValue(string Name, object value) : this(Name, value, false)
		{
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x000FD3A8 File Offset: 0x000FB5A8
		public NameAndValue(string Name, object value, bool valueShallLocalize)
		{
			this.Name = Name;
			this.Value = value;
			this.ValueShallLocalize = valueShallLocalize;
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x000FD3D0 File Offset: 0x000FB5D0
		// (set) Token: 0x06001769 RID: 5993 RVA: 0x000FD480 File Offset: 0x000FB680
		[global::System.Xml.Serialization.XmlAttribute]
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1263415432;
				short num2 = num;
				num = (short)839856264;
				switch (num2 == num)
				{
				default:
				{
					num = (short)934739968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2027618305;
				if (num != 0)
				{
				}
				num = (short)1140391936;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)74178643;
				short num2 = num;
				num = (short)1381097555;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1511653376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)330366976;
				if (num != 0)
				{
				}
				num = (short)1450049537;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x000FD530 File Offset: 0x000FB730
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x000FD5E0 File Offset: 0x000FB7E0
		public object Value
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)693329592;
				short num2 = num;
				num = (short)1984913080;
				switch (num2 == num)
				{
				default:
				{
					num = (short)781189120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1956970497;
				if (num != 0)
				{
				}
				num = (short)708837376;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1477651715;
				short num2 = num;
				num = (short)366554371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)540540928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)758382593;
				if (num != 0)
				{
				}
				num = (short)597032960;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x000FD690 File Offset: 0x000FB890
		// (set) Token: 0x0600176D RID: 5997 RVA: 0x000FD744 File Offset: 0x000FB944
		[global::System.Xml.Serialization.XmlAttribute]
		public bool ValueShallLocalize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)545307738;
				short num2 = num;
				num = (short)875740250;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1448083456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1556348929;
				if (num != 0)
				{
				}
				num = (short)588906496;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1628897281;
				if (num != 0)
				{
				}
				num = (short)813760512;
				short num2 = num;
				num = (short)1690953577;
				short num3 = num;
				num = (short)987817833;
				switch (num3 == num)
				{
				}
				num = (short)1479606272;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x04000AE6 RID: 2790
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x04000AE7 RID: 2791
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private object b;

		// Token: 0x04000AE8 RID: 2792
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c;
	}
}
