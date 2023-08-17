using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class GhoulScript : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Summon_00241699 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024g_00241700;

			internal GhoulScript _0024self__00241701;

			public _0024(GhoulScript self_)
			{
				_0024self__00241701 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Expected O, but got Unknown
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Unknown result type (might be due to invalid IL or missing references)
				//IL_010c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0116: Expected O, but got Unknown
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0094: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a9: Expected O, but got Unknown
				//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
				int result;
				switch (base._state)
				{
				default:
					_0024g_00241700 = null;
					goto IL_0023;
				case 2:
					if (_0024self__00241701.atking && Object.op_Implicit((Object)(object)_0024self__00241701.player) && _0024self__00241701.canFire)
					{
						if (MenuScript.multiplayer > 0)
						{
							_0024g_00241700 = (GameObject)Network.Instantiate(Resources.Load("haz/ghoulFire"), ((Component)_0024self__00241701).transform.position, Quaternion.identity, 0);
							_0024g_00241700.networkView.RPC("Set", (RPCMode)2, new object[1] { _0024self__00241701.player.transform.position });
						}
						else
						{
							_0024g_00241700 = (GameObject)Object.Instantiate(Resources.Load("haz/ghoulFire"), ((Component)_0024self__00241701).transform.position, Quaternion.identity);
							_0024g_00241700.SendMessage("Set", (object)_0024self__00241701.player.transform.position);
						}
					}
					goto IL_0023;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0023:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GhoulScript _0024self__00241702;

		public _0024Summon_00241699(GhoulScript self_)
		{
			_0024self__00241702 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241702);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00241703 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GhoulScript _0024self__00241704;

			public _0024(GhoulScript self_)
			{
				_0024self__00241704 = self_;
			}

			public override bool MoveNext()
			{
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Expected O, but got Unknown
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					if (Object.op_Implicit((Object)(object)_0024self__00241704.player))
					{
						_0024self__00241704.curVector = _0024self__00241704.player.transform.position - _0024self__00241704.t.position;
						if (!(_0024self__00241704.player.transform.position.x <= _0024self__00241704.t.position.x))
						{
							_0024self__00241704.e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
						}
						else
						{
							_0024self__00241704.e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
						}
						_0024self__00241704.atking = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 3:
					_0024self__00241704.atking = false;
					goto default;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GhoulScript _0024self__00241705;

		public _0024Attack_00241703(GhoulScript self_)
		{
			_0024self__00241705 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241705);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private bool canFire;

	public GhoulScript()
	{
		speed = 6f;
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		if (MenuScript.multiplayer > 0)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(Attack());
		}
		else
		{
			int[] array = new int[3] { 0, 0, 17 };
			SetStats(50, 5, 0, 7, 10f, array, Random.Range(6, 20), 8);
			if (MenuScript.multiplayer > 0)
			{
				player = GameObject.Find("playerN(Clone)");
			}
			else
			{
				player = GameObject.Find("player(Clone)");
			}
			((MonoBehaviour)this).StartCoroutine_Auto(Attack());
		}
		((MonoBehaviour)this).StartCoroutine_Auto(Summon());
	}

	public override IEnumerator Summon()
	{
		return new _0024Summon_00241699(this).GetEnumerator();
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)player) || MenuScript.multiplayer != 1)
		{
			return;
		}
		if (atking && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 10f) && !knocking)
		{
			canFire = true;
			if (r.isKinematic)
			{
				t.Translate(((Vector3)(ref curVector)).normalized * speed * Time.deltaTime);
			}
		}
		else
		{
			canFire = false;
		}
	}

	public override IEnumerator Attack()
	{
		return new _0024Attack_00241703(this).GetEnumerator();
	}
}
