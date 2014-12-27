using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeAnalysis
{
  public class someClass
  {
    public void doSomething(int count, int i)
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
