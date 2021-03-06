/*
 * SETTE - Symbolic Execution based Test Tool Evaluator
 * 
 * SETTE is a tool to help the evaluation and comparison of symbolic execution
 * based test input generator tools.
 * 
 * Budapest University of Technology and Economics (BME)
 * 
 * Authors: Lajos Cseppento <lajos.cseppento@inf.mit.bme.hu>, Zoltan Micskei
 * <micskeiz@mit.bme.hu>
 * 
 * Copyright 2014
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */

using System;

using BME.MIT.SETTE.Objects.Dependencies;

namespace BME.MIT.SETTE.Objects
{
    public static class O1_Simple
    {
        public static int oneOperationParams(int x)
        {
            SimpleObject obj = new SimpleObject();
            obj.addAbs(x);
            return obj.getResult();
        }

        public static int oneOperationWithCheck(SimpleObject obj, int x)
        {
            if (obj == null)
            {
                return -1;
            }

            obj.addAbs(x);
            return obj.getResult();
        }

        public static int oneOperationNoCheck(SimpleObject obj, int x)
        {
            obj.addAbs(x);
            return obj.getResult();
        }

        public static int twoOperationsParams(int x1, int x2)
        {
            SimpleObject obj = new SimpleObject();
            obj.addAbs(x1);
            return obj.chainedAddAbs(x2).getResult();
        }

        public static int twoOperationsWithCheck(SimpleObject obj, int x1,
                int x2)
        {
            if (obj == null)
            {
                return -1;
            }

            obj.addAbs(x1);
            return obj.chainedAddAbs(x2).getResult();
        }

        public static int twoOperationsWithNocheck(SimpleObject obj,
                int x1, int x2)
        {
            obj.addAbs(x1);
            return obj.chainedAddAbs(x2).getResult();
        }

        public static int guessResultParams(int x1, int x2, int x3)
        {
            SimpleObject obj = new SimpleObject();

            obj.addAbs(x1);
            obj.addAbs(x2);
            obj.addAbs(x3);

            if (obj.getResult() == 10)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int guessResult(SimpleObject obj, int x1, int x2,
                int x3)
        {
            if (obj == null)
            {
                return -1;
            }

            obj.addAbs(x1);
            obj.addAbs(x2);
            obj.addAbs(x3);

            if (obj.getResult() == 10)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //@SetteRequiredStatementCoverage(value = 90)
        public static int guessImpossibleResultParams(int x1, int x2, int x3)
        {
            SimpleObject obj = new SimpleObject();

            obj.addAbs(x1);
            obj.addAbs(x2);
            obj.addAbs(x3);

            if (obj.getResult() < 0)
            {
                // only with overflow
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //@SetteRequiredStatementCoverage(value = 90)
        public static int guessImpossibleResult(SimpleObject obj, int x1,
                int x2, int x3)
        {
            if (obj == null)
            {
                return -1;
            }

            obj.addAbs(x1);
            obj.addAbs(x2);
            obj.addAbs(x3);

            if (obj.getResult() < 0)
            {
                // only with overflow
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int guessOperationCountParams(int oc)
        {
            SimpleObject obj = new SimpleObject();

            for (int i = 0; i < oc; i++)
            {
                obj.addAbs(1);
            }

            if (obj.getOperationCount() == 5)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int guessOperationCount(SimpleObject obj, int oc)
        {
            if (obj == null)
            {
                return -1;
            }

            for (int i = 0; i < oc; i++)
            {
                obj.addAbs(1);
            }

            if (obj.getOperationCount() == 5)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //@SetteRequiredStatementCoverage(value = 85)
        public static int guessImpossibleOperationCountParams(int oc)
        {
            SimpleObject obj = new SimpleObject();

            for (int i = 0; i < oc; i++)
            {
                obj.addAbs(1);
            }

            if (obj.getOperationCount() < 0)
            {
                // only with overflow
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //@SetteRequiredStatementCoverage(value = 87)
        public static int guessImpossibleOperationCount(SimpleObject obj,
                int oc)
        {
            if (obj == null)
            {
                return -1;
            }

            for (int i = 0; i < oc; i++)
            {
                obj.addAbs(1);
            }

            if (obj.getOperationCount() < 0)
            {
                // impossible
                throw new Exception();
            }
            else
            {
                return 0;
            }
        }

        public static int guessResultAndOperationCountParams(int x, int oc)
        {
            SimpleObject obj = new SimpleObject();

            for (int i = 0; i < oc; i++)
            {
                obj.addAbs(x);
            }

            if (obj.getResult() == 10 && obj.getOperationCount() == 5)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int guessResultAndOperationCount(SimpleObject obj,
                int x, int oc)
        {
            if (obj == null)
            {
                return -1;
            }

            for (int i = 0; i < oc; i++)
            {
                obj.addAbs(x);
            }

            if (obj.getResult() == 10 && obj.getOperationCount() == 5)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //@SetteRequiredStatementCoverage(value = 75)
        public static int guessImpossibleResultAndOperationCountParams(
                int x, int oc)
        {
            SimpleObject obj = new SimpleObject();

            for (int i = 0; i < oc; i++)
            {
                obj.addAbs(x);
            }

            if (obj.getResult() == 10 && obj.getOperationCount() == 4)
            {
                // impossible
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //@SetteRequiredStatementCoverage(value = 80)
        public static int guessImpossibleResultAndOperationCount(
                SimpleObject obj, int x, int oc)
        {
            if (obj == null)
            {
                return -1;
            }

            for (int i = 0; i < oc; i++)
            {
                obj.addAbs(x);
            }

            if (obj.getResult() == 10 && obj.getOperationCount() == 4)
            {
                // impossible
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int guessObject(SimpleObject obj)
        {
            if (obj == null)
            {
                return -1;
            }

            if (obj.getOperationCount() == 2 && obj.getResult() == 3)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //@SetteRequiredStatementCoverage(value = 66)
        public static int guessImpossibleObject(SimpleObject obj)
        {
            if (obj == null)
            {
                return -1;
            }

            if (obj.getOperationCount() < 0 || obj.getResult() < 0)
            {
                // invalid object, cannot be created with method call, only via
                // reflection or overflow
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int fullCoverage(SimpleObject obj, int x1, int x2,
        int oc)
        {
            if (obj == null)
            {
                return -1;
            }

            obj.chainedAddAbs(x1).addAbs(x2);

            if (obj.getResult() == 10 && oc == obj.getOperationCount())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}