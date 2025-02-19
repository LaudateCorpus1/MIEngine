﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.MIDebugEngine {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ResourceStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.MIDebugEngine.ResourceStrings", typeof(ResourceStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module containing this breakpoint has not yet loaded or the breakpoint address could not be obtained..
        /// </summary>
        internal static string BreakpointAtInvalidAddress {
            get {
                return ResourceManager.GetString("BreakpointAtInvalidAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connecting debugger to &apos;{0}&apos;.
        /// </summary>
        internal static string ConnectingMessage {
            get {
                return ResourceManager.GetString("ConnectingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Debugging will now abort..
        /// </summary>
        internal static string DebuggingWillAbort {
            get {
                return ResourceManager.GetString("DebuggingWillAbort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sample Engine.
        /// </summary>
        internal static string EngineName {
            get {
                return ResourceManager.GetString("EngineName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Program path &apos;{0}&apos; is missing or invalid.
        ///
        ///{1} failed with message: {2}
        ///
        ///This may occur if the process&apos;s executable was changed after the process was started, such as when installing an update. Try re-launching the application or restarting the machine..
        /// </summary>
        internal static string Error_ExePathInvalid {
            get {
                return ResourceManager.GetString("Error_ExePathInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get executable path with error &apos;{0}&apos;..
        /// </summary>
        internal static string Error_FailedToGetExePath {
            get {
                return ResourceManager.GetString("Error_FailedToGetExePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to obtain target architecture..
        /// </summary>
        internal static string Error_FailedToGetTargetArchitecture {
            get {
                return ResourceManager.GetString("Error_FailedToGetTargetArchitecture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attaching to process {0} with {1} failed because of insufficient privileges with error message &apos;{2}&apos;.
        ///
        ///To attach to an application on Linux, login as super user or set ptrace_scope to 0.
        ///See https://aka.ms/miengine-gdb-troubleshooting for details..
        /// </summary>
        internal static string Error_PTraceFailure {
            get {
                return ResourceManager.GetString("Error_PTraceFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported platform..
        /// </summary>
        internal static string Error_UnsupportedPlatform {
            get {
                return ResourceManager.GetString("Error_UnsupportedPlatform", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error &quot;{0}&quot; while reading file: {1}.
        /// </summary>
        internal static string ErrorReadingFile {
            get {
                return ResourceManager.GetString("ErrorReadingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while updating exception settings. {0}.
        /// </summary>
        internal static string ExceptionSettingsError {
            get {
                return ResourceManager.GetString("ExceptionSettingsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: {0}.
        /// </summary>
        internal static string Failed_ExecCommandError {
            get {
                return ResourceManager.GetString("Failed_ExecCommandError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File not found: {0}.
        /// </summary>
        internal static string FileNotFound {
            get {
                return ResourceManager.GetString("FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initializing Debugger.
        /// </summary>
        internal static string InitializingDebugger {
            get {
                return ResourceManager.GetString("InitializingDebugger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid assignment .
        /// </summary>
        internal static string InvalidAssignment {
            get {
                return ResourceManager.GetString("InvalidAssignment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading core dump {0}.
        /// </summary>
        internal static string LoadingCoreDumpMessage {
            get {
                return ResourceManager.GetString("LoadingCoreDumpMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading Symbols.
        /// </summary>
        internal static string LoadingSymbolCaption {
            get {
                return ResourceManager.GetString("LoadingSymbolCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading symbols for module {0}.
        /// </summary>
        internal static string LoadingSymbolMessage {
            get {
                return ResourceManager.GetString("LoadingSymbolMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting to bind the breakpoint.....
        /// </summary>
        internal static string LongBind {
            get {
                return ResourceManager.GetString("LongBind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to find thread {0} for break event.
        /// </summary>
        internal static string MissingThreadBreakEvent {
            get {
                return ResourceManager.GetString("MissingThreadBreakEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find or open the symbol file..
        /// </summary>
        internal static string ModuleLoadedWithoutSymbols {
            get {
                return ResourceManager.GetString("ModuleLoadedWithoutSymbols", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Symbols loaded..
        /// </summary>
        internal static string ModuleLoadedWithSymbols {
            get {
                return ResourceManager.GetString("ModuleLoadedWithSymbols", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loaded &apos;{0}&apos;. {1}.
        /// </summary>
        internal static string ModuleLoadMessage {
            get {
                return ResourceManager.GetString("ModuleLoadMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unloaded &apos;{0}&apos;..
        /// </summary>
        internal static string ModuleUnloadMessage {
            get {
                return ResourceManager.GetString("ModuleUnloadMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Explicit refresh required for visualized expressions.
        /// </summary>
        internal static string NoSideEffectsVisualizerMessage {
            get {
                return ResourceManager.GetString("NoSideEffectsVisualizerMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Raw View].
        /// </summary>
        internal static string RawView {
            get {
                return ResourceManager.GetString("RawView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting symbol search path.
        /// </summary>
        internal static string SettingSymbolSearchPath {
            get {
                return ResourceManager.GetString("SettingSymbolSearchPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Symbols loaded - {0}.
        /// </summary>
        internal static string SymbolsLoadedInfo {
            get {
                return ResourceManager.GetString("SymbolsLoadedInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Symbols not loaded.
        /// </summary>
        internal static string SymbolsNotLoadedInfo {
            get {
                return ResourceManager.GetString("SymbolsNotLoadedInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thread has exited.
        /// </summary>
        internal static string ThreadExited {
            get {
                return ResourceManager.GetString("ThreadExited", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Unknown/Just-In-Time compiled code].
        /// </summary>
        internal static string UnknownCode {
            get {
                return ResourceManager.GetString("UnknownCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported Breakpoint Type.
        /// </summary>
        internal static string UnsupportedBreakpoint {
            get {
                return ResourceManager.GetString("UnsupportedBreakpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Conditional breakpoints are not supported..
        /// </summary>
        internal static string UnsupportedConditionalBreakpoint {
            get {
                return ResourceManager.GetString("UnsupportedConditionalBreakpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hit counts on breakpoints are not supported..
        /// </summary>
        internal static string UnsupportedPassCountBreakpoint {
            get {
                return ResourceManager.GetString("UnsupportedPassCountBreakpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Visualized View].
        /// </summary>
        internal static string VisualizedView {
            get {
                return ResourceManager.GetString("VisualizedView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Visualizing Expression.
        /// </summary>
        internal static string VisualizingExpressionCaption {
            get {
                return ResourceManager.GetString("VisualizingExpressionCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Visualizing expression: {0}.
        /// </summary>
        internal static string VisualizingExpressionMessage {
            get {
                return ResourceManager.GetString("VisualizingExpressionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Debugger executable &apos;{0}&apos; is not signed. As a result, debugging may not work properly..
        /// </summary>
        internal static string Warning_DarwinDebuggerUnsigned {
            get {
                return ResourceManager.GetString("Warning_DarwinDebuggerUnsigned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning: Exceptions are not supported in this scenario.
        ///.
        /// </summary>
        internal static string Warning_ExceptionsNotSupported {
            get {
                return ResourceManager.GetString("Warning_ExceptionsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning: Source file &apos;{0}&apos; is newer than module file &apos;{1}&apos;..
        /// </summary>
        internal static string Warning_SourceFileOutOfDate_Arg2 {
            get {
                return ResourceManager.GetString("Warning_SourceFileOutOfDate_Arg2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning: One or more C++ exceptions are unchecked while &apos;&lt;All C++ Exceptions not in this list&gt;&apos; is enabled. This is unsupported for GDB and the debugger will break on all C++ exceptions.
        ///.
        /// </summary>
        internal static string Warning_UncheckedExceptionsInCheckedCategory {
            get {
                return ResourceManager.GetString("Warning_UncheckedExceptionsInCheckedCategory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning: Debuggee TargetArchitecture not detected, assuming x86_64..
        /// </summary>
        internal static string Warning_UsingDefaultArchitecture {
            get {
                return ResourceManager.GetString("Warning_UsingDefaultArchitecture", resourceCulture);
            }
        }
    }
}
