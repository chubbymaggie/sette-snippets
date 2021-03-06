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
package hu.bme.mit.sette.snippets._3_objects.dependencies;

import hu.bme.mit.sette.annotations.SetteDependency;

/**
 * The delegate object type used by the code snippets O2.
 */
@SetteDependency
public class SimpleObjectDelegate {
    private final SimpleObject simpleObject;

    public SimpleObjectDelegate(SimpleObject so) {
        simpleObject = so;
    }

    public void addAbs(int x) {
        simpleObject.addAbs(x);
    }

    public int getResult() {
        return simpleObject.getResult();
    }
}
