﻿// Copyright (c) 2012 Artem Abashev (http://abashev.me)
// All rights reserved.
// Licensed under the Microsoft Public License (Ms-PL)
// http://opensource.org/licenses/ms-pl.html

using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using DotAmf.ServiceModel.Dispatcher;

namespace DotAmf.ServiceModel.Description
{
    /// <summary>
    /// Enables the AMF support for an operation.
    /// </summary>
    sealed internal class AmfOperationBehavior : IOperationBehavior
    {
        #region IOperationBehavior implementation
        /// <summary>
        /// Implements a modification or extension of the service across an operation.
        /// </summary>
        /// <param name="operationDescription">The operation being examined. Use for examination only. 
        /// If the operation description is modified, the results are undefined.</param>
        /// <param name="dispatchOperation">The run-time object that exposes customization properties 
        /// for the operation described by <c>operationDescription</c>.</param>
        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
        {
            dispatchOperation.Formatter = new AmfGenericOperationFormatter();
        }

        public void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
        {
        }

        public void Validate(OperationDescription operationDescription)
        {
        }
        #endregion
    }
}
