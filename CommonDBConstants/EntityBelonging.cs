using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000010 RID: 16
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class EntityBelonging : global::System.Attribute
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002690 File Offset: 0x00000890
		// (set) Token: 0x06000010 RID: 16 RVA: 0x0000273C File Offset: 0x0000093C
		public global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType EntityType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1018119057;
				short num2 = num;
				num = (short)257508241;
				switch (num2 == num)
				{
				}
				num = (short)840105984;
				if (num != 0)
				{
				}
				num = (short)1013448704;
				short num3 = num;
				num = (short)1147076609;
				if (num != 0)
				{
				}
				return this.<EntityType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)268533360;
				short num2 = num;
				num = (short)2039512688;
				switch (num2 == num)
				{
				}
				num = (short)1617756161;
				if (num != 0)
				{
				}
				num = (short)245563392;
				short num3 = num;
				num = (short)20774912;
				if (num != 0)
				{
				}
				this.<EntityType>k__BackingField = value;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000027EC File Offset: 0x000009EC
		public EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType entityType)
		{
			this.EntityType = entityType;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002808 File Offset: 0x00000A08
		public static global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType? GetEntityType(object enumVariable)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::System.Reflection.MemberInfo[] member;
			short num2;
			global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging[] array;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_132;
				case 1:
					if (member.Length != 0)
					{
						num2 = (short)1124204546;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_137;
				case 2:
					goto IL_62;
				case 3:
				{
					num2 = (short)1649120188;
					short num3 = num2;
					num2 = (short)1545704380;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_62;
					default:
						num2 = (short)1085407233;
						if (num2 != 0)
						{
						}
						num2 = (short)1532428288;
						if (num2 != 0)
						{
						}
						if (array.Length != 0)
						{
							num2 = (short)1046413312;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_137;
					}
					break;
				}
				}
				goto IL_20;
				IL_62:
				array = (global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging[])member[0].GetCustomAttributes(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging), false);
				num2 = (short)1374683139;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_132:
			return new global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType?(array[0].EntityType);
			IL_137:
			num2 = (short)425263104;
			short num4 = num2;
			return null;
			IL_20:
			member = enumVariable.GetType().GetMember(enumVariable.ToString());
			num2 = (short)1953562625;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002980 File Offset: 0x00000B80
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType> GetPropertyNamesByEntityType(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType entityType)
		{
			short num = (short)662733210;
			short num2 = num;
			num = (short)2089124250;
			switch (num2 == num)
			{
			}
			num = (short)580321280;
			if (num != 0)
			{
			}
			num = (short)688324608;
			short num3 = num;
			num = (short)106102785;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging.a a = new global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging.a();
			a.a = entityType;
			return (global::System.Enum.GetValues(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType)) as global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType[]).Where(new global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, bool>(a.b)).ToList<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType>();
		}

		// Token: 0x02000011 RID: 17
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000015 RID: 21 RVA: 0x00002A74 File Offset: 0x00000C74
			internal bool b(global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType A_0)
			{
				short num = (short)598011455;
				short num2 = num;
				num = (short)1438838335;
				switch (num2 == num)
				{
				}
				num = (short)1212416000;
				if (num != 0)
				{
				}
				num = (short)1955397632;
				short num3 = num;
				num = (short)1253310465;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType? entityType = global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging.GetEntityType(A_0);
				global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType entityType2 = this.a;
				return entityType.GetValueOrDefault() == entityType2 & entityType != null;
			}

			// Token: 0x0400009C RID: 156
			public global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType a;
		}
	}
}
