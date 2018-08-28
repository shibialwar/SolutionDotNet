using KC.SPARTA.Interface.Business;

namespace KC.SPARTA.Rule
{
   public class EMEARule:IRule
    {
        public int Calculate(int A, int B)
        {
            return (A * B);
        }
    }
}
