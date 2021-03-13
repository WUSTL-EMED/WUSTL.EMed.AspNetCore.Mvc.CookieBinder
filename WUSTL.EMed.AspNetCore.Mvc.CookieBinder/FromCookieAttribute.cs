// <copyright file="FromCookieAttribute.cs" company="Washington University in St. Louis">
// Copyright (c) 2021 Washington University in St. Louis. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// </copyright>

namespace WUSTL.EMed.AspNetCore.Mvc.CookieBinder
{
    using System;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using WUSTL.EMed.AspNetCore.Mvc.CookieBinder.ModelBinders;

    /// <summary>
    /// Specifies that a parameter or property should be bound using the request cookies.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class FromCookieAttribute : Attribute, IModelNameProvider, IBinderTypeProviderMetadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FromCookieAttribute"/> class.
        /// </summary>
        /// <param name="name">The name of the cookie to bind using.</param>
        public FromCookieAttribute(string name)
        {
            Name = name;
        }

        /// <inheritdoc/>
        public Type BinderType => typeof(CookieModelBinder);

        /// <inheritdoc/>
        public BindingSource BindingSource => CookieModelBinder.BindingSource;

        /// <inheritdoc/>
        public string Name { get; }
    }
}
