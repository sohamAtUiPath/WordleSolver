using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace BlankProcess5
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService), typeof(UiPath.Testing.API.ITestingService)};
        }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace BlankProcess5.ObjectRepository
{
    public static class Descriptors
    {
        public static class Wordle
        {
            public static _Implementation._Wordle.__NewScreen NewScreen { get; private set; } = new _Implementation._Wordle.__NewScreen();
        }
    }
}

namespace BlankProcess5._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _Wordle._NewScreen
    {
        public class __Div1 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Div1(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "JZpuQGvWBESHXGXJdv6JRQ/x4j-RGCMb0G2g9YflwsuDA", DisplayName = "Div1", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Wordle
    {
        public class __NewScreen : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __NewScreen()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "JZpuQGvWBESHXGXJdv6JRQ/e4RWR25hWUy0Sl4A8PyGqw", DisplayName = "NewScreen", Screen = this};
                Div1 = new _Implementation._Wordle._NewScreen.__Div1(this, null);
            }

            public _Implementation._Wordle._NewScreen.__Div1 Div1 { get; private set; }
        }
    }
}