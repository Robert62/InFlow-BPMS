//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace strICT.InFlow.Workflows {
    
    
    [System.Runtime.InteropServices.ComVisible(false)]
    public partial class TaskTier : System.Activities.Activity, System.ComponentModel.ISupportInitialize {
        
        private bool _contentLoaded;
        
        private System.Activities.InArgument<string> _Type;
        
        private System.Activities.InArgument<string> _WFId;
        
        private System.Activities.InArgument<string> _Name;
        
        private System.Activities.InArgument<bool> _Done;
        
        private System.Activities.InArgument<bool> _IsEndState;
        
        private System.Activities.InArgument<string> _ReadableParameters;
        
        private System.Activities.InArgument<string> _EditableParameters;
        
        private System.Activities.InArgument<string> _TaskProperties;
        
        private System.Activities.InArgument<int> _InternalOrderId;
        
partial void BeforeInitializeComponent(ref bool isInitialized);

partial void AfterInitializeComponent();

        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "4.0.0.0")]
        public TaskTier() {
            this.InitializeComponent();
        }
        
        public System.Activities.InArgument<string> Type {
            get {
                return this._Type;
            }
            set {
                this._Type = value;
            }
        }
        
        public System.Activities.InArgument<string> WFId {
            get {
                return this._WFId;
            }
            set {
                this._WFId = value;
            }
        }
        
        public System.Activities.InArgument<string> Name {
            get {
                return this._Name;
            }
            set {
                this._Name = value;
            }
        }
        
        public System.Activities.InArgument<bool> Done {
            get {
                return this._Done;
            }
            set {
                this._Done = value;
            }
        }
        
        public System.Activities.InArgument<bool> IsEndState {
            get {
                return this._IsEndState;
            }
            set {
                this._IsEndState = value;
            }
        }
        
        public System.Activities.InArgument<string> ReadableParameters {
            get {
                return this._ReadableParameters;
            }
            set {
                this._ReadableParameters = value;
            }
        }
        
        public System.Activities.InArgument<string> EditableParameters {
            get {
                return this._EditableParameters;
            }
            set {
                this._EditableParameters = value;
            }
        }
        
        public System.Activities.InArgument<string> TaskProperties {
            get {
                return this._TaskProperties;
            }
            set {
                this._TaskProperties = value;
            }
        }
        
        public System.Activities.InArgument<int> InternalOrderId {
            get {
                return this._InternalOrderId;
            }
            set {
                this._InternalOrderId = value;
            }
        }
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "4.0.0.0")]
        public void InitializeComponent() {
            if ((this._contentLoaded == true)) {
                return;
            }
            this._contentLoaded = true;
            bool isInitialized = false;
            this.BeforeInitializeComponent(ref isInitialized);
            if ((isInitialized == true)) {
                this.AfterInitializeComponent();
                return;
            }
            string resourceName = this.FindResource();
            System.IO.Stream initializeXaml = typeof(TaskTier).Assembly.GetManifestResourceStream(resourceName);
            System.Xml.XmlReader xmlReader = null;
            System.Xaml.XamlReader reader = null;
            System.Xaml.XamlObjectWriter objectWriter = null;
            try {
                System.Xaml.XamlSchemaContext schemaContext = XamlStaticHelperNamespace._XamlStaticHelper.SchemaContext;
                xmlReader = System.Xml.XmlReader.Create(initializeXaml);
                System.Xaml.XamlXmlReaderSettings readerSettings = new System.Xaml.XamlXmlReaderSettings();
                readerSettings.LocalAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                readerSettings.AllowProtectedMembersOnRoot = true;
                reader = new System.Xaml.XamlXmlReader(xmlReader, schemaContext, readerSettings);
                System.Xaml.XamlObjectWriterSettings writerSettings = new System.Xaml.XamlObjectWriterSettings();
                writerSettings.RootObjectInstance = this;
                writerSettings.AccessLevel = System.Xaml.Permissions.XamlAccessLevel.PrivateAccessTo(typeof(TaskTier));
                objectWriter = new System.Xaml.XamlObjectWriter(schemaContext, writerSettings);
                System.Xaml.XamlServices.Transform(reader, objectWriter);
            }
            finally {
                if ((xmlReader != null)) {
                    ((System.IDisposable)(xmlReader)).Dispose();
                }
                if ((reader != null)) {
                    ((System.IDisposable)(reader)).Dispose();
                }
                if ((objectWriter != null)) {
                    ((System.IDisposable)(objectWriter)).Dispose();
                }
            }
            this.AfterInitializeComponent();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "4.0.0.0")]
        private string FindResource() {
            string[] resources = typeof(TaskTier).Assembly.GetManifestResourceNames();
            for (int i = 0; (i < resources.Length); i = (i + 1)) {
                string resource = resources[i];
                if ((resource.Contains(".TaskTier.g.xaml") || resource.Equals("TaskTier.g.xaml"))) {
                    return resource;
                }
            }
            throw new System.InvalidOperationException("Resource not found.");
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "4.0.0.0")]
        void System.ComponentModel.ISupportInitialize.BeginInit() {
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "4.0.0.0")]
        void System.ComponentModel.ISupportInitialize.EndInit() {
            this.InitializeComponent();
        }
    }
}
