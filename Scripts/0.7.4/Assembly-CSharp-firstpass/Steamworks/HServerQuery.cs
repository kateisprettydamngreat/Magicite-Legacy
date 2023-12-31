namespace Steamworks;

public struct HServerQuery
{
	public static readonly HServerQuery Invalid = new HServerQuery(uint.MaxValue);

	public uint m_HServerQuery;

	public HServerQuery(uint value)
	{
		m_HServerQuery = value;
	}

	public override string ToString()
	{
		return m_HServerQuery.ToString();
	}
}
