using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private static readonly string IS_WALKING = "isWalking";
    private Animator _animator;

    [SerializeField] private Player player;
    
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
