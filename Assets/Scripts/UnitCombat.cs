using UnityEngine;

public class UnitCombat : MonoBehaviour
{
    public UnitTeam team;

    public float moveSpeed = 2f;
    public float attackRange = 1f;
    public float damage = 10f;
    public float attackCooldown = 1f;

    private UnitHealth targetUnit;
    private float attackTimer;
    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        attackTimer -= Time.deltaTime;

        if (targetUnit == null)
        {
            FindEnemy();
        }

        if (targetUnit == null)
            return;

        Vector2 targetPosition = GetTargetPosition();

        float distance = Vector2.Distance(
            transform.position,
            targetPosition
        );

        if (distance > attackRange)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                targetPosition,
                moveSpeed * Time.deltaTime
            );
        }
        else if (attackTimer <= 0f)
        {
            if (animator != null)
            {
                animator.SetTrigger("Attack");
            }

            targetUnit.TakeDamage(damage);
            attackTimer = attackCooldown;
        }
    }

    Vector2 GetTargetPosition()
    {
        Collider2D targetCollider =
            targetUnit.GetComponent<Collider2D>();

        if (targetCollider != null)
        {
            return targetCollider.ClosestPoint(transform.position);
        }

        return targetUnit.transform.position;
    }

    void FindEnemy()
    {
        UnitHealth[] allTargets =
            FindObjectsByType<UnitHealth>(FindObjectsSortMode.None);

        float closestDistance = Mathf.Infinity;
        targetUnit = null;

        foreach (UnitHealth target in allTargets)
        {
            if (target == null || target.gameObject == gameObject)
                continue;

            UnitCombat targetCombat =
                target.GetComponent<UnitCombat>();

            bool isEnemy;

            if (targetCombat != null)
            {
                isEnemy = targetCombat.team != team;
            }
            else
            {
                isEnemy = IsEnemyCastle(target.gameObject);
            }

            if (!isEnemy)
                continue;

            float distance = Vector2.Distance(
                transform.position,
                target.transform.position
            );

            if (distance < closestDistance)
            {
                closestDistance = distance;
                targetUnit = target;
            }
        }
    }

    bool IsEnemyCastle(GameObject target)
    {
        if (team == UnitTeam.Player)
            return target.name == "EnemyCastle";

        return target.name == "PlayerCastle";
    }
}