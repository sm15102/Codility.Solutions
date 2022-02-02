namespace Codility.Solutions.Sorting
{
    /*
    A non-empty array A consisting of N integers is given. The product of triplet (P, Q, R) equates to A[P] * A[Q] * A[R] (0 ≤ P < Q < R < N).

    For example, array A such that:

      A[0] = -3
      A[1] = 1
      A[2] = 2
      A[3] = -2
      A[4] = 5
      A[5] = 6
    contains the following example triplets:

    (0, 1, 2), product is −3 * 1 * 2 = −6
    (1, 2, 4), product is 1 * 2 * 5 = 10
    (2, 4, 5), product is 2 * 5 * 6 = 60
    Your goal is to find the maximal product of any triplet.

    Write a function:

        class Solution { public int solution(int[] A); }

    that, given a non-empty array A, returns the value of the maximal product of any triplet.

    For example, given array A such that:

      A[0] = -3
      A[1] = 1
      A[2] = 2
      A[3] = -2
      A[4] = 5
      A[5] = 6
    the function should return 60, as the product of triplet (2, 4, 5) is maximal.

    Write an efficient algorithm for the following assumptions:

    N is an integer within the range [3..100,000];
    each element of array A is an integer within the range [−1,000..1,000].
     */
    public static class MaxProductOfThree
    {
        public static int Solution(int[] A)
        {
            int[] maxMembers = new int[3]
        {
            int.MinValue,
            int.MinValue,
            int.MinValue,
        };

            int[] minMembers = new int[2]
            {
            int.MaxValue,
            int.MaxValue
            };

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > maxMembers[0])
                {
                    maxMembers[2] = maxMembers[1];
                    maxMembers[1] = maxMembers[0];
                    maxMembers[0] = A[i];

                }
                else if (A[i] > maxMembers[1])
                {
                    maxMembers[2] = maxMembers[1];
                    maxMembers[1] = A[i];

                }
                else if (A[i] > maxMembers[2])
                {
                    maxMembers[2] = A[i];
                }

                if (A[i] < minMembers[0])
                {
                    minMembers[1] = minMembers[0];
                    minMembers[0] = A[i];
                }
                else if (A[i] < minMembers[1])
                {
                    minMembers[1] = A[i];
                }
            }

            return Math.Max(
                maxMembers[0] * maxMembers[1] * maxMembers[2],
                maxMembers[0] * minMembers[0] * minMembers[1]);

        }
    }
}
