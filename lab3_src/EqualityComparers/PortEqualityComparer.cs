using System.Diagnostics.CodeAnalysis;
using lab3_src.Models.Port;

namespace lab3_src.EqualityComparers;

internal class PortEqualityComparer : IEqualityComparer<Port>
{
    public bool Equals(Port? x, Port? y)
    {
        if (x == null && y == null) return true;
        if (x == null || y == null) return false;

        return x.Equals(y);
    }

    public int GetHashCode([DisallowNull] Port obj)
    {
        return obj.GetHashCode();
    }
}
