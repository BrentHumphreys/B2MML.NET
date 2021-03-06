﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("GRecipe", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class GRecipeType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private GRecipeTypeType gRecipeType1Field;
    
        private LifeCycleStateType lifeCycleStateField;
    
        private GRecipeHeaderType headerField;
    
        private GRecipeFormulaType formulaField;
    
        private ProcessElementType processProcedureField;
    
        private ResourceConstraintType[] resourceConstraintField;
    
        private GROtherInformationType[] otherInformationField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("GRecipeType")]
        public GRecipeTypeType GRecipeType1 {
            get {
                return this.gRecipeType1Field;
            }
            set {
                this.gRecipeType1Field = value;
            }
        }
    
        /// <remarks/>
        public LifeCycleStateType LifeCycleState {
            get {
                return this.lifeCycleStateField;
            }
            set {
                this.lifeCycleStateField = value;
            }
        }
    
        /// <remarks/>
        public GRecipeHeaderType Header {
            get {
                return this.headerField;
            }
            set {
                this.headerField = value;
            }
        }
    
        /// <remarks/>
        public GRecipeFormulaType Formula {
            get {
                return this.formulaField;
            }
            set {
                this.formulaField = value;
            }
        }
    
        /// <remarks/>
        public ProcessElementType ProcessProcedure {
            get {
                return this.processProcedureField;
            }
            set {
                this.processProcedureField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceConstraint")]
        public ResourceConstraintType[] ResourceConstraint {
            get {
                return this.resourceConstraintField;
            }
            set {
                this.resourceConstraintField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherInformation")]
        public GROtherInformationType[] OtherInformation {
            get {
                return this.otherInformationField;
            }
            set {
                this.otherInformationField = value;
            }
        }
    }
}