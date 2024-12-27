namespace LeetCode
{
    public abstract class LeetQ
    {
        public virtual void TestCases()
        {
            Helper.TestSummary(GetType().Name);
        }
    }
}