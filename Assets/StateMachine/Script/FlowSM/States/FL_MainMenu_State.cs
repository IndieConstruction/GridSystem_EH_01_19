namespace StateMachine {
    public class FL_MainMenu_State : BaseState {
        public override void Enter() {
            UnityEngine.Debug.Log("Enter FL_MainMenu_State");
            ctx.UI.EnableMainMenuUI(true);
        }

        public override void Exit() {
            ctx.UI.EnableMainMenuUI(false);
        }
    }
}
