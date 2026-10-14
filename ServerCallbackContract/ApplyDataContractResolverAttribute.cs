using System;
using System.Data.Entity.Core.Objects;
using System.IO;
using System.Runtime.Serialization;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Motorola.CommonCPS.ServerCallbackContract
{
	// Token: 0x02000003 RID: 3
	public class ApplyDataContractResolverAttribute : global::System.Attribute, global::System.ServiceModel.Description.IOperationBehavior
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002130 File Offset: 0x00000330
		public void AddBindingParameters(global::System.ServiceModel.Description.OperationDescription description, global::System.ServiceModel.Channels.BindingParameterCollection parameters)
		{
			short num = (short)503420380;
			short num2 = num;
			num = (short)980719068;
			switch (num2 == num)
			{
			}
			num = (short)989069312;
			short num3 = num;
			num = (short)1621884929;
			if (num != 0)
			{
			}
			num = (short)508624896;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021D8 File Offset: 0x000003D8
		public void ApplyClientBehavior(global::System.ServiceModel.Description.OperationDescription description, global::System.ServiceModel.Dispatcher.ClientOperation proxy)
		{
			int num;
			short num2;
			global::System.ServiceModel.Description.DataContractSerializerOperationBehavior dataContractSerializerOperationBehavior;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)470286336;
						short num3 = num2;
						if (dataContractSerializerOperationBehavior != null)
						{
							num2 = (short)411631618;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_CE;
					}
					case 1:
						goto IL_CC;
					case 2:
						dataContractSerializerOperationBehavior.DataContractResolver = new global::System.Data.Entity.Core.Objects.ProxyDataContractResolver();
						num2 = (short)397541377;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_CC:
				IL_CE:
				num2 = (short)177073185;
				short num4 = num2;
				num2 = (short)448850977;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_4F;
				default:
					num2 = (short)1755447296;
					if (num2 != 0)
					{
					}
					return;
				}
				break;
			}
			}
			IL_1C:
			num2 = (short)2007629825;
			if (num2 != 0)
			{
			}
			dataContractSerializerOperationBehavior = description.Behaviors.Find<global::System.ServiceModel.Description.DataContractSerializerOperationBehavior>();
			IL_4F:
			num2 = (short)872022016;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002300 File Offset: 0x00000500
		public void ApplyDispatchBehavior(global::System.ServiceModel.Description.OperationDescription description, global::System.ServiceModel.Dispatcher.DispatchOperation dispatch)
		{
			int num;
			global::System.ServiceModel.Description.DataContractSerializerOperationBehavior dataContractSerializerOperationBehavior;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (dataContractSerializerOperationBehavior != null)
						{
							num2 = (short)1568276480;
							short num3 = num2;
							num2 = (short)16777218;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_A6;
					case 1:
						goto IL_A4;
					case 2:
						dataContractSerializerOperationBehavior.DataContractResolver = new global::System.Data.Entity.Core.Objects.ProxyDataContractResolver();
						num2 = (short)972881921;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_A4:
				IL_A6:
				num2 = (short)95313207;
				short num4 = num2;
				num2 = (short)471555383;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_28;
				default:
					num2 = (short)1010237441;
					if (num2 != 0)
					{
					}
					num2 = (short)328269824;
					if (num2 != 0)
					{
					}
					return;
				}
				break;
			}
			}
			IL_1C:
			dataContractSerializerOperationBehavior = description.Behaviors.Find<global::System.ServiceModel.Description.DataContractSerializerOperationBehavior>();
			IL_28:
			num2 = (short)347471872;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002424 File Offset: 0x00000624
		public void Validate(global::System.ServiceModel.Description.OperationDescription description)
		{
			short num = (short)1077459821;
			short num2 = num;
			num = (short)631356269;
			switch (num2 == num)
			{
			}
			num = (short)69402624;
			short num3 = num;
			num = (short)1039269889;
			if (num != 0)
			{
			}
			num = (short)1801322496;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000024CC File Offset: 0x000006CC
		public static object ConvertProxyToPOCO(object proxyObject)
		{
			short num = (short)1569587200;
			int num2 = (int)((global::System.IntPtr)num);
			object result;
			for (;;)
			{
				global::System.Runtime.Serialization.DataContractSerializer dataContractSerializer;
				global::System.IO.MemoryStream memoryStream;
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
					try
					{
						dataContractSerializer.WriteObject(memoryStream, proxyObject);
						memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
						result = dataContractSerializer.ReadObject(memoryStream);
						goto IL_165;
					}
					finally
					{
						num = (short)186384384;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_ED;
								}
								continue;
							case 1:
								goto IL_122;
							case 2:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)935657473;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_ED:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)401735682;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_122:;
					}
					goto IL_125;
					IL_165:
					num = (short)2003732513;
					short num3 = num;
					num = (short)1674151969;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_19A;
					}
					break;
				}
				case 2:
					goto IL_4B;
				}
				IL_30:
				if (proxyObject == null)
				{
					num = (short)800849922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_125:
				dataContractSerializer = new global::System.Runtime.Serialization.DataContractSerializer(proxyObject.GetType(), new global::System.Runtime.Serialization.DataContractSerializerSettings
				{
					DataContractResolver = new global::System.Data.Entity.Core.Objects.ProxyDataContractResolver()
				});
				memoryStream = new global::System.IO.MemoryStream();
				num = (short)1502281729;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4B:
			num = (short)1667629056;
			short num4 = num;
			num = (short)1294663681;
			if (num != 0)
			{
			}
			return null;
			IL_19A:
			num = (short)1682112512;
			if (num != 0)
			{
			}
			return result;
		}
	}
}
