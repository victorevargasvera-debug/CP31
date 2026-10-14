using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel
{
	// Token: 0x020001C3 RID: 451
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ASTRO_OptionIDDefinition))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ASTRO_OptionIDDefinition))]
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.PCR_OptionIDDefinition))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.PCR_OptionIDDefinition))]
	[global::System.Serializable]
	public abstract class OptionIDDefinition : global::System.IEquatable<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition>
	{
		// Token: 0x06001729 RID: 5929 RVA: 0x000FAB08 File Offset: 0x000F8D08
		public OptionIDDefinition()
		{
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x0600172A RID: 5930
		[global::System.Xml.Serialization.XmlIgnore]
		public abstract string ResourceID { get; }

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x0600172B RID: 5931
		[global::System.Xml.Serialization.XmlIgnore]
		public abstract int OptionInt { get; }

		// Token: 0x0600172C RID: 5932 RVA: 0x000FAB1C File Offset: 0x000F8D1C
		public bool Equals(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition other)
		{
			short num = (short)1401880579;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.OptionInt == other.OptionInt)
					{
						num = (short)615841794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					num = (short)684457984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_11B;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				if (!(base.GetType() == other.GetType()))
				{
					goto IL_11D;
				}
				num = (short)1867612013;
				short num3 = num;
				num = (short)306282349;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				case 1:
					break;
				default:
				{
					num = (short)1290076160;
					short num4 = num;
					break;
				}
				}
				num = (short)21168128;
				if (num != 0)
				{
				}
				num = (short)342425601;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_11B:
			return true;
			IL_11D:
			num = (short)1165950977;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x000FAC70 File Offset: 0x000F8E70
		public override bool Equals(object obj)
		{
			short num = (short)2078539779;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition optionIDDefinition;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (optionIDDefinition == null)
					{
						num = (short)835977218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12F;
				case 1:
					goto IL_C4;
				case 2:
					return false;
				case 3:
				{
					num = (short)1785365852;
					short num3 = num;
					num = (short)1766491484;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F0;
					default:
						num = (short)702087169;
						if (num != 0)
						{
						}
						num = (short)1668677632;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					}
					break;
				}
				}
				IL_AC:
				if (obj == null)
				{
					num = (short)1170472961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F0:
				optionIDDefinition = (obj as global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition);
				num = (short)56819712;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C4:
			num = (short)327090176;
			short num4 = num;
			return false;
			IL_12F:
			return this.Equals(optionIDDefinition);
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x000FADB4 File Offset: 0x000F8FB4
		public override int GetHashCode()
		{
			short num = (short)2089844387;
			short num2 = num;
			num = (short)338919075;
			switch (num2 == num)
			{
			}
			num = (short)242089984;
			short num3 = num;
			num = (short)501022721;
			if (num != 0)
			{
			}
			num = (short)1939996672;
			if (num != 0)
			{
			}
			return this.OptionInt.GetHashCode();
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x000FAE6C File Offset: 0x000F906C
		public static bool operator ==(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition a, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition b)
		{
			short num = (short)146210818;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)564068353;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (a != null)
					{
						num = (short)1291649028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					return false;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 3:
					if (b == null)
					{
						num = (short)1095696385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_166;
				case 4:
					num = (short)1724907523;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1950478810;
					short num3 = num;
					num = (short)1270280666;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_B4;
					}
					break;
				}
				}
				IL_64:
				if (a == b)
				{
					num = (short)1218248709;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1368981504;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_B4:
			num = (short)152698880;
			if (num != 0)
			{
			}
			num = (short)885915648;
			short num4 = num;
			return true;
			IL_166:
			return a.Equals(b);
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x000FAFE8 File Offset: 0x000F91E8
		public static bool operator !=(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition a, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition b)
		{
			short num = (short)1891699452;
			short num2 = num;
			num = (short)1604061948;
			switch (num2 == num)
			{
			}
			num = (short)1725104128;
			short num3 = num;
			num = (short)1012596737;
			if (num != 0)
			{
			}
			num = (short)429457408;
			if (num != 0)
			{
			}
			return !(a == b);
		}
	}
}
