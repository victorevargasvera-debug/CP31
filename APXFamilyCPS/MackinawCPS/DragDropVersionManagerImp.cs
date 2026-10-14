using System;
using System.Globalization;
using System.Reflection;
using System.Threading;
using AcpCommonLib;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x02000033 RID: 51
	public class DragDropVersionManagerImp : global::AcpCommonLib.DragDropVersionManager
	{
		// Token: 0x0600012E RID: 302 RVA: 0x0003AF64 File Offset: 0x00039164
		internal DragDropVersionManagerImp()
		{
			try
			{
				global::System.Reflection.AssemblyName name = global::System.Reflection.Assembly.GetExecutingAssembly().GetName();
				this.version = name.Version.Major;
			}
			catch (global::System.Exception)
			{
				this.version = -1;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0003AFC4 File Offset: 0x000391C4
		public override global::System.Globalization.CultureInfo GetApplicationLanguage()
		{
			short num = (short)303946371;
			short num2 = num;
			num = (short)191683203;
			switch (num2 == num)
			{
			}
			num = (short)1426587649;
			if (num != 0)
			{
			}
			num = (short)1111621632;
			short num3 = num;
			num = (short)1491206144;
			if (num != 0)
			{
			}
			return this.ci;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0003B078 File Offset: 0x00039278
		public override object GetVersionObj()
		{
			short num = (short)1556897368;
			short num2 = num;
			num = (short)1296784984;
			switch (num2 == num)
			{
			}
			num = (short)341377024;
			if (num != 0)
			{
			}
			num = (short)202899456;
			short num3 = num;
			num = (short)43778049;
			if (num != 0)
			{
			}
			return this.version;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0003B12C File Offset: 0x0003932C
		public override bool IsDropAllowedByApp(object producerObj, object consumerObj)
		{
			switch (0)
			{
			case 0:
				goto IL_73;
			}
			short num;
			int num3;
			int num4;
			int num5;
			for (;;)
			{
				IL_0A:
				num = (short)1652600098;
				short num2 = num;
				num = (short)563522850;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)833683456;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_DD;
					case 1:
						if (num4 < 0)
						{
							num = (short)726335493;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)458031106;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (num5 <= num4)
						{
							num = (short)1543045123;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						return true;
					case 4:
						if (num5 >= 0)
						{
							num = (short)1008336896;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						goto IL_149;
					}
					goto IL_73;
				}
				IL_DD:
				num = (short)400752641;
				num3 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_149:
			num = (short)1037172737;
			if (num != 0)
			{
			}
			return false;
			IL_73:
			num = (short)2103640064;
			short num6 = num;
			num5 = (int)producerObj;
			num4 = (int)consumerObj;
			num = (short)888602628;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0003B2B0 File Offset: 0x000394B0
		public override bool IsDropAllowedByLocalApp(object producerObj, object consumerObj)
		{
			int a_ = 4;
			short num = (short)310181890;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.ci.TwoLetterISOLanguageName != global::PreEmptive.SoS.Runtime.FixedLengthStream.b("臣裥", a_))
					{
						num = (short)456458243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
				{
					num = (short)63242240;
					short num3 = num;
					num = (short)1118044161;
					if (num != 0)
					{
					}
					num = (short)736690176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
					goto IL_15A;
				}
				IL_3D:
				num = (short)693303940;
				short num4 = num;
				num = (short)1839594116;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
				{
					num = (short)1535836160;
					if (num != 0)
					{
					}
					int num5 = (int)producerObj;
					int num6 = (int)consumerObj;
					if (num5 >= global::AcpCommonLib.AppInfoManager.LOCALIZED_VERSION_NUMBER)
					{
						return true;
					}
					num = (short)589825;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			return false;
			IL_15A:
			return false;
		}

		// Token: 0x040000C6 RID: 198
		private int version;

		// Token: 0x040000C7 RID: 199
		private global::System.Globalization.CultureInfo ci = global::System.Threading.Thread.CurrentThread.CurrentUICulture;

		// Token: 0x040000C8 RID: 200
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
