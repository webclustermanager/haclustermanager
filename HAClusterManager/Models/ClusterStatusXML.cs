using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HAClusterManager.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class crm_mon
    {

        private crm_monSummary summaryField;

        private crm_monNode[] nodesField;

        private object resourcesField;

        private crm_monNode1[] node_attributesField;

        private crm_monNode2[] node_historyField;

        private object ticketsField;

        private object bansField;

        private string versionField;

        /// <remarks/>
        public crm_monSummary summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("node", IsNullable = false)]
        public crm_monNode[] nodes
        {
            get
            {
                return this.nodesField;
            }
            set
            {
                this.nodesField = value;
            }
        }

        /// <remarks/>
        public object resources
        {
            get
            {
                return this.resourcesField;
            }
            set
            {
                this.resourcesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("node", IsNullable = false)]
        public crm_monNode1[] node_attributes
        {
            get
            {
                return this.node_attributesField;
            }
            set
            {
                this.node_attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("node", IsNullable = false)]
        public crm_monNode2[] node_history
        {
            get
            {
                return this.node_historyField;
            }
            set
            {
                this.node_historyField = value;
            }
        }

        /// <remarks/>
        public object tickets
        {
            get
            {
                return this.ticketsField;
            }
            set
            {
                this.ticketsField = value;
            }
        }

        /// <remarks/>
        public object bans
        {
            get
            {
                return this.bansField;
            }
            set
            {
                this.bansField = value;
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
    public partial class crm_monNode1
    {

        private string nameField;

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
    public partial class crm_monNode2
    {

        private string nameField;

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



}
