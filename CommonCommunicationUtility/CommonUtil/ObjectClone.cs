using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000044 RID: 68
	public static class ObjectClone
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		public static object Clone(object ob)
		{
			short num;
			for (;;)
			{
				num = (short)940244992;
				switch (num)
				{
				default:
				{
					num = (short)843239286;
					short num2 = num;
					num = (short)1347473270;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_54;
					}
					break;
				}
				}
			}
			IL_54:
			num = (short)726401025;
			if (num != 0)
			{
			}
			num = (short)411107328;
			short num3 = num;
			num = (short)2018443264;
			if (num != 0)
			{
			}
			global::System.Runtime.Serialization.IFormatter formatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			global::System.IO.Stream stream = null;
			object result = null;
			try
			{
				stream = new global::System.IO.MemoryStream();
				stream.Position = 0L;
				formatter.Serialize(stream, ob);
				stream.Position = 0L;
				result = formatter.Deserialize(stream);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Error in ObjectClone. {0}", new object[]
				{
					ex.Message
				});
			}
			finally
			{
				num = (short)303759361;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						stream.Close();
						num = (short)1131675650;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_145;
						}
						continue;
					case 2:
						goto IL_17B;
					}
					IL_145:
					if (stream == null)
					{
						break;
					}
					num = (short)429654016;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_17B:;
			}
			return result;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000AF78 File Offset: 0x00009178
		public static global::Motorola.Common.Communication.CommonUtil.DeviceInfo Copy(this global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			short num = (short)1211039744;
			short num2 = num;
			num = (short)1885077505;
			if (num != 0)
			{
			}
			num = (short)472790342;
			short num3 = num;
			num = (short)1978414406;
			switch (num3 == num)
			{
			}
			num = (short)1641742336;
			if (num != 0)
			{
			}
			return (global::Motorola.Common.Communication.CommonUtil.DeviceInfo)global::Motorola.Common.Communication.CommonUtil.ObjectClone.Clone(devInfo);
		}
	}
}
