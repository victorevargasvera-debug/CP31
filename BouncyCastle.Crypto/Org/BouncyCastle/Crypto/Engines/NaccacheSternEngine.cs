using System;
using System.Collections;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004A3 RID: 1187
	public class NaccacheSternEngine : global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher
	{
		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06002DCA RID: 11722 RVA: 0x000CE477 File Offset: 0x000CC677
		public string AlgorithmName
		{
			get
			{
				return "NaccacheStern";
			}
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x000CE480 File Offset: 0x000CC680
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forEncryption = forEncryption;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				parameters = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters).Parameters;
			}
			this.key = (global::Org.BouncyCastle.Crypto.Parameters.NaccacheSternKeyParameters)parameters;
			if (!this.forEncryption)
			{
				global::Org.BouncyCastle.Crypto.Parameters.NaccacheSternPrivateKeyParameters priv = (global::Org.BouncyCastle.Crypto.Parameters.NaccacheSternPrivateKeyParameters)this.key;
				global::System.Collections.IList primes = priv.SmallPrimesList;
				this.lookup = new global::System.Collections.IList[primes.Count];
				for (int i = 0; i < primes.Count; i++)
				{
					global::Org.BouncyCastle.Math.BigInteger actualPrime = (global::Org.BouncyCastle.Math.BigInteger)primes[i];
					int actualPrimeValue = actualPrime.IntValue;
					this.lookup[i] = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(actualPrimeValue);
					this.lookup[i].Add(global::Org.BouncyCastle.Math.BigInteger.One);
					global::Org.BouncyCastle.Math.BigInteger accJ = global::Org.BouncyCastle.Math.BigInteger.Zero;
					for (int j = 1; j < actualPrimeValue; j++)
					{
						accJ = accJ.Add(priv.PhiN);
						global::Org.BouncyCastle.Math.BigInteger comp = accJ.Divide(actualPrime);
						this.lookup[i].Add(priv.G.ModPow(comp, priv.Modulus));
					}
				}
			}
		}

		// Token: 0x17000632 RID: 1586
		// (set) Token: 0x06002DCC RID: 11724 RVA: 0x000CE584 File Offset: 0x000CC784
		[global::System.Obsolete("Remove: no longer used")]
		public virtual bool Debug
		{
			set
			{
			}
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x000CE586 File Offset: 0x000CC786
		public virtual int GetInputBlockSize()
		{
			if (this.forEncryption)
			{
				return (this.key.LowerSigmaBound + 7) / 8 - 1;
			}
			return this.key.Modulus.BitLength / 8 + 1;
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x000CE5B6 File Offset: 0x000CC7B6
		public virtual int GetOutputBlockSize()
		{
			if (this.forEncryption)
			{
				return this.key.Modulus.BitLength / 8 + 1;
			}
			return (this.key.LowerSigmaBound + 7) / 8 - 1;
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x000CE5E8 File Offset: 0x000CC7E8
		public virtual byte[] ProcessBlock(byte[] inBytes, int inOff, int length)
		{
			if (this.key == null)
			{
				throw new global::System.InvalidOperationException("NaccacheStern engine not initialised");
			}
			if (length > this.GetInputBlockSize() + 1)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("input too large for Naccache-Stern cipher.\n");
			}
			if (!this.forEncryption && length < this.GetInputBlockSize())
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("BlockLength does not match modulus for Naccache-Stern cipher.\n");
			}
			global::Org.BouncyCastle.Math.BigInteger input = new global::Org.BouncyCastle.Math.BigInteger(1, inBytes, inOff, length);
			byte[] output;
			if (this.forEncryption)
			{
				output = this.Encrypt(input);
			}
			else
			{
				global::System.Collections.IList plain = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				global::Org.BouncyCastle.Crypto.Parameters.NaccacheSternPrivateKeyParameters priv = (global::Org.BouncyCastle.Crypto.Parameters.NaccacheSternPrivateKeyParameters)this.key;
				global::System.Collections.IList primes = priv.SmallPrimesList;
				for (int i = 0; i < primes.Count; i++)
				{
					global::Org.BouncyCastle.Math.BigInteger exp = input.ModPow(priv.PhiN.Divide((global::Org.BouncyCastle.Math.BigInteger)primes[i]), priv.Modulus);
					global::System.Collections.IList al = this.lookup[i];
					if (this.lookup[i].Count != ((global::Org.BouncyCastle.Math.BigInteger)primes[i]).IntValue)
					{
						throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException(string.Concat(new string[]
						{
							"Error in lookup Array for ",
							((global::Org.BouncyCastle.Math.BigInteger)primes[i]).IntValue.ToString(),
							": Size mismatch. Expected ArrayList with length ",
							((global::Org.BouncyCastle.Math.BigInteger)primes[i]).IntValue.ToString(),
							" but found ArrayList of length ",
							this.lookup[i].Count.ToString()
						}));
					}
					int lookedup = al.IndexOf(exp);
					if (lookedup == -1)
					{
						throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("Lookup failed");
					}
					plain.Add(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)lookedup));
				}
				output = global::Org.BouncyCastle.Crypto.Engines.NaccacheSternEngine.chineseRemainder(plain, primes).ToByteArray();
			}
			return output;
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x000CE7A4 File Offset: 0x000CC9A4
		public virtual byte[] Encrypt(global::Org.BouncyCastle.Math.BigInteger plain)
		{
			byte[] output = new byte[this.key.Modulus.BitLength / 8 + 1];
			byte[] tmp = this.key.G.ModPow(plain, this.key.Modulus).ToByteArray();
			global::System.Array.Copy(tmp, 0, output, output.Length - tmp.Length, tmp.Length);
			return output;
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x000CE800 File Offset: 0x000CCA00
		public virtual byte[] AddCryptedBlocks(byte[] block1, byte[] block2)
		{
			if (this.forEncryption)
			{
				if (block1.Length > this.GetOutputBlockSize() || block2.Length > this.GetOutputBlockSize())
				{
					throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("BlockLength too large for simple addition.\n");
				}
			}
			else if (block1.Length > this.GetInputBlockSize() || block2.Length > this.GetInputBlockSize())
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("BlockLength too large for simple addition.\n");
			}
			global::Org.BouncyCastle.Math.BigInteger bigInteger = new global::Org.BouncyCastle.Math.BigInteger(1, block1);
			global::Org.BouncyCastle.Math.BigInteger m2Crypt = new global::Org.BouncyCastle.Math.BigInteger(1, block2);
			global::Org.BouncyCastle.Math.BigInteger bigInteger2 = bigInteger.Multiply(m2Crypt).Mod(this.key.Modulus);
			byte[] output = new byte[this.key.Modulus.BitLength / 8 + 1];
			byte[] m1m2CryptBytes = bigInteger2.ToByteArray();
			global::System.Array.Copy(m1m2CryptBytes, 0, output, output.Length - m1m2CryptBytes.Length, m1m2CryptBytes.Length);
			return output;
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x000CE8B0 File Offset: 0x000CCAB0
		public virtual byte[] ProcessData(byte[] data)
		{
			if (data.Length > this.GetInputBlockSize())
			{
				int inBlocksize = this.GetInputBlockSize();
				int outBlocksize = this.GetOutputBlockSize();
				int datapos = 0;
				int retpos = 0;
				byte[] retval = new byte[(data.Length / inBlocksize + 1) * outBlocksize];
				while (datapos < data.Length)
				{
					byte[] tmp;
					if (datapos + inBlocksize < data.Length)
					{
						tmp = this.ProcessBlock(data, datapos, inBlocksize);
						datapos += inBlocksize;
					}
					else
					{
						tmp = this.ProcessBlock(data, datapos, data.Length - datapos);
						datapos += data.Length - datapos;
					}
					if (tmp == null)
					{
						throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("cipher returned null");
					}
					tmp.CopyTo(retval, retpos);
					retpos += tmp.Length;
				}
				byte[] ret = new byte[retpos];
				global::System.Array.Copy(retval, 0, ret, 0, retpos);
				return ret;
			}
			return this.ProcessBlock(data, 0, data.Length);
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x000CE96C File Offset: 0x000CCB6C
		private static global::Org.BouncyCastle.Math.BigInteger chineseRemainder(global::System.Collections.IList congruences, global::System.Collections.IList primes)
		{
			global::Org.BouncyCastle.Math.BigInteger retval = global::Org.BouncyCastle.Math.BigInteger.Zero;
			global::Org.BouncyCastle.Math.BigInteger all = global::Org.BouncyCastle.Math.BigInteger.One;
			for (int i = 0; i < primes.Count; i++)
			{
				all = all.Multiply((global::Org.BouncyCastle.Math.BigInteger)primes[i]);
			}
			for (int j = 0; j < primes.Count; j++)
			{
				global::Org.BouncyCastle.Math.BigInteger a = (global::Org.BouncyCastle.Math.BigInteger)primes[j];
				global::Org.BouncyCastle.Math.BigInteger bigInteger = all.Divide(a);
				global::Org.BouncyCastle.Math.BigInteger b2 = bigInteger.ModInverse(a);
				global::Org.BouncyCastle.Math.BigInteger tmp = bigInteger.Multiply(b2);
				tmp = tmp.Multiply((global::Org.BouncyCastle.Math.BigInteger)congruences[j]);
				retval = retval.Add(tmp);
			}
			return retval.Mod(all);
		}

		// Token: 0x04001361 RID: 4961
		private bool forEncryption;

		// Token: 0x04001362 RID: 4962
		private global::Org.BouncyCastle.Crypto.Parameters.NaccacheSternKeyParameters key;

		// Token: 0x04001363 RID: 4963
		private global::System.Collections.IList[] lookup;
	}
}
