using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000497 RID: 1175
	public class DesEdeEngine : global::Org.BouncyCastle.Crypto.Engines.DesEngine
	{
		// Token: 0x06002D37 RID: 11575 RVA: 0x000C9868 File Offset: 0x000C7A68
		public override void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
			{
				throw new global::System.ArgumentException("invalid parameter passed to DESede init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
			}
			byte[] keyMaster = ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey();
			if (keyMaster.Length != 24 && keyMaster.Length != 16)
			{
				throw new global::System.ArgumentException("key size must be 16 or 24 bytes.");
			}
			this.forEncryption = forEncryption;
			byte[] key = new byte[8];
			global::System.Array.Copy(keyMaster, 0, key, 0, key.Length);
			this.workingKey1 = global::Org.BouncyCastle.Crypto.Engines.DesEngine.GenerateWorkingKey(forEncryption, key);
			byte[] key2 = new byte[8];
			global::System.Array.Copy(keyMaster, 8, key2, 0, key2.Length);
			this.workingKey2 = global::Org.BouncyCastle.Crypto.Engines.DesEngine.GenerateWorkingKey(!forEncryption, key2);
			if (keyMaster.Length == 24)
			{
				byte[] key3 = new byte[8];
				global::System.Array.Copy(keyMaster, 16, key3, 0, key3.Length);
				this.workingKey3 = global::Org.BouncyCastle.Crypto.Engines.DesEngine.GenerateWorkingKey(forEncryption, key3);
				return;
			}
			this.workingKey3 = this.workingKey1;
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x000C9937 File Offset: 0x000C7B37
		public override string AlgorithmName
		{
			get
			{
				return "DESede";
			}
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x000C993E File Offset: 0x000C7B3E
		public override int GetBlockSize()
		{
			return 8;
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x000C9944 File Offset: 0x000C7B44
		public override int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (this.workingKey1 == null)
			{
				throw new global::System.InvalidOperationException("DESede engine not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, 8, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, 8, "output buffer too short");
			byte[] temp = new byte[8];
			if (this.forEncryption)
			{
				global::Org.BouncyCastle.Crypto.Engines.DesEngine.DesFunc(this.workingKey1, input, inOff, temp, 0);
				global::Org.BouncyCastle.Crypto.Engines.DesEngine.DesFunc(this.workingKey2, temp, 0, temp, 0);
				global::Org.BouncyCastle.Crypto.Engines.DesEngine.DesFunc(this.workingKey3, temp, 0, output, outOff);
			}
			else
			{
				global::Org.BouncyCastle.Crypto.Engines.DesEngine.DesFunc(this.workingKey3, input, inOff, temp, 0);
				global::Org.BouncyCastle.Crypto.Engines.DesEngine.DesFunc(this.workingKey2, temp, 0, temp, 0);
				global::Org.BouncyCastle.Crypto.Engines.DesEngine.DesFunc(this.workingKey1, temp, 0, output, outOff);
			}
			return 8;
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x000C99ED File Offset: 0x000C7BED
		public override void Reset()
		{
		}

		// Token: 0x040012F5 RID: 4853
		private int[] workingKey1;

		// Token: 0x040012F6 RID: 4854
		private int[] workingKey2;

		// Token: 0x040012F7 RID: 4855
		private int[] workingKey3;

		// Token: 0x040012F8 RID: 4856
		private bool forEncryption;
	}
}
