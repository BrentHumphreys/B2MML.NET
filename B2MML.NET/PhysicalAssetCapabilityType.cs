﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class PhysicalAssetCapabilityType {
    
        private PhysicalAssetClassIDType physicalAssetClassIDField;
    
        private PhysicalAssetIDType physicalAssetIDField;
    
        private DescriptionType[] descriptionField;
    
        private CapabilityTypeType capabilityTypeField;
    
        private ReasonType reasonField;
    
        private EquipmentElementLevelType[] equipmentElementLevelField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private QuantityValueType[] quantityField;
    
        private PhysicalAssetCapabilityPropertyType[] physicalAssetCapabilityPropertyField;
    
        /// <remarks/>
        public PhysicalAssetClassIDType PhysicalAssetClassID {
            get {
                return this.physicalAssetClassIDField;
            }
            set {
                this.physicalAssetClassIDField = value;
            }
        }
    
        /// <remarks/>
        public PhysicalAssetIDType PhysicalAssetID {
            get {
                return this.physicalAssetIDField;
            }
            set {
                this.physicalAssetIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        public CapabilityTypeType CapabilityType {
            get {
                return this.capabilityTypeField;
            }
            set {
                this.capabilityTypeField = value;
            }
        }
    
        /// <remarks/>
        public ReasonType Reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElementLevel")]
        public EquipmentElementLevelType[] EquipmentElementLevel {
            get {
                return this.equipmentElementLevelField;
            }
            set {
                this.equipmentElementLevelField = value;
            }
        }
    
        /// <remarks/>
        public StartTimeType StartTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
            }
        }
    
        /// <remarks/>
        public EndTimeType EndTime {
            get {
                return this.endTimeField;
            }
            set {
                this.endTimeField = value;
            }
        }
    
        /// <remarks/>
        public LocationType Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get {
                return this.hierarchyScopeField;
            }
            set {
                this.hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapabilityProperty")]
        public PhysicalAssetCapabilityPropertyType[] PhysicalAssetCapabilityProperty {
            get {
                return this.physicalAssetCapabilityPropertyField;
            }
            set {
                this.physicalAssetCapabilityPropertyField = value;
            }
        }
    }
}