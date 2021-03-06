﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("PhysicalAsset", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class PhysicalAssetType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private IdentifierType physicalLocationField;
    
        private IdentifierType fixedAssetIDField;
    
        private IdentifierType vendorIDField;
    
        private HierarchyScopeType equipmentLevelField;
    
        private EquipmentAssetMappingType[] equipmentAssetMappingField;
    
        private PhysicalAssetPropertyType[] physicalAssetPropertyField;
    
        private PhysicalAssetType[] physicalAssetField;
    
        private PhysicalAssetClassIDType[] physicalAssetClassIDField;
    
        private PhysicalAssetCapabilityTestSpecificationIDType[] physicalAssetCapabilityTestSpecificationIDField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
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
        public HierarchyScopeType HierarchyScope {
            get {
                return this.hierarchyScopeField;
            }
            set {
                this.hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType PhysicalLocation {
            get {
                return this.physicalLocationField;
            }
            set {
                this.physicalLocationField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType FixedAssetID {
            get {
                return this.fixedAssetIDField;
            }
            set {
                this.fixedAssetIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType VendorID {
            get {
                return this.vendorIDField;
            }
            set {
                this.vendorIDField = value;
            }
        }
    
        /// <remarks/>
        public HierarchyScopeType EquipmentLevel {
            get {
                return this.equipmentLevelField;
            }
            set {
                this.equipmentLevelField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentAssetMapping")]
        public EquipmentAssetMappingType[] EquipmentAssetMapping {
            get {
                return this.equipmentAssetMappingField;
            }
            set {
                this.equipmentAssetMappingField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetProperty")]
        public PhysicalAssetPropertyType[] PhysicalAssetProperty {
            get {
                return this.physicalAssetPropertyField;
            }
            set {
                this.physicalAssetPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAsset")]
        public PhysicalAssetType[] PhysicalAsset {
            get {
                return this.physicalAssetField;
            }
            set {
                this.physicalAssetField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetClassID")]
        public PhysicalAssetClassIDType[] PhysicalAssetClassID {
            get {
                return this.physicalAssetClassIDField;
            }
            set {
                this.physicalAssetClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapabilityTestSpecificationID")]
        public PhysicalAssetCapabilityTestSpecificationIDType[] PhysicalAssetCapabilityTestSpecificationID {
            get {
                return this.physicalAssetCapabilityTestSpecificationIDField;
            }
            set {
                this.physicalAssetCapabilityTestSpecificationIDField = value;
            }
        }
    }
}