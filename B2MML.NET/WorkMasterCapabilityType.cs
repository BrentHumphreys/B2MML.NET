﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class WorkMasterCapabilityType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private IdentifierType[] workMasterIDField;
    
        private CapabilityTypeType capabilityTypeField;
    
        private ReasonType[] reasonField;
    
        private HierarchyScopeType[] hierarchyScopeField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private OpPersonnelCapabilityType[] personnelCapabilityField;
    
        private OpEquipmentCapabilityType[] equipmentCapabilityField;
    
        private OpPhysicalAssetCapabilityType[] physicalAssetCapabilityField;
    
        private OpMaterialCapabilityType[] materialCapabilityField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("WorkMasterID")]
        public IdentifierType[] WorkMasterID {
            get {
                return this.workMasterIDField;
            }
            set {
                this.workMasterIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Reason")]
        public ReasonType[] Reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HierarchyScope")]
        public HierarchyScopeType[] HierarchyScope {
            get {
                return this.hierarchyScopeField;
            }
            set {
                this.hierarchyScopeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("PersonnelCapability")]
        public OpPersonnelCapabilityType[] PersonnelCapability {
            get {
                return this.personnelCapabilityField;
            }
            set {
                this.personnelCapabilityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapability")]
        public OpEquipmentCapabilityType[] EquipmentCapability {
            get {
                return this.equipmentCapabilityField;
            }
            set {
                this.equipmentCapabilityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapability")]
        public OpPhysicalAssetCapabilityType[] PhysicalAssetCapability {
            get {
                return this.physicalAssetCapabilityField;
            }
            set {
                this.physicalAssetCapabilityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialCapability")]
        public OpMaterialCapabilityType[] MaterialCapability {
            get {
                return this.materialCapabilityField;
            }
            set {
                this.materialCapabilityField = value;
            }
        }
    }
}