//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/InputControler.inputactions
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

public partial class @InputControler: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControler()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControler"",
    ""maps"": [
        {
            ""name"": ""Movimiento"",
            ""id"": ""1e8d7446-a9f6-4f86-b986-32d3f722cfc5"",
            ""actions"": [
                {
                    ""name"": ""Salto"",
                    ""type"": ""Button"",
                    ""id"": ""379f20ee-b66e-4955-acf5-fd132cd4d692"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""agachar"",
                    ""type"": ""Button"",
                    ""id"": ""5f766616-fca2-4180-8b2c-0416d7a23e13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""mover"",
                    ""type"": ""Value"",
                    ""id"": ""7b59b3d9-a005-4ca8-ac6b-5a6e890e8cdb"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""correr"",
                    ""type"": ""Button"",
                    ""id"": ""a5b53930-d7d3-4a2f-99c3-fa1b7f6e4791"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""rodar"",
                    ""type"": ""Button"",
                    ""id"": ""f8b2917f-75e4-49f4-98e2-7d11b8c4fbc5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""57494cf7-53c2-4766-bc29-5d7753fca8bd"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Salto"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b50c779f-17ff-459e-a6a7-047245446021"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""agachar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""811597ce-ac81-4f3f-8e5a-148b9a605f5e"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""178373b7-3cab-4a86-8b35-0ca13d49d877"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""correr"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9684c69a-8b7d-45a0-929c-ab39cfd58475"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rodar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movimiento
        m_Movimiento = asset.FindActionMap("Movimiento", throwIfNotFound: true);
        m_Movimiento_Salto = m_Movimiento.FindAction("Salto", throwIfNotFound: true);
        m_Movimiento_agachar = m_Movimiento.FindAction("agachar", throwIfNotFound: true);
        m_Movimiento_mover = m_Movimiento.FindAction("mover", throwIfNotFound: true);
        m_Movimiento_correr = m_Movimiento.FindAction("correr", throwIfNotFound: true);
        m_Movimiento_rodar = m_Movimiento.FindAction("rodar", throwIfNotFound: true);
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

    // Movimiento
    private readonly InputActionMap m_Movimiento;
    private List<IMovimientoActions> m_MovimientoActionsCallbackInterfaces = new List<IMovimientoActions>();
    private readonly InputAction m_Movimiento_Salto;
    private readonly InputAction m_Movimiento_agachar;
    private readonly InputAction m_Movimiento_mover;
    private readonly InputAction m_Movimiento_correr;
    private readonly InputAction m_Movimiento_rodar;
    public struct MovimientoActions
    {
        private @InputControler m_Wrapper;
        public MovimientoActions(@InputControler wrapper) { m_Wrapper = wrapper; }
        public InputAction @Salto => m_Wrapper.m_Movimiento_Salto;
        public InputAction @agachar => m_Wrapper.m_Movimiento_agachar;
        public InputAction @mover => m_Wrapper.m_Movimiento_mover;
        public InputAction @correr => m_Wrapper.m_Movimiento_correr;
        public InputAction @rodar => m_Wrapper.m_Movimiento_rodar;
        public InputActionMap Get() { return m_Wrapper.m_Movimiento; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovimientoActions set) { return set.Get(); }
        public void AddCallbacks(IMovimientoActions instance)
        {
            if (instance == null || m_Wrapper.m_MovimientoActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovimientoActionsCallbackInterfaces.Add(instance);
            @Salto.started += instance.OnSalto;
            @Salto.performed += instance.OnSalto;
            @Salto.canceled += instance.OnSalto;
            @agachar.started += instance.OnAgachar;
            @agachar.performed += instance.OnAgachar;
            @agachar.canceled += instance.OnAgachar;
            @mover.started += instance.OnMover;
            @mover.performed += instance.OnMover;
            @mover.canceled += instance.OnMover;
            @correr.started += instance.OnCorrer;
            @correr.performed += instance.OnCorrer;
            @correr.canceled += instance.OnCorrer;
            @rodar.started += instance.OnRodar;
            @rodar.performed += instance.OnRodar;
            @rodar.canceled += instance.OnRodar;
        }

        private void UnregisterCallbacks(IMovimientoActions instance)
        {
            @Salto.started -= instance.OnSalto;
            @Salto.performed -= instance.OnSalto;
            @Salto.canceled -= instance.OnSalto;
            @agachar.started -= instance.OnAgachar;
            @agachar.performed -= instance.OnAgachar;
            @agachar.canceled -= instance.OnAgachar;
            @mover.started -= instance.OnMover;
            @mover.performed -= instance.OnMover;
            @mover.canceled -= instance.OnMover;
            @correr.started -= instance.OnCorrer;
            @correr.performed -= instance.OnCorrer;
            @correr.canceled -= instance.OnCorrer;
            @rodar.started -= instance.OnRodar;
            @rodar.performed -= instance.OnRodar;
            @rodar.canceled -= instance.OnRodar;
        }

        public void RemoveCallbacks(IMovimientoActions instance)
        {
            if (m_Wrapper.m_MovimientoActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovimientoActions instance)
        {
            foreach (var item in m_Wrapper.m_MovimientoActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovimientoActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovimientoActions @Movimiento => new MovimientoActions(this);
    public interface IMovimientoActions
    {
        void OnSalto(InputAction.CallbackContext context);
        void OnAgachar(InputAction.CallbackContext context);
        void OnMover(InputAction.CallbackContext context);
        void OnCorrer(InputAction.CallbackContext context);
        void OnRodar(InputAction.CallbackContext context);
    }
}