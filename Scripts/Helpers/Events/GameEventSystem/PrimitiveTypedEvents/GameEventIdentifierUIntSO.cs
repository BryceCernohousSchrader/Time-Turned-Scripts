using UnityEngine;
// Original Authors - Wyatt Senalik

namespace Helpers.Events.GameEventSystem.ParameterEvents
{
    [CreateAssetMenu(fileName = "new GameEventIdentifier(uint)",
        menuName = GameEventIdentifierSO.MENU_FOLDER_PATH +
        "/Primitives/uint")]
    public sealed class GameEventIdentifierUIntSO : GameEventIdentifierSO<uint>
    { }
}