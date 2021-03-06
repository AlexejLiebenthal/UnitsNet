﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToForcePerLength
{
    public static class NumberToForcePerLengthExtensions
    {
        #region CentinewtonPerMeter

        /// <inheritdoc cref="ForcePerLength.FromCentinewtonsPerMeter(UnitsNet.QuantityValue)" />
        public static ForcePerLength CentinewtonsPerMeter<T>(this T value) => ForcePerLength.FromCentinewtonsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromCentinewtonsPerMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static ForcePerLength? CentinewtonsPerMeter<T>(this T? value) where T : struct => ForcePerLength.FromCentinewtonsPerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecinewtonPerMeter

        /// <inheritdoc cref="ForcePerLength.FromDecinewtonsPerMeter(UnitsNet.QuantityValue)" />
        public static ForcePerLength DecinewtonsPerMeter<T>(this T value) => ForcePerLength.FromDecinewtonsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromDecinewtonsPerMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static ForcePerLength? DecinewtonsPerMeter<T>(this T? value) where T : struct => ForcePerLength.FromDecinewtonsPerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramForcePerMeter

        /// <inheritdoc cref="ForcePerLength.FromKilogramsForcePerMeter(UnitsNet.QuantityValue)" />
        public static ForcePerLength KilogramsForcePerMeter<T>(this T value) => ForcePerLength.FromKilogramsForcePerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromKilogramsForcePerMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static ForcePerLength? KilogramsForcePerMeter<T>(this T? value) where T : struct => ForcePerLength.FromKilogramsForcePerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilonewtonPerMeter

        /// <inheritdoc cref="ForcePerLength.FromKilonewtonsPerMeter(UnitsNet.QuantityValue)" />
        public static ForcePerLength KilonewtonsPerMeter<T>(this T value) => ForcePerLength.FromKilonewtonsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromKilonewtonsPerMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static ForcePerLength? KilonewtonsPerMeter<T>(this T? value) where T : struct => ForcePerLength.FromKilonewtonsPerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MeganewtonPerMeter

        /// <inheritdoc cref="ForcePerLength.FromMeganewtonsPerMeter(UnitsNet.QuantityValue)" />
        public static ForcePerLength MeganewtonsPerMeter<T>(this T value) => ForcePerLength.FromMeganewtonsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromMeganewtonsPerMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static ForcePerLength? MeganewtonsPerMeter<T>(this T? value) where T : struct => ForcePerLength.FromMeganewtonsPerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicronewtonPerMeter

        /// <inheritdoc cref="ForcePerLength.FromMicronewtonsPerMeter(UnitsNet.QuantityValue)" />
        public static ForcePerLength MicronewtonsPerMeter<T>(this T value) => ForcePerLength.FromMicronewtonsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromMicronewtonsPerMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static ForcePerLength? MicronewtonsPerMeter<T>(this T? value) where T : struct => ForcePerLength.FromMicronewtonsPerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillinewtonPerMeter

        /// <inheritdoc cref="ForcePerLength.FromMillinewtonsPerMeter(UnitsNet.QuantityValue)" />
        public static ForcePerLength MillinewtonsPerMeter<T>(this T value) => ForcePerLength.FromMillinewtonsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromMillinewtonsPerMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static ForcePerLength? MillinewtonsPerMeter<T>(this T? value) where T : struct => ForcePerLength.FromMillinewtonsPerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanonewtonPerMeter

        /// <inheritdoc cref="ForcePerLength.FromNanonewtonsPerMeter(UnitsNet.QuantityValue)" />
        public static ForcePerLength NanonewtonsPerMeter<T>(this T value) => ForcePerLength.FromNanonewtonsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromNanonewtonsPerMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static ForcePerLength? NanonewtonsPerMeter<T>(this T? value) where T : struct => ForcePerLength.FromNanonewtonsPerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NewtonPerMeter

        /// <inheritdoc cref="ForcePerLength.FromNewtonsPerMeter(UnitsNet.QuantityValue)" />
        public static ForcePerLength NewtonsPerMeter<T>(this T value) => ForcePerLength.FromNewtonsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromNewtonsPerMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static ForcePerLength? NewtonsPerMeter<T>(this T? value) where T : struct => ForcePerLength.FromNewtonsPerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
