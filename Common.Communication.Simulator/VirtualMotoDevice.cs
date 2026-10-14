using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.Common.Communication;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Common.Communication.Simulator
{
	// Token: 0x02000005 RID: 5
	public class VirtualMotoDevice : global::Motorola.Common.Communication.IMotoDevice, global::Motorola.Common.Communication.CommonUtil.IObservable
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00003BE8 File Offset: 0x00001DE8
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00003C94 File Offset: 0x00001E94
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo DeviceInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)440747745;
				short num2 = num;
				num = (short)428033761;
				switch (num2 == num)
				{
				}
				num = (short)1267269632;
				if (num != 0)
				{
				}
				num = (short)355860480;
				short num3 = num;
				num = (short)2067595265;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)847017354;
				short num2 = num;
				num = (short)1492219274;
				switch (num2 == num)
				{
				}
				num = (short)1695088641;
				if (num != 0)
				{
				}
				num = (short)1522794496;
				short num3 = num;
				num = (short)33226752;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003D44 File Offset: 0x00001F44
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00003DF4 File Offset: 0x00001FF4
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2021788962;
				short num2 = num;
				num = (short)352849186;
				switch (num2 == num)
				{
				}
				num = (short)350945281;
				if (num != 0)
				{
				}
				num = (short)2049703936;
				short num3 = num;
				num = (short)1294401536;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)952176776;
				short num2 = num;
				num = (short)220139656;
				switch (num2 == num)
				{
				}
				num = (short)1251672065;
				if (num != 0)
				{
				}
				num = (short)1927413760;
				short num3 = num;
				num = (short)1230503936;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003EA8 File Offset: 0x000020A8
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00003F5C File Offset: 0x0000215C
		public bool DifferentialWriteCapableRadio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)263975603;
				short num2 = num;
				num = (short)1057813171;
				switch (num2 == num)
				{
				}
				num = (short)1014300673;
				if (num != 0)
				{
				}
				num = (short)1302659072;
				short num3 = num;
				num = (short)1249116160;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2070306586;
				short num2 = num;
				num = (short)2005688090;
				switch (num2 == num)
				{
				}
				num = (short)1954349057;
				if (num != 0)
				{
				}
				num = (short)1784938496;
				short num3 = num;
				num = (short)54001664;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000400C File Offset: 0x0000220C
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000040BC File Offset: 0x000022BC
		public bool Active
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)733386350;
				short num2 = num;
				num = (short)1988531822;
				switch (num2 == num)
				{
				}
				num = (short)255066113;
				if (num != 0)
				{
				}
				num = (short)1616773120;
				short num3 = num;
				num = (short)648806400;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1530128346;
				short num2 = num;
				num = (short)1437198298;
				switch (num2 == num)
				{
				}
				num = (short)2048000001;
				if (num != 0)
				{
				}
				num = (short)1848377344;
				short num3 = num;
				num = (short)1407844352;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000416C File Offset: 0x0000236C
		public bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			short num = (short)1962596573;
			short num2 = num;
			num = (short)1128913117;
			switch (num2 == num)
			{
			}
			num = (short)1926561793;
			if (num != 0)
			{
			}
			num = (short)1228996608;
			short num3 = num;
			num = (short)1357905920;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00004218 File Offset: 0x00002418
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000042CC File Offset: 0x000024CC
		public global::Motorola.Common.Communication.CommonUtil.RadioState radioState
		{
			get
			{
				short num = (short)1171413919;
				short num2 = num;
				num = (short)47143839;
				switch (num2 == num)
				{
				}
				num = (short)1830289408;
				if (num != 0)
				{
				}
				num = (short)1826684928;
				short num3 = num;
				num = (short)1723990017;
				if (num != 0)
				{
				}
				return this.DeviceInfo.RadioState;
			}
			set
			{
				short num = (short)1694323493;
				short num2 = num;
				num = (short)1228165925;
				switch (num2 == num)
				{
				}
				num = (short)2091974657;
				if (num != 0)
				{
				}
				num = (short)712114176;
				short num3 = num;
				num = (short)512819200;
				if (num != 0)
				{
				}
				this.DeviceInfo.RadioState = value;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004380 File Offset: 0x00002580
		public VirtualMotoDevice(global::Motorola.Common.Communication.IRadioProfile radioProf)
		{
			this.a = (radioProf as global::Common.Communication.Simulator.a);
			this.DeviceInfo = this.a.a().Key;
			this.c = this.a.a().Value;
			this.radioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			this.DeviceInfo.RadioID = this.a.b();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000043F0 File Offset: 0x000025F0
		public ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			short num = (short)2109341701;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (operationType != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
					{
						num = (short)253886467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_196;
				case 1:
				{
					num = (short)785055744;
					short num3 = num;
					this.b = true;
					num = (short)1022361607;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (operationType != global::Motorola.Common.Communication.CommonUtil.RadioOperation.None)
					{
						num = (short)60751873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_196;
				case 3:
				{
					num = (short)18233262;
					short num4 = num;
					num = (short)1165506478;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15D;
					default:
						num = (short)160563200;
						if (num != 0)
						{
						}
						num = (short)1942421506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_15D;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 6:
					goto IL_1B5;
				case 7:
					goto IL_AE;
				}
				IL_44:
				num = (short)348192769;
				if (num != 0)
				{
				}
				if (operationType != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)
				{
					num = (short)564592644;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_196;
				IL_15D:
				num = (short)1262026752;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_196:
				this.b = false;
				num = (short)1838350342;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AE:
			IL_1B5:
			this.e = operationType;
			return 0;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000045BC File Offset: 0x000027BC
		public void CloseSession(bool pendingDeploy)
		{
			short num = (short)301989894;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1454670240;
					short num3 = num;
					num = (short)1888190880;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1415184384;
						if (num != 0)
						{
						}
						num = (short)1279459332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_1A9;
				case 2:
					num = (short)2019229704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (this.e != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
					{
						num = (short)2088501248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6A;
				case 4:
					if (this.e != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
					{
						num = (short)446431233;
						if (num != 0)
						{
						}
						num = (short)1278738434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6A;
				case 5:
					global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>.Instance().DetachDevice(this.a);
					global::System.Threading.Thread.Sleep(2000);
					num = (short)1175060483;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 7:
					goto IL_CF;
				case 8:
					if (this.e == global::Motorola.Common.Communication.CommonUtil.RadioOperation.ChargingFeature)
					{
						num = (short)499056647;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>.Instance().AttachDevice(new global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>(this.DeviceInfo, this.c), true, false);
					num = (short)1231028225;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_48:
				if (!this.b)
				{
					return;
				}
				num = (short)1686241285;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_6A:
			global::System.Threading.Thread.Sleep(8000);
			global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>.Instance().AttachDevice(new global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>(this.DeviceInfo, this.c), true, true);
			return;
			IL_CF:
			goto IL_6A;
			IL_1A9:
			num = (short)614531072;
			short num4 = num;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004808 File Offset: 0x00002A08
		public void FreeDeviceStatuse(bool closeConnectWithError)
		{
			short num = (short)1220526363;
			short num2 = num;
			num = (short)1837941019;
			switch (num2 == num)
			{
			}
			num = (short)98959361;
			if (num != 0)
			{
			}
			num = (short)507117568;
			short num3 = num;
			num = (short)1879048192;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000048B4 File Offset: 0x00002AB4
		public void Prefetch()
		{
			short num = (short)575796981;
			short num2 = num;
			num = (short)153155317;
			switch (num2 == num)
			{
			}
			num = (short)1170604032;
			if (num != 0)
			{
			}
			num = (short)235995136;
			short num3 = num;
			num = (short)1063059457;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000495C File Offset: 0x00002B5C
		public bool WaitForReady(int timeout)
		{
			short num = (short)1176371201;
			if (num != 0)
			{
			}
			num = (short)1153627270;
			short num2 = num;
			num = (short)2035872902;
			switch (num2 == num)
			{
			}
			num = (short)1246756864;
			short num3 = num;
			num = (short)1024720896;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004A04 File Offset: 0x00002C04
		public void Init(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)838644367;
			short num2 = num;
			num = (short)595374735;
			switch (num2 == num)
			{
			}
			num = (short)1288634369;
			if (num != 0)
			{
			}
			num = (short)1076428800;
			short num3 = num;
			num = (short)1782054912;
			if (num != 0)
			{
			}
			this.d = progressIndicator;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004AB4 File Offset: 0x00002CB4
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			short num = (short)682504739;
			short num2 = num;
			num = (short)128725539;
			switch (num2 == num)
			{
			}
			num = (short)1922564097;
			if (num != 0)
			{
			}
			num = (short)1146814464;
			short num3 = num;
			num = (short)753139712;
			if (num != 0)
			{
			}
			return this.DeviceInfo.Copy();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004B68 File Offset: 0x00002D68
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			short num = (short)872785277;
			short num2 = num;
			num = (short)23504253;
			switch (num2 == num)
			{
			}
			num = (short)818479105;
			if (num != 0)
			{
			}
			num = (short)543424512;
			short num3 = num;
			num = (short)2122842112;
			if (num != 0)
			{
			}
			return this.ReadDeviceInfo() as global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004C1C File Offset: 0x00002E1C
		public global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba)
		{
			short num = (short)271319619;
			short num2 = num;
			num = (short)2066022979;
			switch (num2 == num)
			{
			}
			num = (short)532545537;
			if (num != 0)
			{
			}
			num = (short)81657856;
			short num3 = num;
			num = (short)15794176;
			if (num != 0)
			{
			}
			this.a(global::Common.Communication.Simulator.VRDefinitions.ReadTime);
			return this.c;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004CD4 File Offset: 0x00002ED4
		public global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			short num = (short)736034816;
			switch (num)
			{
			default:
			{
				num = (short)1383792644;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator;
					global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
					switch (num2)
					{
					case 0:
					{
						num = (short)1795883008;
						short num3 = num;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>(blockList.Count);
						num = (short)207880193;
						if (num != 0)
						{
						}
						num = (short)2009923586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)861077508;
							num2 = (int)((global::System.IntPtr)num);
							global::Motorola.Common.Communication.Pba.PbaObject result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3F0;
								case 1:
									num = (short)272891904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_371;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1727332353;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.DataPartition dataPartition = enumerator.Current;
									global::Motorola.Common.Communication.Pba.DataPartition dataPartition2 = new global::Motorola.Common.Communication.Pba.DataPartition
									{
										PartitionID = dataPartition.PartitionID,
										PartitionName = dataPartition.PartitionName,
										DataBlocks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>()
									};
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2 = dataPartition.DataBlocks.GetEnumerator();
									num = (short)1289224197;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_B9;
									}
									continue;
								case 5:
								{
									global::Motorola.Common.Communication.Pba.DataPartition dataPartition2;
									try
									{
										num = (short)439812099;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)936181764;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.Common.Communication.Pba.DataBlock dataBlock = enumerator2.Current;
												global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list;
												global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>.Enumerator enumerator3 = list.GetEnumerator();
												num = (short)1026949121;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												try
												{
													num = (short)6160391;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
															goto IL_27E;
														case 1:
															goto IL_263;
														case 2:
															num = (short)1816788992;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 3:
														{
															global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
															global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
															if (ishHeader.IshID == dataBlock.BlockID)
															{
																num = (short)431489032;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														}
														case 4:
														{
															global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
															dataPartition2.DataBlocks.Add(dataBlock);
															num = (short)1312882689;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 5:
														{
															global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
															global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
															if (ishHeader.IshType == dataBlock.BlockType)
															{
																num = (short)192348164;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														}
														case 6:
														{
															global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>.Enumerator enumerator3;
															if (!enumerator3.MoveNext())
															{
																num = (short)480641026;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader = enumerator3.Current;
															num = (short)417136643;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 7:
															switch (0)
															{
															case 0:
																goto IL_16F;
															}
															continue;
														case 8:
															num = (short)533725189;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														IL_171:
														num = (short)809435142;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_16F:
														goto IL_171;
													}
													IL_263:
													IL_27E:;
												}
												finally
												{
													global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>.Enumerator enumerator3;
													((global::System.IDisposable)enumerator3).Dispose();
												}
												break;
											case 2:
												goto IL_2E6;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_F8;
												}
												continue;
											case 4:
												num = (short)653262850;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_28E:
											num = (short)1200816128;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_F8:
											goto IL_28E;
										}
										IL_2E6:
										goto IL_339;
									}
									finally
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2;
										((global::System.IDisposable)enumerator2).Dispose();
									}
									break;
									IL_339:
									pbaObject.CodeplugData.DataPartitions.Add(dataPartition2);
									this.a(global::Common.Communication.Simulator.VRDefinitions.ReadTime);
									result = pbaObject;
									num = (short)759824386;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_2F6:
								num = (short)1810432003;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B9:
								goto IL_2F6;
							}
							IL_371:
							return result;
							IL_3F0:
							goto IL_48C;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_403;
					case 2:
					{
						try
						{
							global::System.Collections.Generic.IEnumerator<T> enumerator4 = blockList.GetEnumerator();
							try
							{
								num = (short)1779256430;
								short num4 = num;
								num = (short)962088046;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_586:
									goto IL_588;
								default:
									num = (short)590610432;
									if (num != 0)
									{
									}
									num = (short)935002115;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
								for (;;)
								{
									IL_56B:
									switch (num2)
									{
									case 0:
										num = (short)1081409538;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										if (!enumerator4.MoveNext())
										{
											num = (short)1970143232;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										object obj = enumerator4.Current;
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list;
										list.Add((global::Motorola.Common.Communication.CommonUtil.IshHeader)obj);
										num = (short)988151812;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_604;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_586;
										}
										continue;
									}
									break;
								}
								goto IL_588;
								IL_604:
								goto IL_670;
								IL_588:
								num = (short)696516609;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_56B;
							}
							finally
							{
								num = (short)1650786305;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator4.Dispose();
										num = (short)1587609602;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_638;
										}
										continue;
									case 2:
										goto IL_66D;
									}
									IL_638:
									if (enumerator4 == null)
									{
										break;
									}
									num = (short)1562574848;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_66D:;
							}
							IL_670:
							goto IL_403;
						}
						catch (global::System.InvalidCastException systemException)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgumentType, systemException);
						}
						global::Motorola.Common.Communication.Pba.PbaObject result;
						return result;
					}
					case 3:
						num = (short)414187525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						continue;
					case 5:
						if (blockList.Any<T>())
						{
							num = (short)222429184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48C;
					}
					IL_5B:
					if (blockList != null)
					{
						num = (short)1719599107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_403:
					pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
					enumerator = this.c.CodeplugData.DataPartitions.GetEnumerator();
					num = (short)648478721;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_48C:
				return null;
			}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000053E0 File Offset: 0x000035E0
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, string pcrNewPassword, int? userDefersAllowed = null)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (writePBA.LanguagePackData.LanguagePacks != null)
					{
						num2 = (short)1638137857;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BE;
				case 1:
					IL_1BF:
					num2 = (short)2041643009;
					if (num2 != 0)
					{
					}
					num2 = (short)458424322;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (writePBA.LanguagePackData.LanguagePacks.Count <= 0)
					{
						num2 = (short)87425030;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1EA;
				case 3:
					goto IL_12E;
				case 4:
					num2 = (short)1182400512;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (writePBA.LanguagePackData != null)
					{
						num2 = (short)1381040132;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BE;
				case 6:
					goto IL_BE;
				}
				goto IL_2C;
				IL_BE:
				this.c.LanguagePackData = languagePackData;
				num2 = (short)819996776;
				short num3 = num2;
				num2 = (short)1788946536;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1BF;
				default:
					num2 = (short)576061440;
					if (num2 != 0)
					{
					}
					num2 = (short)1736310787;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			IL_12E:
			IL_1EA:
			return this.c;
			IL_2C:
			num2 = (short)670564352;
			short num4 = num2;
			this.a(global::Common.Communication.Simulator.VRDefinitions.WriteTime);
			languagePackData = this.c.LanguagePackData;
			this.c = writePBA;
			this.c.ValidationFields.Clear();
			num2 = (short)630718469;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000055E0 File Offset: 0x000037E0
		public void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA)
		{
			short num = (short)1605178561;
			short num2 = num;
			num = (short)788665537;
			switch (num2 == num)
			{
			}
			num = (short)532545536;
			short num3 = num;
			num = (short)1022754816;
			if (num != 0)
			{
			}
			num = (short)79167489;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005688 File Offset: 0x00003888
		public void DepotForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA)
		{
			short num = (short)1948148089;
			short num2 = num;
			num = (short)2052809081;
			switch (num2 == num)
			{
			}
			num = (short)901709824;
			short num3 = num;
			num = (short)28180480;
			if (num != 0)
			{
			}
			num = (short)1620443137;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005738 File Offset: 0x00003938
		public void UpdateSerialNumber(string serialNumber)
		{
			short num = (short)523103325;
			short num2 = num;
			num = (short)1596124253;
			switch (num2 == num)
			{
			}
			num = (short)600309760;
			short num3 = num;
			num = (short)1249116160;
			if (num != 0)
			{
			}
			num = (short)1654784001;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000057E4 File Offset: 0x000039E4
		public void CBIProgramme()
		{
			short num = (short)1545053864;
			short num2 = num;
			num = (short)1745659560;
			switch (num2 == num)
			{
			}
			num = (short)979238912;
			short num3 = num;
			num = (short)1112670209;
			if (num != 0)
			{
			}
			num = (short)1371865088;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005890 File Offset: 0x00003A90
		public void DeviceControl(global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams inputParams, ref global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams outputParams)
		{
			short num = (short)1267019110;
			short num2 = num;
			num = (short)1843408230;
			switch (num2 == num)
			{
			}
			num = (short)1780350976;
			short num3 = num;
			num = (short)1619001345;
			if (num != 0)
			{
			}
			num = (short)610664448;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005940 File Offset: 0x00003B40
		public byte[] ReadUnkillChallengeValue()
		{
			short num = (short)1733506964;
			short num2 = num;
			num = (short)1170552724;
			switch (num2 == num)
			{
			}
			num = (short)2095513600;
			short num3 = num;
			num = (short)321978368;
			if (num != 0)
			{
			}
			num = (short)2104098817;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000059F0 File Offset: 0x00003BF0
		public void UnkillRadio(byte[] authenticationValue)
		{
			short num = (short)896910253;
			short num2 = num;
			num = (short)99468205;
			switch (num2 == num)
			{
			}
			num = (short)554369024;
			short num3 = num;
			num = (short)305266688;
			if (num != 0)
			{
			}
			num = (short)419430401;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005A9C File Offset: 0x00003C9C
		public void InitDeviceParams()
		{
			short num = (short)771323660;
			short num2 = num;
			num = (short)1434679052;
			switch (num2 == num)
			{
			}
			num = (short)1105526784;
			short num3 = num;
			num = (short)1565196289;
			if (num != 0)
			{
			}
			num = (short)1857748992;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005B48 File Offset: 0x00003D48
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			short num = (short)1519236452;
			short num2 = num;
			num = (short)805287268;
			switch (num2 == num)
			{
			}
			num = (short)1628372992;
			short num3 = num;
			num = (short)469499904;
			if (num != 0)
			{
			}
			num = (short)1649344513;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005BF8 File Offset: 0x00003DF8
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> ReadFilesListInDir(global::Motorola.Common.Communication.Pba.FileItem dir)
		{
			short num = (short)136789905;
			short num2 = num;
			num = (short)311836561;
			switch (num2 == num)
			{
			}
			num = (short)2109210624;
			short num3 = num;
			num = (short)1463549953;
			if (num != 0)
			{
			}
			num = (short)178847744;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005CA8 File Offset: 0x00003EA8
		public global::Motorola.Common.Communication.Pba.FileItem ReadFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			short num = (short)123660762;
			short num2 = num;
			num = (short)2072898010;
			switch (num2 == num)
			{
			}
			num = (short)14286848;
			short num3 = num;
			num = (short)1374289920;
			if (num != 0)
			{
			}
			num = (short)359268353;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005D54 File Offset: 0x00003F54
		public void WriteFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			short num = (short)602169718;
			short num2 = num;
			num = (short)1218077046;
			switch (num2 == num)
			{
			}
			num = (short)87556096;
			short num3 = num;
			num = (short)998572033;
			if (num != 0)
			{
			}
			num = (short)1404567552;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005E00 File Offset: 0x00004000
		public void DeleteFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			short num = (short)78222710;
			short num2 = num;
			num = (short)1779012982;
			switch (num2 == num)
			{
			}
			num = (short)1952382976;
			short num3 = num;
			num = (short)680984576;
			if (num != 0)
			{
			}
			num = (short)1162608641;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005EB0 File Offset: 0x000040B0
		public long GetFileOrDirSize(global::Motorola.Common.Communication.Pba.FileItem fileOrDir)
		{
			short num = (short)199470765;
			short num2 = num;
			num = (short)1068936877;
			switch (num2 == num)
			{
			}
			num = (short)1720778752;
			short num3 = num;
			num = (short)1556807680;
			if (num != 0)
			{
			}
			num = (short)1317076993;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005F60 File Offset: 0x00004160
		public void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			short num = (short)1254626443;
			short num2 = num;
			num = (short)798495883;
			switch (num2 == num)
			{
			}
			num = (short)1487339520;
			short num3 = num;
			num = (short)30998528;
			if (num != 0)
			{
			}
			num = (short)1493434369;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00006010 File Offset: 0x00004210
		public void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			short num = (short)2141739000;
			short num2 = num;
			num = (short)1031231480;
			switch (num2 == num)
			{
			}
			num = (short)1848508416;
			short num3 = num;
			num = (short)1551695873;
			if (num != 0)
			{
			}
			num = (short)1113915392;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000060BC File Offset: 0x000042BC
		public void UpgradeFlashStrap(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			short num = (short)1244937565;
			short num2 = num;
			num = (short)1772830045;
			switch (num2 == num)
			{
			}
			num = (short)606797824;
			short num3 = num;
			num = (short)1938096129;
			if (num != 0)
			{
			}
			num = (short)1367474176;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00006170 File Offset: 0x00004370
		public void EraseRadio(global::System.Collections.Generic.List<string> sections)
		{
			short num = (short)115605505;
			if (num != 0)
			{
			}
			num = (short)2030884325;
			short num2 = num;
			num = (short)1987565029;
			switch (num2 == num)
			{
			default:
			{
				num = (short)942276608;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)454295552;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00006220 File Offset: 0x00004420
		public void EraseRadioFromTo(uint startAddress, uint size)
		{
			short num = (short)1823972784;
			short num2 = num;
			num = (short)1139908016;
			switch (num2 == num)
			{
			}
			num = (short)1580204032;
			short num3 = num;
			num = (short)1828192257;
			if (num != 0)
			{
			}
			num = (short)610729984;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000062D0 File Offset: 0x000044D0
		public void UpgradeFDT(string destModel, string destCPVersion, string serialNumber)
		{
			short num = (short)1708982273;
			if (num != 0)
			{
			}
			num = (short)1998913987;
			short num2 = num;
			num = (short)1996882371;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1151467520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1819279360;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000637C File Offset: 0x0000457C
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData updateData)
		{
			short num = (short)1133130918;
			short num2 = num;
			num = (short)292500646;
			switch (num2 == num)
			{
			}
			num = (short)517406720;
			short num3 = num;
			num = (short)1665400832;
			if (num != 0)
			{
			}
			num = (short)485818369;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00006428 File Offset: 0x00004628
		public global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageByAddress(uint startAddress, uint size)
		{
			short num = (short)1370659524;
			short num2 = num;
			num = (short)1143249604;
			switch (num2 == num)
			{
			}
			num = (short)2094989312;
			short num3 = num;
			num = (short)522452993;
			if (num != 0)
			{
			}
			num = (short)1890385920;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000064D4 File Offset: 0x000046D4
		public void WriteImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image)
		{
			short num = (short)1353383937;
			if (num != 0)
			{
			}
			num = (short)1539861962;
			short num2 = num;
			num = (short)846228938;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2031353856;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)25165824;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00006584 File Offset: 0x00004784
		public void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			short num = (short)74727994;
			short num2 = num;
			num = (short)2138980922;
			switch (num2 == num)
			{
			}
			num = (short)1307705344;
			short num3 = num;
			num = (short)493420544;
			if (num != 0)
			{
			}
			num = (short)2026438657;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00006634 File Offset: 0x00004834
		public void UpdateRadioDisplay()
		{
			short num = (short)444359089;
			short num2 = num;
			num = (short)1565811121;
			switch (num2 == num)
			{
			}
			num = (short)1997471744;
			short num3 = num;
			num = (short)676790273;
			if (num != 0)
			{
			}
			num = (short)726401024;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000066E4 File Offset: 0x000048E4
		public void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject updatePBA, bool hostedDepotOperation, int? userDefersAllowed = null)
		{
			short num = (short)1582011155;
			short num2 = num;
			num = (short)290362131;
			switch (num2 == num)
			{
			}
			num = (short)1674117120;
			short num3 = num;
			num = (short)375062528;
			if (num != 0)
			{
			}
			num = (short)1120862209;
			if (num != 0)
			{
			}
			this.a(global::Common.Communication.Simulator.VRDefinitions.UpgradeTime);
			this.c = updatePBA;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000067A0 File Offset: 0x000049A0
		public void PreUpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject updatePBA, bool hostedDepotOperation)
		{
			short num = (short)1240224487;
			short num2 = num;
			num = (short)2114409191;
			switch (num2 == num)
			{
			}
			num = (short)1112801280;
			short num3 = num;
			num = (short)2082734081;
			if (num != 0)
			{
			}
			num = (short)1495203840;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006850 File Offset: 0x00004A50
		public bool WriteRamdownloader(string filePath)
		{
			short num = (short)1968766976;
			short num2 = num;
			num = (short)206127466;
			short num3 = num;
			num = (short)1937850730;
			switch (num3 == num)
			{
			}
			num = (short)1247608833;
			if (num != 0)
			{
			}
			num = (short)965672960;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000068FC File Offset: 0x00004AFC
		public void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			short num = (short)222691328;
			short num2 = num;
			num = (short)1499735819;
			short num3 = num;
			num = (short)770057995;
			switch (num3 == num)
			{
			}
			num = (short)1841430528;
			if (num != 0)
			{
			}
			num = (short)1900019713;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000069AC File Offset: 0x00004BAC
		public void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			short num = (short)583794688;
			short num2 = num;
			num = (short)940270146;
			short num3 = num;
			num = (short)1221681730;
			switch (num3 == num)
			{
			}
			num = (short)102825984;
			if (num != 0)
			{
			}
			num = (short)1578237953;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006A58 File Offset: 0x00004C58
		public global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType)
		{
			short num = (short)693370880;
			short num2 = num;
			num = (short)1291269246;
			short num3 = num;
			num = (short)859845758;
			switch (num3 == num)
			{
			}
			num = (short)860749824;
			if (num != 0)
			{
			}
			num = (short)157024257;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006B08 File Offset: 0x00004D08
		public void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			short num = (short)1871773696;
			short num2 = num;
			num = (short)660912960;
			short num3 = num;
			num = (short)215792448;
			switch (num3 == num)
			{
			}
			num = (short)521207808;
			if (num != 0)
			{
			}
			num = (short)1775566849;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006BB4 File Offset: 0x00004DB4
		public string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			short num = (short)352256000;
			short num2 = num;
			num = (short)1223809141;
			short num3 = num;
			num = (short)1167710325;
			switch (num3 == num)
			{
			}
			num = (short)222101505;
			if (num != 0)
			{
			}
			num = (short)1434976256;
			if (num != 0)
			{
			}
			return "";
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00006C64 File Offset: 0x00004E64
		public void Register(global::Motorola.Common.Communication.CommonUtil.IObserver anObserver)
		{
			short num = (short)83755008;
			short num2 = num;
			num = (short)485236345;
			short num3 = num;
			num = (short)1970806393;
			switch (num3 == num)
			{
			}
			num = (short)1822162944;
			if (num != 0)
			{
			}
			num = (short)1394081793;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006D10 File Offset: 0x00004F10
		public void UnRegister(global::Motorola.Common.Communication.CommonUtil.IObserver anObserver)
		{
			short num = (short)1337917440;
			short num2 = num;
			num = (short)1710383304;
			short num3 = num;
			num = (short)2122080456;
			switch (num3 == num)
			{
			}
			num = (short)162004993;
			if (num != 0)
			{
			}
			num = (short)1508573184;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006DC0 File Offset: 0x00004FC0
		public void SendUpdateIMEType(byte ime)
		{
			short num = (short)1933901824;
			short num2 = num;
			num = (short)1702800297;
			short num3 = num;
			num = (short)44673961;
			switch (num3 == num)
			{
			}
			num = (short)503185408;
			if (num != 0)
			{
			}
			num = (short)691077121;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006E6C File Offset: 0x0000506C
		public void SendUpdateDateCode(byte[] datecode, ushort source)
		{
			short num = (short)1796014080;
			short num2 = num;
			num = (short)783492138;
			short num3 = num;
			num = (short)100803626;
			switch (num3 == num)
			{
			}
			num = (short)2000486401;
			if (num != 0)
			{
			}
			num = (short)1576009728;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00006F1C File Offset: 0x0000511C
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo()
		{
			short num = (short)568131584;
			short num2 = num;
			num = (short)1394691083;
			short num3 = num;
			num = (short)3230731;
			switch (num3 == num)
			{
			}
			num = (short)282918913;
			if (num != 0)
			{
			}
			num = (short)1508376576;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006FC8 File Offset: 0x000051C8
		public void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			short num = (short)102432768;
			short num2 = num;
			num = (short)417792001;
			if (num != 0)
			{
			}
			num = (short)61026740;
			short num3 = num;
			num = (short)1641361844;
			switch (num3 == num)
			{
			}
			num = (short)1189740544;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00007074 File Offset: 0x00005274
		public void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			short num = (short)509739008;
			short num2 = num;
			num = (short)172252890;
			short num3 = num;
			num = (short)957374170;
			switch (num3 == num)
			{
			}
			num = (short)1012203520;
			if (num != 0)
			{
			}
			num = (short)1784872961;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00007120 File Offset: 0x00005320
		public void WaitForCancelReading()
		{
			short num = (short)39452672;
			short num2 = num;
			num = (short)2037130285;
			short num3 = num;
			num = (short)1934304301;
			switch (num3 == num)
			{
			}
			num = (short)1519910913;
			if (num != 0)
			{
			}
			num = (short)488308736;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000071D0 File Offset: 0x000053D0
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			short num = (short)1344929792;
			short num2 = num;
			num = (short)777125889;
			if (num != 0)
			{
			}
			num = (short)2133418448;
			short num3 = num;
			num = (short)1213489616;
			switch (num3 == num)
			{
			}
			num = (short)1342570496;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00007280 File Offset: 0x00005480
		public void UpdateMACAddress(byte[] macAddress)
		{
			short num = (short)1937965056;
			short num2 = num;
			num = (short)500868667;
			short num3 = num;
			num = (short)570009147;
			switch (num3 == num)
			{
			}
			num = (short)885784576;
			if (num != 0)
			{
			}
			num = (short)395313153;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00007330 File Offset: 0x00005530
		public void SynPrepareDevice()
		{
			short num = (short)404750336;
			short num2 = num;
			num = (short)2023232403;
			short num3 = num;
			num = (short)1077220243;
			switch (num3 == num)
			{
			}
			num = (short)228917248;
			if (num != 0)
			{
			}
			num = (short)1093599233;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000073E0 File Offset: 0x000055E0
		public void FactoryReset()
		{
			short num = (short)735641600;
			short num2 = num;
			num = (short)671632851;
			short num3 = num;
			num = (short)1581600211;
			switch (num3 == num)
			{
			}
			num = (short)745144321;
			if (num != 0)
			{
			}
			num = (short)1223360512;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00007490 File Offset: 0x00005690
		private void a(int timer)
		{
			switch (0)
			{
			case 0:
				goto IL_BD;
			}
			short num;
			int num4;
			int num5;
			for (;;)
			{
				IL_0A:
				num = (short)51585065;
				short num2 = num;
				num = (short)2085756969;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)393871360;
					if (num != 0)
					{
					}
					num = (short)76218369;
					if (num != 0)
					{
					}
					num = (short)77332480;
					short num3 = num;
					switch (num4)
					{
					case 0:
						goto IL_E2;
					case 1:
						goto IL_E2;
					case 2:
						if (timer <= 0)
						{
							goto IL_FE;
						}
						global::System.Threading.Thread.Sleep(1000);
						this.d.UpdateProgress((double)(num5 - timer) / (double)timer);
						timer--;
						num = (short)1364721665;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_117;
					}
					goto IL_BD;
					IL_E2:
					num = (short)1343815682;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_FE:
				num = (short)132186115;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_117:
			this.d.UpdateProgress(1.0);
			return;
			IL_BD:
			timer = global::System.Math.Max(timer, 1);
			num5 = timer;
			num = (short)2067595264;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00007608 File Offset: 0x00005808
		public byte QueryRadioUpdateStatus()
		{
			short num = (short)1429929984;
			short num2 = num;
			num = (short)178269092;
			short num3 = num;
			num = (short)1623141284;
			switch (num3 == num)
			{
			}
			num = (short)677969921;
			if (num != 0)
			{
			}
			num = (short)2042888192;
			if (num != 0)
			{
			}
			return 0;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000076B4 File Offset: 0x000058B4
		public void ReadRadioParameters(global::Motorola.Common.Communication.CommonUtil.RadioParameterPairs paramPairs)
		{
			short num = (short)132317184;
			short num2 = num;
			num = (short)2123057224;
			short num3 = num;
			num = (short)2068006984;
			switch (num3 == num)
			{
			}
			num = (short)471203840;
			if (num != 0)
			{
			}
			num = (short)1797980161;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00007760 File Offset: 0x00005960
		public bool SetFWDLConfig(ushort tg, string version)
		{
			short num = (short)2112028672;
			short num2 = num;
			num = (short)1718083578;
			short num3 = num;
			num = (short)1951260666;
			switch (num3 == num)
			{
			}
			num = (short)516685825;
			if (num != 0)
			{
			}
			num = (short)299761664;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007810 File Offset: 0x00005A10
		public void SwitchAmpRadioToApMode()
		{
			short num = (short)1188036608;
			short num2 = num;
			num = (short)1032018582;
			short num3 = num;
			num = (short)1166498454;
			switch (num3 == num)
			{
			}
			num = (short)508821505;
			if (num != 0)
			{
			}
			num = (short)1380319232;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000078B8 File Offset: 0x00005AB8
		public bool EstablishSecureConnection(string psk)
		{
			short num = (short)120586240;
			short num2 = num;
			num = (short)749991109;
			short num3 = num;
			num = (short)1590097093;
			switch (num3 == num)
			{
			}
			num = (short)310771712;
			if (num != 0)
			{
			}
			num = (short)229048321;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00007968 File Offset: 0x00005B68
		public bool ResetPassword(byte[] resetBytes)
		{
			short num = (short)481296384;
			short num2 = num;
			num = (short)827969431;
			short num3 = num;
			num = (short)1820970903;
			switch (num3 == num)
			{
			}
			num = (short)616038401;
			if (num != 0)
			{
			}
			num = (short)2019950592;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007A14 File Offset: 0x00005C14
		public string GetPskId()
		{
			int a_ = 4;
			short num = (short)434241536;
			short num2 = num;
			num = (short)721511570;
			short num3 = num;
			num = (short)444818578;
			switch (num3 == num)
			{
			}
			num = (short)346947585;
			if (num != 0)
			{
			}
			num = (short)815726592;
			if (num != 0)
			{
			}
			return global::Common.Communication.Simulator.VirtualLEDevices.b("၂⩄⩆ⱈ歊ᵌᱎᩐ獒᱔ፖ", a_);
		}

		// Token: 0x04000008 RID: 8
		private global::Common.Communication.Simulator.a a;

		// Token: 0x04000009 RID: 9
		private bool b;

		// Token: 0x0400000A RID: 10
		private global::Motorola.Common.Communication.Pba.PbaObject c;

		// Token: 0x0400000B RID: 11
		private global::Motorola.Common.Communication.IProgressIndicator d;

		// Token: 0x0400000C RID: 12
		private global::Motorola.Common.Communication.CommonUtil.RadioOperation e;

		// Token: 0x0400000D RID: 13
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo f;

		// Token: 0x0400000E RID: 14
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo g;

		// Token: 0x0400000F RID: 15
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool h;

		// Token: 0x04000010 RID: 16
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool i;
	}
}
