/*
 * SETTE - Symbolic Execution based Test Tool Evaluator
 *
 * SETTE is a tool to help the evaluation and comparison of symbolic execution
 * based test input generator tools.
 *
 * Budapest University of Technology and Economics (BME)
 *
 * Authors: Lajos Cseppentő <lajos.cseppento@inf.mit.bme.hu>, Zoltán Micskei
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
package hu.bme.mit.sette.snippets._1_basic.B5_functions;

import hu.bme.mit.sette.annotations.SetteIncludeCoverage;
import hu.bme.mit.sette.annotations.SetteRequiredStatementCoverage;
import hu.bme.mit.sette.annotations.SetteSnippetContainer;
import hu.bme.mit.sette.snippets.inputs._1_basic.B5_functions.B5a_CallPrivate_Inputs;

@SetteSnippetContainer(category = "B5",
        goal = "Check support for private function calls",
        inputFactoryContainer = B5a_CallPrivate_Inputs.class)
public final class B5a_CallPrivate {
    private B5a_CallPrivate() {
        throw new UnsupportedOperationException("Static class");
    }

    private static int calledFunction(int x, int y) {
        if (x > 0 && y > 0) {
            return 1;
        } else if (x < 0 && y > 0) {
            return 2;
        } else if (x < 0 && y < 0) {
            return 3;
        } else if (x > 0 && y < 0) {
            return 4;
        } else {
            return -1;
        }
    }

    @SetteRequiredStatementCoverage(value = 100)
    @SetteIncludeCoverage(classes = { B5a_CallPrivate.class },
            methods = { "calledFunction(int, int)" })
    public static int simple(int x, int y) {
        return calledFunction(x, y);
    }

    @SetteRequiredStatementCoverage(value = 100)
    @SetteIncludeCoverage(classes = { B5a_CallPrivate.class },
            methods = { "calledFunction(int, int)" })
    public static int useReturnValue(int x, int y) {
        if (calledFunction(x, y) >= 0) {
            return 1;
        } else {
            return 0;
        }
    }

    @SetteRequiredStatementCoverage(value = 100)
    @SetteIncludeCoverage(classes = { B5a_CallPrivate.class },
            methods = { "calledFunction(int, int)" })
    public static int conditionalCall(int x, int y, boolean z) {
        if (z) {
            return calledFunction(x, y);
        } else {
            return -2;
        }
    }
}
