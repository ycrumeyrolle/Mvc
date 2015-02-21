﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;

namespace CorsWebSite
{
    public class Product
    {
        [Range(10, 100)]
        public int SampleInt { get; set; }

        [MinLength(15)]
        public string SampleString { get; set; }
    }
}