using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAnalysis
{
  public class SomeClass
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "i")]
    public void DoSomething(int count, int i)
    {
      var newCount = countUp(count);
    }

    private int countUp(int count)
    {
      return count + 1;
    }

    private static void UnUseMethod()
    {
    }
  }
}
