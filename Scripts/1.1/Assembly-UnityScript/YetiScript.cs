using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class YetiScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242977 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00242978;

			internal YetiScript _0024self__00242979;

			public _0024(YetiScript self_)
			{
				_0024self__00242979 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242979.@base.animation["i"].layer = 0;
					_0024self__00242979.@base.animation["a"].layer = 1;
					_0024self__00242979.@base.animation["i"].speed = 0.5f;
					_0024drops_00242978 = new int[3] { 1, 0, 0 };
					_0024self__00242979.SetStats(20, 2, 1, 8, 6f, _0024drops_00242978, Random.Range(3, 20), 6);
					goto case 2;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00242979).StartCoroutine_Auto(_0024self__00242979.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal YetiScript _0024self__00242980;

		public _0024Start_00242977(YetiScript self_)
		{
			_0024self__00242980 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00242980);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00242981 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector3 _0024startPos_00242982;

			internal Ray _0024ray_00242983;

			internal Ray _0024ray2_00242984;

			internal int _0024num_00242985;

			internal YetiScript _0024self__00242986;

			public _0024(YetiScript self_)
			{
				_0024self__00242986 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Unknown result type (might be due to invalid IL or missing references)
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0094: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_0186: Unknown result type (might be due to invalid IL or missing references)
				//IL_011b: Unknown result type (might be due to invalid IL or missing references)
				//IL_012c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0136: Expected O, but got Unknown
				//IL_0171: Unknown result type (might be due to invalid IL or missing references)
				//IL_017b: Expected O, but got Unknown
				//IL_015c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0161: Unknown result type (might be due to invalid IL or missing references)
				//IL_023b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0245: Expected O, but got Unknown
				//IL_0226: Unknown result type (might be due to invalid IL or missing references)
				//IL_022b: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0200: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024startPos_00242982 = new Vector3(_0024self__00242986.t.position.x, _0024self__00242986.t.position.y - 0.3f, 0f);
					_0024ray_00242983 = new Ray(_0024startPos_00242982, new Vector3(1f, 0f, 0f));
					_0024ray2_00242984 = new Ray(_0024startPos_00242982, new Vector3(-1f, 0f, 0f));
					_0024num_00242985 = default(int);
					if (Physics.Raycast(_0024ray_00242983, ref _0024self__00242986.hit, 20f, 256))
					{
						_0024self__00242986.attacking = true;
						_0024num_00242985 = Random.Range(0, 5);
						_0024self__00242986.@base.animation.Play("a");
						_0024self__00242986.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00242984, ref _0024self__00242986.hit, 20f, 256))
					{
						_0024self__00242986.attacking = true;
						_0024self__00242986.@base.animation.Play("a");
						_0024self__00242986.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 2:
					if (MenuScript.multiplayer == 1)
					{
						Network.Instantiate((Object)(object)_0024self__00242986.ballR, _0024self__00242986.t.position, Quaternion.identity, 0);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 4:
					if (MenuScript.multiplayer == 1)
					{
						Network.Instantiate((Object)(object)_0024self__00242986.ballL, _0024self__00242986.t.position, Quaternion.identity, 0);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 3:
				case 5:
					_0024self__00242986.attacking = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal YetiScript _0024self__00242987;

		public _0024ATK_00242981(YetiScript self_)
		{
			_0024self__00242987 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242987);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00242988 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector3 _0024startPos_00242989;

			internal Ray _0024ray_00242990;

			internal Ray _0024ray2_00242991;

			internal int _0024num_00242992;

			internal int _0024doodoo_00242993;

			internal int _0024doodoso_00242994;

			internal int _0024_00241118_00242995;

			internal Vector3 _0024_00241119_00242996;

			internal int _0024_00241120_00242997;

			internal Vector3 _0024_00241121_00242998;

			internal YetiScript _0024self__00242999;

			public _0024(YetiScript self_)
			{
				_0024self__00242999 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_004b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c1: Expected O, but got Unknown
				//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_0218: Unknown result type (might be due to invalid IL or missing references)
				//IL_021d: Unknown result type (might be due to invalid IL or missing references)
				//IL_038d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0392: Unknown result type (might be due to invalid IL or missing references)
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_022c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0236: Expected O, but got Unknown
				//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ab: Expected O, but got Unknown
				//IL_0361: Unknown result type (might be due to invalid IL or missing references)
				//IL_0366: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bb: Expected O, but got Unknown
				//IL_0315: Unknown result type (might be due to invalid IL or missing references)
				//IL_0326: Unknown result type (might be due to invalid IL or missing references)
				//IL_0330: Expected O, but got Unknown
				//IL_0129: Unknown result type (might be due to invalid IL or missing references)
				//IL_012e: Unknown result type (might be due to invalid IL or missing references)
				//IL_012f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0130: Unknown result type (might be due to invalid IL or missing references)
				//IL_0135: Unknown result type (might be due to invalid IL or missing references)
				//IL_015b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0160: Unknown result type (might be due to invalid IL or missing references)
				//IL_0161: Unknown result type (might be due to invalid IL or missing references)
				//IL_0168: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02da: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024startPos_00242989 = new Vector3(_0024self__00242999.t.position.x, _0024self__00242999.t.position.y - 0.3f, 0f);
					_0024ray_00242990 = new Ray(_0024startPos_00242989, new Vector3(1f, 0f, 0f));
					_0024ray2_00242991 = new Ray(_0024startPos_00242989, new Vector3(-1f, 0f, 0f));
					_0024num_00242992 = default(int);
					if (!_0024self__00242999.attacking)
					{
						if (Physics.Raycast(_0024ray_00242990, ref _0024self__00242999.hit, 20f, 256))
						{
							_0024num_00242992 = Random.Range(0, 5);
							if (MenuScript.multiplayer == 1)
							{
								_0024doodoo_00242993 = Random.Range(0, 3);
								if (_0024doodoo_00242993 == 0)
								{
									int num = (_0024_00241118_00242995 = 20);
									Vector3 val = (_0024_00241119_00242996 = _0024self__00242999.r.velocity);
									float num2 = (_0024_00241119_00242996.y = _0024_00241118_00242995);
									Vector3 val3 = (_0024self__00242999.r.velocity = _0024_00241119_00242996);
								}
							}
							_0024self__00242999.@base.animation.Play("a");
							_0024self__00242999.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
							break;
						}
						if (Physics.Raycast(_0024ray2_00242991, ref _0024self__00242999.hit, 20f, 256))
						{
							if (MenuScript.multiplayer == 1)
							{
								_0024doodoso_00242994 = Random.Range(0, 3);
								if (_0024doodoso_00242994 == 0)
								{
									int num3 = (_0024_00241120_00242997 = 20);
									Vector3 val4 = (_0024_00241121_00242998 = _0024self__00242999.r.velocity);
									float num4 = (_0024_00241121_00242998.y = _0024_00241120_00242997);
									Vector3 val6 = (_0024self__00242999.r.velocity = _0024_00241121_00242998);
								}
							}
							_0024self__00242999.@base.animation.Play("a");
							_0024self__00242999.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.3f)) ? 1 : 0);
							break;
						}
					}
					goto case 3;
				case 2:
					if (MenuScript.multiplayer > 0)
					{
						if (MenuScript.multiplayer == 1)
						{
							Network.Instantiate((Object)(object)_0024self__00242999.ballR, _0024self__00242999.t.position, Quaternion.identity, 0);
						}
					}
					else
					{
						Object.Instantiate((Object)(object)_0024self__00242999.ballR, _0024self__00242999.t.position, Quaternion.identity);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 4:
					if (MenuScript.multiplayer > 0)
					{
						if (MenuScript.multiplayer == 1)
						{
							Network.Instantiate((Object)(object)_0024self__00242999.ballL, _0024self__00242999.t.position, Quaternion.identity, 0);
						}
					}
					else
					{
						Object.Instantiate((Object)(object)_0024self__00242999.ballL, _0024self__00242999.t.position, Quaternion.identity);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 3:
				case 5:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 6:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal YetiScript _0024self__00243000;

		public _0024AttackCheck_00242988(YetiScript self_)
		{
			_0024self__00243000 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243000);
		}
	}

	public GameObject ballL;

	public GameObject ballR;

	private RaycastHit hit;

	private int num;

	public override IEnumerator Start()
	{
		return new _0024Start_00242977(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator ATK()
	{
		return new _0024ATK_00242981(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00242988(this).GetEnumerator();
	}
}
