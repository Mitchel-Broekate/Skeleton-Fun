//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Inputs/Interactions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Interactions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Interactions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Interactions"",
    ""maps"": [
        {
            ""name"": ""Click"",
            ""id"": ""8b2e0fc5-2942-4e05-b36c-0902992c6a80"",
            ""actions"": [
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""6b05dfb5-bdf8-4bd0-a0f3-b2469d6121c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""20212c57-a270-44db-8132-1f444914ab78"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Click
        m_Click = asset.FindActionMap("Click", throwIfNotFound: true);
        m_Click_LeftClick = m_Click.FindAction("LeftClick", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Click
    private readonly InputActionMap m_Click;
    private List<IClickActions> m_ClickActionsCallbackInterfaces = new List<IClickActions>();
    private readonly InputAction m_Click_LeftClick;
    public struct ClickActions
    {
        private @Interactions m_Wrapper;
        public ClickActions(@Interactions wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftClick => m_Wrapper.m_Click_LeftClick;
        public InputActionMap Get() { return m_Wrapper.m_Click; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ClickActions set) { return set.Get(); }
        public void AddCallbacks(IClickActions instance)
        {
            if (instance == null || m_Wrapper.m_ClickActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ClickActionsCallbackInterfaces.Add(instance);
            @LeftClick.started += instance.OnLeftClick;
            @LeftClick.performed += instance.OnLeftClick;
            @LeftClick.canceled += instance.OnLeftClick;
        }

        private void UnregisterCallbacks(IClickActions instance)
        {
            @LeftClick.started -= instance.OnLeftClick;
            @LeftClick.performed -= instance.OnLeftClick;
            @LeftClick.canceled -= instance.OnLeftClick;
        }

        public void RemoveCallbacks(IClickActions instance)
        {
            if (m_Wrapper.m_ClickActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IClickActions instance)
        {
            foreach (var item in m_Wrapper.m_ClickActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ClickActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ClickActions @Click => new ClickActions(this);
    public interface IClickActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
    }
}
