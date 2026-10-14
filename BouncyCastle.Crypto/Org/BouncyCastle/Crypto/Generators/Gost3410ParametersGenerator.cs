using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000472 RID: 1138
	public class Gost3410ParametersGenerator
	{
		// Token: 0x06002BD7 RID: 11223 RVA: 0x000BC013 File Offset: 0x000BA213
		public void Init(int size, int typeProcedure, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			this.size = size;
			this.typeproc = typeProcedure;
			this.init_random = random;
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x000BC02C File Offset: 0x000BA22C
		private int procedure_A(int x0, int c, global::Org.BouncyCastle.Math.BigInteger[] pq, int size)
		{
			while (x0 < 0 || x0 > 65536)
			{
				x0 = this.init_random.NextInt() / 32768;
			}
			while (c < 0 || c > 65536 || c / 2 == 0)
			{
				c = this.init_random.NextInt() / 32768 + 1;
			}
			global::Org.BouncyCastle.Math.BigInteger C = global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)c);
			global::Org.BouncyCastle.Math.BigInteger constA16 = global::Org.BouncyCastle.Math.BigInteger.ValueOf(19381L);
			global::Org.BouncyCastle.Math.BigInteger[] y = new global::Org.BouncyCastle.Math.BigInteger[]
			{
				global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)x0)
			};
			int[] t = new int[]
			{
				size
			};
			int s = 0;
			int i = 0;
			while (t[i] >= 17)
			{
				int[] tmp_t = new int[t.Length + 1];
				global::System.Array.Copy(t, 0, tmp_t, 0, t.Length);
				t = new int[tmp_t.Length];
				global::System.Array.Copy(tmp_t, 0, t, 0, tmp_t.Length);
				t[i + 1] = t[i] / 2;
				s = i + 1;
				i++;
			}
			global::Org.BouncyCastle.Math.BigInteger[] p = new global::Org.BouncyCastle.Math.BigInteger[s + 1];
			p[s] = new global::Org.BouncyCastle.Math.BigInteger("8003", 16);
			int j = s - 1;
			for (int k = 0; k < s; k++)
			{
				int rm = t[j] / 16;
				for (;;)
				{
					global::Org.BouncyCastle.Math.BigInteger[] tmp_y = new global::Org.BouncyCastle.Math.BigInteger[y.Length];
					global::System.Array.Copy(y, 0, tmp_y, 0, y.Length);
					y = new global::Org.BouncyCastle.Math.BigInteger[rm + 1];
					global::System.Array.Copy(tmp_y, 0, y, 0, tmp_y.Length);
					for (int l = 0; l < rm; l++)
					{
						y[l + 1] = y[l].Multiply(constA16).Add(C).Mod(global::Org.BouncyCastle.Math.BigInteger.Two.Pow(16));
					}
					global::Org.BouncyCastle.Math.BigInteger Ym = global::Org.BouncyCastle.Math.BigInteger.Zero;
					for (int m = 0; m < rm; m++)
					{
						Ym = Ym.Add(y[m].ShiftLeft(16 * m));
					}
					y[0] = y[rm];
					global::Org.BouncyCastle.Math.BigInteger N = global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(t[j] - 1).Divide(p[j + 1]).Add(Ym.ShiftLeft(t[j] - 1).Divide(p[j + 1].ShiftLeft(16 * rm)));
					if (N.TestBit(0))
					{
						N = N.Add(global::Org.BouncyCastle.Math.BigInteger.One);
					}
					for (;;)
					{
						global::Org.BouncyCastle.Math.BigInteger NByLastP = N.Multiply(p[j + 1]);
						if (NByLastP.BitLength > t[j])
						{
							break;
						}
						p[j] = NByLastP.Add(global::Org.BouncyCastle.Math.BigInteger.One);
						if (global::Org.BouncyCastle.Math.BigInteger.Two.ModPow(NByLastP, p[j]).CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) == 0 && global::Org.BouncyCastle.Math.BigInteger.Two.ModPow(N, p[j]).CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) != 0)
						{
							goto IL_27C;
						}
						N = N.Add(global::Org.BouncyCastle.Math.BigInteger.Two);
					}
				}
				IL_27C:
				if (--j < 0)
				{
					pq[0] = p[0];
					pq[1] = p[1];
					return y[0].IntValue;
				}
			}
			return y[0].IntValue;
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x000BC2F0 File Offset: 0x000BA4F0
		private long procedure_Aa(long x0, long c, global::Org.BouncyCastle.Math.BigInteger[] pq, int size)
		{
			while (x0 < 0L || x0 > 4294967296L)
			{
				x0 = (long)(this.init_random.NextInt() * 2);
			}
			while (c < 0L || c > 4294967296L || c / 2L == 0L)
			{
				c = (long)(this.init_random.NextInt() * 2 + 1);
			}
			global::Org.BouncyCastle.Math.BigInteger C = global::Org.BouncyCastle.Math.BigInteger.ValueOf(c);
			global::Org.BouncyCastle.Math.BigInteger constA32 = global::Org.BouncyCastle.Math.BigInteger.ValueOf(97781173L);
			global::Org.BouncyCastle.Math.BigInteger[] y = new global::Org.BouncyCastle.Math.BigInteger[]
			{
				global::Org.BouncyCastle.Math.BigInteger.ValueOf(x0)
			};
			int[] t = new int[]
			{
				size
			};
			int s = 0;
			int i = 0;
			while (t[i] >= 33)
			{
				int[] tmp_t = new int[t.Length + 1];
				global::System.Array.Copy(t, 0, tmp_t, 0, t.Length);
				t = new int[tmp_t.Length];
				global::System.Array.Copy(tmp_t, 0, t, 0, tmp_t.Length);
				t[i + 1] = t[i] / 2;
				s = i + 1;
				i++;
			}
			global::Org.BouncyCastle.Math.BigInteger[] p = new global::Org.BouncyCastle.Math.BigInteger[s + 1];
			p[s] = new global::Org.BouncyCastle.Math.BigInteger("8000000B", 16);
			int j = s - 1;
			for (int k = 0; k < s; k++)
			{
				int rm = t[j] / 32;
				for (;;)
				{
					global::Org.BouncyCastle.Math.BigInteger[] tmp_y = new global::Org.BouncyCastle.Math.BigInteger[y.Length];
					global::System.Array.Copy(y, 0, tmp_y, 0, y.Length);
					y = new global::Org.BouncyCastle.Math.BigInteger[rm + 1];
					global::System.Array.Copy(tmp_y, 0, y, 0, tmp_y.Length);
					for (int l = 0; l < rm; l++)
					{
						y[l + 1] = y[l].Multiply(constA32).Add(C).Mod(global::Org.BouncyCastle.Math.BigInteger.Two.Pow(32));
					}
					global::Org.BouncyCastle.Math.BigInteger Ym = global::Org.BouncyCastle.Math.BigInteger.Zero;
					for (int m = 0; m < rm; m++)
					{
						Ym = Ym.Add(y[m].ShiftLeft(32 * m));
					}
					y[0] = y[rm];
					global::Org.BouncyCastle.Math.BigInteger N = global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(t[j] - 1).Divide(p[j + 1]).Add(Ym.ShiftLeft(t[j] - 1).Divide(p[j + 1].ShiftLeft(32 * rm)));
					if (N.TestBit(0))
					{
						N = N.Add(global::Org.BouncyCastle.Math.BigInteger.One);
					}
					for (;;)
					{
						global::Org.BouncyCastle.Math.BigInteger NByLastP = N.Multiply(p[j + 1]);
						if (NByLastP.BitLength > t[j])
						{
							break;
						}
						p[j] = NByLastP.Add(global::Org.BouncyCastle.Math.BigInteger.One);
						if (global::Org.BouncyCastle.Math.BigInteger.Two.ModPow(NByLastP, p[j]).CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) == 0 && global::Org.BouncyCastle.Math.BigInteger.Two.ModPow(N, p[j]).CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) != 0)
						{
							goto IL_27F;
						}
						N = N.Add(global::Org.BouncyCastle.Math.BigInteger.Two);
					}
				}
				IL_27F:
				if (--j < 0)
				{
					pq[0] = p[0];
					pq[1] = p[1];
					return y[0].LongValue;
				}
			}
			return y[0].LongValue;
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x000BC5B4 File Offset: 0x000BA7B4
		private void procedure_B(int x0, int c, global::Org.BouncyCastle.Math.BigInteger[] pq)
		{
			while (x0 < 0 || x0 > 65536)
			{
				x0 = this.init_random.NextInt() / 32768;
			}
			while (c < 0 || c > 65536 || c / 2 == 0)
			{
				c = this.init_random.NextInt() / 32768 + 1;
			}
			global::Org.BouncyCastle.Math.BigInteger[] qp = new global::Org.BouncyCastle.Math.BigInteger[2];
			global::Org.BouncyCastle.Math.BigInteger C = global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)c);
			global::Org.BouncyCastle.Math.BigInteger constA16 = global::Org.BouncyCastle.Math.BigInteger.ValueOf(19381L);
			x0 = this.procedure_A(x0, c, qp, 256);
			global::Org.BouncyCastle.Math.BigInteger q = qp[0];
			x0 = this.procedure_A(x0, c, qp, 512);
			global::Org.BouncyCastle.Math.BigInteger Q = qp[0];
			global::Org.BouncyCastle.Math.BigInteger[] y = new global::Org.BouncyCastle.Math.BigInteger[65];
			y[0] = global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)x0);
			global::Org.BouncyCastle.Math.BigInteger qQ = q.Multiply(Q);
			global::Org.BouncyCastle.Math.BigInteger p;
			for (;;)
			{
				for (int i = 0; i < 64; i++)
				{
					y[i + 1] = y[i].Multiply(constA16).Add(C).Mod(global::Org.BouncyCastle.Math.BigInteger.Two.Pow(16));
				}
				global::Org.BouncyCastle.Math.BigInteger Y = global::Org.BouncyCastle.Math.BigInteger.Zero;
				for (int j = 0; j < 64; j++)
				{
					Y = Y.Add(y[j].ShiftLeft(16 * j));
				}
				y[0] = y[64];
				global::Org.BouncyCastle.Math.BigInteger N = global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(1023).Divide(qQ).Add(Y.ShiftLeft(1023).Divide(qQ.ShiftLeft(1024)));
				if (N.TestBit(0))
				{
					N = N.Add(global::Org.BouncyCastle.Math.BigInteger.One);
				}
				for (;;)
				{
					global::Org.BouncyCastle.Math.BigInteger qQN = qQ.Multiply(N);
					if (qQN.BitLength > 1024)
					{
						break;
					}
					p = qQN.Add(global::Org.BouncyCastle.Math.BigInteger.One);
					if (global::Org.BouncyCastle.Math.BigInteger.Two.ModPow(qQN, p).CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) == 0 && global::Org.BouncyCastle.Math.BigInteger.Two.ModPow(q.Multiply(N), p).CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) != 0)
					{
						goto Block_11;
					}
					N = N.Add(global::Org.BouncyCastle.Math.BigInteger.Two);
				}
			}
			Block_11:
			pq[0] = p;
			pq[1] = q;
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x000BC7B4 File Offset: 0x000BA9B4
		private void procedure_Bb(long x0, long c, global::Org.BouncyCastle.Math.BigInteger[] pq)
		{
			while (x0 < 0L || x0 > 4294967296L)
			{
				x0 = (long)(this.init_random.NextInt() * 2);
			}
			while (c < 0L || c > 4294967296L || c / 2L == 0L)
			{
				c = (long)(this.init_random.NextInt() * 2 + 1);
			}
			global::Org.BouncyCastle.Math.BigInteger[] qp = new global::Org.BouncyCastle.Math.BigInteger[2];
			global::Org.BouncyCastle.Math.BigInteger C = global::Org.BouncyCastle.Math.BigInteger.ValueOf(c);
			global::Org.BouncyCastle.Math.BigInteger constA32 = global::Org.BouncyCastle.Math.BigInteger.ValueOf(97781173L);
			x0 = this.procedure_Aa(x0, c, qp, 256);
			global::Org.BouncyCastle.Math.BigInteger q = qp[0];
			x0 = this.procedure_Aa(x0, c, qp, 512);
			global::Org.BouncyCastle.Math.BigInteger Q = qp[0];
			global::Org.BouncyCastle.Math.BigInteger[] y = new global::Org.BouncyCastle.Math.BigInteger[33];
			y[0] = global::Org.BouncyCastle.Math.BigInteger.ValueOf(x0);
			global::Org.BouncyCastle.Math.BigInteger qQ = q.Multiply(Q);
			global::Org.BouncyCastle.Math.BigInteger p;
			for (;;)
			{
				for (int i = 0; i < 32; i++)
				{
					y[i + 1] = y[i].Multiply(constA32).Add(C).Mod(global::Org.BouncyCastle.Math.BigInteger.Two.Pow(32));
				}
				global::Org.BouncyCastle.Math.BigInteger Y = global::Org.BouncyCastle.Math.BigInteger.Zero;
				for (int j = 0; j < 32; j++)
				{
					Y = Y.Add(y[j].ShiftLeft(32 * j));
				}
				y[0] = y[32];
				global::Org.BouncyCastle.Math.BigInteger N = global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(1023).Divide(qQ).Add(Y.ShiftLeft(1023).Divide(qQ.ShiftLeft(1024)));
				if (N.TestBit(0))
				{
					N = N.Add(global::Org.BouncyCastle.Math.BigInteger.One);
				}
				for (;;)
				{
					global::Org.BouncyCastle.Math.BigInteger qQN = qQ.Multiply(N);
					if (qQN.BitLength > 1024)
					{
						break;
					}
					p = qQN.Add(global::Org.BouncyCastle.Math.BigInteger.One);
					if (global::Org.BouncyCastle.Math.BigInteger.Two.ModPow(qQN, p).CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) == 0 && global::Org.BouncyCastle.Math.BigInteger.Two.ModPow(q.Multiply(N), p).CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) != 0)
					{
						goto Block_11;
					}
					N = N.Add(global::Org.BouncyCastle.Math.BigInteger.Two);
				}
			}
			Block_11:
			pq[0] = p;
			pq[1] = q;
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x000BC9B8 File Offset: 0x000BABB8
		private global::Org.BouncyCastle.Math.BigInteger procedure_C(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q)
		{
			global::Org.BouncyCastle.Math.BigInteger pSub = p.Subtract(global::Org.BouncyCastle.Math.BigInteger.One);
			global::Org.BouncyCastle.Math.BigInteger pSub1Divq = pSub.Divide(q);
			global::Org.BouncyCastle.Math.BigInteger a;
			for (;;)
			{
				global::Org.BouncyCastle.Math.BigInteger d = new global::Org.BouncyCastle.Math.BigInteger(p.BitLength, this.init_random);
				if (d.CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) > 0 && d.CompareTo(pSub) < 0)
				{
					a = d.ModPow(pSub1Divq, p);
					if (a.CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) != 0)
					{
						break;
					}
				}
			}
			return a;
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x000BCA1C File Offset: 0x000BAC1C
		public global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters GenerateParameters()
		{
			global::Org.BouncyCastle.Math.BigInteger[] pq = new global::Org.BouncyCastle.Math.BigInteger[2];
			int num;
			global::Org.BouncyCastle.Math.BigInteger p;
			global::Org.BouncyCastle.Math.BigInteger q;
			global::Org.BouncyCastle.Math.BigInteger a;
			if (this.typeproc == 1)
			{
				int x0 = this.init_random.NextInt();
				int c = this.init_random.NextInt();
				num = this.size;
				if (num != 512)
				{
					if (num != 1024)
					{
						throw new global::System.ArgumentException("Ooops! key size 512 or 1024 bit.");
					}
					this.procedure_B(x0, c, pq);
				}
				else
				{
					this.procedure_A(x0, c, pq, 512);
				}
				p = pq[0];
				q = pq[1];
				a = this.procedure_C(p, q);
				return new global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters(p, q, a, new global::Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters(x0, c));
			}
			long x0L = this.init_random.NextLong();
			long cL = this.init_random.NextLong();
			num = this.size;
			if (num != 512)
			{
				if (num != 1024)
				{
					throw new global::System.InvalidOperationException("Ooops! key size 512 or 1024 bit.");
				}
				this.procedure_Bb(x0L, cL, pq);
			}
			else
			{
				this.procedure_Aa(x0L, cL, pq, 512);
			}
			p = pq[0];
			q = pq[1];
			a = this.procedure_C(p, q);
			return new global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters(p, q, a, new global::Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters(x0L, cL));
		}

		// Token: 0x04001233 RID: 4659
		private int size;

		// Token: 0x04001234 RID: 4660
		private int typeproc;

		// Token: 0x04001235 RID: 4661
		private global::Org.BouncyCastle.Security.SecureRandom init_random;
	}
}
