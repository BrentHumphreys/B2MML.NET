﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ProcessOperationsScheduleTypeDataArea {
    
        private TransProcessType processField;
    
        private OperationsScheduleType[] operationsScheduleField;
    
        /// <remarks/>
        public TransProcessType Process {
            get {
                return this.processField;
            }
            set {
                this.processField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsSchedule")]
        public OperationsScheduleType[] OperationsSchedule {
            get {
                return this.operationsScheduleField;
            }
            set {
                this.operationsScheduleField = value;
            }
        }
    }
}