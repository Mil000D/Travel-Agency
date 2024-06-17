using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;

namespace MASProject.Server.Comparers
{
    public class ListOfStringsComparer : ValueComparer<List<string>>
    {
        public ListOfStringsComparer() : base(
            (c1, c2) => c1.SequenceEqual(c2),
            c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList())
        {
        }
    }
}