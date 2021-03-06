﻿/*
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

namespace BME.MIT.SETTE.Basic.B1
{
    public static class B1a_PrimitiveTypes
    {
        public static bool oneParambool(bool x)
        {
            return !x;
        }

        public static bool twoParambool(bool x, bool y)
        {
            return x ^ y;
        }

        public static byte oneParamByte(byte x)
        {
            return (byte)(x + 1);
        }

        public static byte twoParamByte(byte x, byte y)
        {
            return (byte)(x + y);
        }

        public static short oneParamShort(short x)
        {
            return (short)(x + 1);
        }

        public static short twoParamShort(short x, short y)
        {
            return (short)(x + y);
        }

        public static int oneParamInt(int x)
        {
            return x + 1;
        }

        public static int twoParamInt(int x, int y)
        {
            return x + y;
        }

        public static long oneParamLong(long x)
        {
            return x + 1;
        }

        public static long twoParamLong(long x, long y)
        {
            return x + y;
        }

        public static float oneParamFloat(float x)
        {
            return x + 1;
        }

        public static float twoParamFloat(float x, float y)
        {
            return x + y;
        }

        public static double oneParamDouble(double x)
        {
            return x + 1;
        }

        public static double twoParamDouble(double x, double y)
        {
            return x + y;
        }

        public static char oneParamChar(char x)
        {
            return (char)(x + 1);
        }

        public static char twoParamChar(char x, char y)
        {
            return (char)(x + y);
        }
    }
}
