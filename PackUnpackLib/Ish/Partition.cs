using System;
using System.Collections.Generic;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000039 RID: 57
	public class Partition
	{
		// Token: 0x06000246 RID: 582 RVA: 0x000356FC File Offset: 0x000338FC
		internal Partition(global::Motorola.Acp.PackUnpack.Ish.PartitionType A_0, global::Motorola.Acp.PackUnpack.Ish.AccessRights A_1) : this(A_0, A_1, 0)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00035714 File Offset: 0x00033914
		internal Partition(global::Motorola.Acp.PackUnpack.Ish.PartitionType A_0, global::Motorola.Acp.PackUnpack.Ish.AccessRights A_1, int A_2)
		{
			int a_ = 9;
			base..ctor();
			if (A_2 < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쎟쎡풣장쮧쎩\ud8ab힭", a_));
			}
			this.a(A_0, A_1);
			this.f = new global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream(new byte[A_2], 0, A_2, true, false);
			this.f.SetLength(0L);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00035774 File Offset: 0x00033974
		public Partition(global::Motorola.Acp.PackUnpack.Ish.PartitionType partitionType, global::Motorola.Acp.PackUnpack.Ish.AccessRights accessRights, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream image)
		{
			int a_ = 15;
			base..ctor();
			this.a(partitionType, accessRights);
			if (image == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쾥얧쮩쮫쮭", a_));
			}
			this.f = image;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000357B8 File Offset: 0x000339B8
		private void a(global::Motorola.Acp.PackUnpack.Ish.PartitionType A_0, global::Motorola.Acp.PackUnpack.Ish.AccessRights A_1)
		{
			int a_ = 9;
			short num;
			for (;;)
			{
				IL_09:
				num = (short)1414922242;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_93;
					case 1:
						goto IL_166;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3F;
						}
						continue;
					case 3:
					{
						num = (short)806740300;
						short num3 = num;
						num = (short)594534732;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)433258496;
							if (num != 0)
							{
							}
							if (!global::System.Enum.IsDefined(typeof(global::Motorola.Acp.PackUnpack.Ish.AccessRights), A_1))
							{
								num = (short)722468865;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17F;
						}
						break;
					}
					}
					IL_3F:
					if (!global::System.Enum.IsDefined(typeof(global::Motorola.Acp.PackUnpack.Ish.PartitionType), A_0))
					{
						num = (short)2096431104;
						short num4 = num;
						num = (short)1022361600;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)904855555;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
			IL_93:
			num = (short)1214840833;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("킟쎡횣튥솧\udea9얫솭\udeaf춳욵\uddb7", a_));
			IL_166:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솟송잣쎥\udba7\ud9a9ﺫ잭힯\udab1삳억", a_));
			IL_17F:
			this.a = null;
			this.c = A_0;
			this.b = A_1;
			this.d = new global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection(this);
			this.e = new global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection(this);
			this.g = new global::Motorola.Acp.PackUnpack.Ish.IshTypeIdTracker();
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0003597C File Offset: 0x00033B7C
		public global::Motorola.Acp.PackUnpack.Ish.IshTypeIdTracker IdTracker
		{
			get
			{
				short num = (short)358461407;
				short num2 = num;
				num = (short)1130999775;
				switch (num2 == num)
				{
				}
				num = (short)502792192;
				if (num != 0)
				{
				}
				num = (short)1308426240;
				short num3 = num;
				num = (short)2030174209;
				if (num != 0)
				{
				}
				return this.g;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00035A2C File Offset: 0x00033C2C
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00035AD8 File Offset: 0x00033CD8
		public global::Motorola.Acp.PackUnpack.Ish.Codeplug Parent
		{
			get
			{
				short num = (short)1011006480;
				short num2 = num;
				num = (short)1309522960;
				switch (num2 == num)
				{
				}
				num = (short)1577713664;
				if (num != 0)
				{
				}
				num = (short)269025280;
				short num3 = num;
				num = (short)99352577;
				if (num != 0)
				{
				}
				return this.a;
			}
			internal set
			{
				short num = (short)1143169078;
				short num2 = num;
				num = (short)1957650486;
				switch (num2 == num)
				{
				}
				num = (short)1665728513;
				if (num != 0)
				{
				}
				num = (short)246808576;
				short num3 = num;
				num = (short)1993670656;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00035B88 File Offset: 0x00033D88
		public global::Motorola.Acp.PackUnpack.Ish.PartitionType PartitionType
		{
			get
			{
				short num = (short)528504749;
				short num2 = num;
				num = (short)1597396909;
				switch (num2 == num)
				{
				}
				num = (short)1644036097;
				if (num != 0)
				{
				}
				num = (short)71434240;
				short num3 = num;
				num = (short)581500928;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00035C38 File Offset: 0x00033E38
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00035CE8 File Offset: 0x00033EE8
		public global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream Image
		{
			get
			{
				short num = (short)1071893667;
				short num2 = num;
				num = (short)2028260515;
				switch (num2 == num)
				{
				}
				num = (short)324665344;
				if (num != 0)
				{
				}
				num = (short)1674313728;
				short num3 = num;
				num = (short)303628289;
				if (num != 0)
				{
				}
				return this.f;
			}
			internal set
			{
				short num = (short)404393249;
				short num2 = num;
				num = (short)357403937;
				switch (num2 == num)
				{
				}
				num = (short)1199833088;
				if (num != 0)
				{
				}
				num = (short)709427200;
				short num3 = num;
				num = (short)1379139585;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00035D94 File Offset: 0x00033F94
		internal global::Motorola.Acp.PackUnpack.Ish.AccessRights AccessRights
		{
			get
			{
				short num = (short)1169817601;
				if (num != 0)
				{
				}
				num = (short)820210274;
				short num2 = num;
				num = (short)730360418;
				switch (num2 == num)
				{
				}
				num = (short)622133248;
				short num3 = num;
				num = (short)122486784;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00035E48 File Offset: 0x00034048
		internal global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.IshType> Types
		{
			get
			{
				short num = (short)201489924;
				short num2 = num;
				num = (short)2053996036;
				switch (num2 == num)
				{
				}
				num = (short)1509294080;
				if (num != 0)
				{
				}
				num = (short)524877824;
				short num3 = num;
				num = (short)578551809;
				if (num != 0)
				{
				}
				global::Motorola.Acp.PackUnpack.Ish.Partition.a a = new global::Motorola.Acp.PackUnpack.Ish.Partition.a(-2);
				a.d = this;
				return a;
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00035F00 File Offset: 0x00034100
		internal global::Motorola.Acp.PackUnpack.Ish.IshType a(int A_0)
		{
			short num = (short)714342400;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout> enumerator = this.e.GetEnumerator();
				global::Motorola.Acp.PackUnpack.Ish.IshType result;
				try
				{
					num = (short)632029187;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)729153538;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_210;
									case 1:
										num = (short)1080950784;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_15F;
										}
										continue;
									case 3:
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1520959489;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Acp.PackUnpack.Ish.IshType ishType = enumerator2.Current;
										num = (short)1516503044;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
										if (ishType.Value == A_0)
										{
											num = (short)859439110;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										goto IL_178;
									case 6:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
										result = ishType;
										num = (short)685047813;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_1BA:
									num = (short)2093285379;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_15F:
									goto IL_1BA;
								}
								IL_178:
								return result;
								IL_210:
								break;
							}
							finally
							{
								num = (short)553517057;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator2;
									switch (num2)
									{
									case 0:
										goto IL_27E;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_247;
										}
										continue;
									case 2:
										enumerator2.Dispose();
										num = (short)626393088;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_247:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1683947522;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_27E:
								num = (short)2052394721;
								short num3 = num;
								num = (short)389353185;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_27E;
								default:
									num = (short)1596981248;
									if (num != 0)
									{
									}
									break;
								}
							}
							goto IL_2CB;
						case 1:
							goto IL_2E4;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)710213636;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator2 = enumerator.Current.IshTypes.GetEnumerator();
							num = (short)220069888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_B6;
							}
							continue;
						case 4:
							goto IL_2CB;
						}
						IL_B8:
						num = (short)1857683458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B6:
						goto IL_B8;
						IL_2CB:
						num = (short)1319829505;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2E4:
					goto IL_2B;
				}
				finally
				{
					num = (short)2054029313;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_350;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_31B;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)1473380352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_31B:
						if (enumerator == null)
						{
							break;
						}
						num = (short)679018498;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_350:;
				}
				return result;
				IL_2B:
				num = (short)1487667201;
				if (num != 0)
				{
				}
				num = (short)353632256;
				short num4 = num;
				return null;
			}
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00036298 File Offset: 0x00034498
		internal global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection Items
		{
			get
			{
				short num = (short)1162247353;
				short num2 = num;
				num = (short)574127289;
				switch (num2 == num)
				{
				}
				num = (short)1409744897;
				if (num != 0)
				{
				}
				num = (short)356122624;
				short num3 = num;
				num = (short)1351942144;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00036348 File Offset: 0x00034548
		public global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection Layouts
		{
			get
			{
				short num = (short)284855603;
				short num2 = num;
				num = (short)1242074419;
				switch (num2 == num)
				{
				}
				num = (short)514129920;
				if (num != 0)
				{
				}
				num = (short)1122369536;
				short num3 = num;
				num = (short)418971649;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x040000C4 RID: 196
		private global::Motorola.Acp.PackUnpack.Ish.Codeplug a;

		// Token: 0x040000C5 RID: 197
		private global::Motorola.Acp.PackUnpack.Ish.AccessRights b;

		// Token: 0x040000C6 RID: 198
		private global::Motorola.Acp.PackUnpack.Ish.PartitionType c;

		// Token: 0x040000C7 RID: 199
		private global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection d;

		// Token: 0x040000C8 RID: 200
		private global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection e;

		// Token: 0x040000C9 RID: 201
		private global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream f;

		// Token: 0x040000CA RID: 202
		private global::Motorola.Acp.PackUnpack.Ish.IshTypeIdTracker g;
	}
}
