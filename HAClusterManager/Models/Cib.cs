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
    public partial class cib
    {

        private cibConfiguration configurationField;

        private cibNode_state[] statusField;

        private string crm_feature_setField;

        private string validatewithField;

        private byte epochField;

        private byte num_updatesField;

        private byte admin_epochField;

        private string ciblastwrittenField;

        private string updateoriginField;

        private string updateclientField;

        private string updateuserField;

        private byte havequorumField;

        private byte dcuuidField;

        /// <remarks/>
        public cibConfiguration configuration
        {
            get
            {
                return this.configurationField;
            }
            set
            {
                this.configurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("node_state", IsNullable = false)]
        public cibNode_state[] status
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string crm_feature_set
        {
            get
            {
                return this.crm_feature_setField;
            }
            set
            {
                this.crm_feature_setField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("validate-with")]
        public string validatewith
        {
            get
            {
                return this.validatewithField;
            }
            set
            {
                this.validatewithField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte epoch
        {
            get
            {
                return this.epochField;
            }
            set
            {
                this.epochField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte num_updates
        {
            get
            {
                return this.num_updatesField;
            }
            set
            {
                this.num_updatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte admin_epoch
        {
            get
            {
                return this.admin_epochField;
            }
            set
            {
                this.admin_epochField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("cib-last-written")]
        public string ciblastwritten
        {
            get
            {
                return this.ciblastwrittenField;
            }
            set
            {
                this.ciblastwrittenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("update-origin")]
        public string updateorigin
        {
            get
            {
                return this.updateoriginField;
            }
            set
            {
                this.updateoriginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("update-client")]
        public string updateclient
        {
            get
            {
                return this.updateclientField;
            }
            set
            {
                this.updateclientField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("update-user")]
        public string updateuser
        {
            get
            {
                return this.updateuserField;
            }
            set
            {
                this.updateuserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("have-quorum")]
        public byte havequorum
        {
            get
            {
                return this.havequorumField;
            }
            set
            {
                this.havequorumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("dc-uuid")]
        public byte dcuuid
        {
            get
            {
                return this.dcuuidField;
            }
            set
            {
                this.dcuuidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibConfiguration
    {

        private cibConfigurationCrm_config crm_configField;

        private cibConfigurationNode[] nodesField;

        private cibConfigurationResources resourcesField;

        private cibConfigurationConstraints constraintsField;

        /// <remarks/>
        public cibConfigurationCrm_config crm_config
        {
            get
            {
                return this.crm_configField;
            }
            set
            {
                this.crm_configField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("node", IsNullable = false)]
        public cibConfigurationNode[] nodes
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
        public cibConfigurationResources resources
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
        public cibConfigurationConstraints constraints
        {
            get
            {
                return this.constraintsField;
            }
            set
            {
                this.constraintsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibConfigurationCrm_config
    {

        private cibConfigurationCrm_configCluster_property_set cluster_property_setField;

        /// <remarks/>
        public cibConfigurationCrm_configCluster_property_set cluster_property_set
        {
            get
            {
                return this.cluster_property_setField;
            }
            set
            {
                this.cluster_property_setField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibConfigurationCrm_configCluster_property_set
    {

        private cibConfigurationCrm_configCluster_property_setNvpair[] nvpairField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nvpair")]
        public cibConfigurationCrm_configCluster_property_setNvpair[] nvpair
        {
            get
            {
                return this.nvpairField;
            }
            set
            {
                this.nvpairField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibConfigurationCrm_configCluster_property_setNvpair
    {

        private string idField;

        private string nameField;

        private string valueField;

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
        public string value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibConfigurationNode
    {

        private byte idField;

        private string unameField;

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
        public string uname
        {
            get
            {
                return this.unameField;
            }
            set
            {
                this.unameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibConfigurationResources
    {

        private cibConfigurationResourcesGroup groupField;

        private cibConfigurationResourcesClone[] cloneField;

        /// <remarks/>
        public cibConfigurationResourcesGroup group
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
        public cibConfigurationResourcesClone[] clone
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
    public partial class cibConfigurationResourcesGroup
    {

        private cibConfigurationResourcesGroupPrimitive[] primitiveField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("primitive")]
        public cibConfigurationResourcesGroupPrimitive[] primitive
        {
            get
            {
                return this.primitiveField;
            }
            set
            {
                this.primitiveField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibConfigurationResourcesGroupPrimitive
    {

        private cibConfigurationResourcesGroupPrimitiveInstance_attributes instance_attributesField;

        private cibConfigurationResourcesGroupPrimitiveOP[] operationsField;

        private string classField;

        private string idField;

        private string providerField;

        private string typeField;

        /// <remarks/>
        public cibConfigurationResourcesGroupPrimitiveInstance_attributes instance_attributes
        {
            get
            {
                return this.instance_attributesField;
            }
            set
            {
                this.instance_attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("op", IsNullable = false)]
        public cibConfigurationResourcesGroupPrimitiveOP[] operations
        {
            get
            {
                return this.operationsField;
            }
            set
            {
                this.operationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
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
        public string provider
        {
            get
            {
                return this.providerField;
            }
            set
            {
                this.providerField = value;
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
    public partial class cibConfigurationResourcesGroupPrimitiveInstance_attributes
    {

        private cibConfigurationResourcesGroupPrimitiveInstance_attributesNvpair[] nvpairField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nvpair")]
        public cibConfigurationResourcesGroupPrimitiveInstance_attributesNvpair[] nvpair
        {
            get
            {
                return this.nvpairField;
            }
            set
            {
                this.nvpairField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibConfigurationResourcesGroupPrimitiveInstance_attributesNvpair
    {

        private string idField;

        private string nameField;

        private string valueField;

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
        public string value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibConfigurationResourcesGroupPrimitiveOP
    {

        private string idField;

        private string intervalField;

        private string nameField;

        private string timeoutField;

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
        public string timeout
        {
            get
            {
                return this.timeoutField;
            }
            set
            {
                this.timeoutField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibConfigurationResourcesClone
    {

        private cibConfigurationResourcesClonePrimitive primitiveField;

        private string idField;

        /// <remarks/>
        public cibConfigurationResourcesClonePrimitive primitive
        {
            get
            {
                return this.primitiveField;
            }
            set
            {
                this.primitiveField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibConfigurationResourcesClonePrimitive
    {

        private cibConfigurationResourcesClonePrimitiveInstance_attributes instance_attributesField;

        private cibConfigurationResourcesClonePrimitiveOP[] operationsField;

        private string classField;

        private string idField;

        private string providerField;

        private string typeField;

        /// <remarks/>
        public cibConfigurationResourcesClonePrimitiveInstance_attributes instance_attributes
        {
            get
            {
                return this.instance_attributesField;
            }
            set
            {
                this.instance_attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("op", IsNullable = false)]
        public cibConfigurationResourcesClonePrimitiveOP[] operations
        {
            get
            {
                return this.operationsField;
            }
            set
            {
                this.operationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
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
        public string provider
        {
            get
            {
                return this.providerField;
            }
            set
            {
                this.providerField = value;
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
    public partial class cibConfigurationResourcesClonePrimitiveInstance_attributes
    {

        private cibConfigurationResourcesClonePrimitiveInstance_attributesNvpair[] nvpairField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nvpair")]
        public cibConfigurationResourcesClonePrimitiveInstance_attributesNvpair[] nvpair
        {
            get
            {
                return this.nvpairField;
            }
            set
            {
                this.nvpairField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibConfigurationResourcesClonePrimitiveInstance_attributesNvpair
    {

        private string idField;

        private string nameField;

        private string valueField;

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
        public string value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibConfigurationResourcesClonePrimitiveOP
    {

        private string idField;

        private string intervalField;

        private string nameField;

        private string timeoutField;

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
        public string timeout
        {
            get
            {
                return this.timeoutField;
            }
            set
            {
                this.timeoutField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibConfigurationConstraints
    {

        private cibConfigurationConstraintsRsc_location rsc_locationField;

        /// <remarks/>
        public cibConfigurationConstraintsRsc_location rsc_location
        {
            get
            {
                return this.rsc_locationField;
            }
            set
            {
                this.rsc_locationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibConfigurationConstraintsRsc_location
    {

        private string idField;

        private string nodeField;

        private string rscField;

        private string scoreField;

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
        public string rsc
        {
            get
            {
                return this.rscField;
            }
            set
            {
                this.rscField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string score
        {
            get
            {
                return this.scoreField;
            }
            set
            {
                this.scoreField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibNode_state
    {

        private cibNode_stateLrm lrmField;

        private cibNode_stateTransient_attributes transient_attributesField;

        private byte idField;

        private string unameField;

        private bool in_ccmField;

        private string crmdField;

        private string crmdebugoriginField;

        private string joinField;

        private string expectedField;

        /// <remarks/>
        public cibNode_stateLrm lrm
        {
            get
            {
                return this.lrmField;
            }
            set
            {
                this.lrmField = value;
            }
        }

        /// <remarks/>
        public cibNode_stateTransient_attributes transient_attributes
        {
            get
            {
                return this.transient_attributesField;
            }
            set
            {
                this.transient_attributesField = value;
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
        public string uname
        {
            get
            {
                return this.unameField;
            }
            set
            {
                this.unameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool in_ccm
        {
            get
            {
                return this.in_ccmField;
            }
            set
            {
                this.in_ccmField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string crmd
        {
            get
            {
                return this.crmdField;
            }
            set
            {
                this.crmdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("crm-debug-origin")]
        public string crmdebugorigin
        {
            get
            {
                return this.crmdebugoriginField;
            }
            set
            {
                this.crmdebugoriginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string join
        {
            get
            {
                return this.joinField;
            }
            set
            {
                this.joinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expected
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
    public partial class cibNode_stateLrm
    {

        private cibNode_stateLrmLrm_resource[] lrm_resourcesField;

        private byte idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("lrm_resource", IsNullable = false)]
        public cibNode_stateLrmLrm_resource[] lrm_resources
        {
            get
            {
                return this.lrm_resourcesField;
            }
            set
            {
                this.lrm_resourcesField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibNode_stateLrmLrm_resource
    {

        private cibNode_stateLrmLrm_resourceLrm_rsc_op[] lrm_rsc_opField;

        private string idField;

        private string typeField;

        private string classField;

        private string providerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lrm_rsc_op")]
        public cibNode_stateLrmLrm_resourceLrm_rsc_op[] lrm_rsc_op
        {
            get
            {
                return this.lrm_rsc_opField;
            }
            set
            {
                this.lrm_rsc_opField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string provider
        {
            get
            {
                return this.providerField;
            }
            set
            {
                this.providerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibNode_stateLrmLrm_resourceLrm_rsc_op
    {

        private string idField;

        private string operation_keyField;

        private string operationField;

        private string crmdebugoriginField;

        private string crm_feature_setField;

        private string transitionkeyField;

        private string transitionmagicField;

        private string exitreasonField;

        private string on_nodeField;

        private byte callidField;

        private byte rccodeField;

        private byte opstatusField;

        private ushort intervalField;

        private uint lastrunField;

        private bool lastrunFieldSpecified;

        private uint lastrcchangeField;

        private ushort exectimeField;

        private byte queuetimeField;

        private string opdigestField;

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
        public string operation_key
        {
            get
            {
                return this.operation_keyField;
            }
            set
            {
                this.operation_keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("crm-debug-origin")]
        public string crmdebugorigin
        {
            get
            {
                return this.crmdebugoriginField;
            }
            set
            {
                this.crmdebugoriginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string crm_feature_set
        {
            get
            {
                return this.crm_feature_setField;
            }
            set
            {
                this.crm_feature_setField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("transition-key")]
        public string transitionkey
        {
            get
            {
                return this.transitionkeyField;
            }
            set
            {
                this.transitionkeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("transition-magic")]
        public string transitionmagic
        {
            get
            {
                return this.transitionmagicField;
            }
            set
            {
                this.transitionmagicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("exit-reason")]
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
        public string on_node
        {
            get
            {
                return this.on_nodeField;
            }
            set
            {
                this.on_nodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("call-id")]
        public byte callid
        {
            get
            {
                return this.callidField;
            }
            set
            {
                this.callidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("rc-code")]
        public byte rccode
        {
            get
            {
                return this.rccodeField;
            }
            set
            {
                this.rccodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("op-status")]
        public byte opstatus
        {
            get
            {
                return this.opstatusField;
            }
            set
            {
                this.opstatusField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute("last-run")]
        public uint lastrun
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastrunSpecified
        {
            get
            {
                return this.lastrunFieldSpecified;
            }
            set
            {
                this.lastrunFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("last-rc-change")]
        public uint lastrcchange
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
        [System.Xml.Serialization.XmlAttributeAttribute("exec-time")]
        public ushort exectime
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
        public byte queuetime
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
        [System.Xml.Serialization.XmlAttributeAttribute("op-digest")]
        public string opdigest
        {
            get
            {
                return this.opdigestField;
            }
            set
            {
                this.opdigestField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibNode_stateTransient_attributes
    {

        private cibNode_stateTransient_attributesInstance_attributes instance_attributesField;

        private byte idField;

        /// <remarks/>
        public cibNode_stateTransient_attributesInstance_attributes instance_attributes
        {
            get
            {
                return this.instance_attributesField;
            }
            set
            {
                this.instance_attributesField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibNode_stateTransient_attributesInstance_attributes
    {

        private cibNode_stateTransient_attributesInstance_attributesNvpair[] nvpairField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nvpair")]
        public cibNode_stateTransient_attributesInstance_attributesNvpair[] nvpair
        {
            get
            {
                return this.nvpairField;
            }
            set
            {
                this.nvpairField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cibNode_stateTransient_attributesInstance_attributesNvpair
    {

        private string idField;

        private string nameField;

        private string valueField;

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
        public string value
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
    }



}
