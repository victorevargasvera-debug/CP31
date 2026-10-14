using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using AcpBusinessLayer.UndoRedo;

namespace AcpBusinessLayer
{
	// Token: 0x0200003C RID: 60
	public static class SerializationInfoExtensions
	{
		// Token: 0x060004A1 RID: 1185 RVA: 0x00064620 File Offset: 0x00062820
		public static int? GetIntValueNoThrow(this global::System.Runtime.Serialization.SerializationInfo info, string name)
		{
			short num = (short)920051590;
			short num2 = num;
			num = (short)1859116934;
			switch (num2 == num)
			{
			}
			num = (short)195166208;
			short num3 = num;
			num = (short)1229062144;
			if (num != 0)
			{
			}
			num = (short)186384385;
			if (num != 0)
			{
			}
			return (int?)global::AcpBusinessLayer.SerializationInfoExtensions.d.Invoke(info, new object[]
			{
				name,
				global::AcpBusinessLayer.SerializationInfoExtensions.a
			});
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x000646E8 File Offset: 0x000628E8
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static string GetStringValueNoThrow(this global::System.Runtime.Serialization.SerializationInfo info, string name)
		{
			short num = (short)1788524419;
			short num2 = num;
			num = (short)87013251;
			switch (num2 == num)
			{
			}
			num = (short)2072313856;
			short num3 = num;
			num = (short)1302528001;
			if (num != 0)
			{
			}
			num = (short)66715648;
			if (num != 0)
			{
			}
			return (string)global::AcpBusinessLayer.SerializationInfoExtensions.d.Invoke(info, new object[]
			{
				name,
				global::AcpBusinessLayer.SerializationInfoExtensions.b
			});
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x000647B8 File Offset: 0x000629B8
		public static bool? GetBoolValueNoThrow(this global::System.Runtime.Serialization.SerializationInfo info, string name)
		{
			short num = (short)1333854209;
			if (num != 0)
			{
			}
			num = (short)1692481462;
			short num2 = num;
			num = (short)1019951030;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2027880448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1560281088;
			if (num != 0)
			{
			}
			return (bool?)global::AcpBusinessLayer.SerializationInfoExtensions.d.Invoke(info, new object[]
			{
				name,
				global::AcpBusinessLayer.SerializationInfoExtensions.c
			});
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00064880 File Offset: 0x00062A80
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationInfoExtensions()
		{
			int a_ = 4;
			short num = (short)1047259039;
			short num2 = num;
			num = (short)401598367;
			switch (num2 == num)
			{
			}
			num = (short)923664384;
			short num3 = num;
			num = (short)910098433;
			if (num != 0)
			{
			}
			num = (short)1438121984;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.SerializationInfoExtensions.a = typeof(int);
			global::AcpBusinessLayer.SerializationInfoExtensions.b = typeof(string);
			global::AcpBusinessLayer.SerializationInfoExtensions.c = typeof(bool);
			global::AcpBusinessLayer.SerializationInfoExtensions.d = typeof(global::System.Runtime.Serialization.SerializationInfo).GetMethod(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("釕뷗껙諛뿝賟韡臣꣥蟧뻩蓫鳭鿯藱", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
		}

		// Token: 0x0400013B RID: 315
		private static readonly global::System.Type a;

		// Token: 0x0400013C RID: 316
		private static readonly global::System.Type b;

		// Token: 0x0400013D RID: 317
		private static readonly global::System.Type c;

		// Token: 0x0400013E RID: 318
		private static readonly global::System.Reflection.MethodInfo d;
	}
}
