/* _________________________________________________

  (c) Hi-Integrity Systems 2012. All rights reserved.
  www.hisystems.com.au - Toby Wicks
  github.com/hisystems/Interpreter
 
  Licensed under the Apache License, Version 2.0 (the "License");
  you may not use this file except in compliance with the License.
  You may obtain a copy of the License at

      http://www.apache.org/licenses/LICENSE-2.0

  Unless required by applicable law or agreed to in writing, software
  distributed under the License is distributed on an "AS IS" BASIS,
  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
  See the License for the specific language governing permissions and
  limitations under the License.
 ___________________________________________________ */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HiSystems.Interpreter
{
    /// <summary>
    /// Based on the condition / expression returns the true or false result.
    /// Usage: If(condition, trueResult, falseResult)
    /// Example: If(1 = 1, 'Yes', 'No') 
    /// </summary>
    public class If : Function
    {
        public override string Name
        {
            get
            {
                return "If";
            }
        }

        public override Literal Execute(IConstruct[] arguments)
        {
            base.EnsureArgumentCountIs(arguments, 3);

            var condition = base.GetTransformedArgument<Boolean>(arguments, argumentIndex: 0);

            if (condition)
                return base.GetTransformedArgument<Literal>(arguments, argumentIndex: 1);
            else 
                return base.GetTransformedArgument<Literal>(arguments, argumentIndex: 2);
        }
    }
}
