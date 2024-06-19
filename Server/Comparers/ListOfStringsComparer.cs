using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MASProject.Server.Comparers
{
    /// <summary>
    /// Custom value comparer for lists of strings.
    /// </summary>
    public class ListOfStringsComparer : ValueComparer<List<string>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfStringsComparer"/> class.
        /// </summary>
        public ListOfStringsComparer() : base(
            (c1, c2) => c1.SequenceEqual(c2),
            c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList())
        {
        }
    }
}