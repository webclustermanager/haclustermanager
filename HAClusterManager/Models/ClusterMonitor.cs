using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HAClusterManager.Cluster.Monitor
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class crm_mon
    {

        /// <remarks/>
        public crm_monSummary summary { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("node", IsNullable = false)]
        public crm_monNode[] nodes { get; set; }

        /// <remarks/>
        public crm_monResources resources { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("node", IsNullable = false)]
        public crm_monNode1[] node_attributes { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("node", IsNullable = false)]
        public crm_monNode2[] node_history { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("failure", IsNullable = false)]
        public crm_monFailure[] failures { get; set; }

        /// <remarks/>
        public object tickets { get; set; }

        /// <remarks/>
        public object bans { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monSummary
    {

        private crm_monSummaryStack stackField;

        private crm_monSummaryCurrent_dc current_dcField;

        private crm_monSummaryLast_update last_updateField;

        private crm_monSummaryLast_change last_changeField;

        private crm_monSummaryNodes_configured nodes_configuredField;

        private crm_monSummaryResources_configured resources_configuredField;

        private crm_monSummaryCluster_options cluster_optionsField;

        /// <remarks/>
        public crm_monSummaryStack stack
        {
            get
            {
                return this.stackField;
            }
            set
            {
                this.stackField = value;
            }
        }

        /// <remarks/>
        public crm_monSummaryCurrent_dc current_dc
        {
            get
            {
                return this.current_dcField;
            }
            set
            {
                this.current_dcField = value;
            }
        }

        /// <remarks/>
        public crm_monSummaryLast_update last_update
        {
            get
            {
                return this.last_updateField;
            }
            set
            {
                this.last_updateField = value;
            }
        }

        /// <remarks/>
        public crm_monSummaryLast_change last_change
        {
            get
            {
                return this.last_changeField;
            }
            set
            {
                this.last_changeField = value;
            }
        }

        /// <remarks/>
        public crm_monSummaryNodes_configured nodes_configured
        {
            get
            {
                return this.nodes_configuredField;
            }
            set
            {
                this.nodes_configuredField = value;
            }
        }

        /// <remarks/>
        public crm_monSummaryResources_configured resources_configured
        {
            get
            {
                return this.resources_configuredField;
            }
            set
            {
                this.resources_configuredField = value;
            }
        }

        /// <remarks/>
        public crm_monSummaryCluster_options cluster_options
        {
            get
            {
                return this.cluster_optionsField;
            }
            set
            {
                this.cluster_optionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monSummaryStack
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monSummaryCurrent_dc
    {

        private bool presentField;

        private string versionField;

        private string nameField;

        private byte idField;

        private bool with_quorumField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool with_quorum
        {
            get
            {
                return this.with_quorumField;
            }
            set
            {
                this.with_quorumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monSummaryLast_update
    {

        private string timeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monSummaryLast_change
    {

        private string timeField;

        private string userField;

        private string clientField;

        private string originField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string user
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string client
        {
            get
            {
                return this.clientField;
            }
            set
            {
                this.clientField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origin
        {
            get
            {
                return this.originField;
            }
            set
            {
                this.originField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monSummaryNodes_configured
    {

        private byte numberField;

        private string expected_votesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expected_votes
        {
            get
            {
                return this.expected_votesField;
            }
            set
            {
                this.expected_votesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monSummaryResources_configured
    {

        private byte numberField;

        private byte disabledField;

        private byte blockedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte disabled
        {
            get
            {
                return this.disabledField;
            }
            set
            {
                this.disabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte blocked
        {
            get
            {
                return this.blockedField;
            }
            set
            {
                this.blockedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monSummaryCluster_options
    {

        private bool stonithenabledField;

        private bool symmetricclusterField;

        private string noquorumpolicyField;

        private bool maintenancemodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("stonith-enabled")]
        public bool stonithenabled
        {
            get
            {
                return this.stonithenabledField;
            }
            set
            {
                this.stonithenabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("symmetric-cluster")]
        public bool symmetriccluster
        {
            get
            {
                return this.symmetricclusterField;
            }
            set
            {
                this.symmetricclusterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("no-quorum-policy")]
        public string noquorumpolicy
        {
            get
            {
                return this.noquorumpolicyField;
            }
            set
            {
                this.noquorumpolicyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("maintenance-mode")]
        public bool maintenancemode
        {
            get
            {
                return this.maintenancemodeField;
            }
            set
            {
                this.maintenancemodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monNode
    {

        private string nameField;

        private byte idField;

        private bool onlineField;

        private bool standbyField;

        private bool standby_onfailField;

        private bool maintenanceField;

        private bool pendingField;

        private bool uncleanField;

        private bool shutdownField;

        private bool expected_upField;

        private bool is_dcField;

        private byte resources_runningField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool online
        {
            get
            {
                return this.onlineField;
            }
            set
            {
                this.onlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool standby
        {
            get
            {
                return this.standbyField;
            }
            set
            {
                this.standbyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool standby_onfail
        {
            get
            {
                return this.standby_onfailField;
            }
            set
            {
                this.standby_onfailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool maintenance
        {
            get
            {
                return this.maintenanceField;
            }
            set
            {
                this.maintenanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool pending
        {
            get
            {
                return this.pendingField;
            }
            set
            {
                this.pendingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool unclean
        {
            get
            {
                return this.uncleanField;
            }
            set
            {
                this.uncleanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool shutdown
        {
            get
            {
                return this.shutdownField;
            }
            set
            {
                this.shutdownField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool expected_up
        {
            get
            {
                return this.expected_upField;
            }
            set
            {
                this.expected_upField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool is_dc
        {
            get
            {
                return this.is_dcField;
            }
            set
            {
                this.is_dcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte resources_running
        {
            get
            {
                return this.resources_runningField;
            }
            set
            {
                this.resources_runningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monResources
    {

        private crm_monResourcesGroup groupField;

        private crm_monResourcesClone[] cloneField;

        /// <remarks/>
        public crm_monResourcesGroup group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("clone")]
        public crm_monResourcesClone[] clone
        {
            get
            {
                return this.cloneField;
            }
            set
            {
                this.cloneField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monResourcesGroup
    {

        private crm_monResourcesGroupResource[] resourceField;

        private string idField;

        private byte number_resourcesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resource")]
        public crm_monResourcesGroupResource[] resource
        {
            get
            {
                return this.resourceField;
            }
            set
            {
                this.resourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte number_resources
        {
            get
            {
                return this.number_resourcesField;
            }
            set
            {
                this.number_resourcesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monResourcesGroupResource
    {

        private crm_monResourcesGroupResourceNode nodeField;

        private string idField;

        private string resource_agentField;

        private string roleField;

        private bool activeField;

        private bool orphanedField;

        private bool blockedField;

        private bool managedField;

        private bool failedField;

        private bool failure_ignoredField;

        private byte nodes_running_onField;

        /// <remarks/>
        public crm_monResourcesGroupResourceNode node
        {
            get
            {
                return this.nodeField;
            }
            set
            {
                this.nodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resource_agent
        {
            get
            {
                return this.resource_agentField;
            }
            set
            {
                this.resource_agentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool orphaned
        {
            get
            {
                return this.orphanedField;
            }
            set
            {
                this.orphanedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool blocked
        {
            get
            {
                return this.blockedField;
            }
            set
            {
                this.blockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool managed
        {
            get
            {
                return this.managedField;
            }
            set
            {
                this.managedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool failed
        {
            get
            {
                return this.failedField;
            }
            set
            {
                this.failedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool failure_ignored
        {
            get
            {
                return this.failure_ignoredField;
            }
            set
            {
                this.failure_ignoredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte nodes_running_on
        {
            get
            {
                return this.nodes_running_onField;
            }
            set
            {
                this.nodes_running_onField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monResourcesGroupResourceNode
    {

        private string nameField;

        private byte idField;

        private bool cachedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool cached
        {
            get
            {
                return this.cachedField;
            }
            set
            {
                this.cachedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monResourcesClone
    {

        private crm_monResourcesCloneResource[] resourceField;

        private string idField;

        private bool multi_stateField;

        private bool uniqueField;

        private bool managedField;

        private bool failedField;

        private bool failure_ignoredField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resource")]
        public crm_monResourcesCloneResource[] resource
        {
            get
            {
                return this.resourceField;
            }
            set
            {
                this.resourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool multi_state
        {
            get
            {
                return this.multi_stateField;
            }
            set
            {
                this.multi_stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool unique
        {
            get
            {
                return this.uniqueField;
            }
            set
            {
                this.uniqueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool managed
        {
            get
            {
                return this.managedField;
            }
            set
            {
                this.managedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool failed
        {
            get
            {
                return this.failedField;
            }
            set
            {
                this.failedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool failure_ignored
        {
            get
            {
                return this.failure_ignoredField;
            }
            set
            {
                this.failure_ignoredField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monResourcesCloneResource
    {

        private crm_monResourcesCloneResourceNode nodeField;

        private string idField;

        private string resource_agentField;

        private string roleField;

        private bool activeField;

        private bool orphanedField;

        private bool blockedField;

        private bool managedField;

        private bool failedField;

        private bool failure_ignoredField;

        private byte nodes_running_onField;

        /// <remarks/>
        public crm_monResourcesCloneResourceNode node
        {
            get
            {
                return this.nodeField;
            }
            set
            {
                this.nodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resource_agent
        {
            get
            {
                return this.resource_agentField;
            }
            set
            {
                this.resource_agentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool orphaned
        {
            get
            {
                return this.orphanedField;
            }
            set
            {
                this.orphanedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool blocked
        {
            get
            {
                return this.blockedField;
            }
            set
            {
                this.blockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool managed
        {
            get
            {
                return this.managedField;
            }
            set
            {
                this.managedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool failed
        {
            get
            {
                return this.failedField;
            }
            set
            {
                this.failedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool failure_ignored
        {
            get
            {
                return this.failure_ignoredField;
            }
            set
            {
                this.failure_ignoredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte nodes_running_on
        {
            get
            {
                return this.nodes_running_onField;
            }
            set
            {
                this.nodes_running_onField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monResourcesCloneResourceNode
    {

        private string nameField;

        private byte idField;

        private bool cachedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool cached
        {
            get
            {
                return this.cachedField;
            }
            set
            {
                this.cachedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monNode1
    {

        private crm_monNodeAttribute attributeField;

        private string nameField;

        /// <remarks/>
        public crm_monNodeAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monNodeAttribute
    {

        private string nameField;

        private ushort valueField;

        private ushort expectedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort expected
        {
            get
            {
                return this.expectedField;
            }
            set
            {
                this.expectedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monNode2
    {

        private crm_monNodeResource_history[] resource_historyField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resource_history")]
        public crm_monNodeResource_history[] resource_history
        {
            get
            {
                return this.resource_historyField;
            }
            set
            {
                this.resource_historyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monNodeResource_history
    {

        private crm_monNodeResource_historyOperation_history[] operation_historyField;

        private string idField;

        private bool orphanField;

        private uint migrationthresholdField;

        private uint failcountField;

        private bool failcountFieldSpecified;

        private string lastfailureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("operation_history")]
        public crm_monNodeResource_historyOperation_history[] operation_history
        {
            get
            {
                return this.operation_historyField;
            }
            set
            {
                this.operation_historyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool orphan
        {
            get
            {
                return this.orphanField;
            }
            set
            {
                this.orphanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("migration-threshold")]
        public uint migrationthreshold
        {
            get
            {
                return this.migrationthresholdField;
            }
            set
            {
                this.migrationthresholdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("fail-count")]
        public uint failcount
        {
            get
            {
                return this.failcountField;
            }
            set
            {
                this.failcountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool failcountSpecified
        {
            get
            {
                return this.failcountFieldSpecified;
            }
            set
            {
                this.failcountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("last-failure")]
        public string lastfailure
        {
            get
            {
                return this.lastfailureField;
            }
            set
            {
                this.lastfailureField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monNodeResource_historyOperation_history
    {

        private byte callField;

        private string taskField;

        private string lastrcchangeField;

        private string lastrunField;

        private string exectimeField;

        private string queuetimeField;

        private byte rcField;

        private string rc_textField;

        private string intervalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte call
        {
            get
            {
                return this.callField;
            }
            set
            {
                this.callField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string task
        {
            get
            {
                return this.taskField;
            }
            set
            {
                this.taskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("last-rc-change")]
        public string lastrcchange
        {
            get
            {
                return this.lastrcchangeField;
            }
            set
            {
                this.lastrcchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("last-run")]
        public string lastrun
        {
            get
            {
                return this.lastrunField;
            }
            set
            {
                this.lastrunField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("exec-time")]
        public string exectime
        {
            get
            {
                return this.exectimeField;
            }
            set
            {
                this.exectimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("queue-time")]
        public string queuetime
        {
            get
            {
                return this.queuetimeField;
            }
            set
            {
                this.queuetimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rc
        {
            get
            {
                return this.rcField;
            }
            set
            {
                this.rcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rc_text
        {
            get
            {
                return this.rc_textField;
            }
            set
            {
                this.rc_textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string interval
        {
            get
            {
                return this.intervalField;
            }
            set
            {
                this.intervalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class crm_monFailure
    {

        private string op_keyField;

        private string nodeField;

        private string exitstatusField;

        private string exitreasonField;

        private byte exitcodeField;

        private byte callField;

        private string statusField;

        private string lastrcchangeField;

        private byte queuedField;

        private ushort execField;

        private ushort intervalField;

        private string taskField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op_key
        {
            get
            {
                return this.op_keyField;
            }
            set
            {
                this.op_keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string node
        {
            get
            {
                return this.nodeField;
            }
            set
            {
                this.nodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exitstatus
        {
            get
            {
                return this.exitstatusField;
            }
            set
            {
                this.exitstatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exitreason
        {
            get
            {
                return this.exitreasonField;
            }
            set
            {
                this.exitreasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte exitcode
        {
            get
            {
                return this.exitcodeField;
            }
            set
            {
                this.exitcodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte call
        {
            get
            {
                return this.callField;
            }
            set
            {
                this.callField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("last-rc-change")]
        public string lastrcchange
        {
            get
            {
                return this.lastrcchangeField;
            }
            set
            {
                this.lastrcchangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte queued
        {
            get
            {
                return this.queuedField;
            }
            set
            {
                this.queuedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort exec
        {
            get
            {
                return this.execField;
            }
            set
            {
                this.execField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort interval
        {
            get
            {
                return this.intervalField;
            }
            set
            {
                this.intervalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string task
        {
            get
            {
                return this.taskField;
            }
            set
            {
                this.taskField = value;
            }
        }
    }


}
