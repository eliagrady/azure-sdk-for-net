// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// A pool in the Azure Batch service.
    /// </summary>
    public partial class CloudPool
    {
        /// <summary>
        /// Initializes a new instance of the CloudPool class.
        /// </summary>
        public CloudPool() { }

        /// <summary>
        /// Initializes a new instance of the CloudPool class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the pool within
        /// the account.</param>
        /// <param name="displayName">The display name for the pool.</param>
        /// <param name="url">The URL of the pool.</param>
        /// <param name="eTag">The ETag of the pool.</param>
        /// <param name="lastModified">The last modified time of the
        /// pool.</param>
        /// <param name="creationTime">The creation time of the pool.</param>
        /// <param name="state">The current state of the pool.</param>
        /// <param name="stateTransitionTime">The time at which the pool
        /// entered its current state.</param>
        /// <param name="allocationState">Whether the pool is resizing.</param>
        /// <param name="allocationStateTransitionTime">The time at which the
        /// pool entered its current allocation state.</param>
        /// <param name="vmSize">The size of virtual machines in the pool. All
        /// virtual machines in a pool are the same size.</param>
        /// <param name="cloudServiceConfiguration">The cloud service
        /// configuration for the pool.</param>
        /// <param name="virtualMachineConfiguration">The virtual machine
        /// configuration for the pool.</param>
        /// <param name="resizeTimeout">The timeout for allocation of compute
        /// nodes to the pool.</param>
        /// <param name="resizeError">Details of any error encountered while
        /// performing the last resize on the pool.</param>
        /// <param name="currentDedicated">The number of compute nodes
        /// currently in the pool.</param>
        /// <param name="targetDedicated">The desired number of compute nodes
        /// in the pool.</param>
        /// <param name="enableAutoScale">Whether the pool size should
        /// automatically adjust over time.</param>
        /// <param name="autoScaleFormula">A formula for the desired number of
        /// compute nodes in the pool.</param>
        /// <param name="autoScaleEvaluationInterval">The time interval at
        /// which to automatically adjust the pool size according to the
        /// autoscale formula.</param>
        /// <param name="autoScaleRun">The results and errors from the last
        /// execution of the autoscale formula.</param>
        /// <param name="enableInterNodeCommunication">Whether the pool
        /// permits direct communication between nodes.</param>
        /// <param name="networkConfiguration">The network configuration for
        /// the pool.</param>
        /// <param name="startTask">A task specified to run on each compute
        /// node as it joins the pool.</param>
        /// <param name="certificateReferences">The list of certificates to be
        /// installed on each compute node in the pool.</param>
        /// <param name="applicationPackageReferences">The list of application
        /// packages to be installed on each compute node in the pool.</param>
        /// <param name="maxTasksPerNode">The maximum number of tasks that can
        /// run concurrently on a single compute node in the pool.</param>
        /// <param name="taskSchedulingPolicy">How the Batch service
        /// distributes tasks between compute nodes in the pool.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the pool as metadata.</param>
        /// <param name="stats">Utilization and resource usage statistics for
        /// the entire lifetime of the pool.</param>
        public CloudPool(string id = default(string), string displayName = default(string), string url = default(string), string eTag = default(string), System.DateTime? lastModified = default(System.DateTime?), System.DateTime? creationTime = default(System.DateTime?), PoolState? state = default(PoolState?), System.DateTime? stateTransitionTime = default(System.DateTime?), AllocationState? allocationState = default(AllocationState?), System.DateTime? allocationStateTransitionTime = default(System.DateTime?), string vmSize = default(string), CloudServiceConfiguration cloudServiceConfiguration = default(CloudServiceConfiguration), VirtualMachineConfiguration virtualMachineConfiguration = default(VirtualMachineConfiguration), System.TimeSpan? resizeTimeout = default(System.TimeSpan?), ResizeError resizeError = default(ResizeError), int? currentDedicated = default(int?), int? targetDedicated = default(int?), bool? enableAutoScale = default(bool?), string autoScaleFormula = default(string), System.TimeSpan? autoScaleEvaluationInterval = default(System.TimeSpan?), AutoScaleRun autoScaleRun = default(AutoScaleRun), bool? enableInterNodeCommunication = default(bool?), NetworkConfiguration networkConfiguration = default(NetworkConfiguration), StartTask startTask = default(StartTask), System.Collections.Generic.IList<CertificateReference> certificateReferences = default(System.Collections.Generic.IList<CertificateReference>), System.Collections.Generic.IList<ApplicationPackageReference> applicationPackageReferences = default(System.Collections.Generic.IList<ApplicationPackageReference>), int? maxTasksPerNode = default(int?), TaskSchedulingPolicy taskSchedulingPolicy = default(TaskSchedulingPolicy), System.Collections.Generic.IList<MetadataItem> metadata = default(System.Collections.Generic.IList<MetadataItem>), PoolStatistics stats = default(PoolStatistics))
        {
            Id = id;
            DisplayName = displayName;
            Url = url;
            ETag = eTag;
            LastModified = lastModified;
            CreationTime = creationTime;
            State = state;
            StateTransitionTime = stateTransitionTime;
            AllocationState = allocationState;
            AllocationStateTransitionTime = allocationStateTransitionTime;
            VmSize = vmSize;
            CloudServiceConfiguration = cloudServiceConfiguration;
            VirtualMachineConfiguration = virtualMachineConfiguration;
            ResizeTimeout = resizeTimeout;
            ResizeError = resizeError;
            CurrentDedicated = currentDedicated;
            TargetDedicated = targetDedicated;
            EnableAutoScale = enableAutoScale;
            AutoScaleFormula = autoScaleFormula;
            AutoScaleEvaluationInterval = autoScaleEvaluationInterval;
            AutoScaleRun = autoScaleRun;
            EnableInterNodeCommunication = enableInterNodeCommunication;
            NetworkConfiguration = networkConfiguration;
            StartTask = startTask;
            CertificateReferences = certificateReferences;
            ApplicationPackageReferences = applicationPackageReferences;
            MaxTasksPerNode = maxTasksPerNode;
            TaskSchedulingPolicy = taskSchedulingPolicy;
            Metadata = metadata;
            Stats = stats;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the pool within the
        /// account.
        /// </summary>
        /// <remarks>
        /// The ID can contain any combination of alphanumeric characters
        /// including hyphens and underscores, and cannot contain more than
        /// 64 characters. It is common to use a GUID for the id.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the pool.
        /// </summary>
        /// <remarks>
        /// The display name need not be unique and can contain any Unicode
        /// characters up to a maximum length of 1024.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the URL of the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the pool.
        /// </summary>
        /// <remarks>
        /// This is an opaque string. You can use it to detect whether the
        /// pool has changed between requests. In particular, you can be pass
        /// the ETag when updating a pool to specify that your changes should
        /// take effect only if nobody else has modified the pool in the
        /// meantime.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the last modified time of the pool.
        /// </summary>
        /// <remarks>
        /// This is the last time at which the pool level data, such as the
        /// targetDedicated or enableAutoscale settings, changed. It does not
        /// factor in node-level changes such as a compute node changing
        /// state.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastModified")]
        public System.DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the current state of the pool.
        /// </summary>
        /// <remarks>
        /// Possible values are: active – The pool is available to run tasks
        /// subject to the availability of compute nodes. deleting – The user
        /// has requested that the pool be deleted, but the delete operation
        /// has not yet completed. upgrading – The user has requested that
        /// the operating system of the pool's nodes be upgraded, but the
        /// upgrade operation has not yet completed (that is, some nodes in
        /// the pool have not yet been upgraded). While upgrading, the pool
        /// may be able to run tasks (with reduced capacity) but this is not
        /// guaranteed. Possible values include: 'active', 'deleting',
        /// 'upgrading'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public PoolState? State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the pool entered its current state.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "stateTransitionTime")]
        public System.DateTime? StateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets whether the pool is resizing.
        /// </summary>
        /// <remarks>
        /// Possible values are: steady – The pool is not resizing. There are
        /// no changes to the number of nodes in the pool in progress. A pool
        /// enters this state when it is created and when no operations are
        /// being performed on the pool to change the number of dedicated
        /// nodes. resizing - The pool is resizing; that is, compute nodes
        /// are being added to or removed from the pool. stopping - The pool
        /// was resizing, but the user has requested that the resize be
        /// stopped, but the stop request has not yet been completed.
        /// Possible values include: 'steady', 'resizing', 'stopping'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "allocationState")]
        public AllocationState? AllocationState { get; set; }

        /// <summary>
        /// Gets or sets the time at which the pool entered its current
        /// allocation state.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "allocationStateTransitionTime")]
        public System.DateTime? AllocationStateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the size of virtual machines in the pool. All virtual
        /// machines in a pool are the same size.
        /// </summary>
        /// <remarks>
        /// For information about available sizes of virtual machines for
        /// Cloud Services pools (pools created with
        /// cloudServiceConfiguration), see Sizes for Cloud Services
        /// (http://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/).
        /// Batch supports all Cloud Services VM sizes except ExtraSmall. For
        /// information about available VM sizes for pools using images from
        /// the Virtual Machines Marketplace (pools created with
        /// virtualMachineConfiguration) see Sizes for Virtual Machines
        /// (Linux)
        /// (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/)
        /// or Sizes for Virtual Machines (Windows)
        /// (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/).
        /// Batch supports all Azure VM sizes except STANDARD_A0 and those
        /// with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2
        /// series).
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets the cloud service configuration for the pool.
        /// </summary>
        /// <remarks>
        /// This property and virtualMachineConfiguration are mutually
        /// exclusive and one of the properties must be specified.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "cloudServiceConfiguration")]
        public CloudServiceConfiguration CloudServiceConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine configuration for the pool.
        /// </summary>
        /// <remarks>
        /// This property and cloudServiceConfiguration are mutually exclusive
        /// and one of the properties must be specified.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "virtualMachineConfiguration")]
        public VirtualMachineConfiguration VirtualMachineConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the timeout for allocation of compute nodes to the
        /// pool.
        /// </summary>
        /// <remarks>
        /// This is the timeout for the most recent resize operation. (The
        /// initial sizing when the pool is created counts as a resize.) The
        /// default value is 15 minutes.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resizeTimeout")]
        public System.TimeSpan? ResizeTimeout { get; set; }

        /// <summary>
        /// Gets or sets details of any error encountered while performing the
        /// last resize on the pool.
        /// </summary>
        /// <remarks>
        /// This property is set only if an error occurred during the last
        /// pool resize, and only when the pool allocationState is Steady.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resizeError")]
        public ResizeError ResizeError { get; set; }

        /// <summary>
        /// Gets or sets the number of compute nodes currently in the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "currentDedicated")]
        public int? CurrentDedicated { get; set; }

        /// <summary>
        /// Gets or sets the desired number of compute nodes in the pool.
        /// </summary>
        /// <remarks>
        /// This property is not set if enableAutoScale is true. It is
        /// required if enableAutoScale is false.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetDedicated")]
        public int? TargetDedicated { get; set; }

        /// <summary>
        /// Gets or sets whether the pool size should automatically adjust
        /// over time.
        /// </summary>
        /// <remarks>
        /// If true, the autoScaleFormula property must be set. If false, the
        /// targetDedicated property must be set.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enableAutoScale")]
        public bool? EnableAutoScale { get; set; }

        /// <summary>
        /// Gets or sets a formula for the desired number of compute nodes in
        /// the pool.
        /// </summary>
        /// <remarks>
        /// This property is set only if the pool automatically scales, i.e.
        /// enableAutoScale is true.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "autoScaleFormula")]
        public string AutoScaleFormula { get; set; }

        /// <summary>
        /// Gets or sets the time interval at which to automatically adjust
        /// the pool size according to the autoscale formula.
        /// </summary>
        /// <remarks>
        /// This property is set only if the pool automatically scales, i.e.
        /// enableAutoScale is true.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "autoScaleEvaluationInterval")]
        public System.TimeSpan? AutoScaleEvaluationInterval { get; set; }

        /// <summary>
        /// Gets or sets the results and errors from the last execution of the
        /// autoscale formula.
        /// </summary>
        /// <remarks>
        /// This property is set only if the pool automatically scales, i.e.
        /// enableAutoScale is true.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "autoScaleRun")]
        public AutoScaleRun AutoScaleRun { get; set; }

        /// <summary>
        /// Gets or sets whether the pool permits direct communication between
        /// nodes.
        /// </summary>
        /// <remarks>
        /// This imposes restrictions on which nodes can be assigned to the
        /// pool. Specifying this value can reduce the chance of the
        /// requested number of nodes to be allocated in the pool.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enableInterNodeCommunication")]
        public bool? EnableInterNodeCommunication { get; set; }

        /// <summary>
        /// Gets or sets the network configuration for the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "networkConfiguration")]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Gets or sets a task specified to run on each compute node as it
        /// joins the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTask")]
        public StartTask StartTask { get; set; }

        /// <summary>
        /// Gets or sets the list of certificates to be installed on each
        /// compute node in the pool.
        /// </summary>
        /// <remarks>
        /// For Windows compute nodes, the Batch service installs the
        /// certificates to the specified certificate store and location. For
        /// Linux compute nodes, the certificates are stored in a directory
        /// inside the task working directory and an environment variable
        /// AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for
        /// this location. For certificates with visibility of 'remoteuser',
        /// a 'certs' directory is created in the user's home directory
        /// (e.g., /home/{user-name}/certs) and certificates are placed in
        /// that directory.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "certificateReferences")]
        public System.Collections.Generic.IList<CertificateReference> CertificateReferences { get; set; }

        /// <summary>
        /// Gets or sets the list of application packages to be installed on
        /// each compute node in the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "applicationPackageReferences")]
        public System.Collections.Generic.IList<ApplicationPackageReference> ApplicationPackageReferences { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of tasks that can run concurrently
        /// on a single compute node in the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maxTasksPerNode")]
        public int? MaxTasksPerNode { get; set; }

        /// <summary>
        /// Gets or sets how the Batch service distributes tasks between
        /// compute nodes in the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "taskSchedulingPolicy")]
        public TaskSchedulingPolicy TaskSchedulingPolicy { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the pool
        /// as metadata.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Gets or sets utilization and resource usage statistics for the
        /// entire lifetime of the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "stats")]
        public PoolStatistics Stats { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.CloudServiceConfiguration != null)
            {
                this.CloudServiceConfiguration.Validate();
            }
            if (this.VirtualMachineConfiguration != null)
            {
                this.VirtualMachineConfiguration.Validate();
            }
            if (this.AutoScaleRun != null)
            {
                this.AutoScaleRun.Validate();
            }
            if (this.StartTask != null)
            {
                this.StartTask.Validate();
            }
            if (this.CertificateReferences != null)
            {
                foreach (var element in this.CertificateReferences)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.ApplicationPackageReferences != null)
            {
                foreach (var element1 in this.ApplicationPackageReferences)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.TaskSchedulingPolicy != null)
            {
                this.TaskSchedulingPolicy.Validate();
            }
            if (this.Metadata != null)
            {
                foreach (var element2 in this.Metadata)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (this.Stats != null)
            {
                this.Stats.Validate();
            }
        }
    }
}
