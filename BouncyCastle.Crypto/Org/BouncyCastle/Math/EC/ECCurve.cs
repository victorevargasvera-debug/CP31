using System;
using System.Collections;
using Org.BouncyCastle.Math.EC.Endo;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Field;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000206 RID: 518
	public abstract class ECCurve
	{
		// Token: 0x06001452 RID: 5202 RVA: 0x00060356 File Offset: 0x0005E556
		public static int[] GetAllCoordinateSystems()
		{
			return new int[]
			{
				0,
				1,
				2,
				3,
				4,
				5,
				6,
				7
			};
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00060369 File Offset: 0x0005E569
		protected ECCurve(global::Org.BouncyCastle.Math.Field.IFiniteField field)
		{
			this.m_field = field;
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06001454 RID: 5204
		public abstract int FieldSize { get; }

		// Token: 0x06001455 RID: 5205
		public abstract global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x);

		// Token: 0x06001456 RID: 5206
		public abstract bool IsValidFieldElement(global::Org.BouncyCastle.Math.BigInteger x);

		// Token: 0x06001457 RID: 5207
		public abstract global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r);

		// Token: 0x06001458 RID: 5208
		public abstract global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r);

		// Token: 0x06001459 RID: 5209 RVA: 0x00060378 File Offset: 0x0005E578
		public virtual global::Org.BouncyCastle.Math.EC.ECCurve.Config Configure()
		{
			return new global::Org.BouncyCastle.Math.EC.ECCurve.Config(this, this.m_coord, this.m_endomorphism, this.m_multiplier);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00060392 File Offset: 0x0005E592
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint ValidatePoint(global::Org.BouncyCastle.Math.BigInteger x, global::Org.BouncyCastle.Math.BigInteger y)
		{
			global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = this.CreatePoint(x, y);
			if (!ecpoint.IsValid())
			{
				throw new global::System.ArgumentException("Invalid point coordinates");
			}
			return ecpoint;
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x000603AF File Offset: 0x0005E5AF
		[global::System.Obsolete("Per-point compression property will be removed")]
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint ValidatePoint(global::Org.BouncyCastle.Math.BigInteger x, global::Org.BouncyCastle.Math.BigInteger y, bool withCompression)
		{
			global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = this.CreatePoint(x, y, withCompression);
			if (!ecpoint.IsValid())
			{
				throw new global::System.ArgumentException("Invalid point coordinates");
			}
			return ecpoint;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x000603CD File Offset: 0x0005E5CD
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(global::Org.BouncyCastle.Math.BigInteger x, global::Org.BouncyCastle.Math.BigInteger y)
		{
			return this.CreatePoint(x, y, false);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x000603D8 File Offset: 0x0005E5D8
		[global::System.Obsolete("Per-point compression property will be removed")]
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(global::Org.BouncyCastle.Math.BigInteger x, global::Org.BouncyCastle.Math.BigInteger y, bool withCompression)
		{
			return this.CreateRawPoint(this.FromBigInteger(x), this.FromBigInteger(y), withCompression);
		}

		// Token: 0x0600145E RID: 5214
		protected abstract global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve();

		// Token: 0x0600145F RID: 5215
		protected internal abstract global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression);

		// Token: 0x06001460 RID: 5216
		protected internal abstract global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression);

		// Token: 0x06001461 RID: 5217 RVA: 0x000603F0 File Offset: 0x0005E5F0
		protected virtual global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateDefaultMultiplier()
		{
			global::Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism glvEndomorphism = this.m_endomorphism as global::Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism;
			if (glvEndomorphism != null)
			{
				return new global::Org.BouncyCastle.Math.EC.Multiplier.GlvMultiplier(this, glvEndomorphism);
			}
			return new global::Org.BouncyCastle.Math.EC.Multiplier.WNafL2RMultiplier();
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00060419 File Offset: 0x0005E619
		public virtual bool SupportsCoordinateSystem(int coord)
		{
			return coord == 0;
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00060420 File Offset: 0x0005E620
		public virtual global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo GetPreCompInfo(global::Org.BouncyCastle.Math.EC.ECPoint point, string name)
		{
			this.CheckPoint(point);
			global::System.Collections.IDictionary table;
			lock (point)
			{
				table = point.m_preCompTable;
			}
			if (table == null)
			{
				return null;
			}
			global::System.Collections.IDictionary obj = table;
			global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo result;
			lock (obj)
			{
				result = (global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo)table[name];
			}
			return result;
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0006049C File Offset: 0x0005E69C
		public virtual global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo Precompute(global::Org.BouncyCastle.Math.EC.ECPoint point, string name, global::Org.BouncyCastle.Math.EC.Multiplier.IPreCompCallback callback)
		{
			this.CheckPoint(point);
			global::System.Collections.IDictionary table;
			lock (point)
			{
				table = point.m_preCompTable;
				if (table == null)
				{
					table = (point.m_preCompTable = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(4));
				}
			}
			global::System.Collections.IDictionary obj = table;
			global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo result2;
			lock (obj)
			{
				global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo existing = (global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo)table[name];
				global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo result = callback.Precompute(existing);
				if (result != existing)
				{
					table[name] = result;
				}
				result2 = result;
			}
			return result2;
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00060544 File Offset: 0x0005E744
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint ImportPoint(global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			if (this == p.Curve)
			{
				return p;
			}
			if (p.IsInfinity)
			{
				return this.Infinity;
			}
			p = p.Normalize();
			return this.CreatePoint(p.XCoord.ToBigInteger(), p.YCoord.ToBigInteger(), p.IsCompressed);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00060595 File Offset: 0x0005E795
		public virtual void NormalizeAll(global::Org.BouncyCastle.Math.EC.ECPoint[] points)
		{
			this.NormalizeAll(points, 0, points.Length, null);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x000605A4 File Offset: 0x0005E7A4
		public virtual void NormalizeAll(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len, global::Org.BouncyCastle.Math.EC.ECFieldElement iso)
		{
			this.CheckPoints(points, off, len);
			int coordinateSystem = this.CoordinateSystem;
			if (coordinateSystem == 0 || coordinateSystem == 5)
			{
				if (iso != null)
				{
					throw new global::System.ArgumentException("not valid for affine coordinates", "iso");
				}
				return;
			}
			else
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs = new global::Org.BouncyCastle.Math.EC.ECFieldElement[len];
				int[] indices = new int[len];
				int count = 0;
				for (int i = 0; i < len; i++)
				{
					global::Org.BouncyCastle.Math.EC.ECPoint p = points[off + i];
					if (p != null && (iso != null || !p.IsNormalized()))
					{
						zs[count] = p.GetZCoord(0);
						indices[count++] = off + i;
					}
				}
				if (count == 0)
				{
					return;
				}
				global::Org.BouncyCastle.Math.EC.ECAlgorithms.MontgomeryTrick(zs, 0, count, iso);
				for (int j = 0; j < count; j++)
				{
					int index = indices[j];
					points[index] = points[index].Normalize(zs[j]);
				}
				return;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06001468 RID: 5224
		public abstract global::Org.BouncyCastle.Math.EC.ECPoint Infinity { get; }

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x00060661 File Offset: 0x0005E861
		public virtual global::Org.BouncyCastle.Math.Field.IFiniteField Field
		{
			get
			{
				return this.m_field;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x00060669 File Offset: 0x0005E869
		public virtual global::Org.BouncyCastle.Math.EC.ECFieldElement A
		{
			get
			{
				return this.m_a;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x00060671 File Offset: 0x0005E871
		public virtual global::Org.BouncyCastle.Math.EC.ECFieldElement B
		{
			get
			{
				return this.m_b;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x00060679 File Offset: 0x0005E879
		public virtual global::Org.BouncyCastle.Math.BigInteger Order
		{
			get
			{
				return this.m_order;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x00060681 File Offset: 0x0005E881
		public virtual global::Org.BouncyCastle.Math.BigInteger Cofactor
		{
			get
			{
				return this.m_cofactor;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x00060689 File Offset: 0x0005E889
		public virtual int CoordinateSystem
		{
			get
			{
				return this.m_coord;
			}
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00060694 File Offset: 0x0005E894
		public virtual global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			int FE_BYTES = (this.FieldSize + 7) / 8;
			byte[] table = new byte[len * FE_BYTES * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				byte[] px = ecpoint.RawXCoord.ToBigInteger().ToByteArray();
				byte[] array = ecpoint.RawYCoord.ToBigInteger().ToByteArray();
				int pxStart = (px.Length > FE_BYTES) ? 1 : 0;
				int pxLen = px.Length - pxStart;
				int pyStart = (array.Length > FE_BYTES) ? 1 : 0;
				int pyLen = array.Length - pyStart;
				global::System.Array.Copy(px, pxStart, table, pos + FE_BYTES - pxLen, pxLen);
				pos += FE_BYTES;
				global::System.Array.Copy(array, pyStart, table, pos + FE_BYTES - pyLen, pyLen);
				pos += FE_BYTES;
			}
			return new global::Org.BouncyCastle.Math.EC.ECCurve.DefaultLookupTable(this, table, len);
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0006074A File Offset: 0x0005E94A
		protected virtual void CheckPoint(global::Org.BouncyCastle.Math.EC.ECPoint point)
		{
			if (point == null || this != point.Curve)
			{
				throw new global::System.ArgumentException("must be non-null and on this curve", "point");
			}
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00060768 File Offset: 0x0005E968
		protected virtual void CheckPoints(global::Org.BouncyCastle.Math.EC.ECPoint[] points)
		{
			this.CheckPoints(points, 0, points.Length);
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00060778 File Offset: 0x0005E978
		protected virtual void CheckPoints(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			if (points == null)
			{
				throw new global::System.ArgumentNullException("points");
			}
			if (off < 0 || len < 0 || off > points.Length - len)
			{
				throw new global::System.ArgumentException("invalid range specified", "points");
			}
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint point = points[off + i];
				if (point != null && this != point.Curve)
				{
					throw new global::System.ArgumentException("entries must be null or on this curve", "points");
				}
			}
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x000607E4 File Offset: 0x0005E9E4
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.ECCurve other)
		{
			return this == other || (other != null && (this.Field.Equals(other.Field) && this.A.ToBigInteger().Equals(other.A.ToBigInteger())) && this.B.ToBigInteger().Equals(other.B.ToBigInteger()));
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00060849 File Offset: 0x0005EA49
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.ECCurve);
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00060857 File Offset: 0x0005EA57
		public override int GetHashCode()
		{
			return this.Field.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Integers.RotateLeft(this.A.ToBigInteger().GetHashCode(), 8) ^ global::Org.BouncyCastle.Utilities.Integers.RotateLeft(this.B.ToBigInteger().GetHashCode(), 16);
		}

		// Token: 0x06001476 RID: 5238
		protected abstract global::Org.BouncyCastle.Math.EC.ECPoint DecompressPoint(int yTilde, global::Org.BouncyCastle.Math.BigInteger X1);

		// Token: 0x06001477 RID: 5239 RVA: 0x00060893 File Offset: 0x0005EA93
		public virtual global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism GetEndomorphism()
		{
			return this.m_endomorphism;
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0006089B File Offset: 0x0005EA9B
		public virtual global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier GetMultiplier()
		{
			if (this.m_multiplier == null)
			{
				this.m_multiplier = this.CreateDefaultMultiplier();
			}
			return this.m_multiplier;
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x000608B8 File Offset: 0x0005EAB8
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint DecodePoint(byte[] encoded)
		{
			int expectedLength = (this.FieldSize + 7) / 8;
			byte type = encoded[0];
			global::Org.BouncyCastle.Math.EC.ECPoint p;
			switch (type)
			{
			case 0:
				if (encoded.Length != 1)
				{
					throw new global::System.ArgumentException("Incorrect length for infinity encoding", "encoded");
				}
				p = this.Infinity;
				goto IL_15A;
			case 2:
			case 3:
			{
				if (encoded.Length != expectedLength + 1)
				{
					throw new global::System.ArgumentException("Incorrect length for compressed encoding", "encoded");
				}
				int yTilde = (int)(type & 1);
				global::Org.BouncyCastle.Math.BigInteger X = new global::Org.BouncyCastle.Math.BigInteger(1, encoded, 1, expectedLength);
				p = this.DecompressPoint(yTilde, X);
				if (!p.ImplIsValid(true, true))
				{
					throw new global::System.ArgumentException("Invalid point");
				}
				goto IL_15A;
			}
			case 4:
			{
				if (encoded.Length != 2 * expectedLength + 1)
				{
					throw new global::System.ArgumentException("Incorrect length for uncompressed encoding", "encoded");
				}
				global::Org.BouncyCastle.Math.BigInteger X2 = new global::Org.BouncyCastle.Math.BigInteger(1, encoded, 1, expectedLength);
				global::Org.BouncyCastle.Math.BigInteger Y = new global::Org.BouncyCastle.Math.BigInteger(1, encoded, 1 + expectedLength, expectedLength);
				p = this.ValidatePoint(X2, Y);
				goto IL_15A;
			}
			case 6:
			case 7:
			{
				if (encoded.Length != 2 * expectedLength + 1)
				{
					throw new global::System.ArgumentException("Incorrect length for hybrid encoding", "encoded");
				}
				global::Org.BouncyCastle.Math.BigInteger X3 = new global::Org.BouncyCastle.Math.BigInteger(1, encoded, 1, expectedLength);
				global::Org.BouncyCastle.Math.BigInteger Y2 = new global::Org.BouncyCastle.Math.BigInteger(1, encoded, 1 + expectedLength, expectedLength);
				if (Y2.TestBit(0) != (type == 7))
				{
					throw new global::System.ArgumentException("Inconsistent Y coordinate in hybrid encoding", "encoded");
				}
				p = this.ValidatePoint(X3, Y2);
				goto IL_15A;
			}
			}
			throw new global::System.FormatException("Invalid point encoding " + type.ToString());
			IL_15A:
			if (type != 0 && p.IsInfinity)
			{
				throw new global::System.ArgumentException("Invalid infinity encoding", "encoded");
			}
			return p;
		}

		// Token: 0x0400093B RID: 2363
		public const int COORD_AFFINE = 0;

		// Token: 0x0400093C RID: 2364
		public const int COORD_HOMOGENEOUS = 1;

		// Token: 0x0400093D RID: 2365
		public const int COORD_JACOBIAN = 2;

		// Token: 0x0400093E RID: 2366
		public const int COORD_JACOBIAN_CHUDNOVSKY = 3;

		// Token: 0x0400093F RID: 2367
		public const int COORD_JACOBIAN_MODIFIED = 4;

		// Token: 0x04000940 RID: 2368
		public const int COORD_LAMBDA_AFFINE = 5;

		// Token: 0x04000941 RID: 2369
		public const int COORD_LAMBDA_PROJECTIVE = 6;

		// Token: 0x04000942 RID: 2370
		public const int COORD_SKEWED = 7;

		// Token: 0x04000943 RID: 2371
		protected readonly global::Org.BouncyCastle.Math.Field.IFiniteField m_field;

		// Token: 0x04000944 RID: 2372
		protected global::Org.BouncyCastle.Math.EC.ECFieldElement m_a;

		// Token: 0x04000945 RID: 2373
		protected global::Org.BouncyCastle.Math.EC.ECFieldElement m_b;

		// Token: 0x04000946 RID: 2374
		protected global::Org.BouncyCastle.Math.BigInteger m_order;

		// Token: 0x04000947 RID: 2375
		protected global::Org.BouncyCastle.Math.BigInteger m_cofactor;

		// Token: 0x04000948 RID: 2376
		protected int m_coord;

		// Token: 0x04000949 RID: 2377
		protected global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism m_endomorphism;

		// Token: 0x0400094A RID: 2378
		protected global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier m_multiplier;

		// Token: 0x020007BD RID: 1981
		public class Config
		{
			// Token: 0x06004558 RID: 17752 RVA: 0x00132FF9 File Offset: 0x001311F9
			internal Config(global::Org.BouncyCastle.Math.EC.ECCurve outer, int coord, global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism endomorphism, global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier multiplier)
			{
				this.outer = outer;
				this.coord = coord;
				this.endomorphism = endomorphism;
				this.multiplier = multiplier;
			}

			// Token: 0x06004559 RID: 17753 RVA: 0x0013301E File Offset: 0x0013121E
			public global::Org.BouncyCastle.Math.EC.ECCurve.Config SetCoordinateSystem(int coord)
			{
				this.coord = coord;
				return this;
			}

			// Token: 0x0600455A RID: 17754 RVA: 0x00133028 File Offset: 0x00131228
			public global::Org.BouncyCastle.Math.EC.ECCurve.Config SetEndomorphism(global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism endomorphism)
			{
				this.endomorphism = endomorphism;
				return this;
			}

			// Token: 0x0600455B RID: 17755 RVA: 0x00133032 File Offset: 0x00131232
			public global::Org.BouncyCastle.Math.EC.ECCurve.Config SetMultiplier(global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier multiplier)
			{
				this.multiplier = multiplier;
				return this;
			}

			// Token: 0x0600455C RID: 17756 RVA: 0x0013303C File Offset: 0x0013123C
			public global::Org.BouncyCastle.Math.EC.ECCurve Create()
			{
				if (!this.outer.SupportsCoordinateSystem(this.coord))
				{
					throw new global::System.InvalidOperationException("unsupported coordinate system");
				}
				global::Org.BouncyCastle.Math.EC.ECCurve eccurve = this.outer.CloneCurve();
				if (eccurve == this.outer)
				{
					throw new global::System.InvalidOperationException("implementation returned current curve");
				}
				eccurve.m_coord = this.coord;
				eccurve.m_endomorphism = this.endomorphism;
				eccurve.m_multiplier = this.multiplier;
				return eccurve;
			}

			// Token: 0x040023E5 RID: 9189
			protected global::Org.BouncyCastle.Math.EC.ECCurve outer;

			// Token: 0x040023E6 RID: 9190
			protected int coord;

			// Token: 0x040023E7 RID: 9191
			protected global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism endomorphism;

			// Token: 0x040023E8 RID: 9192
			protected global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier multiplier;
		}

		// Token: 0x020007BE RID: 1982
		private class DefaultLookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x0600455D RID: 17757 RVA: 0x001330AA File Offset: 0x001312AA
			internal DefaultLookupTable(global::Org.BouncyCastle.Math.EC.ECCurve outer, byte[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A80 RID: 2688
			// (get) Token: 0x0600455E RID: 17758 RVA: 0x001330C7 File Offset: 0x001312C7
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x0600455F RID: 17759 RVA: 0x001330D0 File Offset: 0x001312D0
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				int FE_BYTES = (this.m_outer.FieldSize + 7) / 8;
				byte[] x = new byte[FE_BYTES];
				byte[] y = new byte[FE_BYTES];
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					byte MASK = (byte)((i ^ index) - 1 >> 31);
					for (int j = 0; j < FE_BYTES; j++)
					{
						byte[] array = x;
						int num = j;
						array[num] ^= (this.m_table[pos + j] & MASK);
						byte[] array2 = y;
						int num2 = j;
						array2[num2] ^= (this.m_table[pos + FE_BYTES + j] & MASK);
					}
					pos += FE_BYTES * 2;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004560 RID: 17760 RVA: 0x00133178 File Offset: 0x00131378
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				int FE_BYTES = (this.m_outer.FieldSize + 7) / 8;
				byte[] x = new byte[FE_BYTES];
				byte[] y = new byte[FE_BYTES];
				int pos = index * FE_BYTES * 2;
				for (int i = 0; i < FE_BYTES; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + FE_BYTES + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004561 RID: 17761 RVA: 0x001331E4 File Offset: 0x001313E4
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(byte[] x, byte[] y)
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement X = this.m_outer.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, x));
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y = this.m_outer.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, y));
				return this.m_outer.CreateRawPoint(X, Y, false);
			}

			// Token: 0x040023E9 RID: 9193
			private readonly global::Org.BouncyCastle.Math.EC.ECCurve m_outer;

			// Token: 0x040023EA RID: 9194
			private readonly byte[] m_table;

			// Token: 0x040023EB RID: 9195
			private readonly int m_size;
		}
	}
}
