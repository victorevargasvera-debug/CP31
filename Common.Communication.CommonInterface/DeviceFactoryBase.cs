using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommunicationManager;

namespace Motorola.Common.Communication
{
	// Token: 0x02000006 RID: 6
	public abstract class DeviceFactoryBase : global::Motorola.Common.Communication.IDeviceFactory
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00002DD4 File Offset: 0x00000FD4
		protected DeviceFactoryBase(global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory)
		{
			this.CommunicationManager = communicationManager;
			this.CommunicationPipeFactory = communicationPipeFactory;
			this.SequenceManagerFactory = sequenceManagerFactory;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002DFC File Offset: 0x00000FFC
		public virtual bool CreateRadios(out global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> radioList, global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> hwProfileList)
		{
			short num = (short)252379136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_29:
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile>.Enumerator enumerator;
						bool flag;
						switch (num2)
						{
						case 0:
							if (hwProfileList.Count != 1)
							{
								num = (short)1873215489;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_200;
						case 1:
						{
							num = (short)1707606016;
							short num3 = num;
							num = (short)163446787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							try
							{
								num = (short)731840514;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_14B;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_D5;
										}
										continue;
									case 3:
										num = (short)9371648;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1792737286;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.IRadioProfile hwProfile = enumerator.Current;
										global::Motorola.Common.Communication.IMotoDevice motoDevice;
										flag = this.CreateRadio(out motoDevice, hwProfile);
										num = (short)187891717;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										if (!flag)
										{
											num = (short)228196355;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)591003655;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										num = (short)444727304;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										global::Motorola.Common.Communication.IMotoDevice motoDevice;
										if (motoDevice != null)
										{
											num = (short)1750532105;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
										goto IL_1ED;
									case 9:
									{
										global::Motorola.Common.Communication.IMotoDevice motoDevice;
										radioList.Add(motoDevice);
										num = (short)1351876609;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_F6:
									num = (short)925958148;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_D5:
									goto IL_F6;
								}
								IL_14B:
								IL_1ED:
								return flag;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_200;
						case 3:
							if (hwProfileList.Count != 2)
							{
								num = (short)81395716;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_200;
						case 4:
							return false;
						}
						goto IL_44;
						IL_200:
						flag = false;
						enumerator = hwProfileList.GetEnumerator();
						num = (short)1236879311;
						short num4 = num;
						num = (short)21514191;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4B;
						default:
							num = (short)1130496001;
							if (num != 0)
							{
							}
							num = (short)942342144;
							if (num != 0)
							{
							}
							num = (short)2016739330;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					return false;
				}
				IL_44:
				radioList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice>();
				IL_4B:
				num = (short)1130364928;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
		}

		// Token: 0x06000022 RID: 34
		protected abstract bool CreateRadio(out global::Motorola.Common.Communication.IMotoDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile);

		// Token: 0x06000023 RID: 35 RVA: 0x0000312C File Offset: 0x0000132C
		public virtual bool IsSupport(string productId)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			int num5;
			string[] pidlist;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1055653888;
					short num3 = num2;
					num2 = (short)1325743374;
					short num4 = num2;
					num2 = (short)1648966926;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)2039676928;
						if (num2 != 0)
						{
						}
						goto IL_11D;
					}
					break;
				}
				case 1:
				{
					string value;
					if (productId.Equals(value))
					{
						num2 = (short)494206979;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num5++;
					num2 = (short)1819082754;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_11D;
				case 3:
					return true;
				case 4:
				{
					if (num5 >= pidlist.Length)
					{
						num2 = (short)357498885;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					string value = pidlist[num5];
					num2 = (short)1058471937;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					return false;
				}
				goto IL_28;
				IL_11D:
				num2 = (short)649658369;
				if (num2 != 0)
				{
				}
				num2 = (short)414973956;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_28:
			pidlist = this.PIDList;
			num5 = 0;
			num2 = (short)2027945984;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000032BC File Offset: 0x000014BC
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000336C File Offset: 0x0000156C
		public string[] PIDList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1693843456;
				short num2 = num;
				num = (short)631356134;
				short num3 = num;
				num = (short)1442953958;
				switch (num3 == num)
				{
				}
				num = (short)96862208;
				if (num != 0)
				{
				}
				num = (short)41287681;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)690552832;
				short num2 = num;
				num = (short)1732200841;
				short num3 = num;
				num = (short)1388267913;
				switch (num3 == num)
				{
				}
				num = (short)1129316353;
				if (num != 0)
				{
				}
				num = (short)427950080;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0400000C RID: 12
		protected readonly global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory SequenceManagerFactory;

		// Token: 0x0400000D RID: 13
		protected readonly global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager CommunicationManager;

		// Token: 0x0400000E RID: 14
		protected readonly global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory CommunicationPipeFactory;

		// Token: 0x0400000F RID: 15
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string[] a;
	}
}
