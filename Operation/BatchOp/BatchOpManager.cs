using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000048 RID: 72
	public class BatchOpManager : global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOpManager
	{
		// Token: 0x060001BB RID: 443 RVA: 0x0002ACA0 File Offset: 0x00028EA0
		private BatchOpManager()
		{
			this.BatchOpList = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp>();
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0002ACE0 File Offset: 0x00028EE0
		public static global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOpManager Instance
		{
			get
			{
				short num = (short)752968991;
				short num2 = num;
				num = (short)1895327007;
				switch (num2 == num)
				{
				}
				num = (short)689111041;
				if (num != 0)
				{
				}
				num = (short)792592384;
				short num3 = num;
				num = (short)24641536;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpManager.a;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0002AD90 File Offset: 0x00028F90
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0002AE44 File Offset: 0x00029044
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> BatchOpList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)836429094;
				short num2 = num;
				num = (short)367256870;
				switch (num2 == num)
				{
				}
				num = (short)760348672;
				if (num != 0)
				{
				}
				num = (short)2140930048;
				short num3 = num;
				num = (short)1399586817;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)137926530;
				short num2 = num;
				num = (short)485463938;
				switch (num2 == num)
				{
				}
				num = (short)30605313;
				if (num != 0)
				{
				}
				num = (short)1947598848;
				short num3 = num;
				num = (short)875233280;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0002AEF4 File Offset: 0x000290F4
		public bool IsBusy
		{
			get
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> obj = this.b;
				bool flag = false;
				bool result;
				short num;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					result = (this.b.Count > 0);
				}
				finally
				{
					num = (short)1352728577;
					if (num != 0)
					{
					}
					num = (short)2101280770;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_103;
						case 1:
						{
							num = (short)1932429879;
							short num3 = num;
							num = (short)102664759;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1178927104;
								if (num != 0)
								{
								}
								global::System.Threading.Monitor.Exit(obj);
								break;
							}
							num = (short)1500381184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_7F;
							}
							continue;
						}
						IL_7F:
						if (!flag)
						{
							break;
						}
						num = (short)54657025;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_103:;
				}
				num = (short)1275723776;
				short num4 = num;
				return result;
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0002B044 File Offset: 0x00029244
		public global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp Find(global::System.Guid id)
		{
			short num = (short)1350591586;
			short num2 = num;
			num = (short)1371366498;
			switch (num2 == num)
			{
			}
			num = (short)2128478209;
			if (num != 0)
			{
			}
			num = (short)181403648;
			short num3 = num;
			num = (short)221577216;
			if (num != 0)
			{
			}
			return this.BatchOpList.Where(delegate(global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp rc)
			{
				short num4 = (short)1592420959;
				short num5 = num4;
				num4 = (short)489777759;
				switch (num5 == num4)
				{
				}
				num4 = (short)595066880;
				if (num4 != 0)
				{
				}
				num4 = (short)553189376;
				short num6 = num4;
				num4 = (short)1372127233;
				if (num4 != 0)
				{
				}
				return rc.ID == id;
			}).FirstOrDefault<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp>();
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0002B118 File Offset: 0x00029318
		public global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp FindByJbcId(global::System.Guid jbcId)
		{
			short num = (short)606976027;
			short num2 = num;
			num = (short)38189083;
			switch (num2 == num)
			{
			}
			num = (short)477495297;
			if (num != 0)
			{
			}
			num = (short)1435172864;
			short num3 = num;
			num = (short)241106944;
			if (num != 0)
			{
			}
			return this.BatchOpList.Where(delegate(global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp rc)
			{
				short num4 = (short)1701106397;
				short num5 = num4;
				num4 = (short)803132125;
				switch (num5 == num4)
				{
				}
				num4 = (short)1863122945;
				if (num4 != 0)
				{
				}
				num4 = (short)1024065536;
				if (num4 != 0)
				{
				}
				num4 = (short)955514880;
				short num6 = num4;
				return rc.JobContainerGuid == jbcId;
			}).FirstOrDefault<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp>();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0002B1EC File Offset: 0x000293EC
		public void Run(global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp batchOp)
		{
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> obj = this.d;
			bool flag = false;
			short num;
			try
			{
				num = (short)543031297;
				if (num != 0)
				{
				}
				global::System.Threading.Monitor.Enter(obj, ref flag);
				this.d.Add(batchOp);
				this.BatchOpList.Add(batchOp);
				batchOp.RunWorkerCompleted += this.a;
			}
			finally
			{
				num = (short)569573378;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_11E;
					case 1:
					{
						num = (short)1158173376;
						short num3 = num;
						num = (short)50483904;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)57671680;
							if (num != 0)
							{
							}
							global::System.Threading.Monitor.Exit(obj);
							break;
						}
						num = (short)1554448384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_9A;
						}
						continue;
					}
					IL_9A:
					if (!flag)
					{
						break;
					}
					num = (short)945160193;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11E:;
			}
			num = (short)1495400448;
			short num4 = num;
			this.a();
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0002B358 File Offset: 0x00029558
		public void ClearOldBatchOp()
		{
			short num = (short)247005184;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.Queue<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> obj = this.c;
				bool flag = false;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					using (global::System.Collections.Generic.Queue<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp>.Enumerator enumerator = this.c.GetEnumerator())
					{
						num = (short)568918017;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)993525762;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_79;
								}
								continue;
							case 2:
								goto IL_F5;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1697841152;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp item = enumerator.Current;
								this.BatchOpList.Remove(item);
								num = (short)821624836;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_A7:
							num = (short)1640431619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_79:
							goto IL_A7;
						}
						IL_F5:;
					}
					this.c.Clear();
				}
				finally
				{
					num = (short)38797314;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1CD;
						case 1:
						{
							num = (short)1714000078;
							short num3 = num;
							num = (short)934514894;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)923074560;
								if (num != 0)
								{
								}
								global::System.Threading.Monitor.Exit(obj);
								break;
							}
							num = (short)1294073856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_148;
							}
							continue;
						}
						IL_148:
						if (!flag)
						{
							break;
						}
						num = (short)1899298817;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1CD:;
				}
				num = (short)1319632897;
				if (num != 0)
				{
				}
				num = (short)2041970688;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0002B5A4 File Offset: 0x000297A4
		private void a(object A_0, global::System.ComponentModel.RunWorkerCompletedEventArgs A_1)
		{
			short num = (short)1559116994;
			short num2 = num;
			num = (short)1353596098;
			switch (num2 == num)
			{
			}
			num = (short)620560385;
			if (num != 0)
			{
			}
			num = (short)1588658176;
			short num3 = num;
			num = (short)758710272;
			if (num != 0)
			{
			}
			global::System.Threading.Tasks.Task.Run(delegate()
			{
				short num4 = (short)1754923008;
				short num5 = num4;
				num4 = (short)459997184;
				int num6 = (int)num4;
				switch (num6)
				{
				default:
				{
					global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp item = (global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp)A_0;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> obj = this.b;
					bool flag = false;
					try
					{
						num4 = (short)958447472;
						short num7 = num4;
						num4 = (short)2043592560;
						switch ((num7 == num4) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_101:
							num4 = (short)700055554;
							num6 = (int)((global::System.IntPtr)num4);
							break;
						default:
							num4 = (short)1190068224;
							if (num4 != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_D1;
							}
							break;
						}
						for (;;)
						{
							IL_B6:
							global::System.Collections.Generic.Queue<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> obj2;
							bool flag2;
							switch (num6)
							{
							case 0:
								try
								{
									global::System.Threading.Monitor.Enter(obj2, ref flag2);
									this.c.Enqueue(item);
									goto IL_324;
								}
								finally
								{
									num4 = (short)1331298305;
									num6 = (int)((global::System.IntPtr)num4);
									for (;;)
									{
										switch (num6)
										{
										case 0:
											goto IL_1D2;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_199;
											}
											continue;
										case 2:
											global::System.Threading.Monitor.Exit(obj2);
											num4 = (short)1315438592;
											num6 = (int)((global::System.IntPtr)num4);
											continue;
										}
										IL_199:
										if (!flag2)
										{
											break;
										}
										num4 = (short)403243010;
										num6 = (int)((global::System.IntPtr)num4);
									}
									IL_1D2:;
								}
								goto IL_1D5;
							case 1:
								try
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> obj3;
									global::System.Threading.Monitor.Enter(obj3, ref flag2);
									this.d.Remove(item);
									goto IL_201;
								}
								finally
								{
									num4 = (short)943259649;
									num6 = (int)((global::System.IntPtr)num4);
									for (;;)
									{
										switch (num6)
										{
										case 0:
											goto IL_2B4;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_27D;
											}
											continue;
										case 2:
										{
											global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> obj3;
											global::System.Threading.Monitor.Exit(obj3);
											num4 = (short)2621440;
											num6 = (int)((global::System.IntPtr)num4);
											continue;
										}
										}
										IL_27D:
										if (!flag2)
										{
											break;
										}
										num4 = (short)2140471298;
										num6 = (int)((global::System.IntPtr)num4);
									}
									IL_2B4:;
								}
								break;
							case 2:
								goto IL_1D5;
							case 3:
							{
								if (this.b.Contains(item))
								{
									goto IL_101;
								}
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> obj3 = this.d;
								flag2 = false;
								num4 = (short)906166273;
								num6 = (int)((global::System.IntPtr)num4);
								continue;
							}
							case 4:
								goto IL_201;
							}
							break;
							IL_1D5:
							this.b.Remove(item);
							num4 = (short)53411844;
							num6 = (int)((global::System.IntPtr)num4);
							continue;
							IL_201:
							obj2 = this.c;
							flag2 = false;
							num4 = (short)1975058432;
							num6 = (int)((global::System.IntPtr)num4);
						}
						IL_D1:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num4 = (short)1283981315;
						num6 = (int)((global::System.IntPtr)num4);
						goto IL_B6;
					}
					finally
					{
						num4 = (short)132579329;
						num6 = (int)((global::System.IntPtr)num4);
						for (;;)
						{
							switch (num6)
							{
							case 0:
								goto IL_321;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_2E9;
								}
								continue;
							case 2:
								global::System.Threading.Monitor.Exit(obj);
								num4 = (short)2036400128;
								num6 = (int)((global::System.IntPtr)num4);
								continue;
							}
							IL_2E9:
							if (!flag)
							{
								break;
							}
							num4 = (short)423297026;
							num6 = (int)((global::System.IntPtr)num4);
						}
						IL_321:;
					}
					IL_324:
					num4 = (short)2012872705;
					if (num4 != 0)
					{
					}
					this.a();
					return;
				}
				}
			});
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0002B670 File Offset: 0x00029870
		private void a()
		{
			short num = (short)378011649;
			if (num != 0)
			{
			}
			num = (short)168624128;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> obj = this.b;
				bool flag = false;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> obj2 = this.d;
					bool flag2 = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_97;
						}
						for (;;)
						{
							IL_6C:
							global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp batchOp;
							switch (num2)
							{
							case 0:
								if (this.b.Count >= 1)
								{
									num = (short)430178308;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1A4;
							case 1:
								if (this.d.Count == 0)
								{
									num = (short)168886280;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								batchOp = this.d[0];
								num = (short)352976898;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (!batchOp.IsSafe)
								{
									num = (short)346226695;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1A4;
							case 3:
								goto IL_F2;
							case 4:
								num = (short)990838790;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_1DD;
							case 6:
								goto IL_10F;
							case 7:
								num = (short)167837696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								num = (short)2114453507;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_97;
							IL_1A4:
							this.d.RemoveAt(0);
							this.b.Add(batchOp);
							batchOp.RunWorkerAsync();
							num = (short)855310341;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_F2:
						IL_10F:
						IL_1DD:
						goto IL_30A;
						IL_97:
						global::System.Threading.Monitor.Enter(obj2, ref flag2);
						num = (short)1731985409;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_6C;
					}
					finally
					{
						num = (short)516816898;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_24B;
							case 1:
								global::System.Threading.Monitor.Exit(obj2);
								num = (short)1554120704;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_214;
								}
								continue;
							}
							IL_214:
							if (!flag2)
							{
								break;
							}
							num = (short)1130627073;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_24B:;
					}
				}
				finally
				{
					num = (short)1166082050;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_307;
						case 1:
						{
							num = (short)1801974773;
							short num3 = num;
							num = (short)1833038837;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)873529344;
								if (num != 0)
								{
								}
								global::System.Threading.Monitor.Exit(obj);
								break;
							}
							num = (short)1403453440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_280;
							}
							continue;
						}
						IL_280:
						if (!flag)
						{
							break;
						}
						num = (short)1875443713;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_307:;
				}
				IL_30A:
				num = (short)1928069120;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0002B9E4 File Offset: 0x00029BE4
		// Note: this type is marked as 'beforefieldinit'.
		static BatchOpManager()
		{
			short num = (short)16528556;
			short num2 = num;
			num = (short)1956656300;
			switch (num2 == num)
			{
			}
			num = (short)1485766657;
			if (num != 0)
			{
			}
			num = (short)285016064;
			short num3 = num;
			num = (short)898433024;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpManager.a = new global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpManager();
		}

		// Token: 0x04000086 RID: 134
		private static readonly global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpManager a;

		// Token: 0x04000087 RID: 135
		private readonly global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> b = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp>();

		// Token: 0x04000088 RID: 136
		private readonly global::System.Collections.Generic.Queue<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> c = new global::System.Collections.Generic.Queue<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp>();

		// Token: 0x04000089 RID: 137
		private readonly global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> d = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp>();

		// Token: 0x0400008A RID: 138
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp> e;
	}
}
