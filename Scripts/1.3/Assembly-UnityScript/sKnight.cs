using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class sKnight : EnemyScript
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeRight_00243191 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241204_00243192;

			internal Vector3 _0024_00241205_00243193;

			internal sKnight _0024self__00243194;

			public _0024(sKnight self_)
			{
				_0024self__00243194 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f2: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00243194.charging && MenuScript.multiplayer == 1)
					{
						int num = (_0024_00241204_00243192 = 15);
						Vector3 val = (_0024_00241205_00243193 = _0024self__00243194.r.velocity);
						float num2 = (_0024_00241205_00243193.y = _0024_00241204_00243192);
						Vector3 val3 = (_0024self__00243194.r.velocity = _0024_00241205_00243193);
						_0024self__00243194.charging = true;
						((Component)_0024self__00243194).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
						((Component)_0024self__00243194).networkView.RPC("ATK", (RPCMode)2, new object[0]);
						_0024self__00243194.spdd = 6;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
						break;
					}
					goto IL_011f;
				case 2:
					((Component)_0024self__00243194).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00243194.charging = false;
					goto IL_011f;
				case 1:
					{
						result = 0;
						break;
					}
					IL_011f:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal sKnight _0024self__00243195;

		public _0024ChargeRight_00243191(sKnight self_)
		{
			_0024self__00243195 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243195);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeLeft_00243196 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241206_00243197;

			internal Vector3 _0024_00241207_00243198;

			internal sKnight _0024self__00243199;

			public _0024(sKnight self_)
			{
				_0024self__00243199 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f3: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00243199.charging && MenuScript.multiplayer == 1)
					{
						int num = (_0024_00241206_00243197 = 15);
						Vector3 val = (_0024_00241207_00243198 = _0024self__00243199.r.velocity);
						float num2 = (_0024_00241207_00243198.y = _0024_00241206_00243197);
						Vector3 val3 = (_0024self__00243199.r.velocity = _0024_00241207_00243198);
						_0024self__00243199.charging = true;
						((Component)_0024self__00243199).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
						((Component)_0024self__00243199).networkView.RPC("ATK", (RPCMode)2, new object[0]);
						_0024self__00243199.spdd = -6;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1.5f)) ? 1 : 0);
						break;
					}
					goto IL_0120;
				case 2:
					((Component)_0024self__00243199).networkView.RPC("IDLE", (RPCMode)2, new object[0]);
					_0024self__00243199.charging = false;
					goto IL_0120;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0120:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal sKnight _0024self__00243200;

		public _0024ChargeLeft_00243196(sKnight self_)
		{
			_0024self__00243200 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00243200);
		}
	}

	private GameObject player;

	private bool atking;

	private Vector3 curVector;

	private float speed;

	public AudioClip scourge1;

	private int spdd;

	private bool charging;

	private int mask2;

	private Ray r1U;

	private Ray r2U;

	public sKnight()
	{
		speed = 10f;
		mask2 = 2048;
	}

	public override void Awake()
	{
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		((Component)this).collider.material.dynamicFriction = 0f;
		int[] array = new int[3] { 0, 0, 17 };
		SetStats(55, 7, 0, 20, 10f, array, Random.Range(6, 20), 20);
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
	}

	public override void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		((Ray)(ref r1U)).origin = ((Component)this).transform.position;
		((Ray)(ref r1U)).direction = Vector3.left;
		((Ray)(ref r2U)).origin = ((Component)this).transform.position;
		((Ray)(ref r2U)).direction = Vector3.right;
		if (Physics.Raycast(r1U, 1.5f, mask2) && e.transform.rotation.y == 0f && MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
		{
			((Component)this).networkView.RPC("Turn", (RPCMode)2, new object[1] { 1 });
			spdd *= -1;
		}
		if (Physics.Raycast(r2U, 1.5f, mask2) && e.transform.rotation.y != 0f && MenuScript.multiplayer > 0 && MenuScript.multiplayer == 1)
		{
			((Component)this).networkView.RPC("Turn", (RPCMode)2, new object[1] { 0 });
			spdd *= -1;
		}
		if (Object.op_Implicit((Object)(object)player) && !(Mathf.Abs(player.transform.position.x - t.position.x) >= 7f) && !knocking)
		{
			if (!(player.transform.position.x <= t.position.x))
			{
				((MonoBehaviour)this).StartCoroutine_Auto(ChargeRight());
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine_Auto(ChargeLeft());
			}
		}
		if (charging && !knocking)
		{
			int num = spdd;
			Vector3 velocity = r.velocity;
			float num2 = (velocity.x = num);
			Vector3 val2 = (r.velocity = velocity);
		}
	}

	public override IEnumerator ChargeRight()
	{
		return new _0024ChargeRight_00243191(this).GetEnumerator();
	}

	public override IEnumerator ChargeLeft()
	{
		return new _0024ChargeLeft_00243196(this).GetEnumerator();
	}

	[RPC]
	public override void Turn(int a)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (a == 0)
		{
			int num = 0;
			Quaternion rotation = e.transform.rotation;
			float num2 = (rotation.y = num);
			Quaternion val2 = (e.transform.rotation = rotation);
		}
		else
		{
			int num3 = 180;
			Quaternion rotation2 = e.transform.rotation;
			float num4 = (rotation2.y = num3);
			Quaternion val4 = (e.transform.rotation = rotation2);
		}
	}

	[RPC]
	public override void ATK()
	{
		@base.animation.Play("a");
	}

	[RPC]
	public override void IDLE()
	{
		@base.animation.Play("i");
	}
}
