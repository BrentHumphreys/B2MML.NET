﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OperationsSegmentType {
    
        private IdentifierType idField;
    
        private DescriptionType descriptionField;
    
        private OperationsTypeType operationsTypeField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private string durationField;
    
        private ProcessSegmentIDType[] processSegmentIDField;
    
        private ParameterType[] parameterField;
    
        private OpPersonnelSpecificationType[] personnelSpecificationField;
    
        private OpEquipmentSpecificationType[] equipmentSpecificationField;
    
        private OpPhysicalAssetSpecificationType[] physicalAssetSpecificationField;
    
        private OpMaterialSpecificationType[] materialSpecificationField;
    
        private SegmentDependencyType[] segmentDependencyField;
    
        private OperationsSegmentType[] operationsSegmentField;
    
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
        public DescriptionType Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        public OperationsTypeType OperationsType {
            get {
                return this.operationsTypeField;
            }
            set {
                this.operationsTypeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string Duration {
            get {
                return this.durationField;
            }
            set {
                this.durationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentID")]
        public ProcessSegmentIDType[] ProcessSegmentID {
            get {
                return this.processSegmentIDField;
            }
            set {
                this.processSegmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public ParameterType[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelSpecification")]
        public OpPersonnelSpecificationType[] PersonnelSpecification {
            get {
                return this.personnelSpecificationField;
            }
            set {
                this.personnelSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSpecification")]
        public OpEquipmentSpecificationType[] EquipmentSpecification {
            get {
                return this.equipmentSpecificationField;
            }
            set {
                this.equipmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSpecification")]
        public OpPhysicalAssetSpecificationType[] PhysicalAssetSpecification {
            get {
                return this.physicalAssetSpecificationField;
            }
            set {
                this.physicalAssetSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecification")]
        public OpMaterialSpecificationType[] MaterialSpecification {
            get {
                return this.materialSpecificationField;
            }
            set {
                this.materialSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentDependency")]
        public SegmentDependencyType[] SegmentDependency {
            get {
                return this.segmentDependencyField;
            }
            set {
                this.segmentDependencyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsSegment")]
        public OperationsSegmentType[] OperationsSegment {
            get {
                return this.operationsSegmentField;
            }
            set {
                this.operationsSegmentField = value;
            }
        }
    }
}