using DarkSurvival.Scripts.Systems.Utils;
using DarkSurvival.Scripts.UI.Scripts;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    private InputManager _inputManager;
    private UIController _uiController;
    private Updater _updater;

    private InputControls _inputControls;
    
    private void Initialize()
    {
        InitializeInputControls();
        InitializeUIController();
        InitializeInputManager();
        
        InitializeUpdater();
        
        _updater.RegisterUpdatable(_uiController);
    }

    private void InitializeInputControls()
    {
        _inputControls = new InputControls();
        _inputControls.Enable();
    }

    private void InitializeInputManager()
    {
        _inputManager = new InputManager();
        _inputManager.Initialize(_uiController);
    }

    private void InitializeUIController()
    {
        _uiController = new UIController();
        _uiController.Initialize(_inputControls);
    }
    
    private void InitializeUpdater()
    {
        GameObject created = new GameObject("Updater");
        Updater updater = created.AddComponent<Updater>();
        updater.Initialize();
            
        _updater = updater;
    }
}
