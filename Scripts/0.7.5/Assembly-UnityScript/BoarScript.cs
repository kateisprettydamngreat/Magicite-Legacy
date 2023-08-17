using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class BoarScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241227 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal int[] _0024drops_00241228;

			internal BoarScript _0024self__00241229;

			public _0024(BoarScript self_)
			{
				_0024self__00241229 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241229.@base.animation["i"].layer = 0;
					_0024self__00241229.@base.animation["a"].layer = 1;
					_0024self__00241229.@base.animation["r"].layer = 0;
					_0024self__00241229.@base.animation["r"].speed = 2f;
					_0024drops_00241228 = new int[3] { 7, 18, 0 };
					_0024self__00241229.SetStats(35, 2, 2, 11, 2f, _0024drops_00241228, Random.Range(5, 15), 11);
					goto case 3;
				case 3:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(2, ((MonoBehaviour)_0024self__00241229).StartCoroutine_Auto(_0024self__00241229.MoveCheck())) ? 1 : 0);
					break;
				case 2:
					result = (((GenericGeneratorEnumerator<Coroutine>)this).Yield(3, ((MonoBehaviour)_0024self__00241229).StartCoroutine_Auto(_0024self__00241229.AttackCheck())) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal BoarScript _0024self__00241230;

		public _0024Start_00241227(BoarScript self_)
		{
			_0024self__00241230 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return (IEnumerator<Coroutine>)(object)new _0024(_0024self__00241230);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024AttackCheck_00241231 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00241232;

			internal Ray _0024ray2_00241233;

			internal int _0024_0024460_00241234;

			internal Vector3 _0024_0024461_00241235;

			internal BoarScript _0024self__00241236;

			public _0024(BoarScript self_)
			{
				_0024self__00241236 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0148: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Expected O, but got Unknown
				//IL_0261: Unknown result type (might be due to invalid IL or missing references)
				//IL_026b: Expected O, but got Unknown
				//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_030d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0312: Unknown result type (might be due to invalid IL or missing references)
				//IL_0313: Unknown result type (might be due to invalid IL or missing references)
				//IL_0319: Unknown result type (might be due to invalid IL or missing references)
				//IL_0191: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0107: Expected O, but got Unknown
				//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b5: Expected O, but got Unknown
				//IL_0205: Unknown result type (might be due to invalid IL or missing references)
				//IL_0216: Unknown result type (might be due to invalid IL or missing references)
				//IL_0220: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024ray_00241232 = new Ray(_0024self__00241236.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00241233 = new Ray(_0024self__00241236.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00241232, ref _0024self__00241236.hit, 20f, 256))
					{
						_0024self__00241236.attacking = true;
						_0024self__00241236.@base.animation.Stop();
						_0024self__00241236.@base.animation.Play("a");
						_0024self__00241236.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00241233, ref _0024self__00241236.hit, 20f, 256))
					{
						_0024self__00241236.attacking = true;
						_0024self__00241236.@base.animation.Stop();
						_0024self__00241236.@base.animation.Play("a");
						_0024self__00241236.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					goto IL_02a4;
				case 2:
					_0024self__00241236.@base.animation.Play("r");
					_0024self__00241236.atking = true;
					_0024self__00241236.spdd = 16f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241236.atking = false;
					_0024self__00241236.spdd = 0f;
					_0024self__00241236.@base.animation.Play("i");
					goto IL_02a4;
				case 4:
					_0024self__00241236.@base.animation.Play("r");
					_0024self__00241236.atking = true;
					_0024self__00241236.spdd = -16f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00241236.atking = false;
					_0024self__00241236.spdd = 0f;
					_0024self__00241236.@base.animation.Play("i");
					goto IL_02a4;
				case 6:
				{
					_0024self__00241236.attacking = false;
					int num = (_0024_0024460_00241234 = 0);
					Vector3 val = (_0024_0024461_00241235 = _0024self__00241236.r.velocity);
					float num2 = (_0024_0024461_00241235.x = _0024_0024460_00241234);
					Vector3 val3 = (_0024self__00241236.r.velocity = _0024_0024461_00241235);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_02a4:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(6, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal BoarScript _0024self__00241237;

		public _0024AttackCheck_00241231(BoarScript self_)
		{
			_0024self__00241237 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241237);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MoveCheck_00241238 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal BoarScript _0024self__00241239;

			public _0024(BoarScript self_)
			{
				_0024self__00241239 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241239.atking = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241239.atking = false;
					_0024self__00241239.spdd = 0f;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal BoarScript _0024self__00241240;

		public _0024MoveCheck_00241238(BoarScript self_)
		{
			_0024self__00241240 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241240);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ATK_00241241 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Ray _0024ray_00241242;

			internal Ray _0024ray2_00241243;

			internal BoarScript _0024self__00241244;

			public _0024(BoarScript self_)
			{
				_0024self__00241244 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002f: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_0055: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0147: Unknown result type (might be due to invalid IL or missing references)
				//IL_0151: Expected O, but got Unknown
				//IL_0263: Unknown result type (might be due to invalid IL or missing references)
				//IL_026d: Expected O, but got Unknown
				//IL_0190: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0103: Expected O, but got Unknown
				//IL_0204: Unknown result type (might be due to invalid IL or missing references)
				//IL_0215: Unknown result type (might be due to invalid IL or missing references)
				//IL_021f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024ray_00241242 = new Ray(_0024self__00241244.t.position, new Vector3(1f, 0f, 0f));
					_0024ray2_00241243 = new Ray(_0024self__00241244.t.position, new Vector3(-1f, 0f, 0f));
					if (Physics.Raycast(_0024ray_00241242, ref _0024self__00241244.hit, 20f, 256))
					{
						_0024self__00241244.attacking = true;
						_0024self__00241244.@base.animation.Stop();
						_0024self__00241244.@base.animation.Play("a");
						_0024self__00241244.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					if (Physics.Raycast(_0024ray2_00241243, ref _0024self__00241244.hit, 20f, 256))
					{
						_0024self__00241244.attacking = true;
						_0024self__00241244.@base.animation.Stop();
						_0024self__00241244.@base.animation.Play("a");
						_0024self__00241244.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.7f)) ? 1 : 0);
						break;
					}
					goto IL_02a6;
				case 2:
					_0024self__00241244.@base.animation.Play("r");
					_0024self__00241244.atking = true;
					_0024self__00241244.spdd = 16f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds((float)Random.Range(1, 4))) ? 1 : 0);
					break;
				case 3:
					_0024self__00241244.atking = false;
					_0024self__00241244.spdd = 0f;
					_0024self__00241244.@base.animation.Play("i");
					goto IL_02a6;
				case 4:
					_0024self__00241244.@base.animation.Play("r");
					_0024self__00241244.atking = true;
					_0024self__00241244.spdd = -16f;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds((float)Random.Range(1, 4))) ? 1 : 0);
					break;
				case 5:
					_0024self__00241244.atking = false;
					_0024self__00241244.spdd = 0f;
					_0024self__00241244.@base.animation.Play("i");
					goto IL_02a6;
				case 1:
					{
						result = 0;
						break;
					}
					IL_02a6:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal BoarScript _0024self__00241245;

		public _0024ATK_00241241(BoarScript self_)
		{
			_0024self__00241245 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241245);
		}
	}

	private RaycastHit hit;

	private float spdd;

	private bool atking;

	public override IEnumerator Start()
	{
		return new _0024Start_00241227(this).GetEnumerator();
	}

	public override IEnumerator AttackCheck()
	{
		return new _0024AttackCheck_00241231(this).GetEnumerator();
	}

	public override IEnumerator MoveCheck()
	{
		return new _0024MoveCheck_00241238(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator ATK()
	{
		return new _0024ATK_00241241(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (atking)
		{
			float x = spdd;
			Vector3 velocity = r.velocity;
			float num = (velocity.x = x);
			Vector3 val2 = (r.velocity = velocity);
		}
	}

	public override void Main()
	{
	}
}
