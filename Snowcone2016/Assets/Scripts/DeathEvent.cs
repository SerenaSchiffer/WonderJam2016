using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class DeathEvent : StateMachineBehaviour {

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Teleport");
        //if (animator.gameObject.GetComponent<CheckPointHandler>().getLastCheckPoint() != null)
        //{
        //    animator.gameObject.transform.position = animator.gameObject.GetComponent<CheckPointHandler>().getLastCheckPoint();

        //}
        //Camera.main.GetComponent<CameraZoom>().centerCameraOnCharacter();
        //animator.ResetTrigger("Dying");
        //animator.SetBool("Dead", false);
        SceneManager.LoadScene(NextRoom.roomNumber);
    }

    // OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}
}
