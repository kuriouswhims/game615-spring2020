using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Animator animator;

   

    /* If Raycast is used to shoot, include the following variables:
     * public int damage = 40;
     * public GameObject impactEffect;
     * public LineRenderer lineRenderer; --> need to create line in unity project IF we want to do this
     */

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("IsShooting", true);
            Shoot();
        }

        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("IsShooting", false);
        }
        
    }


    void Shoot()
    {
        //spawn bullet into world
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        /*if we wanted to use raycasting instead, use code below
         * 
         * RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);
         *
         * if (hitInfo)
         * {
         *     Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
         *
         *     if (enemy != null)
         *     {
         *         enemy.TakeDamage(damage);
         *     }
         *
         *     Instantiate(impactEffect, hitInfo.point, Quaternion.identity);
         *
         *     lineRenderer.SetPosition(0, firePoint.position);
         *     lineRenderer.SetPosition(1, hitInfo.point);
         * } else
         *  {
         *      lineRenderer.SetPosition(0, firePoint.position);
         *      lineRenderer.SetPosition(1, firePoint.position + firePoint.right * 100); //taking start position and shifting it 100 units forward
         *  }
         *
         *  lineRenderer.enabled = true;
         *
         *  //wait one frame --> need to change Shoot() into coroutine if we want to do raycasting
         *
         *  lineRenderer.enabled = false;
         */
    }
}
